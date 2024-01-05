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
            if (RecentItems.Count < index || RecentItems.Count == 0)
                throw new IndexOutOfRangeException("List empty or index out of range");

            return RecentItems[index];
        }
    }
}
