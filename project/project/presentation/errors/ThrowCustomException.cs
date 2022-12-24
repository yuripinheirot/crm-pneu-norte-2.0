using project.presentation.errors.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.errors
{
    public class ThrowCustomException
    {
        static Dictionary<string, MessageBoxIcon> typeErrors = new Dictionary<string, MessageBoxIcon>()
        {
            { "Atenção!", MessageBoxIcon.Warning},
            { "Erro!", MessageBoxIcon.Error},
            { "Info!", MessageBoxIcon.Information},
        };

        public static void Throw(Exception error)
        {
            if (error is PresentationException exception)
            {
                MessageBox.Show(exception.description, exception.title, MessageBoxButtons.OK, typeErrors[exception.title]);
            }
            else
            {
                MessageBox.Show(error.Message, "Ops! Algo inesperado aconteceu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
