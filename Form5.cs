using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Serial_Communication.User_Control;
using System.Web.UI.Design;
using System.Runtime.InteropServices;
using System.IO.Ports;  //시리얼통신을 위해 추가해줘야 함
using System.IO;
using AutoIt;
using Microsoft.Win32;


namespace Serial_Communication
{
    public delegate void wprebtn();
    public delegate void loadbtn();
    public partial class Form5 : Form
    {
        /*flag*/
        private int registkey = 0;
        private int image = 0;
        private int connectkey = 0;
        private int editkey = 0;
        private int communitykey = 0;
        private int writekey = 0;
        public int detailkey = 0;
        /*flag*/

        /*use another form*/
        public static Form5 frm5;
        Connect_Control UC_connect = new Connect_Control();
        Edit UC_edit = new Edit();
        community UC_community = new community();
        /*use another form*/

        /*mysql*/
        MySqlConnection datareadconnect = new MySqlConnection("Server=1.236.44.88;Database=presetdb;Uid=gun;Pwd=1234");
        MySqlConnection con = new MySqlConnection("Server=1.236.44.88;Database=presetdb;Uid=gun;Pwd=1234");
        static string savePath = Application.StartupPath + @"\PRESET.txt";
        List<String> data_list = new List<String>();
        /*mysql*/

        public Form5()
        {
            InitializeComponent();
            frm5 = this;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch
            {

            }
            /*button event, mouse event*/
            UC_edit.MouseDown += new MouseEventHandler(edit_Down_event);
            UC_edit.MouseMove += new MouseEventHandler(edit_Move_event);
            UC_connect.MouseDown += new MouseEventHandler(connect_Down_event);
            UC_connect.MouseMove += new MouseEventHandler(connect_Move_event);
            /*button event, mouse event*/
            this.Notification.Visible = true;
        }

        public Point mMyPoint;

        /*usercontrol change image*/
        private void moveImageBox(object sender)
        {
            GunaAdvenceButton b = (GunaAdvenceButton)sender;
            image_slide.Location = new Point(b.Location.X + 40, b.Location.Y);
            if (image == 0)
            {
                image_slide.Visible = true;
                image = 1;
            }
            image_slide.SendToBack();

        }
        /*usercontrol change image*/

        /*usercontrol change -Edit-*/
        private void gunaAdvenceButton1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
            if (editkey == 0)
            {
                UC_connect.Dock = DockStyle.Fill;
                panel2.Controls.Add(UC_edit);
                editkey = 1;
            }
            if (communitykey == 1)
            {
            }
            if (detailkey == 1)
            {
            }
            UC_edit.BringToFront();
            exit_button.BringToFront();
            minimize_button.BringToFront();
        }
        /*usercontrol change -Edit-*/

        /*usercontrol change -connect-*/
        private void gunaAdvenceButton2_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
            if (connectkey == 0)
            {
                UC_connect.Dock = DockStyle.Fill;
                panel2.Controls.Add(UC_connect);
                connectkey = 1;
            }
            if (communitykey == 1)
            {
            }
            if (detailkey == 1)
            {
            }
            UC_connect.BringToFront();
            exit_button.BringToFront();
            minimize_button.BringToFront();
        }
        /*usercontrol change -connect-*/

        /*usercontrol change -community-*/
        private void gunaAdvenceButton3_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
            if (communitykey == 0)
            {
                UC_community.Dock = DockStyle.Fill;
                panel2.Controls.Add(UC_community);
                communitykey = 1;
            }
            if (communitykey == 1)
            {
            }
            UC_community.BringToFront();
            exit_button.BringToFront();
            minimize_button.BringToFront();
        }
        /*usercontrol change -community-*/

        /*login*/
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (Form3.userlogin == 1)
            {
                Form1 showForm1 = new Form1();
                showForm1.ShowDialog();
            }
            else
            {
                Form3 showForm3 = new Form3();
                showForm3.ShowDialog();

            }
        }
        /*login*/

        /*tray*/
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        /*tray*/

        /*tray exit btn*/
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*tray exit btn*/

        /*minimize btn*/
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Notification.Visible = true;
            Notification.ContextMenuStrip = contextMenuStrip1;
        }
        /*minimize btn*/

        /*exit btn*/
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*exit btn*/

        /*program move*/
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표를 저장한다.
                mMyPoint.X = e.X;
                mMyPoint.Y = e.Y;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표와 저장된 마우스 좌표의 차이만큼 이동 시킨다.
                this.Location = new Point(this.Location.X + (e.X - mMyPoint.X)
                , this.Location.Y + (e.Y - mMyPoint.Y));
            }
        }

        private void edit_Down_event(object sedner, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표를 저장한다.
                mMyPoint.X = e.X;
                mMyPoint.Y = e.Y;
            }
        }

        private void edit_Move_event(object sedner, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표와 저장된 마우스 좌표의 차이만큼 이동 시킨다.
                this.Location = new Point(this.Location.X + (e.X - mMyPoint.X)
                , this.Location.Y + (e.Y - mMyPoint.Y));
            }
        }

        private void connect_Down_event(object sedner, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표를 저장한다.
                mMyPoint.X = e.X;
                mMyPoint.Y = e.Y;
            }
        }

        private void connect_Move_event(object sedner, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //현재 마우스 좌표와 저장된 마우스 좌표의 차이만큼 이동 시킨다.
                this.Location = new Point(this.Location.X + (e.X - mMyPoint.X)
                , this.Location.Y + (e.Y - mMyPoint.Y));
            }
        }
        /*program move*/

        void detail_load()
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {

        }


        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            Form7 showForm7 = new Form7();
            showForm7.ShowDialog();
        }

    }
}