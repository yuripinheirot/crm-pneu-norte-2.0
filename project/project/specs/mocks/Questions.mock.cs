using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.domain.model;

namespace project.specs.mocks
{
    internal class QuestionsMock
    {
        public static List<QuestionModel> questions = new List<QuestionModel>()
        {
            new QuestionModel()
            {
                id = "1",
                active = true,
                description = "First question order",
                posSale = "order",
                answers = new List<string> { "1", "2", "3" },
                badAnswers = new List<string> { "1" }
            },
            new QuestionModel()
            {
                id = "2",
                active = false,
                description = "Second question order deactivated",
                posSale = "order",
                answers = new List<string> { "a", "b", "c" },
                badAnswers = new List<string> { "a", "b" }
            },
            new QuestionModel()
            {
                id = "3",
                active = true,
                description = "Third question order",
                posSale = "order",
                answers = new List<string> { "yes", "no", "maybe" },
                badAnswers = new List<string> { "no" }
            },
            new QuestionModel()
            {
                id = "4",
                active = true,
                description = "Fourth question order",
                posSale = "order",
                answers = new List<string> { "3", "4", "5" },
                badAnswers = new List<string> { "3" }
            },
            new QuestionModel()
            {
                id = "5",
                active = true,
                description = "Fifth question order",
                posSale = "order",
                answers = new List<string> { "foo", "bar", "gzz" },
                badAnswers = new List<string> { "foo" }
            },
            new QuestionModel()
            {
                id = "6",
                active = false,
                description = "6 question sale deactivated",
                posSale = "sale",
                answers = new List<string> { "chicken", "horse", "cow" },
                badAnswers = new List<string> { "chicken" }
            },
            new QuestionModel()
            {
                id = "7",
                active = true,
                description = "7 question sale",
                posSale = "sale",
                answers = new List<string> { "metallica", "iron maiden", "led zeppelin", "queen" },
                badAnswers = new List<string> { "queen" }
            },
            new QuestionModel()
            {
                id = "8",
                active = true,
                description = "8 question sale",
                posSale = "sale",
                answers = new List<string> { "javascript", "java", "c#" },
                badAnswers = new List<string> { "java" }
            },
            new QuestionModel()
            {
                id = "9",
                active = true,
                description = "9 question sale",
                posSale = "sale",
                answers = new List<string> { "jazz", "rock", "funk" },
                badAnswers = new List<string> { "funk" }
            },
            new QuestionModel()
            {
                id = "10",
                active = true,
                description = "10 question sale",
                posSale = "sale",
                answers = new List<string> { "dell", "apple", "samsung" },
                badAnswers = new List<string> { "samsung" }
            },
        };
    }
}
