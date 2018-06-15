using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFilmiAPI
{
    public class Film
    {
        public string imdb_id { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string synopsis { get; set; }
        public string runtime { get; set; }
        public string trailer { get; set; }
        public string poster { get; set; }
        public byte percentage { get; set; }
    }
}
