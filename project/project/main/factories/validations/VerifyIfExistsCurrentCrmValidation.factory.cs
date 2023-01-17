using project.data.usecases.answers;
using project.infra.db.mock.repository;
using project.validations.crm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.main.factories.validations
{
    public class VerifyIfExistsCurrentCrmValidationFactory
    {
        private static AnswersMockRepository answersRepository = new AnswersMockRepository();
        private static AnswersData answersData = new AnswersData(answersRepository);

        public static VerifyIfExistsCurrentCrmValidation handle = new VerifyIfExistsCurrentCrmValidation(answersData);
    }
}
