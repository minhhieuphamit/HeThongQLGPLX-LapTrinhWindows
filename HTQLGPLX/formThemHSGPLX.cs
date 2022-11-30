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
    public partial class formThemHSGPLX : Form
    {
        ConnectDB conn = new ConnectDB();

        public formThemHSGPLX()
        {
            InitializeComponent();
        }

        private void loadComboBoxCCCD()
        {
            try
            {
                conn.Open();
                String querry = "SELECT SoCCCD FROM LyLich";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn.GetConnection());
                DataTable dt = new DataTable(); ;
                sda.Fill(dt);
                comboBoxCCCD.DisplayMember = "SoCCCD";
                comboBoxCCCD.DataSource = dt;
                comboBoxCCCD.SelectedIndex = -1;
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

        private void loadComboBoxMaHang()
        {
            try
            {
                String querry = "SELECT MaHang FROM HangGPLX";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn.GetConnection());
                DataTable dt = new DataTable(); ;
                sda.Fill(dt);
                comboBoxMaHang.DisplayMember = "MaHang";
                comboBoxMaHang.DataSource = dt;
                comboBoxMaHang.SelectedIndex = -1;
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

        private void loadComboBoxTTSatHach()
        {
            try
            {
                String querry = "SELECT TenTT FROM TrungTamSatHach";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn.GetConnection());
                DataTable dt = new DataTable(); ;
                sda.Fill(dt);
                comboBoxTTSatHach.DisplayMember = "TenTT";
                comboBoxTTSatHach.DataSource = dt;
                comboBoxTTSatHach.SelectedIndex = -1;
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

        private void formThemThongTin_Load(object sender, EventArgs e)
        {
            loadComboBoxCCCD();
            loadComboBoxMaHang();
            comboBoxCCCD.SelectedIndexChanged += (s, ev) =>
            {
                try
                {
                    String querry = "SELECT CONCAT(HoLot ,' ', Ten) as HoTen FROM LyLich WHERE SoCCCD = '" + comboBoxCCCD.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn.GetConnection());
                    DataTable dt = new DataTable(); ;
                    sda.Fill(dt);
                    labelHoTen.Text = dt.Rows[0][0].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            };
            loadComboBoxTTSatHach();
        }

        formHoSoGPLX obj = (formHoSoGPLX)Application.OpenForms["formHoSoGPLX"];
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCCCD.Text == "" || comboBoxMaHang.Text == "" || comboBoxTTSatHach.Text == "" || textBoxMaGPLX.Text == "" ||
                    dateTimePickerNgayCap.Text == "" || dateTimePickerNgayHetHan.Text == "" || textBoxDiemLT.Text == "" || textBoxDiemTH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String querry = "SELECT MaGPLX FROM HoSoGPLX WHERE MaGPLX = '" + textBoxMaGPLX.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn.GetConnection());
                    DataTable dt = new DataTable(); ;
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Số GPLX đã tồn tại!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        String querry1 = "SELECT MaTT FROM TrungTamSatHach WHERE TenTT LIKE N'" + comboBoxTTSatHach.Text + "'";
                        SqlDataAdapter sda1 = new SqlDataAdapter(querry1, conn.GetConnection());
                        DataTable dt1 = new DataTable();
                        sda1.Fill(dt1);
                        String maTT = dt1.Rows[0][0].ToString();

                        conn.Open();
                        String querry2 = "INSERT INTO HoSoGPLX VALUES('" + textBoxMaGPLX.Text + "','" + comboBoxCCCD.Text + "','" + comboBoxMaHang.Text + "','" + dateTimePickerNgayCap.Value.ToString("yyyy-MM-dd") + "','" + dateTimePickerNgayHetHan.Value.ToString("yyyy-MM-dd") + "','" + maTT + "','" + textBoxDiemLT.Text + "','" + textBoxDiemTH.Text + "')";
                        SqlCommand cmd = new SqlCommand(querry2, conn.GetConnection());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thông tin thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        obj.loadDataGridView();
                    }
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

        private void buttonXoaAllThongTin_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Thao tác này sẽ xóa câu trả lời của bạn khỏi tất cả câu hỏi. Bạn sẽ không thể hủy được thao tác này sau khi thực hiện.", "Xóa hết câu trả lời trong biểu mẫu?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                comboBoxCCCD.Text = "";
                labelHoTen.Text = "";
                comboBoxMaHang.Text = "";
                comboBoxTTSatHach.Text = "";
                textBoxMaGPLX.Text = "";
                dateTimePickerNgayCap.Text = "";
                dateTimePickerNgayHetHan.Text = "";
                textBoxDiemLT.Text = "";
                textBoxDiemTH.Text = "";
            }
        }
    }
}
