using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WallPaperAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WallPaperController : ControllerBase
    {
        public string[] getData()
        {
            return new string[] { "welcome", "Good morning" };
        }
    }
}
