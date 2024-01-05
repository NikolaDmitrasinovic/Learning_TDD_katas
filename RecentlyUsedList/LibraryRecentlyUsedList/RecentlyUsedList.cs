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
            RecentItems.Remove(recentItem);

            RecentItems.Insert(0, recentItem);
        }

        public string ReturnRecentItem(int index)
        {
            return RecentItems[index];
        }
    }
}
