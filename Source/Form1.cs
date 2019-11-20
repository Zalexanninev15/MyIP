using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace qr_code
{
    public partial class Form1 : MaterialForm
    {
        Form f;
        String Out;
        public Form1()
        {
            InitializeComponent();
            // Дефолтная тема
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green100, Accent.Green200, TextShade.WHITE);
            // 1 - под заголовком, 2 - заголовок, 3 - ?, 4 - элементы выбора
        }

        private void B_w_CheckedChanged(object sender, EventArgs e)
        {
            if (b_w.Checked)
            {
                //Включение тёмной темы (галочка)
                b_w.Text = "ТЁМНАЯ ТЕМА";
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue100, Accent.Yellow200, TextShade.WHITE);
            }
            if (!b_w.Checked)
            {
                //Выключение тёмной темы (галочка) (включение дефолтной темы)
                b_w.Text = "ТЁМНАЯ ТЕМА";
                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Green500, Primary.Green700, Primary.Green100, Accent.Green200, TextShade.WHITE);
            }
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            f = new Form2();
            f.Show();
        }

        private void MaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            string qrtext = textBox1.Text; //считываем текст из TextBox'a
            QRCodeEncoder encoder = new QRCodeEncoder(); //создаём новую "генерацию кода"
            Bitmap qrcode = encoder.Encode(qrtext); // кодируем слово, полученное из TextBox'a (qrtext) в переменную qrcode. класса Bitmap(класс, который используется для работы с изображениями)
            pictureBox1.Image = qrcode as Image; // pictureBox выводит qrcode как изображение.
        }

        private void MaterialRaisedButton3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog(); // save будет запрашивать у пользователя место, в которое он захочет сохранить файл. 
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp"; //создаём фильтр, который определяет, в каких форматах мы сможем сохранить нашу информацию. В данном случае выбираем форматы изображений. Записывается так: "название_формата_в обозревателе|*.расширение_формата")
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK) //если пользователь нажимает в обозревателе кнопку "Сохранить".
            {
                pictureBox1.Image.Save(save.FileName); //изображение из pictureBox'a сохраняется под именем, которое введёт пользователь
            }
        }

        private void MaterialRaisedButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog(); //  load будет запрашивать у пользователя место, из которого он хочет загрузить файл.
            if (load.ShowDialog() == System.Windows.Forms.DialogResult.OK) // //если пользователь нажимает в обозревателе кнопку "Открыть".
            {
                pictureBox1.ImageLocation = load.FileName; // в pictureBox'e открывается файл, который был по пути, запрошенном пользователем.
            }
        }

        private void MaterialRaisedButton5_Click(object sender, EventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder(); // создаём "раскодирование изображения"
            Out = decoder.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap)); //в MessageBox'e программа запишет раскодированное сообщение с изображения, которое предоврительно будет переведено из pictureBox'a в класс Bitmap, чтобы мы смогли с этим изображением работать.         
                                                                                      //MessageBox.Show(decoder.Decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap))); ; //в MessageBox'e программа запишет раскодированное сообщение с изображения, которое предоврительно будет переведено из pictureBox'a в класс Bitmap, чтобы мы смогли с этим изображением работать. 
            textBox2.Text = Out;
        }

        private void MaterialRaisedButton6_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(textBox2.Text);
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
        }
    }
}
