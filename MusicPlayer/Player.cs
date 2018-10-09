using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using NAudio.Wave;

namespace DarkPlayer
{
    public partial class Player : Form
    {
        public static List<Music> songs = new List<Music>();
        public static List<Music> playList = new List<Music>();
        private bool _isPlaying = false;
        private TimeSpan _timeSpan = new TimeSpan();
        private static FileStream _fileStream;
        private static Mp3FileReader _reader;
        private static BlockAlignReductionStream _blockAlignStream;
        private static WaveOut _waveOut;
        private int _nowPlaying;
        private Process _proc = new Process();

        public Player()
        {
            InitializeComponent();

            MusicNameLbl.Text = string.Empty;
            VolLbl.Text = string.Empty;
            VolLbl.Text = VolBar.Value.ToString();
            imageList1.ImageSize = new Size(100, 100);
            PlayingNowLbl.ForeColor = Color.White;
            MinhasMusicasLbl.Enabled = false;
            MinhasMusicasLbl.ForeColor = Color.White;
            PlaylistListBox.ScrollAlwaysVisible = false;
            LibraryListBox.ScrollAlwaysVisible = false;

            #region SetVolume

            string tempPath = Path.GetPathRoot(Environment.SystemDirectory)/*<- Retorna "C:\\"*/ + "Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\darkplayer.tmp";
            var volume = 100;

            try
            {
                volume = int.Parse(File.ReadAllText(tempPath));
            }
            catch (Exception)
            {
                volume = 100;
            }
            finally
            {
                VolBar.Value = volume;
                VolLbl.Text = volume.ToString();
            }
            #endregion

            GetMusicFiles();
            GetArtists();
            GetAlbuns();

            MainLibPanel.BringToFront();
            MusicasSelectedLbl.Visible = true;
            _proc = Process.GetCurrentProcess();
        }

        private void GetMusicFiles()
        {
            songs.Clear();
            playList.Clear();
            Music mus = new Music();
            DirectoryInfo d = new DirectoryInfo("C:\\Users\\" + Environment.UserName + "\\Music");
            FileInfo[] Files = d.GetFiles("*.mp3", SearchOption.AllDirectories);
            int i = 0;
            foreach (FileInfo file in Files)
            {
                TagLib.File tf = TagLib.File.Create(file.FullName);
                mus = new Music
                {
                    Artist = tf.Tag.FirstArtist,
                    Title = tf.Tag.Title,
                    Album = tf.Tag.Album,
                    Year = tf.Tag.Year.ToString()
                };
                string[] genres = new string[tf.Tag.Genres.Length];
                for (int j = 0; j < genres.Length; j++)
                    mus.Genero += tf.Tag.Genres[j] + "/";
                mus.Genero = mus.Genero.Remove(mus.Genero.LastIndexOf("/"), 1);
                mus.Path = file.FullName;

                if (mus.Artist == null)
                    mus.Artist = "Artista desconhecido";

                if (mus.Title == null)
                    mus.Title = "Faixa desconhecida";

                if (mus.Album == null)
                    mus.Album = "Album desconhecido";

                if (tf.Tag.Pictures.Length >= 1)
                {
                    var bin = tf.Tag.Pictures[0].Data.Data;
                    Image im = (Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(300, 300, null, IntPtr.Zero));
                    mus.AlbumPic = im;
                }

                songs.Add(mus);
                i++;
            }

            UpdateLibraryListBox();
        }

