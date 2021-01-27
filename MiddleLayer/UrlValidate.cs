using System;

namespace MiddleLayer
{
    public class UrlValidate : TextValidate
    {
        public void ValidateInput(string input)
        {
            if (Uri.IsWellFormedUriString(input, UriKind.Absolute) == false)
            {
                throw new Exception("Ange en giltig url");
            }
        }
    }

}
