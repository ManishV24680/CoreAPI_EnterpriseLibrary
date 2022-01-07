using OKR_COREAPI.Models;
using System.Collections.Generic;
using OKR_COREAPI.BaseClass;
using System.Data;
using OKR_COREAPI.Query;

namespace OKR_COREAPI.Repository
{
    public class FamRepository : IFamRespository
    {
        public List<AssetModel> GetAssetList()
        {
            //List<AssetModel> model = new List<AssetModel>();

            //AssetModel am = new AssetModel();
            //am.AssetName = "COMPUTER & HARDWARE";
            //am.AssetStatus = "Active";
            //am.AssetID = "5432424";
            //am.AssetSN = "SN002";
            //am.Description = "BSG-LAPTOP-125";
            //am.PurchaseDate = "2021-12-31";
            //am.SubAssetName = "LAPTOP";
            //am.Model = "Dell Pro XYZ";
            //am.VendorName = "Manish Infotech";
            //am.EmployeeName = "Manish Verma";
            //am.AssignTo = "BSG-034";
            //model.Add(am);

            //AssetModel am1 = new AssetModel();
            //am1.AssetName = "COMPUTER & HARDWARE";
            //am1.AssetStatus = "Active";
            //am1.AssetID = "5432424";
            //am1.AssetSN = "SN002";
            //am1.Description = "BSG-LAPTOP-125";
            //am1.PurchaseDate = "2021-12-31";
            //am1.SubAssetName = "LAPTOP";
            //am1.Model = "Dell Pro XYZ";
            //am1.VendorName = "Manish Infotech";
            //am1.EmployeeName = "Manish Verma";
            //am1.AssignTo = "BSG-034";
            //model.Add(am1);

            //return model;

            clsDB db = new clsDB();
            DataTable dt = db.GetDataTable(FAMQuery.GetAssetList());
            List<AssetModel> model = clsDataTableToList.ConvertDataTable<AssetModel>(dt);
            return model;
        }
    }
}
