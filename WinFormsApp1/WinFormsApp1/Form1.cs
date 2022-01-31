namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<string, decimal> oilInfos = new Dictionary<string, decimal>() { 
                {"A-95", 35}, 
                {"A-95", 32},
                {"Газ", 25},
                {"Дизель", 27}
        };

        public Form1()
        {
            InitializeComponent();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OilTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOilType = OilTypeComboBox.SelectedItem;
            OilPriceTextBox.Text = oilInfos[selectedOilType].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var oilPrice = oilInfos[selectedOilType];
            OilTotalPriceLabel.Text =
        }
    }
}