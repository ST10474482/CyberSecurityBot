using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CyberSecurityBot2
{
    public class TaskService
    {
        // =========================
        // DATABASE CONNECTION
        // =========================

        private string connection =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=prog_tasks;Integrated Security=True";

        // =========================
        // TEST CONNECTION
        // =========================

        public bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // =========================
        // ADD TASK
        // =========================

        public void AddTask(string title, string description, DateTime? reminder)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO tasks (title, description, reminder_date, status)
                        VALUES (@title, @description, @reminder, 'Pending')";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = title;
                        cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;

                        cmd.Parameters.Add("@reminder", SqlDbType.DateTime).Value =
                            (object)reminder ?? DBNull.Value;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add task: " + ex.Message);
            }
        }

        // =========================
        // GET ALL TASKS
        // =========================

        public List<TaskItem> GetTasks()
        {
            List<TaskItem> tasks = new List<TaskItem>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string query = @"
                        SELECT id, title, description, status, reminder_date
                        FROM tasks";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tasks.Add(new TaskItem
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Title = reader["title"].ToString(),
                                Description = reader["description"].ToString(),
                                Status = reader["status"].ToString(),
                                ReminderDate = reader["reminder_date"] == DBNull.Value
                                    ? (DateTime?)null
                                    : Convert.ToDateTime(reader["reminder_date"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to load tasks: " + ex.Message);
            }

            return tasks;
        }

        // =========================
        // GET TASK BY ID
        // =========================

        public TaskItem GetTaskById(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string query = @"
                        SELECT id, title, description, status, reminder_date
                        FROM tasks
                        WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new TaskItem
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Title = reader["title"].ToString(),
                                    Description = reader["description"].ToString(),
                                    Status = reader["status"].ToString(),
                                    ReminderDate = reader["reminder_date"] == DBNull.Value
                                     ? (DateTime?)null
                                     : Convert.ToDateTime(reader["reminder_date"])
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to get task: " + ex.Message);
            }

            return null;
        }

        // =========================
        // DELETE TASK
        // =========================

        public void DeleteTask(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string query = "DELETE FROM tasks WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete task: " + ex.Message);
            }
        }

        // =========================
        // COMPLETE TASK
        // =========================

        public void CompleteTask(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string query = @"
                        UPDATE tasks
                        SET status = 'Completed'
                        WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to complete task: " + ex.Message);
            }
        }
    }
}