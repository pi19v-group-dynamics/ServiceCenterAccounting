
namespace ServiceCenterAccounting
{
    partial class AddingClient
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
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.middleNameField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.seriesField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numberField = new System.Windows.Forms.TextBox();
            this.cancleBut = new System.Windows.Forms.Button();
            this.addBut = new System.Windows.Forms.Button();
            this.middleNameWarning = new System.Windows.Forms.Label();
            this.seriesWarning = new System.Windows.Forms.Label();
            this.numberWarning = new System.Windows.Forms.Label();
            this.lastNameWarning = new System.Windows.Forms.Label();
            this.firstNameWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Фамилия:";
            // 
            // lastNameField
            // 
            this.lastNameField.Location = new System.Drawing.Point(49, 42);
            this.lastNameField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(102, 20);
            this.lastNameField.TabIndex = 4;
            this.lastNameField.TextChanged += new System.EventHandler(this.lastNameField_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(211, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя:";
            // 
            // firstNameField
            // 
            this.firstNameField.Location = new System.Drawing.Point(212, 42);
            this.firstNameField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(102, 20);
            this.firstNameField.TabIndex = 6;
            this.firstNameField.TextChanged += new System.EventHandler(this.firstNameField_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(128, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отчество:";
            // 
            // middleNameField
            // 
            this.middleNameField.Location = new System.Drawing.Point(130, 114);
            this.middleNameField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.middleNameField.Name = "middleNameField";
            this.middleNameField.Size = new System.Drawing.Size(102, 20);
            this.middleNameField.TabIndex = 8;
            this.middleNameField.TextChanged += new System.EventHandler(this.middleNameField_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(127, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Серия паспорта:";
            // 
            // seriesField
            // 
            this.seriesField.Location = new System.Drawing.Point(129, 173);
            this.seriesField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seriesField.MaxLength = 6;
            this.seriesField.Name = "seriesField";
            this.seriesField.Size = new System.Drawing.Size(102, 20);
            this.seriesField.TabIndex = 10;
            this.seriesField.TextChanged += new System.EventHandler(this.seriesField_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(127, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Тел. номер:";
            // 
            // numberField
            // 
            this.numberField.Location = new System.Drawing.Point(129, 238);
            this.numberField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberField.MaxLength = 10;
            this.numberField.Name = "numberField";
            this.numberField.Size = new System.Drawing.Size(102, 20);
            this.numberField.TabIndex = 12;
            this.numberField.TextChanged += new System.EventHandler(this.numberField_TextChanged);
            // 
            // cancleBut
            // 
            this.cancleBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancleBut.Location = new System.Drawing.Point(67, 316);
            this.cancleBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancleBut.Name = "cancleBut";
            this.cancleBut.Size = new System.Drawing.Size(82, 28);
            this.cancleBut.TabIndex = 14;
            this.cancleBut.Text = "Отмена";
            this.cancleBut.UseVisualStyleBackColor = true;
            this.cancleBut.Click += new System.EventHandler(this.cancleBut_Click);
            // 
            // addBut
            // 
            this.addBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBut.Location = new System.Drawing.Point(214, 316);
            this.addBut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(89, 28);
            this.addBut.TabIndex = 15;
            this.addBut.Text = "Сохранить";
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // middleNameWarning
            // 
            this.middleNameWarning.AutoSize = true;
            this.middleNameWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameWarning.ForeColor = System.Drawing.Color.Maroon;
            this.middleNameWarning.Location = new System.Drawing.Point(236, 114);
            this.middleNameWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.middleNameWarning.Name = "middleNameWarning";
            this.middleNameWarning.Size = new System.Drawing.Size(17, 17);
            this.middleNameWarning.TabIndex = 16;
            this.middleNameWarning.Text = "!!!";
            // 
            // seriesWarning
            // 
            this.seriesWarning.AutoSize = true;
            this.seriesWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seriesWarning.ForeColor = System.Drawing.Color.Maroon;
            this.seriesWarning.Location = new System.Drawing.Point(236, 173);
            this.seriesWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seriesWarning.Name = "seriesWarning";
            this.seriesWarning.Size = new System.Drawing.Size(17, 17);
            this.seriesWarning.TabIndex = 17;
            this.seriesWarning.Text = "!!!";
            // 
            // numberWarning
            // 
            this.numberWarning.AutoSize = true;
            this.numberWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberWarning.ForeColor = System.Drawing.Color.Maroon;
            this.numberWarning.Location = new System.Drawing.Point(236, 238);
            this.numberWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberWarning.Name = "numberWarning";
            this.numberWarning.Size = new System.Drawing.Size(17, 17);
            this.numberWarning.TabIndex = 18;
            this.numberWarning.Text = "!!!";
            // 
            // lastNameWarning
            // 
            this.lastNameWarning.AutoSize = true;
            this.lastNameWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameWarning.ForeColor = System.Drawing.Color.Maroon;
            this.lastNameWarning.Location = new System.Drawing.Point(154, 44);
            this.lastNameWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameWarning.Name = "lastNameWarning";
            this.lastNameWarning.Size = new System.Drawing.Size(17, 17);
            this.lastNameWarning.TabIndex = 19;
            this.lastNameWarning.Text = "!!!";
            // 
            // firstNameWarning
            // 
            this.firstNameWarning.AutoSize = true;
            this.firstNameWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameWarning.ForeColor = System.Drawing.Color.Maroon;
            this.firstNameWarning.Location = new System.Drawing.Point(317, 44);
            this.firstNameWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameWarning.Name = "firstNameWarning";
            this.firstNameWarning.Size = new System.Drawing.Size(17, 17);
            this.firstNameWarning.TabIndex = 20;
            this.firstNameWarning.Text = "!!!";
            // 
            // AddingClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 368);
            this.Controls.Add(this.firstNameWarning);
            this.Controls.Add(this.lastNameWarning);
            this.Controls.Add(this.numberWarning);
            this.Controls.Add(this.seriesWarning);
            this.Controls.Add(this.middleNameWarning);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.cancleBut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numberField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.seriesField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.middleNameField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameField);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddingClient";
            this.Text = "AddingClient";
            this.Load += new System.EventHandler(this.AddingClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox middleNameField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox seriesField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numberField;
        private System.Windows.Forms.Button cancleBut;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Label middleNameWarning;
        private System.Windows.Forms.Label seriesWarning;
        private System.Windows.Forms.Label numberWarning;
        private System.Windows.Forms.Label lastNameWarning;
        private System.Windows.Forms.Label firstNameWarning;
    }
}