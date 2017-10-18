using System.Collections.Generic;

namespace FLV_Example.Helpers
{
	public class Grouping<T, TV> : ObservableRangeCollection<TV>
	{
		/// <summary>
		/// Gets the key.
		/// </summary>
		/// <value>The key.</value>
		public T Key { get; private set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Grouping{T, TV}"/> class.
		/// </summary>
		/// <param name="key">Key.</param>
		/// <param name="items">Items.</param>
		public Grouping(T key, IEnumerable<TV> items)
		{
			Key = key;
			AddRange(items);
		}
	}
}
