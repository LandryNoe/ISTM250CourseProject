using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AUTHOR:           Antonio Alvarado, Landry Noe, Jason Eilers
//COURSE:           ISTM 250.502
//FORM:             frmInventory.cs
//PURPOSE:          Monitor inventory usage for Kirby's Deli
//INITIALIZE:       N/A
//INPUT:            QUantity of ingredients and type of item is extracte from lstOrder listbox
//PROCESS:          Calculates ingredients used depending on the type of item and quantity ordered
//                  and subtracts this amount from the current inventory levels
//OUTPUT:           Displays a listbox containing all of the updated inventory values for each ingredient
//TERMINATE:        N/A
//HONOR CODE:       “On my honor, as an Aggie, I have neither given
//                  nor received unauthorized aid on this academic work.”



namespace Group6Project1
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// runs when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInventory_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < NewClass.temparray.GetLength(0); i++) //for i in the array
            {
                for(int j = 0; j < NewClass.temparray.GetLength(1); j+=2) // for j in the array, increment by 2
                {
                   lstInventory.Items.Add(NewClass.temparray[i,j] + ": " + NewClass.temparray[i,j+1]); //adds item to the listbox
                }
                
            }
        }




        
        /// <summary>
        /// closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); //closes the form
        }
    }
}
