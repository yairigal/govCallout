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

namespace UI
{
    /// <summary>
    /// Interaction logic for MainSkeletonPage.xaml
    /// </summary>
    public partial class MainSkeletonPage : Page
    {
        public MainSkeletonPage()
        {
            InitializeComponent();
            for (int i = 0; i < 30; i++)
            {
                addgovCallToListView(new govCallControl(new BitmapImage(new Uri(@"C:\Users\Yair\Source\Repos\govCallout\govCallout\UI\images.png", UriKind.Absolute)), "test"+(i+1).ToString(), "200", "Yair"));

            }
        }

        public void addgovCallToListView(govCallControl gcc)
        {
            listView.Items.Add(gcc);
        }
    }
}
