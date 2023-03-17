using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IrrKlang;

namespace AP06TVNGAN
{
    public partial class FormMain06 : Form
    {
        public FormMain06()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            timer1_Tick(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = System.DateTime.Now.ToShortDateString() + " : " + System.DateTime.Now.ToLongTimeString();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(ch ==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void quảnLýÂmThanhDùngWMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Fr2WMP06 obj = new Fr2WMP06();
                obj.ShowDialog();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi khi mo form");
            }

        }

        private void quảnLýÂmThanhDùngIrrKlangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Fr3irrKLang06 obj = new Fr3irrKLang06();
                obj.ShowDialog();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Loi khi mo form");
            }
            
        }

        private void tắtMởThanhCôngCụToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        private void tắtMởDòngTrạngTháiStatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = !statusStrip1.Visible;
        }

        private void tắtMởThanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = !menuStrip1.Visible;
        }

        private void tắtFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible; //con trỏ This là Forn hiện tại
        }
    }
}
