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

namespace _2324_2Y_Integ1_2A_ListBoxComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int x = 0; x < 10; x++)
            {
                ListViewItem item = new ListViewItem();
                ListViewItem item2 = new ListViewItem();
                item.Tag = x;
                item2.Tag = x;
                item.Content = "Thing";
                item2.Content = "Thing Din";
                cbSample.Items.Add(item);
                listBThing.Items.Add(item2);
            }
        }

        private void cbSample_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListViewItem lvi = (ListViewItem)cbSample.SelectedItem;
            //MessageBox.Show(lvi.Tag.ToString());
            lblDisplay.Content = "ComboBoxSelection : " + lvi.Tag;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            listBThing.Items.Clear();
        }
    }
}
