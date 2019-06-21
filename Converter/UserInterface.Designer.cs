namespace Converter
{
    partial class UserInterface
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
            this.uxTo = new System.Windows.Forms.Label();
            this.uxText1 = new System.Windows.Forms.TextBox();
            this.uxAnswer = new System.Windows.Forms.TextBox();
            this.uxMeasurement1 = new System.Windows.Forms.ComboBox();
            this.uxMeasurement2 = new System.Windows.Forms.ComboBox();
            this.uxConvert = new System.Windows.Forms.Button();
            this.uxWeightConverter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxTo
            // 
            this.uxTo.AutoSize = true;
            this.uxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTo.Location = new System.Drawing.Point(234, 62);
            this.uxTo.Name = "uxTo";
            this.uxTo.Size = new System.Drawing.Size(43, 29);
            this.uxTo.TabIndex = 1;
            this.uxTo.Text = "To";
            // 
            // uxText1
            // 
            this.uxText1.Location = new System.Drawing.Point(25, 59);
            this.uxText1.Multiline = true;
            this.uxText1.Name = "uxText1";
            this.uxText1.Size = new System.Drawing.Size(142, 32);
            this.uxText1.TabIndex = 2;
            this.uxText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxAnswer
            // 
            this.uxAnswer.Location = new System.Drawing.Point(105, 97);
            this.uxAnswer.Multiline = true;
            this.uxAnswer.Name = "uxAnswer";
            this.uxAnswer.Size = new System.Drawing.Size(142, 32);
            this.uxAnswer.TabIndex = 3;
            this.uxAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxMeasurement1
            // 
            this.uxMeasurement1.FormattingEnabled = true;
            this.uxMeasurement1.ItemHeight = 16;
            this.uxMeasurement1.Items.AddRange(new object[] {
            "oz",
            "lbs",
            "mg",
            "g",
            "kg"});
            this.uxMeasurement1.Location = new System.Drawing.Point(173, 62);
            this.uxMeasurement1.Name = "uxMeasurement1";
            this.uxMeasurement1.Size = new System.Drawing.Size(55, 24);
            this.uxMeasurement1.TabIndex = 4;
            this.uxMeasurement1.SelectedIndexChanged += new System.EventHandler(this.UxMeasurement1_SelectedIndexChanged);
            // 
            // uxMeasurement2
            // 
            this.uxMeasurement2.FormattingEnabled = true;
            this.uxMeasurement2.ItemHeight = 16;
            this.uxMeasurement2.Items.AddRange(new object[] {
            "oz",
            "lbs",
            "mg",
            "g",
            "kg"});
            this.uxMeasurement2.Location = new System.Drawing.Point(283, 62);
            this.uxMeasurement2.Name = "uxMeasurement2";
            this.uxMeasurement2.Size = new System.Drawing.Size(55, 24);
            this.uxMeasurement2.TabIndex = 5;
            this.uxMeasurement2.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // uxConvert
            // 
            this.uxConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxConvert.Location = new System.Drawing.Point(12, 151);
            this.uxConvert.Name = "uxConvert";
            this.uxConvert.Size = new System.Drawing.Size(335, 64);
            this.uxConvert.TabIndex = 0;
            this.uxConvert.Text = "CONVERT";
            this.uxConvert.UseVisualStyleBackColor = true;
            this.uxConvert.Click += new System.EventHandler(this.UxConvert_Click);
            // 
            // uxWeightConverter
            // 
            this.uxWeightConverter.AutoSize = true;
            this.uxWeightConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxWeightConverter.Location = new System.Drawing.Point(70, 9);
            this.uxWeightConverter.Name = "uxWeightConverter";
            this.uxWeightConverter.Size = new System.Drawing.Size(235, 32);
            this.uxWeightConverter.TabIndex = 6;
            this.uxWeightConverter.Text = "Weight Converter";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 244);
            this.Controls.Add(this.uxWeightConverter);
            this.Controls.Add(this.uxMeasurement2);
            this.Controls.Add(this.uxMeasurement1);
            this.Controls.Add(this.uxAnswer);
            this.Controls.Add(this.uxText1);
            this.Controls.Add(this.uxTo);
            this.Controls.Add(this.uxConvert);
            this.Name = "UserInterface";
            this.Text = "Weight Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uxTo;
        private System.Windows.Forms.TextBox uxText1;
        private System.Windows.Forms.ComboBox uxMeasurement1;
        private System.Windows.Forms.ComboBox uxMeasurement2;
        private System.Windows.Forms.Button uxConvert;
        private System.Windows.Forms.TextBox uxAnswer;
        private System.Windows.Forms.Label uxWeightConverter;
    }
}

