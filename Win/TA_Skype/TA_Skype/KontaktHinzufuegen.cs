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
    ///The KontaktHinzufuegen recording.
    /// </summary>
    [TestModule("fbcedd80-444f-4a2c-aa01-ddc4e9f3f02e", ModuleType.Recording, 1)]
    public partial class KontaktHinzufuegen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the TA_SkypeRepository repository.
        /// </summary>
        public static TA_SkypeRepository repo = TA_SkypeRepository.Instance;

        static KontaktHinzufuegen instance = new KontaktHinzufuegen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public KontaktHinzufuegen()
        {
            VornameUndName = "Hans Mueller";
            Telefonnummer = "100 10 00";
            Land = "Schweiz";
            Laendervorwahl = "+41";
            TelefonnummerTyp = "Privat";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static KontaktHinzufuegen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Telefonnummer;

        /// <summary>
        /// Gets or sets the value of variable Telefonnummer.
        /// </summary>
        [TestVariable("b385e338-b49b-4280-bc0e-bf8c96b59910")]
        public string Telefonnummer
        {
            get { return _Telefonnummer; }
            set { _Telefonnummer = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Land.
        /// </summary>
        [TestVariable("744d9200-96cb-436c-897d-b2d708ef12b4")]
        public string Land
        {
            get { return repo.Land; }
            set { repo.Land = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Laendervorwahl.
        /// </summary>
        [TestVariable("118a8ba9-effe-49dd-8709-1d9f58a69bf2")]
        public string Laendervorwahl
        {
            get { return repo.Laendervorwahl; }
            set { repo.Laendervorwahl = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable TelefonnummerTyp.
        /// </summary>
        [TestVariable("cf945fe1-cbed-4d3b-84d6-91fc9e758dfa")]
        public string TelefonnummerTyp
        {
            get { return repo.TelefonnummerTyp; }
            set { repo.TelefonnummerTyp = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable VornameUndName.
        /// </summary>
        [TestVariable("8a9aef5b-8d59-41ca-a2c0-9978215f7c68")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmSkypeMainAreaLinks.MainBar.btnKontakte' at Center.", repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.MainBar.btnKontakteInfo, new RecordItemIndex(0));
            repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.MainBar.btnKontakte.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.btnKontaktHinzufuegen' at Center.", repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.btnKontaktHinzufuegenInfo, new RecordItemIndex(1));
            repo.Skype.frmSkypeMain.frmSkypeMainAreaLinks.Detailbereich.btnKontaktHinzufuegen.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Skype.frmSkypeMain.frmKontaktHinzufuegen'.", repo.Skype.frmSkypeMain.frmKontaktHinzufuegen.SelfInfo, new RecordItemIndex(2));
            Validate.Exists(repo.Skype.frmSkypeMain.frmKontaktHinzufuegen.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmKontaktHinzufuegen.Detailbereich.ListItemTelefonnummerHinzufuegen' at Center.", repo.Skype.frmSkypeMain.frmKontaktHinzufuegen.Detailbereich.ListItemTelefonnummerHinzufuegenInfo, new RecordItemIndex(3));
            repo.Skype.frmSkypeMain.frmKontaktHinzufuegen.Detailbereich.ListItemTelefonnummerHinzufuegen.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Skype.frmSkypeMain.frmTelefonnummerHinzufuegen'.", repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.SelfInfo, new RecordItemIndex(4));
            Validate.Exists(repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$VornameUndName' with focus on 'Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.txtVornameUndName'.", repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.txtVornameUndNameInfo, new RecordItemIndex(5));
            repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.txtVornameUndName.PressKeys(VornameUndName);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.btnLaendervorwahl' at Center.", repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.btnLaendervorwahlInfo, new RecordItemIndex(6));
            repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.btnLaendervorwahl.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Skype.frmLaendervorwahl'.", repo.Skype.frmLaendervorwahl.SelfInfo, new RecordItemIndex(7));
            Validate.Exists(repo.Skype.frmLaendervorwahl.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Land' with focus on 'Skype.frmLaendervorwahl.txtLandRegionSuchen'.", repo.Skype.frmLaendervorwahl.txtLandRegionSuchenInfo, new RecordItemIndex(8));
            repo.Skype.frmLaendervorwahl.txtLandRegionSuchen.PressKeys(Land);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Skype.frmLaendervorwahl.ListItemLaendervorwahl'.", repo.Skype.frmLaendervorwahl.ListItemLaendervorwahlInfo, new RecordItemIndex(9));
            Validate.Exists(repo.Skype.frmLaendervorwahl.ListItemLaendervorwahlInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmLaendervorwahl.ListItemLaendervorwahl' at Center.", repo.Skype.frmLaendervorwahl.ListItemLaendervorwahlInfo, new RecordItemIndex(10));
            repo.Skype.frmLaendervorwahl.ListItemLaendervorwahl.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Skype.frmSkypeMain.frmTelefonnummerHinzufuegen'.", repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.SelfInfo, new RecordItemIndex(11));
            Validate.Exists(repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Laendervorwahl) on item 'Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.txtLaendervorwahl'.", repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.txtLaendervorwahlInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.txtLaendervorwahlInfo, "Text", Laendervorwahl);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Telefonnummer' with focus on 'Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.txtTelefonnummer'.", repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.txtTelefonnummerInfo, new RecordItemIndex(13));
            repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.txtTelefonnummer.PressKeys(Telefonnummer);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.btnTelefonnummerTyp' at Center.", repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.btnTelefonnummerTypInfo, new RecordItemIndex(14));
            repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.btnTelefonnummerTyp.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Skype.PopupMenu'.", repo.Skype.PopupMenu.SelfInfo, new RecordItemIndex(15));
            Validate.Exists(repo.Skype.PopupMenu.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.PopupMenu.PopupItemTelefonnummerTyp' at Center.", repo.Skype.PopupMenu.PopupItemTelefonnummerTypInfo, new RecordItemIndex(16));
            repo.Skype.PopupMenu.PopupItemTelefonnummerTyp.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$TelefonnummerTyp) on item 'Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.txtTelefonnummerTyp'.", repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.txtTelefonnummerTypInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Detailbereich.txtTelefonnummerTypInfo, "Text", TelefonnummerTyp);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Titelzeile.btnSpeichern' at Center.", repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Titelzeile.btnSpeichernInfo, new RecordItemIndex(18));
            repo.Skype.frmSkypeMain.frmTelefonnummerHinzufuegen.Titelzeile.btnSpeichern.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}