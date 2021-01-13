using LeTruongNam.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeTruongNam.GUI
{
    public partial class formDanhBa : Form
    {
        String tenNhom;
        public formDanhBa()
        {
            InitializeComponent();
        }
        public formDanhBa(String TenNhom)
        {
            InitializeComponent();
            LoadComboBox();
            cbbTenNhom.SelectedItem = TenNhom;
            tenNhom = TenNhom;
        }

        private void LoadComboBox()
        {
            var db = new QLDanhBaDB();
            var ls = db.NHOMs.Select(t => t.TenNhom).ToList();
            cbbTenNhom.DataSource = ls;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                String TxtNhom = cbbTenNhom.Text;
                String Txtemail = txtEmail.Text;
                String TxtDiaChi = txtDiaChi.Text;
                String TxtSoDienThoai = txtSoDienThoai.Text;
                var db = new QLDanhBaDB();
                db.DS_DANHBA.Add(new DS_DANHBA
                {
                    ID = Guid.NewGuid().ToString(),
                    TenNhom = TxtNhom,
                    DiaChi = TxtDiaChi,
                    Email = Txtemail,
                    SoDienThoai = TxtSoDienThoai
                });
                db.SaveChanges();
                DialogResult = DialogResult.OK;

            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
