using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mod6A_Abstracts_ver6
{
    public abstract class MediaType
    {
        public int iD {get; set;}
        public string title {get; set;}

        public string Display () {
            return String.Format("ID: {0,7}  Title: {1,-50}", 
                iD, title);
        }
    
        public abstract string DisplayType();
    }
}