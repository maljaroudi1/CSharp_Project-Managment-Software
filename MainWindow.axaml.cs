using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Text.Json;
using Tmds.DBus;

namespace HRAvloniaPr
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }
        private void createJsonFileBtn_Click(object sender, RoutedEventArgs e)
        {
            // Read the existing data from the file, or create an empty list if the file doesn't exist yet
            List<Employee> employees;
            if (File.Exists("employees.json"))
            {
                string json = File.ReadAllText("employees.json");
                employees = JsonSerializer.Deserialize<List<Employee>>(json);
            }
            else
            {
                employees = new List<Employee>();
            }

            // Add the new employee to the list
            employees.Add(new Employee
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Phone = phone.Text,
                Email = email.Text,
                Address = address.Text,
                Wages = wageMonth.SelectedItem.ToString(),
                Gender = gender.SelectedItem.ToString(),
                Nationality = fromWhere.SelectedItem.ToString(),
                Department = jobType.SelectedItem.ToString()
            });

            // Serialize the updated list to JSON
            string jsonString = JsonSerializer.Serialize(employees);

            // Write the JSON to the file
            File.WriteAllText("employees.json", jsonString);

           

            firstName.Text = "";
            lastName.Text = "";
            phone.Text = "";
            email.Text = "";
            address.Text = "";
            gender.SelectedItem = null;
            wageMonth.SelectedItem = null;
            fromWhere.SelectedItem = null;
            jobType.SelectedItem = null;
        }


        private void resetBtn_Click (object sender, RoutedEventArgs e) 
        {
            firstName.Text = "";
            lastName.Text = "";
            phone.Text = "";
            email.Text = "";
            address.Text = "";
            gender.SelectedItem = null; 
            wageMonth.SelectedItem = null;
            fromWhere.SelectedItem = null;
            jobType.SelectedItem = null;

        }
        


    }
}