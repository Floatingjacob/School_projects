
namespace Week_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void F_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(F.Text, out double value))
                {
                    var toCelsius = ((value - 32) * 5.0 / 9.0).ToString("F2") + "°C";
                    rslt.Text = toCelsius;
                }
                else
                {
                    rslt.Text = "Invalid Input";
                }
            }
            catch { }
        }

        private void C_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(C.Text, out double value))
                {
                    var toFahrenheit = ((value * 9.0 / 5.0) + 32).ToString("F2") + "°F";
                    rslt.Text = toFahrenheit;
                }
                else
                {
                    rslt.Text = "Invalid Input";
                }
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}