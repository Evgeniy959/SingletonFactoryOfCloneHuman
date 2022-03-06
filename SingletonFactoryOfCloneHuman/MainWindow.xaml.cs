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

namespace SingletonFactoryOfCloneHuman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IHuman human;
        IHuman clone;
        CloneSingletonFactory cloneFactory;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            human = new Person("Tom", 32);
            Tb1.Text = human.Name;
            Tb2.Text = human.Age.ToString();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            cloneFactory = CloneSingletonFactory.GetSingletone();
            clone = cloneFactory.CloneHumanFactory(human);
            if (clone != default)
            {
                Tb3.Text = clone.Name;
                Tb4.Text = clone.Age.ToString();
            }
        }
    }
}
