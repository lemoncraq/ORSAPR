namespace StoolPlugin.UI
{
    partial class StoolForm
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
            this.stoolTopGroupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stoolLegsGroupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stoolTopGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.stoolLegsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // stoolTopGroupBox
            // 
            this.stoolTopGroupBox.Controls.Add(this.numericUpDown3);
            this.stoolTopGroupBox.Controls.Add(this.numericUpDown2);
            this.stoolTopGroupBox.Controls.Add(this.numericUpDown1);
            this.stoolTopGroupBox.Controls.Add(this.label3);
            this.stoolTopGroupBox.Controls.Add(this.label2);
            this.stoolTopGroupBox.Controls.Add(this.label1);
            this.stoolTopGroupBox.Location = new System.Drawing.Point(9, 10);
            this.stoolTopGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stoolTopGroupBox.Name = "stoolTopGroupBox";
            this.stoolTopGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stoolTopGroupBox.Size = new System.Drawing.Size(197, 98);
            this.stoolTopGroupBox.TabIndex = 0;
            this.stoolTopGroupBox.TabStop = false;
            this.stoolTopGroupBox.Text = "Параметры сиденья";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(128, 71);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown3.TabIndex = 5;
            this.numericUpDown3.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(128, 47);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(128, 22);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Толщина (20 - 35 мм)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ширина (300 - 600 мм)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина (300 - 400 мм)";
            // 
            // stoolLegsGroupBox
            // 
            this.stoolLegsGroupBox.Controls.Add(this.numericUpDown5);
            this.stoolLegsGroupBox.Controls.Add(this.numericUpDown4);
            this.stoolLegsGroupBox.Controls.Add(this.label5);
            this.stoolLegsGroupBox.Controls.Add(this.label4);
            this.stoolLegsGroupBox.Location = new System.Drawing.Point(9, 112);
            this.stoolLegsGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stoolLegsGroupBox.Name = "stoolLegsGroupBox";
            this.stoolLegsGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stoolLegsGroupBox.Size = new System.Drawing.Size(197, 73);
            this.stoolLegsGroupBox.TabIndex = 1;
            this.stoolLegsGroupBox.TabStop = false;
            this.stoolLegsGroupBox.Text = "Параметры ножек";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(128, 47);
            this.numericUpDown5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown5.TabIndex = 5;
            this.numericUpDown5.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(128, 22);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown4.TabIndex = 4;
            this.numericUpDown4.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ширина (25 - 35 мм)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Высота (300 - 400 мм)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 231);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stoolLegsGroupBox);
            this.Controls.Add(this.stoolTopGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StoolForm";
            this.Text = "Табурет";
            this.stoolTopGroupBox.ResumeLayout(false);
            this.stoolTopGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.stoolLegsGroupBox.ResumeLayout(false);
            this.stoolLegsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox stoolTopGroupBox;
        private System.Windows.Forms.GroupBox stoolLegsGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button button1;
    }
}

