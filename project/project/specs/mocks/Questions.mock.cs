﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.domain.model;

namespace project.specs.mocks
{
    internal class QuestionsMock
    {
        public static List<Question> questionsMock = new List<Question>()
        {
            new Question()
            {
                id = 1,
                active = true,
                description = "First question order",
                module = "order",
                answers = new List<string> { "1", "2", "3" }
            },
            new Question()
            {
                id = 2,
                active = false,
                description = "Second question order deactivated",
                module = "order",
                answers = new List<string> { "a", "b", "c" }
            },
            new Question()
            {
                id = 3,
                active = true,
                description = "Third question order",
                module = "order",
                answers = new List<string> { "yes", "no", "maybe" }
            },
            new Question()
            {
                id = 4,
                active = true,
                description = "Fourth question order",
                module = "order",
                answers = new List<string> { "3", "4", "5" }
            },
            new Question()
            {
                id = 5,
                active = true,
                description = "Fifth question order",
                module = "order",
                answers = new List<string> { "foo", "bar", "gzz" }
            },
            new Question()
            {
                id = 6,
                active = false,
                description = "6 question sale deactivated",
                module = "sale",
                answers = new List<string> { "chicken", "horse", "cow" }
            },
            new Question()
            {
                id = 7,
                active = true,
                description = "7 question sale",
                module = "sale",
                answers = new List<string> { "metallica", "iron maiden", "led zeppelin" }
            },
            new Question()
            {
                id = 8,
                active = true,
                description = "8 question sale",
                module = "sale",
                answers = new List<string> { "javascript", "java", "c#" }
            },
            new Question()
            {
                id = 9,
                active = true,
                description = "9 question sale",
                module = "sale",
                answers = new List<string> { "jazz", "rock", "funk" }
            },
            new Question()
            {
                id = 10,
                active = true,
                description = "10 question sale",
                module = "sale",
                answers = new List<string> { "dell", "apple", "samsung" }
            },
        };
    }
}