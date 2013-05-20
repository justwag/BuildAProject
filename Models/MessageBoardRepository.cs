using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildAProject.Models
{
    public class MessageBoardRepository : IMessageBoardRepository
    {
        private MessageBoardContext _db = new MessageBoardContext();

        public IList<MessageBoardEntry> GetMostRecentEntries()
        {
            return (from entry in _db.Entries
                    orderby entry.DateAdded descending 
                    select entry).Take(20).ToList();
        }

        public MessageBoardEntry FindById(int id)
        {
            var entry = _db.Entries.Find(id);
            return entry;
        }

        public IList<PostSummary> GetPostSummary()
        {
            var entries = from entry in _db.Entries
                          group entry by entry.Name
                          into groupedByName
                          orderby groupedByName.Count() descending
                          select new PostSummary
                                     {
                                         TotalPosts = groupedByName.Count(),
                                         UserName = groupedByName.Key
                                     };
            return entries.ToList();
        }

        public void AddEntry(MessageBoardEntry entry)
        {
            entry.DateAdded = DateTime.Now;

            _db.Entries.Add(entry);
            _db.SaveChanges();
        }
    }
}