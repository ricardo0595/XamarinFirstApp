using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSO
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserInfo : ContentPage
	{
		public UserInfo ()
		{
			InitializeComponent ();

            fullName.Text = "Nombre: " + Application.Current.Properties["firstName"]+" "+ Application.Current.Properties["lastname"]+" "+Application.Current.Properties["secondLastname"];
            email.Text = "Correo electrónico:" + Application.Current.Properties["email"];
            phone.Text="Teléfono de contacto: "+Application.Current.Properties["phone"];
            birthday.Text="Fecha de nacimiento: "+Application.Current.Properties["birthday"];
            
        }

        void onExit(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }


    }
}