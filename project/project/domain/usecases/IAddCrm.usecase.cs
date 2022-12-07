using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.domain.model;

namespace project.domain.usecases
{
	interface IAddCrm
	{
		void addCrm(Answer[] answers);		
	}
}
