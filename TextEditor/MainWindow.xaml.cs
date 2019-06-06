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

namespace TextEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            openFileButton.Click += new EventHandler(OpenFileButton_Click);
        }
        
        public string FilePath
        {
            get { return filePathTextBox.Text; }
        }

        public string DataContent
        {
            get { return contentTextBox.Text; }
            set { contentTextBox.Text = value; }
        }

        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentChanged;

        public void SetSymbolCount(int count)
        {
            symbolCountTextBlock.Text = count.ToString();
        }
    }
}
