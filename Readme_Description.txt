//READ ME for basic POS System

-The Base Class Orders is used to store Items from the derived classes of breakfast and dinner(dinner class also contains lunch items)



//MAIN WINDOW
-Place Order Button(directs user to meal type window)
-Recent Order button(directs user to recent order window)

//Meal Type Window
-Breakfast Button(directs user to breakfast menu)
-Lunch/Dinner Buttons(directs user to lunch/dinner menu)
-Finish ordering Redirects backto MAIN WINDOW

//Meal menu windows(share similar functions)
-Breakfast window will only open if it is breakfast time(earlier than 1030am)
-Dinner window will open if it is Lunch/Dinner time(1030am or later)
-item buttons once clicked will place the item into orderBox
-items are temporarily stored into ordersList
-items can be selected in order box and when you hit delete will remove item from box and list.
-certain items require specification about the order, example Crepes require that the type of 
crepe be entered into notes box, if notesBox is empty a message box with error will come up
-when order is done and done button is pressed a receipt will be generated in the textBlock, the 
text block will then be sent to a printDialog.  At the same time the list is written to a .txt file with its orderNumber
	-orderNumber is calculated by counting the number of .txt files in the Orders file found in /wpfApp4/bin/debug/Assets/Orders
-when the receipt is generated it calculated the subTotal, Tax, and Total of the order in OrdersList

//Recent Orders Window
-Program reads in all the Orders from the Order file into seperate listBoxItems to keep them seperate.  For easier viewing of a large receipt
User can double click on of the orders in recentOrders and it will be brought up in its own listBox and listboxitem
-this window is simply for viewing orders, no deletions can be made here, to delete from recent orders user must manually delete .txt files, although this will cause orderNumber to be wrong

//usability
-low contrast menu for little eye strain.
-all windows open centered on screen. attempted to have a mainwindow that held all other windows so they were more localized but could not get this complete.