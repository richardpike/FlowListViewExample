using FLV_Example.Helpers;
using FLV_Example.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FLV_Example
{
	public class ItemsViewModel : BaseViewModel
	{
		public ObservableCollection<Item> Items { get; set; }

		public ObservableRangeCollection<Grouping<string, Item>> ItemListGrouped { get; set; } = new ObservableRangeCollection<Grouping<string, Item>>();

		public Command LoadItemsCommand { get; set; }

		public ItemsViewModel()
		{
			Title = "Browse";
			Items = new ObservableCollection<Item>();
			LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
		}

		async Task ExecuteLoadItemsCommand()
		{
			if (IsBusy)
				return;

			IsBusy = true;

			try
			{
				Items.Clear();
				var items = await DataStore.GetItemsAsync(true);
				foreach (var item in items)
				{
					Items.Add(item);
				}

				AscendingItems();
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
			finally
			{
				IsBusy = false;
			}
		}

		public void AscendingItems()
		{
			ItemListGrouped.ReplaceRange(Items.GroupByIDAscending());
		}

		public void DescendingItems()
		{
			ItemListGrouped.ReplaceRange(Items.GroupByIDDescending());
		}
	}
}
