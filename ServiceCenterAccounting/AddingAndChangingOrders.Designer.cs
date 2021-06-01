
namespace ServiceCenterAccounting
{
    partial class AddingAndChangingOrders
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
            this.clientField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.workersList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.servicesList = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addBut = new System.Windows.Forms.Button();
            this.cancleBut = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLable = new System.Windows.Forms.Label();
            this.deviceField = new System.Windows.Forms.TextBox();
            this.clientWarning = new System.Windows.Forms.Label();
            this.deviceWarning = new System.Windows.Forms.Label();
            this.workerWarning = new System.Windows.Forms.Label();
            this.servicesWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientField
            // 
            this.clientField.Location = new System.Drawing.Point(87, 52);
            this.clientField.Name = "clientField";
            this.clientField.ReadOnly = true;
            this.clientField.Size = new System.Drawing.Size(161, 22);
            this.clientField.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(254, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // workersList
            // 
            this.workersList.FormattingEnabled = true;
            this.workersList.Location = new System.Drawing.Point(351, 52);
            this.workersList.Name = "workersList";
            this.workersList.Size = new System.Drawing.Size(163, 24);
            this.workersList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(84, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Клиент:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(347, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Работник:";
            // 
            // typeList
            // 
            this.typeList.FormattingEnabled = true;
            this.typeList.Location = new System.Drawing.Point(85, 127);
            this.typeList.Name = "typeList";
            this.typeList.Size = new System.Drawing.Size(163, 24);
            this.typeList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(82, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип устройства:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(254, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // servicesList
            // 
            this.servicesList.FormattingEnabled = true;
            this.servicesList.Location = new System.Drawing.Point(351, 146);
            this.servicesList.Name = "servicesList";
            this.servicesList.Size = new System.Drawing.Size(163, 24);
            this.servicesList.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(347, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Тип работ:";
            // 
            // addBut
            // 
            this.addBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBut.Location = new System.Drawing.Point(496, 323);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(110, 34);
            this.addBut.TabIndex = 27;
            this.addBut.Text = "Сохранить";
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // cancleBut
            // 
            this.cancleBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancleBut.Location = new System.Drawing.Point(12, 323);
            this.cancleBut.Name = "cancleBut";
            this.cancleBut.Size = new System.Drawing.Size(110, 34);
            this.cancleBut.TabIndex = 26;
            this.cancleBut.Text = "Отмена";
            this.cancleBut.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(254, 224);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(122, 22);
            this.dateTimePicker.TabIndex = 10;
            // 
            // dateLable
            // 
            this.dateLable.AutoSize = true;
            this.dateLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLable.Location = new System.Drawing.Point(250, 201);
            this.dateLable.Name = "dateLable";
            this.dateLable.Size = new System.Drawing.Size(142, 20);
            this.dateLable.TabIndex = 13;
            this.dateLable.Text = "Дата принятия:";
            // 
            // deviceField
            // 
            this.deviceField.Location = new System.Drawing.Point(85, 157);
            this.deviceField.Name = "deviceField";
            this.deviceField.ReadOnly = true;
            this.deviceField.Size = new System.Drawing.Size(164, 22);
            this.deviceField.TabIndex = 28;
            // 
            // clientWarning
            // 
            this.clientWarning.AutoSize = true;
            this.clientWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientWarning.ForeColor = System.Drawing.Color.Maroon;
            this.clientWarning.Location = new System.Drawing.Point(57, 52);
            this.clientWarning.Name = "clientWarning";
            this.clientWarning.Size = new System.Drawing.Size(24, 20);
            this.clientWarning.TabIndex = 44;
            this.clientWarning.Text = "!!!";
            this.clientWarning.Visible = false;
            // 
            // deviceWarning
            // 
            this.deviceWarning.AutoSize = true;
            this.deviceWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceWarning.ForeColor = System.Drawing.Color.Maroon;
            this.deviceWarning.Location = new System.Drawing.Point(55, 141);
            this.deviceWarning.Name = "deviceWarning";
            this.deviceWarning.Size = new System.Drawing.Size(24, 20);
            this.deviceWarning.TabIndex = 45;
            this.deviceWarning.Text = "!!!";
            this.deviceWarning.Visible = false;
            // 
            // workerWarning
            // 
            this.workerWarning.AutoSize = true;
            this.workerWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workerWarning.ForeColor = System.Drawing.Color.Maroon;
            this.workerWarning.Location = new System.Drawing.Point(520, 52);
            this.workerWarning.Name = "workerWarning";
            this.workerWarning.Size = new System.Drawing.Size(24, 20);
            this.workerWarning.TabIndex = 46;
            this.workerWarning.Text = "!!!";
            this.workerWarning.Visible = false;
            // 
            // servicesWarning
            // 
            this.servicesWarning.AutoSize = true;
            this.servicesWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicesWarning.ForeColor = System.Drawing.Color.Maroon;
            this.servicesWarning.Location = new System.Drawing.Point(520, 150);
            this.servicesWarning.Name = "servicesWarning";
            this.servicesWarning.Size = new System.Drawing.Size(24, 20);
            this.servicesWarning.TabIndex = 47;
            this.servicesWarning.Text = "!!!";
            this.servicesWarning.Visible = false;
            // 
            // AddingAndChangingOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 366);
            this.Controls.Add(this.servicesWarning);
            this.Controls.Add(this.workerWarning);
            this.Controls.Add(this.deviceWarning);
            this.Controls.Add(this.clientWarning);
            this.Controls.Add(this.deviceField);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.cancleBut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.servicesList);
            this.Controls.Add(this.dateLable);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workersList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientField);
            this.Name = "AddingAndChangingOrders";
            this.Text = "AddingAndChangingOrders";
            this.Load += new System.EventHandler(this.AddingAndChangingOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox clientField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox workersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox servicesList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Button cancleBut;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dateLable;
        private System.Windows.Forms.TextBox deviceField;
        private System.Windows.Forms.Label clientWarning;
        private System.Windows.Forms.Label deviceWarning;
        private System.Windows.Forms.Label workerWarning;
        private System.Windows.Forms.Label servicesWarning;
    }
}