
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
        public CameraView()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Integration.WindowsFormsHost.EnableWindowsFormsInterop();
            FaceRec fr = new FaceRec("5574-8911-0383-2181");
            // fr.Dock = System.Windows.Forms.DockStyle.Fill;
            FaceRecognition.Child = fr;

            var timer = new DispatcherTimer
                  (
                  TimeSpan.FromMilliseconds(50),
                  DispatcherPriority.ApplicationIdle,// Or DispatcherPriority.SystemIdle
                  (s, r) => fr.FrameGrabber(null, null),
                  Application.Current.Dispatcher
                  );
        }
    }
}
