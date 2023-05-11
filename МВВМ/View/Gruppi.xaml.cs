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
using System.Windows.Shapes;
using МВВМ.ViewModel;

namespace МВВМ.View
{
    /// <summary>
    /// Логика взаимодействия для Gruppi.xaml
    /// </summary>
    public partial class Gruppi : Window
    {
        public Gruppi()
        {
            InitializeComponent();
            DataContext = new GrupiViewModel ();
        }
    }
}
