# Tính Giai Thừa Của 1 Số
BTVN: ASP.NET
--------------------------------------------
 ## --Thông Tin Cá nhân--
 ### Tác Giả: Lại Chí Bảo   
 ### Lớp: K57KMT.01           
 ### MSSV: K215520216829
-------------------------------------------
 
      
I. Tạo một Console Application (TinhGT):
   - Mở Visual Studio.
   - Chọn File > New > Project....
   - Chọn Console App (.NET Framework) hoặc Console App (.NET Core).
   - Đặt tên cho project là Console1 và chọn Create.
   - Viết mã để tính giai thừa:


```using System;
namespace TinhGT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập một số nguyên dương để tính giai thừa:");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                long result = CalculateFactorial(number);
                Console.WriteLine($"Giai thừa của {number} là: {result}");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ.");
            }
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
        static long TinhGT_1(int number)
        {
            if (number == 0 || number == 1) return 1;
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
```


II. Chuyển phần xử lý sang DLL
   - Tạo một Class Library project:
   - Viết mã trong Class Library:
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVGiaiThua
{
    public class TVGiaiThua
    {
        public static long TinhGT_1(int number)
        {
            if (number == 0 || number == 1) return 1;
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
```
III. Console Application 2 - Sử dụng DLL
   - Tạo một project Console App (Console2)
   - Thêm tham chiếu tới DLL
   - Sử dụng DLL trong Console2:

```
      using System;
using TVGiaiThua;
namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập một số nguyên dương để tính giai thừa:");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                long result = TVGiaiThua.TVGiaiThua.TinhGT_1(number);
                Console.WriteLine($"Giai thừa của {number} là: {result}");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ.");
            }
            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
```
IV. Web Application - Phiên bản 1 (Web Forms)
  - Cập nhật index.aspx

```
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web1.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TÍNH GIAI THỪA</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="color:darkgoldenrod">Chương Trình Tính Giai Thừa</h1>
        <h4>Hãy nhập một số để tính giai thừa</h4>
        
        <asp:Label ID="Label1" runat="server" Height="20" Width="200" Text="Nhập số:"></asp:Label>
        <asp:TextBox ID="txt_number" runat="server" Height="28" Width="100"></asp:TextBox>
        <asp:Button ID="btn_calculate" Height="50" Width="150" runat="server" Text="Tính giai thừa" OnClick="btn_calculate_Click" />

        <br /><br />
        <asp:Label ID="lbl_result" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
```
  - Sửa đổi index.aspx.cs

```
using System;
using System.Web.UI;
using TVGiaiThua; // Đảm bảo rằng thư viện TVGiaiThua.DLL đã được thêm vào project

namespace Web1
{
    public partial class index : Page
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
                int result = Factorial.GiaiThua(number);

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
```
  - Thêm thư viện TVGiaiThua.DLL
  - Chạy và Kiểm Tra
##    Tổng Kết
Với những bước trên, bạn đã tạo giao diện và mã của trang web tính giai thừa, sử dụng thư viện TVGiaiThua.DLL. 
