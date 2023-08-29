﻿namespace TrianguloEqui5834324;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        double a = Convert.ToDouble(EntryA.Text);
        double b = Convert.ToDouble(EntryB.Text);
        double c = Convert.ToDouble(EntryC.Text);

        double S = (a + b + c) / 2;

        double Area = Math.Sqrt(S * (S - a) * (S - b) * (S - c));

        lblA.Text = $"El area del triangulo es: {Area}";
    }
}