        private void GetAlbuns()//
        {
            foreach (var song in songs)
            {
                if (!imageList1.Images.ContainsKey(song.Album))
                {
                    try
                    {
                        imageList1.Images.Add(song.Album, song.AlbumPic);
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            UpdateAlbuns();
        }

        private void GetArtists()
        {
            ArtistsListBox.Items.Clear();
            foreach (var mus in songs)
            {
                if (!ArtistsListBox.Items.Contains(mus.Artist))
                    ArtistsListBox.Items.Add(mus.Artist);
            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (_isPlaying)
            {
                _isPlaying = false;
                Thread tt = new Thread(t => PlayAudio());
                tt.Start();
            }

            else
            {
                _isPlaying = true;
                Thread tt = new Thread(t => PlayAudio());
                tt.Start();

            }
            SetButton();

        }

        private void PlayAudio()
        {
            if (_isPlaying)
            {
                _waveOut.Init(_blockAlignStream);
                _waveOut.Play();
                while (_waveOut.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
            }
            else
                _waveOut.Pause();
        }

        private void SetButton()
        {
            if (_isPlaying)
            {
                PlayBtn.Text = "||";
                ElapsedTime.Start();
            }

            else
            {
                PlayBtn.Text = ">";
                ElapsedTime.Stop();
            }
        }

        private Color SetTransparency(int A, Color color)
        {
            return Color.FromArgb(A, color.R, color.G, color.B);
        }

        #region ListsDoubleClickMethods

        private void ArtistsListBox_DoubleClick(object sender, EventArgs e)
        {
            AlbumListView.Items.Clear();
            foreach (var mus in songs)
            {
                if (mus.Artist.Equals(ArtistsListBox.SelectedItem.ToString()))
                {
                    ListViewItem lt = new ListViewItem
                    {
                        Text = mus.Album + "\n" + mus.Year,
                        ImageKey = mus.Album,
                        Name = mus.Album
                    };
                    if (!AlbumListView.Items.ContainsKey(mus.Album) && mus.Album != null)
                    {
                        AlbumListView.Items.Add(lt);
                    }
                }
            }
            AlbumsFrameLbl_Click(sender, e);
        }

        private void PlaylistListBox_DoubleClick(object sender, EventArgs e)
        {
            PlaySongFromListBox(PlaylistListBox.SelectedIndex);
        }

        private void AlbumListView_DoubleClick(object sender, EventArgs e)
        {
            PlaylistListBox.Items.Clear();
            playList.Clear();

            UpdatePlayingNowFrame(AlbumListView.SelectedItems[0].ImageKey);

            foreach (var song in songs)
            {
                try
                {
                    if (song.Album.Equals(AlbumListView.SelectedItems[0].ImageKey))
                    {
                        PlaylistListBox.Items.Add(song.Title);
                        playList.Add(song);
                    }
                }
                catch (Exception)
                {

                }

            }
            PlayingNowPanel_Click(sender, e);
        }

        private void LibraryListBox_DoubleClick(object sender, EventArgs e)
        {
            PlaySongFromListBox(LibraryListBox.SelectedIndex);
            PlaylistListBox.Items.Clear();
            PlaylistListBox.Items.AddRange(LibraryListBox.Items);
            PlaylistListBox.SelectedIndex = _nowPlaying;
            UpdatePlayingNowFrame(playList[_nowPlaying].Album);

            PlayingNowPanel_Click(sender, e);
        }

        #endregion

        private void VolBar_Scroll(object sender, EventArgs e)
        {
            VolLbl.Visible = true;
            VolLbl.Text = VolBar.Value.ToString();
            if (_reader != null)
                _waveOut.Volume = VolBar.Value * (float)0.01;
        }

        private void ElapsedTime_Tick(object sender, EventArgs e)
        {
            ElapsedBar.Value = (int)_reader.CurrentTime.TotalSeconds;
        }

        private void UpdateLibraryListBox()
        {
            LibraryListBox.Items.Clear();
            playList.Clear();
            foreach (var mus in songs)
            {
                LibraryListBox.Items.Add(mus.Title);
                playList.Add(mus);
            }
        }

        private void UpdateAlbuns()
        {
            AlbumListView.Items.Clear();
            foreach (var mus in songs)
            {
                ListViewItem lt = new ListViewItem
                {
                    Text = mus.Album + "\n" + mus.Year,
                    ImageKey = mus.Album,
                    Name = mus.Album
                };
                //if (!AlbumListView.Items.ContainsKey(mus.Album)&&mus.Album!=null)
                if (!AlbumListView.Items.ContainsKey(mus.Album))
                {
                    AlbumListView.Items.Add(lt);
                }
            }

        }

        private void UpdatePlayingNowFrame(string infoFromAlbum)
        {
            BandAlbumLbl.Text = infoFromAlbum;//AlbumListView.SelectedItems[0].ImageKey;
            BandNameLbl.Text = songs[songs.FindIndex(x => x.Album == BandAlbumLbl.Text)].Artist;
            BandYearLbl.Text = songs[songs.FindIndex(x => x.Album == BandAlbumLbl.Text)].Year;
            BandTypeLbl.Text = songs[songs.FindIndex(x => x.Album == BandAlbumLbl.Text)].Genero;
            AlbumImagePicBox.Image = songs[songs.FindIndex(x => x.Album == BandAlbumLbl.Text)].AlbumPic;
            PlayAllLbl.Text = "Reproduzir tudo de " + BandNameLbl.Text;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            _nowPlaying++;
            ElapsedBar.Value = 0;
            MusicDispose();

            if (_nowPlaying >= playList.Capacity)
                _nowPlaying = 0;

            PlayFromPlaylist(_nowPlaying);
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            ElapsedBar.Value = 0;

            if ( _reader.CurrentTime.Seconds >= 3)
                _nowPlaying--;    
            if(_nowPlaying <= 0)
                _nowPlaying = 0;

            MusicDispose();

            PlayFromPlaylist(_nowPlaying);

        }

        private void MusicDispose()
        {
            if (_reader != null)
            {
                _fileStream.Dispose();
                _waveOut.Dispose();
                _reader.Dispose();
                _blockAlignStream.Dispose();
            }
        }

        private void PlayFromPlaylist(int index)
        {
            _fileStream = File.OpenRead(playList[index].Path);
            _reader = new Mp3FileReader(_fileStream);
            var wavStream = WaveFormatConversionStream.CreatePcmStream(_reader);
            _blockAlignStream = new BlockAlignReductionStream(wavStream);
            _waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback());
            _timeSpan = _reader.TotalTime;
            _waveOut.Volume = VolBar.Value * (float)0.01;

            ElapsedBar.Maximum = (int)_timeSpan.TotalSeconds;
            MusicNameLbl.Text = playList[index].Artist + " - " + playList[index].Title;
            string time = _reader.TotalTime.ToString();
            time = time.Remove(time.LastIndexOf('.'), 8);
            MusicSizeLbl.Text = time;
            SetButton();

            if (_isPlaying)
            {
                Thread tt = new Thread(t => PlayAudio());
                tt.Start();
            }
        }

        private void PlaySongFromListBox(int selectedIndex)
        {
            ElapsedBar.Value = 0;
            _isPlaying = true;
            if (_reader != null)
            {
                _fileStream.Dispose();
                _waveOut.Dispose();
                _reader.Dispose();
                _blockAlignStream.Dispose();
            }

            _nowPlaying = selectedIndex;

            _fileStream = System.IO.File.OpenRead(playList[_nowPlaying].Path);
            _reader = new Mp3FileReader(_fileStream);
            var wavStream = WaveFormatConversionStream.CreatePcmStream(_reader);
            _blockAlignStream = new BlockAlignReductionStream(wavStream);
            _waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback());
            _timeSpan = _reader.TotalTime;//timespan helper
            _waveOut.Volume = VolBar.Value * (float)0.01; //Cálculo para setar o volume de 0 a 100 para 0 a 1 (0.1,0.2...1)

            ElapsedBar.Maximum = (int)_timeSpan.TotalSeconds;
            MusicNameLbl.Text = playList[_nowPlaying].Artist + " - " + playList[_nowPlaying].Title;

            //------------Serve para setar a label que mostra o tempo maximo da musica-------
            string time = _reader.TotalTime.ToString();
            time = time.Remove(time.LastIndexOf('.'), 8);
            //time = rdr.TotalTime.Hours + ":" + rdr.TotalTime.Minutes + ":" + rdr.TotalTime.Seconds;
            MusicSizeLbl.Text = time;
            //-------------------------------------------------------------------------------
            SetButton();
            Thread tt = new Thread(t => PlayAudio());
            tt.Start();
        }

        private void MusicFrameLbl_Click(object sender, EventArgs e)
        {
            ArtistasSelected.Visible = false;
            MusicasSelectedLbl.Visible = true;
            AlbunsSelected.Visible = false;
            LibraryListBox.BringToFront();
            UpdateLibraryListBox();
            //GetMusicFiles();
        }

        private void AlbumsFrameLbl_Click(object sender, EventArgs e)
        {
            ArtistasSelected.Visible = false;
            AlbunsSelected.Visible = true;
            MusicasSelectedLbl.Visible = false;
            AlbumListView.BringToFront();
            UpdateAlbuns();
        }

        private void ArtistsFrameLbl_Click(object sender, EventArgs e)
        {
            ArtistasSelected.Visible = true;
            AlbunsSelected.Visible = false;
            MusicasSelectedLbl.Visible = false;
            ArtistsListBox.BringToFront();
            //GetArtists();
        }

        private void PlayingNowPanel_Click(object sender, EventArgs e)
        {
            PlayingNowFrame.BringToFront();
        }

        private void MinhasMusicasPanel_Click(object sender, EventArgs e)
        {
            MainLibPanel.BringToFront();
        }

        private void ElapsedBar_ValueChanged(object sender, EventArgs e)
        {
            if (_reader != null)
                ElapsedLbl.Text = string.Format("{0:hh\\:mm\\:ss}", _reader.CurrentTime);

            if (ElapsedBar.Value == (int)_timeSpan.TotalSeconds)
                NextBtn_Click(sender, e);
        }

        private void VolBarTimer_Tick(object sender, EventArgs e)
        {
            VolLbl.Visible = false;
            VolBarTimer.Stop();
        }

        private void VolBar_MouseLeave(object sender, EventArgs e)
        {
            VolBarTimer.Start();
        }

        private void ElapsedBar_Scroll(object sender, EventArgs e)
        {
            if (_reader != null)
            {
                _waveOut.Pause();
                TimeSpan time = TimeSpan.FromSeconds(ElapsedBar.Value);//Cria um timestamp para setar o tempo da musica uma vez que o CurrentTime retorna um TimeStamp
                _reader.CurrentTime = time; //Mp3 recebe o tempo definido pela barra em inteiro convertido para TimeStamp.FromSeconds   
            }
        }

        private void ElapsedBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (_isPlaying)
            {
                _waveOut.Pause();
            }

        }

        private void ElapsedBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isPlaying)
            {
                _waveOut.Play();
                _isPlaying = true;
            }
        }

