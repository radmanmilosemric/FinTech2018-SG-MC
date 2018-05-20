using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EasyPayDemo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private BackgroundWorker backgroundWorker1;
        private CardReaderTest.Data currentData;
        private CardReaderTest.Data data;
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(500);
                data = CardReaderTest.Reader.GetData();
                backgroundWorker1.ReportProgress(0);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if(data != currentData && data != null)
            {
                currentData = data;
                txtCardHolderName.Text = data.CardHolder;
                txtCardNumber.Text = data.CardNumber;
                cmbxExpiryMonth.SelectedValue = data.ExpMonth.ToString();
                cmbxExpiryYear.SelectedValue = data.ExpYear.ToString();
            }
        }
    }
}
