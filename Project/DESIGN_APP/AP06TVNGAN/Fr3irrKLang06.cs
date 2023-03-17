using IrrKlang;
using System;
using System.Windows.Forms;

namespace AP06TVNGAN
{
    public partial class Fr3irrKLang06 : Form
    {
        //KHAI BÁO CÁC BIẾN TOÀN CỤC 
        readonly ISoundEngine fn = new ISoundEngine(SoundOutputDriver.AutoDetect);

        // dùng để xác định thời điểm bản nhạc kết thúc
        readonly Timer timer = new Timer();

        ISound sound = null;

        public Fr3irrKLang06()
        {
            InitializeComponent();
        }
 
        private void Fr3irrKLang06_Load(object sender, EventArgs e)
        {
            try
            {
                this.aUDIOFILESTableAdapter.Fill(this.aP06TVNGANDataSet1.AUDIOFILES);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Có lỗi khi kết nối với database", ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (sound == null)
                {
                    PlayNewAudio();
                    TextBox8.Text = "Đang phát";
                }
                else
                {
                    if (sound.Paused == true)
                    {
                        timer.Enabled = true;
                        sound.Paused = false;
                    }
                    else
                    {
                        PlayNewAudio();
                        TextBox8.Text = "Đang phát";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi khi phat nhac", "Lỗi");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (sound != null && sound.Finished == false)
            {
                sound.Paused = true;
                timer.Enabled = false;
                TextBox8.Text = "Tạm dừng";
                textBox9.Text = (timer.Enabled).ToString();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //  fn.StopAllSounds();
            if (sound != null)
            {
                TextBox8.Text = "Dừng phát";
                timer.Stop();

                sound.Paused = false;
                sound.Stop();
                textBox9.Text = (timer.Enabled).ToString();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (sound == null)
            {
                return;
            }
            float speed = sound.PlaybackSpeed;

            if (speed < 2)
            {
                sound.PlaybackSpeed += (float)(0.25);
            }
            else
            {
                sound.PlaybackSpeed = (float)(1);
            }

            textBox10.Text = sound.PlaybackSpeed.ToString() + "x";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (sound == null)
            {
                return;
            }
            float speed = sound.PlaybackSpeed;

            if (speed > 0.25)
            {
                sound.PlaybackSpeed -= (float)(0.25);
            }
            else
            {
                sound.PlaybackSpeed = (float)(1);
            }

            textBox10.Text = sound.PlaybackSpeed.ToString() + "x";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0) listBox1.SelectedIndex--;
            //Nếu chưa phải là Track ĐẦU ( > 0)  thì GIẢM vị trí Track XUỐNG 1 (--) đến Track kế TRƯỚC
            else listBox1.SelectedIndex = listBox1.Items.Count - 1; //nếu đang là Track ĐẦU
            //(0) thì chuyển XUỐNG Track CUỐI CÙNG(vi trí vị trí cuối: count - 1)
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                listBox1.SelectedIndex++; //Nếu chưa phải là Track cuối ( < vị trí cuối: count -1)  
                                          //thì tăng vị trí Track lên 1(++) đến Track kế tiếp
            else listBox1.SelectedIndex = 0; //nếu đang là Track cuối (count - 1) thì 
                                             // chuyển về Track đầu tiên(vi trí 0)
        }
        private void Button9_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }


        private void CheckIsFinished()
        {
            if(timer == null)
            {
                return;
            }
            try
            {
                timer.Interval = 100; // Kiểm tra trạng thái mỗi giây
                timer.Tick += (s, Event) =>
                {
                    if (sound!= null && sound.Finished)
                    {
                        TextBox8.Text = "Kết thúc";
                        timer.Stop();
                        textBox10.Text = "1x";
                        textBox9.Text = (timer.Enabled).ToString();
                    }
                };
                timer.Start();
            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi khi khởi tạo timer ", "Lỗi");
            }

        }

        private void PlayNewAudio()
        {
            try
            {
                // dừng xác định thời gian chạy của bài hát trước nếu có
                if(timer.Enabled == true)
                {
                    timer.Stop();
                }
                if (sound != null)
                {
                    sound.Stop();
                }

                sound = fn.Play2D(textBox3.Text);

                if(sound == null)
                {
                    MessageBox.Show("Khong the phat nhac tu path: " + textBox3.Text , "loi");
                }

                CheckIsFinished();
                textBox9.Text = (timer?.Enabled).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi mở file âm thanh" + ex.ToString(), "Lỗi");
            }
        }

        //phat am thanh 3d
        private void Button10_Click(object sender, EventArgs e)
        {
            int count = 0;
            ISoundEngine engine = new ISoundEngine();
            ISound music = engine.Play3D(textBox3.Text,0, 0, 0, true);
            if(music==null)
            {
                return;
            }
            if (music != null)
                music.MinDistance = 5.0f;

            const float radius = 5;
            float posOnCircle = 0;
            
            while (count < 3) // endless loop until user exits
            {
                count++;
                Console.WriteLine(count.ToString());

                posOnCircle += 0.4f;
                Vector3D pos3d = new Vector3D(radius *
                          (float)Math.Cos(posOnCircle), 0,
                          radius * (float)Math.Sin(posOnCircle * 0.5f));

                engine.SetListenerPosition(0, 0, 0, 0, 0, 1);

                if (music != null)
                    music.Position = pos3d;

                System.Threading.Thread.Sleep(100);
            }
            music.Stop(); // dung phat nhac
        }

        private void Fr3irrKLang06_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(sound != null)
            {
                sound.Stop();
            }
        }
    }
}
