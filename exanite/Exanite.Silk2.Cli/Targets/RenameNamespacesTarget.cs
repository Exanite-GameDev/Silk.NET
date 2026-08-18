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

        GuardUtility.IsTrue(AbsolutePath.WorkingDirectory.TryFindFileUpwards(SolutionName, out var solutionPath), $"Failed to find solution: {SolutionName}");

        logger.Information("Found solution: {SolutionPath}", solutionPath);

        using var workspace = MSBuildWorkspace.Create();
        var solution = await workspace.OpenSolutionAsync(solutionPath);
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

        logger.Information("Updating string references to Silk.NET in SilkTouch (naively)");

        var silkTouchProject = solution.Projects.First(x => x.Name == "Silk.NET.SilkTouch");
        var silkTouchProjectPath = new AbsolutePath(GuardUtility.NotNull(silkTouchProject.FilePath)).Parent;
        foreach (var file in silkTouchProjectPath.GlobFiles("**/*.cs"))
        {
            logger.Debug("Rewriting {File}", file);

            var contents = file.ReadAllText();
            var newContents = contents.Replace("\"Silk.NET", "\"Silk2.NET");

            if (contents != newContents)
            {
                file.WriteAllText(newContents);
            }
        }

        logger.Information("Naive SilkTouch rename completed");
        logger.Information("Target completed");
    }
}
