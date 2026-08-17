using System.Threading.Tasks;
using Exanite.Silk2.Targets;

namespace Exanite.Silk2;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        await new RenameNamespacesTarget().Run();

        return 0;
    }
}
