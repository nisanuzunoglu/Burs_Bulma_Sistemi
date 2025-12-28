namespace projeburs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(307, 20);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 0;
            label1.Text = "HOŞGELDİNİZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(22, 23);
            label2.Name = "label2";
            label2.Size = new Size(404, 22);
            label2.TabIndex = 1;
            label2.Text = "Hangi kullanıcı olarak devam edeceğinizi seçiniz:";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ControlLightLight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Seçiniz", "Öğrenci", "Kurum" });
            comboBox1.Location = new Point(22, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.MintCream;
            button1.Font = new Font("Times New Roman", 11F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(70, 271);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Giriş yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(254, 271);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Kayıt ol";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 338);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(175, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 342);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(379, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(379, 27);
            textBox1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(22, 160);
            label7.Name = "label7";
            label7.Size = new Size(48, 19);
            label7.TabIndex = 9;
            label7.Text = "Şifre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(22, 91);
            label6.Name = "label6";
            label6.Size = new Size(59, 19);
            label6.TabIndex = 8;
            label6.Text = "TC No:";
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(665, 391);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "ÇIKIŞ YAP";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            ForeColor = Color.DimGray;
            Name = "Form1";
            Text = "BURS BULMA SİSTEMİ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Button button3;
    }
}
