using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildAProject.Models
{
    public class MessageBoardEntry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public DateTime DateAdded { get; set; }
    }
}