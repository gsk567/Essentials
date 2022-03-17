using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Essentials.Results
{
    /// <summary>
    /// Result that contains collection of items and corresponding pagination details.
    /// </summary>
    /// <typeparam name="T">List item type.</typeparam>
    public class PaginatedItemsResult<T>
    {
        private PaginatedItemsResult(IEnumerable<T> items, int pageSize, int currentPage, int totalCount)
        {
            this.Items = new ReadOnlyCollection<T>(items.ToList());
            this.PageSize = pageSize;
            this.CurrentPage = currentPage;
            this.TotalCount = totalCount;
            this.ValidateResult();
        }

        /// <summary>
        /// Collection of all items in the result.
        /// </summary>
        public IEnumerable<T> Items { get; }

        /// <summary>
        /// Count of all items in all pages.
        /// </summary>
        public int TotalCount { get; }

        /// <summary>
        /// Count of the items in the current page.
        /// </summary>
        public int Count => this.Items?.Count() ?? 0;

        /// <summary>
        /// Amount of the pages based on all items and page size.
        /// </summary>
        public int PagesCount
        {
            get
            {
                if (this.PageSize == 0)
                {
                    return 1;
                }

                return (int)Math.Ceiling(this.TotalCount / ((double)this.PageSize));
            }
        }

        /// <summary>
        /// Amount items on a page.
        /// </summary>
        public int PageSize { get; }

        /// <summary>
        /// Current page index.
        /// </summary>
        public int CurrentPage { get; } = 1;

        /// <summary>
        /// Index of the first item of the current page based on all items.
        /// </summary>
        public int StartRow => (this.CurrentPage - 1) * this.PageSize;

        /// <summary>
        /// Returns paginated items result from general input.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="pageSize"></param>
        /// <param name="currentPage"></param>
        /// <param name="totalCount"></param>
        /// <returns></returns>
        public static PaginatedItemsResult<T> ResultFrom(IEnumerable<T> items, int pageSize, int currentPage, int totalCount) =>
            new PaginatedItemsResult<T>(items, pageSize, currentPage, totalCount);

        private void ValidateResult()
        {
            if (this.PageSize < this.Count)
            {
                throw new InvalidOperationException("Items in the current result cannot exceeds the page size");
            }
        }
    }
}