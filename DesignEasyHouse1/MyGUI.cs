using System;
using System.Collections.Generic;
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
    }
}
