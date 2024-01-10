
using LazarB_MiniChallengeFiveToSevenEndpoint.Services.MadL.OddOrEven;
using Microsoft.AspNetCore.Mvc;


namespace LazarB_MiniChallengeFiveToSevenEndpoint.Controllers;

[ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : Controller
    {
    private readonly IOddOrEvenServices _oddOrEvenServices;

    public OddOrEvenController(IOddOrEvenServices oddOrEvenServices)
    {
        _oddOrEvenServices = oddOrEvenServices;
    }

    [HttpGet]
    [Route("OddOrEven/{num}")]

    public string EvenOrOdd(string num){
        return _oddOrEvenServices.EvenOrOdd(num);
    }
}
