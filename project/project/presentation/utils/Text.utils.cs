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
            posSale = posSale.Trim();
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
                throw new Exception($"Unexpected posSale name {posSale}");
            }
        }

        public static string translatePosSalePresentation(string posSale)
        {
            posSale = posSale.Trim();
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
                throw new Exception($"Unexpected posSale name {posSale}");
            }
        }

        public static string translateStatusAnswerData(string status)
        {
            status = status.Trim();
            if (status == "PENDENTE")
            {
                return "pending";
            }
            else if (status == "RESOLVIDO")
            {
                return "done";
            }
            else
            {
                throw new Exception($"Unexpected status name {status}");
            }
        }

        public static string translateStatusAnswerPresentation(string status)
        {
            status = status.Trim();
            if (status == "pending")
            {
                return "PENDENTE";
            }
            else if (status == "done")
            {
                return "RESOLVIDO";
            }
            else
            {
                throw new Exception($"Unexpected status name {status}"  );
            }
        }
    }
}
