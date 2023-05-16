using System;
using System.CodeDom;
using System.Windows.Forms;

namespace MegaDesk
{
    partial class AddQuote
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
        ///
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.drawersInput = new System.Windows.Forms.TextBox();
            this.surfaceInput = new System.Windows.Forms.ComboBox();
            this.errorWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.submitButton = new System.Windows.Forms.Button();
            this.rushOrderInput = new System.Windows.Forms.ComboBox();
            this.customerName = new System.Windows.Forms.TextBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desk Size Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desk Size Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(113, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Surface Material";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rush Order";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(462, 130);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(143, 20);
            this.widthTextBox.TabIndex = 10;
            this.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.widthTextBox_Validating);
            this.widthTextBox.Validated += new System.EventHandler(this.widthTextBox_Validated);
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(462, 177);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(143, 20);
            this.depthTextBox.TabIndex = 11;
            this.depthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.depthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.depthTextBox_Validating);
            this.depthTextBox.Validated += new System.EventHandler(this.depthTextBox_Validated);
            // 
            // drawersInput
            // 
            this.drawersInput.Location = new System.Drawing.Point(462, 227);
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(143, 20);
            this.drawersInput.TabIndex = 12;
            this.drawersInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.drawersInput.Validating += new System.ComponentModel.CancelEventHandler(this.drawersInput_Validating);
            this.drawersInput.Validated += new System.EventHandler(this.drawersInput_Validated);
            // 
            // surfaceInput
            // 
            this.surfaceInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfaceInput.FormattingEnabled = true;
            this.surfaceInput.Location = new System.Drawing.Point(462, 278);
            this.surfaceInput.Name = "surfaceInput";
            this.surfaceInput.Size = new System.Drawing.Size(143, 21);
            this.surfaceInput.TabIndex = 13;
            this.surfaceInput.Click += new System.EventHandler(this.AddQuote_Load);
            // 
            // errorWidth
            // 
            this.errorWidth.ContainerControl = this;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(265, 373);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(149, 48);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // rushOrderInput
            // 
            this.rushOrderInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rushOrderInput.FormattingEnabled = true;
            this.rushOrderInput.Location = new System.Drawing.Point(462, 326);
            this.rushOrderInput.Name = "rushOrderInput";
            this.rushOrderInput.Size = new System.Drawing.Size(143, 21);
            this.rushOrderInput.TabIndex = 16;
            this.rushOrderInput.SelectedIndexChanged += new System.EventHandler(this.rushOrderInput_SelectedIndexChanged);
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(462, 88);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(143, 20);
            this.customerName.TabIndex = 9;
            this.customerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customerName.TextChanged += new System.EventHandler(this.customerName_TextChanged);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.Salmon;
            this.warningLabel.Location = new System.Drawing.Point(285, 42);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 18;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 444);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.rushOrderInput);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.surfaceInput);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.errorWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Label label7;


      


        private TextBox widthTextBox;
        private TextBox depthTextBox;
        private TextBox drawersInput;
        private ComboBox surfaceInput;
        private ErrorProvider errorWidth;
        private Button submitButton;
        private ComboBox rushOrderInput;
        private TextBox customerName;
        private Label warningLabel;
        private Timer timer1;
    }
}