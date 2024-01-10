
using LazarB_MiniChallengeFiveToSevenEndpoint.Services.MadL;
using Microsoft.AspNetCore.Mvc;


namespace LazarB_MiniChallengeFiveToSevenEndpoint.Controllers;
[ApiController]
    [Route("[controller]")]
    public class MadLibController : Controller
    {
    private readonly IMadLibServices _madLibServices;

    public MadLibController(IMadLibServices madLibServices)
    {
        _madLibServices = madLibServices;
    }

    [HttpGet]
    [Route("MadLib/{animal}/{store}/{animal2}/{verb}/{adjective}/{possessivePronoun}/{weapon}/{vehicle}/{niceLocation}/{blastOrLeave}")]

    public string AdLibs(string animal, string store, string animal2, string verb, string adjective, string possessivePronoun, string weapon, string vehicle, string niceLocation, string blastOrLeave){
        return _madLibServices.AdLibs(animal, store, animal2, verb, adjective, possessivePronoun, weapon, vehicle, niceLocation, blastOrLeave);
    }
    }
