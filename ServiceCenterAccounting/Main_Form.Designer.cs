﻿namespace ServiceCenterAccounting
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
            this.dg_Orders_Viev = new System.Windows.Forms.DataGridView();
            this.tp_Orders_in_Progress = new System.Windows.Forms.TabPage();
            this.dg_Orders_in_Progress = new System.Windows.Forms.DataGridView();
            this.tp_Completed_Orders = new System.Windows.Forms.TabPage();
            this.dg_Completed_Orders = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.bnt_Report = new System.Windows.Forms.Button();
            this.btn_Change_of_Status = new System.Windows.Forms.Button();
            this.btn_ = new System.Windows.Forms.Button();
            this.btn_Add_Order = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tp_Accepted_Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Orders_Viev)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 294);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_Accepted_Orders
            // 
            this.tp_Accepted_Orders.Controls.Add(this.dg_Orders_Viev);
            this.tp_Accepted_Orders.Location = new System.Drawing.Point(4, 22);
            this.tp_Accepted_Orders.Name = "tp_Accepted_Orders";
            this.tp_Accepted_Orders.Size = new System.Drawing.Size(604, 268);
            this.tp_Accepted_Orders.TabIndex = 3;
            this.tp_Accepted_Orders.Text = "Принятые заказы";
            this.tp_Accepted_Orders.UseVisualStyleBackColor = true;
            // 
            // dg_Orders_Viev
            // 
            this.dg_Orders_Viev.AllowUserToAddRows = false;
            this.dg_Orders_Viev.AllowUserToDeleteRows = false;
            this.dg_Orders_Viev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Orders_Viev.Location = new System.Drawing.Point(5, 3);
            this.dg_Orders_Viev.Name = "dg_Orders_Viev";
            this.dg_Orders_Viev.ReadOnly = true;
            this.dg_Orders_Viev.Size = new System.Drawing.Size(596, 262);
            this.dg_Orders_Viev.TabIndex = 0;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Settings);
            this.groupBox2.Controls.Add(this.bnt_Report);
            this.groupBox2.Controls.Add(this.btn_Change_of_Status);
            this.groupBox2.Controls.Add(this.btn_);
            this.groupBox2.Controls.Add(this.btn_Add_Order);
            this.groupBox2.Location = new System.Drawing.Point(617, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 272);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btn_Settings
            // 
            this.btn_Settings.Location = new System.Drawing.Point(4, 119);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(136, 23);
            this.btn_Settings.TabIndex = 4;
            this.btn_Settings.Text = "Настройки";
            this.btn_Settings.UseVisualStyleBackColor = true;
            // 
            // bnt_Report
            // 
            this.bnt_Report.Location = new System.Drawing.Point(4, 90);
            this.bnt_Report.Name = "bnt_Report";
            this.bnt_Report.Size = new System.Drawing.Size(138, 23);
            this.bnt_Report.TabIndex = 3;
            this.bnt_Report.Text = "Создание отчета";
            this.bnt_Report.UseVisualStyleBackColor = true;
            this.bnt_Report.Click += new System.EventHandler(this.bnt_Reports_Click);
            // 
            // btn_Change_of_Status
            // 
            this.btn_Change_of_Status.Location = new System.Drawing.Point(4, 61);
            this.btn_Change_of_Status.Name = "btn_Change_of_Status";
            this.btn_Change_of_Status.Size = new System.Drawing.Size(138, 23);
            this.btn_Change_of_Status.TabIndex = 2;
            this.btn_Change_of_Status.Text = "Изменение заказа";
            this.btn_Change_of_Status.UseVisualStyleBackColor = true;
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(4, 32);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(138, 23);
            this.btn_.TabIndex = 1;
            this.btn_.Text = "Изменить статус";
            this.btn_.UseVisualStyleBackColor = true;
            // 
            // btn_Add_Order
            // 
            this.btn_Add_Order.Location = new System.Drawing.Point(4, 3);
            this.btn_Add_Order.Name = "btn_Add_Order";
            this.btn_Add_Order.Size = new System.Drawing.Size(138, 23);
            this.btn_Add_Order.TabIndex = 0;
            this.btn_Add_Order.Text = "Добавить заказ";
            this.btn_Add_Order.UseVisualStyleBackColor = true;
            this.btn_Add_Order.Click += new System.EventHandler(this.btn_Add_Order_Click);
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
            this.tp_Accepted_Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Orders_Viev)).EndInit();
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
        private System.Windows.Forms.Button btn_Change_of_Status;
        private System.Windows.Forms.Button btn_;
        private System.Windows.Forms.Button btn_Add_Order;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.TabPage tp_Accepted_Orders;
        private System.Windows.Forms.DataGridView dg_Orders_Viev;
        private System.Windows.Forms.DataGridView dg_Orders_in_Progress;
        private System.Windows.Forms.DataGridView dg_Completed_Orders;
    }
}

