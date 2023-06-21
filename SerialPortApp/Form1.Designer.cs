
namespace SerialPortApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtBoxReceived = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label121 = new System.Windows.Forms.Label();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button18 = new System.Windows.Forms.Button();
            this.label118 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.button7 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox89 = new System.Windows.Forms.TextBox();
            this.label144 = new System.Windows.Forms.Label();
            this.textBox90 = new System.Windows.Forms.TextBox();
            this.textBox91 = new System.Windows.Forms.TextBox();
            this.textBox92 = new System.Windows.Forms.TextBox();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.textBox94 = new System.Windows.Forms.TextBox();
            this.textBox95 = new System.Windows.Forms.TextBox();
            this.textBox96 = new System.Windows.Forms.TextBox();
            this.textBox97 = new System.Windows.Forms.TextBox();
            this.textBox98 = new System.Windows.Forms.TextBox();
            this.textBox99 = new System.Windows.Forms.TextBox();
            this.textBox100 = new System.Windows.Forms.TextBox();
            this.textBox101 = new System.Windows.Forms.TextBox();
            this.textBox102 = new System.Windows.Forms.TextBox();
            this.label145 = new System.Windows.Forms.Label();
            this.textBox103 = new System.Windows.Forms.TextBox();
            this.textBox104 = new System.Windows.Forms.TextBox();
            this.label146 = new System.Windows.Forms.Label();
            this.textBox105 = new System.Windows.Forms.TextBox();
            this.label147 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.label152 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.textBox106 = new System.Windows.Forms.TextBox();
            this.label161 = new System.Windows.Forms.Label();
            this.textBox86 = new System.Windows.Forms.TextBox();
            this.label141 = new System.Windows.Forms.Label();
            this.textBox85 = new System.Windows.Forms.TextBox();
            this.label140 = new System.Windows.Forms.Label();
            this.textBox84 = new System.Windows.Forms.TextBox();
            this.label139 = new System.Windows.Forms.Label();
            this.textBox68 = new System.Windows.Forms.TextBox();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.textBox70 = new System.Windows.Forms.TextBox();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.textBox72 = new System.Windows.Forms.TextBox();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.textBox74 = new System.Windows.Forms.TextBox();
            this.textBox75 = new System.Windows.Forms.TextBox();
            this.textBox76 = new System.Windows.Forms.TextBox();
            this.textBox77 = new System.Windows.Forms.TextBox();
            this.textBox78 = new System.Windows.Forms.TextBox();
            this.textBox79 = new System.Windows.Forms.TextBox();
            this.textBox80 = new System.Windows.Forms.TextBox();
            this.label123 = new System.Windows.Forms.Label();
            this.textBox81 = new System.Windows.Forms.TextBox();
            this.textBox82 = new System.Windows.Forms.TextBox();
            this.label124 = new System.Windows.Forms.Label();
            this.textBox83 = new System.Windows.Forms.TextBox();
            this.label125 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.label122 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label109 = new System.Windows.Forms.Label();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.textBox87 = new System.Windows.Forms.TextBox();
            this.textBox88 = new System.Windows.Forms.TextBox();
            this.textBox107 = new System.Windows.Forms.TextBox();
            this.textBox108 = new System.Windows.Forms.TextBox();
            this.textBox109 = new System.Windows.Forms.TextBox();
            this.textBox110 = new System.Windows.Forms.TextBox();
            this.textBox111 = new System.Windows.Forms.TextBox();
            this.textBox112 = new System.Windows.Forms.TextBox();
            this.textBox113 = new System.Windows.Forms.TextBox();
            this.textBox114 = new System.Windows.Forms.TextBox();
            this.textBox115 = new System.Windows.Forms.TextBox();
            this.textBox116 = new System.Windows.Forms.TextBox();
            this.textBox117 = new System.Windows.Forms.TextBox();
            this.textBox118 = new System.Windows.Forms.TextBox();
            this.textBox119 = new System.Windows.Forms.TextBox();
            this.textBox120 = new System.Windows.Forms.TextBox();
            this.textBox121 = new System.Windows.Forms.TextBox();
            this.textBox122 = new System.Windows.Forms.TextBox();
            this.textBox123 = new System.Windows.Forms.TextBox();
            this.textBox124 = new System.Windows.Forms.TextBox();
            this.label142 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.label164 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.label168 = new System.Windows.Forms.Label();
            this.label169 = new System.Windows.Forms.Label();
            this.label170 = new System.Windows.Forms.Label();
            this.label171 = new System.Windows.Forms.Label();
            this.label172 = new System.Windows.Forms.Label();
            this.label173 = new System.Windows.Forms.Label();
            this.label174 = new System.Windows.Forms.Label();
            this.label175 = new System.Windows.Forms.Label();
            this.label176 = new System.Windows.Forms.Label();
            this.label177 = new System.Windows.Forms.Label();
            this.label178 = new System.Windows.Forms.Label();
            this.label179 = new System.Windows.Forms.Label();
            this.label180 = new System.Windows.Forms.Label();
            this.label181 = new System.Windows.Forms.Label();
            this.label182 = new System.Windows.Forms.Label();
            this.label183 = new System.Windows.Forms.Label();
            this.label184 = new System.Windows.Forms.Label();
            this.label185 = new System.Windows.Forms.Label();
            this.label186 = new System.Windows.Forms.Label();
            this.label187 = new System.Windows.Forms.Label();
            this.label188 = new System.Windows.Forms.Label();
            this.label189 = new System.Windows.Forms.Label();
            this.label190 = new System.Windows.Forms.Label();
            this.label191 = new System.Windows.Forms.Label();
            this.label192 = new System.Windows.Forms.Label();
            this.label193 = new System.Windows.Forms.Label();
            this.label194 = new System.Windows.Forms.Label();
            this.label195 = new System.Windows.Forms.Label();
            this.label196 = new System.Windows.Forms.Label();
            this.label197 = new System.Windows.Forms.Label();
            this.label198 = new System.Windows.Forms.Label();
            this.label199 = new System.Windows.Forms.Label();
            this.button15 = new System.Windows.Forms.Button();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(122, 46);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorts.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(305, 44);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(421, 44);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtBoxReceived
            // 
            this.txtBoxReceived.Location = new System.Drawing.Point(142, 68);
            this.txtBoxReceived.Name = "txtBoxReceived";
            this.txtBoxReceived.ReadOnly = true;
            this.txtBoxReceived.Size = new System.Drawing.Size(100, 20);
            this.txtBoxReceived.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(472, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(472, 29);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(211, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(83, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(142, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(211, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(83, 20);
            this.textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(142, 119);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(211, 93);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(83, 20);
            this.textBox7.TabIndex = 10;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(142, 146);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 18;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(142, 172);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 17;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(142, 198);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 16;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(142, 226);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 15;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(142, 252);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 14;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(142, 278);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 13;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(142, 304);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 12;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(211, 116);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(83, 20);
            this.textBox15.TabIndex = 11;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(241, 142);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(53, 20);
            this.textBox16.TabIndex = 28;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(142, 329);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 26;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(142, 355);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 25;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(142, 381);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(100, 20);
            this.textBox20.TabIndex = 24;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(142, 407);
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(100, 20);
            this.textBox21.TabIndex = 23;
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox22.Location = new System.Drawing.Point(907, 9);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(127, 37);
            this.textBox22.TabIndex = 22;
            this.textBox22.Text = "0";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox23.Location = new System.Drawing.Point(1090, 9);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(127, 37);
            this.textBox23.TabIndex = 21;
            this.textBox23.Text = "0";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(142, 435);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(100, 20);
            this.textBox24.TabIndex = 20;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(142, 460);
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            this.textBox25.Size = new System.Drawing.Size(100, 20);
            this.textBox25.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(784, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "CHANGE DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(784, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 47);
            this.button2.TabIndex = 30;
            this.button2.Text = "REQUEST DATA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(300, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1148, 777);
            this.tabControl1.TabIndex = 31;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1140, 751);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CONNECTION";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.comboBoxBaudrate);
            this.groupBox1.Controls.Add(this.comboBoxPorts);
            this.groupBox1.Location = new System.Drawing.Point(23, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 130);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMPORT CONTROL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM PORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "BAUD RATE";
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.comboBoxBaudrate.Location = new System.Drawing.Point(122, 73);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaudrate.TabIndex = 4;
            this.comboBoxBaudrate.Text = "57600";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label121);
            this.tabPage2.Controls.Add(this.trackBar3);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.button18);
            this.tabPage2.Controls.Add(this.label118);
            this.tabPage2.Controls.Add(this.label117);
            this.tabPage2.Controls.Add(this.button17);
            this.tabPage2.Controls.Add(this.trackBar2);
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.map);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.splitter1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1140, 751);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MAP";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(944, 3);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(32, 13);
            this.label121.TabIndex = 65;
            this.label121.Text = "zoom";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(944, 22);
            this.trackBar3.Maximum = 20;
            this.trackBar3.Minimum = 1;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.Size = new System.Drawing.Size(45, 726);
            this.trackBar3.TabIndex = 64;
            this.trackBar3.Value = 18;
            this.trackBar3.ValueChanged += new System.EventHandler(this.trackBar3_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1095, 723);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 63;
            this.checkBox1.Text = "lock";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(1013, 718);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 62;
            this.button18.Text = "center map";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(1090, 620);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(14, 13);
            this.label118.TabIndex = 61;
            this.label118.Text = "E";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(1089, 551);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(15, 13);
            this.label117.TabIndex = 60;
            this.label117.Text = "N";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(1013, 675);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 31);
            this.button17.TabIndex = 59;
            this.button17.Text = "reset";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1038, 506);
            this.trackBar2.Minimum = -10;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.Size = new System.Drawing.Size(45, 104);
            this.trackBar2.TabIndex = 58;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(994, 616);
            this.trackBar1.Minimum = -10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 57;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(994, 422);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(110, 50);
            this.button10.TabIndex = 44;
            this.button10.Text = "BREAK";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(994, 102);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 50);
            this.button6.TabIndex = 40;
            this.button6.Text = "DISARM";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(994, 342);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 50);
            this.button9.TabIndex = 43;
            this.button9.Text = "RTL";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(994, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 50);
            this.button5.TabIndex = 39;
            this.button5.Text = "ARM";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(994, 262);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 50);
            this.button8.TabIndex = 42;
            this.button8.Text = "LAND";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(6, 6);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(917, 727);
            this.map.TabIndex = 29;
            this.map.Zoom = 0D;
            this.map.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.map_OnMapZoomChanged);
            this.map.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.map_MouseDoubleClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(994, 182);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 50);
            this.button7.TabIndex = 41;
            this.button7.Text = "TAKE OFF";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(934, 745);
            this.splitter1.TabIndex = 56;
            this.splitter1.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox89);
            this.tabPage4.Controls.Add(this.label144);
            this.tabPage4.Controls.Add(this.textBox90);
            this.tabPage4.Controls.Add(this.textBox91);
            this.tabPage4.Controls.Add(this.textBox92);
            this.tabPage4.Controls.Add(this.textBox93);
            this.tabPage4.Controls.Add(this.textBox94);
            this.tabPage4.Controls.Add(this.textBox95);
            this.tabPage4.Controls.Add(this.textBox96);
            this.tabPage4.Controls.Add(this.textBox97);
            this.tabPage4.Controls.Add(this.textBox98);
            this.tabPage4.Controls.Add(this.textBox99);
            this.tabPage4.Controls.Add(this.textBox100);
            this.tabPage4.Controls.Add(this.textBox101);
            this.tabPage4.Controls.Add(this.textBox102);
            this.tabPage4.Controls.Add(this.label145);
            this.tabPage4.Controls.Add(this.textBox103);
            this.tabPage4.Controls.Add(this.textBox104);
            this.tabPage4.Controls.Add(this.label146);
            this.tabPage4.Controls.Add(this.textBox105);
            this.tabPage4.Controls.Add(this.label147);
            this.tabPage4.Controls.Add(this.label148);
            this.tabPage4.Controls.Add(this.label149);
            this.tabPage4.Controls.Add(this.label150);
            this.tabPage4.Controls.Add(this.label151);
            this.tabPage4.Controls.Add(this.label152);
            this.tabPage4.Controls.Add(this.label153);
            this.tabPage4.Controls.Add(this.label154);
            this.tabPage4.Controls.Add(this.label155);
            this.tabPage4.Controls.Add(this.label156);
            this.tabPage4.Controls.Add(this.label157);
            this.tabPage4.Controls.Add(this.label158);
            this.tabPage4.Controls.Add(this.label159);
            this.tabPage4.Controls.Add(this.label160);
            this.tabPage4.Controls.Add(this.textBox106);
            this.tabPage4.Controls.Add(this.label161);
            this.tabPage4.Controls.Add(this.textBox86);
            this.tabPage4.Controls.Add(this.label141);
            this.tabPage4.Controls.Add(this.textBox85);
            this.tabPage4.Controls.Add(this.label140);
            this.tabPage4.Controls.Add(this.textBox84);
            this.tabPage4.Controls.Add(this.label139);
            this.tabPage4.Controls.Add(this.textBox68);
            this.tabPage4.Controls.Add(this.textBox69);
            this.tabPage4.Controls.Add(this.textBox70);
            this.tabPage4.Controls.Add(this.textBox71);
            this.tabPage4.Controls.Add(this.textBox72);
            this.tabPage4.Controls.Add(this.textBox73);
            this.tabPage4.Controls.Add(this.textBox74);
            this.tabPage4.Controls.Add(this.textBox75);
            this.tabPage4.Controls.Add(this.textBox76);
            this.tabPage4.Controls.Add(this.textBox77);
            this.tabPage4.Controls.Add(this.textBox78);
            this.tabPage4.Controls.Add(this.textBox79);
            this.tabPage4.Controls.Add(this.textBox80);
            this.tabPage4.Controls.Add(this.label123);
            this.tabPage4.Controls.Add(this.textBox81);
            this.tabPage4.Controls.Add(this.textBox82);
            this.tabPage4.Controls.Add(this.label124);
            this.tabPage4.Controls.Add(this.textBox83);
            this.tabPage4.Controls.Add(this.label125);
            this.tabPage4.Controls.Add(this.label126);
            this.tabPage4.Controls.Add(this.label127);
            this.tabPage4.Controls.Add(this.label128);
            this.tabPage4.Controls.Add(this.label129);
            this.tabPage4.Controls.Add(this.label130);
            this.tabPage4.Controls.Add(this.label131);
            this.tabPage4.Controls.Add(this.label132);
            this.tabPage4.Controls.Add(this.label133);
            this.tabPage4.Controls.Add(this.label134);
            this.tabPage4.Controls.Add(this.label135);
            this.tabPage4.Controls.Add(this.label136);
            this.tabPage4.Controls.Add(this.label137);
            this.tabPage4.Controls.Add(this.label138);
            this.tabPage4.Controls.Add(this.textBox67);
            this.tabPage4.Controls.Add(this.label122);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.textBox20);
            this.tabPage4.Controls.Add(this.textBox13);
            this.tabPage4.Controls.Add(this.textBox8);
            this.tabPage4.Controls.Add(this.textBox9);
            this.tabPage4.Controls.Add(this.textBox24);
            this.tabPage4.Controls.Add(this.textBox4);
            this.tabPage4.Controls.Add(this.textBox14);
            this.tabPage4.Controls.Add(this.textBox6);
            this.tabPage4.Controls.Add(this.textBox19);
            this.tabPage4.Controls.Add(this.textBox12);
            this.tabPage4.Controls.Add(this.textBox18);
            this.tabPage4.Controls.Add(this.textBox21);
            this.tabPage4.Controls.Add(this.textBox25);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.textBox10);
            this.tabPage4.Controls.Add(this.textBox11);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.txtBoxReceived);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1140, 751);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "TELEMETRY";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox89
            // 
            this.textBox89.Location = new System.Drawing.Point(679, 508);
            this.textBox89.Name = "textBox89";
            this.textBox89.ReadOnly = true;
            this.textBox89.Size = new System.Drawing.Size(100, 20);
            this.textBox89.TabIndex = 130;
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.Location = new System.Drawing.Point(574, 511);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(36, 13);
            this.label144.TabIndex = 131;
            this.label144.Text = "test_6";
            // 
            // textBox90
            // 
            this.textBox90.Location = new System.Drawing.Point(679, 403);
            this.textBox90.Name = "textBox90";
            this.textBox90.ReadOnly = true;
            this.textBox90.Size = new System.Drawing.Size(100, 20);
            this.textBox90.TabIndex = 111;
            // 
            // textBox91
            // 
            this.textBox91.Location = new System.Drawing.Point(679, 300);
            this.textBox91.Name = "textBox91";
            this.textBox91.ReadOnly = true;
            this.textBox91.Size = new System.Drawing.Size(100, 20);
            this.textBox91.TabIndex = 102;
            // 
            // textBox92
            // 
            this.textBox92.Location = new System.Drawing.Point(679, 168);
            this.textBox92.Name = "textBox92";
            this.textBox92.ReadOnly = true;
            this.textBox92.Size = new System.Drawing.Size(100, 20);
            this.textBox92.TabIndex = 107;
            // 
            // textBox93
            // 
            this.textBox93.Location = new System.Drawing.Point(679, 194);
            this.textBox93.Name = "textBox93";
            this.textBox93.ReadOnly = true;
            this.textBox93.Size = new System.Drawing.Size(100, 20);
            this.textBox93.TabIndex = 106;
            // 
            // textBox94
            // 
            this.textBox94.Location = new System.Drawing.Point(679, 457);
            this.textBox94.Name = "textBox94";
            this.textBox94.ReadOnly = true;
            this.textBox94.Size = new System.Drawing.Size(100, 20);
            this.textBox94.TabIndex = 109;
            // 
            // textBox95
            // 
            this.textBox95.Location = new System.Drawing.Point(679, 115);
            this.textBox95.Name = "textBox95";
            this.textBox95.ReadOnly = true;
            this.textBox95.Size = new System.Drawing.Size(100, 20);
            this.textBox95.TabIndex = 99;
            // 
            // textBox96
            // 
            this.textBox96.Location = new System.Drawing.Point(679, 326);
            this.textBox96.Name = "textBox96";
            this.textBox96.ReadOnly = true;
            this.textBox96.Size = new System.Drawing.Size(100, 20);
            this.textBox96.TabIndex = 101;
            // 
            // textBox97
            // 
            this.textBox97.Location = new System.Drawing.Point(679, 141);
            this.textBox97.Name = "textBox97";
            this.textBox97.ReadOnly = true;
            this.textBox97.Size = new System.Drawing.Size(100, 20);
            this.textBox97.TabIndex = 100;
            // 
            // textBox98
            // 
            this.textBox98.Location = new System.Drawing.Point(679, 377);
            this.textBox98.Name = "textBox98";
            this.textBox98.ReadOnly = true;
            this.textBox98.Size = new System.Drawing.Size(100, 20);
            this.textBox98.TabIndex = 112;
            // 
            // textBox99
            // 
            this.textBox99.Location = new System.Drawing.Point(679, 274);
            this.textBox99.Name = "textBox99";
            this.textBox99.ReadOnly = true;
            this.textBox99.Size = new System.Drawing.Size(100, 20);
            this.textBox99.TabIndex = 103;
            // 
            // textBox100
            // 
            this.textBox100.Location = new System.Drawing.Point(679, 351);
            this.textBox100.Name = "textBox100";
            this.textBox100.ReadOnly = true;
            this.textBox100.Size = new System.Drawing.Size(100, 20);
            this.textBox100.TabIndex = 113;
            // 
            // textBox101
            // 
            this.textBox101.Location = new System.Drawing.Point(679, 429);
            this.textBox101.Name = "textBox101";
            this.textBox101.ReadOnly = true;
            this.textBox101.Size = new System.Drawing.Size(100, 20);
            this.textBox101.TabIndex = 110;
            // 
            // textBox102
            // 
            this.textBox102.Location = new System.Drawing.Point(679, 482);
            this.textBox102.Name = "textBox102";
            this.textBox102.ReadOnly = true;
            this.textBox102.Size = new System.Drawing.Size(100, 20);
            this.textBox102.TabIndex = 108;
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.Location = new System.Drawing.Point(574, 485);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(36, 13);
            this.label145.TabIndex = 129;
            this.label145.Text = "test_5";
            // 
            // textBox103
            // 
            this.textBox103.Location = new System.Drawing.Point(679, 220);
            this.textBox103.Name = "textBox103";
            this.textBox103.ReadOnly = true;
            this.textBox103.Size = new System.Drawing.Size(100, 20);
            this.textBox103.TabIndex = 105;
            // 
            // textBox104
            // 
            this.textBox104.Location = new System.Drawing.Point(679, 248);
            this.textBox104.Name = "textBox104";
            this.textBox104.ReadOnly = true;
            this.textBox104.Size = new System.Drawing.Size(100, 20);
            this.textBox104.TabIndex = 104;
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.Location = new System.Drawing.Point(574, 460);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(36, 13);
            this.label146.TabIndex = 128;
            this.label146.Text = "test_4";
            // 
            // textBox105
            // 
            this.textBox105.Location = new System.Drawing.Point(679, 90);
            this.textBox105.Name = "textBox105";
            this.textBox105.ReadOnly = true;
            this.textBox105.Size = new System.Drawing.Size(100, 20);
            this.textBox105.TabIndex = 98;
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.Location = new System.Drawing.Point(574, 93);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(57, 13);
            this.label147.TabIndex = 114;
            this.label147.Text = "gps_vacc ";
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.Location = new System.Drawing.Point(574, 432);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(36, 13);
            this.label148.TabIndex = 127;
            this.label148.Text = "test_3";
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.Location = new System.Drawing.Point(574, 118);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(96, 13);
            this.label149.TabIndex = 115;
            this.label149.Text = "home_distance_m ";
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.Location = new System.Drawing.Point(574, 144);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(94, 13);
            this.label150.TabIndex = 116;
            this.label150.Text = "route_distance_m ";
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.Location = new System.Drawing.Point(574, 406);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(36, 13);
            this.label151.TabIndex = 126;
            this.label151.Text = "test_2";
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.Location = new System.Drawing.Point(574, 171);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(80, 13);
            this.label152.TabIndex = 117;
            this.label152.Text = "flight_time_sec ";
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.Location = new System.Drawing.Point(574, 197);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(81, 13);
            this.label153.TabIndex = 118;
            this.label153.Text = "power_milliwatt ";
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.Location = new System.Drawing.Point(574, 380);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(39, 13);
            this.label154.TabIndex = 125;
            this.label154.Text = "test_1 ";
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Location = new System.Drawing.Point(574, 223);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(101, 13);
            this.label155.TabIndex = 119;
            this.label155.Text = "remaining_capacity ";
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.Location = new System.Drawing.Point(574, 249);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(63, 13);
            this.label156.TabIndex = 120;
            this.label156.Text = "throttle_out ";
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.Location = new System.Drawing.Point(574, 354);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(39, 13);
            this.label157.TabIndex = 124;
            this.label157.Text = "test_0 ";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.Location = new System.Drawing.Point(574, 277);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(84, 13);
            this.label158.TabIndex = 121;
            this.label158.Text = "pid_flight_mode ";
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Location = new System.Drawing.Point(574, 303);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(109, 13);
            this.label159.TabIndex = 122;
            this.label159.Text = "gps_satellite_number ";
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Location = new System.Drawing.Point(574, 329);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(84, 13);
            this.label160.TabIndex = 123;
            this.label160.Text = "battery_percent ";
            // 
            // textBox106
            // 
            this.textBox106.Location = new System.Drawing.Point(679, 64);
            this.textBox106.Name = "textBox106";
            this.textBox106.ReadOnly = true;
            this.textBox106.Size = new System.Drawing.Size(100, 20);
            this.textBox106.TabIndex = 96;
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Location = new System.Drawing.Point(574, 67);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(57, 13);
            this.label161.TabIndex = 97;
            this.label161.Text = "gps_hacc ";
            // 
            // textBox86
            // 
            this.textBox86.Location = new System.Drawing.Point(419, 560);
            this.textBox86.Name = "textBox86";
            this.textBox86.ReadOnly = true;
            this.textBox86.Size = new System.Drawing.Size(100, 20);
            this.textBox86.TabIndex = 94;
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.Location = new System.Drawing.Point(298, 563);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(57, 13);
            this.label141.TabIndex = 95;
            this.label141.Text = "gps_pdop ";
            // 
            // textBox85
            // 
            this.textBox85.Location = new System.Drawing.Point(419, 534);
            this.textBox85.Name = "textBox85";
            this.textBox85.ReadOnly = true;
            this.textBox85.Size = new System.Drawing.Size(100, 20);
            this.textBox85.TabIndex = 92;
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.Location = new System.Drawing.Point(298, 537);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(109, 13);
            this.label140.TabIndex = 93;
            this.label140.Text = "ground_speed_cmps ";
            // 
            // textBox84
            // 
            this.textBox84.Location = new System.Drawing.Point(419, 508);
            this.textBox84.Name = "textBox84";
            this.textBox84.ReadOnly = true;
            this.textBox84.Size = new System.Drawing.Size(100, 20);
            this.textBox84.TabIndex = 90;
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.Location = new System.Drawing.Point(298, 511);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(124, 13);
            this.label139.TabIndex = 91;
            this.label139.Text = "ref_gps_E_speed_cmps ";
            // 
            // textBox68
            // 
            this.textBox68.Location = new System.Drawing.Point(419, 403);
            this.textBox68.Name = "textBox68";
            this.textBox68.ReadOnly = true;
            this.textBox68.Size = new System.Drawing.Size(100, 20);
            this.textBox68.TabIndex = 71;
            // 
            // textBox69
            // 
            this.textBox69.Location = new System.Drawing.Point(419, 300);
            this.textBox69.Name = "textBox69";
            this.textBox69.ReadOnly = true;
            this.textBox69.Size = new System.Drawing.Size(100, 20);
            this.textBox69.TabIndex = 62;
            // 
            // textBox70
            // 
            this.textBox70.Location = new System.Drawing.Point(419, 168);
            this.textBox70.Name = "textBox70";
            this.textBox70.ReadOnly = true;
            this.textBox70.Size = new System.Drawing.Size(100, 20);
            this.textBox70.TabIndex = 67;
            // 
            // textBox71
            // 
            this.textBox71.Location = new System.Drawing.Point(419, 194);
            this.textBox71.Name = "textBox71";
            this.textBox71.ReadOnly = true;
            this.textBox71.Size = new System.Drawing.Size(100, 20);
            this.textBox71.TabIndex = 66;
            // 
            // textBox72
            // 
            this.textBox72.Location = new System.Drawing.Point(419, 457);
            this.textBox72.Name = "textBox72";
            this.textBox72.ReadOnly = true;
            this.textBox72.Size = new System.Drawing.Size(100, 20);
            this.textBox72.TabIndex = 69;
            // 
            // textBox73
            // 
            this.textBox73.Location = new System.Drawing.Point(419, 115);
            this.textBox73.Name = "textBox73";
            this.textBox73.ReadOnly = true;
            this.textBox73.Size = new System.Drawing.Size(100, 20);
            this.textBox73.TabIndex = 59;
            // 
            // textBox74
            // 
            this.textBox74.Location = new System.Drawing.Point(419, 326);
            this.textBox74.Name = "textBox74";
            this.textBox74.ReadOnly = true;
            this.textBox74.Size = new System.Drawing.Size(100, 20);
            this.textBox74.TabIndex = 61;
            // 
            // textBox75
            // 
            this.textBox75.Location = new System.Drawing.Point(419, 141);
            this.textBox75.Name = "textBox75";
            this.textBox75.ReadOnly = true;
            this.textBox75.Size = new System.Drawing.Size(100, 20);
            this.textBox75.TabIndex = 60;
            // 
            // textBox76
            // 
            this.textBox76.Location = new System.Drawing.Point(419, 377);
            this.textBox76.Name = "textBox76";
            this.textBox76.ReadOnly = true;
            this.textBox76.Size = new System.Drawing.Size(100, 20);
            this.textBox76.TabIndex = 72;
            // 
            // textBox77
            // 
            this.textBox77.Location = new System.Drawing.Point(419, 274);
            this.textBox77.Name = "textBox77";
            this.textBox77.ReadOnly = true;
            this.textBox77.Size = new System.Drawing.Size(100, 20);
            this.textBox77.TabIndex = 63;
            // 
            // textBox78
            // 
            this.textBox78.Location = new System.Drawing.Point(419, 351);
            this.textBox78.Name = "textBox78";
            this.textBox78.ReadOnly = true;
            this.textBox78.Size = new System.Drawing.Size(100, 20);
            this.textBox78.TabIndex = 73;
            // 
            // textBox79
            // 
            this.textBox79.Location = new System.Drawing.Point(419, 429);
            this.textBox79.Name = "textBox79";
            this.textBox79.ReadOnly = true;
            this.textBox79.Size = new System.Drawing.Size(100, 20);
            this.textBox79.TabIndex = 70;
            // 
            // textBox80
            // 
            this.textBox80.Location = new System.Drawing.Point(419, 482);
            this.textBox80.Name = "textBox80";
            this.textBox80.ReadOnly = true;
            this.textBox80.Size = new System.Drawing.Size(100, 20);
            this.textBox80.TabIndex = 68;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(298, 485);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(125, 13);
            this.label123.TabIndex = 89;
            this.label123.Text = "ref_gps_N_speed_cmps ";
            // 
            // textBox81
            // 
            this.textBox81.Location = new System.Drawing.Point(419, 220);
            this.textBox81.Name = "textBox81";
            this.textBox81.ReadOnly = true;
            this.textBox81.Size = new System.Drawing.Size(100, 20);
            this.textBox81.TabIndex = 65;
            // 
            // textBox82
            // 
            this.textBox82.Location = new System.Drawing.Point(419, 248);
            this.textBox82.Name = "textBox82";
            this.textBox82.ReadOnly = true;
            this.textBox82.Size = new System.Drawing.Size(100, 20);
            this.textBox82.TabIndex = 64;
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(298, 460);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(106, 13);
            this.label124.TabIndex = 88;
            this.label124.Text = "gps_E_speed_cmps ";
            // 
            // textBox83
            // 
            this.textBox83.Location = new System.Drawing.Point(419, 90);
            this.textBox83.Name = "textBox83";
            this.textBox83.ReadOnly = true;
            this.textBox83.Size = new System.Drawing.Size(100, 20);
            this.textBox83.TabIndex = 58;
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(298, 93);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(77, 13);
            this.label125.TabIndex = 74;
            this.label125.Text = "ref_latitude_e7";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(298, 432);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(107, 13);
            this.label126.TabIndex = 87;
            this.label126.Text = "gps_N_speed_cmps ";
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(298, 118);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(86, 13);
            this.label127.TabIndex = 75;
            this.label127.Text = "ref_longitude_e7";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(298, 144);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(94, 13);
            this.label128.TabIndex = 76;
            this.label128.Text = "home_latitude_e7 ";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(298, 406);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(133, 13);
            this.label129.TabIndex = 86;
            this.label129.Text = "ref_climb_rate_mps_m100 ";
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(298, 171);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(103, 13);
            this.label130.TabIndex = 77;
            this.label130.Text = "home_longitude_e7 ";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(298, 197);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(66, 13);
            this.label131.TabIndex = 78;
            this.label131.Text = "status_flags ";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(298, 380);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(83, 13);
            this.label132.TabIndex = 85;
            this.label132.Text = "rangefinder_cm ";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Location = new System.Drawing.Point(298, 223);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(61, 13);
            this.label133.TabIndex = 79;
            this.label133.Text = "mag_x_mg ";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(298, 249);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(61, 13);
            this.label134.TabIndex = 80;
            this.label134.Text = "mag_y_mg ";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(298, 354);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(60, 13);
            this.label135.TabIndex = 84;
            this.label135.Text = "asl_gps_m ";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(298, 277);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(61, 13);
            this.label136.TabIndex = 81;
            this.label136.Text = "mag_z_mg ";
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.Location = new System.Drawing.Point(298, 303);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(38, 13);
            this.label137.TabIndex = 82;
            this.label137.Text = "agl_m ";
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.Location = new System.Drawing.Point(298, 329);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(56, 13);
            this.label138.TabIndex = 83;
            this.label138.Text = "agl_ref_m ";
            // 
            // textBox67
            // 
            this.textBox67.Location = new System.Drawing.Point(419, 64);
            this.textBox67.Name = "textBox67";
            this.textBox67.ReadOnly = true;
            this.textBox67.Size = new System.Drawing.Size(100, 20);
            this.textBox67.TabIndex = 56;
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(298, 67);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(70, 13);
            this.label122.TabIndex = 57;
            this.label122.Text = "utc_time_sec\t";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(107, 42);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(72, 13);
            this.label27.TabIndex = 55;
            this.label27.Text = "TELEMETRY";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(58, 463);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(54, 13);
            this.label28.TabIndex = 54;
            this.label28.Text = "cpu_load ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(58, 438);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "flight_mode ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "runtime_ms";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(58, 410);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 50;
            this.label18.Text = "pwm4 ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "roll_ref_deg";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "pitch_ref_deg";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(58, 384);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "pwm3 ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "yaw_ref_deg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "gyro_x_dps";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(58, 358);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 48;
            this.label20.Text = "pwm2 ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "gyro_y_dps";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "gyro_z_dps";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(58, 332);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 47;
            this.label21.Text = "pwm1 ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(58, 255);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(78, 13);
            this.label26.TabIndex = 42;
            this.label26.Text = "lin_acc_x_mp2";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(58, 281);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 13);
            this.label25.TabIndex = 43;
            this.label25.Text = "lin_acc_y_mp2";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(58, 307);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(78, 13);
            this.label24.TabIndex = 44;
            this.label24.Text = "lin_acc_z_mp2";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label109);
            this.tabPage3.Controls.Add(this.textBox64);
            this.tabPage3.Controls.Add(this.textBox63);
            this.tabPage3.Controls.Add(this.textBox62);
            this.tabPage3.Controls.Add(this.textBox61);
            this.tabPage3.Controls.Add(this.textBox60);
            this.tabPage3.Controls.Add(this.textBox59);
            this.tabPage3.Controls.Add(this.textBox58);
            this.tabPage3.Controls.Add(this.textBox57);
            this.tabPage3.Controls.Add(this.textBox56);
            this.tabPage3.Controls.Add(this.textBox55);
            this.tabPage3.Controls.Add(this.textBox54);
            this.tabPage3.Controls.Add(this.textBox53);
            this.tabPage3.Controls.Add(this.textBox52);
            this.tabPage3.Controls.Add(this.textBox51);
            this.tabPage3.Controls.Add(this.textBox50);
            this.tabPage3.Controls.Add(this.textBox49);
            this.tabPage3.Controls.Add(this.textBox48);
            this.tabPage3.Controls.Add(this.textBox47);
            this.tabPage3.Controls.Add(this.textBox46);
            this.tabPage3.Controls.Add(this.textBox45);
            this.tabPage3.Controls.Add(this.textBox44);
            this.tabPage3.Controls.Add(this.textBox43);
            this.tabPage3.Controls.Add(this.textBox42);
            this.tabPage3.Controls.Add(this.textBox41);
            this.tabPage3.Controls.Add(this.textBox40);
            this.tabPage3.Controls.Add(this.textBox39);
            this.tabPage3.Controls.Add(this.textBox38);
            this.tabPage3.Controls.Add(this.textBox37);
            this.tabPage3.Controls.Add(this.textBox36);
            this.tabPage3.Controls.Add(this.textBox35);
            this.tabPage3.Controls.Add(this.textBox34);
            this.tabPage3.Controls.Add(this.textBox33);
            this.tabPage3.Controls.Add(this.textBox32);
            this.tabPage3.Controls.Add(this.textBox31);
            this.tabPage3.Controls.Add(this.textBox30);
            this.tabPage3.Controls.Add(this.textBox29);
            this.tabPage3.Controls.Add(this.textBox28);
            this.tabPage3.Controls.Add(this.textBox27);
            this.tabPage3.Controls.Add(this.textBox26);
            this.tabPage3.Controls.Add(this.textBox17);
            this.tabPage3.Controls.Add(this.label89);
            this.tabPage3.Controls.Add(this.label90);
            this.tabPage3.Controls.Add(this.label91);
            this.tabPage3.Controls.Add(this.label92);
            this.tabPage3.Controls.Add(this.label93);
            this.tabPage3.Controls.Add(this.label94);
            this.tabPage3.Controls.Add(this.label95);
            this.tabPage3.Controls.Add(this.label96);
            this.tabPage3.Controls.Add(this.label97);
            this.tabPage3.Controls.Add(this.label98);
            this.tabPage3.Controls.Add(this.label99);
            this.tabPage3.Controls.Add(this.label100);
            this.tabPage3.Controls.Add(this.label101);
            this.tabPage3.Controls.Add(this.label102);
            this.tabPage3.Controls.Add(this.label103);
            this.tabPage3.Controls.Add(this.label104);
            this.tabPage3.Controls.Add(this.label105);
            this.tabPage3.Controls.Add(this.label106);
            this.tabPage3.Controls.Add(this.label107);
            this.tabPage3.Controls.Add(this.label108);
            this.tabPage3.Controls.Add(this.label50);
            this.tabPage3.Controls.Add(this.label51);
            this.tabPage3.Controls.Add(this.label71);
            this.tabPage3.Controls.Add(this.label72);
            this.tabPage3.Controls.Add(this.label73);
            this.tabPage3.Controls.Add(this.label74);
            this.tabPage3.Controls.Add(this.label75);
            this.tabPage3.Controls.Add(this.label76);
            this.tabPage3.Controls.Add(this.label77);
            this.tabPage3.Controls.Add(this.label78);
            this.tabPage3.Controls.Add(this.label79);
            this.tabPage3.Controls.Add(this.label80);
            this.tabPage3.Controls.Add(this.label81);
            this.tabPage3.Controls.Add(this.label82);
            this.tabPage3.Controls.Add(this.label83);
            this.tabPage3.Controls.Add(this.label84);
            this.tabPage3.Controls.Add(this.label85);
            this.tabPage3.Controls.Add(this.label86);
            this.tabPage3.Controls.Add(this.label87);
            this.tabPage3.Controls.Add(this.label88);
            this.tabPage3.Controls.Add(this.label52);
            this.tabPage3.Controls.Add(this.label53);
            this.tabPage3.Controls.Add(this.label54);
            this.tabPage3.Controls.Add(this.label55);
            this.tabPage3.Controls.Add(this.label56);
            this.tabPage3.Controls.Add(this.label57);
            this.tabPage3.Controls.Add(this.label58);
            this.tabPage3.Controls.Add(this.label59);
            this.tabPage3.Controls.Add(this.label60);
            this.tabPage3.Controls.Add(this.label61);
            this.tabPage3.Controls.Add(this.label62);
            this.tabPage3.Controls.Add(this.label63);
            this.tabPage3.Controls.Add(this.label64);
            this.tabPage3.Controls.Add(this.label65);
            this.tabPage3.Controls.Add(this.label66);
            this.tabPage3.Controls.Add(this.label67);
            this.tabPage3.Controls.Add(this.label68);
            this.tabPage3.Controls.Add(this.label69);
            this.tabPage3.Controls.Add(this.label70);
            this.tabPage3.Controls.Add(this.label49);
            this.tabPage3.Controls.Add(this.label45);
            this.tabPage3.Controls.Add(this.label46);
            this.tabPage3.Controls.Add(this.label47);
            this.tabPage3.Controls.Add(this.label48);
            this.tabPage3.Controls.Add(this.label41);
            this.tabPage3.Controls.Add(this.label42);
            this.tabPage3.Controls.Add(this.label43);
            this.tabPage3.Controls.Add(this.label44);
            this.tabPage3.Controls.Add(this.label37);
            this.tabPage3.Controls.Add(this.label38);
            this.tabPage3.Controls.Add(this.label39);
            this.tabPage3.Controls.Add(this.label40);
            this.tabPage3.Controls.Add(this.label33);
            this.tabPage3.Controls.Add(this.label34);
            this.tabPage3.Controls.Add(this.label35);
            this.tabPage3.Controls.Add(this.label36);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.label30);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1140, 751);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PID";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(305, 26);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(57, 13);
            this.label109.TabIndex = 151;
            this.label109.Text = "PID DATA";
            // 
            // textBox64
            // 
            this.textBox64.Location = new System.Drawing.Point(555, 562);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(100, 20);
            this.textBox64.TabIndex = 150;
            // 
            // textBox63
            // 
            this.textBox63.Location = new System.Drawing.Point(555, 537);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(100, 20);
            this.textBox63.TabIndex = 149;
            // 
            // textBox62
            // 
            this.textBox62.Location = new System.Drawing.Point(555, 512);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(100, 20);
            this.textBox62.TabIndex = 148;
            // 
            // textBox61
            // 
            this.textBox61.Location = new System.Drawing.Point(555, 487);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(100, 20);
            this.textBox61.TabIndex = 147;
            // 
            // textBox60
            // 
            this.textBox60.Location = new System.Drawing.Point(555, 462);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(100, 20);
            this.textBox60.TabIndex = 146;
            // 
            // textBox59
            // 
            this.textBox59.Location = new System.Drawing.Point(555, 437);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(100, 20);
            this.textBox59.TabIndex = 145;
            // 
            // textBox58
            // 
            this.textBox58.Location = new System.Drawing.Point(555, 412);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(100, 20);
            this.textBox58.TabIndex = 144;
            // 
            // textBox57
            // 
            this.textBox57.Location = new System.Drawing.Point(555, 387);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(100, 20);
            this.textBox57.TabIndex = 143;
            // 
            // textBox56
            // 
            this.textBox56.Location = new System.Drawing.Point(555, 361);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(100, 20);
            this.textBox56.TabIndex = 142;
            // 
            // textBox55
            // 
            this.textBox55.Location = new System.Drawing.Point(555, 337);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(100, 20);
            this.textBox55.TabIndex = 141;
            // 
            // textBox54
            // 
            this.textBox54.Location = new System.Drawing.Point(555, 312);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(100, 20);
            this.textBox54.TabIndex = 140;
            // 
            // textBox53
            // 
            this.textBox53.Location = new System.Drawing.Point(555, 287);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(100, 20);
            this.textBox53.TabIndex = 139;
            // 
            // textBox52
            // 
            this.textBox52.Location = new System.Drawing.Point(555, 262);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(100, 20);
            this.textBox52.TabIndex = 138;
            // 
            // textBox51
            // 
            this.textBox51.Location = new System.Drawing.Point(555, 238);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(100, 20);
            this.textBox51.TabIndex = 137;
            // 
            // textBox50
            // 
            this.textBox50.Location = new System.Drawing.Point(555, 212);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(100, 20);
            this.textBox50.TabIndex = 136;
            // 
            // textBox49
            // 
            this.textBox49.Location = new System.Drawing.Point(555, 187);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(100, 20);
            this.textBox49.TabIndex = 135;
            // 
            // textBox48
            // 
            this.textBox48.Location = new System.Drawing.Point(555, 162);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(100, 20);
            this.textBox48.TabIndex = 134;
            // 
            // textBox47
            // 
            this.textBox47.Location = new System.Drawing.Point(555, 137);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(100, 20);
            this.textBox47.TabIndex = 133;
            // 
            // textBox46
            // 
            this.textBox46.Location = new System.Drawing.Point(555, 112);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(100, 20);
            this.textBox46.TabIndex = 132;
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(555, 87);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(100, 20);
            this.textBox45.TabIndex = 131;
            // 
            // textBox44
            // 
            this.textBox44.Location = new System.Drawing.Point(206, 562);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(100, 20);
            this.textBox44.TabIndex = 130;
            // 
            // textBox43
            // 
            this.textBox43.Location = new System.Drawing.Point(206, 537);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(100, 20);
            this.textBox43.TabIndex = 129;
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(206, 512);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(100, 20);
            this.textBox42.TabIndex = 128;
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(206, 487);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(100, 20);
            this.textBox41.TabIndex = 127;
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(206, 462);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(100, 20);
            this.textBox40.TabIndex = 126;
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(206, 437);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(100, 20);
            this.textBox39.TabIndex = 125;
            // 
            // textBox38
            // 
            this.textBox38.Location = new System.Drawing.Point(206, 412);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(100, 20);
            this.textBox38.TabIndex = 124;
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(206, 387);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(100, 20);
            this.textBox37.TabIndex = 123;
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(206, 361);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(100, 20);
            this.textBox36.TabIndex = 122;
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(206, 337);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(100, 20);
            this.textBox35.TabIndex = 121;
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(206, 312);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(100, 20);
            this.textBox34.TabIndex = 120;
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(206, 287);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(100, 20);
            this.textBox33.TabIndex = 119;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(206, 262);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(100, 20);
            this.textBox32.TabIndex = 118;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(206, 237);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(100, 20);
            this.textBox31.TabIndex = 117;
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(206, 212);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(100, 20);
            this.textBox30.TabIndex = 116;
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(206, 187);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(100, 20);
            this.textBox29.TabIndex = 115;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(206, 162);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(100, 20);
            this.textBox28.TabIndex = 114;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(206, 137);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(100, 20);
            this.textBox27.TabIndex = 113;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(206, 112);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(100, 20);
            this.textBox26.TabIndex = 112;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(206, 87);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 111;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(378, 490);
            this.label89.Margin = new System.Windows.Forms.Padding(0);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(92, 13);
            this.label89.TabIndex = 110;
            this.label89.Text = "pitch_output_limit ";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(378, 515);
            this.label90.Margin = new System.Windows.Forms.Padding(0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(70, 13);
            this.label90.TabIndex = 109;
            this.label90.Text = "pitch_ki_limit ";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(378, 540);
            this.label91.Margin = new System.Windows.Forms.Padding(0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(74, 13);
            this.label91.TabIndex = 108;
            this.label91.Text = "pitch_kd_limit ";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(378, 565);
            this.label92.Margin = new System.Windows.Forms.Padding(0);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(100, 13);
            this.label92.TabIndex = 107;
            this.label92.Text = "pitch_kd_filter_freq ";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(378, 390);
            this.label93.Margin = new System.Windows.Forms.Padding(0);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(51, 13);
            this.label93.TabIndex = 106;
            this.label93.Text = "pitch_kd ";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(378, 415);
            this.label94.Margin = new System.Windows.Forms.Padding(0);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(51, 13);
            this.label94.TabIndex = 105;
            this.label94.Text = "pitch_kff ";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(378, 441);
            this.label95.Margin = new System.Windows.Forms.Padding(0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(85, 13);
            this.label95.TabIndex = 104;
            this.label95.Text = "pitch_input_limit ";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(378, 465);
            this.label96.Margin = new System.Windows.Forms.Padding(0);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(109, 13);
            this.label96.TabIndex = 103;
            this.label96.Text = "pitch_input_rate_limit ";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(378, 290);
            this.label97.Margin = new System.Windows.Forms.Padding(0);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(64, 13);
            this.label97.TabIndex = 102;
            this.label97.Text = "roll_kd_limit ";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(378, 315);
            this.label98.Margin = new System.Windows.Forms.Padding(0);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(90, 13);
            this.label98.TabIndex = 101;
            this.label98.Text = "roll_kd_filter_freq ";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(378, 340);
            this.label99.Margin = new System.Windows.Forms.Padding(0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(51, 13);
            this.label99.TabIndex = 100;
            this.label99.Text = "pitch_kp ";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(378, 364);
            this.label100.Margin = new System.Windows.Forms.Padding(0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(47, 13);
            this.label100.TabIndex = 99;
            this.label100.Text = "pitch_ki ";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(378, 190);
            this.label101.Margin = new System.Windows.Forms.Padding(0);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(75, 13);
            this.label101.TabIndex = 98;
            this.label101.Text = "roll_input_limit ";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(378, 215);
            this.label102.Margin = new System.Windows.Forms.Padding(0);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(99, 13);
            this.label102.TabIndex = 97;
            this.label102.Text = "roll_input_rate_limit ";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(378, 241);
            this.label103.Margin = new System.Windows.Forms.Padding(0);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(82, 13);
            this.label103.TabIndex = 96;
            this.label103.Text = "roll_output_limit ";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(378, 265);
            this.label104.Margin = new System.Windows.Forms.Padding(0);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(60, 13);
            this.label104.TabIndex = 95;
            this.label104.Text = "roll_ki_limit ";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(378, 140);
            this.label105.Margin = new System.Windows.Forms.Padding(0);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(41, 13);
            this.label105.TabIndex = 94;
            this.label105.Text = "roll_kd ";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(378, 165);
            this.label106.Margin = new System.Windows.Forms.Padding(0);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(38, 13);
            this.label106.TabIndex = 93;
            this.label106.Text = "roll_kff";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(378, 115);
            this.label107.Margin = new System.Windows.Forms.Padding(0);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(37, 13);
            this.label107.TabIndex = 92;
            this.label107.Text = "roll_ki ";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(378, 90);
            this.label108.Margin = new System.Windows.Forms.Padding(0);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(41, 13);
            this.label108.TabIndex = 91;
            this.label108.Text = "roll_kp ";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(27, 90);
            this.label50.Margin = new System.Windows.Forms.Padding(0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(62, 13);
            this.label50.TabIndex = 90;
            this.label50.Text = "roll_rate_kp";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(27, 115);
            this.label51.Margin = new System.Windows.Forms.Padding(0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(61, 13);
            this.label51.TabIndex = 89;
            this.label51.Text = "roll_rate_ki ";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(27, 140);
            this.label71.Margin = new System.Windows.Forms.Padding(0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(65, 13);
            this.label71.TabIndex = 88;
            this.label71.Text = "roll_rate_kd ";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(27, 165);
            this.label72.Margin = new System.Windows.Forms.Padding(0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(65, 13);
            this.label72.TabIndex = 87;
            this.label72.Text = "roll_rate_kff ";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(27, 190);
            this.label73.Margin = new System.Windows.Forms.Padding(0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(99, 13);
            this.label73.TabIndex = 86;
            this.label73.Text = "roll_rate_input_limit ";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(27, 215);
            this.label74.Margin = new System.Windows.Forms.Padding(0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(123, 13);
            this.label74.TabIndex = 85;
            this.label74.Text = "roll_rate_input_rate_limit ";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(27, 240);
            this.label75.Margin = new System.Windows.Forms.Padding(0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(106, 13);
            this.label75.TabIndex = 84;
            this.label75.Text = "roll_rate_output_limit ";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(27, 265);
            this.label76.Margin = new System.Windows.Forms.Padding(0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(84, 13);
            this.label76.TabIndex = 83;
            this.label76.Text = "roll_rate_ki_limit ";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(27, 290);
            this.label77.Margin = new System.Windows.Forms.Padding(0);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(88, 13);
            this.label77.TabIndex = 82;
            this.label77.Text = "roll_rate_kd_limit ";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(27, 315);
            this.label78.Margin = new System.Windows.Forms.Padding(0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(114, 13);
            this.label78.TabIndex = 81;
            this.label78.Text = "roll_rate_kd_filter_freq ";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(27, 340);
            this.label79.Margin = new System.Windows.Forms.Padding(0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(75, 13);
            this.label79.TabIndex = 80;
            this.label79.Text = "pitch_rate_kp ";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(27, 365);
            this.label80.Margin = new System.Windows.Forms.Padding(0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(71, 13);
            this.label80.TabIndex = 79;
            this.label80.Text = "pitch_rate_ki ";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(27, 390);
            this.label81.Margin = new System.Windows.Forms.Padding(0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(75, 13);
            this.label81.TabIndex = 78;
            this.label81.Text = "pitch_rate_kd ";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(27, 415);
            this.label82.Margin = new System.Windows.Forms.Padding(0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(75, 13);
            this.label82.TabIndex = 77;
            this.label82.Text = "pitch_rate_kff ";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(27, 440);
            this.label83.Margin = new System.Windows.Forms.Padding(0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(109, 13);
            this.label83.TabIndex = 76;
            this.label83.Text = "pitch_rate_input_limit ";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(27, 465);
            this.label84.Margin = new System.Windows.Forms.Padding(0);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(133, 13);
            this.label84.TabIndex = 75;
            this.label84.Text = "pitch_rate_input_rate_limit ";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(27, 490);
            this.label85.Margin = new System.Windows.Forms.Padding(0);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(116, 13);
            this.label85.TabIndex = 74;
            this.label85.Text = "pitch_rate_output_limit ";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(27, 565);
            this.label86.Margin = new System.Windows.Forms.Padding(0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(124, 13);
            this.label86.TabIndex = 73;
            this.label86.Text = "pitch_rate_kd_filter_freq ";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(27, 540);
            this.label87.Margin = new System.Windows.Forms.Padding(0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(98, 13);
            this.label87.TabIndex = 72;
            this.label87.Text = "pitch_rate_kd_limit ";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(27, 515);
            this.label88.Margin = new System.Windows.Forms.Padding(0);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(94, 13);
            this.label88.TabIndex = 71;
            this.label88.Text = "pitch_rate_ki_limit ";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.LightGreen;
            this.label52.Location = new System.Drawing.Point(511, 565);
            this.label52.Margin = new System.Windows.Forms.Padding(0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(13, 13);
            this.label52.TabIndex = 70;
            this.label52.Text = "0";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.LightGreen;
            this.label53.Location = new System.Drawing.Point(511, 540);
            this.label53.Margin = new System.Windows.Forms.Padding(0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(13, 13);
            this.label53.TabIndex = 69;
            this.label53.Text = "0";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.LightGreen;
            this.label54.Location = new System.Drawing.Point(511, 515);
            this.label54.Margin = new System.Windows.Forms.Padding(0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(13, 13);
            this.label54.TabIndex = 68;
            this.label54.Text = "0";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.LightGreen;
            this.label55.Location = new System.Drawing.Point(511, 490);
            this.label55.Margin = new System.Windows.Forms.Padding(0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(13, 13);
            this.label55.TabIndex = 67;
            this.label55.Text = "0";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.Color.LightGreen;
            this.label56.Location = new System.Drawing.Point(511, 465);
            this.label56.Margin = new System.Windows.Forms.Padding(0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(13, 13);
            this.label56.TabIndex = 66;
            this.label56.Text = "0";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.LightGreen;
            this.label57.Location = new System.Drawing.Point(511, 441);
            this.label57.Margin = new System.Windows.Forms.Padding(0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(13, 13);
            this.label57.TabIndex = 65;
            this.label57.Text = "0";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.Color.LightGreen;
            this.label58.Location = new System.Drawing.Point(511, 415);
            this.label58.Margin = new System.Windows.Forms.Padding(0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(13, 13);
            this.label58.TabIndex = 64;
            this.label58.Text = "0";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.LightGreen;
            this.label59.Location = new System.Drawing.Point(511, 390);
            this.label59.Margin = new System.Windows.Forms.Padding(0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(13, 13);
            this.label59.TabIndex = 63;
            this.label59.Text = "0";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.LightGreen;
            this.label60.Location = new System.Drawing.Point(511, 365);
            this.label60.Margin = new System.Windows.Forms.Padding(0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(13, 13);
            this.label60.TabIndex = 62;
            this.label60.Text = "0";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.LightGreen;
            this.label61.Location = new System.Drawing.Point(511, 340);
            this.label61.Margin = new System.Windows.Forms.Padding(0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(13, 13);
            this.label61.TabIndex = 61;
            this.label61.Text = "0";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.Color.LightGreen;
            this.label62.Location = new System.Drawing.Point(511, 315);
            this.label62.Margin = new System.Windows.Forms.Padding(0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(13, 13);
            this.label62.TabIndex = 60;
            this.label62.Text = "0";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.BackColor = System.Drawing.Color.LightGreen;
            this.label63.Location = new System.Drawing.Point(511, 290);
            this.label63.Margin = new System.Windows.Forms.Padding(0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(13, 13);
            this.label63.TabIndex = 59;
            this.label63.Text = "0";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.BackColor = System.Drawing.Color.LightGreen;
            this.label64.Location = new System.Drawing.Point(511, 265);
            this.label64.Margin = new System.Windows.Forms.Padding(0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(13, 13);
            this.label64.TabIndex = 58;
            this.label64.Text = "0";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.LightGreen;
            this.label65.Location = new System.Drawing.Point(511, 241);
            this.label65.Margin = new System.Windows.Forms.Padding(0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(13, 13);
            this.label65.TabIndex = 57;
            this.label65.Text = "0";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.Color.LightGreen;
            this.label66.Location = new System.Drawing.Point(511, 215);
            this.label66.Margin = new System.Windows.Forms.Padding(0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(13, 13);
            this.label66.TabIndex = 56;
            this.label66.Text = "0";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.BackColor = System.Drawing.Color.LightGreen;
            this.label67.Location = new System.Drawing.Point(511, 190);
            this.label67.Margin = new System.Windows.Forms.Padding(0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(13, 13);
            this.label67.TabIndex = 55;
            this.label67.Text = "0";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.Color.LightGreen;
            this.label68.Location = new System.Drawing.Point(511, 165);
            this.label68.Margin = new System.Windows.Forms.Padding(0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(13, 13);
            this.label68.TabIndex = 54;
            this.label68.Text = "0";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BackColor = System.Drawing.Color.LightGreen;
            this.label69.Location = new System.Drawing.Point(511, 140);
            this.label69.Margin = new System.Windows.Forms.Padding(0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(13, 13);
            this.label69.TabIndex = 53;
            this.label69.Text = "0";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.Color.LightGreen;
            this.label70.Location = new System.Drawing.Point(511, 115);
            this.label70.Margin = new System.Windows.Forms.Padding(0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(13, 13);
            this.label70.TabIndex = 52;
            this.label70.Text = "0";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.LightGreen;
            this.label49.Location = new System.Drawing.Point(511, 90);
            this.label49.Margin = new System.Windows.Forms.Padding(0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(13, 13);
            this.label49.TabIndex = 51;
            this.label49.Text = "0";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.LightGreen;
            this.label45.Location = new System.Drawing.Point(162, 490);
            this.label45.Margin = new System.Windows.Forms.Padding(0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(13, 13);
            this.label45.TabIndex = 50;
            this.label45.Text = "0";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.LightGreen;
            this.label46.Location = new System.Drawing.Point(162, 515);
            this.label46.Margin = new System.Windows.Forms.Padding(0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(13, 13);
            this.label46.TabIndex = 49;
            this.label46.Text = "0";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.LightGreen;
            this.label47.Location = new System.Drawing.Point(162, 540);
            this.label47.Margin = new System.Windows.Forms.Padding(0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(13, 13);
            this.label47.TabIndex = 48;
            this.label47.Text = "0";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.LightGreen;
            this.label48.Location = new System.Drawing.Point(162, 565);
            this.label48.Margin = new System.Windows.Forms.Padding(0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(13, 13);
            this.label48.TabIndex = 47;
            this.label48.Text = "0";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.LightGreen;
            this.label41.Location = new System.Drawing.Point(162, 390);
            this.label41.Margin = new System.Windows.Forms.Padding(0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(13, 13);
            this.label41.TabIndex = 46;
            this.label41.Text = "0";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.LightGreen;
            this.label42.Location = new System.Drawing.Point(162, 415);
            this.label42.Margin = new System.Windows.Forms.Padding(0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(13, 13);
            this.label42.TabIndex = 45;
            this.label42.Text = "0";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.LightGreen;
            this.label43.Location = new System.Drawing.Point(162, 441);
            this.label43.Margin = new System.Windows.Forms.Padding(0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(13, 13);
            this.label43.TabIndex = 44;
            this.label43.Text = "0";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.LightGreen;
            this.label44.Location = new System.Drawing.Point(162, 465);
            this.label44.Margin = new System.Windows.Forms.Padding(0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(13, 13);
            this.label44.TabIndex = 43;
            this.label44.Text = "0";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.LightGreen;
            this.label37.Location = new System.Drawing.Point(162, 290);
            this.label37.Margin = new System.Windows.Forms.Padding(0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(13, 13);
            this.label37.TabIndex = 42;
            this.label37.Text = "0";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.LightGreen;
            this.label38.Location = new System.Drawing.Point(162, 315);
            this.label38.Margin = new System.Windows.Forms.Padding(0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(13, 13);
            this.label38.TabIndex = 41;
            this.label38.Text = "0";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.LightGreen;
            this.label39.Location = new System.Drawing.Point(162, 340);
            this.label39.Margin = new System.Windows.Forms.Padding(0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(13, 13);
            this.label39.TabIndex = 40;
            this.label39.Text = "0";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.LightGreen;
            this.label40.Location = new System.Drawing.Point(162, 365);
            this.label40.Margin = new System.Windows.Forms.Padding(0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(13, 13);
            this.label40.TabIndex = 39;
            this.label40.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.LightGreen;
            this.label33.Location = new System.Drawing.Point(162, 190);
            this.label33.Margin = new System.Windows.Forms.Padding(0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(13, 13);
            this.label33.TabIndex = 38;
            this.label33.Text = "0";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.LightGreen;
            this.label34.Location = new System.Drawing.Point(162, 215);
            this.label34.Margin = new System.Windows.Forms.Padding(0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(13, 13);
            this.label34.TabIndex = 37;
            this.label34.Text = "0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.LightGreen;
            this.label35.Location = new System.Drawing.Point(162, 241);
            this.label35.Margin = new System.Windows.Forms.Padding(0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(13, 13);
            this.label35.TabIndex = 36;
            this.label35.Text = "0";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.LightGreen;
            this.label36.Location = new System.Drawing.Point(162, 265);
            this.label36.Margin = new System.Windows.Forms.Padding(0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(13, 13);
            this.label36.TabIndex = 35;
            this.label36.Text = "0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.LightGreen;
            this.label31.Location = new System.Drawing.Point(162, 140);
            this.label31.Margin = new System.Windows.Forms.Padding(0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(13, 13);
            this.label31.TabIndex = 34;
            this.label31.Text = "0";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.LightGreen;
            this.label32.Location = new System.Drawing.Point(162, 165);
            this.label32.Margin = new System.Windows.Forms.Padding(0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(13, 13);
            this.label32.TabIndex = 33;
            this.label32.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.LightGreen;
            this.label30.Location = new System.Drawing.Point(162, 115);
            this.label30.Margin = new System.Windows.Forms.Padding(0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(13, 13);
            this.label30.TabIndex = 32;
            this.label30.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.LightGreen;
            this.label29.Location = new System.Drawing.Point(162, 90);
            this.label29.Margin = new System.Windows.Forms.Padding(0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(13, 13);
            this.label29.TabIndex = 31;
            this.label29.Text = "0";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button19);
            this.tabPage5.Controls.Add(this.button20);
            this.tabPage5.Controls.Add(this.textBox87);
            this.tabPage5.Controls.Add(this.textBox88);
            this.tabPage5.Controls.Add(this.textBox107);
            this.tabPage5.Controls.Add(this.textBox108);
            this.tabPage5.Controls.Add(this.textBox109);
            this.tabPage5.Controls.Add(this.textBox110);
            this.tabPage5.Controls.Add(this.textBox111);
            this.tabPage5.Controls.Add(this.textBox112);
            this.tabPage5.Controls.Add(this.textBox113);
            this.tabPage5.Controls.Add(this.textBox114);
            this.tabPage5.Controls.Add(this.textBox115);
            this.tabPage5.Controls.Add(this.textBox116);
            this.tabPage5.Controls.Add(this.textBox117);
            this.tabPage5.Controls.Add(this.textBox118);
            this.tabPage5.Controls.Add(this.textBox119);
            this.tabPage5.Controls.Add(this.textBox120);
            this.tabPage5.Controls.Add(this.textBox121);
            this.tabPage5.Controls.Add(this.textBox122);
            this.tabPage5.Controls.Add(this.textBox123);
            this.tabPage5.Controls.Add(this.textBox124);
            this.tabPage5.Controls.Add(this.label142);
            this.tabPage5.Controls.Add(this.label143);
            this.tabPage5.Controls.Add(this.label162);
            this.tabPage5.Controls.Add(this.label163);
            this.tabPage5.Controls.Add(this.label164);
            this.tabPage5.Controls.Add(this.label165);
            this.tabPage5.Controls.Add(this.label166);
            this.tabPage5.Controls.Add(this.label167);
            this.tabPage5.Controls.Add(this.label168);
            this.tabPage5.Controls.Add(this.label169);
            this.tabPage5.Controls.Add(this.label170);
            this.tabPage5.Controls.Add(this.label171);
            this.tabPage5.Controls.Add(this.label172);
            this.tabPage5.Controls.Add(this.label173);
            this.tabPage5.Controls.Add(this.label174);
            this.tabPage5.Controls.Add(this.label175);
            this.tabPage5.Controls.Add(this.label176);
            this.tabPage5.Controls.Add(this.label177);
            this.tabPage5.Controls.Add(this.label178);
            this.tabPage5.Controls.Add(this.label179);
            this.tabPage5.Controls.Add(this.label180);
            this.tabPage5.Controls.Add(this.label181);
            this.tabPage5.Controls.Add(this.label182);
            this.tabPage5.Controls.Add(this.label183);
            this.tabPage5.Controls.Add(this.label184);
            this.tabPage5.Controls.Add(this.label185);
            this.tabPage5.Controls.Add(this.label186);
            this.tabPage5.Controls.Add(this.label187);
            this.tabPage5.Controls.Add(this.label188);
            this.tabPage5.Controls.Add(this.label189);
            this.tabPage5.Controls.Add(this.label190);
            this.tabPage5.Controls.Add(this.label191);
            this.tabPage5.Controls.Add(this.label192);
            this.tabPage5.Controls.Add(this.label193);
            this.tabPage5.Controls.Add(this.label194);
            this.tabPage5.Controls.Add(this.label195);
            this.tabPage5.Controls.Add(this.label196);
            this.tabPage5.Controls.Add(this.label197);
            this.tabPage5.Controls.Add(this.label198);
            this.tabPage5.Controls.Add(this.label199);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1140, 751);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "EXPERIMENTAL";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(509, 97);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(146, 47);
            this.button19.TabIndex = 192;
            this.button19.Text = "REQUEST DATA";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(509, 177);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(146, 23);
            this.button20.TabIndex = 191;
            this.button20.Text = "CHANGE DATA";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // textBox87
            // 
            this.textBox87.Location = new System.Drawing.Point(269, 569);
            this.textBox87.Name = "textBox87";
            this.textBox87.Size = new System.Drawing.Size(100, 20);
            this.textBox87.TabIndex = 190;
            // 
            // textBox88
            // 
            this.textBox88.Location = new System.Drawing.Point(269, 544);
            this.textBox88.Name = "textBox88";
            this.textBox88.Size = new System.Drawing.Size(100, 20);
            this.textBox88.TabIndex = 189;
            // 
            // textBox107
            // 
            this.textBox107.Location = new System.Drawing.Point(269, 519);
            this.textBox107.Name = "textBox107";
            this.textBox107.Size = new System.Drawing.Size(100, 20);
            this.textBox107.TabIndex = 188;
            // 
            // textBox108
            // 
            this.textBox108.Location = new System.Drawing.Point(269, 494);
            this.textBox108.Name = "textBox108";
            this.textBox108.Size = new System.Drawing.Size(100, 20);
            this.textBox108.TabIndex = 187;
            // 
            // textBox109
            // 
            this.textBox109.Location = new System.Drawing.Point(269, 469);
            this.textBox109.Name = "textBox109";
            this.textBox109.Size = new System.Drawing.Size(100, 20);
            this.textBox109.TabIndex = 186;
            // 
            // textBox110
            // 
            this.textBox110.Location = new System.Drawing.Point(269, 444);
            this.textBox110.Name = "textBox110";
            this.textBox110.Size = new System.Drawing.Size(100, 20);
            this.textBox110.TabIndex = 185;
            // 
            // textBox111
            // 
            this.textBox111.Location = new System.Drawing.Point(269, 419);
            this.textBox111.Name = "textBox111";
            this.textBox111.Size = new System.Drawing.Size(100, 20);
            this.textBox111.TabIndex = 184;
            // 
            // textBox112
            // 
            this.textBox112.Location = new System.Drawing.Point(269, 394);
            this.textBox112.Name = "textBox112";
            this.textBox112.Size = new System.Drawing.Size(100, 20);
            this.textBox112.TabIndex = 183;
            // 
            // textBox113
            // 
            this.textBox113.Location = new System.Drawing.Point(269, 368);
            this.textBox113.Name = "textBox113";
            this.textBox113.Size = new System.Drawing.Size(100, 20);
            this.textBox113.TabIndex = 182;
            // 
            // textBox114
            // 
            this.textBox114.Location = new System.Drawing.Point(269, 344);
            this.textBox114.Name = "textBox114";
            this.textBox114.Size = new System.Drawing.Size(100, 20);
            this.textBox114.TabIndex = 181;
            // 
            // textBox115
            // 
            this.textBox115.Location = new System.Drawing.Point(269, 319);
            this.textBox115.Name = "textBox115";
            this.textBox115.Size = new System.Drawing.Size(100, 20);
            this.textBox115.TabIndex = 180;
            // 
            // textBox116
            // 
            this.textBox116.Location = new System.Drawing.Point(269, 294);
            this.textBox116.Name = "textBox116";
            this.textBox116.Size = new System.Drawing.Size(100, 20);
            this.textBox116.TabIndex = 179;
            // 
            // textBox117
            // 
            this.textBox117.Location = new System.Drawing.Point(269, 269);
            this.textBox117.Name = "textBox117";
            this.textBox117.Size = new System.Drawing.Size(100, 20);
            this.textBox117.TabIndex = 178;
            // 
            // textBox118
            // 
            this.textBox118.Location = new System.Drawing.Point(269, 244);
            this.textBox118.Name = "textBox118";
            this.textBox118.Size = new System.Drawing.Size(100, 20);
            this.textBox118.TabIndex = 177;
            // 
            // textBox119
            // 
            this.textBox119.Location = new System.Drawing.Point(269, 219);
            this.textBox119.Name = "textBox119";
            this.textBox119.Size = new System.Drawing.Size(100, 20);
            this.textBox119.TabIndex = 176;
            // 
            // textBox120
            // 
            this.textBox120.Location = new System.Drawing.Point(269, 194);
            this.textBox120.Name = "textBox120";
            this.textBox120.Size = new System.Drawing.Size(100, 20);
            this.textBox120.TabIndex = 175;
            // 
            // textBox121
            // 
            this.textBox121.Location = new System.Drawing.Point(269, 169);
            this.textBox121.Name = "textBox121";
            this.textBox121.Size = new System.Drawing.Size(100, 20);
            this.textBox121.TabIndex = 174;
            // 
            // textBox122
            // 
            this.textBox122.Location = new System.Drawing.Point(269, 144);
            this.textBox122.Name = "textBox122";
            this.textBox122.Size = new System.Drawing.Size(100, 20);
            this.textBox122.TabIndex = 173;
            // 
            // textBox123
            // 
            this.textBox123.Location = new System.Drawing.Point(269, 119);
            this.textBox123.Name = "textBox123";
            this.textBox123.Size = new System.Drawing.Size(100, 20);
            this.textBox123.TabIndex = 172;
            // 
            // textBox124
            // 
            this.textBox124.Location = new System.Drawing.Point(269, 94);
            this.textBox124.Name = "textBox124";
            this.textBox124.Size = new System.Drawing.Size(100, 20);
            this.textBox124.TabIndex = 171;
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.Location = new System.Drawing.Point(90, 97);
            this.label142.Margin = new System.Windows.Forms.Padding(0);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(57, 13);
            this.label142.TabIndex = 170;
            this.label142.Text = "test_1_f32";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.Location = new System.Drawing.Point(90, 122);
            this.label143.Margin = new System.Windows.Forms.Padding(0);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(57, 13);
            this.label143.TabIndex = 169;
            this.label143.Text = "test_2_f32";
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Location = new System.Drawing.Point(90, 147);
            this.label162.Margin = new System.Windows.Forms.Padding(0);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(57, 13);
            this.label162.TabIndex = 168;
            this.label162.Text = "test_3_f32";
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Location = new System.Drawing.Point(90, 172);
            this.label163.Margin = new System.Windows.Forms.Padding(0);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(57, 13);
            this.label163.TabIndex = 167;
            this.label163.Text = "test_4_f32";
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Location = new System.Drawing.Point(90, 197);
            this.label164.Margin = new System.Windows.Forms.Padding(0);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(57, 13);
            this.label164.TabIndex = 166;
            this.label164.Text = "test_5_f32";
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.Location = new System.Drawing.Point(90, 222);
            this.label165.Margin = new System.Windows.Forms.Padding(0);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(57, 13);
            this.label165.TabIndex = 165;
            this.label165.Text = "test_6_f32";
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.Location = new System.Drawing.Point(90, 247);
            this.label166.Margin = new System.Windows.Forms.Padding(0);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(57, 13);
            this.label166.TabIndex = 164;
            this.label166.Text = "test_7_f32";
            // 
            // label167
            // 
            this.label167.AutoSize = true;
            this.label167.Location = new System.Drawing.Point(90, 272);
            this.label167.Margin = new System.Windows.Forms.Padding(0);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(57, 13);
            this.label167.TabIndex = 163;
            this.label167.Text = "test_8_f32";
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Location = new System.Drawing.Point(90, 297);
            this.label168.Margin = new System.Windows.Forms.Padding(0);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(57, 13);
            this.label168.TabIndex = 162;
            this.label168.Text = "test_9_f32";
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.Location = new System.Drawing.Point(90, 322);
            this.label169.Margin = new System.Windows.Forms.Padding(0);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(63, 13);
            this.label169.TabIndex = 161;
            this.label169.Text = "test_10_f32";
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Location = new System.Drawing.Point(90, 347);
            this.label170.Margin = new System.Windows.Forms.Padding(0);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(65, 13);
            this.label170.TabIndex = 160;
            this.label170.Text = "test_11_s32";
            // 
            // label171
            // 
            this.label171.AutoSize = true;
            this.label171.Location = new System.Drawing.Point(90, 372);
            this.label171.Margin = new System.Windows.Forms.Padding(0);
            this.label171.Name = "label171";
            this.label171.Size = new System.Drawing.Size(68, 13);
            this.label171.TabIndex = 159;
            this.label171.Text = "test_12_s32 ";
            // 
            // label172
            // 
            this.label172.AutoSize = true;
            this.label172.Location = new System.Drawing.Point(90, 397);
            this.label172.Margin = new System.Windows.Forms.Padding(0);
            this.label172.Name = "label172";
            this.label172.Size = new System.Drawing.Size(69, 13);
            this.label172.TabIndex = 158;
            this.label172.Text = "test_13_u32 ";
            // 
            // label173
            // 
            this.label173.AutoSize = true;
            this.label173.Location = new System.Drawing.Point(90, 422);
            this.label173.Margin = new System.Windows.Forms.Padding(0);
            this.label173.Name = "label173";
            this.label173.Size = new System.Drawing.Size(69, 13);
            this.label173.TabIndex = 157;
            this.label173.Text = "test_14_u32 ";
            // 
            // label174
            // 
            this.label174.AutoSize = true;
            this.label174.Location = new System.Drawing.Point(90, 447);
            this.label174.Margin = new System.Windows.Forms.Padding(0);
            this.label174.Name = "label174";
            this.label174.Size = new System.Drawing.Size(68, 13);
            this.label174.TabIndex = 156;
            this.label174.Text = "test_15_s16 ";
            // 
            // label175
            // 
            this.label175.AutoSize = true;
            this.label175.Location = new System.Drawing.Point(90, 472);
            this.label175.Margin = new System.Windows.Forms.Padding(0);
            this.label175.Name = "label175";
            this.label175.Size = new System.Drawing.Size(68, 13);
            this.label175.TabIndex = 155;
            this.label175.Text = "test_16_s16 ";
            // 
            // label176
            // 
            this.label176.AutoSize = true;
            this.label176.Location = new System.Drawing.Point(90, 497);
            this.label176.Margin = new System.Windows.Forms.Padding(0);
            this.label176.Name = "label176";
            this.label176.Size = new System.Drawing.Size(69, 13);
            this.label176.TabIndex = 154;
            this.label176.Text = "test_17_u16 ";
            // 
            // label177
            // 
            this.label177.AutoSize = true;
            this.label177.Location = new System.Drawing.Point(90, 572);
            this.label177.Margin = new System.Windows.Forms.Padding(0);
            this.label177.Name = "label177";
            this.label177.Size = new System.Drawing.Size(63, 13);
            this.label177.TabIndex = 153;
            this.label177.Text = "test_20_u8 ";
            // 
            // label178
            // 
            this.label178.AutoSize = true;
            this.label178.Location = new System.Drawing.Point(90, 547);
            this.label178.Margin = new System.Windows.Forms.Padding(0);
            this.label178.Name = "label178";
            this.label178.Size = new System.Drawing.Size(62, 13);
            this.label178.TabIndex = 152;
            this.label178.Text = "test_19_s8 ";
            // 
            // label179
            // 
            this.label179.AutoSize = true;
            this.label179.Location = new System.Drawing.Point(90, 522);
            this.label179.Margin = new System.Windows.Forms.Padding(0);
            this.label179.Name = "label179";
            this.label179.Size = new System.Drawing.Size(69, 13);
            this.label179.TabIndex = 151;
            this.label179.Text = "test_18_u16 ";
            // 
            // label180
            // 
            this.label180.AutoSize = true;
            this.label180.BackColor = System.Drawing.Color.LightGreen;
            this.label180.Location = new System.Drawing.Point(225, 497);
            this.label180.Margin = new System.Windows.Forms.Padding(0);
            this.label180.Name = "label180";
            this.label180.Size = new System.Drawing.Size(13, 13);
            this.label180.TabIndex = 150;
            this.label180.Text = "0";
            // 
            // label181
            // 
            this.label181.AutoSize = true;
            this.label181.BackColor = System.Drawing.Color.LightGreen;
            this.label181.Location = new System.Drawing.Point(225, 522);
            this.label181.Margin = new System.Windows.Forms.Padding(0);
            this.label181.Name = "label181";
            this.label181.Size = new System.Drawing.Size(13, 13);
            this.label181.TabIndex = 149;
            this.label181.Text = "0";
            // 
            // label182
            // 
            this.label182.AutoSize = true;
            this.label182.BackColor = System.Drawing.Color.LightGreen;
            this.label182.Location = new System.Drawing.Point(225, 547);
            this.label182.Margin = new System.Windows.Forms.Padding(0);
            this.label182.Name = "label182";
            this.label182.Size = new System.Drawing.Size(13, 13);
            this.label182.TabIndex = 148;
            this.label182.Text = "0";
            // 
            // label183
            // 
            this.label183.AutoSize = true;
            this.label183.BackColor = System.Drawing.Color.LightGreen;
            this.label183.Location = new System.Drawing.Point(225, 572);
            this.label183.Margin = new System.Windows.Forms.Padding(0);
            this.label183.Name = "label183";
            this.label183.Size = new System.Drawing.Size(13, 13);
            this.label183.TabIndex = 147;
            this.label183.Text = "0";
            // 
            // label184
            // 
            this.label184.AutoSize = true;
            this.label184.BackColor = System.Drawing.Color.LightGreen;
            this.label184.Location = new System.Drawing.Point(225, 397);
            this.label184.Margin = new System.Windows.Forms.Padding(0);
            this.label184.Name = "label184";
            this.label184.Size = new System.Drawing.Size(13, 13);
            this.label184.TabIndex = 146;
            this.label184.Text = "0";
            // 
            // label185
            // 
            this.label185.AutoSize = true;
            this.label185.BackColor = System.Drawing.Color.LightGreen;
            this.label185.Location = new System.Drawing.Point(225, 422);
            this.label185.Margin = new System.Windows.Forms.Padding(0);
            this.label185.Name = "label185";
            this.label185.Size = new System.Drawing.Size(13, 13);
            this.label185.TabIndex = 145;
            this.label185.Text = "0";
            // 
            // label186
            // 
            this.label186.AutoSize = true;
            this.label186.BackColor = System.Drawing.Color.LightGreen;
            this.label186.Location = new System.Drawing.Point(225, 448);
            this.label186.Margin = new System.Windows.Forms.Padding(0);
            this.label186.Name = "label186";
            this.label186.Size = new System.Drawing.Size(13, 13);
            this.label186.TabIndex = 144;
            this.label186.Text = "0";
            // 
            // label187
            // 
            this.label187.AutoSize = true;
            this.label187.BackColor = System.Drawing.Color.LightGreen;
            this.label187.Location = new System.Drawing.Point(225, 472);
            this.label187.Margin = new System.Windows.Forms.Padding(0);
            this.label187.Name = "label187";
            this.label187.Size = new System.Drawing.Size(13, 13);
            this.label187.TabIndex = 143;
            this.label187.Text = "0";
            // 
            // label188
            // 
            this.label188.AutoSize = true;
            this.label188.BackColor = System.Drawing.Color.LightGreen;
            this.label188.Location = new System.Drawing.Point(225, 297);
            this.label188.Margin = new System.Windows.Forms.Padding(0);
            this.label188.Name = "label188";
            this.label188.Size = new System.Drawing.Size(13, 13);
            this.label188.TabIndex = 142;
            this.label188.Text = "0";
            // 
            // label189
            // 
            this.label189.AutoSize = true;
            this.label189.BackColor = System.Drawing.Color.LightGreen;
            this.label189.Location = new System.Drawing.Point(225, 322);
            this.label189.Margin = new System.Windows.Forms.Padding(0);
            this.label189.Name = "label189";
            this.label189.Size = new System.Drawing.Size(13, 13);
            this.label189.TabIndex = 141;
            this.label189.Text = "0";
            // 
            // label190
            // 
            this.label190.AutoSize = true;
            this.label190.BackColor = System.Drawing.Color.LightGreen;
            this.label190.Location = new System.Drawing.Point(225, 347);
            this.label190.Margin = new System.Windows.Forms.Padding(0);
            this.label190.Name = "label190";
            this.label190.Size = new System.Drawing.Size(13, 13);
            this.label190.TabIndex = 140;
            this.label190.Text = "0";
            // 
            // label191
            // 
            this.label191.AutoSize = true;
            this.label191.BackColor = System.Drawing.Color.LightGreen;
            this.label191.Location = new System.Drawing.Point(225, 372);
            this.label191.Margin = new System.Windows.Forms.Padding(0);
            this.label191.Name = "label191";
            this.label191.Size = new System.Drawing.Size(13, 13);
            this.label191.TabIndex = 139;
            this.label191.Text = "0";
            // 
            // label192
            // 
            this.label192.AutoSize = true;
            this.label192.BackColor = System.Drawing.Color.LightGreen;
            this.label192.Location = new System.Drawing.Point(225, 197);
            this.label192.Margin = new System.Windows.Forms.Padding(0);
            this.label192.Name = "label192";
            this.label192.Size = new System.Drawing.Size(13, 13);
            this.label192.TabIndex = 138;
            this.label192.Text = "0";
            // 
            // label193
            // 
            this.label193.AutoSize = true;
            this.label193.BackColor = System.Drawing.Color.LightGreen;
            this.label193.Location = new System.Drawing.Point(225, 222);
            this.label193.Margin = new System.Windows.Forms.Padding(0);
            this.label193.Name = "label193";
            this.label193.Size = new System.Drawing.Size(13, 13);
            this.label193.TabIndex = 137;
            this.label193.Text = "0";
            // 
            // label194
            // 
            this.label194.AutoSize = true;
            this.label194.BackColor = System.Drawing.Color.LightGreen;
            this.label194.Location = new System.Drawing.Point(225, 248);
            this.label194.Margin = new System.Windows.Forms.Padding(0);
            this.label194.Name = "label194";
            this.label194.Size = new System.Drawing.Size(13, 13);
            this.label194.TabIndex = 136;
            this.label194.Text = "0";
            // 
            // label195
            // 
            this.label195.AutoSize = true;
            this.label195.BackColor = System.Drawing.Color.LightGreen;
            this.label195.Location = new System.Drawing.Point(225, 272);
            this.label195.Margin = new System.Windows.Forms.Padding(0);
            this.label195.Name = "label195";
            this.label195.Size = new System.Drawing.Size(13, 13);
            this.label195.TabIndex = 135;
            this.label195.Text = "0";
            // 
            // label196
            // 
            this.label196.AutoSize = true;
            this.label196.BackColor = System.Drawing.Color.LightGreen;
            this.label196.Location = new System.Drawing.Point(225, 147);
            this.label196.Margin = new System.Windows.Forms.Padding(0);
            this.label196.Name = "label196";
            this.label196.Size = new System.Drawing.Size(13, 13);
            this.label196.TabIndex = 134;
            this.label196.Text = "0";
            // 
            // label197
            // 
            this.label197.AutoSize = true;
            this.label197.BackColor = System.Drawing.Color.LightGreen;
            this.label197.Location = new System.Drawing.Point(225, 172);
            this.label197.Margin = new System.Windows.Forms.Padding(0);
            this.label197.Name = "label197";
            this.label197.Size = new System.Drawing.Size(13, 13);
            this.label197.TabIndex = 133;
            this.label197.Text = "0";
            // 
            // label198
            // 
            this.label198.AutoSize = true;
            this.label198.BackColor = System.Drawing.Color.LightGreen;
            this.label198.Location = new System.Drawing.Point(225, 122);
            this.label198.Margin = new System.Windows.Forms.Padding(0);
            this.label198.Name = "label198";
            this.label198.Size = new System.Drawing.Size(13, 13);
            this.label198.TabIndex = 132;
            this.label198.Text = "0";
            // 
            // label199
            // 
            this.label199.AutoSize = true;
            this.label199.BackColor = System.Drawing.Color.LightGreen;
            this.label199.Location = new System.Drawing.Point(225, 97);
            this.label199.Margin = new System.Windows.Forms.Padding(0);
            this.label199.Name = "label199";
            this.label199.Size = new System.Drawing.Size(13, 13);
            this.label199.TabIndex = 131;
            this.label199.Text = "0";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(211, 558);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(87, 60);
            this.button15.TabIndex = 10;
            this.button15.Text = "SEND";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // textBox66
            // 
            this.textBox66.Location = new System.Drawing.Point(12, 556);
            this.textBox66.Multiline = true;
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(190, 62);
            this.textBox66.TabIndex = 8;
            // 
            // textBox65
            // 
            this.textBox65.Location = new System.Drawing.Point(12, 168);
            this.textBox65.Multiline = true;
            this.textBox65.Name = "textBox65";
            this.textBox65.ReadOnly = true;
            this.textBox65.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox65.Size = new System.Drawing.Size(286, 382);
            this.textBox65.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(1216, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 37);
            this.label16.TabIndex = 52;
            this.label16.Text = "A";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(1034, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 37);
            this.label17.TabIndex = 51;
            this.label17.Text = "V";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(155, 145);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "climb_rate_mps";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(155, 119);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 45;
            this.label23.Text = "asl_m";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(155, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "yaw_deg ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "pitch_deg ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "roll_deg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "longitude_e7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "latitude_e7";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label110.Location = new System.Drawing.Point(151, -2);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(93, 39);
            this.label110.TabIndex = 32;
            this.label110.Text = "LINK";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(1474, 779);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(47, 13);
            this.label111.TabIndex = 33;
            this.label111.Text = "label111";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(1474, 805);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(28, 13);
            this.label112.TabIndex = 34;
            this.label112.Text = "Lat: ";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(1474, 818);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(31, 13);
            this.label113.TabIndex = 35;
            this.label113.Text = "Lng: ";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(1474, 792);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(85, 13);
            this.label114.TabIndex = 36;
            this.label114.Text = "Selected LatLng";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 630);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 30);
            this.button3.TabIndex = 37;
            this.button3.Text = "ROUTE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(79, 639);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 55);
            this.button11.TabIndex = 39;
            this.button11.Text = "↑";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(25, 695);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(56, 55);
            this.button12.TabIndex = 40;
            this.button12.Text = "←";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(133, 695);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(56, 55);
            this.button13.TabIndex = 41;
            this.button13.Text = "→";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(79, 750);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(56, 55);
            this.button14.TabIndex = 42;
            this.button14.Text = "↓";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(240, 772);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(53, 33);
            this.button16.TabIndex = 43;
            this.button16.Text = "AUTO";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label119.Location = new System.Drawing.Point(1265, 9);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(63, 37);
            this.label119.TabIndex = 53;
            this.label119.Text = "PC";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label120.Location = new System.Drawing.Point(1320, 9);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(84, 37);
            this.label120.TabIndex = 54;
            this.label120.Text = "%00";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label115.Location = new System.Drawing.Point(605, 9);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(126, 37);
            this.label115.TabIndex = 55;
            this.label115.Text = "MODE:";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label116.Location = new System.Drawing.Point(719, 9);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(196, 37);
            this.label116.TabIndex = 56;
            this.label116.Text = "UNKNOWN";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(234, 666);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 41);
            this.button4.TabIndex = 57;
            this.button4.Text = "CLEAR ROUTE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 833);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.label116);
            this.Controls.Add(this.label115);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.label120);
            this.Controls.Add(this.label119);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.label114);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.label113);
            this.Controls.Add(this.textBox66);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label112);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox65);
            this.Controls.Add(this.label110);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "GROUND CONTROL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtBoxReceived;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.TextBox textBox63;
        private System.Windows.Forms.TextBox textBox62;
        private System.Windows.Forms.TextBox textBox61;
        private System.Windows.Forms.TextBox textBox60;
        private System.Windows.Forms.TextBox textBox59;
        private System.Windows.Forms.TextBox textBox58;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox textBox65;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox textBox66;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.TextBox textBox89;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.TextBox textBox90;
        private System.Windows.Forms.TextBox textBox91;
        private System.Windows.Forms.TextBox textBox92;
        private System.Windows.Forms.TextBox textBox93;
        private System.Windows.Forms.TextBox textBox94;
        private System.Windows.Forms.TextBox textBox95;
        private System.Windows.Forms.TextBox textBox96;
        private System.Windows.Forms.TextBox textBox97;
        private System.Windows.Forms.TextBox textBox98;
        private System.Windows.Forms.TextBox textBox99;
        private System.Windows.Forms.TextBox textBox100;
        private System.Windows.Forms.TextBox textBox101;
        private System.Windows.Forms.TextBox textBox102;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.TextBox textBox103;
        private System.Windows.Forms.TextBox textBox104;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.TextBox textBox105;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.TextBox textBox106;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.TextBox textBox86;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.TextBox textBox85;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.TextBox textBox84;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.TextBox textBox68;
        private System.Windows.Forms.TextBox textBox69;
        private System.Windows.Forms.TextBox textBox70;
        private System.Windows.Forms.TextBox textBox71;
        private System.Windows.Forms.TextBox textBox72;
        private System.Windows.Forms.TextBox textBox73;
        private System.Windows.Forms.TextBox textBox74;
        private System.Windows.Forms.TextBox textBox75;
        private System.Windows.Forms.TextBox textBox76;
        private System.Windows.Forms.TextBox textBox77;
        private System.Windows.Forms.TextBox textBox78;
        private System.Windows.Forms.TextBox textBox79;
        private System.Windows.Forms.TextBox textBox80;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.TextBox textBox81;
        private System.Windows.Forms.TextBox textBox82;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.TextBox textBox83;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.TextBox textBox67;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox87;
        private System.Windows.Forms.TextBox textBox88;
        private System.Windows.Forms.TextBox textBox107;
        private System.Windows.Forms.TextBox textBox108;
        private System.Windows.Forms.TextBox textBox109;
        private System.Windows.Forms.TextBox textBox110;
        private System.Windows.Forms.TextBox textBox111;
        private System.Windows.Forms.TextBox textBox112;
        private System.Windows.Forms.TextBox textBox113;
        private System.Windows.Forms.TextBox textBox114;
        private System.Windows.Forms.TextBox textBox115;
        private System.Windows.Forms.TextBox textBox116;
        private System.Windows.Forms.TextBox textBox117;
        private System.Windows.Forms.TextBox textBox118;
        private System.Windows.Forms.TextBox textBox119;
        private System.Windows.Forms.TextBox textBox120;
        private System.Windows.Forms.TextBox textBox121;
        private System.Windows.Forms.TextBox textBox122;
        private System.Windows.Forms.TextBox textBox123;
        private System.Windows.Forms.TextBox textBox124;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Label label167;
        private System.Windows.Forms.Label label168;
        private System.Windows.Forms.Label label169;
        private System.Windows.Forms.Label label170;
        private System.Windows.Forms.Label label171;
        private System.Windows.Forms.Label label172;
        private System.Windows.Forms.Label label173;
        private System.Windows.Forms.Label label174;
        private System.Windows.Forms.Label label175;
        private System.Windows.Forms.Label label176;
        private System.Windows.Forms.Label label177;
        private System.Windows.Forms.Label label178;
        private System.Windows.Forms.Label label179;
        private System.Windows.Forms.Label label180;
        private System.Windows.Forms.Label label181;
        private System.Windows.Forms.Label label182;
        private System.Windows.Forms.Label label183;
        private System.Windows.Forms.Label label184;
        private System.Windows.Forms.Label label185;
        private System.Windows.Forms.Label label186;
        private System.Windows.Forms.Label label187;
        private System.Windows.Forms.Label label188;
        private System.Windows.Forms.Label label189;
        private System.Windows.Forms.Label label190;
        private System.Windows.Forms.Label label191;
        private System.Windows.Forms.Label label192;
        private System.Windows.Forms.Label label193;
        private System.Windows.Forms.Label label194;
        private System.Windows.Forms.Label label195;
        private System.Windows.Forms.Label label196;
        private System.Windows.Forms.Label label197;
        private System.Windows.Forms.Label label198;
        private System.Windows.Forms.Label label199;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button4;
    }
}

