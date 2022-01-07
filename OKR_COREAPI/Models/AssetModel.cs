using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OKR_COREAPI.Models
{
    public class AssetModel
    {
        public long ID { get; set; }
        public string AssetName { get; set; }
        public string SubAssetName { get; set; }
        public string AssetID { get; set; }
        public string AssetSN { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string AssetStatus { get; set; }
        public string PurchaseDate { get; set; }
        public string VendorName { get; set; }
        public string AssignTo { get; set; }
        public string EmployeeName { get; set; }

    }
}
