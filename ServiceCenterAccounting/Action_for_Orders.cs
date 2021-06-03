using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Win32;

namespace ServiceCenterAccounting
{
    public partial class Action_for_Orders : Form
    {
        string Id_order;
        bool Previos_Stage;

        public Action_for_Orders(string id_order, bool previos_stage)
        {
            InitializeComponent();
            Id_order = id_order;
            Previos_Stage = previos_stage;
            if(Previos_Stage == true)
            {
                cb_Worker.Visible = true;
                cb_Worker.DataSource = Connect.Select("SELECT id_worker, " +
                    "concat(workers.last_name_worker, ' ', substring(workers.first_name_worker, 1, 1), '. ', substring(workers.middle_name_worker, 1, 1), '. ') " +
                    "AS \"fio\" " +
                    "FROM workers " +
                    "WHERE employment = false");
                cb_Worker.DisplayMember = "fio";
                cb_Worker.ValueMember = "id_worker";
                l_Text1.Text = "Назначте работника:";
                l_Text1.Location = new Point(54, 9);
            }
            else
            {
                nud_Cost_of_Parts.Visible = true;
                nud_Cost_of_Parts.Enabled = true;
                l_Text1.Text = "Введите стоимость запчастей:";
                l_Text1.Location = new Point(37, 9);
            }
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            if (Previos_Stage == true)
            {
                Connect.Select($"UPDATE orders SET id_worker = {cb_Worker.SelectedValue}, id_stage_of_execution = 2 WHERE id_orders = {Id_order};" +
                    $"UPDATE workers SET employment = true WHERE id_worker = {cb_Worker.SelectedValue}");
                this.Close();
            }
            else
            {
                 Connect.Select($"UPDATE orders SET date_of_completion = '{DateTime.Now.ToString("d")}', " +
                     $"id_stage_of_execution = 3, " +
                     $"cost_of_parts = {nud_Cost_of_Parts.Value.ToString().Replace(',', '.')} WHERE id_orders = {Id_order}");
                Create_Receipt(Id_order);
                this.Close();
            }
        }

