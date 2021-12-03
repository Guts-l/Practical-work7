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

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            Vector3D firstVector = new Vector3D(int.Parse(firsttriadA.Text), int.Parse(secondtriadA.Text), int.Parse(thirdtriadA.Text));
            Vector3D secondVector = new Vector3D(int.Parse(firsttriadB.Text), int.Parse(secondtriadB.Text), int.Parse(thirdtriadB.Text));
            Vector3D resultVector = firstVector + secondVector;
            MessageBox.Show($"Результат сложения вектора А с вектором В - {resultVector.First1} {resultVector.Second1} {resultVector.Third1}", "Сложение векторов", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ScalarProduct_Click(object sender, RoutedEventArgs e)
        {
            Vector3D firstVector = new Vector3D(int.Parse(firsttriadA.Text), int.Parse(secondtriadA.Text), int.Parse(thirdtriadA.Text));
            Vector3D secondVector = new Vector3D(int.Parse(firsttriadB.Text), int.Parse(secondtriadB.Text), int.Parse(thirdtriadB.Text));
            MessageBox.Show($"Результат скалярного произведения векторов А и В - {Vector3D.ScalarProduction(firstVector, secondVector)}", "Скалярное произведение векторов", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Теселько.М ИСП-34.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

