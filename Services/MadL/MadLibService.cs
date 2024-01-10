
using LazarB_MiniChallengeFiveToSevenEndpoint.Services.MadL;


// namespace LazarB_MiniChallengeFiveToSevenEndpoint.Services;

    public class MadLibService : IMadLibServices
    {
        public string AdLibs(string animal, string store, string animal2, string verb, string adjective, string possessivePronoun, string weapon, string vehicle, string niceLocation, string blastOrLeave)
        {
            return $"There once was a {animal} who decided to go {store}, but then his opp who was a {animal2} decided to pull up. So they ended up {verb}, after that they were {adjective}. The {animal} went home after the situation, then decided to go get {possessivePronoun} {weapon} and spin the block on {possessivePronoun} opp. After getting to {possessivePronoun} opp's house the {animal} saw that the opp had a family. Then the {animal} dropped {possessivePronoun} {weapon} and got out {possessivePronoun} {vehicle}. The {animal} went over to dap up his opp, They talked for awhile and decided to go to the {niceLocation} to reflect on their life decisions. Once all was done the {animal} took the {animal2} back to their family, just as the {animal2} was going through the front door... The {animal} decided to {blastOrLeave} {possessivePronoun} opp.";
        }
    }
