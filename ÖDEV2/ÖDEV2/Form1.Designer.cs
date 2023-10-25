namespace ÖDEV2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            adTxt = new TextBox();
            mesaiTxt = new TextBox();
            yasTxt = new TextBox();
            adresTxt = new TextBox();
            button1 = new Button();
            Merhaba = new ListBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 47);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 90);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 1;
            label2.Text = "Adres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 219);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 2;
            label3.Text = "Ünvan:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 168);
            label4.Name = "label4";
            label4.Size = new Size(41, 25);
            label4.TabIndex = 3;
            label4.Text = "Yaş:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 290);
            label5.Name = "label5";
            label5.Size = new Size(62, 25);
            label5.TabIndex = 4;
            label5.Text = "Mesai:";
            // 
            // adTxt
            // 
            adTxt.Location = new Point(155, 47);
            adTxt.Multiline = true;
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(182, 31);
            adTxt.TabIndex = 5;
            // 
            // mesaiTxt
            // 
            mesaiTxt.Location = new Point(155, 284);
            mesaiTxt.Name = "mesaiTxt";
            mesaiTxt.Size = new Size(182, 31);
            mesaiTxt.TabIndex = 6;
            // 
            // yasTxt
            // 
            yasTxt.Location = new Point(155, 165);
            yasTxt.Multiline = true;
            yasTxt.Name = "yasTxt";
            yasTxt.Size = new Size(182, 31);
            yasTxt.TabIndex = 8;
            // 
            // adresTxt
            // 
            adresTxt.Location = new Point(155, 90);
            adresTxt.Multiline = true;
            adresTxt.Name = "adresTxt";
            adresTxt.Size = new Size(182, 69);
            adresTxt.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(164, 352);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 10;
            button1.Text = "Gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Merhaba
            // 
            Merhaba.FormattingEnabled = true;
            Merhaba.ItemHeight = 25;
            Merhaba.Location = new Point(450, 61);
            Merhaba.Name = "Merhaba";
            Merhaba.Size = new Size(257, 204);
            Merhaba.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(155, 219);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(Merhaba);
            Controls.Add(button1);
            Controls.Add(adresTxt);
            Controls.Add(yasTxt);
            Controls.Add(mesaiTxt);
            Controls.Add(adTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox adTxt;
        private TextBox mesaiTxt;
        private TextBox yasTxt;
        private TextBox adresTxt;
        private Button button1;
        private ListBox Merhaba;
        private ComboBox comboBox1;
    }
}