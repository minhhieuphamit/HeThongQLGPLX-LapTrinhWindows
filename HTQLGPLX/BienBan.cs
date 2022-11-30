using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTQLGPLX
{
    internal class BienBan
    {
        private string maBB;
        private string maGPLX;
        private string hoTen;
        private string noiDungViPham;
        private string ngayLap;
        private double tienPhat;

        public BienBan()
        {
        }

        public BienBan(string maBB, string maGPLX, string hoTen, string noiDungViPham, string ngayLap, double tienPhat)
        {
            this.maBB = maBB;
            this.maGPLX = maGPLX;
            this.hoTen = hoTen;
            this.noiDungViPham = noiDungViPham;
            this.ngayLap = ngayLap;
            this.tienPhat = tienPhat;
        }

        public string MaBB { get => maBB; set => maBB = value; }
        public string MaGPLX { get => maGPLX; set => maGPLX = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NoiDungViPham { get => noiDungViPham; set => noiDungViPham = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public double TienPhat { get => tienPhat; set => tienPhat = value; }
    }
}
