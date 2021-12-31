using McMaster.Extensions.CommandLineUtils;
using ProyectoX.Commands;
using Microsoft.Extensions.DependencyInjection;
namespace ProyectoX
{
    [Command("lockdown")]
    [VersionOptionFromMember("--version", MemberName = nameof(LockdownVersion))]
    [Subcommand(typeof(BuildCommand))]
    public class Program
    {
        public string LockdownVersion { get; } = "0.0.0";

        public static int Main(string[] args)
        {
            var services = new ServiceCollection()
                .AddSingleton<IConsole>(PhysicalConsole.Singleton)
                .BuildServiceProvider();
            var app = new CommandLineApplication<Program>();
            app.Conventions.UseDefaultConventions().UseConstructorInjection(services);
            return app.Execute(args);
        }

        public int OnExecute(CommandLineApplication app)
        {
            app.ShowHelp();
            return 0;
        }
    }
}
