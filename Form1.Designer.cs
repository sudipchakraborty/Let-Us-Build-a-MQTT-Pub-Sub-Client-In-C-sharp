namespace Pub_Sub_Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_publish = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_show_graph = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_sub_topic_count = new System.Windows.Forms.TextBox();
            this.btn_clear_disp_sub = new System.Windows.Forms.Button();
            this.lst_topic_sub = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_topic_sub = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_clear_disp_pub = new System.Windows.Forms.Button();
            this.txt_pub_topic_count = new System.Windows.Forms.TextBox();
            this.btn_pub_timer_stp = new System.Windows.Forms.Button();
            this.btn_pub_timer_st = new System.Windows.Forms.Button();
            this.chk_pub_time = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_interval_pub = new System.Windows.Forms.TextBox();
            this.lst_topic_pub = new System.Windows.Forms.ListBox();
            this.chk_pub_auto = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pub_value = new System.Windows.Forms.TextBox();
            this.txt_topic_pub = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_server_address = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_status = new System.Windows.Forms.PictureBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_client_ID = new System.Windows.Forms.TextBox();
            this.txt_server_port = new System.Windows.Forms.TextBox();
            this.timer_sub = new System.Windows.Forms.Timer(this.components);
            this.timer_pub = new System.Windows.Forms.Timer(this.components);
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_running_time = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_display_time = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_get_srv_resp_time = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_publish
            // 
            this.btn_publish.ForeColor = System.Drawing.Color.Black;
            this.btn_publish.Location = new System.Drawing.Point(363, 42);
            this.btn_publish.Name = "btn_publish";
            this.btn_publish.Size = new System.Drawing.Size(77, 19);
            this.btn_publish.TabIndex = 1;
            this.btn_publish.Text = "PUBLISH";
            this.btn_publish.UseVisualStyleBackColor = true;
            this.btn_publish.Click += new System.EventHandler(this.btn_publish_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_show_graph);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_sub_topic_count);
            this.groupBox2.Controls.Add(this.btn_clear_disp_sub);
            this.groupBox2.Controls.Add(this.lst_topic_sub);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_topic_sub);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(469, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 385);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SUBSCRIBER";
            // 
            // btn_show_graph
            // 
            this.btn_show_graph.ForeColor = System.Drawing.Color.Black;
            this.btn_show_graph.Location = new System.Drawing.Point(120, 338);
            this.btn_show_graph.Name = "btn_show_graph";
            this.btn_show_graph.Size = new System.Drawing.Size(156, 35);
            this.btn_show_graph.TabIndex = 11;
            this.btn_show_graph.Text = "Show Graph";
            this.btn_show_graph.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(286, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(283, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "COUNT=";
            // 
            // txt_sub_topic_count
            // 
            this.txt_sub_topic_count.Location = new System.Drawing.Point(340, 15);
            this.txt_sub_topic_count.Name = "txt_sub_topic_count";
            this.txt_sub_topic_count.Size = new System.Drawing.Size(100, 20);
            this.txt_sub_topic_count.TabIndex = 7;
            // 
            // btn_clear_disp_sub
            // 
            this.btn_clear_disp_sub.ForeColor = System.Drawing.Color.Black;
            this.btn_clear_disp_sub.Location = new System.Drawing.Point(11, 337);
            this.btn_clear_disp_sub.Name = "btn_clear_disp_sub";
            this.btn_clear_disp_sub.Size = new System.Drawing.Size(94, 36);
            this.btn_clear_disp_sub.TabIndex = 6;
            this.btn_clear_disp_sub.Text = "Clear";
            this.btn_clear_disp_sub.UseVisualStyleBackColor = true;
            this.btn_clear_disp_sub.Click += new System.EventHandler(this.btn_clear_disp_sub_Click);
            // 
            // lst_topic_sub
            // 
            this.lst_topic_sub.FormattingEnabled = true;
            this.lst_topic_sub.Location = new System.Drawing.Point(11, 67);
            this.lst_topic_sub.Name = "lst_topic_sub";
            this.lst_topic_sub.Size = new System.Drawing.Size(429, 264);
            this.lst_topic_sub.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "TOPIC";
            // 
            // txt_topic_sub
            // 
            this.txt_topic_sub.Location = new System.Drawing.Point(63, 41);
            this.txt_topic_sub.Name = "txt_topic_sub";
            this.txt_topic_sub.Size = new System.Drawing.Size(377, 20);
            this.txt_topic_sub.TabIndex = 2;
            this.txt_topic_sub.Text = "Home/door/Reception";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btn_clear_disp_pub);
            this.groupBox3.Controls.Add(this.txt_pub_topic_count);
            this.groupBox3.Controls.Add(this.btn_pub_timer_stp);
            this.groupBox3.Controls.Add(this.btn_pub_timer_st);
            this.groupBox3.Controls.Add(this.chk_pub_time);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_interval_pub);
            this.groupBox3.Controls.Add(this.lst_topic_pub);
            this.groupBox3.Controls.Add(this.chk_pub_auto);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_pub_value);
            this.groupBox3.Controls.Add(this.txt_topic_pub);
            this.groupBox3.Controls.Add(this.btn_publish);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(17, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 385);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PUBLISHER";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(363, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "COUNT=";
            // 
            // btn_clear_disp_pub
            // 
            this.btn_clear_disp_pub.ForeColor = System.Drawing.Color.Black;
            this.btn_clear_disp_pub.Location = new System.Drawing.Point(241, 333);
            this.btn_clear_disp_pub.Name = "btn_clear_disp_pub";
            this.btn_clear_disp_pub.Size = new System.Drawing.Size(54, 46);
            this.btn_clear_disp_pub.TabIndex = 6;
            this.btn_clear_disp_pub.Text = "Clear";
            this.btn_clear_disp_pub.UseVisualStyleBackColor = true;
            this.btn_clear_disp_pub.Click += new System.EventHandler(this.btn_clear_disp_pub_Click);
            // 
            // txt_pub_topic_count
            // 
            this.txt_pub_topic_count.Location = new System.Drawing.Point(373, 15);
            this.txt_pub_topic_count.Name = "txt_pub_topic_count";
            this.txt_pub_topic_count.Size = new System.Drawing.Size(67, 20);
            this.txt_pub_topic_count.TabIndex = 7;
            // 
            // btn_pub_timer_stp
            // 
            this.btn_pub_timer_stp.ForeColor = System.Drawing.Color.Black;
            this.btn_pub_timer_stp.Location = new System.Drawing.Point(301, 357);
            this.btn_pub_timer_stp.Name = "btn_pub_timer_stp";
            this.btn_pub_timer_stp.Size = new System.Drawing.Size(56, 22);
            this.btn_pub_timer_stp.TabIndex = 9;
            this.btn_pub_timer_stp.Text = "STOP";
            this.btn_pub_timer_stp.UseVisualStyleBackColor = true;
            this.btn_pub_timer_stp.Click += new System.EventHandler(this.btn_pub_timer_stp_Click);
            // 
            // btn_pub_timer_st
            // 
            this.btn_pub_timer_st.ForeColor = System.Drawing.Color.Black;
            this.btn_pub_timer_st.Location = new System.Drawing.Point(301, 333);
            this.btn_pub_timer_st.Name = "btn_pub_timer_st";
            this.btn_pub_timer_st.Size = new System.Drawing.Size(56, 22);
            this.btn_pub_timer_st.TabIndex = 9;
            this.btn_pub_timer_st.Text = "START";
            this.btn_pub_timer_st.UseVisualStyleBackColor = true;
            this.btn_pub_timer_st.Click += new System.EventHandler(this.btn_pub_timer_st_Click);
            // 
            // chk_pub_time
            // 
            this.chk_pub_time.AutoSize = true;
            this.chk_pub_time.Checked = true;
            this.chk_pub_time.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_pub_time.Location = new System.Drawing.Point(156, 354);
            this.chk_pub_time.Name = "chk_pub_time";
            this.chk_pub_time.Size = new System.Drawing.Size(75, 17);
            this.chk_pub_time.TabIndex = 8;
            this.chk_pub_time.Text = "Time Data";
            this.chk_pub_time.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Interval(ms)";
            // 
            // txt_interval_pub
            // 
            this.txt_interval_pub.Location = new System.Drawing.Point(75, 351);
            this.txt_interval_pub.Name = "txt_interval_pub";
            this.txt_interval_pub.Size = new System.Drawing.Size(75, 20);
            this.txt_interval_pub.TabIndex = 6;
            this.txt_interval_pub.Text = "250";
            // 
            // lst_topic_pub
            // 
            this.lst_topic_pub.FormattingEnabled = true;
            this.lst_topic_pub.Location = new System.Drawing.Point(6, 67);
            this.lst_topic_pub.Name = "lst_topic_pub";
            this.lst_topic_pub.Size = new System.Drawing.Size(434, 264);
            this.lst_topic_pub.TabIndex = 5;
            // 
            // chk_pub_auto
            // 
            this.chk_pub_auto.AutoSize = true;
            this.chk_pub_auto.Checked = true;
            this.chk_pub_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_pub_auto.Location = new System.Drawing.Point(13, 348);
            this.chk_pub_auto.Name = "chk_pub_auto";
            this.chk_pub_auto.Size = new System.Drawing.Size(56, 17);
            this.chk_pub_auto.TabIndex = 4;
            this.chk_pub_auto.Text = "AUTO";
            this.chk_pub_auto.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Topic Name";
            // 
            // txt_pub_value
            // 
            this.txt_pub_value.Location = new System.Drawing.Point(263, 41);
            this.txt_pub_value.Name = "txt_pub_value";
            this.txt_pub_value.Size = new System.Drawing.Size(94, 20);
            this.txt_pub_value.TabIndex = 2;
            this.txt_pub_value.Text = "1.0";
            // 
            // txt_topic_pub
            // 
            this.txt_topic_pub.Location = new System.Drawing.Point(6, 41);
            this.txt_topic_pub.Name = "txt_topic_pub";
            this.txt_topic_pub.Size = new System.Drawing.Size(232, 20);
            this.txt_topic_pub.TabIndex = 2;
            this.txt_topic_pub.Text = "Home/door/Reception";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(8, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "MQTT PUB-SUB CLIENT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_get_srv_resp_time);
            this.groupBox1.Controls.Add(this.cbo_server_address);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pb_status);
            this.groupBox1.Controls.Add(this.btn_disconnect);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_client_ID);
            this.groupBox1.Controls.Add(this.txt_server_port);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(17, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Parameter";
            // 
            // cbo_server_address
            // 
            this.cbo_server_address.FormattingEnabled = true;
            this.cbo_server_address.Items.AddRange(new object[] {
            "localhost",
            "broker.hivemq.com",
            "mqtt.flespi.io",
            "mqtt.dioty.co",
            "mqtt.dioty.co",
            "mqtt.fluux.io"});
            this.cbo_server_address.Location = new System.Drawing.Point(15, 46);
            this.cbo_server_address.Name = "cbo_server_address";
            this.cbo_server_address.Size = new System.Drawing.Size(174, 21);
            this.cbo_server_address.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(837, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "STATUS";
            // 
            // pb_status
            // 
            this.pb_status.BackColor = System.Drawing.Color.Red;
            this.pb_status.Location = new System.Drawing.Point(845, 36);
            this.pb_status.Name = "pb_status";
            this.pb_status.Size = new System.Drawing.Size(31, 28);
            this.pb_status.TabIndex = 3;
            this.pb_status.TabStop = false;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.ForeColor = System.Drawing.Color.Navy;
            this.btn_disconnect.Location = new System.Drawing.Point(563, 29);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(72, 37);
            this.btn_disconnect.TabIndex = 2;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.ForeColor = System.Drawing.Color.Navy;
            this.btn_connect.Location = new System.Drawing.Point(492, 29);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(65, 37);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(311, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Client ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Address";
            // 
            // txt_client_ID
            // 
            this.txt_client_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_client_ID.Location = new System.Drawing.Point(311, 46);
            this.txt_client_ID.Name = "txt_client_ID";
            this.txt_client_ID.Size = new System.Drawing.Size(175, 26);
            this.txt_client_ID.TabIndex = 0;
            this.txt_client_ID.Text = "Lenovo-PC";
            // 
            // txt_server_port
            // 
            this.txt_server_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_server_port.Location = new System.Drawing.Point(195, 46);
            this.txt_server_port.Name = "txt_server_port";
            this.txt_server_port.Size = new System.Drawing.Size(110, 26);
            this.txt_server_port.TabIndex = 0;
            this.txt_server_port.Text = "1883";
            // 
            // timer_sub
            // 
            this.timer_sub.Enabled = true;
            this.timer_sub.Interval = 1;
            this.timer_sub.Tick += new System.EventHandler(this.timer_sub_Tick);
            // 
            // timer_pub
            // 
            this.timer_pub.Tick += new System.EventHandler(this.timer_pub_Tick);
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(15, 29);
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(877, 26);
            this.txt_msg.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_msg);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(12, 526);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(900, 73);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message";
            // 
            // txt_running_time
            // 
            this.txt_running_time.BackColor = System.Drawing.Color.Maroon;
            this.txt_running_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_running_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_running_time.ForeColor = System.Drawing.Color.Red;
            this.txt_running_time.Location = new System.Drawing.Point(550, 12);
            this.txt_running_time.Name = "txt_running_time";
            this.txt_running_time.Size = new System.Drawing.Size(195, 37);
            this.txt_running_time.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(433, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "System Running=";
            // 
            // txt_display_time
            // 
            this.txt_display_time.BackColor = System.Drawing.Color.Maroon;
            this.txt_display_time.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_display_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_display_time.ForeColor = System.Drawing.Color.Red;
            this.txt_display_time.Location = new System.Drawing.Point(273, 12);
            this.txt_display_time.Name = "txt_display_time";
            this.txt_display_time.Size = new System.Drawing.Size(132, 37);
            this.txt_display_time.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pub_Sub_Client.Properties.Resources.SU_LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(773, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_get_srv_resp_time
            // 
            this.btn_get_srv_resp_time.ForeColor = System.Drawing.Color.Black;
            this.btn_get_srv_resp_time.Location = new System.Drawing.Point(641, 29);
            this.btn_get_srv_resp_time.Name = "btn_get_srv_resp_time";
            this.btn_get_srv_resp_time.Size = new System.Drawing.Size(152, 35);
            this.btn_get_srv_resp_time.TabIndex = 6;
            this.btn_get_srv_resp_time.Text = "Get Response Time";
            this.btn_get_srv_resp_time.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(929, 611);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_display_time);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_running_time);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "MQTT Pub-Sub Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_status)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_publish;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_server_port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_topic_sub;
        private System.Windows.Forms.CheckBox chk_pub_auto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_topic_pub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_status;
        private System.Windows.Forms.Timer timer_sub;
        private System.Windows.Forms.Timer timer_pub;
        private System.Windows.Forms.ListBox lst_topic_sub;
        private System.Windows.Forms.ListBox lst_topic_pub;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_client_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_pub_value;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_interval_pub;
        private System.Windows.Forms.Button btn_pub_timer_stp;
        private System.Windows.Forms.Button btn_pub_timer_st;
        private System.Windows.Forms.CheckBox chk_pub_time;
        private System.Windows.Forms.Button btn_clear_disp_sub;
        private System.Windows.Forms.Button btn_clear_disp_pub;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_sub_topic_count;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_pub_topic_count;
        private System.Windows.Forms.TextBox txt_running_time;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_display_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbo_server_address;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_show_graph;
        private System.Windows.Forms.Button btn_get_srv_resp_time;
    }
}

