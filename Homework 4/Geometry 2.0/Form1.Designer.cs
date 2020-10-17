namespace Geometry_2._0
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
            this.cbShapes = new System.Windows.Forms.ComboBox();
            this.tbParam1 = new System.Windows.Forms.TextBox();
            this.tbParam2 = new System.Windows.Forms.TextBox();
            this.tbParam3 = new System.Windows.Forms.TextBox();
            this.lbPerim = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.lbParam1 = new System.Windows.Forms.Label();
            this.lbParam2 = new System.Windows.Forms.Label();
            this.lbParam3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbShapes
            // 
            this.cbShapes.FormattingEnabled = true;
            this.cbShapes.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Square",
            "Diamond",
            "Rectangle"});
            this.cbShapes.Location = new System.Drawing.Point(12, 21);
            this.cbShapes.Name = "cbShapes";
            this.cbShapes.Size = new System.Drawing.Size(121, 21);
            this.cbShapes.TabIndex = 0;
            this.cbShapes.Text = "Choose a shape";
            this.cbShapes.SelectedIndexChanged += new System.EventHandler(this.cbShapes_SelectedIndexChanged);
            // 
            // tbParam1
            // 
            this.tbParam1.Location = new System.Drawing.Point(173, 21);
            this.tbParam1.Name = "tbParam1";
            this.tbParam1.Size = new System.Drawing.Size(100, 20);
            this.tbParam1.TabIndex = 1;
            this.tbParam1.Text = "0";
            this.tbParam1.Visible = false;
            // 
            // tbParam2
            // 
            this.tbParam2.Location = new System.Drawing.Point(173, 61);
            this.tbParam2.Name = "tbParam2";
            this.tbParam2.Size = new System.Drawing.Size(100, 20);
            this.tbParam2.TabIndex = 2;
            this.tbParam2.Text = "0";
            this.tbParam2.Visible = false;
            // 
            // tbParam3
            // 
            this.tbParam3.Location = new System.Drawing.Point(173, 102);
            this.tbParam3.Name = "tbParam3";
            this.tbParam3.Size = new System.Drawing.Size(100, 20);
            this.tbParam3.TabIndex = 3;
            this.tbParam3.Text = "0";
            this.tbParam3.Visible = false;
            // 
            // lbPerim
            // 
            this.lbPerim.AutoSize = true;
            this.lbPerim.Location = new System.Drawing.Point(13, 59);
            this.lbPerim.Name = "lbPerim";
            this.lbPerim.Size = new System.Drawing.Size(64, 13);
            this.lbPerim.TabIndex = 4;
            this.lbPerim.Text = "Perimeter is ";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(13, 87);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(42, 13);
            this.lbArea.TabIndex = 5;
            this.lbArea.Text = "Area is ";
            // 
            // lbParam1
            // 
            this.lbParam1.AutoSize = true;
            this.lbParam1.Location = new System.Drawing.Point(279, 24);
            this.lbParam1.Name = "lbParam1";
            this.lbParam1.Size = new System.Drawing.Size(64, 13);
            this.lbParam1.TabIndex = 6;
            this.lbParam1.Text = "Parameter 1";
            this.lbParam1.Visible = false;
            // 
            // lbParam2
            // 
            this.lbParam2.AutoSize = true;
            this.lbParam2.Location = new System.Drawing.Point(279, 64);
            this.lbParam2.Name = "lbParam2";
            this.lbParam2.Size = new System.Drawing.Size(64, 13);
            this.lbParam2.TabIndex = 7;
            this.lbParam2.Text = "Parameter 2";
            this.lbParam2.Visible = false;
            // 
            // lbParam3
            // 
            this.lbParam3.AutoSize = true;
            this.lbParam3.Location = new System.Drawing.Point(280, 105);
            this.lbParam3.Name = "lbParam3";
            this.lbParam3.Size = new System.Drawing.Size(64, 13);
            this.lbParam3.TabIndex = 8;
            this.lbParam3.Text = "Parameter 3";
            this.lbParam3.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Location = new System.Drawing.Point(12, 115);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 150);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbParam3);
            this.Controls.Add(this.lbParam2);
            this.Controls.Add(this.lbParam1);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbPerim);
            this.Controls.Add(this.tbParam3);
            this.Controls.Add(this.tbParam2);
            this.Controls.Add(this.tbParam1);
            this.Controls.Add(this.cbShapes);
            this.Name = "Form1";
            this.Text = "Geometry 2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbShapes;
        private System.Windows.Forms.TextBox tbParam1;
        private System.Windows.Forms.TextBox tbParam2;
        private System.Windows.Forms.TextBox tbParam3;
        private System.Windows.Forms.Label lbPerim;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label lbParam1;
        private System.Windows.Forms.Label lbParam2;
        private System.Windows.Forms.Label lbParam3;
        private System.Windows.Forms.Button btnCalculate;
    }
}

