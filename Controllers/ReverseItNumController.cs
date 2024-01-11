using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LazarB_MiniChallengeFiveToSevenEndpoint.Services.MadL.ReverseAlph;
using LazarB_MiniChallengeFiveToSevenEndpoint.Services.MadL.ReverseNum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LazarB_MiniChallengeFiveToSevenEndpoint.Controllers;
[ApiController]
[Route("[controller]")]
public class ReverseItNumController : Controller
{
    private readonly IReverseNumServices _reverseNumServices;

    public ReverseItNumController(IReverseNumServices reverseNumServices)
    {

        _reverseNumServices = reverseNumServices;
    }

    [HttpGet]
    [Route("ReverseItNum/{userNumber}")]

    public string ReverseNumbers(string userNumber)
    {
        return _reverseNumServices.ReverseNumbers(userNumber);
    }
}
