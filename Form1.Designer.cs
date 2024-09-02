namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listPeople = new System.Windows.Forms.ListBox();
            this.createNewRecord = new System.Windows.Forms.Button();
            this.changeRecord = new System.Windows.Forms.Button();
            this.deleteRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPeople
            // 
            this.listPeople.FormattingEnabled = true;
            this.listPeople.ItemHeight = 25;
            this.listPeople.Location = new System.Drawing.Point(443, 61);
            this.listPeople.Margin = new System.Windows.Forms.Padding(4);
            this.listPeople.Name = "listPeople";
            this.listPeople.Size = new System.Drawing.Size(687, 404);
            this.listPeople.TabIndex = 0;
            // 
            // createNewRecord
            // 
            this.createNewRecord.Location = new System.Drawing.Point(40, 61);
            this.createNewRecord.Margin = new System.Windows.Forms.Padding(4);
            this.createNewRecord.Name = "createNewRecord";
            this.createNewRecord.Size = new System.Drawing.Size(320, 51);
            this.createNewRecord.TabIndex = 1;
            this.createNewRecord.Text = "Создать новую запись";
            this.createNewRecord.UseVisualStyleBackColor = true;
            this.createNewRecord.Click += new System.EventHandler(this.createNewRecord_Click);
            // 
            // changeRecord
            // 
            this.changeRecord.Location = new System.Drawing.Point(40, 166);
            this.changeRecord.Margin = new System.Windows.Forms.Padding(4);
            this.changeRecord.Name = "changeRecord";
            this.changeRecord.Size = new System.Drawing.Size(320, 49);
            this.changeRecord.TabIndex = 2;
            this.changeRecord.Text = "Изменить выбранную";
            this.changeRecord.UseVisualStyleBackColor = true;
            this.changeRecord.Click += new System.EventHandler(this.changeRecord_Click);
            // 
            // deleteRecord
            // 
            this.deleteRecord.Location = new System.Drawing.Point(40, 271);
            this.deleteRecord.Margin = new System.Windows.Forms.Padding(4);
            this.deleteRecord.Name = "deleteRecord";
            this.deleteRecord.Size = new System.Drawing.Size(320, 48);
            this.deleteRecord.TabIndex = 3;
            this.deleteRecord.Text = "Удалить выбранную";
            this.deleteRecord.UseVisualStyleBackColor = true;
            this.deleteRecord.Click += new System.EventHandler(this.deleteRecord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 562);
            this.Controls.Add(this.deleteRecord);
            this.Controls.Add(this.changeRecord);
            this.Controls.Add(this.createNewRecord);
            this.Controls.Add(this.listPeople);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Список";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listPeople;
        private System.Windows.Forms.Button createNewRecord;
        private System.Windows.Forms.Button changeRecord;
        private System.Windows.Forms.Button deleteRecord;
    }
}

