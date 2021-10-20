using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unirest_net.http;
using System.Xml;
using Newtonsoft.Json;

namespace model_dep_test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check if form is valid
            if(isFormValid())
            {

                //  form has all required values create a dictionary to hold them and pass to the unirest function for api call
                var values = new Dictionary<string, string>(){
                {"GRE", txtGRE.Text},
                {"TOEFL", txtTOEFL.Text} };
                // unitrest function we pass the url to our api and the dictionary
                HttpResponse<string> response = Unirest.post("http://127.0.0.1:5000/pred")
                    .header("accept", "application/json")
                    .body(values)
                    .asJson<string>();

                // variable to hold the response from the api and display it in a dialog box 
                string message = response.Body.ToString();
                DialogResult result = MessageBox.Show(message, "Your admittance chance:", MessageBoxButtons.OK);
            }
        }

        private bool isFormValid()
        {   // check if there are any empty fields in the form and raise an error message if one is found
            string gre = txtGRE.Text;
            string toefl = txtTOEFL.Text;
            if (txtGRE.Text.ToString().Trim() == string.Empty || txtTOEFL.Text.ToString().Trim() == string.Empty)
            {
                string message = "One or more of the fields is empty. Please fill all fields to continue";
                string caption = "Empyt Fields!!!";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
