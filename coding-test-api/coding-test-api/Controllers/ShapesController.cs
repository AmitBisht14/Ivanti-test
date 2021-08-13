using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection.XmlEncryption;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace coding_test_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShapeController : ControllerBase
    {
        private ITriangleInfo triangleInfo;
        public ShapeController(ITriangleInfo triangleInfo)
        {
            this.triangleInfo = triangleInfo;
        }

        [HttpGet("GetDataFromVertices")]
        public IActionResult GetNameFromVertices([FromQuery]TriangleVertices triangleVertices)
        {
            try
            {
                RowColumns response = triangleInfo.CalculateRowColumns(triangleVertices);
                return StatusCode(200, response);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }

        }

        [HttpGet("GetDataFromRowColumn")]
        public IActionResult GetVerticesFromName([FromQuery]RowColumns rowColumns)
        {
            try
            {
                TriangleVertices response = triangleInfo.CalculateVertices(rowColumns);
                return StatusCode(200, response);
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }
    }
}
