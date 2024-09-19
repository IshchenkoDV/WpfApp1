using System.Windows;
using System.Windows.Media;

namespace WpfMenuExample
{
    public partial class MainWindow : Window
    {
        private void RedBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Red;
            StatusText.Text = "Фон изменен на красный";
        }

        private void GreenBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Green;
            StatusText.Text = "Фон изменен на зеленый";
        }

        private void BlueBackground_Click(object sender, RoutedEventArgs e)
        {
            this.Background = Brushes.Blue;
            StatusText.Text = "Фон изменен на синий";
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Ищенко Д.В.\nВерсия: 1.0", "О разработчике", MessageBoxButton.OK, MessageBoxImage.Information);
            StatusText.Text = "Данное приложение было разработано Ищенко Д.В. — обучающимся в ВКИ НГУ. \n" +
                "Даниил увлекается программированием и разработкой программного обеспечения, \n" +
                "изучает современные технологии и активно применяет полученные знания на практике.\r\n\r\n" +
                "Если у вас есть предложения или вопросы по поводу приложения, \nвы можете связаться с ним по электронной почте: " +
                "IschenkoDV@mer.cu.nsu.ru.\r\n\r\nСпасибо за использование приложения!";
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
