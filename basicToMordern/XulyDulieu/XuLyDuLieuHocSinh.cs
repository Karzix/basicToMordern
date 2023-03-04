using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using basicToMordern.Data;
using basicToMordern.Models;

namespace basicToMordern.XulyDulieu
{
    public class XuLyDuLieuHocSinh
    {
        DLKL data = new DLKL();
        public XuLyDuLieuHocSinh(DLKL data)
        {
            this.data = data;
        }
        public void LuuDuLieuHocSinh(HocSinh hs)
        {
            data.HocSinhs.Add(hs);
        }
        public List<HocSinh> LayDuLieuHocSinh()
        {
            return data.HocSinhs;
        }
        public List<HocSinh> TimTheoMaLop(string Malop)
        {
            var listhocsinh = new List<HocSinh>();
            foreach (var i in data.HocSinhs)
            {
                if (Malop == i.Lop.MaLop)
                {
                    listhocsinh.Add(i);
                }
            }
            return listhocsinh;
        }
    }
}
