using System;
using System.Windows.Forms;
using System.Net;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using System.Linq;
using System.Linq.Expressions;

namespace WindowsFormsApplication2
{
    public partial class Form1 : MaterialForm
    {
        Form f;
        string theme, host, ip;

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
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
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
                //Включение тёмной темы (галочка)
                B_w.Text = "ТЁМНАЯ ТЕМА";
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Yellow200, TextShade.WHITE);
                IP_Now.Properties.Settings.Default.DarkMode = "1";
                IP_Now.Properties.Settings.Default.Save();
            }
            if (!B_w.Checked)
            {
                //Выключение тёмной темы (галочка) (включение дефолтной темы)
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
            f = new qr_code.Form2();
            f.Show();
        }
    }
}
