namespace cs_lab2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxx1 = new System.Windows.Forms.TextBox();
            this.textBoxy1 = new System.Windows.Forms.TextBox();
            this.textBoxy2 = new System.Windows.Forms.TextBox();
            this.textBoxx2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxy3 = new System.Windows.Forms.TextBox();
            this.textBoxx3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_err = new System.Windows.Forms.Label();
            this.label_res = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(671, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите координаты вершин треугольника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(283, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "x1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(388, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "y1";
            // 
            // textBoxx1
            // 
            this.textBoxx1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxx1.Location = new System.Drawing.Point(259, 155);
            this.textBoxx1.Name = "textBoxx1";
            this.textBoxx1.Size = new System.Drawing.Size(97, 45);
            this.textBoxx1.TabIndex = 3;
            this.textBoxx1.TextChanged += new System.EventHandler(this.textBoxx1_TextChanged);
            // 
            // textBoxy1
            // 
            this.textBoxy1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxy1.Location = new System.Drawing.Point(362, 155);
            this.textBoxy1.Name = "textBoxy1";
            this.textBoxy1.Size = new System.Drawing.Size(97, 45);
            this.textBoxy1.TabIndex = 4;
            this.textBoxy1.TextChanged += new System.EventHandler(this.textBoxy1_TextChanged);
            // 
            // textBoxy2
            // 
            this.textBoxy2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxy2.Location = new System.Drawing.Point(171, 296);
            this.textBoxy2.Name = "textBoxy2";
            this.textBoxy2.Size = new System.Drawing.Size(97, 45);
            this.textBoxy2.TabIndex = 8;
            this.textBoxy2.TextChanged += new System.EventHandler(this.textBoxy2_TextChanged);
            // 
            // textBoxx2
            // 
            this.textBoxx2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxx2.Location = new System.Drawing.Point(68, 296);
            this.textBoxx2.Name = "textBoxx2";
            this.textBoxx2.Size = new System.Drawing.Size(97, 45);
            this.textBoxx2.TabIndex = 7;
            this.textBoxx2.TextChanged += new System.EventHandler(this.textBoxx2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(197, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "y2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(92, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "x2";
            // 
            // textBoxy3
            // 
            this.textBoxy3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxy3.Location = new System.Drawing.Point(568, 296);
            this.textBoxy3.Name = "textBoxy3";
            this.textBoxy3.Size = new System.Drawing.Size(97, 45);
            this.textBoxy3.TabIndex = 12;
            this.textBoxy3.TextChanged += new System.EventHandler(this.textBoxy3_TextChanged);
            // 
            // textBoxx3
            // 
            this.textBoxx3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxx3.Location = new System.Drawing.Point(465, 296);
            this.textBoxx3.Name = "textBoxx3";
            this.textBoxx3.Size = new System.Drawing.Size(97, 45);
            this.textBoxx3.TabIndex = 11;
            this.textBoxx3.TextChanged += new System.EventHandler(this.textBoxx3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(594, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "y3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(489, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 38);
            this.label7.TabIndex = 9;
            this.label7.Text = "x3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(197, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(371, 77);
            this.button1.TabIndex = 13;
            this.button1.Text = "Получить результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_err
            // 
            this.label_err.AutoSize = true;
            this.label_err.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_err.Location = new System.Drawing.Point(211, 504);
            this.label_err.Name = "label_err";
            this.label_err.Size = new System.Drawing.Size(335, 76);
            this.label_err.TabIndex = 14;
            this.label_err.Text = "Некорректное значение.\r\nВведите другое.";
            this.label_err.Visible = false;
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_res.Location = new System.Drawing.Point(217, 511);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(254, 76);
            this.label_res.TabIndex = 15;
            this.label_res.Text = "P = 34.3245213243\r\nS = 4.24293847294";
            this.label_res.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(190, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(378, 54);
            this.button2.TabIndex = 16;
            this.button2.Text = "Следующее задание >";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 742);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_res);
            this.Controls.Add(this.label_err);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxy3);
            this.Controls.Add(this.textBoxx3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxy2);
            this.Controls.Add(this.textBoxx2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxy1);
            this.Controls.Add(this.textBoxx1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxx1;
        private TextBox textBoxy1;
        private TextBox textBoxy2;
        private TextBox textBoxx2;
        private Label label4;
        private Label label5;
        private TextBox textBoxy3;
        private TextBox textBoxx3;
        private Label label6;
        private Label label7;
        private Button button1;
        private Label label_err;
        private Label label_res;
        private Button button2;
    }
}