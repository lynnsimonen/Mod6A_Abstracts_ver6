using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod6A_Abstracts_ver6
{
    public class Video : MediaType
    {
        new public int iD {get; set;}
        new public string title {get; set;}
        public string format {get; set;}
        public int length {get; set;}
        public List<int> regions {get; set;}

        public Video()
        {
            regions = new List<int>();      
        }

        public override string DisplayType ()
        {
            return String.Format("ID: {0,2}  Title: {1,-30}  \nFormat: {2,-20} Length: {3,10} Regions: {4,-25}", 
                iD, title, format, length, regions);            
        }
    }
}