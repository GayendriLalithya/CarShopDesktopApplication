using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Xml.Linq;


namespace ADCoursework1.Entities
{
    internal class Report
    {
        public void SaveFinanceReport(string htmlContent)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
                saveFileDialog.Title = "Save HTML Report";
                saveFileDialog.DefaultExt = "html";
                saveFileDialog.FileName = "FinanceReport.html"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, htmlContent);
                    MessageBox.Show("Report saved successfully at " + filePath, "Report Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void SaveDailyIncomeReport(string htmlContent)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
                saveFileDialog.Title = "Save HTML Report";
                saveFileDialog.DefaultExt = "html";
                saveFileDialog.FileName = "DailyIncome.html"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, htmlContent);
                    MessageBox.Show("Report saved successfully at " + filePath, "Report Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void SaveInventoryReport(string htmlContent)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
                saveFileDialog.Title = "Save HTML Report";
                saveFileDialog.DefaultExt = "html";
                saveFileDialog.FileName = "Inventory.html"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, htmlContent);
                    MessageBox.Show("Report saved successfully at " + filePath, "Report Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void SaveOrderStatusReport(string htmlContent)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "HTML files (*.html)|*.html|All files (*.*)|*.*";
                saveFileDialog.Title = "Save HTML Report";
                saveFileDialog.DefaultExt = "html";
                saveFileDialog.FileName = "OrderQuantityStatus.html"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, htmlContent);
                    MessageBox.Show("Report saved successfully at " + filePath, "Report Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void SaveHtmlReport(string htmlContent, string filePath)
        {
            File.WriteAllText(filePath, htmlContent);
        }
    }
}
