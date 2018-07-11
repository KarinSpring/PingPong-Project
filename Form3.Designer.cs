namespace PongProject
{
    partial class Form3
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
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(27, 28);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(44, 13);
            this.lblPoints.TabIndex = 0;
            this.lblPoints.Text = "Punkte:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(166, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPoint.Location = new System.Drawing.Point(30, 62);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(15, 15);
            this.lblPoint.TabIndex = 2;
            this.lblPoint.Text = "0";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(27, 111);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(28, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "liste ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(169, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(30, 263);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Eintragen";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(227, 263);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Zurück zum Hauptmenü";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 338);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPoints);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClose;
    }
}