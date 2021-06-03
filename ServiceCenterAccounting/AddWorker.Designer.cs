
namespace ServiceCenterAccounting
{
    partial class AddWorker
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
            this.Last_Name_Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.First_Name_Text = new System.Windows.Forms.TextBox();
            this.Middle_Name_Text = new System.Windows.Forms.TextBox();
            this.Date_of_Birth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление работника";
            // 
            // Last_Name_Text
            // 
            this.Last_Name_Text.Location = new System.Drawing.Point(74, 47);
            this.Last_Name_Text.Name = "Last_Name_Text";
            this.Last_Name_Text.Size = new System.Drawing.Size(121, 20);
            this.Last_Name_Text.TabIndex = 1;
            this.Last_Name_Text.TextChanged += new System.EventHandler(this.Last_Name_Text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Отчество";
            // 
            // First_Name_Text
            // 
            this.First_Name_Text.Location = new System.Drawing.Point(74, 80);
            this.First_Name_Text.Name = "First_Name_Text";
            this.First_Name_Text.Size = new System.Drawing.Size(121, 20);
            this.First_Name_Text.TabIndex = 5;
            this.First_Name_Text.TextChanged += new System.EventHandler(this.First_Name_Text_TextChanged);
            // 
            // Middle_Name_Text
            // 
            this.Middle_Name_Text.Location = new System.Drawing.Point(74, 109);
            this.Middle_Name_Text.Name = "Middle_Name_Text";
            this.Middle_Name_Text.Size = new System.Drawing.Size(121, 20);
            this.Middle_Name_Text.TabIndex = 6;
            this.Middle_Name_Text.TextChanged += new System.EventHandler(this.Middle_Name_Text_TextChanged);
            // 
            // Date_of_Birth
            // 
            this.Date_of_Birth.Location = new System.Drawing.Point(104, 164);
            this.Date_of_Birth.Name = "Date_of_Birth";
            this.Date_of_Birth.Size = new System.Drawing.Size(121, 20);
            this.Date_of_Birth.TabIndex = 7;
            this.Date_of_Birth.CloseUp += new System.EventHandler(this.Date_of_Birth_CloseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата рождения";
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(74, 190);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(164, 36);
            this.InsertButton.TabIndex = 9;
            this.InsertButton.Text = "Добавить";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Процентная ставка";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(127, 138);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 11;
            // 
            // AddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 238);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Date_of_Birth);
            this.Controls.Add(this.Middle_Name_Text);
            this.Controls.Add(this.First_Name_Text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Last_Name_Text);
            this.Controls.Add(this.label1);
            this.Name = "AddWorker";
            this.Text = "AddWorker";
            this.Load += new System.EventHandler(this.AddWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Last_Name_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox First_Name_Text;
        private System.Windows.Forms.TextBox Middle_Name_Text;
        private System.Windows.Forms.DateTimePicker Date_of_Birth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}