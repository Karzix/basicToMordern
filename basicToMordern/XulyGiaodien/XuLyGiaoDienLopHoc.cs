using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using basicToMordern.Data;
using basicToMordern.Models;
using basicToMordern.XulyDulieu;

namespace basicToMordern.XulyGiaodien
{
    public class XuLyGiaoDienLopHoc
    {
        XuLyDuLieuLopHoc xl ;
        public XuLyGiaoDienLopHoc(XuLyDuLieuLopHoc xl)
        {
            this.xl = xl;
        }
        private LopHoc NhapLopHoc(KhoiLop kl)
        {
            var lophoc = new LopHoc();
            lophoc.KhoiLop = kl;
            Console.Write("Nhap Ma lop hoc: ");
            lophoc.MaLop = Console.ReadLine();
            Console.Write("Nhap ten lop: ");
            lophoc.TenLop = Console.ReadLine();
            return lophoc;
        }
        public void NhapDuLieu(KhoiLop kl, LopHoc lophoc)
        {
            lophoc= NhapLopHoc(kl);
            xl.LuuDuLieuLopHoc(lophoc);
        }
        public void xuatLopHoc(LopHoc lh)
        {
            Console.Write(lh.MaLop);
            Console.WriteLine("\t| " + lh.TenLop);
        }
    }
}
