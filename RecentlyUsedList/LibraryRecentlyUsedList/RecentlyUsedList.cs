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
            recentItems.Remove(recentItem);

            recentItems.Insert(0, recentItem);
        }

        public string ReturnRecentItem(int index)
        {
            if (IsOutOfRange(index))
                throw new IndexOutOfRangeException("List empty or index out of range");

            return recentItems[index];
        }

        private bool IsOutOfRange(int index)
        {
            return recentItems.Count < index || recentItems.Count == 0;
        }
    }
}
