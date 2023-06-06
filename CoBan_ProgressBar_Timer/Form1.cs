using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoBan_ProgressBar_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_1_Tick(object sender, EventArgs e)
        {
            // Tạo sự kiện hiển thì ngày tháng hiện tại
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            label1.Text = String.Format("{0:hh:mm:ss tt}", dt);
            lblNgayThang.Text = String.Format("{0:dd/MM/yyyy}", dt);
        }

        private void tmr_2_Tick(object sender, EventArgs e)
        {
            // Tạo sự kiện hiển thị % thực hiện công việc và khi đạt 100% thì load form2
            Form2 frm = new Form2();

            progressBar1.Increment(1);  // Tăng giá trị ProgressBar
            lblLoading.Text = "Connecting to from " + progressBar1.Value.ToString() + "%";
            if(progressBar1.Value == progressBar1.Maximum)  // Mặc định: Minimum = 0, Maximum = 100
            {
                tmr_2.Enabled = false;  // tmr_2.stop();
                frm.ShowDialog();
            }    
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if(progressBar1.Enabled)
            {
                progressBar1.Enabled = false;
                tmr_1.Start();
                tmr_2.Enabled = true;
            }    
            else
            {
                progressBar1.Enabled = true;
                tmr_1.Stop();
                tmr_2.Stop();
            }    
        }
    }
}
