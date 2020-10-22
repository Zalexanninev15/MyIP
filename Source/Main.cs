using System;
using System.Windows.Forms;
using System.Net;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication2
{
    public partial class Form1 : MaterialForm
    {
   [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);
        [DllImport("user32", CharSet = CharSet.Auto)]
#pragma warning disable CS0108
        internal extern static bool ReleaseCapture();
#pragma warning restore CS0108
        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private bool m_aeroEnabled;
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
        }

        Form f;
        string theme, host, ip;
        int form2 = 0; 
        
        public Form1()
        {
            InitializeComponent();
            // Дефолтная тема
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            theme = IP_Now.Properties.Settings.Default.DarkMode;
            if ((theme == "") || (theme == " ") || (theme == "0"))
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Blue200, TextShade.WHITE);
                // 1 - под заголовком, 2 - заголовок, 3 - ?, 4 - элементы выбора
            }
            if (theme == "1")
            {
                B_w.Checked = true;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Yellow200, TextShade.WHITE);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                host = Dns.GetHostName();
                WebClient client = new WebClient();
                ip = client.DownloadString("http://api.ipify.org");
                materialSingleLineTextField1.Text = host;
                materialSingleLineTextField2.Text = ip;
                materialSingleLineTextField3.Text = Dns.GetHostByName(host).AddressList[0].ToString();
                materialLabel5.Text = GeoInfo(ip);
                ip = null;

            }
            catch
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
            }
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                host = Dns.GetHostName();
                WebClient client = new WebClient();
                ip = client.DownloadString("http://api.ipify.org");
                materialSingleLineTextField1.Text = host;
                materialSingleLineTextField2.Text = ip;
                materialSingleLineTextField3.Text = Dns.GetHostByName(host).AddressList[0].ToString();
                materialLabel5.Text = GeoInfo(ip);
                ip = null;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                ip = null;
            }
            catch
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
            }
        }

        private void MaterialRaisedButton3_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(materialSingleLineTextField2.Text);
        }

        private void MaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(materialSingleLineTextField1.Text);
        }

        private void B_w_CheckedChanged_1(object sender, EventArgs e)
        {
            if (B_w.Checked)
            {
                B_w.Text = "ТЁМНАЯ ТЕМА";
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Yellow200, TextShade.WHITE);
                IP_Now.Properties.Settings.Default.DarkMode = "1";
                IP_Now.Properties.Settings.Default.Save();
            }
            if (!B_w.Checked)
            {
                B_w.Text = "ТЁМНАЯ ТЕМА";
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Blue200, TextShade.WHITE);
                IP_Now.Properties.Settings.Default.DarkMode = "0";
                IP_Now.Properties.Settings.Default.Save();
            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(materialSingleLineTextField3.Text);
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
        foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "Form2")
                {
                    form2 = 1;
                }
                else { form2 = 0; }
            }
            if (form2 == 0)
            {
                f = new qr_code.Form2();
                f.Show();
            }
        }

        public static string GeoInfo(string IP)
        {
            try
            {
                string url = "http://free.ipwhois.io/json/" + IP + "?lang=ru";
                var request = WebRequest.Create(url);
                using (WebResponse wrs = request.GetResponse())
                using (Stream stream = wrs.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    string json = reader.ReadToEnd();
                    var obj = JObject.Parse(json);
                    string ip = (string)obj["ip"];
                    string type = (string)obj["type"];
                    string continent = (string)obj["continent"];
                    string country = (string)obj["country"];
                    string region = (string)obj["region"];
                    string city = (string)obj["city"];
                    string country_code = (string)obj["country_code"];
                    string country_capital = (string)obj["country_capital"];
                    string timezone = (string)obj["timezone"];
                    string timezone_gmt = (string)obj["timezone_gmt"];
                    string currency = (string)obj["currency"];
                    string currency_code = (string)obj["currency_code"];
                    string currency_symbol = (string)obj["currency_symbol"];
                    string currency_rates = (string)obj["currency_rates"];
                    string latitude = (string)obj["latitude"];
                    string longitude = (string)obj["longitude"];
                    string isp = (string)obj["isp"];
                    return ("IP: " + ip + "\nТип IP адреса: " + type + "\nКонтинент: " + continent + "\nСтрана: " + country + "\nКод страны: " + country_code + "\nСтолица страны: " + country_capital + "\nРегион/область: " + region + "\nГород: " + city + "\nШирота: " + latitude + "\nДолгота: " + longitude + "\nИнтернет-провайдер: " + isp + "\nЧасовой пояс: " + timezone + "\nВремя по Гринвичу: " + timezone_gmt + "\nВалюта: " + currency + "\nКод валюты: " + currency_code + "\nОбозначение валюты: " + currency_symbol + "\nКурс валюты: " + currency_rates);
                }
            }
            catch { return "Сервис не отвечает :( \nПовторите попытку позже."; }
        }
    }
}
