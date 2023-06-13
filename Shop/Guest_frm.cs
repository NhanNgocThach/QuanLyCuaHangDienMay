using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class Guest_frm : Form
    {
        
        public Guest_frm()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guest_info_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Guest_frm_Load(object sender, EventArgs e)
        {

        }

        private void guest_phone_TextChanged(object sender, EventArgs e)
        {
            string phoneNumber = guest_phone.Text;
            int characterCount = guest_phone.Text.Length;
            int RequiredLength = 10;
            foreach (char c in phoneNumber)
            {

                // Kiểm tra ràng buộc số điện thoại 10 chữ số

                // if (Regex.IsMatch(phoneNumber, @"^[a-zA-Z]"))
                if (!char.IsDigit(c))
                {
                    // Hiển thị thông báo hoặc thực hiện xử lý khác tùy ý
                    guest_phone.Text = guest_phone.Text.Substring(0, guest_phone.Text.Length - 1);
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại 10 chữ số.");

                }
            }

            if (guest_phone.Text.Length < RequiredLength)
            {
                error_label.Visible = true;
                error_label.Text = "Vui lòng nhập đủ " + RequiredLength + " ký tự.";
                // Hiển thị thông báo lỗi hoặc thực hiện các hành động khác khi không đủ số lượng ký tự
            }
            else
            {
                error_label.Text = ""; // Xóa thông báo lỗi nếu đủ số lượng ký tự
                                       // Thực hiện các hành động khác khi đủ số lượng ký tự

            }
        }
            private void guest_phone_KeyDown(object sender, KeyEventArgs e)
        {
           

        }
       

    }
}
