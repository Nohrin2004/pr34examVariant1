using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pr34examVariant1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(Metri.Text);
            int m2 = Convert.ToInt32(Metri2.Text);
            Otvet.Text = (m * m2 * 1.4).ToString();
            await DisplayAlert("Ответ", $"Результат равен = {Otvet.Text} тысяч рублей ", "ОК");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}