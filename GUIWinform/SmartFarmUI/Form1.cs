using Solid.Arduino;
using Solid.Arduino.Firmata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace SmartFarmUI
{
    public partial class Form1 : Form
    {
        Timer timer1;
        Timer timer2;

        double current_time = 0;
        Boolean LOG_ENABLE = false;
        ArduinoSession arduinoSession = null;
        
        RealtimeData realtimeData;
        bool[] relay_state = { false, false, false, false };
        public Form1()
        {
            InitializeComponent();
            init();
            timer1 = new Timer();
            timer1.Tick += Timer1_Tick;
            timer1.Interval = 100;
            timer1.Enabled = true;
            realtimeData = new RealtimeData();

            timer2 = new Timer();
            timer2.Tick += Timer2_Tick; ;
            timer2.Interval = 100;
            timer2.Enabled = true;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            
            lblApSuat.Text = realtimeData.CurrentPresure + " hPa";
            lblDoAm.Text = realtimeData.CurrentHumid.ToString()  + " %";
          
            lblDoAmDat.Text = realtimeData.CurrentMoiSensor.ToString() + " %";


            if (realtimeData.CurrentMoiSensor < Convert.ToInt32(txtConditionBom.Text))
            {
                lblDoAmDat.ForeColor = Color.Red;
                if (checkAutoMode.Checked && relay_state[0] == false)
                {
                    lblBomStatus.Text = "ON";
                    excuteRelayBom(true);
                }
            }
            else
            {
                lblDoAmDat.ForeColor = Color.Green;
                if(checkAutoMode.Checked && relay_state[0] == true)
                {
                    excuteRelayBom(false);
                    lblBomStatus.Text = "OFF";
                }
            }

            lblNhietDo.Text = realtimeData.CurrentTemperature.ToString() + " °C";

            if (realtimeData.CurrentTemperature > Convert.ToInt32(txtConditionQuat.Text))
            {
                lblNhietDo.ForeColor = Color.Red;
                if (checkAutoMode.Checked && relay_state[1] == false)
                {
                    lblQuatStatus.Text = "ON";
                    excuteRelayQuat(true);
                }
                
            }
            else
            {
                lblNhietDo.ForeColor = Color.Green;
                if (checkAutoMode.Checked && relay_state[1] == true)
                {
                    lblQuatStatus.Text = "OFF";
                    excuteRelayQuat(false);
                }

            }
            lblTimeUpdate.Text = current_time.ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Draw(0);
            //Draw(1);
            //Draw(2);
        }



        public void init()
        {
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Đồ thị dữ liệu theo thời gian";
            myPane.XAxis.Title.Text = "Thời gian (s)";
            myPane.YAxis.Title.Text = "Dữ liệu";

            RollingPointPairList list = new RollingPointPairList(60000);
            RollingPointPairList list1 = new RollingPointPairList(60000);
            //RollingPointPairList list2 = new RollingPointPairList(60000);
            RollingPointPairList list3 = new RollingPointPairList(60000);

            LineItem doam_curve = myPane.AddCurve("Độ ẩm", list, Color.Red, SymbolType.None);
            LineItem nhietdo_curve = myPane.AddCurve("Nhiệt độ", list1, Color.Green, SymbolType.None);
            //LineItem apsuat_dat_curve = myPane.AddCurve("Áp suất", list2, Color.Gray, SymbolType.None);
            LineItem doam_dat_curve = myPane.AddCurve("Độ ẩm đất", list3, Color.Blue, SymbolType.None);

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 30;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 5;
            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 100;

            myPane.AxisChange();
        }
        // Vẽ đồ thị
        private void Draw(int curve_idx, double datas)
        {
            current_time += 100;
            double realtime = current_time / 1000;
            //double datas = 0;
            //Random r = new Random((int)current_time);
            //int rInt = r.Next(0, 100); //for ints
            // int range = 100;
            //  datas = r.NextDouble() * range; //for doubles

            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;

            LineItem curve = zedGraphControl1.GraphPane.CurveList[curve_idx] as LineItem;

            if (curve == null)
                return;

            IPointListEdit list = curve.Points as IPointListEdit;

            if (list == null)
                return;

            list.Add(realtime, datas); // Thêm điểm trên đồ thị

            Scale xScale = zedGraphControl1.GraphPane.XAxis.Scale;
            Scale yScale = zedGraphControl1.GraphPane.YAxis.Scale;

            // Tự động Scale theo trục x
            if (realtime > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = realtime + xScale.MajorStep;
                xScale.Min = xScale.Max - 30;
            }

            // Tự động Scale theo trục y
            if (datas > yScale.Max - yScale.MajorStep)
            {
                yScale.Max = datas + yScale.MajorStep;
            }
            else if (datas < yScale.Min + yScale.MajorStep)
            {
                yScale.Min = datas - yScale.MajorStep;
            }

            //zedGraphControl1.Refresh();
            zedGraphControl1.Invoke((MethodInvoker)delegate ()
            {
                zedGraphControl1.AxisChange();
                zedGraphControl1.Invalidate();

                zedGraphControl1.Refresh();
            });
        }

        // Xóa đồ thị, với ZedGraph thì phải khai báo lại như ở hàm Form1_Load, nếu không sẽ không hiển thị
        private void ClearZedGraph()
        {
            zedGraphControl1.GraphPane.CurveList.Clear(); // Xóa đường
            zedGraphControl1.GraphPane.GraphObjList.Clear(); // Xóa đối tượng

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();

            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Đồ thị dữ liệu theo thời gian";
            myPane.XAxis.Title.Text = "Thời gian (s)";
            myPane.YAxis.Title.Text = "Dữ liệu";

            RollingPointPairList list = new RollingPointPairList(60000);
            LineItem curve = myPane.AddCurve("Dữ liệu", list, Color.Red, SymbolType.None);


            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 30;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 5;
            myPane.YAxis.Scale.Min = -100;
            myPane.YAxis.Scale.Max = 100;

            zedGraphControl1.AxisChange();
        }


        #region CONTROL

        #endregion



        private void btnAutoConnect_Click(object sender, EventArgs e)
        {

            ISerialConnection connection = GetConnection();
            arduinoSession = null;
            if (connection != null)
            {
                arduinoSession = new ArduinoSession(connection);
                arduinoSession.MessageReceived += Session_MessageReceived;
                arduinoSession.StringReceived += Session_StringReceived;
                arduinoSession.DigitalStateReceived += ArduinoSession_DigitalStateReceived;

            }

        }

        private void ArduinoSession_DigitalStateReceived(object sender, FirmataEventArgs<DigitalPortState> eventArgs)
        {
            return;
        }

        private void Session_StringReceived(object sender, StringEventArgs eventArgs)
        {
            txtLog.Text += ($"[String evnt] {eventArgs.Text}.\n");
        }

        private ISerialConnection GetConnection()
        {
            ISerialConnection connection = null;
            Console.WriteLine("Searching Arduino connection...");
            try {
                connection = EnhancedSerialConnection.Find();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng kiểm tra lại arduino. Reset và thử nhận diện lại!!!"); 
            }
            if (connection == null)
            {
                txtLog.Text += ("No connection found. Make shure your Arduino board is attached to a USB port.\n");
                Console.WriteLine("No connection found. Make shure your Arduino board is attached to a USB port.");
            }
            else
            {
                txtLog.Text += ($"Connected to port {connection.PortName} at {connection.BaudRate} baud.\n");
                this.txtPort.Text = connection.PortName;
                this.txtBaundrate.Text = connection.BaudRate.ToString();
                Console.WriteLine($"Connected to port {connection.PortName} at {connection.BaudRate} baud.");
            }
            return connection;
        }

        private void processMessage(String msg)
        {
            if (msg.Contains("Sensor error")) return;

            if (msg.Contains("report"))
            {
                String[] parsed_data = msg.Split('|');

                //Do am, nhiet do, ap suat, do am dat 
                switch (parsed_data[1])
                {
                    case "bmp":
                        realtimeData.CurrentTemperature = Convert.ToDouble(parsed_data[3]);
                        realtimeData.CurrentPresure = Convert.ToDouble(parsed_data[2]);
                        Draw(1, realtimeData.CurrentTemperature);
                        //Draw(2, realtimeData.CurrentPresure
                        break;
                    case "dht":
                        realtimeData.CurrentHumid = Convert.ToDouble(parsed_data[2]);
                        Draw(0, realtimeData.CurrentHumid);

                        break;
                    case "moi":
                        realtimeData.CurrentMoiSensor = Convert.ToInt32(parsed_data[2]);
                        Draw(2, realtimeData.CurrentMoiSensor);
                        break;
                }
            }
        }
        private void Session_MessageReceived(object sender, FirmataMessageEventArgs eventArgs)
        {
            if (LOG_ENABLE)
            {
                txtLog.Invoke((MethodInvoker)delegate ()
                {
                    txtLog.Text += $"Received Message {eventArgs.Value}\n";
                });
                Console.WriteLine("Received Message " + eventArgs.Value);
            }
            var value = eventArgs.Value;
            var msg = value.Value;
            if (msg.GetType() == typeof(Solid.Arduino.Firmata.StringData))
            {
                StringData data = (StringData)msg;

                processMessage(data.Text);

                txtLog.Invoke((MethodInvoker)delegate ()
                {
                    txtLog.Text += $"arduino response:  [{data.Text}]\n";

                });
                Console.WriteLine("String data from arduino: " + data.Text);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        private void btnSendString_Click(object sender, EventArgs e)
        {
            string body = txtStringData.Text;
            if (arduinoSession != null)
            {
                arduinoSession.SendStringData(body);
            }
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {
            if (checkAutoScroll.Checked)
            {
                txtLog.SelectionStart = txtLog.Text.Length;
                // scroll it automatically
                txtLog.ScrollToCaret();
            }

        }
        private void excuteRelayBom(bool state)
        {
            if (arduinoSession == null) { return; }

            arduinoSession.SetDigitalPinMode(2, PinMode.DigitalOutput);
            arduinoSession.SetDigitalPin(2, state);
            relay_state[0] = state;
        }
        private void excuteRelayQuat(bool state)
        {
            if(arduinoSession == null) { return; }
            arduinoSession.SetDigitalPinMode(3, PinMode.DigitalOutput);
            arduinoSession.SetDigitalPin(3, state);
            relay_state[1] = state;
        }
        

        private void btnRelayBom_Click(object sender, EventArgs e)
        {
            if (arduinoSession == null) { return; }

            arduinoSession.SetDigitalPinMode(2, PinMode.DigitalOutput);
            arduinoSession.SetDigitalPin(2, !relay_state[0]);
            relay_state[0] = !relay_state[0];


        }

        private void btnRelayQuat_Click(object sender, EventArgs e)
        {
            if (arduinoSession == null) { return; }

            arduinoSession.SetDigitalPinMode(3, PinMode.DigitalOutput);

            arduinoSession.SetDigitalPin(3, !relay_state[1]);
            relay_state[1] = !relay_state[1];

        }
    }
}
