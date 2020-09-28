using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;  //시리얼통신을 위해 추가해줘야 함
using System.IO;
using AutoIt;
using Microsoft.Win32;
using System.Security.Cryptography.X509Certificates;

namespace Serial_Communication.User_Control
{
    public partial class Connect_Control : UserControl
    {
        public Connect_Control()
        {
            InitializeComponent();
        }
        private void Connect_Control_Load(object sender, EventArgs e)  //폼이 로드되면
        {
        }
        
    }
}
