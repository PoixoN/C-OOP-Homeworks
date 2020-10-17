namespace Geometry
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
            this.btnReset = new System.Windows.Forms.Button();
            this.lbSideA = new System.Windows.Forms.Label();
            this.lbSideB = new System.Windows.Forms.Label();
            this.lbSideC = new System.Windows.Forms.Label();
            this.tbSideA = new System.Windows.Forms.TextBox();
            this.tbSideB = new System.Windows.Forms.TextBox();
            this.tbSideC = new System.Windows.Forms.TextBox();
            this.lbAngles = new System.Windows.Forms.Label();
            this.lbPerim = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(238, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(145, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(87, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbSideA
            // 
            this.lbSideA.AutoSize = true;
            this.lbSideA.Location = new System.Drawing.Point(11, 49);
            this.lbSideA.Name = "lbSideA";
            this.lbSideA.Size = new System.Drawing.Size(38, 13);
            this.lbSideA.TabIndex = 2;
            this.lbSideA.Text = "Side A";
            // 
            // lbSideB
            // 
            this.lbSideB.AutoSize = true;
            this.lbSideB.Location = new System.Drawing.Point(11, 85);
            this.lbSideB.Name = "lbSideB";
            this.lbSideB.Size = new System.Drawing.Size(38, 13);
            this.lbSideB.TabIndex = 3;
            this.lbSideB.Text = "Side B";
            // 
            // lbSideC
            // 
            this.lbSideC.AutoSize = true;
            this.lbSideC.Location = new System.Drawing.Point(11, 123);
            this.lbSideC.Name = "lbSideC";
            this.lbSideC.Size = new System.Drawing.Size(38, 13);
            this.lbSideC.TabIndex = 4;
            this.lbSideC.Text = "Side C";
            // 
            // tbSideA
            // 
            this.tbSideA.Location = new System.Drawing.Point(77, 46);
            this.tbSideA.Name = "tbSideA";
            this.tbSideA.Size = new System.Drawing.Size(100, 20);
            this.tbSideA.TabIndex = 5;
            this.tbSideA.Text = "0";
            // 
            // tbSideB
            // 
            this.tbSideB.Location = new System.Drawing.Point(77, 85);
            this.tbSideB.Name = "tbSideB";
            this.tbSideB.Size = new System.Drawing.Size(100, 20);
            this.tbSideB.TabIndex = 6;
            this.tbSideB.Text = "0";
            // 
            // tbSideC
            // 
            this.tbSideC.Location = new System.Drawing.Point(77, 123);
            this.tbSideC.Name = "tbSideC";
            this.tbSideC.Size = new System.Drawing.Size(100, 20);
            this.tbSideC.TabIndex = 7;
            this.tbSideC.Text = "0";
            // 
            // lbAngles
            // 
            this.lbAngles.AutoSize = true;
            this.lbAngles.Location = new System.Drawing.Point(203, 88);
            this.lbAngles.Name = "lbAngles";
            this.lbAngles.Size = new System.Drawing.Size(52, 13);
            this.lbAngles.TabIndex = 10;
            this.lbAngles.Text = "Angles is ";
            // 
            // lbPerim
            // 
            this.lbPerim.AutoSize = true;
            this.lbPerim.Location = new System.Drawing.Point(203, 49);
            this.lbPerim.Name = "lbPerim";
            this.lbPerim.Size = new System.Drawing.Size(64, 13);
            this.lbPerim.TabIndex = 11;
            this.lbPerim.Text = "Perimeter is ";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(331, 49);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(0, 13);
            this.lbArea.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 182);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbPerim);
            this.Controls.Add(this.lbAngles);
            this.Controls.Add(this.tbSideC);
            this.Controls.Add(this.tbSideB);
            this.Controls.Add(this.tbSideA);
            this.Controls.Add(this.lbSideC);
            this.Controls.Add(this.lbSideB);
            this.Controls.Add(this.lbSideA);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Geometry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lbSideA;
        private System.Windows.Forms.Label lbSideB;
        private System.Windows.Forms.Label lbSideC;
        private System.Windows.Forms.TextBox tbSideA;
        private System.Windows.Forms.TextBox tbSideB;
        private System.Windows.Forms.TextBox tbSideC;
        private System.Windows.Forms.Label lbAngles;
        private System.Windows.Forms.Label lbPerim;
        private System.Windows.Forms.Label lbArea;
    }
}

