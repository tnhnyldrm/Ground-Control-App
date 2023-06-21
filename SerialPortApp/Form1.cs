using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Threading.Timer;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Drawing.Imaging;

namespace SerialPortApp
{
    public partial class Form1 : Form
    {
        //MARKER: SMALL PICTURES OR DRAWINGS ON THE MAPS

        int homemarkerfirstDraw = 0; //HOME MARKER CONTROLER IT PREVENT PUT HOME MARKER ON TOP OF THE DRONE MARKER
        int routecontrol = 0; //IT PREVENTS DRAWING TOO MUCH ROUTES 

        Bitmap bmpMarkerhome = (Bitmap)Image.FromFile(@"C:\Users\TNA\Desktop\SerialPortProcess_yedek\heliportv5.png"); //DRONE MARKER PNG GETS FROM PC
        
        GMapOverlay markershome; //IDENTIFY HOME MARKERS HOLDERS
        GMarkerGoogle markerhome;

        double last_time;

        double lat_goto; //FOR DESTION LOCATIONS TO SEND DRONE
        double lng_goto;

        int dronelogocount = 0;//FOR CONTROL DRONE ICON ON THE SCREEN

        GMapOverlay markers; //IDENTIFY DRONE MARKERS HOLDERS
        GMarkerGoogle marker;
        double droneroutelat;
        double droneroutelng;

        GMapRoute line_layer; //IDENTIFY ROUTES MARKERS HOLDERS
        GMapOverlay line_overlay = new GMapOverlay();

        // Load images
        Bitmap mybitmap1 = new Bitmap(@"C:\Users\TNA\Desktop\SerialPortProcess_yedek\SerialPortApp\Resources\horizon.bmp");  //VIRTUAL HORİZON PCITURES GETS FROM PC
        Bitmap mybitmap2 = new Bitmap(@"C:\Users\TNA\Desktop\SerialPortProcess_yedek\SerialPortApp\Resources\bezel.bmp");
        Bitmap mybitmap3 = new Bitmap(@"C:\Users\TNA\Desktop\SerialPortProcess_yedek\SerialPortApp\Resources\heading.bmp");
        Bitmap mybitmap4 = new Bitmap(@"C:\Users\TNA\Desktop\SerialPortProcess_yedek\SerialPortApp\Resources\wings.bmp");


        double PitchAngle = 0; //FOR VIRTUAL HORIZON
        double RollAngle = 0;
        double YawAngle = 0;

        Point ptBoule = new Point(-25, -410); //Ground-Sky initial location
        Point ptHeading = new Point(-592, 150); // Heading ticks
        Point ptRotation = new Point(150, 150); // Point of rotation

        public static int logcount = 0;
        public int logtimeyear = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd")); //FOR CSV LOG GETS TİME
        public int logtimeclock = Convert.ToInt32(DateTime.Now.ToString("HHmmss"));

        public long temp_timer;  //FOR CHECKING LINK CONNECTION
        public long temp_time_now;
        public long temp_time_last;
        public int init = 0;
        public long dif;
        public long runtime_ms_last;

        static float temp_angle = 0; //FOR DRONE MARKERS ROTATE

        public static int limit = 0; //FOR CHECKING SEND PACKET LIMIT 

        const byte HEADER = 0xAB;
        const byte FOOTER = 0xED;
        const byte GCS_ID = 0x01;
        const byte UAV_ID = 0x02;

        const System.UInt16 TELEMETRY_10HZ = 0x10A0;
        const System.UInt16 TELEMETRY_1HZ = 0x10A1;
        const System.UInt16 PID_GAIN_READ = 0x2010;
        const System.UInt16 PID_GAIN_WRITE = 0x2011;

        const System.UInt16 CONSOLE_COMMAND = 0x3010;
        const System.UInt16 CONSOLE_OUTPUT = 0x3011;
        const System.UInt16 DISARM_COMMAND = 0x4010;
        const System.UInt16 ARM_COMMAND = 0x4011;
        const System.UInt16 TAKEOFF_COMMAND = 0x4012;
        const System.UInt16 LAND_COMMAND = 0x4013;
        const System.UInt16 RTL_COMMAND = 0x4014;
        const System.UInt16 ALT_INCREASE_COMMAND = 0x4015;
        const System.UInt16 ALT_DECREASE_COMMAND = 0x4016;
        const System.UInt16 YAW_CW_COMMAND = 0x4017;
        const System.UInt16 YAW_CCW_COMMAND = 0x4018;
        const System.UInt16 GOTO_COMMAND = 0x4019;
        const System.UInt16 AUTO_COMMAND = 0x4020;
        const System.UInt16 BRAKE_COMMAND = 0x4021;
        const System.UInt16 TELEMETRY_HEARTBEAT = 0x10A2;

        const System.UInt16 TEST_PARAM_READ = 0x2012;
        const System.UInt16 TEST_PARAM_WRITE = 0x2013;

        public struct buffer_type
        {
            public System.UInt16 size;
            public System.UInt16 counter;
            public System.UInt16 command;
            public System.UInt16 rcv_crc;
            public byte[] data;
        };


        static buffer_type container;

        static parser_state_type state = parser_state_type.HEADER;

        static byte[] buffer;
        System.UInt16 size = 0;
        System.UInt16 size_crc = 2;
        System.UInt16 k = 0;
        int error = 0;

        struct pid_data_type
        {
            public float roll_rate_kp;
            public float roll_rate_ki;
            public float roll_rate_kd;
            public float roll_rate_kff;
            public float roll_rate_input_limit;
            public float roll_rate_input_rate_limit;
            public float roll_rate_output_limit;
            public float roll_rate_ki_limit;
            public float roll_rate_kd_limit;
            public float roll_rate_kd_filter_freq;
            public float pitch_rate_kp;
            public float pitch_rate_ki;
            public float pitch_rate_kd;
            public float pitch_rate_kff;
            public float pitch_rate_input_limit;
            public float pitch_rate_input_rate_limit;
            public float pitch_rate_output_limit;
            public float pitch_rate_ki_limit;
            public float pitch_rate_kd_limit;
            public float pitch_rate_kd_filter_freq;
            public float roll_kp;
            public float roll_ki;
            public float roll_kd;
            public float roll_kff;
            public float roll_input_limit;
            public float roll_input_rate_limit;
            public float roll_output_limit;
            public float roll_ki_limit;
            public float roll_kd_limit;
            public float roll_kd_filter_freq;
            public float pitch_kp;
            public float pitch_ki;
            public float pitch_kd;
            public float pitch_kff;
            public float pitch_input_limit;
            public float pitch_input_rate_limit;
            public float pitch_output_limit;
            public float pitch_ki_limit;
            public float pitch_kd_limit;
            public float pitch_kd_filter_freq;
        };

        struct test_param_data_type
        {
            public float test_1_f32;
            public float test_2_f32;
            public float test_3_f32;
            public float test_4_f32;
            public float test_5_f32;
            public float test_6_f32;
            public float test_7_f32;
            public float test_8_f32;
            public float test_9_f32;
            public float test_10_f32;
            public System.Int32 test_11_s32;
            public System.Int32 test_12_s32;
            public System.UInt32 test_13_u32;
            public System.UInt32 test_14_u32;
            public System.Int16 test_15_s16;
            public System.Int16 test_16_s16;
            public System.UInt16 test_17_u16;
            public System.UInt16 test_18_u16;
            public sbyte test_19_s8;
            public byte test_20_u8;
        }


        struct telem_data_type
        {
            public System.UInt32 runtime_ms; //4
            public System.Int32 latitude_e7; //8
            public System.Int32 longitude_e7; //12
            public System.Int16 roll_deg_m10; //14
            public System.Int16 roll_ref_deg_m10; //16
            public System.Int16 pitch_deg_m10; //18
            public System.Int16 pitch_ref_deg_m10; //20
            public System.Int16 yaw_deg_m10; //22
            public System.Int16 yaw_ref_deg_m10; //24
            public System.Int16 gyro_x_dps_m10; //26
            public System.Int16 gyro_y_dps_m10; //28
            public System.Int16 gyro_z_dps_m10; //30
            public System.Int16 lin_acc_x_mp2_m100; //32
            public System.Int16 lin_acc_y_mp2_m100; //34
            public System.Int16 lin_acc_z_mp2_m100; //36
            public System.Int16 asl_m_m10; //38
            public System.Int16 climb_rate_mps_m100; //40
            public System.UInt16 pwm1; //42
            public System.UInt16 pwm2; //44
            public System.UInt16 pwm3; //46
            public System.UInt16 pwm4; //48
            public System.UInt16 voltage_mv; //50
            public System.UInt16 current_a_m10; //52
            public byte flight_mode; //53
            public byte cpu_load; //54

            public System.Int32 utc_time_sec;       //58
            public System.Int32 ref_latitude_e7;    //62
            public System.Int32 ref_longitude_e7;   //66
            public System.Int32 home_latitude_e7;   //70
            public System.Int32 home_longitude_e7;  //74
            public System.UInt32 status_flags;      //78
            public System.Int16 mag_x_mg;           //80
            public System.Int16 mag_y_mg;           //82
            public System.Int16 mag_z_mg;           //84
            public System.Int16 agl_m;              //86
            public System.Int16 agl_ref_m;          //88
            public System.Int16 asl_gps_m;          //90
            public System.Int16 rangefinder_cm;     //92
            public System.Int16 ref_climb_rate_mps_m100;//94
            public System.Int16 gps_N_speed_cmps;   //96
            public System.Int16 gps_E_speed_cmps;   //98
            public System.Int16 ref_gps_N_speed_cmps;   //100
            public System.Int16 ref_gps_E_speed_cmps;   //102
            public System.Int16 ground_speed_cmps;      //104
            public System.UInt16 gps_pdop;              //106
            public System.UInt16 gps_hacc;              //108
            public System.UInt16 gps_vacc;              //110
            public System.UInt16 home_distance_m;       //112
            public System.UInt16 route_distance_m;      //114
            public System.UInt16 flight_time_sec;       //116
            public System.UInt16 power_milliwatt;       //118
            public System.UInt16 remaining_capacity;    //120
            public System.UInt16 throttle_out;          //122
            public byte pid_flight_mode;        //123
            public byte gps_satellite_number;   //124
            public byte battery_percent;        //125
            public byte test_0;                 //126
            public float test_1;                   //130
            public float test_2;                   //134
            public float test_3;                   //138
            public float test_4;                   //142
            public float test_5;                   //146
            public float test_6;                    //148


        };

        static pid_data_type pid;
        static telem_data_type telem;
        static test_param_data_type test;
        enum parser_state_type
        {
            HEADER = 0,
            SOURCE_ID = 1,
            DESTINATION_ID = 2,
            SIZE_LOW = 3,
            SIZE_HIGH = 4,
            COMMAND_LOW = 5,
            COMMAND_HIGH = 6,
            PAYLOAD = 7,
            CRC_LOW = 8,
            CRC_HIGH = 9,
            FOOTER = 10,
        };

        public Form1()
        {
            InitializeComponent();
            map.MapProvider = GMap.NET.MapProviders.GoogleHybridMapProvider.Instance; //hybrid map

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            GMaps.Instance.OptimizeMapDb(null);
            map.CacheLocation = @"C:\Users\TNA\Desktop\SerialPortProcess_yedek\Cache";

            map.ShowCenter = false; // diasble center red cross
            map.DragButton = MouseButtons.Left;
            map.Position = new PointLatLng(41.104600, 29.024160); //DEFAULT MAP POSITION CURRENTLY SET AT ITU EEE BUILDING
            map.MinZoom = 1;
            map.MaxZoom = 24;
            map.Zoom = 18;

            // This bit of code (using double buffer) reduces flicker from Refresh commands
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);  //THESE FOR VIRTUAL HORIZON
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //////////// END "reduce flicker" code ///////

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var seriPort in SerialPort.GetPortNames())
            {
                comboBoxPorts.Items.Add(seriPort);//ADD AVAIBLE PORTS TO COMBOBOX
            }

            //comboBoxPorts.SelectedIndex = 0;  //IT SELECT FIRST COMPORT WHEN FIRST RUN
            btnDisconnect.Enabled = false; //MAKE DISCONNCET BUTTON UNCLICKABLE

