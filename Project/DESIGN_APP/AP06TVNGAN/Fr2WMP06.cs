using System;
using System.Windows.Forms;
using System.IO; //để lấy đường dẫn của File âm thanh 
using WMPLib;

namespace AP06TVNGAN
{
    public partial class Fr2WMP06 : Form
    {
        string programPath = Application.StartupPath; //Application.StartupPath = đường dẫn thư mục App
        string dataDirectoryPath = Path.Combine(Path.GetDirectoryName(Application.StartupPath), "AUDIO_DATA"); // dung de luu file audio vao app

        string filePath = "mac dinh"; // luu duong dan file
        string fileName = "mac dinh";
        FileInfo fileInfo = null;
        double fileSize = 0;
        string fileExtension = "";
        int fileDuration = 0;
        WindowsMediaPlayer player = null;
        IWMPMedia audio = null;

        public Fr2WMP06()
        {
            InitializeComponent();
        }
        private void Fr2WMP06_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aP06TVNGANDataSet1.AUDIOFILES' table. You can move, or remove it, as needed.
            try
            {
                this.aUDIOFILESTableAdapter.Fill(this.aP06TVNGANDataSet1.AUDIOFILES);
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            catch(System.Exception ex) {
                MessageBox.Show("Có lỗi khi kết nối với database", ex.Message);
            }
            Console.WriteLine(programPath); // kiem tra duong dan
        }
        private void Button1_Click(object sender, EventArgs e) //Play = CHẠY FILE AUDIO FILES
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void Button2_Click(object sender, EventArgs e) //Pause = TẠM DỪNG AUDIO FILES ĐANG CHẠY
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
        private void Button3_Click(object sender, EventArgs e) //Stop = DỪNG AUDIO FILES ĐANG CHẠY
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }
        private void Button4_Click(object sender, EventArgs e) //Faster = CHẠY AUDIO FILES NHANH HƠN
        {
            double soundSpeed = axWindowsMediaPlayer1.settings.rate;
            if (soundSpeed < 3)
            {
                axWindowsMediaPlayer1.settings.rate += 0.25;
            }
            else
            {
                axWindowsMediaPlayer1.settings.rate = 1;
            }
        }
        private void Button5_Click(object sender, EventArgs e) // slow
        {
            double soundSpeed = axWindowsMediaPlayer1.settings.rate;
            if(soundSpeed > 0)
            {
                axWindowsMediaPlayer1.settings.rate -= 0.25;
            }else
            {
                axWindowsMediaPlayer1.settings.rate = 1;
            }
        } 
        private void Button6_Click(object sender, EventArgs e) //VỀ TRACK ĐẦU TIÊN
        {
            listBox1.SelectedIndex = 0;
        }
        private void Button7_Click(object sender, EventArgs e)//CHẠY TRACK KẾ TRƯỚC; NẾU TRACK ĐẦU TIÊN => VỀ TRACK CUỐI
        {
            if (listBox1.SelectedIndex > 0) listBox1.SelectedIndex--;
            //Nếu chưa phải là Track ĐẦU ( > 0)  thì GIẢM vị trí Track XUỐNG 1 (--) đến Track kế TRƯỚC
            else listBox1.SelectedIndex = listBox1.Items.Count - 1; //nếu đang là Track ĐẦU
            //(0) thì chuyển XUỐNG Track CUỐI CÙNG(vi trí vị trí cuối: count - 1)            

        }
        private void Button8_Click(object sender, EventArgs e) //CHẠY TRACK KẾ TIẾP; NẾU TRACK1 CUỐI => VỀ TRACK ĐẦU
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                listBox1.SelectedIndex++; //Nếu chưa phải là Track cuối ( < vị trí cuối: count -1)  
                                          //thì tăng vị trí Track lên 1(++) đến Track kế tiếp
            else listBox1.SelectedIndex = 0; //nếu đang là Track cuối (count - 1) thì 
                                             // chuyển về Track đầu tiên(vi trí 0)
        }
        private void Button9_Click(object sender, EventArgs e) //XUỐNG TRACK ĐẦU CUỐI CÙNG
        {
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        static DialogResult dongYNapFile = DialogResult.No; //BIẾN TOÀN CỤC Giữ nút lệnh NSD đã chọn 
                                                            // khi Chọn file âm thanh dùng OpenFileDialog: Y = đồng ý chọn file, N = ko đồng ý(sẽ chọn lại, hoặc ko chọn)
                                                            //bắt buộc static = Sau khi ra khỏi thủ tục vẫn giữ lại giá trị KO bị hủy vùng nhó
                                                            // nap file am thanh
        private void Button10_Click(object sender, EventArgs e) // nap
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause(); 

            button1.Enabled = !button1.Enabled; // button play
            button2.Enabled= !button2.Enabled; // button pause
            button3.Enabled= !button3.Enabled; // button stop
            button4.Enabled= !button4.Enabled; // button faster
            button5.Enabled= !button5.Enabled; // button slow
            button6.Enabled= !button6.Enabled; // button first track
            button7.Enabled= !button7.Enabled; // 
            button8.Enabled= !button8.Enabled;
            button9.Enabled= !button9.Enabled;
            button11.Enabled= !button11.Enabled;
            button12.Enabled= !button12.Enabled;
            button13.Enabled= !button13.Enabled;

            if (button10.Text == "Nạp file") {//Mở OpenFilesDialog lên cho NSD chọn file âm thanh / PC
                dongYNapFile = openFileDialog1.ShowDialog();
                
                if(dongYNapFile == DialogResult.OK)
                {
                    textBox1.Text = "Quý vị phải nhập mã số file vào đây";
                    textBox5.Text = ""; // Xóa mô tả để NSD nhập mô tả mới
                    button10.Text = "Lưu"; //Đổi nhãn nút này thành "Lưu...": tự nhập

                    textBox1.Enabled = !textBox1.Enabled; // dược phép nhập mã số nhưng không được nhập trung mã số đã có
                    textBox5.Enabled = !textBox5.Enabled;


                    // khoi tao gia tri cho cac bien luu thong tin file audio
                    filePath = openFileDialog1.FileName;
                    fileName = System.IO.Path.GetFileName(filePath);

                    fileInfo = new FileInfo(filePath);
                    fileSize = (Math.Round((double)(fileInfo.Length) / 1024));
                    fileExtension = fileInfo.Extension;
                    player = new WindowsMediaPlayer();
                    audio = player.newMedia(filePath);
                    fileDuration = (int)Math.Round(audio.duration);


                    textBox2.Text = fileName;
                    textBox3.Text = filePath;
                    textBox4.Text = fileSize.ToString();
                    textBox6.Text = fileExtension;
                    textBox7.Text = fileDuration.ToString();

                    Console.WriteLine("Duong dan file vua chon la: " + filePath);
                }
            }
            else if(button10.Text == "Lưu")
            {
                if (dongYNapFile == DialogResult.OK)//NSD đã đồng ý nạp file âm thanh đã chọn từ OpenFileDialog
                {
                    Console.WriteLine(filePath + "   " + dataDirectoryPath);

                    try
                    {
                        if (!Directory.Exists(dataDirectoryPath))
                        {
                            Directory.CreateDirectory(dataDirectoryPath);
                        }

                        System.IO.File.Copy(filePath, Path.Combine(dataDirectoryPath, fileName), true);
                    }
                    catch (System.Exception ex) { MessageBox.Show("Có lỗi copy file âm thanh:" + ex.Message); }

                    //[2] NẠP THÔNG TIN CỦA FILE ÂM THANH ĐÃ CHỌN VÀO DATABASE SQL
                    if (textBox1.Text != "" && textBox1.Text != "Quý vị phải nhập mã số file vào đây")
                    //NSD bắt buộc nhập mã số file âm thanh thì mới lưu được.
                    {
                        try
                        {
                            aUDIOFILESTableAdapter.Insert(textBox1.Text.Trim(), fileName, Path.Combine(dataDirectoryPath, fileName), fileSize, fileExtension, fileDuration, textBox5.Text);
                            //NẠP THÔNG TIN FILE ÂM THANH VÀO DB [1 TRONG 2 CÂU LỆNH QUANG TRỌNG]
                        }
                        catch (System.Exception ex)
                        { MessageBox.Show("Có lỗi khi nạp thông tin file âm thanh vào DB: " + ex.Message); }
                    }
                    else MessageBox.Show("Không được để trống mã file");

                    try
                    {
                        this.aUDIOFILESTableAdapter.Fill(this.aP06TVNGANDataSet1.AUDIOFILES);
                    }
                    catch (System.Exception ex)
                    { MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }

                    button10.Text = "Nạp file";
                }//NSD OK              
            }//Lưu file

            

            axWindowsMediaPlayer1.Ctlcontrols.play();
        }//button10
        private void Button11_Click(object sender, EventArgs e)// SỬA THÔNG TIN FILE ÂM THANH
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            
            //B1:Cho || cấm các nút lệnh các khác và textbox mô tả tin file âm thanh (không sửa được các thông khác)
            textBox1.Enabled = !textBox1.Enabled; // dược phép nhập mã số nhưng không được nhập trung mã số đã có
            textBox5.Enabled = !textBox5.Enabled;
            button1.Enabled = !button1.Enabled; // button play
            button2.Enabled = !button2.Enabled; // button pause
            button3.Enabled = !button3.Enabled; // button stop
            button4.Enabled = !button4.Enabled; // button faster
            button5.Enabled = !button5.Enabled; // button slow
            button6.Enabled = !button6.Enabled; // button first track
            button7.Enabled = !button7.Enabled; // 
            button8.Enabled = !button8.Enabled;
            button9.Enabled = !button9.Enabled;
            button10.Enabled = !button10.Enabled;
            button12.Enabled = !button12.Enabled;
            button13.Enabled = !button13.Enabled;
            //B2: ĐỔI NHÃN (.TEXT) CỦA NÚT LỆNH : "Sửa..." <-> "Lưu..."
            if (button11.Text == "Sửa thông tin file")
            //bắt đầu Sửa thông tin file âm thanh trong các TextBox ["Sửa thông tin files" copy từ Design sang, KHÔNG tự  nhập]
            {//Thông báo nhắc NSD cách sủa thông tin
                MessageBox.Show("Quý vị chỉ được sửa mô tả file"); //thông báo hướng dẫn NSD cách sửa thông tin file
              

                button11.Text = "Lưu"; //Đổi nhãn (.Text) thành2 "Lưu...": tự nhập
            }
            else//Sau khi NSD sửa thông tin xong =>Lưu thông tin file âm thanh sau sửa vào DB
            {//B3: SỬA THÔNG TIN FILE ÂM THANH  + Update THÔNG TIN SỬA VÀO DB
                try
                {
                    aUDIOFILESTableAdapter.Update(textBox5.Text, textBox1.Text.Trim());
                    //Lưu THÔNG TIN FILE ÂM THANH sau Sửa VÀO DB [CÂU LỆNH QUANG TRỌNG]
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi khi SỬA thông tin file âm thanh: " + ex.Message); }

                //B4: Tải file mới vừa nạp vào ListBox và nghe thử / axWMP = COPY xuống TỪ trên FrWMPManagement_Load(..)
                try
                {
                    this.aUDIOFILESTableAdapter.Fill(this.aP06TVNGANDataSet1.AUDIOFILES);
                    //nạp DB files âm thanh
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }
                //B5: Đổi nhãn thành ban đầu
                button11.Text = "Sửa thông tin files";
                //Trả lại nhãn ban đầu ["Sửa thông tin files" copy từ Design sang, KHÔNG tự  nhập]                
            }//else Lưu thông tin file vào DB

            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        private void Button12_Click(object sender, EventArgs e)
        {
          //  saveFileDialog1.Filter = "Thu âm (.wav)|*.wav";
          //  saveFileDialog1.ShowDialog();
          //  record("open new Type waveaudio Alias recsound", "", 0, 0);

           // record("record recsound", "", 0, 0);
        }
        private void Button13_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            //B1: HỎI XÁC NHẬN
            DialogResult ch = MessageBox.Show("Bạncó muốn xóa file: " + textBox2.Text.Trim() + " không(Y/N)?", "Xác nhận",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //B2: XÓA Khi NSD Y
            if (ch == DialogResult.Yes)//NSD đồng ý Xóa
            {
                try
                {
                    aUDIOFILESTableAdapter.Delete(textBox1.Text.Trim());//XÓA FILE ÂM THANH [CÂU LỆNH QUANG TRỌNG]
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi khi XÓA file âm thanh: " + ex.Message); }
                try //B3: Tải các file sau xóa lên ListBox = COPY xuống TỪ trên FrWMPManagement_Load(..)
                {
                    this.aUDIOFILESTableAdapter.Fill(this.aP06TVNGANDataSet1.AUDIOFILES); //nạp DB files âm thanh
                }
                catch (System.Exception ex)
                { MessageBox.Show("Có lỗi tải các files âm thanh lên danh sách! " + ex.Message); }
            }//If NSD Y

            axWindowsMediaPlayer1.Ctlcontrols.play();
        }//button13// XÓA FILE ÂM THANH
        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Trở về màn hình chính?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                this.Close();
            }
        }
        private void Button15_Click_1(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Fr2WMP06_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ch = MessageBox.Show("Trở về màn hình chính?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            else
                e.Cancel = true;
        }
    }
}
