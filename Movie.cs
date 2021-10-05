using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod6A_Abstracts_ver6
{
    public class Movie : MediaType
    {
       new public int iD {get; set;}
        new public string title {get; set;}
        public List<string> genres {get; set;}

        public Movie()
        {
            genres = new List<string>();      
        }

        public override string DisplayType ()
        {
            return String.Format("ID: {0,7}  Title: {1,-50}  Genres: {2,-50}", 
                iD, title, genres);  
        }   
    }
}