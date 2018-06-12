using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalculator
{	
	public partial class Calculator : System.Web.UI.Page
	{
		private static double value1 = 0;
		private static string command = "";
		private static bool waitNewVal = true;		

		protected void Number_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			if(waitNewVal)
			{
				tbInput.Text = "0";
				waitNewVal = false;
				if(command != "")
				{
					tbResult.Text = $"{value1.ToString()} {command} ";
				}
			}
			if (tbInput.Text == "0" && btn.Text != ",")
			{
				tbInput.Text = btn.Text;
			}
			else
			{
				tbInput.Text += btn.Text;
			}
		}
		protected void Operator_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;	
			
			if (waitNewVal)
			{
				command = btn.Text;
				if (command == "=")
				{
					command = "";					
					waitNewVal = true;
					return;
				}
				tbResult.Text = $"{value1.ToString()} {command} ";
				return;
			}
			if (command == "")
			{	
				if(btn.Text == "=")
				{
					return;
				}
				value1 = double.Parse(tbInput.Text.ToString());
				command = btn.Text;								
				tbResult.Text = $"{value1.ToString()} {command} ";
				tbInput.Text = "0";				
			}			
			else
			{
				double value2 = double.Parse(tbInput.Text);
				double res = 0;				
				switch (command)
				{
					case "+":
						res = value1 + value2;
						break;
					case "-":
						res = value1 - value2;
						break;
					case "*":
						res = value1 * value2;
						break;
					case "/":
						if(value2 == 0)
						{
							tbInput.Text = "NAN";
							waitNewVal = true;
							command = "";
							value1 = 0;
							return;
						}
						res = value1 / value2;
						break;
					case "=":
						tbResult.Text = $"{value1.ToString()} {command} {value2.ToString()}";
						tbInput.Text = res.ToString();
						value1 = 0;
						command = "";
						waitNewVal = true;
						return;
				}
				tbResult.Text = $"{value1.ToString()} {command} {value2.ToString()}";
				tbInput.Text = res.ToString();
				value1 = res;
				waitNewVal = true;
				command = btn.Text;
				if(command == "=")
				{
					command = "";					
					waitNewVal = true;
				}
			}
		}
		protected void C_Click(object sender, EventArgs e)
		{
			tbResult.Text = "0";
			tbInput.Text = "0";
			command = "";
			value1 = 0;
		}
		protected void CE_Click(object sender, EventArgs e)
		{			
			tbInput.Text = "0";		
		}
		protected void Del_Click(object sender, EventArgs e)
		{
			if (tbInput.Text != "0")
			{
				tbInput.Text = tbInput.Text.Substring(0, tbInput.Text.Length - 1);
			}
			if(tbInput.Text.Length == 0)
			{
				tbInput.Text = "0";
			}
		}
		protected void Sign_Click(object sender, EventArgs e)
		{
			double tmp = double.Parse(tbInput.Text);
			value1 = -tmp;
			tbInput.Text = value1.ToString();
		}		
	}
}