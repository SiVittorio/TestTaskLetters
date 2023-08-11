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
    public class DeliveryMethodController : IFormGetController<DeliveryMethod>
    {
        public async Task<IEnumerable<DeliveryMethod>> GetAllAsync()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    List<DeliveryMethod> deliveryMethods = new List<DeliveryMethod>();
                    SqlCommand command = new SqlCommand("select * from DeliveryMethods", connection);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        for (int i = 0; await reader.ReadAsync(); i++)
                        {
                            deliveryMethods.Add(new DeliveryMethod(
                                reader.GetInt32(0),
                                reader.GetString(1)));

                        }
                    }
                    return deliveryMethods;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<DeliveryMethod>();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public async Task<DeliveryMethod> GetAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    DeliveryMethod deliveryMethod = null;
                    SqlCommand command = new SqlCommand($"select * from DeliveryMethods where Id = {id}", connection);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            deliveryMethod = new DeliveryMethod(
                                reader.GetInt32(0),
                                reader.GetString(1));
                        }
                        else
                        {
                            MessageBox.Show("Не удалось получить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return deliveryMethod;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new DeliveryMethod();
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
