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
            this.tp_Accepted_Orders = new System.Windows.Forms.TabPage();
            this.dg_Orders_Accepted = new System.Windows.Forms.DataGridView();
            this.tp_Orders_in_Progress = new System.Windows.Forms.TabPage();
            this.dg_Orders_in_Progress = new System.Windows.Forms.DataGridView();
            this.tp_Completed_Orders = new System.Windows.Forms.TabPage();
            this.dg_Completed_Orders = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.bnt_Report = new System.Windows.Forms.Button();
            this.btn_Change = new System.Windows.Forms.Button();
            this.btn_Change_Status = new System.Windows.Forms.Button();
            this.btn_Add_Order = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tp_Accepted_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Orders_Accepted)).BeginInit();
            this.tp_Orders_in_Progress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Orders_in_Progress)).BeginInit();
            this.tp_Completed_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Completed_Orders)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Accepted_Orders);
            this.tabControl1.Controls.Add(this.tp_Orders_in_Progress);
            this.tabControl1.Controls.Add(this.tp_Completed_Orders);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 362);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tp_Accepted_Orders
            // 
            this.tp_Accepted_Orders.Controls.Add(this.dg_Orders_Accepted);
            this.tp_Accepted_Orders.Location = new System.Drawing.Point(4, 25);
            this.tp_Accepted_Orders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Accepted_Orders.Name = "tp_Accepted_Orders";
            this.tp_Accepted_Orders.Size = new System.Drawing.Size(808, 333);
            this.tp_Accepted_Orders.TabIndex = 3;
            this.tp_Accepted_Orders.Text = "Принятые заказы";
            this.tp_Accepted_Orders.UseVisualStyleBackColor = true;
            // 
            // dg_Orders_Accepted
            // 
            this.dg_Orders_Accepted.AllowUserToAddRows = false;
            this.dg_Orders_Accepted.AllowUserToDeleteRows = false;
            this.dg_Orders_Accepted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Orders_Accepted.Location = new System.Drawing.Point(7, 4);
            this.dg_Orders_Accepted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_Orders_Accepted.Name = "dg_Orders_Accepted";
            this.dg_Orders_Accepted.ReadOnly = true;
            this.dg_Orders_Accepted.RowHeadersWidth = 51;
            this.dg_Orders_Accepted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Orders_Accepted.Size = new System.Drawing.Size(795, 322);
            this.dg_Orders_Accepted.TabIndex = 0;
            this.dg_Orders_Accepted.DoubleClick += new System.EventHandler(this.dg_Orders_Accepted_DoubleClick);
            // 
            // tp_Orders_in_Progress
            // 
            this.tp_Orders_in_Progress.Controls.Add(this.dg_Orders_in_Progress);
            this.tp_Orders_in_Progress.Location = new System.Drawing.Point(4, 25);
            this.tp_Orders_in_Progress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Orders_in_Progress.Name = "tp_Orders_in_Progress";
            this.tp_Orders_in_Progress.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Orders_in_Progress.Size = new System.Drawing.Size(808, 333);
            this.tp_Orders_in_Progress.TabIndex = 1;
            this.tp_Orders_in_Progress.Text = "Заказы в работе";
            this.tp_Orders_in_Progress.UseVisualStyleBackColor = true;
            // 
            // dg_Orders_in_Progress
            // 
            this.dg_Orders_in_Progress.AllowUserToAddRows = false;
            this.dg_Orders_in_Progress.AllowUserToDeleteRows = false;
            this.dg_Orders_in_Progress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Orders_in_Progress.Location = new System.Drawing.Point(7, 4);
            this.dg_Orders_in_Progress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_Orders_in_Progress.Name = "dg_Orders_in_Progress";
            this.dg_Orders_in_Progress.ReadOnly = true;
            this.dg_Orders_in_Progress.RowHeadersWidth = 51;
            this.dg_Orders_in_Progress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Orders_in_Progress.Size = new System.Drawing.Size(795, 322);
            this.dg_Orders_in_Progress.TabIndex = 0;
            // 
            // tp_Completed_Orders
            // 
            this.tp_Completed_Orders.Controls.Add(this.dg_Completed_Orders);
            this.tp_Completed_Orders.Location = new System.Drawing.Point(4, 25);
            this.tp_Completed_Orders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Completed_Orders.Name = "tp_Completed_Orders";
            this.tp_Completed_Orders.Size = new System.Drawing.Size(808, 333);
            this.tp_Completed_Orders.TabIndex = 2;
            this.tp_Completed_Orders.Text = "Завершенные заказы";
            this.tp_Completed_Orders.UseVisualStyleBackColor = true;
            // 
            // dg_Completed_Orders
            // 
            this.dg_Completed_Orders.AllowUserToAddRows = false;
            this.dg_Completed_Orders.AllowUserToDeleteRows = false;
            this.dg_Completed_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Completed_Orders.Location = new System.Drawing.Point(7, 4);
            this.dg_Completed_Orders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_Completed_Orders.Name = "dg_Completed_Orders";
            this.dg_Completed_Orders.ReadOnly = true;
            this.dg_Completed_Orders.RowHeadersWidth = 51;
            this.dg_Completed_Orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_Completed_Orders.Size = new System.Drawing.Size(795, 322);
            this.dg_Completed_Orders.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Settings);
            this.groupBox2.Controls.Add(this.bnt_Report);
            this.groupBox2.Controls.Add(this.btn_Change);
            this.groupBox2.Controls.Add(this.btn_Change_Status);
            this.groupBox2.Controls.Add(this.btn_Add_Order);
            this.groupBox2.Location = new System.Drawing.Point(823, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(201, 335);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btn_Settings
            // 
            this.btn_Settings.Location = new System.Drawing.Point(7, 160);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(184, 28);
            this.btn_Settings.TabIndex = 4;
            this.btn_Settings.Text = "Настройки";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // bnt_Report
            // 
            this.bnt_Report.Location = new System.Drawing.Point(7, 58);
            this.bnt_Report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt_Report.Name = "bnt_Report";
            this.bnt_Report.Size = new System.Drawing.Size(184, 28);
            this.bnt_Report.TabIndex = 3;
            this.bnt_Report.Text = "Создание отчета";
            this.bnt_Report.UseVisualStyleBackColor = true;
            this.bnt_Report.Click += new System.EventHandler(this.bnt_Reports_Click);
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(7, 126);
            this.btn_Change.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(184, 28);
            this.btn_Change.TabIndex = 2;
            this.btn_Change.Text = "Изменение заказа";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_of_Status_Click);
            // 
            // btn_Change_Status
            // 
            this.btn_Change_Status.Location = new System.Drawing.Point(7, 92);
            this.btn_Change_Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Change_Status.Name = "btn_Change_Status";
            this.btn_Change_Status.Size = new System.Drawing.Size(184, 28);
            this.btn_Change_Status.TabIndex = 1;
            this.btn_Change_Status.Text = "Изменить статус";
            this.btn_Change_Status.UseVisualStyleBackColor = true;
            this.btn_Change_Status.Click += new System.EventHandler(this.btn_Change_Stattus_Click);
            // 
            // btn_Add_Order
            // 
            this.btn_Add_Order.Location = new System.Drawing.Point(7, 23);
            this.btn_Add_Order.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add_Order.Name = "btn_Add_Order";
            this.btn_Add_Order.Size = new System.Drawing.Size(184, 28);
            this.btn_Add_Order.TabIndex = 0;
            this.btn_Add_Order.Text = "Добавить заказ";
            this.btn_Add_Order.UseVisualStyleBackColor = true;
            this.btn_Add_Order.Click += new System.EventHandler(this.btn_Add_Order_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 367);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.Text = "Service Center Accounting";
            this.tabControl1.ResumeLayout(false);
            this.tp_Accepted_Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Orders_Accepted)).EndInit();
            this.tp_Orders_in_Progress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Orders_in_Progress)).EndInit();
            this.tp_Completed_Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Completed_Orders)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Orders_in_Progress;
        private System.Windows.Forms.TabPage tp_Completed_Orders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bnt_Report;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.Button btn_Change_Status;
        private System.Windows.Forms.Button btn_Add_Order;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.TabPage tp_Accepted_Orders;
        private System.Windows.Forms.DataGridView dg_Orders_Accepted;
        private System.Windows.Forms.DataGridView dg_Orders_in_Progress;
        private System.Windows.Forms.DataGridView dg_Completed_Orders;
    }
}

