
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
            this.l_Text3 = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Name_Database = new System.Windows.Forms.TextBox();
            this.l_Input_Text4 = new System.Windows.Forms.Label();
            this.l_Input_Text6 = new System.Windows.Forms.Label();
            this.l_Input_Text5 = new System.Windows.Forms.Label();
            this.l_Warning4 = new System.Windows.Forms.Label();
            this.l_Warning6 = new System.Windows.Forms.Label();
            this.l_Warning5 = new System.Windows.Forms.Label();
            this.dg_Table_Viev = new System.Windows.Forms.DataGridView();
            this.tb_Name_Service = new System.Windows.Forms.TextBox();
            this.l_Input_Text7 = new System.Windows.Forms.Label();
            this.tb_Cost_Service = new System.Windows.Forms.TextBox();
            this.l_Input_Text8 = new System.Windows.Forms.Label();
            this.l_Text4 = new System.Windows.Forms.Label();
            this.l_Warning7 = new System.Windows.Forms.Label();
            this.l_Warning8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Table_Viev)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Text1
            // 
            this.l_Text1.AutoSize = true;
            this.l_Text1.Location = new System.Drawing.Point(64, 87);
            this.l_Text1.Name = "l_Text1";
            this.l_Text1.Size = new System.Drawing.Size(347, 104);
            this.l_Text1.TabIndex = 0;
            this.l_Text1.Text = resources.GetString("l_Text1.Text");
            // 
            // btn_Further
            // 
            this.btn_Further.Location = new System.Drawing.Point(320, 257);
            this.btn_Further.Name = "btn_Further";
            this.btn_Further.Size = new System.Drawing.Size(75, 23);
            this.btn_Further.TabIndex = 1;
            this.btn_Further.Text = "Далее";
            this.btn_Further.UseVisualStyleBackColor = true;
            this.btn_Further.Click += new System.EventHandler(this.btn_Further_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(401, 257);
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
            this.btn_Back.Location = new System.Drawing.Point(239, 257);
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
            this.tb_Name_Srvice.Location = new System.Drawing.Point(165, 116);
            this.tb_Name_Srvice.Name = "tb_Name_Srvice";
            this.tb_Name_Srvice.Size = new System.Drawing.Size(145, 20);
            this.tb_Name_Srvice.TabIndex = 4;
            this.tb_Name_Srvice.Visible = false;
            this.tb_Name_Srvice.Leave += new System.EventHandler(this.tb_Name_Srvice_Leave);
            // 
            // tb_Addres_Service
            // 
            this.tb_Addres_Service.Enabled = false;
            this.tb_Addres_Service.Location = new System.Drawing.Point(165, 155);
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
            this.tb_Phone_Service.Location = new System.Drawing.Point(165, 194);
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
            this.l_Input_Text2.Location = new System.Drawing.Point(162, 139);
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
            this.l_Input_Text3.Location = new System.Drawing.Point(162, 178);
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
            this.l_Input_Text1.Location = new System.Drawing.Point(162, 100);
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
            this.l_Warning1.Location = new System.Drawing.Point(316, 119);
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
            this.l_Warning2.Location = new System.Drawing.Point(316, 158);
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
            this.l_Warning3.Location = new System.Drawing.Point(316, 197);
            this.l_Warning3.Name = "l_Warning3";
            this.l_Warning3.Size = new System.Drawing.Size(16, 13);
            this.l_Warning3.TabIndex = 12;
            this.l_Warning3.Text = "!!!";
            this.l_Warning3.Visible = false;
            // 
            // l_Text2
            // 
            this.l_Text2.AutoSize = true;
            this.l_Text2.Location = new System.Drawing.Point(54, 9);
            this.l_Text2.Name = "l_Text2";
            this.l_Text2.Size = new System.Drawing.Size(376, 91);
            this.l_Text2.TabIndex = 13;
            this.l_Text2.Text = resources.GetString("l_Text2.Text");
            this.l_Text2.Visible = false;
            // 
            // l_Text3
            // 
            this.l_Text3.AutoSize = true;
            this.l_Text3.Location = new System.Drawing.Point(52, 9);
            this.l_Text3.Name = "l_Text3";
            this.l_Text3.Size = new System.Drawing.Size(378, 91);
            this.l_Text3.TabIndex = 14;
            this.l_Text3.Text = resources.GetString("l_Text3.Text");
            this.l_Text3.Visible = false;
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(165, 155);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(170, 20);
            this.tb_Login.TabIndex = 15;
            this.tb_Login.Visible = false;
            this.tb_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Eng_and_Digits_KeyPress);
            this.tb_Login.Leave += new System.EventHandler(this.tb_Login_Leave);
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(165, 194);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(170, 20);
            this.tb_Password.TabIndex = 16;
            this.tb_Password.Visible = false;
            this.tb_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Eng_and_Digits_KeyPress);
            this.tb_Password.Leave += new System.EventHandler(this.tb_Password_Leave);
            // 
            // tb_Name_Database
            // 
            this.tb_Name_Database.Location = new System.Drawing.Point(165, 116);
            this.tb_Name_Database.Name = "tb_Name_Database";
            this.tb_Name_Database.Size = new System.Drawing.Size(170, 20);
            this.tb_Name_Database.TabIndex = 17;
            this.tb_Name_Database.Visible = false;
            this.tb_Name_Database.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Eng_and_Digits_KeyPress);
            this.tb_Name_Database.Leave += new System.EventHandler(this.tb_Name_Database_Leave);
            // 
            // l_Input_Text4
            // 
            this.l_Input_Text4.AutoSize = true;
            this.l_Input_Text4.Location = new System.Drawing.Point(162, 100);
            this.l_Input_Text4.Name = "l_Input_Text4";
            this.l_Input_Text4.Size = new System.Drawing.Size(172, 13);
            this.l_Input_Text4.TabIndex = 18;
            this.l_Input_Text4.Text = "Введите название базы данных:";
            this.l_Input_Text4.Visible = false;
            // 
            // l_Input_Text6
            // 
            this.l_Input_Text6.AutoSize = true;
            this.l_Input_Text6.Location = new System.Drawing.Point(162, 178);
            this.l_Input_Text6.Name = "l_Input_Text6";
            this.l_Input_Text6.Size = new System.Drawing.Size(178, 13);
            this.l_Input_Text6.TabIndex = 19;
            this.l_Input_Text6.Text = "Введите пароль администратора:";
            this.l_Input_Text6.Visible = false;
            // 
            // l_Input_Text5
            // 
            this.l_Input_Text5.AutoSize = true;
            this.l_Input_Text5.Location = new System.Drawing.Point(162, 139);
            this.l_Input_Text5.Name = "l_Input_Text5";
            this.l_Input_Text5.Size = new System.Drawing.Size(173, 13);
            this.l_Input_Text5.TabIndex = 20;
            this.l_Input_Text5.Text = "Введите логин админимтратора:";
            this.l_Input_Text5.Visible = false;
            // 
            // l_Warning4
            // 
            this.l_Warning4.AutoSize = true;
            this.l_Warning4.ForeColor = System.Drawing.Color.Red;
            this.l_Warning4.Location = new System.Drawing.Point(341, 119);
            this.l_Warning4.Name = "l_Warning4";
            this.l_Warning4.Size = new System.Drawing.Size(16, 13);
            this.l_Warning4.TabIndex = 21;
            this.l_Warning4.Text = "!!!";
            this.l_Warning4.Visible = false;
            // 
            // l_Warning6
            // 
            this.l_Warning6.AutoSize = true;
            this.l_Warning6.ForeColor = System.Drawing.Color.Red;
            this.l_Warning6.Location = new System.Drawing.Point(341, 197);
            this.l_Warning6.Name = "l_Warning6";
            this.l_Warning6.Size = new System.Drawing.Size(16, 13);
            this.l_Warning6.TabIndex = 22;
            this.l_Warning6.Text = "!!!";
            this.l_Warning6.Visible = false;
            // 
            // l_Warning5
            // 
            this.l_Warning5.AutoSize = true;
            this.l_Warning5.ForeColor = System.Drawing.Color.Red;
            this.l_Warning5.Location = new System.Drawing.Point(341, 158);
            this.l_Warning5.Name = "l_Warning5";
            this.l_Warning5.Size = new System.Drawing.Size(16, 13);
            this.l_Warning5.TabIndex = 23;
            this.l_Warning5.Text = "!!!";
            this.l_Warning5.Visible = false;
            // 
            // dg_Table_Viev
            // 
            this.dg_Table_Viev.AllowUserToAddRows = false;
            this.dg_Table_Viev.AllowUserToDeleteRows = false;
            this.dg_Table_Viev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Table_Viev.Location = new System.Drawing.Point(12, 119);
            this.dg_Table_Viev.Name = "dg_Table_Viev";
            this.dg_Table_Viev.ReadOnly = true;
            this.dg_Table_Viev.Size = new System.Drawing.Size(464, 132);
            this.dg_Table_Viev.TabIndex = 24;
            this.dg_Table_Viev.Visible = false;
            // 
            // tb_Name_Service
            // 
            this.tb_Name_Service.Location = new System.Drawing.Point(31, 93);
            this.tb_Name_Service.Name = "tb_Name_Service";
            this.tb_Name_Service.Size = new System.Drawing.Size(145, 20);
            this.tb_Name_Service.TabIndex = 25;
            this.tb_Name_Service.Visible = false;
            this.tb_Name_Service.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Addres_Service_KeyPress);
            this.tb_Name_Service.Leave += new System.EventHandler(this.tb_Name_Service_Leave);
            // 
            // l_Input_Text7
            // 
            this.l_Input_Text7.AutoSize = true;
            this.l_Input_Text7.Location = new System.Drawing.Point(28, 77);
            this.l_Input_Text7.Name = "l_Input_Text7";
            this.l_Input_Text7.Size = new System.Drawing.Size(148, 13);
            this.l_Input_Text7.TabIndex = 26;
            this.l_Input_Text7.Text = "Наименование типа услуги:";
            this.l_Input_Text7.Visible = false;
            // 
            // tb_Cost_Service
            // 
            this.tb_Cost_Service.Location = new System.Drawing.Point(331, 93);
            this.tb_Cost_Service.Name = "tb_Cost_Service";
            this.tb_Cost_Service.Size = new System.Drawing.Size(145, 20);
            this.tb_Cost_Service.TabIndex = 27;
            this.tb_Cost_Service.Visible = false;
            this.tb_Cost_Service.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Cost_Service_KeyPress);
            this.tb_Cost_Service.Leave += new System.EventHandler(this.tb_Cost_Service_Leave);
            // 
            // l_Input_Text8
            // 
            this.l_Input_Text8.AutoSize = true;
            this.l_Input_Text8.Location = new System.Drawing.Point(329, 77);
            this.l_Input_Text8.Name = "l_Input_Text8";
            this.l_Input_Text8.Size = new System.Drawing.Size(101, 13);
            this.l_Input_Text8.TabIndex = 28;
            this.l_Input_Text8.Text = "Стоимость услуги:";
            this.l_Input_Text8.Visible = false;
            // 
            // l_Text4
            // 
            this.l_Text4.AutoSize = true;
            this.l_Text4.Location = new System.Drawing.Point(54, 9);
            this.l_Text4.Name = "l_Text4";
            this.l_Text4.Size = new System.Drawing.Size(395, 65);
            this.l_Text4.TabIndex = 29;
            this.l_Text4.Text = resources.GetString("l_Text4.Text");
            this.l_Text4.Visible = false;
            // 
            // l_Warning7
            // 
            this.l_Warning7.AutoSize = true;
            this.l_Warning7.ForeColor = System.Drawing.Color.Red;
            this.l_Warning7.Location = new System.Drawing.Point(182, 96);
            this.l_Warning7.Name = "l_Warning7";
            this.l_Warning7.Size = new System.Drawing.Size(16, 13);
            this.l_Warning7.TabIndex = 30;
            this.l_Warning7.Text = "!!!";
            this.l_Warning7.Visible = false;
            // 
            // l_Warning8
            // 
            this.l_Warning8.AutoSize = true;
            this.l_Warning8.ForeColor = System.Drawing.Color.Red;
            this.l_Warning8.Location = new System.Drawing.Point(309, 96);
            this.l_Warning8.Name = "l_Warning8";
            this.l_Warning8.Size = new System.Drawing.Size(16, 13);
            this.l_Warning8.TabIndex = 31;
            this.l_Warning8.Text = "!!!";
            this.l_Warning8.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Initial_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_Warning8);
            this.Controls.Add(this.l_Warning7);
            this.Controls.Add(this.l_Text4);
            this.Controls.Add(this.l_Input_Text8);
            this.Controls.Add(this.tb_Cost_Service);
            this.Controls.Add(this.l_Input_Text7);
            this.Controls.Add(this.tb_Name_Service);
            this.Controls.Add(this.dg_Table_Viev);
            this.Controls.Add(this.l_Warning5);
            this.Controls.Add(this.l_Warning6);
            this.Controls.Add(this.l_Warning4);
            this.Controls.Add(this.l_Input_Text5);
            this.Controls.Add(this.l_Input_Text6);
            this.Controls.Add(this.l_Input_Text4);
            this.Controls.Add(this.tb_Name_Database);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.l_Text3);
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
            ((System.ComponentModel.ISupportInitialize)(this.dg_Table_Viev)).EndInit();
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
        private System.Windows.Forms.Label l_Text3;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Name_Database;
        private System.Windows.Forms.Label l_Input_Text4;
        private System.Windows.Forms.Label l_Input_Text6;
        private System.Windows.Forms.Label l_Input_Text5;
        private System.Windows.Forms.Label l_Warning4;
        private System.Windows.Forms.Label l_Warning6;
        private System.Windows.Forms.Label l_Warning5;
        private System.Windows.Forms.DataGridView dg_Table_Viev;
        private System.Windows.Forms.TextBox tb_Name_Service;
        private System.Windows.Forms.Label l_Input_Text7;
        private System.Windows.Forms.TextBox tb_Cost_Service;
        private System.Windows.Forms.Label l_Input_Text8;
        private System.Windows.Forms.Label l_Text4;
        private System.Windows.Forms.Label l_Warning7;
        private System.Windows.Forms.Label l_Warning8;
        private System.Windows.Forms.Button button1;
    }
}