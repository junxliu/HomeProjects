namespace OptionCalculator
{
    partial class OptionCalculatorGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelCurrentStockPrice = new System.Windows.Forms.Label();
            this.TextBoxStockPrice = new NumericTextBox();
            this.LabelOptionStrikePrice = new System.Windows.Forms.Label();
            this.TextBoxStrikePrice = new NumericTextBox();
            this.LabelInterestRate = new System.Windows.Forms.Label();
            this.TextBoxInterestRate = new NumericTextBox();
            this.LabelOptionType = new System.Windows.Forms.Label();
            this.LabelToday = new System.Windows.Forms.Label();
            this.LabelMaturityDate = new System.Windows.Forms.Label();
            this.DateTimePickerToday = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerMaturity = new System.Windows.Forms.DateTimePicker();
            this.RadioButtonCall = new System.Windows.Forms.RadioButton();
            this.RadioButtonPut = new System.Windows.Forms.RadioButton();
            this.GroupBoxCalculation = new System.Windows.Forms.GroupBox();
            this.RichTextBoxGreeks = new System.Windows.Forms.RichTextBox();
            this.Greeks = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxOptionPrice = new NumericTextBox();
            this.TextBoxVolatility = new NumericTextBox();
            this.LabelOptionPrice = new System.Windows.Forms.Label();
            this.LabelVolatility = new System.Windows.Forms.Label();
            this.GroupBoxInput = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxCalculation.SuspendLayout();
            this.GroupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelCurrentStockPrice
            // 
            this.LabelCurrentStockPrice.AutoSize = true;
            this.LabelCurrentStockPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelCurrentStockPrice.Location = new System.Drawing.Point(33, 36);
            this.LabelCurrentStockPrice.Name = "LabelCurrentStockPrice";
            this.LabelCurrentStockPrice.Size = new System.Drawing.Size(118, 13);
            this.LabelCurrentStockPrice.TabIndex = 0;
            this.LabelCurrentStockPrice.Text = "Current Stock Price";
            // 
            // TextBoxStockPrice
            // 
            this.TextBoxStockPrice.AllowNegative = false;
            this.TextBoxStockPrice.Location = new System.Drawing.Point(179, 29);
            this.TextBoxStockPrice.Name = "TextBoxStockPrice";
            this.TextBoxStockPrice.Size = new System.Drawing.Size(132, 20);
            this.TextBoxStockPrice.TabIndex = 1;
            this.TextBoxStockPrice.Text = "64.0";
            this.TextBoxStockPrice.TextChanged += new System.EventHandler(this.TextBoxStockPrice_TextChanged_1);
            this.TextBoxStockPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxStockPrice_KeyDown);
            this.TextBoxStockPrice.Leave += new System.EventHandler(this.TextBoxStockPrice_Leave);
            // 
            // LabelOptionStrikePrice
            // 
            this.LabelOptionStrikePrice.AutoSize = true;
            this.LabelOptionStrikePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelOptionStrikePrice.Location = new System.Drawing.Point(33, 73);
            this.LabelOptionStrikePrice.Name = "LabelOptionStrikePrice";
            this.LabelOptionStrikePrice.Size = new System.Drawing.Size(114, 13);
            this.LabelOptionStrikePrice.TabIndex = 2;
            this.LabelOptionStrikePrice.Text = "Option Strike Price";
            // 
            // TextBoxStrikePrice
            // 
            this.TextBoxStrikePrice.AllowNegative = false;
            this.TextBoxStrikePrice.Location = new System.Drawing.Point(179, 66);
            this.TextBoxStrikePrice.Name = "TextBoxStrikePrice";
            this.TextBoxStrikePrice.Size = new System.Drawing.Size(132, 20);
            this.TextBoxStrikePrice.TabIndex = 3;
            this.TextBoxStrikePrice.Text = "60.0";
            this.TextBoxStrikePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxStrikePrice_KeyDown);
            this.TextBoxStrikePrice.Leave += new System.EventHandler(this.TextBoxStrikePrice_Leave);
            // 
            // LabelInterestRate
            // 
            this.LabelInterestRate.AutoSize = true;
            this.LabelInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelInterestRate.Location = new System.Drawing.Point(33, 110);
            this.LabelInterestRate.Name = "LabelInterestRate";
            this.LabelInterestRate.Size = new System.Drawing.Size(81, 13);
            this.LabelInterestRate.TabIndex = 4;
            this.LabelInterestRate.Text = "Interest Rate";
            // 
            // TextBoxInterestRate
            // 
            this.TextBoxInterestRate.AllowNegative = true;
            this.TextBoxInterestRate.Location = new System.Drawing.Point(178, 103);
            this.TextBoxInterestRate.Name = "TextBoxInterestRate";
            this.TextBoxInterestRate.Size = new System.Drawing.Size(133, 20);
            this.TextBoxInterestRate.TabIndex = 5;
            this.TextBoxInterestRate.Text = "5";
            this.TextBoxInterestRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxInterestRate_KeyDown);
            this.TextBoxInterestRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInterestRate_KeyPress);
            this.TextBoxInterestRate.Leave += new System.EventHandler(this.TextBoxInterestRate_Leave);
            // 
            // LabelOptionType
            // 
            this.LabelOptionType.AutoSize = true;
            this.LabelOptionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelOptionType.Location = new System.Drawing.Point(33, 221);
            this.LabelOptionType.Name = "LabelOptionType";
            this.LabelOptionType.Size = new System.Drawing.Size(76, 13);
            this.LabelOptionType.TabIndex = 6;
            this.LabelOptionType.Text = "Option Type";
            // 
            // LabelToday
            // 
            this.LabelToday.AutoSize = true;
            this.LabelToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelToday.Location = new System.Drawing.Point(33, 147);
            this.LabelToday.Name = "LabelToday";
            this.LabelToday.Size = new System.Drawing.Size(42, 13);
            this.LabelToday.TabIndex = 7;
            this.LabelToday.Text = "Today";
            // 
            // LabelMaturityDate
            // 
            this.LabelMaturityDate.AutoSize = true;
            this.LabelMaturityDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelMaturityDate.Location = new System.Drawing.Point(33, 184);
            this.LabelMaturityDate.Name = "LabelMaturityDate";
            this.LabelMaturityDate.Size = new System.Drawing.Size(83, 13);
            this.LabelMaturityDate.TabIndex = 8;
            this.LabelMaturityDate.Text = "Maturity Date";
            // 
            // DateTimePickerToday
            // 
            this.DateTimePickerToday.Location = new System.Drawing.Point(178, 140);
            this.DateTimePickerToday.Name = "DateTimePickerToday";
            this.DateTimePickerToday.Size = new System.Drawing.Size(133, 20);
            this.DateTimePickerToday.TabIndex = 9;
            this.DateTimePickerToday.Value = new System.DateTime(2011, 6, 10, 0, 0, 0, 0);
            this.DateTimePickerToday.ValueChanged += new System.EventHandler(this.DateTimePickerToday_ValueChanged);
            // 
            // DateTimePickerMaturity
            // 
            this.DateTimePickerMaturity.Location = new System.Drawing.Point(178, 177);
            this.DateTimePickerMaturity.Name = "DateTimePickerMaturity";
            this.DateTimePickerMaturity.Size = new System.Drawing.Size(133, 20);
            this.DateTimePickerMaturity.TabIndex = 10;
            this.DateTimePickerMaturity.Value = new System.DateTime(2012, 6, 10, 0, 0, 0, 0);
            this.DateTimePickerMaturity.ValueChanged += new System.EventHandler(this.DateTimePickerMaturity_ValueChanged);
            // 
            // RadioButtonCall
            // 
            this.RadioButtonCall.AutoSize = true;
            this.RadioButtonCall.Checked = true;
            this.RadioButtonCall.Location = new System.Drawing.Point(178, 221);
            this.RadioButtonCall.Name = "RadioButtonCall";
            this.RadioButtonCall.Size = new System.Drawing.Size(42, 17);
            this.RadioButtonCall.TabIndex = 11;
            this.RadioButtonCall.TabStop = true;
            this.RadioButtonCall.Text = "Call";
            this.RadioButtonCall.UseVisualStyleBackColor = true;
            this.RadioButtonCall.CheckedChanged += new System.EventHandler(this.RadioButtonCall_CheckedChanged);
            // 
            // RadioButtonPut
            // 
            this.RadioButtonPut.AutoSize = true;
            this.RadioButtonPut.Location = new System.Drawing.Point(270, 221);
            this.RadioButtonPut.Name = "RadioButtonPut";
            this.RadioButtonPut.Size = new System.Drawing.Size(41, 17);
            this.RadioButtonPut.TabIndex = 12;
            this.RadioButtonPut.Text = "Put";
            this.RadioButtonPut.UseVisualStyleBackColor = true;
            this.RadioButtonPut.CheckedChanged += new System.EventHandler(this.RadioButtonPut_CheckedChanged);
            // 
            // GroupBoxCalculation
            // 
            this.GroupBoxCalculation.Controls.Add(this.RichTextBoxGreeks);
            this.GroupBoxCalculation.Controls.Add(this.Greeks);
            this.GroupBoxCalculation.Controls.Add(this.label2);
            this.GroupBoxCalculation.Controls.Add(this.TextBoxOptionPrice);
            this.GroupBoxCalculation.Controls.Add(this.TextBoxVolatility);
            this.GroupBoxCalculation.Controls.Add(this.LabelOptionPrice);
            this.GroupBoxCalculation.Controls.Add(this.LabelVolatility);
            this.GroupBoxCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBoxCalculation.Location = new System.Drawing.Point(12, 283);
            this.GroupBoxCalculation.Name = "GroupBoxCalculation";
            this.GroupBoxCalculation.Size = new System.Drawing.Size(347, 227);
            this.GroupBoxCalculation.TabIndex = 13;
            this.GroupBoxCalculation.TabStop = false;
            this.GroupBoxCalculation.Text = "Calculation";
            // 
            // RichTextBoxGreeks
            // 
            this.RichTextBoxGreeks.Enabled = false;
            this.RichTextBoxGreeks.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxGreeks.Location = new System.Drawing.Point(166, 121);
            this.RichTextBoxGreeks.Name = "RichTextBoxGreeks";
            this.RichTextBoxGreeks.ReadOnly = true;
            this.RichTextBoxGreeks.Size = new System.Drawing.Size(128, 86);
            this.RichTextBoxGreeks.TabIndex = 16;
            this.RichTextBoxGreeks.Text = "";
            // 
            // Greeks
            // 
            this.Greeks.AutoSize = true;
            this.Greeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Greeks.Location = new System.Drawing.Point(20, 141);
            this.Greeks.Name = "Greeks";
            this.Greeks.Size = new System.Drawing.Size(67, 20);
            this.Greeks.TabIndex = 15;
            this.Greeks.Text = "Greeks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "%";
            // 
            // TextBoxOptionPrice
            // 
            this.TextBoxOptionPrice.AllowNegative = false;
            this.TextBoxOptionPrice.Location = new System.Drawing.Point(167, 75);
            this.TextBoxOptionPrice.Name = "TextBoxOptionPrice";
            this.TextBoxOptionPrice.Size = new System.Drawing.Size(100, 23);
            this.TextBoxOptionPrice.TabIndex = 3;
            this.TextBoxOptionPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxOptionPrice_KeyDown);
            this.TextBoxOptionPrice.Leave += new System.EventHandler(this.TextBoxOptionPrice_Leave);
            // 
            // TextBoxVolatility
            // 
            this.TextBoxVolatility.AllowNegative = false;
            this.TextBoxVolatility.Location = new System.Drawing.Point(167, 34);
            this.TextBoxVolatility.Name = "TextBoxVolatility";
            this.TextBoxVolatility.Size = new System.Drawing.Size(100, 23);
            this.TextBoxVolatility.TabIndex = 2;
            this.TextBoxVolatility.Text = "25";
            this.TextBoxVolatility.TextChanged += new System.EventHandler(this.TextBoxVolatility_TextChanged);
            this.TextBoxVolatility.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxVolatility_KeyDown);
            this.TextBoxVolatility.Leave += new System.EventHandler(this.TextBoxVolatility_Leave);
            // 
            // LabelOptionPrice
            // 
            this.LabelOptionPrice.AutoSize = true;
            this.LabelOptionPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelOptionPrice.Location = new System.Drawing.Point(20, 78);
            this.LabelOptionPrice.Name = "LabelOptionPrice";
            this.LabelOptionPrice.Size = new System.Drawing.Size(107, 20);
            this.LabelOptionPrice.TabIndex = 1;
            this.LabelOptionPrice.Text = "Option Price";
            // 
            // LabelVolatility
            // 
            this.LabelVolatility.AutoSize = true;
            this.LabelVolatility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelVolatility.Location = new System.Drawing.Point(20, 37);
            this.LabelVolatility.Name = "LabelVolatility";
            this.LabelVolatility.Size = new System.Drawing.Size(77, 20);
            this.LabelVolatility.TabIndex = 0;
            this.LabelVolatility.Text = "Volatility";
            // 
            // GroupBoxInput
            // 
            this.GroupBoxInput.Controls.Add(this.label1);
            this.GroupBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBoxInput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupBoxInput.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxInput.Name = "GroupBoxInput";
            this.GroupBoxInput.Size = new System.Drawing.Size(347, 256);
            this.GroupBoxInput.TabIndex = 0;
            this.GroupBoxInput.TabStop = false;
            this.GroupBoxInput.Text = "Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "%";
            // 
            // OptionCalculatorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 522);
            this.Controls.Add(this.GroupBoxCalculation);
            this.Controls.Add(this.RadioButtonPut);
            this.Controls.Add(this.RadioButtonCall);
            this.Controls.Add(this.DateTimePickerMaturity);
            this.Controls.Add(this.DateTimePickerToday);
            this.Controls.Add(this.LabelMaturityDate);
            this.Controls.Add(this.LabelToday);
            this.Controls.Add(this.LabelOptionType);
            this.Controls.Add(this.TextBoxInterestRate);
            this.Controls.Add(this.LabelInterestRate);
            this.Controls.Add(this.TextBoxStrikePrice);
            this.Controls.Add(this.LabelOptionStrikePrice);
            this.Controls.Add(this.TextBoxStockPrice);
            this.Controls.Add(this.LabelCurrentStockPrice);
            this.Controls.Add(this.GroupBoxInput);
            this.Name = "OptionCalculatorGUI";
            this.Text = "Option Calculator";
            this.GroupBoxCalculation.ResumeLayout(false);
            this.GroupBoxCalculation.PerformLayout();
            this.GroupBoxInput.ResumeLayout(false);
            this.GroupBoxInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCurrentStockPrice;
        private NumericTextBox TextBoxStockPrice;
        private System.Windows.Forms.Label LabelOptionStrikePrice;
        private NumericTextBox TextBoxStrikePrice;
        private System.Windows.Forms.Label LabelInterestRate;
        private NumericTextBox TextBoxInterestRate;
        private System.Windows.Forms.Label LabelOptionType;
        private System.Windows.Forms.Label LabelToday;
        private System.Windows.Forms.Label LabelMaturityDate;
        private System.Windows.Forms.DateTimePicker DateTimePickerToday;
        private System.Windows.Forms.DateTimePicker DateTimePickerMaturity;
        private System.Windows.Forms.RadioButton RadioButtonCall;
        private System.Windows.Forms.RadioButton RadioButtonPut;
        private System.Windows.Forms.GroupBox GroupBoxCalculation;
        private System.Windows.Forms.GroupBox GroupBoxInput;
        private System.Windows.Forms.Label LabelOptionPrice;
        private System.Windows.Forms.Label LabelVolatility;
        private NumericTextBox TextBoxOptionPrice;
        private NumericTextBox TextBoxVolatility;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RichTextBoxGreeks;
        private System.Windows.Forms.Label Greeks;
    }
}

