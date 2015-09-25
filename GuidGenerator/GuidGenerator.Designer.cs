namespace GuidGenerator
{
    partial class GuidGenerator
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txbGuids = new System.Windows.Forms.TextBox();
            this.Counter = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Counter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 344);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txbGuids
            // 
            this.txbGuids.Location = new System.Drawing.Point(12, 12);
            this.txbGuids.Multiline = true;
            this.txbGuids.Name = "txbGuids";
            this.txbGuids.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbGuids.Size = new System.Drawing.Size(290, 326);
            this.txbGuids.TabIndex = 1;
            // 
            // Counter
            // 
            this.Counter.Location = new System.Drawing.Point(93, 347);
            this.Counter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(56, 20);
            this.Counter.TabIndex = 2;
            this.Counter.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // GuidGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 379);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.txbGuids);
            this.Controls.Add(this.btnGenerate);
            this.Name = "GuidGenerator";
            this.Text = "GuidGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.Counter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txbGuids;
        private System.Windows.Forms.NumericUpDown Counter;
    }
}

