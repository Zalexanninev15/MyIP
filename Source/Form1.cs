using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace WindowsFormsApplication2
{
    public partial class Form1 : MaterialForm
    {
        [Obsolete]
        Form f;

        [Obsolete]
        public Form1()
        {
            InitializeComponent();
            // Дефолтная тема
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red700, Primary.Red100, Accent.Blue200, TextShade.WHITE);
            // 1 - под заголовком, 2 - заголовок, 3 - ?, 4 - элементы выбора
        }

        [Obsolete]

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.B_w = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(228, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Имя компьютера в сети (host) ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(43, 170);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(155, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Ваш IP (в интернете)";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(246, 80);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(193, 23);
            this.materialSingleLineTextField1.TabIndex = 2;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(244, 170);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(195, 23);
            this.materialSingleLineTextField2.TabIndex = 3;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            this.materialSingleLineTextField2.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(246, 210);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(198, 33);
            this.materialRaisedButton1.TabIndex = 4;
            this.materialRaisedButton1.Text = "ОБНОВИТЬ";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(445, 80);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(118, 24);
            this.materialRaisedButton2.TabIndex = 5;
            this.materialRaisedButton2.Text = "скопировать";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.MaterialRaisedButton2_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(445, 170);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(118, 24);
            this.materialRaisedButton3.TabIndex = 6;
            this.materialRaisedButton3.Text = "скопировать";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.MaterialRaisedButton3_Click);
            // 
            // B_w
            // 
            this.B_w.Depth = 0;
            this.B_w.Font = new System.Drawing.Font("Roboto", 10F);
            this.B_w.Location = new System.Drawing.Point(452, 213);
            this.B_w.Margin = new System.Windows.Forms.Padding(0);
            this.B_w.MouseLocation = new System.Drawing.Point(-1, -1);
            this.B_w.MouseState = MaterialSkin.MouseState.HOVER;
            this.B_w.Name = "B_w";
            this.B_w.Ripple = true;
            this.B_w.Size = new System.Drawing.Size(133, 30);
            this.B_w.TabIndex = 7;
            this.B_w.Text = "ТЁМНАЯ ТЕМА";
            this.B_w.UseVisualStyleBackColor = true;
            this.B_w.CheckedChanged += new System.EventHandler(this.B_w_CheckedChanged_1);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(445, 124);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(118, 24);
            this.materialRaisedButton4.TabIndex = 11;
            this.materialRaisedButton4.Text = "скопировать";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(246, 124);
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(193, 23);
            this.materialSingleLineTextField3.TabIndex = 10;
            this.materialSingleLineTextField3.TabStop = false;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(30, 124);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(193, 19);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Ваш IP (в домашней сети)";
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Location = new System.Drawing.Point(56, 210);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(128, 33);
            this.materialRaisedButton5.TabIndex = 12;
            this.materialRaisedButton5.Text = "о приложении";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.materialRaisedButton5_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(587, 261);
            this.Controls.Add(this.materialRaisedButton5);
            this.Controls.Add(this.materialRaisedButton4);
            this.Controls.Add(this.materialSingleLineTextField3);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.B_w);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мой IP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        [Obsolete]
        private void Form1_Load(object sender, EventArgs e)
        {
            string Host = System.Net.Dns.GetHostName();
            WebClient client = new WebClient();
            string IP = client.DownloadString("http://api.ipify.org");
            materialSingleLineTextField1.Text = Host;
            materialSingleLineTextField2.Text = IP;
            materialSingleLineTextField3.Text = Dns.GetHostByName(Host).AddressList[0].ToString();
        }

        [Obsolete]
        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            string Host = System.Net.Dns.GetHostName();
            WebClient client = new WebClient();
            string IP = client.DownloadString("http://api.ipify.org");
            materialSingleLineTextField1.Text = Host;
            materialSingleLineTextField2.Text = IP;
            materialSingleLineTextField3.Text = Dns.GetHostByName(Host).AddressList[0].ToString();
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
            }
            if (!B_w.Checked)
            {
                //Выключение тёмной темы (галочка) (включение дефолтной темы)
                B_w.Text = "ТЁМНАЯ ТЕМА";
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Red500, Primary.Red700, Primary.Red100, Accent.Blue200, TextShade.WHITE);
            }
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(materialSingleLineTextField3.Text);
        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            f = new qr_code.Form2();
            f.Show();
        }
    }
}
