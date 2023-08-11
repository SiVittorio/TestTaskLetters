using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTaskLetters.Models;

namespace TestTaskLetters.Controllers
{
    public class IncomingLetterController : IFormWriteController<IncomingLetter>, IFormGetController<IncomingLetter>
    {
        private static SqlGuid _letterGuid = new SqlGuid("BF4D19DD-6A58-4D30-8DB2-8E39587FD16A");
        public IncomingLetterController() { }

        public async Task DeleteAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    List<IncomingLetter> baseLetters = new List<IncomingLetter>();
                    string commandText = $"delete from IncomingLetters where Id = @id";
                    using (SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.AddWithValue("id", id);

                        await command.ExecuteNonQueryAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public async Task<IEnumerable<IncomingLetter>> GetAllAsync()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    List<IncomingLetter> incomingLetters = new List<IncomingLetter>();
                    SqlCommand command = new SqlCommand("select * from IncomingLetters", connection);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        for (int i = 0; await reader.ReadAsync(); i++)
                        {
                            incomingLetters.Add(new IncomingLetter(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3) ?? null,
                                reader.GetSqlDateTime(4),
                                reader.GetString(5),
                                reader.GetSqlGuid(6),
                                reader.GetInt32(7),
                                reader.GetInt32(8),
                                reader.GetInt32(9),
                                reader.GetInt32(10)
                                ));

                        }
                    }
                    return incomingLetters;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<IncomingLetter>();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public async Task<IncomingLetter> GetAsync(int id = 1)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    IncomingLetter incomingLetter = null;
                    SqlCommand command = new SqlCommand($"select * from IncomingLetters where Id = {id}", connection);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            incomingLetter = new IncomingLetter(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3) ?? null,
                                reader.GetSqlDateTime(4),
                                reader.GetString(5),
                                reader.GetSqlGuid(6),
                                reader.GetInt32(7),
                                reader.GetInt32(8),
                                reader.GetInt32(9),
                                reader.GetInt32(10)
                                );
                        }
                        else
                        {
                            MessageBox.Show("Не удалось получить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return incomingLetter;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new IncomingLetter();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public async Task InsertAsync(IncomingLetter data)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    List<IncomingLetter> incomingLetters = new List<IncomingLetter>();
                    string commandText = $"insert into IncomingLetters (\"Name\", \"Subject\", \"DocumentNumber\", \"LetterKindGuid\", " +
                        $"\"AddresseeId\", \"DeliveryMethodId\", \"OrganisationId\", \"CounterpartyId\")" +
                        $"values (@Name, @Subject, @DocumentNumber, @LetterKindGuid, @AddresseeId, @DeliveryMethodId, @OrganisationId, @CounterpartyId)";
                    using (SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.AddWithValue("Name", data.Name);
                        command.Parameters.AddWithValue("Subject", data.Subject);
                        command.Parameters.AddWithValue("DocumentNumber", data.DocumentNumber);
                        command.Parameters.AddWithValue("LetterKindGuid", _letterGuid);
                        command.Parameters.AddWithValue("AddresseeId", data.AddresseeId);
                        command.Parameters.AddWithValue("DeliveryMethodId", data.DeliveryMethodId);
                        command.Parameters.AddWithValue("OrganisationId", data.OrganisationId);
                        command.Parameters.AddWithValue("CounterpartyId", data.CounterpartyId);

                        await command.ExecuteNonQueryAsync();
                        MessageBox.Show("Письмо отправлено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public async Task UpdateAsync(IncomingLetter data)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    List<IncomingLetter> incomingLetters = new List<IncomingLetter>();
                    string commandText = $"update IncomingLetters set \"Name\" = @Name, \"Subject\" = @Subject," +
                        $" \"DocumentNumber\" = @DocumentNumber, \"LetterKindGuid\" = @LetterKindGuid," +
                        $"\"AddresseeId\" = @AddresseeId, \"DeliveryMethodId\" = @DeliveryMethodId," +
                        $"\"OrganisationId\" = @OrganisationId, \"CounterpartyId\" = @CounterpartyId where Id = @Id";
                    using (SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.AddWithValue("Name", data.Name);
                        command.Parameters.AddWithValue("Subject", data.Subject);
                        command.Parameters.AddWithValue("DocumentNumber", data.DocumentNumber);
                        command.Parameters.AddWithValue("LetterKindGuid", _letterGuid);
                        command.Parameters.AddWithValue("AddresseeId", data.AddresseeId);
                        command.Parameters.AddWithValue("DeliveryMethodId", data.DeliveryMethodId);
                        command.Parameters.AddWithValue("OrganisationId", data.OrganisationId);
                        command.Parameters.AddWithValue("CounterpartyId", data.CounterpartyId);
                        command.Parameters.AddWithValue("Id", data.Id);

                        await command.ExecuteNonQueryAsync();
                        MessageBox.Show("Письмо изменено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
