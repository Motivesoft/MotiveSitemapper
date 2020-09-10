using System;

namespace MotiveSitemapper
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( "Hello, World!" );

            if ( args.Length < 1 )
            {
                Console.Error.WriteLine( "" );
            }
        }
    }
}
