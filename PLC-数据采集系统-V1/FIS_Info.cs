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
    public partial class FIS_Info : Form
    {
        public FIS_Info()
        {
            InitializeComponent();
        }

        string strcon = "Data Source=10.228.141.253/ORCL;User Id=WEBKF;Password=WEBKF";//连接数据库的字符串
            string sql = "select * from BODYINFOL200 order by ID";//数据库执行语句
        OracleConnection lianjie; //设置数据库连接对象
        OracleDataAdapter da;//设置数据库连接器对象
        DataSet ds;//设置数据集对象

        private void FIS_Info_Load(object sender, EventArgs e)
        {
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//记录选中的ID号

                lianjie = new OracleConnection(strcon);
                da = new OracleDataAdapter("select * from BODYINFOL200 where ID=" + id + "", lianjie);
                ds = new DataSet();
                da.Fill(ds);

                if(ds.Tables[0].Rows.Count>0)
                {
                    textBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                    textBox2.Text = ds.Tables[0].Rows[0][1].ToString();
                    textBox3.Text = ds.Tables[0].Rows[0][2].ToString();
                    textBox4.Text = ds.Tables[0].Rows[0][3].ToString();
                    textBox5.Text = ds.Tables[0].Rows[0][4].ToString();
                    textBox6.Text = ds.Tables[0].Rows[0][5].ToString();
                    textBox7.Text = ds.Tables[0].Rows[0][6].ToString();
                    textBox8.Text = ds.Tables[0].Rows[0][7].ToString();
                    textBox9.Text = ds.Tables[0].Rows[0][8].ToString();

                }
            }
        }
    }
}
