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
    /// Interaction logic for govCallControl.xaml
    /// </summary>
    public partial class govCallControl : UserControl
    {
        public govCallControl(BitmapImage image , string name,string mny,string who)
        {
            InitializeComponent();
            setPicture(image);
            setName(name);
            setMoney(mny);
            setWhoTo(who);
        }
        public govCallControl()
        {
            InitializeComponent();
        }

        public void setPicture(BitmapImage img)
        {
            image.Source = img;
        }
        public void setName(string name)
        {
            NameTB.Text = name;
        }
        public void setMoney(string mny)
        {
            moneyTB.Text = mny;
        }
        public void setMoney(int mny)
        {
            moneyTB.Text = mny.ToString();
        }
        public void setWhoTo(string who)
        {
            whoToTB.Text = who;
        }
    }
}
