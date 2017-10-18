﻿using System;

using Xamarin.Forms;

namespace FLV_Example
{
	public class MainPage : TabbedPage
	{
		public MainPage()
		{
			Page itemsPage = null;

			switch (Device.RuntimePlatform)
			{
				case Device.iOS:
					itemsPage = new NavigationPage(new ItemsPage())
					{
						Title = "Browse"
					};

					itemsPage.Icon = "tab_feed.png";
					break;
				default:
					itemsPage = new ItemsPage()
					{
						Title = "Browse"
					};

					break;
			}

			Children.Add(itemsPage);

			Title = Children[0].Title;
		}

		protected override void OnCurrentPageChanged()
		{
			base.OnCurrentPageChanged();
			Title = CurrentPage?.Title ?? string.Empty;
		}
	}
}
