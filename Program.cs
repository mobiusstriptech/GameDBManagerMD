﻿using System;
using System.Windows.Forms;

namespace GameDbManagerMega
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main(string[] param)
		{
			if (param.Length >= 1)
			{
				if (param[0].Equals("-scanroms", StringComparison.CurrentCultureIgnoreCase))
				{
					GameDBMgr.DoScanWithoutUI(param[1]);
				}
				else if (param[0].Equals("-convertimg", StringComparison.CurrentCultureIgnoreCase))
				{
					GameDBMgr.ConvertImages();
				}
				else
				{
					Console.WriteLine("Command Line usage:");
					Console.WriteLine();
					Console.WriteLine("GameDbManager [-scanroms directory_name|-convertimg]");
				}
				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new GameDBMgr());
		}
	}
}