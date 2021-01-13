using APPQLNV.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPQLNV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DanhSachNhanVien();
        }

        private void DanhSachNhanVien()
        {
            var db = new Model1();
            var ls = db.NhanViens.ToList();
            bdsNhanVien.DataSource = ls;
            dataGridView1.DataSource = bdsNhanVien;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            String MaNv = txtMaNV.Text;
            String Ho = txtHo.Text;
            String Ten = txtTen.Text;
            String DiaChi = txtDiaChi.Text;
            String MatKhau = txtMatKhau.Text;
            String Quyen = txtQuyen.Text;
            var db = new Model1();
             db.NhanViens.Add(new NhanVien
            {
                 Manv = MaNv,
                 HoTen = Ho +Ten,
                 DiaChi = DiaChi,
                 MatKhau = MatKhau,
                 Quyen = Quyen,

            });
            db.SaveChanges();
            DanhSachNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var NhanVienDangChon = bdsNhanVien.Current as NhanVien;
            var db = new Model1();
            var NhanVienXoa = db.NhanViens.Where(t => t.Manv == NhanVienDangChon.Manv).FirstOrDefault();
            db.NhanViens.Remove(NhanVienXoa);
            db.SaveChanges();
            DanhSachNhanVien();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String MaNv = txtMaNV.Text;
            if (MaNv != null)
            {
                var db = new Model1();
                var ls = db.NhanViens.Where(t => t.Manv.Contains(MaNv)).ToList();
                dataGridView1.DataSource = ls;
            }
            else
            {
                var db = new Model1();
                var ls = db.NhanViens.ToList();
                dataGridView1.DataSource = ls;
            }

        }
    }
}
