namespace FormUI
{
    partial class Dashboard
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
            //this.components = new System.ComponentModel.Container();
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(800, 450);
            //this.Text = "Dashboard";

            this.headerLabel = new System.Windows.Forms.Label();
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.allPeopleLabel = new System.Windows.Forms.Label();
            this.yearsLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.filteredLabel = new System.Windows.Forms.Label();
            this.peopleComboBox = new System.Windows.Forms.ComboBox();
            this.yearsExperiencePicker = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.yearsExperiencePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(27, 24);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(175, 29);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Linq 101 Demo";
            // 
            // peopleListBox
            // 
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.ItemHeight = 16;
            this.peopleListBox.Location = new System.Drawing.Point(502, 92);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(231, 260);
            this.peopleListBox.TabIndex = 1;
            // 
            // allPeopleLabel
            // 
            this.allPeopleLabel.AutoSize = true;
            this.allPeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPeopleLabel.Location = new System.Drawing.Point(32, 72);
            this.allPeopleLabel.Name = "allPeopleLabel";
            this.allPeopleLabel.Size = new System.Drawing.Size(84, 20);
            this.allPeopleLabel.TabIndex = 3;
            this.allPeopleLabel.Text = "All People";
            // 
            // yearsLabel
            // 
            this.yearsLabel.AutoSize = true;
            this.yearsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsLabel.Location = new System.Drawing.Point(32, 224);
            this.yearsLabel.Name = "yearsLabel";
            this.yearsLabel.Size = new System.Drawing.Size(140, 20);
            this.yearsLabel.TabIndex = 4;
            this.yearsLabel.Text = "Years Experience";
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(117, 353);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(137, 47);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.update_button_Click);
            // 
            // filteredLabel
            // 
            this.filteredLabel.AutoSize = true;
            this.filteredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filteredLabel.Location = new System.Drawing.Point(498, 45);
            this.filteredLabel.Name = "filteredLabel";
            this.filteredLabel.Size = new System.Drawing.Size(98, 20);
            this.filteredLabel.TabIndex = 7;
            this.filteredLabel.Text = "Filtered List";
            // 
            // peopleComboBox
            // 
            this.peopleComboBox.FormattingEnabled = true;
            this.peopleComboBox.Location = new System.Drawing.Point(36, 116);
            this.peopleComboBox.Name = "peopleComboBox";
            this.peopleComboBox.Size = new System.Drawing.Size(202, 24);
            this.peopleComboBox.TabIndex = 2;
            this.peopleComboBox.SelectedIndexChanged += new System.EventHandler(this.peopleComboBox_SelectedIndexChanged);
            // 
            // yearsExperiencePicker
            // 
            this.yearsExperiencePicker.Location = new System.Drawing.Point(36, 283);
            this.yearsExperiencePicker.Name = "yearsExperiencePicker";
            this.yearsExperiencePicker.Size = new System.Drawing.Size(120, 22);
            this.yearsExperiencePicker.TabIndex = 8;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yearsExperiencePicker);
            this.Controls.Add(this.filteredLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.yearsLabel);
            this.Controls.Add(this.allPeopleLabel);
            this.Controls.Add(this.peopleComboBox);
            this.Controls.Add(this.peopleListBox);
            this.Controls.Add(this.headerLabel);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.yearsExperiencePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ListBox peopleListBox;
        private System.Windows.Forms.Label allPeopleLabel;
        private System.Windows.Forms.Label yearsLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label filteredLabel;
        private System.Windows.Forms.ComboBox peopleComboBox;
        private System.Windows.Forms.NumericUpDown yearsExperiencePicker;
    }
}