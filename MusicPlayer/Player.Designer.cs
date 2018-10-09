namespace DarkPlayer
{
    partial class Player
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.PlayBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.ElapsedBar = new System.Windows.Forms.TrackBar();
            this.VolBar = new System.Windows.Forms.TrackBar();
            this.ElapsedLbl = new System.Windows.Forms.Label();
            this.MusicSizeLbl = new System.Windows.Forms.Label();
            this.ElapsedTime = new System.Windows.Forms.Timer(this.components);
            this.MusicNameLbl = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.VolLbl = new System.Windows.Forms.Label();
            this.VolBarTimer = new System.Windows.Forms.Timer(this.components);
            this.MusicControlPanel = new System.Windows.Forms.Panel();
            this.SpeakerPictureBox = new System.Windows.Forms.PictureBox();
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.PlayingNowPanel = new System.Windows.Forms.Panel();
            this.PlayingNowLbl = new System.Windows.Forms.Label();
            this.MinhasMusicasPanel = new System.Windows.Forms.Panel();
            this.MinhasMusicasLbl = new System.Windows.Forms.Label();
            this.PlayingNowFrame = new System.Windows.Forms.Panel();
            this.PlaylistListBox = new System.Windows.Forms.ListBox();
            this.BandInfoPanel = new System.Windows.Forms.Panel();
            this.AlbumImagePicBox = new System.Windows.Forms.PictureBox();
            this.AddToLbl = new System.Windows.Forms.Label();
            this.PlayAllLbl = new System.Windows.Forms.Label();
            this.BandYearLbl = new System.Windows.Forms.Label();
            this.BandNameLbl = new System.Windows.Forms.Label();
            this.BandTypeLbl = new System.Windows.Forms.Label();
            this.BandAlbumLbl = new System.Windows.Forms.Label();
            this.InYourMuicsLbl = new System.Windows.Forms.Label();
            this.MainLibPanel = new System.Windows.Forms.Panel();
            this.BibliotecaLbl = new System.Windows.Forms.Label();
            this.LibraryPanel = new System.Windows.Forms.Panel();
            this.AlbumsFrameLbl = new System.Windows.Forms.Label();
            this.ArtistsFrameLbl = new System.Windows.Forms.Label();
            this.MusicFrameLbl = new System.Windows.Forms.Label();
            this.AlbunsSelected = new System.Windows.Forms.Label();
            this.ArtistasSelected = new System.Windows.Forms.Label();
            this.MusicasSelectedLbl = new System.Windows.Forms.Label();
            this.AlbumListView = new System.Windows.Forms.ListView();
            this.Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArtistsListBox = new System.Windows.Forms.ListBox();
            this.LibraryListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ElapsedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolBar)).BeginInit();
            this.MusicControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeakerPictureBox)).BeginInit();
            this.SideBarPanel.SuspendLayout();
            this.PlayingNowPanel.SuspendLayout();
            this.MinhasMusicasPanel.SuspendLayout();
            this.PlayingNowFrame.SuspendLayout();
            this.BandInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumImagePicBox)).BeginInit();
            this.MainLibPanel.SuspendLayout();
            this.LibraryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayBtn
            // 
            this.PlayBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PlayBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PlayBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PlayBtn.Location = new System.Drawing.Point(407, 23);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(75, 48);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = ">";
            this.PlayBtn.UseVisualStyleBackColor = false;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NextBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextBtn.Location = new System.Drawing.Point(488, 33);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(53, 28);
            this.NextBtn.TabIndex = 0;
            this.NextBtn.Text = ">>||";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PrevBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PrevBtn.Location = new System.Drawing.Point(348, 33);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(53, 28);
            this.PrevBtn.TabIndex = 0;
            this.PrevBtn.Text = "||<<";
            this.PrevBtn.UseVisualStyleBackColor = false;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // ElapsedBar
            // 
            this.ElapsedBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ElapsedBar.AutoSize = false;
            this.ElapsedBar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ElapsedBar.LargeChange = 1;
            this.ElapsedBar.Location = new System.Drawing.Point(310, 73);
            this.ElapsedBar.Maximum = 100;
            this.ElapsedBar.Name = "ElapsedBar";
            this.ElapsedBar.Size = new System.Drawing.Size(267, 45);
            this.ElapsedBar.TabIndex = 1;
            this.ElapsedBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ElapsedBar.Scroll += new System.EventHandler(this.ElapsedBar_Scroll);
            this.ElapsedBar.ValueChanged += new System.EventHandler(this.ElapsedBar_ValueChanged);
            this.ElapsedBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ElapsedBar_MouseDown);
            this.ElapsedBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ElapsedBar_MouseUp);
            // 
            // VolBar
            // 
            this.VolBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolBar.AutoSize = false;
            this.VolBar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.VolBar.LargeChange = 1;
            this.VolBar.Location = new System.Drawing.Point(779, 32);
            this.VolBar.Maximum = 100;
            this.VolBar.Name = "VolBar";
            this.VolBar.Size = new System.Drawing.Size(88, 45);
            this.VolBar.SmallChange = 10;
            this.VolBar.TabIndex = 3;
            this.VolBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolBar.Value = 100;
            this.VolBar.Scroll += new System.EventHandler(this.VolBar_Scroll);
            this.VolBar.MouseLeave += new System.EventHandler(this.VolBar_MouseLeave);
            this.VolBar.MouseHover += new System.EventHandler(this.VolBar_MouseHover);
            // 
            // ElapsedLbl
            // 
            this.ElapsedLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ElapsedLbl.BackColor = System.Drawing.Color.Transparent;
            this.ElapsedLbl.ForeColor = System.Drawing.Color.White;
            this.ElapsedLbl.Location = new System.Drawing.Point(255, 79);
            this.ElapsedLbl.Name = "ElapsedLbl";
            this.ElapsedLbl.Size = new System.Drawing.Size(49, 13);
            this.ElapsedLbl.TabIndex = 5;
            this.ElapsedLbl.Text = "00:00:00";
            // 
            // MusicSizeLbl
            // 
            this.MusicSizeLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MusicSizeLbl.BackColor = System.Drawing.Color.Transparent;
            this.MusicSizeLbl.ForeColor = System.Drawing.Color.White;
            this.MusicSizeLbl.Location = new System.Drawing.Point(583, 79);
            this.MusicSizeLbl.Name = "MusicSizeLbl";
            this.MusicSizeLbl.Size = new System.Drawing.Size(49, 13);
            this.MusicSizeLbl.TabIndex = 5;
            this.MusicSizeLbl.Text = "00:00:00";
            // 
            // ElapsedTime
            // 
            this.ElapsedTime.Interval = 500;
            this.ElapsedTime.Tick += new System.EventHandler(this.ElapsedTime_Tick);
            // 
            // MusicNameLbl
            // 
            this.MusicNameLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MusicNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.MusicNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicNameLbl.ForeColor = System.Drawing.Color.White;
            this.MusicNameLbl.Location = new System.Drawing.Point(62, 1);
            this.MusicNameLbl.Name = "MusicNameLbl";
            this.MusicNameLbl.Size = new System.Drawing.Size(759, 16);
            this.MusicNameLbl.TabIndex = 7;
            this.MusicNameLbl.Text = "[MusicNameLbl]";
            this.MusicNameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CloseBtn.png");
            // 
            // VolLbl
            // 
            this.VolLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VolLbl.BackColor = System.Drawing.Color.Transparent;
            this.VolLbl.ForeColor = System.Drawing.Color.White;
            this.VolLbl.Location = new System.Drawing.Point(873, 32);
            this.VolLbl.Name = "VolLbl";
            this.VolLbl.Size = new System.Drawing.Size(42, 13);
            this.VolLbl.TabIndex = 11;
            this.VolLbl.Text = "[VolLbl]";
            this.VolLbl.Visible = false;
            // 
            // VolBarTimer
            // 
            this.VolBarTimer.Interval = 3000;
            this.VolBarTimer.Tick += new System.EventHandler(this.VolBarTimer_Tick);
            // 
            // MusicControlPanel
            // 
            this.MusicControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MusicControlPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MusicControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MusicControlPanel.Controls.Add(this.SpeakerPictureBox);
            this.MusicControlPanel.Controls.Add(this.PrevBtn);
            this.MusicControlPanel.Controls.Add(this.NextBtn);
            this.MusicControlPanel.Controls.Add(this.PlayBtn);
            this.MusicControlPanel.Controls.Add(this.MusicNameLbl);
            this.MusicControlPanel.Controls.Add(this.ElapsedBar);
            this.MusicControlPanel.Controls.Add(this.VolLbl);
            this.MusicControlPanel.Controls.Add(this.VolBar);
            this.MusicControlPanel.Controls.Add(this.ElapsedLbl);
            this.MusicControlPanel.Controls.Add(this.MusicSizeLbl);
            this.MusicControlPanel.Location = new System.Drawing.Point(-4, 587);
            this.MusicControlPanel.Name = "MusicControlPanel";
            this.MusicControlPanel.Size = new System.Drawing.Size(935, 103);
            this.MusicControlPanel.TabIndex = 13;
            // 
            // SpeakerPictureBox
            // 
            this.SpeakerPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeakerPictureBox.Image = global::DarkPlayer.Properties.Resources.altofalanteBranco1;
            this.SpeakerPictureBox.Location = new System.Drawing.Point(753, 30);
            this.SpeakerPictureBox.Name = "SpeakerPictureBox";
            this.SpeakerPictureBox.Size = new System.Drawing.Size(27, 24);
            this.SpeakerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpeakerPictureBox.TabIndex = 1;
            this.SpeakerPictureBox.TabStop = false;
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SideBarPanel.BackgroundImage = global::DarkPlayer.Properties.Resources.blurback;
            this.SideBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SideBarPanel.Controls.Add(this.PlayingNowPanel);
            this.SideBarPanel.Controls.Add(this.MinhasMusicasPanel);
            this.SideBarPanel.Location = new System.Drawing.Point(-4, -1);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(235, 691);
            this.SideBarPanel.TabIndex = 12;
            // 
            // PlayingNowPanel
            // 
            this.PlayingNowPanel.BackColor = System.Drawing.Color.Transparent;
            this.PlayingNowPanel.Controls.Add(this.PlayingNowLbl);
            this.PlayingNowPanel.Location = new System.Drawing.Point(-2, 75);
            this.PlayingNowPanel.Name = "PlayingNowPanel";
            this.PlayingNowPanel.Size = new System.Drawing.Size(235, 45);
            this.PlayingNowPanel.TabIndex = 0;
            this.PlayingNowPanel.Click += new System.EventHandler(this.PlayingNowPanel_Click);
            this.PlayingNowPanel.MouseEnter += new System.EventHandler(this.PlayingNowPanel_MouseHover);
            this.PlayingNowPanel.MouseLeave += new System.EventHandler(this.PlayingNowPanel_MouseLeave);
            // 
            // PlayingNowLbl
            // 
            this.PlayingNowLbl.AutoSize = true;
            this.PlayingNowLbl.BackColor = System.Drawing.Color.Transparent;
            this.PlayingNowLbl.Enabled = false;
            this.PlayingNowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayingNowLbl.ForeColor = System.Drawing.Color.White;
            this.PlayingNowLbl.Location = new System.Drawing.Point(22, 13);
            this.PlayingNowLbl.Name = "PlayingNowLbl";
            this.PlayingNowLbl.Size = new System.Drawing.Size(154, 20);
            this.PlayingNowLbl.TabIndex = 0;
            this.PlayingNowLbl.Text = "Reproduzindo agora";
            // 
            // MinhasMusicasPanel
            // 
            this.MinhasMusicasPanel.BackColor = System.Drawing.Color.Transparent;
            this.MinhasMusicasPanel.Controls.Add(this.MinhasMusicasLbl);
            this.MinhasMusicasPanel.Location = new System.Drawing.Point(-2, 130);
            this.MinhasMusicasPanel.Name = "MinhasMusicasPanel";
            this.MinhasMusicasPanel.Size = new System.Drawing.Size(235, 45);
            this.MinhasMusicasPanel.TabIndex = 0;
            this.MinhasMusicasPanel.Click += new System.EventHandler(this.MinhasMusicasPanel_Click);
            this.MinhasMusicasPanel.MouseEnter += new System.EventHandler(this.MinhasMusicasPanel_MouseHover);
            this.MinhasMusicasPanel.MouseLeave += new System.EventHandler(this.MinhasMusicasPanel_MouseLeave);
            // 
            // MinhasMusicasLbl
            // 
            this.MinhasMusicasLbl.AutoSize = true;
            this.MinhasMusicasLbl.BackColor = System.Drawing.Color.Transparent;
            this.MinhasMusicasLbl.Enabled = false;
            this.MinhasMusicasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinhasMusicasLbl.ForeColor = System.Drawing.Color.White;
            this.MinhasMusicasLbl.Location = new System.Drawing.Point(23, 12);
            this.MinhasMusicasLbl.Name = "MinhasMusicasLbl";
            this.MinhasMusicasLbl.Size = new System.Drawing.Size(122, 20);
            this.MinhasMusicasLbl.TabIndex = 0;
            this.MinhasMusicasLbl.Text = "Minhas músicas";
            // 
            // PlayingNowFrame
            // 
            this.PlayingNowFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayingNowFrame.Controls.Add(this.PlaylistListBox);
            this.PlayingNowFrame.Controls.Add(this.BandInfoPanel);
            this.PlayingNowFrame.Controls.Add(this.InYourMuicsLbl);
            this.PlayingNowFrame.Location = new System.Drawing.Point(231, -1);
            this.PlayingNowFrame.Name = "PlayingNowFrame";
            this.PlayingNowFrame.Size = new System.Drawing.Size(697, 588);
            this.PlayingNowFrame.TabIndex = 14;
            // 
            // PlaylistListBox
            // 
            this.PlaylistListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlaylistListBox.BackColor = System.Drawing.Color.Black;
            this.PlaylistListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlaylistListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistListBox.ForeColor = System.Drawing.Color.White;
            this.PlaylistListBox.FormattingEnabled = true;
            this.PlaylistListBox.ItemHeight = 16;
            this.PlaylistListBox.Location = new System.Drawing.Point(37, 275);
            this.PlaylistListBox.Name = "PlaylistListBox";
            this.PlaylistListBox.Size = new System.Drawing.Size(627, 256);
            this.PlaylistListBox.TabIndex = 1;
            this.PlaylistListBox.DoubleClick += new System.EventHandler(this.PlaylistListBox_DoubleClick);
            // 
            // BandInfoPanel
            // 
            this.BandInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BandInfoPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BandInfoPanel.Controls.Add(this.AlbumImagePicBox);
            this.BandInfoPanel.Controls.Add(this.AddToLbl);
            this.BandInfoPanel.Controls.Add(this.PlayAllLbl);
            this.BandInfoPanel.Controls.Add(this.BandYearLbl);
            this.BandInfoPanel.Controls.Add(this.BandNameLbl);
            this.BandInfoPanel.Controls.Add(this.BandTypeLbl);
            this.BandInfoPanel.Controls.Add(this.BandAlbumLbl);
            this.BandInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.BandInfoPanel.Name = "BandInfoPanel";
            this.BandInfoPanel.Size = new System.Drawing.Size(697, 184);
            this.BandInfoPanel.TabIndex = 0;
            // 
            // AlbumImagePicBox
            // 
            this.AlbumImagePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlbumImagePicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlbumImagePicBox.Location = new System.Drawing.Point(12, 11);
            this.AlbumImagePicBox.Name = "AlbumImagePicBox";
            this.AlbumImagePicBox.Size = new System.Drawing.Size(181, 160);
            this.AlbumImagePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlbumImagePicBox.TabIndex = 1;
            this.AlbumImagePicBox.TabStop = false;
            // 
            // AddToLbl
            // 
            this.AddToLbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddToLbl.AutoSize = true;
            this.AddToLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToLbl.ForeColor = System.Drawing.Color.White;
            this.AddToLbl.Location = new System.Drawing.Point(522, 147);
            this.AddToLbl.Name = "AddToLbl";
            this.AddToLbl.Size = new System.Drawing.Size(86, 16);
            this.AddToLbl.TabIndex = 0;
            this.AddToLbl.Text = "+ Adicionar a";
            this.AddToLbl.MouseEnter += new System.EventHandler(this.AddToLbl_MouseEnter);
            this.AddToLbl.MouseLeave += new System.EventHandler(this.AddToLbl_MouseLeave);
            // 
            // PlayAllLbl
            // 
            this.PlayAllLbl.AutoSize = true;
            this.PlayAllLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAllLbl.ForeColor = System.Drawing.Color.White;
            this.PlayAllLbl.Location = new System.Drawing.Point(218, 147);
            this.PlayAllLbl.Name = "PlayAllLbl";
            this.PlayAllLbl.Size = new System.Drawing.Size(103, 16);
            this.PlayAllLbl.TabIndex = 0;
            this.PlayAllLbl.Text = "Reproduzir tudo";
            this.PlayAllLbl.MouseEnter += new System.EventHandler(this.PlayAllLbl_MouseEnter);
            this.PlayAllLbl.MouseLeave += new System.EventHandler(this.PlayAllLbl_MouseLeave);
            // 
            // BandYearLbl
            // 
            this.BandYearLbl.AutoSize = true;
            this.BandYearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BandYearLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.BandYearLbl.Location = new System.Drawing.Point(218, 87);
            this.BandYearLbl.Name = "BandYearLbl";
            this.BandYearLbl.Size = new System.Drawing.Size(87, 16);
            this.BandYearLbl.TabIndex = 0;
            this.BandYearLbl.Text = "BandYearLbl";
            // 
            // BandNameLbl
            // 
            this.BandNameLbl.AutoSize = true;
            this.BandNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BandNameLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.BandNameLbl.Location = new System.Drawing.Point(218, 52);
            this.BandNameLbl.Name = "BandNameLbl";
            this.BandNameLbl.Size = new System.Drawing.Size(95, 16);
            this.BandNameLbl.TabIndex = 0;
            this.BandNameLbl.Text = "BandNameLbl";
            // 
            // BandTypeLbl
            // 
            this.BandTypeLbl.AutoSize = true;
            this.BandTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BandTypeLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.BandTypeLbl.Location = new System.Drawing.Point(218, 69);
            this.BandTypeLbl.Name = "BandTypeLbl";
            this.BandTypeLbl.Size = new System.Drawing.Size(90, 16);
            this.BandTypeLbl.TabIndex = 0;
            this.BandTypeLbl.Text = "BandTypeLbl";
            // 
            // BandAlbumLbl
            // 
            this.BandAlbumLbl.AutoSize = true;
            this.BandAlbumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BandAlbumLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.BandAlbumLbl.Location = new System.Drawing.Point(208, 20);
            this.BandAlbumLbl.Name = "BandAlbumLbl";
            this.BandAlbumLbl.Size = new System.Drawing.Size(170, 29);
            this.BandAlbumLbl.TabIndex = 0;
            this.BandAlbumLbl.Text = "BandAlbumLbl";
            // 
            // InYourMuicsLbl
            // 
            this.InYourMuicsLbl.AutoSize = true;
            this.InYourMuicsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InYourMuicsLbl.ForeColor = System.Drawing.Color.White;
            this.InYourMuicsLbl.Location = new System.Drawing.Point(31, 209);
            this.InYourMuicsLbl.Name = "InYourMuicsLbl";
            this.InYourMuicsLbl.Size = new System.Drawing.Size(157, 24);
            this.InYourMuicsLbl.TabIndex = 0;
            this.InYourMuicsLbl.Text = "Em suas músicas";
            // 
            // MainLibPanel
            // 
            this.MainLibPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLibPanel.Controls.Add(this.BibliotecaLbl);
            this.MainLibPanel.Controls.Add(this.LibraryPanel);
            this.MainLibPanel.Location = new System.Drawing.Point(231, -1);
            this.MainLibPanel.Name = "MainLibPanel";
            this.MainLibPanel.Size = new System.Drawing.Size(694, 588);
            this.MainLibPanel.TabIndex = 2;
            // 
            // BibliotecaLbl
            // 
            this.BibliotecaLbl.AutoSize = true;
            this.BibliotecaLbl.BackColor = System.Drawing.Color.Transparent;
            this.BibliotecaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BibliotecaLbl.ForeColor = System.Drawing.Color.White;
            this.BibliotecaLbl.Location = new System.Drawing.Point(23, 12);
            this.BibliotecaLbl.Name = "BibliotecaLbl";
            this.BibliotecaLbl.Size = new System.Drawing.Size(120, 29);
            this.BibliotecaLbl.TabIndex = 11;
            this.BibliotecaLbl.Text = "Biblioteca";
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LibraryPanel.BackColor = System.Drawing.Color.Transparent;
            this.LibraryPanel.Controls.Add(this.AlbumsFrameLbl);
            this.LibraryPanel.Controls.Add(this.ArtistsFrameLbl);
            this.LibraryPanel.Controls.Add(this.MusicFrameLbl);
            this.LibraryPanel.Controls.Add(this.AlbunsSelected);
            this.LibraryPanel.Controls.Add(this.ArtistasSelected);
            this.LibraryPanel.Controls.Add(this.MusicasSelectedLbl);
            this.LibraryPanel.Controls.Add(this.LibraryListBox);
            this.LibraryPanel.Controls.Add(this.AlbumListView);
            this.LibraryPanel.Controls.Add(this.ArtistsListBox);
            this.LibraryPanel.Location = new System.Drawing.Point(10, 63);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Size = new System.Drawing.Size(674, 513);
            this.LibraryPanel.TabIndex = 12;
            // 
            // AlbumsFrameLbl
            // 
            this.AlbumsFrameLbl.AutoSize = true;
            this.AlbumsFrameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumsFrameLbl.ForeColor = System.Drawing.Color.White;
            this.AlbumsFrameLbl.Location = new System.Drawing.Point(152, 5);
            this.AlbumsFrameLbl.Name = "AlbumsFrameLbl";
            this.AlbumsFrameLbl.Size = new System.Drawing.Size(58, 20);
            this.AlbumsFrameLbl.TabIndex = 10;
            this.AlbumsFrameLbl.Text = "Álbuns";
            this.AlbumsFrameLbl.Click += new System.EventHandler(this.AlbumsFrameLbl_Click);
            this.AlbumsFrameLbl.MouseEnter += new System.EventHandler(this.AlbumsFrameLbl_MouseHover);
            this.AlbumsFrameLbl.MouseLeave += new System.EventHandler(this.AlbumsFrameLbl_MouseLeave);
            // 
            // ArtistsFrameLbl
            // 
            this.ArtistsFrameLbl.AutoSize = true;
            this.ArtistsFrameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistsFrameLbl.ForeColor = System.Drawing.Color.White;
            this.ArtistsFrameLbl.Location = new System.Drawing.Point(84, 5);
            this.ArtistsFrameLbl.Name = "ArtistsFrameLbl";
            this.ArtistsFrameLbl.Size = new System.Drawing.Size(63, 20);
            this.ArtistsFrameLbl.TabIndex = 10;
            this.ArtistsFrameLbl.Text = "Artistas";
            this.ArtistsFrameLbl.Click += new System.EventHandler(this.ArtistsFrameLbl_Click);
            this.ArtistsFrameLbl.MouseEnter += new System.EventHandler(this.ArtistsFrameLbl_MouseHover);
            this.ArtistsFrameLbl.MouseLeave += new System.EventHandler(this.ArtistsFrameLbl_MouseLeave);
            // 
            // MusicFrameLbl
            // 
            this.MusicFrameLbl.AutoSize = true;
            this.MusicFrameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicFrameLbl.ForeColor = System.Drawing.Color.White;
            this.MusicFrameLbl.Location = new System.Drawing.Point(13, 5);
            this.MusicFrameLbl.Name = "MusicFrameLbl";
            this.MusicFrameLbl.Size = new System.Drawing.Size(67, 20);
            this.MusicFrameLbl.TabIndex = 10;
            this.MusicFrameLbl.Text = "Músicas";
            this.MusicFrameLbl.Click += new System.EventHandler(this.MusicFrameLbl_Click);
            this.MusicFrameLbl.MouseEnter += new System.EventHandler(this.MusicFrameLbl_MouseHover);
            this.MusicFrameLbl.MouseLeave += new System.EventHandler(this.MusicFrameLbl_MouseLeave);
            // 
            // AlbunsSelected
            // 
            this.AlbunsSelected.AutoSize = true;
            this.AlbunsSelected.Font = new System.Drawing.Font("Old English Text MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbunsSelected.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AlbunsSelected.Location = new System.Drawing.Point(154, 14);
            this.AlbunsSelected.Name = "AlbunsSelected";
            this.AlbunsSelected.Size = new System.Drawing.Size(55, 14);
            this.AlbunsSelected.TabIndex = 12;
            this.AlbunsSelected.Text = "________";
            this.AlbunsSelected.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AlbunsSelected.Visible = false;
            // 
            // ArtistasSelected
            // 
            this.ArtistasSelected.AutoSize = true;
            this.ArtistasSelected.Font = new System.Drawing.Font("Old English Text MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistasSelected.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ArtistasSelected.Location = new System.Drawing.Point(85, 14);
            this.ArtistasSelected.Name = "ArtistasSelected";
            this.ArtistasSelected.Size = new System.Drawing.Size(61, 14);
            this.ArtistasSelected.TabIndex = 12;
            this.ArtistasSelected.Text = "_________";
            this.ArtistasSelected.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ArtistasSelected.Visible = false;
            // 
            // MusicasSelectedLbl
            // 
            this.MusicasSelectedLbl.AutoSize = true;
            this.MusicasSelectedLbl.Font = new System.Drawing.Font("Old English Text MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicasSelectedLbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.MusicasSelectedLbl.Location = new System.Drawing.Point(13, 14);
            this.MusicasSelectedLbl.Name = "MusicasSelectedLbl";
            this.MusicasSelectedLbl.Size = new System.Drawing.Size(67, 14);
            this.MusicasSelectedLbl.TabIndex = 12;
            this.MusicasSelectedLbl.Text = "__________";
            this.MusicasSelectedLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MusicasSelectedLbl.Visible = false;
            // 
            // AlbumListView
            // 
            this.AlbumListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlbumListView.BackColor = System.Drawing.Color.Black;
            this.AlbumListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlbumListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Album});
            this.AlbumListView.ForeColor = System.Drawing.Color.White;
            this.AlbumListView.LargeImageList = this.imageList1;
            this.AlbumListView.Location = new System.Drawing.Point(23, 43);
            this.AlbumListView.MultiSelect = false;
            this.AlbumListView.Name = "AlbumListView";
            this.AlbumListView.Size = new System.Drawing.Size(631, 435);
            this.AlbumListView.TabIndex = 0;
            this.AlbumListView.UseCompatibleStateImageBehavior = false;
            this.AlbumListView.DoubleClick += new System.EventHandler(this.AlbumListView_DoubleClick);
            // 
            // Album
            // 
            this.Album.Text = "";
            // 
            // ArtistsListBox
            // 
            this.ArtistsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArtistsListBox.BackColor = System.Drawing.Color.Black;
            this.ArtistsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ArtistsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistsListBox.ForeColor = System.Drawing.Color.White;
            this.ArtistsListBox.FormattingEnabled = true;
            this.ArtistsListBox.ItemHeight = 16;
            this.ArtistsListBox.Location = new System.Drawing.Point(23, 44);
            this.ArtistsListBox.Name = "ArtistsListBox";
            this.ArtistsListBox.Size = new System.Drawing.Size(631, 434);
            this.ArtistsListBox.TabIndex = 0;
            this.ArtistsListBox.DoubleClick += new System.EventHandler(this.ArtistsListBox_DoubleClick);
            // 
            // LibraryListBox
            // 
            this.LibraryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LibraryListBox.BackColor = System.Drawing.Color.Black;
            this.LibraryListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LibraryListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryListBox.ForeColor = System.Drawing.Color.White;
            this.LibraryListBox.FormattingEnabled = true;
            this.LibraryListBox.ItemHeight = 16;
            this.LibraryListBox.Location = new System.Drawing.Point(23, 44);
            this.LibraryListBox.Name = "LibraryListBox";
            this.LibraryListBox.Size = new System.Drawing.Size(631, 434);
            this.LibraryListBox.TabIndex = 6;
            this.LibraryListBox.DoubleClick += new System.EventHandler(this.LibraryListBox_DoubleClick);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 690);
            this.Controls.Add(this.MusicControlPanel);
            this.Controls.Add(this.SideBarPanel);
            this.Controls.Add(this.PlayingNowFrame);
            this.Controls.Add(this.MainLibPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Player";
            this.Text = "Dark Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Player_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Player_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ElapsedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolBar)).EndInit();
            this.MusicControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpeakerPictureBox)).EndInit();
            this.SideBarPanel.ResumeLayout(false);
            this.PlayingNowPanel.ResumeLayout(false);
            this.PlayingNowPanel.PerformLayout();
            this.MinhasMusicasPanel.ResumeLayout(false);
            this.MinhasMusicasPanel.PerformLayout();
            this.PlayingNowFrame.ResumeLayout(false);
            this.PlayingNowFrame.PerformLayout();
            this.BandInfoPanel.ResumeLayout(false);
            this.BandInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumImagePicBox)).EndInit();
            this.MainLibPanel.ResumeLayout(false);
            this.MainLibPanel.PerformLayout();
            this.LibraryPanel.ResumeLayout(false);
            this.LibraryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.TrackBar ElapsedBar;
        private System.Windows.Forms.TrackBar VolBar;
        private System.Windows.Forms.Label ElapsedLbl;
        private System.Windows.Forms.Label MusicSizeLbl;
        private System.Windows.Forms.Timer ElapsedTime;
        private System.Windows.Forms.Label MusicNameLbl;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label VolLbl;
        private System.Windows.Forms.Timer VolBarTimer;
        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.Panel MusicControlPanel;
        private System.Windows.Forms.Panel MinhasMusicasPanel;
        private System.Windows.Forms.PictureBox SpeakerPictureBox;
        private System.Windows.Forms.Panel PlayingNowPanel;
        private System.Windows.Forms.Label PlayingNowLbl;
        private System.Windows.Forms.Label MinhasMusicasLbl;
        private System.Windows.Forms.Panel PlayingNowFrame;
        private System.Windows.Forms.ListBox PlaylistListBox;
        private System.Windows.Forms.Panel BandInfoPanel;
        private System.Windows.Forms.PictureBox AlbumImagePicBox;
        private System.Windows.Forms.Label AddToLbl;
        private System.Windows.Forms.Label PlayAllLbl;
        private System.Windows.Forms.Label BandYearLbl;
        private System.Windows.Forms.Label BandTypeLbl;
        private System.Windows.Forms.Label BandAlbumLbl;
        private System.Windows.Forms.Label InYourMuicsLbl;
        private System.Windows.Forms.Label BandNameLbl;
        private System.Windows.Forms.Panel MainLibPanel;
        private System.Windows.Forms.Label BibliotecaLbl;
        private System.Windows.Forms.Panel LibraryPanel;
        private System.Windows.Forms.Label AlbumsFrameLbl;
        private System.Windows.Forms.Label ArtistsFrameLbl;
        private System.Windows.Forms.Label MusicFrameLbl;
        private System.Windows.Forms.Label AlbunsSelected;
        private System.Windows.Forms.Label ArtistasSelected;
        private System.Windows.Forms.Label MusicasSelectedLbl;
        private System.Windows.Forms.ListView AlbumListView;
        private System.Windows.Forms.ColumnHeader Album;
        private System.Windows.Forms.ListBox ArtistsListBox;
        private System.Windows.Forms.ListBox LibraryListBox;
        //private WindowBar minhasMuicasWB;
    }
}

