using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DrugWarz
{
    
    public partial class Form1 : Form
    {
        //Initialize cocaine object


        

        public Form1()
        {
            InitializeComponent();

            
  
        }

       // Drug_Cocaine cocaine = new Drug_Cocaine();
        List<Drug_Cocaine> coatPocket = new List<Drug_Cocaine>();

        public void button_Click(object sender, EventArgs e)
        {

            Drug_Cocaine cocaine = new Drug_Cocaine();
            int streetRate = cocaine.DrugRate(30);
            drugPriceListBox.Items.Add("The street Rate is $" + streetRate);
            coatPocket.Add(cocaine);
           // textBox2.ToString() = coatPocket.
           
        }

        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void amountToBuybutton_Click(object sender, EventArgs e)
        {
            string temp = amountToBuyBox.ToString();
            int amountToBuy = Convert.ToInt32(temp);

            for (int i = amountToBuy; i > 0; i--)
            {
                //coatPocket.Add(cocaine);
            }

        }
        

    }
}
