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

        private string maBB;
        public formReport(string maBB)
        {
            InitializeComponent();
            this.maBB = maBB;
        }


        private void formReport_Load(object sender, EventArgs e)
        {
            List<BienBan> listBB = new List<BienBan>();
            List<BienBan> listBBreport = new List<BienBan>();
            ConnectDB conn = new ConnectDB();

            try
            {
                {
                    String querry = "select l.HoLot + ' ' + l.Ten as HoTen, h.MaGPLX,b.MaBienBan, lo.NoiDungViPham, b.NgayLap, lo.TienPhat from LyLich l, HoSoGPLX h, BienBanViPham b, CT_ViPham ct, LoiViPham lo where b.MaBienBan = ct.MaBienBan and ct.MaViPham = lo.MaViPham and l.SoCCCD = h.SoCCCD and h.MaGPLX = b.MaGPLX and b.MaBienBan = '" + maBB + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn.GetConnection());
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    foreach (DataRow row in dtbl.Rows)
                    {
                        BienBan bb = new BienBan();
                        bb.MaBB = row["MaBienBan"].ToString();
                        bb.HoTen = row["HoTen"].ToString();
                        bb.MaGPLX = row["MaGPLX"].ToString();
                        bb.NgayLap = Convert.ToDateTime(row["NgayLap"]).ToString("dd/MM/yyyy");
                        bb.TienPhat = Convert.ToDouble(row["TienPhat"]);
                        bb.NoiDungViPham = row["NoiDungViPham"].ToString();
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
            var reportDataSource = new ReportDataSource("DataSetBienBan", listBBreport);
            this.reportViewer.LocalReport.DataSources.Clear();
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer.RefreshReport();
        }
    }
}
