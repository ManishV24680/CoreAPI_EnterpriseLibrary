using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OKR_COREAPI.BaseClass;
using OKR_COREAPI.Models;
using OKR_COREAPI.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace OKR_COREAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamController : ControllerBase
    {
        IFamRespository testRepository = new FamRepository();

        [HttpGet]
        [Route("get_asset_list")]
        public IActionResult getAssetData()
        {
            return Ok(JsonSerializer.Serialize(testRepository.GetAssetList()));
        }

        [HttpGet]
        [Route("test")]
        public ActionResult gettest()
        {
            return Ok("test");
        }

        //[HttpGet]
        //[Route("assetdata")]
        //public async Task<ActionResult<IEnumerable<AssetModel>>> getAssetDataList()
        //{
        //    return await testRepository.GetAssetList();
        //}
    }
}
