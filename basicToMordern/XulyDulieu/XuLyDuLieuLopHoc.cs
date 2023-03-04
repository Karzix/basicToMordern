using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using basicToMordern.Data;
using basicToMordern.Models;

namespace basicToMordern.XulyDulieu
{
    public class XuLyDuLieuLopHoc
    {
        DLKL data = new DLKL();
        public XuLyDuLieuLopHoc(DLKL data)
        {
            this.data = data;
        }
        public void LuuDuLieuLopHoc(LopHoc l)
        {
            data.LopHocs.Add(l);
        }
        public List<LopHoc> LayDuLieuLopHoc()
        {
            return data.LopHocs;
        }
        public List<LopHoc> TimTheoTenKhoi(string tenkhoi)
        {
            var listlophoc = new List<LopHoc>();
            foreach(var i in data.LopHocs)
            {
                if(tenkhoi== i.KhoiLop.TenKhoiLop)
                {
                    listlophoc.Add(i);
                }
            }
            return listlophoc;
        }
    }
}
