using Intel.RealSense;
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
using System.Windows.Threading;

namespace CameraF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        #region ===================================================== Input =====================================================
        private Pipeline pipeline;
        private Colorizer colorizer = new Colorizer();
        private Action<VideoFrame> updateColor;
        #endregion

        #region ===================================================== Display =====================================================

        #endregion

        #region ===================================================== Cal =====================================================
        private void SetupWindow(PipelineProfile pipelineProfile, out Action<VideoFrame> color) {
            using (var p = pipelineProfile.GetStream(Stream.Color).As<VideoStreamProfile>())
                im_camera.Source = new WriteableBitmap(p.Width, p.Height, 96d, 96d, PixelFormats.Rgb24, null);
            color = UpdateImage(im_camera);
        }
        static Action<VideoFrame> UpdateImage(Image img) {
            var wbmp = img.Source as WriteableBitmap;
            return new Action<VideoFrame>(frame => {
                var rect = new Int32Rect(0, 0, frame.Width, frame.Height);
                wbmp.WritePixels(rect, frame.Data, frame.Stride * frame.Height, frame.Stride);
            });
        }
        /// <summary>
        /// Set camera to ready for get image
        /// </summary>
        private void SetCameraImage() {
            try {
                pipeline.Dispose();
            } catch { }

            pipeline = new Pipeline();
            Context context = new Context();
            DeviceList devicesList = context.QueryDevices();
            Device devices = devicesList[0];

            string ss = devices.Info[CameraInfo.Name];
            string ss2 = devices.Info[CameraInfo.SerialNumber];
            string ss3 = devices.Info[CameraInfo.FirmwareVersion];

            System.Collections.ObjectModel.ReadOnlyCollection<Sensor> sensors = devices.QuerySensors();
            //Sensor depthSensor = sensors[0];
            Sensor colorSensor = sensors[1];

            VideoStreamProfile colorProfile = colorSensor.StreamProfiles
                                        .Where(p => p.Stream == Stream.Color)
                                        .OrderBy(p => p.Framerate)
                                        .Select(p => p.As<VideoStreamProfile>()).First();

            Config config = new Config();
            config.EnableStream(Stream.Color, colorProfile.Width, colorProfile.Height,
                colorProfile.Format, colorProfile.Framerate);

            PipelineProfile profile = pipeline.Start(config);
            SetupWindow(profile, out updateColor);
        }
        /// <summary>
        /// For gat image from camera
        /// </summary>
        private void GetImage() {
            FrameSet frames = pipeline.WaitForFrames();
            VideoFrame colorFrame = frames.ColorFrame.DisposeWith(frames);
            Dispatcher.Invoke(DispatcherPriority.Render, updateColor, colorFrame);
        }
        /// <summary>
        /// For set camera for get depth
        /// </summary>
        private void SetCameraDepth() {
            try {
                pipeline.Dispose();
            } catch { }

            pipeline = new Pipeline();
            pipeline.Start();
        }
        /// <summary>
        /// For get depth from camera
        /// </summary>
        /// <returns></returns>
        private string GetDepth() {
            FrameSet frames = pipeline.WaitForFrames();
            DepthFrame depth = frames.DepthFrame;
            int width = depth.Width;
            int height = depth.Height;
            float depthValue = depth.GetDistance((int)(width / 2), (int)(height / 2));
            return depthValue.ToString("0.0000");
        }
        #endregion

        #region ===================================================== Main =====================================================
        /// <summary>
        /// Timer for get camera auto
        /// </summary>
        private DispatcherTimer timerAuto = new DispatcherTimer();



        /// <summary>
        /// Set timer auto and add event tick
        /// </summary>
        private void SetTimerAuto() {
            timerAuto.Tick += timerAutoTick;
            timerAuto.Interval = new TimeSpan(0, 0, 0, 0, 250);
        }


        private void CameraFFFFFFF_Loaded(object sender, RoutedEventArgs e) {
            SetTimerAuto();
        }
        private void bt_setCamera_Click(object sender, RoutedEventArgs e) {
            SetCameraImage();
        }
        private void bt_getImage_Click(object sender, RoutedEventArgs e) {
            GetImage();
        }
        private void bt_setDepth_Click(object sender, RoutedEventArgs e) {
            SetCameraDepth();
        }
        private void bt_getDepth_Click(object sender, RoutedEventArgs e) {
            lb_depth.Content = GetDepth();
        }
        private void bt_auto_Click(object sender, RoutedEventArgs e) {
            timerAuto.Start();
        }
        private void bt_stop_Click(object sender, RoutedEventArgs e) {
            timerAuto.Stop();
        }
        private void timerAutoTick(object sender, EventArgs e) {
            SetCameraImage();
            GetImage();
            SetCameraDepth();
            GetDepth();
        }
        #endregion
    }
}
