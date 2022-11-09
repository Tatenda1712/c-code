using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ZinaraAdminMain.Form1;

namespace ZinaraAdminMain
{
    public partial class Home : Form
    {
        String new_card = "";
        public String idnumber;
        SerialPort port = new SerialPort("COM8", 9600);
        public Home()
        {
            InitializeComponent();
            displayPanel.BackColor = Color.FromArgb(150, 255, 255, 255);
            SerialPortProgram1();
        }

        private void SerialPortProgram1()
        {

            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived1);


            // Begin communications 



            //port.Open();


        }

        private void port_DataReceived1(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer

            String data = port.ReadLine();
            new_card = data;
            SetText(data);


        }

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lblnewcard.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (text.Length > 2)
                    this.lblnewcard.Text = text;


            }
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            this.Close();
            login.ShowDialog();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click_1(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

       //     if (new_card.Equals(""))
         //   {
           //     lblnewcard.Text = "N/A";
             //   MessageBox.Show("Please tap new card first.", "Status");

               // return;
            //}
            if (newCardNumber.Text == "")
            {
                homeerror.Text = "Enter Card Number";
            }
            else
            {
                var request = (HttpWebRequest)WebRequest.Create("http://172.16.2.242:8080/etc_back/public/admin/assigncard");    //for assigning card


                var postData = "idnumber=" + Uri.EscapeDataString(idnumber) + "&&card_number=" + Uri.EscapeDataString(newCardNumber.Text);

                var data_2 = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.134 Safari/537.36";
                request.CookieContainer = new CookieContainer();
                foreach (Cookie c in Globals.cookieCollection)
                {
                    request.CookieContainer.Add(c);
                }
                request.ContentLength = data_2.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data_2, 0, data_2.Length);
                }
                try
                {
                    var response = (HttpWebResponse)request.GetResponse();

                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    dynamic results = JsonConvert.DeserializeObject<dynamic>(responseString);
                    string data = results.data;
                    new_card = "";
                    lblnewcard.Text = "N/A";
                    if (data.Equals("done"))
                        MessageBox.Show("Done", "Status");
                    else if (data.Equals("card in use"))
                        MessageBox.Show("Card Already in use.", "Status");

                }
                catch
                {
                    Console.WriteLine("Eonnection error retry");
                }
            }

           
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtId.Text == "")
                {
                    iderror.Text = "Enter Id Number";
                }
                //Send a server request here
                else
                {

                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://172.16.2.242:8080/etc_back/public/admin/getcitizen?id_number=" + txtId.Text);
                    request.Method = "GET";
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.134 Safari/537.36";
                    request.AutomaticDecompression = DecompressionMethods.GZip;
                    request.CookieContainer = new CookieContainer();
                    foreach (Cookie c in Globals.cookieCollection)
                    {
                        request.CookieContainer.Add(c);
                    }
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        dynamic results = JsonConvert.DeserializeObject<dynamic>(reader.ReadToEnd());
                        lblname.Text = results.data.fname + " " + results.data.lname;
                        lblid.Text = results.data.n_id;
                        lblemail.Text = results.data.email;
                        lbladdress.Text = results.data.residential_addres;
                        idnumber = results.data.n_id;
                    }
                }
            }
        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Topup topup = new Topup(port);

            topup.ShowDialog();

        }

        private void lblnewcard_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
