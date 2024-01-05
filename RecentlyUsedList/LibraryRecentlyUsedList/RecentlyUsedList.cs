
namespace LibraryRecentlyUsedList
{
    public class RecentlyUsedList
    {
        private readonly List<string> recentItems;

        public int NumberOfRecentItems => recentItems.Count;

        public RecentlyUsedList()
        {
            recentItems = [];
        }

        public void AddRecentItem(string recentItem)
        {
            recentItems.Add(recentItem);
        }
    }
}
