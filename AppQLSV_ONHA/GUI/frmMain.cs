using AppQLSV_ONHA.DAL;
using AppQLSV_ONHA.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLSV_ONHA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            GridSinhVien.AutoGenerateColumns = false;
            DanhSachLopHoc();
        }

        public void DanhSachLopHoc()
        {
            var db = new AppQLSVDB();
            var Class = db.Classrooms.Select(e=> new ClassroomViewModel
            { 
                ID = e.ID,
                Name = e.Name,
                Room = e.Room,
                TongNam = e.Students.Where(t => t.Gender == 1).Count(),
                TongNu = e.Students.Where(t => t.Gender == 0).Count(),
                TotalStudent = e.Students.Count()
                
            }).ToList();
            BDSLopHoc.DataSource = Class;
            dataGridView1.DataSource = BDSLopHoc;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var LopDangChon = BDSLopHoc.Current as Classroom;
            if (LopDangChon != null)
            {
                var db = new AppQLSVDB();
                var Lop = db.Classrooms.Where(t => t.ID == LopDangChon.ID).FirstOrDefault();
                if (Lop != null)
                {

                    var rs = MessageBox.Show("Bạn có muốn xóa?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (rs == DialogResult.OK)
                    {
                        var HocSinh = db.Students.Where(t => t.IDClassroom == LopDangChon.ID).ToList();
                        foreach (Student student in HocSinh)
                        {
                            db.Students.Remove(student);
                        }
                        db.Classrooms.Remove(Lop);
                        db.SaveChanges();
                    }

                    DanhSachLopHoc();
                }

            }
        }

        private void BDSLopHoc_CurrentChanged(object sender, EventArgs e)
        {
            var LopDangChon= BDSLopHoc.Current as ClassroomViewModel;
          
            if (LopDangChon != null)
            {
                var db = new AppQLSVDB();
                var dssv = db.Students.Where(t => t.IDClassroom == LopDangChon.ID).ToList();
                BDSSinhVien.DataSource = dssv;
                GridSinhVien.DataSource = BDSSinhVien;
            }
        }

        private void BDSSinhVien_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void BtnThemLop_Click(object sender, EventArgs e)
        {
            frmLopChiTiet f = new frmLopChiTiet();
            if(f.ShowDialog()==DialogResult.OK)
                DanhSachLopHoc();
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            var LopDangChon = BDSLopHoc.Current as Classroom;
            if (LopDangChon != null)
            {
                var f = new frmLopChiTiet(LopDangChon);
                if(f.ShowDialog()== DialogResult.OK)
                {
                    DanhSachLopHoc();
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            var LopDuocChon = BDSLopHoc.Current as ClassroomViewModel;
            String Lop = LopDuocChon.Name;
            var f = new frmHocSinhChiTiet(Lop); 
            if(f.ShowDialog()== DialogResult.OK)
            {
                DanhSachLopHoc();   
            }
        }

        private void btnSuaSinhVien_Click(object sender, EventArgs e)
        { 
            var db = new AppQLSVDB();
            var HocSinhDangChon = BDSSinhVien.Current as Student;
            if(HocSinhDangChon!=null)
            if (HocSinhDangChon.ID != null)
            {
                var f = new frmHocSinhChiTiet(HocSinhDangChon);

                if (f.ShowDialog() == DialogResult.OK)
                {
                    DanhSachLopHoc();
                }

            }
               

        }

        private void btnXoaSinhVien_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có muốn xóa","Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(rs == DialogResult.OK)
            {
                var db = new AppQLSVDB();
                var SV = BDSSinhVien.Current as Student;
                var SinhVienDuocChon = db.Students.Where(t => t.ID == SV.ID).FirstOrDefault();
                db.Students.Remove(SinhVienDuocChon);
                db.SaveChanges();
                DanhSachLopHoc();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var db = new AppQLSVDB();
            var Lop = BDSLopHoc.Current as ClassroomViewModel;
            
            var f = new frmEcxel(Lop.ID);
            if(f.ShowDialog() == DialogResult.OK)
            {
                DanhSachLopHoc();
            }
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
