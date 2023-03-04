using basicToMordern.Data;
using basicToMordern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicToMordern.XulyDulieu
{
    public class XulyDulieuKhoiLop
    {
        DLKL data = new DLKL();
        public XulyDulieuKhoiLop(DLKL data)
        {
            this.data = data;
        }
        public void LuuKhoiLopMoi(KhoiLop khoi)
        {
            data.KhoiLops.Add(khoi);
        }

        public List<KhoiLop> LayDuLieuKhoiLop()
        {
            return data.KhoiLops;
        }
    }
}
