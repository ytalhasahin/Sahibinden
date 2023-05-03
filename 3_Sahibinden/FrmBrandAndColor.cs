using _3_Sahibinden.Context;
using _3_Sahibinden.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = _3_Sahibinden.Models.Color;

namespace _3_Sahibinden
{
    public partial class FrmBrandAndColor : Form
    {
        public FrmBrandAndColor()
        {
            InitializeComponent();
        }

        CarsDbContext db = new CarsDbContext();
        FrmCarAdd fc = (FrmCarAdd)Application.OpenForms["FrmCarAdd"];
        public bool isBrand;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(isBrand)
            {
                db.Brands.Add(new Brand(txtName.Text));
                db.SaveChanges();
            }
            else
            {
                db.Colors.Add(new Color(txtName.Text));
                db.SaveChanges();
            }
            Close();
        }
    }
}
