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
    public partial class FrmMain : Form
    {
        SqlConnection conn;
        public FrmMain()
        {
            conn = new SqlConnection(
                @"Server = (localdb)\MSSQLLocalDB;" +
                "Database = nyelviskola");
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            conn.Open();

            var r = new SqlCommand(
                "SELECT jelentkezesek.sorsz, nev, nyelv, szint " +
                "FROM jelentkezesek " +
                "INNER JOIN vizsgak ON jelentkezesek.vizsga = vizsgak.sorsz " +
                "INNER JOIN nyelvek ON vizsgak.nyelvid = nyelvek.id;", conn)
                .ExecuteReader();


            while (r.Read())
            {
                dgvVizsgazok.Rows.Add(r[0], r[1], r[2], r[3]);
            }

            conn.Close();
        }

        private void msiVizsgak_Click(object sender, EventArgs e)
        {
            var frm = new FrmVizsgaKereso(conn);
            frm.ShowDialog();
        }
    }
}
