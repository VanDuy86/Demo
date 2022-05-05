using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTQL_BANHANG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            uC_WellCome1.BringToFront();
            uC_NhapHang1.Visible = false;
            uC_XuatHang1.Visible = false;
            
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            uC_NhapHang1.Visible = true;
            uC_NhapHang1.BringToFront();

            uC_WellCome1.Visible = false;
            uC_XuatHang1.Visible = false;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            uC_WellCome1.BringToFront();
            uC_WellCome1.Visible = true;

            uC_NhapHang1.Visible = false;
            uC_XuatHang1.Visible = false;

        }

        private void btnXuatHang_Click(object sender, EventArgs e)
        {
            uC_XuatHang1.Visible = true;
            uC_XuatHang1.BringToFront();

            uC_NhapHang1.Visible = false;
            uC_WellCome1.Visible = false;
            
        }

      
    }
}
