using project.domain.model.entities;
using System.Collections.Generic;

namespace project.specs.mocks
{
    internal class QuestionsMock
    {
        public static List<QuestionModel> questions = new List<QuestionModel>()
        {
            new QuestionModel()
            {
                id = "8f2e538a-8cf1-4012-8011-6c3f8f4a085b",
                active = true,
                description = "First question order",
                posSale = "order",
                answers = new List<string> { "1", "2", "3" },
                badAnswers = new List<string> { "1" }
            },
            new QuestionModel()
            {
                id = "b3d553c8-48f1-42b6-8c08-9e8658e53a7d",
                active = false,
                description = "Second question order deactivated",
                posSale = "order",
                answers = new List<string> { "a", "b", "c" },
                badAnswers = new List<string> { "a", "b" }
            },
            new QuestionModel()
            {
                id = "a2957f07-9893-4f60-9961-8769fd2f9295",
                active = true,
                description = "Third question order",
                posSale = "order",
                answers = new List<string> { "yes", "no", "maybe" },
                badAnswers = new List<string> { "no" }
            },
            new QuestionModel()
            {
                id = "d95239be-62ff-4b78-8ea1-1f454bf579f9",
                active = true,
                description = "Fourth question order",
                posSale = "order",
                answers = new List<string> { "3", "4", "5" },
                badAnswers = new List<string> { "3" }
            },
            new QuestionModel()
            {
                id = "99b84ac8-916f-4f53-ac9a-9edcf6df2fbc",
                active = true,
                description = "Fifth question order",
                posSale = "order",
                answers = new List<string> { "foo", "bar", "gzz" },
                badAnswers = new List<string> { "foo" }
            },
            new QuestionModel()
            {
                id = "1ca430f4-6fb9-41bd-8a35-9a71e5decc46",
                active = false,
                description = "6 question sale deactivated",
                posSale = "sale",
                answers = new List<string> { "chicken", "horse", "cow" },
                badAnswers = new List<string> { "chicken" }
            },
            new QuestionModel()
            {
                id = "0f6b958d-3e0a-48bd-be6d-0ced93cf2767",
                active = true,
                description = "7 question sale",
                posSale = "sale",
                answers = new List<string> { "metallica", "iron maiden", "led zeppelin", "queen" },
                badAnswers = new List<string> { "queen" }
            },
            new QuestionModel()
            {
                id = "9aa1357e-5866-491a-b09b-bab3ff3704d6",
                active = true,
                description = "8 question sale",
                posSale = "sale",
                answers = new List<string> { "javascript", "java", "c#" },
                badAnswers = new List<string> { "java" }
            },
            new QuestionModel()
            {
                id = "a3c12558-1c0c-4b4e-acad-9ef352adefde",
                active = true,
                description = "9 question sale",
                posSale = "sale",
                answers = new List<string> { "jazz", "rock", "funk" },
                badAnswers = new List<string> { "funk" }
            },
            new QuestionModel()
            {
                id = "bc6124cb-cd60-4ac3-8a61-04da839bb986",
                active = true,
                description = "10 question sale",
                posSale = "sale",
                answers = new List<string> { "dell", "apple", "samsung" },
                badAnswers = new List<string> { "samsung" }
            },
        };
    }
}
