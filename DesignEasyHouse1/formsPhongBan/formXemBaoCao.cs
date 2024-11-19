using DesignEasyHouse1.DAO;
using DesignEasyHouse1.DTO;
using System;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsPhongBan
{
    public partial class formXemBaoCao : Form
    {
        BaoCaoDoanhThuChiPhi baoCao = null;

        public formXemBaoCao(int baoCaoID)
        {
            InitializeComponent();
            this.baoCao = BaoCaoDoanhThuChiPhiDAO.Instance.LayBaoCaoBangID(baoCaoID);
        }

        void LoadForm()
        {
            if (this.baoCao == null)
            {
                return;
            }

            if (this.baoCao.FilePDF != null)
            {
                btnTaiFile.Visible = true;
            }

            txtPhanLoai.Text = this.baoCao.PhanLoai.ToString();
            txtThangNam.Text = this.baoCao.ThangNam.ToString("MM/yyyy");
            txtDoanhThu.Text = this.baoCao.DoanhThu.ToString();
            txtChiPhi.Text = this.baoCao.ChiPhi.ToString();
            txtNgayTao.Text = this.baoCao.NgayTao.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formXemBaoCao_Load(object sender, EventArgs e)
        {
            LoadForm();
        }



        private void btnTaiFile_Click(object sender, EventArgs e)
        {
            if (baoCao.FilePDF == null)
            {
                MessageBox.Show("Không có tệp đính kèm để tải.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files|*.pdf|Word Files|*.docx|Excel Files|*.xlsx";
                saveFileDialog.FileName = "BaoCao_" + baoCao.ThangNam.ToString("MM_yyyy");

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        System.IO.File.WriteAllBytes(saveFileDialog.FileName, baoCao.FilePDF);
                        MessageBox.Show("Tệp đã được tải xuống thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi lưu tệp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
