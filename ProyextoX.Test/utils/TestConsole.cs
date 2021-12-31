using System;
using System.IO;
using McMaster.Extensions.CommandLineUtils;

namespace ProyextoX.Test.Utils
{
    class TestConsole : IConsole
    {
        private readonly MemoryStream outStream;

        public TestConsole()
        {
            this.outStream = new MemoryStream();
            this.Out = new StreamWriter(this.outStream);
        }
        public TextWriter Out
        {
            get;
            private set;
        }

        public string GetWrittendContent()
        {
            this.Out.Flush();
            this.outStream.Flush();
            this.outStream.Seek(0, SeekOrigin.Begin);
            StreamReader reader = new StreamReader(this.outStream);
            return reader.ReadToEnd();
        }
        public TextWriter Error => throw new NotImplementedException();

        public TextReader In => throw new NotImplementedException();

        public bool IsInputRedirected => throw new NotImplementedException();

        public bool IsOutputRedirected => throw new NotImplementedException();

        public bool IsErrorRedirected => throw new NotImplementedException();

        public ConsoleColor ForegroundColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ConsoleColor BackgroundColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event ConsoleCancelEventHandler CancelKeyPress;

        public void ResetColor()
        {
            throw new NotImplementedException();
        }
    }
}