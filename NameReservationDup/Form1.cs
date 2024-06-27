using System.Net.Http;
namespace NameReservationDup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void entityKindToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lIMITEDPARTNERSHIPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the entered name from the textbox
            string entityName = entityNameTextBox.Text;

            // Get the selected item from the combobox (if applicable)
            string entityKind = entityKindComboBox.SelectedItem?.ToString();

            // Check if both entityName and entityKind have values (not empty)
            if (!string.IsNullOrEmpty(entityName) && !string.IsNullOrEmpty(entityKind))
            {
                try
                {
                    // ... (Code for sending POST request and handling response) ...
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                // Entity is not available (either name or kind is missing)

                // Highlight combobox red if entityKind is missing
                if (string.IsNullOrEmpty(entityKind))
                {
                    entityKindComboBox.ForeColor = Color.Red;
                }

                string message;
                if (string.IsNullOrEmpty(entityName))
                {
                    message = "Entity Name is required.";
                }
                else
                {
                    message = "To proceed 'Entity Kind' is required";
                }
                MessageBox.Show(message);
            }

            // Reset combobox color after button click (optional)
            entityKindComboBox.ForeColor = SystemColors.WindowText; // Default text color

            // Confirmation message only if both name and kind are available
            if (!string.IsNullOrEmpty(entityName) && !string.IsNullOrEmpty(entityKind))
            {
                string confirmationMessage = $"{entityName}IS AVAILABLE! Would you like to reserve this for a fee of $75.00? ";
                DialogResult result = MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.YesNo);

                // Handle user confirmation (optional)
                if (result == DialogResult.Yes)
                {
                    // Code to handle reservation confirmation (e.g., display success message, process payment)
                    MessageBox.Show("Reservation confirmed!");
                }
            }
        }
    }
}
