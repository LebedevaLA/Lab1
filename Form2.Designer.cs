using System;

namespace Lab_1
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
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.inputDateTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputNumberCard = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(67, 217);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(90, 30);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK\r\n\r\n";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(310, 217);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(95, 31);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // inputDateTime
            // 
            this.inputDateTime.Location = new System.Drawing.Point(234, 113);
            this.inputDateTime.Name = "inputDateTime";
            this.inputDateTime.Size = new System.Drawing.Size(200, 31);
            this.inputDateTime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите дату";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введите имя";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(234, 156);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(200, 31);
            this.inputName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Введите номер";
            // 
            // inputNumberCard
            // 
            this.inputNumberCard.Location = new System.Drawing.Point(234, 68);
            this.inputNumberCard.Name = "inputNumberCard";
            this.inputNumberCard.Size = new System.Drawing.Size(200, 31);
            this.inputNumberCard.TabIndex = 7;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(576, 319);
            this.Controls.Add(this.inputNumberCard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputDateTime);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Создание/изменение  записи";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown_login);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DateTimePicker inputDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputNumberCard;
    }
}