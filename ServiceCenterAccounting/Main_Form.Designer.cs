namespace ServiceCenterAccounting
{
    partial class Form_Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Orders_in_Progress = new System.Windows.Forms.TabPage();
            this.tp_Completed_Orders = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnt_Reports = new System.Windows.Forms.Button();
            this.btn_Change_of_Status = new System.Windows.Forms.Button();
            this.btn_ = new System.Windows.Forms.Button();
            this.btn_Add_Order = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.dg_Orders_in_Progress = new System.Windows.Forms.DataGridView();
            this.tp_Accepted_Orders = new System.Windows.Forms.TabPage();
            this.dg_Completed_Orders = new System.Windows.Forms.DataGridView();
            this.dg_ = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tp_Orders_in_Progress.SuspendLayout();
            this.tp_Completed_Orders.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Orders_in_Progress)).BeginInit();
            this.tp_Accepted_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Completed_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Accepted_Orders);
            this.tabControl1.Controls.Add(this.tp_Orders_in_Progress);
            this.tabControl1.Controls.Add(this.tp_Completed_Orders);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_Orders_in_Progress
            // 
            this.tp_Orders_in_Progress.Controls.Add(this.dg_Orders_in_Progress);
            this.tp_Orders_in_Progress.Location = new System.Drawing.Point(4, 22);
            this.tp_Orders_in_Progress.Name = "tp_Orders_in_Progress";
            this.tp_Orders_in_Progress.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Orders_in_Progress.Size = new System.Drawing.Size(604, 268);
            this.tp_Orders_in_Progress.TabIndex = 1;
            this.tp_Orders_in_Progress.Text = "Заказы в работе";
            this.tp_Orders_in_Progress.UseVisualStyleBackColor = true;
            // 
            // tp_Completed_Orders
            // 
            this.tp_Completed_Orders.Controls.Add(this.dg_Completed_Orders);
            this.tp_Completed_Orders.Location = new System.Drawing.Point(4, 22);
            this.tp_Completed_Orders.Name = "tp_Completed_Orders";
            this.tp_Completed_Orders.Size = new System.Drawing.Size(604, 268);
            this.tp_Completed_Orders.TabIndex = 2;
            this.tp_Completed_Orders.Text = "Завершенные заказы";
            this.tp_Completed_Orders.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Settings);
            this.groupBox2.Controls.Add(this.bnt_Reports);
            this.groupBox2.Controls.Add(this.btn_Change_of_Status);
            this.groupBox2.Controls.Add(this.btn_);
            this.groupBox2.Controls.Add(this.btn_Add_Order);
            this.groupBox2.Location = new System.Drawing.Point(617, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 294);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // bnt_Reports
            // 
            this.bnt_Reports.Location = new System.Drawing.Point(7, 97);
            this.bnt_Reports.Name = "bnt_Reports";
            this.bnt_Reports.Size = new System.Drawing.Size(138, 23);
            this.bnt_Reports.TabIndex = 3;
            this.bnt_Reports.Text = "Создание отчетов";
            this.bnt_Reports.UseVisualStyleBackColor = true;
            // 
            // btn_Change_of_Status
            // 
            this.btn_Change_of_Status.Location = new System.Drawing.Point(7, 68);
            this.btn_Change_of_Status.Name = "btn_Change_of_Status";
            this.btn_Change_of_Status.Size = new System.Drawing.Size(138, 23);
            this.btn_Change_of_Status.TabIndex = 2;
            this.btn_Change_of_Status.Text = "Изменение заказа";
            this.btn_Change_of_Status.UseVisualStyleBackColor = true;
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(6, 39);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(138, 23);
            this.btn_.TabIndex = 1;
            this.btn_.Text = "Изменить статус";
            this.btn_.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Order
            // 
            this.btn_Add_Order.Location = new System.Drawing.Point(7, 10);
            this.btn_Add_Order.Name = "btn_Add_Order";
            this.btn_Add_Order.Size = new System.Drawing.Size(138, 23);
            this.btn_Add_Order.TabIndex = 0;
            this.btn_Add_Order.Text = "Добавить заказ";
            this.btn_Add_Order.UseVisualStyleBackColor = true;
            // 
            // btn_Settings
            // 
            this.btn_Settings.Location = new System.Drawing.Point(7, 126);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(136, 23);
            this.btn_Settings.TabIndex = 4;
            this.btn_Settings.Text = "Настройки";
            this.btn_Settings.UseVisualStyleBackColor = true;
            // 
            // dg_Orders_in_Progress
            // 
            this.dg_Orders_in_Progress.AllowUserToAddRows = false;
            this.dg_Orders_in_Progress.AllowUserToDeleteRows = false;
            this.dg_Orders_in_Progress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Orders_in_Progress.Location = new System.Drawing.Point(5, 3);
            this.dg_Orders_in_Progress.Name = "dg_Orders_in_Progress";
            this.dg_Orders_in_Progress.ReadOnly = true;
            this.dg_Orders_in_Progress.Size = new System.Drawing.Size(596, 262);
            this.dg_Orders_in_Progress.TabIndex = 0;
            // 
            // tp_Accepted_Orders
            // 
            this.tp_Accepted_Orders.Controls.Add(this.dg_);
            this.tp_Accepted_Orders.Location = new System.Drawing.Point(4, 22);
            this.tp_Accepted_Orders.Name = "tp_Accepted_Orders";
            this.tp_Accepted_Orders.Size = new System.Drawing.Size(604, 268);
            this.tp_Accepted_Orders.TabIndex = 3;
            this.tp_Accepted_Orders.Text = "Принятые заказы";
            this.tp_Accepted_Orders.UseVisualStyleBackColor = true;
            // 
            // dg_Completed_Orders
            // 
            this.dg_Completed_Orders.AllowUserToAddRows = false;
            this.dg_Completed_Orders.AllowUserToDeleteRows = false;
            this.dg_Completed_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Completed_Orders.Location = new System.Drawing.Point(5, 3);
            this.dg_Completed_Orders.Name = "dg_Completed_Orders";
            this.dg_Completed_Orders.ReadOnly = true;
            this.dg_Completed_Orders.Size = new System.Drawing.Size(596, 262);
            this.dg_Completed_Orders.TabIndex = 0;
            // 
            // dg_
            // 
            this.dg_.AllowUserToAddRows = false;
            this.dg_.AllowUserToDeleteRows = false;
            this.dg_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_.Location = new System.Drawing.Point(5, 3);
            this.dg_.Name = "dg_";
            this.dg_.ReadOnly = true;
            this.dg_.Size = new System.Drawing.Size(596, 262);
            this.dg_.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 298);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tp_Orders_in_Progress.ResumeLayout(false);
            this.tp_Completed_Orders.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Orders_in_Progress)).EndInit();
            this.tp_Accepted_Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Completed_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Orders_in_Progress;
        private System.Windows.Forms.TabPage tp_Completed_Orders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bnt_Reports;
        private System.Windows.Forms.Button btn_Change_of_Status;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.Button btn_Add_Order;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.TabPage tp_Accepted_Orders;
        private System.Windows.Forms.DataGridView dg_;
        private System.Windows.Forms.DataGridView dg_Orders_in_Progress;
        private System.Windows.Forms.DataGridView dg_Completed_Orders;
    }
}

