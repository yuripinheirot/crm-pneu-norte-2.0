using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.domain.model;
using project.presentation.protocols;

namespace project.domain.interfaces.usecases
{
	public interface IPostAnswerAlreadyExists
	{
		bool postAnswerAlreadyExists(string idCompany, string idSale);
	}
}
