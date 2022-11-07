using AppNauAnAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AppNauAnAPI.Controllers
{
    
    [Route("api/")]
    [ApiController]
    public class GetallMonController : ControllerBase
    {
        AppNauAnContext appnauancontext;
        public GetallMonController(AppNauAnContext context)
        {
            appnauancontext = context;
        }
        [HttpGet]
        [Route("getallmonProcedure")]
        public IActionResult Getallmon()
        {
            string query = "EXEC dbo.laydanhsachmon";
            var result = appnauancontext.Mons.FromSqlRaw(query).AsEnumerable().ToList();
            return Ok(result);
        }

        [HttpGet]
        [Route("getallmonEntity")]
        public IActionResult layDS()
        {
            List<Mon> list = appnauancontext.Mons.ToList();
            return Ok(list);
        }



        [HttpPost]
        [Route("themmotmon")]
        public IActionResult ChangePassword(string mamon, string tenmon,string maloai,string congthuclam)
        {

            string query = "EXEC duyhieu.Themmotmon @mamon ,@tenmon ,@maloai ,@congthuclam ";

            List<SqlParameter> parms = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@mamon", Value = mamon },
                new SqlParameter { ParameterName = "@tenmon", Value = tenmon },
                new SqlParameter { ParameterName = "@maloai", Value = maloai },
                new SqlParameter { ParameterName = "@congthuclam", Value = congthuclam }
            };

            var result = appnauancontext.Database.ExecuteSqlRaw(query, parms);
            return Ok(result);
        }



    }
}
