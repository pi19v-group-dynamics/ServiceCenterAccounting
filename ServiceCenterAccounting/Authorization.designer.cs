
namespace ServiceCenterAccounting
{
    partial class Authorization
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
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_Warning1 = new System.Windows.Forms.Label();
            this.l_Warning2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(12, 64);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(152, 20);
            this.tb_Password.TabIndex = 1;
            this.tb_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Eng_and_Digits_KeyPress);
            this.tb_Password.Leave += new System.EventHandler(this.tb_Password_Leave);
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(12, 25);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(152, 20);
            this.tb_Login.TabIndex = 2;
            this.tb_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Eng_and_Digits_KeyPress);
            this.tb_Login.Leave += new System.EventHandler(this.tb_Login_Leave);
            // 
            // tb_Enter
            // 
            this.tb_Enter.Location = new System.Drawing.Point(12, 90);
            this.tb_Enter.Name = "tb_Enter";
            this.tb_Enter.Size = new System.Drawing.Size(152, 21);
            this.tb_Enter.TabIndex = 3;
            this.tb_Enter.Text = "Войти";
            this.tb_Enter.UseVisualStyleBackColor = true;
            this.tb_Enter.Click += new System.EventHandler(this.tb_Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // l_Warning1
            // 
            this.l_Warning1.AutoSize = true;
            this.l_Warning1.ForeColor = System.Drawing.Color.Red;
            this.l_Warning1.Location = new System.Drawing.Point(169, 28);
            this.l_Warning1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Warning1.Name = "l_Warning1";
            this.l_Warning1.Size = new System.Drawing.Size(16, 13);
            this.l_Warning1.TabIndex = 23;
            this.l_Warning1.Text = "!!!";
            this.l_Warning1.Visible = false;
            // 
            // l_Warning2
            // 
            this.l_Warning2.AutoSize = true;
            this.l_Warning2.ForeColor = System.Drawing.Color.Red;
            this.l_Warning2.Location = new System.Drawing.Point(169, 67);
            this.l_Warning2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_Warning2.Name = "l_Warning2";
            this.l_Warning2.Size = new System.Drawing.Size(16, 13);
            this.l_Warning2.TabIndex = 24;
            this.l_Warning2.Text = "!!!";
            this.l_Warning2.Visible = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 123);
            this.Controls.Add(this.l_Warning2);
            this.Controls.Add(this.l_Warning1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Enter);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.tb_Password);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.ShowIcon = false;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authorization_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.Button tb_Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_Warning1;
        private System.Windows.Forms.Label l_Warning2;
    }
}