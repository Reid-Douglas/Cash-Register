using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Cash_Register
{
    

    public partial class cashRegister : Form
    {
        //global variables
        double savannahPrice = 452.72;
        double derekPrice = 452.73;
        double danielPrice = 0.02;
        int numberOfSavannahs = 0;
        int numberOfDereks = 0;
        int numberOfDaniels = 0;
        double taxRate = 0.63;
        double savannahTotal;
        double derekTotal;
        double danielTotal;
        double subtotalAmount;
        double taxAmount;
        double totalAmount;
        public cashRegister()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void totalAmount_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void subtotalAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateTotal_Click(object sender, EventArgs e)
        {
            try
            {
                // get inputs
                numberOfSavannahs = Convert.ToInt32(savannahInput.Text);
                numberOfDereks = Convert.ToInt32(derekInput.Text);
                numberOfDaniels = Convert.ToInt32(danielInput.Text);

                //do calculations
                savannahTotal = numberOfSavannahs * savannahPrice;
                derekTotal = numberOfDereks * derekPrice;
                danielTotal = numberOfDaniels * danielPrice;
                subtotalAmount = savannahTotal + derekTotal + danielTotal;
                taxAmount = subtotalAmount * taxRate;
                totalAmount = subtotalAmount + taxAmount;

                //outputs
                subtotalOutput.Text = $"{subtotalAmount.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("c")}";
                totalOwed.Text = $"{totalAmount.ToString("c")}";   


            }
            catch { 
            }
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void reciept_Click(object sender, EventArgs e)
        {
            //change colour of receipt labels
            receiptPrinter.BackColor = Color.White;

            receiptPrinter.Text = "                    Ingrid Gropps Child Shop";
            Refresh();
            Thread.Sleep(400);

            receiptPrinter.Text += $"\n\nSavannahs:   {numberOfSavannahs}@{savannahPrice}";
            Refresh();
            Thread.Sleep(400);

            receiptPrinter.Text += $"\n       Dereks:   {numberOfDereks}@{derekPrice}";
            Refresh();
            Thread.Sleep(400);

            receiptPrinter.Text += $"\n       Daniels:   {numberOfDaniels}@{danielPrice}";
            Refresh();
            Thread.Sleep(400);

            receiptPrinter.Text += $"\n\n Subtotal: {subtotalAmount}";
            Refresh();
            Thread.Sleep(400);

            receiptPrinter.Text += $"\n Tax: {taxAmount}";
            Refresh();
            Thread.Sleep(400);

            receiptPrinter.Text += $"\n Total: {totalAmount}";
            Refresh();
            Thread.Sleep(400);

            receiptPrinter.Text += $"\n\n Have a Nice Day!";




        }
    }
}
