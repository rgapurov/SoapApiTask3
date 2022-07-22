using System.Xml.Linq;

namespace SoapApiTask3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string apiKey = "5ef9ab480d733ebc67740da680f7cdd8";

            //ankara
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=" + "ankara&mode=xml&lang=tr&units=metric&appid=" + apiKey;
            XDocument weather = XDocument.Load(connection);
            
            var hava = weather.Descendants("clouds").ElementAt(0).Attribute("name");
            var sicak = weather.Descendants("temperature").ElementAt(0).Attribute("value");
            var ruzgar = weather.Descendants("speed").ElementAt(0).Attribute("value");

            lblA1.Text = Convert.ToString(hava.Value);
            lblA2.Text = Convert.ToString(sicak.Value) + " Derece";
            lbla3.Text = Convert.ToString(ruzgar.Value) + " km/s";

            //istanbul
            connection = "https://api.openweathermap.org/data/2.5/weather?q=" + "istanbul&mode=xml&lang=tr&units=metric&appid=" + apiKey;
            weather = XDocument.Load(connection);

            hava = weather.Descendants("clouds").ElementAt(0).Attribute("name");
            sicak = weather.Descendants("temperature").ElementAt(0).Attribute("value");
            ruzgar = weather.Descendants("speed").ElementAt(0).Attribute("value");

            lblIs1.Text = Convert.ToString(hava.Value);
            lblIs2.Text = Convert.ToString(sicak.Value) + " Derece";
            lblIs3.Text = Convert.ToString(ruzgar.Value) + " km/s";

            //istanbul
            connection = "https://api.openweathermap.org/data/2.5/weather?q=" + "izmir&mode=xml&lang=tr&units=metric&appid=" + apiKey;
            weather = XDocument.Load(connection);

            hava = weather.Descendants("clouds").ElementAt(0).Attribute("name");
            sicak = weather.Descendants("temperature").ElementAt(0).Attribute("value");
            ruzgar = weather.Descendants("speed").ElementAt(0).Attribute("value");

            lblIz1.Text = Convert.ToString(hava.Value);
            lblIz2.Text = Convert.ToString(sicak.Value) + " derece";
            lblIz3.Text = Convert.ToString(ruzgar.Value) + " km/s";


        }
    }
}