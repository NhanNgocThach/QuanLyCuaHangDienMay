using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public class Funtions
    {
        public static SqlConnection Conn;  //Khai báo đối tượng kết nối        
        public static void Connect()
        {
            Conn = new SqlConnection();   //Khởi tạo đối tượng
            Conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WEB\myproject\Shop\Shop\mydb\qlch.mdf;Integrated Security=True";
            Conn.Open();                  //Mở kết nối
                                         //Kiểm tra kết nối
            if (Conn.State != ConnectionState.Open)               
             MessageBox.Show("Không thể kết nối với dữ liệu");
        }
        public static void Disconnect()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();    //Đóng kết nối
                Conn.Dispose();  //Giải phóng tài nguyên
                Conn = null;
            }
        }

        
    }
}