        #region MouseHoverStyleSection

        private void VolBar_MouseHover(object sender, EventArgs e)
        {
            VolLbl.Visible = true;
        }

        private void PlayingNowPanel_MouseHover(object sender, EventArgs e)
        {
            MouseHoverControl(PlayingNowPanel);
        }

        private void MouseHoverControl(Control control)
        {
            control.BackColor = SetTransparency(127, Color.AntiqueWhite);
        }

        private void PlayingNowPanel_MouseLeave(object sender, EventArgs e)
        {
            PlayingNowPanel.BackColor = Color.Transparent;
        }

        private void MinhasMusicasPanel_MouseHover(object sender, EventArgs e)
        {
            MouseHoverControl(MinhasMusicasPanel);
        }

        private void MinhasMusicasPanel_MouseLeave(object sender, EventArgs e)
        {
            MinhasMusicasPanel.BackColor = Color.Transparent;
        }

        private void AlbumsFrameLbl_MouseHover(object sender, EventArgs e)
        {
            MouseHoverControl(AlbumsFrameLbl);
        }

        private void AlbumsFrameLbl_MouseLeave(object sender, EventArgs e)
        {
            AlbumsFrameLbl.BackColor = Color.Black;
        }

        private void ArtistsFrameLbl_MouseHover(object sender, EventArgs e)
        {
            MouseHoverControl(ArtistsFrameLbl);
        }

