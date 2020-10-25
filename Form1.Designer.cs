namespace ComputerForensicsHasher
{
    partial class btnLogThis
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
            this.components = new System.ComponentModel.Container();
            this.btnChoosefolder = new System.Windows.Forms.Button();
            this.txtHashDisplay = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaseNum = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChoosefolder
            // 
            this.btnChoosefolder.Location = new System.Drawing.Point(118, 68);
            this.btnChoosefolder.Name = "btnChoosefolder";
            this.btnChoosefolder.Size = new System.Drawing.Size(235, 54);
            this.btnChoosefolder.TabIndex = 0;
            this.btnChoosefolder.Text = "choose folder";
            this.btnChoosefolder.UseVisualStyleBackColor = true;
            this.btnChoosefolder.Click += new System.EventHandler(this.btnChoosefolder_Click);
            // 
            // txtHashDisplay
            // 
            this.txtHashDisplay.Location = new System.Drawing.Point(634, 77);
            this.txtHashDisplay.Multiline = true;
            this.txtHashDisplay.Name = "txtHashDisplay";
            this.txtHashDisplay.Size = new System.Drawing.Size(561, 649);
            this.txtHashDisplay.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hash:";
            // 
            // txtCaseNum
            // 
            this.txtCaseNum.Location = new System.Drawing.Point(202, 201);
            this.txtCaseNum.Name = "txtCaseNum";
            this.txtCaseNum.Size = new System.Drawing.Size(422, 38);
            this.txtCaseNum.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(202, 314);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(422, 38);
            this.txtDescription.TabIndex = 5;
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(202, 425);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(422, 38);
            this.txtDateTime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-5, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "CaseNumber:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-5, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-5, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "DateTime:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "Log";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-5, 525);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(202, 519);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(422, 38);
            this.txtLocation.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Logging A folder:";
            // 
            // btnLogThis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2225, 899);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDateTime);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCaseNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHashDisplay);
            this.Controls.Add(this.btnChoosefolder);
            this.Name = "btnLogThis";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoosefolder;
        private System.Windows.Forms.TextBox txtHashDisplay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaseNum;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label6;
    }
}

