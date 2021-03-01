using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA210301
{
    public partial class FrmVizsgaKereso : Form
    {
        SqlConnection conn;
        public FrmVizsgaKereso(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void TbKereso_TextChanged(object sender, EventArgs e)
        {
            Lekerdezes(tbKereso.Text);
        }

        private void FrmVizsgaKereso_Load(object sender, EventArgs e)
        {
            Lekerdezes("");
        }

        private void Lekerdezes(string kulcsszo)
        {
            dgvVizsgak.Rows.Clear();
            conn.Open();

            var r = new SqlCommand(
                "SELECT idopont, nyelv, szint FROM vizsgak " +
                "vizsgak INNER JOIN nyelvek ON nyelvid = id " +
                $"WHERE nyelv LIKE '{kulcsszo}%';", conn)
                .ExecuteReader();

            while (r.Read())
            {
                dgvVizsgak.Rows.Add(
                    r.GetDateTime(0).ToString("MMMM dd., (dddd): HH:mm"),
                    r[1], r[2]);
            }
            conn.Close();
        }
    }
}
