using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LazarB_MiniChallengeFiveToSevenEndpoint.Services.MadL.ReverseAlph;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LazarB_MiniChallengeFiveToSevenEndpoint.Controllers;
[ApiController]
[Route("[controller]")]
public class ReverseItNumController : Controller
{
    private readonly IReverseAlphServices _reverseAlphServices;

    public ReverseItNumController(IReverseAlphServices reverseAlphServices)
    {
        _reverseAlphServices = reverseAlphServices;
    }

    [HttpGet]
    [Route("ReverseItNum/{userNumber}")]

    public string ReverseAlphabet(string userNumber)
    {
        return _reverseAlphServices.ReverseAlphabet(userNumber);
    }
}
