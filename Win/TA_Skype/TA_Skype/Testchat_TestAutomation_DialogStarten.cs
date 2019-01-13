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
    ///The Testchat_TestAutomation_DialogStarten recording.
    /// </summary>
    [TestModule("48fd798d-d761-484e-b9d6-b99033bb5de0", ModuleType.Recording, 1)]
    public partial class Testchat_TestAutomation_DialogStarten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TA_SkypeRepository repository.
        /// </summary>
        public static TA_SkypeRepository repo = TA_SkypeRepository.Instance;

        static Testchat_TestAutomation_DialogStarten instance = new Testchat_TestAutomation_DialogStarten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Testchat_TestAutomation_DialogStarten()
        {
            VornameUndName = "Sarah Pfister";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Testchat_TestAutomation_DialogStarten Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable VornameUndName.
        /// </summary>
        [TestVariable("c880ee55-32ec-4543-be01-a612266cf2bc")]
        public string VornameUndName
        {
            get { return repo.VornameUndName; }
            set { repo.VornameUndName = value; }
        }

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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.btnNeuerChat' at 70;10.", repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.btnNeuerChatInfo, new RecordItemIndex(1));
            repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.btnNeuerChat.Click("70;10");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.PopupMenu.PopupItemNeuerChat' at 98;19.", repo.Skype.PopupMenu.PopupItemNeuerChatInfo, new RecordItemIndex(3));
            repo.Skype.PopupMenu.PopupItemNeuerChat.Click("98;19");
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Skype.frmSkypeMain.frmEinstellungen.frmChatPartnerAuswahl'.", repo.Skype.frmSkypeMain.frmEinstellungen.frmChatPartnerAuswahl.SelfInfo, new RecordItemIndex(4));
                Validate.Exists(repo.Skype.frmSkypeMain.frmEinstellungen.frmChatPartnerAuswahl.SelfInfo, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$VornameUndName' with focus on 'Skype.frmSkypeMain.frmEinstellungen.frmChatPartnerAuswahl.txtSuchen'.", repo.Skype.frmSkypeMain.frmEinstellungen.frmChatPartnerAuswahl.txtSuchenInfo, new RecordItemIndex(5));
            repo.Skype.frmSkypeMain.frmEinstellungen.frmChatPartnerAuswahl.txtSuchen.PressKeys(VornameUndName);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Skype.frmSkypeMain.frmEinstellungen.frmChatPartnerAuswahl.ListitemChatPartner'.", repo.Skype.frmSkypeMain.frmEinstellungen.frmChatPartnerAuswahl.ListitemChatPartnerInfo, new RecordItemIndex(6));
                Validate.Exists(repo.Skype.frmSkypeMain.frmEinstellungen.frmChatPartnerAuswahl.ListitemChatPartnerInfo, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Skype.frmSkypeMain.frmEinstellungen.frmChatPartnerAuswahl.ListitemChatPartner' at 105;48.", repo.Skype.frmSkypeMain.frmEinstellungen.frmChatPartnerAuswahl.ListitemChatPartnerInfo, new RecordItemIndex(7));
            repo.Skype.frmSkypeMain.frmEinstellungen.frmChatPartnerAuswahl.ListitemChatPartner.DoubleClick("105;48");
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Skype.frmSkypeMain.frmChat'.", repo.Skype.frmSkypeMain.frmChat.SelfInfo, new RecordItemIndex(8));
                Validate.Exists(repo.Skype.frmSkypeMain.frmChat.SelfInfo, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmChat.txtNachricht' at Center.", repo.Skype.frmSkypeMain.frmChat.txtNachrichtInfo, new RecordItemIndex(9));
            repo.Skype.frmSkypeMain.frmChat.txtNachricht.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Hallo Sarah, wie geht es Dir?' with focus on 'Skype.frmSkypeMain.frmChat.txtNachricht'.", repo.Skype.frmSkypeMain.frmChat.txtNachrichtInfo, new RecordItemIndex(10));
            repo.Skype.frmSkypeMain.frmChat.txtNachricht.PressKeys("Hallo Sarah, wie geht es Dir?");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(11));
            Keyboard.Press("{Return}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Was hast Du während den Ferien gemacht? :)' with focus on 'Skype.frmSkypeMain.frmChat.txtNachricht'.", repo.Skype.frmSkypeMain.frmChat.txtNachrichtInfo, new RecordItemIndex(12));
            repo.Skype.frmSkypeMain.frmChat.txtNachricht.PressKeys("Was hast Du während den Ferien gemacht? :)");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(13));
            Keyboard.Press("{Return}");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
