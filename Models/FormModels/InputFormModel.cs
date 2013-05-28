using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildAProject.Models.FormModels
{
    public class InputFormModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public InputFormModel (string first, string last)
        {
            FirstName = first;
            LastName = last;

        }
    }
}