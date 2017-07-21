namespace DlugieCwiczenie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.goToButton = new System.Windows.Forms.Button();
            this.exitsLocation = new System.Windows.Forms.ComboBox();
            this.throughtTheDoorButton = new System.Windows.Forms.Button();
            this.checkButton1 = new System.Windows.Forms.Button();
            this.hideUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 12);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(352, 134);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // goToButton
            // 
            this.goToButton.Location = new System.Drawing.Point(12, 162);
            this.goToButton.Name = "goToButton";
            this.goToButton.Size = new System.Drawing.Size(105, 23);
            this.goToButton.TabIndex = 1;
            this.goToButton.Text = "Idź do:";
            this.goToButton.UseVisualStyleBackColor = true;
            this.goToButton.Click += new System.EventHandler(this.goToButton_Click);
            // 
            // exitsLocation
            // 
            this.exitsLocation.FormattingEnabled = true;
            this.exitsLocation.Location = new System.Drawing.Point(123, 164);
            this.exitsLocation.Name = "exitsLocation";
            this.exitsLocation.Size = new System.Drawing.Size(241, 21);
            this.exitsLocation.TabIndex = 2;
            // 
            // throughtTheDoorButton
            // 
            this.throughtTheDoorButton.Location = new System.Drawing.Point(12, 191);
            this.throughtTheDoorButton.Name = "throughtTheDoorButton";
            this.throughtTheDoorButton.Size = new System.Drawing.Size(352, 27);
            this.throughtTheDoorButton.TabIndex = 3;
            this.throughtTheDoorButton.Text = "Przejdź przez drzwi";
            this.throughtTheDoorButton.UseVisualStyleBackColor = true;
            this.throughtTheDoorButton.Click += new System.EventHandler(this.throughtTheDoorButton_Click);
            // 
            // checkButton1
            // 
            this.checkButton1.Location = new System.Drawing.Point(12, 224);
            this.checkButton1.Name = "checkButton1";
            this.checkButton1.Size = new System.Drawing.Size(352, 36);
            this.checkButton1.TabIndex = 4;
            this.checkButton1.Text = "Sprawdź";
            this.checkButton1.UseVisualStyleBackColor = true;
            this.checkButton1.Click += new System.EventHandler(this.checkButton1_Click);
            // 
            // hideUpButton
            // 
            this.hideUpButton.Location = new System.Drawing.Point(12, 275);
            this.hideUpButton.Name = "hideUpButton";
            this.hideUpButton.Size = new System.Drawing.Size(352, 33);
            this.hideUpButton.TabIndex = 5;
            this.hideUpButton.Text = "Kryj się!!!";
            this.hideUpButton.UseVisualStyleBackColor = true;
            this.hideUpButton.Click += new System.EventHandler(this.hideUpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 321);
            this.Controls.Add(this.hideUpButton);
            this.Controls.Add(this.checkButton1);
            this.Controls.Add(this.throughtTheDoorButton);
            this.Controls.Add(this.exitsLocation);
            this.Controls.Add(this.goToButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Name = "Form1";
            this.Text = "Zabawa w chowanego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button goToButton;
        private System.Windows.Forms.ComboBox exitsLocation;
        private System.Windows.Forms.Button throughtTheDoorButton;
        private System.Windows.Forms.Button checkButton1;
        private System.Windows.Forms.Button hideUpButton;
    }
}

