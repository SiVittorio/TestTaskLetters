using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTaskLetters.Controllers;
using TestTaskLetters.Models;

namespace TestTaskLetters.Utilities
{
    public static class LettersDataGridViewDataBinder
    {
        public static void LoadToDataGridView(DataGridView table, IEnumerable<BaseLetter> data)
        {
            if (data != null)
            {
                try
                {
                    table.Rows.Clear();
                    table.Columns.Clear();

                    table.Columns.Add("Id", "Id");
                    table.Columns.Add("Name", "Название письма");
                    table.Columns.Add("CreationDate", "Дата создания");
                    table.Columns.Add("Description", "Текст письма");
                    table.Columns[0].Visible = false;

                    foreach (var item in data)
                    {
                        table.Rows.Add();
                        table.Rows[table.Rows.Count - 1].Cells[0].Value = item.Id;
                        table.Rows[table.Rows.Count - 1].Cells[1].Value = item.Name;
                        table.Rows[table.Rows.Count - 1].Cells[2].Value = item.CreatedDate.ToString();
                        table.Rows[table.Rows.Count - 1].Cells[3].Value = item.Subject;
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    
                }
            }
        }

        public static void LoadToDataGridView(DataGridView table, IEnumerable<IncomingLetter> data)
        {
            if (data != null)
            {
                try
                {
                    table.Rows.Clear();
                    table.Columns.Clear();

                    table.Columns.Add("Id", "Id");
                    table.Columns.Add("Name", "Название письма");
                    table.Columns.Add("CreationDate", "Дата создания");
                    table.Columns.Add("Description", "Текст письма");
                    table.Columns[0].Visible = false;

                    foreach (var item in data)
                    {
                        table.Rows.Add();
                        table.Rows[table.Rows.Count - 1].Cells[0].Value = item.Id;
                        table.Rows[table.Rows.Count - 1].Cells[1].Value = item.Name;
                        table.Rows[table.Rows.Count - 1].Cells[2].Value = item.CreatedDate.ToString();
                        table.Rows[table.Rows.Count - 1].Cells[3].Value = item.Subject;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {

                }
            }
        }

        public static void ApplyFilter(DataGridView table, IEnumerable<BaseLetter> data, FilterInfo filter)
        {
            if (filter != null)
            {
                List<BaseLetter> newData = new List<BaseLetter>();
                if (!String.IsNullOrEmpty(filter.FilterName))
                {
                    newData
                        .AddRange(data
                                    .Where(p => p.Name.Contains(filter.FilterName))
                                    .Except(newData));
                }
                if (filter.EndDate.HasValue && filter.BeginDate.HasValue)
                {
                    newData
                        .AddRange(data
                                    .Where(p => (bool)(p.CreatedDate >= filter.BeginDate.Value)
                                        && (bool)(p.CreatedDate <= filter.EndDate.Value))
                                    .Except(newData));
                }
                LoadToDataGridView(table, newData);

            }
            else
            {
                LoadToDataGridView(table, data);
            }
        }

        public static void ApplyFilter(DataGridView table, IEnumerable<IncomingLetter> data, FilterInfo filter)
        {
            if (filter != null)
            {
                if (!String.IsNullOrEmpty(filter.FilterName))
                {
                    data = data.Where(p => p.Name.Contains(filter.FilterName));
                }
                if (filter.EndDate.HasValue && filter.BeginDate.HasValue)
                {
                    data = data.Where(p => (bool)(p.CreatedDate >= filter.BeginDate.Value)
                                        && (bool)(p.CreatedDate <= filter.EndDate.Value));
                }
                if (filter.DeliveryMethodId.HasValue && filter.DeliveryMethodId != 0)
                {
                    data = data.Where(p => p.DeliveryMethodId == filter.DeliveryMethodId);
                }
                if (filter.OrganizationId.HasValue && filter.OrganizationId != 0)
                {
                    data = data.Where(p => p.OrganisationId == filter.OrganizationId);
                }
                LoadToDataGridView(table, data);

            }
            else
            {
                LoadToDataGridView(table, data);
            }
        }
    }
}
