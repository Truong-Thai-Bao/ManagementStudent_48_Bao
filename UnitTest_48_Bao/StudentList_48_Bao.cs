using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace UnitTest_48_Bao
{
    public partial class StudentList_48_Bao : Form
    {
        //Khởi tạo danh sách học viên
        private List<Student_48_Bao> stuList_48_Bao_48_Bao = new List<Student_48_Bao>();
        public StudentList_48_Bao()
        {
            InitializeComponent();
        }

        private void btnAdd_48_Bao_Click(object sender, EventArgs e)
        {
            //Gọi form thêm học viên
            AddNewStudent_48_Bao add_48_Bao = new AddNewStudent_48_Bao();

            //Sử dụng try catch để tránh bị ngắt chương trình lúc thực thi 
            try
            {
                if (add_48_Bao.ShowDialog() == DialogResult.OK)
                {
                    //Tạo học viên mới và gán thông tin 
                    Student_48_Bao hv_48_Bao = new Student_48_Bao()
                    {
                        HoTen_48_Bao = add_48_Bao.name_48_Bao,
                        QueQuan_48_Bao = add_48_Bao.hometown_48_Bao,
                        DiemToan_48_Bao = add_48_Bao.diemToan_48_Bao,
                        DiemVan_48_Bao = add_48_Bao.diemVan_48_Bao,
                        DiemAnh_48_Bao = add_48_Bao.diemAnh_48_Bao
                    };
                    //Thêm học viên vào danh sách
                    stuList_48_Bao_48_Bao.Add(hv_48_Bao);
                    //Gọi hàm hiển thị danh sách
                    HienThiDanhSach_48_Bao(stuList_48_Bao_48_Bao);
                }
            }
            catch (Exception ex)
            {
                //Hiển thị thất bại
                MessageBox.Show("Lỗi nhập dữ liệu! " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Hàm hiển thị danh sách ra dgv
        private void HienThiDanhSach_48_Bao(List<Student_48_Bao> danhSach_48_Bao)
        {
            //Làm mới dgv
            dgv_48_Bao.DataSource = null;
            //Gán dgv là danh sách hiện tại
            dgv_48_Bao.DataSource = danhSach_48_Bao;
        }

        private void btnFilter_48_Bao_Click(object sender, EventArgs e)
        {
            //Lọc theo điều kiện đã được viết trong hàm DuocHocBong()
            var danhSachHocBong_48_Bao = stuList_48_Bao_48_Bao.Where(hv => hv.DuocHocBong()).ToList();
            //Hiển thị danh sách ra
            HienThiDanhSach_48_Bao(danhSachHocBong_48_Bao);
        }
    }
}
