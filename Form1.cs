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
        }
    }
}