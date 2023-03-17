namespace AP06TVNGAN
{
    partial class Fr2WMP06
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr2WMP06));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.aUDIOFILESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aP06TVNGANDataSet1 = new AP06TVNGAN.AP06TVNGANDataSet1();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBoxAudioInfo = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAudioTest = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.aUDIOFILESTableAdapter = new AP06TVNGAN.AP06TVNGANDataSet1TableAdapters.AUDIOFILESTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOFILESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aP06TVNGANDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBoxAudioInfo.SuspendLayout();
            this.groupBoxAudioTest.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.aUDIOFILESBindingSource1;
            this.listBox1.DisplayMember = "filename";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 324);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "filepath";
            // 
            // aUDIOFILESBindingSource1
            // 
            this.aUDIOFILESBindingSource1.DataMember = "AUDIOFILES";
            this.aUDIOFILESBindingSource1.DataSource = this.aP06TVNGANDataSet1;
            // 
            // aP06TVNGANDataSet1
            // 
            this.aP06TVNGANDataSet1.DataSetName = "AP06TVNGANDataSet1";
            this.aP06TVNGANDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.DataBindings.Add(new System.Windows.Forms.Binding("URL", this.aUDIOFILESBindingSource1, "filepath", true));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 15);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(643, 210);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // groupBoxAudioInfo
            // 
            this.groupBoxAudioInfo.Controls.Add(this.textBox5);
            this.groupBoxAudioInfo.Controls.Add(this.textBox7);
            this.groupBoxAudioInfo.Controls.Add(this.textBox6);
            this.groupBoxAudioInfo.Controls.Add(this.textBox4);
            this.groupBoxAudioInfo.Controls.Add(this.textBox3);
            this.groupBoxAudioInfo.Controls.Add(this.textBox2);
            this.groupBoxAudioInfo.Controls.Add(this.textBox1);
            this.groupBoxAudioInfo.Controls.Add(this.label8);
            this.groupBoxAudioInfo.Controls.Add(this.label7);
            this.groupBoxAudioInfo.Controls.Add(this.label6);
            this.groupBoxAudioInfo.Controls.Add(this.label5);
            this.groupBoxAudioInfo.Controls.Add(this.label4);
            this.groupBoxAudioInfo.Controls.Add(this.label3);
            this.groupBoxAudioInfo.Controls.Add(this.label2);
            this.groupBoxAudioInfo.Controls.Add(this.label1);
            this.groupBoxAudioInfo.Controls.Add(this.listBox1);
            this.groupBoxAudioInfo.Location = new System.Drawing.Point(45, 113);
            this.groupBoxAudioInfo.Name = "groupBoxAudioInfo";
            this.groupBoxAudioInfo.Size = new System.Drawing.Size(547, 382);
            this.groupBoxAudioInfo.TabIndex = 2;
            this.groupBoxAudioInfo.TabStop = false;
            this.groupBoxAudioInfo.Text = "QUẢN LÝ FILE ÂM THANH";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource1, "description", true));
            this.textBox5.Enabled = false;
            this.textBox5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox5.Location = new System.Drawing.Point(350, 264);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(191, 112);
            this.textBox5.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource1, "length", true));
            this.textBox7.Enabled = false;
            this.textBox7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox7.Location = new System.Drawing.Point(350, 231);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(191, 22);
            this.textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource1, "ext", true));
            this.textBox6.Enabled = false;
            this.textBox6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox6.Location = new System.Drawing.Point(350, 193);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(191, 22);
            this.textBox6.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource1, "size", true));
            this.textBox4.Enabled = false;
            this.textBox4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox4.Location = new System.Drawing.Point(350, 154);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 22);
            this.textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource1, "filepath", true));
            this.textBox3.Enabled = false;
            this.textBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox3.Location = new System.Drawing.Point(350, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource1, "filename", true));
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.Location = new System.Drawing.Point(350, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aUDIOFILESBindingSource1, "ms", true));
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(350, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mô tả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Chiều dài(giây):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phần mở rộng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Size(KB):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên file:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã số:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn file âm thanh";
            // 
            // groupBoxAudioTest
            // 
            this.groupBoxAudioTest.Controls.Add(this.button5);
            this.groupBoxAudioTest.Controls.Add(this.button4);
            this.groupBoxAudioTest.Controls.Add(this.button3);
            this.groupBoxAudioTest.Controls.Add(this.button2);
            this.groupBoxAudioTest.Controls.Add(this.button9);
            this.groupBoxAudioTest.Controls.Add(this.button8);
            this.groupBoxAudioTest.Controls.Add(this.button7);
            this.groupBoxAudioTest.Controls.Add(this.button6);
            this.groupBoxAudioTest.Controls.Add(this.button1);
            this.groupBoxAudioTest.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBoxAudioTest.Location = new System.Drawing.Point(598, 113);
            this.groupBoxAudioTest.Name = "groupBoxAudioTest";
            this.groupBoxAudioTest.Size = new System.Drawing.Size(643, 382);
            this.groupBoxAudioTest.TabIndex = 3;
            this.groupBoxAudioTest.TabStop = false;
            this.groupBoxAudioTest.Text = "KIỂM THỬ FILE ÂM THANH";
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(536, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 1;
            this.button5.Text = "Slow";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(410, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 1;
            this.button4.Text = "Faster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(281, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 1;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(165, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(517, 340);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 30);
            this.button9.TabIndex = 1;
            this.button9.Text = "Last Track";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(359, 340);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 30);
            this.button8.TabIndex = 1;
            this.button8.Text = "Next Track";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(190, 340);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(126, 30);
            this.button7.TabIndex = 1;
            this.button7.Text = "Privious Track";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(33, 340);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 30);
            this.button6.TabIndex = 1;
            this.button6.Text = "First Track";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(33, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(143, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(986, 32);
            this.label9.TabIndex = 4;
            this.label9.Text = "QUẢN LÝ FILE ÂM THANH DÙNG THƯ VIỆN WMPLIB.dll CỦA WINDOW";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.button12);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Location = new System.Drawing.Point(45, 534);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1196, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nút chức năng";
            // 
            // button15
            // 
            this.button15.AutoSize = true;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(981, 21);
            this.button15.Name = "button15";
            this.button15.Padding = new System.Windows.Forms.Padding(5);
            this.button15.Size = new System.Drawing.Size(195, 45);
            this.button15.TabIndex = 0;
            this.button15.Text = "Thoát chương trình";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button15_Click_1);
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(783, 21);
            this.button14.Name = "button14";
            this.button14.Padding = new System.Windows.Forms.Padding(5);
            this.button14.Size = new System.Drawing.Size(126, 45);
            this.button14.TabIndex = 0;
            this.button14.Text = "Thoát form";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.AutoSize = true;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(619, 21);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(5);
            this.button13.Size = new System.Drawing.Size(97, 45);
            this.button13.TabIndex = 0;
            this.button13.Text = "Xóa file";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(420, 21);
            this.button12.Name = "button12";
            this.button12.Padding = new System.Windows.Forms.Padding(5);
            this.button12.Size = new System.Drawing.Size(127, 45);
            this.button12.TabIndex = 0;
            this.button12.Text = "Ghi file mới";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(168, 21);
            this.button11.Name = "button11";
            this.button11.Padding = new System.Windows.Forms.Padding(5);
            this.button11.Size = new System.Drawing.Size(176, 45);
            this.button11.TabIndex = 0;
            this.button11.Text = "Sửa thông tin file";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(11, 21);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(5);
            this.button10.Size = new System.Drawing.Size(97, 45);
            this.button10.TabIndex = 0;
            this.button10.Text = "Nạp file";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // aUDIOFILESTableAdapter
            // 
            this.aUDIOFILESTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Fr2WMP06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1282, 639);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAudioTest);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBoxAudioInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Fr2WMP06";
            this.Text = "Fr2WMP06 Quản lý file âm thanh dùng thư viện Window Media Player Lib";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fr2WMP06_FormClosing);
            this.Load += new System.EventHandler(this.Fr2WMP06_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aUDIOFILESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aP06TVNGANDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBoxAudioInfo.ResumeLayout(false);
            this.groupBoxAudioInfo.PerformLayout();
            this.groupBoxAudioTest.ResumeLayout(false);
            this.groupBoxAudioTest.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBoxAudioInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAudioTest;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    //    private AP06TVNGANDataSet1TableAdapters.AUDIOFILESTableAdapter aUDIOFILESTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private AP06TVNGANDataSet1 aP06TVNGANDataSet1;
        private System.Windows.Forms.BindingSource aUDIOFILESBindingSource1;
        private AP06TVNGANDataSet1TableAdapters.AUDIOFILESTableAdapter aUDIOFILESTableAdapter;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}