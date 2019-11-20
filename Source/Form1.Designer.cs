namespace qr_code
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.b_w = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton7 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::qr_code.Properties.Resources.qrcreator_103328;
            this.pictureBox1.Location = new System.Drawing.Point(207, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(11, 214);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(106, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Текст для QR:";
            // 
            // b_w
            // 
            this.b_w.Depth = 0;
            this.b_w.Font = new System.Drawing.Font("Roboto", 10F);
            this.b_w.Location = new System.Drawing.Point(207, 292);
            this.b_w.Margin = new System.Windows.Forms.Padding(0);
            this.b_w.MouseLocation = new System.Drawing.Point(-1, -1);
            this.b_w.MouseState = MaterialSkin.MouseState.HOVER;
            this.b_w.Name = "b_w";
            this.b_w.Ripple = true;
            this.b_w.Size = new System.Drawing.Size(144, 27);
            this.b_w.TabIndex = 14;
            this.b_w.Text = "ТЁМНАЯ ТЕМА";
            this.b_w.UseVisualStyleBackColor = true;
            this.b_w.CheckedChanged += new System.EventHandler(this.B_w_CheckedChanged);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(207, 409);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(144, 36);
            this.materialRaisedButton1.TabIndex = 15;
            this.materialRaisedButton1.Text = "о приложении";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Depth = 0;
            this.textBox1.Hint = "";
            this.textBox1.Location = new System.Drawing.Point(131, 213);
            this.textBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.Size = new System.Drawing.Size(284, 23);
            this.textBox1.TabIndex = 16;
            this.textBox1.TabStop = false;
            this.textBox1.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(131, 242);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(135, 36);
            this.materialRaisedButton2.TabIndex = 17;
            this.materialRaisedButton2.Text = "Создать";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.MaterialRaisedButton2_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(272, 242);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(135, 36);
            this.materialRaisedButton3.TabIndex = 18;
            this.materialRaisedButton3.Text = "сохранить";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.MaterialRaisedButton3_Click);
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(132, 357);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(134, 36);
            this.materialRaisedButton4.TabIndex = 19;
            this.materialRaisedButton4.Text = "загрузить";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Click += new System.EventHandler(this.MaterialRaisedButton4_Click);
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Location = new System.Drawing.Point(272, 357);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(135, 36);
            this.materialRaisedButton5.TabIndex = 20;
            this.materialRaisedButton5.Text = "РАСШИФРОВАТЬ";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.MaterialRaisedButton5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Depth = 0;
            this.textBox2.Hint = "";
            this.textBox2.Location = new System.Drawing.Point(131, 327);
            this.textBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '\0';
            this.textBox2.SelectedText = "";
            this.textBox2.SelectionLength = 0;
            this.textBox2.SelectionStart = 0;
            this.textBox2.Size = new System.Drawing.Size(284, 23);
            this.textBox2.TabIndex = 22;
            this.textBox2.TabStop = false;
            this.textBox2.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(11, 327);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(112, 19);
            this.materialLabel2.TabIndex = 21;
            this.materialLabel2.Text = "Расшифровка:";
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.Location = new System.Drawing.Point(421, 322);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(113, 31);
            this.materialRaisedButton6.TabIndex = 23;
            this.materialRaisedButton6.Text = "скопировать";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            this.materialRaisedButton6.Click += new System.EventHandler(this.MaterialRaisedButton6_Click);
            // 
            // materialRaisedButton7
            // 
            this.materialRaisedButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton7.Depth = 0;
            this.materialRaisedButton7.Location = new System.Drawing.Point(421, 209);
            this.materialRaisedButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton7.Name = "materialRaisedButton7";
            this.materialRaisedButton7.Primary = true;
            this.materialRaisedButton7.Size = new System.Drawing.Size(113, 31);
            this.materialRaisedButton7.TabIndex = 24;
            this.materialRaisedButton7.Text = "вставить";
            this.materialRaisedButton7.UseVisualStyleBackColor = true;
            this.materialRaisedButton7.Click += new System.EventHandler(this.materialRaisedButton7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 461);
            this.Controls.Add(this.materialRaisedButton7);
            this.Controls.Add(this.materialRaisedButton6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialRaisedButton5);
            this.Controls.Add(this.materialRaisedButton4);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.b_w);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конструктор QR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox b_w;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton7;
    }
}

