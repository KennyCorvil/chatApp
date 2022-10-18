namespace lmitp
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
            this.panelside = new System.Windows.Forms.Panel();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.panelheader = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panelMid = new System.Windows.Forms.Panel();
            this.borderLeft = new System.Windows.Forms.Panel();
            this.borderTop = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnTeam = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnemp = new System.Windows.Forms.Button();
            this.btndashbaord = new System.Windows.Forms.Button();
            this.btnminimize = new System.Windows.Forms.Button();
            this.btnmaximize = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.panelside.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.panelheader.SuspendLayout();
            this.borderTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelside.Controls.Add(this.btnCalendar);
            this.panelside.Controls.Add(this.btnTeam);
            this.panelside.Controls.Add(this.pnlProfile);
            this.panelside.Controls.Add(this.btnSettings);
            this.panelside.Controls.Add(this.btnMessage);
            this.panelside.Controls.Add(this.btnemp);
            this.panelside.Controls.Add(this.btndashbaord);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 48);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(200, 543);
            this.panelside.TabIndex = 0;
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.lblUserName);
            this.pnlProfile.Controls.Add(this.pictureBox1);
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfile.Location = new System.Drawing.Point(0, 0);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(200, 174);
            this.pnlProfile.TabIndex = 5;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelheader.Controls.Add(this.borderTop);
            this.panelheader.Controls.Add(this.btnminimize);
            this.panelheader.Controls.Add(this.btnmaximize);
            this.panelheader.Controls.Add(this.txtSearch);
            this.panelheader.Controls.Add(this.btnclose);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1150, 48);
            this.panelheader.TabIndex = 1;
            this.panelheader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panelheader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSearch.Location = new System.Drawing.Point(415, 12);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(321, 25);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Text = "  Search for something...\r\n";
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.mainpanel.Location = new System.Drawing.Point(200, 48);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(950, 543);
            this.mainpanel.TabIndex = 2;
            // 
            // panelMid
            // 
            this.panelMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMid.Location = new System.Drawing.Point(200, 48);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(0, 543);
            this.panelMid.TabIndex = 3;
            // 
            // borderLeft
            // 
            this.borderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.borderLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.borderLeft.Location = new System.Drawing.Point(199, 48);
            this.borderLeft.Name = "borderLeft";
            this.borderLeft.Size = new System.Drawing.Size(1, 543);
            this.borderLeft.TabIndex = 4;
            // 
            // borderTop
            // 
            this.borderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.borderTop.Controls.Add(this.textBox1);
            this.borderTop.Controls.Add(this.button1);
            this.borderTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderTop.Location = new System.Drawing.Point(0, 47);
            this.borderTop.Name = "borderTop";
            this.borderTop.Size = new System.Drawing.Size(1150, 1);
            this.borderTop.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBox1.Location = new System.Drawing.Point(415, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 25);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "  Search for something...\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1108, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblUserName.Location = new System.Drawing.Point(23, 118);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(147, 16);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "Firstname Lastname";
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCalendar.Image = global::lmitp.Properties.Resources.calendar;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(0, 324);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(200, 30);
            this.btnCalendar.TabIndex = 7;
            this.btnCalendar.Text = "CALENDAR";
            this.btnCalendar.UseVisualStyleBackColor = false;
            // 
            // btnTeam
            // 
            this.btnTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTeam.FlatAppearance.BorderSize = 0;
            this.btnTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeam.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTeam.Image = global::lmitp.Properties.Resources.people;
            this.btnTeam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeam.Location = new System.Drawing.Point(0, 288);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Size = new System.Drawing.Size(200, 30);
            this.btnTeam.TabIndex = 6;
            this.btnTeam.Text = "TEAM";
            this.btnTeam.UseVisualStyleBackColor = false;
            this.btnTeam.Click += new System.EventHandler(this.btnTeam_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lmitp.Properties.Resources.icons8_test_account_96;
            this.pictureBox1.Location = new System.Drawing.Point(44, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = global::lmitp.Properties.Resources.settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 478);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(200, 65);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMessage
            // 
            this.btnMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMessage.FlatAppearance.BorderSize = 0;
            this.btnMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMessage.Image = global::lmitp.Properties.Resources.chat;
            this.btnMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMessage.Location = new System.Drawing.Point(0, 252);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(200, 30);
            this.btnMessage.TabIndex = 2;
            this.btnMessage.Text = "MESSAGES";
            this.btnMessage.UseVisualStyleBackColor = false;
            this.btnMessage.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btnemp
            // 
            this.btnemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnemp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnemp.FlatAppearance.BorderSize = 0;
            this.btnemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnemp.Image = global::lmitp.Properties.Resources.Conact;
            this.btnemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnemp.Location = new System.Drawing.Point(0, 216);
            this.btnemp.Name = "btnemp";
            this.btnemp.Size = new System.Drawing.Size(200, 30);
            this.btnemp.TabIndex = 1;
            this.btnemp.Text = "PEOPLE";
            this.btnemp.UseVisualStyleBackColor = false;
            this.btnemp.Click += new System.EventHandler(this.btnemp_Click);
            // 
            // btndashbaord
            // 
            this.btndashbaord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btndashbaord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndashbaord.FlatAppearance.BorderSize = 0;
            this.btndashbaord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashbaord.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashbaord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btndashbaord.Image = global::lmitp.Properties.Resources.home;
            this.btndashbaord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashbaord.Location = new System.Drawing.Point(0, 180);
            this.btndashbaord.Name = "btndashbaord";
            this.btndashbaord.Size = new System.Drawing.Size(200, 30);
            this.btndashbaord.TabIndex = 0;
            this.btndashbaord.Text = "DASHBOARD";
            this.btndashbaord.UseVisualStyleBackColor = false;
            this.btndashbaord.Click += new System.EventHandler(this.btndashbaord_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimize.ForeColor = System.Drawing.Color.White;
            this.btnminimize.Image = global::lmitp.Properties.Resources.minimize;
            this.btnminimize.Location = new System.Drawing.Point(1030, 0);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(40, 48);
            this.btnminimize.TabIndex = 15;
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnmaximize
            // 
            this.btnmaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnmaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmaximize.FlatAppearance.BorderSize = 0;
            this.btnmaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaximize.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmaximize.ForeColor = System.Drawing.Color.White;
            this.btnmaximize.Image = global::lmitp.Properties.Resources.maximize;
            this.btnmaximize.Location = new System.Drawing.Point(1070, 0);
            this.btnmaximize.Name = "btnmaximize";
            this.btnmaximize.Size = new System.Drawing.Size(40, 48);
            this.btnmaximize.TabIndex = 14;
            this.btnmaximize.UseVisualStyleBackColor = false;
            this.btnmaximize.Click += new System.EventHandler(this.btnmaximize_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Image = global::lmitp.Properties.Resources.close;
            this.btnclose.Location = new System.Drawing.Point(1110, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(40, 48);
            this.btnclose.TabIndex = 1;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 591);
            this.Controls.Add(this.borderLeft);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelside.ResumeLayout(false);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.borderTop.ResumeLayout(false);
            this.borderTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnemp;
        private System.Windows.Forms.Button btndashbaord;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.Panel borderLeft;
        private System.Windows.Forms.Panel borderTop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnTeam;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnmaximize;
    }
}

