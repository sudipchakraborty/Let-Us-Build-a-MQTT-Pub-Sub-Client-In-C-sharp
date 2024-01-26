using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tools;

namespace Pub_Sub_Client
{
    public partial class Form1 : Form
    {
        Mqtt client;
        MSG disp_pub;
        MSG disp_sub;
        DateTime time_st;
        
        public Form1()
        {
            InitializeComponent();
            client = new Mqtt();
            disp_pub=new MSG(lst_topic_pub);
            disp_sub=new MSG(lst_topic_sub);    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbo_server_address.SelectedIndex = 0;
        }

        private void btn_publish_Click(object sender, EventArgs e)
        {
            client.publish(txt_topic_pub.Text,txt_pub_value.Text); 
            disp_pub.push(txt_topic_pub.Text);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            string addr= cbo_server_address.Text;
            if(client.Connect(txt_client_ID.Text,addr,txt_topic_sub.Text))
            {
                pb_status.BackColor=Color.Green;
                time_st = DateTime.Now;

            }else
            {
                pb_status.BackColor=Color.Red;
            }
            timer_sub.Enabled=true;
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if(client.Disconnect()) pb_status.BackColor=Color.Red;
            else
            {
                txt_msg.Text="Unable to disconnect from server!!!";
            }

            timer_pub.Stop();
            timer_sub.Stop();

        }

        private void timer_sub_Tick(object sender, EventArgs e)
        {
            if(client.message_receive())
            {
                disp_sub.push(client.receive_msg_new);
            }
            txt_sub_topic_count.Text=lst_topic_sub.Items.Count.ToString();  
        }

        private void btn_pub_timer_st_Click(object sender, EventArgs e)
        {
            timer_pub.Interval = Convert.ToInt16(txt_interval_pub.Text);
            timer_pub.Enabled = true;
        }

        private void btn_pub_timer_stp_Click(object sender, EventArgs e)
        {
            timer_pub.Enabled=false;
        }

        private void timer_pub_Tick(object sender, EventArgs e)
        {
            if(chk_pub_auto.Checked)
            {
                if(chk_pub_time.Checked)
                {
                    client.publish(txt_topic_pub.Text, DateTime.Now.ToString());
                    disp_pub.push(txt_topic_pub.Text +":"+DateTime.Now.ToString());
                }
                else
                {
                    client.publish(txt_topic_pub.Text, txt_pub_value.Text);
                    disp_pub.push(txt_topic_pub.Text +":"+txt_pub_value.Text);
                }
                
            }

            txt_pub_topic_count.Text=lst_topic_pub.Items.Count.ToString();  
            
        }

        private void btn_clear_disp_sub_Click(object sender, EventArgs e)
        {
            lst_topic_sub.Items.Clear();
        }

        private void btn_clear_disp_pub_Click(object sender, EventArgs e)
        {
            lst_topic_pub.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string hh = DateTime.Now.Hour.ToString();
            hh=hh.PadLeft(2, '0');

            string mm = DateTime.Now.Minute.ToString();
            mm=mm.PadLeft(2, '0');

            string ss = DateTime.Now.Second.ToString();
            ss=ss.PadLeft(2, '0');

            txt_display_time.Text = hh+":"+mm+":"+ss;

            TimeSpan span = (DateTime.Now-time_st);
            txt_running_time.Text = span.ToString();

             
        }
    }
}
