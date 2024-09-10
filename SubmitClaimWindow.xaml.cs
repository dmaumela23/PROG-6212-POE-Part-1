using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace CMCSwpf
{
    public partial class SubmitClaimWindow : Window
    {
        public SubmitClaimWindow()
        {
            InitializeComponent();
            LoadHourlyRate();
        }

        private void LoadHourlyRate()
        {
            // Example to load hourly rate, typically this will come from a database or user profile
            txtHourlyRate.Text = "50.00"; // Example hourly rate
        }

        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf|Word Files (*.docx)|*.docx|Excel Files (*.xlsx)|*.xlsx"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                // Handle file upload logic, like saving to a specific directory or cloud storage
                MessageBox.Show($"File '{Path.GetFileName(filePath)}' uploaded successfully.");
            }
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoursWorked.Text))
            {
                MessageBox.Show("Please enter the total hours worked.");
                return;
            }

            // Example of simple claim submission, this would typically involve saving the claim to a database
            double totalHoursWorked = Convert.ToDouble(txtHoursWorked.Text);
            double hourlyRate = Convert.ToDouble(txtHourlyRate.Text);
            double totalAmount = totalHoursWorked * hourlyRate;

            txtTotalAmount.Text = totalAmount.ToString("C"); // Display the total amount in currency format

            MessageBox.Show($"Claim for {totalHoursWorked} hours submitted successfully with a total of {txtTotalAmount.Text}.");
            this.Close();
        }
    }
}
