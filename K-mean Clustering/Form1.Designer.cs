namespace K_mean_Clustering
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnInitializeCluster = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAssignDataPointsToCloserCluster = new System.Windows.Forms.Button();
            this.btnCalculateCenterOfEachCluster = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGoodRandom = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.tfNumberOfCluster = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindTheResult = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tfNumberOfDataPoints = new System.Windows.Forms.TextBox();
            this.btnInitializeClusterWithImproving = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(854, 156);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnInitializeCluster
            // 
            this.btnInitializeCluster.Location = new System.Drawing.Point(854, 185);
            this.btnInitializeCluster.Name = "btnInitializeCluster";
            this.btnInitializeCluster.Size = new System.Drawing.Size(126, 23);
            this.btnInitializeCluster.TabIndex = 1;
            this.btnInitializeCluster.Text = "Initialize Cluster";
            this.btnInitializeCluster.UseVisualStyleBackColor = true;
            this.btnInitializeCluster.Click += new System.EventHandler(this.btnInitializeCluster_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 627);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAssignDataPointsToCloserCluster
            // 
            this.btnAssignDataPointsToCloserCluster.Location = new System.Drawing.Point(853, 302);
            this.btnAssignDataPointsToCloserCluster.Name = "btnAssignDataPointsToCloserCluster";
            this.btnAssignDataPointsToCloserCluster.Size = new System.Drawing.Size(183, 23);
            this.btnAssignDataPointsToCloserCluster.TabIndex = 3;
            this.btnAssignDataPointsToCloserCluster.Text = "Assign data points to closer cluster";
            this.btnAssignDataPointsToCloserCluster.UseVisualStyleBackColor = true;
            this.btnAssignDataPointsToCloserCluster.Click += new System.EventHandler(this.btnIterate_Click);
            // 
            // btnCalculateCenterOfEachCluster
            // 
            this.btnCalculateCenterOfEachCluster.Location = new System.Drawing.Point(853, 331);
            this.btnCalculateCenterOfEachCluster.Name = "btnCalculateCenterOfEachCluster";
            this.btnCalculateCenterOfEachCluster.Size = new System.Drawing.Size(183, 23);
            this.btnCalculateCenterOfEachCluster.TabIndex = 6;
            this.btnCalculateCenterOfEachCluster.Text = "Calculate center of each cluster";
            this.btnCalculateCenterOfEachCluster.UseVisualStyleBackColor = true;
            this.btnCalculateCenterOfEachCluster.Click += new System.EventHandler(this.btnCalculateCenterOfEachCluster_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGoodRandom);
            this.groupBox1.Controls.Add(this.rbRandom);
            this.groupBox1.Location = new System.Drawing.Point(854, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 66);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Points";
            // 
            // rbGoodRandom
            // 
            this.rbGoodRandom.AutoSize = true;
            this.rbGoodRandom.Location = new System.Drawing.Point(14, 42);
            this.rbGoodRandom.Name = "rbGoodRandom";
            this.rbGoodRandom.Size = new System.Drawing.Size(89, 17);
            this.rbGoodRandom.TabIndex = 1;
            this.rbGoodRandom.Text = "Good random";
            this.rbGoodRandom.UseVisualStyleBackColor = true;
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Checked = true;
            this.rbRandom.Location = new System.Drawing.Point(14, 19);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(65, 17);
            this.rbRandom.TabIndex = 0;
            this.rbRandom.TabStop = true;
            this.rbRandom.Text = "Random";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // tfNumberOfCluster
            // 
            this.tfNumberOfCluster.Location = new System.Drawing.Point(978, 55);
            this.tfNumberOfCluster.Name = "tfNumberOfCluster";
            this.tfNumberOfCluster.Size = new System.Drawing.Size(39, 20);
            this.tfNumberOfCluster.TabIndex = 8;
            this.tfNumberOfCluster.Text = "4";
            this.tfNumberOfCluster.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(851, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cluster Number :";
            // 
            // btnFindTheResult
            // 
            this.btnFindTheResult.Location = new System.Drawing.Point(854, 377);
            this.btnFindTheResult.Name = "btnFindTheResult";
            this.btnFindTheResult.Size = new System.Drawing.Size(183, 23);
            this.btnFindTheResult.TabIndex = 10;
            this.btnFindTheResult.Text = "Find the result";
            this.btnFindTheResult.UseVisualStyleBackColor = true;
            this.btnFindTheResult.Click += new System.EventHandler(this.btnFindTheResult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(850, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Number Of Data Points :";
            // 
            // tfNumberOfDataPoints
            // 
            this.tfNumberOfDataPoints.Location = new System.Drawing.Point(978, 26);
            this.tfNumberOfDataPoints.Name = "tfNumberOfDataPoints";
            this.tfNumberOfDataPoints.Size = new System.Drawing.Size(39, 20);
            this.tfNumberOfDataPoints.TabIndex = 12;
            this.tfNumberOfDataPoints.Text = "1000";
            this.tfNumberOfDataPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnInitializeClusterWithImproving
            // 
            this.btnInitializeClusterWithImproving.Location = new System.Drawing.Point(854, 214);
            this.btnInitializeClusterWithImproving.Name = "btnInitializeClusterWithImproving";
            this.btnInitializeClusterWithImproving.Size = new System.Drawing.Size(182, 23);
            this.btnInitializeClusterWithImproving.TabIndex = 13;
            this.btnInitializeClusterWithImproving.Text = "Initialize Cluster With Improving";
            this.btnInitializeClusterWithImproving.UseVisualStyleBackColor = true;
            this.btnInitializeClusterWithImproving.Click += new System.EventHandler(this.btnInitializeClusterWithImproving_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 651);
            this.Controls.Add(this.btnInitializeClusterWithImproving);
            this.Controls.Add(this.tfNumberOfDataPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFindTheResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tfNumberOfCluster);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculateCenterOfEachCluster);
            this.Controls.Add(this.btnAssignDataPointsToCloserCluster);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInitializeCluster);
            this.Controls.Add(this.btnReset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnInitializeCluster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAssignDataPointsToCloserCluster;
        private System.Windows.Forms.Button btnCalculateCenterOfEachCluster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGoodRandom;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.TextBox tfNumberOfCluster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindTheResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tfNumberOfDataPoints;
        private System.Windows.Forms.Button btnInitializeClusterWithImproving;
    }
}

