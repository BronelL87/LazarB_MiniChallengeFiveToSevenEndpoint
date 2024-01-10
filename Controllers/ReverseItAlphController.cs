using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LazarB_MiniChallengeFiveToSevenEndpoint.Services.MadL.ReverseAlph;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LazarB_MiniChallengeFiveToSevenEndpoint.Controllers;

    [Route("[controller]")]
    public class ReverseItAlphController : Controller
    {
    private readonly IReverseAlphServices _reverseAlphServices;

    public ReverseItAlphController(IReverseAlphServices reverseAlphServices)
    {
        _reverseAlphServices = reverseAlphServices;
    }

    [HttpGet]
    [Route("ReverseItAlph/{word}")]

    public string ReverseAlphabet(string word){
        return _reverseAlphServices.ReverseAlphabet(word);
    }
}
