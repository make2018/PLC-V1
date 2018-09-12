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
    public partial class Any_View_ethan : Form
    {
        public Any_View_ethan()
        {
            InitializeComponent();
        }

        string strcon = "Data Source=10.228.141.253/ORCL;User Id=WEBKF;Password=WEBKF";//连接数据库的字符串
        
        OracleConnection lianjie; //设置数据库连接对象
        OracleDataAdapter da;//设置数据库连接器对象
        DataSet ds;//设置数据集对象

        private void button1_Click(object sender, EventArgs e)
        {
            string sql =textBox1.Text;//数据库执行语句

            dataGridView1.AllowUserToAddRows = false;//禁止添加行
            dataGridView1.AllowUserToDeleteRows = false;//禁止删除行

            lianjie = new OracleConnection(strcon);//实例化连接
            da = new OracleDataAdapter(sql, lianjie);//实例化连接器
            ds = new DataSet();//实例化数据集
            da.Fill(ds);//填充数据
            dataGridView1.DataSource = ds.Tables[0];//填充完的数据在datagridview中显示
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//选择时可以选择一整行
            dataGridView1.ReadOnly = true;//设置控件只能只读
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Green;//设置选中行显示绿色
        }

        private void Any_View_ethan_Load(object sender, EventArgs e)
        {

        }
    }
}
