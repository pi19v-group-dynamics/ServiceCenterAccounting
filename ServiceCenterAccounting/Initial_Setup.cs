using Microsoft.Win32;
using Npgsql;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ServiceCenterAccounting
{
    public partial class Initial_Setup : Form
    {
        NpgsqlConnection Connection;
        Regex Telephone_Check = new Regex(@"^\+?38-?\(?0\d{2}\)?-?\d{3}-?\d{2}-?\d{2}$");
        int counter = 0; 
        bool is_have_name_service = false;
        bool is_have_addres_service = false;
        bool is_have_phone_service = false;
        bool is_have_name_database = false;
        bool is_have_login_admin = false;
        bool is_have_password_admin = false;
        bool is_have_repeat_password = false;

        public Initial_Setup()
        {
            InitializeComponent();
        }

        private void btn_Further_Click(object sender, EventArgs e)
        {
            switch(counter)
            {
                case 0:
                    {
                        counter++;
                        btn_Back.Enabled = true;
                        l_Text1.Visible = false;
                        l_Text2.Visible = true;
                        l_Input_Text1.Visible = true;
                        l_Input_Text2.Visible = true;
                        l_Input_Text3.Visible = true;
                        tb_Addres_Service.Visible = true;
                        tb_Name_Srvice.Visible = true;
                        tb_Phone_Service.Visible = true;
                        l_Text2.Enabled = true;
                        l_Input_Text1.Enabled = true;
                        l_Input_Text2.Enabled = true;
                        l_Input_Text3.Enabled = true;
                        tb_Addres_Service.Enabled = true;
                        tb_Name_Srvice.Enabled = true;
                        tb_Phone_Service.Enabled = true;
                        break;
                    }
                case 1:
                    {
                        if(is_have_name_service & is_have_addres_service & is_have_phone_service)
                        {
                            counter++;
                            RegistryKey currentUserKey = Registry.CurrentUser;
                            RegistryKey SCA_Key = currentUserKey.CreateSubKey("SCA_Key");
                            SCA_Key.SetValue("name_srvice", tb_Name_Srvice.Text);
                            SCA_Key.SetValue("addres_service", tb_Addres_Service.Text);
                            SCA_Key.SetValue("phone_service", tb_Phone_Service.Text);
                            l_Text2.Visible = false;
                            l_Input_Text1.Visible = false;
                            l_Input_Text2.Visible = false;
                            l_Input_Text3.Visible = false;
                            tb_Addres_Service.Visible = false;
                            tb_Name_Srvice.Visible = false;
                            tb_Phone_Service.Visible = false;
                            l_Text3.Visible = true;
                            l_Input_Text4.Visible = true;
                            l_Input_Text5.Visible = true;
                            l_Input_Text6.Visible = true;
                            l_Input_Text7.Visible = true;
                            tb_Name_Database.Visible = true;
                            tb_Password.Visible = true;
                            tb_Login.Visible = true;
                            tb_Password_Repeat.Visible = true;
                            l_Text3.Enabled = true;
                            l_Input_Text4.Enabled = true;
                            l_Input_Text5.Enabled = true;
                            l_Input_Text6.Enabled = true;
                            l_Input_Text7.Enabled = true;
                            tb_Name_Database.Enabled = true;
                            tb_Password.Enabled = true;
                            tb_Login.Enabled = true;
                            tb_Password_Repeat.Enabled = true;
                        }
                        else
                        {
                            if (!is_have_name_service)
                            {
                                MessageBox.Show(
                                            $"Заполните название видеосалона!\nПоля доступные для заполнения не могут содержать только пробелы!",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
                            }
                            if (!is_have_addres_service)
                            {
                                MessageBox.Show(
                                            $"Заполните адрес!\nАдрес не может содержать только цифры и не может начинаться со спецсимволов\n" +
                                            $"Поля доступные для заполнения не могут содержать только пробелы!",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
                            }
                            if (!is_have_phone_service)
                            {
                                MessageBox.Show(
                                            $"Заполните телефонный номер!\nТелефонный номер должен иметь вид:\n" +
                                            $" 38071XXXXXXX\n+38071XXXXXXX\n+38-071-XXX-XX-XX\n+38(071)-XXX-XX-XX\n" +
                                            $"Поля доступные для заполнения не могут содержать только пробелы!",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        if(is_have_name_database & is_have_login_admin & is_have_password_admin & is_have_repeat_password)
                        {
                            counter++;
                            RegistryKey currentUserKey = Registry.CurrentUser;
                            RegistryKey SCA_Key = currentUserKey.CreateSubKey("SCA_Key");
                            SCA_Key.SetValue("name_database", tb_Name_Database.Text);
                            l_Text3.Visible = false;
                            is_have_name_database = false;
                            is_have_login_admin = false;
                            is_have_password_admin = false;
                            is_have_repeat_password = false;
                            l_Input_Text4.Visible = false;
                            tb_Name_Database.Visible = false;
                            l_Text4.Visible = true;
                            l_Text4.Enabled = true;
                            l_Input_Text5.Text = "Введите логин опратора:";
                            l_Input_Text6.Text = "Введите пароль опратора:";
                            l_Input_Text7.Text = "Повторите пароль опратора:";
                            CreateDatabase(tb_Password.Text.ToString(), tb_Login.Text.ToString());
                            tb_Password_Repeat.Text = "";
                            tb_Login.Text = "";
                            tb_Password.Text = "";
                        }
                        else
                        {
                            if (!is_have_name_database)
                            {
                                MessageBox.Show(
                                            $"Заполните название базы данных!\nПоля доступные для заполнения не могут содержать только пробелы!",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
                            }
                            if (!is_have_login_admin)
                            {
                                MessageBox.Show(
                                            $"Заполните логин администратора!\n" +
                                            $"Поля доступные для заполнения не могут содержать только пробелы!",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
                            }
                            if (!is_have_password_admin)
                            {
                                MessageBox.Show(
                                            $"Заполните пароль администратора!\n" +
                                            $"Поля доступные для заполнения не могут содержать только пробелы!",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
                            }
                            if (!is_have_repeat_password)
                            {
                                MessageBox.Show(
                                            $"Пароли не совпадают!\n",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        if (is_have_login_admin & is_have_password_admin & is_have_repeat_password)
                        {
                            counter++;
                            RegistryKey currentUserKey = Registry.CurrentUser;
                            RegistryKey SCA_Key = currentUserKey.CreateSubKey("SCA_Key");
                            SCA_Key.SetValue("login_op", tb_Login.Text);
                            l_Text4.Visible = false;
                            l_Input_Text4.Visible = false;
                            l_Input_Text5.Visible = false;
                            l_Input_Text6.Visible = false;
                            l_Input_Text7.Visible = false;
                            tb_Name_Database.Visible = false;
                            tb_Password.Visible = false;
                            tb_Login.Visible = false;
                            tb_Password_Repeat.Visible = false;
                            btn_Back.Visible = false;
                            btn_Cancel.Text = "Закрыть";
                            btn_Further.Text = "Готово";
                            l_Text5.Visible = true;
                            l_Text5.Enabled = true;
                            Create_Operator(tb_Password.Text.ToString(), tb_Login.Text.ToString());
                        }
                        else
                        {
                            if (!is_have_login_admin)
                            {
                                MessageBox.Show(
                                            $"Заполните пароль опратора!\n" +
                                            $"Поля доступные для заполнения не могут содержать только пробелы!",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
                            }
                            if (!is_have_password_admin)
                            {
                                MessageBox.Show(
                                            $"Пароли не совпадают!\n",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
                            }
                            if (!is_have_repeat_password)
                            {
                                MessageBox.Show(
                                            $"Пароли не совпадают!\n",
                                            "Ошибка",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error
                                            );
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        this.Close();
                        break;
                    }
            }
        }

        private void tb_Name_Srvice_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Name_Srvice.Text) || tb_Name_Srvice.Text.StartsWith(" "))
            {
                l_Warning1.Visible = true;
                is_have_name_service = false;
            }
            else
            {
                is_have_name_service = true;
                l_Warning1.Visible = false;
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            switch (counter)
            {
                case 1:
                    {
                        counter--;
                        btn_Back.Enabled = false;
                        l_Text1.Visible = true;
                        l_Input_Text1.Enabled = true;
                        l_Text2.Visible = false;
                        l_Input_Text1.Visible = false;
                        l_Input_Text2.Visible = false;
                        l_Input_Text3.Visible = false;
                        tb_Addres_Service.Visible = false;
                        tb_Name_Srvice.Visible = false;
                        tb_Phone_Service.Visible = false;
                        l_Warning1.Visible = false;
                        l_Warning2.Visible = false;
                        l_Warning3.Visible = false;
                        break;
                    }
                case 2:
                    {
                        counter--;
                        l_Text2.Visible = true;
                        l_Input_Text1.Visible = true;
                        l_Input_Text2.Visible = true;
                        l_Input_Text3.Visible = true;
                        tb_Addres_Service.Visible = true;
                        tb_Name_Srvice.Visible = true;
                        tb_Phone_Service.Visible = true;
                        l_Text3.Visible = false;
                        l_Input_Text4.Visible = false;
                        l_Input_Text5.Visible = false;
                        l_Input_Text6.Visible = false;
                        l_Input_Text7.Visible = false;
                        tb_Name_Database.Visible = false;
                        tb_Password.Visible = false;
                        tb_Login.Visible = false;
                        tb_Password_Repeat.Visible = false;
                        break;
                    }
                case 3:
                    {
                        counter--;
                        l_Text3.Visible = true;
                        l_Input_Text4.Visible = true;
                        l_Input_Text5.Visible = true;
                        l_Input_Text6.Visible = true;
                        l_Input_Text7.Visible = true;
                        tb_Name_Database.Visible = true;
                        tb_Password.Visible = true;
                        tb_Login.Visible = true;
                        tb_Password_Repeat.Visible = true;
                        is_have_name_database = false;
                        is_have_login_admin = false;
                        is_have_password_admin = false;
                        is_have_repeat_password = false;
                        l_Text4.Visible = false;
                        l_Input_Text5.Text = "Введите логин администратора:";
                        l_Input_Text6.Text = "Введите пароль администратора:";
                        l_Input_Text7.Text = "Повторите пароль администратора:";
                        tb_Name_Database.Text = "";
                        tb_Password_Repeat.Text = "";
                        tb_Login.Text = "";
                        tb_Password.Text = "";
                        break;
                    }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tb_Addres_Service_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && (number < 0x0410 || number > 0x044F) && number != 8 && number != 0x0027 
                && number != 1101 && number != 1025 && number != 1105 && number != 1069 && number != 1098 && number != 1066 
                && number != 45 && number != 96 && number != 32 && number != 44 && number != 46 && number != 47)
            {
                e.Handled = true;
            }
        }

        private void tb_Phone_Service_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45 && number != 43 && number != 40 && number != 41)
            {
                e.Handled = true;
            }
        }

        private void tb_Addres_Service_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Addres_Service.Text) || DigitsOnly(tb_Addres_Service.Text) ||
                tb_Addres_Service.Text.StartsWith("-") | tb_Addres_Service.Text.StartsWith("`") | tb_Addres_Service.Text.StartsWith("'")
                || tb_Addres_Service.Text.StartsWith(" ") || tb_Addres_Service.Text.StartsWith(".") || tb_Addres_Service.Text.StartsWith(",")
                || tb_Addres_Service.Text.StartsWith("/"))
            {
                l_Warning2.Visible = true;
                is_have_addres_service = false;
            }
            else
            {
                is_have_addres_service = true;
                l_Warning2.Visible = false;
            }
        }

        private void tb_Phone_Service_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Phone_Service.Text) || !Telephone_Check.IsMatch(tb_Phone_Service.Text) || tb_Phone_Service.Text.StartsWith(" ") 
                || tb_Phone_Service.Text.StartsWith("-"))
            {
                l_Warning3.Visible = true;
                is_have_phone_service = false;
            }
            else
            {
                is_have_phone_service = true;
                l_Warning3.Visible = false;
            }
        }

        private bool DigitsOnly(string s)
        {
            int len = s.Length;
            for (int i = 0; i < len; ++i)
            {
                char c = s[i];
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private void Eng_and_Digits_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void tb_Name_Database_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Name_Database.Text) || tb_Name_Database.Text.StartsWith(" "))
            {
                l_Warning4.Visible = true;
                is_have_name_database = false;
            }
            else
            {
                is_have_name_database = true;
                l_Warning4.Visible = false;
            }
        }

        private void tb_Login_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Login.Text) || tb_Login.Text.StartsWith(" "))
            {
                l_Warning5.Visible = true;
                is_have_login_admin = false;
            }
            else
            {
                is_have_login_admin = true;
                l_Warning5.Visible = false;
            }
        }

        private void tb_Password_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Password.Text) || tb_Password.Text.StartsWith(" "))
            {
                l_Warning6.Visible = true;
                is_have_password_admin = false;
            }
            else
            {
                is_have_password_admin = true;
                l_Warning6.Visible = false;
            }
        }

        private void CreateDatabase(string password, string login)
        {
            string log = "postgres";
            string pass = "1234";
            string ConnectionString = $"Server=127.0.0.1;Port=5432;User Id={log};Password={pass};Timeout=180;Command Timeout=180";
            Connection = new NpgsqlConnection(ConnectionString);
            try
            {
                Connection.Open();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Неверный ввод названия базы данных!", "Ошибка подключения к БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            pass = "";
            log = "";
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey SCA_Key = currentUserKey.OpenSubKey("SCA_Key");
            string name_database = SCA_Key.GetValue("name_database").ToString();
            try
            {
                NpgsqlCommand Command = new NpgsqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.Text;
                Command.CommandText = $"CREATE DATABASE \"{name_database}\" " + 
                    "WITH " +
                    "OWNER = \"postgres\" " + 
                    "ENCODING = 'UTF8' " +
                    "LC_COLLATE = 'Russian_Russia.1251' " +
                    "LC_CTYPE = 'Russian_Russia.1251' " +
                    "TABLESPACE = pg_default;";
                NpgsqlDataReader DataReader = Command.ExecuteReader();
                Command.Dispose();
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            try
            {
                Connection.Open();
                NpgsqlCommand Command = new NpgsqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.Text;
                Command.CommandText = $"CREATE ROLE \"{login}\" CREATEDB CREATEROLE LOGIN PASSWORD '{password}'; " +
                    $"GRANT Connect, Create ON DATABASE \"{name_database}\" TO \"{login}\";";
                NpgsqlDataReader DataReader = Command.ExecuteReader();
                Command.Dispose();
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            ConnectionString = $"Server=127.0.0.1;Port=5432;User Id={login};Password={password}; Database={name_database};Timeout=180;Command Timeout=180";
            Connection = new NpgsqlConnection(ConnectionString);
            try
            {
                Connection.Open();
                NpgsqlCommand Command = new NpgsqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.Text;
                Command.CommandText = $"CREATE TABLE public.stages_of_execution " +
                    "( "+
                        "id_stage_of_execution serial NOT NULL, " +
                        "name_stage_of_execution character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "CONSTRAINT \"stages _of_execution_pkey\" PRIMARY KEY(id_stage_of_execution), " +
                        "CONSTRAINT \"stages _of_execution_id_stage_of_execution_key\" UNIQUE(id_stage_of_execution), " +
                        "CONSTRAINT \"stages _of_execution_name_stage_of_execution_key\" UNIQUE(name_stage_of_execution) " +
                    ") " +
                    "TABLESPACE pg_default; " +
                    "ALTER TABLE public.stages_of_execution " +
                        $"OWNER to {login}; " +
                    $"CREATE TABLE public.stationary_computers " +
                    "( " +
                        "id_stationary_computer serial NOT NULL, " +
                        "motherboard character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "cpu character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "gpu character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "power_supply character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "number_of_drives integer NOT NULL, " +
                        "total_drives_capacity integer NOT NULL, " +
                        "cpu_cooling character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "additional_devices text COLLATE pg_catalog.\"default\", " +
                        "ram character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "ram_capacity integer NOT NULL, " +
                        "CONSTRAINT stationary_computers_pkey PRIMARY KEY(id_stationary_computer) " +
                    ") " +
                    "TABLESPACE pg_default; " +
                    "ALTER TABLE public.stationary_computers " +
                        $"OWNER to {login}; " +
                    $"CREATE TABLE public.types_of_device " +
                    "( "+
                        "id_type_of_device serial NOT NULL, " +
                        "type_of_device character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "name_table character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "CONSTRAINT types_of_device_pkey PRIMARY KEY(id_type_of_device), " + 
                        "CONSTRAINT types_of_device_id_type_of_device_key UNIQUE(id_type_of_device), " +
                        "CONSTRAINT types_of_device_name_table_key UNIQUE(name_table), " +
                        "CONSTRAINT types_of_device_type_of_device_key UNIQUE(type_of_device) " +
                    ") " +
                    "TABLESPACE pg_default; " +
                    "ALTER TABLE public.types_of_device " +
                        $"OWNER to {login}; " +
                    $"CREATE TABLE public.types_of_service " +
                    "( " +
                        "id_type_of_service serial NOT NULL, " +
                        "name_type_of_service character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "cost_of_service real NOT NULL, " +
                        "CONSTRAINT types_of_service_pkey PRIMARY KEY(id_type_of_service), " +
                        "CONSTRAINT types_of_service_name_type_of_service_key UNIQUE(name_type_of_service) " +
                    ") " +
                    "TABLESPACE pg_default; " +
                    "ALTER TABLE public.types_of_service " +
                        $"OWNER to {login}; " +
                    $"CREATE TABLE public.workers " +
                    "( " +
                        "id_worker serial NOT NULL, " +
                        "last_name_worker character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "first_name_worker character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "middle_name_worker character varying(255) COLLATE pg_catalog.\"default\", " +
                        "interest_rate integer NOT NULL, " +
                        "employment boolean NOT NULL, " +
                        "CONSTRAINT workers_pkey PRIMARY KEY(id_worker), " +
                        "CONSTRAINT workers_id_worker_key UNIQUE(id_worker) " +
                    ") " +
                    "TABLESPACE pg_default; " +
                    "ALTER TABLE public.workers " +
                        $"OWNER to {login}; " +
                    $"CREATE TABLE public.clients" +
                    "( "+
                        "id_client serial NOT NULL, " +
                        "last_name_client character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "first_name_client character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "middle_name_client character varying(255) COLLATE pg_catalog.\"default\", " +
                        "passport_series character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "phone character varying(255) COLLATE pg_catalog.\"default\" NOT NULL," +
                        "CONSTRAINT clients_pkey PRIMARY KEY(id_client), " +
                        "CONSTRAINT clients_id_client_key UNIQUE(id_client), " +
                        "CONSTRAINT clients_passport_series_key UNIQUE(passport_series), " +
                        "CONSTRAINT clients_phone_key UNIQUE(phone) " +
                    ")" +
                    "TABLESPACE pg_default; " +
                    "ALTER TABLE public.clients " +
                        $"OWNER to {login}; " +
                    "CREATE TABLE public.component_or_other_device_types " +
                    "(" +
                        "id_component_or_other_device_type serial NOT NULL, " +
                        "name_component_or_other_device_type character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "CONSTRAINT component_types_pkey PRIMARY KEY(id_component_or_other_device_type), " +
                        "CONSTRAINT component_types_id_component_type_key UNIQUE(id_component_or_other_device_type), " +
                        "CONSTRAINT component_types_name_component_type_key UNIQUE(name_component_or_other_device_type) " +
                        ") " +
                    "TABLESPACE pg_default; " +
                    "ALTER TABLE public.component_or_other_device_types " +
                        $"OWNER to {login}; " +
                    "CREATE TABLE public.components_or_other_devices " +
                    "( " +
                        "id_component_or_other_devices serial NOT NULL, " +
                        "id_component_type integer NOT NULL, " +
                        "manufacturer character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "model character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "CONSTRAINT components_or_other_devices_pkey PRIMARY KEY(id_component_or_other_devices), " +
                        "CONSTRAINT components_or_other_devices_id_component_or_other_devices_key UNIQUE(id_component_or_other_devices), " +
                        "CONSTRAINT components_or_other_devices_id_component_type_fkey FOREIGN KEY(id_component_type) " +
                        "REFERENCES public.component_or_other_device_types(id_component_or_other_device_type) MATCH SIMPLE " +
                            "ON UPDATE NO ACTION " +
                            "ON DELETE CASCADE " +
                    ") " +
                    "TABLESPACE pg_default; " +
                    "ALTER TABLE public.components_or_other_devices " +
                        $"OWNER to {login}; " +
                    "CREATE TABLE public.laptops_and_monoblocks " +
                    "( " +
                        "id_laptop_or_monoblock serial NOT NULL, " +
                        "manufacturer character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "model character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "cpu character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "ram character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "ram_capacity integer NOT NULL, " +
                        "number_of_drives integer NOT NULL, " +
                        "total_drives_capacity integer NOT NULL, " +
                        "CONSTRAINT laptops_and_monoblocks_pkey PRIMARY KEY(id_laptop_or_monoblock) " +
                    ") " +
                    "TABLESPACE pg_default; " +
                    "ALTER TABLE public.laptops_and_monoblocks " +
                        $"OWNER to {login}; " +
                    "CREATE TABLE public.orders " +
                    "( " +
                        "id_orders serial NOT NULL, " +
                        "id_client integer NOT NULL, " +
                        "id_worker integer, " +
                        "date_of_adoption date NOT NULL, " +
                        "date_of_completion date, " +
                        "customer_comment text COLLATE pg_catalog.\"default\", " +
                        "id_stage_of_execution integer NOT NULL, " +
                        "id_type_of_service integer NOT NULL, " +
                        "cost_of_parts real, " +
                        "price real, " +
                        "CONSTRAINT orders_pkey PRIMARY KEY(id_orders), " +
                        "CONSTRAINT orders_id_client_fkey FOREIGN KEY(id_client) " +
                        "REFERENCES public.clients(id_client) MATCH SIMPLE " + 
                            "ON UPDATE NO ACTION " +
                            "ON DELETE CASCADE, " +
                        "CONSTRAINT orders_id_stage_of_execution_fkey FOREIGN KEY(id_stage_of_execution) " +
                        "REFERENCES public.stages_of_execution(id_stage_of_execution) MATCH SIMPLE " +
                            "ON UPDATE NO ACTION " +
                            "ON DELETE CASCADE, " +
                        "CONSTRAINT orders_id_type_of_service_fkey FOREIGN KEY(id_type_of_service) " +
                        "REFERENCES public.types_of_service(id_type_of_service) MATCH SIMPLE " +
                            "ON UPDATE NO ACTION " +
                            "ON DELETE CASCADE, " +
                        "CONSTRAINT orders_id_worker_fkey FOREIGN KEY(id_worker) " +
                        "REFERENCES public.workers(id_worker) MATCH SIMPLE " +
                            "ON UPDATE NO ACTION " +
                            "ON DELETE CASCADE " +
                    ") " +
                    "TABLESPACE pg_default; " +
                    "ALTER TABLE public.orders " +
                        $"OWNER to {login}; " +
                    "CREATE TABLE public.orders_and_devices " +
                    "( " +
                        "id_order_and_device serial NOT NULL, " +
                        "id_order integer NOT NULL, " +
                        "id_type_of_device integer NOT NULL, " +
                        "id_specific_device integer NOT NULL, " +
                        "CONSTRAINT orders_and_devices_pkey PRIMARY KEY(id_order_and_device), " + 
                        "CONSTRAINT orders_and_devices_id_order_fkey FOREIGN KEY(id_order) " +
                        "REFERENCES public.orders(id_orders) MATCH SIMPLE " +
                            "ON UPDATE NO ACTION " +
                            "ON DELETE CASCADE, " +
                        "CONSTRAINT orders_and_devices_id_type_of_device_fkey FOREIGN KEY(id_type_of_device) " +
                        "REFERENCES public.types_of_device(id_type_of_device) MATCH SIMPLE " +
                            "ON UPDATE NO ACTION " +
                            "ON DELETE CASCADE " +
                    ") " +
                    "TABLESPACE pg_default; " +
                    "ALTER TABLE public.orders_and_devices " +
                        $"OWNER to {login}; " +
                    "CREATE TABLE public.smartphones " +
                    "( " +
                        "id_smartphone serial NOT NULL, " +
                        "manufacturer character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "model character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "imei character varying(255) COLLATE pg_catalog.\"default\" NOT NULL, " +
                        "CONSTRAINT smartphones_pkey PRIMARY KEY(id_smartphone), " +
                        "CONSTRAINT smartphones_imei_key UNIQUE(imei) " +
                    ") " +
                    "TABLESPACE pg_default; " +
                    "ALTER TABLE public.smartphones " +
                        $"OWNER to {login}; ";
                NpgsqlDataReader DataReader = Command.ExecuteReader();
                Command.Dispose();
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
            try
            {
                Connection.Open();
                NpgsqlCommand Command = new NpgsqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.Text;
                Command.CommandText = $"INSERT INTO stages_of_execution (name_stage_of_execution) VALUES " +
                    $"('Принятый заказ'), " +
                    $"('Заказ в работе'), " +
                    $"('Завершенный заказ'); " +
                    $"INSERT INTO types_of_device (type_of_device, name_table) VALUES " +
                    $"('Смартфоны', 'smartphones'), " +
                    $"('Стационарные компьютеры', 'stationary_computers'), " +
                    $"('Ноутбуки и моноблоки', 'laptops_and_monoblocks'), " +
                    $"('Компоненты и другие устройства', 'components_or_other_devices');" +
                    $"INSERT INTO component_or_other_device_types (name_component_or_other_device_type) VALUES " +
                    $"('Другое'); ";
                NpgsqlDataReader DataReader = Command.ExecuteReader();
                Command.Dispose();
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
        }

        private void tb_Password_Repeat_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Password_Repeat.Text) || tb_Password_Repeat.Text.StartsWith(" ") || !(tb_Password_Repeat.Text.Equals(tb_Password.Text)))
            {
                l_Warning7.Visible = true;
                is_have_repeat_password = false;
            }
            else
            {
                is_have_repeat_password = true;
                l_Warning7.Visible = false;
            }
        }

        private void Create_Operator(string password, string login)
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey SCA_Key = currentUserKey.OpenSubKey("SCA_Key");
            string name_database = SCA_Key.GetValue("name_database").ToString();
            try
            {
                Connection.Open();
                NpgsqlCommand Command = new NpgsqlCommand();
                Command.Connection = Connection;
                Command.CommandType = CommandType.Text;
                Command.CommandText = $"CREATE ROLE \"{login}\" CREATEDB CREATEROLE LOGIN PASSWORD '{password}'; " +
                    $"GRANT Connect ON DATABASE \"{name_database}\" TO \"{login}\"; " +
                    $"GRANT Create, Usage ON SCHEMA \"public\" TO \"{login}\"; " +
                    $"GRANT Delete, Insert, References, Select, Trigger, Truncate, Update ON TABLE \"public\".\"clients\" TO \"{login}\"; " +
                    $"GRANT Delete, Insert, References, Select, Trigger, Truncate, Update ON TABLE \"public\".\"components_or_other_devices\" TO \"{login}\"; " +
                    $"GRANT Delete, Insert, References, Select, Trigger, Truncate, Update ON TABLE \"public\".\"laptops_and_monoblocks\" TO \"{login}\"; " +
                    $"GRANT Delete, Insert, References, Select, Trigger, Truncate, Update ON TABLE \"public\".\"orders\" TO \"{login}\"; " + 
                    $"GRANT Delete, Insert, References, Select, Trigger, Truncate, Update ON TABLE \"public\".\"orders_and_devices\" TO \"{login}\"; " + 
                    $"GRANT Delete, Insert, References, Select, Trigger, Truncate, Update ON TABLE \"public\".\"smartphones\" TO \"{login}\"; " +
                    $"GRANT Delete, Insert, References, Select, Trigger, Truncate, Update ON TABLE \"public\".\"stationary_computers\" TO \"{login}\";" +
                    $"GRANT Select ON TABLE \"public\".\"component_or_other_device_types\" TO \"{login}\"; " +
                    $"GRANT Select ON TABLE \"public\".\"stages_of_execution\" TO \"{login}\"; " +
                    $"GRANT Select ON TABLE \"public\".\"types_of_device\" TO \"{login}\"; " +
                    $"GRANT Select ON TABLE \"public\".\"types_of_service\" TO \"{login}\"; " +
                    $"GRANT Select ON TABLE \"public\".\"workers\" TO \"{login}\";"; 
                NpgsqlDataReader DataReader = Command.ExecuteReader();
                Command.Dispose();
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Connection.Close();
            }
        }
    }
}
