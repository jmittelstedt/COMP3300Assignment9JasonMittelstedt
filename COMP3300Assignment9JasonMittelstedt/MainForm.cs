using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using COMP3300Assignment9JasonMittelstedt.Models;

namespace COMP3300Assignment9JasonMittelstedt
{
    public partial class MainForm : Form
    {
        private List<CheckingAccount> checkingAccounts = new();
        private List<SavingsAccount> savingsAccounts = new();
        private List<MoneyMarketAccount> moneymarketAccounts = new ();
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Assignment 9 by Mittelstedt";
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON files (*.json)|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(dialog.FileName);
                statementBox.Text = "Statement for " + dialog.SafeFileName;
                var accounts = JsonSerializer.Deserialize<List<BankAccount>>(json, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                if (accounts != null)
                {
                    checkingAccounts.Clear();
                    savingsAccounts.Clear();
                    moneymarketAccounts.Clear();

                    foreach (var acc in accounts)
                    {
                        switch (acc.Type.ToLower())
                        {
                            case "checking":
                                checkingAccounts.Add(new CheckingAccount(acc.OwnerName, acc.CurrentBalance, acc.MonthOpened, acc.Type, acc.MonthlyInterestRate));
                                break;
                            case "savings":
                                savingsAccounts.Add(new SavingsAccount(acc.OwnerName, acc.CurrentBalance, acc.MonthOpened, acc.Type, acc.MonthlyInterestRate));
                                break;
                            case "money market":
                                moneymarketAccounts.Add(new MoneyMarketAccount(acc.OwnerName, acc.CurrentBalance, acc.MonthOpened, acc.Type, acc.MonthlyInterestRate));
                                break;
                        }
                    }
                    MessageBox.Show("Accounts loaded successfully!");
                }
            }
        }

        private void btnShowChecking_Click(object sender, EventArgs e)
        {
            DisplayAccounts(checkingAccounts);
        }

        private void btnShowSavings_Click(object sender, EventArgs e)
        {
            DisplayAccounts(savingsAccounts);
        }

        private void btnShowMoneyMarket_Click(object sender, EventArgs e)
        {
            DisplayAccounts(moneymarketAccounts);
        }

        private void DisplayAccounts<T>(List<T> accounts)
        {
            txtDisplay.Clear();
            foreach (var acc in accounts)
                txtDisplay.AppendText(acc.ToString() + Environment.NewLine);
        }
    }
}
