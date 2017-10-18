using System.Collections.Generic;
using System.Threading.Tasks;

namespace FLV_Example
{
	public interface IDataStore<T>
	{
		Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
	}
}