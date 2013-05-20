using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildAProject.Models
{
    public class FakeMessageBoardRepository : IMessageBoardRepository
    {
        private List<MessageBoardEntry>  _entries = new List<MessageBoardEntry>();

        public IList<MessageBoardEntry> GetMostRecentEntries()
        {
           return new List<MessageBoardEntry>
                      {
                          new MessageBoardEntry
                              {
                                  DateAdded = new DateTime(2011, 6, 1),
                                  Id = 1,
                                  Message = "Test Message",
                                  Name = "Justin"
                              }
                      };
        }

        public MessageBoardEntry FindById(int id)
        {
            return _entries.SingleOrDefault(x => x.Id == id);
        }

        public IList<PostSummary> GetPostSummary()
        {
            return new List<PostSummary>
                       {
                           new PostSummary
                               {
                                   UserName = "Justin", TotalPosts = 1
                               }
                       };
        }

        public void AddEntry(MessageBoardEntry entry)
        {
            _entries.Add(entry);
        }
    }
}