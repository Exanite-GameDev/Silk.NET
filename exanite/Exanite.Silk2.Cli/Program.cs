using System.Threading.Tasks;
using Exanite.Silk2.Cli.Targets;

namespace Exanite.Silk2.Cli;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        await new RenameNamespacesTarget().Run();

        return 0;
    }
}
