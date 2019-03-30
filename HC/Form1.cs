using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;

namespace HC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbDatabase != null && !string.IsNullOrWhiteSpace(tbDatabase.Text))
            {
                string s = dbcheck(tbDatabase.Text.ToString());
                if (s.Length != 0)
                    lbDBout.Text = s;
                else
                    lbDBout.Text = "Database don't exist";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbURL != null && !string.IsNullOrWhiteSpace(tbURL.Text))
            {
                bool idontcareatall = WebSiteIsAvailable(tbURL.Text);
                lbURLOut.Text = idontcareatall.ToString();
            }
        }



        public static string dbcheck(string str)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spDBcheck", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@arg", str);

                con.Open();
                var obj = cmd.ExecuteScalar();
                return obj.ToString();

            }

        }
        private bool WebSiteIsAvailable(string Url)
        {
            string Message = string.Empty;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(Url);

            //var isSecured=request.Scheme;
            //Console.WriteLine(isSecured);
            //			if(isSecured)
            //				Console.WriteLine(true.ToString());
            //			else
            //				Console.WriteLine(false.ToString());


            request.Credentials = System.Net.CredentialCache.DefaultCredentials;
            request.Method = "GET";

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {

                }
            }
            catch (WebException ex)
            {
                Message += ((Message.Length > 0) ? "\n" : "") + ex.Message;
            }

            return (Message.Length == 0);
        }
    }
}
