using Microsoft.VisualStudio.TestTools.UnitTesting;
using project.domain.model;
using specs.suport.factories.feature.answers;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;

namespace specs.feature.postgres
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var idAnswer = Guid.NewGuid().ToString();
            var idQuestion = Guid.NewGuid().ToString();
            var teste = new List<AnswerModel>()
            {
                    new AnswerModel()
                    {
                        answer = "answer",
                        createdAt = new DateTime(2000, 01, 01),
                        id = idAnswer,
                        idClient = "00001",
                        idCompany = "01",
                        idQuestion = "8f2e538a-8cf1-4012-8011-6c3f8f4a085b",
                        idSale = "idSale",
                        observation = "observation",
                        resolution = "resolution",
                        status = "done",
                        updatedAt = new DateTime(2000, 01, 01)
                    }
            };
            try
            {
                AnswersRepositoryFactoryMock.answerRepository.addAnswersRepository(teste);
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Console.WriteLine("Propriedade: {0} Erro: {1}",
                                          validationError.PropertyName,
                                          validationError.ErrorMessage);
                    }
                }
            }
        }
    }
}
