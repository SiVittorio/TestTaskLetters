using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTaskLetters.Models;

namespace TestTaskLetters.Controllers
{
    public class OrganisationController : IFormGetController<Organisation>
    {
        public async Task<IEnumerable<Organisation>> GetAllAsync()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    List<Organisation> organisation = new List<Organisation>();
                    SqlCommand command = new SqlCommand("select * from Organisations", connection);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        for (int i = 0; await reader.ReadAsync(); i++)
                        {
                            organisation.Add(new Organisation(
                                reader.GetInt32(0),
                                reader.GetString(1)));

                        }
                    }
                    return organisation;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<Organisation>();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public async Task<Organisation> GetAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    Organisation organisation = null;
                    SqlCommand command = new SqlCommand($"select * from Organisations where Id = {id}", connection);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            organisation = new Organisation(
                                reader.GetInt32(0),
                                reader.GetString(1));
                        }
                        else
                        {
                            MessageBox.Show("Не удалось получить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return organisation;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new Organisation();
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
