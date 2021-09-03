using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        public void goster()
        {
            string[] jsonVerileri, koronaVerileri;
            using(WebClient client = new WebClient())
            {
                var json = client.DownloadString("https://raw.githubusercontent.com/ozanerturk/covid19-turkey-api/master/dataset/timeline.json");
                jsonVerileri = json.ToString().Split('{');
            }

            koronaVerileri = jsonVerileri[jsonVerileri.Length - 1].Split('"');

            tarih.Text = koronaVerileri[3] + " 📅";
            test.Text = koronaVerileri[31] + " 🥺";
            vaka.Text = koronaVerileri[35] + " 😢";
            iyilesen.Text = koronaVerileri[55] + " 🥳";
            vefat.Text = koronaVerileri[51] + " 😭";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread islem = new Thread(() => goster());
            islem.Start();
        }
    }
}
