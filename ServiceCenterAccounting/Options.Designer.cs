namespace ServiceCenterAccounting
{
    partial class Options
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
            this.label4 = new System.Windows.Forms.Label();
            this.Name_srv_text = new System.Windows.Forms.TextBox();
            this.Address_srv_text = new System.Windows.Forms.TextBox();
            this.Number_srv_text = new System.Windows.Forms.TextBox();
            this.ChangeInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Type_of_notes = new System.Windows.Forms.ComboBox();
            this.NotesData = new System.Windows.Forms.DataGridView();
            this.NotesUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.InsertNote = new System.Windows.Forms.Button();
            this.DeleteNotes = new System.Windows.Forms.Button();
            this.Type_of_delete = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NotesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotesUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройки программы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название предприятия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адрес предприятия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер телефона предприятия";
            // 
            // Name_srv_text
            // 
            this.Name_srv_text.Location = new System.Drawing.Point(180, 41);
            this.Name_srv_text.Name = "Name_srv_text";
            this.Name_srv_text.Size = new System.Drawing.Size(126, 20);
            this.Name_srv_text.TabIndex = 4;
            // 
            // Address_srv_text
            // 
            this.Address_srv_text.Location = new System.Drawing.Point(180, 75);
            this.Address_srv_text.Name = "Address_srv_text";
            this.Address_srv_text.Size = new System.Drawing.Size(126, 20);
            this.Address_srv_text.TabIndex = 5;
            // 
            // Number_srv_text
            // 
            this.Number_srv_text.Location = new System.Drawing.Point(180, 110);
            this.Number_srv_text.Name = "Number_srv_text";
            this.Number_srv_text.Size = new System.Drawing.Size(126, 20);
            this.Number_srv_text.TabIndex = 6;
            // 
            // ChangeInfo
            // 
            this.ChangeInfo.Location = new System.Drawing.Point(312, 68);
            this.ChangeInfo.Name = "ChangeInfo";
            this.ChangeInfo.Size = new System.Drawing.Size(119, 35);
            this.ChangeInfo.TabIndex = 7;
            this.ChangeInfo.Text = "Изменить";
            this.ChangeInfo.UseVisualStyleBackColor = true;
            this.ChangeInfo.Click += new System.EventHandler(this.ChangeInfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Выберите справочник";
            // 
            // Type_of_notes
            // 
            this.Type_of_notes.FormattingEnabled = true;
            this.Type_of_notes.Items.AddRange(new object[] {
            "Работники",
            "Типы услуг",
            "Типы компонентов"});
            this.Type_of_notes.Location = new System.Drawing.Point(140, 149);
            this.Type_of_notes.Name = "Type_of_notes";
            this.Type_of_notes.Size = new System.Drawing.Size(121, 21);
            this.Type_of_notes.TabIndex = 9;
            this.Type_of_notes.SelectionChangeCommitted += new System.EventHandler(this.Type_of_notes_SelectionChangeCommitted);
            // 
            // NotesData
            // 
            this.NotesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotesData.Location = new System.Drawing.Point(12, 176);
            this.NotesData.Name = "NotesData";
            this.NotesData.Size = new System.Drawing.Size(449, 172);
            this.NotesData.TabIndex = 10;
            // 
            // NotesUpDown
            // 
            this.NotesUpDown.Location = new System.Drawing.Point(408, 150);
            this.NotesUpDown.Name = "NotesUpDown";
            this.NotesUpDown.Size = new System.Drawing.Size(41, 20);
            this.NotesUpDown.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Страница:";
            // 
            // InsertNote
            // 
            this.InsertNote.Location = new System.Drawing.Point(12, 354);
            this.InsertNote.Name = "InsertNote";
            this.InsertNote.Size = new System.Drawing.Size(125, 29);
            this.InsertNote.TabIndex = 13;
            this.InsertNote.Text = "Добавить";
            this.InsertNote.UseVisualStyleBackColor = true;
            this.InsertNote.Click += new System.EventHandler(this.InsertNote_Click);
            // 
            // DeleteNotes
            // 
            this.DeleteNotes.Location = new System.Drawing.Point(338, 354);
            this.DeleteNotes.Name = "DeleteNotes";
            this.DeleteNotes.Size = new System.Drawing.Size(123, 29);
            this.DeleteNotes.TabIndex = 14;
            this.DeleteNotes.Text = "Удалить";
            this.DeleteNotes.UseVisualStyleBackColor = true;
            // 
            // Type_of_delete
            // 
            this.Type_of_delete.FormattingEnabled = true;
            this.Type_of_delete.Items.AddRange(new object[] {
            "Одно поле",
            "Выделенные поля",
            "Все поля"});
            this.Type_of_delete.Location = new System.Drawing.Point(211, 362);
            this.Type_of_delete.Name = "Type_of_delete";
            this.Type_of_delete.Size = new System.Drawing.Size(121, 21);
            this.Type_of_delete.TabIndex = 15;
            this.Type_of_delete.Text = "Выберите метод";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 385);
            this.Controls.Add(this.Type_of_delete);
            this.Controls.Add(this.DeleteNotes);
            this.Controls.Add(this.InsertNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NotesUpDown);
            this.Controls.Add(this.NotesData);
            this.Controls.Add(this.Type_of_notes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChangeInfo);
            this.Controls.Add(this.Number_srv_text);
            this.Controls.Add(this.Address_srv_text);
            this.Controls.Add(this.Name_srv_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.ShowIcon = false;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotesData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotesUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Name_srv_text;
        private System.Windows.Forms.TextBox Address_srv_text;
        private System.Windows.Forms.TextBox Number_srv_text;
        private System.Windows.Forms.Button ChangeInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Type_of_notes;
        private System.Windows.Forms.DataGridView NotesData;
        private System.Windows.Forms.NumericUpDown NotesUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button InsertNote;
        private System.Windows.Forms.Button DeleteNotes;
        private System.Windows.Forms.ComboBox Type_of_delete;
    }
}