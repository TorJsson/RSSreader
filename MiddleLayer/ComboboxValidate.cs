using System;

namespace MiddleLayer
{

    public class ComboboxValidate : TextValidate
    {
        public void ValidateInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Ange ett värde i comboboxen");
            }
        }
    }
}



