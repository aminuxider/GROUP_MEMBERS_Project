namespace HigherLuck
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
            this.grpInit = new System.Windows.Forms.GroupBox();
            this.lblRounds = new System.Windows.Forms.Label();
            this.nudRounds = new System.Windows.Forms.NumericUpDown();
            this.lblName1 = new System.Windows.Forms.Label();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.lblRoundsCaption = new System.Windows.Forms.Label();
            this.lblRoundsLeft = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.pbDice = new System.Windows.Forms.PictureBox();
            this.lblRollInfo = new System.Windows.Forms.Label();
            this.grpAvatars = new System.Windows.Forms.GroupBox();
            this.rbAvatar1 = new System.Windows.Forms.RadioButton();
            this.rbAvatar2 = new System.Windows.Forms.RadioButton();
            this.rbAvatar3 = new System.Windows.Forms.RadioButton();
            this.rbAvatar4 = new System.Windows.Forms.RadioButton();
            this.btnSetup1 = new System.Windows.Forms.Button();
            this.btnSetup2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpPlayer1 = new System.Windows.Forms.GroupBox();
            this.pbPlayer1 = new System.Windows.Forms.PictureBox();
            this.lblPointCaption1 = new System.Windows.Forms.Label();
            this.lblPoints1 = new System.Windows.Forms.Label();
            this.grpPlayer2 = new System.Windows.Forms.GroupBox();
            this.pbPlayer2 = new System.Windows.Forms.PictureBox();
            this.lblPointCaption2 = new System.Windows.Forms.Label();
            this.lblPoints2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.lblTeam = new System.Windows.Forms.Label();
            this.grpInit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRounds)).BeginInit();
            this.grpAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).BeginInit();
            this.grpAvatars.SuspendLayout();
            this.grpPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).BeginInit();
            this.grpPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).BeginInit();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInit
            // 
            this.grpInit.Controls.Add(this.txtName2);
            this.grpInit.Controls.Add(this.lblName2);
            this.grpInit.Controls.Add(this.txtName1);
            this.grpInit.Controls.Add(this.lblName1);
            this.grpInit.Controls.Add(this.nudRounds);
            this.grpInit.Controls.Add(this.lblRounds);
            this.grpInit.Location = new System.Drawing.Point(12, 12);
            this.grpInit.Name = "grpInit";
            this.grpInit.Size = new System.Drawing.Size(235, 130);
            this.grpInit.TabIndex = 0;
            this.grpInit.TabStop = false;
            this.grpInit.Text = "Initializations";
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Location = new System.Drawing.Point(12, 30);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(43, 13);
            this.lblRounds.TabIndex = 0;
            this.lblRounds.Text = "Rounds";
            // 
            // nudRounds
            // 
            this.nudRounds.Location = new System.Drawing.Point(130, 26);
            this.nudRounds.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudRounds.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRounds.Name = "nudRounds";
            this.nudRounds.Size = new System.Drawing.Size(90, 20);
            this.nudRounds.TabIndex = 1;
            this.nudRounds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(12, 66);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(92, 13);
            this.lblName1.TabIndex = 2;
            this.lblName1.Text = "First Player Name";
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(130, 63);
            this.txtName1.MaxLength = 15;
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(90, 20);
            this.txtName1.TabIndex = 3;
            this.txtName1.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(12, 99);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(112, 13);
            this.lblName2.TabIndex = 4;
            this.lblName2.Text = "Second Player Name";
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(130, 96);
            this.txtName2.MaxLength = 15;
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(90, 20);
            this.txtName2.TabIndex = 5;
            this.txtName2.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.lblRollInfo);
            this.grpAction.Controls.Add(this.pbDice);
            this.grpAction.Controls.Add(this.btnRoll);
            this.grpAction.Controls.Add(this.lblTurn);
            this.grpAction.Controls.Add(this.lblRoundsLeft);
            this.grpAction.Controls.Add(this.lblRoundsCaption);
            this.grpAction.Location = new System.Drawing.Point(12, 150);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(235, 240);
            this.grpAction.TabIndex = 1;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "Action";
            // 
            // lblRoundsCaption
            // 
            this.lblRoundsCaption.AutoSize = true;
            this.lblRoundsCaption.Location = new System.Drawing.Point(12, 26);
            this.lblRoundsCaption.Name = "lblRoundsCaption";
            this.lblRoundsCaption.Size = new System.Drawing.Size(61, 13);
            this.lblRoundsCaption.TabIndex = 0;
            this.lblRoundsCaption.Text = "Rounds left";
            // 
            // lblRoundsLeft
            // 
            this.lblRoundsLeft.AutoSize = true;
            this.lblRoundsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundsLeft.Location = new System.Drawing.Point(130, 25);
            this.lblRoundsLeft.Name = "lblRoundsLeft";
            this.lblRoundsLeft.Size = new System.Drawing.Size(16, 16);
            this.lblRoundsLeft.TabIndex = 1;
            this.lblRoundsLeft.Text = "0";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoEllipsis = true;
            this.lblTurn.BackColor = System.Drawing.Color.Black;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(12, 52);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(211, 26);
            this.lblTurn.TabIndex = 2;
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRoll
            // 
            this.btnRoll.BackColor = System.Drawing.Color.Gold;
            this.btnRoll.Enabled = false;
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(12, 86);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(211, 32);
            this.btnRoll.TabIndex = 3;
            this.btnRoll.Text = "ROLL";
            this.btnRoll.UseVisualStyleBackColor = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // pbDice
            // 
            this.pbDice.Location = new System.Drawing.Point(69, 122);
            this.pbDice.Name = "pbDice";
            this.pbDice.Size = new System.Drawing.Size(96, 96);
            this.pbDice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDice.TabIndex = 4;
            this.pbDice.TabStop = false;
            // 
            // lblRollInfo
            // 
            this.lblRollInfo.AutoEllipsis = true;
            this.lblRollInfo.Location = new System.Drawing.Point(6, 219);
            this.lblRollInfo.Name = "lblRollInfo";
            this.lblRollInfo.Size = new System.Drawing.Size(223, 16);
            this.lblRollInfo.TabIndex = 5;
            this.lblRollInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpAvatars
            // 
            this.grpAvatars.Controls.Add(this.rbAvatar4);
            this.grpAvatars.Controls.Add(this.rbAvatar3);
            this.grpAvatars.Controls.Add(this.rbAvatar2);
            this.grpAvatars.Controls.Add(this.rbAvatar1);
            this.grpAvatars.Location = new System.Drawing.Point(255, 12);
            this.grpAvatars.Name = "grpAvatars";
            this.grpAvatars.Size = new System.Drawing.Size(150, 262);
            this.grpAvatars.TabIndex = 2;
            this.grpAvatars.TabStop = false;
            this.grpAvatars.Text = "Avatars";
            // 
            // rbAvatar1
            // 
            this.rbAvatar1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbAvatar1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAvatar1.Location = new System.Drawing.Point(14, 24);
            this.rbAvatar1.Name = "rbAvatar1";
            this.rbAvatar1.Size = new System.Drawing.Size(120, 52);
            this.rbAvatar1.TabIndex = 0;
            this.rbAvatar1.TabStop = true;
            this.rbAvatar1.UseVisualStyleBackColor = true;
            // 
            // rbAvatar2
            // 
            this.rbAvatar2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbAvatar2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAvatar2.Location = new System.Drawing.Point(14, 81);
            this.rbAvatar2.Name = "rbAvatar2";
            this.rbAvatar2.Size = new System.Drawing.Size(120, 52);
            this.rbAvatar2.TabIndex = 1;
            this.rbAvatar2.UseVisualStyleBackColor = true;
            // 
            // rbAvatar3
            // 
            this.rbAvatar3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbAvatar3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAvatar3.Location = new System.Drawing.Point(14, 138);
            this.rbAvatar3.Name = "rbAvatar3";
            this.rbAvatar3.Size = new System.Drawing.Size(120, 52);
            this.rbAvatar3.TabIndex = 2;
            this.rbAvatar3.UseVisualStyleBackColor = true;
            // 
            // rbAvatar4
            // 
            this.rbAvatar4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbAvatar4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAvatar4.Location = new System.Drawing.Point(14, 195);
            this.rbAvatar4.Name = "rbAvatar4";
            this.rbAvatar4.Size = new System.Drawing.Size(120, 52);
            this.rbAvatar4.TabIndex = 3;
            this.rbAvatar4.UseVisualStyleBackColor = true;
            // 
            // btnSetup1
            // 
            this.btnSetup1.Enabled = false;
            this.btnSetup1.Location = new System.Drawing.Point(255, 282);
            this.btnSetup1.Name = "btnSetup1";
            this.btnSetup1.Size = new System.Drawing.Size(150, 32);
            this.btnSetup1.TabIndex = 3;
            this.btnSetup1.Text = "Set Up First Player";
            this.btnSetup1.UseVisualStyleBackColor = true;
            this.btnSetup1.Click += new System.EventHandler(this.btnSetup1_Click);
            // 
            // btnSetup2
            // 
            this.btnSetup2.Enabled = false;
            this.btnSetup2.Location = new System.Drawing.Point(255, 320);
            this.btnSetup2.Name = "btnSetup2";
            this.btnSetup2.Size = new System.Drawing.Size(150, 32);
            this.btnSetup2.TabIndex = 4;
            this.btnSetup2.Text = "Set Up Second Player";
            this.btnSetup2.UseVisualStyleBackColor = true;
            this.btnSetup2.Click += new System.EventHandler(this.btnSetup2_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightCoral;
            this.btnReset.Location = new System.Drawing.Point(255, 358);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 32);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET ALL";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpPlayer1
            // 
            this.grpPlayer1.Controls.Add(this.lblPoints1);
            this.grpPlayer1.Controls.Add(this.lblPointCaption1);
            this.grpPlayer1.Controls.Add(this.pbPlayer1);
            this.grpPlayer1.Location = new System.Drawing.Point(413, 12);
            this.grpPlayer1.Name = "grpPlayer1";
            this.grpPlayer1.Size = new System.Drawing.Size(150, 126);
            this.grpPlayer1.TabIndex = 6;
            this.grpPlayer1.TabStop = false;
            this.grpPlayer1.Text = "First Player";
            // 
            // pbPlayer1
            // 
            this.pbPlayer1.Location = new System.Drawing.Point(10, 26);
            this.pbPlayer1.Name = "pbPlayer1";
            this.pbPlayer1.Size = new System.Drawing.Size(72, 72);
            this.pbPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer1.TabIndex = 0;
            this.pbPlayer1.TabStop = false;
            // 
            // lblPointCaption1
            // 
            this.lblPointCaption1.AutoSize = true;
            this.lblPointCaption1.Location = new System.Drawing.Point(94, 26);
            this.lblPointCaption1.Name = "lblPointCaption1";
            this.lblPointCaption1.Size = new System.Drawing.Size(31, 13);
            this.lblPointCaption1.TabIndex = 1;
            this.lblPointCaption1.Text = "Point";
            // 
            // lblPoints1
            // 
            this.lblPoints1.AutoSize = true;
            this.lblPoints1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints1.Location = new System.Drawing.Point(88, 42);
            this.lblPoints1.Name = "lblPoints1";
            this.lblPoints1.Size = new System.Drawing.Size(55, 46);
            this.lblPoints1.TabIndex = 2;
            this.lblPoints1.Text = "0";
            // 
            // grpPlayer2
            // 
            this.grpPlayer2.Controls.Add(this.lblPoints2);
            this.grpPlayer2.Controls.Add(this.lblPointCaption2);
            this.grpPlayer2.Controls.Add(this.pbPlayer2);
            this.grpPlayer2.Location = new System.Drawing.Point(413, 148);
            this.grpPlayer2.Name = "grpPlayer2";
            this.grpPlayer2.Size = new System.Drawing.Size(150, 126);
            this.grpPlayer2.TabIndex = 7;
            this.grpPlayer2.TabStop = false;
            this.grpPlayer2.Text = "Second Player";
            // 
            // pbPlayer2
            // 
            this.pbPlayer2.Location = new System.Drawing.Point(10, 26);
            this.pbPlayer2.Name = "pbPlayer2";
            this.pbPlayer2.Size = new System.Drawing.Size(72, 72);
            this.pbPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayer2.TabIndex = 0;
            this.pbPlayer2.TabStop = false;
            // 
            // lblPointCaption2
            // 
            this.lblPointCaption2.AutoSize = true;
            this.lblPointCaption2.Location = new System.Drawing.Point(94, 26);
            this.lblPointCaption2.Name = "lblPointCaption2";
            this.lblPointCaption2.Size = new System.Drawing.Size(31, 13);
            this.lblPointCaption2.TabIndex = 1;
            this.lblPointCaption2.Text = "Point";
            // 
            // lblPoints2
            // 
            this.lblPoints2.AutoSize = true;
            this.lblPoints2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints2.Location = new System.Drawing.Point(88, 42);
            this.lblPoints2.Name = "lblPoints2";
            this.lblPoints2.Size = new System.Drawing.Size(55, 46);
            this.lblPoints2.TabIndex = 2;
            this.lblPoints2.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightGreen;
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(413, 282);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 108);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.lstReport);
            this.grpReport.Location = new System.Drawing.Point(571, 12);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(177, 262);
            this.grpReport.TabIndex = 9;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Report";
            // 
            // lstReport
            // 
            this.lstReport.FormattingEnabled = true;
            this.lstReport.HorizontalScrollbar = true;
            this.lstReport.Location = new System.Drawing.Point(8, 20);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(161, 225);
            this.lstReport.TabIndex = 0;
            // 
            // btnShowResult
            // 
            this.btnShowResult.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResult.Location = new System.Drawing.Point(571, 282);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(177, 108);
            this.btnShowResult.TabIndex = 10;
            this.btnShowResult.Text = "SHOW RESULT";
            this.btnShowResult.UseVisualStyleBackColor = false;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.Location = new System.Drawing.Point(12, 405);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(165, 17);
            this.lblTeam.TabIndex = 11;
            this.lblTeam.Text = "Team: GROUP MEMBERS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(760, 440);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpPlayer2);
            this.Controls.Add(this.grpPlayer1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSetup2);
            this.Controls.Add(this.btnSetup1);
            this.Controls.Add(this.grpAvatars);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.grpInit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Higher Luck";
            this.grpInit.ResumeLayout(false);
            this.grpInit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRounds)).EndInit();
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).EndInit();
            this.grpAvatars.ResumeLayout(false);
            this.grpPlayer1.ResumeLayout(false);
            this.grpPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer1)).EndInit();
            this.grpPlayer2.ResumeLayout(false);
            this.grpPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer2)).EndInit();
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInit;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.NumericUpDown nudRounds;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Label lblRoundsCaption;
        private System.Windows.Forms.Label lblRoundsLeft;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox pbDice;
        private System.Windows.Forms.Label lblRollInfo;
        private System.Windows.Forms.GroupBox grpAvatars;
        private System.Windows.Forms.RadioButton rbAvatar1;
        private System.Windows.Forms.RadioButton rbAvatar2;
        private System.Windows.Forms.RadioButton rbAvatar3;
        private System.Windows.Forms.RadioButton rbAvatar4;
        private System.Windows.Forms.Button btnSetup1;
        private System.Windows.Forms.Button btnSetup2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpPlayer1;
        private System.Windows.Forms.PictureBox pbPlayer1;
        private System.Windows.Forms.Label lblPointCaption1;
        private System.Windows.Forms.Label lblPoints1;
        private System.Windows.Forms.GroupBox grpPlayer2;
        private System.Windows.Forms.PictureBox pbPlayer2;
        private System.Windows.Forms.Label lblPointCaption2;
        private System.Windows.Forms.Label lblPoints2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.Label lblTeam;
    }
}
