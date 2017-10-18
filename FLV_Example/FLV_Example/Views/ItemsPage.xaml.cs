using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FLV_Example
{
	public partial class ItemsPage : ContentPage
	{
		ItemsViewModel viewModel;

		public ItemsPage()
		{
			InitializeComponent();

			BindingContext = viewModel = new ItemsViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (viewModel.Items.Count == 0)
				viewModel.LoadItemsCommand.Execute(null);
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			viewModel.AscendingItems();
		}

		private void Button_Clicked_1(object sender, EventArgs e)
		{
			viewModel.DescendingItems();
		}
	}
}