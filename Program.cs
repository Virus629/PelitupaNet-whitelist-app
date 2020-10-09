using System;
using Renci.SshNet;
using MySql.Data.MySqlClient;
using System.Globalization;

/* 
 * Made for Fivem server called PelitupaNet
 * 
 * By: Eetu "Virus629" Lauren, 2020
 * 
 * 
 * TODO:
 * - Create Winforms UI
 * - Support to isVip
 * - Sanitize input string (only allow alphabets and numbers)
 * 
 * 
 * SOURCES: 
 * - https://stackoverflow.com/a/16168100
 * - https://en.it1352.com/article/d9f24e041aab4820983d94ae9534d800.html
*/

namespace PelitupaWhitelister
{
    class Program
    {
        // SSH Settings
        private static string serverIp = "SSH_SERVER_IP"; // SSH Server ip
        private static string sshUsername = "SSH_USER"; // SSH Username
        private static string sshPasswd = "SSH_PASSWORD"; // SSH Password

        // MySQL Settings
        private static string dbServerIp = "DB_SERVER_IP"; // Database Ip
        private static string dbUsername = "DB_USER"; // Database Username
        private static string dbPasswd = "DB_PASSWORD"; // Database Password
        private static string dbName = "DB_NAME"; // Database name
        private static uint dbPort = 3306; // Database Port

        public static void Main()
        {
            Console.Write("Write player hexId: ");
            string userInput = Console.ReadLine(); // Read user input
            string playerHexId = userInput.ToLower(new CultureInfo("en-US", false)); // Convert string to lower cases

            DatabaseConnection(playerHexId);
        }

        protected static void DatabaseConnection(string hexId)
        {
            SshClient client = null;
            MySqlConnection conn = null;
            MySqlCommand connCmd = null;

            using (client = new SshClient(serverIp, sshUsername, sshPasswd))
            {
                client.Connect(); // Connect to ssh server

                if (client.IsConnected)
                {
                    var portForwarded = new ForwardedPortLocal("127.0.0.1", 3306, "127.0.0.1", 3306);

                    client.AddForwardedPort(portForwarded);
                    portForwarded.Start();

                    string connString = $"SERVER={dbServerIp};PORT={dbPort};UID={dbUsername};PASSWORD={dbPasswd};DATABASE={dbName}"; // MySQL connection string

                    conn = new MySqlConnection(connString); // Create new mysql connection
                    conn.Open(); // Open mysql connection

                    connCmd = conn.CreateCommand();

                    connCmd.CommandText = "INSERT INTO `whitelist`(steamId) VALUES (@steamId)"; // Mysql Query
                    connCmd.Parameters.AddWithValue("@steamId", hexId); // Mysql query variables

                    Console.WriteLine("User " + hexId + " added to database!");  // Nice info to user
                    connCmd.ExecuteNonQuery(); // Execute sql query

                    conn.Close(); // Close database / ssh connection
                } 
                else
                {
                    Console.WriteLine("Cannot establish mysql connection!"); // Tell user if we cant establish connection to server
                }
            }
        }
    }
}
