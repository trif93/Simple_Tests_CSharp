/*
 * Created by SharpDevelop.
 * User: Барсик
 * Date: 13.01.2017
 * Time: 19:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Tests
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string[] questions;
		string[] answers;
		int question_number, answer_number;
		int Score, progress;
		bool isActive=true;
		
		public MainForm()
		{
			InitializeComponent();
			questions = File.ReadAllLines("questions.txt");
			answers = File.ReadAllLines("answers.txt");
			Init();
		}
		void ButtonCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			LabelProgress.Text = "Progress: ";
		}
		void check(string answer){
			if((question_number<=questions.Length)&&answer.Equals(answers[answer_number])){
				Score++;	
			}	
		}
		void Buttons_Click(object sender, EventArgs e){
			if(isActive){
				check(((Button)sender).Text);
				progress = 100*question_number/questions.Length;
				LabelResult.Text = "Result: "+Score +"/"+questions.Length;
				ProgressBarProgress.Value = progress;
				
				if(question_number<questions.Length){
					QuestionText.Text = questions[question_number];
				}
				else{
					isActive=false;
					QuestionText.Text = "Test has ended. Press Close to exit.";
					MessageBox.Show("Your result:"+Score +"/"+questions.Length+".","Tests",MessageBoxButtons.OK);
				}
				question_number++;
				answer_number++;
			}
			
		}
		
		void Init(){
			isActive=true;
			question_number=0;
			answer_number=0;
			ProgressBarProgress.Value=0;
			Score = 0;
			progress = 0;
			LabelResult.Text = "Result: "+Score +"/"+questions.Length;
			QuestionText.Text = questions[question_number];
			question_number++;
		}
		void ButtonRestartClick(object sender, EventArgs e)
		{
			Init();
		}

	}
}
