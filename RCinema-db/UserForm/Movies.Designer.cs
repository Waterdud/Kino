namespace RCinema_db.User
{
    partial class Movies
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btn_UserProfile = new Button();
            btn_Log_Out = new Button();
            lbl_Movie_Release_Date = new Label();
            txt_Movie_Description = new TextBox();
            lbl_Movie_Duration_Genre = new Label();
            lbl_Movie_Title = new Label();
            picbox_Movie_Poster = new PictureBox();
            lbl_Title = new Label();
            listbox_Movies = new ListBox();
            btn_BuyTicket = new Button();
            ((System.ComponentModel.ISupportInitialize)picbox_Movie_Poster).BeginInit();
            SuspendLayout();
            // 
            // btn_UserProfile
            // 
            btn_UserProfile.Location = new Point(0, 0);
            btn_UserProfile.Name = "btn_UserProfile";
            btn_UserProfile.Size = new Size(75, 23);
            btn_UserProfile.TabIndex = 0;
            // 
            // btn_Log_Out
            // 
            btn_Log_Out.BackColor = Color.Red;
            btn_Log_Out.Font = new Font("Arial", 10F, FontStyle.Bold);
            btn_Log_Out.ForeColor = Color.White;
            btn_Log_Out.Location = new Point(620, 20);
            btn_Log_Out.Name = "btn_Log_Out";
            btn_Log_Out.Size = new Size(100, 30);
            btn_Log_Out.TabIndex = 8;
            btn_Log_Out.Text = "Log Out";
            btn_Log_Out.UseVisualStyleBackColor = false;
            btn_Log_Out.Click += btn_Log_Out_Click;
            // 
            // lbl_Movie_Release_Date
            // 
            lbl_Movie_Release_Date.AutoSize = true;
            lbl_Movie_Release_Date.Font = new Font("Arial", 12F);
            lbl_Movie_Release_Date.Location = new Point(460, 120);
            lbl_Movie_Release_Date.Name = "lbl_Movie_Release_Date";
            lbl_Movie_Release_Date.Size = new Size(0, 18);
            lbl_Movie_Release_Date.TabIndex = 4;
            // 
            // txt_Movie_Description
            // 
            txt_Movie_Description.BackColor = Color.FromArgb(45, 45, 45);
            txt_Movie_Description.BorderStyle = BorderStyle.FixedSingle;
            txt_Movie_Description.Font = new Font("Arial", 10F);
            txt_Movie_Description.ForeColor = Color.White;
            txt_Movie_Description.Location = new Point(460, 198);
            txt_Movie_Description.Multiline = true;
            txt_Movie_Description.Name = "txt_Movie_Description";
            txt_Movie_Description.Size = new Size(300, 100);
            txt_Movie_Description.TabIndex = 6;
            // 
            // lbl_Movie_Duration_Genre
            // 
            lbl_Movie_Duration_Genre.AutoSize = true;
            lbl_Movie_Duration_Genre.Font = new Font("Arial", 12F);
            lbl_Movie_Duration_Genre.Location = new Point(460, 150);
            lbl_Movie_Duration_Genre.Name = "lbl_Movie_Duration_Genre";
            lbl_Movie_Duration_Genre.Size = new Size(0, 18);
            lbl_Movie_Duration_Genre.TabIndex = 5;
            // 
            // lbl_Movie_Title
            // 
            lbl_Movie_Title.AutoSize = true;
            lbl_Movie_Title.Font = new Font("Arial", 16F, FontStyle.Bold);
            lbl_Movie_Title.ForeColor = Color.Cyan;
            lbl_Movie_Title.Location = new Point(460, 80);
            lbl_Movie_Title.Name = "lbl_Movie_Title";
            lbl_Movie_Title.Size = new Size(0, 26);
            lbl_Movie_Title.TabIndex = 3;
            // 
            // picbox_Movie_Poster
            // 
            picbox_Movie_Poster.Location = new Point(250, 68);
            picbox_Movie_Poster.Name = "picbox_Movie_Poster";
            picbox_Movie_Poster.Size = new Size(180, 250);
            picbox_Movie_Poster.SizeMode = PictureBoxSizeMode.Zoom;
            picbox_Movie_Poster.TabIndex = 2;
            picbox_Movie_Poster.TabStop = false;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Arial", 24F, FontStyle.Bold);
            lbl_Title.ForeColor = Color.Orange;
            lbl_Title.Location = new Point(267, 20);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(251, 37);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "Current Movies";
            // 
            // listbox_Movies
            // 
            listbox_Movies.BackColor = Color.FromArgb(45, 45, 45);
            listbox_Movies.Font = new Font("Arial", 12F);
            listbox_Movies.ForeColor = Color.White;
            listbox_Movies.ItemHeight = 18;
            listbox_Movies.Location = new Point(12, 68);
            listbox_Movies.Name = "listbox_Movies";
            listbox_Movies.Size = new Size(220, 292);
            listbox_Movies.TabIndex = 1;
            listbox_Movies.SelectedIndexChanged += listbox_Movies_SelectedIndexChanged_1;
            // 
            // btn_BuyTicket
            // 
            btn_BuyTicket.BackColor = Color.Green;
            btn_BuyTicket.Font = new Font("Arial", 12F, FontStyle.Bold);
            btn_BuyTicket.ForeColor = Color.White;
            btn_BuyTicket.Location = new Point(20, 388);
            btn_BuyTicket.Name = "btn_BuyTicket";
            btn_BuyTicket.Size = new Size(150, 50);
            btn_BuyTicket.TabIndex = 7;
            btn_BuyTicket.Text = "Buy Ticket";
            btn_BuyTicket.UseVisualStyleBackColor = false;
            btn_BuyTicket.Click += btn_BuyTicket_Click;
            // 
            // Movies
            // 
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Title);
            Controls.Add(listbox_Movies);
            Controls.Add(picbox_Movie_Poster);
            Controls.Add(lbl_Movie_Title);
            Controls.Add(lbl_Movie_Release_Date);
            Controls.Add(lbl_Movie_Duration_Genre);
            Controls.Add(txt_Movie_Description);
            Controls.Add(btn_BuyTicket);
            Controls.Add(btn_Log_Out);
            Font = new Font("Arial", 10F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Movies";
            Text = "Movies";
            ((System.ComponentModel.ISupportInitialize)picbox_Movie_Poster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_UserProfile;
        private Button btn_Log_Out;
        private Label lbl_Movie_Release_Date;
        private TextBox txt_Movie_Description;
        private Label lbl_Movie_Duration_Genre;
        private Label lbl_Movie_Title;
        private PictureBox picbox_Movie_Poster;
        private Label lbl_Title;
        private ListBox listbox_Movies;
        private Button btn_BuyTicket;
    }
}
