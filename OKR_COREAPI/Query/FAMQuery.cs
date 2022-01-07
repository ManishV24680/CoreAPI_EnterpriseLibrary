using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OKR_COREAPI.Query
{
    public class FAMQuery
    {
        public static string GetAssetList()
        {
            return "select * from tbl_AssetMaster";
        }
    }
}
