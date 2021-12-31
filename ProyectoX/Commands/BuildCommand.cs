namespace ProyectoX.Commands
{
    using System;
    using McMaster.Extensions.CommandLineUtils;
    public class BuildCommand
    {
        public int OnExecute()
        {
            Console.WriteLine("You exceute the build command");
            return 0;
        }
    }
}