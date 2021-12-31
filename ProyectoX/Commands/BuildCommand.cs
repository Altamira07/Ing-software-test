namespace ProyectoX.Commands
{
    using McMaster.Extensions.CommandLineUtils;
    public class BuildCommand
    {
        private readonly IConsole console;
        public BuildCommand(IConsole console)
        {
            this.console = console;
        }
        public int OnExecute()
        {
            this.console.WriteLine("You are used the command build");
            return 0;
        }
    }
}