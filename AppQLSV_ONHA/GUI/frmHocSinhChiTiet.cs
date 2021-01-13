using AppQLSV_ONHA.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLSV_ONHA.GUI
{
    public partial class frmHocSinhChiTiet : Form
    {
        Student HocSinh;
        public frmHocSinhChiTiet(String Lop)
        {
            InitializeComponent();
            LoadComboBox();
           
            cbbClass.SelectedItem = Lop;
        }
         public frmHocSinhChiTiet(Student student)
        {
            InitializeComponent();
            this.Text = "Sửa Sinh viên";
            btnAccept.Text = "Sửa";
            HocSinh = student;
            txtID.Text = student.ID;
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            dtpDateOfBirth.Value =(DateTime) student.DateOfBirth;
            txtPlaceOfBirth.Text = student.PlaceOfBirth;
            switch (student.Gender)
            {
                case 1:
                    rdbMale.Checked = true;
                    break;
                case 0:
                    rdbFemale.Checked = true;
                    break;
                case -1:
                    rdbOther.Checked = true;
                    break;

            }
            LoadComboBox();

            var db = new AppQLSVDB();
            Classroom LopDuocChon = db.Classrooms.Where(t => t.ID == student.IDClassroom).FirstOrDefault();
            cbbClass.SelectedItem = LopDuocChon.Name;

        }

        private void LoadComboBox()
        {
            var db = new AppQLSVDB();
            var list = db.Classrooms.Select(t => t.Name).ToList();
            cbbClass.DataSource = list;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            var db = new AppQLSVDB();
            var LopDangChon = db.Classrooms.Where(t => t.Name == cbbClass.Text).FirstOrDefault();
            String ID = txtID.Text;
            String FirstName = txtFirstName.Text;
            String LastName = txtLastName.Text;
            DateTime DateOfBirth = dtpDateOfBirth.Value;
            String PlaceOfBirth = txtPlaceOfBirth.Text;
            int Gender = rdbMale.Checked ? 1 : rdbFemale.Checked ? 0 : -1;
            String IDClassroom = LopDangChon.ID;
            if (HocSinh == null)
            {
               

                db.Students.Add(new Student
                {
                    ID = ID,
                    FirstName = FirstName,
                    LastName = LastName,
                    DateOfBirth = DateOfBirth,
                    PlaceOfBirth = PlaceOfBirth,
                    Gender = Gender,
                    IDClassroom = IDClassroom
                });
              
             


            }
            else
            {
                var HocSinhSua = db.Students.Where(t => t.ID == HocSinh.ID).FirstOrDefault();
                HocSinhSua.ID = ID;
                HocSinhSua.FirstName = FirstName;
                HocSinhSua.LastName = LastName;
                HocSinhSua.DateOfBirth = DateOfBirth;
                HocSinhSua.PlaceOfBirth = PlaceOfBirth;
                HocSinhSua.Gender = Gender;
                HocSinhSua.IDClassroom = IDClassroom;

            }
            db.SaveChanges();
            DialogResult = DialogResult.OK;
        }
    }
}
