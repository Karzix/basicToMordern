using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using basicToMordern.Models;
using basicToMordern.XulyDulieu;

namespace basicToMordern.XulyGiaodien
{
    public class XuLyGiaoDienHocSinh
    {
        XuLyDuLieuHocSinh xl;
        public XuLyGiaoDienHocSinh(XuLyDuLieuHocSinh xl)
        {
            this.xl = xl;
        }
        private HocSinh NhapHocSinh(LopHoc lh)
        {
            var hs = new HocSinh();
            hs.Lop = lh;
            Console.Write("Nhap STT: ");
            hs.SoTT= int.Parse(Console.ReadLine());
            Console.Write("Nhap Ho va ten hoc sinh: ");
            hs.TenHocSinh = Console.ReadLine();
            return hs;
        }
        public void NhapDuLieu(LopHoc lh,HocSinh hs)
        {
            hs=NhapHocSinh(lh);
            xl.LuuDuLieuHocSinh(hs);
        }
        public void XuatHocsinh(HocSinh hs)
        {
            Console.Write( hs.SoTT);
            Console.WriteLine("\t| " + hs.TenHocSinh);
        }
    }
}
