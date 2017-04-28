/*
 * Created by SharpDevelop.
 * User: Барсик
 * Date: 13.01.2017
 * Time: 19:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tests
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label LabelResult;
		private System.Windows.Forms.Button VariantA;
		private System.Windows.Forms.Button VariantB;
		private System.Windows.Forms.Button VariantC;
		private System.Windows.Forms.Button VariantD;
		private System.Windows.Forms.Button ButtonClose;
		private System.Windows.Forms.Label LabelProgress;
		private System.Windows.Forms.RichTextBox QuestionText;
		private System.Windows.Forms.ProgressBar ProgressBarProgress;
		private System.Windows.Forms.Button buttonRestart;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.LabelResult = new System.Windows.Forms.Label();
			this.VariantA = new System.Windows.Forms.Button();
			this.VariantB = new System.Windows.Forms.Button();
			this.VariantC = new System.Windows.Forms.Button();
			this.VariantD = new System.Windows.Forms.Button();
			this.ButtonClose = new System.Windows.Forms.Button();
			this.LabelProgress = new System.Windows.Forms.Label();
			this.QuestionText = new System.Windows.Forms.RichTextBox();
			this.ProgressBarProgress = new System.Windows.Forms.ProgressBar();
			this.buttonRestart = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LabelResult
			// 
			this.LabelResult.Location = new System.Drawing.Point(180, 9);
			this.LabelResult.Name = "LabelResult";
			this.LabelResult.Size = new System.Drawing.Size(100, 23);
			this.LabelResult.TabIndex = 1;
			// 
			// VariantA
			// 
			this.VariantA.Location = new System.Drawing.Point(13, 180);
			this.VariantA.Name = "VariantA";
			this.VariantA.Size = new System.Drawing.Size(67, 23);
			this.VariantA.TabIndex = 2;
			this.VariantA.Text = "A";
			this.VariantA.UseVisualStyleBackColor = true;
			this.VariantA.Click += new System.EventHandler(this.Buttons_Click);
			// 
			// VariantB
			// 
			this.VariantB.Location = new System.Drawing.Point(86, 180);
			this.VariantB.Name = "VariantB";
			this.VariantB.Size = new System.Drawing.Size(60, 23);
			this.VariantB.TabIndex = 3;
			this.VariantB.Text = "B";
			this.VariantB.UseVisualStyleBackColor = true;
			this.VariantB.Click += new System.EventHandler(this.Buttons_Click);
			// 
			// VariantC
			// 
			this.VariantC.Location = new System.Drawing.Point(152, 181);
			this.VariantC.Name = "VariantC";
			this.VariantC.Size = new System.Drawing.Size(61, 23);
			this.VariantC.TabIndex = 4;
			this.VariantC.Text = "C";
			this.VariantC.UseVisualStyleBackColor = true;
			this.VariantC.Click += new System.EventHandler(this.Buttons_Click);
			// 
			// VariantD
			// 
			this.VariantD.Location = new System.Drawing.Point(219, 181);
			this.VariantD.Name = "VariantD";
			this.VariantD.Size = new System.Drawing.Size(61, 23);
			this.VariantD.TabIndex = 5;
			this.VariantD.Text = "D";
			this.VariantD.UseVisualStyleBackColor = true;
			this.VariantD.Click += new System.EventHandler(this.Buttons_Click);
			// 
			// ButtonClose
			// 
			this.ButtonClose.Location = new System.Drawing.Point(205, 238);
			this.ButtonClose.Name = "ButtonClose";
			this.ButtonClose.Size = new System.Drawing.Size(75, 23);
			this.ButtonClose.TabIndex = 6;
			this.ButtonClose.Text = "Close";
			this.ButtonClose.UseVisualStyleBackColor = true;
			this.ButtonClose.Click += new System.EventHandler(this.ButtonCloseClick);
			// 
			// LabelProgress
			// 
			this.LabelProgress.Location = new System.Drawing.Point(12, 9);
			this.LabelProgress.Name = "LabelProgress";
			this.LabelProgress.Size = new System.Drawing.Size(100, 13);
			this.LabelProgress.TabIndex = 7;
			// 
			// QuestionText
			// 
			this.QuestionText.Location = new System.Drawing.Point(13, 54);
			this.QuestionText.Name = "QuestionText";
			this.QuestionText.Size = new System.Drawing.Size(267, 120);
			this.QuestionText.TabIndex = 8;
			this.QuestionText.Text = "";
			// 
			// ProgressBarProgress
			// 
			this.ProgressBarProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.ProgressBarProgress.Location = new System.Drawing.Point(13, 25);
			this.ProgressBarProgress.Name = "ProgressBarProgress";
			this.ProgressBarProgress.Size = new System.Drawing.Size(100, 23);
			this.ProgressBarProgress.Step = 1;
			this.ProgressBarProgress.TabIndex = 9;
			// 
			// buttonRestart
			// 
			this.buttonRestart.Location = new System.Drawing.Point(13, 238);
			this.buttonRestart.Name = "buttonRestart";
			this.buttonRestart.Size = new System.Drawing.Size(75, 23);
			this.buttonRestart.TabIndex = 10;
			this.buttonRestart.Text = "Restart";
			this.buttonRestart.UseVisualStyleBackColor = true;
			this.buttonRestart.Click += new System.EventHandler(this.ButtonRestartClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.buttonRestart);
			this.Controls.Add(this.ProgressBarProgress);
			this.Controls.Add(this.QuestionText);
			this.Controls.Add(this.LabelProgress);
			this.Controls.Add(this.ButtonClose);
			this.Controls.Add(this.VariantD);
			this.Controls.Add(this.VariantC);
			this.Controls.Add(this.VariantB);
			this.Controls.Add(this.VariantA);
			this.Controls.Add(this.LabelResult);
			this.Name = "MainForm";
			this.Text = "Tests";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
