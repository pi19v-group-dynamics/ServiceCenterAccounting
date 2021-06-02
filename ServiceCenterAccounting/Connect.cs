﻿using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace ServiceCenterAccounting
{
    class Connect
    {
        static public NpgsqlConnection connection = null;

        public static void OpenConnection(string name, string login, string password)
        {
            string connStr = "Server=localhost;Port=5432;" +
                $"User Id={login};" +
                $"Password={password};" +
                $"Database={name};";
            connection = new NpgsqlConnection(connStr);
        }

        static public DataTable Select(string sql)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        static public string GetString(string sql)
        {
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(sql, connection);
                string result = cmd.ExecuteScalar().ToString();
                return result;
            }
            catch
            {
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
