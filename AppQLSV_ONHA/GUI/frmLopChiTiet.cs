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
    public partial class frmLopChiTiet : Form
    {
        Classroom LopSua = null;
        public frmLopChiTiet()
        {
            InitializeComponent();
        }
        public frmLopChiTiet(Classroom Class)
        {
            InitializeComponent();
            btnThem.Text = "Sửa";
            txtName.Text = Class.Name;
            txtRoom.Text = Class.Room;
            LopSua = Class;

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if (LopSua != null)
            {
                String Name = txtName.Text;
                String Room = txtRoom.Text;
                var db = new AppQLSVDB();
                var lop = db.Classrooms.Where(t => t.ID == LopSua.ID).FirstOrDefault();
                if (lop != null)
                {
                    lop.Name = Name;
                    lop.Room = Room;
                }
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            else
            try
            {

                String Name = txtName.Text;
                String Room = txtRoom.Text;
                var db = new AppQLSVDB();
                db.Classrooms.Add(new Classroom
                {
                    ID = Guid.NewGuid().ToString(),
                    Name = Name,
                    Room = Room
                });
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch
            {

            }
            
        }
    }
}
