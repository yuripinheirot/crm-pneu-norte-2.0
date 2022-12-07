using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.domain.model;

namespace project.specs.mocks
{
    internal class Questions
    {
        public static List<Question> questionsMock = new List<Question>()
        {
            new Question()
            {
                id = 1,
                active = true,
                description = "First question order",
                module = "order"
            },
            new Question()
            {
                id = 2,
                active = false,
                description = "Second question order deactivated",
                module = "order"
            },
            new Question()
            {
                id = 3,
                active = true,
                description = "Third question order",
                module = "order"
            },
            new Question()
            {
                id = 4,
                active = true,
                description = "Fourth question order",
                module = "order"
            },
            new Question()
            {
                id = 5,
                active = true,
                description = "Fifth question order",
                module = "order"
            },
            new Question()
            {
                id = 6,
                active = false,
                description = "6 question sale deactivated",
                module = "sale"
            },
            new Question()
            {
                id = 7,
                active = true,
                description = "7 question sale",
                module = "sale"
            },
            new Question()
            {
                id = 8,
                active = true,
                description = "8 question sale",
                module = "sale"
            },
            new Question()
            {
                id = 9,
                active = true,
                description = "9 question sale",
                module = "sale"
            },
            new Question()
            {
                id = 10,
                active = true,
                description = "10 question sale",
                module = "sale"
            },
        };
    }
}
