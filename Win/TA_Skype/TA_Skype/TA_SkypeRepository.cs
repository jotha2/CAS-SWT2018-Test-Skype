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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace TA_Skype
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the TA_SkypeRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
    [RepositoryFolder("bd9057c9-e431-44a7-ba05-6153dff61cc0")]
    public partial class TA_SkypeRepository : RepoGenBaseFolder
    {
        static TA_SkypeRepository instance = new TA_SkypeRepository();
        TA_SkypeRepositoryFolders.ExplorerAppFolder _explorer;
        TA_SkypeRepositoryFolders.SkypeAppFolder _skype;

        /// <summary>
        /// Gets the singleton class instance representing the TA_SkypeRepository element repository.
        /// </summary>
        [RepositoryFolder("bd9057c9-e431-44a7-ba05-6153dff61cc0")]
        public static TA_SkypeRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public TA_SkypeRepository() 
            : base("TA_SkypeRepository", "/", null, 0, false, "bd9057c9-e431-44a7-ba05-6153dff61cc0", ".\\RepositoryImages\\TA_SkypeRepositorybd9057c9.rximgres")
        {
            _explorer = new TA_SkypeRepositoryFolders.ExplorerAppFolder(this);
            _skype = new TA_SkypeRepositoryFolders.SkypeAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("bd9057c9-e431-44a7-ba05-6153dff61cc0")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("4431fc6e-46f6-4e85-b084-435feecea8e6")]
        public virtual TA_SkypeRepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }

        /// <summary>
        /// The Skype folder.
        /// </summary>
        [RepositoryFolder("f0a1d291-9d6e-4e9c-ac26-607165225622")]
        public virtual TA_SkypeRepositoryFolders.SkypeAppFolder Skype
        {
            get { return _skype; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.3")]
    public partial class TA_SkypeRepositoryFolders
    {
        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("4431fc6e-46f6-4e85-b084-435feecea8e6")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _skypeInfo;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/menubar[@processname='explorer']", parentFolder, 30000, null, true, "4431fc6e-46f6-4e85-b084-435feecea8e6", "")
            {
                _skypeInfo = new RepoItemInfo(this, "Skype", "container[@controlid='40965']//toolbar[@accessiblename='Ausgeführte Anwendungen']/button[@accessiblename='Skype']", 30000, null, "e9eb9817-e9f1-41a2-a062-16a50ef80794");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("4431fc6e-46f6-4e85-b084-435feecea8e6")]
            public virtual Ranorex.MenuBar Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MenuBar>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("4431fc6e-46f6-4e85-b084-435feecea8e6")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Skype item.
            /// </summary>
            [RepositoryItem("e9eb9817-e9f1-41a2-a062-16a50ef80794")]
            public virtual Ranorex.Button Skype
            {
                get
                {
                    return _skypeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Skype item info.
            /// </summary>
            [RepositoryItemInfo("e9eb9817-e9f1-41a2-a062-16a50ef80794")]
            public virtual RepoItemInfo SkypeInfo
            {
                get
                {
                    return _skypeInfo;
                }
            }
        }

        /// <summary>
        /// The SkypeAppFolder folder.
        /// </summary>
        [RepositoryFolder("f0a1d291-9d6e-4e9c-ac26-607165225622")]
        public partial class SkypeAppFolder : RepoGenBaseFolder
        {
            TA_SkypeRepositoryFolders.MainAreaFolder _mainarea;
            TA_SkypeRepositoryFolders.None1Folder _none1;
            RepoItemInfo _btncloseInfo;
            RepoItemInfo _anmeldenodererstellenInfo;
            RepoItemInfo _namedcontainerautomationpeerInfo;
            RepoItemInfo _willkommentestInfo;
            RepoItemInfo _abmeldenInfo;
            RepoItemInfo _systemInfo;

            /// <summary>
            /// Creates a new Skype  folder.
            /// </summary>
            public SkypeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Skype", "/winapp[@appid='App' and @name='Skype' and @processname='SkypeApp' and @instance='0']", parentFolder, 30000, null, true, "f0a1d291-9d6e-4e9c-ac26-607165225622", "")
            {
                _mainarea = new TA_SkypeRepositoryFolders.MainAreaFolder(this);
                _none1 = new TA_SkypeRepositoryFolders.None1Folder(this);
                _btncloseInfo = new RepoItemInfo(this, "btnClose", "titlebar[@name='Skype' and @classname='ApplicationFrameTitleBarWindow']/?/?/button[@automationid='Close']", 30000, null, "800e7cb4-3e1d-448f-ab90-44eab8d8a0fc");
                _anmeldenodererstellenInfo = new RepoItemInfo(this, "AnmeldenOderErstellen", "element[@orientation='None']/container[@orientation='None']/?/?/button[@name='Anmelden oder erstellen']//text[@name='Anmelden oder erstellen']", 30000, null, "86484711-50c6-4248-8edf-2f461ec41c45");
                _namedcontainerautomationpeerInfo = new RepoItemInfo(this, "NamedContainerAutomationPeer", "element[@orientation='None']//container[@classname='NamedContainerAutomationPeer']", 30000, null, "fcc4684b-c6fb-4463-ba41-3dbf99c93ac2");
                _willkommentestInfo = new RepoItemInfo(this, "WillkommenTest", "element/container[@orientation='None']/container[@orientation='None']/container[1]/container[2]/container[2]/?/?/text[@name='Willkommen, Test']", 30000, null, "e0c5c5a9-6bc3-4300-8e17-90883f25db01");
                _abmeldenInfo = new RepoItemInfo(this, "Abmelden", "form[@name='Popup']//text[@name='Abmelden']", 30000, null, "80d86ab2-4ee4-4b37-8860-d86203953957");
                _systemInfo = new RepoItemInfo(this, "System", "titlebar[@name='Skype' and @classname='ApplicationFrameTitleBarWindow']/?/?/menuitem[@name='System']", 30000, null, "ca36ac8e-6f01-4e75-82b8-9447e59eeda2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("f0a1d291-9d6e-4e9c-ac26-607165225622")]
            public virtual Ranorex.WindowsApp Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WindowsApp>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("f0a1d291-9d6e-4e9c-ac26-607165225622")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The btnClose item.
            /// </summary>
            [RepositoryItem("800e7cb4-3e1d-448f-ab90-44eab8d8a0fc")]
            public virtual Ranorex.Button btnClose
            {
                get
                {
                    return _btncloseInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The btnClose item info.
            /// </summary>
            [RepositoryItemInfo("800e7cb4-3e1d-448f-ab90-44eab8d8a0fc")]
            public virtual RepoItemInfo btnCloseInfo
            {
                get
                {
                    return _btncloseInfo;
                }
            }

            /// <summary>
            /// The AnmeldenOderErstellen item.
            /// </summary>
            [RepositoryItem("86484711-50c6-4248-8edf-2f461ec41c45")]
            public virtual Ranorex.Text AnmeldenOderErstellen
            {
                get
                {
                    return _anmeldenodererstellenInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The AnmeldenOderErstellen item info.
            /// </summary>
            [RepositoryItemInfo("86484711-50c6-4248-8edf-2f461ec41c45")]
            public virtual RepoItemInfo AnmeldenOderErstellenInfo
            {
                get
                {
                    return _anmeldenodererstellenInfo;
                }
            }

            /// <summary>
            /// The NamedContainerAutomationPeer item.
            /// </summary>
            [RepositoryItem("fcc4684b-c6fb-4463-ba41-3dbf99c93ac2")]
            public virtual Ranorex.Container NamedContainerAutomationPeer
            {
                get
                {
                    return _namedcontainerautomationpeerInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The NamedContainerAutomationPeer item info.
            /// </summary>
            [RepositoryItemInfo("fcc4684b-c6fb-4463-ba41-3dbf99c93ac2")]
            public virtual RepoItemInfo NamedContainerAutomationPeerInfo
            {
                get
                {
                    return _namedcontainerautomationpeerInfo;
                }
            }

            /// <summary>
            /// The WillkommenTest item.
            /// </summary>
            [RepositoryItem("e0c5c5a9-6bc3-4300-8e17-90883f25db01")]
            public virtual Ranorex.Text WillkommenTest
            {
                get
                {
                    return _willkommentestInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The WillkommenTest item info.
            /// </summary>
            [RepositoryItemInfo("e0c5c5a9-6bc3-4300-8e17-90883f25db01")]
            public virtual RepoItemInfo WillkommenTestInfo
            {
                get
                {
                    return _willkommentestInfo;
                }
            }

            /// <summary>
            /// The Abmelden item.
            /// </summary>
            [RepositoryItem("80d86ab2-4ee4-4b37-8860-d86203953957")]
            public virtual Ranorex.Text Abmelden
            {
                get
                {
                    return _abmeldenInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Abmelden item info.
            /// </summary>
            [RepositoryItemInfo("80d86ab2-4ee4-4b37-8860-d86203953957")]
            public virtual RepoItemInfo AbmeldenInfo
            {
                get
                {
                    return _abmeldenInfo;
                }
            }

            /// <summary>
            /// The System item.
            /// </summary>
            [RepositoryItem("ca36ac8e-6f01-4e75-82b8-9447e59eeda2")]
            public virtual Ranorex.MenuItem System
            {
                get
                {
                    return _systemInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The System item info.
            /// </summary>
            [RepositoryItemInfo("ca36ac8e-6f01-4e75-82b8-9447e59eeda2")]
            public virtual RepoItemInfo SystemInfo
            {
                get
                {
                    return _systemInfo;
                }
            }

            /// <summary>
            /// The MainArea folder.
            /// </summary>
            [RepositoryFolder("d144eb36-e29d-4feb-a11b-9e0e0264e4f5")]
            public virtual TA_SkypeRepositoryFolders.MainAreaFolder MainArea
            {
                get { return _mainarea; }
            }

            /// <summary>
            /// The None1 folder.
            /// </summary>
            [RepositoryFolder("62fa1213-ccc6-451a-9235-71d577eca75a")]
            public virtual TA_SkypeRepositoryFolders.None1Folder None1
            {
                get { return _none1; }
            }
        }

        /// <summary>
        /// The MainAreaFolder folder.
        /// </summary>
        [RepositoryFolder("d144eb36-e29d-4feb-a11b-9e0e0264e4f5")]
        public partial class MainAreaFolder : RepoGenBaseFolder
        {
            TA_SkypeRepositoryFolders.LeftAreaFolder _leftarea;
            TA_SkypeRepositoryFolders.RightAreaFolder _rightarea;

            /// <summary>
            /// Creates a new MainArea  folder.
            /// </summary>
            public MainAreaFolder(RepoGenBaseFolder parentFolder) :
                    base("MainArea", "element/container/container/container/container[2]", parentFolder, 30000, null, false, "d144eb36-e29d-4feb-a11b-9e0e0264e4f5", "")
            {
                _leftarea = new TA_SkypeRepositoryFolders.LeftAreaFolder(this);
                _rightarea = new TA_SkypeRepositoryFolders.RightAreaFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d144eb36-e29d-4feb-a11b-9e0e0264e4f5")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d144eb36-e29d-4feb-a11b-9e0e0264e4f5")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The LeftArea folder.
            /// </summary>
            [RepositoryFolder("82f7878c-7260-432a-9adc-8ce32c9b255e")]
            public virtual TA_SkypeRepositoryFolders.LeftAreaFolder LeftArea
            {
                get { return _leftarea; }
            }

            /// <summary>
            /// The RightArea folder.
            /// </summary>
            [RepositoryFolder("7c9ad572-4ec1-4252-9baf-51120af4fcaf")]
            public virtual TA_SkypeRepositoryFolders.RightAreaFolder RightArea
            {
                get { return _rightarea; }
            }
        }

        /// <summary>
        /// The LeftAreaFolder folder.
        /// </summary>
        [RepositoryFolder("82f7878c-7260-432a-9adc-8ce32c9b255e")]
        public partial class LeftAreaFolder : RepoGenBaseFolder
        {
            RepoItemInfo _btnprofilinfoInfo;
            RepoItemInfo _btnoptionenInfo;
            RepoItemInfo _btnsuchenInfo;
            RepoItemInfo _btnchatsInfo;
            RepoItemInfo _btnanrufeInfo;
            RepoItemInfo _btnkontakteInfo;
            RepoItemInfo _btnbenachrichtigungenInfo;

            /// <summary>
            /// Creates a new LeftArea  folder.
            /// </summary>
            public LeftAreaFolder(RepoGenBaseFolder parentFolder) :
                    base("LeftArea", "container[1]", parentFolder, 30000, null, false, "82f7878c-7260-432a-9adc-8ce32c9b255e", "")
            {
                _btnprofilinfoInfo = new RepoItemInfo(this, "btnProfilInfo", "button[@name='Meine Info, Aktiv']", 30000, null, "d153211a-81a9-4268-aa6a-bfe9477a7d86");
                _btnoptionenInfo = new RepoItemInfo(this, "btnOptionen", "button[@name='Weitere Optionen']", 30000, null, "30314c00-1e29-48fc-b76f-ab2a882c7d5a");
                _btnsuchenInfo = new RepoItemInfo(this, "btnSuchen", "container/button[@name~'^Nach\\ Personen,\\ Gruppen\\ &\\ ']", 30000, null, "10ccceab-94ac-4966-a219-28c6bec5f8a3");
                _btnchatsInfo = new RepoItemInfo(this, "btnChats", "?/?/button[@name~'^Ausgewählt\\.\\ Chats,\\ Keine\\ ']", 30000, null, "fa4f2930-958b-4b5b-93fe-15b0be0ecf45");
                _btnanrufeInfo = new RepoItemInfo(this, "btnAnrufe", "?/?/button[@name~'^Anrufe,\\ Registerkarte\\ 2\\ v']", 30000, null, "e1e85084-1057-4e32-925d-66613028693d");
                _btnkontakteInfo = new RepoItemInfo(this, "btnKontakte", "?/?/button[@name~'^Kontakte,\\ Registerkarte\\ 3']", 30000, null, "4540ab9c-a1f5-4650-88cc-ce8959322e4f");
                _btnbenachrichtigungenInfo = new RepoItemInfo(this, "btnBenachrichtigungen", "?/?/button[@name~'^Benachrichtig\\.,\\ Keine\\ neu']", 30000, null, "7ccbf441-33f9-4eab-9c58-1c6a884e22b8");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("82f7878c-7260-432a-9adc-8ce32c9b255e")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("82f7878c-7260-432a-9adc-8ce32c9b255e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The btnProfilInfo item.
            /// </summary>
            [RepositoryItem("d153211a-81a9-4268-aa6a-bfe9477a7d86")]
            public virtual Ranorex.Button btnProfilInfo
            {
                get
                {
                    return _btnprofilinfoInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The btnProfilInfo item info.
            /// </summary>
            [RepositoryItemInfo("d153211a-81a9-4268-aa6a-bfe9477a7d86")]
            public virtual RepoItemInfo btnProfilInfoInfo
            {
                get
                {
                    return _btnprofilinfoInfo;
                }
            }

            /// <summary>
            /// The btnOptionen item.
            /// </summary>
            [RepositoryItem("30314c00-1e29-48fc-b76f-ab2a882c7d5a")]
            public virtual Ranorex.Button btnOptionen
            {
                get
                {
                    return _btnoptionenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The btnOptionen item info.
            /// </summary>
            [RepositoryItemInfo("30314c00-1e29-48fc-b76f-ab2a882c7d5a")]
            public virtual RepoItemInfo btnOptionenInfo
            {
                get
                {
                    return _btnoptionenInfo;
                }
            }

            /// <summary>
            /// The btnSuchen item.
            /// </summary>
            [RepositoryItem("10ccceab-94ac-4966-a219-28c6bec5f8a3")]
            public virtual Ranorex.Button btnSuchen
            {
                get
                {
                    return _btnsuchenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The btnSuchen item info.
            /// </summary>
            [RepositoryItemInfo("10ccceab-94ac-4966-a219-28c6bec5f8a3")]
            public virtual RepoItemInfo btnSuchenInfo
            {
                get
                {
                    return _btnsuchenInfo;
                }
            }

            /// <summary>
            /// The btnChats item.
            /// </summary>
            [RepositoryItem("fa4f2930-958b-4b5b-93fe-15b0be0ecf45")]
            public virtual Ranorex.Button btnChats
            {
                get
                {
                    return _btnchatsInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The btnChats item info.
            /// </summary>
            [RepositoryItemInfo("fa4f2930-958b-4b5b-93fe-15b0be0ecf45")]
            public virtual RepoItemInfo btnChatsInfo
            {
                get
                {
                    return _btnchatsInfo;
                }
            }

            /// <summary>
            /// The btnAnrufe item.
            /// </summary>
            [RepositoryItem("e1e85084-1057-4e32-925d-66613028693d")]
            public virtual Ranorex.Button btnAnrufe
            {
                get
                {
                    return _btnanrufeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The btnAnrufe item info.
            /// </summary>
            [RepositoryItemInfo("e1e85084-1057-4e32-925d-66613028693d")]
            public virtual RepoItemInfo btnAnrufeInfo
            {
                get
                {
                    return _btnanrufeInfo;
                }
            }

            /// <summary>
            /// The btnKontakte item.
            /// </summary>
            [RepositoryItem("4540ab9c-a1f5-4650-88cc-ce8959322e4f")]
            public virtual Ranorex.Button btnKontakte
            {
                get
                {
                    return _btnkontakteInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The btnKontakte item info.
            /// </summary>
            [RepositoryItemInfo("4540ab9c-a1f5-4650-88cc-ce8959322e4f")]
            public virtual RepoItemInfo btnKontakteInfo
            {
                get
                {
                    return _btnkontakteInfo;
                }
            }

            /// <summary>
            /// The btnBenachrichtigungen item.
            /// </summary>
            [RepositoryItem("7ccbf441-33f9-4eab-9c58-1c6a884e22b8")]
            public virtual Ranorex.Button btnBenachrichtigungen
            {
                get
                {
                    return _btnbenachrichtigungenInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The btnBenachrichtigungen item info.
            /// </summary>
            [RepositoryItemInfo("7ccbf441-33f9-4eab-9c58-1c6a884e22b8")]
            public virtual RepoItemInfo btnBenachrichtigungenInfo
            {
                get
                {
                    return _btnbenachrichtigungenInfo;
                }
            }
        }

        /// <summary>
        /// The RightAreaFolder folder.
        /// </summary>
        [RepositoryFolder("7c9ad572-4ec1-4252-9baf-51120af4fcaf")]
        public partial class RightAreaFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new RightArea  folder.
            /// </summary>
            public RightAreaFolder(RepoGenBaseFolder parentFolder) :
                    base("RightArea", "container[2]", parentFolder, 30000, null, false, "7c9ad572-4ec1-4252-9baf-51120af4fcaf", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7c9ad572-4ec1-4252-9baf-51120af4fcaf")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("7c9ad572-4ec1-4252-9baf-51120af4fcaf")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The None1Folder folder.
        /// </summary>
        [RepositoryFolder("62fa1213-ccc6-451a-9235-71d577eca75a")]
        public partial class None1Folder : RepoGenBaseFolder
        {
            RepoItemInfo _weitereoptionenInfo;
            RepoItemInfo _jaundanmeldedatenloeschenInfo;
            RepoItemInfo _noneInfo;
            RepoItemInfo _loginfeld_emailadresseInfo;
            RepoItemInfo _loginfeld_passworteInfo;

            /// <summary>
            /// Creates a new None1  folder.
            /// </summary>
            public None1Folder(RepoGenBaseFolder parentFolder) :
                    base("None1", "element/container[@orientation='None']/container[@orientation='None']", parentFolder, 30000, null, false, "62fa1213-ccc6-451a-9235-71d577eca75a", "")
            {
                _weitereoptionenInfo = new RepoItemInfo(this, "WeitereOptionen", "container[1]/container[2]/container[1]/button[@name='Weitere Optionen']/?/?/text[@name='']", 30000, null, "2e0f183b-bce3-49ad-8325-56c10da3c271");
                _jaundanmeldedatenloeschenInfo = new RepoItemInfo(this, "JaUndAnmeldedatenLoeschen", "container[2]/container[3]/container[@name~'^Möchtest\\ du\\ dich\\ wirklich']/?/?/button[@name~'^Ja,\\ und\\ Anmeldedaten\\ lösc']/?/?/text[@name~'^Ja,\\ und\\ Anmeldedaten\\ lösc']", 30000, null, "ac9d2d35-7e17-4644-9015-4c097cb85a00");
                _noneInfo = new RepoItemInfo(this, "None", "container[2]/container[3]/container[@name~'^Möchtest\\ du\\ dich\\ wirklich']/?/?/button[@name~'^Ja,\\ und\\ Anmeldedaten\\ lösc']/container[@orientation='None']", 30000, null, "607d5e72-93be-4cf5-8eba-e0112ff5adde");
                _loginfeld_emailadresseInfo = new RepoItemInfo(this, "Loginfeld_Emailadresse", "container[3]/?/?/container[@name~'^https://login\\.live\\.com/oa']/container[@name='Bei Skype anmelden']/container[@automationid='i0281']/?/?/text[@automationid='i0116']", 30000, null, "55b48a56-3677-451a-8f19-02eef2337ce4");
                _loginfeld_passworteInfo = new RepoItemInfo(this, "Loginfeld_Passworte", "container[3]/?/?/container[@name~'^https://login\\.live\\.com/oa']/container[@name='Bei Skype anmelden']/container[@automationid='i0281']/?/?/text[@automationid='i0118']", 30000, null, "e64b8548-479e-4390-827a-e8f8f160e30c");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("62fa1213-ccc6-451a-9235-71d577eca75a")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("62fa1213-ccc6-451a-9235-71d577eca75a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The WeitereOptionen item.
            /// </summary>
            [RepositoryItem("2e0f183b-bce3-49ad-8325-56c10da3c271")]
            public virtual Ranorex.Text WeitereOptionen
            {
                get
                {
                    return _weitereoptionenInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The WeitereOptionen item info.
            /// </summary>
            [RepositoryItemInfo("2e0f183b-bce3-49ad-8325-56c10da3c271")]
            public virtual RepoItemInfo WeitereOptionenInfo
            {
                get
                {
                    return _weitereoptionenInfo;
                }
            }

            /// <summary>
            /// The JaUndAnmeldedatenLoeschen item.
            /// </summary>
            [RepositoryItem("ac9d2d35-7e17-4644-9015-4c097cb85a00")]
            public virtual Ranorex.Text JaUndAnmeldedatenLoeschen
            {
                get
                {
                    return _jaundanmeldedatenloeschenInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The JaUndAnmeldedatenLoeschen item info.
            /// </summary>
            [RepositoryItemInfo("ac9d2d35-7e17-4644-9015-4c097cb85a00")]
            public virtual RepoItemInfo JaUndAnmeldedatenLoeschenInfo
            {
                get
                {
                    return _jaundanmeldedatenloeschenInfo;
                }
            }

            /// <summary>
            /// The None item.
            /// </summary>
            [RepositoryItem("607d5e72-93be-4cf5-8eba-e0112ff5adde")]
            public virtual Ranorex.Container None
            {
                get
                {
                    return _noneInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The None item info.
            /// </summary>
            [RepositoryItemInfo("607d5e72-93be-4cf5-8eba-e0112ff5adde")]
            public virtual RepoItemInfo NoneInfo
            {
                get
                {
                    return _noneInfo;
                }
            }

            /// <summary>
            /// The Loginfeld_Emailadresse item.
            /// </summary>
            [RepositoryItem("55b48a56-3677-451a-8f19-02eef2337ce4")]
            public virtual Ranorex.Text Loginfeld_Emailadresse
            {
                get
                {
                    return _loginfeld_emailadresseInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Loginfeld_Emailadresse item info.
            /// </summary>
            [RepositoryItemInfo("55b48a56-3677-451a-8f19-02eef2337ce4")]
            public virtual RepoItemInfo Loginfeld_EmailadresseInfo
            {
                get
                {
                    return _loginfeld_emailadresseInfo;
                }
            }

            /// <summary>
            /// The Loginfeld_Passworte item.
            /// </summary>
            [RepositoryItem("e64b8548-479e-4390-827a-e8f8f160e30c")]
            public virtual Ranorex.Text Loginfeld_Passworte
            {
                get
                {
                    return _loginfeld_passworteInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Loginfeld_Passworte item info.
            /// </summary>
            [RepositoryItemInfo("e64b8548-479e-4390-827a-e8f8f160e30c")]
            public virtual RepoItemInfo Loginfeld_PassworteInfo
            {
                get
                {
                    return _loginfeld_passworteInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}