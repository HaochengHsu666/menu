namespace menu
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Old English Text MT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 28);
            label1.TabIndex = 0;
            label1.Text = "點選內用外帶，進行點餐";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Old English Text MT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(40, 40);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(479, 577);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Old English Text MT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(210, 623);
            button1.Name = "button1";
            button1.Size = new Size(145, 82);
            button1.TabIndex = 2;
            button1.Text = "清除";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Old English Text MT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(379, 623);
            button2.Name = "button2";
            button2.Size = new Size(140, 82);
            button2.TabIndex = 3;
            button2.Text = "結束";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.下載1;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(541, 348);
            button3.Name = "button3";
            button3.Size = new Size(310, 269);
            button3.TabIndex = 4;
            button3.Text = "外帶";
            button3.TextAlign = ContentAlignment.BottomRight;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.images;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Font = new Font("Microsoft JhengHei UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(541, 40);
            button4.Name = "button4";
            button4.Size = new Size(310, 302);
            button4.TabIndex = 5;
            button4.Text = "內用";
            button4.TextAlign = ContentAlignment.BottomRight;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1417, 737);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "外帶";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}