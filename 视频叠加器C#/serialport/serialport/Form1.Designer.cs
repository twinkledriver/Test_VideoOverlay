namespace serialport
{
    partial class FormTestSerialPort
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestSerialPort));
            this.buttonOpenport = new System.Windows.Forms.Button();
            this.ContentBox = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.comboPortNme = new System.Windows.Forms.ComboBox();
            this.comboBaudrate = new System.Windows.Forms.ComboBox();
            this.groupDataReceived = new System.Windows.Forms.GroupBox();
            this.labelReceiveCount = new System.Windows.Forms.Label();
            this.checkBoxAN = new System.Windows.Forms.CheckBox();
            this.checkBoxRHex = new System.Windows.Forms.CheckBox();
            this.labelPortNME = new System.Windows.Forms.Label();
            this.labelBaudrate = new System.Windows.Forms.Label();
            this.button_TestClean = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkbox_L_ALL = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Check_R_ALL = new System.Windows.Forms.CheckBox();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button35 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupDataReceived.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenport
            // 
            this.buttonOpenport.Location = new System.Drawing.Point(25, 32);
            this.buttonOpenport.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenport.Name = "buttonOpenport";
            this.buttonOpenport.Size = new System.Drawing.Size(85, 31);
            this.buttonOpenport.TabIndex = 0;
            this.buttonOpenport.Text = "打开串口";
            this.buttonOpenport.UseVisualStyleBackColor = true;
            this.buttonOpenport.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // ContentBox
            // 
            this.ContentBox.Location = new System.Drawing.Point(26, 56);
            this.ContentBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContentBox.Multiline = true;
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.ReadOnly = true;
            this.ContentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ContentBox.Size = new System.Drawing.Size(272, 359);
            this.ContentBox.TabIndex = 1;
            this.ContentBox.TextChanged += new System.EventHandler(this.ContentBox_TextChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(153, 32);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(91, 31);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "清空数据";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // comboPortNme
            // 
            this.comboPortNme.FormattingEnabled = true;
            this.comboPortNme.Location = new System.Drawing.Point(102, 2);
            this.comboPortNme.Margin = new System.Windows.Forms.Padding(4);
            this.comboPortNme.Name = "comboPortNme";
            this.comboPortNme.Size = new System.Drawing.Size(103, 24);
            this.comboPortNme.TabIndex = 4;
            this.comboPortNme.Click += new System.EventHandler(this.comboPortNme_Click);
            // 
            // comboBaudrate
            // 
            this.comboBaudrate.AutoCompleteCustomSource.AddRange(new string[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBaudrate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBaudrate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBaudrate.FormatString = "N0";
            this.comboBaudrate.FormattingEnabled = true;
            this.comboBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBaudrate.Location = new System.Drawing.Point(312, 3);
            this.comboBaudrate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBaudrate.Name = "comboBaudrate";
            this.comboBaudrate.Size = new System.Drawing.Size(100, 24);
            this.comboBaudrate.TabIndex = 5;
            this.comboBaudrate.Text = "9600";
            // 
            // groupDataReceived
            // 
            this.groupDataReceived.Controls.Add(this.labelReceiveCount);
            this.groupDataReceived.Controls.Add(this.checkBoxAN);
            this.groupDataReceived.Controls.Add(this.checkBoxRHex);
            this.groupDataReceived.Controls.Add(this.ContentBox);
            this.groupDataReceived.Location = new System.Drawing.Point(14, 71);
            this.groupDataReceived.Margin = new System.Windows.Forms.Padding(4);
            this.groupDataReceived.Name = "groupDataReceived";
            this.groupDataReceived.Padding = new System.Windows.Forms.Padding(4);
            this.groupDataReceived.Size = new System.Drawing.Size(427, 423);
            this.groupDataReceived.TabIndex = 6;
            this.groupDataReceived.TabStop = false;
            this.groupDataReceived.Text = "收到的数据   ";
            // 
            // labelReceiveCount
            // 
            this.labelReceiveCount.AutoSize = true;
            this.labelReceiveCount.Location = new System.Drawing.Point(303, 27);
            this.labelReceiveCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReceiveCount.Name = "labelReceiveCount";
            this.labelReceiveCount.Size = new System.Drawing.Size(96, 16);
            this.labelReceiveCount.TabIndex = 9;
            this.labelReceiveCount.Text = "接收计数：0";
            // 
            // checkBoxAN
            // 
            this.checkBoxAN.AutoSize = true;
            this.checkBoxAN.Checked = true;
            this.checkBoxAN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAN.Location = new System.Drawing.Point(117, 24);
            this.checkBoxAN.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAN.Name = "checkBoxAN";
            this.checkBoxAN.Size = new System.Drawing.Size(91, 20);
            this.checkBoxAN.TabIndex = 4;
            this.checkBoxAN.Text = "自动换行";
            this.checkBoxAN.UseVisualStyleBackColor = true;
            // 
            // checkBoxRHex
            // 
            this.checkBoxRHex.AutoSize = true;
            this.checkBoxRHex.Checked = true;
            this.checkBoxRHex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRHex.Location = new System.Drawing.Point(26, 25);
            this.checkBoxRHex.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRHex.Name = "checkBoxRHex";
            this.checkBoxRHex.Size = new System.Drawing.Size(83, 20);
            this.checkBoxRHex.TabIndex = 3;
            this.checkBoxRHex.Text = "Hex视图";
            this.checkBoxRHex.UseVisualStyleBackColor = true;
            // 
            // labelPortNME
            // 
            this.labelPortNME.AutoSize = true;
            this.labelPortNME.Location = new System.Drawing.Point(22, 4);
            this.labelPortNME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPortNME.Name = "labelPortNME";
            this.labelPortNME.Size = new System.Drawing.Size(72, 16);
            this.labelPortNME.TabIndex = 7;
            this.labelPortNME.Text = "串口名称";
            // 
            // labelBaudrate
            // 
            this.labelBaudrate.AutoSize = true;
            this.labelBaudrate.Location = new System.Drawing.Point(236, 6);
            this.labelBaudrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBaudrate.Name = "labelBaudrate";
            this.labelBaudrate.Size = new System.Drawing.Size(56, 16);
            this.labelBaudrate.TabIndex = 8;
            this.labelBaudrate.Text = "波特率";
            // 
            // button_TestClean
            // 
            this.button_TestClean.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_TestClean.Location = new System.Drawing.Point(299, 35);
            this.button_TestClean.Margin = new System.Windows.Forms.Padding(4);
            this.button_TestClean.Name = "button_TestClean";
            this.button_TestClean.Size = new System.Drawing.Size(83, 31);
            this.button_TestClean.TabIndex = 16;
            this.button_TestClean.Text = "重新检测";
            this.button_TestClean.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 34);
            this.button1.TabIndex = 44;
            this.button1.Text = "7开";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.checkbox_L_ALL);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(448, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 123);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "左屏地图";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "速率";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "500",
            "1000"});
            this.comboBox2.Location = new System.Drawing.Point(173, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(59, 24);
            this.comboBox2.TabIndex = 50;
            this.comboBox2.Text = "100";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // checkbox_L_ALL
            // 
            this.checkbox_L_ALL.AutoSize = true;
            this.checkbox_L_ALL.Location = new System.Drawing.Point(158, 68);
            this.checkbox_L_ALL.Name = "checkbox_L_ALL";
            this.checkbox_L_ALL.Size = new System.Drawing.Size(107, 20);
            this.checkbox_L_ALL.TabIndex = 49;
            this.checkbox_L_ALL.Text = "循环检测左";
            this.checkbox_L_ALL.UseVisualStyleBackColor = true;
            this.checkbox_L_ALL.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(80, 68);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 34);
            this.button5.TabIndex = 48;
            this.button5.Text = "2开";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 34);
            this.button4.TabIndex = 47;
            this.button4.Text = "8开";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 34);
            this.button3.TabIndex = 46;
            this.button3.Text = "关闭";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 34);
            this.button2.TabIndex = 45;
            this.button2.Text = "9开";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(448, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 147);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "左屏das";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(16, 101);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(56, 32);
            this.button12.TabIndex = 6;
            this.button12.Text = "7缩2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(135, 63);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(59, 32);
            this.button11.TabIndex = 5;
            this.button11.Text = "7滑8";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(78, 63);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(51, 32);
            this.button10.TabIndex = 4;
            this.button10.Text = "7开\r\n";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(16, 63);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 32);
            this.button9.TabIndex = 3;
            this.button9.Text = "1开";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(134, 25);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(59, 32);
            this.button8.TabIndex = 2;
            this.button8.Text = "关闭";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(78, 25);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 32);
            this.button7.TabIndex = 1;
            this.button7.Text = "8开";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(16, 25);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 32);
            this.button6.TabIndex = 0;
            this.button6.Text = "2开";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button17);
            this.groupBox3.Controls.Add(this.button16);
            this.groupBox3.Controls.Add(this.button15);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Location = new System.Drawing.Point(448, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 112);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "左屏联动";
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(350, 63);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(141, 32);
            this.button17.TabIndex = 11;
            this.button17.Text = "地图2开 Das关";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(6, 63);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(338, 32);
            this.button16.TabIndex = 10;
            this.button16.Text = "由（9开 Das无显示）返回（地图2开Das7开）";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(275, 25);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(155, 32);
            this.button15.TabIndex = 9;
            this.button15.Text = "地图9开Das无显示";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(141, 25);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(128, 32);
            this.button14.TabIndex = 8;
            this.button14.Text = "地图2开 Das7开";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(6, 25);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(129, 32);
            this.button13.TabIndex = 7;
            this.button13.Text = "地图7开 Das2开";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Check_R_ALL);
            this.groupBox4.Controls.Add(this.button22);
            this.groupBox4.Controls.Add(this.button21);
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Controls.Add(this.button19);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Location = new System.Drawing.Point(727, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 123);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "右屏地图";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "500",
            "1000"});
            this.comboBox1.Location = new System.Drawing.Point(159, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(59, 24);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.Text = "100";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "速率";
            // 
            // Check_R_ALL
            // 
            this.Check_R_ALL.AutoSize = true;
            this.Check_R_ALL.Location = new System.Drawing.Point(130, 68);
            this.Check_R_ALL.Name = "Check_R_ALL";
            this.Check_R_ALL.Size = new System.Drawing.Size(107, 20);
            this.Check_R_ALL.TabIndex = 53;
            this.Check_R_ALL.Text = "循环检测右";
            this.Check_R_ALL.UseVisualStyleBackColor = true;
            this.Check_R_ALL.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(68, 68);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(56, 34);
            this.button22.TabIndex = 52;
            this.button22.Text = "2开";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(6, 68);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(56, 34);
            this.button21.TabIndex = 50;
            this.button21.Text = "8开";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(130, 28);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(56, 34);
            this.button20.TabIndex = 51;
            this.button20.Text = "关闭";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(68, 28);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(56, 34);
            this.button19.TabIndex = 50;
            this.button19.Text = "9开";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(6, 28);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(56, 34);
            this.button18.TabIndex = 49;
            this.button18.Text = "7开";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button29);
            this.groupBox5.Controls.Add(this.button28);
            this.groupBox5.Controls.Add(this.button27);
            this.groupBox5.Controls.Add(this.button26);
            this.groupBox5.Controls.Add(this.button25);
            this.groupBox5.Controls.Add(this.button24);
            this.groupBox5.Controls.Add(this.button23);
            this.groupBox5.Location = new System.Drawing.Point(727, 141);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(247, 146);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "右屏das";
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(6, 101);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(56, 32);
            this.button29.TabIndex = 13;
            this.button29.Text = "7缩2";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(130, 63);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(56, 32);
            this.button28.TabIndex = 12;
            this.button28.Text = "7滑8";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(68, 63);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(56, 32);
            this.button27.TabIndex = 11;
            this.button27.Text = "7开";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(6, 63);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(56, 32);
            this.button26.TabIndex = 10;
            this.button26.Text = "1开";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(130, 25);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(56, 32);
            this.button25.TabIndex = 9;
            this.button25.Text = "关闭";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(68, 24);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(56, 32);
            this.button24.TabIndex = 8;
            this.button24.Text = "8开";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(6, 25);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(56, 32);
            this.button23.TabIndex = 7;
            this.button23.Text = "2开";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button35);
            this.groupBox6.Controls.Add(this.button34);
            this.groupBox6.Controls.Add(this.button33);
            this.groupBox6.Controls.Add(this.button32);
            this.groupBox6.Controls.Add(this.button31);
            this.groupBox6.Controls.Add(this.button30);
            this.groupBox6.Location = new System.Drawing.Point(448, 411);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(503, 94);
            this.groupBox6.TabIndex = 50;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "右屏联动";
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(441, 18);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(56, 32);
            this.button35.TabIndex = 14;
            this.button35.Text = "闪烁";
            this.button35.UseVisualStyleBackColor = true;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(350, 56);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(141, 32);
            this.button34.TabIndex = 12;
            this.button34.Text = "地图2开 Das关";
            this.button34.UseVisualStyleBackColor = true;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(6, 57);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(338, 32);
            this.button33.TabIndex = 12;
            this.button33.Text = "由（9开 Das无显示）返回（地图2开Das7开）";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(275, 20);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(155, 32);
            this.button32.TabIndex = 12;
            this.button32.Text = "地图9开Das无显示";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(141, 19);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(128, 32);
            this.button31.TabIndex = 12;
            this.button31.Text = "地图2开 Das7开";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(6, 20);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(129, 32);
            this.button30.TabIndex = 12;
            this.button30.Text = "地图7开 Das2开";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // FormTestSerialPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 517);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_TestClean);
            this.Controls.Add(this.labelBaudrate);
            this.Controls.Add(this.labelPortNME);
            this.Controls.Add(this.comboBaudrate);
            this.Controls.Add(this.comboPortNme);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonOpenport);
            this.Controls.Add(this.groupDataReceived);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTestSerialPort";
            this.Text = "视屏叠加器测试 V1.0";
            this.Load += new System.EventHandler(this.FormTestSerialPort_Load);
            this.groupDataReceived.ResumeLayout(false);
            this.groupDataReceived.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenport;
        private System.Windows.Forms.TextBox ContentBox;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ComboBox comboPortNme;
        private System.Windows.Forms.ComboBox comboBaudrate;
        private System.Windows.Forms.GroupBox groupDataReceived;
        private System.Windows.Forms.Label labelPortNME;
        private System.Windows.Forms.Label labelReceiveCount;
        private System.Windows.Forms.CheckBox checkBoxAN;
        private System.Windows.Forms.CheckBox checkBoxRHex;
        private System.Windows.Forms.Label labelBaudrate;
        private System.Windows.Forms.Button button_TestClean;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox checkbox_L_ALL;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Check_R_ALL;
        private System.Windows.Forms.Timer timer3;
    }
}

