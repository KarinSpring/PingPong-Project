namespace PongProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.playGround = new System.Windows.Forms.Panel();
            this.pctRacket = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovsBall = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.playGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRacket)).BeginInit();
            this.SuspendLayout();
            // 
            // playGround
            // 
            this.playGround.BackColor = System.Drawing.Color.Black;
            this.playGround.Controls.Add(this.pctRacket);
            this.playGround.Controls.Add(this.shapeContainer1);
            this.playGround.Location = new System.Drawing.Point(13, 13);
            this.playGround.Name = "playGround";
            this.playGround.Size = new System.Drawing.Size(556, 320);
            this.playGround.TabIndex = 0;
            // 
            // pctRacket
            // 
            this.pctRacket.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pctRacket.Location = new System.Drawing.Point(514, -1);
            this.pctRacket.Name = "pctRacket";
            this.pctRacket.Size = new System.Drawing.Size(10, 50);
            this.pctRacket.TabIndex = 1;
            this.pctRacket.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovsBall});
            this.shapeContainer1.Size = new System.Drawing.Size(556, 320);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // ovsBall
            // 
            this.ovsBall.BackColor = System.Drawing.Color.PapayaWhip;
            this.ovsBall.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovsBall.FillColor = System.Drawing.Color.Transparent;
            this.ovsBall.FillGradientColor = System.Drawing.Color.Transparent;
            this.ovsBall.Location = new System.Drawing.Point(0, 0);
            this.ovsBall.Name = "ovsBall";
            this.ovsBall.SelectionColor = System.Drawing.SystemColors.ControlDark;
            this.ovsBall.Size = new System.Drawing.Size(25, 25);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 362);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 49);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Spiel starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 20;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Punkte";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(165, 362);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(105, 49);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Neustart";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(433, 380);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(13, 13);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "0";
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUp.BackgroundImage")));
            this.btnUp.Location = new System.Drawing.Point(635, 93);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(55, 55);
            this.btnUp.TabIndex = 6;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUp_MouseClick);
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDown.BackgroundImage")));
            this.btnDown.Location = new System.Drawing.Point(635, 204);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(55, 55);
            this.btnDown.TabIndex = 7;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDown_MouseClick);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLeft.BackgroundImage")));
            this.btnLeft.Location = new System.Drawing.Point(575, 151);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(55, 55);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseClick);
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRight.BackgroundImage")));
            this.btnRight.Location = new System.Drawing.Point(698, 151);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(55, 55);
            this.btnRight.TabIndex = 9;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 464);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.playGround);
            this.Name = "Form2";
            this.Text = "Form2";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            this.playGround.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctRacket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel playGround;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovsBall;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pctRacket;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
    }
}