using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Murach.Inventory;

/*
 *		Extra 16-2 Create and use a class library
 *		=========================================
 *
 *		In this exercise, you'll create a class library
 *		that includes the InventoryItem and InventoryDB
 *		classes. Then, use that class library with the 
 *		Inventory Maintenance app.
 *
 *		Create the Class Library project
 *
 *
 *		1.	Create a new Class Library project named
 *			InventoryLibrary.
 *
 *		2. 	Delete the empty Class1.cs class, and add
 *			the InventoryItem and InventoryDB classes 
 *			from the Inventory Maintenance project in
 *			the same directory.
 *
 *		3. 	Change the namespace in both of the classes
 *			you just added so it's a namespace named 
 *			Inventory nested within a namespace with 
 *			your last name.
 *
 *		4. 	Generate a file that will allow any XML 
 *			documentation in the class library to be 
 *			visible to any code that uses the library.
 *
 *		5. 	Change the solution configuration for the
 *			class library to Release, and then build 
 *			the class library. When you’re done, close 
 *			the solution. Modify the Inventory Maintenance
 *			app to use the library
 *
 *		6. 	Open the InventoryMaintenance project in the
 *			ExtraStarts\Ch16\ InventoryMaintenanceLib
 *			directory.
 *
 *		7. 	Delete the InventoryItem.cs and InventoryDB.cs
 *			files, and then add a reference to the 
 *			InventoryLibrary assembly created in step 4.
 *
 *		8. 	Display the code for the Inventory Maintenance
 *			form, and add a using directive for the namespace
 *			you created in step 3. Do the same for the New
 *			Item form.
 *
 *		9. 	Test the app to be sure it still works.
 *
 *		Bonus
 *
 *		10. Move the Validator class to a class library
 *			and update the Inventory Maintenance app to
 *			use it.
 */

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        private List<InvItem> invItems = null;

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            invItems = InvItemDB.GetItems();
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            foreach (InvItem item in invItems)
            {
                lstItems.Items.Add(item.GetDisplayText());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new frmNewItem();
            InvItem invItem = newItemForm.GetNewItem();
            if (invItem != null)
            {
                invItems.Add(invItem);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                InvItem invItem = (InvItem)invItems[i];
                string message = $"Are you sure you want to delete {invItem.Description}?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    invItems.Remove(invItem);
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
