namespace cs_lab2
{
    partial class Form5
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
            this.textBoxnum = new System.Windows.Forms.TextBox();
            this.textBoxmodel = new System.Windows.Forms.TextBox();
            this.textBoxowner = new System.Windows.Forms.TextBox();
            this.label_res = new System.Windows.Forms.Label();
            this.label_err = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заполните поля структуры";
            // 
            // textBoxnum
            // 
            this.textBoxnum.Location = new System.Drawing.Point(56, 119);
            this.textBoxnum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxnum.Name = "textBoxnum";
            this.textBoxnum.Size = new System.Drawing.Size(170, 34);
            this.textBoxnum.TabIndex = 1;
            this.textBoxnum.Text = "Номер";
            this.textBoxnum.TextChanged += new System.EventHandler(this.textBoxnum_TextChanged);
            // 
            // textBoxmodel
            // 
            this.textBoxmodel.Location = new System.Drawing.Point(56, 181);
            this.textBoxmodel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxmodel.Name = "textBoxmodel";
            this.textBoxmodel.Size = new System.Drawing.Size(170, 34);
            this.textBoxmodel.TabIndex = 2;
            this.textBoxmodel.Text = "Модель";
            this.textBoxmodel.TextChanged += new System.EventHandler(this.textBoxmodel_TextChanged);
            // 
            // textBoxowner
            // 
            this.textBoxowner.Location = new System.Drawing.Point(56, 249);
            this.textBoxowner.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxowner.Name = "textBoxowner";
            this.textBoxowner.Size = new System.Drawing.Size(170, 34);
            this.textBoxowner.TabIndex = 3;
            this.textBoxowner.Text = "Владелец";
            this.textBoxowner.TextChanged += new System.EventHandler(this.textBoxowner_TextChanged);
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.Location = new System.Drawing.Point(662, 119);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(65, 28);
            this.label_res.TabIndex = 4;
            this.label_res.Text = "label2";
            // 
            // label_err
            // 
            this.label_err.AutoSize = true;
            this.label_err.Location = new System.Drawing.Point(342, 119);
            this.label_err.Name = "label_err";
            this.label_err.Size = new System.Drawing.Size(65, 28);
            this.label_err.TabIndex = 5;
            this.label_err.Text = "label2";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.label_err);
            this.Controls.Add(this.label_res);
            this.Controls.Add(this.textBoxowner);
            this.Controls.Add(this.textBoxmodel);
            this.Controls.Add(this.textBoxnum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxnum;
        private TextBox textBoxmodel;
        private TextBox textBoxowner;
        private Label label_res;
        private Label label_err;
    }
}