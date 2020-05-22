using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GmailApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GmailReaderController : ControllerBase
    {

        private readonly ILogger<GmailReaderController> _logger;

        public GmailReaderController(ILogger<GmailReaderController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public bool Get()
        {
            return true;
        }
    }
}
