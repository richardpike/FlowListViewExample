using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[assembly: Xamarin.Forms.Dependency(typeof(FLV_Example.MockDataStore))]
namespace FLV_Example
{
	public class MockDataStore : IDataStore<Item>
	{
		List<Item> items;

		public MockDataStore()
		{
			items = new List<Item>();
			var mockItems = new List<Item>
			{
				new Item { Id = 1, Text = "First item", Description="This is an item description." },
				new Item { Id = 2, Text = "Second item", Description="This is an item description." },
				new Item { Id = 3, Text = "Third item", Description="This is an item description." },
			};

			foreach (var item in mockItems)
			{
				items.Add(item);
			}
		}

		

		public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
		{
			return await Task.FromResult(items);
		}
	}
}
