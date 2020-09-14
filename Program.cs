using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading;

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
                Console.Error.WriteLine( "Insufficient command line arguments" );
                ShowHelp();
            }
            else
            {
                Console.WriteLine( "Starting" );
                var task = ScrapeAsync( args[ 0 ] );
                task.Wait();
                Console.WriteLine( "Stopping" );
            }
        }

        private static async System.Threading.Tasks.Task ScrapeAsync( string siteUrl )
        {
            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage request = await httpClient.GetAsync( siteUrl );
            cancellationToken.Token.ThrowIfCancellationRequested();

            Stream response = await request.Content.ReadAsStreamAsync();
            cancellationToken.Token.ThrowIfCancellationRequested();

            HtmlParser parser = new HtmlParser();
            IHtmlDocument document = parser.ParseDocument( response );

            //Add connection between initial scrape, and parsing of results
            Console.WriteLine( document.Title );
            var refs = document.All.Where( x => x.NodeName.Equals( "A" ) );
            foreach ( var r in refs )
            {
                try
                {
                    Console.WriteLine( $"HREF: {r.Attributes[ "href" ].Value}" );
                }
                catch ( Exception ex )
                {
                    Console.WriteLine( $"{ex.Message} caused by: {r.OuterHtml}" );
                }
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
