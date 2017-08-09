using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CATestGit
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin Forms!" }
                    //Changes to release 1.2
                }
            };
        }
    }
}