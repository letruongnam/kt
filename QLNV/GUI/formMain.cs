﻿using QLNV.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var db = new AppDB();
            var ls = db.NhanViens.ToList();
            bdsNhanVien.DataSource = ls;
            dataGridView1.DataSource = bdsNhanVien;
        }
    }
}
