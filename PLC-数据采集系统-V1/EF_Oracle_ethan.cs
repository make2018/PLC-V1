using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.VsDevTools;


namespace PLC_数据采集系统_V1
{
    public partial class EF_Oracle_ethan : Form
    {
        public EF_Oracle_ethan()
        {
            InitializeComponent();
        }

        private void EF_Oracle_ethan_Load(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
                     dataGridView1.DataSource = db.BODYINFOL200.ToList();
            }

        }
    }
}
