using System;
using System.IO;
using System.Windows.Forms;
using DesignEasyHouse1.DTO;
using DesignEasyHouse1.DAO;
using System.Collections.Generic;

namespace DesignEasyHouse1.formsPhongBan.PhongDuAnThiCong
{
    public partial class formBaoCaoDuAnThiCong : Form
    {
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        public formBaoCaoDuAnThiCong()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "PDF Files|*.pdf|Word Files|*.docx;*.doc|Excel Files|*.xlsx;*.xls";

            dtpThangNam.Format = DateTimePickerFormat.Custom;
            dtpThangNam.CustomFormat = "MM/yyyy";
            dtpThangNam.ShowUpDown = true;
            dtpThangNam.Value = DateTime.Now.AddMonths(-1);

            LoadDTGV();
            dtgvBaoCao.CellFormatting += dtgvBaoCao_CellFormatting;
            btnGuiBaoCao.Click += btnGuiBaoCao_Click;
            dtgvBaoCao.CellContentClick += dtgvBaoCao_CellContentClick;
        }

        void LoadDTGV()
        {
            string phanLoai = "Dự án thi công";
            dtgvBaoCao.DataSource = BaoCaoDoanhThuChiPhiDAO.Instance.LayBaoCaoTheoPhanLoai(phanLoai);
            dtgvBaoCao.Columns["BaoCaoID"].HeaderText = "ID";
            dtgvBaoCao.Columns["PhanLoai"].HeaderText = "Phân Loại";
            dtgvBaoCao.Columns["PhanLoai"].Visible = false;
            dtgvBaoCao.Columns["ThangNam"].HeaderText = "Tháng";
            dtgvBaoCao.Columns["DoanhThu"].HeaderText = "Doanh Thu";
            dtgvBaoCao.Columns["ChiPhi"].HeaderText = "Chi Phí";
            dtgvBaoCao.Columns["NgayTao"].HeaderText = "Ngày tạo";
            MyGUI.chuyenCotDenCuoiDTGV(dtgvBaoCao, new List<string> { "Delete", "Details"});
            MyGUI.dinhDangCotAllCellsDTGV(dtgvBaoCao, new List<string> { "BaoCaoID" });
        }


        void GuiBaoCao()
        {
            string phanLoai = "Dự án thi công";
            DateTime thangNam = dtpThangNam.Value;

            //thangNam = new DateTime(thangNam.Year, thangNam.Month, 1);

            // Kiểm tra báo cáo đã tồn tại
            if (BaoCaoDoanhThuChiPhiDAO.Instance.KiemTraBaoCaoTheoThangPhanLoai(thangNam, phanLoai))
            {
                MessageBox.Show("Báo cáo cho tháng này đã tồn tại. Không thể gửi báo cáo thêm lần nữa. Vui lòng liên hệ phòng tài chính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            float doanhThu = (float)nudDoanhThu.Value;
            float chiPhi = (float)nudChiPhi.Value;
            byte[] filePDF = null;

            // Hỏi người dùng có muốn đính kèm file không, trường hợp không chọn file thì file là null
            DialogResult fileDialogResult = MessageBox.Show(
                "Bạn có muốn đính kèm file không?",
                "Chọn file đính kèm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (fileDialogResult == DialogResult.Yes)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePDF = File.ReadAllBytes(openFileDialog1.FileName);
                }
            }

            DialogResult confirmResult = MessageBox.Show(
                "Bạn có chắc chắn muốn gửi báo cáo này không? Mỗi một tháng chỉ gửi một lần",
                "Xác nhận gửi báo cáo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            BaoCaoDoanhThuChiPhi baoCao = new BaoCaoDoanhThuChiPhi
            {
                PhanLoai = phanLoai,
                ThangNam = thangNam,
                DoanhThu = doanhThu,
                ChiPhi = chiPhi,
                FilePDF = filePDF
            };

            bool result = BaoCaoDoanhThuChiPhiDAO.Instance.ThemBaoCao(baoCao);

            if (result)
            {
                MessageBox.Show("Báo cáo đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDTGV();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi gửi báo cáo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void XemChiTiet(int baoCaoID)
        {
            formXemBaoCao f = new formXemBaoCao(baoCaoID);
            f.ShowDialog();
        }

        private void btnGuiBaoCao_Click(object sender, EventArgs e)
        {
            GuiBaoCao();
        }

        private void dtgvBaoCao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtgvBaoCao.Columns[e.ColumnIndex].Name == "ThangNam" && e.Value != null)
            {
                DateTime thangNam = (DateTime)e.Value;
                // Hiển thị chỉ Tháng/Năm
                e.Value = thangNam.ToString("MM/yyyy");
                e.FormattingApplied = true;
            }
        }

        private void dtgvBaoCao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgvBaoCao.Columns["Details"].Index)
            {
                int baoCaoID = Convert.ToInt32(dtgvBaoCao.Rows[e.RowIndex].Cells["BaoCaoID"].Value);
                XemChiTiet(baoCaoID);
            }
        }

    }
}
