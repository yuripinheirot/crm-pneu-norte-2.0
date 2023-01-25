using project.presentation.errors.exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
            
            if (error is DbEntityValidationException dbError)
            {
                string errorString = "";

                foreach (var validationError in dbError.EntityValidationErrors)
                {
                    errorString += String.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors: \n",
                        validationError.Entry.Entity.GetType().Name, validationError.Entry.State);
                    foreach (var propertyError in validationError.ValidationErrors)
                    {
                        errorString += String.Format("- Property: \"{0}\", Error: \"{1}\"\n",
                            propertyError.PropertyName, propertyError.ErrorMessage);
                    }
                }

                new ErrorForm(error.Message, errorString).ShowDialog();
            }
            else
            {
                if (error.InnerException != null)
                {
                    new ErrorForm(error.Message, error.InnerException.ToString()).ShowDialog();
                }
                else
                {
                    new ErrorForm(error.Message, error.Message).ShowDialog();
                }
            }
        }
    }
}
