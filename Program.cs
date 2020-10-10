using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;

/* 
 * Made for Fivem server called PelitupaNet
 * 
 * By: Eetu "Virus629" Lauren, 2020
 *
 * SOURCES: 
 * - https://stackoverflow.com/a/16168100
 * - https://en.it1352.com/article/d9f24e041aab4820983d94ae9534d800.html
*/

namespace PelitupaWhitelisterUI
{
    static class Program
    {
        // SSH Settings
        private static readonly string sshServerIp = "SSH_SERVER_IP"; // SSH Server ip
        private static readonly string sshUsername = "SSH_USER"; // SSH Username
        private static readonly string sshPasswd = "SSH_PASSWORD"; // SSH Password

        // MySQL Settings
        private static readonly string dbServerIp = "DB_SERVER_IP"; // Database Ip
        private static readonly string dbUsername = "DB_USER"; // Database Username
        private static readonly string dbPasswd = "DB_PASSWORD"; // Database Password
        private static readonly string dbName = "DB_NAME"; // Database name
        private static readonly uint dbPort = 3306; // Database Port

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void Database(string hexId, bool isVip)
        {
            using (SshClient client = new SshClient(sshServerIp, sshUsername, sshPasswd))
            {
                client.Connect(); // Connect to ssh server

                if (client.IsConnected)
                {
                    var portForwarded = new ForwardedPortLocal("127.0.0.1", 3306, "127.0.0.1", 3306);

                    client.AddForwardedPort(portForwarded);
                    portForwarded.Start();

                    string connString = $"SERVER={dbServerIp};PORT={dbPort};UID={dbUsername};PASSWORD={dbPasswd};DATABASE={dbName}"; // MySQL connection string

                    MySqlConnection conn = new MySqlConnection(connString); // Create new mysql connection
                    conn.Open(); // Open mysql connection

                    MySqlCommand connCmd = conn.CreateCommand();

                    connCmd.CommandText = "INSERT INTO `whitelist`(steamId, isVip) VALUES (@steamId, @isVip)"; // Mysql Query
                    connCmd.Parameters.AddWithValue("@steamId", hexId); // Mysql steamId variable
                    connCmd.Parameters.AddWithValue("@isVip", isVip); // Mysql isVip variable

                    // Console.WriteLine("User " + hexId + " added to database!");  // Nice info to user
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
