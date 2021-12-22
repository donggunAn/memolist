using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace 과제_프로젝트
{
    public partial class 리스트뷰 : Form
    {
        public 리스트뷰()
        {
            InitializeComponent();
        }

        public string Conn { get; private set; }

        private void Listbutton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(Conn))
            {
                DataSet ds = new DataSet();
                string sql = "SELECT * FROM test";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "test");

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = ds.Tables[0].Rows[i]["id"].ToString();
                    lvi.SubItems.Add(ds.Tables[0].Rows[i]["title"].ToString());
                    lvi.SubItems.Add(ds.Tables[0].Rows[i]["content"].ToString());

                    listview.Items.Add(lvi);
                }
            }
        }
    }
}
