namespace menu
{
    partial class Form3
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button1 = new Button();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(26, 73);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 34);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "一般會員";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(184, 74);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(156, 34);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "20元折價券";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(205, 176);
            button1.Name = "button1";
            button1.Size = new Size(253, 100);
            button1.TabIndex = 2;
            button1.Text = "完成";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox3.Location = new Point(184, 104);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(156, 34);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "40元折價券";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox4.Location = new Point(184, 137);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(170, 34);
            checkBox4.TabIndex = 4;
            checkBox4.Text = "100元折價券";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox5.Location = new Point(26, 104);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(128, 34);
            checkBox5.TabIndex = 5;
            checkBox5.Text = "鑽石會員";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox6.Location = new Point(26, 137);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(128, 34);
            checkBox6.TabIndex = 6;
            checkBox6.Text = "黃金會員";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox7.Location = new Point(26, 43);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(104, 34);
            checkBox7.TabIndex = 7;
            checkBox7.Text = "非會員";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 311);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(button1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
    }
}