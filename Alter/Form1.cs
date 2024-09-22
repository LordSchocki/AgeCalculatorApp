namespace Alter
{
    public partial class AgeCalculator : Form
    {
        public AgeCalculator()
        {
            InitializeComponent();
        }
        private int days; //how many days i am alive

        private int weeks;

        private int years;

        private DateTime birthDay = new DateTime(2008, 5, 18); // year month day

        private void refreshTime(DateTime timeNow) //method to refresh the label
        {
            TimeSpan timeAlive = timeNow - birthDay;

            days = (int)timeAlive.TotalDays;

            weeks = (int)Math.Floor(timeAlive.TotalDays / 7);

            years = (int)Math.Floor(timeAlive.TotalDays / 360);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshTime(DateTime.Today);
            DaysLabel.Text = days.ToString();
            WeekLabel.Text = weeks.ToString();
            YearLabel.Text = years.ToString();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void WeekTitle_Click(object sender, EventArgs e)
        {

        }

        private void YearTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
