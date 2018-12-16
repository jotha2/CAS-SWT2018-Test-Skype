﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace TA_Skype
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Logoff_TestAutomation recording.
    /// </summary>
    [TestModule("17f5c6f4-53d1-4fad-a022-3e8df59bb7ab", ModuleType.Recording, 1)]
    public partial class Logoff_TestAutomation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TA_SkypeRepository repository.
        /// </summary>
        public static TA_SkypeRepository repo = TA_SkypeRepository.Instance;

        static Logoff_TestAutomation instance = new Logoff_TestAutomation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Logoff_TestAutomation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Logoff_TestAutomation Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.None1.WeitereOptionen' at 20;11.", repo.Skype.None1.WeitereOptionenInfo, new RecordItemIndex(0));
            repo.Skype.None1.WeitereOptionen.Click("20;11");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.Abmelden' at Center.", repo.Skype.AbmeldenInfo, new RecordItemIndex(2));
            repo.Skype.Abmelden.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.None1.JaUndAnmeldedatenLoeschen' at 120;17.", repo.Skype.None1.JaUndAnmeldedatenLoeschenInfo, new RecordItemIndex(3));
            repo.Skype.None1.JaUndAnmeldedatenLoeschen.Click("120;17");
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='Anmelden oder erstellen') on item 'Skype.AnmeldenOderErstellen'.", repo.Skype.AnmeldenOderErstellenInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Skype.AnmeldenOderErstellenInfo, "Text", "Anmelden oder erstellen", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}