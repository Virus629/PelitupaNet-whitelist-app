namespace PelitupaWhitelisterUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.steamIdText = new System.Windows.Forms.Label();
            this.isVipText = new System.Windows.Forms.Label();
            this.isVipCheckBox = new System.Windows.Forms.CheckBox();
            this.steamIdTextBox = new System.Windows.Forms.TextBox();
            this.whitelistPlayer = new System.Windows.Forms.Button();
            this.serverLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.serverLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // steamIdText
            // 
            this.steamIdText.AutoSize = true;
            this.steamIdText.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steamIdText.Location = new System.Drawing.Point(12, 122);
            this.steamIdText.Name = "steamIdText";
            this.steamIdText.Size = new System.Drawing.Size(288, 17);
            this.steamIdText.TabIndex = 0;
            this.steamIdText.Text = "User steam hexID (11000010a7857c5):";
            // 
            // isVipText
            // 
            this.isVipText.AutoSize = true;
            this.isVipText.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isVipText.Location = new System.Drawing.Point(12, 181);
            this.isVipText.Name = "isVipText";
            this.isVipText.Size = new System.Drawing.Size(104, 17);
            this.isVipText.TabIndex = 1;
            this.isVipText.Text = "Is user vip:";
            // 
            // isVipCheckBox
            // 
            this.isVipCheckBox.AutoSize = true;
            this.isVipCheckBox.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isVipCheckBox.Location = new System.Drawing.Point(122, 184);
            this.isVipCheckBox.Name = "isVipCheckBox";
            this.isVipCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isVipCheckBox.TabIndex = 2;
            this.isVipCheckBox.UseVisualStyleBackColor = true;
            this.isVipCheckBox.CheckedChanged += new System.EventHandler(this.isVipCheckBox_CheckedChanged);
            // 
            // steamIdTextBox
            // 
            this.steamIdTextBox.Location = new System.Drawing.Point(314, 121);
            this.steamIdTextBox.Name = "steamIdTextBox";
            this.steamIdTextBox.Size = new System.Drawing.Size(155, 20);
            this.steamIdTextBox.TabIndex = 3;
            this.steamIdTextBox.TextChanged += new System.EventHandler(this.steamIdTextBox_TextChanged);
            // 
            // whitelistPlayer
            // 
            this.whitelistPlayer.Location = new System.Drawing.Point(15, 270);
            this.whitelistPlayer.Name = "whitelistPlayer";
            this.whitelistPlayer.Size = new System.Drawing.Size(454, 43);
            this.whitelistPlayer.TabIndex = 4;
            this.whitelistPlayer.Text = "Whitelist Player";
            this.whitelistPlayer.UseVisualStyleBackColor = true;
            this.whitelistPlayer.Click += new System.EventHandler(this.whitelistPlayer_Click);
            // 
            // serverLogo
            // 
            this.serverLogo.Image = ((System.Drawing.Image)(resources.GetObject("serverLogo.Image")));
            this.serverLogo.Location = new System.Drawing.Point(15, 12);
            this.serverLogo.Name = "serverLogo";
            this.serverLogo.Size = new System.Drawing.Size(96, 107);
            this.serverLogo.TabIndex = 5;
            this.serverLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 327);
            this.Controls.Add(this.serverLogo);
            this.Controls.Add(this.whitelistPlayer);
            this.Controls.Add(this.steamIdTextBox);
            this.Controls.Add(this.isVipCheckBox);
            this.Controls.Add(this.isVipText);
            this.Controls.Add(this.steamIdText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PelitupaNet - Admin Tools | Whitelister";
            ((System.ComponentModel.ISupportInitialize)(this.serverLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label steamIdText;
        private System.Windows.Forms.Label isVipText;
        private System.Windows.Forms.CheckBox isVipCheckBox;
        private System.Windows.Forms.TextBox steamIdTextBox;
        private System.Windows.Forms.Button whitelistPlayer;
        private System.Windows.Forms.PictureBox serverLogo;
    }
}

