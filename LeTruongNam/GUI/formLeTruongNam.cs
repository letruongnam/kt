using LeTruongNam.DAL;
using LeTruongNam.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeTruongNam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gridNhom.AutoGenerateColumns = false;
            gridDanhBa.AutoGenerateColumns = false;
            DanhSachNhom();
        }

        private void DanhSachNhom()
        {
            var db = new QLDanhBaDB();
            var ls = db.NHOMs.ToList();
            bdsNhom.DataSource = ls;
            gridNhom.DataSource = bdsNhom;
        }

        private void bdsNhom_CurrentChanged(object sender, EventArgs e)
        {
            var NhomDuocChon = bdsNhom.Current as NHOM;
            if (NhomDuocChon != null)
            {
                var db = new QLDanhBaDB();
                var ls = db.DS_DANHBA.Where(l => l.TenNhom == NhomDuocChon.TenNhom).ToList();
                bdsDanhBa.DataSource = ls;
                gridDanhBa.DataSource = bdsDanhBa;
            }
        }

        private void bdsDanhBa_CurrentChanged(object sender, EventArgs e)
        {
            var DanhBaDuocChon = bdsDanhBa.Current as DS_DANHBA;
            if (DanhBaDuocChon != null)
            {
                lblTenGoi.Text = DanhBaDuocChon.TenNhom;
                lblSoDienThoai.Text = DanhBaDuocChon.SoDienThoai;
                lblDiaChi.Text = DanhBaDuocChon.DiaChi;
                lblEmail.Text = DanhBaDuocChon.Email;
            }
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            var f = new formThemNhom();
            if(f.ShowDialog()==DialogResult.OK)
            {
                DanhSachNhom();
            }    
            
        }

        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có thực sự muốn xóa không? ",
                                          "chú ý",
                                          MessageBoxButtons.OKCancel,
                                          MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                var db = new QLDanhBaDB();
                var NhomDuocChon = bdsNhom.Current as NHOM;
                if (NhomDuocChon != null)
                {
                    String TenNhom = NhomDuocChon.TenNhom;
                    var DANHBA = db.DS_DANHBA.Where(t => t.TenNhom == NhomDuocChon.TenNhom).ToList();
                    foreach (DS_DANHBA danhba in DANHBA)
                    {
                        db.DS_DANHBA.Remove(danhba);
                    }
                    NHOM NhomXoa = db.NHOMs.Where(t => t.TenNhom == NhomDuocChon.TenNhom).FirstOrDefault();
                    db.NHOMs.Remove(NhomXoa);
                    db.SaveChanges();
                    DanhSachNhom();
                }
            }
        }

        private void btnThemLienLac_Click(object sender, EventArgs e)
        {
            var NhomDangChon = bdsNhom.Current as NHOM;
            if (NhomDangChon != null)
            {
                var f = new formDanhBa(NhomDangChon.TenNhom);
                if (f.ShowDialog() == DialogResult.OK)
                {
                    DanhSachNhom();
                }
            }
        }

        private void btnXoaLienLac_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có thực sự muốn xóa không? ",
                                          "chú ý",
                                          MessageBoxButtons.OKCancel,
                                          MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
                var db = new QLDanhBaDB();
                var DanhBaDangChon = bdsDanhBa.Current as DS_DANHBA;
                if (DanhBaDangChon != null)
                {
                    DS_DANHBA Danhba = db.DS_DANHBA.Where(t => t.TenNhom == DanhBaDangChon.TenNhom).FirstOrDefault();
                    db.DS_DANHBA.Remove(Danhba);
                    db.SaveChanges();
                    DanhSachNhom();
                }
            }
        }

        private void KeyDownEnter(object sender, KeyEventArgs e)
        {
            var NhomDangChon = bdsNhom.Current as NHOM;
            if(e.KeyCode == Keys.Enter)
            {
                String Tim = textBoxTimKiem.Text;
                if (Tim != null)
                {
                    var db = new QLDanhBaDB();
                    var ls = db.DS_DANHBA.Where(t => t.TenNhom == NhomDangChon.TenNhom && (t.SoDienThoai.Contains(Tim) || t.Email.Contains(Tim))).ToList();
                    
                    gridDanhBa.DataSource = ls;
                }
                else
                {

                }
            }
        }
    }
}
