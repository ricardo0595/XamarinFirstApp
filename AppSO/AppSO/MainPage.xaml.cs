using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppSO
{
    public partial class MainPage : ContentPage
    {

        //public Entry Firstname { get; set; }
        //public Entry Lastname { get; set; }
        //public Entry SecondLastname { get; set; }
        //public Entry Password { get; set; }
        //public Entry ConfirmPassword { get; set; }
        //public Entry Phone { get; set; }
        //public DatePicker MyProperty { get; set; }

        public MainPage()
        {
            InitializeComponent();
            
        }

        private bool isValidEmail(string email)
        {
            return true;
        }

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            //File.WriteAllText(_fileName, editor.Text);

            if (String.IsNullOrEmpty(Firstname.Text))
            {
                DisplayAlert("Información", "Por favor ingrese su nombre", "Aceptar");
            }else if (String.IsNullOrEmpty(Lastname.Text))
            {
                DisplayAlert("Información", "Por favor ingrese su Apellido", "Aceptar");
            }else if (String.IsNullOrEmpty(SecondLastname.Text))
            {
                DisplayAlert("Información", "Por favor ingrese su segundo apellido", "Aceptar");
            }else if (String.IsNullOrEmpty(Email.Text))
            {
                DisplayAlert("Información", "Por favor ingrese su correo electrónico", "Aceptar");
            }else if (!isValidEmail(Email.Text))
            {
                DisplayAlert("Información", "Correo electrónico incorrecto", "Aceptar");
            }else if (String.IsNullOrEmpty(Phone.Text))
            {
                DisplayAlert("Información", "Por favor ingrese su número de teléfono", "Aceptar");
            }else if (String.IsNullOrEmpty(Password.Text))
            {
                DisplayAlert("Información", "Por favor ingrese la contraseña", "Aceptar");
            }else if (String.IsNullOrEmpty(ConfirmPassword.Text))
            {
                DisplayAlert("Información", "Por favor ingrese la confirmación de contraseña", "Aceptar");
            }else if (ConfirmPassword.Text!=Password.Text)
            {
                DisplayAlert("Información", "La confirmación de contraseña no coincide", "Aceptar");
            }
            else
            {
                
                User user = new User();
                user.firstName = Firstname.Text;
                user.secondLastname = SecondLastname.Text;
                user.email = Email.Text;
                user.lastname = Lastname.Text;
                user.phone = Phone.Text;
                user.birthday = Birthday.Date.ToShortDateString();
                user.password = Password.Text;

                Application.Current.Properties["firstName"] = user.firstName;
                Application.Current.Properties["secondLastname"] = user.secondLastname;
                Application.Current.Properties["lastname"] = user.lastname;
                Application.Current.Properties["phone"] = user.phone;
                Application.Current.Properties["birthday"] = user.birthday;
                Application.Current.Properties["email"] = user.email;

                string message = "";
                DisplayAlert("Usuario guardado correctamente", message, "Aceptar");
                App.Current.MainPage = new UserInfo();
            }

        }

        
    }
}
