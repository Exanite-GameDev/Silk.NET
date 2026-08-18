using System.Linq;
using System.Threading.Tasks;
using Exanite.Core.Io;
using Exanite.Core.Utilities;
using Exanite.Engine.BuildSystem.Utilities;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.Rename;

namespace Exanite.Silk2.Cli.Targets;

public class RenameNamespacesTarget
{
    private const string SolutionName = "Silk.NET.slnx";

    public async Task Run()
    {
        MSBuildLocator.RegisterDefaults();

        GuardUtility.IsTrue(AbsolutePath.WorkingDirectory.TryFindFileUpwards(SolutionName, out var solutionPath), $"Failed to find solution: {SolutionName}");

        $"Found solution: {solutionPath}".Dump();

        using var workspace = MSBuildWorkspace.Create();
        var solution = await workspace.OpenSolutionAsync(solutionPath);
        var originalSolution = solution;

        $"Opened solution with {solution.ProjectIds.Count} projects".Dump();

        var coreProject = solution.Projects.First(x => x.Name == "Silk.NET.Core");
        var compilation = GuardUtility.NotNull(await coreProject.GetCompilationAsync());
        var silkNamespaceSymbol = compilation.GlobalNamespace.GetNamespaceMembers().First(x => x.Name == "Silk");

        "Renaming Silk namespace to Silk2, this might take a while".Dump();

        solution = await Renamer.RenameSymbolAsync(solution, silkNamespaceSymbol, new SymbolRenameOptions()
        {
            RenameFile = false,
            RenameInComments = false,
            RenameInStrings = false,
            RenameOverloads = true,
        }, "Silk2");

        "Applying changes to disk".Dump();

        await RoslynUtility.ApplyChanges(originalSolution, solution);

        "Symbol rename completed".Dump();

        "Updating string references to Silk.NET in SilkTouch (naively)".Dump();

        var silkTouchProject = solution.Projects.First(x => x.Name == "Silk.NET.SilkTouch");
        var silkTouchProjectPath = new AbsolutePath(GuardUtility.NotNull(silkTouchProject.FilePath)).Parent;
        foreach (var file in silkTouchProjectPath.GlobFiles("**/*.cs"))
        {
            $"Rewriting {file}".Dump();

            var contents = file.ReadAllText();
            var newContents = contents.Replace("\"Silk.NET", "\"Silk2.NET");

            if (contents != newContents)
            {
                file.WriteAllText(newContents);
            }
        }

        "Naive SilkTouch rename completed".Dump();
        "Target completed".Dump();
    }
}
