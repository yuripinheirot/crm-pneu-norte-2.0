using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.domain.model;
using project.presentation.protocols;

namespace project.domain.usecases
{
	interface IPostCrmRepository
	{
		void addCrm(List<AnswerModel> answers);		
			
	}	
	interface IPostCrm
	{
		void addCrm(List<PostAnswerDTO> answers);		
			
	}
}
