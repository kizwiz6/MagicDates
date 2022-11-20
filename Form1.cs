// https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-7.0

namespace MagicDates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime chosenDate = dateTimePicker1.Value;

            int day = chosenDate.Day;
            int month = chosenDate.Month;

            int year = chosenDate.Year;

            String yearString = year.ToString();

            String lastTwoDigits = yearString.Substring(2); // year 1999 would give 99

            int finalTwoValue = int.Parse(lastTwoDigits); // gets final two digits and puts value back into int

        }
    }
}