/*
 * Created by Ranorex
 * User: Thoma
 * Date: 12.01.2019
 * Time: 14:16
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Runtime.InteropServices;

namespace TA_Skype.Helper
{
	/// <summary>
	/// Description of Play.
	/// </summary>
	public class Play
 	{
        [System.Runtime.InteropServices.DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
        public static extern bool PlaySound(string fileName, System.IntPtr hMod, PlaySoundFlags flags);

        [System.Flags] 
        public enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001, 
            SND_NODEFAULT = 0x0002, 
            SND_LOOP = 0x0008, 
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000, 
            SND_FILENAME = 0x00020000, 
            SND_RESOURCE = 0x00040004 
        }
       
	}
}
