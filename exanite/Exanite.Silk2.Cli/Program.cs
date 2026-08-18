using System.Threading.Tasks;
using Autofac;
using Exanite.Logging;
using Exanite.Silk2.Cli.Targets;
using Serilog;

namespace Exanite.Silk2.Cli;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        var builder = new ContainerBuilder();
        builder.RegisterModule(new LoggingModule(new LoggingModuleSettings()));

        var container = builder.Build();
        var logger = container.Resolve<ILogger>();

        await new RenameNamespacesTarget(logger.ForContext<RenameNamespacesTarget>()).Run();

        return 0;
    }
}
