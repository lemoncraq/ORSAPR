
namespace StoolPlugin.UI
{
    partial class StoolPluginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuildButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.StoolLegsHeightNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.StoolLegsBaseNum = new System.Windows.Forms.NumericUpDown();
            this.legsParameters = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StoolTopLengthNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.StoolTopWidthNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.StoolTopThicknessNum = new System.Windows.Forms.NumericUpDown();
            this.stoolTopGroupBox = new System.Windows.Forms.GroupBox();
            this.LegsTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StoolLegsHeightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoolLegsBaseNum)).BeginInit();
            this.legsParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoolTopLengthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoolTopWidthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoolTopThicknessNum)).BeginInit();
            this.stoolTopGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(34, 321);
            this.BuildButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(225, 43);
            this.BuildButton.TabIndex = 2;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Высота (300 - 400) мм";
            // 
            // StoolLegsHeightNum
            // 
            this.StoolLegsHeightNum.Location = new System.Drawing.Point(192, 28);
            this.StoolLegsHeightNum.Margin = new System.Windows.Forms.Padding(4);
            this.StoolLegsHeightNum.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.StoolLegsHeightNum.Name = "StoolLegsHeightNum";
            this.StoolLegsHeightNum.Size = new System.Drawing.Size(67, 22);
            this.StoolLegsHeightNum.TabIndex = 1;
            this.StoolLegsHeightNum.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.StoolLegsHeightNum.ValueChanged += new System.EventHandler(this.AnyValueNumericUpDown_ValueChanged);
            this.StoolLegsHeightNum.Validating += new System.ComponentModel.CancelEventHandler(this.AnyValueNumericUpDown_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Основание (25 - 35) мм";
            // 
            // StoolLegsBaseNum
            // 
            this.StoolLegsBaseNum.Location = new System.Drawing.Point(192, 70);
            this.StoolLegsBaseNum.Margin = new System.Windows.Forms.Padding(4);
            this.StoolLegsBaseNum.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.StoolLegsBaseNum.Name = "StoolLegsBaseNum";
            this.StoolLegsBaseNum.Size = new System.Drawing.Size(67, 22);
            this.StoolLegsBaseNum.TabIndex = 3;
            this.StoolLegsBaseNum.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.StoolLegsBaseNum.ValueChanged += new System.EventHandler(this.AnyValueNumericUpDown_ValueChanged);
            this.StoolLegsBaseNum.Validating += new System.ComponentModel.CancelEventHandler(this.AnyValueNumericUpDown_Validating);
            // 
            // legsParameters
            // 
            this.legsParameters.Controls.Add(this.label4);
            this.legsParameters.Controls.Add(this.LegsTypeComboBox);
            this.legsParameters.Controls.Add(this.StoolLegsBaseNum);
            this.legsParameters.Controls.Add(this.label5);
            this.legsParameters.Controls.Add(this.StoolLegsHeightNum);
            this.legsParameters.Controls.Add(this.label6);
            this.legsParameters.Location = new System.Drawing.Point(13, 166);
            this.legsParameters.Margin = new System.Windows.Forms.Padding(4);
            this.legsParameters.Name = "legsParameters";
            this.legsParameters.Padding = new System.Windows.Forms.Padding(4);
            this.legsParameters.Size = new System.Drawing.Size(267, 147);
            this.legsParameters.TabIndex = 1;
            this.legsParameters.TabStop = false;
            this.legsParameters.Text = "Параметры ножек";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина (300 - 400) мм";
            // 
            // StoolTopLengthNum
            // 
            this.StoolTopLengthNum.Location = new System.Drawing.Point(192, 28);
            this.StoolTopLengthNum.Margin = new System.Windows.Forms.Padding(4);
            this.StoolTopLengthNum.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.StoolTopLengthNum.Name = "StoolTopLengthNum";
            this.StoolTopLengthNum.Size = new System.Drawing.Size(67, 22);
            this.StoolTopLengthNum.TabIndex = 1;
            this.StoolTopLengthNum.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.StoolTopLengthNum.ValueChanged += new System.EventHandler(this.AnyValueNumericUpDown_ValueChanged);
            this.StoolTopLengthNum.Validating += new System.ComponentModel.CancelEventHandler(this.AnyValueNumericUpDown_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ширина (300 - 600) мм";
            // 
            // StoolTopWidthNum
            // 
            this.StoolTopWidthNum.Location = new System.Drawing.Point(192, 70);
            this.StoolTopWidthNum.Margin = new System.Windows.Forms.Padding(4);
            this.StoolTopWidthNum.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.StoolTopWidthNum.Name = "StoolTopWidthNum";
            this.StoolTopWidthNum.Size = new System.Drawing.Size(67, 22);
            this.StoolTopWidthNum.TabIndex = 3;
            this.StoolTopWidthNum.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.StoolTopWidthNum.ValueChanged += new System.EventHandler(this.AnyValueNumericUpDown_ValueChanged);
            this.StoolTopWidthNum.Validating += new System.ComponentModel.CancelEventHandler(this.AnyValueNumericUpDown_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Толщина (20 - 35) мм";
            // 
            // StoolTopThicknessNum
            // 
            this.StoolTopThicknessNum.Location = new System.Drawing.Point(192, 112);
            this.StoolTopThicknessNum.Margin = new System.Windows.Forms.Padding(4);
            this.StoolTopThicknessNum.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.StoolTopThicknessNum.Name = "StoolTopThicknessNum";
            this.StoolTopThicknessNum.Size = new System.Drawing.Size(67, 22);
            this.StoolTopThicknessNum.TabIndex = 5;
            this.StoolTopThicknessNum.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.StoolTopThicknessNum.ValueChanged += new System.EventHandler(this.AnyValueNumericUpDown_ValueChanged);
            this.StoolTopThicknessNum.Validating += new System.ComponentModel.CancelEventHandler(this.AnyValueNumericUpDown_Validating);
            // 
            // stoolTopGroupBox
            // 
            this.stoolTopGroupBox.Controls.Add(this.StoolTopThicknessNum);
            this.stoolTopGroupBox.Controls.Add(this.label3);
            this.stoolTopGroupBox.Controls.Add(this.StoolTopWidthNum);
            this.stoolTopGroupBox.Controls.Add(this.label2);
            this.stoolTopGroupBox.Controls.Add(this.StoolTopLengthNum);
            this.stoolTopGroupBox.Controls.Add(this.label1);
            this.stoolTopGroupBox.Location = new System.Drawing.Point(13, 13);
            this.stoolTopGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.stoolTopGroupBox.Name = "stoolTopGroupBox";
            this.stoolTopGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.stoolTopGroupBox.Size = new System.Drawing.Size(267, 145);
            this.stoolTopGroupBox.TabIndex = 0;
            this.stoolTopGroupBox.TabStop = false;
            this.stoolTopGroupBox.Text = "Параметры сиденья";
            // 
            // LegsTypeComboBox
            // 
            this.LegsTypeComboBox.FormattingEnabled = true;
            this.LegsTypeComboBox.Items.AddRange(new object[] {
            "квадратные",
            "круглые",
            "треугольные"});
            this.LegsTypeComboBox.Location = new System.Drawing.Point(132, 112);
            this.LegsTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.LegsTypeComboBox.Name = "LegsTypeComboBox";
            this.LegsTypeComboBox.Size = new System.Drawing.Size(127, 24);
            this.LegsTypeComboBox.TabIndex = 8;
            this.LegsTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.LegsTypeComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип ножек";
            // 
            // StoolPluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 373);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.legsParameters);
            this.Controls.Add(this.stoolTopGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(310, 420);
            this.MinimumSize = new System.Drawing.Size(310, 420);
            this.Name = "StoolPluginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Плагин для построения табурета";
            ((System.ComponentModel.ISupportInitialize)(this.StoolLegsHeightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoolLegsBaseNum)).EndInit();
            this.legsParameters.ResumeLayout(false);
            this.legsParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoolTopLengthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoolTopWidthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoolTopThicknessNum)).EndInit();
            this.stoolTopGroupBox.ResumeLayout(false);
            this.stoolTopGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown StoolLegsHeightNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown StoolLegsBaseNum;
        private System.Windows.Forms.GroupBox legsParameters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown StoolTopLengthNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown StoolTopWidthNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown StoolTopThicknessNum;
        private System.Windows.Forms.GroupBox stoolTopGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox LegsTypeComboBox;
    }
}

