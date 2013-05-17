using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BuildAProject.Models
{
    public class MessageBoardContext : DbContext
    {
        public MessageBoardContext() : base("Message Board"){}

        public DbSet<MessageBoardEntry> Entries { get; set; }
    }
}