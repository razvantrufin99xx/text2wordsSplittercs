/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/14/2024
 * Time: 6:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace frasesplitterfordatasearch
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public string [] lines = new string[50];
		public string [,]words = new string[50,100];
		public string [] splitchars = {" ",";","\r\n","\r","\n"};
		
		public void findlines(ref TextBox t)
		{
			lines = t.Text.Split(splitchars , StringSplitOptions.None);
		    int rows = lines.Length;
		    int cols = 100;
		    
		    for (int y = 0; y < rows; y++)
        {
        	string[] recordsperline = lines[y].Split(new[] {' ',';'});
            for (int x = 0; x < cols; x++)
            {
            	words[y,x] = recordsperline[x];
               
            }
        }
		    
		    
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}
