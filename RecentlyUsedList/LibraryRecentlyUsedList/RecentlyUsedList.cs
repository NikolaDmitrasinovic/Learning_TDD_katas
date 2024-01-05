
namespace LibraryRecentlyUsedList
{
    public class RecentlyUsedList
    {
        public List<string> RecentItems { get; private set; }

        public int NumberOfRecentItems => RecentItems.Count;

        public RecentlyUsedList()
        {
            RecentItems = [];
        }

        public void AddRecentItem(string recentItem)
        {
            if (RecentItems.Contains(recentItem))
                RecentItems.Remove(recentItem);

            RecentItems.Insert(0, recentItem);
        }
    }
}
