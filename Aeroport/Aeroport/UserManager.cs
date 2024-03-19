using System;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Aeroport
{
    public class UserManager//работа с бд
    {
        private string connectionString =
            "server=127.0.0.1;port=3306;database=aeroport;user=root;password=Plm19941967;";

        private string userTableName = "User";

        public UserManager(string connectionString, string userTableName)
        {
            this.connectionString = connectionString;
            this.userTableName = userTableName;
        }

        public UserManager()
        {

        }

        public void Create(string login, string password, string name,
            string surname, int age, int coin)

        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql =
                $"insert ignore into {userTableName} (login, password, name, surname, age, coin) values ('{login}','{password}','{name}','{surname}','{age}','{coin}')";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();


        }

        public Buyer Get(string login)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"SELECT login, password, name, surname, age, coin " +
                         $"FROM {userTableName} WHERE login = '{login}'";

            MySqlCommand command = new MySqlCommand(sql, connection);

            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            Console.WriteLine(reader.HasRows);
            if (!reader.HasRows)
            {
                return null;
            }
            reader.Read();

            login = reader.GetString(0);
            string pass = reader.GetString(1);
            string name = reader.GetString(2);
            string surname = reader.GetString(3);
            int age = reader.GetInt32(4);
            int coin = reader.GetInt32(5);
            Buyer u = new Buyer(login, pass, name, surname, age, coin);
            reader.Close();
            connection.Close();
            return u;
        }
        public void Delete(string login)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"DELETE FROM {userTableName} WHERE login = '{login}'";
            MySqlCommand command = new MySqlCommand(sql, connection);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void Update(string login, string password, string name,
            string surname, int age, string coin)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"UPDATE {userTableName} SET name = '{name}', " +
                         $"password='{password}', " +
                         $"coin='{coin}', " +
                         $"age='{age}', " +
                         $"surname='{surname}', " + 
                         $"WHERE login = '{login}'";

            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdateName(string login, string name)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"UPDATE {userTableName} SET name = '{name}' WHERE login = '{login}'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UpdateSurname(string login, string surname)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"UPDATE {userTableName} SET surname = '{surname}' WHERE login = '{login}'";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteAll()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = $"DELETE FROM {userTableName}";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        
            

        
    }
}