using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperGrid
{
    partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
            this.Text = String.Format("Acerca de {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Versión {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
        }

        private void TestAbout()
        {

            string[] cultureNames = { "en-US", "fr-FR", "de-DE", "es-ES" };

            DateTime dateToDisplay = new DateTime(2021, 5, 25, 18, 32, 0);
            double value = 87654321.98;

            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0,-11} {1,-35} {2:N}\n",
                                "Cultura", "EjemploFecha", "EjemploNumero");

            Console.WriteLine("Culture     Date                                Value\n");
            foreach (string cultureName in cultureNames)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo(cultureName);
                output.AppendFormat(culture, "{0,-11} {1,-35:D} {2:N}\n",
                                              culture.Name, dateToDisplay, value);
                // Console.WriteLine(output);
            }
            MessageBox.Show(output.ToString(), "Tabla Culturas");

        }

        public void TestDatePatterns(string cult)
        {
            // Get the properties of an en-US DateTimeFormatInfo object.
            DateTimeFormatInfo dtfi = CultureInfo.GetCultureInfo(cult).DateTimeFormat;
            Type typ = dtfi.GetType();
            PropertyInfo[] props = typ.GetProperties();
            DateTime value = new DateTime(2021, 5, 26, 11, 35, 0);
            
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0,-33} {1} \n{2,-37}Ejemplo: {3}\n",
                                      "Nombre patrón:", "Formato", "",
                                      "Valor ejemplo");
            foreach (var prop in props)
            {
                // Is this a format pattern-related property?
                if (prop.Name.Contains("Pattern"))
                {
                    string fmt = prop.GetValue(dtfi, null).ToString();
                    output.AppendFormat("{0,-33} {1} \n{2,-37}Ejemplo: {3}\n",
                                      prop.Name + ":", fmt, "",
                                      value.ToString(fmt));

                }
            }
            MessageBox.Show(output.ToString(),"Tabla Patrones fechas "+cult);
        }



        #region Descriptores de acceso de atributos de ensamblado

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMas_Click(object sender, EventArgs e)
        {
            TestAbout();
            TestDatePatterns("en-US");
            TestDatePatterns("es-ES");
        }
    }
}
