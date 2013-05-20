using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAProject.Models
{
    public interface IMessageBoardRepository
    {
        IList<MessageBoardEntry> GetMostRecentEntries();
        MessageBoardEntry FindById(int id);
        IList<PostSummary> GetPostSummary();
        void AddEntry(MessageBoardEntry entry);
    }
}
