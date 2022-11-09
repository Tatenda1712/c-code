using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ZinaraAdminMain
{
    public partial class Topup : Form
    {
        String topUpCard = "";
        SerialPort port1;
        public Topup(SerialPort port)
        {
            InitializeComponent();
            port1 = port;
            SerialPortProgram1();
        }

        private void SerialPortProgram1()
        {

            port1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived1);


            // Begin communications 

        }
        private void port_DataReceived1(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer

            String data = port1.ReadLine();
            topUpCard = data;
            SetText(data);


        }
        delegate void SetTextCallback(string text);
        private void SetText(string text)
        {


            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.topUpCardNumber.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                if (text.Length > 2)
                    this.topUpCardNumber.Text = text;


            }
            this.topUpCardNumber.Text = text;


        }
        private void Topup_Load(object sender, EventArgs e)
        {
            currencyCombo.SelectedIndex = 0;
        }
        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (topUpCard.Equals(""))
            {
                topUpCard = "N/A";
                MessageBox.Show("Please tap new card first.", "Status");

                return;
            }

            var request = (HttpWebRequest)WebRequest.Create("http://172.16.2.242:8080/etc_back/public/admin/getcitizen");    //for topup


            var postData = "currency=" + (currencyCombo.SelectedIndex == 0 ? "rtgs" : "usd") + "&&card_number=" + Uri.EscapeDataString(topUpCard) + "&&amount=" + Uri.EscapeDataString(txtammount.Text);

            var data_2 = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
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

                topUpCardNumber.Text = "";
                topUpCardNumber.Text = "N/A";
                if (data.Equals("done"))
                {

                    MessageBox.Show("Amount succisfully added", "Status");

                }



            }
            catch
            {
                Console.WriteLine("Eonnection error retry");
            }
        }

        private void txtammount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
