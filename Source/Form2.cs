using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace qr_code
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();

            // Дефолтная тема
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://zalexanninev15.github.io/MyIP/");
        }
    }
}
