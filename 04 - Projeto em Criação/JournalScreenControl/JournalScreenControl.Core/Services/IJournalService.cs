using JournalScreenControl.Core.Model;

namespace JournalScreenControl.Core.Services
{
    public interface IJournalService : IService<Journal>
    {
        Journal NextJournal();
    }
}
