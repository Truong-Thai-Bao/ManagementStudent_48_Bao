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

    public partial class AddNewStudent_48_Bao : Form
    {
        public string name_48_Bao = "";
        public string hometown_48_Bao = "";
        public double diemToan_48_Bao = 0;
        public double diemVan_48_Bao = 0;
        public double diemAnh_48_Bao = 0;

        public AddNewStudent_48_Bao()
        {
            InitializeComponent();
        }

        private void btnAdd_48_Bao_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ textbox
            name_48_Bao = txtName_48_Bao.Text.Trim();
            hometown_48_Bao = txtCountry_48_Bao.Text.Trim();

            // Kiểm tra tên và quê quán không được để trống
            if (string.IsNullOrWhiteSpace(name_48_Bao))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(hometown_48_Bao))
            {
                MessageBox.Show("Vui lòng nhập quê quán!", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra ô điểm không được để trống
            if (string.IsNullOrWhiteSpace(txtDiemToan_48_Bao.Text) ||
                string.IsNullOrWhiteSpace(txtDiemVan_48_Bao.Text) ||
                string.IsNullOrWhiteSpace(txtDiemAnh_48_Bao.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ điểm các môn!", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem các ô điểm có hợp lệ không trước khi chuyển đổi
            if (!double.TryParse(txtDiemToan_48_Bao.Text, out diemToan_48_Bao) ||
                !double.TryParse(txtDiemVan_48_Bao.Text, out diemVan_48_Bao) ||
                !double.TryParse(txtDiemAnh_48_Bao.Text, out diemAnh_48_Bao))
            {
                MessageBox.Show("Vui lòng nhập điểm hợp lệ!", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra không cho nhập điểm âm
            if (diemToan_48_Bao < 0 || diemVan_48_Bao < 0 || diemAnh_48_Bao < 0)
            {
                MessageBox.Show("Điểm không được nhỏ hơn 0!", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu mọi thứ hợp lệ, đóng form và lưu dữ liệu
            this.DialogResult = DialogResult.OK;
            txtName_48_Bao.Text = string.Empty;
            txtCountry_48_Bao.Text = string.Empty;
            txtDiemToan_48_Bao.Text = string.Empty;
            txtDiemAnh_48_Bao.Text = string.Empty;
            txtDiemVan_48_Bao.Text = string.Empty;
        }
    }
}
