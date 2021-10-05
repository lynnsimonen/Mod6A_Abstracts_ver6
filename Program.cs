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

            var logData = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            logData.Info("Program started");
            string libraryOption = "";
             do
            {
                Console.WriteLine("");
                Console.WriteLine("WELCOME TO THE MOVIE LIBRARY.  HOW CAN WE HELP YOU?");
                Console.WriteLine("ADD a movie");
                Console.WriteLine("LIST all movies");
                Console.WriteLine("QUIT program");
                

                try
                {
                    libraryOption = Console.ReadLine().ToUpper();
                    //logData.Info("Data: {0}", libraryOption);
                }
                catch (System.Exception e)
                {
                    //TODO LOGGING HERE!
                    Console.WriteLine(e.Message);
                    //logData.Info(e.Message);
                    //logData.Info(e.StackTrace);
                }





           

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

                System.Console.WriteLine(media);  //TEST
                
                
                string movieFile = $"{Environment.CurrentDirectory}/data/{media}";
                StreamReader sr = new StreamReader(movieFile);
                System.Console.WriteLine(movieFile);  //TEST
                //MovieManager movieManager = new MovieManager();
                //MovieListUtility movieListUtility = new MovieListUtility();
                //Movie movie = new Movie();
            } while (!(libraryOption.ToUpper() == "QUIT"));
        }
    }
}
