using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
// Takuya Hasama, 30038637, 15.06.2021, Assessment Task 2
// a stand-alone application which will be used 
// in-house to keep track of all books and sales. 

namespace AT2Project
{
    public partial class MegaBooksForm : Form
    {
        //Rename the form1.cs file to “MegaBooksForm.cs”
        public MegaBooksForm()
        {
            InitializeComponent();
        }
        //The object Book Array, Array size of 20.
        private static int max = 20;
        Book[] myBookArray = new Book[max];
        int number_of_books = 0;

        //The object Customer Array, Array size of 20.   
        Customer[] myCustomerArray = new Customer[max];
        int number_of_customers = 0;

        //2D string array for transaction data
        string[,] myTransactionArray = new string[max, 3];
        int number_of_transactions = 0;

        #region Book
        //Book Add button method,
        //Verify the data type, create a book object, add to the array, and display in the listbox with hyphens between data items. Then, test Boxes should be cleared.
        private void btnBook_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAuthor.Text) &&
                !string.IsNullOrEmpty(txtTitle.Text) &&
                !string.IsNullOrEmpty(txtPublisher.Text) &&
                !string.IsNullOrEmpty(txtPrice.Text) &&
                !string.IsNullOrEmpty(txtDate.Text) &&
                 number_of_books < max)
            {
                Book addBook = new Book();

                addBook.gsIsbn = txtIsbn.Text;
                addBook.gsAuthor = txtAuthor.Text;
                addBook.gsTitle = txtTitle.Text;
                addBook.gsPublisher = txtPublisher.Text;
                addBook.gsPrice = double.Parse(txtPrice.Text);
                addBook.gsDate = txtDate.Text;
                myBookArray[number_of_books] = addBook;
                number_of_books++;
            }
            else
            {
                MessageBox.Show("Ensure all text boxes have data");
            }
            ClearBookTB();
            SortBooks();
            DisplayAllBooksList();
        }

        //Clear the textbox and Set the textbox into empty
        private void ClearBookTB()
        {
            txtIsbn.Clear();
            txtAuthor.Clear();
            txtTitle.Clear();
            txtPublisher.Clear();
            txtPrice.Clear();
            txtDate.Clear();
        }

        //Double click method,
        //Double click and all the input textboxes associated with the Book and allow a new book to be entered.
        private void txtIsbn_DoubleClick(object sender, EventArgs e)
        {
            ClearBookTB();
        }

        //ustom method to display the books from the array
        private void DisplayAllBooksList()
        {
            listBoxBook.Items.Clear();
            for (int i = 0; i < number_of_books; i++)
            {
                listBoxBook.Items.Add(myBookArray[i].DisplayBookDetails());
            }
        }

        //Avoid from filling char data into date 
        private void textBoxDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //Avoid from filling char data into price 
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //List click method,
        //When a record in the book listbox is clicked the book information is filled into the remaining book input text boxes,
        //and the appropriate information is also added to the textboxes under Transaction.
        private void listBoxBook_Click(object sender, EventArgs e)
        {
            ClearBookTB();
            if (listBoxBook.SelectedIndex != -1)
            {
                string curItem = listBoxBook.SelectedItem.ToString();
                int index = listBoxBook.FindString(curItem);
                listBoxBook.SetSelected(index, true);
                //put datas in each book text boxes
                txtIsbn.Text = myBookArray[index].gsIsbn;
                txtAuthor.Text = myBookArray[index].gsAuthor;
                txtTitle.Text = myBookArray[index].gsTitle;
                txtPublisher.Text = myBookArray[index].gsPublisher;
                txtPrice.Text = myBookArray[index].gsPrice.ToString();
                txtDate.Text = myBookArray[index].gsDate;
                //put datas in each transaction text boxes
                txtIsbnRead.Text = myBookArray[index].gsIsbn;
            }
            else
            {
                MessageBox.Show("Select book");
            }
        }

        //Load the book information from a binary file called books.
        private void BinaryLoadBookArray()
        {
            number_of_books = 0;
            try
            {
                using (Stream stream = File.Open("books.dat", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    while (stream.Position < stream.Length)
                    {
                        Book addBook = new Book();

                        string record = bin.Deserialize(stream).ToString();
                        string[] datas = record.Split(',');
                        addBook.gsIsbn = datas[0];
                        addBook.gsAuthor = datas[1];
                        addBook.gsTitle = datas[2];
                        addBook.gsPublisher = datas[3];
                        addBook.gsPrice = double.Parse(datas[4]);
                        addBook.gsDate = datas[5];
                        myBookArray[number_of_books] = addBook;
                        number_of_books++;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n can not open the file.");
                return;
            }
            DisplayAllBooksList();
        }

        //Save book data into binary file
        private void BinarySaveBookArray()
        {
            try
            {
                using (Stream stream = File.Open("books.dat", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    for (int i = 0; i < number_of_books; i++)
                    {
                        string record = myBookArray[i].saveBooks();
                        bin.Serialize(stream, record);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n can not create the file.");
                return;
            }
        }

        //Sort method(Simple bubble sort),
        //Sort the array by Title in ascending order. 
        private void SortBooks()
        {
            bool flag;
            do
            {
                flag = false;
                for (int i = 0; i < number_of_books - 1; i++)
                {
                    if (string.Compare(myBookArray[i].gsTitle, myBookArray[i + 1].gsTitle) > 0)
                    {
                        SwapBook(ref myBookArray, i);
                        flag = true;
                    }
                    DisplayAllBooksList();
                }
            } while (flag);
        }
        //Swap method,
        //Swap two objects and give them back to SortBooks
        private void SwapBook(ref Book[] myBookArray, int j)
        {
            Book ptr = myBookArray[j];
            myBookArray[j] = myBookArray[j + 1];
            myBookArray[j + 1] = ptr;
        }
        #endregion Book

        #region Customer

        //Customer Add button method,
        //Verify the data type, create a customer object, add to the array, and display in the listbox with hyphens between data items. Then, test Boxes should be cleared. 
        //If information is not present then a dialog popup is generated with a request to generate a default customer using a yes/no option,
        //If no details are provided, they can be grouped as a single unknown customer with an ID of "C999". The other fields can be filled with “unknown”.
        private void btnCus_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            Customer addCustomer = new Customer();
            {
                if (!string.IsNullOrEmpty(txtCustId.Text) &&
                    !string.IsNullOrEmpty(txtName.Text) &&
                    !string.IsNullOrEmpty(txtCity.Text) &&
                    !string.IsNullOrEmpty(txtMail.Text) &&

                     number_of_customers < max)
                {

                    addCustomer.gsCustId = txtCustId.Text;
                    addCustomer.gsFullName = txtName.Text;
                    addCustomer.gsCity = txtCity.Text;
                    addCustomer.gsEmail = txtMail.Text;
                    myCustomerArray[number_of_customers] = addCustomer;
                    number_of_customers++;
                }
                else
                {
                    result = MessageBox.Show("Customer data is not correct, you want to add default customer?", "Notice", MessageBoxButtons.YesNo);
                }
                if (result == DialogResult.Yes)
                {
                    addCustomer.gsCustId = "C999";
                    addCustomer.gsFullName = "unknown";
                    addCustomer.gsCity = "unknown";
                    addCustomer.gsEmail = "unknown";
                    myCustomerArray[number_of_customers] = addCustomer;
                    number_of_customers++;
                }
                ClearCustomerTB();
                DisplayAllCustomersList();
            }
        }

        //Clear the textbox and Set the textbox into empty
        private void ClearCustomerTB()
        {
            txtCustId.Clear();
            txtName.Clear();
            txtCity.Clear();
            txtMail.Clear();
        }

        //Custom method to display the books from the array
        private void DisplayAllCustomersList()
        {
            listBoxCust.Items.Clear();
            for (int i = 0; i < number_of_customers; i++)
            {
                listBoxCust.Items.Add(myCustomerArray[i].DisplayCustomerDetails());
            }
        }

        //Double click method,
        //Double click and all the input textboxes associated with the Book and allow a new book to be entered.
        private void txtCustId_DoubleClick(object sender, EventArgs e)
        {
            ClearCustomerTB();
        }

        //List click method,
        //When a record in the customer listbox is clicked the customer information is filled into the remaining customer input text boxes,
        //and the appropriate information is also added to the textboxes under Transaction.
        public void listBoxCust_Click(object sender, EventArgs e)
        {
            ClearCustomerTB();
            if (listBoxCust.SelectedIndex != -1)
            {
                string curItem = listBoxCust.SelectedItem.ToString();
                int index = listBoxCust.FindString(curItem);
                listBoxCust.SetSelected(index, true);
                //put datas in each customer text boxes
                txtCustId.Text = myCustomerArray[index].gsCustId;
                txtName.Text = myCustomerArray[index].gsFullName;
                txtCity.Text = myCustomerArray[index].gsCity;
                txtMail.Text = myCustomerArray[index].gsEmail;
                //put datas in each transaction text boxes
                txtCustIdRead.Text = myCustomerArray[index].gsCustId;
            }
            else
            {
                MessageBox.Show("Select customer");
            }
        }

        //Load the customer information from a binary file called customers.dat 
        private void BinaryLoadCustomerArray()
        {
            number_of_customers = 0;
            try
            {
                using (Stream stream = File.Open("customers.dat", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    while (stream.Position < stream.Length)
                    {
                        Customer addCustomer = new Customer();

                        string record = bin.Deserialize(stream).ToString();
                        string[] datas = record.Split(',');
                        addCustomer.gsCustId = datas[0];
                        addCustomer.gsFullName = datas[1];
                        addCustomer.gsCity = datas[2];
                        addCustomer.gsEmail = datas[3];
                        myCustomerArray[number_of_customers] = addCustomer;
                        number_of_customers++;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n can not open the file.");
                return;
            }
            DisplayAllCustomersList();
        }

        //Save customer data into binary file
        private void BinarySaveCustmerArray()
        {
            try
            {
                using (Stream stream = File.Open("customers.dat", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    for (int i = 0; i < number_of_customers; i++)
                    {
                        string record = myCustomerArray[i].saveCustomers();
                        bin.Serialize(stream, record);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n can not create the file.");
                return;
            }
        }

        //Search right click method,
        //Enter text into the custID input textbox, right clicks, push a search button, and display the data in the listbox.
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool found = false;
            if (!string.IsNullOrEmpty(txtCustId.Text))
            {
                for (int i = 0; i < number_of_customers; i++)
                {
                    if (string.Compare(myCustomerArray[i].gsCustId, txtCustId.Text) == 0)
                    {
                        txtName.Text = myCustomerArray[i].gsFullName;
                        txtCity.Text = myCustomerArray[i].gsCity;
                        txtMail.Text = myCustomerArray[i].gsEmail;
                        found = true;
                        break;
                    }
                    else
                    {
                        found = false;
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("Not found");
                    txtCustId.Clear();
                }
            }
            else
            {
                MessageBox.Show("Empty");
                txtCustId.Clear();
            }        
        }

        #endregion Customer
        #region Transaction

        //Transaction Add button method,
        //Verify the data type, create a  object, add to the 2D array, and display in the listbox with delimiter between data items. Then, test Boxes should be cleared.
        private void btnTrans_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTransId.Text) &&
                !string.IsNullOrEmpty(txtCustId.Text) &&
                !string.IsNullOrEmpty(txtIsbn.Text) &&
                 number_of_transactions < max)
            {
                myTransactionArray[number_of_transactions, 0] = txtTransId.Text;
                myTransactionArray[number_of_transactions, 1] = txtCustId.Text;
                myTransactionArray[number_of_transactions, 2] = txtIsbn.Text;
                number_of_transactions++;
            }
            else
            {
                MessageBox.Show("Ensure all text boxes have data");
            }
            ClearTransTB();
            DisplayAllTransactionList();
        }

        //Custom method to display the transactions from the 2D array
        private void DisplayAllTransactionList()
        {
            listBoxTrans.Items.Clear();
            for (int x = 0; x < number_of_transactions; x++)
            {
                string oneRecord = myTransactionArray[x, 0] + " | " +
                     myTransactionArray[x, 1] + " | " +
                     myTransactionArray[x, 2];
                listBoxTrans.Items.Add(oneRecord);
            }
        }

        //Clear the textbox and Set the textbox into empty
        private void ClearTransTB()
        {
            txtTransId.Clear();
            txtCustIdRead.Clear();
            txtIsbnRead.Clear();
        }

        //Double click method,
        //Double click and all the input textboxes associated with the transaction and allow a new transaction to be entered.
        private void txtTransId_DoubleClick(object sender, EventArgs e)
        {
            ClearTransTB();
        }

        //List click method,
        //When a record in the transaction listbox is clicked the transaction information is filled into the remaining transaction input text boxes,
        //and the appropriate Book and Customer records are automatically selected in the listboxes.
        private void listBoxTrans_Click(object sender, EventArgs e)
        {
            if (listBoxTrans.SelectedIndex != -1)
            {
                string curItem = listBoxTrans.SelectedItem.ToString();
                int index = listBoxTrans.FindString(curItem);
                listBoxTrans.SetSelected(index, true);
                //put datas in each transaction text boxes
                txtTransId.Text = myTransactionArray[index, 0];
                txtCustIdRead.Text = myTransactionArray[index, 1];
                txtIsbnRead.Text = myTransactionArray[index, 2];
                //put datas in each customer text boxes
                int indexCustId = listBoxCust.FindString(txtCustIdRead.Text);
                listBoxCust.SetSelected(indexCustId, true);
                txtCustId.Text = myCustomerArray[indexCustId].gsCustId;
                txtName.Text = myCustomerArray[indexCustId].gsFullName;
                txtCity.Text = myCustomerArray[indexCustId].gsCity;
                txtMail.Text = myCustomerArray[indexCustId].gsEmail;
                //put datas in each book text boxes
                int indexIsbn = listBoxBook.FindString(txtIsbnRead.Text);
                listBoxBook.SetSelected(indexIsbn, true);
                txtIsbn.Text = myBookArray[indexIsbn].gsIsbn;
                txtAuthor.Text = myBookArray[index].gsAuthor;
                txtTitle.Text = myBookArray[indexIsbn].gsTitle;
                txtPublisher.Text = myBookArray[indexIsbn].gsPublisher;
                txtPrice.Text = myBookArray[indexIsbn].gsPrice.ToString();
                txtDate.Text = myBookArray[indexIsbn].gsDate;
            }
            else
            {
                MessageBox.Show("Select transaction");
            }
        }

        //Load the transaction information from a binary file called transactions.dat 
        private void BinaryLoadTransactionArray()
        {
            number_of_transactions = 0;
            try
            {
                using (Stream stream = File.Open("transactions.dat", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    while (stream.Position < stream.Length)
                    {
                        string record = bin.Deserialize(stream).ToString();
                        string[] datas = record.Split(',');
                        for (int i = 0; i < 3; i++)
                            myTransactionArray[number_of_transactions, i] = datas[i];
                        number_of_transactions++;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n can not open the file.");
                return;
            }
            DisplayAllTransactionList();
        }

        //Save transaction data into binary file
        private void BinarySaveTransactionArray()
        {
            try
            {
                using (Stream stream = File.Open("transactions.dat", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    for (int i = 0; i < number_of_transactions; i++)
                    {
                        string record = myTransactionArray[i, 0] + "," +
                            myTransactionArray[i, 1] + "," +
                            myTransactionArray[i, 2] + ",";
                        bin.Serialize(stream, record);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n can not create the file.");
                return;
            }
        }
        #endregion Transaction

        //Save all data into three binary files when the form closes. 
        private void MegaBooksForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinarySaveBookArray();
            BinarySaveCustmerArray();
            BinarySaveTransactionArray();
        }

        //Load data from binary file into array
        private void MegaBooksForm_Load(object sender, EventArgs e)
        {
            BinaryLoadBookArray();
            BinaryLoadCustomerArray();
            BinaryLoadTransactionArray();
        }
    }
}




