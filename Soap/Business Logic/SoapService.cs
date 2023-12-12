using System.ServiceModel;

namespace Soap.Business_Logic
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        string ReverseString(string contextToReverse);

        [OperationContract]
        string ReverseChars(string contextToReverse);

    }

    public class SoapService : ISoapService
    {
        public string ReverseString(string contextToReverse)
        {
            var words = contextToReverse.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        public string ReverseChars(string contextToReverse)
        {
            var chars= contextToReverse.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
