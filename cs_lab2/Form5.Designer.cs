﻿namespace cs_lab2
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
            this.label_err = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заполните поля структуры";
            // 
            // textBoxnum
            // 
            this.textBoxnum.Location = new System.Drawing.Point(56, 119);
            this.textBoxnum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxnum.Name = "textBoxnum";
            this.textBoxnum.Size = new System.Drawing.Size(170, 45);
            this.textBoxnum.TabIndex = 1;
            this.textBoxnum.Text = "Номер";
            this.textBoxnum.TextChanged += new System.EventHandler(this.textBoxnum_TextChanged);
            // 
            // textBoxmodel
            // 
            this.textBoxmodel.Location = new System.Drawing.Point(56, 181);
            this.textBoxmodel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxmodel.Name = "textBoxmodel";
            this.textBoxmodel.Size = new System.Drawing.Size(170, 45);
            this.textBoxmodel.TabIndex = 2;
            this.textBoxmodel.Text = "Модель";
            this.textBoxmodel.TextChanged += new System.EventHandler(this.textBoxmodel_TextChanged);
            // 
            // textBoxowner
            // 
            this.textBoxowner.Location = new System.Drawing.Point(56, 249);
            this.textBoxowner.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxowner.Name = "textBoxowner";
            this.textBoxowner.Size = new System.Drawing.Size(170, 45);
            this.textBoxowner.TabIndex = 3;
            this.textBoxowner.Text = "Владелец";
            this.textBoxowner.TextChanged += new System.EventHandler(this.textBoxowner_TextChanged);
            // 
            // label_err
            // 
            this.label_err.AutoSize = true;
            this.label_err.Location = new System.Drawing.Point(233, 107);
            this.label_err.Name = "label_err";
            this.label_err.Size = new System.Drawing.Size(335, 76);
            this.label_err.TabIndex = 5;
            this.label_err.Text = "Некорректное значение.\nВведите другое.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 83);
            this.button1.TabIndex = 6;
            this.button1.Text = "Вывести результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Готовая структура";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(187, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(378, 54);
            this.button2.TabIndex = 10;
            this.button2.Text = "Возврат к 1 заданию >";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_err);
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
        private Label label_err;
        private Button button1;
        private Label label2;
        private Button button2;
        private Label label3;
    }
}