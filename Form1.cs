using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PelitupaWhitelisterUI
{
    public partial class Form1 : Form
    {

        public static string steamHexId;
        public static bool isVip;

        public Form1()
        {
            InitializeComponent();
        }

        private void steamIdTextBox_TextChanged(object sender, EventArgs e)
        {
            steamHexId = steamIdTextBox.Text; // user input converted to steamHexId
        }

        private void isVipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            isVip = isVipCheckBox.Checked; // user input converted to isVip
        }

        private void whitelistPlayer_Click(object sender, EventArgs e)
        {
            if (steamHexId == null || steamHexId.Count() == 0)
            {
                MessageBox.Show("Steam hexID cannot be empty!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); // HexId is must have
            } else
            {
                Program.Database(steamHexId, isVip); // Sent data to database

                if (isVip == true) {
                    MessageBox.Show("HexID: " + steamHexId + " added to database, with vip status", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Inform hexId and vip status
                    steamIdTextBox.Clear(); // Clear user input after successful database entry
                    isVipCheckBox.Checked = false; // Clear user input after successful database entry
                } else {
                    MessageBox.Show("HexID: " + steamHexId + " added to database, without vip status", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Inform hexId and vip status
                    steamIdTextBox.Clear(); // Clear user input after successful database entry
                }
            }
        }
    }
}
