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

        static Drug_Cocaine cocaine = new Drug_Cocaine();
       // List<Drug_Cocaine> coatPocket = new List<Drug_Cocaine>();
        Drug_Cocaine[] coatPocketArray = new Drug_Cocaine[10];
        Coat userCoat = new Coat();
        static int streetRate;
        public void button_Click(object sender, EventArgs e)
        {

           // Drug_Cocaine cocaine = new Drug_Cocaine();
            streetRate = cocaine.DrugRate(30);
            drugPriceListBox.Items.Add("The street Rate is $" + streetRate);
            //coatPocket.Add(cocaine);
           // textBox2.ToString() = coatPocket.
           
        }

        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void amountToBuybutton_Click(object sender, EventArgs e)
        {
            string temp = amountToBuyBox.ToString();
            int amountToBuy = Convert.ToInt32(temp);

            for (int i = 0; i > amountToBuy-1; i--)
            {
                //coatPocket.Add(cocaine);
                coatPocketArray[i] = new Drug_Cocaine();
                coatPocketArray[i].cokeRate = streetRate;
            }

        }
        

    }
}
