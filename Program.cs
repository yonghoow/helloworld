// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

namespace helloworld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string pathtoFile = @"testnote.txt";

            Process.Start(@"notepad.exe", pathtoFile);

            
        }
    }
}

