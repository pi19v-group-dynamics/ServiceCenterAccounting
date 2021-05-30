
namespace ServiceCenterAccounting
{
    partial class Initial_Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Initial_Setup));
            this.l_Text1 = new System.Windows.Forms.Label();
            this.btn_Further = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.tb_Name_Srvice = new System.Windows.Forms.TextBox();
            this.tb_Addres_Service = new System.Windows.Forms.TextBox();
            this.tb_Phone_Service = new System.Windows.Forms.TextBox();
            this.l_Input_Text2 = new System.Windows.Forms.Label();
            this.l_Input_Text3 = new System.Windows.Forms.Label();
            this.l_Input_Text1 = new System.Windows.Forms.Label();
            this.l_Warning1 = new System.Windows.Forms.Label();
            this.l_Warning2 = new System.Windows.Forms.Label();
            this.l_Warning3 = new System.Windows.Forms.Label();
            this.l_Text2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_Text1
            // 
            this.l_Text1.AutoSize = true;
            this.l_Text1.Location = new System.Drawing.Point(37, 68);
            this.l_Text1.Name = "l_Text1";
            this.l_Text1.Size = new System.Drawing.Size(347, 104);
            this.l_Text1.TabIndex = 0;
            this.l_Text1.Text = resources.GetString("l_Text1.Text");
            // 
            // btn_Further
            // 
            this.btn_Further.Location = new System.Drawing.Point(246, 242);
            this.btn_Further.Name = "btn_Further";
            this.btn_Further.Size = new System.Drawing.Size(75, 23);
            this.btn_Further.TabIndex = 1;
            this.btn_Further.Text = "Далее";
            this.btn_Further.UseVisualStyleBackColor = true;
            this.btn_Further.Click += new System.EventHandler(this.btn_Further_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(327, 242);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Enabled = false;
            this.btn_Back.Location = new System.Drawing.Point(165, 242);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Назад";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // tb_Name_Srvice
            // 
            this.tb_Name_Srvice.Enabled = false;
            this.tb_Name_Srvice.Location = new System.Drawing.Point(125, 97);
            this.tb_Name_Srvice.Name = "tb_Name_Srvice";
            this.tb_Name_Srvice.Size = new System.Drawing.Size(145, 20);
            this.tb_Name_Srvice.TabIndex = 4;
            this.tb_Name_Srvice.Visible = false;
            this.tb_Name_Srvice.Leave += new System.EventHandler(this.tb_Name_Srvice_Leave);
            // 
            // tb_Addres_Service
            // 
            this.tb_Addres_Service.Enabled = false;
            this.tb_Addres_Service.Location = new System.Drawing.Point(125, 136);
            this.tb_Addres_Service.Name = "tb_Addres_Service";
            this.tb_Addres_Service.Size = new System.Drawing.Size(145, 20);
            this.tb_Addres_Service.TabIndex = 5;
            this.tb_Addres_Service.Visible = false;
            this.tb_Addres_Service.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Addres_Service_KeyPress);
            this.tb_Addres_Service.Leave += new System.EventHandler(this.tb_Addres_Service_Leave);
            // 
            // tb_Phone_Service
            // 
            this.tb_Phone_Service.Enabled = false;
            this.tb_Phone_Service.Location = new System.Drawing.Point(125, 175);
            this.tb_Phone_Service.Name = "tb_Phone_Service";
            this.tb_Phone_Service.Size = new System.Drawing.Size(145, 20);
            this.tb_Phone_Service.TabIndex = 6;
            this.tb_Phone_Service.Visible = false;
            this.tb_Phone_Service.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Phone_Service_KeyPress);
            this.tb_Phone_Service.Leave += new System.EventHandler(this.tb_Phone_Service_Leave);
            // 
            // l_Input_Text2
            // 
            this.l_Input_Text2.AutoSize = true;
            this.l_Input_Text2.Enabled = false;
            this.l_Input_Text2.Location = new System.Drawing.Point(122, 120);
            this.l_Input_Text2.Name = "l_Input_Text2";
            this.l_Input_Text2.Size = new System.Drawing.Size(130, 13);
            this.l_Input_Text2.TabIndex = 7;
            this.l_Input_Text2.Text = "Введите адрес сервиса:";
            this.l_Input_Text2.Visible = false;
            // 
            // l_Input_Text3
            // 
            this.l_Input_Text3.AutoSize = true;
            this.l_Input_Text3.Enabled = false;
            this.l_Input_Text3.Location = new System.Drawing.Point(122, 159);
            this.l_Input_Text3.Name = "l_Input_Text3";
            this.l_Input_Text3.Size = new System.Drawing.Size(143, 13);
            this.l_Input_Text3.TabIndex = 8;
            this.l_Input_Text3.Text = "Введите телефон сервиса:";
            this.l_Input_Text3.Visible = false;
            // 
            // l_Input_Text1
            // 
            this.l_Input_Text1.AutoSize = true;
            this.l_Input_Text1.Enabled = false;
            this.l_Input_Text1.Location = new System.Drawing.Point(122, 81);
            this.l_Input_Text1.Name = "l_Input_Text1";
            this.l_Input_Text1.Size = new System.Drawing.Size(148, 13);
            this.l_Input_Text1.TabIndex = 9;
            this.l_Input_Text1.Text = "Введите название сервиса:";
            this.l_Input_Text1.Visible = false;
            // 
            // l_Warning1
            // 
            this.l_Warning1.AutoSize = true;
            this.l_Warning1.ForeColor = System.Drawing.Color.Red;
            this.l_Warning1.Location = new System.Drawing.Point(276, 100);
            this.l_Warning1.Name = "l_Warning1";
            this.l_Warning1.Size = new System.Drawing.Size(16, 13);
            this.l_Warning1.TabIndex = 10;
            this.l_Warning1.Text = "!!!";
            this.l_Warning1.Visible = false;
            // 
            // l_Warning2
            // 
            this.l_Warning2.AutoSize = true;
            this.l_Warning2.ForeColor = System.Drawing.Color.Red;
            this.l_Warning2.Location = new System.Drawing.Point(276, 139);
            this.l_Warning2.Name = "l_Warning2";
            this.l_Warning2.Size = new System.Drawing.Size(16, 13);
            this.l_Warning2.TabIndex = 11;
            this.l_Warning2.Text = "!!!";
            this.l_Warning2.Visible = false;
            // 
            // l_Warning3
            // 
            this.l_Warning3.AutoSize = true;
            this.l_Warning3.ForeColor = System.Drawing.Color.Red;
            this.l_Warning3.Location = new System.Drawing.Point(276, 178);
            this.l_Warning3.Name = "l_Warning3";
            this.l_Warning3.Size = new System.Drawing.Size(16, 13);
            this.l_Warning3.TabIndex = 12;
            this.l_Warning3.Text = "!!!";
            this.l_Warning3.Visible = false;
            // 
            // l_Text2
            // 
            this.l_Text2.AutoSize = true;
            this.l_Text2.Location = new System.Drawing.Point(94, 26);
            this.l_Text2.Name = "l_Text2";
            this.l_Text2.Size = new System.Drawing.Size(227, 13);
            this.l_Text2.TabIndex = 13;
            this.l_Text2.Text = "Введите основную информацию о сервисе.\r\n";
            this.l_Text2.Visible = false;
            // 
            // Initial_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 277);
            this.Controls.Add(this.l_Text2);
            this.Controls.Add(this.l_Warning3);
            this.Controls.Add(this.l_Warning2);
            this.Controls.Add(this.l_Warning1);
            this.Controls.Add(this.l_Input_Text1);
            this.Controls.Add(this.l_Input_Text3);
            this.Controls.Add(this.l_Input_Text2);
            this.Controls.Add(this.tb_Phone_Service);
            this.Controls.Add(this.tb_Addres_Service);
            this.Controls.Add(this.tb_Name_Srvice);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Further);
            this.Controls.Add(this.l_Text1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Initial_Setup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Initial_Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Text1;
        private System.Windows.Forms.Button btn_Further;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox tb_Name_Srvice;
        private System.Windows.Forms.TextBox tb_Addres_Service;
        private System.Windows.Forms.TextBox tb_Phone_Service;
        private System.Windows.Forms.Label l_Input_Text2;
        private System.Windows.Forms.Label l_Input_Text3;
        private System.Windows.Forms.Label l_Input_Text1;
        private System.Windows.Forms.Label l_Warning1;
        private System.Windows.Forms.Label l_Warning2;
        private System.Windows.Forms.Label l_Warning3;
        private System.Windows.Forms.Label l_Text2;
    }
}