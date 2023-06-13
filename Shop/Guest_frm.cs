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
            // Tạo card form đầu tiên
            CreateCardForm("Card 1", "This is the content of Card 1");

            // Tạo card form thứ hai
          //  CreateCardForm("Card 2", "This is the content of Card 2");
        }

        private void guest_phone_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void guest_phone_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        private void check_number(object sender, KeyPressEventArgs e)
        {
            string phoneNumber = guest_phone.Text;
            int characterCount = guest_phone.Text.Length;
            int RequiredLength = 10;
            foreach (char c in phoneNumber)
            {

                // Kiểm tra ràng buộc số điện thoại 10 chữ số

                // if (Regex.IsMatch(phoneNumber, @"^[a-zA-Z]"))
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // Hiển thị thông báo hoặc thực hiện xử lý khác tùy ý
                    // guest_phone.Text = guest_phone.Text.Substring(0, guest_phone.Text.Length - 1);
                    e.Handled = true;
                    error_label.Text = "Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại 10 chữ số.";
                    this.Select();
                }
            }

            if ((guest_phone.Text.Length < RequiredLength) || (guest_phone.Text.Length > RequiredLength))
            {
                error_label.Visible = true;
                error_label.Text = "Vui lòng đúng " + RequiredLength + " ký tự.";
                // Hiển thị thông báo lỗi hoặc thực hiện các hành động khác khi không đủ số lượng ký tự
            }
            else
            {
                error_label.Text = ""; // Xóa thông báo lỗi nếu đủ số lượng ký tự
                                       // Thực hiện các hành động khác khi đủ số lượng ký tự
            }

        }
       

        private void guest_id_TextChanged(object sender, EventArgs e)
        {

        }

        public void CreateCardForm(string title, string content)
        {
            // Tạo form cho card
            Panel guestCard = new Panel();
            guestCard.BorderStyle = BorderStyle.FixedSingle;
            guestCard.BackColor = Color.Red;
            guestCard.Size = new Size(120, 78);

            // Tạo PictureBox
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(@"C:\Users\Administrator\AppData\Roaming\Microsoft\Windows\Network Shortcuts\B1805657_08.png");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Width = 100;


            // Tạo các controls cho card form
            Label titleLabel = new Label();
            titleLabel.Text = title;
            titleLabel.Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            titleLabel.Dock = DockStyle.Top;

            Label contentLabel = new Label();
            contentLabel.Text = content;
            contentLabel.Font = new Font(FontFamily.GenericSansSerif, 10);
            contentLabel.Dock = DockStyle.Fill;

            //   guest_info_panel.TopLevelControl = false;

            guest_info_panel.Controls.Add(pictureBox);
            guest_info_panel.Controls.Add(titleLabel);
            guest_info_panel.Controls.Add(contentLabel);

            // Thêm card panel vào form chính
            Controls.Add(guest_info_panel);

            // Đặt vị trí card panel
            guest_info_panel.Top = (Controls.Count - 1) * guest_info_panel.Height + 10;

        }
    }
}
