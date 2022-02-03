using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void btnParseName_Click(object sender, System.EventArgs e) {
            // TODO: Add code to parse name


        }

        private void btnEditPhoneNumber_Click(object sender, System.EventArgs e) {
            ////// TODO: Add code to edit the phone number

            // Exercise 9-2 - Work with Strings

            ///////////////////////////////////////////////////////////////////////////////////
            // First walk through:

            #region EditPhoneNumber
            //// Replace the txtPhoneNumber.Text with an empty string
            //string phoneNumber = txtPhoneNumber.Text.Replace("(", "");
            //string digitsOnly = phoneNumber.Replace(")", "");
            //digitsOnly = digitsOnly.Replace("-", "");
            //digitsOnly = digitsOnly.Replace(" ", "");
            //string standardFormat = digitsOnly.Substring(0, 3) + "-"
            //                       + digitsOnly.Substring(3, 3) + "-"
            //                       + digitsOnly.Substring(6);

            //string message = string.Empty;
            //message += ($"Entered:      \t{txtPhoneNumber.Text}\n\n");
            //message += ($"Digits Only:   \t{digitsOnly}\n\n");
            //message += ($"Standard format:\t{standardFormat}\n\n");

            //MessageBox.Show(message, "Edit Phone Number");
            #endregion

            ///////////////////////////////////////////////////////////////////////////////////

            //// Here, Replicating the above code with added notes of steps:
            
            #region ReplicatingPhoneNumberCode
            // Takes inputed phone number & replaces the ( with a empty string
            string phoneNumber = txtPhoneNumber.Text.Replace("(","");
            // Same as above but replaces the ) with a empty string
            phoneNumber = phoneNumber.Replace(")", "");
            // Now, the phone number has no parentheses

            // Now, replacing the spaces in the phone number with an
            // empty string & putting back into the phoneNumber variable
            phoneNumber = phoneNumber.Replace(" ", "");

            // Replacing the -'s with a empty string in a new variable called digitsOnly
            string digitsOnly = phoneNumber.Replace("-", "");

            // Creating a empty string for the created Standard Format variable
            string standardFormat = string.Empty;

            // Taking first 3 digits into a variable called standardFormat
            standardFormat += digitsOnly.Substring(0, 3);
            // Putting a dash at end of first 3 characters
            standardFormat += "-";
            
            // Taking the next 3 digits & inserting into standardFormat
            standardFormat += digitsOnly.Substring(3, 3);
            // Adding the second dash in the phone number
            standardFormat += "-";

            // Adding the last 4 characters to the phone number
            // The 4 is optional since the 6 would go till the rest of the characters
            standardFormat += digitsOnly.Substring(6, 4);

            // Creating a empty string to store the message in
            string message = string.Empty;

            // The text that displays the value entered,
            // the digits & the Standard Format
            message += ($"Entered:      \t{txtPhoneNumber.Text}\n\n");
            message += ($"Digits Only:   \t{digitsOnly}\n\n");
            message += ($"Standard format:\t{standardFormat}\n\n");

            // The display of the the value entered, the digits & the Standard Format
            MessageBox.Show(message, "Edit Phone Number");
            #endregion
        }

        // TODO: Add ToInitialCap method here


        private void btnExit_Click(object sender, System.EventArgs e) {
            this.Close();
        }

    }
}
