using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************************
    Juan Rodriguez
    CIST 2341
    C# Programming 1
    Lab #9
try & catch
This is my code....
*****************************************************************/
namespace MyArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // creates an array using List class
        // made the array global 
        int input = 0;
        int[] myNumberList = new int[10];
        int i = 0;
        private void addValueBtn_Click(object sender, EventArgs e)
        {
            // gets the string in text box then converts it
            getInputAndConvert();
            // adds converted string to array
            try
            {
                myNumberList[i] = input;
                i++;
                //lets user know what happened
                Console.WriteLine("You added " + input + " to the array.");
            }
            catch {
                MessageBox.Show("Array only stores 10 values. Array is now full!");
            }
            

            
        }

        public void getInputAndConvert()
        {
           input = Int32.Parse(addValueTxtBox.Text);
            
        }

        private void displayValuesBtn_Click(object sender, EventArgs e)
        {
            
            for (int index = 0; index < myNumberList.Length; index++)
            {
                Console.WriteLine(myNumberList[index]);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
