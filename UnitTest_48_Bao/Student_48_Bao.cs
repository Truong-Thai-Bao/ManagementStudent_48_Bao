using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_48_Bao
{
    internal class Student_48_Bao
    {
        //Biến dùng để tăng id tự động
        public static int count = 0;
        //Các thông tin cơ bản của một học viên
        public int MaSo_48_Bao { get; set; }
        public string HoTen_48_Bao { get; set; }
        public string QueQuan_48_Bao { get; set; }
        public double DiemToan_48_Bao { get; set; }
        public double DiemVan_48_Bao { get; set; }
        public double DiemAnh_48_Bao { get; set; }

        //Constructor không tham số 
        public Student_48_Bao()
        {
            //Mỗi lần tạo thì id sẽ tăng lên 1 đơn vị
            MaSo_48_Bao = ++count;
        }
        //Hàm tính điểm trung bình . Trả ra kết quả điểm trung bình
        public double DiemTrungBinh() => (DiemToan_48_Bao + DiemVan_48_Bao + DiemAnh_48_Bao) / 3;

        //Hàm xét điều kiện nhận học bổng . Trả ra True nếu đủ điều kiện 
        public bool DuocHocBong() => DiemTrungBinh() >= 8.0 && DiemToan_48_Bao >= 5 && DiemVan_48_Bao >= 5 && DiemAnh_48_Bao >= 5;

    }
}
