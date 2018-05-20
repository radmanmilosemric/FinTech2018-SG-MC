
using MultiFaceRec;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace ConnectWithFaceRecognition
{
    /// <summary>
    /// Interaction logic for CameraView.xaml
    /// </summary>
    public partial class CameraView : Window
    {
        public string card;
        public bool IsValid;
        DispatcherTimer timer;

        public bool IsVerified;

        public CameraView(string card)
        {
            this.card = card;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Integration.WindowsFormsHost.EnableWindowsFormsInterop();
            FaceRec fr = new FaceRec(card);
            // fr.Dock = System.Windows.Forms.DockStyle.Fill;
            FaceRecognition.Child = fr;

            timer = new DispatcherTimer
                  (
                  TimeSpan.FromMilliseconds(50),
                  DispatcherPriority.ApplicationIdle,// Or DispatcherPriority.SystemIdle
                  (s, r) => Work(fr),
                  Application.Current.Dispatcher
                  );


        }

        private void Work(FaceRec fr)
        {
            fr.FrameGrabber(null, null);

            if(fr.Verification == "Verified")
            {
                IsVerified = true;
                Close();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(timer != null)
            {
                timer.Stop();
                timer = null;
            }
        }
    }
}
