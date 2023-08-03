namespace TouristAgencyApp
{
    partial class addCustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.RichTextBox();
            this.textBoxContactDetails = new System.Windows.Forms.RichTextBox();
            this.textBoxPaymentInformation = new System.Windows.Forms.RichTextBox();
            this.textBoxCustomerID = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Price = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(0, 0);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(490, 42);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Name";
            // 
            // textBoxContactDetails
            // 
            this.textBoxContactDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxContactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxContactDetails.Location = new System.Drawing.Point(0, 42);
            this.textBoxContactDetails.Name = "textBoxContactDetails";
            this.textBoxContactDetails.Size = new System.Drawing.Size(490, 42);
            this.textBoxContactDetails.TabIndex = 1;
            this.textBoxContactDetails.Text = "Contacts";
            // 
            // textBoxPaymentInformation
            // 
            this.textBoxPaymentInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPaymentInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPaymentInformation.Location = new System.Drawing.Point(0, 84);
            this.textBoxPaymentInformation.Name = "textBoxPaymentInformation";
            this.textBoxPaymentInformation.Size = new System.Drawing.Size(490, 42);
            this.textBoxPaymentInformation.TabIndex = 2;
            this.textBoxPaymentInformation.Text = "Trip";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCustomerID.Location = new System.Drawing.Point(0, 126);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(490, 46);
            this.textBoxCustomerID.TabIndex = 4;
            this.textBoxCustomerID.Text = "ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(113, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Price
            // 
            this.Price.Dock = System.Windows.Forms.DockStyle.Top;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(0, 172);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(490, 46);
            this.Price.TabIndex = 7;
            this.Price.Text = "Price";
            // 
            // addCustomerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(490, 313);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.textBoxPaymentInformation);
            this.Controls.Add(this.textBoxContactDetails);
            this.Controls.Add(this.textBoxName);
            this.Name = "addCustomerForm";
            this.Text = "addCustomerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxName;
        private System.Windows.Forms.RichTextBox textBoxContactDetails;
        private System.Windows.Forms.RichTextBox textBoxPaymentInformation;
        private System.Windows.Forms.RichTextBox textBoxCustomerID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox Price;
    }
}