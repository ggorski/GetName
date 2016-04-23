namespace GetData
{
    partial class Result
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelNavButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.tableLayoutPanelData = new System.Windows.Forms.TableLayoutPanel();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelPhoneNumberResult = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelFirstNameResult = new System.Windows.Forms.Label();
            this.labelLastNameResult = new System.Windows.Forms.Label();
            this.labelAddressResult = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.flowLayoutPanelNavButtons.SuspendLayout();
            this.tableLayoutPanelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelNavButtons, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelData, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(354, 191);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // flowLayoutPanelNavButtons
            // 
            this.flowLayoutPanelNavButtons.Controls.Add(this.buttonNext);
            this.flowLayoutPanelNavButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelNavButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelNavButtons.Location = new System.Drawing.Point(3, 159);
            this.flowLayoutPanelNavButtons.Name = "flowLayoutPanelNavButtons";
            this.flowLayoutPanelNavButtons.Size = new System.Drawing.Size(348, 29);
            this.flowLayoutPanelNavButtons.TabIndex = 0;
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonNext.Location = new System.Drawing.Point(270, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Close";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tableLayoutPanelData
            // 
            this.tableLayoutPanelData.ColumnCount = 2;
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelData.Controls.Add(this.labelPhoneNumber, 0, 3);
            this.tableLayoutPanelData.Controls.Add(this.labelPhoneNumberResult, 0, 3);
            this.tableLayoutPanelData.Controls.Add(this.labelFirstName, 0, 0);
            this.tableLayoutPanelData.Controls.Add(this.labelLastName, 0, 1);
            this.tableLayoutPanelData.Controls.Add(this.labelAddress, 0, 2);
            this.tableLayoutPanelData.Controls.Add(this.labelFirstNameResult, 1, 0);
            this.tableLayoutPanelData.Controls.Add(this.labelLastNameResult, 1, 1);
            this.tableLayoutPanelData.Controls.Add(this.labelAddressResult, 1, 2);
            this.tableLayoutPanelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelData.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelData.Name = "tableLayoutPanelData";
            this.tableLayoutPanelData.RowCount = 4;
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelData.Size = new System.Drawing.Size(348, 150);
            this.tableLayoutPanelData.TabIndex = 1;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(3, 124);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.labelPhoneNumber.TabIndex = 8;
            this.labelPhoneNumber.Text = "Phone number:";
            this.labelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPhoneNumberResult
            // 
            this.labelPhoneNumberResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhoneNumberResult.AutoSize = true;
            this.labelPhoneNumberResult.Location = new System.Drawing.Point(90, 124);
            this.labelPhoneNumberResult.Name = "labelPhoneNumberResult";
            this.labelPhoneNumberResult.Size = new System.Drawing.Size(255, 13);
            this.labelPhoneNumberResult.TabIndex = 7;
            this.labelPhoneNumberResult.Text = "Phone number:";
            this.labelPhoneNumberResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(3, 12);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(81, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(3, 49);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(81, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(3, 86);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(81, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address:";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFirstNameResult
            // 
            this.labelFirstNameResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFirstNameResult.AutoSize = true;
            this.labelFirstNameResult.Location = new System.Drawing.Point(90, 12);
            this.labelFirstNameResult.Name = "labelFirstNameResult";
            this.labelFirstNameResult.Size = new System.Drawing.Size(255, 13);
            this.labelFirstNameResult.TabIndex = 4;
            this.labelFirstNameResult.Text = "First name:";
            this.labelFirstNameResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLastNameResult
            // 
            this.labelLastNameResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastNameResult.AutoSize = true;
            this.labelLastNameResult.Location = new System.Drawing.Point(90, 49);
            this.labelLastNameResult.Name = "labelLastNameResult";
            this.labelLastNameResult.Size = new System.Drawing.Size(255, 13);
            this.labelLastNameResult.TabIndex = 5;
            this.labelLastNameResult.Text = "Last name:";
            this.labelLastNameResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAddressResult
            // 
            this.labelAddressResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddressResult.AutoSize = true;
            this.labelAddressResult.Location = new System.Drawing.Point(90, 86);
            this.labelAddressResult.Name = "labelAddressResult";
            this.labelAddressResult.Size = new System.Drawing.Size(255, 13);
            this.labelAddressResult.TabIndex = 6;
            this.labelAddressResult.Text = "Address:";
            this.labelAddressResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 191);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.MaximumSize = new System.Drawing.Size(450, 250);
            this.MinimumSize = new System.Drawing.Size(370, 200);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.flowLayoutPanelNavButtons.ResumeLayout(false);
            this.tableLayoutPanelData.ResumeLayout(false);
            this.tableLayoutPanelData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNavButtons;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelData;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumberResult;
        private System.Windows.Forms.Label labelFirstNameResult;
        private System.Windows.Forms.Label labelLastNameResult;
        private System.Windows.Forms.Label labelAddressResult;
    }
}