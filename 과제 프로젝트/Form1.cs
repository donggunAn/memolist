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
    public partial class Memo : Form
    {
        string Conn = "Server=localhost;Database=####;Uid=####;Pwd=####;";

        public Memo()
        {
            InitializeComponent();
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Memo_Load(object sender, EventArgs e)
        {

        }

        private void Boxtitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void memopush_Click(object sender, EventArgs e)
        {
            //내용입력
            if (boxContent.Text == " " || boxtitle.Text == " ")
            {
                MessageBox.Show("내용을 입력해주세요!");
            }
            //DB전송
            else
            {
                using (MySqlConnection conn = new MySqlConnection(Conn))
                {
                    conn.Open();
                    MySqlCommand msc = new MySqlCommand("insert into test(title,content) values('" + boxtitle.Text + "','" + boxContent.Text + "')", conn);
                    int result = msc.ExecuteNonQuery();

                    if (result == 1)
                    {
                        MessageBox.Show("정상적으로 처리되었습니다!");
                    }
                }
            }
        }

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

        private void listview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
