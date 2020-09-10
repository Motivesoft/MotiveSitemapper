using System;
using System.Reflection;

namespace MotiveSitemapper
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( "Hello, World!" );

            ShowHeader();

            if ( args.Length < 1 )
            {
                ShowHelp();
            }
        }

        // Try and get some sort of version from Git and maybe use it in prebuild step?
        // Or see if there is some sort of auto-increment anyway
        // Then just try and implement some sort of crawler

        static void ShowHeader()
        {
            Console.WriteLine( $"{Assembly.GetEntryAssembly().GetName().Name} {Assembly.GetEntryAssembly().GetName().Version}" );
        }

        static void ShowHelp()
        {
            Console.WriteLine( "Usage:" );
        }
    }
}
