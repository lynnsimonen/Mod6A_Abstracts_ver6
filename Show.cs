using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod6A_Abstracts_ver6
{
    public class Show : MediaType
    {
        new public int iD {get; set;}
        new public string title {get; set;}
        public int season {get; set;}
        public int episode {get; set;}
        public List<int> writers {get; set;}

        public Show()
        {
            writers = new List<int>();      
        }

        public override string DisplayType ()
        {
            return String.Format("ID: {0,2}  Title: {1,-30}  \nSeason: {2,-20} Episode: {3,10} Writers: {4,-25}", 
                iD, title, season, episode, writers);            
        }
    }
}