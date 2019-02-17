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
//FORM:             frmVendor.cs
//PURPOSE:          Display and edit vendor information
//INITIALIZE:       N/A
//INPUT:            Data is imported from an external XML File & the XML file
//                  is updated from input in the textboxes upon saving
//PROCESS:          Vendor information is displayed in textboxes after being 
//                  pulled frm the XML file
//OUTPUT:           If the text input is valid, then the corresponding XML 
//                  file is updated with the new information upon saving
//TERMINATE:        N/A
//HONOR CODE:       “On my honor, as an Aggie, I have neither given
//                  nor received unauthorized aid on this academic work.”





namespace Group6Project1
{
    public partial class frmVendor : Form
    {
        #region globals

        

        List<Vendor> vendors = new List<Vendor>();

        int intCurrentVendor = 0;
        bool isDataSaved = true;

        #endregion

        #region FormLoading
        public frmVendor()
        {
            InitializeComponent();

            vendors = VendorDB.GetVendors();
            PopulateVendors();
            this.Text = ("Vendors");
            isDataSaved = true;
        }
        #endregion

        #region PopulateVendors
        /// <summary>
        /// Method to populate the textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        public void PopulateVendors()
        {
            Vendor vendor = vendors[intCurrentVendor];

            txtName.Text = vendor.Name;
            txtStreetAddress.Text = vendor.Address;
            txtCity.Text = vendor.City;
            txtState.Text = vendor.State;
            txtZipCode.Text = vendor.Zip;
            txtYTDSales.Text = Convert.ToString(vendor.YTD);
            txtSalesRep.Text = vendor.Contact;
            txtPhoneNumber.Text = vendor.Phone;
            txtComments.Text = vendor.Comment;


            //this was much cleaner than my if/else statements
            switch (vendor.DefaultDiscount)
            {
                case 10:
                    rdo10Days.Checked = true;
                    break;
                case 15:
                    rdo15Days.Checked = true;
                    break;
                case 20:
                    rdo20Days.Checked = true;
                    break;
                //this is if a vendor is entered without a discount period (in an xml), or if an error has been made.
                default:
                    rdo10Days.Checked = false;
                    rdo15Days.Checked = false;
                    rdo20Days.Checked = false;
                    break;

            }

            //continue




        }

        #endregion

