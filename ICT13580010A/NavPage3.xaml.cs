using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580010A
{
    public partial class NavPage3 : ContentPage
    {
        public NavPage3()
        {
            InitializeComponent();

			backToRootButton.Clicked += BackToRootButton_Clicked;

			backButton.Clicked += BackButton_Clicked;
		}

		void BackToRootButton_Clicked(object sender, EventArgs e)
		{
            Navigation.PopToRootAsync();
		}

		void BackButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}

    }
}
