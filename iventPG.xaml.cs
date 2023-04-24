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
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace something
{
    /// <summary>
    /// Логика взаимодействия для iventPG.xaml
    /// </summary>
    public partial class iventPG : Window
    {
        public iventPG()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            ivents_LB.Items.Insert(1, enter.Text);
        }
/*        private void XMLSER_Click(object sender, RoutedEventArgs e)
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
            ivent.ivent_name = ivents_LB.SelectedItems;
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
            }*/
        /*}*/
    }
}
