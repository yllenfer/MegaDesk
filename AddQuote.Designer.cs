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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.deskSizeInput = new System.Windows.Forms.TextBox();
            this.depthInput = new System.Windows.Forms.TextBox();
            this.drawersInput = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desk Size Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desk Size Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Surface Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(326, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ylle Fernandez";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rush Order";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(76, 44);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.goback_Click);
            // 
            // deskSizeInput
            // 
            this.deskSizeInput.Location = new System.Drawing.Point(331, 133);
            this.deskSizeInput.Name = "deskSizeInput";
            this.deskSizeInput.Size = new System.Drawing.Size(100, 20);
            this.deskSizeInput.TabIndex = 10;
            this.deskSizeInput.Click += new System.EventHandler(this.deskSizeInput_TextChanged);
            // 
            // depthInput
            // 
            this.depthInput.Location = new System.Drawing.Point(331, 180);
            this.depthInput.Name = "depthInput";
            this.depthInput.Size = new System.Drawing.Size(100, 20);
            this.depthInput.TabIndex = 11;
            this.depthInput.Click += new System.EventHandler(this.deskDepthInput_TextChanged);
            // 
            // drawersInput
            // 
            this.drawersInput.Location = new System.Drawing.Point(331, 230);
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(100, 20);
            this.drawersInput.TabIndex = 12;
            this.drawersInput.Click += new System.EventHandler(this.deskDrawers_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(331, 281);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Click += new System.EventHandler(this.AddQuote_Load);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(331, 330);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 423);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.depthInput);
            this.Controls.Add(this.deskSizeInput);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button backButton;


        private void deskSizeInput_TextChanged(object sender, EventArgs e)
        {
            int size;
            if (int.TryParse(deskSizeInput.Text, out size))
            {
                if (Width < Desk.MINWIDTH || Width > Desk.MAXWIDTH)
                {
                    deskSizeInput.Text = String.Empty;
                    deskSizeInput.Focus();
                    MessageBox.Show("Hello, Width must between 24 and 96 inches");
                }
            }
        }


        private void deskDepthInput_TextChanged(object sender, EventArgs e)
        {
            int size;
            if (int.TryParse(depthInput.Text, out size))
            {
                if (Width < Desk.MINDEPTH || Width > Desk.MAXDEPTH)
                {
                    depthInput.Text = String.Empty;
                    depthInput.Focus();
                    MessageBox.Show("Hello, Depth must between 12 and 48 inches");
                }
            }
        }


        private void deskMaterialInput_TextChanged(object sender, EventArgs e)
        {
            int size;
            if (int.TryParse(depthInput.Text, out size))
            {
                if (Width < Desk.MINDEPTH || Width > Desk.MAXDEPTH)
                {
                    depthInput.Text = String.Empty;
                    depthInput.Focus();
                    MessageBox.Show("Hello, Depth must between 12 and 48 inches");
                }
            }
        }


        private void AddQuote_Load(object sender, EventArgs e)
        {
            string[] materials = Enum.GetNames(typeof(Desk.SurfaceMaterial));
            comboBox1.Items.AddRange(materials);
            //comboBox1.SelectedIndex = 0;
            //TODO: There's an error here
        }


     





        private void deskDrawers_TextChanged(object sender, EventArgs e)
        {
            int size;
            if (int.TryParse(depthInput.Text, out size))
            {
                if (Width < Desk.MINDRAWERS || Width > Desk.MAXDRAWERS)
                {
                    depthInput.Text = String.Empty;
                    depthInput.Focus();
                    MessageBox.Show("Hello, Drawers must between 0 and 7 inches");
                }
            }
        }





        private void goback_Click(object sender, EventArgs e)
        {
            
            Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show(this);
        }
        private TextBox deskSizeInput;
        private TextBox depthInput;
        private TextBox drawersInput;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private ErrorProvider errorProvider1;
    }
}