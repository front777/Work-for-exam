using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TouristAgencyApp
{
    public partial class addCustomerForm : Form
    {

        public Form1 mainForm;
        
        public addCustomerForm(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получение значений из текстовых полей
            int customerId = int.Parse(textBoxCustomerID.Text);
            string name = textBoxName.Text;
            string contactDetails = textBoxContactDetails.Text;
            string price = Price.Text;
            string paymentInformation = textBoxPaymentInformation.Text;

            // Создание нового клиента
            Customer newCustomer = new Customer()
            {
                CustomerID = customerId,
                Name = name,
                ContactDetails = contactDetails,
                Price = price,
                PaymentInformation = paymentInformation
            };

            // Добавление клиента на главную форму (Form1)
            mainForm.AddCustomer(newCustomer);

            // Сохранение данных в XML
            mainForm.SaveCustomersToXml();

            // Закрытие формы
            this.Close();
        }


       


    }
}
