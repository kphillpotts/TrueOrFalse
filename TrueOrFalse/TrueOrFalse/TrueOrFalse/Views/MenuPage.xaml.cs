using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TrueOrFalse.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public void NewGameTapped(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new QuestionPage());
        }
    }
}
