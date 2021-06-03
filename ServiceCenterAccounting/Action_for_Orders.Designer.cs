namespace ServiceCenterAccounting
{
    partial class Action_for_Orders
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
            this.l_Text1 = new System.Windows.Forms.Label();
            this.cb_Worker = new System.Windows.Forms.ComboBox();
            this.btn_Accept = new System.Windows.Forms.Button();
            this.nud_Cost_of_Parts = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cost_of_Parts)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Text1
            // 
            this.l_Text1.AutoSize = true;
            this.l_Text1.Location = new System.Drawing.Point(37, 9);
            this.l_Text1.Name = "l_Text1";
            this.l_Text1.Size = new System.Drawing.Size(164, 13);
            this.l_Text1.TabIndex = 0;
            this.l_Text1.Text = "Введите стоимость запчастей:";
            // 
            // cb_Worker
            // 
            this.cb_Worker.FormattingEnabled = true;
            this.cb_Worker.Location = new System.Drawing.Point(57, 25);
            this.cb_Worker.Name = "cb_Worker";
            this.cb_Worker.Size = new System.Drawing.Size(121, 21);
            this.cb_Worker.TabIndex = 1;
            // 
            // btn_Accept
            // 
            this.btn_Accept.Location = new System.Drawing.Point(57, 52);
            this.btn_Accept.Name = "btn_Accept";
            this.btn_Accept.Size = new System.Drawing.Size(121, 23);
            this.btn_Accept.TabIndex = 2;
            this.btn_Accept.Text = "Изменить статус";
            this.btn_Accept.UseVisualStyleBackColor = true;
            this.btn_Accept.Click += new System.EventHandler(this.btn_Accept_Click);
            // 
            // nud_Cost_of_Parts
            // 
            this.nud_Cost_of_Parts.DecimalPlaces = 2;
            this.nud_Cost_of_Parts.Location = new System.Drawing.Point(57, 25);
            this.nud_Cost_of_Parts.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_Cost_of_Parts.Name = "nud_Cost_of_Parts";
            this.nud_Cost_of_Parts.Size = new System.Drawing.Size(121, 20);
            this.nud_Cost_of_Parts.TabIndex = 3;
            this.nud_Cost_of_Parts.Visible = false;
            // 
            // Action_for_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 87);
            this.Controls.Add(this.nud_Cost_of_Parts);
            this.Controls.Add(this.btn_Accept);
            this.Controls.Add(this.cb_Worker);
            this.Controls.Add(this.l_Text1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Action_for_Orders";
            this.ShowIcon = false;
            this.Text = "Изменение статуса заказа";
            this.Load += new System.EventHandler(this.Action_for_Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cost_of_Parts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Text1;
        private System.Windows.Forms.ComboBox cb_Worker;
        private System.Windows.Forms.Button btn_Accept;
        private System.Windows.Forms.NumericUpDown nud_Cost_of_Parts;
    }
}