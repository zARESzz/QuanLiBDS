using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
namespace Main
{
    public class cls_ChucVu
    {
        data_BDSEntities db = new data_BDSEntities();
        public List<CHUCVU> getList()
        {
            return db.CHUCVUs.ToList();
        }
    }
}
