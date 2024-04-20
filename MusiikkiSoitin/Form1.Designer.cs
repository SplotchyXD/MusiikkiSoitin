namespace MusiikkiSoitin
{
    partial class MusiikkiSoitinApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusiikkiSoitinApp));
            this.Toppanel = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ListMusicList = new System.Windows.Forms.ListBox();
            this.btnValitseMusiikki = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayerMusiikinSoitin = new AxWMPLib.AxWindowsMediaPlayer();
            this.Toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusiikinSoitin)).BeginInit();
            this.SuspendLayout();
            // 
            // Toppanel
            // 
            this.Toppanel.BackColor = System.Drawing.Color.Teal;
            this.Toppanel.Controls.Add(this.button1);
            this.Toppanel.Controls.Add(this.lblName);
            this.Toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Toppanel.Location = new System.Drawing.Point(0, 0);
            this.Toppanel.Name = "Toppanel";
            this.Toppanel.Size = new System.Drawing.Size(851, 68);
            this.Toppanel.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Northstar Super-Italic", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(743, 35);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Splotchys MusicPlayer";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(764, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListMusicList
            // 
            this.ListMusicList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListMusicList.FormattingEnabled = true;
            this.ListMusicList.ItemHeight = 16;
            this.ListMusicList.Location = new System.Drawing.Point(641, 74);
            this.ListMusicList.Name = "ListMusicList";
            this.ListMusicList.Size = new System.Drawing.Size(198, 372);
            this.ListMusicList.TabIndex = 2;
            this.ListMusicList.SelectedIndexChanged += new System.EventHandler(this.ListMusicList_SelectedIndexChanged);
            // 
            // btnValitseMusiikki
            // 
            this.btnValitseMusiikki.BackColor = System.Drawing.Color.Teal;
            this.btnValitseMusiikki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValitseMusiikki.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValitseMusiikki.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnValitseMusiikki.Location = new System.Drawing.Point(641, 452);
            this.btnValitseMusiikki.Name = "btnValitseMusiikki";
            this.btnValitseMusiikki.Size = new System.Drawing.Size(198, 72);
            this.btnValitseMusiikki.TabIndex = 2;
            this.btnValitseMusiikki.Text = "Valitsi Biisit";
            this.btnValitseMusiikki.UseVisualStyleBackColor = false;
            this.btnValitseMusiikki.Click += new System.EventHandler(this.btnValitseMusiikki_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblFooter.Location = new System.Drawing.Point(12, 534);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(92, 13);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "Made by Splotchy";
            // 
            // axWindowsMediaPlayerMusiikinSoitin
            // 
            this.axWindowsMediaPlayerMusiikinSoitin.Enabled = true;
            this.axWindowsMediaPlayerMusiikinSoitin.Location = new System.Drawing.Point(13, 75);
            this.axWindowsMediaPlayerMusiikinSoitin.Name = "axWindowsMediaPlayerMusiikinSoitin";
            this.axWindowsMediaPlayerMusiikinSoitin.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMusiikinSoitin.OcxState")));
            this.axWindowsMediaPlayerMusiikinSoitin.Size = new System.Drawing.Size(622, 449);
            this.axWindowsMediaPlayerMusiikinSoitin.TabIndex = 3;
            // 
            // MusiikkiSoitinApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 556);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.axWindowsMediaPlayerMusiikinSoitin);
            this.Controls.Add(this.btnValitseMusiikki);
            this.Controls.Add(this.ListMusicList);
            this.Controls.Add(this.Toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusiikkiSoitinApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusiikkiSoitinApp";
            this.Toppanel.ResumeLayout(false);
            this.Toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusiikinSoitin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Toppanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox ListMusicList;
        private System.Windows.Forms.Button btnValitseMusiikki;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusiikinSoitin;
        private System.Windows.Forms.Label lblFooter;
    }
}

