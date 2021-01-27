using System;
using System.Windows.Forms;

namespace MiddleLayer
{

    public class ErrorHandler
        {
            public static void HandleError(Exception ex)
            {
                if (ex.GetType() == typeof(Exception))
                {
                    MessageBox.Show(ex.Message, "Valideringsfel", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Något gick fel!", MessageBoxButtons.OK);
                }
            }
        }
}

