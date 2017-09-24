using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580010A
{
    public partial class MyPage3 : ContentPage
    {
        public MyPage3()
        {
            InitializeComponent();
            backToRootButton.Clicked += BackToRootButton_Clicked;
			backButton.Clicked += BackButton_Clicked;
		}

        void BackToRootButton_Clicked(object sender, EventArgs e)
        {
            
        }

		void BackButton_Clicked(object sender, EventArgs e)
		{
            Navigation.PopModalAsync();
		}

    }
}
