using System;
using System.Windows.Forms;

/*
 *		Extra 14-1 Use inheritance
 *		==========================
 *
 *		In this exercise, you'll add two classes
 *		to the Inventory Maintenance app that 
 *		inherit the InventoryItem class.
 *
 *		Then, you'll add code to the forms to 
 *		provide for these new classes.
 *
 *		1.	Create the GUI shown.
 *
 *		2.	Display the InventoryItem class and
 *			modify the GetDisplayText() method 
 *			so it's overridable.
 *
 *		3.	Add a class named Plant that inherits
 *			the InventoryItem class. This new class
 *			should add a string property named Size.
 *
 *			It should also provide both a default
 *			constructor and a constructor that 
 *			accepts four parameters to initialize
 *			the class properties.:
 *			-	item number
 *			-	description
 *			-	price
 *			-	size
 *
 *			This constructor should call the base
 *			class constructor to initialize the 
 *			properties defined by that class.
 *
 *			Finally, this class should override the
 *			GetDisplayText() method to add the size 
 *			in front of the description, as in this
 *			example:
 *
 *			3245649 1 gallon Agapanthus ($7.95)
 *
 *		4. 	Add another class named Supply that 
 *			inherits the InventoryItem class and 
 *			adds a string property named Manufacturer.
 *			Like the Plant class, the Supply class
 *			should provide a default constructor and
 *			a constructor that accepts four parameters,
 *			and it should override the GetDisplayText()
 *			method so the manufacturer is added in front
 *			of the description like this:
 *
 *			9210584 Ortho Snail pellets ($12.95)
 *
 *		5. 	Modify the event handler for the Click event
 *			of the Save button on the New Item form so it
 *			creates a new item of the appropriate type 
 *			using the data entered by the user.
 *
 *		6.	Modify the event handler for the Click event
 *			of the Add button on the Inventory Maintenance
 *			form so it displays a dialog indicating that
 *			the item has been added successfully, as shown
 *			above. The message should use the Size and 
 *			Description properties for a Plant object, and
 *			the Manufacturer and Description properties for
 *			a Supply object.
 *
 *		7.	Test the app by adding at least one of each 
 *			type of inventory item.
 */

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        private InvItemList invItems = new InvItemList();

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            invItems.Changed += new InvItemList.ChangeHandler(HandleChange);
            invItems.Fill();
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            InvItem item;
            lstItems.Items.Clear();
            for (int i = 0; i < invItems.Count; i++)
            {
                item = invItems[i];
                lstItems.Items.Add(item.GetDisplayText());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new frmNewItem();
            InvItem invItem = newItemForm.GetNewItem();
            if (invItem != null)
            {
                invItems += invItem;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                InvItem invItem = invItems[i];
                string message = "Are you sure you want to delete "
                    + invItem.Description + "?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    invItems -= invItem;
                }
            }
        }

        private void HandleChange(InvItemList invItems)
        {
            invItems.Save();
            FillItemListBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
