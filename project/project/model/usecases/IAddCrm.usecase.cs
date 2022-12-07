using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.model.protocols;

namespace project.model.usecases
{
	interface IAddCrm
	{
		void addCrm(NewAnswer[] answers);		
	}
}
