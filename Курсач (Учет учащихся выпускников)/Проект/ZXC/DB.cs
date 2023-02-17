using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;


namespace ZXC
{
    public static class DB
    {
        public static string connectionString;
        private static SqlConnection _connection;


        static DB()
        {
            using (StreamReader r = new StreamReader("CONNECTION_STRING.txt", false))
                connectionString = r.ReadToEnd();
            _connection = new SqlConnection(connectionString);
        }


        public static class SELECT
        {
            public static string SpecialityByID(object id)
            {
                string output = "";
                SqlConnection con = new SqlConnection(connectionString);
                string query = $"select Название_специальности from Специальность where Специальность.ID_Специальности = {id}";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    output = reader["Название_специальности"].ToString();
                con.Close();
                return output;
            }
            public static string SredvaByID(object id)
            {
                string output = "";
                SqlConnection con = new SqlConnection(connectionString);
                string query = $"select Вид_средств_обучения from Средства_обучения where Средства_обучения.ID_Средств_обучения = {id}";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    output = reader["Вид_средств_обучения"].ToString();
                con.Close();
                return output;
            }
            public static string YearByID(object id)
            {
                string output = "";
                SqlConnection con = new SqlConnection(connectionString);
                string query = $"select Номер_года from Год_выпуска where Год_выпуска.ID_Года_выпуска = {id}";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    output = reader["Номер_года"].ToString();
                con.Close();
                return output;
            }
            public static string DistByID(object id)
            {
                string output = "";
                SqlConnection con = new SqlConnection(connectionString);
                string query = $"select Название_района from Район where Район.ID_Района = {id}";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    output = reader["Название_района"].ToString();
                con.Close();
                return output;
            }
            public static string OrgByID(object id)
            {
                string output = "";
                SqlConnection con = new SqlConnection(connectionString);
                string query = $"select Наименование from Организация where ID_Организации = {id}";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    output = reader["Наименование"].ToString();
                con.Close();
                return output;
            }
            public static string StudentByID(object id)
            {
                string output = "";
                SqlConnection con = new SqlConnection(connectionString);
                string query = $"select Фамилия, Имя, Отчество from Выпускник where ID_Выпускника = {id}";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    output = reader["Фамилия"].ToString() + ' ' + reader["Имя"].ToString() + ' ' + reader["Отчество"].ToString();
                con.Close();
                return output;
            }
            public static string ZayByID(object id)
            {
                string output = "";
                SqlConnection con = new SqlConnection(connectionString);
                string query = $"select Номер, Должность from Заявка where ID_Заявки = {id}";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    output = "№" + reader["Номер"].ToString() + ", " + reader["Должность"].ToString();
                con.Close();
                return output;
            }
            public static List<string[]> Students()
            {
                List<string[]> output = new List<string[]>();
                string query = "select * from Выпускник";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    output.Add(new string[]
                    {
                        reader["ID_Выпускника"].ToString(),
                        reader["Фамилия"].ToString(),
                        reader["Имя"].ToString(),
                        reader["Отчество"].ToString(),
                        reader["ID_Специальности"].ToString(),
                        SpecialityByID(reader["ID_Специальности"]).ToString(),
                        reader["ID_Средств_обучения"].ToString(),
                        SredvaByID(reader["ID_Средств_обучения"]),
                        reader["ID_Года_выпуска"].ToString(),
                        YearByID(reader["ID_Года_выпуска"]).ToString()
                    });
                }
                _connection.Close();
                return output;
            }
            public static List<string[]> Years()
            {
                List<string[]> output = new List<string[]>();
                string query = "select * from Год_выпуска";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    output.Add(new string[]
                    {
                        reader["ID_Года_выпуска"].ToString(),
                        reader["Номер_года"].ToString()
                    });
                }
                _connection.Close();
                return output;
            }
            public static List<string[]> Speciality()
           {
               List<string[]> output = new List<string[]>();
               string query = "select * from Специальность";
               SqlCommand cmd = new SqlCommand(query, _connection);
               _connection.Open();
               SqlDataReader reader = cmd.ExecuteReader();
               while (reader.Read())
               {
                   output.Add(new string[]
                   {
                       reader["ID_Специальности"].ToString(),
                       reader["Название_специальности"].ToString()
                   });
               }
               _connection.Close();
               return output;
           }
            public static List<string[]> Sredstva()
            {
                List<string[]> output = new List<string[]>();
                string query = "select * from Средства_обучения";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    output.Add(new string[]
                    {
                       reader["ID_Средств_обучения"].ToString(),
                       reader["Вид_средств_обучения"].ToString()
                    });
                }
                _connection.Close();
                return output;
            }
            public static List<string[]> Dist()
            {
                List<string[]> output = new List<string[]>();
                string query = "select * from Район";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    output.Add(new string[]
                    {
                       reader["ID_Района"].ToString(),
                       reader["Название_района"].ToString()
                    });
                }
                _connection.Close();
                return output;
            }
            public static List<string[]> Org()
            {
                List<string[]> output = new List<string[]>();
                string query = "select * from Организация";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    output.Add(new string[]
                    {
                       reader["ID_Организации"].ToString(),
                       reader["Наименование"].ToString(),
                       reader["ID_Района"].ToString(),
                       DistByID(reader["ID_Района"]),
                       reader["Населенный_пункт"].ToString(),
                       reader["Адрес"].ToString()
                    });
                }
                _connection.Close();
                return output;
            }
            public static List<string[]> Zay()
            {
                List<string[]> output = new List<string[]>();
                string query = "select * from Заявка";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    output.Add(new string[]
                    {
                       reader["ID_Заявки"].ToString(),
                       reader["ID_Организации"].ToString(),
                       OrgByID(reader["ID_Организации"]),
                       reader["ID_Специальности"].ToString(),
                       SpecialityByID(reader["ID_Специальности"]),
                       reader["Количество_мест"].ToString(),
                       reader["Должность"].ToString(),
                       reader["Дата"].ToString().Split(' ')[0],
                       reader["Номер"].ToString(),
                       reader["ID_Выпускника"].ToString(),
                       StudentByID(reader["ID_Выпускника"])
                    });
                }
                _connection.Close();
                return output;
            }
            public static List<string[]> Rasp()
            {
                List<string[]> output = new List<string[]>();
                string query = "select * from Распределение";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    output.Add(new string[]
                    {
                       reader["ID_Распределения"].ToString(),
                       reader["ID_Выпускника"].ToString(),
                       StudentByID(reader["ID_Выпускника"]),
                       reader["ID_Заявки"].ToString(),
                       ZayByID(reader["ID_Заявки"]),
                       reader["Дата_получения_направления"].ToString().Split(' ')[0],
                       reader["Куда_прибыл"].ToString(),
                       reader["Когда_прибыл"].ToString().Split(' ')[0],
                       reader["Номер_подтверждения"].ToString()
                    });
                }
                _connection.Close();
                return output;
            }
            public static List<string[]> Rerasp()
            {
                List<string[]> output = new List<string[]>();
                string query = "select * from Перераспределение";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    output.Add(new string[]
                    {
                       reader["ID_Перераспределения"].ToString(),
                       reader["ID_Выпускника"].ToString(),
                       StudentByID(reader["ID_Выпускника"]),
                       reader["ID_Организации"].ToString(),
                       OrgByID(reader["ID_Организации"]),
                       reader["Дата_перераспределения"].ToString().Split(' ')[0],
                       reader["Должность"].ToString(),
                       reader["Номер_подтверждения"].ToString()
                    });
                }
                _connection.Close();
                return output;
            }
        }


        public static class INSERT
        {
            public static void Student(string name, string surname, string secname, object spec, object sred, object year)
            {
                string query = $"insert into Выпускник (Имя, Фамилия, Отчество, ID_Специальности, ID_Средств_обучения, ID_Года_выпуска) values ('{name}', '{surname}', '{secname}', {spec}, {sred}, {year})";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Dist(string name)
            {
                string query = $"insert into Район (Название_района) values ('{name}')";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Spec(string name)
            {
                string query = $"insert into Специальность (Название_специальности) values ('{name}')";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Year(string name)
            {
                string query = $"insert into Год_выпуска (Номер_года) values ('{name}')";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Sred(string name)
            {
                string query = $"insert into Средства_обучения (Вид_средств_обучения) values ('{name}')";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Org(string name, object dist, string place, string addr)
            {
                string query = $"insert into Организация (Наименование, ID_Района, Населенный_пункт, Адрес) values ('{name}', {dist}, '{place}', '{addr}')";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Zay(object org_id, object spec_id, int places, string dolzh, DateTime date, int num, object id_stud)
            {
                string query = $"insert into Заявка(ID_Организации, ID_Специальности, Количество_мест, Должность, Дата, Номер, ID_Выпускника) values({org_id}, {spec_id}, {places}, '{dolzh}', @datee, {num}, {id_stud})";
                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@datee", date);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Rasp(object stud_id, object zay_id, DateTime get_date, string place, DateTime when, string num)
            {
                string query = $"insert into Распределение (ID_Выпускника, ID_Заявки, Дата_получения_направления, Куда_прибыл, Когда_прибыл, Номер_подтверждения) values ({stud_id}, {zay_id}, @get_date, '{place}', @when, '{num}')";
                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@get_date", get_date);
                cmd.Parameters.AddWithValue("@when", when);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Rerasp(object stud_id, object org_id, DateTime get_date, string dolzh, string num)
            {
                string query = $"insert into Перераспределение (ID_Выпускника, ID_Организации, Дата_перераспределения, Должность, Номер_подтверждения) values ({stud_id}, {org_id}, @get_date, '{dolzh}', '{num}')";
                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@get_date", get_date);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
        }


        public static class UPDATE
        {
            public static void Student(object id, string name, string surname, string secname, object spec, object sred, object year)
            {
                string query = $"update Выпускник set Имя = '{name}', Фамилия = '{surname}', Отчество = '{secname}', ID_Специальности = {spec}, ID_Средств_обучения = {sred}, ID_Года_выпуска = {year} where Выпускник.ID_Выпускника = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Dist(object id, string name)
            {
                string query = $"update Район set Название_района = '{name}' where Район.ID_Района = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Spec(object id, string name)
            {
                string query = $"update Специальность set Название_специальности = '{name}' where Специальность.ID_Специальности = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Year(object id, string name)
            {
                string query = $"update Год_выпуска set Номер_года = '{name}' where Год_выпуска.ID_Года_выпуска = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Sred(object id, string name)
            {
                string query = $"update Средства_обучения set Вид_средств_обучения = '{name}' where Средства_обучения.ID_Средств_обучения = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Org(object id, string name, object dist, string place, string addr)
            {
                string query = $"update Организация set Наименование = '{name}', ID_Района = {dist}, Населенный_пункт = '{place}', Адрес = '{addr}' where ID_Организации = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Zay(object id, object org_id, object spec_id, int places, string dolzh, DateTime date, int num, object id_stud)
            {
                string query = $"update Заявка set ID_Организации = {org_id}, ID_Специальности = {spec_id}, Количество_мест = {places}, Должность = '{dolzh}', Дата = @datee, Номер = {num}, ID_Выпускника = {id_stud} where ID_Заявки = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@datee", date);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Rasp(object id, object stud_id, object zay_id, DateTime get_date, string place, DateTime when, string num)
            {
                string query = $"update Распределение set ID_Выпускника = {stud_id}, ID_Заявки = {zay_id}, Дата_получения_направления = @get_date, Куда_прибыл = '{place}', Когда_прибыл = @when, Номер_подтверждения = '{num}' where ID_Распределения = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@get_date", get_date);
                cmd.Parameters.AddWithValue("@when", when);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Rerasp(object id, object stud_id, object org_id, DateTime get_date, string dolzh, string num)
            {
                string query = $"update Перераспределение set ID_Выпускника = {stud_id}, ID_Организации = {org_id}, Дата_перераспределения = @get_date, Должность = '{dolzh}', Номер_подтверждения = '{num}' where ID_Перераспределения = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                cmd.Parameters.AddWithValue("@get_date", get_date);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
        }


        public static class DELETE
        {
            public static void Student(object id)
            {
                string query = $"delete from Выпускник where ID_Выпускника = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Dist(object id)
            {
                string query = $"delete from Район where ID_Района = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Spec(object id)
            {
                string query = $"delete from Специальность where ID_Специальности = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Year(object id)
            {
                string query = $"delete from Год_выпуска where ID_Года_выпуска = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Sred(object id)
            {
                string query = $"delete from Средства_обучения where ID_Средств_обучения = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Org(object id)
            {
                string query = $"delete from Организация where ID_Организации = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Zay(object id)
            {
                string query = $"delete from Заявка where ID_Заявки = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Rasp(object id)
            {
                string query = $"delete from Распределение where ID_Распределения = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
            public static void Rerasp(object id)
            {
                string query = $"delete from Перераспределение where ID_Перераспределения = {id}";
                SqlCommand cmd = new SqlCommand(query, _connection);
                _connection.Open();
                cmd.ExecuteNonQuery();
                _connection.Close();
            }
        }
    }
}