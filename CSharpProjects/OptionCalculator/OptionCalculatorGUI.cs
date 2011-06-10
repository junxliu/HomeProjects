using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OptionCalculator
{
    public partial class OptionCalculatorGUI : Form
    {
        public OptionCalculatorGUI()
        {
            InitializeComponent();
            updatePrice();
        }


        private void updatePrice()
        {
            double currentPrice     = this.TextBoxStockPrice.DoubleValue;
            double strikePrice      = this.TextBoxStrikePrice.DoubleValue;
            double interestRate     = this.TextBoxInterestRate.DoubleValue / 100.0;
            DateTime today          = this.DateTimePickerToday.Value;
            DateTime maturityDate   = this.DateTimePickerMaturity.Value;
            TimeSpan span           = maturityDate - today;
            double yearsToMaturity  = span.TotalDays / 365.0;
            double volatility       = this.TextBoxVolatility.DoubleValue / 100.0;
            bool isCall             = this.RadioButtonCall.Checked;
            double optionPrice      = BlackScholesCalculator.calculateOptionPrice(currentPrice, strikePrice, yearsToMaturity, interestRate, volatility, isCall);
            this.TextBoxOptionPrice.Text = String.Format("{0:F3}", optionPrice);
            calculateGreeks();
        }

        private void calculateGreeks()
        {
            double currentPrice = this.TextBoxStockPrice.DoubleValue;
            double strikePrice = this.TextBoxStrikePrice.DoubleValue;
            double interestRate = this.TextBoxInterestRate.DoubleValue / 100.0;
            DateTime today = this.DateTimePickerToday.Value;
            DateTime maturityDate = this.DateTimePickerMaturity.Value;
            TimeSpan span = maturityDate - today;
            double yearsToMaturity = span.TotalDays / 365.0;
            double volatility = this.TextBoxVolatility.DoubleValue / 100.0;
            bool isCall = this.RadioButtonCall.Checked;

            JLNumerics.UnaryFunction deltaFunction = (cp) => BlackScholesCalculator.calculateOptionPrice(cp, strikePrice, yearsToMaturity, interestRate, volatility, isCall);
            double delta = JLNumerics.DerivativeCalculator.numericalDifferentiation(deltaFunction, currentPrice);
            JLNumerics.UnaryFunction vegaFunction  = (vol) => BlackScholesCalculator.calculateOptionPrice(currentPrice, strikePrice, yearsToMaturity, interestRate, vol, isCall);
            double vega = JLNumerics.DerivativeCalculator.numericalDifferentiation(vegaFunction, volatility);
            JLNumerics.UnaryFunction thetaFunction = (time) => BlackScholesCalculator.calculateOptionPrice(currentPrice, strikePrice, time, interestRate, volatility, isCall);
            double theta = -JLNumerics.DerivativeCalculator.numericalDifferentiation(thetaFunction, yearsToMaturity);
            JLNumerics.UnaryFunction rhoFunction = (r) => BlackScholesCalculator.calculateOptionPrice(currentPrice, strikePrice, yearsToMaturity, r, volatility, isCall);
            double rho = JLNumerics.DerivativeCalculator.numericalDifferentiation(rhoFunction, interestRate);

            this.RichTextBoxGreeks.Text = "Delta = " + String.Format("{0:F3}", delta) + System.Environment.NewLine +
                                          "Vega  = " + String.Format("{0:F3}", vega) + System.Environment.NewLine +
                                          "Theta = " + String.Format("{0:F3}", theta) + System.Environment.NewLine +
                                          "Rho   = " + String.Format("{0:F3}", rho);

        
        }

        private void updateVolatility()
        {
            double currentPrice = this.TextBoxStockPrice.DoubleValue;
            double strikePrice = this.TextBoxStrikePrice.DoubleValue;
            double interestRate = this.TextBoxInterestRate.DoubleValue / 100.0;
            DateTime today = this.DateTimePickerToday.Value;
            DateTime maturityDate = this.DateTimePickerMaturity.Value;
            TimeSpan span = maturityDate - today;
            double yearsToMaturity = span.TotalDays / 365.0;
            bool isCall = this.RadioButtonCall.Checked;
            double optionPrice = this.TextBoxOptionPrice.DoubleValue;

            double volatility = 0.25;
            JLNumerics.UnaryFunction priceFunction = (vol) => BlackScholesCalculator.calculateOptionPrice(currentPrice, strikePrice, yearsToMaturity, interestRate, vol, isCall) - optionPrice; 
            bool success = JLNumerics.RootFinder.findRootSecantMethod(priceFunction, ref volatility, 1.0E-10, 50, 0.0);
            if (success)
            {
                this.TextBoxVolatility.Text = String.Format("{0:F3}", volatility * 100.0);
                calculateGreeks();
            }
            else
            {
                MessageBox.Show("Root Finding Failed -- volatility cannot be calculated!");
            }
        }




        private void TextBoxInterestRate_Leave(object sender, EventArgs e)
        {
            try
            {
               double x = this.TextBoxInterestRate.DoubleValue;
            }
            catch (SystemException exception)
            {
                MessageBox.Show(this.LabelInterestRate.Text + ": " + exception.Message);
                return;
            }

            updatePrice();
        }

        private void TextBoxInterestRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxStockPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxInterestRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                TextBoxInterestRate_Leave(sender, e); 
        }

        private void TextBoxInterestRate_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TextBoxStockPrice_Leave(object sender, EventArgs e)
        {
            try
            {
                double x = this.TextBoxStockPrice.DoubleValue;
            }
            catch (SystemException exception)
            {
                MessageBox.Show(this.LabelCurrentStockPrice.Text + ": " + exception.Message);
                return;
            }

            updatePrice();
        }

        private void TextBoxStrikePrice_Leave(object sender, EventArgs e)
        {
            try
            {
                double x = this.TextBoxStrikePrice.DoubleValue;
            }
            catch (SystemException exception)
            {
                MessageBox.Show(this.LabelOptionStrikePrice.Text + ": " + exception.Message);
                return;
            }

            updatePrice();
        }

        private void DateTimePickerToday_ValueChanged(object sender, EventArgs e)
        {
            if (this.DateTimePickerToday.Value >= this.DateTimePickerMaturity.Value)
            {
                MessageBox.Show(this.LabelToday.Text + ": must be before the maturity date!");
                this.DateTimePickerToday.Value = this.DateTimePickerMaturity.Value.AddYears(-1);
                return;
            }
            updatePrice();
        }

        private void DateTimePickerMaturity_ValueChanged(object sender, EventArgs e)
        {
            if (this.DateTimePickerToday.Value >= this.DateTimePickerMaturity.Value)
            {
                MessageBox.Show(this.LabelToday.Text + ": must be before the maturity date!");
                this.DateTimePickerMaturity.Value = this.DateTimePickerToday.Value.AddYears(1);
                return;
            }
            updatePrice();
        }

        private void RadioButtonCall_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice();
        }

        private void RadioButtonPut_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice();
        }

        private void TextBoxVolatility_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxVolatility_Leave(object sender, EventArgs e)
        {
            try
            {
                double x = this.TextBoxVolatility.DoubleValue;
            }
            catch (SystemException exception)
            {
                MessageBox.Show(this.LabelVolatility.Text + ": " + exception.Message);
                return;
            }

            updatePrice();
        }

        private void TextBoxStockPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                TextBoxStockPrice_Leave(sender, e); 
        }

        private void TextBoxStrikePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                TextBoxStrikePrice_Leave(sender, e); 
        }

        private void TextBoxVolatility_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                TextBoxVolatility_Leave(sender, e); 
        }

        private void TextBoxStockPrice_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBoxOptionPrice_Leave(object sender, EventArgs e)
        {
            try
            {
                double x = this.TextBoxOptionPrice.DoubleValue;
            }
            catch (SystemException exception)
            {
                MessageBox.Show(this.LabelOptionPrice.Text + ": " + exception.Message);
                return;
            }

            updateVolatility();
        }

        private void TextBoxOptionPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)
                TextBoxOptionPrice_Leave(sender, e); 
        }

    }
}
