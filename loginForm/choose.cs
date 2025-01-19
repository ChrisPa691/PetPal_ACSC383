using System;
using System.Windows.Forms;

namespace loginForm
{
    public partial class choose : Form
    {
        public choose()
        {
            InitializeComponent();
        }

        private void dogOpt_Click(object sender, EventArgs e)
        {
            string petName = ShowInputDialog("Enter the name of your pet:", "Pet Name");

            if (!string.IsNullOrEmpty(petName))
            {
                this.Hide();
                gameF gameF = new gameF(petName, "dog");
                gameF.ShowDialog();
                this.Close();
            }
            MessageBox.Show("Please enter a name!");
        }
    
        private void catOpt_Click(object sender, EventArgs e)
        {
            string petName = ShowInputDialog("Enter the name of your pet:", "Pet Name");

            if (!string.IsNullOrEmpty(petName))
            {
                this.Hide();
                gameF gameF = new gameF(petName, "cat");
                gameF.ShowDialog();
                this.Close();
            }
            MessageBox.Show("Please enter a name!");
        }

        private void pigOpt_Click(object sender, EventArgs e)
        {
            string petName = ShowInputDialog("Enter the name of your pet:", "Pet Name");

            if (!string.IsNullOrEmpty(petName))
            {
                this.Hide();
                gameF gameF = new gameF(petName, "pig");
                gameF.ShowDialog();
                this.Close();
            }
            MessageBox.Show("Please enter a name!");
        }

        public static string ShowInputDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
