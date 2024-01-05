
namespace LibraryRecentlyUsedList
{
    public class RecentlyUsedList
    {
        private readonly List<string> recentItems;

        public List<string> RecentItems { get { return recentItems; } }

        public int NumberOfRecentItems => recentItems.Count;

        public RecentlyUsedList()
        {
            recentItems = [];
        }

        public void AddRecentItem(string recentItem)
        {
            recentItems.Insert(0, recentItem);
        }
    }
}
