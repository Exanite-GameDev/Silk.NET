using System.Linq;
using System.Threading.Tasks;
using Exanite.Core.Io;
using Exanite.Core.Utilities;
using Exanite.Engine.BuildSystem.Utilities;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.Rename;
using Serilog;

namespace Exanite.Silk2.Cli.Targets;

public class RenameNamespacesTarget
{
    private readonly ILogger logger;

    public RenameNamespacesTarget(ILogger logger)
    {
        this.logger = logger;
    }

    private const string SolutionName = "Silk.NET.slnx";

    public async Task Run()
    {
        MSBuildLocator.RegisterDefaults();

        GuardUtility.IsTrue(AbsolutePath.WorkingDirectory.TryFindFileUpwards(SolutionName, out var solutionFilePath), $"Failed to find solution: {SolutionName}");

        logger.Information("Found solution: {FilePath}", solutionFilePath);

        using var workspace = MSBuildWorkspace.Create();
        var solution = await workspace.OpenSolutionAsync(solutionFilePath);
        var originalSolution = solution;

        logger.Information("Opened solution with {ProjectCount} projects", solution.ProjectIds.Count);

        var coreProject = solution.Projects.First(x => x.Name == "Silk.NET.Core");
        var compilation = GuardUtility.NotNull(await coreProject.GetCompilationAsync());
        var silkNamespaceSymbol = compilation.GlobalNamespace.GetNamespaceMembers().First(x => x.Name == "Silk");

        logger.Information("Renaming Silk namespace to Silk2, this might take a while");

        solution = await Renamer.RenameSymbolAsync(solution, silkNamespaceSymbol, new SymbolRenameOptions()
        {
            RenameFile = false,
            RenameInComments = false,
            RenameInStrings = false,
            RenameOverloads = true,
        }, "Silk2");

        logger.Information("Applying changes to disk");

        await RoslynUtility.ApplyChanges(originalSolution, solution);

        logger.Information("Symbol rename completed");

        logger.Information("Updating remaining string references to Silk.NET (naively)");

        var coreProjectsRootPath = solutionFilePath.Parent / "src" / "Core";
        foreach (var file in coreProjectsRootPath.GlobFiles("**/*.cs"))
        {
            logger.Debug("Rewriting {File}", file);

            var contents = file.ReadAllText();
            var newContents = contents.Replace("\"Silk.NET", "\"Silk2.NET");

            if (contents != newContents)
            {
                file.WriteAllText(newContents);
            }
        }

        logger.Information("Naive rename completed");
        logger.Information("Target completed");
    }
}
