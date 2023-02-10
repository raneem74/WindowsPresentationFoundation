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

namespace textEditor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Set(object sender, RoutedEventArgs e)
        {
            FlowDocument flowDoc = new FlowDocument();
            Paragraph para = new Paragraph();
            para.Inlines.Add(new Run("Replace default text with initial text value"));
            flowDoc.Blocks.Add(para);
            txtBx.Document = flowDoc;
        }

        private void SelectAll(object sender, RoutedEventArgs e)
        { 
            txtBx.Focus();
            txtBx.SelectAll();
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            txtBx.Document = new FlowDocument();
        }

        private void Prepend(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(
               // TextPointer to the start of content in the RichTextBox.
               txtBx.Document.ContentStart,
               // TextPointer to the end of content in the RichTextBox.
               txtBx.Document.ContentEnd
           );
            string existedText = textRange.Text.Length>2 ? (textRange.Text).Substring(0, textRange.Text.Length - 2) : string.Empty;
            txtBx.Document = new FlowDocument();
            txtBx.Document.Blocks.Add(new Paragraph(new Run("**pre**"+ existedText)));
            
        }

        private void Insert(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(txtBx.CaretPosition, txtBx.CaretPosition);
            textRange.Text = "**inserted**";
            txtBx.CaretPosition = txtBx.CaretPosition.GetPositionAtOffset(textRange.Text.Length);

        }

        private void Append1(object sender, RoutedEventArgs e)
        {
            txtBx.AppendText("**Append text**");
        }

        private void Cut(object sender, RoutedEventArgs e)
        {
            txtBx.Cut();
                
        }

        private void Paste1(object sender, RoutedEventArgs e)
        {
            txtBx.Paste();
        }

        private void Undo(object sender, RoutedEventArgs e)
        {
            txtBx.Undo();
        }

        private void Editable(object sender, RoutedEventArgs e)
        {
            switch( ((RadioButton)sender).Content.ToString() ) 
            {
                case "editable":
                    txtBx.IsReadOnly = false;
                    break;

                case "read only":
                    txtBx.IsReadOnly = true;
                    break;

            }
        }

        private void Alignment(object sender, RoutedEventArgs e)
        {
            switch (((RadioButton)sender).Content.ToString())
            {
                case "left":
                    txtBx.Selection.ApplyPropertyValue(Block.TextAlignmentProperty, TextAlignment.Left);
                    break;

                case "center":
                    txtBx.Selection.ApplyPropertyValue(Block.TextAlignmentProperty, TextAlignment.Center);
                    break;

                case "right":
                    txtBx.Selection.ApplyPropertyValue(Block.TextAlignmentProperty, TextAlignment.Right);
                    break;

            }
        }
    }
}
