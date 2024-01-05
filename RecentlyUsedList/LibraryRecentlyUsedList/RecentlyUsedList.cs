
namespace LibraryRecentlyUsedList
{
    public class RecentlyUsedList
    {
        private List<string> recentItems;

        public int NumberOfRecentItems => recentItems.Count;

        public RecentlyUsedList()
        {
            recentItems = new List<string>();
        }

        public void AddRecentItem(string v)
        {
            recentItems.Add(v);
        }
    }
}
