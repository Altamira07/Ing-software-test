using System;
using Xunit;
using ProyectoX.Commands;
using ProyextoX.Test.Utils;

namespace ProyextoX.Test
{
    public class BuildCommandTest
    {
        [Fact]
        public void TestWriteToConsole()
        {
            var testConsole = new TestConsole();
            var buildCommand = new BuildCommand(testConsole);

            buildCommand.OnExecute();
            var writtenText = testConsole.GetWrittendContent().Trim();

            Assert.Equal("You are used the command build", writtenText);

        }
    }
}
