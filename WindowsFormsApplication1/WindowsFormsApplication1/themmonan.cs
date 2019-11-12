using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class themmonan : Form
    {
        public themmonan()
        {
            InitializeComponent();
            this.btnLuu.Click += btnLuu_Click;
        }

        void btnLuu_Click(object sender, EventArgs e)
        {
            var tenMon = this.tbxTenMon.Text;
            var giaTien = int.Parse(this.tbxGiaTien.Text);
            var anSang = new AnSang();
            anSang.TenMon=tenMon;
            anSang.GiaTien=giaTien;
            var db = new QuanAnEntities();
            db.AnSangs.Add(anSang);
            db.SaveChanges();

            MessageBox.Show("Them Mon Thanh Cong !!!");
            this.Close();
        }

        
    }
}