        #region SaveVendorsList
        /// <summary>
        /// Saving the information in the vendors list
        /// </summary>
        public void SaveVendorsList()
        {
            try
            {
                if(IsValidData())
                {
                    Vendor vendor = vendors[intCurrentVendor];


                    vendor.Name = txtName.Text;  //these pull all the information from the position within the vendor array and put respective data into the text boxes
                    vendor.Address = txtStreetAddress.Text;
                    vendor.City = txtCity.Text;
                    vendor.State = txtState.Text;
                    vendor.Zip = txtZipCode.Text;
                    vendor.YTD = Convert.ToInt32(txtYTDSales.Text);
                    vendor.Contact = txtSalesRep.Text;
                    vendor.Phone = txtPhoneNumber.Text;
                    vendor.Comment = txtComments.Text;




                    if (rdo10Days.Checked == true)  //this will set the radio buttons to the proper amount
                    {
                        vendor.DefaultDiscount = 10;
                    }
                    else if (rdo15Days.Checked == true)
                    {
                        vendor.DefaultDiscount = 15;
                    }
                    else if (rdo20Days.Checked == true)
                    {
                        vendor.DefaultDiscount = 20;
                    }
                    else
                    {
                        vendor.DefaultDiscount = Convert.ToInt32(null);
                    }
                    vendors[intCurrentVendor] = vendor;
                    VendorDB.SaveVendors(vendors);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show("Oops! An unexpected error occured." + "\n\n" + ex.ToString());
            }

            

        }


        #endregion

        #region IsDataSaved

        public void IsDataSaved(object sender, EventArgs e)
        {
            if(isDataSaved == false)
            {
                DialogResult button = MessageBox.Show("You have unsaved data, would you like to save?", "Unsaved Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (button == DialogResult.Yes)
                {
                    SaveVendorsList();
                }

                else if(button == DialogResult.No)
                {
                    return;
                }

                else //cancel
                {
                    
                }
            }
        }




        #endregion
        
        #region DataChanged Method
        private void DataChanged(object sender, EventArgs e) //need these things
        {
            isDataSaved = false;
            this.Text = "Vendors *";


        }
        #endregion
                          
        #region Close Button

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Next Button
        private void btnNextVendor_Click(object sender, EventArgs e)
        {

            if (isDataSaved == false)
            {
                DialogResult button = MessageBox.Show("You have unsaved data, would you like to save?", "Unsaved Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (button == DialogResult.Yes)
                {
                    try
                    {
                        if(IsValidData())
                        {
                            SaveVendorsList(); //the below is the action to move the vendot
                            NextMethod(); //logic to loop then next vendor function
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Oops! An unexpected error occured." + "\n\n" + ex.ToString());
                    }

                    
                }

                else if (button == DialogResult.No)
                {
                    NextMethod();
                    return;
                }
            }
            else if (isDataSaved == true)
            {
                NextMethod();
            }
            


            
        }


        #endregion
        
        #region Previous Button
        private void btnPreviousVendor_Click(object sender, EventArgs e)
        {
            if (isDataSaved == false)
            {
                DialogResult button = MessageBox.Show("You have unsaved data, would you like to save?", "Unsaved Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (button == DialogResult.Yes)
                {
                    try
                    {
                        if(IsValidData())
                        {
                            SaveVendorsList(); //the below is the action to move the vendot
                            PreviousMethod();
                        }
                    }


                    catch(Exception ex)
                    {
                        MessageBox.Show("Oops! An unexpected error occured." + "\n\n" + ex.ToString());
                    }


                    
                }

                else if (button == DialogResult.No)
                {
                    PreviousMethod();
                    return;
                }
            }
            else if (isDataSaved == true)
            {
                PreviousMethod();
            }

                

                

                //if current vendor = 0, set equal to vendors.count(possibly -1)/opposite for next

                
            
        }
        #endregion

        #region Save Button
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(IsValidData())
                {
                    SaveVendorsList();
                    MessageBox.Show("Data has been saved.", "Save");
                    this.Text = ("Vendors");
                    isDataSaved = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Oops! An unexpected error occured." + "\n\n" + ex.ToString());
            }





                
        }

        #endregion

        #region Form Closing
        private void frmVendor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isDataSaved == false)
            {



                DialogResult button = MessageBox.Show("You have unsaved data, would you like to save?", "Unsaved Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (button == DialogResult.Yes)
                {
                    SaveVendorsList();
                }

                else if (button == DialogResult.No)
                {
                    return;
                }

                else //cancel
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion
        
        #region IsValidData
        public bool IsValidData()
        {
            return
                //ispresent
                Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtStreetAddress) &&
                Validator.IsPresent(txtCity) &&
                Validator.IsPresent(txtState) &&
                Validator.IsPresent(txtZipCode) &&
                Validator.IsPresent(txtYTDSales) &&
                Validator.IsPresent(txtSalesRep) &&
                Validator.IsPresent(txtPhoneNumber) &&

                //isint
                Validator.IsInteger(txtYTDSales) &&
                Validator.IsInteger(txtPhoneNumber);


            
        }

        #endregion
        
        #region Radio Buttons Changed

        
        private void rdo10Days_CheckedChanged(object sender, EventArgs e)  //if any of the radio buttons are manually saved, it will reflect that in the form and validation for saving
        {
            isDataSaved = false;
            this.Text = "Vendors *";
        }

        private void rdo15Days_CheckedChanged(object sender, EventArgs e)
        {
            isDataSaved = false;
            this.Text = "Vendors *";
        }

        private void rdo20Days_CheckedChanged(object sender, EventArgs e)
        {
            isDataSaved = false;
            this.Text = "Vendors *";
        }
               

        #endregion

        #region NextMethod
        /// <summary>
        /// this function is used to loop through the vendors
        /// and set the datasaved to true so that changes will
        /// be noted.
        /// </summary>
        private void NextMethod()
        {
            if (intCurrentVendor != 5)
            {
                intCurrentVendor++;
                PopulateVendors();
                this.Text = ("Vendors");
                isDataSaved = true;
            }
            else
            {
                intCurrentVendor = 0;
                PopulateVendors();
                this.Text = ("Vendors");
                isDataSaved = true;
            }
        }
        #endregion
               
        #region PreviousMethod
        /// <summary>
        /// this function is used to loop through the vendors
        /// and set the datasaved to true in a backwards direction
        /// to ensure data changes will be noted.
        /// </summary>
        private void PreviousMethod()
        {
            if (intCurrentVendor != 0)
            {
                intCurrentVendor--;
                PopulateVendors();
                this.Text = ("Vendors");
                isDataSaved = true;
            }
            else
            {
                intCurrentVendor = vendors.Count - 1;
                PopulateVendors();
                this.Text = ("Vendors");
                isDataSaved = true;
            }
        }
        #endregion

    }







}
