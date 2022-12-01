using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraRL {
    public partial class FormCameraRL : Form {
        public FormCameraRL() {
            InitializeComponent();
            SetupCamera();
            CameraCallExe();
            CameraCallBat();
        }

        #region ================================================ Input ================================================
        /// <summary>
        /// ip of socket
        /// </summary>
        public string ip { get; set; }
        /// <summary>
        /// port of socket
        /// </summary>
        public int port { get; set; }
        /// <summary>
        /// Command Get Value from Camera
        /// </summary>
        public string cmdGet { get; set; }
        /// <summary>
        /// Name file config camera csv.
        /// Value = "camera_config"
        /// </summary>
        private string nameFile = "camera_config";
        /// <summary>
        /// Flag send every ? millisec
        /// </summary>
        public bool sendTick { get; set; }
        /// <summary>
        /// Read Value Depth from DepthCam.exe
        /// </summary>
        public Socket socket { get; set; }
        /// <summary>
        /// Header in file config of camera_config.csv
        /// </summary>
        public HeadConfig headConfig = new HeadConfig();
        /// <summary>
        /// For read and write file config
        /// </summary>
        private SetupPay.FormPay setupPay = new SetupPay.FormPay();
        /// <summary>
        /// Timer for flag sendTick
        /// </summary>
        private System.Threading.Timer timerSend { get; set; }
        /// <summary>
        /// For check depth of roll at down
        /// </summary>
        private double checkDepthRollDown { get; set; }
        /// <summary>
        /// For check depth of roll at up
        /// </summary>
        private double checkDepthRollUp { get; set; }
        /// <summary>
        /// For check rail different
        /// </summary>
        private double checkRailDif { get; set; }
        /// <summary>
        /// For off speed car
        /// </summary>
        public bool offSpeed { get; set; }
        /// <summary>
        /// Flag for first connect socket to set position x y
        /// </summary>
        private bool firstConnect { get; set; }
        /// <summary>
        /// for check Object forward
        /// </summary>
        private double checkObjectForward { get; set; }
        /// <summary>
        /// for check Object Other
        /// </summary>
        private double checkObjectOther { get; set; }
        /// <summary>
        /// Path of camera.exe
        /// </summary>
        public string pathExe { get; set; }
        /// <summary>
        /// Path of camera.bat
        /// </summary>
        public string pathBat { get; set; }
        /// <summary>
        /// Value of depth roll left camera
        /// </summary>
        private double valueDepthRollL { get; set; }
        /// <summary>
        /// Value of depth rail left camera
        /// </summary>
        private double valueDepthRailL { get; set; }
        /// <summary>
        /// Value of depth roll Right camera
        /// </summary>
        private double valueDepthRollR { get; set; }
        /// <summary>
        /// Value of depth rail Right camera
        /// </summary>
        private double valueDepthRailR { get; set; }
        /// <summary>
        /// Value of depth Object
        /// </summary>
        private double valueDepthObject { get; set; }
        /// <summary>
        /// Flag of depth roll
        /// </summary>
        public bool flagDepthRoll { get; set; }
        /// <summary>
        /// Flag of rail different
        /// </summary>
        public bool flagRailDif { get; set; }
        /// <summary>
        /// For lock depth roll case reverse 1 2
        /// </summary>
        public bool flagLockDetectCam { get; set; }
        /// <summary>
        /// For reverse end position
        /// </summary>
        public bool flagEndPosition { get; set; }
        #endregion

        #region ================================================ Display ================================================
        /// <summary>
        /// Display error convert value camera
        /// </summary>
        private void ShowMessageConvertValueError() {
            MessageBox.Show("**Error Convert value camera");
        }
        #endregion

        #region ================================================ Cal ================================================
        /// <summary>
        /// Connect to Socket cameraRL
        /// </summary>
        public bool Connect() {
            try {
                socket.Dispose();
            } catch { }

            try {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            } catch { }

            IAsyncResult result = socket.BeginConnect(ip, port, null, null);
            bool success = result.AsyncWaitHandle.WaitOne(2000, true);

            if (socket.Connected) {
                socket.EndConnect(result);
                return true;

            } else {
                socket.Close();
                return false;
            }
        }
        /// <summary>
        /// Dis connect socket
        /// </summary>
        public void DisConnect() {
            try {
                socket.Shutdown(SocketShutdown.Both);
            } catch { }

            try {
                socket.Close();
            } catch { }

            try {
                socket.Dispose();
            } catch { }
        }
        /// <summary>
        /// Send text to Socket camera.
        /// text is message send to socket camera
        /// </summary>
        public void Send(string text) {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }
        /// <summary>
        /// Read value in config file csv to parametor
        /// </summary>
        private void SetupCamera() {
            setupPay.form1.csv.path = "../../../Config/";
            setupPay.SelectTab = SetupPay.tabPage.TAB6;
            setupPay.set_nameTab(nameFile);
            setupPay.setup();

            ip = setupPay.read_text(headConfig.ip, nameFile);
            port = Convert.ToInt32(setupPay.read_text(headConfig.port, nameFile));
            cmdGet = setupPay.read_text(headConfig.getDepthCmd, nameFile);
            int sendEvery = Convert.ToInt32(setupPay.read_text(headConfig.sendEvery, nameFile));
            checkDepthRollDown = Convert.ToDouble(setupPay.read_text(headConfig.depthRollDown, nameFile));
            checkDepthRollUp = Convert.ToDouble(setupPay.read_text(headConfig.depthRollUp, nameFile));
            checkRailDif = Convert.ToDouble(setupPay.read_text(headConfig.railDifferent, nameFile));
            checkObjectForward = Convert.ToDouble(setupPay.read_text(headConfig.factorForward, nameFile));
            checkObjectOther = Convert.ToDouble(setupPay.read_text(headConfig.factorOther, nameFile));
            pathExe = setupPay.read_text(headConfig.pathExe, nameFile);
            pathBat = setupPay.read_text(headConfig.pathBat, nameFile);

            timerSend = new System.Threading.Timer(TimerSendTick, null, 1000, sendEvery);
        }
        /// <summary>
        /// Event tick of timer send
        /// </summary>
        private void TimerSendTick(object state) {
            sendTick = true;
        }
        /// <summary>
        /// Read data from socket cameraRL
        /// </summary>
        /// <returns>Return true is read success</returns>
        public bool Read() {
            byte[] dataByte = new byte[socket.Available];
            socket.Receive(dataByte, SocketFlags.None);
            string data = Encoding.ASCII.GetString(dataByte);
            string[] dataSup = data.Split('-');
            string dataValue = dataSup[1].Trim();
            string[] dataSplit = dataValue.Split(',');

            try {
                valueDepthRollL = Convert.ToDouble(dataSplit[0]);
                valueDepthRailL = Convert.ToDouble(dataSplit[1]);
                valueDepthRollR = Convert.ToDouble(dataSplit[2]);
                valueDepthRailR = Convert.ToDouble(dataSplit[3]);
                valueDepthObject = Convert.ToDouble(dataSplit[4]);
            } catch {
                ShowMessageConvertValueError();
                return false;
            }

            return true;
        }
        /// <summary>
        /// Check depth roll left right to set flagDepthRoll
        /// </summary>
        public void CheckDepthRoll(int reverseValue = 1) {
            double checkValueDif = Math.Abs(valueDepthRollL - valueDepthRollR);
            if (checkValueDif == 0 || checkValueDif > 0.5) {
                flagDepthRoll = false;
                return;
            }

            if (reverseValue == 1 || reverseValue == 2) {
                if (valueDepthRollL < checkDepthRollUp && valueDepthRollR < checkDepthRollUp) {
                    flagDepthRoll = true;
                } else {
                    flagDepthRoll = false;
                }
            }
            if (reverseValue == 3 || reverseValue == 4) {
                if (valueDepthRollL < checkDepthRollDown && valueDepthRollR < checkDepthRollDown) {
                    flagDepthRoll = true;
                } else {
                    flagDepthRoll = false;
                }
            }
        }
        /// <summary>
        /// Check rail different left right to set flagRailDif
        /// </summary>
        public void CheckRailDifferent() {
            double dif = Math.Abs(valueDepthRailL - valueDepthRailR);

            if (dif <= checkRailDif) {
                flagRailDif = true;
            } else {
                flagRailDif = false;
            }
        }
        /// <summary>
        /// For call camera.exe
        /// </summary>
        public void CameraCallExe() {
            string[] pathSup = pathExe.Split('\\');
            Process[] pname = Process.GetProcessesByName(pathSup[pathSup.Length - 1].Replace(".exe", ""));
            if (pname.Length > 0) {
                return;
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = pathExe;
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.WorkingDirectory = pathExe.Replace(pathSup[pathSup.Length - 1], "");

            try {
                Process.Start(startInfo);
            } catch { }
        }
        /// <summary>
        /// For call camera.bat
        /// </summary>
        public void CameraCallBat() {
            Process[] pname = Process.GetProcessesByName("rs-multicam");
            if (pname.Length > 0) {
                return;
            }
            string[] pathSup = pathBat.Split('\\');
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = pathBat;
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.WorkingDirectory = pathBat.Replace(pathSup[pathSup.Length - 1], "");

            try {
                Process.Start(startInfo);
            } catch { }
        }
        /// <summary>
        /// For close all camera.exe
        /// </summary>
        public void CameraCloseExe() {
            string[] pathSup = pathExe.Split('\\');
            string nameExe = pathSup[pathSup.Length - 1].Replace(".exe", "");
            Process[] camera = Process.GetProcessesByName(nameExe);

            for (int index = 0; index < camera.Count(); index++) {
                Process process = camera[index];
                process.Kill();
            }
        }
        /// <summary>
        /// For close all camera.bat
        /// </summary>
        public void CameraCloseBat() {
            Process[] camera = Process.GetProcessesByName("rs-multicam");

            for (int index = 0; index < camera.Count(); index++) {
                Process process = camera[index];
                process.Kill();
            }
        }
        #endregion

        #region ================================================ Main ================================================

        #endregion

        public class HeadConfig {
            /// <summary>Value = "IP"</summary>
            public string ip { get; set; }
            /// <summary>Value = "Port"</summary>
            public string port { get; set; }
            /// <summary>Value = "Get Depth Cmd"</summary>
            public string getDepthCmd { get; set; }
            /// <summary>Value = "Send Every"</summary>
            public string sendEvery { get; set; }
            /// <summary>Value = "Depth Roll Down"</summary>
            public string depthRollDown { get; set; }
            /// <summary>
            /// Value = "Depth Roll Up"
            /// </summary>
            public string depthRollUp { get; set; }
            /// <summary>
            /// Value = "Rail Different"
            /// </summary>
            public string railDifferent { get; set; }
            /// <summary>
            /// Value = "Factor Forward"
            /// </summary>
            public string factorForward { get; set; }
            /// <summary>
            /// Value = "Factor Other"
            /// </summary>
            public string factorOther { get; set; }
            /// <summary>
            /// Value = "Path Exe"
            /// </summary>
            public string pathExe { get; set; }
            /// <summary>
            /// Value = "Path Bat"
            /// </summary>
            public string pathBat { get; set; }

            public HeadConfig() {
                ip = "IP";
                port = "Port";
                getDepthCmd = "Get Depth Cmd";
                factorForward = "Factor Forward";
                factorOther = "Factor Other";
                sendEvery = "Send Every";
                depthRollDown = "Depth Roll Down";
                depthRollUp = "Depth Roll Up";
                railDifferent = "Rail Different";
                pathExe = "Path Exe";
                pathBat = "Path Bat";
            }
        }

        #region ================================================ In Project ================================================
        private bool inFlagConnect;

        private void InMessageNotConnect() {
            MessageBox.Show("Not Connect Socket!!");
        }
        private void DisplayValueCamera() {
            lb_depthRollL.Text = "Depth Roll L = " + valueDepthRollL;
            lb_depthRailL.Text = "Depth Rail L = " + valueDepthRailL;
            lb_depthRollR.Text = "Depth Roll R = " + valueDepthRollR;
            lb_depthRailR.Text = "Depth Rail R = " + valueDepthRailR;
            lb_depthObject.Text = "Depth Object = " + valueDepthObject;
        }
        private void FormCameraRL_Load(object sender, EventArgs e) {
            tb_parameter1.Text = "IP = " + ip;
            tb_parameter2.Text = "Port = " + port;
            tb_parameter3.Text = "Cmd Get = " + cmdGet;
            tb_parameter4.Text = "Factor Forward = " + checkObjectForward;
            tb_parameter5.Text = "Factor Other = " + checkObjectOther;
            tb_parameter6.Text = "Check Depth Roll Down = " + checkDepthRollDown;
            tb_parameter7.Text = "Check Depth Roll Up = " + checkDepthRollUp;
            tb_parameter8.Text = "Check Rail Dif = " + checkRailDif;
            tb_parameter9.Text = "Path .exe = " + pathExe;
            tb_parameter10.Text = "Path .bat = " + pathBat;
        }
        private void bt_connect_Click(object sender, EventArgs e) {
            if (Connect()) {
                lb_connect.Text = "True";
                inFlagConnect = true;
            } else {
                lb_connect.Text = "False";
                inFlagConnect = false;
            }
        }
        private void bt_getDepth_Click(object sender, EventArgs e) {
            if (!inFlagConnect) {
                InMessageNotConnect();
                return;
            }
            InRead();
        }
        private void bt_checkDepth_Click(object sender, EventArgs e) {
            if (!inFlagConnect) {
                InMessageNotConnect();
                return;
            }
            CheckDepthRoll();
            lb_checkDepthRoll.Text = flagDepthRoll.ToString();
        }
        private void bt_getAverage_Click(object sender, EventArgs e) {
            if (!inFlagConnect) {
                InMessageNotConnect();
                return;
            }
            CheckRailDifferent();
            lb_checkRailDifferent.Text = flagRailDif.ToString();
        }
        private void bt_startAuto_Click(object sender, EventArgs e) {
            timerAuto.Start();
        }
        private void bt_stop_Click(object sender, EventArgs e) {
            timerAuto.Stop();
        }
        private void timerAuto_Tick(object sender, EventArgs e) {
            Connect();
            InRead();
            DisConnect();
            CheckDepthRoll();
            lb_checkDepthRoll.Text = flagDepthRoll.ToString();
            CheckRailDifferent();
            lb_checkRailDifferent.Text = flagRailDif.ToString();
        }
        private void InRead() {
            Send(cmdGet);
            Thread.Sleep(50);
            if (Read()) {
                lb_read.Text = "True";
            } else {
                lb_read.Text = "False";
            }

            DisplayValueCamera();
        }
        private void FormCameraRL_FormClosed(object sender, FormClosedEventArgs e) {
            CameraCloseExe();
            CameraCloseBat();
        }
        #endregion
    }
}
