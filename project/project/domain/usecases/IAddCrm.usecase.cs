using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.domain.model;
using project.presentation.protocols;

namespace project.domain.usecases
{
	interface IAddCrm
	{
		void addCrm(List<Answer> answers);		
			
	}	
	interface IAddCrmDTO
	{
		void addCrm(List<AnswerDTO> answers);		
			
	}
}
