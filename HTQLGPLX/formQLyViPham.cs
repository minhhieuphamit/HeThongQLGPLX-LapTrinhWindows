using MySql.Data.MySqlClient;
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
    public partial class formQLyViPham : Form
    {
        public formQLyViPham()
        {
            InitializeComponent();
        }

        ConnectDB conn = new ConnectDB();

        internal void loadDataGridView()
        {
            try
            {
                String querry = "select b.MaBienBan, b.MaGPLX, l.NoiDungViPham, CONVERT(varchar, b.NgayLap, 103) as NgayLap, l.TienPhat from BienBanViPham b, CT_ViPham ct, LoiViPham l where b.MaBienBan = ct.MaBienBan and ct.MaViPham = l.MaViPham";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn.GetConnection());
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dataGridViewLoiViPham.DataSource = dtbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void loadComboBoxNDViPham()
        {
            try
            {
                string querry = "select NoiDungViPham from LoiViPham";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn.GetConnection());
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                comboBoxNDViPham.DataSource = dtbl;
                comboBoxNDViPham.DisplayMember = "NoiDungViPham";
                comboBoxNDViPham.ValueMember = "NoiDungViPham";
                comboBoxNDViPham.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void loadComboBoxMaGPLX()
        {
            try
            {
                String querry = "select MaGPLX from HoSoGPLX";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn.GetConnection());
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                comboBoxMaGPLX.DataSource = dtbl;
                comboBoxMaGPLX.DisplayMember = "MaGPLX";
                comboBoxMaGPLX.ValueMember = "MaGPLX";
                comboBoxMaGPLX.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void formQLyViPham_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            loadComboBoxNDViPham();
            loadComboBoxMaGPLX();
            comboBoxNDViPham.SelectedIndexChanged += (s, ev) =>
            {
                try
                {
                    String querry = "SELECT TienPhat FROM LoiViPham WHERE NoiDungViPham = N'" + comboBoxNDViPham.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn.GetConnection());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    labelTienPhat.Text = dt.Rows[0][0].ToString();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    conn.Close();
                }
            };
            ToolTip toolTiptextBoxSeach = new ToolTip();
            toolTiptextBoxSeach.SetToolTip(textBoxSearch, "Tìm kiếm theo mã giấy phép lái xe");
            ToolTip toolTipButtonSearch = new ToolTip();
            toolTipButtonSearch.SetToolTip(buttonSearch, "Tìm kiếm");
            ToolTip toolTipButtonAdd = new ToolTip();
            toolTipButtonAdd.SetToolTip(buttonAdd, "Thêm");
            ToolTip toolTipButtonEdit = new ToolTip();
            toolTipButtonEdit.SetToolTip(buttonEdit, "Sửa");
            ToolTip toolTipButtonDelete = new ToolTip();
            toolTipButtonDelete.SetToolTip(buttonDelete, "Xóa");
        }

        private void dataGridViewLoiViPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex == this.dataGridViewLoiViPham.NewRowIndex)
            {
                return;
            }
            if (e.ColumnIndex == this.dataGridViewLoiViPham.Columns["STT"].Index)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void toolStripMenuThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void toolStripMenuLogout_Click(object sender, EventArgs e)
        {
            buttonLogout_Click(sender, e);
        }

        private void toolStripMenuHoSoGPLX_Click(object sender, EventArgs e)
        {
            formHoSoGPLX formHoSoGPLX = new formHoSoGPLX();
            formHoSoGPLX.Show();
            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất tài khoản?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                formLogin formLogin = new formLogin();
                formLogin.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void dataGridViewLoiViPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaBienBan.Text = dataGridViewLoiViPham.CurrentRow.Cells[1].Value.ToString();
            comboBoxMaGPLX.Text = dataGridViewLoiViPham.CurrentRow.Cells[2].Value.ToString();
            comboBoxNDViPham.Text = dataGridViewLoiViPham.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerNgayLap.Text = dataGridViewLoiViPham.CurrentRow.Cells[4].Value.ToString();
            labelTienPhat.Text = dataGridViewLoiViPham.CurrentRow.Cells[5].Value.ToString();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Search")
            {
                textBoxSearch.Text = null;
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = "Search";
                textBoxSearch.ForeColor = Color.DarkGray;
            }
            if (textBoxSearch.Text == "Search")
            {
                formQLyViPham_Load(sender, e);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string querry = "select b.MaBienBan, b.MaGPLX, l.NoiDungViPham, b.NgayLap, l.TienPhat from BienBanViPham b, CT_ViPham ct, LoiViPham l where b.MaBienBan = ct.MaBienBan and ct.MaViPham = l.MaViPham and (b.MaGPLX like '" + textBoxSearch.Text + "' or b.MaBienBan like '" + textBoxSearch.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn.GetConnection());
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (textBoxSearch.Text == "Search")
                {
                    MessageBox.Show("Vui lòng điền thông tin cần tìm kiếm", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (dtbl.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hồ sơ GPLX có mã " + textBoxSearch.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formQLyViPham_Load(sender, e);
                }
                else
                {
                    dataGridViewLoiViPham.DataSource = dtbl;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxMaBienBan.Text == "" || comboBoxMaGPLX.Text == ""
                                || comboBoxNDViPham.Text == "" || dateTimePickerNgayLap.Text == "" || labelTienPhat.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    /*string querry = "SELECT MaBienBan FROM BienBanViPham WHERE MaBienBan = '" + textBoxMaBienBan.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Mã biên bản đã tồn tại", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else*/
                    //{
                    conn.Open();
                    string querry1 = "insert into BienBanViPham values ('" + textBoxMaBienBan.Text + "', '" + comboBoxMaGPLX.Text + "', '" + dateTimePickerNgayLap.Value.ToString("yyyy-MM-dd") + "')";
                    SqlCommand cmd = new SqlCommand(querry1, conn.GetConnection());
                    cmd.ExecuteNonQuery();

                    string querry2 = "select MaViPham from LoiViPham where NoiDungViPham like N'" + comboBoxNDViPham.Text + "'";
                    SqlDataAdapter sda1 = new SqlDataAdapter(querry2, conn.GetConnection());
                    DataTable dtbl = new DataTable();
                    sda1.Fill(dtbl);
                    string maViPham = dtbl.Rows[0][0].ToString();

                    string querry3 = "insert into CT_ViPham values ('" + textBoxMaBienBan.Text + "', '" + maViPham + "')";
                    SqlCommand cmd1 = new SqlCommand(querry3, conn.GetConnection());
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formQLyViPham_Load(sender, e);
                    //}
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string maBienBan = dataGridViewLoiViPham.CurrentRow.Cells["MaBienBan"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá biên bản có mã " + maBienBan + " không?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (textBoxMaBienBan.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hồ sơ cần xóa", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string querry = "delete from CT_ViPham where MaBienBan = '" + textBoxMaBienBan.Text + "'";
                    SqlCommand cmd = new SqlCommand(querry, conn.GetConnection());
                    cmd.ExecuteNonQuery();

                    string querry1 = "select MaViPham from LoiViPham where NoiDungViPham like N'" + comboBoxNDViPham.Text + "'";
                    SqlDataAdapter adap = new SqlDataAdapter(querry1, conn.GetConnection());
                    DataTable dtbl = new DataTable();
                    adap.Fill(dtbl);
                    string maViPham = dtbl.Rows[0][0].ToString();

                    string querry2 = "delete from BienBanViPham where MaBienBan = '" + maBienBan + "'";
                    SqlCommand cmd1 = new SqlCommand(querry2, conn.GetConnection());
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formQLyViPham_Load(sender, e);
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
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string maBienBan = dataGridViewLoiViPham.CurrentRow.Cells["MaBienBan"].Value.ToString();
                conn.Open();
                string querry = "update BienBanViPham set MaBienBan = '" + textBoxMaBienBan.Text + "', MaGPLX = '" + comboBoxMaGPLX.Text + "', NgayLap = '" + dateTimePickerNgayLap.Value.ToString("yyyy-MM-dd") + "' where MaBienBan = '" + maBienBan + "'";
                SqlCommand cmd = new SqlCommand(querry, conn.GetConnection());
                cmd.ExecuteNonQuery();

                string querry1 = "select MaViPham from LoiViPham where NoiDungViPham like N'" + comboBoxNDViPham.Text + "'";
                SqlDataAdapter adap = new SqlDataAdapter(querry1, conn.GetConnection());
                DataTable dtbl = new DataTable();
                adap.Fill(dtbl);
                string maViPham = dtbl.Rows[0][0].ToString();

                string querry2 = "update CT_ViPham set MaViPham = '" + maViPham + "' where MaBienBan = '" + textBoxMaBienBan.Text + "'";
                SqlCommand cmd1 = new SqlCommand(querry2, conn.GetConnection());
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formQLyViPham_Load(sender, e);
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

        private void toolStripMenuXuatBaoCao_Click(object sender, EventArgs e)
        {
            formReport formReport = new formReport();
            formReport.Show();
        }
    }
}

