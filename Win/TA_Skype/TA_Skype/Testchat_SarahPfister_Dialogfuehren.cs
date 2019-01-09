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
    ///The Testchat_SarahPfister_Dialogfuehren recording.
    /// </summary>
    [TestModule("925b537f-8e6a-4d59-b0bb-6a30fbad67f8", ModuleType.Recording, 1)]
    public partial class Testchat_SarahPfister_Dialogfuehren : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TA_SkypeRepository repository.
        /// </summary>
        public static TA_SkypeRepository repo = TA_SkypeRepository.Instance;

        static Testchat_SarahPfister_Dialogfuehren instance = new Testchat_SarahPfister_Dialogfuehren();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Testchat_SarahPfister_Dialogfuehren()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Testchat_SarahPfister_Dialogfuehren Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmSkypeMainAreaLinks.MainBar.btnChats' at Center.", repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.MainBar.btnChatsInfo, new RecordItemIndex(0));
            repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.MainBar.btnChats.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.Chatfenster_TestAutomation'.", repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.Chatfenster_TestAutomationInfo, new RecordItemIndex(1));
            Validate.Exists(repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.Chatfenster_TestAutomationInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.Chatfenster_TestAutomation' at 69;12.", repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.Chatfenster_TestAutomationInfo, new RecordItemIndex(2));
            repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.Chatfenster_TestAutomation.Click("69;12");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmSkypeMainAreaRechts_Chatfenster.Chatfenster_Textfeld' at Center.", repo.Skype.frmSkypeMain.frmSkypeMainAreaRechts_Chatfenster.Chatfenster_TextfeldInfo, new RecordItemIndex(3));
            repo.Skype.frmSkypeMain.frmSkypeMainAreaRechts_Chatfenster.Chatfenster_Textfeld.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Hoi Test, mir gehts blendend. Und wie geht es Dir?' with focus on 'Skype.frmSkypeMain.frmSkypeMainAreaRechts_Chatfenster.Chatfenster_Textfeld'.", repo.Skype.frmSkypeMain.frmSkypeMainAreaRechts_Chatfenster.Chatfenster_TextfeldInfo, new RecordItemIndex(4));
            repo.Skype.frmSkypeMain.frmSkypeMainAreaRechts_Chatfenster.Chatfenster_Textfeld.PressKeys("Hoi Test, mir gehts blendend. Und wie geht es Dir?");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(5));
            Keyboard.Press("{Return}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Am ersten Ferientag war ich in Leukerbad bädelen. Dann kam der obligatorische Familientürk mit viel Essen und Trinken. Dann war ich noch auf dem Pilatus  und bin für einen Tag nach Bellinzona gegangen, um das schöne und warme Wetter zu geniessen. ' with focus on 'Skype.frmSkypeMain.frmSkypeMainAreaRechts_Chatfenster.Chatfenster_Textfeld'.", repo.Skype.frmSkypeMain.frmSkypeMainAreaRechts_Chatfenster.Chatfenster_TextfeldInfo, new RecordItemIndex(6));
            repo.Skype.frmSkypeMain.frmSkypeMainAreaRechts_Chatfenster.Chatfenster_Textfeld.PressKeys("Am ersten Ferientag war ich in Leukerbad bädelen. Dann kam der obligatorische Familientürk mit viel Essen und Trinken. Dann war ich noch auf dem Pilatus  und bin für einen Tag nach Bellinzona gegangen, um das schöne und warme Wetter zu geniessen. ");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(7));
            Keyboard.Press("{Return}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Hattest Du auch schöne Ferien?' with focus on 'Skype.frmSkypeMain.frmSkypeMainAreaRechts_Chatfenster.Chatfenster_Textfeld'.", repo.Skype.frmSkypeMain.frmSkypeMainAreaRechts_Chatfenster.Chatfenster_TextfeldInfo, new RecordItemIndex(8));
            repo.Skype.frmSkypeMain.frmSkypeMainAreaRechts_Chatfenster.Chatfenster_Textfeld.PressKeys("Hattest Du auch schöne Ferien?");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(9));
            Keyboard.Press("{Return}");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
