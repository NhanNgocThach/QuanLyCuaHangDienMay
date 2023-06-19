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
            CreateCardForm();

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

        public void CreateCardForm()
        {
            int itemsPerPage = 5; // Số lượng phần tử hiển thị trên mỗi trang
            int currentPage = 0; // Trang hiện tại

            List<Panel> guest_list_control = new List<Panel>();
            // Thêm các shopItemPanel vào danh sách (giả sử đã có)

            int totalItems = guest_list_control.Count; // Tổng số phần tử trong danh sách
            int totalPages = (int)Math.Ceiling((double)totalItems / itemsPerPage); // Tính số trang
            
            // Tạo danh sách các shopItemPanel và thiết lập các thuộc tính
            for (int i = 0; i < 10; i++) // numberOfItems là số lượng phần tử trong danh sách
            {
                Panel shopItemPanel = new Panel();
                shopItemPanel.Name = "Card" + i;
                shopItemPanel.BackColor = Color.White;
                shopItemPanel.AutoSize = true;
                

                // Thiết lập các điều khiển bên trong shopItemPanel
                Label nameLabel = new Label();
                nameLabel.Text = "Product Name";
                shopItemPanel.Controls.Add(nameLabel);

                PictureBox imageBox = new PictureBox();
                imageBox.Image = Image.FromFile(@"C:\Users\Administrator\Desktop\images.png");
                imageBox.SizeMode = PictureBoxSizeMode.Zoom;
                shopItemPanel.Controls.Add(imageBox);

                // Thêm shopItemPanel vào danh sách
                guest_list_control.Add(shopItemPanel);                
            }

           /* foreach (Panel Panel in guest_list_control)
            {
                int topOffset = 0; // Khoảng cách top giữa các phần tử
                int leftOffset = 0; // Khoảng cách left giữa các phần tử               

                Panel.Dock = DockStyle.Top;
                Panel.Top = topOffset;
                Panel.Left = leftOffset;
                topOffset += Panel.Height; // Cập nhật khoảng cách top cho phần tử tiếp theo
                leftOffset += Panel.Width; // Cập nhật khoảng cách left cho phần tử tiếp theo (nếu cần)

                this.Controls.Add(Panel); // Thêm panel vào Form hoặc một điều khiển khác

            }*/
           /* FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Name = "guest_list_control";
            
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.WrapContents = false;
            flowLayoutPanel.AutoScroll = true;*/
            foreach (Panel shopItemPanel in guest_list_control)
            {
                shopItemPanel.AutoSize = true;
                


            }

            // Thêm flowLayoutPanel vào Form hoặc một điều khiển khác
            

            foreach (Panel shopItemPanel in guest_list_control)
            {
                guest_info_panel.Controls.Add(shopItemPanel);
            }
            



            // Thêm các panel con vào FlowLayoutPanel


            // Thêm FlowLayoutPanel vào parentPanel


            // Đặt Dock cho từng phần tử trong danh sách*/



        }
    }
}
