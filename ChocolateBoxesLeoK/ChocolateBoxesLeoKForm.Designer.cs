namespace ChocolateBoxesLeoK
{
    partial class frmChocolateBoxesLeoK
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
            this.nudBoxesSold = new System.Windows.Forms.NumericUpDown();
            this.lblRequest = new System.Windows.Forms.Label();
            this.btnGetReward = new System.Windows.Forms.Button();
            this.lblConclusion = new System.Windows.Forms.Label();
            this.lblPrize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxesSold)).BeginInit();
            this.SuspendLayout();
            // 
            // nudBoxesSold
            // 
            this.nudBoxesSold.Location = new System.Drawing.Point(438, 39);
            this.nudBoxesSold.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudBoxesSold.Name = "nudBoxesSold";
            this.nudBoxesSold.Size = new System.Drawing.Size(39, 20);
            this.nudBoxesSold.TabIndex = 0;
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequest.Location = new System.Drawing.Point(4, 36);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(428, 20);
            this.lblRequest.TabIndex = 1;
            this.lblRequest.Text = "Please enter the number of choclate boxes you sold:";
            // 
            // btnGetReward
            // 
            this.btnGetReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetReward.Location = new System.Drawing.Point(171, 94);
            this.btnGetReward.Name = "btnGetReward";
            this.btnGetReward.Size = new System.Drawing.Size(128, 35);
            this.btnGetReward.TabIndex = 2;
            this.btnGetReward.Text = "Get Reward!";
            this.btnGetReward.UseVisualStyleBackColor = true;
            this.btnGetReward.Click += new System.EventHandler(this.btnGetReward_Click);
            // 
            // lblConclusion
            // 
            this.lblConclusion.AutoSize = true;
            this.lblConclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConclusion.Location = new System.Drawing.Point(79, 199);
            this.lblConclusion.Name = "lblConclusion";
            this.lblConclusion.Size = new System.Drawing.Size(129, 20);
            this.lblConclusion.TabIndex = 3;
            this.lblConclusion.Text = "Your reward is:";
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrize.Location = new System.Drawing.Point(245, 199);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(0, 20);
            this.lblPrize.TabIndex = 4;
            // 
            // frmChocolateBoxesLeoK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 261);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.lblConclusion);
            this.Controls.Add(this.btnGetReward);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.nudBoxesSold);
            this.Name = "frmChocolateBoxesLeoK";
            this.Text = "Chocolate Boxes by Leo Kay";
            ((System.ComponentModel.ISupportInitialize)(this.nudBoxesSold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudBoxesSold;
        private System.Windows.Forms.Label lblRequest;
        private System.Windows.Forms.Button btnGetReward;
        private System.Windows.Forms.Label lblConclusion;
        private System.Windows.Forms.Label lblPrize;
    }
}

