using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;

namespace AgendaContactos_DAM
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //declaracion entidades EF
        ContactosEnt context = new ContactosEnt();
        CollectionViewSource lista_ContactosViewSource;


        public MainWindow()
        {
            InitializeComponent();
            //instanciacion entidades EF
            lista_ContactosViewSource = ((CollectionViewSource)(FindResource("lista_ContactosViewSource")));
            DataContext = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Load is an extension method on IQueryable,    
            // defined in the System.Data.Entity namespace.   
            // This method enumerates the results of the query,    
            // similar to ToList but without creating a list.   
            // When used with Linq to Entities, this method    
            // creates entity objects and adds them to the context.   

            context.Lista_Contactos.Load();

            // After the data is loaded, call the DbSet<T>.Local property    
            // to use the DbSet<T> as a binding source. 

            lista_ContactosViewSource.Source = context.Lista_Contactos.Local;
            // Cargar datos estableciendo la propiedad CollectionViewSource.Source:
            // lista_ContactosViewSource.Source = [origen de datos genérico]
        }
        private void LastCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            lista_ContactosViewSource.View.MoveCurrentToLast();
        }

        private void PreviousCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            lista_ContactosViewSource.View.MoveCurrentToPrevious();
        }

        private void NextCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            lista_ContactosViewSource.View.MoveCurrentToNext();
        }

        private void FirstCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            lista_ContactosViewSource.View.MoveCurrentToFirst();
        }
        // Cancels any input into the new customer form  
        private void CancelCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            apellido1TextBox.Text = "";
            apellido2TextBox.Text = "";
            nombreTextBox.Text = "";
            dNITextBox.Text = "";
            emailTextBox.Text = "";
            sueldoTextBox.Text = "";
            telefonoTextBox.Text = "";
            fecha_AltaDatePicker.Text = "";
            fecha_BajaDatePicker.Text = "";
        }

        private void DeleteCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            // If existing window is visible, delete the customer and all their orders.  
            // In a real application, you should add warnings and allow the user to cancel the operation.  
            var cur = lista_ContactosViewSource.View.CurrentItem as Lista_Contactos;

            var cust = (from c in context.Lista_Contactos
                        where c.Apellido1 == cur.Apellido1
                        select c).FirstOrDefault();

            if (cust != null)
            {
                context.Lista_Contactos.Remove(cust);
            }
            context.SaveChanges();
            lista_ContactosViewSource.View.Refresh();
        }

        private void AddCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            double dsueldo = 0.0;
            try {
                dsueldo = Convert.ToDouble(sueldoTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sueldo debe ser tipo Double" + ex.StackTrace);
                return;
            }

            // Create a new object because the old one  
            // is being tracked by EF now.  
            Lista_Contactos nuevo = new Lista_Contactos
            {
                Apellido1 = apellido1TextBox.Text,
                Apellido2 = apellido2TextBox.Text,
                Nombre = nombreTextBox.Text,
                DNI = dNITextBox.Text,
                email = emailTextBox.Text,
                Sueldo = dsueldo,
                Telefono = telefonoTextBox.Text,
                Fecha_Alta = fecha_AltaDatePicker.SelectedDate,
                Fecha_Baja = fecha_BajaDatePicker.SelectedDate
            };
            // Add the new object into the EF model  
            context.Lista_Contactos.Add(nuevo);
            context.SaveChanges();
            lista_ContactosViewSource.View.Refresh();
            lista_ContactosViewSource.View.MoveCurrentTo(nuevo);
        }

        //// Save the changes, either for a new customer, a new order  
        //// or an edit to an existing customer or order.
        //context.SaveChanges();

        //        int len = context.Lista_Contactos.Local.Count();
        //        int pos = len;
        //        for (int i = 0; i < len; ++i)
        //        {
        //            if (String.CompareOrdinal(nuevo.Apellido1, context.Lista_Contactos.Local[i].Apellido1) < 0)
        //            {
        //                pos = i;
        //                break;
        //            }
        //        }
        //        context.Lista_Contactos.Local.Insert(pos, nuevo);
        //        lista_ContactosViewSource.View.Refresh();
        //        lista_ContactosViewSource.View.MoveCurrentTo(nuevo);
        // }

        private void UpdateCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            double dsueldo = 0.0;
            try
            {
                dsueldo = Convert.ToDouble(sueldoTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sueldo debe ser tipo Double" + ex.StackTrace);
                return;
            }

            // Create a new object because the old one  
            // is being tracked by EF now.  
            Lista_Contactos nuevo = new Lista_Contactos
            {
                Apellido1 = apellido1TextBox.Text,
                Apellido2 = apellido2TextBox.Text,
                Nombre = nombreTextBox.Text,
                DNI = dNITextBox.Text,
                email = emailTextBox.Text,
                Sueldo = dsueldo,
                Telefono = telefonoTextBox.Text,
                Fecha_Alta = fecha_AltaDatePicker.SelectedDate,
                Fecha_Baja = fecha_BajaDatePicker.SelectedDate
            };
            // Add the new object into the EF model  
            context.Lista_Contactos.Add(nuevo);
            context.SaveChanges();
            lista_ContactosViewSource.View.Refresh();
            lista_ContactosViewSource.View.MoveCurrentTo(nuevo);
        }

    }

}
