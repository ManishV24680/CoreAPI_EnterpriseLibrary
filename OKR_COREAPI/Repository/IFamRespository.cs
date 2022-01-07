using OKR_COREAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OKR_COREAPI.Repository
{
    public interface IFamRespository
    {
        List<AssetModel> GetAssetList();
    }
}
