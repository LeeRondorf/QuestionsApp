﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsApp
{
    class RunSqlCommands
    {
        //make sure to change the data source to your computer
        static string connectionString = @"Data Source=UMC-1040-1147\SQLEXPRESS01;Initial Catalog=QuestionApp;Integrated Security=True";
        SqlConnection con = new SqlConnection(connectionString);

        private bool runCommand(SqlCommand command)
        {
            try
            {
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                //return true;
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        //results.Add(reader[0]);
                        foreach (var res in reader)
                        {
                            
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception err)
            {
                Console.Error.WriteLine(err);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        private bool checkIfExists(string table, string paramToCheck, string text)
        {
            string sql = "SELECT @paramToCheck FROM @table where @paramToCheck = @text";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@paramToCheck", paramToCheck);
            command.Parameters.AddWithValue("@table", table);
            command.Parameters.AddWithValue("@text", text);

            return runCommand(command);
        }

        private int returnIDValue(string table, string idType, int id)
        {
            if (id == -1) //get max id
            {
                string sql = "SELECT COUNT";
                Console.Error.WriteLine("max id= ");
            }
            else //get specified id
            {
                string sql = "SELECT * FROM @table WHERE @idType = @id";
                SqlCommand command = new SqlCommand(sql, con);
                command.Parameters.AddWithValue("@table", table);
                command.Parameters.AddWithValue("@idType", idType);
                command.Parameters.AddWithValue("@id", id);


            }

            return 0;
        }

        public bool login(string username, string password)
        {
            string sql = "SELECT username, password FROM users where username = @username AND password = @password";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);


             return runCommand(command);
        }

        public bool register(string un, string pw, string fn, string mn, string ln, string ad, string city, string state, string pc)
        {
            if (!checkIfExists("users", "username", un)) //checks to see if username already exists. returns false if it does not exist
            {
                //submit user details to database
                string sql = "INSERT INTO users (username,password,first_name,middle_name,last_name,address,city,state_abbr,postal_code)" +
                        "VALUES (@username,@password,@first_name,@middle_name,@last_name,@address,@city,@state,@postal_code)";

                SqlCommand command = new SqlCommand(sql, con);
                //parameterize values for sql query
                command.Parameters.AddWithValue("@username", un);
                command.Parameters.AddWithValue("@password", pw);
                command.Parameters.AddWithValue("@first_name", fn);
                command.Parameters.AddWithValue("@middle_name", mn);
                command.Parameters.AddWithValue("@last_name", ln);
                command.Parameters.AddWithValue("@address", ad);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@state", state);
                command.Parameters.AddWithValue("@postal_code", pc);

                return runCommand(command);
            }
            else
            {
                MessageBox.Show("Username already exists. Enter something else.");
                return false;
            }
        }

        public bool saveQuizData(Quiz quiz)
        {
            string sql = "INSERT INTO quiz (quizName) VALUES (@quizName)";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@quizName", quiz.quizTitle);
            runCommand(command);

            foreach (Question question in quiz.questions)
            {

            }

            return false;
        }
    }
}