using Microsoft.Win32;
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
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Painter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Change_Color(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {
                case "Red":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Red;
                    break;

                case "Green":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Green;
                    break;

                case "Blue":

                    InkCan.DefaultDrawingAttributes.Color = Colors.Blue;
                    break;
            }
        }

        private void Change_Mode(object sender, RoutedEventArgs e)
        {

            switch (((RadioButton)sender).Content.ToString())
            {
                case "Ink":

                    InkCan.EditingMode = InkCanvasEditingMode.Ink;
                    break;

                case "Select":

                    InkCan.EditingMode = InkCanvasEditingMode.Select;
                    break;

                case "Erase":

                    InkCan.EditingMode = InkCanvasEditingMode.EraseByPoint;
                    break;

                case "Erase by strock":

                    InkCan.EditingMode = InkCanvasEditingMode.EraseByStroke;
                    break;
            }
        }

        private void Change_Shape(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "rectangle":

                    InkCan.DefaultDrawingAttributes.StylusTip = StylusTip.Rectangle;
                    break;

                case "ellipse":

                    InkCan.DefaultDrawingAttributes.StylusTip = StylusTip.Ellipse;
                    break;
            }
        }

        private void Change_Size(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "small":
                    InkCan.DefaultDrawingAttributes.Height = 5;
                    InkCan.DefaultDrawingAttributes.Width = 5;
                    break;

                case "normal":

                    InkCan.DefaultDrawingAttributes.Height = 10;
                    InkCan.DefaultDrawingAttributes.Width = 10;
                    break;

                case "large":

                    InkCan.DefaultDrawingAttributes.Height = 15;
                    InkCan.DefaultDrawingAttributes.Width = 15;
                    break;
            }
        }

        private void New(object sender, RoutedEventArgs e)
        {
            InkCan.Strokes.Clear();
        }

        private void save(object sender, RoutedEventArgs e)
        {
            
            SaveFileDialog saveFileDialog= new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName!="")
            {
                using (FileStream fs = (FileStream)saveFileDialog.OpenFile())
                {
                    InkCan.Strokes.Save(fs);
                }
            }
        }

        private void load(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
       
            if (openFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName,FileMode.Open);
                InkCan.Strokes = new StrokeCollection(fs);
                fs.Close();
            }
        }

        private void copy(object sender, RoutedEventArgs e)
        {
            InkCan.CopySelection();
        }

        private void cut(object sender, RoutedEventArgs e)
        {
            InkCan.CutSelection();
        }

        private void paste(object sender, RoutedEventArgs e)
        {
            InkCan.Paste();
        }
    }






}

