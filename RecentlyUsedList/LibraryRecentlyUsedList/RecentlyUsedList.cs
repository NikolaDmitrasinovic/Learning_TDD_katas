namespace LibraryRecentlyUsedList
{
    public class RecentlyUsedList
    {
        private readonly List<string> recentItems;
        private readonly int setNumberOfItems;
        public int NumberOfRecentItems => recentItems.Count;

        public RecentlyUsedList(int _setNumberOfItems = 10)
        {
            recentItems = [];
            setNumberOfItems = _setNumberOfItems;
        }

        public void AddRecentItem(string recentItem)
        {
            recentItems.Remove(recentItem);

            recentItems.Insert(0, recentItem);

            if (NumberOfRecentItems > setNumberOfItems)
            {
                recentItems.RemoveAt(setNumberOfItems);
            }
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
