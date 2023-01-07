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

namespace HTQLGPLX
{
    public partial class formTimBB : Form
    {
        public formTimBB()
        {
            InitializeComponent();
        }

        ConnectDB conn = new ConnectDB();

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    String querry = "select MaBienBan from BienBanViPham where MaBienBan = '" + textBoxSearch.Text + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn.GetConnection());
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    if (dtbl.Rows.Count == 0)
                    {
                        MessageBox.Show("Biên bản vừa nhập không tồn tại trong cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        formReport formRP = new formReport(textBoxSearch.Text);
                        formRP.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
