
namespace LazarB_MiniChallengeFiveToSevenEndpoint.Services.MadL.ReverseAlph
{
    public class ReverseAlphService : IReverseAlphServices
    {
        public string ReverseAlphabet(string word)
        {
            string reversedW = "";
            for(int i = word.Length - 1; i >= 0; i--){
                reversedW += word[i];
            }
            return $"The reverse of {word} is {reversedW}";
        }
    }
}