            mybitmap2.MakeTransparent(Color.Yellow); // Sets image transparency//THESE FOR VIRTUAL HORIZON
            mybitmap3.MakeTransparent(Color.Black); // Sets image transparency
            mybitmap4.MakeTransparent(Color.Yellow); // Sets image transparency
        }

        private void btnConnect_Click(object sender, EventArgs e)//COMPORT CONNECT BUTTON
        {
            //COMPORT CONNECT BUTTON
            try
            {
                serialPort1.PortName = comboBoxPorts.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudrate.Text);
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.DataBits = 8;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serialport connection error");
            }

            if (serialPort1.IsOpen)
            {
                btnConnect.Enabled = false; //MAKE CONNECT BUTTON UNCLICKABLE
                btnDisconnect.Enabled = true; //MAKE CONNECT BUTTON CLICKABLE
            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)//COMPORT DCONNECT BUTTON
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
            }
        }

        #region TEXTBOXWRITEFUNCTIONS
        public delegate void veriGoster(String s); //IF TEXTBOX GETS DATA FROM ANOTHER FUNCTION IT GIVES ERROR , TO FIX THAT WE USE DELEGATES
                                                   //THIS USING IS CORRECT BUT I FOUND ANOTHER SHORT AND USED WHEN ADDING EXTRA TELEMETRY

        public void textBoxYaz(String s)
        {
            txtBoxReceived.Text = s;
        }
        public void textBox1Yaz(String s)
        {
            textBox1.Text = s;
        }
        public void textBox2Yaz(String s)
        {
            textBox2.Text = s;
        }
        public void textBox3Yaz(String s)
        {
            textBox3.Text = s;
        }
        public void textBox4Yaz(String s)
        {
            textBox4.Text = s;
        }
        public void textBox5Yaz(String s)
        {
            textBox5.Text = s;
        }
        public void textBox6Yaz(String s)
        {
            textBox6.Text = s;
        }
        public void textBox7Yaz(String s)
        {
            textBox7.Text = s;
        }
        public void textBox8Yaz(String s)
        {
            textBox8.Text = s;
        }
        public void textBox9Yaz(String s)
        {
            textBox9.Text = s;
        }
        public void textBox10Yaz(String s)
        {
            textBox10.Text = s;
        }
        public void textBox11Yaz(String s)
        {
            textBox11.Text = s;
        }
        public void textBox12Yaz(String s)
        {
            textBox12.Text = s;
        }
        public void textBox13Yaz(String s)
        {
            textBox13.Text = s;
        }
        public void textBox14Yaz(String s)
        {
            textBox14.Text = s;
        }
        public void textBox15Yaz(String s)
        {
            textBox15.Text = s;
        }
        public void textBox16Yaz(String s)
        {
            textBox16.Text = s;
        }
        /*public void textBox17Yaz(String s)
        {
            textBox17.Text = s;
        }*/
        public void textBox18Yaz(String s)
        {
            textBox18.Text = s;
        }
        public void textBox19Yaz(String s)
        {
            textBox19.Text = s;
        }
        public void textBox20Yaz(String s)
        {
            textBox20.Text = s;
        }
        public void textBox21Yaz(String s)
        {
            textBox21.Text = s;
        }
        public void textBox22Yaz(String s)
        {
            textBox22.Text = s;
        }
        public void textBox23Yaz(String s)
        {
            textBox23.Text = s;
        }
        public void textBox24Yaz(String s)
        {
            textBox24.Text = s;
        }
        public void textBox25Yaz(String s)
        {
            textBox25.Text = s;
        }


        private delegate void SetTextDeleg(string text);
        #endregion

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //THIS FUNCTION READ DATA FROM SERIALPORT

            Thread.Sleep(50);//PC IS RUNNING TO FAST SO SOMETIMES IT GETS SAME DATA, THIS LINE FOR PREVENT THIS
            SerialPort serialPort1 = sender as SerialPort;
            byte[] dataReceive = new byte[serialPort1.BytesToRead];

            Stream portStream = serialPort1.BaseStream;
            portStream.Read(dataReceive, 0, dataReceive.Length);


            // HEADER | SOURCE_ID | DEST_ID | PAYLOAD_SIZE 	| COMMAND	| PAYLOAD  ---------- | CRC_LOW | CRC_HIGH | FOOTER
            // 0xAB   | 0x01      | 0x02    | 0x0021 		| 0x1020	| 0x01  ........ 0x09 | 0xAA    | 0xAC     | 0xED
            // Overhead is 10 bytes							| <----------  CALC CRC --------> |


            container.data = new byte[512];
            buffer = dataReceive;
            size = (System.UInt16)dataReceive.Length;


            //Console.WriteLine("size: " + size);
            //STATE MACHINE
            if (size > 0)
            {
                for (k = 0; k < size; k++)
                {
                    switch (state)
                    {
                        case parser_state_type.HEADER:
                            if (buffer[k] == HEADER)
                            {
                                container.command = 0;
                                container.size = 0;
                                container.counter = 0;
                                state = parser_state_type.SOURCE_ID;
                            }
                            break;


                        case parser_state_type.SOURCE_ID:
                            if (buffer[k] == UAV_ID)
                            {
                                state = parser_state_type.DESTINATION_ID;
                            }
                            else
                            {
                                error++;
                                state = parser_state_type.HEADER;
                            }
                            break;


                        case parser_state_type.DESTINATION_ID:
                            if (buffer[k] == GCS_ID)
                            {
                                state = parser_state_type.SIZE_LOW;
                            }
                            else
                            {
                                error++;
                                state = parser_state_type.HEADER;
                            }
                            break;


                        case parser_state_type.SIZE_LOW:
                            container.size = Convert.ToUInt16(buffer[k]);
                            state = parser_state_type.SIZE_HIGH;
                            break;


                        case parser_state_type.SIZE_HIGH:
                            container.size |= Convert.ToUInt16(buffer[k] << 8);
                            state = parser_state_type.COMMAND_LOW;
                            break;


                        case parser_state_type.COMMAND_LOW:
                            container.command = Convert.ToUInt16(buffer[k]);
                            container.data[container.counter++] = buffer[k];
                            state = parser_state_type.COMMAND_HIGH;
                            break;


                        case parser_state_type.COMMAND_HIGH:
                            container.command |= Convert.ToUInt16(buffer[k] << 8);
                            container.data[container.counter++] = buffer[k];
                            state = parser_state_type.PAYLOAD;
                            break;


                        case parser_state_type.PAYLOAD:
                            container.data[container.counter++] = buffer[k];
                            if (container.counter >= container.size + 2)
                            {
                                state = parser_state_type.CRC_LOW;
                            }
                            break;


                        case parser_state_type.CRC_LOW:
                            container.rcv_crc = Convert.ToUInt16(buffer[k]);
                            state = parser_state_type.CRC_HIGH;
                            break;


                        case parser_state_type.CRC_HIGH:
                            container.rcv_crc |= Convert.ToUInt16(buffer[k] << 8);
                            state = parser_state_type.FOOTER;
                            break;


                        case parser_state_type.FOOTER:
                            if (buffer[k] == FOOTER)
                            {
                                size_crc = (ushort)(container.size + 2);
                                if (CRC(container.data, size_crc, false) == container.rcv_crc)
                                {
                                    // Console.WriteLine("Process Packet OK");
                                    processReceivedPacket(container);
                                }
                                else
                                {
                                    error++;
                                }
                            }
                            else
                            {
                                error++;
                            }
                            state = parser_state_type.HEADER;
                            break;



                        default:
                            //Error
                            break;
                    }
                }
            }



            void processReceivedPacket(buffer_type packet)
            {
                string packet_dataString = BitConverter.ToString(packet.data);
                //Console.WriteLine("packet_dataString: " + packet.size);
                string[] returnedArray = packet_dataString.Split('-');
                switch (packet.command)
                {
                    case TELEMETRY_10HZ:
                        //telem.runtime_ms = Convert.ToUInt32(packet.data[2]) |
                        //                   Convert.ToUInt32(packet.data[3]) << 8 |
                        //                   Convert.ToUInt32(packet.data[4]) << 16 |
                        //                   Convert.ToUInt32(packet.data[5]) << 24;
                        //Console.WriteLine("runtime_ms_orj: " + telem.runtime_ms);
                        telem.runtime_ms = stringToUint32Converter(returnedArray[5] + returnedArray[4] + returnedArray[3] + returnedArray[2]);
                        telem.latitude_e7 = stringToint32Converter(returnedArray[9] + returnedArray[8] + returnedArray[7] + returnedArray[6]);
                        telem.longitude_e7 = stringToint32Converter(returnedArray[13] + returnedArray[12] + returnedArray[11] + returnedArray[10]);
                        telem.roll_deg_m10 = (short)stringToint16Converter(returnedArray[15] + returnedArray[14]);
                        telem.roll_ref_deg_m10 = (short)stringToint16Converter(returnedArray[17] + returnedArray[16]);
                        telem.pitch_deg_m10 = (short)stringToint16Converter(returnedArray[19] + returnedArray[18]);
                        telem.pitch_ref_deg_m10 = (short)stringToint16Converter(returnedArray[21] + returnedArray[20]);
                        telem.yaw_deg_m10 = (short)stringToint16Converter(returnedArray[23] + returnedArray[22]);
                        telem.yaw_ref_deg_m10 = (short)stringToint16Converter(returnedArray[25] + returnedArray[24]);
                        telem.gyro_x_dps_m10 = (short)stringToint16Converter(returnedArray[27] + returnedArray[26]);
                        telem.gyro_y_dps_m10 = (short)stringToint16Converter(returnedArray[29] + returnedArray[28]);
                        telem.gyro_z_dps_m10 = (short)stringToint16Converter(returnedArray[31] + returnedArray[30]);
                        telem.lin_acc_x_mp2_m100 = (short)stringToint16Converter(returnedArray[33] + returnedArray[32]);
                        telem.lin_acc_y_mp2_m100 = (short)stringToint16Converter(returnedArray[35] + returnedArray[34]);
                        telem.lin_acc_z_mp2_m100 = (short)stringToint16Converter(returnedArray[37] + returnedArray[36]);
                        telem.asl_m_m10 = (short)stringToint16Converter(returnedArray[39] + returnedArray[38]);
                        telem.climb_rate_mps_m100 = (short)stringToint16Converter(returnedArray[41] + returnedArray[40]);
                        telem.pwm1 = (ushort)stringToint16Converter(returnedArray[43] + returnedArray[42]);
                        telem.pwm2 = (ushort)stringToUint16Converter(returnedArray[45] + returnedArray[44]);
                        telem.pwm3 = (ushort)stringToUint16Converter(returnedArray[47] + returnedArray[46]);
                        telem.pwm4 = (ushort)stringToUint16Converter(returnedArray[49] + returnedArray[48]);
                        telem.voltage_mv = (ushort)stringToUint16Converter(returnedArray[51] + returnedArray[50]);
                        telem.current_a_m10 = (ushort)stringToUint16Converter(returnedArray[53] + returnedArray[52]);
                        telem.flight_mode = (byte)stringToByte(returnedArray[54]);
                        telem.cpu_load = (byte)stringToByte(returnedArray[55]);

                        telem.utc_time_sec = stringToint32Converter(returnedArray[59] + returnedArray[58] + returnedArray[57] + returnedArray[56]);
                        telem.ref_latitude_e7 = stringToint32Converter(returnedArray[63] + returnedArray[62] + returnedArray[61] + returnedArray[60]);
                        telem.ref_longitude_e7 = stringToint32Converter(returnedArray[67] + returnedArray[66] + returnedArray[65] + returnedArray[64]);
                        telem.home_latitude_e7 = stringToint32Converter(returnedArray[71] + returnedArray[70] + returnedArray[69] + returnedArray[68]);
                        telem.home_longitude_e7 = stringToint32Converter(returnedArray[75] + returnedArray[74] + returnedArray[73] + returnedArray[72]);
                        telem.status_flags = stringToUint32Converter(returnedArray[79] + returnedArray[78] + returnedArray[77] + returnedArray[76]);
                        telem.mag_x_mg = (short)stringToint16Converter(returnedArray[81] + returnedArray[80]);
                        telem.mag_y_mg = (short)stringToint16Converter(returnedArray[83] + returnedArray[82]);
                        telem.mag_z_mg = (short)stringToint16Converter(returnedArray[85] + returnedArray[84]);
                        telem.agl_m = (short)stringToint16Converter(returnedArray[87] + returnedArray[86]);
                        telem.agl_ref_m = (short)stringToint16Converter(returnedArray[89] + returnedArray[88]);
                        telem.asl_gps_m = (short)stringToint16Converter(returnedArray[91] + returnedArray[90]);
                        telem.rangefinder_cm = (short)stringToint16Converter(returnedArray[93] + returnedArray[92]);
                        telem.ref_climb_rate_mps_m100 = (short)stringToint16Converter(returnedArray[95] + returnedArray[94]);
                        telem.gps_N_speed_cmps = (short)stringToint16Converter(returnedArray[97] + returnedArray[96]);
                        telem.gps_E_speed_cmps = (short)stringToint16Converter(returnedArray[99] + returnedArray[98]);
                        telem.ref_gps_N_speed_cmps = (short)stringToint16Converter(returnedArray[101] + returnedArray[100]);
                        telem.ref_gps_E_speed_cmps = (short)stringToint16Converter(returnedArray[103] + returnedArray[102]);
                        telem.ground_speed_cmps = (short)stringToint16Converter(returnedArray[105] + returnedArray[104]);
                        telem.gps_pdop = (ushort)stringToint16Converter(returnedArray[107] + returnedArray[106]);
                        telem.gps_hacc = (ushort)stringToint16Converter(returnedArray[109] + returnedArray[108]);
                        telem.gps_vacc = (ushort)stringToint16Converter(returnedArray[111] + returnedArray[110]);
                        telem.home_distance_m = (ushort)stringToint16Converter(returnedArray[113] + returnedArray[112]);
                        telem.route_distance_m = (ushort)stringToint16Converter(returnedArray[115] + returnedArray[114]);
                        telem.flight_time_sec = (ushort)stringToint16Converter(returnedArray[117] + returnedArray[116]);
                        telem.power_milliwatt = (ushort)stringToint16Converter(returnedArray[119] + returnedArray[118]);
                        telem.remaining_capacity = (ushort)stringToint16Converter(returnedArray[121] + returnedArray[120]);
                        telem.throttle_out = (ushort)stringToint16Converter(returnedArray[123] + returnedArray[122]);
                        telem.pid_flight_mode = (byte)stringToByte(returnedArray[124]);
                        telem.gps_satellite_number = (byte)stringToByte(returnedArray[125]);
                        telem.battery_percent = (byte)stringToByte(returnedArray[126]);
                        telem.test_0 = (byte)stringToByte(returnedArray[127]);
                        telem.test_1 = floatConverter(returnedArray[131] + returnedArray[130] + returnedArray[129] + returnedArray[128]);
                        telem.test_2 = floatConverter(returnedArray[135] + returnedArray[134] + returnedArray[133] + returnedArray[132]);
                        telem.test_3 = floatConverter(returnedArray[139] + returnedArray[138] + returnedArray[137] + returnedArray[136]);
                        telem.test_4 = floatConverter(returnedArray[143] + returnedArray[142] + returnedArray[141] + returnedArray[140]);
                        telem.test_5 = floatConverter(returnedArray[147] + returnedArray[146] + returnedArray[145] + returnedArray[144]);
                        telem.test_6 = floatConverter(returnedArray[151] + returnedArray[150] + returnedArray[149] + returnedArray[148]);

                        #region TextBoxInfoToWrite
                        //OLD WAY OF TEXTBOX WRITING
                        txtBoxReceived.Invoke(new veriGoster(textBoxYaz), intTostringConverter(telem.runtime_ms));
                        txtBoxReceived.Invoke(new veriGoster(textBox1Yaz), intTostringConverter(telem.latitude_e7));
                        txtBoxReceived.Invoke(new veriGoster(textBox2Yaz), intTostringConverter(telem.longitude_e7));
                        txtBoxReceived.Invoke(new veriGoster(textBox3Yaz), intTostringConverter(telem.roll_deg_m10 / (float)10));
                        txtBoxReceived.Invoke(new veriGoster(textBox4Yaz), intTostringConverter(telem.roll_ref_deg_m10 / (float)10));
                        txtBoxReceived.Invoke(new veriGoster(textBox5Yaz), intTostringConverter(telem.pitch_deg_m10 / (float)10));
                        txtBoxReceived.Invoke(new veriGoster(textBox6Yaz), intTostringConverter(telem.pitch_ref_deg_m10 / (float)10));
                        txtBoxReceived.Invoke(new veriGoster(textBox7Yaz), intTostringConverter(telem.yaw_deg_m10 / (float)10));
                        txtBoxReceived.Invoke(new veriGoster(textBox8Yaz), intTostringConverter(telem.yaw_ref_deg_m10 / (float)10));
                        txtBoxReceived.Invoke(new veriGoster(textBox9Yaz), intTostringConverter(telem.gyro_x_dps_m10 / (float)10));
                        txtBoxReceived.Invoke(new veriGoster(textBox10Yaz), intTostringConverter(telem.gyro_y_dps_m10 / (float)10));
                        txtBoxReceived.Invoke(new veriGoster(textBox11Yaz), intTostringConverter(telem.gyro_z_dps_m10 / (float)10));
                        txtBoxReceived.Invoke(new veriGoster(textBox12Yaz), intTostringConverter(telem.lin_acc_x_mp2_m100 / (float)100));
                        txtBoxReceived.Invoke(new veriGoster(textBox13Yaz), intTostringConverter(telem.lin_acc_y_mp2_m100 / (float)100));
                        txtBoxReceived.Invoke(new veriGoster(textBox14Yaz), intTostringConverter(telem.lin_acc_z_mp2_m100 / (float)100));
                        txtBoxReceived.Invoke(new veriGoster(textBox15Yaz), intTostringConverter(telem.asl_m_m10 / (float)10));
                        txtBoxReceived.Invoke(new veriGoster(textBox16Yaz), intTostringConverter(telem.climb_rate_mps_m100 / (float)100));
                        txtBoxReceived.Invoke(new veriGoster(textBox18Yaz), intTostringConverter(telem.pwm1));
                        txtBoxReceived.Invoke(new veriGoster(textBox19Yaz), intTostringConverter(telem.pwm2));
                        txtBoxReceived.Invoke(new veriGoster(textBox20Yaz), intTostringConverter(telem.pwm3));
                        txtBoxReceived.Invoke(new veriGoster(textBox21Yaz), intTostringConverter(telem.pwm4));
                        txtBoxReceived.Invoke(new veriGoster(textBox22Yaz), intTostringConverter(telem.voltage_mv / (float)1000));
                        txtBoxReceived.Invoke(new veriGoster(textBox23Yaz), intTostringConverter(telem.current_a_m10 / (float)1000));
                        txtBoxReceived.Invoke(new veriGoster(textBox24Yaz), intTostringConverter(telem.flight_mode));
                        txtBoxReceived.Invoke(new veriGoster(textBox25Yaz), intTostringConverter(telem.cpu_load));

                        //NEW SHORT WAY OF TEXTBOX WRITING, IT DOES THE SAME JOB
                        BeginInvoke(new Action(delegate () { textBox67.Text = telem.utc_time_sec.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox83.Text = telem.ref_latitude_e7.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox73.Text = telem.ref_longitude_e7.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox75.Text = telem.home_latitude_e7.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox70.Text = telem.home_longitude_e7.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox71.Text = telem.status_flags.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox81.Text = telem.mag_x_mg.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox82.Text = telem.mag_y_mg.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox77.Text = telem.mag_z_mg.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox69.Text = telem.agl_m.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox74.Text = telem.agl_ref_m.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox78.Text = telem.asl_gps_m.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox76.Text = telem.rangefinder_cm.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox68.Text = telem.ref_climb_rate_mps_m100.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox79.Text = telem.gps_N_speed_cmps.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox72.Text = telem.gps_E_speed_cmps.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox80.Text = telem.ref_gps_N_speed_cmps.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox84.Text = telem.ref_gps_E_speed_cmps.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox85.Text = telem.ground_speed_cmps.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox86.Text = telem.gps_pdop.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox106.Text = telem.gps_hacc.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox105.Text = telem.gps_vacc.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox95.Text = telem.home_distance_m.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox97.Text = telem.route_distance_m.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox92.Text = telem.flight_time_sec.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox93.Text = telem.power_milliwatt.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox103.Text = telem.remaining_capacity.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox104.Text = telem.throttle_out.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox99.Text = telem.pid_flight_mode.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox91.Text = telem.gps_satellite_number.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox96.Text = telem.battery_percent.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox100.Text = telem.test_0.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox98.Text = telem.test_1.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox90.Text = telem.test_2.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox101.Text = telem.test_3.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox94.Text = telem.test_4.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox102.Text = telem.test_5.ToString(); }));
                        BeginInvoke(new Action(delegate () { textBox89.Text = telem.test_6.ToString(); }));
                        

                        #endregion
                        //DRAW DRONE MARKER WHEN THE NEW DATA CAME
                        show_drone_logo((double)(telem.latitude_e7 / (double)10000000), (double)(telem.longitude_e7 / (double)10000000), (float)(telem.yaw_deg_m10 / (float)10));
                        if (routecontrol == 0)//PREVENT DRAWING TOO MUCH ROUTES
                        {
                            routeMarker();
                            routecontrol = 1;
                        }
                        BeginInvoke(new Action(delegate () { deleterouteAuto(); }));//CHECK AND DELETE ROUTES //WE USE DELEGATE TO PREVENT ERROR THE FUNCTION IS deleterouteAuto();

                        if (homemarkerfirstDraw == 0)//TO PREVENT REPEATITLY DRAW HOME ICON
                        {
                            homeMarker();

                            homemarkerfirstDraw = 1;
                        }
                        homeMarkerPos();//CHANGE POSITION OF THE HOME ICON

                        PitchAngle = telem.pitch_deg_m10 / 10; //VIRTUAL HORIZONS VALUES
                        RollAngle = (telem.roll_deg_m10 / 10) * Math.PI / 180;
                        YawAngle = (double)(telem.yaw_deg_m10 / 10) * Math.PI / 180;

                        Invalidate();

                        #region CSVLOGDATA
                        //ADDS DATA TO CSV
                        addCSV(telem.runtime_ms + ";" +
                               telem.latitude_e7 + ";" +
                               telem.longitude_e7 + ";" +
                               telem.roll_deg_m10 / (float)10 + ";" +
                               telem.roll_ref_deg_m10 / (float)10 + ";" +
                               telem.pitch_deg_m10 / (float)10 + ";" +
                               telem.pitch_ref_deg_m10 / (float)10 + ";" +
                               telem.yaw_deg_m10 / (float)10 + ";" +
                               telem.yaw_ref_deg_m10 / (float)10 + ";" +
                               telem.gyro_x_dps_m10 / (float)10 + ";" +
                               telem.gyro_y_dps_m10 / (float)10 + ";" +
                               telem.gyro_z_dps_m10 / (float)10 + ";" +
                               telem.lin_acc_x_mp2_m100 / (float)100 + ";" +
                               telem.lin_acc_y_mp2_m100 / (float)100 + ";" +
                               telem.lin_acc_z_mp2_m100 / (float)100 + ";" +
                               telem.asl_m_m10 / (float)10 + ";" +
                               telem.climb_rate_mps_m100 / (float)100 + ";" +
                               telem.pwm1 + ";" +
                               telem.pwm2 + ";" +
                               telem.pwm3 + ";" +
                               telem.pwm4 + ";" +
                               telem.voltage_mv / (float)1000 + ";" +
                               telem.current_a_m10 / (float)1000 + ";" +
                               telem.flight_mode + ";" +
                               telem.cpu_load + ";" +
                               telem.utc_time_sec + ";" +
                               telem.ref_latitude_e7 + ";" +
                               telem.ref_longitude_e7 + ";" +
                               telem.home_latitude_e7 + ";" +
                               telem.home_longitude_e7 + ";" +
                               telem.status_flags + ";" +
                               telem.mag_x_mg + ";" +
                               telem.mag_y_mg + ";" +
                               telem.mag_z_mg + ";" +
                               telem.agl_m + ";" +
                               telem.agl_ref_m + ";" +
                               telem.asl_gps_m + ";" +
                               telem.rangefinder_cm + ";" +
                               telem.ref_climb_rate_mps_m100 + ";" +
                               telem.gps_N_speed_cmps + ";" +
                               telem.gps_E_speed_cmps + ";" +
                               telem.ref_gps_N_speed_cmps + ";" +
                               telem.ref_gps_E_speed_cmps + ";" +
                               telem.ground_speed_cmps + ";" +
                               telem.gps_pdop + ";" +
                               telem.gps_hacc + ";" +
                               telem.gps_vacc + ";" +
                               telem.home_distance_m + ";" +
                               telem.route_distance_m + ";" +
                               telem.flight_time_sec + ";" +
                               telem.power_milliwatt + ";" +
                               telem.remaining_capacity + ";" +
                               telem.throttle_out + ";" +
                               telem.pid_flight_mode + ";" +
                               telem.gps_satellite_number + ";" +
                               telem.battery_percent + ";" +
                               telem.test_0 + ";" +
                               telem.test_1 + ";" +
                               telem.test_2 + ";" +
                               telem.test_3 + ";" +
                               telem.test_4 + ";" +
                               telem.test_5 + ";" +
                               telem.test_6, "log" + logtimeyear + logtimeclock + ".csv");
                        logcount = 1;

                        #endregion



                        break;

                    case PID_GAIN_READ:

                        #region pid read data

                        pid.roll_rate_kp = floatConverter(returnedArray[5] + returnedArray[4] + returnedArray[3] + returnedArray[2]);
                        pid.roll_rate_ki = floatConverter(returnedArray[9] + returnedArray[8] + returnedArray[7] + returnedArray[6]);
                        pid.roll_rate_kd = floatConverter(returnedArray[13] + returnedArray[12] + returnedArray[11] + returnedArray[10]);
                        pid.roll_rate_kff = floatConverter(returnedArray[17] + returnedArray[16] + returnedArray[15] + returnedArray[14]);
                        pid.roll_rate_input_limit = floatConverter(returnedArray[21] + returnedArray[20] + returnedArray[19] + returnedArray[18]);
                        pid.roll_rate_input_rate_limit = floatConverter(returnedArray[25] + returnedArray[24] + returnedArray[23] + returnedArray[22]);
                        pid.roll_rate_output_limit = floatConverter(returnedArray[29] + returnedArray[28] + returnedArray[27] + returnedArray[26]);
                        pid.roll_rate_ki_limit = floatConverter(returnedArray[33] + returnedArray[32] + returnedArray[31] + returnedArray[30]);
                        pid.roll_rate_kd_limit = floatConverter(returnedArray[37] + returnedArray[36] + returnedArray[35] + returnedArray[34]);
                        pid.roll_rate_kd_filter_freq = floatConverter(returnedArray[41] + returnedArray[40] + returnedArray[39] + returnedArray[38]);
                        pid.pitch_rate_kp = floatConverter(returnedArray[45] + returnedArray[44] + returnedArray[43] + returnedArray[42]);
                        pid.pitch_rate_ki = floatConverter(returnedArray[49] + returnedArray[48] + returnedArray[47] + returnedArray[46]);
                        pid.pitch_rate_kd = floatConverter(returnedArray[53] + returnedArray[52] + returnedArray[51] + returnedArray[50]);
                        pid.pitch_rate_kff = floatConverter(returnedArray[57] + returnedArray[56] + returnedArray[55] + returnedArray[54]);
                        pid.pitch_rate_input_limit = floatConverter(returnedArray[61] + returnedArray[60] + returnedArray[59] + returnedArray[58]);
                        pid.pitch_rate_input_rate_limit = floatConverter(returnedArray[65] + returnedArray[64] + returnedArray[63] + returnedArray[62]);
                        pid.pitch_rate_output_limit = floatConverter(returnedArray[69] + returnedArray[68] + returnedArray[67] + returnedArray[66]);
                        pid.pitch_rate_ki_limit = floatConverter(returnedArray[73] + returnedArray[72] + returnedArray[71] + returnedArray[70]);
                        pid.pitch_rate_kd_limit = floatConverter(returnedArray[77] + returnedArray[76] + returnedArray[75] + returnedArray[74]);
                        pid.pitch_rate_kd_filter_freq = floatConverter(returnedArray[81] + returnedArray[80] + returnedArray[79] + returnedArray[78]);
                        pid.roll_kp = floatConverter(returnedArray[85] + returnedArray[84] + returnedArray[83] + returnedArray[82]);
                        pid.roll_ki = floatConverter(returnedArray[89] + returnedArray[88] + returnedArray[87] + returnedArray[86]);
                        pid.roll_kd = floatConverter(returnedArray[93] + returnedArray[92] + returnedArray[91] + returnedArray[90]);
                        pid.roll_kff = floatConverter(returnedArray[97] + returnedArray[96] + returnedArray[95] + returnedArray[94]);
                        pid.roll_input_limit = floatConverter(returnedArray[101] + returnedArray[100] + returnedArray[99] + returnedArray[98]);
                        pid.roll_input_rate_limit = floatConverter(returnedArray[105] + returnedArray[104] + returnedArray[103] + returnedArray[102]);
                        pid.roll_output_limit = floatConverter(returnedArray[109] + returnedArray[108] + returnedArray[107] + returnedArray[106]);
                        pid.roll_ki_limit = floatConverter(returnedArray[113] + returnedArray[112] + returnedArray[111] + returnedArray[110]);
                        pid.roll_kd_limit = floatConverter(returnedArray[117] + returnedArray[116] + returnedArray[115] + returnedArray[114]);
                        pid.roll_kd_filter_freq = floatConverter(returnedArray[121] + returnedArray[120] + returnedArray[119] + returnedArray[118]);
                        pid.pitch_kp = floatConverter(returnedArray[125] + returnedArray[124] + returnedArray[123] + returnedArray[122]);
                        pid.pitch_ki = floatConverter(returnedArray[129] + returnedArray[128] + returnedArray[127] + returnedArray[126]);
                        pid.pitch_kd = floatConverter(returnedArray[133] + returnedArray[132] + returnedArray[131] + returnedArray[130]);
                        pid.pitch_kff = floatConverter(returnedArray[137] + returnedArray[136] + returnedArray[135] + returnedArray[134]);
                        pid.pitch_input_limit = floatConverter(returnedArray[141] + returnedArray[140] + returnedArray[139] + returnedArray[138]);
                        pid.pitch_input_rate_limit = floatConverter(returnedArray[145] + returnedArray[144] + returnedArray[143] + returnedArray[142]);
                        pid.pitch_output_limit = floatConverter(returnedArray[149] + returnedArray[148] + returnedArray[147] + returnedArray[146]);
                        pid.pitch_ki_limit = floatConverter(returnedArray[153] + returnedArray[152] + returnedArray[151] + returnedArray[150]);
                        pid.pitch_kd_limit = floatConverter(returnedArray[157] + returnedArray[156] + returnedArray[155] + returnedArray[154]);
                        pid.pitch_kd_filter_freq = floatConverter(returnedArray[161] + returnedArray[160] + returnedArray[159] + returnedArray[158]);

                        BeginInvoke(new Action(delegate () { update_piddata(); }));//UPDATE PID DATA

                        #endregion

                        //assign pid struct
                        break;

                    case TEST_PARAM_READ:

                        test.test_1_f32 = floatConverter(returnedArray[5] + returnedArray[4] + returnedArray[3] + returnedArray[2]);
                        test.test_2_f32 = floatConverter(returnedArray[9] + returnedArray[8] + returnedArray[7] + returnedArray[6]);
                        test.test_3_f32 = floatConverter(returnedArray[13] + returnedArray[12] + returnedArray[11] + returnedArray[10]);
                        test.test_4_f32 = floatConverter(returnedArray[17] + returnedArray[16] + returnedArray[15] + returnedArray[14]);
                        test.test_5_f32 = floatConverter(returnedArray[21] + returnedArray[20] + returnedArray[19] + returnedArray[18]);
                        test.test_6_f32 = floatConverter(returnedArray[25] + returnedArray[24] + returnedArray[23] + returnedArray[22]);
                        test.test_7_f32 = floatConverter(returnedArray[29] + returnedArray[28] + returnedArray[27] + returnedArray[26]);
                        test.test_8_f32 = floatConverter(returnedArray[33] + returnedArray[32] + returnedArray[31] + returnedArray[30]);
                        test.test_9_f32 = floatConverter(returnedArray[37] + returnedArray[36] + returnedArray[35] + returnedArray[34]);
                        test.test_10_f32 = floatConverter(returnedArray[41] + returnedArray[40] + returnedArray[39] + returnedArray[38]);
                        test.test_11_s32 = stringToint32Converter(returnedArray[45] + returnedArray[44] + returnedArray[43] + returnedArray[42]);
                        test.test_12_s32 = stringToint32Converter(returnedArray[49] + returnedArray[48] + returnedArray[47] + returnedArray[46]);
                        test.test_13_u32 = stringToUint32Converter(returnedArray[53] + returnedArray[52] + returnedArray[51] + returnedArray[50]);
                        test.test_14_u32 = stringToUint32Converter(returnedArray[57] + returnedArray[56] + returnedArray[55] + returnedArray[54]);
                        test.test_15_s16 = (short)stringToint16Converter(returnedArray[59] + returnedArray[58]);
                        test.test_16_s16 = (short)stringToint16Converter(returnedArray[61] + returnedArray[60]);
                        test.test_17_u16 = (ushort)stringToUint16Converter(returnedArray[63] + returnedArray[62]);
                        test.test_18_u16 = (ushort)stringToUint16Converter(returnedArray[65] + returnedArray[64]);
                        test.test_19_s8 = (sbyte)stringToSByte(returnedArray[66]);
                        test.test_20_u8 = (byte)stringToByte(returnedArray[67]);

                        BeginInvoke(new Action(delegate () { getexperimentaldata(); })); //UPDATE EXPERIMENTAL PID DATA


                        break;

                    case CONSOLE_COMMAND:

                        //delete first and last two byte
                        var source = packet.data;
                        var sourceStartIndex = 2;
                        var destinationLength = packet.size;
                        var destinationStartIndex = 0;
                        var destination = new byte[destinationLength];
                        Array.Copy(source, sourceStartIndex, destination, destinationStartIndex, destinationLength);

                        string result = System.Text.Encoding.ASCII.GetString(destination);
                        //Console.WriteLine("returnedArray: "+ result);
                        BeginInvoke(new Action(delegate ()
                        {
                            //Console.WriteLine("asd: " + result);
                            textBox65.AppendText(result);
                            //textBox65.AppendText(Environment.NewLine);
                        }));


                        break;



                    default:
                        //Unknown Command
                        error++;
                        break;
                }
            }



        }

        #region CONVERTERFUNCTIONS
        public float floatConverter(String s)
        {
            uint num = uint.Parse(s, System.Globalization.NumberStyles.AllowHexSpecifier);

            byte[] floatVals = BitConverter.GetBytes(num);
            float f = BitConverter.ToSingle(floatVals, 0);
            //Console.WriteLine("float convert = {0}", f);

            return f;
        }
              
        public UInt32 stringToUint32Converter(string i)
        {
            return Convert.ToUInt32(i, 16);
        }
        public Int32 stringToint32Converter(string i)
        {
            return Convert.ToInt32(i, 16);
        }

        public Int16 stringToint16Converter(string i)
        {
            return Convert.ToInt16(i, 16);
        }

        public UInt16 stringToUint16Converter(string i)
        {
            return Convert.ToUInt16(i, 16);
        }

        public byte stringToByte(string i)
        {
            return Convert.ToByte(i, 16);
        }

        public sbyte stringToSByte(string i)
        {
            return Convert.ToSByte(i, 16);
        }

        public string intTostringConverter(int s)
        {
            return s.ToString();
        }
        public string intTostringConverter(float s)
        {
            return s.ToString();
        }

        #endregion

        private static ushort CRC(byte[] data, System.UInt16 size, bool send_request)
        {
            ushort crc = 0xFFFF;
            int pos = 0;

            if (send_request)
            {
                pos = 5;
            }
            else
            {
                pos = 0;
            }
            for (; pos < size; pos++)
            {
                crc ^= (UInt16)data[pos];
                for (int i = 8; i != 0; i--)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }
            return crc;
        }

        public static void addCSV(string add, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    if (logcount == 0)
                    {
                        file.WriteLine("time;runtime_ms;latitude_e7;longitude_e7;roll_deg_m10;roll_ref_deg_m10;pitch_deg_m10;pitch_ref_deg_m10;yaw_deg_m10;yaw_ref_deg_m10;" +
                            "gyro_x_dps_m10;gyro_y_dps_m10;gyro_z_dps_m10;lin_acc_x_mp2_m100;lin_acc_y_mp2_m100;lin_acc_z_mp2_m100;asl_m_m10;climb_rate_mps_m100;pwm1;pwm2;" +
                            "pwm3;pwm4;voltage_mv;current_a_m10;flight_mode;cpu_load;utc_time_sec;ref_latitude_e7;ref_longitude_e7;home_latitude_e7;home_longitude_e7;" +
                            "status_flags;mag_x_mg;mag_y_mg;mag_z_mg;agl_m;agl_ref_m;asl_gps_m;rangefinder_cm;ref_climb_rate_mps_m100;gps_N_speed_cmps;gps_E_speed_cmps;" +
                            "ref_gps_N_speed_cmps;ref_gps_E_speed_cmps;ground_speed_cmps;gps_pdop;gps_hacc;gps_vacc;home_distance_m;route_distance_m;flight_time_sec;" +
                            "power_milliwatt;remaining_capacity;throttle_out;pid_flight_mode;gps_satellite_number;battery_percent;test_0;test_1;test_2;test_3;test_4;test_5;test_6");
                    }
                    file.WriteLine(DateTime.Now.ToString("yyyy-MM-dd") + "_" + DateTime.Now.ToString("HH:mm:ss") + ";" + add);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("This program did an error: ", ex);
            }


        }

        void sendPacket(System.UInt16 command, byte[] data, System.UInt16 size)
        {
            //byte buffer[1024] = { 0 };
            byte[] buffer = new byte[1024];
            System.UInt16 k = 0;
            System.UInt16 t = 0;
            System.UInt16 crc_result = 0;

            buffer[k++] = HEADER;
            buffer[k++] = GCS_ID;
            buffer[k++] = UAV_ID;
            buffer[k++] = (byte)(size & 0x00FF);
            buffer[k++] = (byte)((size & 0xFF00) >> 8);
            buffer[k++] = (byte)(command & 0x00FF);
            buffer[k++] = (byte)((command & 0xFF00) >> 8);

            for (t = 0; t < size; t++)
            {
                buffer[k++] = data[t];
            }

            crc_result = CRC(buffer, k, true);
            buffer[k++] = (byte)(crc_result & 0x00FF);
            buffer[k++] = (byte)((crc_result & 0xFF00) >> 8);
            buffer[k++] = FOOTER;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(buffer, 0, k);
            }

            string bir = BitConverter.ToString(buffer);



            if (command == 0x2013)
            {
                Console.WriteLine("giden: " + bir);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //PID CHANGE DATA BUTTON

            change_piddata();

            byte[] buffer = new byte[160];
            //ADDS DATA TO BUFFER
            #region ADDSENDDATA
            limit = 0;
            buffer = addToSendData(ref pid.roll_rate_kp, ref buffer);
            buffer = addToSendData(ref pid.roll_rate_ki, ref buffer);
            buffer = addToSendData(ref pid.roll_rate_kd, ref buffer);
            buffer = addToSendData(ref pid.roll_rate_kff, ref buffer);
            buffer = addToSendData(ref pid.roll_rate_input_limit, ref buffer);
            buffer = addToSendData(ref pid.roll_rate_input_rate_limit, ref buffer);
            buffer = addToSendData(ref pid.roll_rate_output_limit, ref buffer);
            buffer = addToSendData(ref pid.roll_rate_ki_limit, ref buffer);
            buffer = addToSendData(ref pid.roll_rate_kd_limit, ref buffer);
            buffer = addToSendData(ref pid.roll_rate_kd_filter_freq, ref buffer);
            buffer = addToSendData(ref pid.pitch_rate_kp, ref buffer);
            buffer = addToSendData(ref pid.pitch_rate_ki, ref buffer);
            buffer = addToSendData(ref pid.pitch_rate_kd, ref buffer);
            buffer = addToSendData(ref pid.pitch_rate_kff, ref buffer);
            buffer = addToSendData(ref pid.pitch_rate_input_limit, ref buffer);
            buffer = addToSendData(ref pid.pitch_rate_input_rate_limit, ref buffer);
            buffer = addToSendData(ref pid.pitch_rate_output_limit, ref buffer);
            buffer = addToSendData(ref pid.pitch_rate_ki_limit, ref buffer);
            buffer = addToSendData(ref pid.pitch_rate_kd_limit, ref buffer);
            buffer = addToSendData(ref pid.pitch_rate_kd_filter_freq, ref buffer);
            buffer = addToSendData(ref pid.roll_kp, ref buffer);
            buffer = addToSendData(ref pid.roll_ki, ref buffer);
            buffer = addToSendData(ref pid.roll_kd, ref buffer);
            buffer = addToSendData(ref pid.roll_kff, ref buffer);
            buffer = addToSendData(ref pid.roll_input_limit, ref buffer);
            buffer = addToSendData(ref pid.roll_input_rate_limit, ref buffer);
            buffer = addToSendData(ref pid.roll_output_limit, ref buffer);
            buffer = addToSendData(ref pid.roll_ki_limit, ref buffer);
            buffer = addToSendData(ref pid.roll_kd_limit, ref buffer);
            buffer = addToSendData(ref pid.roll_kd_filter_freq, ref buffer);
            buffer = addToSendData(ref pid.pitch_kp, ref buffer);
            buffer = addToSendData(ref pid.pitch_ki, ref buffer);
            buffer = addToSendData(ref pid.pitch_kd, ref buffer);
            buffer = addToSendData(ref pid.pitch_kff, ref buffer);
            buffer = addToSendData(ref pid.pitch_input_limit, ref buffer);
            buffer = addToSendData(ref pid.pitch_input_rate_limit, ref buffer);
            buffer = addToSendData(ref pid.pitch_output_limit, ref buffer);
            buffer = addToSendData(ref pid.pitch_ki_limit, ref buffer);
            buffer = addToSendData(ref pid.pitch_kd_limit, ref buffer);
            buffer = addToSendData(ref pid.pitch_kd_filter_freq, ref buffer);

            #endregion

            //SEND BUFFER
            string sdasdas = BitConverter.ToString(buffer);
            Console.WriteLine("sdasdas: " + sdasdas);
            sendPacket(PID_GAIN_WRITE, buffer, 160);
            Thread.Sleep(50);
            byte[] buffer2 = new byte[2];
            buffer2[0] = (byte)(PID_GAIN_READ & 0x00FF);
            buffer2[1] = (byte)((PID_GAIN_READ & 0xFF00) >> 8);
            sendPacket(PID_GAIN_READ, buffer2, 2);
            Thread.Sleep(50);

        }

        #region ADDSENDDATAFUNCTIONS

        public static byte[] addToSendData(ref float addData, ref byte[] returnData)
        {
            byte[] vOut = BitConverter.GetBytes(addData);
            if (limit < returnData.Length)
            {
                System.Buffer.BlockCopy(vOut, 0, returnData, limit, vOut.Length);

            }

            limit = limit + vOut.Length;
            return returnData;
        }

        public static byte[] addToSendData(ref Int32 addData, ref byte[] returnData)
        {
            byte[] vOut = BitConverter.GetBytes(addData);
            if (limit < returnData.Length)
            {
                System.Buffer.BlockCopy(vOut, 0, returnData, limit, vOut.Length);

            }

            limit = limit + vOut.Length;
            return returnData;
        }

        public static byte[] addToSendData(ref UInt32 addData, ref byte[] returnData)
        {
            byte[] vOut = BitConverter.GetBytes(addData);
            if (limit < returnData.Length)
            {
                System.Buffer.BlockCopy(vOut, 0, returnData, limit, vOut.Length);

            }

            limit = limit + vOut.Length;
            return returnData;
        }

        public static byte[] addToSendData(ref Int16 addData, ref byte[] returnData)
        {
            byte[] vOut = BitConverter.GetBytes(addData);
            if (limit < returnData.Length)
            {
                System.Buffer.BlockCopy(vOut, 0, returnData, limit, vOut.Length);

            }

            limit = limit + vOut.Length;
            return returnData;
        }

        public static byte[] addToSendData(ref UInt16 addData, ref byte[] returnData)
        {
            byte[] vOut = BitConverter.GetBytes(addData);
            if (limit < returnData.Length)
            {
                System.Buffer.BlockCopy(vOut, 0, returnData, limit, vOut.Length);

            }

            limit = limit + vOut.Length;
            return returnData;
        }

        public static byte[] addToSendData(ref byte addData, ref byte[] returnData)
        {
            byte[] vOut = BitConverter.GetBytes(addData);

            if (limit < returnData.Length)
            {
                //GetBytes gets lenghts of the bytes as 2 instead of 1 ,so I add -1 to equal to real value
                System.Buffer.BlockCopy(vOut, 0, returnData, limit, vOut.Length - 1);
            }

            limit = limit + vOut.Length - 1;

            return returnData;
        }

        public static byte[] addToSendData(ref sbyte addData, ref byte[] returnData)
        {
            byte[] vOut = BitConverter.GetBytes(addData);
            if (limit < returnData.Length)
            {
                //GetBytes gets lenghts of the bytes as 2 instead of 1 ,so I add -1 to equal to real value
                System.Buffer.BlockCopy(vOut, 0, returnData, limit, vOut.Length - 1);

            }

            limit = limit + vOut.Length - 1;

            return returnData;
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            //PID REQUEST DATA BUTTON

            byte[] buffer = new byte[2];
            buffer[0] = (byte)(PID_GAIN_READ & 0x00FF);
            buffer[1] = (byte)((PID_GAIN_READ & 0xFF00) >> 8);
            sendPacket(PID_GAIN_READ, buffer, 2);
            Thread.Sleep(50);

        }

        public void update_piddata()
        {
            label29.Text = pid.roll_rate_kp.ToString();
            label30.Text = pid.roll_rate_ki.ToString();
            label31.Text = pid.roll_rate_kd.ToString();
            label32.Text = pid.roll_rate_kff.ToString();
            label33.Text = pid.roll_rate_input_limit.ToString();
            label34.Text = pid.roll_rate_input_rate_limit.ToString();
            label35.Text = pid.roll_rate_output_limit.ToString();
            label36.Text = pid.roll_rate_ki_limit.ToString();
            label37.Text = pid.roll_rate_kd_limit.ToString();
            label38.Text = pid.roll_rate_kd_filter_freq.ToString();
            label39.Text = pid.pitch_rate_kp.ToString();
            label40.Text = pid.pitch_rate_ki.ToString();
            label41.Text = pid.pitch_rate_kd.ToString();
            label42.Text = pid.pitch_rate_kff.ToString();
            label43.Text = pid.pitch_rate_input_limit.ToString();
            label44.Text = pid.pitch_rate_input_rate_limit.ToString();
            label45.Text = pid.pitch_rate_output_limit.ToString();
            label46.Text = pid.pitch_rate_ki_limit.ToString();
            label47.Text = pid.pitch_rate_kd_limit.ToString();
            label48.Text = pid.pitch_rate_kd_filter_freq.ToString();
            label49.Text = pid.roll_kp.ToString();
            label70.Text = pid.roll_ki.ToString();
            label69.Text = pid.roll_kd.ToString();
            label68.Text = pid.roll_kff.ToString();
            label67.Text = pid.roll_input_limit.ToString();
            label66.Text = pid.roll_input_rate_limit.ToString();
            label65.Text = pid.roll_output_limit.ToString();
            label64.Text = pid.roll_ki_limit.ToString();
            label63.Text = pid.roll_kd_limit.ToString();
            label62.Text = pid.roll_kd_filter_freq.ToString();
            label61.Text = pid.pitch_kp.ToString();
            label60.Text = pid.pitch_ki.ToString();
            label59.Text = pid.pitch_kd.ToString();
            label58.Text = pid.pitch_kff.ToString();
            label57.Text = pid.pitch_input_limit.ToString();
            label56.Text = pid.pitch_input_rate_limit.ToString();
            label55.Text = pid.pitch_output_limit.ToString();
            label54.Text = pid.pitch_ki_limit.ToString();
            label53.Text = pid.pitch_kd_limit.ToString();
            label52.Text = pid.pitch_kd_filter_freq.ToString();

            textBox17.Text = pid.roll_rate_kp.ToString();
            textBox26.Text = pid.roll_rate_ki.ToString();
            textBox27.Text = pid.roll_rate_kd.ToString();
            textBox28.Text = pid.roll_rate_kff.ToString();
            textBox29.Text = pid.roll_rate_input_limit.ToString();
            textBox30.Text = pid.roll_rate_input_rate_limit.ToString();
            textBox31.Text = pid.roll_rate_output_limit.ToString();
            textBox32.Text = pid.roll_rate_ki_limit.ToString();
            textBox33.Text = pid.roll_rate_kd_limit.ToString();
            textBox34.Text = pid.roll_rate_kd_filter_freq.ToString();
            textBox35.Text = pid.pitch_rate_kp.ToString();
            textBox36.Text = pid.pitch_rate_ki.ToString();
            textBox37.Text = pid.pitch_rate_kd.ToString();
            textBox38.Text = pid.pitch_rate_kff.ToString();
            textBox39.Text = pid.pitch_rate_input_limit.ToString();
            textBox40.Text = pid.pitch_rate_input_rate_limit.ToString();
            textBox41.Text = pid.pitch_rate_output_limit.ToString();
            textBox42.Text = pid.pitch_rate_ki_limit.ToString();
            textBox43.Text = pid.pitch_rate_kd_limit.ToString();
            textBox44.Text = pid.pitch_rate_kd_filter_freq.ToString();
            textBox45.Text = pid.roll_kp.ToString();
            textBox46.Text = pid.roll_ki.ToString();
            textBox47.Text = pid.roll_kd.ToString();
            textBox48.Text = pid.roll_kff.ToString();
            textBox49.Text = pid.roll_input_limit.ToString();
            textBox50.Text = pid.roll_input_rate_limit.ToString();
            textBox51.Text = pid.roll_output_limit.ToString();
            textBox52.Text = pid.roll_ki_limit.ToString();
            textBox53.Text = pid.roll_kd_limit.ToString();
            textBox54.Text = pid.roll_kd_filter_freq.ToString();
            textBox55.Text = pid.pitch_kp.ToString();
            textBox56.Text = pid.pitch_ki.ToString();
            textBox57.Text = pid.pitch_kd.ToString();
            textBox58.Text = pid.pitch_kff.ToString();
            textBox59.Text = pid.pitch_input_limit.ToString();
            textBox60.Text = pid.pitch_input_rate_limit.ToString();
            textBox61.Text = pid.pitch_output_limit.ToString();
            textBox62.Text = pid.pitch_ki_limit.ToString();
            textBox63.Text = pid.pitch_kd_limit.ToString();
            textBox64.Text = pid.pitch_kd_filter_freq.ToString();

            logcount++;
        }

        public void change_piddata()
        {
            pid.roll_rate_kp = Convert.ToSingle(textBox17.Text);
            pid.roll_rate_ki = Convert.ToSingle(textBox26.Text);
            pid.roll_rate_kd = Convert.ToSingle(textBox27.Text);
            pid.roll_rate_kff = Convert.ToSingle(textBox28.Text);
            pid.roll_rate_input_limit = Convert.ToSingle(textBox29.Text);
            pid.roll_rate_input_rate_limit = Convert.ToSingle(textBox30.Text);
            pid.roll_rate_output_limit = Convert.ToSingle(textBox31.Text);
            pid.roll_rate_ki_limit = Convert.ToSingle(textBox32.Text);
            pid.roll_rate_kd_limit = Convert.ToSingle(textBox33.Text);
            pid.roll_rate_kd_filter_freq = Convert.ToSingle(textBox34.Text);
            pid.pitch_rate_kp = Convert.ToSingle(textBox35.Text);
            pid.pitch_rate_ki = Convert.ToSingle(textBox36.Text);
            pid.pitch_rate_kd = Convert.ToSingle(textBox37.Text);
            pid.pitch_rate_kff = Convert.ToSingle(textBox38.Text);
            pid.pitch_rate_input_limit = Convert.ToSingle(textBox39.Text);
            pid.pitch_rate_input_rate_limit = Convert.ToSingle(textBox40.Text);
            pid.pitch_rate_output_limit = Convert.ToSingle(textBox41.Text);
            pid.pitch_rate_ki_limit = Convert.ToSingle(textBox42.Text);
            pid.pitch_rate_kd_limit = Convert.ToSingle(textBox43.Text);
            pid.pitch_rate_kd_filter_freq = Convert.ToSingle(textBox44.Text);
            pid.roll_kp = Convert.ToSingle(textBox45.Text);
            pid.roll_ki = Convert.ToSingle(textBox46.Text);
            pid.roll_kd = Convert.ToSingle(textBox47.Text);
            pid.roll_kff = Convert.ToSingle(textBox48.Text);
            pid.roll_input_limit = Convert.ToSingle(textBox49.Text);
            pid.roll_input_rate_limit = Convert.ToSingle(textBox50.Text);
            pid.roll_output_limit = Convert.ToSingle(textBox51.Text);
            pid.roll_ki_limit = Convert.ToSingle(textBox52.Text);
            pid.roll_kd_limit = Convert.ToSingle(textBox53.Text);
            pid.roll_kd_filter_freq = Convert.ToSingle(textBox54.Text);
            pid.pitch_kp = Convert.ToSingle(textBox55.Text);
            pid.pitch_ki = Convert.ToSingle(textBox56.Text);
            pid.pitch_kd = Convert.ToSingle(textBox57.Text);
            pid.pitch_kff = Convert.ToSingle(textBox58.Text);
            pid.pitch_input_limit = Convert.ToSingle(textBox59.Text);
            pid.pitch_input_rate_limit = Convert.ToSingle(textBox60.Text);
            pid.pitch_output_limit = Convert.ToSingle(textBox61.Text);
            pid.pitch_ki_limit = Convert.ToSingle(textBox62.Text);
            pid.pitch_kd_limit = Convert.ToSingle(textBox63.Text);
            pid.pitch_kd_filter_freq = Convert.ToSingle(textBox64.Text);
            textBox17.Text = pid.roll_rate_kp.ToString();
            textBox26.Text = pid.roll_rate_ki.ToString();
            textBox27.Text = pid.roll_rate_kd.ToString();
            textBox28.Text = pid.roll_rate_kff.ToString();
            textBox29.Text = pid.roll_rate_input_limit.ToString();
            textBox30.Text = pid.roll_rate_input_rate_limit.ToString();
            textBox31.Text = pid.roll_rate_output_limit.ToString();
            textBox32.Text = pid.roll_rate_ki_limit.ToString();
            textBox33.Text = pid.roll_rate_kd_limit.ToString();
            textBox34.Text = pid.roll_rate_kd_filter_freq.ToString();
            textBox35.Text = pid.pitch_rate_kp.ToString();
            textBox36.Text = pid.pitch_rate_ki.ToString();
            textBox37.Text = pid.pitch_rate_kd.ToString();
            textBox38.Text = pid.pitch_rate_kff.ToString();
            textBox39.Text = pid.pitch_rate_input_limit.ToString();
            textBox40.Text = pid.pitch_rate_input_rate_limit.ToString();
            textBox41.Text = pid.pitch_rate_output_limit.ToString();
            textBox42.Text = pid.pitch_rate_ki_limit.ToString();
            textBox43.Text = pid.pitch_rate_kd_limit.ToString();
            textBox44.Text = pid.pitch_rate_kd_filter_freq.ToString();
            textBox45.Text = pid.roll_kp.ToString();
            textBox46.Text = pid.roll_ki.ToString();
            textBox47.Text = pid.roll_kd.ToString();
            textBox48.Text = pid.roll_kff.ToString();
            textBox49.Text = pid.roll_input_limit.ToString();
            textBox50.Text = pid.roll_input_rate_limit.ToString();
            textBox51.Text = pid.roll_output_limit.ToString();
            textBox52.Text = pid.roll_ki_limit.ToString();
            textBox53.Text = pid.roll_kd_limit.ToString();
            textBox54.Text = pid.roll_kd_filter_freq.ToString();
            textBox55.Text = pid.pitch_kp.ToString();
            textBox56.Text = pid.pitch_ki.ToString();
            textBox57.Text = pid.pitch_kd.ToString();
            textBox58.Text = pid.pitch_kff.ToString();
            textBox59.Text = pid.pitch_input_limit.ToString();
            textBox60.Text = pid.pitch_input_rate_limit.ToString();
            textBox61.Text = pid.pitch_output_limit.ToString();
            textBox62.Text = pid.pitch_ki_limit.ToString();
            textBox63.Text = pid.pitch_kd_limit.ToString();
            textBox64.Text = pid.pitch_kd_filter_freq.ToString();
        }

        public void show_drone_logo(double lat, double lng, float angle)
        {
            map.HoldInvalidation = true;


            Bitmap bmpMarker = (Bitmap)Image.FromFile(@"C:\Users\w10\Desktop\SerialPortProcess_yedek\drone_logoV2.png");

            if (angle < 0)
            {
                angle = angle + (float)360;
            }

            if (temp_angle != angle)
            {
                if (dronelogocount != 0)
                {
                    markers.Markers.Remove(marker);

                    dronelogocount = 1;
                }
                map.Overlays.Remove(markers);

                temp_angle = angle;
                //map.Overlays.Clear();

                bmpMarker = RotateImage(bmpMarker, angle);//ROTATES DRONE LOGO FOR YAV

                //custom marker drone logo
                PointLatLng point = new PointLatLng(lat, lng);

                //Console.WriteLine("lat: " + lat + "lng: " + lng);

                markers = new GMapOverlay("markers");

                marker = new GMarkerGoogle(point, bmpMarker);

                marker.Offset = new Point(-bmpMarker.Width / 2, -bmpMarker.Height / 2);
                map.Overlays.Add(markers);
                markers.Markers.Add(marker);

            }

            map.HoldInvalidation = false;
            BeginInvoke(new Action(delegate () { map.Refresh(); }));

        }

        public static Bitmap RotateImage(Bitmap b, float angle)
        {

            //create a new empty bitmap to hold rotated image
            Bitmap returnBitmap = new Bitmap(b.Width, b.Height);
            //make a graphics object from the empty bitmap

            using (Graphics g = Graphics.FromImage(returnBitmap))
            {
                //g.CompositingQuality = CompositingQuality.HighSpeed;
                //move rotation point to center of image
                g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
                //rotate
                g.RotateTransform(angle);
                //move image back
                g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                //g.CompositingQuality = CompositingQuality.HighQuality;
                //draw passed in image onto graphics object
                g.DrawImage(b, new Point(0, 0));
                //g.Dispose();

            }
            return returnBitmap;

        }//ROTATES DRONE ICON

        protected override void OnPaint(PaintEventArgs paintEvnt)
        {
            // Calling the base class OnPaint
            base.OnPaint(paintEvnt);


            // Clipping mask for Attitude Indicator
            paintEvnt.Graphics.Clip = new Region(new Rectangle(0, 0, 150, 150));
            paintEvnt.Graphics.FillRegion(Brushes.Black, paintEvnt.Graphics.Clip);


            // Make sure lines are drawn smoothly
            paintEvnt.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            // Create the graphics object
            Graphics gfx = paintEvnt.Graphics;

            // Adjust and draw horizon image
            RotateAndTranslate(paintEvnt, mybitmap1, RollAngle, 0, ptBoule, (double)(4 * PitchAngle), ptRotation, (float)0.5);

            RotateAndTranslate2(paintEvnt, mybitmap3, YawAngle, RollAngle, 0, ptHeading, (double)(4 * PitchAngle), ptRotation, (float)0.5);



            // Draw a mask
            //Pen maskPen = new Pen(this.BackColor, 220); // width of mask
            //gfx.DrawRectangle(maskPen, -100, -100, 500, 500); // size of mask

            //gfx.DrawImage(mybitmap2, 0, 0); // Draw bezel image
            //gfx.DrawImage(mybitmap4, 37, 62); // Draw wings image

            //myPen = new Pen(System.Drawing.Color.Green, 3);
            //gfx.DrawLine(myPen, 200, 20, 20, 210); // Draw a line

            // The sliders are updated from the Pitch, Roll & Yaw values (calculated first from serial data)
            //slider1.Value = Convert.ToInt16(PitchAngle); //Update sliders
            //slider2.Value = Convert.ToInt16((-1.0 * RollAngle / Math.PI) * 180);  //with values from
            //slider3.Value = Convert.ToInt16((YawAngle / Math.PI) * 180);   //serial data (if available)           

            // Update text boxes with angles (if we have any)

            /*
            textBox1.Text = Convert.ToString(slider1.Value);
            textBox2.Text = Convert.ToString(slider2.Value);
            textBox3.Text = Convert.ToString(slider3.Value);*/

        }//PAINT VIRTUAL HORIZON

        protected void RotateAndTranslate(PaintEventArgs pe, Image img, Double alphaRot, Double alphaTrs, Point ptImg, double deltaPx, Point ptRot, float scaleFactor)
        {
            double beta = 0;
            double d = 0;
            float deltaXRot = 0;
            float deltaYRot = 0;
            float deltaXTrs = 0;
            float deltaYTrs = 0;

            // Rotation

            if (ptImg != ptRot)
            {
                // Internals coeffs
                if (ptRot.X != 0)
                {
                    beta = Math.Atan((double)ptRot.Y / (double)ptRot.X);
                }

                d = Math.Sqrt((ptRot.X * ptRot.X) + (ptRot.Y * ptRot.Y));

                // Computed offset
                deltaXRot = (float)(d * (Math.Cos(alphaRot - beta) - Math.Cos(alphaRot) * Math.Cos(alphaRot + beta) - Math.Sin(alphaRot) * Math.Sin(alphaRot + beta)));
                deltaYRot = (float)(d * (Math.Sin(beta - alphaRot) + Math.Sin(alphaRot) * Math.Cos(alphaRot + beta) - Math.Cos(alphaRot) * Math.Sin(alphaRot + beta)));
            }

            // Translation

            // Computed offset
            deltaXTrs = (float)(deltaPx * (Math.Sin(alphaTrs)));
            deltaYTrs = (float)(-deltaPx * (-Math.Cos(alphaTrs)));

            // Rotate image support
            pe.Graphics.RotateTransform((float)(alphaRot * 180 / Math.PI));

            // Dispay image
            pe.Graphics.DrawImage(img, (ptImg.X + deltaXRot + deltaXTrs) * scaleFactor, (ptImg.Y + deltaYRot + deltaYTrs) * scaleFactor, img.Width * scaleFactor, img.Height * scaleFactor);

            // Put image support as found
            pe.Graphics.RotateTransform((float)(-alphaRot * 180 / Math.PI));
        }//PAINT VIRTUAL HORIZON

        protected void RotateAndTranslate2(PaintEventArgs pe, Image img, Double yawRot, Double alphaRot, Double alphaTrs, Point ptImg, double deltaPx, Point ptRot, float scaleFactor)
        {
            double beta = 0;
            double d = 0;
            float deltaXRot = 0;
            float deltaYRot = 0;
            float deltaXTrs = 0;
            float deltaYTrs = 0;

            // Rotation

            if (ptImg != ptRot)
            {
                // Internals coeffs
                if (ptRot.X != 0)
                {
                    beta = Math.Atan((double)ptRot.Y / (double)ptRot.X);
                }

                d = Math.Sqrt((ptRot.X * ptRot.X) + (ptRot.Y * ptRot.Y));

                // Computed offset
                deltaXRot = (float)(d * (Math.Cos(alphaRot - beta) - Math.Cos(alphaRot) * Math.Cos(alphaRot + beta) - Math.Sin(alphaRot) * Math.Sin(alphaRot + beta) + yawRot));
                deltaYRot = (float)(d * (Math.Sin(beta - alphaRot) + Math.Sin(alphaRot) * Math.Cos(alphaRot + beta) - Math.Cos(alphaRot) * Math.Sin(alphaRot + beta)));
            }

            // Translation

            // Computed offset
            deltaXTrs = (float)(deltaPx * (Math.Sin(alphaTrs)));
            deltaYTrs = (float)(-deltaPx * (-Math.Cos(alphaTrs)));

            // Rotate image support
            pe.Graphics.RotateTransform((float)(alphaRot * 180 / Math.PI));

            // Dispay image
            pe.Graphics.DrawImage(img, (ptImg.X + deltaXRot + deltaXTrs) * scaleFactor, (ptImg.Y + deltaYRot + deltaYTrs) * scaleFactor, img.Width * scaleFactor, img.Height * scaleFactor);

            // Put image support as found
            pe.Graphics.RotateTransform((float)(-alphaRot * 180 / Math.PI));
        }//PAINT VIRTUAL HORIZON

        public void ConnectionChecker()
        {
            if (init == 0 && (long)telem.runtime_ms != 0)
            {
                dif = temp_time_now - (long)telem.runtime_ms;
                init = 1;
            }

            if (((temp_time_now - (long)telem.runtime_ms) - dif) > 500)
            {
                BeginInvoke(new Action(delegate () { label110.Text = "NO LINK"; }));
                //Çapraz İş Parçacığı İşlemi Geçerli Değil Hatasını giddermek için DELEGATE kullanıldı.
                //DELEGATE KULLANILAN HERYERDE BU HATA ALINDIGI ICINN KULLANILDI
                BeginInvoke(new Action(delegate () { label110.BackColor = Color.Red; }));
            }
            else
            {
                BeginInvoke(new Action(delegate () { label110.Text = "CONNECTED"; }));
                BeginInvoke(new Action(delegate () { label110.BackColor = Color.Green; }));
            }

            if (runtime_ms_last > (long)telem.runtime_ms)
            {
                init = 0;
            }
            runtime_ms_last = (long)telem.runtime_ms;
            //temp_timer = (long)telem.runtime_ms;
            //temp_time_last = temp_time_now;


        }

        private void timer1_Tick(object sender, EventArgs e)  //10Hz 100ms
        {
            //TIMER

            if (checkBox1.Checked)//CENTER MAP
            {
                map.Position = new PointLatLng((double)(telem.latitude_e7 / (double)10000000), (double)(telem.longitude_e7 / (double)10000000));
                map.Refresh();
            }

            PowerStatus pw = SystemInformation.PowerStatus;//GETS PC BATTERY PERCENTAGE
            label120.Text = ("%" + pw.BatteryLifePercent * 100).ToString();

            switch (telem.flight_mode)
            {
                case 0:
                    label116.Text = "DISARM";
                    break;
                case 1:
                    label116.Text = "MANUAL";
                    break;
                case 2:
                    label116.Text = "ON THE GROUND";
                    break;
                case 3:
                    label116.Text = "TAKEOFF";
                    break;
                case 4:
                    label116.Text = "POSITION_HOLD";
                    break;
                case 5:
                    label116.Text = "GOTO";
                    break;
                case 6:
                    label116.Text = "LAND";
                    break;
                case 7:
                    label116.Text = "RTL";
                    break;
                case 8:
                    label116.Text = "AUTO";
                    break;
                default:
                    label116.Text = "UNKNOWN FLIGHT MODE";

                    break;
            }

            temp_time_now = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds();//GETS UTC TIME FOR CONNECTIN CHECKER
            ConnectionChecker();//LINK CONTROL
            BeginInvoke(new Action(delegate () { label111.Text = temp_time_now.ToString(); }));//DRAW SCRREN CURRENT TIME
            double current_time = DateTime.Now.Millisecond;

            byte joy_N_mps = (byte)trackBar2.Value;// GETS TRACKBAR VALUES FOR CONTROL DRONE SPEED
            byte joy_E_mps = (byte)trackBar1.Value;
            byte joy_active = 0;

            label117.Text = trackBar2.Value.ToString();
            label118.Text = trackBar1.Value.ToString();

            if (trackBar1.Value != 0 || trackBar2.Value != 0)
            {
                joy_active = 1;
            }

            byte[] buffer = new byte[7];
            System.Buffer.BlockCopy(BitConverter.GetBytes(telem.runtime_ms), 0, buffer, 0, 3); //BLOCKCOPY ADDS BYTES TO BUFFER
            System.Buffer.BlockCopy(BitConverter.GetBytes(joy_N_mps), 0, buffer, 4, 1);
            System.Buffer.BlockCopy(BitConverter.GetBytes(joy_E_mps), 0, buffer, 5, 1);
            System.Buffer.BlockCopy(BitConverter.GetBytes(joy_active), 0, buffer, 6, 1);

            //Console.WriteLine(current_time - last_time);
            last_time = current_time;
            sendPacket(TELEMETRY_HEARTBEAT, buffer, 7);
            //Thread.Sleep(50);


        }

        private void map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //WHEN DOUBLE CLICK ON THE MAPS DO THIS
            var point = map.FromLocalToLatLng(e.X, e.Y);//GETS REAL LAT LONG FOR MOUSE POSITION
            

            lat_goto = (point.Lat * 10000000000000); 
            lng_goto = (point.Lng * 10000000000000);


            droneroutelat = point.Lat;
            droneroutelng = point.Lng;

            lat_goto = (lat_goto - (lat_goto % 1000000)) / 1000000;//FOR MAKE LAT LONG 9 DIGIT WITHOUT COMMA eg.414568974
            lng_goto = (lng_goto - (lng_goto % 1000000)) / 1000000;

            
            label112.Text = "Lat: " + lat_goto.ToString();//PRINTS SCREEN SELECTED LOCATION
            label113.Text = "Lng: " + lng_goto.ToString();
           


            System.Int32 lt;
            System.Int32 ln;
            lt = (int)lat_goto;
            ln = (int)lng_goto;

            // GOTO_COMMAND = 0x4019;

            byte[] buffer = new byte[8];

            System.Buffer.BlockCopy(BitConverter.GetBytes(lt), 0, buffer, 0, BitConverter.GetBytes(lt).Length);//SEND DESTNATION LOCATION TO THE DRONE
            System.Buffer.BlockCopy(BitConverter.GetBytes(ln), 0, buffer, BitConverter.GetBytes(lt).Length, BitConverter.GetBytes(ln).Length);
            sendPacket(GOTO_COMMAND, buffer, 8);
            Thread.Sleep(50);

        }

        private void button3_Click(object sender, EventArgs e)
        {   
            //ROUTE BUTTON
            //Draws route
            routeMarker();
            routecontrol = 0;
        }

        private void map_OnMapZoomChanged()
        {
            //WHEN ZOOM CHANGE BY MOUSE THIRD BUTTON ,EQUALS ZOOM VALUE TO THE ZOOM_TRACKBAR
            if ((int)map.Zoom > 0 && (int)map.Zoom < 21)
            {
                trackBar3.Value = (int)map.Zoom;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //CONSOLE SEND BUTTON
            string someString = textBox66.Text;

            byte[] bytes = Encoding.ASCII.GetBytes(someString);
            int size = System.Text.ASCIIEncoding.ASCII.GetByteCount(someString);
            Console.WriteLine("textbox65: " + bytes);
            Console.WriteLine("size: " + size);
            sendPacket(CONSOLE_OUTPUT, bytes, (ushort)size);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ARM_COMMAND = 0x4011;

            byte[] buffer = new byte[2];
            buffer[0] = (byte)(PID_GAIN_READ & 0x00FF);
            buffer[1] = (byte)((PID_GAIN_READ & 0xFF00) >> 8);
            sendPacket(ARM_COMMAND, buffer, 2);
            Thread.Sleep(50);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // DISARM_COMMAND = 0x4010;

            byte[] buffer = new byte[2];
            buffer[0] = (byte)(PID_GAIN_READ & 0x00FF);
            buffer[1] = (byte)((PID_GAIN_READ & 0xFF00) >> 8);
            sendPacket(DISARM_COMMAND, buffer, 2);
            Thread.Sleep(50);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // TAKEOFF_COMMAND = 0x4012;

            byte[] buffer = new byte[2];
            buffer[0] = (byte)(PID_GAIN_READ & 0x00FF);
            buffer[1] = (byte)((PID_GAIN_READ & 0xFF00) >> 8);
            sendPacket(TAKEOFF_COMMAND, buffer, 2);
            Thread.Sleep(50);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            // LAND_COMMAND = 0x4013;

            byte[] buffer = new byte[2];
            buffer[0] = (byte)(PID_GAIN_READ & 0x00FF);
            buffer[1] = (byte)((PID_GAIN_READ & 0xFF00) >> 8);
            sendPacket(LAND_COMMAND, buffer, 2);
            Thread.Sleep(50);
        }

        private void button9_Click(object sender, EventArgs e)
        {

            // RTL_COMMAND = 0x4014;

            byte[] buffer = new byte[2];
            buffer[0] = (byte)(PID_GAIN_READ & 0x00FF);
            buffer[1] = (byte)((PID_GAIN_READ & 0xFF00) >> 8);
            sendPacket(RTL_COMMAND, buffer, 2);
            Thread.Sleep(50);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            // BRAKE_COMMAND = 0x4021;

            byte[] buffer = new byte[2];
            buffer[0] = (byte)(PID_GAIN_READ & 0x00FF);
            buffer[1] = (byte)((PID_GAIN_READ & 0xFF00) >> 8);
            sendPacket(BRAKE_COMMAND, buffer, 2);
            Thread.Sleep(50);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            // ALT_INCREASE_COMMAND = 0x4015;

            byte[] buffer = new byte[2];
            buffer[0] = (byte)(PID_GAIN_READ & 0x00FF);
            buffer[1] = (byte)((PID_GAIN_READ & 0xFF00) >> 8);
            sendPacket(ALT_INCREASE_COMMAND, buffer, 2);
            Thread.Sleep(50);
        }

        private void button14_Click(object sender, EventArgs e)
        {

            // ALT_DECREASE_COMMAND = 0x4016;

            byte[] buffer = new byte[2];
            buffer[0] = (byte)(PID_GAIN_READ & 0x00FF);
            buffer[1] = (byte)((PID_GAIN_READ & 0xFF00) >> 8);
            sendPacket(ALT_DECREASE_COMMAND, buffer, 2);
            Thread.Sleep(50);
        }

        private void button13_Click(object sender, EventArgs e)
        {

            // YAW_CW_COMMAND = 0x4017;

            byte[] buffer = new byte[2];
            buffer[0] = (byte)(PID_GAIN_READ & 0x00FF);
            buffer[1] = (byte)((PID_GAIN_READ & 0xFF00) >> 8);
            sendPacket(YAW_CW_COMMAND, buffer, 2);
            Thread.Sleep(50);
        }

        private void button12_Click(object sender, EventArgs e)
        {

            // YAW_CCW_COMMAND = 0x4018;

            byte[] buffer = new byte[2];
            buffer[0] = (byte)(PID_GAIN_READ & 0x00FF);
            buffer[1] = (byte)((PID_GAIN_READ & 0xFF00) >> 8);
            sendPacket(YAW_CCW_COMMAND, buffer, 2);
            Thread.Sleep(50);

        }

        private void button16_Click(object sender, EventArgs e)
        {

            // AUTO_COMMAND = 0x4020;

            byte[] buffer = new byte[2];
            buffer[0] = (byte)(PID_GAIN_READ & 0x00FF);
            buffer[1] = (byte)((PID_GAIN_READ & 0xFF00) >> 8);
            sendPacket(AUTO_COMMAND, buffer, 2);
            Thread.Sleep(50);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //RESET DRONE SPEED BUTTON
            trackBar1.Value = 0; //EAST
            trackBar2.Value = 0; //NORTH
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //CENTER MAP BUTTON
            map.Position = new PointLatLng((double)(telem.latitude_e7 / (double)10000000), (double)(telem.longitude_e7 / (double)10000000));
            map.Refresh();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            //MAP ZOOM TRACKBAR
            label121.Text = trackBar3.Value.ToString();
            map.Zoom = trackBar3.Value;
        }

        public void button20_Click(object sender, EventArgs e)
        {
            //EXPERIMENTAL CHANGE DATA BUTTON
            test.test_1_f32 = Convert.ToSingle(textBox124.Text);
            test.test_2_f32 = Convert.ToSingle(textBox123.Text);
            test.test_3_f32 = Convert.ToSingle(textBox122.Text);
            test.test_4_f32 = Convert.ToSingle(textBox121.Text);
            test.test_5_f32 = Convert.ToSingle(textBox120.Text);
            test.test_6_f32 = Convert.ToSingle(textBox119.Text);
            test.test_7_f32 = Convert.ToSingle(textBox118.Text);
            test.test_8_f32 = Convert.ToSingle(textBox117.Text);
            test.test_9_f32 = Convert.ToSingle(textBox116.Text);
            test.test_10_f32 = Convert.ToSingle(textBox115.Text);
            test.test_11_s32 = Convert.ToInt32(textBox114.Text);
            test.test_12_s32 = Convert.ToInt32(textBox113.Text);
            test.test_13_u32 = Convert.ToUInt32(textBox112.Text);
            test.test_14_u32 = Convert.ToUInt32(textBox111.Text);
            test.test_15_s16 = Convert.ToInt16(textBox110.Text);
            test.test_16_s16 = Convert.ToInt16(textBox109.Text);
            test.test_17_u16 = Convert.ToUInt16(textBox108.Text);
            test.test_18_u16 = Convert.ToUInt16(textBox107.Text);
            test.test_19_s8 = Convert.ToSByte(textBox88.Text);
            test.test_20_u8 = Convert.ToByte(textBox87.Text);


            byte[] buffer = new byte[66];
            limit = 0;
            buffer = addToSendData(ref test.test_1_f32, ref buffer);
            buffer = addToSendData(ref test.test_2_f32, ref buffer);
            buffer = addToSendData(ref test.test_3_f32, ref buffer);
            buffer = addToSendData(ref test.test_4_f32, ref buffer);
            buffer = addToSendData(ref test.test_5_f32, ref buffer);
            buffer = addToSendData(ref test.test_6_f32, ref buffer);
            buffer = addToSendData(ref test.test_7_f32, ref buffer);
            buffer = addToSendData(ref test.test_8_f32, ref buffer);
            buffer = addToSendData(ref test.test_9_f32, ref buffer);
            buffer = addToSendData(ref test.test_10_f32, ref buffer);
            buffer = addToSendData(ref test.test_11_s32, ref buffer);
            buffer = addToSendData(ref test.test_12_s32, ref buffer);
            buffer = addToSendData(ref test.test_13_u32, ref buffer);
            buffer = addToSendData(ref test.test_14_u32, ref buffer);
            buffer = addToSendData(ref test.test_15_s16, ref buffer);
            buffer = addToSendData(ref test.test_16_s16, ref buffer);
            buffer = addToSendData(ref test.test_17_u16, ref buffer);
            buffer = addToSendData(ref test.test_18_u16, ref buffer);
            buffer = addToSendData(ref test.test_19_s8, ref buffer);
            buffer = addToSendData(ref test.test_20_u8, ref buffer);

            sendPacket(TEST_PARAM_WRITE, buffer, (ushort)buffer.Length);
            Thread.Sleep(50);

            getexperimentaldata();

        }

        public void getexperimentaldata()
        {
            label199.Text = test.test_1_f32.ToString();
            label198.Text = test.test_2_f32.ToString();
            label196.Text = test.test_3_f32.ToString();
            label197.Text = test.test_4_f32.ToString();
            label192.Text = test.test_5_f32.ToString();
            label193.Text = test.test_6_f32.ToString();
            label194.Text = test.test_7_f32.ToString();
            label195.Text = test.test_8_f32.ToString();
            label188.Text = test.test_9_f32.ToString();
            label189.Text = test.test_10_f32.ToString();
            label190.Text = test.test_11_s32.ToString();
            label191.Text = test.test_12_s32.ToString();
            label184.Text = test.test_13_u32.ToString();
            label185.Text = test.test_14_u32.ToString();
            label186.Text = test.test_15_s16.ToString();
            label187.Text = test.test_16_s16.ToString();
            label180.Text = test.test_17_u16.ToString();
            label181.Text = test.test_18_u16.ToString();
            label182.Text = test.test_19_s8.ToString();
            label183.Text = test.test_20_u8.ToString();

            textBox124.Text = test.test_1_f32.ToString();
            textBox123.Text = test.test_2_f32.ToString();
            textBox122.Text = test.test_3_f32.ToString();
            textBox121.Text = test.test_4_f32.ToString();
            textBox120.Text = test.test_5_f32.ToString();
            textBox119.Text = test.test_6_f32.ToString();
            textBox118.Text = test.test_7_f32.ToString();
            textBox117.Text = test.test_8_f32.ToString();
            textBox116.Text = test.test_9_f32.ToString();
            textBox115.Text = test.test_10_f32.ToString();
            textBox114.Text = test.test_11_s32.ToString();
            textBox113.Text = test.test_12_s32.ToString();
            textBox112.Text = test.test_13_u32.ToString();
            textBox111.Text = test.test_14_u32.ToString();
            textBox110.Text = test.test_15_s16.ToString();
            textBox109.Text = test.test_16_s16.ToString();
            textBox108.Text = test.test_17_u16.ToString();
            textBox107.Text = test.test_18_u16.ToString();
            textBox88.Text = test.test_19_s8.ToString();
            textBox87.Text = test.test_20_u8.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //EXPERIMENTAL REQUEST DATA BUTTON
            byte[] buffer = new byte[2];
            buffer[0] = (byte)(TEST_PARAM_READ & 0x00FF);
            buffer[1] = (byte)((TEST_PARAM_READ & 0xFF00) >> 8);
            sendPacket(TEST_PARAM_READ, buffer, 2);
            Thread.Sleep(50);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //IT GETS PID DATAS WHEN TAB CHANGES
            if (tabControl1.SelectedTab == tabPage5)
            {
                byte[] buffer = new byte[2];
                buffer[0] = (byte)(TEST_PARAM_READ & 0x00FF);
                buffer[1] = (byte)((TEST_PARAM_READ & 0xFF00) >> 8);
                sendPacket(TEST_PARAM_READ, buffer, 2);
                Thread.Sleep(50);

            }
            if (tabControl1.SelectedTab == tabPage3)
            {
                byte[] buffer = new byte[2];
                buffer[0] = (byte)(PID_GAIN_READ & 0x00FF);
                buffer[1] = (byte)((PID_GAIN_READ & 0xFF00) >> 8);
                sendPacket(PID_GAIN_READ, buffer, 2);
                Thread.Sleep(50);
            }
        }

        public void deleterouteAuto()
        {
            //DELETE ROUTES
            if (telem.route_distance_m < 3 || telem.route_distance_m == 0)
            {
                line_layer.Points.Clear();

                line_overlay.Routes.Remove(line_layer);
                line_overlay.Routes.Clear();

                map.Overlays.Remove(line_overlay);
            }
            if (telem.ref_latitude_e7 == 0  && telem.ref_longitude_e7 == 0)
            {
                line_layer.Points.Clear();

                line_overlay.Routes.Remove(line_layer);
                line_overlay.Routes.Clear();

                map.Overlays.Remove(line_overlay);
            }
        }

        public void homeMarker()
        {
            //DRAW HOME ICON
            PointLatLng point = new PointLatLng((double)(telem.home_latitude_e7 / (double)10000000), (double)(telem.home_longitude_e7 / (double)10000000));

            markershome = new GMapOverlay("markershome");

            markerhome = new GMarkerGoogle(point, bmpMarkerhome);

            markerhome.Offset = new Point(-bmpMarkerhome.Width / 2, -bmpMarkerhome.Height / 2);
            map.Overlays.Add(markershome);
            markershome.Markers.Add(markerhome);

        }

        public void homeMarkerPos()
        {
            //CHANGE HOME ICON POSITION
            markerhome.Position = new PointLatLng((double)(telem.home_latitude_e7 / (double)10000000), (double)(telem.home_longitude_e7 / (double)10000000));
            map.UpdateMarkerLocalPosition(markerhome);
        }

        public void routeMarker()
        {
            //DRAW ROUTES
            if (telem.route_distance_m > 3 || telem.route_distance_m != 0)
            {
                line_layer = new GMapRoute("single_line");
                line_layer.Stroke = new Pen(Brushes.Red, 3); //width and color of line

                line_overlay.Routes.Add(line_layer);
                map.Overlays.Add(line_overlay);

                //Once the layer is created, simply add the two points you want

                line_layer.Points.Add(new PointLatLng((double)(telem.latitude_e7 / (double)10000000), (double)(telem.longitude_e7 / (double)10000000)));
                line_layer.Points.Add(new PointLatLng((double)(telem.ref_latitude_e7 / (double)10000000), (double)(telem.ref_longitude_e7 / (double)10000000)));

                //Note that if you are using the MouseEventArgs you need to use local coordinates and convert them:
                //line_layer.Points.Add(map.FromLocalToLatLng(e.X, e.Y));

                //To force the draw, you need to update the route
                map.UpdateRouteLocalPosition(line_layer);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //DELETE ROUTES BUTTON
            line_layer.Points.Clear();

            line_overlay.Routes.Remove(line_layer);
            line_overlay.Routes.Clear();

            map.Overlays.Remove(line_overlay);
            
        }







    }
}
