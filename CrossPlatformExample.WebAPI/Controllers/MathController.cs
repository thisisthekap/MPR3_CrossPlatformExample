using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace CrossPlatformExample.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class MathController
    {
        [HttpGet("square/{valueToSquare}")]
        [SwaggerOperation(nameof(Square))]
        public int Square([Required] int valueToSquare)
        {
            return valueToSquare * valueToSquare;
        }
    }
}
