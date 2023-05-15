namespace MegaDesk
{
    partial class SearchQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.ComboBox();
            this.deskQuotesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Quotes";
            // 
            // searchBox
            // 
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Location = new System.Drawing.Point(208, 152);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(196, 21);
            this.searchBox.TabIndex = 1;
            this.searchBox.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deskQuotesListBox
            // 
            this.deskQuotesListBox.FormattingEnabled = true;
            this.deskQuotesListBox.Location = new System.Drawing.Point(49, 192);
            this.deskQuotesListBox.Name = "deskQuotesListBox";
            this.deskQuotesListBox.Size = new System.Drawing.Size(484, 212);
            this.deskQuotesListBox.TabIndex = 2;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 454);
            this.Controls.Add(this.deskQuotesListBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox searchBox;
        private System.Windows.Forms.ListBox deskQuotesListBox;
    }
}