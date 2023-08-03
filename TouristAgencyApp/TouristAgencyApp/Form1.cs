using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace TouristAgencyApp
{
    public partial class Form1 : Form
    {

        public List<Customer> customers;
      

        public Form1()
        {

            customers = new List<Customer>();
            InitializeComponent();
            LoadCustomersFromXml();
            PopulateListBox();
      

        }
      

        private void LoadCustomersFromXml()
        {
            string xamlStr = @"C:\Users\артур данжен\Documents\Visual Studio 2022\c#\TouristAgencyApp\TouristAgencyApp\database\customers.xml";

            XDocument doc = XDocument.Load(xamlStr);
            foreach (XElement customerElement in doc.Root.Elements("Customer"))
            {
                Customer customer = new Customer();

                customer.CustomerID = int.Parse(customerElement.Element("CustomerID").Value);
                customer.Name = customerElement.Element("Name").Value;
                customer.ContactDetails = customerElement.Element("ContactDetails").Value;

                customer.PaymentInformation = customerElement.Element("PaymentInformation").Value;
                /*customer.Price = customerElement.Element("Price").Value;*/

                foreach (XElement bookingElement in customerElement.Element("BookingHistory").Elements("Booking"))
                {
                    Booking booking = new Booking();

                    booking.BookingID = int.Parse(bookingElement.Element("BookingID").Value);
                    booking.CustomerID = int.Parse(bookingElement.Element("CustomerID").Value);

                    /*booking.Price = int.Parse(bookingElement.Element("Price").Value);*/
                    booking.Status = bookingElement.Element("Status").Value;

                    customer.BookingHistory.Add(booking);
                }

                customers.Add(customer);
            }
        }

        private void PopulateListBox()
        {
            foreach (Customer customer in customers)
            {
                string customerInfo = $"Customer ID: {customer.CustomerID}, Name: {customer.Name}, Trip: {customer.PaymentInformation}, Price: {customer.Price}";

                customerListBox.Items.Add(customerInfo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            var addCustomerForm = new addCustomerForm(this);
            addCustomerForm.ShowDialog();
          
        }

     
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
            PopulateListBox();
        }

        public void SaveCustomersToXml()
        {
            string xmlFilePath = @"C:\Users\артур данжен\Documents\Visual Studio 2022\c#\TouristAgencyApp\TouristAgencyApp\database\customers.xml";

            XElement customersElement = new XElement("Customers");

            foreach (Customer customer in customers)
            {
                XElement customerElement = new XElement("Customer",
                    new XElement("CustomerID", customer.CustomerID),
                    new XElement("Name", customer.Name),
                    new XElement("ContactDetails", customer.ContactDetails),
              
                    new XElement("PaymentInformation", customer.PaymentInformation)
                );

                XElement bookingHistoryElement = new XElement("BookingHistory");

                foreach (Booking booking in customer.BookingHistory)
                {
                    XElement bookingElement = new XElement("Booking",
                        new XElement("BookingID", booking.BookingID),
                        new XElement("CustomerID", booking.CustomerID),
                     
                      
                        new XElement("Status", booking.Status)
                    );

                    bookingHistoryElement.Add(bookingElement);
                }

                customerElement.Add(bookingHistoryElement);
                customersElement.Add(customerElement);
            }

            XDocument doc = new XDocument(customersElement);
            doc.Save(xmlFilePath);
        }

       


        private void button2_Click(object sender, EventArgs e)
        {
            
            if (customerListBox.SelectedItem != null)
            {
                int selectedIndex = customerListBox.SelectedIndex;
                customerListBox.SelectedIndex = selectedIndex;
                customerListBox.Items.Remove(customerListBox.SelectedItem);

                // Удаление клиента из списка формы Form1 и обновление ListBox
                customers.RemoveAt(selectedIndex);
                PopulateListBox();

                // Сохранение данных в XML-файл
                SaveCustomersToXml();
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var d = new Documentation();
            d.Show();
        }
    }
}
   

  

   

     
    



    












