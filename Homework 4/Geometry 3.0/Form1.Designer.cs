namespace Geometry_3._0
{
    partial class Form1
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbSideA = new System.Windows.Forms.Label();
            this.lbSideB = new System.Windows.Forms.Label();
            this.lbPerim = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.lbAngleAB = new System.Windows.Forms.Label();
            this.tbSideA = new System.Windows.Forms.TextBox();
            this.tbSideB = new System.Windows.Forms.TextBox();
            this.tbAngleAB = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(170, 98);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbSideA
            // 
            this.lbSideA.AutoSize = true;
            this.lbSideA.Location = new System.Drawing.Point(9, 14);
            this.lbSideA.Name = "lbSideA";
            this.lbSideA.Size = new System.Drawing.Size(38, 13);
            this.lbSideA.TabIndex = 1;
            this.lbSideA.Text = "Side A";
            // 
            // lbSideB
            // 
            this.lbSideB.AutoSize = true;
            this.lbSideB.Location = new System.Drawing.Point(9, 65);
            this.lbSideB.Name = "lbSideB";
            this.lbSideB.Size = new System.Drawing.Size(38, 13);
            this.lbSideB.TabIndex = 2;
            this.lbSideB.Text = "Side B";
            // 
            // lbPerim
            // 
            this.lbPerim.AutoSize = true;
            this.lbPerim.Location = new System.Drawing.Point(167, 33);
            this.lbPerim.Name = "lbPerim";
            this.lbPerim.Size = new System.Drawing.Size(64, 13);
            this.lbPerim.TabIndex = 3;
            this.lbPerim.Text = "Perimeter is ";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(167, 65);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(42, 13);
            this.lbArea.TabIndex = 4;
            this.lbArea.Text = "Area is ";
            // 
            // lbAngleAB
            // 
            this.lbAngleAB.AutoSize = true;
            this.lbAngleAB.Location = new System.Drawing.Point(9, 120);
            this.lbAngleAB.Name = "lbAngleAB";
            this.lbAngleAB.Size = new System.Drawing.Size(119, 13);
            this.lbAngleAB.TabIndex = 5;
            this.lbAngleAB.Text = "Angle between A and B";
            // 
            // tbSideA
            // 
            this.tbSideA.Location = new System.Drawing.Point(12, 30);
            this.tbSideA.Name = "tbSideA";
            this.tbSideA.Size = new System.Drawing.Size(116, 20);
            this.tbSideA.TabIndex = 6;
            this.tbSideA.Text = "0";
            // 
            // tbSideB
            // 
            this.tbSideB.Location = new System.Drawing.Point(12, 81);
            this.tbSideB.Name = "tbSideB";
            this.tbSideB.Size = new System.Drawing.Size(116, 20);
            this.tbSideB.TabIndex = 7;
            this.tbSideB.Text = "0";
            // 
            // tbAngleAB
            // 
            this.tbAngleAB.Location = new System.Drawing.Point(12, 136);
            this.tbAngleAB.Name = "tbAngleAB";
            this.tbAngleAB.Size = new System.Drawing.Size(116, 20);
            this.tbAngleAB.TabIndex = 8;
            this.tbAngleAB.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(170, 133);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 187);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbAngleAB);
            this.Controls.Add(this.tbSideB);
            this.Controls.Add(this.tbSideA);
            this.Controls.Add(this.lbAngleAB);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbPerim);
            this.Controls.Add(this.lbSideB);
            this.Controls.Add(this.lbSideA);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Geometry 3.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbSideA;
        private System.Windows.Forms.Label lbSideB;
        private System.Windows.Forms.Label lbPerim;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label lbAngleAB;
        private System.Windows.Forms.TextBox tbSideA;
        private System.Windows.Forms.TextBox tbSideB;
        private System.Windows.Forms.TextBox tbAngleAB;
        private System.Windows.Forms.Button btnReset;
    }
}

