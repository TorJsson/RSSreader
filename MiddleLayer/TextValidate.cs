using System;
namespace MiddleLayer
{

    public class TextValidate
    {
        public virtual void ValideraInput(string input)
        {
            if (input.Length <= 2)
            {
                throw new Exception("Ange mer än 2 tecken");
            }
        }
    }





}
