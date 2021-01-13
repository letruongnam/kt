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
    public partial class formThemNhom : Form
    {
        public formThemNhom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String TenNhom = txtTenNhom.Text;

            if (TenNhom != null)
            {
                try
                {
                    var db = new QLDanhBaDB();
                    db.NHOMs.Add(new NHOM
                    {
                        TenNhom = TenNhom
                    });
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
                catch
                {
                    MessageBox.Show("Tên nhóm đã tồn tại");
                }
              
            }
            else
            {
                MessageBox.Show("Vui lòng điền tên nhóm");
            }
        }
    }
}
