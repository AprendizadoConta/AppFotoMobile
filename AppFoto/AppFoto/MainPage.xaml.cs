using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace AppFoto
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e) //pegar Foto
        {
            var result = await MediaPicker.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Por favor escolha uma foto"
            });
            if (result!=null)
            {
                var stream = await result.OpenReadAsync();
                ResultImage.Source = ImageSource.FromStream(()=> stream); //=> forma de atribuição
            }
        }

        async void Button_Clicked_1(object sender, EventArgs e)//Tirar Foto
        {
            var result = await MediaPicker.CapturePhotoAsync();
            if (result!=null)
            {
                var stream = await result.OpenReadAsync();
                ResultImage.Source = ImageSource.FromStream(()=> stream);
            }
        }
    }
}
