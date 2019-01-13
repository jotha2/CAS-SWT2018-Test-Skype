﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;
using TA_Skype.Helper;

namespace TA_Skype
{
    public partial class Verbindungstest_Abspielen
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void PlaySound(int frequency, int duration)
        {
        	Console.Beep(frequency, duration);
        }
        	
        public void PlayWav(string fileName)
        {
			Play.PlaySound (fileName, new System.IntPtr(), Play.PlaySoundFlags.SND_SYNC);        
        }
        
        public void RecordSound(string fileName)
        {
        	ProcessStartInfo pci = new ProcessStartInfo(@"C:\Tools\fmedia\fmedia.exe");
        	pci.Arguments = "--record --until=5 --overwrite --out=" + fileName;
        	Process.Start(pci);
        }
        
        public void AnalyzeRecording(string recordedFile, string statisticsFile)
        {
        	ProcessStartInfo pci = new ProcessStartInfo(@"C:\Program Files (x86)\sox-14-4-2\sox.exe");
        	//pci.Arguments = "--dft-min 8 " + recordedFile + " -n stat 2>" + statisticsFile;
        	//pci.Arguments = @"--dft-min 8 c:\temp\skypeSoundtestTA.wav -n stat 2>c:\temp\skypeSoundTestTA.stat";
        	pci.Arguments = @"--dft-min 8 " + @"c:\temp\skypeSoundtestTA.wav" + " -n stat 2>" + @"c:\temp\skypeSoundTestTA.stat";
        	Process.Start(pci);
        }
        
        public void CreateSoundStatisticsFile()
        {
        	Process.Start(@"C:\SkypeGit\Win\TA_Skype\resources\CreateSoundStatistics.bat");
        }
        
        public bool CheckSoundStatistics(string statisticsFile, int expectedFrequency, int deviationInPercent)
        {
			string search = "Rough   frequency:";
			string line;
			bool returnValue = false;			
  
			System.IO.StreamReader file = new System.IO.StreamReader(statisticsFile);  
			while((line = file.ReadLine()) != null)  
			{  
				if(line.Contains(search))
				{
					string frequencyString = line.Substring(search.Length);
					int frequency;
					if (int.TryParse(frequencyString, out frequency))
					{
						int minFrequency = expectedFrequency * (100 - deviationInPercent)/100;
						int maxFrequency = expectedFrequency * (100 + deviationInPercent)/100;
						if (frequency >= minFrequency && frequency <= maxFrequency)
						{
							returnValue = true;
							break;							
						}
					}
				}
			}  
  			file.Close();
			return returnValue;  			
        }
    }
}
