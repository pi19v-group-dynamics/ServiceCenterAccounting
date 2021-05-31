using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Win32;
using System.IO;

namespace ServiceCenterAccounting
{
    public partial class Reports_Creator : Form
    {
        string Counter;
        string Sum;
        PdfPCell cell;
        string LoadSQL;
        public Reports_Creator()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IntervalBox.SelectedItem.ToString() == "За определённый промежуток")
            {
                label2.Visible = true;
                label3.Visible = true;
                IntervalTo.Visible = true;
                IntervalAfter.Visible = true;
            }
            else {
                label2.Visible = true;
                IntervalTo.Visible = true;
            }
        }
        private void LoadTable() {
            switch (IntervalBox.SelectedItem.ToString()) {
                case "За месяц":
                    LoadSQL = "select distinct workers.id_worker as ID,workers.last_name_worker as \"Фамилия работника\"," +
                    "workers.first_name_worker as \"Имя работника\",workers.middle_name_worker as \"Отчество работника\"," +
                    "(select count(*)from orders where id_worker = workers.id_worker)" +
                    "as \"Кол-во выполненных заказов\",(select sum(price) from orders where id_worker = workers.id_worker) as \"Общая стоимость заказов\"," +
                    "(select sum(cost_of_parts) from orders where id_worker=workers.id_worker) as \"Стоимость запчастей для заказов\"," +
                    "((select sum(price/25)from orders where id_worker = workers.id_worker)/interest_rate) as \"Зарплата сотрудника\"" +
                    $" from workers, orders where EXTRACT(YEAR from date_of_completion)={IntervalTo.Value.Year} and EXTRACT(MONTH from date_of_completion)={IntervalTo.Value.Month} ; ";
                    Counter = $"select count(*) from orders where EXTRACT(YEAR from date_of_completion)={IntervalTo.Value.Year} and EXTRACT(MONTH from date_of_completion)={IntervalTo.Value.Month} ;";
                    Sum = $"select sum(orders.price-(orders.cost_of_parts+((orders.price/25)/" +
                        $"(select interest_rate from workers where workers.id_worker=orders.id_worker)))) " +
                        $" from orders where EXTRACT(YEAR from date_of_completion)={IntervalTo.Value.Year} and EXTRACT(MONTH from date_of_completion)={IntervalTo.Value.Month} ";
                    break;
                case "За год":
                    LoadSQL = "select distinct workers.id_worker as ID,workers.last_name_worker as \"Фамилия работника\"," +
                    "workers.first_name_worker as \"Имя работника\",workers.middle_name_worker as \"Отчество работника\"," +
                    "(select count(*)from orders where id_worker = workers.id_worker)" +
                    "as \"Кол-во выполненных заказов\",(select sum(price) from orders where id_worker = workers.id_worker) as \"Общая стоимость заказов\"," +
                    "(select sum(cost_of_parts) from orders where id_worker=workers.id_worker) as \"Стоимость запчастей для заказов\"," +
                    "((select sum(price/25)from orders where id_worker = workers.id_worker)/interest_rate) as \"Зарплата сотрудника\"" +
                    $" from workers, orders where EXTRACT(YEAR from date_of_completion)={IntervalTo.Value.Year} ; ";
                    Counter = $"select count(*) from orders where EXTRACT(YEAR from date_of_completion)={IntervalTo.Value.Year} ;";
                    Sum = $"select sum(orders.price-(orders.cost_of_parts+((orders.price/25)/" +
                        $"(select interest_rate from workers where workers.id_worker=orders.id_worker)))) " +
                        $" from orders where EXTRACT(YEAR from date_of_completion)={IntervalTo.Value.Year} ";
                    break;

            }
            ReportTable.DataSource = Connect.Select(LoadSQL);
            OrdersCount.Text = Connect.GetString(Counter);
            Earnings.Text = Connect.GetString(Sum);

        }
        private void Reports_Creator_Load(object sender, EventArgs e)
        {

        }

        private void IntervalAfter_CloseUp(object sender, EventArgs e)
        {
            LoadSQL = "select distinct workers.id_worker as ID,workers.last_name_worker as \"Фамилия работника\"," +
            "workers.first_name_worker as \"Имя работника\",workers.middle_name_worker as \"Отчество работника\"," +
            "(select count(*)from orders where id_worker = workers.id_worker) as \"Количество выполненных заказов\"," +
            "(select sum(price) from orders where id_worker = workers.id_worker) as \"Общая стоимость заказов\"," +
            "(select sum(cost_of_parts) from orders where id_worker=workers.id_worker) as \"Стоимость запчастей для заказов\"," +
            "((select sum(price/25)from orders where id_worker = workers.id_worker)/interest_rate) as \"Зарплата сотрудника\"" +
            $" from workers, orders where orders.date_of_completion between date('{IntervalTo.Value.Date.ToString("yyyy-MM-dd")}') and date('{IntervalAfter.Value.Date.ToString("yyyy-MM-dd")}')";
            Counter = $"select count(*) from orders where date_of_completion between date('{IntervalTo.Value.Date.ToString("yyyy-MM-dd")}') and date('{IntervalAfter.Value.Date.ToString("yyyy-MM-dd")}')";
            Sum = $"select sum(orders.price-(orders.cost_of_parts+((orders.price/25)/" +
            $"(select interest_rate from workers where workers.id_worker=orders.id_worker)))) " +
             $" from orders where date_of_completion between date('{IntervalTo.Value.Date.ToString("yyyy-MM-dd")}') and date('{IntervalAfter.Value.Date.ToString("yyyy-MM-dd")}')";
            LoadTable();
        }

        private void IntervalTo_CloseUp(object sender, EventArgs e)
        {
            if (IntervalBox.SelectedItem.ToString() == "За определённый промежуток") { return; }
            LoadTable();
        }

        private void Save_to_PDF_Click(object sender, EventArgs e)
        {
            if (ReportTable.RowCount == 0) { MessageBox.Show("Отсутствуют данные за выбранный период!"); }
            else
            {
                RegistryKey currentUserKey = Registry.CurrentUser;
                string[] sub_keys = currentUserKey.GetSubKeyNames();
                PdfPTable pdfTable = new PdfPTable(ReportTable.ColumnCount);
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
                    cell.Colspan = 8;
                    cell.HorizontalAlignment = 1;
                    cell.Border = 0;
                    pdfTable.AddCell(cell);
                    cell = new PdfPCell(new Phrase($" ", font1));
                    cell.Colspan = 8;
                    cell.HorizontalAlignment = 1;
                    cell.Border = 0;
                    pdfTable.AddCell(cell);
                }
                for (int i = 0; i < ReportTable.ColumnCount; i++)
                {
                    cell = new PdfPCell(new Phrase(ReportTable.Columns[i].HeaderText, font));
                    cell.BackgroundColor = new BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }
                for (int i = 0; i < ReportTable.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < ReportTable.Rows[i].Cells.Count; j++)
                    {
                        pdfTable.AddCell(new Phrase(ReportTable.Rows[i].Cells[j].Value.ToString(), font));
                    }
                }
                cell = new PdfPCell(new Phrase($" ", font1));
                cell.Colspan = 8;
                cell.HorizontalAlignment = 1;
                cell.Border = 0;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Phrase(label4.Text + "=" + OrdersCount.Text, font1));
                cell.Colspan = 8;
                cell.HorizontalAlignment = 0;
                cell.Border = 0;
                pdfTable.AddCell(cell);
                cell = new PdfPCell(new Phrase(label5.Text + "=" + Earnings.Text, font1));
                cell.Colspan = 8;
                cell.HorizontalAlignment = 0;
                cell.Border = 0;
                pdfTable.AddCell(cell);


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
}
