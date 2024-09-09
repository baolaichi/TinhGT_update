using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TVGiaiThua;

namespace web_v1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ TextBox
                int number = int.Parse(txt_number.Text);

                // Tính giai thừa sử dụng thư viện TVGiaiThua
                int result = (int)TVGiaiThua.TVGiaiThua.TinhGT_1(number);

                // Hiển thị kết quả
                lbl_result.Text = "Giai thừa của " + number + " là: " + result;
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi nếu có
                lbl_result.Text = "Đã xảy ra lỗi: " + ex.Message;
            }
        }

    }
}