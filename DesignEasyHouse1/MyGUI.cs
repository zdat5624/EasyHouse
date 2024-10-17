using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1
{
    public static class MyGUI
    {
        public static void chuyenCotDenCuoiDTGV(DataGridView dtgv, List<string> lstTenCot)
        {
            lstTenCot.Reverse();

            for (int i = 0; i < lstTenCot.Count; i++)
            {
                string strTenCot = lstTenCot[i];
                if (dtgv.Columns.Contains(strTenCot))
                {
                    dtgv.Columns[strTenCot].DisplayIndex = dtgv.Columns.Count - 1 - i;
                }
            }
        }

        public static void dinhDangCotAllCellsDTGV(DataGridView dtgv, List<string> lstTenCot)
        {

            foreach (string strTenCot in lstTenCot)
            {
                if (dtgv.Columns.Contains(strTenCot))
                {
                    dtgv.Columns[strTenCot].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Lưu ảnh vào MemoryStream dưới dạng định dạng PNG, bạn có thể thay đổi định dạng khác nếu muốn.
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray(); // Chuyển đổi MemoryStream thành mảng byte[]
            }
        }

        public static Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
