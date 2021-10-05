using System;
using System.IO;
using System.Collections.Generic;
using NLog.Web;

namespace Mod6A_Abstracts_ver6
{
    class Program
    {
        static void Main(string[] args)
        {

            // public static System.Globalization.CultureInfo InvariantCulture { get; }
            
            // using (var streamReader = new StreamReader(@"D:\2021_Fall_dotNet\Git_Repos\Mod4A6AMovieApp\Data.movies.csv")) 
            //     {
            //         using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
            //         {
            //             var records = csvReader.GetRecords<dynamic>().ToList;
            //         }
            //     }
            // var logData = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            // logData.Info("Program started");

            string mediaChoice = "";
            string media = ""; 
            try
            {
                Console.WriteLine("");
                Console.Write("Which media type would you like listed? SHOW, VIDEO or MOVIE:   ");
                mediaChoice = Console.ReadLine().ToUpper();  
                Console.WriteLine("");  
            }
            catch (System.Exception)
            {
                //if mediaChoice doesn't equal show, video or movie, exception brings to beginning (or while loop?)
                throw;
            }
                       
            media = (mediaChoice == "SHOW") ? "shows.csv" : (media = (mediaChoice == "VIDEO") ? "videos.csv" : "movies.csv");
            
            string movieFile = $"{Environment.CurrentDirectory}/data/{media}";
            StreamReader sr = new StreamReader(movieFile);
            //MovieManager movieManager = new MovieManager();
            //MovieListUtility movieListUtility = new MovieListUtility();

            //Movie movie = new Movie();
        }
    }
}
