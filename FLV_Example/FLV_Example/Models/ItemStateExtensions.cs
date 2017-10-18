using FLV_Example.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLV_Example.Models
{
	public static class ItemStateExtensions
	{
		public static IEnumerable<Grouping<string, Item>> GroupByIDAscending(this IList<Item> itemList)
		{
			var grouped = (from iList in itemList
						   orderby iList.Id
						   group iList by iList.Id
					into itemGroup
						   select new Grouping<string, Item>(itemGroup.Key.ToString(), itemGroup)).ToList();

			return grouped;
		}

		public static IEnumerable<Grouping<string, Item>> GroupByIDDescending(this IList<Item> itemList)
		{
			var grouped = (from iList in itemList
						   orderby iList.Id descending
						   group iList by iList.Id
					into itemGroup
						   select new Grouping<string, Item>(itemGroup.Key.ToString(), itemGroup)).ToList();

			return grouped;
		}
	}
}
