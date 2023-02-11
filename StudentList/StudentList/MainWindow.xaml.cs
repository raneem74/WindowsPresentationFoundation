using StudentList;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace StudentList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<student> stList = new List<student>();
            stList.Add(new student { id = 1, name = "John Doe", age = 22, grade = 89, image = "D:\\1-ITI\\ITI_WPF\\lab3\\StudentList\\StudentList\\images\\1.png" });
            stList.Add(new student { id = 2, name = "Jane Doe", age = 21, grade = 92, image = "D:\\1-ITI\\ITI_WPF\\lab3\\StudentList\\StudentList\\images\\2.png" });
            stList.Add(new student { id = 3, name = "Bob Smith", age = 23, grade = 75, image = "D:\\1-ITI\\ITI_WPF\\lab3\\StudentList\\StudentList\\images\\3.png" });
            stList.Add(new student { id = 4, name = "Eimagesa Watson", age = 24, grade = 95, image = "D:\\1-ITI\\ITI_WPF\\lab3\\StudentList\\StudentList\\images\\4.png" });
            stList.Add(new student { id = 5, name = "Michael Scott", age = 25, grade = 76, image = "D:\\1-ITI\\ITI_WPF\\lab3\\StudentList\\StudentList\\images\\1.png" });
            stList.Add(new student { id = 6, name = "Sarah Johnson", age = 26, grade = 87, image = "D:\\1-ITI\\ITI_WPF\\lab3\\StudentList\\StudentList\\images\\2.png" });
            stList.Add(new student { id = 7, name = "David Smith", age = 27, grade = 91, image = "D:\\1-ITI\\ITI_WPF\\lab3\\StudentList\\StudentList\\images\\3.png" });
            stList.Add(new student { id = 8, name = "Emily Davis", age = 28, grade = 80, image = "D:\\1-ITI\\ITI_WPF\\lab3\\StudentList\\StudentList\\images\\4.png" });
            namesList.ItemsSource = stList;

        }



    }
}
