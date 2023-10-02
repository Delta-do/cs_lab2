namespace cs_lab2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxz1 = new System.Windows.Forms.TextBox();
            this.textBoxz2 = new System.Windows.Forms.TextBox();
            this.textBoxz3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_err = new System.Windows.Forms.Label();
            this.label_res = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(306, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите три числа";
            // 
            // textBoxz1
            // 
            this.textBoxz1.Location = new System.Drawing.Point(225, 128);
            this.textBoxz1.Name = "textBoxz1";
            this.textBoxz1.Size = new System.Drawing.Size(57, 27);
            this.textBoxz1.TabIndex = 1;
            this.textBoxz1.TextChanged += new System.EventHandler(this.textBoxz1_TextChanged);
            // 
            // textBoxz2
            // 
            this.textBoxz2.Location = new System.Drawing.Point(365, 128);
            this.textBoxz2.Name = "textBoxz2";
            this.textBoxz2.Size = new System.Drawing.Size(57, 27);
            this.textBoxz2.TabIndex = 2;
            this.textBoxz2.TextChanged += new System.EventHandler(this.textBoxz2_TextChanged);
            // 
            // textBoxz3
            // 
            this.textBoxz3.Location = new System.Drawing.Point(507, 128);
            this.textBoxz3.Name = "textBoxz3";
            this.textBoxz3.Size = new System.Drawing.Size(57, 27);
            this.textBoxz3.TabIndex = 3;
            this.textBoxz3.TextChanged += new System.EventHandler(this.textBoxz3_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(306, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 73);
            this.button1.TabIndex = 4;
            this.button1.Text = "Вывести результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_err
            // 
            this.label_err.AutoSize = true;
            this.label_err.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_err.Location = new System.Drawing.Point(278, 298);
            this.label_err.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_err.Name = "label_err";
            this.label_err.Size = new System.Drawing.Size(239, 56);
            this.label_err.TabIndex = 15;
            this.label_err.Text = "Некорректное значение.\r\nВведите другое.";
            this.label_err.Visible = false;
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_res.Location = new System.Drawing.Point(357, 313);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(65, 28);
            this.label_res.TabIndex = 16;
            this.label_res.Text = "label2";
            this.label_res.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(265, 376);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Следующее задание >";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_res);
            this.Controls.Add(this.label_err);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxz3);
            this.Controls.Add(this.textBoxz2);
            this.Controls.Add(this.textBoxz1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxz1;
        private TextBox textBoxz2;
        private TextBox textBoxz3;
        private Button button1;
        private Label label_err;
        private Label label_res;
        private Button button2;
    }
}