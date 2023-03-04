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
    public class XuLyGiaoDien
    {
        DLKL data;
        public XuLyGiaoDien(DLKL data)
        {
            this.data = data;
        }
        public void GiaoDien()
        {
            do
            {
                int n;
                Console.WriteLine("1: Quan ly khoi lop\n2: Quan ly lop hoc\n3: Quan ly hoc sinh\n4: Thoat");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                if (n == 1)
                {
                    QuanLyKhoiLop();
                }
                else if (n == 2)
                {
                    QuanLyLopHoc();
                }
                else if (n == 3)
                {
                    QuanLyHocSinh();
                }
                else if (n == 4)
                {
                    Console.WriteLine("Ket thuc chuong trinh");
                    break;
                }
            }while(true);
        }
        public void QuanLyHocSinh()
        {
            var xulydulieulophoc = new XuLyDuLieuLopHoc(data);
            var xulygiaodienlophoc = new XuLyGiaoDienLopHoc(xulydulieulophoc);
            var xulydulieuhocsinh = new XuLyDuLieuHocSinh(data);
            var xulygiaodienhocsinh = new XuLyGiaoDienHocSinh(xulydulieuhocsinh);
            do
            {
                Console.WriteLine("1: Nhap them hoc sinh\n2: quay ve");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                if (n == 1)
                {
                    Console.WriteLine("Ma lop \tTen lop");
                    foreach (var i in xulydulieulophoc.LayDuLieuLopHoc())
                    {
                       xulygiaodienlophoc.xuatLopHoc(i);
                    }
                    Console.Write("Nhap ma lop cua hoc sinh: ");
                    string malop = Console.ReadLine();
                    Console.Clear();
                    foreach (var lophoc in xulydulieulophoc.LayDuLieuLopHoc())
                    {
                        if (lophoc.MaLop == malop)
                            do
                            {
                                Console.WriteLine("Dang nhap hoc sinh cho lop  " + lophoc.MaLop);
                                Console.WriteLine("STT \tTen hoc sinh");
                                foreach (var hocsinh in xulydulieuhocsinh.TimTheoMaLop(malop))
                                {
                                    xulygiaodienhocsinh.XuatHocsinh(hocsinh);
                                }
                                Console.WriteLine("1: nhap hoc sinh cho lop {0}\n2: quay ve", lophoc.MaLop);
                                int n2 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (n2 == 1)
                                {
                                    var hocsinh = new HocSinh();
                                    xulygiaodienhocsinh.NhapDuLieu(lophoc, hocsinh);
                                    Console.Clear();
                                }
                                else if (n2 == 2)
                                {
                                    break;
                                }
                            } while (true);
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (n == 2)
                {
                    break;
                }
            } while (true);

        }
        public void QuanLyLopHoc()
        {
            var xulydulieukhoilop = new XulyDulieuKhoiLop(data);
            var xulygiaodienkhoilop = new XulyGiaoDienKhoilop(xulydulieukhoilop);
            var xulydulieulophoc = new XuLyDuLieuLopHoc(data);
            var xulygiaodienlophoc = new XuLyGiaoDienLopHoc(xulydulieulophoc);
            do
            {
                Console.WriteLine("1: Nhap them lop hoc\n2: quay ve");
                int n = int.Parse(Console.ReadLine());
                Console.Clear();
                if (n == 1)
                {
                    Console.WriteLine("STT \tTen khoi lop");
                    foreach (var i in xulydulieukhoilop.LayDuLieuKhoiLop())
                    {
                        xulygiaodienkhoilop.XuatDuLieuKhoi(i);
                    }
                    Console.Write("Nhap ten khoi cua lop: ");
                    string tenkhoi = Console.ReadLine();
                    Console.Clear();
                    foreach (var khoilop in xulydulieukhoilop.LayDuLieuKhoiLop())
                    {
                        if (khoilop.TenKhoiLop == tenkhoi)
                            do
                            {
                                Console.WriteLine("Dang nhap lop hoc cho khoi " + khoilop.TenKhoiLop);
                                Console.WriteLine("Ma lop \tTen lop");
                                foreach(var lop in xulydulieulophoc.TimTheoTenKhoi(tenkhoi))
                                {
                                    xulygiaodienlophoc.xuatLopHoc(lop);
                                }
                                Console.WriteLine("1: nhap lop hoc cho khoi {0}\n2: quay ve",khoilop.TenKhoiLop);
                                int n2 = int.Parse(Console.ReadLine());
                                Console.Clear();
                                if (n2 == 1)
                                {
                                    var lophoc = new LopHoc();
                                    xulygiaodienlophoc.NhapDuLieu(khoilop, lophoc);
                                    Console.Clear();
                                }
                                else if (n2 == 2)
                                {
                                    break;
                                }
                            } while (true);
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (n == 2)
                {
                    break;
                }
            } while (true);
        }
        public void QuanLyKhoiLop() {
            var xulydulieukhoilop = new XulyDulieuKhoiLop(data);
            var xulygiaodienkhoilop = new XulyGiaoDienKhoilop(xulydulieukhoilop);
            do
            {
                int n;
                Console.WriteLine("1: Nhap them khoi lop\n2: quay ve");
                Console.WriteLine("STT \tTen khoi lop");
                foreach(var kl in xulydulieukhoilop.LayDuLieuKhoiLop())
                {
                    xulygiaodienkhoilop.XuatDuLieuKhoi(kl);
                }
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                if (n == 1)
                {
                    var khoilop = new KhoiLop();
                    xulygiaodienkhoilop.NhapDuLieu(khoilop);
                    Console.Clear();
                }
                else if (n == 2)
                {
                    break;
                }
            } while (true);
        }
        public void xuatdskhoilop()
        {
            var xulydulieukhoilop = new XulyDulieuKhoiLop(data);
            var xulygiaodienkhoilop = new XulyGiaoDienKhoilop(xulydulieukhoilop);
            Console.WriteLine("STT \t Ten Khoi Lop;");
            foreach(var khoilop in xulydulieukhoilop.LayDuLieuKhoiLop())
            {
                xulygiaodienkhoilop.XuatDuLieuKhoi(khoilop);
            }
            Console.WriteLine();
        }
        public void xuatdslop()
        {
            var xulydulieulophoc = new XuLyDuLieuLopHoc(data);
            var xulygiaodienlophoc = new XuLyGiaoDienLopHoc(xulydulieulophoc);
            Console.WriteLine("Nhap ten khoi lop can xuat danh sach lop");
            string n = Console.ReadLine();
            Console.Clear();
            //Console.WriteLine("Khoi: " + n);
            Console.WriteLine("Ma lop \tTen lop");
            foreach(var lophoc in xulydulieulophoc.TimTheoTenKhoi(n))
            {
                xulygiaodienlophoc.xuatLopHoc(lophoc);
            }
            Console.WriteLine();
        }
        public void xuatdshocsinh()
        {
            var xulydulieuhocsinh = new XuLyDuLieuHocSinh(data);
            var xulygiaodienhocsinh = new XuLyGiaoDienHocSinh(xulydulieuhocsinh);
            Console.WriteLine("Nhap Malop can xuat danh sach hoc sinh: ");
            string n=Console.ReadLine();
            Console.Clear();
            //Console.WriteLine("Lop "+ n);
            foreach(var hocsinh in xulydulieuhocsinh.TimTheoMaLop(n))
            {
                xulygiaodienhocsinh.XuatHocsinh(hocsinh);
            }
            Console.WriteLine();
        }
    }
}
