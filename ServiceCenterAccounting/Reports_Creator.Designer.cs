namespace ServiceCenterAccounting
{
    partial class Reports_Creator
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
            this.IntervalBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IntervalTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.IntervalAfter = new System.Windows.Forms.DateTimePicker();
            this.ReportTable = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.OrdersCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Earnings = new System.Windows.Forms.TextBox();
            this.Save_to_PDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(231, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Отчёт по предприятию";
            // 
            // IntervalBox
            // 
            this.IntervalBox.FormattingEnabled = true;
            this.IntervalBox.Items.AddRange(new object[] {
            "За месяц",
            "За год",
            "За определённый промежуток"});
            this.IntervalBox.Location = new System.Drawing.Point(237, 43);
            this.IntervalBox.Name = "IntervalBox";
            this.IntervalBox.Size = new System.Drawing.Size(248, 21);
            this.IntervalBox.TabIndex = 2;
            this.IntervalBox.Text = "Выберите временной промежуток";
            this.IntervalBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "С";
            this.label2.Visible = false;
            // 
            // IntervalTo
            // 
            this.IntervalTo.Location = new System.Drawing.Point(56, 70);
            this.IntervalTo.Name = "IntervalTo";
            this.IntervalTo.Size = new System.Drawing.Size(200, 20);
            this.IntervalTo.TabIndex = 6;
            this.IntervalTo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(442, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "По";
            this.label3.Visible = false;
            // 
            // IntervalAfter
            // 
            this.IntervalAfter.Location = new System.Drawing.Point(481, 69);
            this.IntervalAfter.Name = "IntervalAfter";
            this.IntervalAfter.Size = new System.Drawing.Size(200, 20);
            this.IntervalAfter.TabIndex = 8;
            this.IntervalAfter.Visible = false;
            // 
            // ReportTable
            // 
            this.ReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportTable.Location = new System.Drawing.Point(12, 96);
            this.ReportTable.Name = "ReportTable";
            this.ReportTable.Size = new System.Drawing.Size(711, 221);
            this.ReportTable.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Общее количество выполненых заказов";
            // 
            // OrdersCount
            // 
            this.OrdersCount.Location = new System.Drawing.Point(296, 320);
            this.OrdersCount.Name = "OrdersCount";
            this.OrdersCount.ReadOnly = true;
            this.OrdersCount.Size = new System.Drawing.Size(116, 20);
            this.OrdersCount.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(442, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Прибыль предприятия";
            // 
            // Earnings
            // 
            this.Earnings.Location = new System.Drawing.Point(611, 321);
            this.Earnings.Name = "Earnings";
            this.Earnings.ReadOnly = true;
            this.Earnings.Size = new System.Drawing.Size(100, 20);
            this.Earnings.TabIndex = 13;
            // 
            // Save_to_PDF
            // 
            this.Save_to_PDF.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_to_PDF.Location = new System.Drawing.Point(270, 346);
            this.Save_to_PDF.Name = "Save_to_PDF";
            this.Save_to_PDF.Size = new System.Drawing.Size(189, 48);
            this.Save_to_PDF.TabIndex = 14;
            this.Save_to_PDF.Text = "Сохранить в PDF";
            this.Save_to_PDF.UseVisualStyleBackColor = true;
            // 
            // Reports_Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 395);
            this.Controls.Add(this.Save_to_PDF);
            this.Controls.Add(this.Earnings);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrdersCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReportTable);
            this.Controls.Add(this.IntervalAfter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IntervalTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IntervalBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reports_Creator";
            this.ShowIcon = false;
            this.Text = "Reports_Createor";
            ((System.ComponentModel.ISupportInitialize)(this.ReportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IntervalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker IntervalTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker IntervalAfter;
        private System.Windows.Forms.DataGridView ReportTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrdersCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Earnings;
        private System.Windows.Forms.Button Save_to_PDF;
    }
}