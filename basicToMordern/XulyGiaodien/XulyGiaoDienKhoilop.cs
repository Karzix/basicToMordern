using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using basicToMordern.Models;
using basicToMordern.XulyDulieu;

namespace basicToMordern.XulyGiaodien
{
    internal class XulyGiaoDienKhoilop
    {
        
        XulyDulieuKhoiLop xuly;
        public XulyGiaoDienKhoilop(XulyDulieuKhoiLop xuly)
        {
            
            this.xuly = xuly;
        }
        public void XuatDuLieuKhoi(KhoiLop khoi)
        {
            //var ListKhoiLop = xuly.LayDuLieuKhoiLop();
            //foreach (var khoi in ListKhoiLop)
            //{
                XuatKhoiLop(khoi);
            //}
            //Console.ReadLine();
        }

        private void XuatKhoiLop(KhoiLop khoi)
        {
            Console.Write(khoi.SoThuTu);
            Console.WriteLine("\t| " + khoi.TenKhoiLop);
        }

        public void NhapDuLieu(KhoiLop Khoi)
        {
            //for (int i = 0; i < 3; i++)
            //{
                Khoi = NhapKhoiLop();
                xuly.LuuKhoiLopMoi(Khoi);
            //}
        }
        private KhoiLop NhapKhoiLop()
        {
            KhoiLop khoi = new KhoiLop();

            Console.Write("Nhap So Thu tu:");
            do
            {
                try
                {
                    khoi.SoThuTu = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("So thu tu phai la so! Vui long nhap lai");
                }
            } while (khoi.SoThuTu == 0);
            Console.Write("Nhap Ten Khoi: ");
            khoi.TenKhoiLop = Console.ReadLine();
            return khoi;

        }
    }
}
