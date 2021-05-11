﻿using AdvancedLINQ.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedLINQ.Entities
{
    public class Subject : BaseEntity
    {
        public string Title { get; set; }
        public int Modules { get; set; }
        public int StudentsAttending { get; set; }
        public Academy Type { get; set; }

        public Subject(int id, string title, int modules, int students, Academy type)
        {
            Id = id;
            Title = title;
            Modules = modules;
            StudentsAttending = students;
            Type = type;
        }

        public override string Info()
        {
            return $"{Id}) {Title} of the {Type} Academy - {StudentsAttending} attending!";
        }
    }

}
