using CameraRL;
using Newtonsoft.Json;
using SimpleWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace AMR_Command {
    public partial class FormMain : Form {
        public FormMain() {
            InitializeComponent();
            SetupConfig();
        }
        public SetupPay.FormPay setupPay = new SetupPay.FormPay();
        public Route route = new Route();
        public CarStatus carStatus = new CarStatus();
        public RedLight redLight = new RedLight();
        public SeRial serial = new SeRial();
        public Server server = new Server();
        public JuncTion junction = new JuncTion();
        public Reverse reverse = new Reverse();
        public Sensor sensor = new Sensor();
        public Emer emer = new Emer();
        public Clien clien = new Clien();
        public RemoteCF remoteCF = new RemoteCF();
        public ErrorCode errorCode = new ErrorCode();
        public DebugCode debugCode = new DebugCode();
        public WifiClass wifiClass = new WifiClass();
        public CalMove calMove = new CalMove();
        public AdjustCar adjustCar = new AdjustCar();
        public FormCameraRL cameraRL = new FormCameraRL();
        public ReverseBack reverseBack = new ReverseBack();

        private void SetupConfig() {
            setupPay.form1.csv.path = "../../../Config/";
            setupPay.SelectTab = SetupPay.tabPage.TAB1;
            setupPay.set_nameTab(route.nameFile);
            setupPay.SelectTab = SetupPay.tabPage.TAB2;
            setupPay.set_nameTab(sensor.nameFile);
            setupPay.SelectTab = SetupPay.tabPage.TAB3;
            setupPay.set_nameTab(serial.nameFile);
            setupPay.SelectTab = SetupPay.tabPage.TAB4;
            setupPay.set_nameTab(server.nameFile);
            setupPay.SelectTab = SetupPay.tabPage.TAB5;
            setupPay.set_nameTab(carStatus.nameFile);
            setupPay.SelectTab = SetupPay.tabPage.TAB7;
            setupPay.set_nameTab(adjustCar.nameFile);

            setupPay.setup();
            SetupRoute();
            SetupSensor();
            SetupSerial();
            SetupServer();
            SetupCarStatus();
            SetupAdjustCar();
        }
        private void SetupRoute() {
            route.lockJobOrder = setupPay.read_text(route.headConfig.lockJobOrder, route.nameFile);
            route.agvNo = setupPay.read_text(route.headConfig.agvNo, route.nameFile);
            if (route.lockJobOrder == route.define.deFault) {
                route.pathSensorConfig = Path.sensorConfig + Path.sensorConfig2;
                route.pathRoute = Path.pathRoute;
                route.mapRoute.path = Path.pathRoute;

            } else {
                route.pathSensorConfig = Path.sensorConfig + route.lockJobOrder + "/" + Path.sensorConfig2;
                route.pathRoute = Path.pathRoute + route.lockJobOrder + "/";
                route.mapRoute.path = Path.pathRoute + route.lockJobOrder + "/";
            }
        }
        private void SetupSensor() {
            sensor.type = setupPay.read_text(sensor.headConfig.type, sensor.nameFile);
            sensor.ip = setupPay.read_text(sensor.headConfig.ip, sensor.nameFile);
            sensor.port = Convert.ToInt32(setupPay.read_text(sensor.headConfig.port, sensor.nameFile));
            sensor.portConfig = Convert.ToInt32(setupPay.read_text(sensor.headConfig.portConfig, sensor.nameFile));
            sensor.rowConfig = setupPay.read_text(sensor.headConfig.rowConfig, sensor.nameFile);
            sensor.quality.minValue = Convert.ToInt32(setupPay.read_text(sensor.headConfig.qualityMin, sensor.nameFile));
            sensor.quality.timeOut = Convert.ToInt32(setupPay.read_text(sensor.headConfig.qualityTimeOut, sensor.nameFile));
            sensor.positionLimitX = Convert.ToInt32(setupPay.read_text(sensor.headConfig.positionLimitX, sensor.nameFile));
            sensor.positionLimitY = Convert.ToInt32(setupPay.read_text(sensor.headConfig.positionLimitY, sensor.nameFile));
            sensor.different.lidarX = Convert.ToInt32(setupPay.read_text(sensor.headConfig.lidarDifferentX, sensor.nameFile));
            sensor.different.lidarY = Convert.ToInt32(setupPay.read_text(sensor.headConfig.lidarDifferentY, sensor.nameFile));
        }
        private void SetupSerial() {
            serial.port = setupPay.read_text(serial.headConfig.port, serial.nameFile);
            serial.baudRate = Convert.ToInt32(setupPay.read_text(serial.headConfig.baudRate, serial.nameFile));
            serial.melody.value = Convert.ToInt32(setupPay.read_text(serial.headConfig.melodyValue, serial.nameFile));
            serial.rx.percenBatMin = Convert.ToInt32(setupPay.read_text(serial.headConfig.percenBatMin, serial.nameFile));
            serial.rx.percenBatMax = Convert.ToInt32(setupPay.read_text(serial.headConfig.percenBatMax, serial.nameFile));
            serial.speedMax = Convert.ToInt32(setupPay.read_text(serial.headConfig.speedMax, serial.nameFile));
            serial.speedDownTime = Convert.ToInt16(setupPay.read_text(serial.headConfig.speedDownTime, serial.nameFile));
            serial.speedDownUnit = Convert.ToInt16(setupPay.read_text(serial.headConfig.speedDownUnit, serial.nameFile));
            serial.speedSlowFactor = Convert.ToDouble(setupPay.read_text(serial.headConfig.speedSlowFactor, serial.nameFile));
        }
        private void SetupServer() {
            server.ip = setupPay.read_text(server.headConfig.ip, server.nameFile);
            server.port = Convert.ToInt32(setupPay.read_text(server.headConfig.port, server.nameFile));
            clien.ip = setupPay.read_text(clien.headConfig.ip, clien.nameFile);
            clien.port = Convert.ToInt32(setupPay.read_text(clien.headConfig.port, clien.nameFile));
            server.positionSendEvery = Convert.ToInt32(setupPay.read_text(server.headConfig.positionSendEvery, server.nameFile));
            server.remoteCfSendEvery = Convert.ToInt32(setupPay.read_text(server.headConfig.remoteCfSendEvery, server.nameFile));
            server.reverseSendEvery = Convert.ToInt32(setupPay.read_text(server.headConfig.reverseSendEvery, server.nameFile));
            server.junctionSendEvery = Convert.ToInt32(setupPay.read_text(server.headConfig.junctionSendEvery, server.nameFile));
            server.SetPositionTick();
            errorCode.readServerTimeOut = Convert.ToInt32(setupPay.read_text(server.headConfig.errorCodeSendEvery, server.nameFile));
            server.wifiName = setupPay.read_text(server.headConfig.wifiName, server.nameFile);
            wifiClass.nameWifi = server.wifiName;
        }
        private void SetupCarStatus() {
            carStatus.statusHookFinish = setupPay.read_text(carStatus.headConfig.statusHookFinish, carStatus.nameFile);
            carStatus.directionHook = setupPay.read_text(carStatus.headConfig.directionHook, carStatus.nameFile);
            if (carStatus.directionHook == CarStatus.Direction.forward) {
                carStatus.directionHookByte = 0x00;
            } else {
                carStatus.directionHookByte = 0x02;
            }
            carStatus.reverseCSVHook = Convert.ToBoolean(setupPay.read_text(carStatus.headConfig.reverseCSVHook, carStatus.nameFile));
            tm_send_data.Tick += SerialPort;
            carStatus.passWord = setupPay.read_text(carStatus.headConfig.passWord, carStatus.nameFile);
            calMove.lengthCar = Convert.ToDouble(setupPay.read_text(adjustCar.headConfig.lengthCar, adjustCar.nameFile));
        }
        private void SetupAdjustCar() {
            calMove.lengthCar = Convert.ToDouble(setupPay.read_text(adjustCar.headConfig.lengthCar, adjustCar.nameFile));
            calMove.offsetAngleL = Convert.ToInt32(setupPay.read_text(adjustCar.headConfig.offsetPulseAngleL, adjustCar.nameFile));
            calMove.offsetAngleR = Convert.ToInt32(setupPay.read_text(adjustCar.headConfig.offsetPulseAngleR, adjustCar.nameFile));
        }
        public string function_timeout(Func<string> function, int timeout) {
            Task<string> task = Task.Run(function);
            if (task.Wait(timeout)) return task.Result;
            else return "over timeout";
        }
        public void DelaymS(int mS) {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Restart();

            while (mS > stopWatch.ElapsedMilliseconds) {

                if (!stopWatch.IsRunning) {
                    stopWatch.Start();
                }

                Application.DoEvents();
            }

            stopWatch.Stop();
        }
        private static void discom(string cmd, string comport) {//enable disable//
            ManagementObjectSearcher manager = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'");
            ManagementObjectCollection managerGet = manager.Get();

            foreach (ManagementObject usbList in managerGet) {
                string name = usbList.GetPropertyValue("NAME").ToString();

                if (name.Contains(comport)) {
                    Process process = new Process();
                    process.StartInfo.FileName = "DevManView.exe";
                    process.StartInfo.Arguments = "/" + cmd + " \"" + name + "\"";
                    process.Start();
                    process.WaitForExit();
                }
            }
        }

        #region================================================== Display_Message =====================================================
        public Color[] LogColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        public enum LogMsgType { Incoming_Blue, Outgoing_Green, Normal_Black, Warning_Orange, Error_Red };
        public void LogSerial(LogMsgType msgtype, string msg) {
            return;
            try {//2147483647
                rtb_serial.Invoke(new EventHandler(delegate {

                    rtb_serial.SelectedText = string.Empty;
                    rtb_serial.SelectionFont = new Font(rtb_serial.SelectionFont, FontStyle.Bold);
                    rtb_serial.SelectionColor = LogColor[(int)msgtype];
                    rtb_serial.AppendText(msg);
                    rtb_serial.ScrollToCaret();

                }));
            } catch { }
        }
        public void LogServer(LogMsgType msgtype, string msg) {
            return;
            try {//2147483647
                rtb_server.Invoke(new EventHandler(delegate {

                    rtb_server.SelectedText = string.Empty;
                    rtb_server.SelectionFont = new Font(rtb_server.SelectionFont, FontStyle.Bold);
                    rtb_server.SelectionColor = LogColor[(int)msgtype];
                    rtb_server.AppendText(msg);
                    rtb_server.ScrollToCaret();

                }));
            } catch { }
        }
        public void LabelSerialTx(LogMsgType msgtype, string msg) {
            try {
                lb_serialTx.Text = msg.Replace("\n", string.Empty);
                lb_serialTx.ForeColor = LogColor[(int)msgtype];
            } catch { }
        }
        public void LabelSerialRx(LogMsgType msgtype, string msg) {
            try {
                lb_serialRx.Text = msg.Replace("\n", string.Empty);
                lb_serialRx.ForeColor = LogColor[(int)msgtype];
            } catch { }
        }
        public void LabelServerSend(LogMsgType msgtype, string msg) {
            try {
                lb_serverSend.Text = msg.Replace("\n", string.Empty);
                lb_serverSend.ForeColor = LogColor[(int)msgtype];
            } catch { }
        }
        public void LabelServerGet(LogMsgType msgtype, string msg) {
            try {
                lb_serverGet.Text = msg.Replace("\n", string.Empty);
                lb_serverGet.ForeColor = LogColor[(int)msgtype];
            } catch { }
        }
        #endregion

        #region ======================================================== Define ===========================================================
        private bool buttonStartBlock;
        private bool formCloseMessageBox;
        private bool waitSendSerialPort;
        private bool tm_close_flag;
        /// <summary>
        /// Flag for wait click button preparation
        /// </summary>
        private bool preparationFlag = true;
        #endregion

        #region ===================================================== Function ========================================================
        private bool SensorConfig() {
            if (sensor.type == Sensor.TypeSensor.udpClient) {
                string jsonRest = string.Empty;
                sensor.sendRest(jsonRest, "http://192.168.1.11/api/LocStartLocalizing");
                sensor.readRest();

                string[] sensorSup = File.ReadAllLines(route.pathSensorConfig);
                string sensorCon = sensorSup[Convert.ToInt32(sensorSup[0].Replace(",", string.Empty))];
                string[] sensorConfig = sensorCon.Replace("P", "+").Replace("M", "-").Split(',');
                SelectRoute(sensorConfig[4]);

                jsonRest = sensor.genJsonRest(sensorConfig[0], sensorConfig[1], sensorConfig[2]);
                sensor.sendRest(jsonRest, "http://192.168.1.11/api/LocResumeAtPose");
                sensor.readRest();

                bgwk_sensor.RunWorkerAsync();
                sensor.quality.ConfirmValue(this);
                bgwk_serial.RunWorkerAsync();

                return true;

            } else {
                bool connected = sensor.ConnectSocketConfig(this);
                if (!connected) {
                    return false;
                }

                string[] sensorSup = File.ReadAllLines(route.pathSensorConfig);
                string sensorCon = sensorSup[Convert.ToInt32(sensorSup[0].Replace(",", string.Empty))];
                string[] sensorConfig = sensorCon.Replace("P", "+").Replace("M", "-").Split(',');
                sensorCon = sensorConfig[0] + " " + sensorConfig[1] + " " + sensorConfig[2] + " " + sensorConfig[3];
                SelectRoute(sensorConfig[4]);
                string headConfig = sensor.GetHeadConfig(this);
                string endConfig = sensor.GetEndConfig(this);
                string[] command = { ("sMN IsSystemReady"),
                                  ("sRN LocState"),
                                  ("sRN LocMapState"),
                                  ("sRN LocMap"),
                                  ("sMN DevSetLidarConfig +0 +300 +100000 -180000 -180000 -2000 +0 +0 0 +12 192.168.1.9 +2122 0 0 1"),
                                  ("sMN LocSetPose " + sensorCon),
                                  ("sMN LocStartLocalizing"),
                                  ("sMN LocSetResultMode 0")
                };

                foreach (string commandSup in command) {
                    sensor.SocketConfigSend(this, headConfig + commandSup + endConfig);
                    DelaymS(500);
                }

                connected = sensor.ConnectSocket(this);

                if (!connected) {
                    return false;
                }

                bgwk_sensor.RunWorkerAsync();
                bgwk_serial.RunWorkerAsync();

                while (Convert.ToInt32(sensor.quality.value) <= 40) {
                    sensor.SocketConfigSend(this, headConfig + sensor.GetLocForceUpdate() + endConfig);
                    DelaymS(500);
                }

                sensor.socketConfig.Disconnect(true);
                sensor.socketConfig.Dispose();
                WaitClickPreparation();
                return true;
            }
        }

        private void SelectRoute(string route_) {
            route.csv.route = route.mapRoute.name + route_;

            if (route.lockJobOrder == route.define.deFault) {
                lb_plant.Text = route.csv.route;

            } else {
                lb_plant.Text = route.lockJobOrder;
            }

            lb_jobOrder.Text = route.csv.route;
        }

        private void ButtonClearColor() {
            bt_start.BackColor = Color.LightGray;
            bt_stop.BackColor = Color.LightGray;
            bt_manual.BackColor = Color.LightGray;
            bt_forkLevel0.BackColor = Color.LightGray;
            bt_forkLevel1.BackColor = Color.LightGray;
            bt_forkLevel2.BackColor = Color.LightGray;
        }
        private void ButtonStartSup() {
            serial.melody.disable(this);

            if (bt_start.Text == Define.auto) {
                if (buttonStartBlock && serial.sending) {
                    return;
                }

                string[] stepSup = new string[0];
                try {
                    stepSup = File.ReadAllLines(route.pathRoute + route.csv.route + ".csv");

                } catch {
                    MessageBox.Show(Define.csvError);
                    if (junction.running) {
                        MessageBox.Show(JuncTion.Define.juncTion + junction.data);
                    }
                    return;
                }

                route.dataInRow.Clear();
                foreach (string step in stepSup) {
                    route.dataInRow.Add(step);
                }
                route.dataInRow.RemoveAt(0);
                route.stepTest = 0;
                NextStep();
                serial.sending = true;
                tm_send_data.Enabled = true;

            } else {
                string[] stepSup = new string[0];
                try {
                    stepSup = File.ReadAllLines(route.pathRoute + route.csv.route + ".csv");

                } catch {
                    MessageBox.Show(Define.csvError);
                    if (junction.running) {
                        MessageBox.Show(JuncTion.Define.juncTion + junction.data);
                    }
                    return;
                }

                route.dataInRow.Clear();
                foreach (string step in stepSup) {
                    route.dataInRow.Add(step);
                }
                route.dataInRow.RemoveAt(0);
            }

            serial.tx.mode = SeRial.Tx.Define.auto;
            bt_start.Text = Define.auto;
            ButtonClearColor();
            bt_start.BackColor = Color.Lime;
        }
        private bool ButtonManual() {
            if (serial.tx.mode == SeRial.Tx.Define.auto) {
                while (true) {
                    string input = Microsoft.VisualBasic.Interaction.InputBox(Define.enterPassWord, Define.enterPassWord, string.Empty, 200, 150);
                    if (input == string.Empty) return false;
                    if (input != carStatus.passWord) {
                        MessageBox.Show(Define.passWordError);
                        continue;
                    }
                    break;
                }
            }

            serial.tx.dataManual[SeRial.Tx.Index.header1] = 0xAA;
            serial.tx.dataManual[SeRial.Tx.Index.header2] = 0x55;
            serial.tx.dataManual[SeRial.Tx.Index.lengthData1] = 0x39;
            serial.tx.dataManual[SeRial.Tx.Index.lengthData2] = 0x00;
            serial.tx.dataManual[SeRial.Tx.Index.command] = 0xAA;
            serial.tx.dataManual[SeRial.Tx.Index.control] = 0x00;
            //serial.tx.dataManual[SeRial.Tx.Index.liftControl] = 0x00;

            serial.tx.manualShow = string.Empty;
            string[] data_sup = ByteArrayToString(serial.tx.dataManual);
            foreach (string s in data_sup) {
                serial.tx.manualShow += s;
            }

            if (bt_start.BackColor == Color.Lime) {
                bt_start.Text = Define.contiNue;
            }

            if (!tm_send_data.Enabled) {
                tm_send_data.Enabled = true;
            }

            serial.tx.mode = SeRial.Tx.Define.manual;
            serial.sending = true;
            return true;
        }
        private bool ButtonManualSup(byte byte_) {
            if (serial.tx.mode == SeRial.Tx.Define.auto) {
                while (true) {
                    string input = Microsoft.VisualBasic.Interaction.InputBox(Define.enterPassWord, Define.enterPassWord, string.Empty, 500, 300);
                    if (input == string.Empty) return false;
                    if (input != carStatus.passWord) {
                        MessageBox.Show(Define.passWordError);
                        continue;
                    }
                    break;
                }
            }

            serial.tx.dataManual[SeRial.Tx.Index.header1] = 0xAA;
            serial.tx.dataManual[SeRial.Tx.Index.header2] = 0x55;
            serial.tx.dataManual[SeRial.Tx.Index.lengthData1] = 0x39;
            serial.tx.dataManual[SeRial.Tx.Index.lengthData2] = 0x00;
            serial.tx.dataManual[SeRial.Tx.Index.liftControl] = byte_;
            serial.tx.dataManual[SeRial.Tx.Index.normalSpeedLow] = 0x00;
            serial.tx.dataManual[SeRial.Tx.Index.normalSpeedHigh] = 0x00;

            serial.tx.manualShow = string.Empty;
            string[] data_sup = ByteArrayToString(serial.tx.dataManual);
            foreach (string s in data_sup) {
                serial.tx.manualShow += s;
            }

            if (bt_start.BackColor == Color.Lime) {
                bt_start.Text = Define.contiNue;
            }

            if (!tm_send_data.Enabled) {
                tm_send_data.Enabled = true;
            }

            serial.tx.mode = SeRial.Tx.Define.manual;
            serial.sending = true;
            return true;
        }
        private void StatusUpdateInternal() {
            byte intLow = Convert.ToByte(serial.rx.data[SeRial.Rx.Index.keyInputLow]);
            byte intHigh = Convert.ToByte(serial.rx.data[SeRial.Rx.Index.keyInputHigh]);

            carStatus.keyInputLow = ByteToBoolArray(intLow);
            carStatus.keyInputHigh = ByteToBoolArray(intHigh);

            lb_startSwitch.Text = carStatus.keyInputLow[CarStatus.IndexLow.start].ToString();
            lb_resetSwitch.Text = carStatus.keyInputLow[CarStatus.IndexLow.reset].ToString();
            lb_forkLevel0.Text = carStatus.keyInputLow[CarStatus.IndexLow.forkLevel0].ToString();
            lb_forkLevel1.Text = carStatus.keyInputLow[CarStatus.IndexLow.forkLevel1].ToString();
            lb_forkLevel2.Text = carStatus.keyInputHigh[CarStatus.IndexHigh.forkLevel2].ToString();
            lb_maxLimit.Text = carStatus.keyInputHigh[CarStatus.IndexHigh.forkMax].ToString();
            lb_rollDetect.Text = carStatus.keyInputHigh[CarStatus.IndexHigh.rollDetect].ToString();
        }
        private void StatusUpdateExternal() {
            byte extLow = Convert.ToByte(serial.rx.data[SeRial.Rx.Index.keyExtInputLow]);
            byte extHigh = Convert.ToByte(serial.rx.data[SeRial.Rx.Index.keyExtInputHigh]);

            carStatus.keyExtInputLow = ByteToBoolArray(extLow);
            carStatus.keyExtInputHigh = ByteToBoolArray(extHigh);

            lb_Emergency.Text = carStatus.keyExtInputLow[CarStatus.IndexExtLow.emergency].ToString();
            lb_ScanFrontMalfunction.Text = carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanFrontMalfunction].ToString();
            lb_ScanFrontWarning.Text = carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanFrontWarning].ToString();
            lb_ScanFrontStop.Text = carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanFrontStop].ToString();
            lb_ScanSideMalfunctionR.Text = carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanSideMalfunctionR].ToString();
            lb_ScanSideWarningR.Text = carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanSideWarningR].ToString();
            lb_ScanSideStopR.Text = carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanSideStopR].ToString();
            lb_ScanSideMalfunctionL.Text = carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanSideMalfunctionL].ToString();

            //if (carStatus.statusHookFinish == CarStatus.Direction.reverse) {
            //    bool sup = carStatus.keyExtInputLow[CarStatus.IndexExtLow.hookUnlockFinish];
            //    carStatus.keyExtInputLow[CarStatus.IndexExtLow.hookUnlockFinish] = carStatus.keyExtInputLow[CarStatus.IndexExtLow.hookLockFinish];
            //    carStatus.keyExtInputLow[CarStatus.IndexExtLow.hookLockFinish] = sup;
            //}

            //lb_ScanSideStopR.Text = carStatus.keyExtInputLow[CarStatus.IndexExtLow.hookLockFinish].ToString();
            //lb_ScanSideMalfunctionL.Text = carStatus.keyExtInputLow[CarStatus.IndexExtLow.hookUnlockFinish].ToString();

            lb_ScanSideWarningL.Text = carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.scanSideWarningL].ToString();
            lb_ScanSideStopL.Text = carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.scanSideStopL].ToString();
            lb_BumperFront.Text = carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperFront].ToString();
            lb_BumperSideL.Text = carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperSideL].ToString();
            lb_BumperSideR.Text = carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperSideR].ToString();
            lb_BumperWingL.Text = carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperWingL].ToString();
            lb_BumperWingR.Text = carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperWingR].ToString();
            lb_StatusNc.Text = carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.nc1].ToString();
        }
        /// <summary>
        /// For wait click button preparation
        /// </summary>
        private void WaitClickPreparation() {
            while (preparationFlag) {
                DelaymS(500);
            }
        }
        /// <summary>
        /// For clear preparation flag and color button
        /// </summary>
        private void PreparationClear() {
            bt_preparation.BackColor = Color.LightGray;
            preparationFlag = true;
        }

        private byte MelodyCheckSend() {
            if (errorCode.flagOpen || sensor.quality.flag || sensor.different.formOpen) {
                return 0x03;
            }

            if (emer.speedError) {
                return 0x02;
            }

            if (carStatus.flagAlarmEndPosition || carStatus.flagAlarmSensorRollDetectOff || 
                carStatus.flagAlarmSensorRollDetectOn) {
                if (carStatus.flagAlarmEndPosition) {
                    return 0x02;
                }
                if (carStatus.flagAlarmSensorRollDetectOff) {
                    return 0x02;
                }
                if (carStatus.flagAlarmSensorRollDetectOn) {
                    return 0x02;
                }
            }

            if (carStatus.flagForkUp || carStatus.flagForkDown) {
                if (carStatus.flagForkUp) {
                    return 0x07;
                } else {
                    return 0x08;
                }
            }

            if (route.csv.command == 0x02) {
                return 0x09;
            }

            if (reverse.formFlag) {
                return 0x04;
            }

            if (remoteCF.flag || reverse.resum.wait || junction.running || reverse.value5To50) {
                return 0x00;
            }

            if (cameraRL.offSpeed) {
                return 0x05;
            }

            if (carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanFrontMalfunction] ||
                    carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanFrontStop] ||
                    carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanSideMalfunctionR] ||
                    carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanSideStopR] ||
                    carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanSideMalfunctionL] ||
                    carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.scanSideStopL] ||
                sensor.quality.flag) {
                return 0x05;
            }

            if (carStatus.offSpeedFlag) {
                return 0x00;

            } else {
                return 0x01;
            }
        }
        /// <summary>
        /// For on lamp follow state
        /// </summary>
        /// <returns>Return byte status lamp</returns>
        private byte LampDisplay() {
            byte data = 0x00;

            if (!preparationFlag) {
                data |= Convert.ToByte("00100000", 2);
            }

            if (serial.tx.mode == SeRial.Tx.Define.auto) {
                data |= Convert.ToByte("00000100", 2);
            } else {
                data |= Convert.ToByte("00010000", 2);
            }

            if (sensor.quality.flag || sensor.different.formOpen || cameraRL.offSpeed) {
                data |= Convert.ToByte("00001000", 2);
            }

            if (carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanFrontMalfunction] |
                carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanFrontStop] |
                carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanSideMalfunctionR] |
                carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanSideStopR] |
                carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanSideMalfunctionL] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.scanSideStopL]) {
                data |= Convert.ToByte("00001000", 2);
            }

            if (carStatus.keyExtInputLow[CarStatus.IndexExtLow.emergency] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperWingL] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperSideR] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperSideL] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperFront] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperWingR]) {
                data |= Convert.ToByte("00001000", 2);
            }

            return data;
        }
        /// <summary>
        /// For preparation check emer and bumper to set flag preparation
        /// </summary>
        private void PreparationCheck() {
            if (carStatus.keyExtInputLow[CarStatus.IndexExtLow.emergency] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperWingL] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperSideR] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperSideL] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperFront] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperWingR]) {
                PreparationClear();
            }
        }
        /// <summary>
        /// For check level fork and clear flag fork off speed
        /// </summary>
        /// <param name="dataLiftControl">data send byte lift control</param>
        private void CheckLevelForkToOnSpeed(byte dataLiftControl) {
            bool checkUp = carStatus.CheckLevelForkUp(reverse.value, dataLiftControl);
            if (!checkUp) {
                carStatus.flagForkUp = false;
            }

            bool checkDown = carStatus.CheckLevelForkDown(reverse.value, dataLiftControl);
            if (!checkDown) {
                carStatus.flagForkDown = false;
            }
        }
        /// <summary>
        /// Set flag after cameraRL ok
        /// </summary>
        private void ReverseSetFlagFork() {
            if (carStatus.lavelFork == 1) {
                if (reverse.value == 1 || reverse.value == 2) {
                    carStatus.lavelFork = 3;
                    carStatus.flagForkUp = true;
                }
            } else {
                if (reverse.value == 3 || reverse.value == 4) {
                    carStatus.lavelFork = 1;
                    carStatus.flagForkDown = true;
                }
            }
        }
        /// <summary>
        /// Check falg cameraRL
        /// </summary>
        /// <returns>Return reverse stop end</returns>
        private bool ReverseCheckFlagCameraRL() {
            if (route.flagNextStep) {
                route.flagNextStep = false;
                cameraRL.flagEndPosition = true;

                if (reverse.value == 1 || reverse.value == 2) {
                    if (!cameraRL.flagDepthRoll) {
                        carStatus.flagAlarmEndPosition = true;
                        return false;
                    }
                }
                if (cameraRL.flagRailDif) {
                    carStatus.flagAlarmEndPosition = false;
                    return true;
                } else {
                    carStatus.flagAlarmEndPosition = true;
                    return false;
                }
            }

            if (cameraRL.flagLockDetectCam) {
                return true;
            }
            if (cameraRL.flagDepthRoll) {
                if (cameraRL.flagRailDif) {
                    if (reverse.value == 1 || reverse.value == 2) {
                        cameraRL.flagLockDetectCam = true;
                    }
                    bgwk_serial.ReportProgress(4);
                    return true;
                } else {
                    bgwk_serial.ReportProgress(3);
                    //run back
                }
            } else {
                bgwk_serial.ReportProgress(5);
            }

            return false;
        }
        /// <summary>
        /// Reverse check flag cameraRL rail to show label
        /// </summary>
        private void ReverseCheckFlagRail() {
            if (cameraRL.flagRailDif) {
                bgwk_serial.ReportProgress(6);
            } else {
                bgwk_serial.ReportProgress(7);
            }
        }
        /// <summary>
        /// Reverse check value = 0 to value++ and set flag fork
        /// </summary>
        /// <param name="reverseCameraEnd">is flag reverse next step</param>
        private bool ReverseValue0ToSetFlagFork(bool reverseCameraEnd) {
            if (!reverseCameraEnd) {
                return false;
            }

            if (reverse.resum.value == 0) {
                reverse.resum.value++;
                ReverseSetFlagFork();
                return true;
            }

            return false;
        }
        /// <summary>
        /// Reverse check value = 1 to wait flag fork up down false
        /// </summary>
        /// <param name="reverseCameraEnd">is flag reverse next step</param>
        private bool ReverseValue1WaitFlagForkClear(bool reverseCameraEnd) {
            if (!reverseCameraEnd) {
                return false;
            }

            if (reverse.resum.value == 1) {
                if (!carStatus.flagForkUp && !carStatus.flagForkDown) {
                    reverse.resum.value++;
                    reverse.resum.wait = true;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Reverse check value = 3 to set next step = true and clear flagEndPosition
        /// </summary>
        /// <param name="reverseCameraEnd">is flag reverse next step</param>
        private bool ReverseWaitValue3(bool reverseCameraEnd) {
            if (!reverseCameraEnd) {
                return false;
            }

            if (reverse.resum.value == 3) {
                if (!carStatus.flagForkUp && !carStatus.flagForkDown) {
                    route.flagNextStep = true;
                    cameraRL.flagEndPosition = false;
                    cameraRL.flagLockDetectCam = false;
                    return true;
                }
            }
            return false;
        }

        private void grthrth() {

        }

        /// <summary>
        /// Wait connect camera
        /// </summary>
        private void CameraWaitConnect() {
            while (true) {
                bool result = cameraRL.Connect();

                if (result) {
                    break;
                }

                Thread.Sleep(1000);
            }
        }
        /// <summary>
        /// Process of camera read to check  value
        /// </summary>
        private void CameraProcess() {
            if (!cameraRL.sendTick) return;
            cameraRL.sendTick = false;

            if (!cameraRL.Connect()) {
                cameraRL.offSpeed = true;
                MessageBox.Show("Connect Camera Error");

            } else {
                cameraRL.Send(cameraRL.cmdGet);
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Restart();

                while (stopWatch.ElapsedMilliseconds < 3000) {
                    if (cameraRL.socket.Available == 0) {
                        Thread.Sleep(100);
                        continue;
                    }

                    cameraRL.Read();
                    cameraRL.DisConnect();
                    cameraRL.CheckDepthRoll(reverse.value);
                    cameraRL.CheckRailDifferent();

                    stopWatch.Stop();
                    break;
                }

                if (stopWatch.IsRunning) {
                    cameraRL.offSpeed = true;
                    MessageBox.Show("รับค่าจาก camera ไม่ได้");
                }
            }
        }
        /// <summary>
        /// For clear flag wait while loop
        /// </summary>
        private void ClearWaitWhileLoop() {
            preparationFlag = false;
        }

        private void BindServer() {
            bgwk_main.ReportProgress(0);

            try {
                server.hostName = Dns.GetHostName();
                IPHostEntry ipEntry = Dns.GetHostByName(server.hostName);
                server.ipAddress = ipEntry.AddressList;

            } catch {
                bgwk_main.ReportProgress(1);
            }

            if (server.ipAddress == null || server.ipAddress.Length < 1) {
                bgwk_main.ReportProgress(2);
                return;
            }

            bgwk_main.ReportProgress(3);
            foreach (IPAddress ipAddressSup in server.ipAddress) {
                if (ipAddressSup.ToString() != server.ip) {
                    server.ip = ipAddressSup.ToString();
                }
            }

            while (true) {
                try {
                    server.socket.Bind(new IPEndPoint(IPAddress.Parse(server.ip), server.port));
                    server.socket.Listen(0);
                    server.socket.BeginAccept(AcceptCallback, null);
                    break;

                } catch {
                    bgwk_main.ReportProgress(6);
                    Thread.Sleep(1000);
                }
            }

            bgwk_main.ReportProgress(4);
        }
        private void ClienShowLabel(bool flagSend, string json) {
            clien.jsonSend = json;

            if (flagSend) {
                bgwk_main.ReportProgress(7);

            } else {
                bgwk_main.ReportProgress(8);
            }
        }
        private void ClienPosition() {
            if (server.sendPositionTick) {
                server.sendPositionTick = false;
                string json = JsonPosition(0);
                clien.Connect(this, clien.ip, clien.port);
                bool flagSend = true;
                byte[] buffer = Encoding.ASCII.GetBytes(json);

                try {
                    clien.socket.SendTimeout = Clien.Define.timeOut;
                    clien.socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                } catch (Exception excep) {
                    LogSendError(excep, json);
                    flagSend = false;
                }

                ClienShowLabel(flagSend, json);
                clien.Close();
            }
        }
        private void ClienRemoteCF() {
            if (remoteCF.flag) {
                string json = JsonRemoteCF(0);
                byte[] buffer = Encoding.ASCII.GetBytes(json);
                server.receive.remoteCF = false;

                while (!server.receive.remoteCF) {
                    ClienCheckAck();
                    clien.Connect(this, clien.ip, clien.port);
                    bool result = true;

                    try {
                        clien.socket.SendTimeout = Clien.Define.timeOut;
                        clien.socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                    } catch (Exception excep) {
                        LogSendError(excep, json);
                        result = false;
                    }

                    ClienShowLabel(result, json);
                    if (!result) {
                        Thread.Sleep(1000);
                        continue;
                    }
                    clien.Close();

                    Stopwatch timeout = new Stopwatch();
                    timeout.Restart();

                    while (timeout.ElapsedMilliseconds <= server.remoteCfSendEvery) {
                        ClienCheckAck();
                        if (server.receive.remoteCF) break;
                        Thread.Sleep(50);
                    }
                }

                remoteCF.flag = false;
            }
        }
        private void ClienEndProcess() {
            if (server.endProcess) {

                server.endProcess = false;

                ClienEndSend();

                sensor.reConnect = true;
                Thread.Sleep(2500);

                serial.rx.CheckBatMin();

                sensor.reConnect = false;
                ClienStartSend();
            }
        }
        private void ClienReverse12() {
            if (reverse.resum.value == 2) {

                string json = JsonReverse(0);
                bool result = true;
                byte[] buffer = Encoding.ASCII.GetBytes(json);

                if (reverse.value == 1 || reverse.value == 2) {
                    while (!reverse.receive.pickUp) {
                        ClienCheckAck();
                        clien.Connect(this, clien.ip, clien.port);

                        try {
                            clien.socket.SendTimeout = Clien.Define.timeOut;
                            clien.socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                        } catch (Exception excep) {
                            LogSendError(excep, json);
                            result = false;
                        }

                        ClienShowLabel(result, json);
                        if (!result) {
                            Thread.Sleep(1000);
                            continue;
                        }

                        clien.Close();

                        Stopwatch timeout = new Stopwatch();
                        timeout.Restart();
                        while (timeout.ElapsedMilliseconds <= server.reverseSendEvery) {
                            ClienCheckAck();
                            if (reverse.receive.pickUp) {
                                break;
                            }
                            Thread.Sleep(50);
                        }
                    }

                } else {
                    while (!reverse.receive.drop) {
                        ClienCheckAck();
                        clien.Connect(this, clien.ip, clien.port);
                        reverse.receive.resum = false;

                        try {
                            clien.socket.SendTimeout = Clien.Define.timeOut;
                            clien.socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                        } catch (Exception excep) {
                            LogSendError(excep, json);
                            result = false;
                        }

                        ClienShowLabel(result, json);
                        if (!result) {
                            Thread.Sleep(1000);
                            continue;
                        }

                        try { clien.socket.Shutdown(SocketShutdown.Both); } catch { }
                        try { clien.socket.Close(); } catch { }
                        try { clien.socket.Dispose(); } catch { }

                        Stopwatch timeout = new Stopwatch();
                        timeout.Restart();

                        while (timeout.ElapsedMilliseconds <= server.reverseSendEvery) {
                            ClienCheckAck();
                            if (reverse.receive.drop) {
                                break;
                            }
                            Thread.Sleep(50);
                        }
                    }
                }

                while (!reverse.receive.resum) {
                    ClienCheckAck();
                    wifiClass.CheckStatus();
                    Thread.Sleep(100);
                }
                reverse.resum.wait = false;
                reverse.resum.value++;
            }
        }
        private void ClienReverse34() {
            if (reverse.value3To50) {
                if (reverse.resum.value != 2) {
                    return;
                }

                string json = JsonReverse(0);
                bool result = true;
                byte[] buffer = Encoding.ASCII.GetBytes(json);

                if (reverse.value == 1 || reverse.value == 2) {
                    while (!reverse.receive.pickUp) {
                        ClienCheckAck();
                        clien.Connect(this, clien.ip, clien.port);

                        try {
                            clien.socket.SendTimeout = Clien.Define.timeOut;
                            clien.socket.Send(buffer, 0, buffer.Length, SocketFlags.None);

                        } catch (Exception excep) {
                            LogSendError(excep, json);
                            result = false;
                        }

                        ClienShowLabel(result, json);
                        if (!result) {
                            Thread.Sleep(1000);
                            continue;
                        }

                        try { clien.socket.Shutdown(SocketShutdown.Both); } catch { }
                        try { clien.socket.Close(); } catch { }
                        try { clien.socket.Dispose(); } catch { }

                        Stopwatch timeout = new Stopwatch();
                        timeout.Restart();

                        while (timeout.ElapsedMilliseconds <= server.reverseSendEvery) {
                            ClienCheckAck();
                            if (reverse.receive.pickUp) {
                                break;
                            }
                            Thread.Sleep(50);
                        }

                    }
                } else {

                    while (!reverse.receive.drop) {
                        ClienCheckAck();
                        clien.Connect(this, clien.ip, clien.port);
                        reverse.receive.resum = false;

                        try {
                            clien.socket.SendTimeout = Clien.Define.timeOut;
                            clien.socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                        } catch (Exception excep) {
                            LogSendError(excep, json);
                            result = false;
                        }

                        ClienShowLabel(result, json);
                        if (!result) {
                            Thread.Sleep(1000);
                            continue;
                        }

                        try { clien.socket.Shutdown(SocketShutdown.Both); } catch { }
                        try { clien.socket.Close(); } catch { }
                        try { clien.socket.Dispose(); } catch { }

                        Stopwatch timeout = new Stopwatch();
                        timeout.Restart();

                        while (timeout.ElapsedMilliseconds <= server.reverseSendEvery) {
                            ClienCheckAck();
                            if (reverse.receive.drop) {
                                break;
                            }
                            Thread.Sleep(50);
                        }
                    }
                }

                while (!reverse.receive.resum) {
                    ClienCheckAck();
                    wifiClass.CheckStatus();
                    Thread.Sleep(100);
                }

                reverse.value3To50 = false;
                reverse.nextStep = true;
            }
        }
        private void ClienAckResum() {
            string json = JsonResum(0);
            bool result = true;
            byte[] buffer = Encoding.ASCII.GetBytes(json);
            clien.Connect(this, clien.ip, clien.port);

            try {
                clien.socket.SendTimeout = Clien.Define.timeOut;
                clien.socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
            } catch (Exception excep) {
                LogSendError(excep, json);
                result = false;
            }

            ClienShowLabel(result, json);
            clien.Close();
        }
        private void ClienAckJobOrder() {
            string json = JsonJobOrder(0);
            bool result = true;
            byte[] buffer = Encoding.ASCII.GetBytes(json);
            clien.Connect(this, clien.ip, clien.port);

            try {
                clien.socket.SendTimeout = Clien.Define.timeOut;
                clien.socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
            } catch (Exception excep) {
                LogSendError(excep, json);
                result = false;
            }

            ClienShowLabel(result, json);
            clien.Close();
        }
        private void ClienJunction() {
            if (junction.running) {
                Thread.Sleep(3000);
                string json = JsonJunction(0);

                while (junction.running) {
                    ClienCheckAck();
                    clien.Connect(this, clien.ip, clien.port);
                    bool result = true;
                    byte[] buffer = Encoding.ASCII.GetBytes(json);

                    try {
                        clien.socket.SendTimeout = Clien.Define.timeOut;
                        clien.socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                    } catch (Exception excep) {
                        LogSendError(excep, json);
                        result = false;
                    }

                    ClienShowLabel(result, json);
                    if (!result) {
                        Thread.Sleep(1000);
                        continue;
                    }

                    try { clien.socket.Shutdown(SocketShutdown.Both); } catch { }
                    try { clien.socket.Close(); } catch { }
                    try { clien.socket.Dispose(); } catch { }

                    Stopwatch timeout = new Stopwatch();
                    timeout.Restart();

                    while (timeout.ElapsedMilliseconds <= server.junctionSendEvery) {
                        ClienCheckAck();
                        if (!junction.running) break;
                        Thread.Sleep(50);
                    }
                }
            }
        }
        private void ClienStartSend() {
            while (!server.receive.start) {
                ClienCheckAck();
                string json = JsonStart(0);
                clien.Connect(this, clien.ip, clien.port);
                byte[] buffer = Encoding.ASCII.GetBytes(json);
                bool flagSend = true;

                try {
                    clien.socket.SendTimeout = Clien.Define.timeOut;
                    clien.socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                } catch (Exception excep) {
                    LogSendError(excep, json);
                    flagSend = false;
                }

                ClienShowLabel(flagSend, json);
                if (!flagSend) {
                    Thread.Sleep(1000);
                    continue;
                }

                clien.Close();

                Stopwatch timeout = new Stopwatch();
                timeout.Restart();
                while (timeout.ElapsedMilliseconds <= 3000) {
                    ClienCheckAck();
                    if (server.receive.start) {
                        break;
                    }
                    Thread.Sleep(50);
                }
            }
        }
        private void ClienEndSend() {
            while (!server.receive.end) {
                ClienCheckAck();
                string json = JsonEnd(0);
                clien.Connect(this, clien.ip, clien.port);
                byte[] buffer = Encoding.ASCII.GetBytes(json);
                bool flagSend = true;

                try {
                    clien.socket.SendTimeout = Clien.Define.timeOut;
                    clien.socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                } catch (Exception excep) {
                    LogSendError(excep, json);
                    flagSend = false;
                }

                ClienShowLabel(flagSend, json);
                if (!flagSend) {
                    Thread.Sleep(1000);
                    continue;
                }

                clien.Close();

                Stopwatch timeout = new Stopwatch();
                timeout.Restart();
                while (timeout.ElapsedMilliseconds <= 3000) {
                    ClienCheckAck();
                    if (server.receive.end) {
                        break;
                    }
                    Thread.Sleep(50);
                }
            }
        }
        private void ClienErrorCode() {
            if (errorCode.sendServer) {
                errorCode.readServer = false;
                string json = JsonErrorCode(0);
                byte[] buffer = Encoding.ASCII.GetBytes(json);

                while (errorCode.flagOpen) {
                    ClienCheckAck();
                    clien.Connect(this, clien.ip, clien.port);
                    bool result = true;
                    errorCode.readServer = false;

                    try {
                        clien.socket.SendTimeout = Clien.Define.timeOut;
                        clien.socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                    } catch (Exception excep) {
                        LogSendError(excep, json);
                        result = false;
                    }

                    ClienShowLabel(result, json);
                    if (!result) {
                        Thread.Sleep(1000);
                        continue;
                    }

                    clien.Close();

                    Stopwatch timeout = new Stopwatch();
                    timeout.Restart();

                    while (timeout.ElapsedMilliseconds <= errorCode.readServerTimeOut) {
                        ClienCheckAck();
                        if (errorCode.readServer) break;
                        Thread.Sleep(50);
                    }
                }

                errorCode.sendServer = false;
            }
        }
        private void ClienErrorPosition() {
            if (sensor.quality.flag) {
                sensor.quality.readServer = false;
                string json = JsonErrorPosition(0);
                byte[] buffer = Encoding.ASCII.GetBytes(json);

                while (sensor.quality.flag) {
                    ClienCheckAck();
                    clien.Connect(this, clien.ip, clien.port);
                    bool result = true;
                    sensor.quality.readServer = false;

                    try {
                        clien.socket.SendTimeout = Clien.Define.timeOut;
                        clien.socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                    } catch (Exception excep) {
                        LogSendError(excep, json);
                        result = false;
                    }

                    ClienShowLabel(result, json);
                    if (!result) {
                        Thread.Sleep(1000);
                        continue;
                    }

                    clien.Close();

                    Stopwatch timeout = new Stopwatch();
                    timeout.Restart();

                    while (timeout.ElapsedMilliseconds <= errorCode.readServerTimeOut) {
                        ClienCheckAck();
                        if (sensor.quality.readServer) break;
                        Thread.Sleep(50);
                    }
                }
            }

            if (sensor.different.formOpen) {
                sensor.different.readServer = false;
                string json = JsonErrorPosition(0);
                byte[] buffer = Encoding.ASCII.GetBytes(json);

                while (sensor.different.formOpen) {
                    ClienCheckAck();
                    clien.Connect(this, clien.ip, clien.port);
                    bool result = true;
                    sensor.different.readServer = false;

                    try {
                        clien.socket.SendTimeout = Clien.Define.timeOut;
                        clien.socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                    } catch (Exception excep) {
                        LogSendError(excep, json);
                        result = false;
                    }

                    ClienShowLabel(result, json);
                    if (!result) {
                        Thread.Sleep(1000);
                        continue;
                    }

                    clien.Close();

                    Stopwatch timeout = new Stopwatch();
                    timeout.Restart();

                    while (timeout.ElapsedMilliseconds <= errorCode.readServerTimeOut) {
                        ClienCheckAck();
                        if (sensor.different.readServer) break;
                        Thread.Sleep(50);
                    }
                }
            }
        }
        private void ClienCheckAck() {
            if (clien.ackResume) {
                clien.ackResume = false;
                //ClienAckResum();
            }

            if (clien.ackJobOrder) {
                clien.ackJobOrder = false;
                //ClienAckJobOrder();
            }
        }

        private void ReStartProgram() {
            if (!tm_close_flag) return;

            Application.Restart();

            try {
                bgwk_sensor.Dispose();
            } catch { }
            try {
                bgwk_serial.Dispose();
            } catch { }
            try {
                bgwk_main.Dispose();
            } catch { }

            this.Close();
        }

        private string JsonPosition(double mesID) {
            Server.JsonServer jsonServer = new Server.JsonServer();

            jsonServer.TimeStamp = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));
            jsonServer.MessageID = mesID.ToString("00000000");
            jsonServer.SourceID = server.ip;
            jsonServer.TargetID = clien.ip;

            if (carStatus.offSpeedFlag || emer.lockOffSpeed) {
                jsonServer.Cmd = Clien.Cmd.stop;

            } else {
                jsonServer.Cmd = Clien.Cmd.position;
            }

            jsonServer.Position.X = sensor.X.ToString();
            jsonServer.Position.Y = sensor.Y.ToString();
            jsonServer.Position.YW = sensor.angle.value.ToString();
            jsonServer.Battery = serial.rx.voltBatPercen.ToString();

            return new JavaScriptSerializer().Serialize(jsonServer);
        }
        private string JsonStart(double mesID) {
            Server.JsonServer jsonServer = new Server.JsonServer();

            jsonServer.TimeStamp = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));
            jsonServer.MessageID = mesID.ToString("00000000");
            jsonServer.SourceID = server.ip;
            jsonServer.TargetID = clien.ip;
            jsonServer.Cmd = Clien.Cmd.start;
            jsonServer.Position.X = sensor.X.ToString();
            jsonServer.Position.Y = sensor.Y.ToString();
            jsonServer.Position.YW = sensor.angle.value.ToString();
            jsonServer.Battery = serial.rx.voltBatPercen.ToString();

            return new JavaScriptSerializer().Serialize(jsonServer);
        }
        private string JsonEnd(double mesID) {
            Server.JsonServer jsonServer = new Server.JsonServer();

            jsonServer.TimeStamp = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));
            jsonServer.MessageID = mesID.ToString("00000000");
            jsonServer.SourceID = server.ip;
            jsonServer.TargetID = clien.ip;
            jsonServer.Cmd = Clien.Cmd.end;
            jsonServer.Position.X = sensor.X.ToString();
            jsonServer.Position.Y = sensor.Y.ToString();
            jsonServer.Position.YW = sensor.angle.value.ToString();
            jsonServer.Battery = serial.rx.voltBatPercen.ToString();

            return new JavaScriptSerializer().Serialize(jsonServer);
        }
        private string JsonRemoteCF(double mesID) {
            Server.JsonServer jsonServer = new Server.JsonServer();

            jsonServer.TimeStamp = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));
            jsonServer.MessageID = mesID.ToString("00000000");
            jsonServer.SourceID = server.ip;
            jsonServer.TargetID = clien.ip;
            jsonServer.Cmd = Clien.Cmd.remoteCF + remoteCF.value;
            jsonServer.Position.X = sensor.X.ToString();
            jsonServer.Position.Y = sensor.Y.ToString();
            jsonServer.Position.YW = sensor.angle.value.ToString();
            jsonServer.Battery = serial.rx.voltBatPercen.ToString();

            return new JavaScriptSerializer().Serialize(jsonServer);
        }
        private string JsonReverse(double mesID) {
            string cmd = string.Empty;
            string data = string.Empty;
            Server.JsonServer jsonServer = new Server.JsonServer();

            switch (reverse.value) {
                case 1: cmd = Clien.Cmd.pickedUp; break;
                case 2: cmd = Clien.Cmd.pickedUp; break;
                case 3: cmd = Clien.Cmd.drop; break;
                case 4: cmd = Clien.Cmd.drop; break;
                default: cmd = Clien.Cmd.pause; break;
            }
            switch (reverse.value) {
                case 1: data = Clien.Cmd.part; break;
                case 2: data = Clien.Cmd.empty; break;
                case 3: data = Clien.Cmd.part; break;
                case 4: data = Clien.Cmd.empty; break;
                default: data = (reverse.value - 4).ToString(); break;
            }

            jsonServer.TimeStamp = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));
            jsonServer.MessageID = mesID.ToString("00000000");
            jsonServer.SourceID = server.ip;
            jsonServer.TargetID = clien.ip;
            jsonServer.Cmd = cmd;
            jsonServer.PayLoad.Data = data;
            jsonServer.Position.X = sensor.X.ToString();
            jsonServer.Position.Y = sensor.Y.ToString();
            jsonServer.Position.YW = sensor.angle.value.ToString();
            jsonServer.Battery = serial.rx.voltBatPercen.ToString();

            return new JavaScriptSerializer().Serialize(jsonServer);
        }
        private string JsonResum(double mesID) {
            Server.JsonServer jsonServer = new Server.JsonServer();

            jsonServer.TimeStamp = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));
            jsonServer.MessageID = mesID.ToString("00000000");
            jsonServer.SourceID = server.ip;
            jsonServer.TargetID = clien.ip;
            jsonServer.Cmd = Clien.Cmd.resume;
            jsonServer.Position.X = sensor.X.ToString();
            jsonServer.Position.Y = sensor.Y.ToString();
            jsonServer.Position.YW = sensor.angle.value.ToString();
            jsonServer.Battery = serial.rx.voltBatPercen.ToString();

            return new JavaScriptSerializer().Serialize(jsonServer);
        }
        private string JsonJobOrder(double mesID) {
            Server.JsonServer jsonServer = new Server.JsonServer();

            jsonServer.TimeStamp = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));
            jsonServer.MessageID = mesID.ToString("00000000");
            jsonServer.SourceID = server.ip;
            jsonServer.TargetID = clien.ip;
            jsonServer.Cmd = Clien.Cmd.jobOrder;
            jsonServer.Position.X = sensor.X.ToString();
            jsonServer.Position.Y = sensor.Y.ToString();
            jsonServer.Position.YW = sensor.angle.value.ToString();
            jsonServer.Battery = serial.rx.voltBatPercen.ToString();

            return new JavaScriptSerializer().Serialize(jsonServer);
        }
        private string JsonLed(double mesID, string data_payload) {
            Server.JsonMcu jsonMcu = new Server.JsonMcu();

            jsonMcu.timeStamp = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));
            jsonMcu.messageID = mesID.ToString("00000001");
            jsonMcu.sourceID = server.ip;
            jsonMcu.targetID = redLight.ip;
            if (redLight.ipConfig <= 40) {
                jsonMcu.cmd = Clien.Cmd.door;

            } else {
                jsonMcu.cmd = Clien.Cmd.light;
            }
            jsonMcu.payload.Data = data_payload;

            return new JavaScriptSerializer().Serialize(jsonMcu);
        }
        private string JsonJunction(double mesID) {
            Server.JsonServer jsonServer = new Server.JsonServer();

            jsonServer.TimeStamp = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));
            jsonServer.MessageID = mesID.ToString("00000000");
            jsonServer.SourceID = server.ip;
            jsonServer.TargetID = clien.ip;
            jsonServer.Cmd = Clien.Cmd.junction;
            jsonServer.PayLoad.Data = junction.point;
            jsonServer.Position.X = sensor.X.ToString();
            jsonServer.Position.Y = sensor.Y.ToString();
            jsonServer.Position.YW = sensor.angle.value.ToString();
            jsonServer.Battery = serial.rx.voltBatPercen.ToString();

            return new JavaScriptSerializer().Serialize(jsonServer);
        }
        private string JsonErrorCode(double mesID) {
            Server.JsonServer jsonServer = new Server.JsonServer();

            jsonServer.TimeStamp = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));
            jsonServer.MessageID = mesID.ToString("00000000");
            jsonServer.SourceID = server.ip;
            jsonServer.TargetID = clien.ip;
            jsonServer.Cmd = Clien.Cmd.errorCode;
            jsonServer.PayLoad.Data = errorCode.codeHead;
            jsonServer.PayLoad.Data1 = errorCode.codeDetail;
            jsonServer.Position.X = sensor.X.ToString();
            jsonServer.Position.Y = sensor.Y.ToString();
            jsonServer.Position.YW = sensor.angle.value.ToString();
            jsonServer.Battery = serial.rx.voltBatPercen.ToString();

            return new JavaScriptSerializer().Serialize(jsonServer);
        }
        private string JsonErrorPosition(double mesID) {
            Server.JsonServer jsonServer = new Server.JsonServer();

            jsonServer.TimeStamp = DateTime.Now.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));
            jsonServer.MessageID = mesID.ToString("00000000");
            jsonServer.SourceID = server.ip;
            jsonServer.TargetID = clien.ip;
            jsonServer.Cmd = Clien.Cmd.errorCode;

            if (sensor.quality.flag) {
                jsonServer.PayLoad.Data = "0004";
            }
            if (sensor.different.formOpen) {
                jsonServer.PayLoad.Data = "0005";
            }

            jsonServer.PayLoad.Data1 = "0000";
            jsonServer.Position.X = sensor.X.ToString();
            jsonServer.Position.Y = sensor.Y.ToString();
            jsonServer.Position.YW = sensor.angle.value.ToString();
            jsonServer.Battery = serial.rx.voltBatPercen.ToString();

            return new JavaScriptSerializer().Serialize(jsonServer);
        }

        private void CloseAllSockets() {
            clien.CloseAll();

            server.socket.Close();
        }
        private void AcceptCallback(IAsyncResult resultIAsync) {
            Socket socket;

            try {
                socket = server.socket.EndAccept(resultIAsync);
            } catch {
                return;
            }

            clien.listSocket.Add(socket);
            socket.BeginReceive(server.buffer, 0, Server.Define.bufferSize, SocketFlags.None, ReceiveCallback, socket);
            bgwk_main.ReportProgress(10);

            server.ipEndPointNewConnect = socket.RemoteEndPoint as IPEndPoint;

            bgwk_main.ReportProgress(11);
            server.socket.BeginAccept(AcceptCallback, null);
        }
        private void ReceiveCallback(IAsyncResult resultIAsync) {
            Thread.Sleep(100);
            Socket socketSup = (Socket)resultIAsync.AsyncState;
            int received;

            try {
                received = socketSup.EndReceive(resultIAsync);
                if (received == 0) {
                    ClientDisConnect(socketSup);
                    return;
                }

            } catch {
                ClientDisConnect(socketSup);
                return;
            }

            byte[] buf = new byte[received];
            Array.Copy(server.buffer, buf, received);
            string text = Encoding.ASCII.GetString(buf);

            server.jsonReceive = text;
            bgwk_main.ReportProgress(9);

            if (serial.rx.batteryMinFlag) {
                return;
            }

            Server.JsonServerRead jsonRead;
            try {
                jsonRead = JsonConvert.DeserializeObject<Server.JsonServerRead>(text);
            } catch {
                //MessageBox.Show(Server.Error.convertJson);
                socketSup.BeginReceive(server.buffer, 0, Server.Define.bufferSize, SocketFlags.None, ReceiveCallback, socketSup);
                return;
            }

            if (jsonRead.Cmd == Server.Cmd.jobOrder) {
                clien.ackJobOrder = true;

                if (!serial.sending) {
                    SelectRoute(jsonRead.PayLoad.Data + jsonRead.PayLoad.Data1 + jsonRead.PayLoad.Data2);
                    bgwk_main.ReportProgress(5);
                }

            } else if (jsonRead.Cmd == Clien.Cmd.remoteCF + remoteCF.value) {
                server.receive.remoteCF = true;

            } else if (jsonRead.Cmd == Clien.Cmd.start) {
                server.receive.start = true;

            } else if (jsonRead.Cmd == Clien.Cmd.end) {
                server.receive.end = true;

            } else if (jsonRead.Cmd == Server.Cmd.june) {
                int dataSup;
                dataSup = Convert.ToInt32(jsonRead.PayLoad.Data);
                byte[] intBytes = BitConverter.GetBytes(dataSup);
                serial.tx.data[SeRial.Tx.Index.normalSpeedLow] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.normalSpeedHigh] = intBytes[1];

                dataSup = Convert.ToInt32(jsonRead.PayLoad.Data1);
                intBytes = BitConverter.GetBytes(dataSup);
                serial.tx.data[SeRial.Tx.Index.angleSteppingLow] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.angleSteppingHigh] = intBytes[1];

                byte[] byteSup = new byte[1];
                byteSup = StringToByteArray(jsonRead.PayLoad.Data2);
                serial.tx.data[SeRial.Tx.Index.speedUpTime] = byteSup[0];

                byteSup = StringToByteArray(jsonRead.PayLoad.Data3);
                serial.tx.data[SeRial.Tx.Index.speedUpUnit] = byteSup[0];

                byteSup = StringToByteArray(jsonRead.PayLoad.Data4);
                serial.tx.data[SeRial.Tx.Index.speedDownTime] = byteSup[0];

                byteSup = StringToByteArray(jsonRead.PayLoad.Data5);
                serial.tx.data[SeRial.Tx.Index.speedDownUnit] = byteSup[0];

                byteSup = StringToByteArray(jsonRead.PayLoad.Data6);
                serial.tx.data[SeRial.Tx.Index.liftControl] = byteSup[0];

                dataSup = Convert.ToInt32(jsonRead.PayLoad.Data7);
                intBytes = BitConverter.GetBytes(dataSup);
                serial.tx.data[SeRial.Tx.Index.maximumSpeedLow] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.maximumSpeedHigh] = intBytes[1];

                dataSup = Convert.ToInt32(jsonRead.PayLoad.Data8);
                intBytes = BitConverter.GetBytes(dataSup);
                serial.tx.data[SeRial.Tx.Index.minimumSpeedLow] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.minimumSpeedHigh] = intBytes[1];

                dataSup = Convert.ToInt32(jsonRead.PayLoad.Data9);
                intBytes = BitConverter.GetBytes(dataSup);
                serial.tx.data[SeRial.Tx.Index.pid1LowP] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.pid1HighP] = intBytes[1];

                dataSup = Convert.ToInt32(jsonRead.PayLoad.Data10);
                intBytes = BitConverter.GetBytes(dataSup);
                serial.tx.data[SeRial.Tx.Index.pid1LowI] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.pid1HighI] = intBytes[1];

                dataSup = Convert.ToInt32(jsonRead.PayLoad.Data11);
                intBytes = BitConverter.GetBytes(dataSup);
                serial.tx.data[SeRial.Tx.Index.pid1LowD] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.pid1HighD] = intBytes[1];

                byteSup = StringToByteArray(jsonRead.PayLoad.Data12);
                serial.tx.data[SeRial.Tx.Index.pid1Gain] = byteSup[0];

                dataSup = Convert.ToInt32(jsonRead.PayLoad.Data13);
                intBytes = BitConverter.GetBytes(dataSup);
                serial.tx.data[SeRial.Tx.Index.pidControlTime] = intBytes[0];

                dataSup = Convert.ToInt32(jsonRead.PayLoad.Data14);
                intBytes = BitConverter.GetBytes(dataSup);
                serial.tx.data[SeRial.Tx.Index.melodyVolumnData] = intBytes[0];

                dataSup = Convert.ToInt32(jsonRead.PayLoad.Data15);
                intBytes = BitConverter.GetBytes(dataSup);
                serial.tx.data[SeRial.Tx.Index.pidActivete] = intBytes[0];

            } else if (jsonRead.Cmd == Clien.Cmd.pickedUp) {
                reverse.receive.pickUp = true;

            } else if (jsonRead.Cmd == Clien.Cmd.drop || jsonRead.Cmd == Clien.Cmd.pause) {
                reverse.receive.drop = true;

            } else if (jsonRead.Cmd == Server.Cmd.reSume) {
                reverse.receive.resum = true;
                clien.ackResume = true;

            } else if (jsonRead.Cmd == Clien.Cmd.junction) {
                junction.data = jsonRead.PayLoad.Data + jsonRead.PayLoad.Data1 + jsonRead.PayLoad.Data2;

            } else if (jsonRead.Cmd == Clien.Cmd.errorCode) {
                errorCode.readServer = true;
                sensor.quality.readServer = true;
                sensor.different.readServer = true;

            }

            socketSup.BeginReceive(server.buffer, 0, Server.Define.bufferSize, SocketFlags.None, ReceiveCallback, socketSup);
        }
        private void ClientDisConnect(Socket socket) {
            LogServer(LogMsgType.Incoming_Blue, "\nClient forcefully disconnected");
            IPEndPoint IPEndPoint = socket.RemoteEndPoint as IPEndPoint;
            LogServer(LogMsgType.Incoming_Blue, "\nClient address is " + IPEndPoint.Address.ToString() +
                " port is " + IPEndPoint.Port.ToString());

            socket.Close();
            clien.listSocket.Remove(socket);
        }

        private void LogSendError(Exception e, string json) {
            string path = "D:\\AMR_log_send_err";

            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }

            DateTime now = DateTime.Now;
            StreamWriter swOut = new StreamWriter(path + "\\" + now.Year + "_" + now.Month + ".csv", true);
            swOut.WriteLine(e + "," + json.Replace(",", "$"));
            swOut.Close();
        }

        private void NextStep() {
            route.flagNextStep = false;
            ClearFlagBefore();

            if (ClearEndStep()) {
                return;
            }

            route.dataInColumn = route.dataInRow[route.stepTest].Split(',');
            route.SetNullToZero(route.dataInColumn.Length - 1);
            if (route.dataInColumn.Length != route.csv.length) {
                MessageBox.Show(IndexCSV.lengthError);
                return;
            }
            route.stepTest++;

            if (junction.Check(route.dataInColumn, route)) {
                return;
            }


            int valueSup = 0;
            byte[] intBytes = BitConverter.GetBytes(valueSup);
            byte[] byteSup = new byte[1];

            try {
                byteSup = StringToByteArray(route.dataInColumn[IndexCSV.header1]);
                serial.tx.data[SeRial.Tx.Index.header1] = byteSup[0];
                byteSup = StringToByteArray(route.dataInColumn[IndexCSV.header2]);
                serial.tx.data[SeRial.Tx.Index.header2] = byteSup[0];

                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.lengthData]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.lengthData1] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.lengthData2] = intBytes[1];

                byteSup = StringToByteArray(route.dataInColumn[IndexCSV.command]);
                serial.tx.data[SeRial.Tx.Index.command] = byteSup[0];
                route.csv.command = byteSup[0];
                if (route.csv.command == 0x01 || route.csv.command == 0x02 || route.csv.command == 0x03 || route.csv.command == 0x04 ||
                    route.csv.command == 0x05 || route.csv.command == 0x06) {
                    sensor.different.flag = true;
                }
                if (route.csv.command == 0x03 || route.csv.command == 0x04) {
                    carStatus.pcControlCar = true;
                    calMove.ClearValue();
                    GetPointPast(route.stepTest - 1);
                    GetPointFuture(route.stepTest - 1);
                    //calMove.CalIcc(route.csv.command);
                    calMove.CalAngleStepping(route.csv.command);
                }

                //Skip command 5 6
                //if (route.csv.command == 0x03 || route.csv.command == 0x04) {
                //    carStatus.pcControlCar = true;
                //    if (calMove.flagControlAgain0x04) {
                //        calMove.flagControlAgain0x04 = false;
                //    } else {
                //        calMove.ClearValue();
                //        GetPointPast(route.stepTest - 1);
                //        GetPointFuture(route.stepTest - 1);
                //        //calMove.CalIcc(route.csv.command);
                //        calMove.CalAngleStepping(route.csv.command);
                //    }
                //}
                //Skip command 5 6
                //if (route.csv.command == 0x05 || route.csv.command == 0x06) {
                //    carStatus.pcControlCar = true;
                //    if (calMove.flagControlAgain0x04) {
                //        calMove.flagControlAgain0x04 = false;
                //    } else {
                //        calMove.ClearValue();
                //        GetPointPast(route.stepTest - 1);
                //        GetPointFutureReverse(route.stepTest - 1);
                //        calMove.CalAngleStepping(route.csv.command);
                //    }
                //}

                byteSup = StringToByteArray(route.dataInColumn[IndexCSV.control]);
                serial.tx.data[SeRial.Tx.Index.control] = byteSup[0];
                if (sensor.different.flag) {
                    if (serial.tx.data[SeRial.Tx.Index.control] == 0x01) {
                        sensor.different.axisX = true;
                    }
                    if (serial.tx.data[SeRial.Tx.Index.control] == 0x02) {
                        sensor.different.axisY = true;
                    }
                }

                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.normalSpeed]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.normalSpeedLow] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.normalSpeedHigh] = intBytes[1];

                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.angleStepping]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.angleSteppingLow] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.angleSteppingHigh] = intBytes[1];

                byteSup = StringToByteArray(route.dataInColumn[IndexCSV.speedUpTime]);
                serial.tx.data[SeRial.Tx.Index.speedUpTime] = byteSup[0];
                byteSup = StringToByteArray(route.dataInColumn[IndexCSV.speedUpUnit]);
                serial.tx.data[SeRial.Tx.Index.speedUpUnit] = byteSup[0];
                byteSup = StringToByteArray(route.dataInColumn[IndexCSV.speedDownTime]);
                serial.tx.data[SeRial.Tx.Index.speedDownTime] = byteSup[0];
                byteSup = StringToByteArray(route.dataInColumn[IndexCSV.speedDownUnit]);
                serial.tx.data[SeRial.Tx.Index.speedDownUnit] = byteSup[0];

                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.liftControl]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.liftControl] = intBytes[0];
                int levelForkCurrent = Convert.ToInt32(carStatus.lavelFork);
                int levelForkNew = Convert.ToInt32(intBytes[0]);
                int calFork = levelForkCurrent - levelForkNew;
                if (calFork > 0) {
                    carStatus.flagForkDown = true;
                    carStatus.lavelFork = levelForkNew;
                }
                if (calFork < 0) {
                    carStatus.flagForkUp = true;
                    carStatus.lavelFork = levelForkNew;
                }

                byteSup = StringToByteArray(route.dataInColumn[IndexCSV.specialFlag]);
                if (carStatus.reverseCSVHook) {
                    bool[] reverseCSVHookSup = ByteToBoolArray(byteSup[0]);
                    if (reverseCSVHookSup[1]) byteSup[0] &= Convert.ToByte("11111011", 2);
                    else byteSup[0] |= Convert.ToByte("000001100", 2);
                }
                serial.tx.data[SeRial.Tx.Index.specialFlag] = byteSup[0];

                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.maxSpeed]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.maximumSpeedLow] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.maximumSpeedHigh] = intBytes[1];
                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.minSpeed]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.minimumSpeedLow] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.minimumSpeedHigh] = intBytes[1];

                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.targetX]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.targetPositionLowX1] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.targetPositionLowX2] = intBytes[1];
                serial.tx.data[SeRial.Tx.Index.targetPositionHighX1] = intBytes[2];
                serial.tx.data[SeRial.Tx.Index.targetPositionHighX2] = intBytes[3];
                route.csv.targetPositionX = valueSup;
                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.targetY]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.targetPositionLowY1] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.targetPositionLowY2] = intBytes[1];
                serial.tx.data[SeRial.Tx.Index.targetPositionHighY1] = intBytes[2];
                serial.tx.data[SeRial.Tx.Index.targetPositionHighY2] = intBytes[3];
                route.csv.targetPositionY = valueSup;
                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.targetYW]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.targetAngleLow1] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.targetAngleLow2] = intBytes[1];
                serial.tx.data[SeRial.Tx.Index.targetAngleHigh1] = intBytes[2];
                serial.tx.data[SeRial.Tx.Index.targetAngleHigh2] = intBytes[3];

                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.pidP]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.pid1LowP] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.pid1HighP] = intBytes[1];
                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.pidI]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.pid1LowI] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.pid1HighI] = intBytes[1];
                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.pidD]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.pid1LowD] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.pid1HighD] = intBytes[1];
                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.pidGain]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.pid1Gain] = intBytes[0];

                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.pidControlTime]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.pidControlTime] = intBytes[0];
                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.volumeMelody]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.melodyVolumnData] = intBytes[0];
                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.pidActivateErrorValue]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.pidActivete] = intBytes[0];

                route.csv.condition = route.dataInColumn[IndexCSV.condition];
                route.csv.endCommand = Convert.ToInt32(route.dataInColumn[IndexCSV.endCommand]);
                sensor.angle.controlLow = false;
                sensor.angle.controlHigh = false;
                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.targetEndCommand]);
                route.csv.endCommandTarget = valueSup;

                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.traffic]);
                if (valueSup > 0) {
                    redLight.SelectStatus(valueSup);
                }

                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.remoteCF]);
                if (valueSup >= 1 && valueSup <= 20) {
                    remoteCF.value = valueSup;
                    remoteCF.flag = true;
                    string[] zxdf = File.ReadAllLines(route.pathSensorConfig);
                    zxdf[0] = (100 + remoteCF.value).ToString();
                    File.WriteAllLines(route.pathSensorConfig, zxdf);
                }

                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.reveres]);
                reverse.value = valueSup;
                if (reverse.value != 0) {
                    reverse.stopFlag = true;
                    reverse.resum.value = 0;
                    reverse.receive.pickUp = false;
                    reverse.receive.drop = false;
                    reverse.receive.resum = false;
                    reverse.value3To50 = false;
                    reverse.nextStep = false;
                    reverse.value5To50 = false;
                    if (reverse.value >= 3 && reverse.value <= 50) {
                        if (reverse.value >= 5 && reverse.value <= 50)
                            reverse.value5To50 = true;
                        reverse.value3To50 = true;
                    }
                    string[] zxdf = File.ReadAllLines(route.pathSensorConfig);
                    zxdf[0] = reverse.value.ToString();
                    File.WriteAllLines(route.pathSensorConfig, zxdf);
                } else {
                    reverse.stopFlag = false;
                }

                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.delay]);
                if (valueSup > 0) {
                    route.csv.delayFlag = true;
                    tm_delay_csv.Interval = valueSup * 1000;
                    tm_delay_csv.Enabled = true;
                }

                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.pidSupP_free]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.pid2LowP] = intBytes[0];
                serial.tx.data[SeRial.Tx.Index.pid2HighP] = intBytes[1];
                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.pidSupI_free]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.pid2LowI] = intBytes[0];
                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.areaSensorFront]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.areaSensorFront] = intBytes[0];
                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.areaSensorRight]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.areaSensorRight] = intBytes[0];
                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.areaSensorLeft]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.areaSensorLeft] = intBytes[0];

                valueSup = Convert.ToInt32(route.dataInColumn[IndexCSV.pidHighGain]);
                intBytes = BitConverter.GetBytes(valueSup);
                serial.tx.data[SeRial.Tx.Index.pid2Gain] = intBytes[0];

                route.mapRoute.number = route.dataInColumn[IndexCSV.mapRoute];
                route.mapRoute.name = route.mapRoute.GetNameRoute(route.stepTest - 1);

            } catch {
                route.csv.flagError = true;
                MessageBox.Show(IndexCSV.dataErr + route.csv.route + IndexCSV.dataErr2 + (route.stepTest - 1));
            }
        }
        private bool ClearEndStep() {
            if (route.stepTest == route.dataInRow.Count) {
                serial.sending = false;
                ButtonClearColor();
                server.endProcess = true;
                serial.melody.enable(this);
                server.receive.start = false;
                server.receive.end = false;

                return true;
            }

            return false;
        }
        private void ClearFlagBefore() {
            sensor.different.flag = false;
            sensor.different.axisX = false;
            sensor.different.axisY = false;
            carStatus.pcControlCar = false;
        }
        private void GetPointPast(int rowStep) {
            //byte[] byteSup = new byte[1];
            //string[] dataPast = route.dataInRow[rowStep - 1].Split(',');

            //byteSup = StringToByteArray(dataPast[IndexCSV.control]);
            //if (byteSup[0] == 0x04) {
            //    GetPointPast(rowStep - 1);
            //    return;

            //} else {
            //    if (byteSup[0] == 0x01) {
            //        calMove.currentX = Convert.ToInt32(dataPast[IndexCSV.targetX]);
            //    }

            //    if (byteSup[0] == 0x02) {
            //        calMove.currentY = Convert.ToInt32(dataPast[IndexCSV.targetY]);
            //    }

            //    if (byteSup[0] == 0x03) {

            //    }
            //}

            //byteSup = StringToByteArray(dataPast[IndexCSV.endCommand]);
            //if (byteSup[0] == 0x01) {
            //    calMove.currentX = Convert.ToInt32(dataPast[IndexCSV.targetEndCommand]);
            //}

            //if (byteSup[0] == 0x02) {
            //    calMove.currentY = Convert.ToInt32(dataPast[IndexCSV.targetEndCommand]);
            //}

            //if (byteSup[0] == 0x03) {

            //}

            calMove.currentX = sensor.X;
            calMove.currentY = sensor.Y;

            if (sensor.angle.value > -45000 && sensor.angle.value <= 45000) {
                calMove.currentAngle = 0;

            } else if (sensor.angle.value > 45000 && sensor.angle.value <= 135000) {
                calMove.currentAngle = 90;

            } else if ((sensor.angle.value > 135000 && sensor.angle.value <= 180000) ||
                       (sensor.angle.value > -180000 && sensor.angle.value <= -135000)) {
                calMove.currentAngle = 180;

            } else {
                calMove.currentAngle = -90;
            }
        }
        private void GetPointFuture(int rowStep) {
            byte[] byteSup = new byte[1];
            string[] dataPast = route.dataInRow[rowStep + 1].Split(',');

            byteSup = StringToByteArray(dataPast[IndexCSV.control]);
            if (byteSup[0] == 0x04) {
                //Skip command 5 6
                //calMove.flagControlAgain0x04 = true;
                //GetPointFuture2(rowStep + 1);

                GetPointFuture(rowStep + 1);
                return;

            } else {
                if (byteSup[0] == 0x01) {
                    calMove.targetX = Convert.ToInt32(dataPast[IndexCSV.targetX]);

                    if (calMove.currentAngle == 0) {
                        calMove.calRSup = calMove.targetX - calMove.currentX;

                    } else {
                        calMove.calRSup = calMove.currentX - calMove.targetX;
                    }
                }

                if (byteSup[0] == 0x02) {
                    calMove.targetY = Convert.ToInt32(dataPast[IndexCSV.targetY]);

                    if (calMove.currentAngle == 90) {
                        calMove.calRSup = calMove.targetY - calMove.currentY;

                    } else {
                        calMove.calRSup = calMove.currentY - calMove.targetY;
                    }
                }

                if (byteSup[0] == 0x03) {

                }
            }

            calMove.calR = calMove.calRSup + calMove.lengthCar;

            if (calMove.calR < 0) {
                calMove.calR = 0;
            }
        }
        private void GetPointFuture2(int rowStep) {
            byte[] byteSup = new byte[1];
            string[] dataPast = route.dataInRow[rowStep + 1].Split(',');

            byteSup = StringToByteArray(dataPast[IndexCSV.control]);
            if (byteSup[0] == 0x04) {
                route.csv.flagError = true;
                MessageBox.Show("Control = 0x04 more than 2 times.");
                return;

            } else {
                if (byteSup[0] == 0x01) {
                    calMove.targetX = Convert.ToInt32(dataPast[IndexCSV.targetX]);
                    calMove.calRSup = Math.Abs(calMove.targetX - calMove.currentX);
                }

                if (byteSup[0] == 0x02) {
                    calMove.targetY = Convert.ToInt32(dataPast[IndexCSV.targetY]);
                    calMove.calRSup = Math.Abs(calMove.targetY - calMove.currentY);
                }

                if (byteSup[0] == 0x03) {

                }
            }

            calMove.calR = calMove.calRSup;
        }
        private void GetPointFutureReverse(int rowStep) {
            byte[] byteSup = new byte[1];
            string[] dataPast = route.dataInRow[rowStep + 1].Split(',');

            byteSup = StringToByteArray(dataPast[IndexCSV.control]);
            if (byteSup[0] == 0x04) {
                calMove.flagControlAgain0x04 = true;
                GetPointFutureReverse2(rowStep + 1);
                return;

            } else {
                if (byteSup[0] == 0x01) {
                    calMove.targetX = Convert.ToInt32(dataPast[IndexCSV.targetX]);
                    calMove.calRSup = Math.Abs(calMove.targetX - calMove.currentX);
                }

                if (byteSup[0] == 0x02) {
                    calMove.targetY = Convert.ToInt32(dataPast[IndexCSV.targetY]);
                    calMove.calRSup = Math.Abs(calMove.targetY - calMove.currentY);
                }

                if (byteSup[0] == 0x03) {

                }
            }

            calMove.calR = calMove.calRSup - calMove.lengthCar;
        }
        private void GetPointFutureReverse2(int rowStep) {
            byte[] byteSup = new byte[1];
            string[] dataPast = route.dataInRow[rowStep + 1].Split(',');

            byteSup = StringToByteArray(dataPast[IndexCSV.control]);
            if (byteSup[0] == 0x04) {
                route.csv.flagError = true;
                MessageBox.Show("Control = 0x04 more than 2 times.");
                return;

            } else {
                if (byteSup[0] == 0x01) {
                    calMove.targetX = Convert.ToInt32(dataPast[IndexCSV.targetX]);
                    calMove.calRSup = Math.Abs(calMove.targetX - calMove.currentX);
                }

                if (byteSup[0] == 0x02) {
                    calMove.targetY = Convert.ToInt32(dataPast[IndexCSV.targetY]);
                    calMove.calRSup = Math.Abs(calMove.targetY - calMove.currentY);
                }

                if (byteSup[0] == 0x03) {

                }
            }

            calMove.calR = calMove.calRSup;
        }
        #endregion

        #region ========================================================== Event ===========================================================
        private void Form1_Load(object sender, EventArgs e) {
            tm_close.Interval = 60000 * 40;
            tm_close.Enabled = true;

            lb_AGV.Text = route.agvNo;

            serial.Connect(this);
            tb_ip.Text = sensor.ip;
            tb_port.Text = sensor.port.ToString();
            ButtonClearColor();

            lb_melody.Text = serial.melody.value.ToString();
            bgwk_main.RunWorkerAsync();

            if (!SensorConfig()) {
                MessageBox.Show("server err");
                return;
            }

            ButtonStartSup();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            try {
                bgwk_sensor.Dispose();
            } catch { }

            try {
                bgwk_serial.Dispose();
            } catch { }

            try {
                bgwk_main.Dispose();
            } catch { }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (formCloseMessageBox) {
                return;
            }

            DialogResult dialogResult = MessageBox.Show("_กรุณายืนยันการปิดโปรแกรม", "Close Form", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) {
                e.Cancel = true;
                return;
            }

            cameraRL.CameraCloseExe();
            cameraRL.CameraCloseBat();
            ClearWaitWhileLoop();
        }

        private void bt_start_Click(object sender, EventArgs e) {
            buttonStartBlock = true;
            ButtonClearColor();
            ButtonStartSup();
            bt_start.Enabled = false;
            bt_manual.Enabled = true;
            buttonStartBlock = false;
        }
        private void bt_stop_Click(object sender, EventArgs e) {
            serial.sending = false;
            ButtonClearColor();
            bt_start.Text = Define.auto;
            serial.melody.enable(this);
            bt_start.Enabled = true;
            PreparationClear();
        }
        private void bt_manual_Click(object sender, EventArgs e) {
            if (!ButtonManual()) {
                return;
            }

            ButtonClearColor();
            bt_manual.BackColor = Color.Lime;
            bt_start.Enabled = true;
            bt_manual.Enabled = false;
            PreparationClear();
        }
        private void bt_forkLevel0_Click(object sender, EventArgs e) {
            if (!ButtonManualSup(0x01)) {
                return;
            }

            ButtonClearColor();
            bt_forkLevel0.BackColor = Color.Lime;
        }
        private void bt_forkLevel1_Click(object sender, EventArgs e) {
            if (!ButtonManualSup(0x02)) {
                return;
            }

            ButtonClearColor();
            bt_forkLevel1.BackColor = Color.Lime;
        }
        private void bt_forkLevel2_Click(object sender, EventArgs e) {
            if (!ButtonManualSup(0x03)) {
                return;
            }

            ButtonClearColor();
            bt_forkLevel2.BackColor = Color.Lime;
        }
        private void bt_preparation_Click(object sender, EventArgs e) {
            if (!preparationFlag) {
                return;
            }

            bt_preparation.BackColor = Color.Lime;
            preparationFlag = false;
        }

        public void EmerEventClick(object sender, EventArgs e) {
            EmerEventClickSup();
        }
        public void EmerEventClickSup() {
            if (carStatus.keyExtInputLow[CarStatus.IndexExtLow.emergency] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperWingL] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperSideR] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperSideL] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperFront] |
                carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperWingR]) {
                MessageBox.Show(Emer.Text.error);
                return;
            }

            emer.form.Close();
            emer.form.Dispose();
            emer.form = null;
            emer.lockOffSpeed = false;
            cb_melody.Checked = false;
            serial.melody.disable(this);
        }
        public void ReverseEventClick(object sender, EventArgs e) {
            ReverseEventClickSup();
        }
        private void ReverseEventClickSup() {
            if (!carStatus.keyInputHigh[CarStatus.IndexHigh.rollDetect]) {
                MessageBox.Show(Reverse.Text.errorCart);
                return;
            }

            reverse.form.Close();
            reverse.form.Dispose();
            reverse.form = null;
            reverse.formFlag = false;
        }

        private void bt_unlockStart_Click(object sender, EventArgs e) {

        }
        private void bt_unlockPause_Click(object sender, EventArgs e) {

        }
        private void bt_unlockResume_Click(object sender, EventArgs e) {

        }
        private void bt_unlockCF1_Click(object sender, EventArgs e) {

        }
        private void bt_unlockPickedup_Click(object sender, EventArgs e) {

        }
        private void bt_unlockDrop_Click(object sender, EventArgs e) {

        }
        private void bt_unlockEnd_Click(object sender, EventArgs e) {

        }
        private void bt_unlockCF2_Click(object sender, EventArgs e) {

        }

        private void bt_minus_Click(object sender, EventArgs e) {
            if (serial.melody.value == SeRial.Melody.min) {
                serial.melody.value = SeRial.Melody.min;
            } else {
                serial.melody.value--;
            }

            if (serial.sending) {
                lb_melody.Text = serial.melody.value.ToString();
                cb_melody.Checked = true;
                return;
            }

            Stopwatch time = new Stopwatch();
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            serial.rx.data.Clear();

            byte[] send_data = new byte[serial.tx.length];
            send_data[SeRial.Tx.Index.header1] = 0xAA;
            send_data[SeRial.Tx.Index.header2] = 0x55;
            send_data[SeRial.Tx.Index.lengthData1] = 0x2F;
            send_data[SeRial.Tx.Index.lengthData2] = 0x00;
            send_data[SeRial.Tx.Index.command] = 0xAA;
            send_data[SeRial.Tx.Index.specialFlag] = 128 + 64;
            send_data[SeRial.Tx.Index.melodyVolumnData] = Convert.ToByte(serial.melody.value);

            serial.rx.readed = false;
            try { serialPort1.Write(send_data, 0, send_data.Length); } catch {
                LogSerial(LogMsgType.Error_Red, SeRial.Tx.Define.sendError);
                LabelSerialTx(LogMsgType.Error_Red, SeRial.Tx.Define.sendError);
                return;
            }

            LogSerial(LogMsgType.Incoming_Blue, SeRial.Tx.Define.send + send_data);
            LabelSerialTx(LogMsgType.Incoming_Blue, SeRial.Tx.Define.send + send_data);
            time.Restart();
            while (time.ElapsedMilliseconds < 1500) {
                if (!serial.rx.readed) {
                    Thread.Sleep(100);
                    continue;
                }

                serial.rx.readed = false;
                time.Stop();
                break;
            }

            if (time.IsRunning) {
                LogSerial(LogMsgType.Warning_Orange, SeRial.Rx.Define.readError);
                LabelSerialRx(LogMsgType.Warning_Orange, SeRial.Rx.Define.readError);
                return;
            }
        }
        private void bt_plus_Click(object sender, EventArgs e) {
            if (serial.melody.value == SeRial.Melody.max) {
                serial.melody.value = SeRial.Melody.max;

            } else {
                serial.melody.value++;
            }

            if (serial.sending) {
                lb_melody.Text = serial.melody.value.ToString();
                cb_melody.Checked = true;
                return;
            }

            Stopwatch time = new Stopwatch();
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            serial.rx.data.Clear();

            byte[] send_data = new byte[62];
            send_data[SeRial.Tx.Index.header1] = 0xAA;
            send_data[SeRial.Tx.Index.header2] = 0x55;
            send_data[SeRial.Tx.Index.lengthData1] = 0x2F;
            send_data[SeRial.Tx.Index.lengthData2] = 0x00;
            send_data[SeRial.Tx.Index.command] = 0xAA;
            send_data[SeRial.Tx.Index.specialFlag] = 128 + 64;
            send_data[SeRial.Tx.Index.melodyVolumnData] = Convert.ToByte(serial.melody.value);
            serial.rx.readed = false;

            try {
                serialPort1.Write(send_data, 0, send_data.Length);
            } catch {
                LogSerial(LogMsgType.Error_Red, SeRial.Tx.Define.sendError);
                LabelSerialTx(LogMsgType.Error_Red, SeRial.Tx.Define.sendError);
                return;
            }

            LogSerial(LogMsgType.Incoming_Blue, SeRial.Tx.Define.send + send_data);
            LabelSerialTx(LogMsgType.Incoming_Blue, SeRial.Tx.Define.send + send_data);
            time.Restart();
            while (time.ElapsedMilliseconds < 1500) {
                if (serial.rx.readed != true) {
                    Thread.Sleep(100);
                    continue;
                }

                serial.rx.readed = false;
                time.Stop();
                break;
            }

            if (time.IsRunning) {
                LogSerial(LogMsgType.Warning_Orange, SeRial.Rx.Define.readError);
                LabelSerialRx(LogMsgType.Warning_Orange, SeRial.Rx.Define.readError);
                return;
            }
        }
        private void bt_melody_send_Click(object sender, EventArgs e) {
            setupPay.write_text(serial.headConfig.melodyValue, serial.melody.value.ToString(), serial.nameFile);
        }

        private void tm_delay_csv_Tick(object sender, EventArgs e) {
            tm_delay_csv.Enabled = false;
            route.csv.delayFlag = false;
        }
        private void tm_close_Tick(object sender, EventArgs e) {
            tm_close_flag = true;
            tm_close.Enabled = false;
        }

        private void bt_focusPos_Click(object sender, EventArgs e) {
            sensor.flagFocusPos = true;
        }
        private void bt_unFocusPos_Click(object sender, EventArgs e) {
            sensor.flagFocusPos = false;
        }
        #endregion

        #region ========================================================== Process ===========================================================
        private void SerialPort(object sender, EventArgs e) {
            //Edit send serial always
            //if (!serial.sending) return;
            
            tm_send_data.Enabled = false;

            byte[] dataSend = serial.tx.data.ToArray();

            #region =================================== Auto ===========================================
            if (serial.tx.mode == SeRial.Tx.Define.auto) {
                carStatus.offSpeedFlag = carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanFrontMalfunction] |
                    carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanFrontStop] |
                    carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanSideMalfunctionR] |
                    carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanSideStopR] |
                    carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanSideMalfunctionL] |
                    carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.scanSideStopL] |
                    redLight.csvFlag | remoteCF.flag | reverse.formFlag | route.csv.delayFlag | route.csv.flagError |
                    reverse.value5To50 | reverse.resum.wait | junction.running | sensor.quality.flag |
                    sensor.different.formOpen | cameraRL.offSpeed | carStatus.flagForkUp | carStatus.flagForkDown |
                    preparationFlag | ((cameraRL.flagDepthRoll | cameraRL.flagLockDetectCam) & reverse.stopFlag) | 
                    cameraRL.flagEndPosition;

                emer.speedError = carStatus.keyExtInputLow[CarStatus.IndexExtLow.emergency] |
                    carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperWingL] |
                    carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperSideR] |
                    carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperSideL] |
                    carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperFront] |
                    carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperWingR];

                #region =================================== Control Speed ===========================================
                if (carStatus.keyExtInputLow[CarStatus.IndexExtLow.scanFrontWarning]) {
                    byte[] speedDownRightByte = new byte[2];
                    byte[] speedDownLiftByte = new byte[2];
                    speedDownRightByte[0] = dataSend[SeRial.Tx.Index.normalSpeedLow];
                    speedDownRightByte[1] = dataSend[SeRial.Tx.Index.normalSpeedHigh];
                    Int16 speedRightInt = BitConverter.ToInt16(speedDownRightByte, 0);
                    Int16 speedLiftInt = BitConverter.ToInt16(speedDownLiftByte, 0);
                    if (route.csv.command == 0x01 || route.csv.command == 0x02) {
                        if (speedRightInt < serial.speedMax) {
                            byte[] speedBalance = BitConverter.GetBytes(speedRightInt);
                            dataSend[SeRial.Tx.Index.normalSpeedLow] = speedBalance[0];
                            dataSend[SeRial.Tx.Index.normalSpeedHigh] = speedBalance[1];
                        } else {
                            speedRightInt = Convert.ToInt16(serial.speedMax);
                            speedLiftInt = speedRightInt;
                            byte[] speedRightByte = BitConverter.GetBytes(speedRightInt);
                            dataSend[SeRial.Tx.Index.normalSpeedLow] = speedRightByte[1];
                            dataSend[SeRial.Tx.Index.normalSpeedHigh] = speedRightByte[0];
                            byte[] speedDownTime = BitConverter.GetBytes(serial.speedDownTime);
                            byte[] speedDownUnit = BitConverter.GetBytes(serial.speedDownUnit);
                            dataSend[SeRial.Tx.Index.speedDownTime] = speedDownTime[0];
                            dataSend[SeRial.Tx.Index.speedDownUnit] = speedDownUnit[0];
                        }
                    } else {
                        double speedSlow = speedRightInt * serial.speedSlowFactor;
                        speedRightInt = Convert.ToInt16(speedSlow);
                        speedSlow = speedLiftInt * serial.speedSlowFactor;
                        speedLiftInt = Convert.ToInt16(speedSlow);
                    }
                    byte[] speedAdjust = BitConverter.GetBytes(speedRightInt);
                    dataSend[SeRial.Tx.Index.normalSpeedLow] = speedAdjust[0];
                    dataSend[SeRial.Tx.Index.normalSpeedHigh] = speedAdjust[1];
                    speedAdjust = BitConverter.GetBytes(speedLiftInt);
                }
                #endregion

                SerialPortCalMoveCar(dataSend);

                if (cb_melody.Checked) {
                    dataSend[SeRial.Tx.Index.specialFlag] |= Convert.ToByte("11000000", 2);
                }
                if (!serial.rx.CheckBatMax()) {
                    dataSend[SeRial.Tx.Index.specialFlag] &= Convert.ToByte("11111011", 2);
                }

                //Check fork level status from serial rx to set flagFork
                CheckLevelForkToOnSpeed(dataSend[SeRial.Tx.Index.liftControl]);

                //Check reverse csv to set liftControl in serial tx
                dataSend[SeRial.Tx.Index.liftControl] = route.csv.CheckReverseToLiftControl(carStatus.lavelFork, reverse.value,
                                                        dataSend[SeRial.Tx.Index.liftControl]);

                //Check emer and bumper to set flag preparation
                PreparationCheck();

                //Set lamp follow status
                dataSend[SeRial.Tx.Index.pid2LowI] |= LampDisplay();

                if (cameraRL.offSpeed) {
                    dataSend[SeRial.Tx.Index.speedUpTime] = 0x00;
                    dataSend[SeRial.Tx.Index.speedUpUnit] = 0x00;
                    dataSend[SeRial.Tx.Index.speedDownTime] = 0x00;
                    dataSend[SeRial.Tx.Index.speedDownUnit] = 0x00;
                }
                if (carStatus.offSpeedFlag || emer.lockOffSpeed) {
                    dataSend[SeRial.Tx.Index.normalSpeedLow] = 0x00;
                    dataSend[SeRial.Tx.Index.normalSpeedHigh] = 0x00;
                    //dataSend[SeRial.Tx.Index.normalSpeedLeftLow] = 0x00;
                    //dataSend[SeRial.Tx.Index.normalSpeedLeftHigh] = 0x00;
                }
                if (emer.speedError && !emer.lockOffSpeed) {
                    emer.lockOffSpeed = true;
                    emer.SetupForm(this);
                }
                if (emer.lockOffSpeed && carStatus.keyInputLow[CarStatus.IndexLow.start]) {
                    EmerEventClickSup();
                }

                #region =================================== Get Sensor ===========================================
                byte[] intBytes = new Byte[1];

                if (sensor.flagFocusPos) {
                    intBytes = BitConverter.GetBytes(Convert.ToInt32(tb_xPos.Text));
                    dataSend[SeRial.Tx.Index.currentPositionLowX1] = intBytes[0];
                    dataSend[SeRial.Tx.Index.currentPositionLowX2] = intBytes[1];
                    dataSend[SeRial.Tx.Index.currentPositionHighX1] = intBytes[2];
                    dataSend[SeRial.Tx.Index.currentPositionHighX2] = intBytes[3];
                    intBytes = BitConverter.GetBytes(Convert.ToInt32(tb_yPos.Text));
                    dataSend[SeRial.Tx.Index.currentPositionLowY1] = intBytes[0];
                    dataSend[SeRial.Tx.Index.currentPositionLowY2] = intBytes[1];
                    dataSend[SeRial.Tx.Index.currentPositionHighY1] = intBytes[2];
                    dataSend[SeRial.Tx.Index.currentPositionHighY2] = intBytes[3];
                    intBytes = BitConverter.GetBytes(Convert.ToInt32(tb_anglePos.Text));
                    dataSend[SeRial.Tx.Index.currentAngleLow1] = intBytes[0];
                    dataSend[SeRial.Tx.Index.currentAngleLow2] = intBytes[1];
                    dataSend[SeRial.Tx.Index.currentAngleHigh1] = intBytes[2];
                    dataSend[SeRial.Tx.Index.currentAngleHigh2] = intBytes[3];

                } else {
                    intBytes = BitConverter.GetBytes(sensor.newX);
                    dataSend[SeRial.Tx.Index.currentPositionLowX1] = intBytes[0];
                    dataSend[SeRial.Tx.Index.currentPositionLowX2] = intBytes[1];
                    dataSend[SeRial.Tx.Index.currentPositionHighX1] = intBytes[2];
                    dataSend[SeRial.Tx.Index.currentPositionHighX2] = intBytes[3];
                    intBytes = BitConverter.GetBytes(sensor.newY);
                    dataSend[SeRial.Tx.Index.currentPositionLowY1] = intBytes[0];
                    dataSend[SeRial.Tx.Index.currentPositionLowY2] = intBytes[1];
                    dataSend[SeRial.Tx.Index.currentPositionHighY1] = intBytes[2];
                    dataSend[SeRial.Tx.Index.currentPositionHighY2] = intBytes[3];
                    intBytes = BitConverter.GetBytes(sensor.angle.value);
                    dataSend[SeRial.Tx.Index.currentAngleLow1] = intBytes[0];
                    dataSend[SeRial.Tx.Index.currentAngleLow2] = intBytes[1];
                    dataSend[SeRial.Tx.Index.currentAngleHigh1] = intBytes[2];
                    dataSend[SeRial.Tx.Index.currentAngleHigh2] = intBytes[3];
                }

                if (sensor.different.axisX) {
                    sensor.different.value = Math.Abs(sensor.newX - route.csv.targetPositionX);
                    if (sensor.different.value > sensor.different.lidarX && !sensor.different.formOpen) {
                        sensor.different.Setup();
                    }
                }
                if (sensor.different.axisY) {
                    sensor.different.value = Math.Abs(sensor.newY - route.csv.targetPositionY);
                    if (sensor.different.value > sensor.different.lidarY && !sensor.different.formOpen) {
                        sensor.different.Setup();
                    }
                }
                if (sensor.different.formOpen && carStatus.keyInputLow[CarStatus.IndexLow.reset]) {
                    sensor.different.DifferentClickSup();
                }
                #endregion

                dataSend[SeRial.Tx.Index.melodyVolumnData] = Convert.ToByte(serial.melody.value);

                #region =================================== Reverse ===========================================
                if (reverse.formFlag) {
                    reverse.SetupForm(this);
                    if (carStatus.keyInputLow[CarStatus.IndexLow.start]) {
                        ReverseEventClickSup();
                    }
                }
                #endregion

                if (errorCode.flagOpen && carStatus.keyInputLow[CarStatus.IndexLow.reset]) {
                    errorCode.ResetClickSup();
                }
                if (sensor.quality.flag && carStatus.keyInputLow[CarStatus.IndexLow.reset]) {
                    sensor.quality.QualityClickSup();
                }
                if (errorCode.click || errorCode.clickAgainNum <= errorCode.clickAgain) {
                    errorCode.click = false;
                    errorCode.clickAgainNum++;
                    dataSend[SeRial.Tx.Index.specialFlag] |= errorCode.byte_;
                }

                dataSend[SeRial.Tx.Index.pid2LowP] = MelodyCheckSend();
                dataSend[SeRial.Tx.Index.checkSum] = serial.tx.CheckSum(dataSend);

                #region =================================== Send ===========================================
                Stopwatch timeOut = new Stopwatch();
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
                serial.rx.data.Clear();
                serial.rx.readed = false;
                try {
                    serialPort1.Write(dataSend, 0, dataSend.Length);
                } catch {
                    LogSerial(LogMsgType.Error_Red, SeRial.Tx.Define.sendError);
                    LabelSerialTx(LogMsgType.Error_Red, SeRial.Tx.Define.sendError);
                    tm_send_data.Enabled = true;
                    return;
                }

                string[] data_sup = ByteArrayToString(dataSend);
                string sendSerial = string.Empty;
                foreach (string splitData in data_sup) {
                    sendSerial += splitData;
                }
                lb_step.Text = "Step = " + (route.stepTest);
                LogSerial(LogMsgType.Incoming_Blue, SeRial.Tx.Define.send + sendSerial);
                LabelSerialTx(LogMsgType.Incoming_Blue, SeRial.Tx.Define.send + sendSerial);
                #endregion

                #region =================================== Wait Read ===========================================
                timeOut.Restart();
                while (timeOut.ElapsedMilliseconds < 1500) {
                    if (serial.rx.readed != true) { Thread.Sleep(10); continue; }
                    serial.rx.readed = false;
                    timeOut.Stop();
                    break;
                }
                if (timeOut.IsRunning) {
                    LogSerial(LogMsgType.Warning_Orange, SeRial.Rx.Define.readError);
                    LabelSerialRx(LogMsgType.Warning_Orange, SeRial.Rx.Define.readError);
                    tm_send_data.Enabled = true;
                    return;
                }
                #endregion
            }
            #endregion

            #region =================================== Manual ===========================================
            else {
                Stopwatch timeOut = new Stopwatch();
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
                serial.rx.data.Clear();
                byte[] dataSendManual = serial.tx.dataManual.ToArray();

                //Check emer and bumper to set flag preparation
                PreparationCheck();

                //Set lamp follow status
                dataSendManual[SeRial.Tx.Index.pid2LowI] |= LampDisplay();

                dataSendManual[SeRial.Tx.Index.checkSum] = serial.tx.CheckSum(dataSendManual);
                serial.rx.readed = false;
                try {
                    serialPort1.Write(dataSendManual, 0, dataSendManual.Length);
                } catch {
                    LogSerial(LogMsgType.Error_Red, SeRial.Tx.Define.sendError);
                    LabelSerialTx(LogMsgType.Error_Red, SeRial.Tx.Define.sendError);
                    tm_send_data.Enabled = true;
                    return;
                }
                LogSerial(LogMsgType.Incoming_Blue, SeRial.Tx.Define.send + serial.tx.manualShow);
                LabelSerialTx(LogMsgType.Incoming_Blue, SeRial.Tx.Define.send + serial.tx.manualShow);
                timeOut.Restart();
                while (timeOut.ElapsedMilliseconds < 1500) {
                    if (serial.rx.readed != true) {
                        Thread.Sleep(100);
                        continue;
                    }
                    serial.rx.readed = false;
                    timeOut.Stop();
                    break;
                }
                if (timeOut.IsRunning) {
                    LogSerial(LogMsgType.Warning_Orange, SeRial.Rx.Define.readError);
                    LabelSerialRx(LogMsgType.Warning_Orange, SeRial.Rx.Define.readError);
                    tm_send_data.Enabled = true;
                    return;
                }
            }
            #endregion

            lb_normalSpeed.Text = carStatus.GetSpeed(dataSend[SeRial.Tx.Index.normalSpeedLow],
                dataSend[SeRial.Tx.Index.normalSpeedHigh]);
            lb_angleStepping.Text = Convert.ToInt16(calMove.angleStepping).ToString();

            string rxResultSup = string.Empty;
            if (serial.rx.data.Count != 0) {
                try {
                    foreach (byte rxSup in serial.rx.data) {
                        rxResultSup += rxSup.ToString("X2");
                    }
                } catch { }
            }

            #region =================================== Rx CheckSum ===========================================
            if (serial.rx.data.Count == SeRial.Rx.Index.checkSum + 1) {
                if (rxResultSup.Substring(0, 4) == "AA55" && serial.rx.CheckSum()) {
                    LogSerial(LogMsgType.Warning_Orange, SeRial.Rx.Define.read + rxResultSup);
                    LabelSerialRx(LogMsgType.Warning_Orange, SeRial.Rx.Define.read + rxResultSup);
                    StatusUpdateInternal();
                    StatusUpdateExternal();

                    string errorHead = serial.rx.data[SeRial.Rx.Index.errorCodeHigh].ToString("X2") +
                        serial.rx.data[SeRial.Rx.Index.errorCodeLow].ToString("X2");
                    string errorDetail = serial.rx.data[SeRial.Rx.Index.errorDetailHigh].ToString("X2") +
                        serial.rx.data[SeRial.Rx.Index.errorDetailLow].ToString("X2");
                    errorCode.Check(errorHead, errorDetail);

                    lb_NormalSpeedCurrent.Text = carStatus.GetSpeedByInt(serial.rx.data[SeRial.Rx.Index.currentSpeedRightLow],
                        serial.rx.data[SeRial.Rx.Index.currentSpeedRightHigh]);
                    lb_angleSteppingCurrent.Text = carStatus.GetSpeedByInt(serial.rx.data[SeRial.Rx.Index.currentSpeedLeftLow],
                        serial.rx.data[SeRial.Rx.Index.currentSpeedLeftHigh]);
                    lb_speedSum.Text = carStatus.GetSpeedSum();

                    lb_angleStep.Text = serial.rx.GetAngleStep().ToString();
                    lb_errorSup.Text = serial.rx.GetErrorSup();

                    if (!serial.rx.SklipCheckBat()) {
                        serial.rx.voltBat = serial.rx.GetVoltBat();
                        serial.rx.voltBatPercen = serial.rx.data[SeRial.Rx.Index.voltBatPercen];
                        lb_battery.Text = serial.rx.voltBatPercen + " %";
                    }

                } else {
                    LogSerial(LogMsgType.Error_Red, "\nread Err : " + rxResultSup);
                    LabelSerialRx(LogMsgType.Error_Red, "\nread Err : " + rxResultSup);
                }

                if (serial.rx.checkSumCount == 5) {
                    MessageBox.Show(SeRial.Rx.Text.overCheckSum);
                }
            }
            #endregion

            sensor.quality.CheckStatus(this);
            sensor.quality.CheckValue(this);

            waitSendSerialPort = true;
            tm_send_data.Enabled = true;
        }
        private void SerialReceiveEvent(object sender, SerialDataReceivedEventArgs e) {
            Thread.Sleep(10);
            int length = 0;
            serialPort1 = (SerialPort)sender;
            int buf = 0;

            try {
                length = serialPort1.BytesToRead;
            } catch {
                return;
            }

            while (length != 0) {

                for (int i = 0; i < length; i++) {
                    buf = serialPort1.ReadByte();
                    serial.rx.data.Add(buf);
                }

                Thread.Sleep(10);
                serialPort1 = (SerialPort)sender;

                try {
                    length = serialPort1.BytesToRead;
                } catch {
                    return;
                }
            }

            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            serial.rx.readed = true;
        }
        private void SerialPortCalMoveCar(byte[] dataSend) {
            if (carStatus.pcControlCar) {
                byte[] angleStepping = calMove.CalPluse();
                dataSend[SeRial.Tx.Index.angleSteppingLow] = angleStepping[0];
                dataSend[SeRial.Tx.Index.angleSteppingHigh] = angleStepping[1];
            }
        }

        private void Condition() {
            while (true) {
                if (junction.running) {
                    if (junction.data == string.Empty) { Thread.Sleep(50); continue; }
                    if (junction.data != JuncTion.Define.continous) {
                        SelectRoute(junction.data);
                        junction.point = "0";
                        junction.startFirst = true;
                        bgwk_serial.ReportProgress(2);
                        while (junction.startFirst) {
                            Thread.Sleep(50);
                        }
                    }
                    junction.running = false;
                    Thread.Sleep(50);
                    continue;
                }
                if (!waitSendSerialPort || !serial.sending || redLight.csvFlag || remoteCF.flag ||
                    reverse.formFlag || route.csv.delayFlag) {
                    Thread.Sleep(50);
                    continue;
                }

                if (reverse.resum.value == 2) { Thread.Sleep(50); continue; }
                if (!reverse.stopFlag) {
                    if (route.csv.condition == "1") {
                        switch (route.csv.endCommand) {
                            case 1:
                                if (sensor.X >= route.csv.endCommandTarget)
                                    route.flagNextStep = true;
                                break;
                            case 2:
                                if (sensor.Y >= route.csv.endCommandTarget)
                                    route.flagNextStep = true;
                                break;
                            case 3:
                                if (sensor.angle.newValue >= route.csv.endCommandTarget) {
                                    sensor.angle.controlHigh = false;
                                    sensor.angle.controlLow = false;
                                    route.flagNextStep = true;
                                }
                                break;
                        }
                    } else {
                        switch (route.csv.endCommand) {
                            case 1:
                                if (sensor.X <= route.csv.endCommandTarget)
                                    route.flagNextStep = true;
                                break;
                            case 2:
                                if (sensor.Y <= route.csv.endCommandTarget)
                                    route.flagNextStep = true;
                                break;
                            case 3:
                                if (sensor.angle.newValue <= route.csv.endCommandTarget) {
                                    sensor.angle.controlHigh = false;
                                    sensor.angle.controlLow = false;
                                    route.flagNextStep = true;
                                }
                                break;
                        }
                    }
                } else {
                    if (route.csv.condition == "1") {
                        switch (route.csv.endCommand) {
                            case 1:
                                if (sensor.X >= route.csv.endCommandTarget)
                                    route.flagNextStep = true;
                                break;
                            case 2:
                                if (sensor.Y >= route.csv.endCommandTarget)
                                    route.flagNextStep = true;
                                break;
                        }
                    } else {
                        switch (route.csv.endCommand) {
                            case 1:
                                if (sensor.X <= route.csv.endCommandTarget)
                                    route.flagNextStep = true;
                                break;
                            case 2:
                                if (sensor.Y <= route.csv.endCommandTarget)
                                    route.flagNextStep = true;
                                break;
                        }
                    }

                    bool reverseCameraEnd = ReverseCheckFlagCameraRL();
                    ReverseCheckFlagRail();
                    bool reverse0 = ReverseValue0ToSetFlagFork(reverseCameraEnd);
                    bool reverse1 = ReverseValue1WaitFlagForkClear(reverseCameraEnd);
                    bool reverse3 = ReverseWaitValue3(reverseCameraEnd);
                }

                Lable_nextStep:

                if (route.flagNextStep) {
                    route.flagNextStepEnd = false;
                    bgwk_serial.ReportProgress(1);
                    while (!route.flagNextStepEnd) Thread.Sleep(50);
                }
                Thread.Sleep(50);
            }
        }
        private void bgwk_serial_DoWork(object sender, DoWorkEventArgs e) {
            Condition();
        }
        private void bgwk_serial_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if (e.ProgressPercentage == 1) {
                NextStep();
                route.flagNextStepEnd = true;
            }

            if (e.ProgressPercentage == 2) {
                ButtonStartSup();
                junction.startFirst = false;
            }

            if (e.ProgressPercentage == 3) {
                lb_messageRail.Text = "**New route in csv**";
            }

            if (e.ProgressPercentage == 4) {
                lb_messageRail.Text = "**Rail OK**";
            }

            if (e.ProgressPercentage == 5) {
                lb_messageRail.Text = "DetectF = False";
            }

            if (e.ProgressPercentage == 6) {
                lb_statusRail.Text = "Rail = True";
            }

            if (e.ProgressPercentage == 7) {
                lb_statusRail.Text = "Rail = False";
            }
        }

        private void bgwk_sensor_DoWork(object sender, DoWorkEventArgs e) {
            if (sensor.type == Sensor.TypeSensor.udpClient) {
                SensorUdp();

            } else {
                SensorSocket();
            }
        }
        private void SensorUdp() {
            sensor.udpServer = new UdpClient(new IPEndPoint(IPAddress.Any, 5000));
            sensor.udpServer.BeginReceive(new AsyncCallback(sensor.SensorReceiveCallback), sensor.udpServer);

            byte[] xSensor = new byte[8];
            byte[] ySensor = new byte[8];
            byte[] ywSensor = new byte[4];

            while (true) {
                if (sensor.reConnect) {
                    Thread.Sleep(50);
                    continue;
                }

                try {
                    if (sensor.data[11] != 0x05 || sensor.data[13] != 0x02 || sensor.data.Count != 56) {
                        Thread.Sleep(100);
                        continue;
                    }

                    for (int i = 0; i < 8; i++) {
                        xSensor[i] = sensor.data[39 - i];
                    }
                    sensor.X = BitConverter.ToInt32(xSensor, 0);
                    if (sensor.X <= sensor.positionLimitX) {
                        continue;
                    }

                    for (int i = 0; i < 8; i++) {
                        ySensor[i] = sensor.data[47 - i];
                    }
                    sensor.Y = BitConverter.ToInt32(ySensor, 0);
                    if (sensor.Y <= sensor.positionLimitY) {
                        continue;
                    }

                    for (int i = 0; i < 4; i++) {
                        ywSensor[i] = sensor.data[51 - i];
                    }
                    sensor.angle.value = BitConverter.ToInt32(ywSensor, 0);

                    sensor.quality.status = sensor.data[52];
                    sensor.quality.value = sensor.data[53];
                } catch { }

                SensorShift();

                bgwk_sensor.ReportProgress(3);
                Thread.Sleep(20);
            }
        }
        private void SensorSocket() {
            byte[] dataRead = new byte[106];

            while (true) {
                if (sensor.socket.Available == 0) {
                    Thread.Sleep(50);
                    continue;
                }

                try {
                    byte[] buffer = new byte[sensor.socket.Available];
                    int received = sensor.socket.Receive(buffer, SocketFlags.None);

                    if (received == 0) {
                        return;
                    }

                    if ((received % 106) != 0) {
                        Thread.Sleep(50);
                        continue;
                    }

                    int shiftByte = received - 106;
                    byte[] dataReadSup = new byte[received];
                    Array.Copy(buffer, dataReadSup, received);

                    for (int i = 0; i < dataRead.Length; i++) {
                        dataRead[i] = dataReadSup[i + shiftByte];
                    }

                    byte[] dataConvert = dataRead;
                    byte[] coordinateX = new byte[4];
                    byte[] coordinateY = new byte[4];
                    byte[] coordinateAngle = new byte[4];

                    int numberByte = 63 - 1;
                    for (int i = numberByte; i < numberByte + 4; i++) {
                        coordinateX[(numberByte + 3) - i] = dataConvert[i];
                    }
                    sensor.X = BitConverter.ToInt32(coordinateX, 0);

                    numberByte = 67 - 1;
                    for (int i = numberByte; i < numberByte + 4; i++) {
                        coordinateY[(numberByte + 3) - i] = dataConvert[i];
                    }
                    sensor.Y = BitConverter.ToInt32(coordinateY, 0);

                    numberByte = 71 - 1;
                    for (int i = numberByte; i < numberByte + 4; i++) {
                        coordinateAngle[(numberByte + 3) - i] = dataConvert[i];
                    }
                    sensor.angle.value = BitConverter.ToInt32(coordinateAngle, 0);

                    sensor.quality.value = dataConvert[83 - 1];
                } catch { }

                SensorShift();

                bgwk_sensor.ReportProgress(3);
                Thread.Sleep(20);
            }
        }
        private void SensorShift() {
            int direction = 0;
            int directionSup = 0;
            int aFlag;
            int bFlag;
            double factorCal = 2510;
            double xSup = 0;
            double ySup = 0;

            if (sensor.angle.value > 90000 && sensor.angle.value <= 180000) {
                direction = 180000;
                aFlag = -1;
                bFlag = 1;
                directionSup = (direction - sensor.angle.value) / 1000;
                double a = factorCal * sensor.Sin(directionSup);
                double b = factorCal * sensor.Cos(directionSup);
                xSup = b * aFlag;
                ySup = a * bFlag;

            } else if (sensor.angle.value > 0 && sensor.angle.value <= 90000) {
                direction = 90000;
                aFlag = 1;
                bFlag = 1;
                directionSup = (direction - sensor.angle.value) / 1000;
                double a = factorCal * sensor.Sin(directionSup);
                double b = factorCal * sensor.Cos(directionSup);
                xSup = a * aFlag;
                ySup = b * bFlag;

            } else if (sensor.angle.value > -90000 && sensor.angle.value <= 0) {
                direction = 0;
                aFlag = 1;
                bFlag = -1;
                directionSup = (direction - sensor.angle.value) / 1000;
                double a = factorCal * sensor.Sin(directionSup);
                double b = factorCal * sensor.Cos(directionSup);
                xSup = b * aFlag;
                ySup = a * bFlag;

            } else {
                direction = -90000;
                aFlag = -1;
                bFlag = -1;
                directionSup = (direction - sensor.angle.value) / 1000;
                double a = factorCal * sensor.Sin(directionSup);
                double b = factorCal * sensor.Cos(directionSup);
                xSup = a * aFlag;
                ySup = b * bFlag;
            }

            if (sensor.angle.value > -179999 && sensor.angle.value <= -150000) {
                sensor.angle.newValue = sensor.angle.value + 360000;
            } else {
                sensor.angle.newValue = sensor.angle.value;
            }

            if (route.csv.command == 0x02 || route.csv.command == 0x05 || route.csv.command == 0x06) {
                xSup *= -1;
                ySup *= -1;
            }

            sensor.newX = Convert.ToInt32(sensor.X + xSup);
            sensor.newY = Convert.ToInt32(sensor.Y + ySup);
        }
        private void bgwk_sensor_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if (e.ProgressPercentage == 3) {
                double xxxx = sensor.X / 1000;
                int xxxx2 = sensor.X % 1000;
                double yyyy = sensor.Y / 1000;
                int yyyy2 = sensor.Y % 1000;
                double angleeee = sensor.angle.value / 1000;
                int angleeee2 = sensor.angle.value % 1000;
                lb_x.Text = "X = " + xxxx.ToString() + "." + Math.Abs(xxxx2).ToString();
                lb_y.Text = "Y = " + yyyy.ToString() + "." + Math.Abs(yyyy2).ToString();
                lb_angle.Text = "angle = " + angleeee.ToString() + "." + Math.Abs(angleeee2).ToString();

                lb_xSup.Text = "X_ = " + sensor.newX.ToString();
                lb_ySup.Text = "Y_ = " + sensor.newY.ToString();
            }
        }

        private void ServerMain() {
            BindServer();
            CameraWaitConnect();

            while (true) {
                bool connected = clien.Connect(this, clien.ip, clien.port);

                if (connected) {
                    ClienStartSend();
                } else {
                    Thread.Sleep(1000);
                    continue;
                }

                break;
            }

            while (true) {
                Thread.Sleep(50);

                ClienPosition();
                CameraProcess();
                redLight.Process(this);
                ClienRemoteCF();
                ClienEndProcess();
                ClienReverse12();
                ClienReverse34();
                ClienJunction();
                ClienErrorCode();
                ClienErrorPosition();
                ClienCheckAck();
            }
        }
        private void bgwk_main_DoWork(object sender, DoWorkEventArgs e) {
            Thread.Sleep(2500);

            ServerMain();
        }
        private void bgwk_main_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            if (e.ProgressPercentage == 0) {
                LogServer(LogMsgType.Incoming_Blue, "\n*** Chat Server Started " + DateTime.Now.ToString("G") + " *** ");
                LabelServerSend(LogMsgType.Incoming_Blue, "\n*** Chat Server Started " + DateTime.Now.ToString("G") + " *** ");
            }

            if (e.ProgressPercentage == 1) {
                LogServer(LogMsgType.Error_Red, "\nError trying to get local address Err");
                LabelServerSend(LogMsgType.Error_Red, "\nError trying to get local address Err");
            }

            if (e.ProgressPercentage == 2) {
                LogServer(LogMsgType.Error_Red, "\nUnable to get local address");
                LabelServerSend(LogMsgType.Error_Red, "\nUnable to get local address");
            }

            if (e.ProgressPercentage == 3) {
                LogServer(LogMsgType.Incoming_Blue, "\nPC Name: " + server.hostName);
                LogServer(LogMsgType.Incoming_Blue, "\nServer IP: " + server.ipAddress[0]);
                LogServer(LogMsgType.Incoming_Blue, "\nServer Port: " + server.port);
                LabelServerSend(LogMsgType.Incoming_Blue, "\nPC Name: " + server.hostName + "\r\n" +
                    "Server IP: " + server.ipAddress[0] + "\r\n" + "Server Port: " + server.port);
            }

            if (e.ProgressPercentage == 4) {
                LogServer(LogMsgType.Incoming_Blue, "\nServer start complete");
                LabelServerSend(LogMsgType.Incoming_Blue, "Server start complete");
                gb_sever.Text = "Sever : IP " + server.ip + "  Port " + server.port;
            }

            if (e.ProgressPercentage == 5) {
                ButtonStartSup();
            }

            if (e.ProgressPercentage == 6) {
                LogServer(LogMsgType.Error_Red, "\nError Open Server");
                LabelServerSend(LogMsgType.Error_Red, "Error Open Server");
            }

            if (e.ProgressPercentage == 7) {
                LogServer(LogMsgType.Outgoing_Green, Clien.Define.send + clien.jsonSend);
                LabelServerSend(LogMsgType.Outgoing_Green, Clien.Define.send + clien.jsonSend);
            }

            if (e.ProgressPercentage == 8) {
                LogServer(LogMsgType.Error_Red, Clien.Define.sendError);
                LabelServerSend(LogMsgType.Error_Red, Clien.Define.sendError);
            }

            if (e.ProgressPercentage == 9) {
                LogServer(LogMsgType.Warning_Orange, "\n" + server.jsonReceive);
                LabelServerGet(LogMsgType.Warning_Orange, "\n" + server.jsonReceive);
            }

            if (e.ProgressPercentage == 10) {
                LogServer(LogMsgType.Incoming_Blue, "\nClient connected, waiting for request...");
                LabelServerGet(LogMsgType.Incoming_Blue, "\nClient connected, waiting for request...");
            }

            if (e.ProgressPercentage == 11) {
                try {
                    LogServer(LogMsgType.Incoming_Blue, "\nClient address is " + server.ipEndPointNewConnect.Address.ToString() +
                " [" + server.ipEndPointNewConnect.Port.ToString() + "]");
                    LabelServerGet(LogMsgType.Incoming_Blue, "\nClient address is " + server.ipEndPointNewConnect.Address.ToString() +
                        " [" + server.ipEndPointNewConnect.Port.ToString() + "]");
                } catch { }
            }

            if (e.ProgressPercentage == 12) {
                LabelServerSend(LogMsgType.Outgoing_Green, "Turn Off Turn On Wifi...");
            }

            if (e.ProgressPercentage == 13) {
                LabelServerSend(LogMsgType.Outgoing_Green, "Connected to server " + clien.ip.ToString() + " port " + clien.port.ToString());
            }

            if (e.ProgressPercentage == 14) {
                LabelServerSend(LogMsgType.Error_Red, "Connected to server " + clien.ip.ToString() + " port " + clien.port.ToString());
            }

            if (e.ProgressPercentage == 15) {
                redLight.ShowLabel(this);
            }
        }
        #endregion

        #region ================================================== Function Convert =====================================================
        public byte[] StringToByteArray(string hex) {
            if (hex.Length == 1) {
                hex = "0" + hex;
            }

            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        private bool[] ByteToBoolArray(byte Byte) {
            bool[] result = new bool[8];

            for (int i = 0; i < 8; i++) {
                result[i] = (Byte & (1 << i)) == 0 ? false : true;
            }

            Array.Reverse(result);
            return result;
        }
        public string HexToAscii(string hex) {
            string ascii = "";

            for (int i = 0; i < hex.Length; i += 2) {

                string part = hex.Substring(i, 2);
                char ch = (char)Convert.ToInt32(part, 16); ;
                ascii = ascii + ch;
            }

            return ascii;
        }
        private string[] ByteArrayToString(byte[] byteArray) {
            List<string> list = new List<string>();

            foreach (byte Byte in byteArray) {
                list.Add(Byte.ToString("X2"));
            }

            return list.ToArray();
        }
        #endregion


        #region ========================================================== Class ===========================================================
        public class Route {
            /// <summary>nameFile = "route_config"</summary>
            public string nameFile { get; set; }
            public HeadConfig headConfig { get; set; }
            public Define define { get; set; }
            public bool flagNextStep { get; set; }
            public bool flagNextStepEnd { get; set; }
            public List<string> dataInRow { get; set; }
            public int stepTest { get; set; }
            public string[] dataInColumn { get; set; }
            public string lockJobOrder { get; set; }
            public string agvNo { get; set; }
            public string pathSensorConfig { get; set; }
            public string pathRoute { get; set; }
            public CSV csv { get; set; }
            public MapRoute mapRoute { get; set; }

            public Route() {
                nameFile = "route_config";
                headConfig = new HeadConfig();
                define = new Define();
                dataInRow = new List<string>();
                csv = new CSV();
                mapRoute = new MapRoute();
            }
            public void SetNullToZero(int index) {
                if (index < 0) {
                    return;
                }

                if (dataInColumn[index] == "" || dataInColumn[index] == null) {
                    dataInColumn[index] = "0";
                }

                SetNullToZero(index - 1);
            }

            public class HeadConfig {
                public string lockJobOrder { get; set; }
                public string agvNo { get; set; }

                public HeadConfig() {
                    lockJobOrder = "Lock Job Order";
                    agvNo = "AGV No";
                }
            }
            public class Define {
                /// <summary>deFault = "Default"</summary>
                public string deFault { get; set; }

                public Define() {
                    deFault = "Default";
                }
            }
            public class CSV {
                public string route { get; set; }
                public string condition { get; set; }
                /// <summary>Value = 42</summary>
                public int length { get; set; }
                public int endCommand { get; set; }
                public int endCommandTarget { get; set; }
                public bool delayFlag { get; set; }
                public byte command { get; set; }
                public int targetPositionX { get; set; }
                public int targetPositionY { get; set; }
                public bool flagError { get; set; }

                public CSV() {
                    route = "KITTING1";
                    length = 42;
                }
                /// <summary>
                /// Check level fork at csv reverse to Return value lift control
                /// </summary>
                /// <param name="levelFork">is level fork about to change</param>
                /// <param name="reverseValue">is value of reverse for check reverse on?</param>
                /// <param name="liftControl">is status lift</param>
                /// <returns></returns>
                public byte CheckReverseToLiftControl(int levelFork, int reverseValue, byte liftControl) {
                    if (reverseValue == 0) {
                        return liftControl;
                    } else {
                        return Convert.ToByte(levelFork);
                    }
                }
            }
            public class MapRoute {
                public string nameFile { get; set; }
                public string path { get; set; }
                public string number { get; set; }
                /// <summary>
                /// name of route in file csv MapRoute
                /// </summary>
                public string name { get; set; }

                public MapRoute() {
                    nameFile = "MapRoute.csv";
                }
                public string GetNameRoute(int stepTest) {
                    List<string> data = File.ReadAllLines(path + nameFile).ToList();

                    List<string> dataFind = data.FindAll(element => element.Contains(number + ","));

                    if (dataFind.Count == 0) {
                        MessageBox.Show("File Route csv Error [MapRoute] [Row=" + stepTest + "]");
                        return string.Empty;
                    }

                    if (dataFind.Count > 1) {
                        MessageBox.Show("File Route csv Error [MapRoute] [Row=" + stepTest + "]");
                    }

                    string[] dataSplit = dataFind[0].Split(',');

                    return dataSplit[1];
                }
            }
        }
        public class CarStatus {
            /// <summary>nameFile = "carStatus_config"</summary>
            public string nameFile { get; set; }
            private Int16 speedRight { get; set; }
            private Int16 speedLeft { get; set; }
            private bool speedFlag { get; set; }
            public bool[] keyInputLow { get; set; }
            public bool[] keyInputHigh { get; set; }
            public bool[] keyExtInputLow { get; set; }
            public bool[] keyExtInputHigh { get; set; }
            public string statusHookFinish { get; set; }
            public string directionHook { get; set; }
            public byte directionHookByte { get; set; }
            public bool reverseCSVHook { get; set; }
            public HeadConfig headConfig { get; set; }
            /// <summary>flag นี้จะเป็น true ก็ต่อเมื่อ มีการสั่งให้ speed ของรถเป็น 0</summary>
            public bool offSpeedFlag { get; set; }
            public bool pcControlCar { get; set; }
            public string passWord { get; set; }
            /// <summary>
            /// For follow status level fork
            /// </summary>
            public int lavelFork { get; set; }
            /// <summary>
            /// Flag for status fork up on
            /// </summary>
            public bool flagForkUp { get; set; }
            /// <summary>
            /// Flag for status fork down on
            /// </summary>
            public bool flagForkDown { get; set; }
            /// <summary>
            /// For reverse end position but camera roll rail not on to set falg
            /// </summary>
            public bool flagAlarmEndPosition { get; set; }
            /// <summary>
            /// For reverse 1 2 fork up but sensor roll detect off to set flag
            /// </summary>
            public bool flagAlarmSensorRollDetectOff { get; set; }
            /// <summary>
            /// For reverse 3 4 fork up but sensor roll detect on to set flag
            /// </summary>
            public bool flagAlarmSensorRollDetectOn { get; set; }

            public CarStatus() {
                nameFile = "carStatus_config";
                headConfig = new HeadConfig();
                keyInputLow = new bool[8];
                keyInputHigh = new bool[8];
                keyExtInputLow = new bool[8];
                keyExtInputHigh = new bool[8];

                lavelFork = 1;

                //keyExtInputLow[IndexExtLow.emergency] = true;
                //keyExtInputHigh[IndexExtHigh.bumperFront] = false;
                //keyExtInputHigh[IndexExtHigh.bumperSideL] = false;
                //keyExtInputHigh[IndexExtHigh.bumperSideR] = false;
                //keyExtInputHigh[IndexExtHigh.bumperWingL] = true;
                //keyExtInputHigh[IndexExtHigh.bumperWingR] = true;
            }
            public string GetSpeed(byte byteLow, byte byteHigh) {
                byte[] speedByte = new byte[4];

                speedByte[0] = byteLow;
                speedByte[1] = byteHigh;
                Int16 speed = BitConverter.ToInt16(speedByte, 0);

                return speed.ToString();
            }
            public string GetSpeedByInt(int byteLow, int byteHigh) {
                byte[] speedByte = new byte[4];

                speedByte[0] = Convert.ToByte(byteLow);
                speedByte[1] = Convert.ToByte(byteHigh);
                Int16 speed = BitConverter.ToInt16(speedByte, 0);

                if (speedFlag) {
                    speedRight = speed;
                    speedFlag = false;

                } else {
                    speedLeft = speed;
                    speedFlag = true;
                }

                return speed.ToString();
            }
            public string GetSpeedSum() {
                double speedSum = 0;

                speedSum += Math.Abs(speedRight);
                //speedSum += Math.Abs(speedLeft);
                speedSum /= 20;
                //speedSum *= 30;

                return speedSum.ToString("0000");
            }
            /// <summary>
            /// Check level fork if fork level 2 and rollDetect to set flagForkUp = false
            /// </summary>
            /// <param name="reverseValue">is value of reverse in csv</param>
            /// <param name="liftControl">is level lift control in csv</param>
            /// <returns></returns>
            public bool CheckLevelForkUp(int reverseValue, byte liftControl) {
                if (reverseValue != 0) {
                    if (keyInputHigh[IndexHigh.forkLevel2]) {
                        if (keyInputHigh[IndexHigh.rollDetect]) {
                            flagAlarmSensorRollDetectOff = false;
                            return false;
                        } else {
                            flagAlarmSensorRollDetectOff = true;
                            return true;
                        }
                    } else {
                        return true;
                    }


                } else {
                    if (liftControl == 0x01 && keyInputLow[IndexLow.forkLevel0]) {
                        return false;
                    } else if (liftControl == 0x02 && keyInputLow[IndexLow.forkLevel1]) {
                        return false;
                    } else if (liftControl == 0x03 && keyInputHigh[IndexHigh.forkLevel2]) {
                        return false;
                    } else {
                        return true;
                    }
                }
            }
            /// <summary>
            /// Check level fork if fork level 0 and rollDetect to set flagForkDown = false
            /// </summary>
            /// <param name="reverseValue">is value of reverse in csv</param>
            /// <param name="liftControl">is level lift control in csv</param>
            /// <returns></returns>
            public bool CheckLevelForkDown(int reverseValue, byte liftControl) {
                if (reverseValue != 0) {
                    if (keyInputLow[IndexLow.forkLevel0]) {
                        if (!keyInputHigh[IndexHigh.rollDetect]) {
                            flagAlarmSensorRollDetectOn = false;
                            return false;
                        } else {
                            flagAlarmSensorRollDetectOn = true;
                            return true;
                        }
                    } else {
                        return true;
                    }

                } else {
                    if (liftControl == 0x01 && keyInputLow[IndexLow.forkLevel0]) {
                        return false;
                    } else if (liftControl == 0x02 && keyInputLow[IndexLow.forkLevel1]) {
                        return false;
                    } else if (liftControl == 0x03 && keyInputHigh[IndexHigh.forkLevel2]) {
                        return false;
                    } else {
                        return true;
                    }
                }
            }

            public class HeadConfig {
                public string statusHookFinish { get; set; }
                public string directionHook { get; set; }
                public string reverseCSVHook { get; set; }
                public string passWord { get; set; }

                public HeadConfig() {
                    statusHookFinish = "Status Hook Finish";
                    directionHook = "Direction Hook";
                    reverseCSVHook = "Reverse CSV Hook";
                    passWord = "PassWord";
                }
            }
            public static class Direction {
                /// <summary>Value = "Forward"</summary>
                public static readonly string forward = "Forward";
                /// <summary>Value = "Reverse"</summary>
                public static readonly string reverse = "Reverse";
            }
            public static class IndexLow {
                /// <summary>Value = 0</summary>
                public static readonly int forkLevel1 = 0;
                /// <summary>Value = 1</summary>
                public static readonly int forkLevel0 = 1;
                /// <summary>Value = 2</summary>
                public static readonly int reset = 2;
                /// <summary>Value = 3</summary>
                public static readonly int free4 = 3;
                /// <summary>Value = 4</summary>
                public static readonly int free3 = 4;
                /// <summary>Value = 5</summary>
                public static readonly int free2 = 5;
                /// <summary>Value = 6</summary>
                public static readonly int free1 = 6;
                /// <summary>Value = 7</summary>
                public static readonly int start = 7;
            }
            public static class IndexHigh {
                /// <summary>Value = 0</summary>
                public static readonly int free9 = 0;
                /// <summary>Value = 1</summary>
                public static readonly int free8 = 1;
                /// <summary>Value = 2</summary>
                public static readonly int free7 = 2;
                /// <summary>Value = 3</summary>
                public static readonly int free6 = 3;
                /// <summary>Value = 4</summary>
                public static readonly int free5 = 4;
                /// <summary>Value = 5</summary>
                public static readonly int rollDetect = 5;
                /// <summary>Value = 6</summary>
                public static readonly int forkMax = 6;
                /// <summary>Value = 7</summary>
                public static readonly int forkLevel2 = 7;
            }
            public static class IndexExtLow {
                /// <summary>Value = 0</summary>
                public static readonly int scanSideMalfunctionL = 0;
                /// <summary>Value = 1</summary>
                public static readonly int scanSideStopR = 1;
                /// <summary>Value = 2</summary>
                public static readonly int scanSideWarningR = 2;
                /// <summary>Value = 3</summary>
                public static readonly int scanSideMalfunctionR = 3;
                /// <summary>Value = 4</summary>
                public static readonly int scanFrontStop = 4;
                /// <summary>Value = 5</summary>
                public static readonly int scanFrontWarning = 5;
                /// <summary>Value = 6</summary>
                public static readonly int scanFrontMalfunction = 6;
                /// <summary>Value = 7</summary>
                public static readonly int emergency = 7;
            }
            public static class IndexExtHigh {
                /// <summary>Value = 0</summary>
                public static readonly int nc1 = 0;
                /// <summary>Value = 1</summary>
                public static readonly int bumperWingR = 1;
                /// <summary>Value = 2</summary>
                public static readonly int bumperWingL = 2;
                /// <summary>Value = 3</summary>
                public static readonly int bumperSideR = 3;
                /// <summary>Value = 4</summary>
                public static readonly int bumperSideL = 4;
                /// <summary>Value = 5</summary>
                public static readonly int bumperFront = 5;
                /// <summary>Value = 6</summary>
                public static readonly int scanSideStopL = 6;
                /// <summary>Value = 7</summary>
                public static readonly int scanSideWarningL = 7;
            }
        }
        public class RedLight {
            public Socket socket { get; set; }
            public string ip { get; set; }
            public int port { get; set; }
            /// <summary>Value = 2000</summary>
            public int waitOne { get; set; }
            public bool csvFlag { get; set; }
            public int ipConfig { get; set; }
            public string status { get; set; }
            /// <summary>Value = "OPEN"</summary>
            public string open { get; set; }
            /// <summary>Value = "CLOSE"</summary>
            public string close { get; set; }
            /// <summary>Value = "GREEN"</summary>
            public string green { get; set; }
            /// <summary>Value = "RED"</summary>
            public string red { get; set; }
            /// <summary>Value = "../../StepTest/IP.csv"</summary>
            public string pathIP { get; set; }
            /// <summary>Value = 3</summary>
            private int loopFirstConnect { get; set; }
            /// <summary>Value = 0</summary>
            private int csvIP { get; set; }
            /// <summary>Value = 1</summary>
            private int csvPort { get; set; }
            /// <summary>Value = 2</summary>
            private int csvStatus { get; set; }
            /// <summary>Value = "enable"</summary>
            private string enable { get; set; }
            /// <summary>Value = "disable"</summary>
            private string disable { get; set; }
            public bool sendStatus { get; set; }
            private byte[] buffer { get; set; }
            private string json { get; set; }
            public string reCeiveData { get; set; }
            public string reCeiveData1 { get; set; }


            public RedLight() {
                waitOne = 2000;
                open = "OPEN";
                close = "CLOSE";
                green = "GREEN";
                red = "RED";
                pathIP = "../../StepTest/IP.csv";
                loopFirstConnect = 3;
                csvIP = 0;
                csvPort = 1;
                csvStatus = 2;
                enable = "enable";
                disable = "disable";
            }
            public bool Connect(FormMain form) {
                DisConnect();

                try {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                } catch { }

                IAsyncResult result = null;

                try {
                    result = socket.BeginConnect(ip, port, null, null);
                    result.AsyncWaitHandle.WaitOne(waitOne, true);
                } catch { }

                if (socket.Connected) {
                    socket.EndConnect(result);
                    form.LogServer(LogMsgType.Incoming_Blue, MesSage.connectOK + ip.ToString() + MesSage.port + port.ToString());
                    return true;

                } else {
                    socket.Close();
                    form.LogServer(LogMsgType.Error_Red, MesSage.connectErr + ip.ToString() + MesSage.port + port.ToString());
                    return false;
                }
            }
            private void FirstConnect(string ip_, string port_, FormMain form) {
                for (int i = 0; i < loopFirstConnect; i++) {
                    ip = ip_;
                    port = Convert.ToInt32(port_);
                    Connect(form);
                    if (socket == null) {
                        Thread.Sleep(1000);
                        continue;
                    }
                    break;
                }
            }
            public void Process(FormMain form) {
                if (!csvFlag) {
                    return;
                }

                ProcessSup(form);
                csvFlag = false;
            }
            private void ProcessSup(FormMain form) {
                string[] listIP;

                try {
                    listIP = File.ReadAllLines(pathIP);
                } catch {
                    MessageBox.Show(MesSage.getPathIP_Err);
                    return;
                }

                string[] ipSplit = listIP[ipConfig - 1].Split(',');
                FirstConnect(ipSplit[csvIP], ipSplit[csvPort], form);

                if (socket == null) {
                    return;
                }

                json = form.JsonLed(0, status);
                buffer = Encoding.ASCII.GetBytes(json);

                if (ipSplit[csvStatus] == enable) {
                    while (true) {
                        sendStatus = true;
                        Send(form);

                        //For showLabel redlight in gui
                        form.bgwk_main.ReportProgress(15);
                        //ShowLabel(form);

                        Stopwatch timeout = new Stopwatch();
                        timeout.Restart();

                        while (timeout.ElapsedMilliseconds <= 2000) {
                            GetData();

                            if (reCeiveData == status && reCeiveData1 == "FINISH") {
                                DisConnect();
                                return;
                            }
                            Thread.Sleep(50);
                        }
                    }

                } else {
                    for (int i = 0; i < 2; i++) {
                        sendStatus = true;
                        Send(form);

                        //For showLabel redlight in gui
                        form.bgwk_main.ReportProgress(15);
                        //ShowLabel(form);

                        CheckSend(form);
                        Thread.Sleep(50);
                    }
                }

                DisConnect();
            }
            private void Send(FormMain form) {
                try {
                    socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                } catch (Exception excep) {
                    form.LogSendError(excep, json);
                    sendStatus = false;
                }
            }
            private void CheckSend(FormMain form) {
                if (sendStatus) {
                    form.LogServer(LogMsgType.Normal_Black, MesSage.send + json);
                    form.LabelServerSend(LogMsgType.Normal_Black, MesSage.send + json);

                } else {
                    form.LogServer(LogMsgType.Error_Red, MesSage.sendErr);
                    form.LabelServerSend(LogMsgType.Error_Red, MesSage.sendErr);
                    Connect(form);
                }
            }
            public void ShowLabel(FormMain form) {
                if (sendStatus) {
                    form.LogServer(LogMsgType.Normal_Black, MesSage.send + json);
                    form.LabelServerSend(LogMsgType.Normal_Black, MesSage.send + json);

                } else {
                    form.LogServer(LogMsgType.Error_Red, MesSage.sendErr);
                    form.LabelServerSend(LogMsgType.Error_Red, MesSage.sendErr);
                    Connect(form);
                }
            }
            private void DisConnect() {
                try {
                    socket.Disconnect(true);
                } catch { }
            }
            public void SelectStatus(int value) {
                Clear();
                csvFlag = true;
                ipConfig = value;

                if (value <= 20) {
                    status = open;
                    return;
                }
                if (value <= 40) {
                    status = close;
                    return;
                }
                if (value <= 60) {
                    status = green;
                    return;
                }
                if (value <= 80) {
                    status = red;
                    return;
                }
            }
            public void Clear() {
                reCeiveData = string.Empty;
                reCeiveData1 = string.Empty;
            }
            private void GetData() {
                if (socket.Available == 0) {
                    return;
                }

                byte[] dataByte = new byte[socket.Available];
                socket.Receive(dataByte, SocketFlags.None);
                string data = Encoding.ASCII.GetString(dataByte);

                Server.JsonMcuRead jsonRead;
                try {
                    jsonRead = JsonConvert.DeserializeObject<Server.JsonMcuRead>(data);
                } catch {
                    MessageBox.Show(Server.Error.convertJson +
                        "\r\n" + data);
                    return;
                }

                if (ipConfig <= 40) {
                    if (jsonRead.cmd == Clien.Cmd.door + "_STS") {
                        reCeiveData = jsonRead.payload.Data;
                        reCeiveData1 = jsonRead.payload.Data1;
                    }

                } else {
                    if (jsonRead.cmd == Clien.Cmd.light + "_STS") {
                        reCeiveData = jsonRead.payload.Data;
                        reCeiveData1 = jsonRead.payload.Data1;
                    }
                }
            }

            public static class MesSage {
                public static readonly string connectOK = "\nConnect Red Light Ok: ";
                public static readonly string connectErr = "\nConnect Red Light Err: ";
                public static readonly string port = " port: ";
                public static readonly string getPathIP_Err = "Get IP.csv Error";
                public static readonly string send = "\nSend : ";
                public static readonly string sendErr = "\nSend Error";
            }
        }
        public class Sensor {
            /// <summary>Value = "sensor_config"</summary>
            public string nameFile { get; set; }
            public HeadConfig headConfig { get; set; }
            public string type { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
            public int newX { get; set; }
            public int newY { get; set; }
            public string ip { get; set; }
            public int port { get; set; }
            public int portConfig { get; set; }
            /// <summary>Value = "sMN LocForceUpdate"</summary>
            public string forceUpdate { get; set; }
            public Quality quality { get; set; }
            public bool reConnect { get; set; }
            public HttpWebRequest httpSend { get; set; }
            public HttpWebResponse httpRead { get; set; }
            public UdpClient udpServer { get; set; }
            public List<byte> data { get; set; }
            public Angle angle { get; set; }
            /// <summary>เอาไว้เก็บค่า ที่จะให้เลือกว่าเอาค่า config จากบรรทัดไหน"</summary>
            public string rowConfig { get; set; }
            public int positionLimitX { get; set; }
            public int positionLimitY { get; set; }
            public Socket socket { get; set; }
            public Socket socketConfig { get; set; }
            public Different different { get; set; }
            public bool flagFocusPos { get; set; }

            public Sensor() {
                nameFile = "sensor_config";
                headConfig = new HeadConfig();
                forceUpdate = "sMN LocForceUpdate";
                quality = new Quality();
                data = new List<byte>();
                angle = new Angle();
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socketConfig = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                different = new Different();
            }
            public void sendRest(string jsonRest, string url) {
                httpSend = (HttpWebRequest)WebRequest.Create(url);
                httpSend.Method = "POST";
                httpSend.ContentType = "application/json";
                try {
                    StreamWriter swJSONPayload = new StreamWriter(httpSend.GetRequestStream());
                    swJSONPayload.Write(jsonRest);
                    swJSONPayload.Close();
                } catch { }
            }
            public string readRest() {
                httpRead = null;
                try {
                    httpRead = (HttpWebResponse)httpSend.GetResponse();
                    Stream stream = httpRead.GetResponseStream();
                    if (stream != null) {
                        StreamReader reader = new StreamReader(stream);
                        return reader.ReadToEnd();
                    }
                } catch (Exception ex) {
                    return "{\"errorMessages\":\"" + ex.Message.ToString() + "\"}";
                }

                return string.Empty;
            }
            public string genJsonRest(string xConfig, string yConfig, string angleConfig) {
                SensorConfig config = new SensorConfig();
                config.data.pose.x = Convert.ToInt32(xConfig);
                config.data.pose.y = Convert.ToInt32(yConfig); ;
                config.data.pose.yaw = Convert.ToInt32(angleConfig); ;

                string json_ = new JavaScriptSerializer().Serialize(config);

                return json_;
            }
            public void SensorReceiveCallback(IAsyncResult ar) {
                UdpClient client = (UdpClient)ar.AsyncState;
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 0);
                byte[] datagram = client.EndReceive(ar, ref ep);
                data = datagram.ToList();
                udpServer.BeginReceive(new AsyncCallback(SensorReceiveCallback), udpServer);
            }
            public double Sin(double angle) {
                double radians = Math.PI * angle / 180.0;
                return Math.Sin(radians);
            }
            public double Cos(double angle) {
                double radians = Math.PI * angle / 180.0;
                return Math.Cos(radians);
            }
            public bool ConnectSocket(FormMain form) {
                try {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                } catch { }

                IAsyncResult result = socket.BeginConnect(ip, port, null, null);
                bool success = result.AsyncWaitHandle.WaitOne(2000, true);

                if (socket.Connected) {
                    socket.EndConnect(result);
                    form.LabelServerSend(LogMsgType.Incoming_Blue, "\nConnected to server " + ip + " port " + port);
                    return true;
                } else {
                    socket.Close();
                    form.LabelServerSend(LogMsgType.Error_Red, "\nConnected to server " + ip + " port " + port);
                    return false;
                }
            }
            public bool ConnectSocketConfig(FormMain form) {
                try {
                    socketConfig = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                } catch { }

                IAsyncResult result = socketConfig.BeginConnect(ip, portConfig, null, null);
                bool success = result.AsyncWaitHandle.WaitOne(2000, true);

                if (socketConfig.Connected) {
                    socketConfig.EndConnect(result);
                    form.LabelServerSend(LogMsgType.Incoming_Blue, "\nConnected to server " + ip + " port " + portConfig);
                    return true;
                } else {
                    socketConfig.Close();
                    form.LabelServerSend(LogMsgType.Error_Red, "\nConnected to server " + ip + " port " + portConfig);
                    return false;
                }
            }
            public void SocketConfigSend(FormMain form, string text) {
                byte[] buffer = Encoding.ASCII.GetBytes(text);
                socketConfig.Send(buffer, 0, buffer.Length, SocketFlags.None);
                form.LabelServerSend(LogMsgType.Outgoing_Green, "\nsend : " + text);
            }
            public string GetHeadConfig(FormMain form) {
                return form.HexToAscii("02");
            }
            public string GetEndConfig(FormMain form) {
                return form.HexToAscii("03");
            }
            public string GetLocForceUpdate() {
                return "sMN LocForceUpdate";
            }

            public class Angle {
                public int value { get; set; }
                public int newValue { get; set; }
                public bool controlLow { get; set; }
                public bool controlHigh { get; set; }
            }
            public class HeadConfig {
                public string type { get; set; }
                public string ip { get; set; }
                public string port { get; set; }
                public string portConfig { get; set; }
                public string rowConfig { get; set; }
                public string qualityMin { get; set; }
                public string qualityTimeOut { get; set; }
                public string positionLimitX { get; set; }
                public string positionLimitY { get; set; }
                public string lidarDifferentX { get; set; }
                public string lidarDifferentY { get; set; }

                public HeadConfig() {
                    type = "Type";
                    ip = "IP";
                    port = "Port";
                    portConfig = "Port Config";
                    rowConfig = "Row Config";
                    qualityMin = "Quality Min";
                    qualityTimeOut = "Quality TimeOut";
                    positionLimitX = "Position Limit X";
                    positionLimitY = "Position Limit Y";
                    lidarDifferentX = "Lidar X Different";
                    lidarDifferentY = "Lidar Y Different";
                }
            }
            public static class Define {
                public static readonly string ok = "ok";
                public static readonly string connectServer = "\nConnected to server IP:";
                public static readonly string port = " port:";
                public static readonly string send = "\nsend : ";
            }
            public class Quality {
                public int value { get; set; }
                public int status { get; set; }
                public Form2 form { get; set; }
                public bool flag { get; set; }
                public Stopwatch time { get; set; }
                public int timeOut { get; set; }
                public int minValue { get; set; }
                public bool readServer { get; set; }

                public Quality() {
                    time = new Stopwatch();
                }
                public void Setup(string detail) {
                    form = new Form2();
                    form.button1.Click += QualityClick;
                    form.label1.Text = detail;
                    flag = true;
                    form.Show();
                }
                public void QualityClick(object sender, EventArgs e) {
                    QualityClickSup();
                }
                public void QualityClickSup() {
                    if (value <= minValue) {
                        MessageBox.Show(Define.checkLidar);
                        return;
                    }

                    try {
                        form.Close();
                        form.Dispose();
                        form = null;
                        flag = false;
                    } catch { }
                }
                public void ConfirmValue(FormMain form) {
                    time.Restart();

                    while (time.ElapsedMilliseconds <= timeOut) {

                        if (value >= minValue) {
                            time.Stop();
                            break;
                        }
                    }

                    if (time.IsRunning) {
                        time.Stop();
                        Setup(Define.lidarErr);

                        while (flag) {
                            form.DelaymS(500);
                        }
                    }
                }
                public void CheckValue(FormMain form) {
                    if (flag) {
                        if (value >= minValue) {
                            form.DelaymS(3000);
                            QualityClickSup();
                        }
                        SendLocForceUpdate(form);

                    } else {
                        if (value < minValue) {

                            if (!flag) {
                                SendLocForceUpdate(form);
                                Setup(Define.lidarErrValue);
                            }
                        }
                    }
                }
                public void CheckStatus(FormMain form) {
                    if (status == 30 || status == 40) {

                        if (!flag) {
                            SendLocForceUpdate(form);
                            Setup(Define.lidarErrStatus);
                        }
                    }
                }
                public void SendLocForceUpdate(FormMain form) {
                    bool connected = form.sensor.ConnectSocketConfig(form);
                    if (!connected) {
                        return;
                    }

                    string headConfig = form.sensor.GetHeadConfig(form);
                    string endConfig = form.sensor.GetEndConfig(form);

                    form.sensor.SocketConfigSend(form, headConfig + form.sensor.GetLocForceUpdate() + endConfig);
                    form.sensor.SocketConfigSend(form, headConfig + form.sensor.GetLocForceUpdate() + endConfig);
                    form.sensor.SocketConfigSend(form, headConfig + form.sensor.GetLocForceUpdate() + endConfig);

                    form.sensor.socketConfig.Disconnect(true);
                    form.sensor.socketConfig.Dispose();
                }

                public static class Define {
                    public static readonly string checkLidar = "_กรุณาเช็ค Position Lidar ก่อน";
                    public static readonly string lidarErr = "Lidar Position Error";
                    public static readonly string lidarErrStatus = "Lidar Position Error (Status)";
                    public static readonly string lidarErrValue = "Lidar Position Error (Value)";
                }
            }
            public class SensorConfig {
                public Data data { get; set; }
                public SensorConfig() {
                    data = new Data();
                }

                public class Data {
                    public Pose pose { get; set; }
                    public Data() {
                        pose = new Pose();
                    }
                }
                public class Pose {
                    public int x { get; set; }
                    public int y { get; set; }
                    public int yaw { get; set; }
                }
            }
            public static class TypeSensor {
                public static readonly string udpClient = "UdpClient";
                public static readonly string socket = "Socket";
            }
            public class Different {
                public int lidarX { get; set; }
                public int lidarY { get; set; }
                public bool flag { get; set; }
                public bool axisX { get; set; }
                public bool axisY { get; set; }
                public Form2 form { get; set; }
                public bool formOpen { get; set; }
                public int value { get; set; }
                public bool readServer { get; set; }

                public Different() {

                }
                public void Setup() {
                    form = new Form2();
                    form.button1.Click += DifferentClick;
                    if (axisX) {
                        form.label1.Text = Define.errorAxisX;
                    }
                    if (axisY) {
                        form.label1.Text = Define.errorAxisY;
                    }
                    formOpen = true;
                    form.Show();
                }
                public void DifferentClick(object sender, EventArgs e) {
                    DifferentClickSup();
                }
                public void DifferentClickSup() {
                    if (axisX) {
                        if (value > lidarX) {
                            MessageBox.Show(Define.checkLidar + "\r\n" + Define.axisDifferentX + value);
                            return;
                        }
                    }
                    if (axisY) {
                        if (value > lidarY) {
                            MessageBox.Show(Define.checkLidar + "\r\n" + Define.axisDifferentY + value);
                            return;
                        }
                    }

                    form.Close();
                    form.Dispose();
                    form = null;
                    formOpen = false;
                }

                public static class Define {
                    public static readonly string checkLidar = "_กรุณาเช็ค Position Lidar ก่อน";
                    public static readonly string axisDifferentX = "Axis X Different = ";
                    public static readonly string axisDifferentY = "Axis Y Different = ";
                    public static readonly string errorAxisX = "Target Position X and Lidar X different";
                    public static readonly string errorAxisY = "Target Position Y and Lidar Y different";
                }
            }
        }
        public class AdjustCar {
            /// <summary>nameFile = "adjustCar_config"</summary>
            public string nameFile { get; set; }
            public HeadConfig headConfig { get; set; }

            public AdjustCar() {
                nameFile = "adjustCar_config";
                headConfig = new HeadConfig();
            }
            public class HeadConfig {
                public string lengthCar { get; set; }
                public string offsetPulseAngleL { get; set; }
                public string offsetPulseAngleR { get; set; }

                public HeadConfig() {
                    lengthCar = "Length Car";
                    offsetPulseAngleL = "Offset Pulse Angle L";
                    offsetPulseAngleR = "Offset Pulse Angle R";
                }
            }
        }

        public class SeRial {
            /// <summary>nameFile = "serial_config"</summary>
            public string nameFile { get; set; }
            public bool sending { get; set; }
            public Rx rx { get; set; }
            public Tx tx { get; set; }
            public bool disCom { get; set; }
            public string port { get; set; }
            public HeadConfig headConfig { get; set; }
            public Melody melody { get; set; }
            public int baudRate { get; set; }
            public int speedMax { get; set; }
            public short speedDownTime { get; set; }
            public short speedDownUnit { get; set; }
            public double speedSlowFactor { get; set; }

            public SeRial() {
                nameFile = "serial_config";
                rx = new Rx();
                tx = new Tx();
                headConfig = new HeadConfig();
                melody = new Melody();
            }
            public void Connect(FormMain form) {
                form.serialPort1.PortName = port;
                form.serialPort1.BaudRate = 38400;
                form.serialPort1.DataBits = 8;
                form.serialPort1.StopBits = StopBits.One;
                form.serialPort1.Parity = Parity.None;
                form.serialPort1.Handshake = Handshake.None;
                form.serialPort1.RtsEnable = true;
                form.serialPort1.DataReceived += new SerialDataReceivedEventHandler(form.SerialReceiveEvent);

                labelDiscom:
                Stopwatch time = new Stopwatch();
                time.Restart();

                while (time.ElapsedMilliseconds < 5000) {
                    try {
                        form.serialPort1.Open();
                        time.Stop();
                        break;
                    } catch {
                        Thread.Sleep(250);
                    }

                    try {
                        form.serialPort1.Close();
                    } catch { }
                }

                if (time.IsRunning) {
                    if (!disCom) {
                        try {
                            form.serialPort1.Close();
                        } catch { }

                        discom("disable", port);
                        discom("enable", port);
                        disCom = true;
                        goto labelDiscom;
                    }

                    try {
                        form.serialPort1.Close();
                    } catch { }

                    MessageBox.Show("can not connect SerialPort");
                    return;
                }

                form.lb_comport.Text = "Serial = " + port;
            }

            public class Rx {
                public int checkSumCount { get; set; }
                public List<int> data { get; set; }
                public bool readed { get; set; }
                public double voltBat { get; set; }
                public int voltBatPercen { get; set; }
                public int percenBatMin { get; set; }
                public int percenBatMax { get; set; }
                public bool batteryMinFlag { get; set; }

                public Rx() {
                    data = new List<int>();
                }
                public bool CheckSum() {
                    bool result;
                    byte checkSum = (byte)data[Index.lengthLow];

                    for (int i = 3; i < data.Count - 1; i++) {
                        checkSum ^= (byte)data[i];
                    }

                    if (checkSum == (byte)data[data.Count - 1]) {
                        checkSumCount = 0;
                        result = true;

                    } else {
                        checkSumCount++;
                        result = false;
                    }

                    return result;
                }
                public double GetVoltBat() {
                    byte[] voltByte = new byte[4];

                    voltByte[0] = Convert.ToByte(data[Index.voltBatLow]);
                    voltByte[1] = Convert.ToByte(data[Index.voltBatHigh]);
                    Int16 voltSup = BitConverter.ToInt16(voltByte, 0);

                    double volt = Convert.ToDouble(voltSup);
                    volt /= 10;

                    return volt;
                }
                public void CheckBatMin() {
                    if (voltBatPercen < percenBatMin) {
                        batteryMinFlag = true;
                        MessageBox.Show("Please change the battery!!");
                        batteryMinFlag = false;
                    }
                }
                public bool CheckBatMax() {
                    if (voltBatPercen > percenBatMax) {
                        return false;
                    }

                    return true;
                }
                public bool SklipCheckBat() {
                    if (0x00 == data[Index.voltBatLow] &&
                        0x00 == data[Index.voltBatHigh] &&
                        0x00 == data[Index.voltBatPercen]) {
                        return true;
                    }

                    if (0xff == data[Index.voltBatLow] &&
                        0xff == data[Index.voltBatHigh] &&
                        0xff == data[Index.voltBatPercen]) {
                        return true;
                    }

                    return false;
                }
                public Int16 GetAngleStep() {
                    byte[] angleStepByte = new byte[4];

                    angleStepByte[0] = Convert.ToByte(data[Index.firmwareCodeLow]);
                    angleStepByte[1] = Convert.ToByte(data[Index.firmwareCodeHigh]);
                    Int16 result = BitConverter.ToInt16(angleStepByte, 0);

                    return result;
                }
                public string GetErrorSup() {
                    byte[] errorByte = new byte[4];

                    errorByte[0] = Convert.ToByte(data[Index.currentSpeedLeftLow]);
                    errorByte[1] = Convert.ToByte(data[Index.currentSpeedLeftHigh]);
                    Int16 errorSup = BitConverter.ToInt16(errorByte, 0);

                    return errorSup.ToString();
                }

                public static class Text {
                    /// <summary>Value = "CheckSum Error 5 times!!"</summary>
                    public static readonly string overCheckSum = "CheckSum Error 5 times!!";
                }
                public static class Index {
                    /// <summary>Value = 0</summary>
                    public static readonly int header1 = 0;
                    /// <summary>Value = 1</summary>
                    public static readonly int header2 = 1;
                    /// <summary>Value = 2</summary>
                    public static readonly int lengthLow = 2;
                    /// <summary>Value = 3</summary>
                    public static readonly int lengthHigh = 3;
                    /// <summary>Value = 4</summary>
                    public static readonly int firmwareCodeLow = 4;
                    /// <summary>Value = 5</summary>
                    public static readonly int firmwareCodeHigh = 5;
                    /// <summary>Value = 6</summary>
                    public static readonly int firmwareVersion = 6;
                    /// <summary>Value = 7</summary>
                    public static readonly int firmwareReVersion = 7;
                    /// <summary>Value = 8</summary>
                    public static readonly int errorCodeLow = 8;
                    /// <summary>Value = 9</summary>
                    public static readonly int errorCodeHigh = 9;
                    /// <summary>Value = 10</summary>
                    public static readonly int errorDetailLow = 10;
                    /// <summary>Value = 11</summary>
                    public static readonly int errorDetailHigh = 11;
                    /// <summary>Value = 12</summary>
                    public static readonly int keyInputLow = 12;
                    /// <summary>Value = 13</summary>
                    public static readonly int keyInputHigh = 13;
                    /// <summary>Value = 14</summary>
                    public static readonly int keyExtInputLow = 14;
                    /// <summary>Value = 15</summary>
                    public static readonly int keyExtInputHigh = 15;
                    /// <summary>Value = 16</summary>
                    public static readonly int targetSpeedRightLow = 16;
                    /// <summary>Value = 17</summary>
                    public static readonly int targetSpeedRightHigh = 17;
                    /// <summary>Value = 18</summary>
                    public static readonly int commandRightSpeedLow = 18;
                    /// <summary>Value = 19</summary>
                    public static readonly int commandRightSpeedHigh = 19;
                    /// <summary>Value = 20</summary>
                    public static readonly int outSpeedRightLow = 20;
                    /// <summary>Value = 21</summary>
                    public static readonly int outSpeedRightHigh = 21;
                    /// <summary>Value = 22</summary>
                    public static readonly int currentSpeedRightLow = 22;
                    /// <summary>Value = 23</summary>
                    public static readonly int currentSpeedRightHigh = 23;
                    /// <summary>Value = 24</summary>
                    public static readonly int targetSpeedLeftLow = 24;
                    /// <summary>Value = 25</summary>
                    public static readonly int targetSpeedLeftHigh = 25;
                    /// <summary>Value = 26</summary>
                    public static readonly int commandSpeedLeftLow = 26;
                    /// <summary>Value = 27</summary>
                    public static readonly int commandSpeedLeftHigh = 27;
                    /// <summary>Value = 28</summary>
                    public static readonly int outSpeedLeftLow = 28;
                    /// <summary>Value = 29</summary>
                    public static readonly int outSpeedLeftHigh = 29;
                    /// <summary>Value = 30</summary>
                    public static readonly int currentSpeedLeftLow = 30;
                    /// <summary>Value = 31</summary>
                    public static readonly int currentSpeedLeftHigh = 31;
                    /// <summary>Value = 32</summary>
                    public static readonly int voltBatLow = 32;
                    /// <summary>Value = 33</summary>
                    public static readonly int voltBatHigh = 33;
                    /// <summary>Value = 34</summary>
                    public static readonly int voltBatPercen = 34;
                    /// <summary>Value = 35</summary>
                    public static readonly int checkSum = 35;
                }
                public static class Define {
                    /// <summary>Value = "\nread : "</summary>
                    public static readonly string read = "\nread : ";
                    /// <summary>Value = "\nread : err"</summary>
                    public static readonly string readError = "\nread : err";
                }

            }
            public class Tx {
                /// <summary>Value = 62</summary>
                public int length { get; set; }
                public byte[] data { get; set; }
                public byte[] dataManual { get; set; }
                public string mode { get; set; }
                public string manualShow { get; set; }

                public Tx() {
                    length = 62;
                    data = new byte[length];
                    dataManual = new byte[length];
                }
                public byte CheckSum(byte[] data) {
                    byte checksum = data[2];

                    for (int i = 3; i < data.Length - 1; i++) {
                        checksum ^= data[i];
                    }

                    return checksum;
                }

                public static class Define {
                    /// <summary>Value = "Auto"</summary>
                    public static readonly string auto = "Auto";
                    /// <summary>Value = "Manual"</summary>
                    public static readonly string manual = "Manual";
                    /// <summary>Value = "\nsend : "</summary>
                    public static readonly string send = "\nsend : ";
                    /// <summary>Value = "\nsend : err"</summary>
                    public static readonly string sendError = "\nsend : err";
                }
                public static class Index {
                    /// <summary>Value = 0</summary>
                    public static readonly int header1 = 0;
                    /// <summary>Value = 1</summary>
                    public static readonly int header2 = 1;
                    /// <summary>Value = 2</summary>
                    public static readonly int lengthData1 = 2;
                    /// <summary>Value = 3</summary>
                    public static readonly int lengthData2 = 3;
                    /// <summary>Value = 4</summary>
                    public static readonly int command = 4;
                    /// <summary>Value = 5</summary>
                    public static readonly int control = 5;
                    /// <summary>Value = 6</summary>
                    public static readonly int normalSpeedLow = 6;
                    /// <summary>Value = 7</summary>
                    public static readonly int normalSpeedHigh = 7;
                    /// <summary>Value = 8</summary>
                    public static readonly int angleSteppingLow = 8;
                    /// <summary>Value = 9</summary>
                    public static readonly int angleSteppingHigh = 9;
                    /// <summary>Value = 10</summary>
                    public static readonly int speedUpTime = 10;
                    /// <summary>Value = 11</summary>
                    public static readonly int speedUpUnit = 11;
                    /// <summary>Value = 12</summary>
                    public static readonly int speedDownTime = 12;
                    /// <summary>Value = 13</summary>
                    public static readonly int speedDownUnit = 13;
                    /// <summary>Value = 14</summary>
                    public static readonly int liftControl = 14;
                    /// <summary>Value = 15</summary>
                    public static readonly int specialFlag = 15;
                    /// <summary>Value = 16</summary>
                    public static readonly int maximumSpeedLow = 16;
                    /// <summary>Value = 17</summary>
                    public static readonly int maximumSpeedHigh = 17;
                    /// <summary>Value = 18</summary>
                    public static readonly int minimumSpeedLow = 18;
                    /// <summary>Value = 19</summary>
                    public static readonly int minimumSpeedHigh = 19;
                    /// <summary>Value = 20</summary>
                    public static readonly int targetPositionLowX1 = 20;
                    /// <summary>Value = 21</summary>
                    public static readonly int targetPositionLowX2 = 21;
                    /// <summary>Value = 22</summary>
                    public static readonly int targetPositionHighX1 = 22;
                    /// <summary>Value = 23</summary>
                    public static readonly int targetPositionHighX2 = 23;
                    /// <summary>Value = 24</summary>
                    public static readonly int targetPositionLowY1 = 24;
                    /// <summary>Value = 25</summary>
                    public static readonly int targetPositionLowY2 = 25;
                    /// <summary>Value = 26</summary>
                    public static readonly int targetPositionHighY1 = 26;
                    /// <summary>Value = 27</summary>
                    public static readonly int targetPositionHighY2 = 27;
                    /// <summary>Value = 28</summary>
                    public static readonly int targetAngleLow1 = 28;
                    /// <summary>Value = 29</summary>
                    public static readonly int targetAngleLow2 = 29;
                    /// <summary>Value = 30</summary>
                    public static readonly int targetAngleHigh1 = 30;
                    /// <summary>Value = 31</summary>
                    public static readonly int targetAngleHigh2 = 31;
                    /// <summary>Value = 32</summary>
                    public static readonly int currentPositionLowX1 = 32;
                    /// <summary>Value = 33</summary>
                    public static readonly int currentPositionLowX2 = 33;
                    /// <summary>Value = 34</summary>
                    public static readonly int currentPositionHighX1 = 34;
                    /// <summary>Value = 35</summary>
                    public static readonly int currentPositionHighX2 = 35;
                    /// <summary>Value = 36</summary>
                    public static readonly int currentPositionLowY1 = 36;
                    /// <summary>Value = 37</summary>
                    public static readonly int currentPositionLowY2 = 37;
                    /// <summary>Value = 38</summary>
                    public static readonly int currentPositionHighY1 = 38;
                    /// <summary>Value = 39</summary>
                    public static readonly int currentPositionHighY2 = 39;
                    /// <summary>Value = 40</summary>
                    public static readonly int currentAngleLow1 = 40;
                    /// <summary>Value = 41</summary>
                    public static readonly int currentAngleLow2 = 41;
                    /// <summary>Value = 42</summary>
                    public static readonly int currentAngleHigh1 = 42;
                    /// <summary>Value = 43</summary>
                    public static readonly int currentAngleHigh2 = 43;
                    /// <summary>Value = 44</summary>
                    public static readonly int pid1LowP = 44;
                    /// <summary>Value = 45</summary>
                    public static readonly int pid1HighP = 45;
                    /// <summary>Value = 46</summary>
                    public static readonly int pid1LowI = 46;
                    /// <summary>Value = 47</summary>
                    public static readonly int pid1HighI = 47;
                    /// <summary>Value = 48</summary>
                    public static readonly int pid1LowD = 48;
                    /// <summary>Value = 49</summary>
                    public static readonly int pid1HighD = 49;
                    /// <summary>Value = 50</summary>
                    public static readonly int pid1Gain = 50;
                    /// <summary>Value = 51</summary>
                    public static readonly int pidControlTime = 51;
                    /// <summary>Value = 52</summary>
                    public static readonly int melodyVolumnData = 52;
                    /// <summary>Value = 53</summary>
                    public static readonly int pidActivete = 53;
                    /// <summary>Value = 54</summary>
                    public static readonly int pid2LowP = 54;
                    /// <summary>Value = 55</summary>
                    public static readonly int pid2HighP = 55;
                    /// <summary>Value = 56</summary>
                    public static readonly int pid2LowI = 56;
                    /// <summary>Value = 57</summary>
                    public static readonly int areaSensorFront = 57;
                    /// <summary>Value = 58</summary>
                    public static readonly int areaSensorRight = 58;
                    /// <summary>Value = 59</summary>
                    public static readonly int areaSensorLeft = 59;
                    /// <summary>Value = 60</summary>
                    public static readonly int pid2Gain = 60;
                    /// <summary>Value = 61</summary>
                    public static readonly int checkSum = 61;
                }
            }
            public class Melody {
                public int value { get; set; }
                /// <summary>Value = 0</summary>
                public static readonly int min = 0;
                /// <summary>Value = 31</summary>
                public static readonly int max = 31;

                public void enable(FormMain form) {
                    form.bt_minus.Enabled = true;
                    form.bt_plus.Enabled = true;
                    form.bt_melody_send.Enabled = true;
                    form.cb_melody.Enabled = true;
                }
                public void disable(FormMain form) {
                    form.bt_minus.Enabled = false;
                    form.bt_plus.Enabled = false;
                    form.bt_melody_send.Enabled = false;
                    form.cb_melody.Enabled = false;
                }
            }
            public class HeadConfig {
                public string port { get; set; }
                public string baudRate { get; set; }
                public string melodyValue { get; set; }
                public string percenBatMin { get; set; }
                public string percenBatMax { get; set; }
                public string speedMax { get; set; }
                public string speedDownTime { get; set; }
                public string speedDownUnit { get; set; }
                public string speedSlowFactor { get; set; }

                public HeadConfig() {
                    port = "Port";
                    baudRate = "BaudRate";
                    melodyValue = "Melody Value";
                    percenBatMin = "Percen Bat Min";
                    percenBatMax = "Percen Bat Max";
                    speedMax = "Speed Max";
                    speedDownTime = "Speed Down Time";
                    speedDownUnit = "Speed Down Unit";
                    speedSlowFactor = "Speed Slow Factor";
                }
            }
        }
        public class Server {
            /// <summary>Value = "server_config"</summary>
            public string nameFile { get; set; }
            public bool endProcess { get; set; }
            public Socket socket { get; set; }
            public int port { get; set; }
            public string ip { get; set; }
            public byte[] buffer { get; set; }
            public IPAddress[] ipAddress { get; set; }
            public string hostName { get; set; }
            public Receive receive { get; set; }
            public HeadConfig headConfig { get; set; }
            public System.Threading.Timer positionTimeer { get; set; }
            public bool sendPositionTick { get; set; }
            public int positionSendEvery { get; set; }
            public int cameraSendEvery { get; set; }
            public int remoteCfSendEvery { get; set; }
            public int reverseSendEvery { get; set; }
            public int junctionSendEvery { get; set; }
            public string jsonReceive { get; set; }
            public IPEndPoint ipEndPointNewConnect { get; set; }
            public string wifiName { get; set; }

            public Server() {
                nameFile = "server_config";
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                buffer = new byte[Server.Define.bufferSize];
                receive = new Receive();
                headConfig = new HeadConfig();
            }
            public void SetPositionTick() {
                positionTimeer = new System.Threading.Timer(PositionTick, null, 1000, positionSendEvery);
            }
            public void PositionTick(object state) {
                sendPositionTick = true;
            }

            public class Receive {
                public bool start { get; set; }
                public bool remoteCF { get; set; }
                public bool end { get; set; }

                public Receive() {
                    remoteCF = true;
                }
            }
            public static class Define {
                /// <summary>Value = 65536</summary>
                public static readonly int bufferSize = 65536;
            }
            public class JsonServer {
                public string TimeStamp { get; set; }
                public string MessageID { get; set; }
                public string SourceID { get; set; }
                public string TargetID { get; set; }
                public string Cmd { get; set; }
                public PAYLOAD PayLoad { get; set; }
                public POSITION Position { get; set; }
                public string Battery { get; set; }

                public JsonServer() {
                    TimeStamp = string.Empty;
                    MessageID = string.Empty;
                    SourceID = string.Empty;
                    TargetID = string.Empty;
                    Cmd = string.Empty;
                    PayLoad = new PAYLOAD();
                    Position = new POSITION();
                    Battery = string.Empty;
                }
                public class PAYLOAD {
                    public string Data { get; set; }
                    public string Data1 { get; set; }
                    public string Data2 { get; set; }

                    public PAYLOAD() {
                        Data = string.Empty;
                        Data1 = string.Empty;
                        Data2 = string.Empty;
                    }
                }
                public class POSITION {
                    public string X { get; set; }
                    public string Y { get; set; }
                    public string YW { get; set; }

                    public POSITION() {
                        X = string.Empty;
                        Y = string.Empty;
                        YW = string.Empty;
                    }
                }
            }
            public class JsonServerRead {
                public string TimeStamp { get; set; }
                public string MessageID { get; set; }
                public string SourceID { get; set; }
                public string TargetID { get; set; }
                public string Cmd { get; set; }
                public PAYLOAD PayLoad { get; set; }
                public POSITION Position { get; set; }
                public string Battery { get; set; }

                public JsonServerRead() {
                    TimeStamp = string.Empty;
                    MessageID = string.Empty;
                    SourceID = string.Empty;
                    TargetID = string.Empty;
                    Cmd = string.Empty;
                    PayLoad = new PAYLOAD();
                    Position = new POSITION();
                    Battery = string.Empty;
                }
                public class PAYLOAD {
                    public string Data { get; set; }
                    public string Data1 { get; set; }
                    public string Data2 { get; set; }
                    public string Data3 { get; set; }
                    public string Data4 { get; set; }
                    public string Data5 { get; set; }
                    public string Data6 { get; set; }
                    public string Data7 { get; set; }
                    public string Data8 { get; set; }
                    public string Data9 { get; set; }
                    public string Data10 { get; set; }
                    public string Data11 { get; set; }
                    public string Data12 { get; set; }
                    public string Data13 { get; set; }
                    public string Data14 { get; set; }
                    public string Data15 { get; set; }

                    public PAYLOAD() {
                        Data = string.Empty;
                        Data1 = string.Empty;
                        Data2 = string.Empty;
                        Data3 = string.Empty;
                        Data4 = string.Empty;
                        Data5 = string.Empty;
                        Data6 = string.Empty;
                        Data7 = string.Empty;
                        Data8 = string.Empty;
                        Data9 = string.Empty;
                        Data10 = string.Empty;
                        Data11 = string.Empty;
                        Data12 = string.Empty;
                        Data13 = string.Empty;
                        Data14 = string.Empty;
                        Data15 = string.Empty;
                    }
                }
                public class POSITION {
                    public string X { get; set; }
                    public string Y { get; set; }
                    public string YW { get; set; }

                    public POSITION() {
                        X = string.Empty;
                        Y = string.Empty;
                        YW = string.Empty;
                    }
                }
            }
            public class JsonMcu {
                public string timeStamp { get; set; }
                public string messageID { get; set; }
                public string sourceID { get; set; }
                public string targetID { get; set; }
                public string cmd { get; set; }
                public PAYLOAD payload { get; set; }

                public JsonMcu() {
                    timeStamp = string.Empty;
                    messageID = string.Empty;
                    sourceID = string.Empty;
                    targetID = string.Empty;
                    cmd = string.Empty;
                    payload = new PAYLOAD();
                }
                public class PAYLOAD {
                    public string Data { get; set; }
                    public string Data1 { get; set; }
                    public string Data2 { get; set; }

                    public PAYLOAD() {
                        Data = string.Empty;
                        Data1 = string.Empty;
                        Data2 = string.Empty;
                    }
                }
            }
            public class JsonMcuRead {
                public string timeStamp { get; set; }
                public string messageID { get; set; }
                public string sourceID { get; set; }
                public string targetID { get; set; }
                public string cmd { get; set; }
                public PAYLOAD payload { get; set; }

                public JsonMcuRead() {
                    timeStamp = string.Empty;
                    messageID = string.Empty;
                    sourceID = string.Empty;
                    targetID = string.Empty;
                    cmd = string.Empty;
                    payload = new PAYLOAD();
                }
                public class PAYLOAD {
                    public string Data { get; set; }
                    public string Data1 { get; set; }
                    public string Data2 { get; set; }

                    public PAYLOAD() {
                        Data = string.Empty;
                        Data1 = string.Empty;
                        Data2 = string.Empty;
                    }
                }
            }
            public static class Cmd {
                /// <summary>Value = "JOBORDER"</summary>
                public static readonly string jobOrder = "JOBORDER";
                /// <summary>Value = "JUNE"</summary>
                public static readonly string june = "JUNE";
                /// <summary>Value = "RESUME"</summary>
                public static readonly string reSume = "RESUME";
            }
            public static class Error {
                /// <summary>Value = "Convert Format Json Error"</summary>
                public static readonly string convertJson = "Convert Format Json Error";
            }

            public class HeadConfig {
                public string ip { get; set; }
                public string port { get; set; }
                public string positionSendEvery { get; set; }
                public string remoteCfSendEvery { get; set; }
                public string reverseSendEvery { get; set; }
                public string junctionSendEvery { get; set; }
                public string errorCodeSendEvery { get; set; }
                public string wifiName { get; set; }

                public HeadConfig() {
                    ip = "Server IP";
                    port = "Server Port";
                    positionSendEvery = "Position Send Every";
                    remoteCfSendEvery = "Remote CF Send Every";
                    reverseSendEvery = "Reverse Send Every";
                    junctionSendEvery = "Junction Send Every";
                    errorCodeSendEvery = "Error Code Send Every";
                    wifiName = "Wifi Name";
                }
            }
        }
        public class Clien {
            /// <summary>Value = "server_config"</summary>
            public string nameFile { get; set; }
            public Socket socket { get; set; }
            public List<Socket> listSocket { get; set; }
            public int port { get; set; }
            public string ip { get; set; }
            public HeadConfig headConfig { get; set; }
            public Stopwatch connectError { get; set; }
            public bool connectErrorFlag { get; set; }
            public string jsonSend { get; set; }
            public bool ackResume { get; set; }
            public bool ackJobOrder { get; set; }

            public Clien() {
                nameFile = "server_config";
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                listSocket = new List<Socket>();
                headConfig = new HeadConfig();
                connectError = new Stopwatch();
            }
            public void Close() {
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
            public void CloseAll() {
                foreach (Socket socket in listSocket) {
                    try {
                        socket.Shutdown(SocketShutdown.Both);
                    } catch { }

                    socket.Close();
                }
            }
            public bool Connect(FormMain form, string ip, int port) {
                try {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                } catch { }

                IAsyncResult result = null;
                bool success;
                try {
                    result = socket.BeginConnect(ip, port, null, null);
                    success = result.AsyncWaitHandle.WaitOne(2000, true);
                } catch { }

                if (socket.Connected) {
                    socket.EndConnect(result);
                    form.bgwk_main.ReportProgress(13);
                    socket.SendTimeout = Define.timeOut;
                    connectErrorFlag = false;
                    connectError.Reset();
                    return true;
                }

                if (!connectErrorFlag) {
                    if (!connectError.IsRunning) {
                        connectError.Restart();

                    } else {
                        if (connectError.ElapsedMilliseconds >= 7500) {
                            form.wifiClass.LogSendError();
                            Thread.Sleep(1000);
                            form.wifiClass.DisConnect();

                            while (true) {
                                form.bgwk_main.ReportProgress(12);
                                form.wifiClass.Connect();
                                Thread.Sleep(2500);

                                if (form.wifiClass.wifi.ConnectionStatus == WifiStatus.Connected) {
                                    break;
                                }
                            }

                            connectError.Reset();
                            //connectErrorFlag = true;  //เอาไว้ล็อค ให้มัน รีคอนเน็คแค่ครั้งเดียว
                        }
                    }
                }

                socket.Close();
                form.bgwk_main.ReportProgress(14);
                return false;
            }
            public bool Connect_(FormMain form, string ip, int port) {
                try {
                    IPAddress ipAddress = IPAddress.Parse(ip);
                    IPEndPoint remoteEP = new IPEndPoint(ipAddress, port);
                    socket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    //socket.SendTimeout = Define.timeOut;
                    socket.SendTimeout = 1000;
                    socket.Connect(remoteEP);
                } catch { }

                if (socket.Connected) {
                    form.bgwk_main.ReportProgress(13);
                    connectErrorFlag = false;
                    connectError.Reset();
                    return true;
                }

                if (!connectErrorFlag) {
                    if (!connectError.IsRunning) {
                        connectError.Restart();

                    } else {
                        if (connectError.ElapsedMilliseconds >= 7500) {
                            form.wifiClass.LogSendError();
                            Thread.Sleep(1000);
                            form.wifiClass.DisConnect();

                            while (true) {
                                form.bgwk_main.ReportProgress(12);
                                form.wifiClass.Connect();
                                Thread.Sleep(2500);

                                if (form.wifiClass.wifi.ConnectionStatus == WifiStatus.Connected) {
                                    break;
                                }
                            }

                            connectError.Reset();
                            //connectErrorFlag = true;  //เอาไว้ล็อค ให้มัน รีคอนเน็คแค่ครั้งเดียว
                        }
                    }
                }

                try {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                } catch { }

                form.bgwk_main.ReportProgress(14);
                return false;
            }

            public static class Define {
                /// <summary>Value = "\nsend : "</summary>
                public static readonly string send = "\nsend : ";
                /// <summary>Value = "\nsend : err"</summary>
                public static readonly string sendError = "\nsend : err";
                /// <summary>Value = 499</summary>
                public static readonly int timeOut = 499;
            }
            public static class Cmd {
                /// <summary>Value = "POSITION"</summary>
                public static readonly string position = "POSITION";
                /// <summary>Value = "STOP"</summary>
                public static readonly string stop = "STOP";
                /// <summary>Value = "START"</summary>
                public static readonly string start = "START";
                /// <summary>Value = "END"</summary>
                public static readonly string end = "END";
                /// <summary>Value = "REMOTE_CF_"</summary>
                public static readonly string remoteCF = "REMOTE_CF_";
                /// <summary>Value = "PICKEDUP"</summary>
                public static readonly string pickedUp = "PICKEDUP";
                /// <summary>Value = "DROP"</summary>
                public static readonly string drop = "DROP";
                /// <summary>Value = "PAUSE"</summary>
                public static readonly string pause = "PAUSE";
                /// <summary>Value = "PART"</summary>
                public static readonly string part = "PART";
                /// <summary>Value = "EMPTY"</summary>
                public static readonly string empty = "EMPTY";
                /// <summary>Value = "RESUME"</summary>
                public static readonly string resume = "RESUME";
                /// <summary>Value = "JOBORDER"</summary>
                public static readonly string jobOrder = "JOBORDER";
                /// <summary>Value = "CMD_LIGHT"</summary>
                public static readonly string light = "CMD_LIGHT";
                /// <summary>Value = "CMD_DOOR"</summary>
                public static readonly string door = "CMD_DOOR";
                /// <summary>Value = "JUNCTION"</summary>
                public static readonly string junction = "JUNCTION";
                /// <summary>Value = "Error"</summary>
                public static readonly string errorCode = "Error";
            }
            public class HeadConfig {
                public string ip { get; set; }
                public string port { get; set; }

                public HeadConfig() {
                    ip = "Clien IP";
                    port = "Clien Port";
                }
            }
        }
        public class JuncTion {
            public string data { get; set; }
            public bool running { get; set; }
            public string point { get; set; }
            public bool startFirst { get; set; }

            public bool Check(string[] dataStep, Route route) {
                string check = "0";

                if (dataStep[IndexCSV.juncTion1] == check && dataStep[IndexCSV.juncTion2] == check) {
                    data = String.Empty;
                    running = true;
                    point = dataStep[33];

                    GenConfig(route);

                    return true;
                }

                return false;
            }
            private void GenConfig(Route route) {
                string[] result = File.ReadAllLines(route.pathSensorConfig);
                result[0] = (50 + Convert.ToInt32(point)).ToString();
                File.WriteAllLines(route.pathSensorConfig, result);
            }

            public static class Define {
                /// <summary>Value = "JuncTion = "</summary>
                public static readonly string juncTion = "JuncTion = ";
                /// <summary>Value = "CONTINOUS"</summary>
                public static readonly string continous = "CONTINOUS";
            }
        }
        public class RemoteCF {
            public int value { get; set; }
            public bool flag { get; set; }
        }
        public class Reverse {
            public int value { get; set; }
            public bool stopFlag { get; set; }
            public Resum resum { get; set; }
            public Form2 form { get; set; }
            public bool formFlag { get; set; }
            public Receive receive { get; set; }
            public bool value3To50 { get; set; }
            public bool value5To50 { get; set; }
            public bool nextStep { get; set; }

            public Reverse() {
                resum = new Resum();
                receive = new Receive();
            }
            public void SetupForm(FormMain main) {
                try {
                    bool flagIcon = form.ShowIcon;
                    return;
                } catch { }

                form = new Form2();
                form.button1.Click += main.ReverseEventClick;
                form.label1.Text = Text.label;
                form.Show();
            }

            public class Resum {
                public int value { get; set; }
                public bool wait { get; set; }
            }
            public class Receive {
                public bool pickUp { get; set; }
                public bool drop { get; set; }
                public bool resum { get; set; }
            }
            public static class Text {
                /// <summary>Value = "Please Pickup cart"</summary>
                public static readonly string label = "Please Pickup cart";
                /// <summary>Value = "Cart R, Cart L ต้องเป็น True ทั้งคู่"</summary>
                public static readonly string errorCart = "Cart R, Cart L ต้องเป็น True ทั้งคู่";
            }
        }
        public class Emer {
            public bool lockOffSpeed { get; set; }
            public bool speedError { get; set; }
            public Form2 form { get; set; }

            public Emer() {

            }
            public void SetupForm(FormMain main) {
                form = new Form2();
                form.button1.Click += main.EmerEventClick;
                form.label1.Text = Text.label;
                SetupFormSup(main);
                form.Show();
                main.serial.melody.enable(main);
            }
            public void SetupFormSup(FormMain main) {
                if (main.carStatus.keyExtInputLow[CarStatus.IndexExtLow.emergency]) {
                    form.label1.Text += " [" + Text.emergency + "]";
                    return;
                }

                if (main.carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperFront]) {
                    form.label1.Text += " [" + Text.bumperFront + "]";
                    return;
                }

                if (main.carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperSideR]) {
                    form.label1.Text += " [" + Text.bumperSideR + "]";
                    return;
                }

                if (main.carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperSideL]) {
                    form.label1.Text += " [" + Text.bumperSideL + "]";
                    return;
                }

                if (main.carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperWingR]) {
                    form.label1.Text += " [" + Text.bumperWingR + "]";
                    return;
                }

                if (main.carStatus.keyExtInputHigh[CarStatus.IndexExtHigh.bumperWingL]) {
                    form.label1.Text += " [" + Text.bumperWingL + "]";
                    return;
                }
            }
            public static class Text {
                /// <summary>Value = "Emergency stop"</summary>
                public static readonly string label = "Emergency stop";
                /// <summary>Value = "_กรุณากด Emer ก่อน"</summary>
                public static readonly string error = "_กรุณากด Emer ก่อน";
                /// <summary>Value = "Emergency"</summary>
                public static readonly string emergency = "Emergency";
                /// <summary>Value = "BumperFront"</summary>
                public static readonly string bumperFront = "BumperFront";
                /// <summary>Value = "BumperSideL"</summary>
                public static readonly string bumperSideL = "BumperSideL";
                /// <summary>Value = "BumperSideR"</summary>
                public static readonly string bumperSideR = "BumperSideR";
                /// <summary>Value = "BumperWingL"</summary>
                public static readonly string bumperWingL = "BumperWingL";
                /// <summary>Value = "BumperWingR"</summary>
                public static readonly string bumperWingR = "BumperWingR";
            }
        }
        public class ErrorCode {
            public err_code form { get; set; }
            public bool flagOpen { get; set; }
            public bool click { get; set; }
            public byte byte_ { get; set; }
            /// <summary>Value = 5</summary>
            public int clickAgain { get; set; }
            public int clickAgainNum { get; set; }
            public bool dismissClick { get; set; }
            public bool sendServer { get; set; }
            public bool readServer { get; set; }
            public int readServerTimeOut { get; set; }
            public string codeHead { get; set; }
            public string codeDetail { get; set; }

            public ErrorCode() {
                clickAgain = 5;
            }
            public void Setup(string head, string detail) {
                try {
                    bool sup = form.ShowIcon;
                    return;
                } catch { }

                flagOpen = true;
                form = new err_code();
                form.lb_err_code.Text = Define.errorCode + head;
                form.lb_detail.Text = Define.detail + detail;

                if (head == Define.FFFF) {
                    form.bt_reset.Visible = false;
                    form.bt_dismiss.Click += DismissClick;
                    form.bt_cancel.Click += CancelClick;

                } else {
                    form.bt_dismiss.Visible = false;
                    form.bt_cancel.Visible = false;
                    form.bt_reset.Click += ResetClick;
                }

                form.Show();
                clickAgainNum = 0;
                codeHead = head;
                codeDetail = detail;
                sendServer = true;
            }
            public void DismissClick(object sender, EventArgs e) {
                byte_ = 0x10;

                click = true;
                dismissClick = true;
                flagOpen = false;
                form.Close();
                form.Dispose();
                form = null;
            }
            public void ResetClickSup() {
                byte_ = 0x08;

                click = true;
                flagOpen = false;
                form.Close();
                form.Dispose();
                form = null;
            }
            public void ResetClick(object sender, EventArgs e) {
                ResetClickSup();
            }
            public void CancelClick(object sender, EventArgs e) {
                byte_ = 0x20;

                click = true;
                flagOpen = false;
                form.Close();
                form.Dispose();
                form = null;
            }
            public void Check(string head, string detail) {
                if (head != "0002" && head != "0003") {
                    return;
                }

                if (head != "FFFF" && dismissClick) {
                    return;
                }

                Setup(head, detail);
            }

            public static class Define {
                /// <summary>Value = "FFFF"</summary>
                public static readonly string FFFF = "FFFF";
                /// <summary>Value = "Error Code : "</summary>
                public static readonly string errorCode = "Error Code : ";
                /// <summary>Value = "Detail : "</summary>
                public static readonly string detail = "Detail : ";
            }
        }

        public class DebugCode {
            private string pathDesktop { get; set; }
            public Stopwatch time { get; set; }
            private string nameFileSerial { get; set; }
            private string nameFileSensor { get; set; }

            public DebugCode() {
                nameFileSerial = "\\LogSerial.txt";
                nameFileSensor = "\\LogSensor.txt";
                pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.Delete(pathDesktop + nameFileSerial);
                File.Delete(pathDesktop + nameFileSensor);
                time = new Stopwatch();
                time.Restart();
            }
            public void WriteSerial(string cmd) {
                File.AppendAllText(pathDesktop + nameFileSerial, time.ElapsedMilliseconds + " " + cmd + "\r\n");
            }
            public void WriteSensor(string cmd) {
                File.AppendAllText(pathDesktop + nameFileSensor, time.ElapsedMilliseconds + " " + cmd + "\r\n");
            }
        }
        public class WifiClass {
            public Wifi wifi { get; set; }
            public string nameWifi { get; set; }

            public WifiClass() {
                wifi = new Wifi();
            }

            public void CheckStatus() {
                if (wifi.ConnectionStatus == WifiStatus.Connected) {
                    return;
                }

                Connect();
                //LogSendError();
            }
            public void Connect() {
                AccessPoint selectedAP = WifiSelect(nameWifi);
                AuthRequest authRequest = new AuthRequest(selectedAP);
                if (authRequest.IsPasswordRequired) {
                    if (selectedAP.HasProfile) {
                        selectedAP.ConnectAsync(authRequest, false, OnConnectedComplete);
                    }
                }

                //string disableNet = "wmic path win32_networkadapter where PhysicalAdapter=True call disable";
                //string enableNet = "wmic path win32_networkadapter where PhysicalAdapter=True call enable";
                //CallCmdCommad(status ? enableNet : disableNet);

                //if (status) {
                //    Process.Start("ipconfig", "/renew"); //For enabling internet

                //} else {
                //    Process.Start("ipconfig", "/release"); //For disabling internet
                //}
                //Thread.Sleep(2500);
            }
            public void DisConnect() {
                wifi.Disconnect();
            }
            private AccessPoint WifiSelect(string nameWifi) {
                IEnumerable<AccessPoint> accessPoints = wifi.GetAccessPoints().OrderByDescending(ap => ap.SignalStrength);
                AccessPoint selectedAP = accessPoints.ToList()[0];

                LoopConnectWifi:
                int num = 0;
                foreach (AccessPoint ap in accessPoints) {

                    if (ap.Name == nameWifi) {
                        selectedAP = accessPoints.ToList()[num];

                        if (selectedAP.Name != nameWifi) {
                            goto LoopConnectWifi;
                        }

                        break;
                    }

                    num++;
                }

                return selectedAP;
            }
            private void OnConnectedComplete(bool success) {
                //
            }
            private void CallCmdCommad(string cmd) {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = $"/C {cmd}";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }

            public void LogSendError() {
                string path = "D:\\LogErrorWifi";

                if (!Directory.Exists(path)) {
                    Directory.CreateDirectory(path);
                }

                DateTime now = DateTime.Now;
                StreamWriter swOut = new StreamWriter(path + "\\" + now.Year + "_" + now.Month + ".csv", true);
                string time = now.Date.ToString("00") + ":" + now.Hour.ToString("00") + ":" + now.Minute.ToString("00") + ":" + now.Second.ToString("00");
                swOut.WriteLine("Start Process Auto DisConnect Wifi," + time);
                swOut.Close();
            }
        }

        public static class IndexCSV {
            /// <summary>Value = "File Route .csv err"</summary>
            public static readonly string lengthError = "File Route .csv err";
            /// <summary>Value = "File Route : "</summary>
            public static readonly string dataErr = "File Route : ";
            /// <summary>Value = ".csv Error\r\nstep = "</summary>
            public static readonly string dataErr2 = ".csv Error\r\nstep = ";
            /// <summary>Value = 0</summary>
            public static readonly int juncTion1 = 0;
            /// <summary>Value = 1</summary>
            public static readonly int juncTion2 = 1;
            /// <summary>Value = 0</summary>
            public static readonly int header1 = 0;
            /// <summary>Value = 1</summary>
            public static readonly int header2 = 1;
            /// <summary>Value = 2</summary>
            public static readonly int lengthData = 2;
            /// <summary>Value = 3</summary>
            public static readonly int command = 3;
            /// <summary>Value = 4</summary>
            public static readonly int control = 4;
            /// <summary>Value = 5</summary>
            public static readonly int normalSpeed = 5;
            /// <summary>Value = 6</summary>
            public static readonly int angleStepping = 6;
            /// <summary>Value = 7</summary>
            public static readonly int speedUpTime = 7;
            /// <summary>Value = 8</summary>
            public static readonly int speedUpUnit = 8;
            /// <summary>Value = 9</summary>
            public static readonly int speedDownTime = 9;
            /// <summary>Value = 10</summary>
            public static readonly int speedDownUnit = 10;
            /// <summary>Value = 11</summary>
            public static readonly int liftControl = 11;
            /// <summary>Value = 12</summary>
            public static readonly int specialFlag = 12;
            /// <summary>Value = 13</summary>
            public static readonly int maxSpeed = 13;
            /// <summary>Value = 14</summary>
            public static readonly int minSpeed = 14;
            /// <summary>Value = 15</summary>
            public static readonly int targetX = 15;
            /// <summary>Value = 16</summary>
            public static readonly int targetY = 16;
            /// <summary>Value = 17</summary>
            public static readonly int targetYW = 17;
            /// <summary>Value = 21</summary>
            public static readonly int pidP = 21;
            /// <summary>Value = 22</summary>
            public static readonly int pidI = 22;
            /// <summary>Value = 23</summary>
            public static readonly int pidD = 23;
            /// <summary>Value = 24</summary>
            public static readonly int pidGain = 24;
            /// <summary>Value = 25</summary>
            public static readonly int pidControlTime = 25;
            /// <summary>Value = 26</summary>
            public static readonly int volumeMelody = 26;
            /// <summary>Value = 27</summary>
            public static readonly int pidActivateErrorValue = 27;
            /// <summary>Value = 28</summary>
            public static readonly int condition = 28;
            /// <summary>Value = 29</summary>
            public static readonly int endCommand = 29;
            /// <summary>Value = 30</summary>
            public static readonly int targetEndCommand = 30;
            /// <summary>Value = 31</summary>
            public static readonly int traffic = 31;
            /// <summary>Value = 32</summary>
            public static readonly int remoteCF = 32;
            /// <summary>Value = 33</summary>
            public static readonly int reveres = 33;
            /// <summary>Value = 34</summary>
            public static readonly int delay = 34;
            /// <summary>Value = 35</summary>
            public static readonly int pidSupP_free = 35;
            /// <summary>Value = 36</summary>
            public static readonly int pidSupI_free = 36;
            /// <summary>Value = 37</summary>
            public static readonly int areaSensorFront = 37;
            /// <summary>Value = 38</summary>
            public static readonly int areaSensorRight = 38;
            /// <summary>Value = 39</summary>
            public static readonly int areaSensorLeft = 39;
            /// <summary>Value = 40</summary>
            public static readonly int pidHighGain = 40;
            /// <summary>Value = 41</summary>
            public static readonly int mapRoute = 41;
        }
        public static class Path {
            /// <summary>Value = "../../StepTest/"</summary>
            public static readonly string sensorConfig = "../../StepTest/";
            /// <summary>Value = "SensorConfig.csv"</summary>
            public static readonly string sensorConfig2 = "SensorConfig.csv";
            /// <summary>Value = "../../StepTest/"</summary>
            public static readonly string pathRoute = "../../StepTest/";
        }
        public static class Define {
            /// <summary>Value = "AUTO"</summary>
            public static readonly string auto = "AUTO";
            /// <summary>Value = "Continue"</summary>
            public static readonly string contiNue = "Continue";
            /// <summary>Value = "_กรุณาปิด csv ก่อน"</summary>
            public static readonly string csvError = "_กรุณาปิด csv ก่อน";
            /// <summary>Value = "Enter PassWord"</summary>
            public static readonly string enterPassWord = "Enter PassWord";
            /// <summary>Value = "Password Error!!"</summary>
            public static readonly string passWordError = "Password Error!!";
        }
        #endregion

        private void bt_cameraDetectF_Click(object sender, EventArgs e) {
            cameraRL.flagDepthRoll = true;
        }
        private void bt_railFalse_Click(object sender, EventArgs e) {
            cameraRL.flagRailDif = false;
        }
        private void bt_railTrue_Click(object sender, EventArgs e) {
            cameraRL.flagRailDif = true;
        }
    }
}
