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

            RemoveOldItems();
        }

        private void RemoveOldItems()
        {
            if (NumberOfRecentItems > setNumberOfItems)
                recentItems.RemoveAt(setNumberOfItems);
        }

        public string ReturnRecentItem(int index)
        {
            CheckIfOutOfRange(index);

            return recentItems[index];
        }

        private void CheckIfOutOfRange(int index)
        {
            if (recentItems.Count < index || recentItems.Count == 0)
                throw new IndexOutOfRangeException("List empty or index out of range");
        }
    }
}