        private void ArtistsFrameLbl_MouseLeave(object sender, EventArgs e)
        {
            ArtistsFrameLbl.BackColor = Color.Black;
        }

        private void MusicFrameLbl_MouseHover(object sender, EventArgs e)
        {
            MouseHoverControl(MusicFrameLbl);
        }

        private void MusicFrameLbl_MouseLeave(object sender, EventArgs e)
        {
            MusicFrameLbl.BackColor = Color.Black;
        }

        private void PlayAllLbl_MouseEnter(object sender, EventArgs e)
        {
            MouseHoverControl(PlayAllLbl);
        }

        private void PlayAllLbl_MouseLeave(object sender, EventArgs e)
        {
            PlayAllLbl.BackColor = Color.Transparent;
        }

        private void AddToLbl_MouseEnter(object sender, EventArgs e)
        {
            MouseHoverControl(AddToLbl);
        }

        private void AddToLbl_MouseLeave(object sender, EventArgs e)
        {
            AddToLbl.BackColor = Color.Transparent;
        }

        #endregion

        private void Player_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_fileStream != null)
                _fileStream.Dispose();
            if (_waveOut != null)
                _waveOut.Dispose();
            if (_reader != null)
                _reader.Dispose();
            if (_blockAlignStream != null)
                _blockAlignStream.Dispose();

            string tempPath = "C:\\Users\\" + Environment.UserName + "\\AppData\\Local\\Temp";
            File.WriteAllText(tempPath + "\\darkplayer.tmp", VolBar.Value.ToString());
            Application.ExitThread();
            Application.Exit();
        }

        private void Player_FormClosed(object sender, FormClosedEventArgs e)
        {
            string tempPath = Path.GetPathRoot(Environment.SystemDirectory) + "Users\\" + Environment.UserName + "\\AppData\\Local\\Temp\\";
            File.WriteAllText(tempPath + "\\darkplayer.tmp", VolBar.Value.ToString());
        }
    }
}
