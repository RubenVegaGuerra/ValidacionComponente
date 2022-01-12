using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ValidacionComponente.MisControles
{
    /// <summary>
    /// Lógica de interacción para MiControl.xaml
    /// </summary>
    public partial class MiControl : UserControl
    {

        public String Atributo { get; set; }
        public MiControl()
        {
            InitializeComponent();
        }

        private void txtText_LostFocus(object sender, RoutedEventArgs e)
        {
            string patern;

            if (!txtText.Text.Equals(null))
            {
                switch (Atributo)
                {
                    case "DNI":


                        patern = "[0-9]{8}[A-Z]{1}";

                        if (validar(patern, txtText.Text))
                        {
                                lblError.Content = "DNI válido";
                            }
                        else
                        {
                            lblError.Content = "DNI no válido";
                        }
                       
                        break;

                    case "CP":

                        patern = "[0-9]{5}";

                        if (validar(patern, txtText.Text))
                        {
                            lblError.Content = "Codigo Postal válido";
                        }
                        else
                        {
                            lblError.Content = "Codigo Postal no válido";
                        }


                        break;

                       
                    case "TEL":

                        patern = "(\\+34|0034|34)?(6|7|9)[0-9]{8}";

                        if (validar(patern, txtText.Text))
                        {
                            lblError.Content = "Teléfono válido";
                        }
                        else
                        {
                            lblError.Content = "Teléfono no válido";
                        }
                        break;
                }
            }
            else
            {
                lblError.Content = "Campo vacio";
            }
            
        }

        public Boolean validar(string patern, string text)
        {
            Boolean valido = false;

            Regex regex = new Regex(patern);
            Match match = regex.Match(text);
            if (match.Success)
            {
                valido = true; ;
            }

            return valido;
        }
    }
}
