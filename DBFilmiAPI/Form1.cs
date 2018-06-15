using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace DBFilmiAPI
{
    public partial class PridobiPodatke : Form
    {
        public PridobiPodatke()
        {
            InitializeComponent();
        }

        //string povezavaString = "datasource=127.0.0.1;port=3306;username=root;password=;database=popcornfilmi;";

        private void PridobiPodatkeButton_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                /*
                byte[] arr = client.DownloadData("https://tv-v2.api-fetch.website/movie/tt1431045");

                foreach(byte b in arr)
                {
                    MessageBox.Show(b.ToString());
                }
                */

                /*
                Stream st = client.OpenRead("https://tv-v2.api-fetch.website/movie/tt1431045");

                StreamReader reader = new StreamReader(st);
                string s = reader.ReadToEnd();
                */
                //string naslov = Encoding.ASCII.GetString(arr);
                //MessageBox.Show(naslov);


                //Film[] filmi = new Film[10];
                List<Film> list = new List<Film>();

                using (WebClient webC = new WebClient())
                {
                    string s = webC.DownloadString("https://tv-v2.api-fetch.website/movies/1");
                    list.Add(JsonConvert.DeserializeObject<Film>(s));
                }


                //Film f = JsonConvert.DeserializeObject<Film>(s2);

                //MessageBox.Show(f.ToString());

            }
        }

    }
}
