using System.Windows;

namespace YourApp
{
    public partial class PropertiesWindow : Window
    {
        public PropertiesWindow()
        {
            InitializeComponent();
        }

        // OK: aceptar y cerrar
        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        // Cancel: cancelar y cerrar
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        // Apply: aquí aplicarías cambios sin cerrar
        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            // Ejemplo: mostrar que se aplicó
            MessageBox.Show("Changes applied.", "Properties", MessageBoxButton.OK, MessageBoxImage.Information);

            // Normalmente luego de aplicar:
            // btnApply.IsEnabled = false;


        }

        // Help: ayuda simple
        private void Help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Select your options and press OK to save.\nUse Apply to apply without closing.",
                            "Help", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}