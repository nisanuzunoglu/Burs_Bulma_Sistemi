namespace projeburs
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(199, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 317);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(379, 27);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(379, 27);
            textBox1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(6, 111);
            label7.Name = "label7";
            label7.Size = new Size(52, 19);
            label7.TabIndex = 13;
            label7.Text = "Şifre :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(6, 42);
            label6.Name = "label6";
            label6.Size = new Size(59, 19);
            label6.TabIndex = 12;
            label6.Text = "TC No:";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(150, 224);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Kayıt ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Seçiniz:", "Öğrenci", "Kurum" });
            comboBox1.Location = new Point(6, 190);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(300, 19);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 1;
            label1.Text = "Kayıt olma ekranı";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
    }
}