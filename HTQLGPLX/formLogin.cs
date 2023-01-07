using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HTQLGPLX
{
    public partial class formLogin : Form
    {
        ConnectDB conn = new ConnectDB();
        
        public static String idUser = "";
        public static String idRole = "";
        
        public String getIdUser(String username, String password)
        {
            {
                String query = "SELECT idUser FROM [User] WHERE Username = '" + username + "' AND Password = '" + password + "'";
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn.GetConnection());
                    DataTable dt = new DataTable();

                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        idUser = dt.Rows[0][0].ToString();
                    }
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
                finally
                {
                    conn.Close();
                }
                return idUser;
            }
        }

        public String getIdRole()
        {
            {
                String query = "SELECT idRole FROM [User] WHERE idUser = '" + idUser + "'";
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn.GetConnection());
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        idRole = dt.Rows[0][0].ToString();
                    }
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
                finally
                {
                    conn.Close();
                }
                return idRole;
            }
        }

        public formLogin()
        {
            InitializeComponent();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String querry = "select * from [User] where Username = '" + textBoxUsername.Text + "' and Password = '" + textBoxPassword.Text + "'";
                idUser = getIdUser(textBoxUsername.Text, textBoxPassword.Text);
                idRole = getIdRole();
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn.GetConnection());
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (getIdRole() == "1")
                    {
                        formHoSoGPLX formHoSoGPLX = new formHoSoGPLX();
                        formHoSoGPLX.Show();
                        this.Hide();
                    }
                    else if (getIdRole() == "2")
                    {
                        formQLyViPham formQLyViPham = new formQLyViPham();
                        formQLyViPham.Show();
                        this.Hide();
                    }
                }
                else if (textBoxUsername.Text == "Username" && textBoxPassword.Text == "Password")
                {
                    MessageBox.Show("Username và password không được để trống!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxUsername.Focus();
                }
                else if (textBoxUsername.Text == "Username")
                {
                    MessageBox.Show("Username không được để trống!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxUsername.Focus();
                }
                else if (textBoxPassword.Text == "Password")
                {
                    MessageBox.Show("Password không được để trống!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập sai, vui lòng nhập lại!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    textBoxUsername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
                textBoxUsername.Focus();
            }
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Username")
            {
                textBoxUsername.Text = null;
                textBoxUsername.ForeColor = Color.Black;
            }
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Username";
                textBoxUsername.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Password")
            {
                textBoxPassword.Text = null;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            ToolTip toolTipTxtBoxUsername = new ToolTip();
            toolTipTxtBoxUsername.SetToolTip(textBoxUsername, "Tài khoản");
            ToolTip toolTipTxtBoxPassword = new ToolTip();
            toolTipTxtBoxPassword.SetToolTip(textBoxPassword, "Mật khẩu");
            ToolTip toolTipCheckboxShowPass = new ToolTip();
            toolTipCheckboxShowPass.SetToolTip(checkBoxShowPassword, "Hiển thị mật khẩu");
            ToolTip toolTipBtnLogin = new ToolTip();
            toolTipBtnLogin.SetToolTip(buttonLogin, "Đăng nhập");
            ToolTip toolTipBtnExit = new ToolTip();
            toolTipBtnExit.SetToolTip(buttonExit, "Thoát");
        }
    }
}
