using System;
using System.Collections.Generic;
using basicToMordern.Data;
using basicToMordern.Models;
using basicToMordern.XulyDulieu;
using basicToMordern.XulyGiaodien;

namespace basicToMordern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DLKL data = new DLKL();
            //XulyDulieuKhoiLop xulyDulieuKhoiLop = new XulyDulieuKhoiLop(data);

            //XulyGiaoDienKhoilop xulyGiaoDienKhoilop = new XulyGiaoDienKhoilop(xulyDulieuKhoiLop);

            //xulyGiaoDienKhoilop.NhapDuLieu();

            //xulyGiaoDienKhoilop.XuatDuLieuKhoi();
            XuLyGiaoDien xl = new XuLyGiaoDien(data);
            xl.GiaoDien();
            Console.WriteLine("Hello work!");
            Console.ReadLine();
        }
        
    }
}
