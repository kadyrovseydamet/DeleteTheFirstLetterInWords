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

namespace DeleteTheFirstLetterInWords
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s, s0;
            s0 = "";
            string[] ss = textBox1.Text.Split(' ');
            for (int i = 0; i < ss.Count(); i++)
            {
                s = ss[i].Substring(1, ss[i].Length - 1);
                s0 += (s + " ");
            }
            label1.Content = s0;
        }
    }
}
