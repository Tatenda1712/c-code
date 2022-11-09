using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ZinaraAdminMain
{
    public partial class Form1 : Form
    {
  
        private CookieContainer cookies;
        public Form1()
        {
            InitializeComponent();
            
        }
        public static class Globals
        {
            public static CookieContainer cookieJar;
            public static CookieCollection cookieCollection;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (loginemail.Text == "" && loginpassword.Text == "")
            {
                loginerror.Text = "Fill All Fields!!!";
            }
            else if (loginemail.Text == "")
            {
                loginerror.Text = "Enter your Email";
            }
            else if (loginpassword.Text == "")
            {
                loginerror.Text = "Enter your Password";
            }
            else
            {
                Globals.cookieJar=new CookieContainer();
                var request = (HttpWebRequest)WebRequest.Create("http://172.16.2.242:8080/etc_back/public/admin/auth");  //for auth
               // request.CookieContainer = cookieJar;
                var postData = "email=" + Uri.EscapeDataString(loginemail.Text) + "&&password=" + Uri.EscapeDataString(loginpassword.Text);
                var data_2 = Encoding.ASCII.GetBytes(postData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.134 Safari/537.36";
                request.CookieContainer= Globals.cookieJar;
                request.ContentLength = data_2.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data_2, 0, data_2.Length);
                }
                try
                {
                    var response = (HttpWebResponse)request.GetResponse();
                    Globals.cookieCollection=response.Cookies;
                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    dynamic results = JsonConvert.DeserializeObject<dynamic>(responseString);
                    string data = results.data;

                    loginpassword.Text = "";
                    loginemail.Text = "";
                    if (data=="done")
                    {
                        Home home = new Home();
                        this.Hide();
                        home.ShowDialog();
                    }
                    else
                    {
                        loginerror.Text = "Incorrect Credentials";
                    }
                }
                catch
                {
                    Console.WriteLine("Eonnection error retry");
                }
            }

           // if (loginemail.Text == "musodzatatenda@gmail.com" && loginpassword.Text == "pass123")
           // {
            //    Home home = new Home();
            //    this.Hide();
          //      home.ShowDialog();
         //   }
         //   else
         //   {
         //       loginerror.Text = "Incorrect Credentials";
          //  }
        }
    }
}