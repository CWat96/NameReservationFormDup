namespace NameReservationDup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            entityNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nameReservationLabel = new Label();
            entityKindComboBox = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            submitButton = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // entityNameTextBox
            // 
            entityNameTextBox.BackColor = Color.White;
            entityNameTextBox.ForeColor = Color.Black;
            entityNameTextBox.Location = new Point(12, 127);
            entityNameTextBox.Name = "entityNameTextBox";
            entityNameTextBox.Size = new Size(350, 23);
            entityNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 109);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 4;
            label1.Text = "Entity Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(81, 109);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 5;
            label2.Text = "*";
            // 
            // nameReservationLabel
            // 
            nameReservationLabel.AutoSize = true;
            nameReservationLabel.Font = new Font("Bahnschrift Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameReservationLabel.ForeColor = Color.FromArgb(128, 128, 255);
            nameReservationLabel.Location = new Point(9, 31);
            nameReservationLabel.Name = "nameReservationLabel";
            nameReservationLabel.Size = new Size(208, 39);
            nameReservationLabel.TabIndex = 6;
            nameReservationLabel.Text = "Name Reservation";
            // 
            // entityKindComboBox
            // 
            entityKindComboBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entityKindComboBox.FormattingEnabled = true;
            entityKindComboBox.Items.AddRange(new object[] { "CORPORATION", "LIMITED PARTNERSHIP (LP)", "LIMITED LIABILTY PARTNERSHIP (LLP)", "LIMITED LIABILTY COMPANY (LLC)", "GENERAL PARTNERSHIP (GP)", "STATUTORY TRUST", "LLC REGISTERED SERIES", "LP REGISTERED SERIES" });
            entityKindComboBox.Location = new Point(12, 184);
            entityKindComboBox.Name = "entityKindComboBox";
            entityKindComboBox.Size = new Size(350, 24);
            entityKindComboBox.TabIndex = 7;
            entityKindComboBox.Text = "Please select an entity type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 166);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "Entity Kind";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(72, 166);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 9;
            label5.Text = "*";
            label5.Click += label5_Click;
            // 
            // submitButton
            // 
            submitButton.AccessibleDescription = "";
            submitButton.AccessibleName = "submitButton";
            submitButton.BackColor = SystemColors.ActiveCaption;
            submitButton.ForeColor = Color.White;
            submitButton.Location = new Point(12, 280);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(81, 39);
            submitButton.TabIndex = 10;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Location = new Point(12, 222);
            label6.Name = "label6";
            label6.Size = new Size(679, 15);
            label6.TabIndex = 11;
            label6.Text = "By clicking the 'Submit' button, I affirm to have read the disclaimer which includes the legal requirements for naming an entity. ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(submitButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(entityKindComboBox);
            Controls.Add(nameReservationLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(entityNameTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox entityNameTextBox;
        private Label label1;
        private Label label2;
        private Label nameReservationLabel;
        private ComboBox entityKindComboBox;
        private Label label4;
        private Label label5;
        private Button submitButton;
        private Label label6;
    }
}
