using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;

namespace PhoneApp1

{
    	

    public partial class MainPage : PhoneApplicationPage
    {

        List<Persona> ListaPersona = new List<Persona>();

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListaPersona.Add(new Persona { nombre = "Stefa", codigo = 2 });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var query = ListaPersona.Where(xxx => xxx.codigo == 2).Select(x => x);

            //Mostrar cada uno

            foreach (var item in query)
            {
                MessageBox.Show(item.nombre);
            }

            //Cantidad

            MessageBox.Show(query.Count().ToString());

            //Suma codigo

            MessageBox.Show(query.Select(x => x.codigo).Sum().ToString());
        }

        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}