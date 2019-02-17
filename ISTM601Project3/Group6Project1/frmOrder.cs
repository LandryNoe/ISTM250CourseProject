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
//FORM:             frmOrder.cs
//PURPOSE:          Maintain order records for Kirby's Deli
//INITIALIZE:       N/A
//INPUT:            Customer billing information from textboxes and combo boxes 
//                  in the billing and delivery groupboxes. Within the order groupbox,
//                  the item selection and crust/bread selection from the respective
//                  comboboxes and the quantity from txtQuantity.
//PROCESS:          If delivery is selected, the program will verify the delivery
//                  address is in Bryan or College Station and the textboxes in
//                  the delivery groupbox will be autopopulated with the information
//                  from the billing groupbox. Based on the item selected, the requisite 
//                  bread or crust is displayed. The order subtotal, and order total is
//                  then calculated based on the quantity, items selected, and the tax.
//OUTPUT:           The portions of each order is displayed in the listbox lstOrder, 
//                  the subtotal is displayed and updated in the txtSubtotal textbox
//                  the Tax is calculated and displayed in txtTax, and the entire order
//                  total is then displayed in txtOrder.
//TERMINATE:        N/A
//HONOR CODE:       “On my honor, as an Aggie, I have neither given
//                  nor received unauthorized aid on this academic work.”











