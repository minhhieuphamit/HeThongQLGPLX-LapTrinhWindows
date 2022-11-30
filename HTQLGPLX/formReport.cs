using Microsoft.Reporting.WinForms;
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
    public partial class formReport : Form
    {
        public formReport()
        {
            InitializeComponent();
        }

        private void formReport_Load(object sender, EventArgs e)
        {
            List<BienBan> listBB = new List<BienBan>();
            List<BienBan> listBBreport = new List<BienBan>();

            SqlConnection conn = new SqlConnection(@"Data Source=35.222.184.247;Initial Catalog=QLGPLX;Persist Security Info=True;User ID=sqlserver;Password=admin");
            try
            {
                {
                    string querry = "select b.MaBienBan, ll.HoLot + ' ' + ll.Ten [HoTen], b.MaGPLX, l.NoiDungViPham, b.NgayLap, l.TienPhat from BienBanViPham b, CT_ViPham ct, LoiViPham l, HoSoGPLX hs, LyLich ll where b.MaBienBan = ct.MaBienBan and ct.MaViPham = l.MaViPham and hs.MaGPLX = b.MaGPLX and hs.SoCCCD = ll.SoCCCD";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    foreach (DataRow row in dtbl.Rows)
                    {
                        BienBan bb = new BienBan();
                        bb.MaBB = row["MaBienBan"].ToString();
                        bb.HoTen = row["HoTen"].ToString();
                        bb.MaGPLX = row["MaGPLX"].ToString();
                        bb.NoiDungViPham = row["NoiDungViPham"].ToString();
                        bb.NgayLap = Convert.ToDateTime(row["NgayLap"]).ToString("dd/MM/yyyy");
                        bb.TienPhat = Convert.ToDouble(row["TienPhat"].ToString());
                        listBB.Add(bb);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            foreach (BienBan bb in listBB)
            {
                BienBan bbreport = new BienBan();
                bbreport.MaBB = bb.MaBB;
                bbreport.HoTen = bb.HoTen;
                bbreport.MaGPLX = bb.MaGPLX;
                bbreport.NoiDungViPham = bb.NoiDungViPham;
                bbreport.NgayLap = bb.NgayLap;
                bbreport.TienPhat = bb.TienPhat;
                listBBreport.Add(bbreport);
            }
            this.reportViewer.LocalReport.ReportPath = "../../reportBienBanVP.rdlc";
            var reportDataSource = new ReportDataSource("DataSetViPham", listBBreport);
            this.reportViewer.LocalReport.DataSources.Clear();
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer.RefreshReport();
            this.reportViewer.RefreshReport();
        }
    }
}
