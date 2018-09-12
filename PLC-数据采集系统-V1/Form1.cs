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


namespace PLC_数据采集系统_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strcon = "Data Source=10.228.141.253/ORCL;User Id=WEBKF;Password=WEBKF";//连接数据库的字符串
        OracleConnection lianjie; //设置数据库连接对象
      


        private void 信息查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FIS_Info frm1 = new FIS_Info();
            frm1.Show();
            frm1.MdiParent = this;
        }

        private void 检查连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lianjie = new OracleConnection(strcon);
            lianjie.Open();
            if(lianjie.State==ConnectionState.Open)
            {
                MessageBox.Show("数据库连接正常！");
                lianjie.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //左下角显示状态连接的信息
            lianjie = new OracleConnection(strcon);
            lianjie.Open();
            if (lianjie.State == ConnectionState.Open)
            {
                toolStripStatusLabel2.Text = "已经连接";
                lianjie.Close();
            }

            //左下角显示时间的信息
            toolStripStatusLabel4.Text = DateTime.Now.ToString();

        }

        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plc_Ip_ethan frm2 = new Plc_Ip_ethan();
            frm2.Show();
            frm2.MdiParent = this;
        }

        private void 任意显示表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Any_View_ethan frm3 = new Any_View_ethan();
            frm3.Show();
            frm3.MdiParent = this;
        }

        private void 查看信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EF_Oracle_ethan frm4 = new EF_Oracle_ethan();
            frm4.Show();
            frm4.MdiParent = this;
        }
    }
}
