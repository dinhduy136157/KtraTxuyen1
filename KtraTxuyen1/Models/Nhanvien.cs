using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KtraTxuyen1.Models
{
    public class Nhanvien
    {
        public string manv {  get; set; }
        public string hoten { get; set; }
        public string diachi {  get; set; }
        public int songaylam {  get; set; }
        public int luongngay { get; set; }
        public int tienluong {
            get
            {
                return songaylam * luongngay;
            }
        }
        public Nhanvien() { }
        public Nhanvien(string manv, string hoten, string diachi, int songaylam, int luongngay)
        {
            this.manv = manv;
            this.hoten = hoten;
            this.diachi = diachi;
            this.songaylam = songaylam;
            this.luongngay = luongngay;
        }
    }
}