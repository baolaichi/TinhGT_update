using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVGiaiThua;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       

        private void Tinh_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBox1.Text);
                int result = (int)TVGiaiThua.TVGiaiThua.TinhGT_1(number);

                MessageBox.Show("Giai thừa của " + number + " là: " + result);
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập lại số.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
