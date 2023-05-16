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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Quotes";
            // 
            // searchBox
            // 
            this.searchBox.FormattingEnabled = true;
            this.searchBox.Location = new System.Drawing.Point(548, 362);
            this.searchBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(516, 39);
            this.searchBox.TabIndex = 1;
            this.searchBox.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deskQuotesListBox
            // 
            this.deskQuotesListBox.FormattingEnabled = true;
            this.deskQuotesListBox.ItemHeight = 31;
            this.deskQuotesListBox.Location = new System.Drawing.Point(307, 489);
            this.deskQuotesListBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.deskQuotesListBox.Name = "deskQuotesListBox";
            this.deskQuotesListBox.Size = new System.Drawing.Size(967, 469);
            this.deskQuotesListBox.TabIndex = 2;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 1083);
            this.Controls.Add(this.deskQuotesListBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SearchQuotes";
            this.Text = "Search Quotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}