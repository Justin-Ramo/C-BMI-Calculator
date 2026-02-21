namespace BMI_Calc;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalculateBMI(object sender, EventArgs e)
    {
        if (double.TryParse(weightEntry.Text, out double weight) &&
            double.TryParse(heightEntry.Text, out double height) &&
            height > 0)
        {
            double bmi = weight / (height * height);
            string category;

            if (bmi < 18.5)
                category = "Underweight";
            else if (bmi < 25)
                category = "Normal";
            else if (bmi < 30)
                category = "Overweight";
            else
                category = "Obese";

            resultLabel.Text = $"BMI: {bmi:F2}\nCategory: {category}";
        }
        else
        {
            resultLabel.Text = "Please enter valid values.";
        }
    }
}