using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace something
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool _IsEnabled = true;

        public MainWindow()
        {
            InitializeComponent();
            Button btn1 = new Button();
            btn1.Content = "1";
            Button btn2 = new Button();
            btn2.Content = "2";
            Button btn3 = new Button();
            btn3.Content = "3";
            Button btn4 = new Button();
            btn4.Content = "4";
            Button btn5 = new Button();
            btn5.Content = "5";
            Button btn6 = new Button();
            btn6.Content = "6";
            Button btn7 = new Button();
            btn7.Content = "7";
            Button btn8 = new Button();
            btn8.Content = "8";
            Button btn9 = new Button();
            btn9.Content = "9";
            Button btn10 = new Button();
            btn10.Content = "10";
            Button btn11 = new Button();
            btn11.Content = "11";
            Button btn12 = new Button();
            btn12.Content = "12";
            Button btn13 = new Button();
            btn13.Content = "13";
            Button btn14 = new Button();
            btn14.Content = "14";
            Button btn15 = new Button();
            btn15.Content = "15";
            Button btn16 = new Button();
            btn16.Content = "16";
            Button btn17 = new Button();
            btn17.Content = "17";

            Button btn18 = new Button();
            btn18.Content = "18";
            Button btn19 = new Button();
            btn19.Content = "19";
            Button btn20 = new Button();
            btn20.Content = "20";
            Button btn21 = new Button();
            btn21.Content = "21";
            Button btn22 = new Button();
            btn22.Content = "22";
            Button btn23 = new Button();
            btn23.Content = "23";
            Button btn24 = new Button();
            btn24.Content = "24";
            Button btn25 = new Button();
            btn25.Content = "25";
            Button btn26 = new Button();
            btn26.Content = "26";
            Button btn27 = new Button();
            btn27.Content = "27";
            Button btn28 = new Button();
            btn28.Content = "28";
            Button btn29 = new Button();
            btn29.Content = "29";
            Button btn30 = new Button();
            btn30.Content = "30";
            Button btn31 = new Button();
            btn31.Content = "31";
            /*            List<Button> days = new List<Button>() {btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8,btn9,btn10,btn11,btn12,btn13,btn14,btn15,btn16,btn17,btn18,btn19,btn20,btn21,btn22,btn23,btn24,btn25,btn26,btn27,btn28,btn29,btn30,btn31

             }; dayss.ItemsSource = days;*/
            /*< ListBox x: Name = "dayss" Grid.Column = "1" Grid.Row = "1" Grid.ColumnSpan = "7"  Grid.RowSpan = "6" />*/

        }

        private void XMLSER_Click(object sender, RoutedEventArgs e)
        {
            SerializeXML();

        }
        private void JsonSER_Click(object sender, RoutedEventArgs e)
        {
            SerializeJSON();

        }

        private void SerializeJSON()
        {
            Ivent ivent = new Ivent();
            ivent.ivent_name = TBnameIvent.Text;
            ivent.date = (DateTime)DPIvent.SelectedDate;
            string json = JsonConvert.SerializeObject(ivent);
            File.WriteAllText("C:\\Users\\LEGION\\Desktop\\ivents.json", json);
        }

        private void SerializeXML()
        {
            Ivent ivent = new Ivent();
            ivent.ivent_name = TBnameIvent.Text;
            ivent.date = (DateTime)DPIvent.SelectedDate;
            XmlSerializer xml = new XmlSerializer(typeof(Ivent));
            using (FileStream fs = new FileStream("C:\\Users\\LEGION\\Desktop\\ivents.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, ivent);
            }
        }

        private void PrevM_Click(object sender, RoutedEventArgs e)
        {
            var date = Convert.ToDateTime(DPIvent.Text);
            date = date.AddMonths(-1);
            DPIvent.Text = date.ToShortDateString();
            DateCheck(date);
        }

        private void DateCheck(DateTime date)
        {
            if (date.Day != 29)
            {
                btn29.IsEnabled = false;
            }
            else if (date.Day == 29)
            {
                btn29.IsEnabled = true;

            }
            if (date.Day != 30)
            {

                btn23.IsEnabled =false;
            }
            else if (date.Day == 30)
            {

                btn30.IsEnabled = true;

            }
            if (date.Day != 31)
            {

                btn31.IsEnabled = false;
            }
            else if (date.Day == 31)
            {

                btn31.IsEnabled = true;
            }
        }

        private void NextM_Click(object sender, RoutedEventArgs e)
        {
            var date = Convert.ToDateTime(DPIvent.Text);
            date = date.AddMonths(1);
            DPIvent.Text = date.ToShortDateString();
            DateCheck(date);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn31_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn30_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn29_Click(object sender, RoutedEventArgs e)
        {
   
        }

        private void DPIvent_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
    }
}