namespace Group6Project1
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        #region Close

        /// <summary>
        /// closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); //closes the form

        }
        #endregion


        #region Globals
        string[] strStates = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
        //string of states so that user cannot enter state in error
        decimal decPrice = 0m;      //establishes global price variable
        decimal decSubtotal = 0m;   //establishes global subtotal variable
        decimal decTax = .0825m;        //sets the tax rate
        List<string> orderList = new List<string>();
        

        string[,] strInventory =      { {"flour", "200" }, //this array holds the inventory levels
                                        {"yeast", "50" },
                                        {"sugar", "30" },
                                        {"oil", "25" },
                                        {"ham", "10" },
                                        {"turkey", "10" },
                                        {"scheese", "20" },
                                        {"lettuce", "14" },
                                        {"tomato", "14" },
                                        {"bacon", "10" },
                                        {"pickles", "20" },
                                        {"mayo", "15" },
                                        {"mustard", "12" },
                                        {"pepprni", "20" },
                                        {"sauce", "60" },
                                        {"gcheese", "25" },
                                        {"salt", "10" },
                                        {"pepper", "10" },};

        string[,] strIngredientsNeeded = {  {"flour","1","1","1","3","3","3" }, //this array holds the required amounts of ingredients for certain items
                                            { "yeast", ".5", ".5", ".5", "2", "2", "2" },
                                            { "sugar", ".03", ".03", ".03", ".5", ".5", ".5" },
                                            { "oil", ".05", ".05", ".05", ".1", ".1", ".1" },
                                            { "ham", ".1", "0", "0", "0", "0", ".1" },
                                            { "turkey", "0", ".1", "0", "0", "0", ".1" },
                                            { "scheese", ".1", ".1", "0", "0", "0", "0" },
                                            { "lettuce", ".25", ".25", ".3", "0", "0", "0" },
                                            { "tomato", ".25", ".25", ".3", "0", "0", "3" },
                                            { "bacon", "0", "0", ".1", "0", "0", ".1" },
                                            { "pickles", ".02", ".02", "0", "0", "0", "0" },
                                            { "mayo", ".02", ".02", ".02", "0", "0", "0" },
                                            { "mustard", ".02", ".02", ".02", "0", "0", "0" },
                                            { "pepprni", "0", "0", "0", "0", ".3", ".3" },
                                            { "sauce", "0", "0", "0", "1", "1", "1" },
                                            { "gcheese", "0", "0", "0", ".3", ".2", ".2" },
                                            { "salt", ".01", ".01", ".01", ".02", ".02", ".02" },
                                            { "pepper", ".01", ".01", ".01", ".02", ".02", ".02" }, };


        string[,] strInventoryItemsArray =    { {"Ham & Swiss Sandwich", "1" }, //this array contains the item type and index value for the corresponding array strIngredientsNeeded
                                                { "Turkey and Provolone Sandwich", "2" },
                                                { "BLT Sandwich", "3" },
                                                { "Med. Cheese Pizza", "4" },
                                                { "Med.Pepperoni Pizza", "5" },
                                                { "Med. Supreme Pizza", "6" }, };


        #endregion

        #region Checkbox

        /// <summary>
        /// runs whenever the checked property of the checkbox changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkDeliveryOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeliveryOrder.Checked == true)
            {
                grpDeliveryAddress.Enabled = true;  //enables the delivery groupbox
                txtDeliveryName.Text = txtBillingName.Text;     //the following sends all information from the billing textboxes to the deliver textboxes
                txtDeliveryStreetAddress.Text = txtBillingStreetAddress.Text;
                txtDeliveryCity.Text = txtBillingCity.Text;
                cboDeliveryState.SelectedIndex = cboBillingState.SelectedIndex;
                txtDeliveryZipCode.Text = txtBillingZipCode.Text;
                txtDeliveryPhoneNumber.Text = txtBillingPhoneNumber.Text;
                txtDeliverySubdivision.Text = txtBillingSubdivision.Text;


            }
            else
            {
                grpDeliveryAddress.Enabled = false;   //disables the delivery groupbox if delivery check box isn't checked
                txtDeliveryName.Text = "";
                txtDeliveryStreetAddress.Text = "";     //clears all the delivery textboxes
                txtDeliveryCity.Text = "";
                txtDeliveryZipCode.Text = "";
                txtDeliveryPhoneNumber.Text = "";
                txtDeliverySubdivision.Text = "";
            }
        }
        #endregion

        #region Form Load

        /// <summary>
        /// runs when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOrder_Load(object sender, EventArgs e)
        {
            grpDeliveryAddress.Enabled = false; //disables delivery address
            lblBreadCrust.Text = "Bread:"; //sets label to display bread


            cboBillingState.Items.Clear();                  //populates the billing state combo box with all the states from the states string
            for (int i = 0; i < strStates.Length; i++)
            {
                cboBillingState.Items.Add(strStates[i]);
            }
            cboBillingState.SelectedIndex = 42; //defaults to texas

            cboDeliveryState.Items.Clear();     //populates the delivery state combo box with all the states from the states string
            for (int i = 0; i < strStates.Length; i++)
            {
                cboDeliveryState.Items.Add(strStates[i]);
            }
            cboDeliveryState.SelectedIndex = 42; //defaults to texas

            cboItem.Items.Add("Ham & Swiss Sandwich");        //adds all items to the items combobox
            cboItem.Items.Add("Turkey and Provolone Sandwich");
            cboItem.Items.Add("BLT Sandwich");
            cboItem.Items.Add("Med. Cheese Pizza");
            cboItem.Items.Add("Med. Pepperoni Pizza");
            cboItem.Items.Add("Med. Supreme Pizza");
            
            cboItem.SelectedIndex = 0;     //sets initial selections to the first populated item in the respective comboboxes
            cboBreadCrust.SelectedIndex = 0;
            
            
        }
        #endregion



        #region Add Item

        /// <summary>
        /// adds items to the listbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            { 
                if (IsValidDataAddItems())   //performs validation
                {
                    decimal decOrderSubtotal = Convert.ToInt32(txtQuantity.Text) * decPrice;   //calculates & creates variable for the order subtoatl for the listbox 

                    decSubtotal += Convert.ToInt32(txtQuantity.Text) * decPrice; //calculates the running subtotal to be displayed in the textbox
                    orderList.Add(cboBreadCrust.Text.ToString() + " " + cboItem.Text.ToString() + ", " + txtQuantity.Text.ToString() + "@" + decPrice.ToString("c2") + ", total: " + decOrderSubtotal.ToString("c2")); //creates items for listbox

                    loadOrderListBox(); //loads listbox

                    txtSubtotal.Text = decSubtotal.ToString("c");   //displays subtotal
                    txtQuantity.Focus(); //puts focus on txtQuantity

                    txtQuantity.Clear(); //resetting 
                    cboItem.SelectedIndex = 0;  //sets default of items combo box to the first entry

                    decimal decTotal = decSubtotal * (1 + decTax);
                    txtOrderTotal.Text = decTotal.ToString("c2");

                    decimal decOrderTax = decSubtotal * decTax;
                    txtTax.Text = decOrderTax.ToString("c2");

                    txtQuantity.Clear(); //clears quantity after adding an item 
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Text Input Error has occurred. Please check input values.", "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show("One or more of entries are too large. Check inputs for too large of numbers.", "Entry Error");
            }
            catch
            {
                MessageBox.Show("Generic Error", "Error");
            }


        }
        #endregion

        #region Load Order Listbox


        /// <summary>
        /// Loads items into the listbox
        /// </summary>
        private void loadOrderListBox()
        {
            lstOrder.Items.Clear();
            for (int i = 0; i < orderList.Count; i++)
            {
                lstOrder.Items.Add(orderList[i].ToString());            
            }
            
        }
        #endregion

        #region Process

        /// <summary>
        /// processes an order once all items have been added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {

                if(IsValidDataProcess())  //runs validation
                    
                {
                    if (txtQuantity.Text == "") //runs if only processed, and makes sure there is nothing entered in txtQuantity
                    {
                        DialogResult button = MessageBox.Show("Is order correct?", "Order Complete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (button == DialogResult.Yes)
                        {

                            inventoryConversion();
                            
                            
                            
                            //clears all textboxes
                            txtBillingCity.Clear();
                            txtBillingName.Clear();
                            txtBillingPhoneNumber.Clear();
                            txtBillingStreetAddress.Clear();
                            txtBillingSubdivision.Clear();
                            txtBillingZipCode.Clear();
                            txtDeliveryCity.Clear();
                            txtDeliveryName.Clear();
                            txtDeliveryPhoneNumber.Clear();
                            txtDeliveryStreetAddress.Clear();
                            txtDeliverySubdivision.Clear();
                            txtDeliveryZipCode.Clear();
                            txtOrderTotal.Clear();
                            txtQuantity.Clear();
                            txtSubtotal.Clear();
                            txtTax.Clear();
                            lstOrder.Items.Clear();
                            cboBillingState.SelectedIndex = 42;
                            cboDeliveryState.SelectedIndex = 42;
                            orderList.Clear();
                            decSubtotal = 0m;



                            
                            //checks if user would like to view inventory form:

                            DialogResult buttonInventory = MessageBox.Show("Would you like to view current inventory levels?", "Inventory Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (buttonInventory == DialogResult.Yes)
                            {
                                NewClass.temparray = strInventory;

                                frmInventory Inventory = new frmInventory();

                                Inventory.Show();
                            } //if the user selects yes, this sets the curreny inventory levels (strInventory array) equal to a temporary "temparray" from the NewClass class,
                            // the temporary array can then be copied over to the Inventory Form.




                        }
                        else
                        {
                            
                            return;
                        }

                    }
                    else //runs if there is anything in txtQuantity, perhaps something needs to be added and processed
                    {

                        MessageBox.Show("Please finish adding item to order. If you are finished and want to process, leave the quantity textbox blank.");

                        txtQuantity.Focus();
                        return;
                        

                        
                    }
                    

                }
                
            }


            catch (FormatException)
            {
                MessageBox.Show("Text Input Error has occurred. Please check input values.", "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show("One or more of entries are too large. Check inputs for too large of numbers.", "Entry Error");
            }
            catch
            {
                MessageBox.Show("Generic Error");
            }






        }
        #endregion

        #region Clear Button

        /// <summary>
        /// clears the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears all textboxes
            txtBillingCity.Clear();
            txtBillingName.Clear();
            txtBillingPhoneNumber.Clear();
            txtBillingStreetAddress.Clear();
            txtBillingSubdivision.Clear();
            txtBillingZipCode.Clear();
            txtDeliveryCity.Clear();
            txtDeliveryName.Clear();
            txtDeliveryPhoneNumber.Clear();
            txtDeliveryStreetAddress.Clear();
            txtDeliverySubdivision.Clear();
            txtDeliveryZipCode.Clear();
            txtOrderTotal.Clear();
            txtQuantity.Clear();
            txtSubtotal.Clear();
            txtTax.Clear();
            lstOrder.Items.Clear();
            cboBillingState.SelectedIndex = 42;
            cboDeliveryState.SelectedIndex = 42;
            orderList.Clear();
            decSubtotal = 0m;




        }
        #endregion


        #region Inventory Method

        /// <summary>
        /// Inventory processing; this method extracts the specified
        /// item and quantity from the lstOrder listbox using string
        /// manipulation, and stores it in an array to calculate the
        /// amount of ingredients needed and subtracts them from the
        /// inventory array.
        /// </summary>
        public void inventoryConversion()
        {


            int intInventoryItem = 0;
            int intQuantity = 0;
                                       

            foreach (string item in lstOrder.Items) //for each item in the listbox lstOrder
            {
                
                int intItemStartIndex = item.IndexOf(" ") +1;
                int intItemEndIndex = item.IndexOf(", ");
                string strItemName = item.Substring(intItemStartIndex, intItemEndIndex - intItemStartIndex); //this is to parse the item name and compare it to an array with the appropriate array index in strIngredientsNeeded 



                int intQuantityStartIndex = item.IndexOf(", ") +1;
                int intQuantityEndIndex = item.IndexOf("@");
                intQuantity = Convert.ToInt32(item.Substring(intQuantityStartIndex, intQuantityEndIndex - intQuantityStartIndex)); //parses out the quantity ordered

                for (int i = 0; i < strInventoryItemsArray.GetLength(0); i++)
                {
                    if (strItemName == strInventoryItemsArray[i,0])
                    {
                        intInventoryItem = Convert.ToInt32(strInventoryItemsArray[i,1]);

                        for (int rowCounter = 0; rowCounter < strInventory.GetLength(0); rowCounter++)
                        {
                            //for every ingredient, decInventory = the quantity of items made * the required ingredients for the specified item
                            decimal decFood = intQuantity * Convert.ToDecimal(strIngredientsNeeded[rowCounter, intInventoryItem]); 
                            decimal decInventory = Convert.ToDecimal(strInventory[rowCounter, 1]) - decFood;

                            strInventory[rowCounter, 1] = Convert.ToString(decInventory);
                        }
                
                    }
                                                        
                                                                          
                }

            }


           
            //here parse the quantity from the lstOrder listbox (the string data after the ", " and before the "@". Then convert that data to int. then update intQuantity

            
                
            
            

        }













        #endregion





        #region Validation


        public bool IsValidDataAddItems() //validation for the add items button
        {
            return
                //IsPresent

                Validator.IsPresent(txtQuantity) &&//validating quantity ordered


                //IsSelected
                Validator.IsSelected(cboBillingState) &&
                Validator.IsSelected(cboBreadCrust) &&
                Validator.IsSelected(cboItem) &&

                 //IsInteger
                 Validator.IsInteger(txtQuantity) &&


               //IsWithinRange
               Validator.IsWithinRange(txtQuantity, 1, 100);

               

        }
        public bool IsValidDeliveryData() //validation if the delivery checkbox is clicked
        {
            if (chkDeliveryOrder.Checked == true)
            {
                return
                //IsPresent
                Validator.IsPresent(txtDeliveryName) && //validating delivery text boxes
                Validator.IsPresent(txtDeliveryStreetAddress) &&
                Validator.IsPresent(txtDeliveryCity) &&
                Validator.IsPresent(txtDeliveryZipCode) &&
                Validator.IsPresent(txtDeliveryPhoneNumber) &&
                Validator.IsPresent(txtDeliverySubdivision) &&


                //IsSelected
                Validator.IsSelected(cboDeliveryState) &&


                //IsInteger
                Validator.IsInteger(txtDeliveryPhoneNumber) &&
                Validator.IsInteger(txtDeliveryZipCode) &&


                //IsWitinRange
                Validator.IsWithinRange(txtDeliveryZipCode, 0, 99999) &&
                Validator.IsWithinRange(txtDeliveryPhoneNumber, 0, 9999999999)&&

                //IsDeliverable (non case sensitive)
                Validator.IsDeliverableState(cboDeliveryState) &&
                Validator.IsDeliverableCity(txtDeliveryCity) &&

                //Phone and Zip
                Validator.IsPhoneNumber(txtDeliveryPhoneNumber) &&
                Validator.IsZipCode(txtDeliveryZipCode);


            }
            else
            {
                return true;
            }
            
        }

        public bool IsValidDataProcess() //Validation for the process button
        {
            if (lstOrder.Text == "")
            {
                return
                    //IsPresent
                    Validator.IsPresent(txtBillingName) && //validating billing text boxes
                    Validator.IsPresent(txtBillingStreetAddress) &&
                    Validator.IsPresent(txtBillingCity) &&
                    Validator.IsPresent(txtBillingZipCode) &&
                    Validator.IsPresent(txtBillingPhoneNumber) &&
                    Validator.IsPresent(txtBillingSubdivision) &&





                    //IsSelected
                    Validator.IsSelected(cboBillingState) &&
                    Validator.IsSelected(cboBreadCrust) &&
                    Validator.IsSelected(cboItem) &&

                    //IsInteger
                    Validator.IsInteger(txtBillingPhoneNumber) &&
                    Validator.IsInteger(txtBillingZipCode) &&



                    //IsWithinRange
                    Validator.IsWithinRange(txtBillingZipCode, 0, 99999) &&
                    Validator.IsWithinRange(txtBillingPhoneNumber, 0, 9999999999) &&


                    //IsString

                    //PHone and Zip
                    Validator.IsPhoneNumber(txtBillingPhoneNumber) &&
                    Validator.IsZipCode(txtBillingZipCode) &&



                   //isValidDeliveryData
                   IsValidDeliveryData();
                

            }

            else
            {
                return
                    //IsPresent
                    Validator.IsPresent(txtBillingName) && //validating billing text boxes
                    Validator.IsPresent(txtBillingStreetAddress) &&
                    Validator.IsPresent(txtBillingCity) &&
                    Validator.IsPresent(txtBillingZipCode) &&
                    Validator.IsPresent(txtBillingPhoneNumber) &&
                    Validator.IsPresent(txtBillingSubdivision) &&




                    //IsSelected
                    Validator.IsSelected(cboBillingState) &&
                    Validator.IsSelected(cboBreadCrust) &&
                    Validator.IsSelected(cboItem) &&

                    //IsInteger
                    Validator.IsInteger(txtBillingPhoneNumber) &&
                    Validator.IsInteger(txtBillingZipCode) &&



                    //IsWithinRange

                    Validator.IsWithinRange(txtBillingZipCode, 0, 99999) &&
                    Validator.IsWithinRange(txtBillingPhoneNumber, 0, 9999999999) &&


                    //Phone & Zip
                    Validator.IsPhoneNumber(txtBillingPhoneNumber) &&
                    Validator.IsZipCode(txtBillingZipCode) &&


                    



                    //isValidDeliveryData
                    IsValidDeliveryData();
            }


        }

        



        #endregion


        #region Combo Box Selected Index Changed Method
        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboItem.SelectedIndex <= 2)
            {
                decPrice = 5m; //sandwich
                picSandwichOrPizza.Image = Group6Project1.Properties.Resources.deli;
                lblBreadCrust.Text = "Bread";

                //options
                cboBreadCrust.Items.Clear(); //bread options
                cboBreadCrust.Items.Add("White");
                cboBreadCrust.Items.Add("Pumpernickel");
                cboBreadCrust.Items.Add("Rye");
                cboBreadCrust.Items.Add("Sourdough");
                cboBreadCrust.Items.Add("Multigrain");
                cboBreadCrust.SelectedIndex = 0;
            }

            else
            {
                decPrice = 9.5m; //pizza
                picSandwichOrPizza.Image = Group6Project1.Properties.Resources.pizza;
                lblBreadCrust.Text = "Crust";

                //options
                cboBreadCrust.Items.Clear(); //crust options
                cboBreadCrust.Items.Add("Original");
                cboBreadCrust.Items.Add("Pan");
                cboBreadCrust.Items.Add("Thin");
                cboBreadCrust.Items.Add("Wheat");
                cboBreadCrust.SelectedIndex = 0;
            }
        }
        #endregion


        #region Vendor Button

        private void txtVendor_Click(object sender, EventArgs e)
        {
            frmVendor Vendor = new frmVendor();

            Vendor.Show();
        }
        #endregion


    }
}