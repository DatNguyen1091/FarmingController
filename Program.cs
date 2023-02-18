// Xây dựng một ứng dụng để quản lý lượng thức ăn tiêu thụ cho trang trại.
// Trang trại nuôi:
//- Bò sữa: 30kg cỏ/ ngày/ con  150.000
//- Gà mái đẻ: 200g bắp/ ngày/ con  5.000
//- Heo thịt: 20kg cám/ ngày/ con 100.000
//- Chó: 2kg thịt/ ngày/ con  20.000
// Ứng dụng có thể tính toán lượng thức ăn tiêu thụ cho từng loại/ngày 
// cùng với số tiền phải chi/ngày cho thức ăn tương ứng.

//////////////////////////////////////////////////
namespace Project_test
{
    class Program
    {
        static void Main(string[] args)
        {
            FarmingController controller = new FarmingController();

            controller.Menu();
            controller.UserCommand();    
               
        }
    }
}
