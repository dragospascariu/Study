using System.Data.SQLite;
namespace WordPrediction.DbConnection

{
    class DatabaseConnection
    {

        public Array GetPredictionsForWord(string userInput)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            var predictionArray = ReadData(sqlite_conn, userInput);
            return predictionArray;

        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source= Dictionary.db; New = false;");

            try
            {
                sqlite_conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Connection could not be established.");
            }
            return sqlite_conn;
        }



        static Array ReadData(SQLiteConnection conn, string userInput)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"SELECT Value from Words WHERE Words.Value LIKE '{userInput}%'";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            var result = new List<string>();
            while (sqlite_datareader.Read())  
            {
                result.Add(sqlite_datareader.GetString(0));               
            }
            conn.Close();
            return result.ToArray();
        }
    }
}