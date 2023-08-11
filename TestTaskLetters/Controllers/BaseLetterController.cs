using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTaskLetters.Models;

namespace TestTaskLetters.Controllers
{
    public class BaseLetterController : IFormWriteController<BaseLetter>, IFormGetController<BaseLetter>
    {
        private static SqlGuid _letterGuid = new SqlGuid("D68D99DB-F8A5-414A-93FE-C27FFA74AAF8");
        public BaseLetterController() { }

        public async Task DeleteAsync(int id)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    List<BaseLetter> baseLetters = new List<BaseLetter>();
                    string commandText = $"delete from BaseLetters where Id = @id";
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

        public async Task<IEnumerable<BaseLetter>> GetAllAsync()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    List<BaseLetter> baseLetters = new List<BaseLetter>();
                    SqlCommand command = new SqlCommand("select * from BaseLetters", connection);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        for (int i = 0; await reader.ReadAsync(); i++)
                        {
                            baseLetters.Add(new BaseLetter(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3) ?? null,
                                reader.GetSqlDateTime(4),
                                reader.GetString(5),
                                reader.GetSqlGuid(6)
                                ));

                        }
                    }
                    return baseLetters;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<BaseLetter>();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public async Task<BaseLetter> GetAsync(int id = 1)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    BaseLetter baseLetter = null;
                    SqlCommand command = new SqlCommand($"select * from BaseLetters where Id = {id}", connection);
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            baseLetter = new BaseLetter(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3) ?? null,
                                reader.GetSqlDateTime(4),
                                reader.GetString(5),
                                reader.GetSqlGuid(6)
                                );
                        }
                        else
                        {
                            MessageBox.Show("Не удалось получить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return baseLetter;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new BaseLetter();
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public async Task InsertAsync(BaseLetter data)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    List<BaseLetter> baseLetters = new List<BaseLetter>();
                    string commandText = $"insert into BaseLetters (\"Name\", \"Subject\", \"DocumentNumber\", \"LetterKindGuid\")" +
                        $"values (@Name, @Subject, @DocumentNumber, @LetterKindGuid)";
                    using (SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.AddWithValue("Name", data.Name);
                        command.Parameters.AddWithValue("Subject", data.Subject);
                        command.Parameters.AddWithValue("DocumentNumber", data.DocumentNumber);
                        command.Parameters.AddWithValue("LetterKindGuid", _letterGuid);

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

        public async Task UpdateAsync(BaseLetter data)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    List<BaseLetter> baseLetters = new List<BaseLetter>();
                    string commandText = $"update BaseLetters set \"Name\" = @Name, \"Subject\" = @Subject," +
                        $" \"DocumentNumber\" = @DocumentNumber, \"LetterKindGuid\" = @LetterKindGuid where Id = @Id";
                    using (SqlCommand command = new SqlCommand(commandText, connection))
                    {
                        command.Parameters.AddWithValue("Name", data.Name);
                        command.Parameters.AddWithValue("Subject", data.Subject);
                        command.Parameters.AddWithValue("DocumentNumber", data.DocumentNumber);
                        command.Parameters.AddWithValue("LetterKindGuid", _letterGuid);
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
