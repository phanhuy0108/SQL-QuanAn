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
    public partial class ViewAnSangform : Form
    {
        public ViewAnSangform()
        {
            InitializeComponent();
            this.Load += ViewAnSangform_Load;
            this.btnThemMonAn.Click += btnThemMonAn_Click;
        }

        void btnThemMonAn_Click(object sender, EventArgs e)
        {
            var form = new themmonan();
            form.ShowDialog();
            this.ShowAnSangList();
        }

        private void ViewAnSangform_Load(object sender, EventArgs e)
        {
            this.ShowAnSangList();
        }

        private void ShowAnSangList()
        {
            var db = new QuanAnEntities();
            var list = db.AnSangs.ToArray();
            this.grdAnSang.DataSource = list;
        }

        
    }
}
