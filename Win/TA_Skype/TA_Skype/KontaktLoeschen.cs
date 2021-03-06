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
    ///The KontaktLoeschen recording.
    /// </summary>
    [TestModule("402a155c-fb0f-4b6d-9e63-c420293392a5", ModuleType.Recording, 1)]
    public partial class KontaktLoeschen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TA_SkypeRepository repository.
        /// </summary>
        public static TA_SkypeRepository repo = TA_SkypeRepository.Instance;

        static KontaktLoeschen instance = new KontaktLoeschen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public KontaktLoeschen()
        {
            VornameUndName = "Sarah Pfister";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static KontaktLoeschen Instance
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Skype.frmSkypeMain.frmSkypeMainAreaLinks.MainBar'.", repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.MainBar.SelfInfo, new RecordItemIndex(0));
            Validate.Exists(repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.MainBar.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmSkypeMainAreaLinks.MainBar.btnKontakte' at Center.", repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.MainBar.btnKontakteInfo, new RecordItemIndex(1));
            repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.MainBar.btnKontakte.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.ListItemKontakt'.", repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.ListItemKontaktInfo, new RecordItemIndex(2));
            Validate.Exists(repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.ListItemKontaktInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.ListItemKontakt' at Center.", repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.ListItemKontaktInfo, new RecordItemIndex(3));
            repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.ListItemKontakt.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.ListItemKontakt' at Center.", repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.ListItemKontaktInfo, new RecordItemIndex(4));
            repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.ListItemKontakt.Click(System.Windows.Forms.MouseButtons.Right);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Skype.PopupMenu.MenuItemProfilAnzeigen'.", repo.Skype.PopupMenu.MenuItemProfilAnzeigenInfo, new RecordItemIndex(5));
            Validate.Exists(repo.Skype.PopupMenu.MenuItemProfilAnzeigenInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.PopupMenu.MenuItemProfilAnzeigen' at Center.", repo.Skype.PopupMenu.MenuItemProfilAnzeigenInfo, new RecordItemIndex(6));
            repo.Skype.PopupMenu.MenuItemProfilAnzeigen.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Skype.frmSkypeMain.frmProfil'.", repo.Skype.frmSkypeMain.frmProfil.SelfInfo, new RecordItemIndex(7));
            Validate.Exists(repo.Skype.frmSkypeMain.frmProfil.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Skype.frmSkypeMain.frmProfil.btnKontaktLoeschen'.", repo.Skype.frmSkypeMain.frmProfil.btnKontaktLoeschenInfo, new RecordItemIndex(8));
            Validate.Exists(repo.Skype.frmSkypeMain.frmProfil.btnKontaktLoeschenInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmProfil.btnKontaktLoeschen' at Center.", repo.Skype.frmSkypeMain.frmProfil.btnKontaktLoeschenInfo, new RecordItemIndex(9));
            repo.Skype.frmSkypeMain.frmProfil.btnKontaktLoeschen.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Skype.PopupWindow'.", repo.Skype.PopupWindow.SelfInfo, new RecordItemIndex(10));
            Validate.Exists(repo.Skype.PopupWindow.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Skype.PopupWindow.lblPopupWindowTitel'.", repo.Skype.PopupWindow.lblPopupWindowTitelInfo, new RecordItemIndex(11));
            Validate.Exists(repo.Skype.PopupWindow.lblPopupWindowTitelInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.PopupWindow.btnLoeschen' at Center.", repo.Skype.PopupWindow.btnLoeschenInfo, new RecordItemIndex(12));
            repo.Skype.PopupWindow.btnLoeschen.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmProfil.btnBenutzerprofilSchliessen' at Center.", repo.Skype.frmSkypeMain.frmProfil.btnBenutzerprofilSchliessenInfo, new RecordItemIndex(13));
            repo.Skype.frmSkypeMain.frmProfil.btnBenutzerprofilSchliessen.Click();
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.ListItemKontakt'.", repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.ListItemKontaktInfo, new RecordItemIndex(14));
            //Validate.NotExists(repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.ListItemKontaktInfo);
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
