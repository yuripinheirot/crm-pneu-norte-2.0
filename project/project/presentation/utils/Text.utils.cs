using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.presentation.utils
{
    public class TextUtils
    {
        public static string translatePosSaleData(string posSale)
        {
            if (posSale == "VENDAS")
            {
                return "sale";
            }
            else if (posSale == "SERVIÇOS")
            {
                return "order";
            }
            else
            {
                throw new Exception("Unexpected posSale name");
            }
        }

        public static string translatePosSalePresentation(string posSale)
        {
            if (posSale == "sale")
            {
                return "VENDAS";
            }
            else if (posSale == "order")
            {
                return "SERVIÇOS";
            }
            else
            {
                throw new Exception("Unexpected posSale name");
            }
        }

        public static string translateStatusAnswerData(string status)
        {
            if (status == "PENDENTE")
            {
                return "pending";
            }
            else if (status == "RESOLVIDO")
            {
                return "resolved";
            }
            else
            {
                throw new Exception("Unexpected status name");
            }
        }

        public static string translateStatusAnswerPresentation(string status)
        {
            if (status == "pending")
            {
                return "PENDENTE";
            }
            else if (status == "resolved")
            {
                return "RESOLVIDO";
            }
            else
            {
                throw new Exception("Unexpected status name");
            }
        }
    }
}
