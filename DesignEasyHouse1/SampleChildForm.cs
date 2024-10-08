using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1
{
    public partial class SampleChildForm : Form
    {
        public SampleChildForm()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Giá trị 1", "Giá trị 2", "Giá trị 3", "Giá trị 4", "Giá trị 5");
        }
    }
}
