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
            this.stoolLegsGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stoolTopGroupBox.SuspendLayout();
            this.stoolLegsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // stoolTopGroupBox
            // 
            this.stoolTopGroupBox.Controls.Add(this.label3);
            this.stoolTopGroupBox.Controls.Add(this.label2);
            this.stoolTopGroupBox.Controls.Add(this.label1);
            this.stoolTopGroupBox.Location = new System.Drawing.Point(12, 12);
            this.stoolTopGroupBox.Name = "stoolTopGroupBox";
            this.stoolTopGroupBox.Size = new System.Drawing.Size(286, 121);
            this.stoolTopGroupBox.TabIndex = 0;
            this.stoolTopGroupBox.TabStop = false;
            this.stoolTopGroupBox.Text = "Параметры сиденья";
            // 
            // stoolLegsGroupBox
            // 
            this.stoolLegsGroupBox.Controls.Add(this.label5);
            this.stoolLegsGroupBox.Controls.Add(this.label4);
            this.stoolLegsGroupBox.Location = new System.Drawing.Point(465, 12);
            this.stoolLegsGroupBox.Name = "stoolLegsGroupBox";
            this.stoolLegsGroupBox.Size = new System.Drawing.Size(323, 268);
            this.stoolLegsGroupBox.TabIndex = 1;
            this.stoolLegsGroupBox.TabStop = false;
            this.stoolLegsGroupBox.Text = "Параметры ножек";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ширина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Толщина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Высота";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ширина";
            // 
            // StoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stoolLegsGroupBox);
            this.Controls.Add(this.stoolTopGroupBox);
            this.Name = "StoolForm";
            this.Text = "StoolForm";
            this.stoolTopGroupBox.ResumeLayout(false);
            this.stoolTopGroupBox.PerformLayout();
            this.stoolLegsGroupBox.ResumeLayout(false);
            this.stoolLegsGroupBox.PerformLayout();
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
    }
}