        private void Create_Receipt(string id_order)
        {
            PdfPCell cell;
            RegistryKey currentUserKey = Registry.CurrentUser;
            string[] sub_keys = currentUserKey.GetSubKeyNames();
            PdfPTable pdfTable = new PdfPTable(8);
            BaseFont baseFont = BaseFont.CreateFont("C:/Windows/Fonts/times.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font font1 = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            font1.Size = 18;
            font.Size = 11;
            pdfTable.DefaultCell.Padding = 10;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            if (sub_keys.Contains("SCA_Key"))
            {
                RegistryKey SCA_Key = currentUserKey.OpenSubKey("SCA_Key");
                cell = new PdfPCell(new Phrase($"Название предприятия: \"{SCA_Key.GetValue("name_srvice").ToString()}\" ", font1));
                cell.Colspan = 8;
                cell.HorizontalAlignment = 1;
                cell.Border = 0;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Phrase($"Адрес: {SCA_Key.GetValue("addres_service").ToString()} ", font1));
                cell.Colspan = 8;
                cell.HorizontalAlignment = 1;
                cell.Border = 0;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Phrase($"Телефон: {SCA_Key.GetValue("phone_service").ToString()} ", font1));
                cell.Colspan = 8; cell.HorizontalAlignment = 1;
                cell.Border = 0;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Phrase($" ", font1));
                cell.Colspan = 8; cell.HorizontalAlignment = 1;
                cell.Border = 0;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Phrase($"Клиент:", font1));
                cell.Colspan = 11; cell.HorizontalAlignment = 0; cell.Border = 0;
                pdfTable.AddCell(cell);
            }
            DataTable table;
            table = Connect.Select($"select clients.last_name_client,clients.first_name_client,clients.middle_name_client,clients.phone " +
            $"from orders inner join clients on(clients.id_client=orders.id_client) where id_orders={id_order}");
            cell = new PdfPCell(new Phrase($"Фамилия: {table.Rows[0][0].ToString()}", font1));
            cell.Colspan = 8; cell.HorizontalAlignment = 0; cell.Border = 0;
            pdfTable.AddCell(cell);
            cell = new PdfPCell(new Phrase($"Имя: {table.Rows[0][1].ToString()}", font1));
            cell.Colspan = 8; cell.HorizontalAlignment = 0; cell.Border = 0;
            pdfTable.AddCell(cell);
            cell = new PdfPCell(new Phrase($"Отчество: {table.Rows[0][2].ToString()}", font1));
            cell.Colspan = 8; cell.HorizontalAlignment = 0; cell.Border = 0;
            pdfTable.AddCell(cell);
            cell = new PdfPCell(new Phrase($"Номер телефона: {table.Rows[0][3].ToString()}", font1));
            cell.Colspan = 8; cell.HorizontalAlignment = 0; cell.Border = 0;
            pdfTable.AddCell(cell);
            cell = new PdfPCell(new Phrase($" ", font1));
            cell.Colspan = 8; cell.HorizontalAlignment = 0; cell.Border = 0;
            pdfTable.AddCell(cell);
            cell = new PdfPCell(new Phrase($"Информация о заказе:", font1));
            cell.Colspan = 8; cell.HorizontalAlignment = 1; cell.Border = 0;
            pdfTable.AddCell(cell);
            table.Clear();
            table = Connect.Select($"SELECT workers.last_name_worker as \"Фамилия работника\",workers.first_name_worker as \"Имя\"," +
            $"workers.middle_name_worker as \"Отчество работника\",date_of_adoption as \"Дата принятия заказа\",date_of_completion " +
            $"as \"Дата завершения заказа\",cost_of_parts as \"Стоимость запчастей\",price as \"Итоговая сумма\" from orders inner " +
            $"join workers on(workers.id_worker=orders.id_worker) where id_orders={id_order}");
            for (int i = 0; i < table.Columns.Count; i++)
            {
                cell = new PdfPCell(new Phrase(table.Columns[i].ColumnName, font));
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    pdfTable.AddCell(new Phrase(table.Rows[i][j].ToString(), font));
                }
            }
            table.Clear();
            cell = new PdfPCell(new Phrase($"Информация об устройстве клиента:", font1));
            cell.Colspan = 8; cell.HorizontalAlignment = 1; cell.Border = 0;
            pdfTable.AddCell(cell);
            int type_of_device = Convert.ToInt32(Connect.GetString($"Select id_type_of_device from orders_and_devices where id_order={id_order}"));
            switch (type_of_device)
            {
                case 1:
                    table = Connect.Select($"select smartphones.manufacturer as \"Производитель\",smartphones.model as \"Модель\",smartphones.imei as " +
                    "IMEI from smartphones inner join orders_and_devices on(smartphones.id_smartphone=orders_and_devices.id_specific_device) " +
                    $"where orders_and_devices.id_order={id_order}"); break;
                case 2:
                    table = Connect.Select("select motherboard as \"Мат.плата\", cpu as \"Процессор\", gpu as \"Видеокарта\", power_supply as \"БП\", " +
                    "number_of_drives as \"Кол - во носителей\", cpu_cooling as \"Охлаждение\", ram as \"ОЗУ\", additional_devices as \"Остальные устройства\" " +
                    "from stationary_computers inner join orders_and_devices on (stationary_computers.id_stationary_computer = orders_and_devices.id_specific_device) " +
                    $"where orders_and_devices.id_order ={id_order}"); break;
                case 3:
                    table = Connect.Select("select manufacturer as \"Производитель\",model as \"Модель\",cpu as \"Процессор\",ram as \"ОЗУ\",number_of_drives as \"Кол - во носителей\" " +
                    "from laptops_and_monoblocks inner join orders_and_devices on(laptops_and_monoblocks.id_laptop_or_monoblock=orders_and_devices.id_specific_device) " +
                    $"where orders_and_devices.id_order={id_order}"); break;
                case 4:
                    table = Connect.Select("Select component_or_other_device_types.name_component_or_other_device_type as \"Тип устройства\",manufacturer as \"Производитель\",model as \"Модель\" " +
             "from components_or_other_devices inner join orders_and_devices on(components_or_other_devices.id_component_or_other_devices=orders_and_devices.id_specific_device) " +
             "inner join component_or_other_device_types on(component_or_other_device_types.id_component_or_other_device_type=components_or_other_devices.id_component_type) " +
             $"where orders_and_devices.id_order={id_order}"); break;
            }
            for (int i = 0; i < table.Columns.Count; i++)
            {
                cell = new PdfPCell(new Phrase(table.Columns[i].ColumnName, font));
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    pdfTable.AddCell(new Phrase(table.Rows[i][j].ToString(), font));
                }
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.ShowDialog();
            using (FileStream stream = new FileStream(dialog.FileName + ".pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
        }
    
    }
}
