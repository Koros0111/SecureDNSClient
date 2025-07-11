﻿namespace SecureDNSClient
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            SplitContainerShareMain = new SplitContainer();
            SplitContainerShareTop = new SplitContainer();
            SplitContainerShareContent = new SplitContainer();
            CustomLabelProxySSLInfo = new CustomControls.CustomLabel();
            CustomCheckBoxProxyEnableSSL = new CustomControls.CustomCheckBox();
            CustomLabelShareInfo = new CustomControls.CustomLabel();
            CustomCheckBoxProxyEventShowRequest = new CustomControls.CustomCheckBox();
            CustomCheckBoxPDpiEnableFragment = new CustomControls.CustomCheckBox();
            CustomTabControlShareDpiBypassOptions = new CustomControls.CustomTabControl();
            TabPageShareFragment = new TabPage();
            CustomButtonPDpiPresetDefault = new CustomControls.CustomButton();
            CustomCheckBoxProxyEventShowChunkDetails = new CustomControls.CustomCheckBox();
            CustomNumericUpDownPDpiFragDelay = new CustomControls.CustomNumericUpDown();
            CustomLabelPDpiPresets = new CustomControls.CustomLabel();
            CustomNumericUpDownPDpiAntiPatternOffset = new CustomControls.CustomNumericUpDown();
            CustomLabelPDpiFragDelay = new CustomControls.CustomLabel();
            CustomLabelPDpiBeforeSniChunks = new CustomControls.CustomLabel();
            CustomNumericUpDownPDpiSniChunks = new CustomControls.CustomNumericUpDown();
            CustomLabelPDpiSniChunkMode = new CustomControls.CustomLabel();
            CustomNumericUpDownPDpiBeforeSniChunks = new CustomControls.CustomNumericUpDown();
            CustomComboBoxPDpiSniChunkMode = new CustomControls.CustomComboBox();
            CustomLabelPDpiSniChunks = new CustomControls.CustomLabel();
            CustomLabelPDpiAntiPatternOffset = new CustomControls.CustomLabel();
            TabPageShareSslDecryption = new TabPage();
            CustomCheckBoxProxySSLChangeSni = new CustomControls.CustomCheckBox();
            CustomLabelProxySSLChangeSniInfo = new CustomControls.CustomLabel();
            CustomTextBoxProxySSLDefaultSni = new CustomControls.CustomTextBox();
            CustomLabelProxySSLDefaultSni = new CustomControls.CustomLabel();
            CustomGroupBoxShareRulesStatus = new CustomControls.CustomGroupBox();
            SplitContainerShareRulesStatus1 = new SplitContainer();
            CustomTextBoxShareRulesStatusDomain = new CustomControls.CustomTextBox();
            CustomLabelShareRulesStatus = new CustomControls.CustomLabel();
            SplitContainerShareRulesStatus2 = new SplitContainer();
            CustomRichTextBoxShareRulesStatusResult = new CustomControls.CustomRichTextBox();
            CustomButtonShareRulesStatusRead = new CustomControls.CustomButton();
            CustomButtonPDpiCheck = new CustomControls.CustomButton();
            CustomButtonPDpiApplyChanges = new CustomControls.CustomButton();
            CustomButtonSetProxy = new CustomControls.CustomButton();
            CustomButtonShare = new CustomControls.CustomButton();
            CustomRichTextBoxLog = new CustomControls.CustomRichTextBox();
            CustomButtonCheck = new CustomControls.CustomButton();
            CustomGroupBoxLog = new CustomControls.CustomGroupBox();
            CustomCheckBoxInsecure = new CustomControls.CustomCheckBox();
            CustomLabelCustomServersInfo = new CustomControls.CustomLabel();
            CustomButtonEditCustomServers = new CustomControls.CustomButton();
            CustomRadioButtonCustom = new CustomControls.CustomRadioButton();
            CustomRadioButtonBuiltIn = new CustomControls.CustomRadioButton();
            CustomLabelSSLFragmentSize = new CustomControls.CustomLabel();
            CustomNumericUpDownSSLFragmentSize = new CustomControls.CustomNumericUpDown();
            CustomTextBoxHTTPProxy = new CustomControls.CustomTextBox();
            CustomRadioButtonDPIModeExtreme = new CustomControls.CustomRadioButton();
            CustomRadioButtonDPIModeHigh = new CustomControls.CustomRadioButton();
            CustomRadioButtonDPIModeMedium = new CustomControls.CustomRadioButton();
            CustomRadioButtonDPIModeLight = new CustomControls.CustomRadioButton();
            CustomLabelDPIModes = new CustomControls.CustomLabel();
            CustomButtonConnect = new CustomControls.CustomButton();
            CustomTabControlMain = new CustomControls.CustomTabControl();
            TabPageSecureDNS = new TabPage();
            CustomTabControlSecureDNS = new CustomControls.CustomTabControl();
            TabPageCheck = new TabPage();
            SplitContainerCheckMain = new SplitContainer();
            SplitContainerCheckTop = new SplitContainer();
            CustomNumericUpDownCheckInParallel = new CustomControls.CustomNumericUpDown();
            CustomLabelCheckInParallel = new CustomControls.CustomLabel();
            CustomGroupBoxCheckStatus = new CustomControls.CustomGroupBox();
            CustomRichTextBoxCheckStatus = new CustomControls.CustomRichTextBox();
            CustomButtonDisconnectAll = new CustomControls.CustomButton();
            CustomButtonQuickConnect = new CustomControls.CustomButton();
            CustomButtonCheckUpdate = new CustomControls.CustomButton();
            CustomProgressBarCheck = new CustomControls.CustomProgressBar();
            TabPageConnect = new TabPage();
            SplitContainerConnectMain = new SplitContainer();
            SplitContainerConnectTop = new SplitContainer();
            CustomRadioButtonConnectCheckedServers = new CustomControls.CustomRadioButton();
            CustomButtonWriteSavedServersDelay = new CustomControls.CustomButton();
            CustomRadioButtonConnectFakeProxyDohViaProxyDPI = new CustomControls.CustomRadioButton();
            CustomRadioButtonConnectDNSCrypt = new CustomControls.CustomRadioButton();
            CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI = new CustomControls.CustomRadioButton();
            CustomGroupBoxConnectStatus = new CustomControls.CustomGroupBox();
            CustomRichTextBoxConnectStatus = new CustomControls.CustomRichTextBox();
            CustomButtonReconnect = new CustomControls.CustomButton();
            TabPageSetDNS = new TabPage();
            SplitContainerSetDnsMain = new SplitContainer();
            SplitContainerSetDnsTop = new SplitContainer();
            FlowLayoutPanelSetDns = new FlowLayoutPanel();
            CustomLabelSelectNIC = new CustomControls.CustomLabel();
            CustomComboBoxNICs = new CustomControls.CustomComboBox();
            CustomLabelSetDnsSpacer1 = new CustomControls.CustomLabel();
            CustomButtonUpdateNICs = new CustomControls.CustomButton();
            CustomButtonFindActiveNic = new CustomControls.CustomButton();
            CustomButtonEnableDisableNicIPv6 = new CustomControls.CustomButton();
            CustomButtonEnableDisableNic = new CustomControls.CustomButton();
            CustomLabelSetDnsSpacer2 = new CustomControls.CustomLabel();
            CustomGroupBoxNicStatus = new CustomControls.CustomGroupBox();
            CustomDataGridViewNicStatus = new CustomControls.CustomDataGridView();
            ColumnNicStatusName = new DataGridViewTextBoxColumn();
            ColumnNicStatusText = new DataGridViewTextBoxColumn();
            CustomButtonUnsetAllDNSs = new CustomControls.CustomButton();
            CustomButtonSetDNS = new CustomControls.CustomButton();
            TabPageShare = new TabPage();
            TabPageGoodbyeDPI = new TabPage();
            CustomTabControlDPIBasicAdvanced = new CustomControls.CustomTabControl();
            TabPageDPIBasic = new TabPage();
            SplitContainerGoodbyeDpiBasicMain = new SplitContainer();
            CustomLabelInfoDPIModes = new CustomControls.CustomLabel();
            CustomRadioButtonDPIMode6 = new CustomControls.CustomRadioButton();
            CustomRadioButtonDPIMode5 = new CustomControls.CustomRadioButton();
            CustomRadioButtonDPIMode4 = new CustomControls.CustomRadioButton();
            CustomRadioButtonDPIMode3 = new CustomControls.CustomRadioButton();
            CustomLabelDPIModesGoodbyeDPI = new CustomControls.CustomLabel();
            CustomRadioButtonDPIMode2 = new CustomControls.CustomRadioButton();
            CustomRadioButtonDPIMode1 = new CustomControls.CustomRadioButton();
            CustomButtonDPIBasicActivate = new CustomControls.CustomButton();
            CustomButtonDPIBasicDeactivate = new CustomControls.CustomButton();
            TabPageDPIAdvanced = new TabPage();
            SplitContainerGoodbyeDpiAdvancedMain = new SplitContainer();
            CustomCheckBoxDPIAdvP = new CustomControls.CustomCheckBox();
            CustomTextBoxDPIAdvAutoTTL = new CustomControls.CustomTextBox();
            CustomCheckBoxDPIAdvR = new CustomControls.CustomCheckBox();
            CustomNumericUpDownDPIAdvMaxPayload = new CustomControls.CustomNumericUpDown();
            CustomCheckBoxDPIAdvS = new CustomControls.CustomCheckBox();
            CustomNumericUpDownDPIAdvMinTTL = new CustomControls.CustomNumericUpDown();
            CustomCheckBoxDPIAdvM = new CustomControls.CustomCheckBox();
            CustomNumericUpDownDPIAdvSetTTL = new CustomControls.CustomNumericUpDown();
            CustomCheckBoxDPIAdvF = new CustomControls.CustomCheckBox();
            CustomNumericUpDownDPIAdvPort = new CustomControls.CustomNumericUpDown();
            CustomNumericUpDownDPIAdvF = new CustomControls.CustomNumericUpDown();
            CustomButtonDPIAdvBlacklist = new CustomControls.CustomButton();
            CustomCheckBoxDPIAdvK = new CustomControls.CustomCheckBox();
            CustomCheckBoxDPIAdvBlacklist = new CustomControls.CustomCheckBox();
            CustomNumericUpDownDPIAdvK = new CustomControls.CustomNumericUpDown();
            CustomCheckBoxDPIAdvMaxPayload = new CustomControls.CustomCheckBox();
            CustomCheckBoxDPIAdvN = new CustomControls.CustomCheckBox();
            CustomCheckBoxDPIAdvReverseFrag = new CustomControls.CustomCheckBox();
            CustomCheckBoxDPIAdvE = new CustomControls.CustomCheckBox();
            CustomCheckBoxDPIAdvNativeFrag = new CustomControls.CustomCheckBox();
            CustomNumericUpDownDPIAdvE = new CustomControls.CustomNumericUpDown();
            CustomCheckBoxDPIAdvWrongSeq = new CustomControls.CustomCheckBox();
            CustomCheckBoxDPIAdvA = new CustomControls.CustomCheckBox();
            CustomCheckBoxDPIAdvWrongChksum = new CustomControls.CustomCheckBox();
            CustomCheckBoxDPIAdvW = new CustomControls.CustomCheckBox();
            CustomCheckBoxDPIAdvMinTTL = new CustomControls.CustomCheckBox();
            CustomCheckBoxDPIAdvPort = new CustomControls.CustomCheckBox();
            CustomCheckBoxDPIAdvAutoTTL = new CustomControls.CustomCheckBox();
            CustomCheckBoxDPIAdvIpId = new CustomControls.CustomCheckBox();
            CustomCheckBoxDPIAdvSetTTL = new CustomControls.CustomCheckBox();
            CustomTextBoxDPIAdvIpId = new CustomControls.CustomTextBox();
            CustomCheckBoxDPIAdvAllowNoSNI = new CustomControls.CustomCheckBox();
            CustomButtonDPIAdvActivate = new CustomControls.CustomButton();
            CustomButtonDPIAdvDeactivate = new CustomControls.CustomButton();
            TabPageTools = new TabPage();
            CustomButtonBenchmark = new CustomControls.CustomButton();
            CustomButtonToolsFlushDns = new CustomControls.CustomButton();
            CustomButtonToolsDnsScanner = new CustomControls.CustomButton();
            CustomButtonToolsStampGenerator = new CustomControls.CustomButton();
            CustomButtonToolsStampReader = new CustomControls.CustomButton();
            CustomButtonToolsDnsLookup = new CustomControls.CustomButton();
            CustomButtonToolsIpScanner = new CustomControls.CustomButton();
            TabPageSettings = new TabPage();
            SplitContainerSettings = new SplitContainer();
            CustomListBoxSettingsMenu = new CustomControls.CustomListBox();
            CustomTabControlSettings = new CustomControls.CustomTabControl();
            TabPageSettingsWorkingMode = new TabPage();
            CustomNumericUpDownSettingWorkingModeSetDohPort = new CustomControls.CustomNumericUpDown();
            CustomLabelSettingWorkingModeSetDohPort = new CustomControls.CustomLabel();
            CustomButtonSettingUninstallCertificate = new CustomControls.CustomButton();
            CustomRadioButtonSettingWorkingModeDNSandDoH = new CustomControls.CustomRadioButton();
            CustomRadioButtonSettingWorkingModeDNS = new CustomControls.CustomRadioButton();
            CustomLabelSettingInfoWorkingMode1 = new CustomControls.CustomLabel();
            TabPageSettingsCheck = new TabPage();
            CustomCheckBoxSettingCheckClearWorkingServers = new CustomControls.CustomCheckBox();
            CustomGroupBoxSettingCheckDnsProtocol = new CustomControls.CustomGroupBox();
            CustomCheckBoxSettingProtocolPlainDNS = new CustomControls.CustomCheckBox();
            CustomCheckBoxSettingProtocolDoQ = new CustomControls.CustomCheckBox();
            CustomCheckBoxSettingProtocolAnonymizedDNSCrypt = new CustomControls.CustomCheckBox();
            CustomCheckBoxSettingProtocolDNSCrypt = new CustomControls.CustomCheckBox();
            CustomCheckBoxSettingProtocolTLS = new CustomControls.CustomCheckBox();
            CustomCheckBoxSettingProtocolDoH = new CustomControls.CustomCheckBox();
            CustomGroupBoxSettingCheckSDNS = new CustomControls.CustomGroupBox();
            CustomCheckBoxSettingSdnsNoFilter = new CustomControls.CustomCheckBox();
            CustomCheckBoxSettingSdnsNoLog = new CustomControls.CustomCheckBox();
            CustomCheckBoxSettingSdnsDNSSec = new CustomControls.CustomCheckBox();
            CustomTextBoxSettingCheckDPIHost = new CustomControls.CustomTextBox();
            CustomLabelSettingCheckDPIInfo = new CustomControls.CustomLabel();
            CustomLabelSettingCheckTimeout = new CustomControls.CustomLabel();
            CustomNumericUpDownSettingCheckTimeout = new CustomControls.CustomNumericUpDown();
            TabPageSettingsQuickConnect = new TabPage();
            SplitContainerSettingQcMain = new SplitContainer();
            CustomLabelSettingQcInfo = new CustomControls.CustomLabel();
            CustomLabelSettingQcConnectMode = new CustomControls.CustomLabel();
            CustomComboBoxSettingQcConnectMode = new CustomControls.CustomComboBox();
            CustomCheckBoxSettingQcUseSavedServers = new CustomControls.CustomCheckBox();
            CustomCheckBoxSettingQcCheckAllServers = new CustomControls.CustomCheckBox();
            CustomCheckBoxSettingQcSetDnsTo = new CustomControls.CustomCheckBox();
            CustomComboBoxSettingQcNics = new CustomControls.CustomComboBox();
            CustomComboBoxSettingQcGdBasic = new CustomControls.CustomComboBox();
            CustomButtonSettingQcUpdateNics = new CustomControls.CustomButton();
            CustomRadioButtonSettingQcGdAdvanced = new CustomControls.CustomRadioButton();
            CustomCheckBoxSettingQcStartProxyServer = new CustomControls.CustomCheckBox();
            CustomRadioButtonSettingQcGdBasic = new CustomControls.CustomRadioButton();
            CustomCheckBoxSettingQcSetProxy = new CustomControls.CustomCheckBox();
            CustomCheckBoxSettingQcStartGoodbyeDpi = new CustomControls.CustomCheckBox();
            CustomCheckBoxSettingQcOnStartup = new CustomControls.CustomCheckBox();
            CustomButtonSettingQcStartup = new CustomControls.CustomButton();
            TabPageSettingsConnect = new TabPage();
            CustomButtonSettingMalicious = new CustomControls.CustomButton();
            CustomLabelSettingMalicious = new CustomControls.CustomLabel();
            CustomCheckBoxSettingConnectRetry = new CustomControls.CustomCheckBox();
            CustomCheckBoxDnsEventShowRequest = new CustomControls.CustomCheckBox();
            CustomNumericUpDownSettingMaxServers = new CustomControls.CustomNumericUpDown();
            CustomLabelSettingMaxServers = new CustomControls.CustomLabel();
            TabPageSettingsSetUnsetDNS = new TabPage();
            CustomTextBoxSettingUnsetDnsIPv6_2 = new CustomControls.CustomTextBox();
            CustomTextBoxSettingUnsetDnsIPv6_1 = new CustomControls.CustomTextBox();
            CustomLabelSettingUnsetDnsIPv6_2 = new CustomControls.CustomLabel();
            CustomLabelSettingUnsetDnsIPv6_1 = new CustomControls.CustomLabel();
            CustomTextBoxSettingUnsetDns2 = new CustomControls.CustomTextBox();
            CustomTextBoxSettingUnsetDns1 = new CustomControls.CustomTextBox();
            CustomLabelSettingUnsetDns2 = new CustomControls.CustomLabel();
            CustomLabelSettingUnsetDns1 = new CustomControls.CustomLabel();
            CustomRadioButtonSettingUnsetDnsToStatic = new CustomControls.CustomRadioButton();
            CustomRadioButtonSettingUnsetDnsToDhcp = new CustomControls.CustomRadioButton();
            TabPageSettingsShare = new TabPage();
            CustomTabControlSettingProxy = new CustomControls.CustomTabControl();
            TabPageSettingProxyBasic = new TabPage();
            CustomNumericUpDownSettingProxyKillRequestTimeout = new CustomControls.CustomNumericUpDown();
            CustomLabelSettingProxyKillRequestTimeout = new CustomControls.CustomLabel();
            CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs = new CustomControls.CustomCheckBox();
            CustomNumericUpDownSettingProxyUpstreamPort = new CustomControls.CustomNumericUpDown();
            CustomTextBoxSettingProxyUpstreamHost = new CustomControls.CustomTextBox();
            CustomLabelSettingProxyUpstreamPort = new CustomControls.CustomLabel();
            CustomLabelSettingProxyUpstreamHost = new CustomControls.CustomLabel();
            CustomComboBoxSettingProxyUpstreamMode = new CustomControls.CustomComboBox();
            CustomCheckBoxSettingProxyUpstream = new CustomControls.CustomCheckBox();
            CustomLabelSettingProxyPort = new CustomControls.CustomLabel();
            CustomCheckBoxSettingProxyBlockPort80 = new CustomControls.CustomCheckBox();
            CustomLabelSettingProxyHandleRequests = new CustomControls.CustomLabel();
            CustomNumericUpDownSettingProxyPort = new CustomControls.CustomNumericUpDown();
            CustomNumericUpDownSettingProxyHandleRequests = new CustomControls.CustomNumericUpDown();
            TabPageSettingsFakeProxy = new TabPage();
            CustomTextBoxSettingFakeProxyDohCleanIP = new CustomControls.CustomTextBox();
            CustomTextBoxSettingFakeProxyDohAddress = new CustomControls.CustomTextBox();
            CustomLabelSettingFakeProxyDohCleanIP = new CustomControls.CustomLabel();
            CustomLabelSettingFakeProxyDohAddress = new CustomControls.CustomLabel();
            CustomLabelSettingFakeProxyInfo = new CustomControls.CustomLabel();
            TabPageSettingsRules = new TabPage();
            FlowLayoutPanelRules = new FlowLayoutPanel();
            FlowLayoutPanelRules2 = new FlowLayoutPanel();
            CustomCheckBoxSettingProxyCfCleanIP = new CustomControls.CustomCheckBox();
            CustomTextBoxSettingProxyCfCleanIP = new CustomControls.CustomTextBox();
            FlowLayoutPanelRules3 = new FlowLayoutPanel();
            CustomCheckBoxSettingEnableRules = new CustomControls.CustomCheckBox();
            CustomButtonSettingRules = new CustomControls.CustomButton();
            LinkLabelSettingRulesHelp = new LinkLabel();
            TabPageSettingsGeoAssets = new TabPage();
            FlowLayoutPanelGeoAssets = new FlowLayoutPanel();
            CustomLabelGeoAssetsSpacer1 = new CustomControls.CustomLabel();
            CustomCheckBoxGeoAsset_IR_Domains = new CustomControls.CustomCheckBox();
            CustomCheckBoxGeoAsset_IR_CIDRs = new CustomControls.CustomCheckBox();
            CustomCheckBoxGeoAsset_IR_ADS = new CustomControls.CustomCheckBox();
            CustomLabelGeoAssetsSpacer2 = new CustomControls.CustomLabel();
            FlowLayoutPanelGeoAssets2 = new FlowLayoutPanel();
            CustomCheckBoxGeoAssetUpdate = new CustomControls.CustomCheckBox();
            CustomNumericUpDownGeoAssetsUpdate = new CustomControls.CustomNumericUpDown();
            CustomLabelGeoAssetsSpacer3 = new CustomControls.CustomLabel();
            TabPageSettingsCPU = new TabPage();
            CustomNumericUpDownUpdateAutoDelayMS = new CustomControls.CustomNumericUpDown();
            CustomLabelUpdateAutoDelayMS = new CustomControls.CustomLabel();
            CustomNumericUpDownSettingCpuKillProxyRequests = new CustomControls.CustomNumericUpDown();
            CustomLabelSettingCpuKillProxyRequests = new CustomControls.CustomLabel();
            CustomRadioButtonSettingCPULow = new CustomControls.CustomRadioButton();
            CustomRadioButtonSettingCPUBelowNormal = new CustomControls.CustomRadioButton();
            CustomRadioButtonSettingCPUNormal = new CustomControls.CustomRadioButton();
            CustomRadioButtonSettingCPUAboveNormal = new CustomControls.CustomRadioButton();
            CustomRadioButtonSettingCPUHigh = new CustomControls.CustomRadioButton();
            CustomLabelSettingInfoCPU = new CustomControls.CustomLabel();
            TabPageSettingsOthers = new TabPage();
            SplitContainerSettingOthersMain = new SplitContainer();
            CustomCheckBoxSettingAlertDisplayChanges = new CustomControls.CustomCheckBox();
            CustomLabelSettingBootstrapDnsIP = new CustomControls.CustomLabel();
            CustomCheckBoxSettingWriteLogWindowToFile = new CustomControls.CustomCheckBox();
            CustomTextBoxSettingBootstrapDnsIP = new CustomControls.CustomTextBox();
            CustomNumericUpDownSettingFallbackDnsPort = new CustomControls.CustomNumericUpDown();
            CustomLabelSettingFallbackDnsPort = new CustomControls.CustomLabel();
            CustomCheckBoxSettingDisableAudioAlert = new CustomControls.CustomCheckBox();
            CustomTextBoxSettingFallbackDnsIP = new CustomControls.CustomTextBox();
            CustomLabelSettingBootstrapDnsPort = new CustomControls.CustomLabel();
            CustomLabelSettingFallbackDnsIP = new CustomControls.CustomLabel();
            CustomNumericUpDownSettingBootstrapDnsPort = new CustomControls.CustomNumericUpDown();
            CustomButtonSettingRestoreDefault = new CustomControls.CustomButton();
            CustomButtonImportUserData = new CustomControls.CustomButton();
            CustomButtonExportUserData = new CustomControls.CustomButton();
            TabPageAbout = new TabPage();
            LinkLabelStNonbarbari = new LinkLabel();
            LinkLabelStWolfkingal2000 = new LinkLabel();
            CustomLabelAboutVersion = new CustomControls.CustomLabel();
            PictureBoxFarvahar = new PictureBox();
            CustomLabelAboutCopyright = new CustomControls.CustomLabel();
            LinkLabelStAlidxdydz = new LinkLabel();
            CustomLabelAboutSpecialThanks = new CustomControls.CustomLabel();
            LinkLabelGoodbyeDPI = new LinkLabel();
            LinkLabelDNSLookup = new LinkLabel();
            CustomLabelAboutUsing = new CustomControls.CustomLabel();
            CustomLabelAboutThis2 = new CustomControls.CustomLabel();
            CustomLabelAboutThis = new CustomControls.CustomLabel();
            PictureBoxAbout = new PictureBox();
            CustomDataGridViewStatus = new CustomControls.CustomDataGridView();
            ColumnStatusName = new DataGridViewTextBoxColumn();
            ColumnStatusText = new DataGridViewTextBoxColumn();
            NotifyIconMain = new NotifyIcon(components);
            CustomContextMenuStripIcon = new CustomControls.CustomContextMenuStrip();
            CustomGroupBoxStatus = new CustomControls.CustomGroupBox();
            SplitContainerStatusMain = new SplitContainer();
            CustomButtonExit = new CustomControls.CustomButton();
            CustomButtonProcessMonitor = new CustomControls.CustomButton();
            SplitContainerMain = new SplitContainer();
            SplitContainerTop = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)SplitContainerShareMain).BeginInit();
            SplitContainerShareMain.Panel1.SuspendLayout();
            SplitContainerShareMain.Panel2.SuspendLayout();
            SplitContainerShareMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerShareTop).BeginInit();
            SplitContainerShareTop.Panel1.SuspendLayout();
            SplitContainerShareTop.Panel2.SuspendLayout();
            SplitContainerShareTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerShareContent).BeginInit();
            SplitContainerShareContent.Panel1.SuspendLayout();
            SplitContainerShareContent.Panel2.SuspendLayout();
            SplitContainerShareContent.SuspendLayout();
            CustomTabControlShareDpiBypassOptions.SuspendLayout();
            TabPageShareFragment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownPDpiFragDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownPDpiAntiPatternOffset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownPDpiSniChunks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownPDpiBeforeSniChunks).BeginInit();
            TabPageShareSslDecryption.SuspendLayout();
            CustomGroupBoxShareRulesStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerShareRulesStatus1).BeginInit();
            SplitContainerShareRulesStatus1.Panel1.SuspendLayout();
            SplitContainerShareRulesStatus1.Panel2.SuspendLayout();
            SplitContainerShareRulesStatus1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerShareRulesStatus2).BeginInit();
            SplitContainerShareRulesStatus2.Panel1.SuspendLayout();
            SplitContainerShareRulesStatus2.Panel2.SuspendLayout();
            SplitContainerShareRulesStatus2.SuspendLayout();
            CustomGroupBoxLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSSLFragmentSize).BeginInit();
            CustomTabControlMain.SuspendLayout();
            TabPageSecureDNS.SuspendLayout();
            CustomTabControlSecureDNS.SuspendLayout();
            TabPageCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerCheckMain).BeginInit();
            SplitContainerCheckMain.Panel1.SuspendLayout();
            SplitContainerCheckMain.Panel2.SuspendLayout();
            SplitContainerCheckMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerCheckTop).BeginInit();
            SplitContainerCheckTop.Panel1.SuspendLayout();
            SplitContainerCheckTop.Panel2.SuspendLayout();
            SplitContainerCheckTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownCheckInParallel).BeginInit();
            CustomGroupBoxCheckStatus.SuspendLayout();
            TabPageConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerConnectMain).BeginInit();
            SplitContainerConnectMain.Panel1.SuspendLayout();
            SplitContainerConnectMain.Panel2.SuspendLayout();
            SplitContainerConnectMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerConnectTop).BeginInit();
            SplitContainerConnectTop.Panel1.SuspendLayout();
            SplitContainerConnectTop.Panel2.SuspendLayout();
            SplitContainerConnectTop.SuspendLayout();
            CustomGroupBoxConnectStatus.SuspendLayout();
            TabPageSetDNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerSetDnsMain).BeginInit();
            SplitContainerSetDnsMain.Panel1.SuspendLayout();
            SplitContainerSetDnsMain.Panel2.SuspendLayout();
            SplitContainerSetDnsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerSetDnsTop).BeginInit();
            SplitContainerSetDnsTop.Panel1.SuspendLayout();
            SplitContainerSetDnsTop.Panel2.SuspendLayout();
            SplitContainerSetDnsTop.SuspendLayout();
            FlowLayoutPanelSetDns.SuspendLayout();
            CustomGroupBoxNicStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomDataGridViewNicStatus).BeginInit();
            TabPageShare.SuspendLayout();
            TabPageGoodbyeDPI.SuspendLayout();
            CustomTabControlDPIBasicAdvanced.SuspendLayout();
            TabPageDPIBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerGoodbyeDpiBasicMain).BeginInit();
            SplitContainerGoodbyeDpiBasicMain.Panel1.SuspendLayout();
            SplitContainerGoodbyeDpiBasicMain.Panel2.SuspendLayout();
            SplitContainerGoodbyeDpiBasicMain.SuspendLayout();
            TabPageDPIAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerGoodbyeDpiAdvancedMain).BeginInit();
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.SuspendLayout();
            SplitContainerGoodbyeDpiAdvancedMain.Panel2.SuspendLayout();
            SplitContainerGoodbyeDpiAdvancedMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownDPIAdvMaxPayload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownDPIAdvMinTTL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownDPIAdvSetTTL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownDPIAdvPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownDPIAdvF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownDPIAdvK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownDPIAdvE).BeginInit();
            TabPageTools.SuspendLayout();
            TabPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerSettings).BeginInit();
            SplitContainerSettings.Panel1.SuspendLayout();
            SplitContainerSettings.Panel2.SuspendLayout();
            SplitContainerSettings.SuspendLayout();
            CustomTabControlSettings.SuspendLayout();
            TabPageSettingsWorkingMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingWorkingModeSetDohPort).BeginInit();
            TabPageSettingsCheck.SuspendLayout();
            CustomGroupBoxSettingCheckDnsProtocol.SuspendLayout();
            CustomGroupBoxSettingCheckSDNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingCheckTimeout).BeginInit();
            TabPageSettingsQuickConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerSettingQcMain).BeginInit();
            SplitContainerSettingQcMain.Panel1.SuspendLayout();
            SplitContainerSettingQcMain.Panel2.SuspendLayout();
            SplitContainerSettingQcMain.SuspendLayout();
            TabPageSettingsConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingMaxServers).BeginInit();
            TabPageSettingsSetUnsetDNS.SuspendLayout();
            TabPageSettingsShare.SuspendLayout();
            CustomTabControlSettingProxy.SuspendLayout();
            TabPageSettingProxyBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingProxyKillRequestTimeout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingProxyUpstreamPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingProxyPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingProxyHandleRequests).BeginInit();
            TabPageSettingsFakeProxy.SuspendLayout();
            TabPageSettingsRules.SuspendLayout();
            FlowLayoutPanelRules.SuspendLayout();
            FlowLayoutPanelRules2.SuspendLayout();
            FlowLayoutPanelRules3.SuspendLayout();
            TabPageSettingsGeoAssets.SuspendLayout();
            FlowLayoutPanelGeoAssets.SuspendLayout();
            FlowLayoutPanelGeoAssets2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownGeoAssetsUpdate).BeginInit();
            TabPageSettingsCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownUpdateAutoDelayMS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingCpuKillProxyRequests).BeginInit();
            TabPageSettingsOthers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerSettingOthersMain).BeginInit();
            SplitContainerSettingOthersMain.Panel1.SuspendLayout();
            SplitContainerSettingOthersMain.Panel2.SuspendLayout();
            SplitContainerSettingOthersMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingFallbackDnsPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingBootstrapDnsPort).BeginInit();
            TabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFarvahar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAbout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomDataGridViewStatus).BeginInit();
            CustomGroupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerStatusMain).BeginInit();
            SplitContainerStatusMain.Panel1.SuspendLayout();
            SplitContainerStatusMain.Panel2.SuspendLayout();
            SplitContainerStatusMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerMain).BeginInit();
            SplitContainerMain.Panel1.SuspendLayout();
            SplitContainerMain.Panel2.SuspendLayout();
            SplitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainerTop).BeginInit();
            SplitContainerTop.Panel1.SuspendLayout();
            SplitContainerTop.Panel2.SuspendLayout();
            SplitContainerTop.SuspendLayout();
            SuspendLayout();
            // 
            // SplitContainerShareMain
            // 
            SplitContainerShareMain.Dock = DockStyle.Fill;
            SplitContainerShareMain.FixedPanel = FixedPanel.Panel2;
            SplitContainerShareMain.IsSplitterFixed = true;
            SplitContainerShareMain.Location = new Point(3, 3);
            SplitContainerShareMain.MinimumSize = new Size(200, 200);
            SplitContainerShareMain.Name = "SplitContainerShareMain";
            SplitContainerShareMain.Orientation = Orientation.Horizontal;
            // 
            // SplitContainerShareMain.Panel1
            // 
            SplitContainerShareMain.Panel1.Controls.Add(SplitContainerShareTop);
            SplitContainerShareMain.Panel1MinSize = 200;
            // 
            // SplitContainerShareMain.Panel2
            // 
            SplitContainerShareMain.Panel2.Controls.Add(CustomButtonPDpiCheck);
            SplitContainerShareMain.Panel2.Controls.Add(CustomButtonPDpiApplyChanges);
            SplitContainerShareMain.Panel2.Controls.Add(CustomButtonSetProxy);
            SplitContainerShareMain.Panel2.Controls.Add(CustomButtonShare);
            SplitContainerShareMain.Panel2MinSize = 40;
            SplitContainerShareMain.Size = new Size(751, 330);
            SplitContainerShareMain.SplitterDistance = 275;
            SplitContainerShareMain.TabIndex = 0;
            // 
            // SplitContainerShareTop
            // 
            SplitContainerShareTop.Dock = DockStyle.Fill;
            SplitContainerShareTop.Location = new Point(0, 0);
            SplitContainerShareTop.Name = "SplitContainerShareTop";
            // 
            // SplitContainerShareTop.Panel1
            // 
            SplitContainerShareTop.Panel1.Controls.Add(SplitContainerShareContent);
            SplitContainerShareTop.Panel1MinSize = 400;
            // 
            // SplitContainerShareTop.Panel2
            // 
            SplitContainerShareTop.Panel2.Controls.Add(CustomGroupBoxShareRulesStatus);
            SplitContainerShareTop.Panel2MinSize = 200;
            SplitContainerShareTop.Size = new Size(751, 275);
            SplitContainerShareTop.SplitterDistance = 547;
            SplitContainerShareTop.TabIndex = 5;
            // 
            // SplitContainerShareContent
            // 
            SplitContainerShareContent.Dock = DockStyle.Fill;
            SplitContainerShareContent.FixedPanel = FixedPanel.Panel1;
            SplitContainerShareContent.IsSplitterFixed = true;
            SplitContainerShareContent.Location = new Point(0, 0);
            SplitContainerShareContent.Name = "SplitContainerShareContent";
            SplitContainerShareContent.Orientation = Orientation.Horizontal;
            // 
            // SplitContainerShareContent.Panel1
            // 
            SplitContainerShareContent.Panel1.Controls.Add(CustomLabelProxySSLInfo);
            SplitContainerShareContent.Panel1.Controls.Add(CustomCheckBoxProxyEnableSSL);
            SplitContainerShareContent.Panel1.Controls.Add(CustomLabelShareInfo);
            SplitContainerShareContent.Panel1.Controls.Add(CustomCheckBoxProxyEventShowRequest);
            SplitContainerShareContent.Panel1.Controls.Add(CustomCheckBoxPDpiEnableFragment);
            // 
            // SplitContainerShareContent.Panel2
            // 
            SplitContainerShareContent.Panel2.Controls.Add(CustomTabControlShareDpiBypassOptions);
            SplitContainerShareContent.Size = new Size(547, 275);
            SplitContainerShareContent.SplitterDistance = 148;
            SplitContainerShareContent.TabIndex = 1;
            // 
            // CustomLabelProxySSLInfo
            // 
            CustomLabelProxySSLInfo.AutoSize = true;
            CustomLabelProxySSLInfo.BackColor = Color.DimGray;
            CustomLabelProxySSLInfo.Border = false;
            CustomLabelProxySSLInfo.BorderColor = Color.Blue;
            CustomLabelProxySSLInfo.FlatStyle = FlatStyle.Flat;
            CustomLabelProxySSLInfo.ForeColor = Color.White;
            CustomLabelProxySSLInfo.Location = new Point(164, 83);
            CustomLabelProxySSLInfo.Margin = new Padding(3);
            CustomLabelProxySSLInfo.Name = "CustomLabelProxySSLInfo";
            CustomLabelProxySSLInfo.RoundedCorners = 0;
            CustomLabelProxySSLInfo.Size = new Size(214, 17);
            CustomLabelProxySSLInfo.TabIndex = 147;
            CustomLabelProxySSLInfo.Text = "By Installing Root Certificate Authority.";
            CustomLabelProxySSLInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomCheckBoxProxyEnableSSL
            // 
            CustomCheckBoxProxyEnableSSL.BackColor = Color.DimGray;
            CustomCheckBoxProxyEnableSSL.BorderColor = Color.Blue;
            CustomCheckBoxProxyEnableSSL.CheckColor = Color.Blue;
            CustomCheckBoxProxyEnableSSL.ForeColor = Color.White;
            CustomCheckBoxProxyEnableSSL.Location = new Point(13, 83);
            CustomCheckBoxProxyEnableSSL.Name = "CustomCheckBoxProxyEnableSSL";
            CustomCheckBoxProxyEnableSSL.SelectionColor = Color.LightBlue;
            CustomCheckBoxProxyEnableSSL.Size = new Size(145, 17);
            CustomCheckBoxProxyEnableSSL.TabIndex = 148;
            CustomCheckBoxProxyEnableSSL.Text = "Enable SSL Decryption";
            CustomCheckBoxProxyEnableSSL.UseVisualStyleBackColor = false;
            CustomCheckBoxProxyEnableSSL.CheckedChanged += CustomCheckBoxProxyEnableSSL_CheckedChanged;
            // 
            // CustomLabelShareInfo
            // 
            CustomLabelShareInfo.AutoSize = true;
            CustomLabelShareInfo.BackColor = Color.DimGray;
            CustomLabelShareInfo.Border = false;
            CustomLabelShareInfo.BorderColor = Color.Blue;
            CustomLabelShareInfo.FlatStyle = FlatStyle.Flat;
            CustomLabelShareInfo.Font = new Font("Segoe UI", 12F);
            CustomLabelShareInfo.ForeColor = Color.White;
            CustomLabelShareInfo.Location = new Point(13, 5);
            CustomLabelShareInfo.Name = "CustomLabelShareInfo";
            CustomLabelShareInfo.RoundedCorners = 0;
            CustomLabelShareInfo.Size = new Size(319, 23);
            CustomLabelShareInfo.TabIndex = 132;
            CustomLabelShareInfo.Text = "Share to other devices on the same network.";
            // 
            // CustomCheckBoxProxyEventShowRequest
            // 
            CustomCheckBoxProxyEventShowRequest.BackColor = Color.DimGray;
            CustomCheckBoxProxyEventShowRequest.BorderColor = Color.Blue;
            CustomCheckBoxProxyEventShowRequest.CheckColor = Color.Blue;
            CustomCheckBoxProxyEventShowRequest.Checked = true;
            CustomCheckBoxProxyEventShowRequest.CheckState = CheckState.Checked;
            CustomCheckBoxProxyEventShowRequest.ForeColor = Color.White;
            CustomCheckBoxProxyEventShowRequest.Location = new Point(13, 37);
            CustomCheckBoxProxyEventShowRequest.Name = "CustomCheckBoxProxyEventShowRequest";
            CustomCheckBoxProxyEventShowRequest.SelectionColor = Color.LightBlue;
            CustomCheckBoxProxyEventShowRequest.Size = new Size(125, 17);
            CustomCheckBoxProxyEventShowRequest.TabIndex = 133;
            CustomCheckBoxProxyEventShowRequest.Text = "Write requests to log";
            CustomCheckBoxProxyEventShowRequest.UseVisualStyleBackColor = false;
            CustomCheckBoxProxyEventShowRequest.CheckedChanged += SecureDNSClient_CheckedChanged;
            // 
            // CustomCheckBoxPDpiEnableFragment
            // 
            CustomCheckBoxPDpiEnableFragment.BackColor = Color.DimGray;
            CustomCheckBoxPDpiEnableFragment.BorderColor = Color.Blue;
            CustomCheckBoxPDpiEnableFragment.CheckColor = Color.Blue;
            CustomCheckBoxPDpiEnableFragment.Checked = true;
            CustomCheckBoxPDpiEnableFragment.CheckState = CheckState.Checked;
            CustomCheckBoxPDpiEnableFragment.ForeColor = Color.White;
            CustomCheckBoxPDpiEnableFragment.Location = new Point(13, 60);
            CustomCheckBoxPDpiEnableFragment.Name = "CustomCheckBoxPDpiEnableFragment";
            CustomCheckBoxPDpiEnableFragment.SelectionColor = Color.LightBlue;
            CustomCheckBoxPDpiEnableFragment.Size = new Size(121, 17);
            CustomCheckBoxPDpiEnableFragment.TabIndex = 151;
            CustomCheckBoxPDpiEnableFragment.Text = "Enable Fragment";
            CustomCheckBoxPDpiEnableFragment.UseVisualStyleBackColor = false;
            CustomCheckBoxPDpiEnableFragment.TextChanged += CustomCheckBoxPDpiEnableFragment_TextChanged;
            CustomCheckBoxPDpiEnableFragment.CheckedChanged += CustomCheckBoxPDpiEnableFragment_CheckedChanged;
            // 
            // CustomTabControlShareDpiBypassOptions
            // 
            CustomTabControlShareDpiBypassOptions.BorderColor = Color.Blue;
            CustomTabControlShareDpiBypassOptions.Controls.Add(TabPageShareFragment);
            CustomTabControlShareDpiBypassOptions.Controls.Add(TabPageShareSslDecryption);
            CustomTabControlShareDpiBypassOptions.Dock = DockStyle.Fill;
            CustomTabControlShareDpiBypassOptions.HideTabHeader = false;
            CustomTabControlShareDpiBypassOptions.ItemSize = new Size(140, 21);
            CustomTabControlShareDpiBypassOptions.Location = new Point(0, 0);
            CustomTabControlShareDpiBypassOptions.Name = "CustomTabControlShareDpiBypassOptions";
            CustomTabControlShareDpiBypassOptions.RoundedCorners = 5;
            CustomTabControlShareDpiBypassOptions.SelectedIndex = 0;
            CustomTabControlShareDpiBypassOptions.Size = new Size(547, 123);
            CustomTabControlShareDpiBypassOptions.SizeMode = TabSizeMode.Fixed;
            CustomTabControlShareDpiBypassOptions.TabIndex = 1;
            CustomTabControlShareDpiBypassOptions.Tag = 0;
            // 
            // TabPageShareFragment
            // 
            TabPageShareFragment.AutoScroll = true;
            TabPageShareFragment.BackColor = Color.Transparent;
            TabPageShareFragment.Controls.Add(CustomButtonPDpiPresetDefault);
            TabPageShareFragment.Controls.Add(CustomCheckBoxProxyEventShowChunkDetails);
            TabPageShareFragment.Controls.Add(CustomNumericUpDownPDpiFragDelay);
            TabPageShareFragment.Controls.Add(CustomLabelPDpiPresets);
            TabPageShareFragment.Controls.Add(CustomNumericUpDownPDpiAntiPatternOffset);
            TabPageShareFragment.Controls.Add(CustomLabelPDpiFragDelay);
            TabPageShareFragment.Controls.Add(CustomLabelPDpiBeforeSniChunks);
            TabPageShareFragment.Controls.Add(CustomNumericUpDownPDpiSniChunks);
            TabPageShareFragment.Controls.Add(CustomLabelPDpiSniChunkMode);
            TabPageShareFragment.Controls.Add(CustomNumericUpDownPDpiBeforeSniChunks);
            TabPageShareFragment.Controls.Add(CustomComboBoxPDpiSniChunkMode);
            TabPageShareFragment.Controls.Add(CustomLabelPDpiSniChunks);
            TabPageShareFragment.Controls.Add(CustomLabelPDpiAntiPatternOffset);
            TabPageShareFragment.Location = new Point(4, 25);
            TabPageShareFragment.Name = "TabPageShareFragment";
            TabPageShareFragment.Padding = new Padding(3);
            TabPageShareFragment.Size = new Size(539, 94);
            TabPageShareFragment.TabIndex = 0;
            TabPageShareFragment.Tag = 0;
            TabPageShareFragment.Text = "Fragment Options";
            TabPageShareFragment.Visible = false;
            // 
            // CustomButtonPDpiPresetDefault
            // 
            CustomButtonPDpiPresetDefault.BorderColor = Color.Blue;
            CustomButtonPDpiPresetDefault.FlatStyle = FlatStyle.Flat;
            CustomButtonPDpiPresetDefault.Location = new Point(329, 61);
            CustomButtonPDpiPresetDefault.Name = "CustomButtonPDpiPresetDefault";
            CustomButtonPDpiPresetDefault.RoundedCorners = 5;
            CustomButtonPDpiPresetDefault.SelectionColor = Color.LightBlue;
            CustomButtonPDpiPresetDefault.Size = new Size(75, 27);
            CustomButtonPDpiPresetDefault.TabIndex = 145;
            CustomButtonPDpiPresetDefault.Text = "Default";
            CustomButtonPDpiPresetDefault.UseVisualStyleBackColor = true;
            CustomButtonPDpiPresetDefault.Click += CustomButtonPDpiPresetDefault_Click;
            // 
            // CustomCheckBoxProxyEventShowChunkDetails
            // 
            CustomCheckBoxProxyEventShowChunkDetails.BackColor = Color.DimGray;
            CustomCheckBoxProxyEventShowChunkDetails.BorderColor = Color.Blue;
            CustomCheckBoxProxyEventShowChunkDetails.CheckColor = Color.Blue;
            CustomCheckBoxProxyEventShowChunkDetails.ForeColor = Color.White;
            CustomCheckBoxProxyEventShowChunkDetails.Location = new Point(318, 125);
            CustomCheckBoxProxyEventShowChunkDetails.Name = "CustomCheckBoxProxyEventShowChunkDetails";
            CustomCheckBoxProxyEventShowChunkDetails.SelectionColor = Color.LightBlue;
            CustomCheckBoxProxyEventShowChunkDetails.Size = new Size(158, 17);
            CustomCheckBoxProxyEventShowChunkDetails.TabIndex = 113;
            CustomCheckBoxProxyEventShowChunkDetails.Text = "Write fragment details to log";
            CustomCheckBoxProxyEventShowChunkDetails.UseVisualStyleBackColor = false;
            CustomCheckBoxProxyEventShowChunkDetails.CheckedChanged += SecureDNSClient_CheckedChanged;
            // 
            // CustomNumericUpDownPDpiFragDelay
            // 
            CustomNumericUpDownPDpiFragDelay.BackColor = Color.DimGray;
            CustomNumericUpDownPDpiFragDelay.BorderColor = Color.Blue;
            CustomNumericUpDownPDpiFragDelay.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownPDpiFragDelay.Location = new Point(164, 123);
            CustomNumericUpDownPDpiFragDelay.Name = "CustomNumericUpDownPDpiFragDelay";
            CustomNumericUpDownPDpiFragDelay.RoundedCorners = 5;
            CustomNumericUpDownPDpiFragDelay.Size = new Size(44, 23);
            CustomNumericUpDownPDpiFragDelay.TabIndex = 137;
            CustomNumericUpDownPDpiFragDelay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownPDpiFragDelay.ValueChanged += CustomNumericUpDownPDpiFragment_ValueChanged;
            // 
            // CustomLabelPDpiPresets
            // 
            CustomLabelPDpiPresets.AutoSize = true;
            CustomLabelPDpiPresets.BackColor = Color.DimGray;
            CustomLabelPDpiPresets.Border = false;
            CustomLabelPDpiPresets.BorderColor = Color.Blue;
            CustomLabelPDpiPresets.FlatStyle = FlatStyle.Flat;
            CustomLabelPDpiPresets.ForeColor = Color.White;
            CustomLabelPDpiPresets.Location = new Point(318, 39);
            CustomLabelPDpiPresets.Name = "CustomLabelPDpiPresets";
            CustomLabelPDpiPresets.RoundedCorners = 0;
            CustomLabelPDpiPresets.Size = new Size(49, 17);
            CustomLabelPDpiPresets.TabIndex = 144;
            CustomLabelPDpiPresets.Text = "Presets:";
            // 
            // CustomNumericUpDownPDpiAntiPatternOffset
            // 
            CustomNumericUpDownPDpiAntiPatternOffset.BackColor = Color.DimGray;
            CustomNumericUpDownPDpiAntiPatternOffset.BorderColor = Color.Blue;
            CustomNumericUpDownPDpiAntiPatternOffset.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownPDpiAntiPatternOffset.Location = new Point(164, 94);
            CustomNumericUpDownPDpiAntiPatternOffset.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            CustomNumericUpDownPDpiAntiPatternOffset.Name = "CustomNumericUpDownPDpiAntiPatternOffset";
            CustomNumericUpDownPDpiAntiPatternOffset.RoundedCorners = 5;
            CustomNumericUpDownPDpiAntiPatternOffset.Size = new Size(44, 23);
            CustomNumericUpDownPDpiAntiPatternOffset.TabIndex = 139;
            CustomNumericUpDownPDpiAntiPatternOffset.Value = new decimal(new int[] { 2, 0, 0, 0 });
            CustomNumericUpDownPDpiAntiPatternOffset.ValueChanged += CustomNumericUpDownPDpiFragment_ValueChanged;
            // 
            // CustomLabelPDpiFragDelay
            // 
            CustomLabelPDpiFragDelay.AutoSize = true;
            CustomLabelPDpiFragDelay.BackColor = Color.DimGray;
            CustomLabelPDpiFragDelay.Border = false;
            CustomLabelPDpiFragDelay.BorderColor = Color.Blue;
            CustomLabelPDpiFragDelay.FlatStyle = FlatStyle.Flat;
            CustomLabelPDpiFragDelay.ForeColor = Color.White;
            CustomLabelPDpiFragDelay.Location = new Point(22, 125);
            CustomLabelPDpiFragDelay.Margin = new Padding(3);
            CustomLabelPDpiFragDelay.Name = "CustomLabelPDpiFragDelay";
            CustomLabelPDpiFragDelay.RoundedCorners = 0;
            CustomLabelPDpiFragDelay.Size = new Size(119, 15);
            CustomLabelPDpiFragDelay.TabIndex = 136;
            CustomLabelPDpiFragDelay.Text = "Fragment delay (ms):";
            CustomLabelPDpiFragDelay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomLabelPDpiBeforeSniChunks
            // 
            CustomLabelPDpiBeforeSniChunks.AutoSize = true;
            CustomLabelPDpiBeforeSniChunks.BackColor = Color.DimGray;
            CustomLabelPDpiBeforeSniChunks.Border = false;
            CustomLabelPDpiBeforeSniChunks.BorderColor = Color.Blue;
            CustomLabelPDpiBeforeSniChunks.FlatStyle = FlatStyle.Flat;
            CustomLabelPDpiBeforeSniChunks.ForeColor = Color.White;
            CustomLabelPDpiBeforeSniChunks.Location = new Point(22, 8);
            CustomLabelPDpiBeforeSniChunks.Margin = new Padding(3);
            CustomLabelPDpiBeforeSniChunks.Name = "CustomLabelPDpiBeforeSniChunks";
            CustomLabelPDpiBeforeSniChunks.RoundedCorners = 0;
            CustomLabelPDpiBeforeSniChunks.Size = new Size(110, 17);
            CustomLabelPDpiBeforeSniChunks.TabIndex = 142;
            CustomLabelPDpiBeforeSniChunks.Text = "Chunks before SNI:";
            CustomLabelPDpiBeforeSniChunks.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomNumericUpDownPDpiSniChunks
            // 
            CustomNumericUpDownPDpiSniChunks.BackColor = Color.DimGray;
            CustomNumericUpDownPDpiSniChunks.BorderColor = Color.Blue;
            CustomNumericUpDownPDpiSniChunks.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownPDpiSniChunks.Location = new Point(164, 65);
            CustomNumericUpDownPDpiSniChunks.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            CustomNumericUpDownPDpiSniChunks.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownPDpiSniChunks.Name = "CustomNumericUpDownPDpiSniChunks";
            CustomNumericUpDownPDpiSniChunks.RoundedCorners = 5;
            CustomNumericUpDownPDpiSniChunks.Size = new Size(44, 23);
            CustomNumericUpDownPDpiSniChunks.TabIndex = 135;
            CustomNumericUpDownPDpiSniChunks.Value = new decimal(new int[] { 5, 0, 0, 0 });
            CustomNumericUpDownPDpiSniChunks.ValueChanged += CustomNumericUpDownPDpiFragment_ValueChanged;
            // 
            // CustomLabelPDpiSniChunkMode
            // 
            CustomLabelPDpiSniChunkMode.AutoSize = true;
            CustomLabelPDpiSniChunkMode.BackColor = Color.DimGray;
            CustomLabelPDpiSniChunkMode.Border = false;
            CustomLabelPDpiSniChunkMode.BorderColor = Color.Blue;
            CustomLabelPDpiSniChunkMode.FlatStyle = FlatStyle.Flat;
            CustomLabelPDpiSniChunkMode.ForeColor = Color.White;
            CustomLabelPDpiSniChunkMode.Location = new Point(22, 39);
            CustomLabelPDpiSniChunkMode.Margin = new Padding(3);
            CustomLabelPDpiSniChunkMode.Name = "CustomLabelPDpiSniChunkMode";
            CustomLabelPDpiSniChunkMode.RoundedCorners = 0;
            CustomLabelPDpiSniChunkMode.Size = new Size(100, 17);
            CustomLabelPDpiSniChunkMode.TabIndex = 141;
            CustomLabelPDpiSniChunkMode.Text = "SNI chunk mode:";
            CustomLabelPDpiSniChunkMode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomNumericUpDownPDpiBeforeSniChunks
            // 
            CustomNumericUpDownPDpiBeforeSniChunks.BackColor = Color.DimGray;
            CustomNumericUpDownPDpiBeforeSniChunks.BorderColor = Color.Blue;
            CustomNumericUpDownPDpiBeforeSniChunks.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownPDpiBeforeSniChunks.Location = new Point(164, 6);
            CustomNumericUpDownPDpiBeforeSniChunks.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            CustomNumericUpDownPDpiBeforeSniChunks.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownPDpiBeforeSniChunks.Name = "CustomNumericUpDownPDpiBeforeSniChunks";
            CustomNumericUpDownPDpiBeforeSniChunks.RoundedCorners = 5;
            CustomNumericUpDownPDpiBeforeSniChunks.Size = new Size(44, 23);
            CustomNumericUpDownPDpiBeforeSniChunks.TabIndex = 143;
            CustomNumericUpDownPDpiBeforeSniChunks.Value = new decimal(new int[] { 50, 0, 0, 0 });
            CustomNumericUpDownPDpiBeforeSniChunks.ValueChanged += CustomNumericUpDownPDpiFragment_ValueChanged;
            // 
            // CustomComboBoxPDpiSniChunkMode
            // 
            CustomComboBoxPDpiSniChunkMode.BackColor = Color.DimGray;
            CustomComboBoxPDpiSniChunkMode.BorderColor = Color.Blue;
            CustomComboBoxPDpiSniChunkMode.DrawMode = DrawMode.OwnerDrawVariable;
            CustomComboBoxPDpiSniChunkMode.ForeColor = Color.White;
            CustomComboBoxPDpiSniChunkMode.FormattingEnabled = true;
            CustomComboBoxPDpiSniChunkMode.ItemHeight = 17;
            CustomComboBoxPDpiSniChunkMode.Items.AddRange(new object[] { "SNI", "SNI Extension", "All Extensions" });
            CustomComboBoxPDpiSniChunkMode.Location = new Point(164, 36);
            CustomComboBoxPDpiSniChunkMode.Name = "CustomComboBoxPDpiSniChunkMode";
            CustomComboBoxPDpiSniChunkMode.RoundedCorners = 5;
            CustomComboBoxPDpiSniChunkMode.SelectionColor = Color.DodgerBlue;
            CustomComboBoxPDpiSniChunkMode.Size = new Size(110, 23);
            CustomComboBoxPDpiSniChunkMode.TabIndex = 140;
            CustomComboBoxPDpiSniChunkMode.SelectedIndexChanged += CustomComboBoxPDpiSniChunkMode_SelectedIndexChanged;
            // 
            // CustomLabelPDpiSniChunks
            // 
            CustomLabelPDpiSniChunks.AutoSize = true;
            CustomLabelPDpiSniChunks.BackColor = Color.DimGray;
            CustomLabelPDpiSniChunks.Border = false;
            CustomLabelPDpiSniChunks.BorderColor = Color.Blue;
            CustomLabelPDpiSniChunks.FlatStyle = FlatStyle.Flat;
            CustomLabelPDpiSniChunks.ForeColor = Color.White;
            CustomLabelPDpiSniChunks.Location = new Point(22, 67);
            CustomLabelPDpiSniChunks.Margin = new Padding(3);
            CustomLabelPDpiSniChunks.Name = "CustomLabelPDpiSniChunks";
            CustomLabelPDpiSniChunks.RoundedCorners = 0;
            CustomLabelPDpiSniChunks.Size = new Size(73, 17);
            CustomLabelPDpiSniChunks.TabIndex = 134;
            CustomLabelPDpiSniChunks.Text = "Chunks SNI:";
            CustomLabelPDpiSniChunks.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomLabelPDpiAntiPatternOffset
            // 
            CustomLabelPDpiAntiPatternOffset.AutoSize = true;
            CustomLabelPDpiAntiPatternOffset.BackColor = Color.DimGray;
            CustomLabelPDpiAntiPatternOffset.Border = false;
            CustomLabelPDpiAntiPatternOffset.BorderColor = Color.Blue;
            CustomLabelPDpiAntiPatternOffset.FlatStyle = FlatStyle.Flat;
            CustomLabelPDpiAntiPatternOffset.ForeColor = Color.White;
            CustomLabelPDpiAntiPatternOffset.Location = new Point(22, 96);
            CustomLabelPDpiAntiPatternOffset.Margin = new Padding(3);
            CustomLabelPDpiAntiPatternOffset.Name = "CustomLabelPDpiAntiPatternOffset";
            CustomLabelPDpiAntiPatternOffset.RoundedCorners = 0;
            CustomLabelPDpiAntiPatternOffset.Size = new Size(106, 15);
            CustomLabelPDpiAntiPatternOffset.TabIndex = 138;
            CustomLabelPDpiAntiPatternOffset.Text = "Anti pattern offset:";
            CustomLabelPDpiAntiPatternOffset.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TabPageShareSslDecryption
            // 
            TabPageShareSslDecryption.AutoScroll = true;
            TabPageShareSslDecryption.BackColor = Color.Transparent;
            TabPageShareSslDecryption.Controls.Add(CustomCheckBoxProxySSLChangeSni);
            TabPageShareSslDecryption.Controls.Add(CustomLabelProxySSLChangeSniInfo);
            TabPageShareSslDecryption.Controls.Add(CustomTextBoxProxySSLDefaultSni);
            TabPageShareSslDecryption.Controls.Add(CustomLabelProxySSLDefaultSni);
            TabPageShareSslDecryption.Location = new Point(4, 25);
            TabPageShareSslDecryption.Name = "TabPageShareSslDecryption";
            TabPageShareSslDecryption.Padding = new Padding(3);
            TabPageShareSslDecryption.Size = new Size(539, 94);
            TabPageShareSslDecryption.TabIndex = 1;
            TabPageShareSslDecryption.Tag = 1;
            TabPageShareSslDecryption.Text = "SSL Decryption Options";
            TabPageShareSslDecryption.Visible = false;
            // 
            // CustomCheckBoxProxySSLChangeSni
            // 
            CustomCheckBoxProxySSLChangeSni.BackColor = Color.DimGray;
            CustomCheckBoxProxySSLChangeSni.BorderColor = Color.Blue;
            CustomCheckBoxProxySSLChangeSni.CheckColor = Color.Blue;
            CustomCheckBoxProxySSLChangeSni.ForeColor = Color.White;
            CustomCheckBoxProxySSLChangeSni.Location = new Point(16, 16);
            CustomCheckBoxProxySSLChangeSni.Name = "CustomCheckBoxProxySSLChangeSni";
            CustomCheckBoxProxySSLChangeSni.SelectionColor = Color.LightBlue;
            CustomCheckBoxProxySSLChangeSni.Size = new Size(82, 17);
            CustomCheckBoxProxySSLChangeSni.TabIndex = 149;
            CustomCheckBoxProxySSLChangeSni.Text = "Change SNI";
            CustomCheckBoxProxySSLChangeSni.UseVisualStyleBackColor = false;
            CustomCheckBoxProxySSLChangeSni.CheckedChanged += CustomCheckBoxProxySSLChangeSni_CheckedChanged;
            // 
            // CustomLabelProxySSLChangeSniInfo
            // 
            CustomLabelProxySSLChangeSniInfo.AutoSize = true;
            CustomLabelProxySSLChangeSniInfo.BackColor = Color.DimGray;
            CustomLabelProxySSLChangeSniInfo.Border = false;
            CustomLabelProxySSLChangeSniInfo.BorderColor = Color.Blue;
            CustomLabelProxySSLChangeSniInfo.FlatStyle = FlatStyle.Flat;
            CustomLabelProxySSLChangeSniInfo.ForeColor = Color.White;
            CustomLabelProxySSLChangeSniInfo.Location = new Point(29, 39);
            CustomLabelProxySSLChangeSniInfo.Margin = new Padding(3);
            CustomLabelProxySSLChangeSniInfo.Name = "CustomLabelProxySSLChangeSniInfo";
            CustomLabelProxySSLChangeSniInfo.RoundedCorners = 0;
            CustomLabelProxySSLChangeSniInfo.Size = new Size(301, 60);
            CustomLabelProxySSLChangeSniInfo.TabIndex = 150;
            CustomLabelProxySSLChangeSniInfo.Text = "Some websites may break when this option is enabled.\r\n - You can use \"Proxy Rules\" to exclude them,\r\n - Or set a custom SNI per domain.\r\n - You can leave \"Default SNI\" empty to use original SNI.";
            // 
            // CustomTextBoxProxySSLDefaultSni
            // 
            CustomTextBoxProxySSLDefaultSni.AcceptsReturn = false;
            CustomTextBoxProxySSLDefaultSni.AcceptsTab = false;
            CustomTextBoxProxySSLDefaultSni.BackColor = Color.DimGray;
            CustomTextBoxProxySSLDefaultSni.Border = true;
            CustomTextBoxProxySSLDefaultSni.BorderColor = Color.Blue;
            CustomTextBoxProxySSLDefaultSni.BorderSize = 1;
            CustomTextBoxProxySSLDefaultSni.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxProxySSLDefaultSni.Font = new Font("Segoe UI", 9F);
            CustomTextBoxProxySSLDefaultSni.ForeColor = Color.White;
            CustomTextBoxProxySSLDefaultSni.HideSelection = true;
            CustomTextBoxProxySSLDefaultSni.Location = new Point(93, 104);
            CustomTextBoxProxySSLDefaultSni.MaxLength = 32767;
            CustomTextBoxProxySSLDefaultSni.Multiline = false;
            CustomTextBoxProxySSLDefaultSni.Name = "CustomTextBoxProxySSLDefaultSni";
            CustomTextBoxProxySSLDefaultSni.ReadOnly = false;
            CustomTextBoxProxySSLDefaultSni.RoundedCorners = 0;
            CustomTextBoxProxySSLDefaultSni.ScrollBars = ScrollBars.None;
            CustomTextBoxProxySSLDefaultSni.ShortcutsEnabled = true;
            CustomTextBoxProxySSLDefaultSni.Size = new Size(168, 23);
            CustomTextBoxProxySSLDefaultSni.TabIndex = 0;
            CustomTextBoxProxySSLDefaultSni.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxProxySSLDefaultSni.Texts = "speedtest.net";
            CustomTextBoxProxySSLDefaultSni.UnderlinedStyle = true;
            CustomTextBoxProxySSLDefaultSni.UsePasswordChar = false;
            CustomTextBoxProxySSLDefaultSni.WordWrap = true;
            CustomTextBoxProxySSLDefaultSni.KeyUp += CustomTextBoxProxySSLDefaultSni_KeyUp;
            // 
            // CustomLabelProxySSLDefaultSni
            // 
            CustomLabelProxySSLDefaultSni.AutoSize = true;
            CustomLabelProxySSLDefaultSni.BackColor = Color.DimGray;
            CustomLabelProxySSLDefaultSni.Border = false;
            CustomLabelProxySSLDefaultSni.BorderColor = Color.Blue;
            CustomLabelProxySSLDefaultSni.FlatStyle = FlatStyle.Flat;
            CustomLabelProxySSLDefaultSni.ForeColor = Color.White;
            CustomLabelProxySSLDefaultSni.Location = new Point(16, 108);
            CustomLabelProxySSLDefaultSni.Margin = new Padding(3);
            CustomLabelProxySSLDefaultSni.Name = "CustomLabelProxySSLDefaultSni";
            CustomLabelProxySSLDefaultSni.RoundedCorners = 0;
            CustomLabelProxySSLDefaultSni.Size = new Size(69, 15);
            CustomLabelProxySSLDefaultSni.TabIndex = 152;
            CustomLabelProxySSLDefaultSni.Text = "Default SNI:";
            // 
            // CustomGroupBoxShareRulesStatus
            // 
            CustomGroupBoxShareRulesStatus.BorderColor = Color.Blue;
            CustomGroupBoxShareRulesStatus.Controls.Add(SplitContainerShareRulesStatus1);
            CustomGroupBoxShareRulesStatus.Dock = DockStyle.Fill;
            CustomGroupBoxShareRulesStatus.Location = new Point(0, 0);
            CustomGroupBoxShareRulesStatus.Name = "CustomGroupBoxShareRulesStatus";
            CustomGroupBoxShareRulesStatus.RoundedCorners = 5;
            CustomGroupBoxShareRulesStatus.Size = new Size(200, 275);
            CustomGroupBoxShareRulesStatus.TabIndex = 0;
            CustomGroupBoxShareRulesStatus.TabStop = false;
            CustomGroupBoxShareRulesStatus.Text = "Rules Status";
            // 
            // SplitContainerShareRulesStatus1
            // 
            SplitContainerShareRulesStatus1.Dock = DockStyle.Fill;
            SplitContainerShareRulesStatus1.FixedPanel = FixedPanel.Panel1;
            SplitContainerShareRulesStatus1.IsSplitterFixed = true;
            SplitContainerShareRulesStatus1.Location = new Point(3, 19);
            SplitContainerShareRulesStatus1.Name = "SplitContainerShareRulesStatus1";
            SplitContainerShareRulesStatus1.Orientation = Orientation.Horizontal;
            // 
            // SplitContainerShareRulesStatus1.Panel1
            // 
            SplitContainerShareRulesStatus1.Panel1.Controls.Add(CustomTextBoxShareRulesStatusDomain);
            SplitContainerShareRulesStatus1.Panel1.Controls.Add(CustomLabelShareRulesStatus);
            // 
            // SplitContainerShareRulesStatus1.Panel2
            // 
            SplitContainerShareRulesStatus1.Panel2.Controls.Add(SplitContainerShareRulesStatus2);
            SplitContainerShareRulesStatus1.Size = new Size(194, 253);
            SplitContainerShareRulesStatus1.SplitterDistance = 54;
            SplitContainerShareRulesStatus1.TabIndex = 0;
            // 
            // CustomTextBoxShareRulesStatusDomain
            // 
            CustomTextBoxShareRulesStatusDomain.AcceptsReturn = false;
            CustomTextBoxShareRulesStatusDomain.AcceptsTab = false;
            CustomTextBoxShareRulesStatusDomain.BackColor = Color.DimGray;
            CustomTextBoxShareRulesStatusDomain.Border = true;
            CustomTextBoxShareRulesStatusDomain.BorderColor = Color.Blue;
            CustomTextBoxShareRulesStatusDomain.BorderSize = 1;
            CustomTextBoxShareRulesStatusDomain.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxShareRulesStatusDomain.Font = new Font("Segoe UI", 9F);
            CustomTextBoxShareRulesStatusDomain.ForeColor = Color.White;
            CustomTextBoxShareRulesStatusDomain.HideSelection = true;
            CustomTextBoxShareRulesStatusDomain.Location = new Point(6, 22);
            CustomTextBoxShareRulesStatusDomain.MaxLength = 32767;
            CustomTextBoxShareRulesStatusDomain.Multiline = false;
            CustomTextBoxShareRulesStatusDomain.Name = "CustomTextBoxShareRulesStatusDomain";
            CustomTextBoxShareRulesStatusDomain.ReadOnly = false;
            CustomTextBoxShareRulesStatusDomain.RoundedCorners = 0;
            CustomTextBoxShareRulesStatusDomain.ScrollBars = ScrollBars.None;
            CustomTextBoxShareRulesStatusDomain.ShortcutsEnabled = true;
            CustomTextBoxShareRulesStatusDomain.Size = new Size(145, 23);
            CustomTextBoxShareRulesStatusDomain.TabIndex = 0;
            CustomTextBoxShareRulesStatusDomain.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxShareRulesStatusDomain.Texts = "";
            CustomTextBoxShareRulesStatusDomain.UnderlinedStyle = true;
            CustomTextBoxShareRulesStatusDomain.UsePasswordChar = false;
            CustomTextBoxShareRulesStatusDomain.WordWrap = true;
            // 
            // CustomLabelShareRulesStatus
            // 
            CustomLabelShareRulesStatus.AutoSize = true;
            CustomLabelShareRulesStatus.BackColor = Color.DimGray;
            CustomLabelShareRulesStatus.Border = false;
            CustomLabelShareRulesStatus.BorderColor = Color.Blue;
            CustomLabelShareRulesStatus.FlatStyle = FlatStyle.Flat;
            CustomLabelShareRulesStatus.ForeColor = Color.White;
            CustomLabelShareRulesStatus.Location = new Point(4, 2);
            CustomLabelShareRulesStatus.Name = "CustomLabelShareRulesStatus";
            CustomLabelShareRulesStatus.RoundedCorners = 0;
            CustomLabelShareRulesStatus.Size = new Size(147, 17);
            CustomLabelShareRulesStatus.TabIndex = 0;
            CustomLabelShareRulesStatus.Text = "Check Rules for a domain:";
            // 
            // SplitContainerShareRulesStatus2
            // 
            SplitContainerShareRulesStatus2.Dock = DockStyle.Fill;
            SplitContainerShareRulesStatus2.FixedPanel = FixedPanel.Panel2;
            SplitContainerShareRulesStatus2.IsSplitterFixed = true;
            SplitContainerShareRulesStatus2.Location = new Point(0, 0);
            SplitContainerShareRulesStatus2.Name = "SplitContainerShareRulesStatus2";
            SplitContainerShareRulesStatus2.Orientation = Orientation.Horizontal;
            // 
            // SplitContainerShareRulesStatus2.Panel1
            // 
            SplitContainerShareRulesStatus2.Panel1.Controls.Add(CustomRichTextBoxShareRulesStatusResult);
            // 
            // SplitContainerShareRulesStatus2.Panel2
            // 
            SplitContainerShareRulesStatus2.Panel2.Controls.Add(CustomButtonShareRulesStatusRead);
            SplitContainerShareRulesStatus2.Size = new Size(194, 195);
            SplitContainerShareRulesStatus2.SplitterDistance = 138;
            SplitContainerShareRulesStatus2.TabIndex = 0;
            // 
            // CustomRichTextBoxShareRulesStatusResult
            // 
            CustomRichTextBoxShareRulesStatusResult.AcceptsTab = false;
            CustomRichTextBoxShareRulesStatusResult.AutoWordSelection = false;
            CustomRichTextBoxShareRulesStatusResult.BackColor = Color.DimGray;
            CustomRichTextBoxShareRulesStatusResult.Border = false;
            CustomRichTextBoxShareRulesStatusResult.BorderColor = Color.Blue;
            CustomRichTextBoxShareRulesStatusResult.BorderSize = 1;
            CustomRichTextBoxShareRulesStatusResult.BulletIndent = 0;
            CustomRichTextBoxShareRulesStatusResult.DetectUrls = false;
            CustomRichTextBoxShareRulesStatusResult.Dock = DockStyle.Fill;
            CustomRichTextBoxShareRulesStatusResult.EnableAutoDragDrop = false;
            CustomRichTextBoxShareRulesStatusResult.Font = new Font("Segoe UI", 9F);
            CustomRichTextBoxShareRulesStatusResult.ForeColor = Color.White;
            CustomRichTextBoxShareRulesStatusResult.HideSelection = false;
            CustomRichTextBoxShareRulesStatusResult.Location = new Point(0, 0);
            CustomRichTextBoxShareRulesStatusResult.MaxLength = int.MaxValue;
            CustomRichTextBoxShareRulesStatusResult.MinimumSize = new Size(0, 23);
            CustomRichTextBoxShareRulesStatusResult.Multiline = true;
            CustomRichTextBoxShareRulesStatusResult.Name = "CustomRichTextBoxShareRulesStatusResult";
            CustomRichTextBoxShareRulesStatusResult.ReadOnly = true;
            CustomRichTextBoxShareRulesStatusResult.RightMargin = 0;
            CustomRichTextBoxShareRulesStatusResult.RoundedCorners = 0;
            CustomRichTextBoxShareRulesStatusResult.ScrollBars = ScrollBars.Both;
            CustomRichTextBoxShareRulesStatusResult.ScrollToBottom = false;
            CustomRichTextBoxShareRulesStatusResult.SelectionColor = Color.White;
            CustomRichTextBoxShareRulesStatusResult.SelectionLength = 0;
            CustomRichTextBoxShareRulesStatusResult.SelectionStart = 0;
            CustomRichTextBoxShareRulesStatusResult.ShortcutsEnabled = true;
            CustomRichTextBoxShareRulesStatusResult.Size = new Size(194, 138);
            CustomRichTextBoxShareRulesStatusResult.TabIndex = 0;
            CustomRichTextBoxShareRulesStatusResult.Texts = "";
            CustomRichTextBoxShareRulesStatusResult.UnderlinedStyle = false;
            CustomRichTextBoxShareRulesStatusResult.WordWrap = true;
            CustomRichTextBoxShareRulesStatusResult.ZoomFactor = 1F;
            // 
            // CustomButtonShareRulesStatusRead
            // 
            CustomButtonShareRulesStatusRead.BorderColor = Color.Blue;
            CustomButtonShareRulesStatusRead.FlatStyle = FlatStyle.Flat;
            CustomButtonShareRulesStatusRead.Location = new Point(6, 3);
            CustomButtonShareRulesStatusRead.Name = "CustomButtonShareRulesStatusRead";
            CustomButtonShareRulesStatusRead.RoundedCorners = 5;
            CustomButtonShareRulesStatusRead.SelectionColor = Color.LightBlue;
            CustomButtonShareRulesStatusRead.Size = new Size(97, 27);
            CustomButtonShareRulesStatusRead.TabIndex = 0;
            CustomButtonShareRulesStatusRead.Text = "Read";
            CustomButtonShareRulesStatusRead.UseVisualStyleBackColor = true;
            CustomButtonShareRulesStatusRead.Click += CustomButtonShareRulesStatusRead_Click;
            // 
            // CustomButtonPDpiCheck
            // 
            CustomButtonPDpiCheck.BorderColor = Color.Blue;
            CustomButtonPDpiCheck.FlatStyle = FlatStyle.Flat;
            CustomButtonPDpiCheck.Location = new Point(403, 3);
            CustomButtonPDpiCheck.Name = "CustomButtonPDpiCheck";
            CustomButtonPDpiCheck.RoundedCorners = 5;
            CustomButtonPDpiCheck.SelectionColor = Color.LightBlue;
            CustomButtonPDpiCheck.Size = new Size(110, 27);
            CustomButtonPDpiCheck.TabIndex = 78;
            CustomButtonPDpiCheck.Text = "Check DPI Bypass";
            CustomButtonPDpiCheck.UseVisualStyleBackColor = true;
            CustomButtonPDpiCheck.Click += CustomButtonPDpiCheck_Click;
            // 
            // CustomButtonPDpiApplyChanges
            // 
            CustomButtonPDpiApplyChanges.BorderColor = Color.Blue;
            CustomButtonPDpiApplyChanges.FlatStyle = FlatStyle.Flat;
            CustomButtonPDpiApplyChanges.Location = new Point(217, 3);
            CustomButtonPDpiApplyChanges.Name = "CustomButtonPDpiApplyChanges";
            CustomButtonPDpiApplyChanges.RoundedCorners = 5;
            CustomButtonPDpiApplyChanges.SelectionColor = Color.LightBlue;
            CustomButtonPDpiApplyChanges.Size = new Size(157, 27);
            CustomButtonPDpiApplyChanges.TabIndex = 68;
            CustomButtonPDpiApplyChanges.Text = "Apply DPI Bypass Changes";
            CustomButtonPDpiApplyChanges.UseVisualStyleBackColor = true;
            CustomButtonPDpiApplyChanges.Click += CustomButtonPDpiApplyChanges_Click;
            // 
            // CustomButtonSetProxy
            // 
            CustomButtonSetProxy.BorderColor = Color.Blue;
            CustomButtonSetProxy.FlatStyle = FlatStyle.Flat;
            CustomButtonSetProxy.Location = new Point(99, 3);
            CustomButtonSetProxy.Name = "CustomButtonSetProxy";
            CustomButtonSetProxy.RoundedCorners = 5;
            CustomButtonSetProxy.SelectionColor = Color.LightBlue;
            CustomButtonSetProxy.Size = new Size(82, 27);
            CustomButtonSetProxy.TabIndex = 65;
            CustomButtonSetProxy.Text = "Unset Proxy";
            CustomButtonSetProxy.UseVisualStyleBackColor = true;
            CustomButtonSetProxy.Click += CustomButtonSetProxy_Click;
            // 
            // CustomButtonShare
            // 
            CustomButtonShare.BorderColor = Color.Blue;
            CustomButtonShare.FlatStyle = FlatStyle.Flat;
            CustomButtonShare.Location = new Point(3, 3);
            CustomButtonShare.Name = "CustomButtonShare";
            CustomButtonShare.RoundedCorners = 5;
            CustomButtonShare.SelectionColor = Color.LightBlue;
            CustomButtonShare.Size = new Size(76, 27);
            CustomButtonShare.TabIndex = 60;
            CustomButtonShare.Text = "Start Proxy";
            CustomButtonShare.UseVisualStyleBackColor = true;
            CustomButtonShare.Click += CustomButtonShare_Click;
            // 
            // CustomRichTextBoxLog
            // 
            CustomRichTextBoxLog.AcceptsTab = false;
            CustomRichTextBoxLog.AutoWordSelection = false;
            CustomRichTextBoxLog.BackColor = Color.DimGray;
            CustomRichTextBoxLog.Border = false;
            CustomRichTextBoxLog.BorderColor = Color.Blue;
            CustomRichTextBoxLog.BorderSize = 1;
            CustomRichTextBoxLog.BulletIndent = 0;
            CustomRichTextBoxLog.Cursor = Cursors.IBeam;
            CustomRichTextBoxLog.DetectUrls = false;
            CustomRichTextBoxLog.Dock = DockStyle.Fill;
            CustomRichTextBoxLog.EnableAutoDragDrop = false;
            CustomRichTextBoxLog.Font = new Font("Segoe UI", 9F);
            CustomRichTextBoxLog.ForeColor = Color.White;
            CustomRichTextBoxLog.HideSelection = false;
            CustomRichTextBoxLog.Location = new Point(3, 19);
            CustomRichTextBoxLog.Margin = new Padding(1);
            CustomRichTextBoxLog.MaxLength = int.MaxValue;
            CustomRichTextBoxLog.MinimumSize = new Size(0, 23);
            CustomRichTextBoxLog.Multiline = true;
            CustomRichTextBoxLog.Name = "CustomRichTextBoxLog";
            CustomRichTextBoxLog.ReadOnly = true;
            CustomRichTextBoxLog.RightMargin = 0;
            CustomRichTextBoxLog.RoundedCorners = 0;
            CustomRichTextBoxLog.ScrollBars = ScrollBars.Both;
            CustomRichTextBoxLog.ScrollToBottom = true;
            CustomRichTextBoxLog.SelectionColor = Color.White;
            CustomRichTextBoxLog.SelectionLength = 0;
            CustomRichTextBoxLog.SelectionStart = 0;
            CustomRichTextBoxLog.ShortcutsEnabled = true;
            CustomRichTextBoxLog.Size = new Size(978, 155);
            CustomRichTextBoxLog.TabIndex = 0;
            CustomRichTextBoxLog.Texts = "";
            CustomRichTextBoxLog.UnderlinedStyle = false;
            CustomRichTextBoxLog.WordWrap = true;
            CustomRichTextBoxLog.ZoomFactor = 1F;
            CustomRichTextBoxLog.SizeChanged += CustomRichTextBoxLog_SizeChanged;
            // 
            // CustomButtonCheck
            // 
            CustomButtonCheck.BorderColor = Color.Blue;
            CustomButtonCheck.FlatStyle = FlatStyle.Flat;
            CustomButtonCheck.Location = new Point(110, 2);
            CustomButtonCheck.Name = "CustomButtonCheck";
            CustomButtonCheck.RoundedCorners = 5;
            CustomButtonCheck.SelectionColor = Color.LightBlue;
            CustomButtonCheck.Size = new Size(76, 27);
            CustomButtonCheck.TabIndex = 2;
            CustomButtonCheck.Text = "Stopping...";
            CustomButtonCheck.UseVisualStyleBackColor = true;
            CustomButtonCheck.MouseUp += CustomButtonCheck_MouseUp;
            // 
            // CustomGroupBoxLog
            // 
            CustomGroupBoxLog.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CustomGroupBoxLog.BorderColor = Color.Blue;
            CustomGroupBoxLog.Controls.Add(CustomRichTextBoxLog);
            CustomGroupBoxLog.Dock = DockStyle.Fill;
            CustomGroupBoxLog.Location = new Point(0, 0);
            CustomGroupBoxLog.Margin = new Padding(1);
            CustomGroupBoxLog.Name = "CustomGroupBoxLog";
            CustomGroupBoxLog.RoundedCorners = 5;
            CustomGroupBoxLog.Size = new Size(984, 177);
            CustomGroupBoxLog.TabIndex = 3;
            CustomGroupBoxLog.TabStop = false;
            CustomGroupBoxLog.Text = "Log";
            // 
            // CustomCheckBoxInsecure
            // 
            CustomCheckBoxInsecure.BackColor = Color.DimGray;
            CustomCheckBoxInsecure.BorderColor = Color.Blue;
            CustomCheckBoxInsecure.CheckColor = Color.Blue;
            CustomCheckBoxInsecure.ForeColor = Color.White;
            CustomCheckBoxInsecure.Location = new Point(7, 227);
            CustomCheckBoxInsecure.Name = "CustomCheckBoxInsecure";
            CustomCheckBoxInsecure.SelectionColor = Color.LightBlue;
            CustomCheckBoxInsecure.Size = new Size(210, 17);
            CustomCheckBoxInsecure.TabIndex = 7;
            CustomCheckBoxInsecure.Text = "Allow insecure (not recommended)";
            CustomCheckBoxInsecure.UseVisualStyleBackColor = false;
            CustomCheckBoxInsecure.CheckedChanged += SecureDNSClient_CheckedChanged;
            // 
            // CustomLabelCustomServersInfo
            // 
            CustomLabelCustomServersInfo.AutoSize = true;
            CustomLabelCustomServersInfo.BackColor = Color.DimGray;
            CustomLabelCustomServersInfo.Border = false;
            CustomLabelCustomServersInfo.BorderColor = Color.Blue;
            CustomLabelCustomServersInfo.FlatStyle = FlatStyle.Flat;
            CustomLabelCustomServersInfo.ForeColor = Color.White;
            CustomLabelCustomServersInfo.Location = new Point(23, 60);
            CustomLabelCustomServersInfo.Name = "CustomLabelCustomServersInfo";
            CustomLabelCustomServersInfo.RoundedCorners = 0;
            CustomLabelCustomServersInfo.Size = new Size(306, 122);
            CustomLabelCustomServersInfo.TabIndex = 6;
            CustomLabelCustomServersInfo.Text = "Supported:\r\nAnonymized DNSCrypt, DNSCrypt, DoH, DoT, UDP, TCP.\r\ne.g:\r\n  https://cloudflare-dns.com/dns-query\r\n  tls://dns.google\r\n  sdns://\r\n  udp://8.8.8.8\r\n  tcp://1.1.1.1:53";
            // 
            // CustomButtonEditCustomServers
            // 
            CustomButtonEditCustomServers.BorderColor = Color.Blue;
            CustomButtonEditCustomServers.FlatStyle = FlatStyle.Flat;
            CustomButtonEditCustomServers.Location = new Point(3, 2);
            CustomButtonEditCustomServers.Name = "CustomButtonEditCustomServers";
            CustomButtonEditCustomServers.RoundedCorners = 5;
            CustomButtonEditCustomServers.SelectionColor = Color.LightBlue;
            CustomButtonEditCustomServers.Size = new Size(101, 27);
            CustomButtonEditCustomServers.TabIndex = 5;
            CustomButtonEditCustomServers.Text = "Custom Servers";
            CustomButtonEditCustomServers.UseVisualStyleBackColor = true;
            CustomButtonEditCustomServers.MouseUp += CustomButtonEditCustomServers_MouseUp;
            // 
            // CustomRadioButtonCustom
            // 
            CustomRadioButtonCustom.BackColor = Color.DimGray;
            CustomRadioButtonCustom.BorderColor = Color.Blue;
            CustomRadioButtonCustom.CheckColor = Color.Blue;
            CustomRadioButtonCustom.ForeColor = Color.White;
            CustomRadioButtonCustom.Location = new Point(7, 35);
            CustomRadioButtonCustom.Name = "CustomRadioButtonCustom";
            CustomRadioButtonCustom.SelectionColor = Color.LightBlue;
            CustomRadioButtonCustom.Size = new Size(129, 17);
            CustomRadioButtonCustom.TabIndex = 4;
            CustomRadioButtonCustom.Text = "Use custom servers";
            CustomRadioButtonCustom.UseVisualStyleBackColor = false;
            CustomRadioButtonCustom.CheckedChanged += SecureDNSClient_CheckedChanged;
            // 
            // CustomRadioButtonBuiltIn
            // 
            CustomRadioButtonBuiltIn.BackColor = Color.DimGray;
            CustomRadioButtonBuiltIn.BorderColor = Color.Blue;
            CustomRadioButtonBuiltIn.CheckColor = Color.Blue;
            CustomRadioButtonBuiltIn.ForeColor = Color.White;
            CustomRadioButtonBuiltIn.Location = new Point(7, 5);
            CustomRadioButtonBuiltIn.Name = "CustomRadioButtonBuiltIn";
            CustomRadioButtonBuiltIn.SelectionColor = Color.LightBlue;
            CustomRadioButtonBuiltIn.Size = new Size(128, 17);
            CustomRadioButtonBuiltIn.TabIndex = 3;
            CustomRadioButtonBuiltIn.Text = "Use built-in servers";
            CustomRadioButtonBuiltIn.UseVisualStyleBackColor = false;
            CustomRadioButtonBuiltIn.CheckedChanged += SecureDNSClient_CheckedChanged;
            // 
            // CustomLabelSSLFragmentSize
            // 
            CustomLabelSSLFragmentSize.AutoSize = true;
            CustomLabelSSLFragmentSize.BackColor = Color.DimGray;
            CustomLabelSSLFragmentSize.Border = false;
            CustomLabelSSLFragmentSize.BorderColor = Color.Blue;
            CustomLabelSSLFragmentSize.FlatStyle = FlatStyle.Flat;
            CustomLabelSSLFragmentSize.ForeColor = Color.White;
            CustomLabelSSLFragmentSize.Location = new Point(282, 88);
            CustomLabelSSLFragmentSize.Name = "CustomLabelSSLFragmentSize";
            CustomLabelSSLFragmentSize.RoundedCorners = 0;
            CustomLabelSSLFragmentSize.Size = new Size(102, 15);
            CustomLabelSSLFragmentSize.TabIndex = 10;
            CustomLabelSSLFragmentSize.Text = "SSL fragment size:";
            // 
            // CustomNumericUpDownSSLFragmentSize
            // 
            CustomNumericUpDownSSLFragmentSize.BackColor = Color.DimGray;
            CustomNumericUpDownSSLFragmentSize.BorderColor = Color.Blue;
            CustomNumericUpDownSSLFragmentSize.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownSSLFragmentSize.Location = new Point(390, 86);
            CustomNumericUpDownSSLFragmentSize.Margin = new Padding(1);
            CustomNumericUpDownSSLFragmentSize.Maximum = new decimal(new int[] { 70000, 0, 0, 0 });
            CustomNumericUpDownSSLFragmentSize.Name = "CustomNumericUpDownSSLFragmentSize";
            CustomNumericUpDownSSLFragmentSize.RoundedCorners = 5;
            CustomNumericUpDownSSLFragmentSize.Size = new Size(53, 23);
            CustomNumericUpDownSSLFragmentSize.TabIndex = 9;
            CustomNumericUpDownSSLFragmentSize.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // CustomTextBoxHTTPProxy
            // 
            CustomTextBoxHTTPProxy.AcceptsReturn = false;
            CustomTextBoxHTTPProxy.AcceptsTab = false;
            CustomTextBoxHTTPProxy.BackColor = Color.DimGray;
            CustomTextBoxHTTPProxy.Border = true;
            CustomTextBoxHTTPProxy.BorderColor = Color.Blue;
            CustomTextBoxHTTPProxy.BorderSize = 1;
            CustomTextBoxHTTPProxy.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxHTTPProxy.Enabled = false;
            CustomTextBoxHTTPProxy.Font = new Font("Segoe UI", 9F);
            CustomTextBoxHTTPProxy.ForeColor = Color.White;
            CustomTextBoxHTTPProxy.HideSelection = true;
            CustomTextBoxHTTPProxy.Location = new Point(20, 211);
            CustomTextBoxHTTPProxy.Margin = new Padding(1);
            CustomTextBoxHTTPProxy.MaxLength = 32767;
            CustomTextBoxHTTPProxy.Multiline = false;
            CustomTextBoxHTTPProxy.Name = "CustomTextBoxHTTPProxy";
            CustomTextBoxHTTPProxy.ReadOnly = false;
            CustomTextBoxHTTPProxy.RoundedCorners = 0;
            CustomTextBoxHTTPProxy.ScrollBars = ScrollBars.None;
            CustomTextBoxHTTPProxy.ShortcutsEnabled = true;
            CustomTextBoxHTTPProxy.Size = new Size(205, 23);
            CustomTextBoxHTTPProxy.TabIndex = 0;
            CustomTextBoxHTTPProxy.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxHTTPProxy.Texts = "";
            CustomTextBoxHTTPProxy.UnderlinedStyle = true;
            CustomTextBoxHTTPProxy.UsePasswordChar = false;
            CustomTextBoxHTTPProxy.WordWrap = true;
            // 
            // CustomRadioButtonDPIModeExtreme
            // 
            CustomRadioButtonDPIModeExtreme.BackColor = Color.DimGray;
            CustomRadioButtonDPIModeExtreme.BorderColor = Color.Blue;
            CustomRadioButtonDPIModeExtreme.CheckColor = Color.Blue;
            CustomRadioButtonDPIModeExtreme.ForeColor = Color.White;
            CustomRadioButtonDPIModeExtreme.Location = new Point(182, 88);
            CustomRadioButtonDPIModeExtreme.Margin = new Padding(1);
            CustomRadioButtonDPIModeExtreme.Name = "CustomRadioButtonDPIModeExtreme";
            CustomRadioButtonDPIModeExtreme.SelectionColor = Color.LightBlue;
            CustomRadioButtonDPIModeExtreme.Size = new Size(68, 17);
            CustomRadioButtonDPIModeExtreme.TabIndex = 7;
            CustomRadioButtonDPIModeExtreme.Text = "Extreme";
            CustomRadioButtonDPIModeExtreme.UseVisualStyleBackColor = false;
            CustomRadioButtonDPIModeExtreme.CheckedChanged += SecureDNSClient_CheckedChanged;
            // 
            // CustomRadioButtonDPIModeHigh
            // 
            CustomRadioButtonDPIModeHigh.BackColor = Color.DimGray;
            CustomRadioButtonDPIModeHigh.BorderColor = Color.Blue;
            CustomRadioButtonDPIModeHigh.CheckColor = Color.Blue;
            CustomRadioButtonDPIModeHigh.ForeColor = Color.White;
            CustomRadioButtonDPIModeHigh.Location = new Point(133, 88);
            CustomRadioButtonDPIModeHigh.Margin = new Padding(1);
            CustomRadioButtonDPIModeHigh.Name = "CustomRadioButtonDPIModeHigh";
            CustomRadioButtonDPIModeHigh.SelectionColor = Color.LightBlue;
            CustomRadioButtonDPIModeHigh.Size = new Size(50, 17);
            CustomRadioButtonDPIModeHigh.TabIndex = 6;
            CustomRadioButtonDPIModeHigh.Text = "High";
            CustomRadioButtonDPIModeHigh.UseVisualStyleBackColor = false;
            CustomRadioButtonDPIModeHigh.CheckedChanged += SecureDNSClient_CheckedChanged;
            // 
            // CustomRadioButtonDPIModeMedium
            // 
            CustomRadioButtonDPIModeMedium.BackColor = Color.DimGray;
            CustomRadioButtonDPIModeMedium.BorderColor = Color.Blue;
            CustomRadioButtonDPIModeMedium.CheckColor = Color.Blue;
            CustomRadioButtonDPIModeMedium.ForeColor = Color.White;
            CustomRadioButtonDPIModeMedium.Location = new Point(65, 88);
            CustomRadioButtonDPIModeMedium.Margin = new Padding(1);
            CustomRadioButtonDPIModeMedium.Name = "CustomRadioButtonDPIModeMedium";
            CustomRadioButtonDPIModeMedium.SelectionColor = Color.LightBlue;
            CustomRadioButtonDPIModeMedium.Size = new Size(69, 17);
            CustomRadioButtonDPIModeMedium.TabIndex = 5;
            CustomRadioButtonDPIModeMedium.Text = "Medium";
            CustomRadioButtonDPIModeMedium.UseVisualStyleBackColor = false;
            CustomRadioButtonDPIModeMedium.CheckedChanged += SecureDNSClient_CheckedChanged;
            // 
            // CustomRadioButtonDPIModeLight
            // 
            CustomRadioButtonDPIModeLight.BackColor = Color.DimGray;
            CustomRadioButtonDPIModeLight.BorderColor = Color.Blue;
            CustomRadioButtonDPIModeLight.CheckColor = Color.Blue;
            CustomRadioButtonDPIModeLight.Checked = true;
            CustomRadioButtonDPIModeLight.ForeColor = Color.White;
            CustomRadioButtonDPIModeLight.Location = new Point(11, 88);
            CustomRadioButtonDPIModeLight.Margin = new Padding(1);
            CustomRadioButtonDPIModeLight.Name = "CustomRadioButtonDPIModeLight";
            CustomRadioButtonDPIModeLight.SelectionColor = Color.LightBlue;
            CustomRadioButtonDPIModeLight.Size = new Size(51, 17);
            CustomRadioButtonDPIModeLight.TabIndex = 4;
            CustomRadioButtonDPIModeLight.TabStop = true;
            CustomRadioButtonDPIModeLight.Text = "Light";
            CustomRadioButtonDPIModeLight.UseVisualStyleBackColor = false;
            CustomRadioButtonDPIModeLight.CheckedChanged += SecureDNSClient_CheckedChanged;
            // 
            // CustomLabelDPIModes
            // 
            CustomLabelDPIModes.AutoSize = true;
            CustomLabelDPIModes.BackColor = Color.DimGray;
            CustomLabelDPIModes.Border = false;
            CustomLabelDPIModes.BorderColor = Color.Blue;
            CustomLabelDPIModes.FlatStyle = FlatStyle.Flat;
            CustomLabelDPIModes.ForeColor = Color.White;
            CustomLabelDPIModes.Location = new Point(11, 63);
            CustomLabelDPIModes.Name = "CustomLabelDPIModes";
            CustomLabelDPIModes.RoundedCorners = 0;
            CustomLabelDPIModes.Size = new Size(75, 15);
            CustomLabelDPIModes.TabIndex = 3;
            CustomLabelDPIModes.Text = "Select mode:";
            // 
            // CustomButtonConnect
            // 
            CustomButtonConnect.BorderColor = Color.Blue;
            CustomButtonConnect.FlatStyle = FlatStyle.Flat;
            CustomButtonConnect.Location = new Point(3, 3);
            CustomButtonConnect.Name = "CustomButtonConnect";
            CustomButtonConnect.RoundedCorners = 5;
            CustomButtonConnect.SelectionColor = Color.LightBlue;
            CustomButtonConnect.Size = new Size(104, 27);
            CustomButtonConnect.TabIndex = 1;
            CustomButtonConnect.Text = "Disconnecting...";
            CustomButtonConnect.UseVisualStyleBackColor = true;
            CustomButtonConnect.Click += CustomButtonConnect_Click;
            // 
            // CustomTabControlMain
            // 
            CustomTabControlMain.BorderColor = Color.Blue;
            CustomTabControlMain.Controls.Add(TabPageSecureDNS);
            CustomTabControlMain.Controls.Add(TabPageTools);
            CustomTabControlMain.Controls.Add(TabPageSettings);
            CustomTabControlMain.Controls.Add(TabPageAbout);
            CustomTabControlMain.Dock = DockStyle.Fill;
            CustomTabControlMain.HideTabHeader = false;
            CustomTabControlMain.ItemSize = new Size(90, 21);
            CustomTabControlMain.Location = new Point(0, 0);
            CustomTabControlMain.Margin = new Padding(0);
            CustomTabControlMain.Name = "CustomTabControlMain";
            CustomTabControlMain.RoundedCorners = 5;
            CustomTabControlMain.SelectedIndex = 0;
            CustomTabControlMain.Size = new Size(779, 400);
            CustomTabControlMain.SizeMode = TabSizeMode.Fixed;
            CustomTabControlMain.TabIndex = 6;
            CustomTabControlMain.Tag = 2;
            // 
            // TabPageSecureDNS
            // 
            TabPageSecureDNS.BackColor = Color.Transparent;
            TabPageSecureDNS.Controls.Add(CustomTabControlSecureDNS);
            TabPageSecureDNS.Location = new Point(4, 25);
            TabPageSecureDNS.Name = "TabPageSecureDNS";
            TabPageSecureDNS.Padding = new Padding(3);
            TabPageSecureDNS.Size = new Size(771, 371);
            TabPageSecureDNS.TabIndex = 0;
            TabPageSecureDNS.Tag = 0;
            TabPageSecureDNS.Text = "Secure DNS";
            // 
            // CustomTabControlSecureDNS
            // 
            CustomTabControlSecureDNS.BorderColor = Color.Blue;
            CustomTabControlSecureDNS.Controls.Add(TabPageCheck);
            CustomTabControlSecureDNS.Controls.Add(TabPageConnect);
            CustomTabControlSecureDNS.Controls.Add(TabPageSetDNS);
            CustomTabControlSecureDNS.Controls.Add(TabPageShare);
            CustomTabControlSecureDNS.Controls.Add(TabPageGoodbyeDPI);
            CustomTabControlSecureDNS.Dock = DockStyle.Fill;
            CustomTabControlSecureDNS.HideTabHeader = false;
            CustomTabControlSecureDNS.ItemSize = new Size(120, 21);
            CustomTabControlSecureDNS.Location = new Point(3, 3);
            CustomTabControlSecureDNS.Margin = new Padding(0);
            CustomTabControlSecureDNS.Name = "CustomTabControlSecureDNS";
            CustomTabControlSecureDNS.RoundedCorners = 5;
            CustomTabControlSecureDNS.SelectedIndex = 0;
            CustomTabControlSecureDNS.Size = new Size(765, 365);
            CustomTabControlSecureDNS.SizeMode = TabSizeMode.Fixed;
            CustomTabControlSecureDNS.TabIndex = 0;
            CustomTabControlSecureDNS.Tag = 0;
            CustomTabControlSecureDNS.SelectedIndexChanged += CustomTabControlSecureDNS_SelectedIndexChanged;
            // 
            // TabPageCheck
            // 
            TabPageCheck.BackColor = Color.Transparent;
            TabPageCheck.Controls.Add(SplitContainerCheckMain);
            TabPageCheck.Location = new Point(4, 25);
            TabPageCheck.Name = "TabPageCheck";
            TabPageCheck.Padding = new Padding(3);
            TabPageCheck.Size = new Size(757, 336);
            TabPageCheck.TabIndex = 0;
            TabPageCheck.Tag = 0;
            TabPageCheck.Text = "1. Check";
            // 
            // SplitContainerCheckMain
            // 
            SplitContainerCheckMain.Dock = DockStyle.Fill;
            SplitContainerCheckMain.FixedPanel = FixedPanel.Panel2;
            SplitContainerCheckMain.IsSplitterFixed = true;
            SplitContainerCheckMain.Location = new Point(3, 3);
            SplitContainerCheckMain.Name = "SplitContainerCheckMain";
            SplitContainerCheckMain.Orientation = Orientation.Horizontal;
            // 
            // SplitContainerCheckMain.Panel1
            // 
            SplitContainerCheckMain.Panel1.Controls.Add(SplitContainerCheckTop);
            // 
            // SplitContainerCheckMain.Panel2
            // 
            SplitContainerCheckMain.Panel2.Controls.Add(CustomButtonEditCustomServers);
            SplitContainerCheckMain.Panel2.Controls.Add(CustomButtonDisconnectAll);
            SplitContainerCheckMain.Panel2.Controls.Add(CustomButtonCheck);
            SplitContainerCheckMain.Panel2.Controls.Add(CustomButtonQuickConnect);
            SplitContainerCheckMain.Panel2.Controls.Add(CustomButtonCheckUpdate);
            SplitContainerCheckMain.Panel2.Controls.Add(CustomProgressBarCheck);
            SplitContainerCheckMain.Size = new Size(751, 330);
            SplitContainerCheckMain.SplitterDistance = 282;
            SplitContainerCheckMain.TabIndex = 22;
            // 
            // SplitContainerCheckTop
            // 
            SplitContainerCheckTop.Dock = DockStyle.Fill;
            SplitContainerCheckTop.Location = new Point(0, 0);
            SplitContainerCheckTop.Name = "SplitContainerCheckTop";
            // 
            // SplitContainerCheckTop.Panel1
            // 
            SplitContainerCheckTop.Panel1.AutoScroll = true;
            SplitContainerCheckTop.Panel1.Controls.Add(CustomRadioButtonBuiltIn);
            SplitContainerCheckTop.Panel1.Controls.Add(CustomNumericUpDownCheckInParallel);
            SplitContainerCheckTop.Panel1.Controls.Add(CustomRadioButtonCustom);
            SplitContainerCheckTop.Panel1.Controls.Add(CustomLabelCheckInParallel);
            SplitContainerCheckTop.Panel1.Controls.Add(CustomLabelCustomServersInfo);
            SplitContainerCheckTop.Panel1.Controls.Add(CustomCheckBoxInsecure);
            SplitContainerCheckTop.Panel1MinSize = 500;
            // 
            // SplitContainerCheckTop.Panel2
            // 
            SplitContainerCheckTop.Panel2.Controls.Add(CustomGroupBoxCheckStatus);
            SplitContainerCheckTop.Panel2MinSize = 200;
            SplitContainerCheckTop.Size = new Size(751, 282);
            SplitContainerCheckTop.SplitterDistance = 547;
            SplitContainerCheckTop.TabIndex = 0;
            // 
            // CustomNumericUpDownCheckInParallel
            // 
            CustomNumericUpDownCheckInParallel.BackColor = Color.DimGray;
            CustomNumericUpDownCheckInParallel.BorderColor = Color.Blue;
            CustomNumericUpDownCheckInParallel.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownCheckInParallel.Location = new Point(112, 195);
            CustomNumericUpDownCheckInParallel.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            CustomNumericUpDownCheckInParallel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownCheckInParallel.Name = "CustomNumericUpDownCheckInParallel";
            CustomNumericUpDownCheckInParallel.RoundedCorners = 5;
            CustomNumericUpDownCheckInParallel.Size = new Size(50, 23);
            CustomNumericUpDownCheckInParallel.TabIndex = 20;
            CustomNumericUpDownCheckInParallel.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // CustomLabelCheckInParallel
            // 
            CustomLabelCheckInParallel.AutoSize = true;
            CustomLabelCheckInParallel.BackColor = Color.DimGray;
            CustomLabelCheckInParallel.Border = false;
            CustomLabelCheckInParallel.BorderColor = Color.Blue;
            CustomLabelCheckInParallel.FlatStyle = FlatStyle.Flat;
            CustomLabelCheckInParallel.ForeColor = Color.White;
            CustomLabelCheckInParallel.Location = new Point(7, 197);
            CustomLabelCheckInParallel.Name = "CustomLabelCheckInParallel";
            CustomLabelCheckInParallel.RoundedCorners = 0;
            CustomLabelCheckInParallel.Size = new Size(99, 17);
            CustomLabelCheckInParallel.TabIndex = 19;
            CustomLabelCheckInParallel.Text = "Check in parallel:";
            // 
            // CustomGroupBoxCheckStatus
            // 
            CustomGroupBoxCheckStatus.BorderColor = Color.Blue;
            CustomGroupBoxCheckStatus.Controls.Add(CustomRichTextBoxCheckStatus);
            CustomGroupBoxCheckStatus.Dock = DockStyle.Fill;
            CustomGroupBoxCheckStatus.Location = new Point(0, 0);
            CustomGroupBoxCheckStatus.Name = "CustomGroupBoxCheckStatus";
            CustomGroupBoxCheckStatus.RoundedCorners = 5;
            CustomGroupBoxCheckStatus.Size = new Size(200, 282);
            CustomGroupBoxCheckStatus.TabIndex = 0;
            CustomGroupBoxCheckStatus.TabStop = false;
            CustomGroupBoxCheckStatus.Text = "Check Status";
            // 
            // CustomRichTextBoxCheckStatus
            // 
            CustomRichTextBoxCheckStatus.AcceptsTab = false;
            CustomRichTextBoxCheckStatus.AutoScroll = true;
            CustomRichTextBoxCheckStatus.AutoWordSelection = false;
            CustomRichTextBoxCheckStatus.BackColor = Color.DimGray;
            CustomRichTextBoxCheckStatus.Border = false;
            CustomRichTextBoxCheckStatus.BorderColor = Color.Blue;
            CustomRichTextBoxCheckStatus.BorderSize = 1;
            CustomRichTextBoxCheckStatus.BulletIndent = 0;
            CustomRichTextBoxCheckStatus.DetectUrls = false;
            CustomRichTextBoxCheckStatus.Dock = DockStyle.Fill;
            CustomRichTextBoxCheckStatus.EnableAutoDragDrop = false;
            CustomRichTextBoxCheckStatus.Font = new Font("Segoe UI", 9F);
            CustomRichTextBoxCheckStatus.ForeColor = Color.White;
            CustomRichTextBoxCheckStatus.HideSelection = false;
            CustomRichTextBoxCheckStatus.Location = new Point(3, 19);
            CustomRichTextBoxCheckStatus.MaxLength = int.MaxValue;
            CustomRichTextBoxCheckStatus.MinimumSize = new Size(0, 23);
            CustomRichTextBoxCheckStatus.Multiline = true;
            CustomRichTextBoxCheckStatus.Name = "CustomRichTextBoxCheckStatus";
            CustomRichTextBoxCheckStatus.ReadOnly = true;
            CustomRichTextBoxCheckStatus.RightMargin = 0;
            CustomRichTextBoxCheckStatus.RoundedCorners = 0;
            CustomRichTextBoxCheckStatus.ScrollBars = ScrollBars.Both;
            CustomRichTextBoxCheckStatus.ScrollToBottom = false;
            CustomRichTextBoxCheckStatus.SelectionColor = Color.White;
            CustomRichTextBoxCheckStatus.SelectionLength = 0;
            CustomRichTextBoxCheckStatus.SelectionStart = 0;
            CustomRichTextBoxCheckStatus.ShortcutsEnabled = true;
            CustomRichTextBoxCheckStatus.Size = new Size(194, 260);
            CustomRichTextBoxCheckStatus.TabIndex = 0;
            CustomRichTextBoxCheckStatus.Texts = "";
            CustomRichTextBoxCheckStatus.UnderlinedStyle = false;
            CustomRichTextBoxCheckStatus.WordWrap = true;
            CustomRichTextBoxCheckStatus.ZoomFactor = 1F;
            // 
            // CustomButtonDisconnectAll
            // 
            CustomButtonDisconnectAll.BorderColor = Color.Blue;
            CustomButtonDisconnectAll.FlatStyle = FlatStyle.Flat;
            CustomButtonDisconnectAll.Location = new Point(296, 2);
            CustomButtonDisconnectAll.Name = "CustomButtonDisconnectAll";
            CustomButtonDisconnectAll.RoundedCorners = 5;
            CustomButtonDisconnectAll.SelectionColor = Color.LightBlue;
            CustomButtonDisconnectAll.Size = new Size(98, 27);
            CustomButtonDisconnectAll.TabIndex = 18;
            CustomButtonDisconnectAll.Text = "Disconnect All";
            CustomButtonDisconnectAll.UseVisualStyleBackColor = true;
            CustomButtonDisconnectAll.Click += CustomButtonDisconnectAll_Click;
            // 
            // CustomButtonQuickConnect
            // 
            CustomButtonQuickConnect.BorderColor = Color.Blue;
            CustomButtonQuickConnect.FlatStyle = FlatStyle.Flat;
            CustomButtonQuickConnect.Location = new Point(192, 2);
            CustomButtonQuickConnect.Name = "CustomButtonQuickConnect";
            CustomButtonQuickConnect.RoundedCorners = 5;
            CustomButtonQuickConnect.SelectionColor = Color.LightBlue;
            CustomButtonQuickConnect.Size = new Size(98, 27);
            CustomButtonQuickConnect.TabIndex = 17;
            CustomButtonQuickConnect.Text = "Quick Connect";
            CustomButtonQuickConnect.UseVisualStyleBackColor = true;
            CustomButtonQuickConnect.MouseUp += CustomButtonQuickConnect_MouseUp;
            // 
            // CustomButtonCheckUpdate
            // 
            CustomButtonCheckUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CustomButtonCheckUpdate.BorderColor = Color.Blue;
            CustomButtonCheckUpdate.FlatStyle = FlatStyle.Flat;
            CustomButtonCheckUpdate.Location = new Point(655, 2);
            CustomButtonCheckUpdate.Name = "CustomButtonCheckUpdate";
            CustomButtonCheckUpdate.RoundedCorners = 5;
            CustomButtonCheckUpdate.SelectionColor = Color.LightBlue;
            CustomButtonCheckUpdate.Size = new Size(93, 27);
            CustomButtonCheckUpdate.TabIndex = 13;
            CustomButtonCheckUpdate.Text = "Check Update";
            CustomButtonCheckUpdate.UseVisualStyleBackColor = true;
            CustomButtonCheckUpdate.Click += CustomButtonCheckUpdate_Click;
            // 
            // CustomProgressBarCheck
            // 
            CustomProgressBarCheck.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomProgressBarCheck.BackColor = Color.DimGray;
            CustomProgressBarCheck.BorderColor = Color.Blue;
            CustomProgressBarCheck.ChunksColor = Color.LightBlue;
            CustomProgressBarCheck.CustomText = "";
            CustomProgressBarCheck.ForeColor = Color.White;
            CustomProgressBarCheck.Location = new Point(400, 2);
            CustomProgressBarCheck.Name = "CustomProgressBarCheck";
            CustomProgressBarCheck.RoundedCorners = 5;
            CustomProgressBarCheck.Size = new Size(249, 27);
            CustomProgressBarCheck.StopTimer = false;
            CustomProgressBarCheck.TabIndex = 16;
            // 
            // TabPageConnect
            // 
            TabPageConnect.BackColor = Color.Transparent;
            TabPageConnect.Controls.Add(SplitContainerConnectMain);
            TabPageConnect.Location = new Point(4, 25);
            TabPageConnect.Name = "TabPageConnect";
            TabPageConnect.Padding = new Padding(3);
            TabPageConnect.Size = new Size(757, 336);
            TabPageConnect.TabIndex = 1;
            TabPageConnect.Tag = 1;
            TabPageConnect.Text = "2. Connect";
            TabPageConnect.Visible = false;
            // 
            // SplitContainerConnectMain
            // 
            SplitContainerConnectMain.Dock = DockStyle.Fill;
            SplitContainerConnectMain.FixedPanel = FixedPanel.Panel2;
            SplitContainerConnectMain.IsSplitterFixed = true;
            SplitContainerConnectMain.Location = new Point(3, 3);
            SplitContainerConnectMain.Name = "SplitContainerConnectMain";
            SplitContainerConnectMain.Orientation = Orientation.Horizontal;
            // 
            // SplitContainerConnectMain.Panel1
            // 
            SplitContainerConnectMain.Panel1.Controls.Add(SplitContainerConnectTop);
            // 
            // SplitContainerConnectMain.Panel2
            // 
            SplitContainerConnectMain.Panel2.Controls.Add(CustomButtonReconnect);
            SplitContainerConnectMain.Panel2.Controls.Add(CustomButtonConnect);
            SplitContainerConnectMain.Size = new Size(751, 330);
            SplitContainerConnectMain.SplitterDistance = 283;
            SplitContainerConnectMain.TabIndex = 22;
            // 
            // SplitContainerConnectTop
            // 
            SplitContainerConnectTop.Dock = DockStyle.Fill;
            SplitContainerConnectTop.Location = new Point(0, 0);
            SplitContainerConnectTop.Name = "SplitContainerConnectTop";
            // 
            // SplitContainerConnectTop.Panel1
            // 
            SplitContainerConnectTop.Panel1.AutoScroll = true;
            SplitContainerConnectTop.Panel1.Controls.Add(CustomRadioButtonConnectCheckedServers);
            SplitContainerConnectTop.Panel1.Controls.Add(CustomButtonWriteSavedServersDelay);
            SplitContainerConnectTop.Panel1.Controls.Add(CustomTextBoxHTTPProxy);
            SplitContainerConnectTop.Panel1.Controls.Add(CustomRadioButtonConnectFakeProxyDohViaProxyDPI);
            SplitContainerConnectTop.Panel1.Controls.Add(CustomRadioButtonConnectDNSCrypt);
            SplitContainerConnectTop.Panel1.Controls.Add(CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI);
            SplitContainerConnectTop.Panel1MinSize = 500;
            // 
            // SplitContainerConnectTop.Panel2
            // 
            SplitContainerConnectTop.Panel2.Controls.Add(CustomGroupBoxConnectStatus);
            SplitContainerConnectTop.Panel2MinSize = 200;
            SplitContainerConnectTop.Size = new Size(751, 283);
            SplitContainerConnectTop.SplitterDistance = 547;
            SplitContainerConnectTop.TabIndex = 0;
            // 
            // CustomRadioButtonConnectCheckedServers
            // 
            CustomRadioButtonConnectCheckedServers.BackColor = Color.DimGray;
            CustomRadioButtonConnectCheckedServers.BorderColor = Color.Blue;
            CustomRadioButtonConnectCheckedServers.CheckColor = Color.Blue;
            CustomRadioButtonConnectCheckedServers.Checked = true;
            CustomRadioButtonConnectCheckedServers.ForeColor = Color.White;
            CustomRadioButtonConnectCheckedServers.Location = new Point(9, 15);
            CustomRadioButtonConnectCheckedServers.Name = "CustomRadioButtonConnectCheckedServers";
            CustomRadioButtonConnectCheckedServers.SelectionColor = Color.LightBlue;
            CustomRadioButtonConnectCheckedServers.Size = new Size(173, 17);
            CustomRadioButtonConnectCheckedServers.TabIndex = 14;
            CustomRadioButtonConnectCheckedServers.TabStop = true;
            CustomRadioButtonConnectCheckedServers.Text = "Connect to working servers";
            CustomRadioButtonConnectCheckedServers.UseVisualStyleBackColor = false;
            // 
            // CustomButtonWriteSavedServersDelay
            // 
            CustomButtonWriteSavedServersDelay.BorderColor = Color.Blue;
            CustomButtonWriteSavedServersDelay.FlatStyle = FlatStyle.Flat;
            CustomButtonWriteSavedServersDelay.Location = new Point(184, 9);
            CustomButtonWriteSavedServersDelay.Name = "CustomButtonWriteSavedServersDelay";
            CustomButtonWriteSavedServersDelay.RoundedCorners = 5;
            CustomButtonWriteSavedServersDelay.SelectionColor = Color.LightBlue;
            CustomButtonWriteSavedServersDelay.Size = new Size(140, 27);
            CustomButtonWriteSavedServersDelay.TabIndex = 19;
            CustomButtonWriteSavedServersDelay.Text = "Get saved servers delay";
            CustomButtonWriteSavedServersDelay.UseVisualStyleBackColor = true;
            CustomButtonWriteSavedServersDelay.Click += CustomButtonWriteSavedServersDelay_Click;
            // 
            // CustomRadioButtonConnectFakeProxyDohViaProxyDPI
            // 
            CustomRadioButtonConnectFakeProxyDohViaProxyDPI.BackColor = Color.DimGray;
            CustomRadioButtonConnectFakeProxyDohViaProxyDPI.BorderColor = Color.Blue;
            CustomRadioButtonConnectFakeProxyDohViaProxyDPI.CheckColor = Color.Blue;
            CustomRadioButtonConnectFakeProxyDohViaProxyDPI.ForeColor = Color.White;
            CustomRadioButtonConnectFakeProxyDohViaProxyDPI.Location = new Point(9, 60);
            CustomRadioButtonConnectFakeProxyDohViaProxyDPI.Name = "CustomRadioButtonConnectFakeProxyDohViaProxyDPI";
            CustomRadioButtonConnectFakeProxyDohViaProxyDPI.SelectionColor = Color.LightBlue;
            CustomRadioButtonConnectFakeProxyDohViaProxyDPI.Size = new Size(252, 37);
            CustomRadioButtonConnectFakeProxyDohViaProxyDPI.TabIndex = 17;
            CustomRadioButtonConnectFakeProxyDohViaProxyDPI.TabStop = true;
            CustomRadioButtonConnectFakeProxyDohViaProxyDPI.Text = "Connect to Fake Proxy DoH using ProxyDPI\r\n(Gets Fragment settings from Share tab)";
            CustomRadioButtonConnectFakeProxyDohViaProxyDPI.UseVisualStyleBackColor = false;
            // 
            // CustomRadioButtonConnectDNSCrypt
            // 
            CustomRadioButtonConnectDNSCrypt.BackColor = Color.DimGray;
            CustomRadioButtonConnectDNSCrypt.BorderColor = Color.Blue;
            CustomRadioButtonConnectDNSCrypt.CheckColor = Color.Blue;
            CustomRadioButtonConnectDNSCrypt.ForeColor = Color.White;
            CustomRadioButtonConnectDNSCrypt.Location = new Point(9, 164);
            CustomRadioButtonConnectDNSCrypt.Name = "CustomRadioButtonConnectDNSCrypt";
            CustomRadioButtonConnectDNSCrypt.SelectionColor = Color.LightBlue;
            CustomRadioButtonConnectDNSCrypt.Size = new Size(287, 37);
            CustomRadioButtonConnectDNSCrypt.TabIndex = 13;
            CustomRadioButtonConnectDNSCrypt.Text = "Connect to popular servers using upstream proxy:\r\n(HTTP and SOCKS5 are supported)";
            CustomRadioButtonConnectDNSCrypt.UseVisualStyleBackColor = false;
            // 
            // CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI
            // 
            CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI.BackColor = Color.DimGray;
            CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI.BorderColor = Color.Blue;
            CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI.CheckColor = Color.Blue;
            CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI.ForeColor = Color.White;
            CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI.Location = new Point(9, 110);
            CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI.Name = "CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI";
            CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI.SelectionColor = Color.LightBlue;
            CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI.Size = new Size(287, 37);
            CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI.TabIndex = 15;
            CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI.Text = "Connect to Fake Proxy DoH using GoodbyeDPI\r\n(User Choice)";
            CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI.UseVisualStyleBackColor = false;
            // 
            // CustomGroupBoxConnectStatus
            // 
            CustomGroupBoxConnectStatus.BorderColor = Color.Blue;
            CustomGroupBoxConnectStatus.Controls.Add(CustomRichTextBoxConnectStatus);
            CustomGroupBoxConnectStatus.Dock = DockStyle.Fill;
            CustomGroupBoxConnectStatus.Location = new Point(0, 0);
            CustomGroupBoxConnectStatus.Name = "CustomGroupBoxConnectStatus";
            CustomGroupBoxConnectStatus.RoundedCorners = 5;
            CustomGroupBoxConnectStatus.Size = new Size(200, 283);
            CustomGroupBoxConnectStatus.TabIndex = 0;
            CustomGroupBoxConnectStatus.TabStop = false;
            CustomGroupBoxConnectStatus.Text = "Connect Status";
            // 
            // CustomRichTextBoxConnectStatus
            // 
            CustomRichTextBoxConnectStatus.AcceptsTab = false;
            CustomRichTextBoxConnectStatus.AutoScroll = true;
            CustomRichTextBoxConnectStatus.AutoWordSelection = false;
            CustomRichTextBoxConnectStatus.BackColor = Color.DimGray;
            CustomRichTextBoxConnectStatus.Border = false;
            CustomRichTextBoxConnectStatus.BorderColor = Color.Blue;
            CustomRichTextBoxConnectStatus.BorderSize = 1;
            CustomRichTextBoxConnectStatus.BulletIndent = 0;
            CustomRichTextBoxConnectStatus.DetectUrls = false;
            CustomRichTextBoxConnectStatus.Dock = DockStyle.Fill;
            CustomRichTextBoxConnectStatus.EnableAutoDragDrop = false;
            CustomRichTextBoxConnectStatus.Font = new Font("Segoe UI", 9F);
            CustomRichTextBoxConnectStatus.ForeColor = Color.White;
            CustomRichTextBoxConnectStatus.HideSelection = false;
            CustomRichTextBoxConnectStatus.Location = new Point(3, 19);
            CustomRichTextBoxConnectStatus.MaxLength = int.MaxValue;
            CustomRichTextBoxConnectStatus.MinimumSize = new Size(0, 23);
            CustomRichTextBoxConnectStatus.Multiline = true;
            CustomRichTextBoxConnectStatus.Name = "CustomRichTextBoxConnectStatus";
            CustomRichTextBoxConnectStatus.ReadOnly = true;
            CustomRichTextBoxConnectStatus.RightMargin = 0;
            CustomRichTextBoxConnectStatus.RoundedCorners = 0;
            CustomRichTextBoxConnectStatus.ScrollBars = ScrollBars.Both;
            CustomRichTextBoxConnectStatus.ScrollToBottom = false;
            CustomRichTextBoxConnectStatus.SelectionColor = Color.White;
            CustomRichTextBoxConnectStatus.SelectionLength = 0;
            CustomRichTextBoxConnectStatus.SelectionStart = 0;
            CustomRichTextBoxConnectStatus.ShortcutsEnabled = true;
            CustomRichTextBoxConnectStatus.Size = new Size(194, 261);
            CustomRichTextBoxConnectStatus.TabIndex = 0;
            CustomRichTextBoxConnectStatus.Texts = "";
            CustomRichTextBoxConnectStatus.UnderlinedStyle = false;
            CustomRichTextBoxConnectStatus.WordWrap = true;
            CustomRichTextBoxConnectStatus.ZoomFactor = 1F;
            // 
            // CustomButtonReconnect
            // 
            CustomButtonReconnect.BorderColor = Color.Blue;
            CustomButtonReconnect.FlatStyle = FlatStyle.Flat;
            CustomButtonReconnect.Location = new Point(121, 3);
            CustomButtonReconnect.Name = "CustomButtonReconnect";
            CustomButtonReconnect.RoundedCorners = 5;
            CustomButtonReconnect.SelectionColor = Color.LightBlue;
            CustomButtonReconnect.Size = new Size(104, 27);
            CustomButtonReconnect.TabIndex = 2;
            CustomButtonReconnect.Text = "Reconnect";
            CustomButtonReconnect.UseVisualStyleBackColor = true;
            CustomButtonReconnect.Click += CustomButtonReconnect_Click;
            // 
            // TabPageSetDNS
            // 
            TabPageSetDNS.BackColor = Color.Transparent;
            TabPageSetDNS.Controls.Add(SplitContainerSetDnsMain);
            TabPageSetDNS.Location = new Point(4, 25);
            TabPageSetDNS.Name = "TabPageSetDNS";
            TabPageSetDNS.Padding = new Padding(3);
            TabPageSetDNS.Size = new Size(757, 336);
            TabPageSetDNS.TabIndex = 3;
            TabPageSetDNS.Tag = 2;
            TabPageSetDNS.Text = "3. Set DNS";
            TabPageSetDNS.Visible = false;
            // 
            // SplitContainerSetDnsMain
            // 
            SplitContainerSetDnsMain.Dock = DockStyle.Fill;
            SplitContainerSetDnsMain.FixedPanel = FixedPanel.Panel2;
            SplitContainerSetDnsMain.IsSplitterFixed = true;
            SplitContainerSetDnsMain.Location = new Point(3, 3);
            SplitContainerSetDnsMain.Name = "SplitContainerSetDnsMain";
            SplitContainerSetDnsMain.Orientation = Orientation.Horizontal;
            // 
            // SplitContainerSetDnsMain.Panel1
            // 
            SplitContainerSetDnsMain.Panel1.Controls.Add(SplitContainerSetDnsTop);
            // 
            // SplitContainerSetDnsMain.Panel2
            // 
            SplitContainerSetDnsMain.Panel2.Controls.Add(CustomButtonUnsetAllDNSs);
            SplitContainerSetDnsMain.Panel2.Controls.Add(CustomButtonSetDNS);
            SplitContainerSetDnsMain.Size = new Size(751, 330);
            SplitContainerSetDnsMain.SplitterDistance = 278;
            SplitContainerSetDnsMain.TabIndex = 22;
            // 
            // SplitContainerSetDnsTop
            // 
            SplitContainerSetDnsTop.Dock = DockStyle.Fill;
            SplitContainerSetDnsTop.Location = new Point(0, 0);
            SplitContainerSetDnsTop.Name = "SplitContainerSetDnsTop";
            // 
            // SplitContainerSetDnsTop.Panel1
            // 
            SplitContainerSetDnsTop.Panel1.Controls.Add(FlowLayoutPanelSetDns);
            SplitContainerSetDnsTop.Panel1MinSize = 200;
            // 
            // SplitContainerSetDnsTop.Panel2
            // 
            SplitContainerSetDnsTop.Panel2.Controls.Add(CustomGroupBoxNicStatus);
            SplitContainerSetDnsTop.Panel2MinSize = 200;
            SplitContainerSetDnsTop.Size = new Size(751, 278);
            SplitContainerSetDnsTop.SplitterDistance = 349;
            SplitContainerSetDnsTop.TabIndex = 0;
            // 
            // FlowLayoutPanelSetDns
            // 
            FlowLayoutPanelSetDns.AutoScroll = true;
            FlowLayoutPanelSetDns.Controls.Add(CustomLabelSelectNIC);
            FlowLayoutPanelSetDns.Controls.Add(CustomComboBoxNICs);
            FlowLayoutPanelSetDns.Controls.Add(CustomLabelSetDnsSpacer1);
            FlowLayoutPanelSetDns.Controls.Add(CustomButtonUpdateNICs);
            FlowLayoutPanelSetDns.Controls.Add(CustomButtonFindActiveNic);
            FlowLayoutPanelSetDns.Controls.Add(CustomButtonEnableDisableNicIPv6);
            FlowLayoutPanelSetDns.Controls.Add(CustomButtonEnableDisableNic);
            FlowLayoutPanelSetDns.Controls.Add(CustomLabelSetDnsSpacer2);
            FlowLayoutPanelSetDns.Dock = DockStyle.Fill;
            FlowLayoutPanelSetDns.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanelSetDns.Location = new Point(0, 0);
            FlowLayoutPanelSetDns.Name = "FlowLayoutPanelSetDns";
            FlowLayoutPanelSetDns.Padding = new Padding(5);
            FlowLayoutPanelSetDns.Size = new Size(349, 278);
            FlowLayoutPanelSetDns.TabIndex = 0;
            FlowLayoutPanelSetDns.WrapContents = false;
            // 
            // CustomLabelSelectNIC
            // 
            CustomLabelSelectNIC.AutoSize = true;
            CustomLabelSelectNIC.BackColor = Color.DimGray;
            CustomLabelSelectNIC.Border = false;
            CustomLabelSelectNIC.BorderColor = Color.Blue;
            CustomLabelSelectNIC.FlatStyle = FlatStyle.Flat;
            CustomLabelSelectNIC.ForeColor = Color.White;
            CustomLabelSelectNIC.Location = new Point(8, 8);
            CustomLabelSelectNIC.Margin = new Padding(3);
            CustomLabelSelectNIC.Name = "CustomLabelSelectNIC";
            CustomLabelSelectNIC.RoundedCorners = 0;
            CustomLabelSelectNIC.Size = new Size(144, 15);
            CustomLabelSelectNIC.TabIndex = 0;
            CustomLabelSelectNIC.Text = "Select a Network Interface";
            // 
            // CustomComboBoxNICs
            // 
            CustomComboBoxNICs.BackColor = Color.DimGray;
            CustomComboBoxNICs.BorderColor = Color.Blue;
            CustomComboBoxNICs.DrawMode = DrawMode.OwnerDrawVariable;
            CustomComboBoxNICs.ForeColor = Color.White;
            CustomComboBoxNICs.FormattingEnabled = true;
            CustomComboBoxNICs.ItemHeight = 17;
            CustomComboBoxNICs.Location = new Point(15, 36);
            CustomComboBoxNICs.Margin = new Padding(10);
            CustomComboBoxNICs.Name = "CustomComboBoxNICs";
            CustomComboBoxNICs.RoundedCorners = 5;
            CustomComboBoxNICs.SelectionColor = Color.DodgerBlue;
            CustomComboBoxNICs.Size = new Size(200, 23);
            CustomComboBoxNICs.TabIndex = 1;
            CustomComboBoxNICs.Text = "Select a Network Adapter";
            CustomComboBoxNICs.SelectedIndexChanged += CustomComboBoxNICs_SelectedIndexChanged;
            // 
            // CustomLabelSetDnsSpacer1
            // 
            CustomLabelSetDnsSpacer1.BackColor = Color.DimGray;
            CustomLabelSetDnsSpacer1.Border = false;
            CustomLabelSetDnsSpacer1.BorderColor = Color.Blue;
            CustomLabelSetDnsSpacer1.FlatStyle = FlatStyle.Flat;
            CustomLabelSetDnsSpacer1.ForeColor = Color.White;
            CustomLabelSetDnsSpacer1.Location = new Point(8, 72);
            CustomLabelSetDnsSpacer1.Margin = new Padding(3);
            CustomLabelSetDnsSpacer1.Name = "CustomLabelSetDnsSpacer1";
            CustomLabelSetDnsSpacer1.RoundedCorners = 0;
            CustomLabelSetDnsSpacer1.Size = new Size(103, 20);
            CustomLabelSetDnsSpacer1.TabIndex = 9;
            CustomLabelSetDnsSpacer1.Text = "                    ";
            // 
            // CustomButtonUpdateNICs
            // 
            CustomButtonUpdateNICs.BorderColor = Color.Blue;
            CustomButtonUpdateNICs.FlatStyle = FlatStyle.Flat;
            CustomButtonUpdateNICs.Location = new Point(8, 98);
            CustomButtonUpdateNICs.Name = "CustomButtonUpdateNICs";
            CustomButtonUpdateNICs.RoundedCorners = 5;
            CustomButtonUpdateNICs.SelectionColor = Color.LightBlue;
            CustomButtonUpdateNICs.Size = new Size(110, 27);
            CustomButtonUpdateNICs.TabIndex = 8;
            CustomButtonUpdateNICs.Text = "Update";
            CustomButtonUpdateNICs.UseVisualStyleBackColor = true;
            CustomButtonUpdateNICs.Click += CustomButtonUpdateNICs_Click;
            // 
            // CustomButtonFindActiveNic
            // 
            CustomButtonFindActiveNic.BorderColor = Color.Blue;
            CustomButtonFindActiveNic.FlatStyle = FlatStyle.Flat;
            CustomButtonFindActiveNic.Location = new Point(8, 131);
            CustomButtonFindActiveNic.Name = "CustomButtonFindActiveNic";
            CustomButtonFindActiveNic.RoundedCorners = 5;
            CustomButtonFindActiveNic.SelectionColor = Color.LightBlue;
            CustomButtonFindActiveNic.Size = new Size(110, 27);
            CustomButtonFindActiveNic.TabIndex = 7;
            CustomButtonFindActiveNic.Text = "Find Active NIC";
            CustomButtonFindActiveNic.UseVisualStyleBackColor = true;
            CustomButtonFindActiveNic.Click += CustomButtonFindActiveNic_Click;
            // 
            // CustomButtonEnableDisableNicIPv6
            // 
            CustomButtonEnableDisableNicIPv6.BorderColor = Color.Blue;
            CustomButtonEnableDisableNicIPv6.FlatStyle = FlatStyle.Flat;
            CustomButtonEnableDisableNicIPv6.Location = new Point(8, 164);
            CustomButtonEnableDisableNicIPv6.Name = "CustomButtonEnableDisableNicIPv6";
            CustomButtonEnableDisableNicIPv6.RoundedCorners = 5;
            CustomButtonEnableDisableNicIPv6.SelectionColor = Color.LightBlue;
            CustomButtonEnableDisableNicIPv6.Size = new Size(110, 27);
            CustomButtonEnableDisableNicIPv6.TabIndex = 11;
            CustomButtonEnableDisableNicIPv6.Text = "Disable IPv6";
            CustomButtonEnableDisableNicIPv6.UseVisualStyleBackColor = true;
            CustomButtonEnableDisableNicIPv6.Click += CustomButtonEnableDisableNicIPv6_Click;
            // 
            // CustomButtonEnableDisableNic
            // 
            CustomButtonEnableDisableNic.BorderColor = Color.Blue;
            CustomButtonEnableDisableNic.FlatStyle = FlatStyle.Flat;
            CustomButtonEnableDisableNic.Location = new Point(8, 197);
            CustomButtonEnableDisableNic.Name = "CustomButtonEnableDisableNic";
            CustomButtonEnableDisableNic.RoundedCorners = 5;
            CustomButtonEnableDisableNic.SelectionColor = Color.LightBlue;
            CustomButtonEnableDisableNic.Size = new Size(110, 27);
            CustomButtonEnableDisableNic.TabIndex = 6;
            CustomButtonEnableDisableNic.Text = "Disable NIC";
            CustomButtonEnableDisableNic.UseVisualStyleBackColor = true;
            CustomButtonEnableDisableNic.Click += CustomButtonEnableDisableNic_Click;
            // 
            // CustomLabelSetDnsSpacer2
            // 
            CustomLabelSetDnsSpacer2.BackColor = Color.DimGray;
            CustomLabelSetDnsSpacer2.Border = false;
            CustomLabelSetDnsSpacer2.BorderColor = Color.Blue;
            CustomLabelSetDnsSpacer2.FlatStyle = FlatStyle.Flat;
            CustomLabelSetDnsSpacer2.ForeColor = Color.White;
            CustomLabelSetDnsSpacer2.Location = new Point(8, 230);
            CustomLabelSetDnsSpacer2.Margin = new Padding(3);
            CustomLabelSetDnsSpacer2.Name = "CustomLabelSetDnsSpacer2";
            CustomLabelSetDnsSpacer2.RoundedCorners = 0;
            CustomLabelSetDnsSpacer2.Size = new Size(103, 20);
            CustomLabelSetDnsSpacer2.TabIndex = 10;
            CustomLabelSetDnsSpacer2.Text = "                    ";
            // 
            // CustomGroupBoxNicStatus
            // 
            CustomGroupBoxNicStatus.BorderColor = Color.Blue;
            CustomGroupBoxNicStatus.Controls.Add(CustomDataGridViewNicStatus);
            CustomGroupBoxNicStatus.Dock = DockStyle.Fill;
            CustomGroupBoxNicStatus.Location = new Point(0, 0);
            CustomGroupBoxNicStatus.Name = "CustomGroupBoxNicStatus";
            CustomGroupBoxNicStatus.RoundedCorners = 5;
            CustomGroupBoxNicStatus.Size = new Size(398, 278);
            CustomGroupBoxNicStatus.TabIndex = 5;
            CustomGroupBoxNicStatus.TabStop = false;
            CustomGroupBoxNicStatus.Text = "Network Adapter Status";
            // 
            // CustomDataGridViewNicStatus
            // 
            CustomDataGridViewNicStatus.AllowUserToAddRows = false;
            CustomDataGridViewNicStatus.AllowUserToDeleteRows = false;
            CustomDataGridViewNicStatus.AllowUserToResizeColumns = false;
            CustomDataGridViewNicStatus.AllowUserToResizeRows = false;
            CustomDataGridViewNicStatus.BorderColor = Color.Blue;
            CustomDataGridViewNicStatus.CheckColor = Color.Blue;
            CustomDataGridViewNicStatus.ColumnHeadersBorder = true;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(73, 73, 73);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle17.ForeColor = Color.White;
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(73, 73, 73);
            dataGridViewCellStyle17.SelectionForeColor = Color.White;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            CustomDataGridViewNicStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            CustomDataGridViewNicStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomDataGridViewNicStatus.ColumnHeadersVisible = false;
            CustomDataGridViewNicStatus.Columns.AddRange(new DataGridViewColumn[] { ColumnNicStatusName, ColumnNicStatusText });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.DimGray;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = Color.White;
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(97, 177, 255);
            dataGridViewCellStyle18.SelectionForeColor = Color.White;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            CustomDataGridViewNicStatus.DefaultCellStyle = dataGridViewCellStyle18;
            CustomDataGridViewNicStatus.Dock = DockStyle.Fill;
            CustomDataGridViewNicStatus.GridColor = Color.LightBlue;
            CustomDataGridViewNicStatus.Location = new Point(3, 19);
            CustomDataGridViewNicStatus.MultiSelect = false;
            CustomDataGridViewNicStatus.Name = "CustomDataGridViewNicStatus";
            CustomDataGridViewNicStatus.ReadOnly = true;
            CustomDataGridViewNicStatus.RowHeadersVisible = false;
            CustomDataGridViewNicStatus.RowTemplate.Height = 25;
            CustomDataGridViewNicStatus.ScrollBars = ScrollBars.Vertical;
            CustomDataGridViewNicStatus.SelectionColor = Color.DodgerBlue;
            CustomDataGridViewNicStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomDataGridViewNicStatus.SelectionModeFocus = false;
            CustomDataGridViewNicStatus.ShowCellErrors = false;
            CustomDataGridViewNicStatus.ShowCellToolTips = false;
            CustomDataGridViewNicStatus.ShowEditingIcon = false;
            CustomDataGridViewNicStatus.ShowRowErrors = false;
            CustomDataGridViewNicStatus.Size = new Size(392, 256);
            CustomDataGridViewNicStatus.TabIndex = 19;
            // 
            // ColumnNicStatusName
            // 
            ColumnNicStatusName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnNicStatusName.HeaderText = "Status Name";
            ColumnNicStatusName.Name = "ColumnNicStatusName";
            ColumnNicStatusName.ReadOnly = true;
            ColumnNicStatusName.Resizable = DataGridViewTriState.False;
            ColumnNicStatusName.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnNicStatusName.Width = 5;
            // 
            // ColumnNicStatusText
            // 
            ColumnNicStatusText.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnNicStatusText.HeaderText = "Status Text";
            ColumnNicStatusText.Name = "ColumnNicStatusText";
            ColumnNicStatusText.ReadOnly = true;
            ColumnNicStatusText.Resizable = DataGridViewTriState.False;
            ColumnNicStatusText.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomButtonUnsetAllDNSs
            // 
            CustomButtonUnsetAllDNSs.BorderColor = Color.Blue;
            CustomButtonUnsetAllDNSs.FlatStyle = FlatStyle.Flat;
            CustomButtonUnsetAllDNSs.Location = new Point(84, 3);
            CustomButtonUnsetAllDNSs.Name = "CustomButtonUnsetAllDNSs";
            CustomButtonUnsetAllDNSs.RoundedCorners = 5;
            CustomButtonUnsetAllDNSs.SelectionColor = Color.LightBlue;
            CustomButtonUnsetAllDNSs.Size = new Size(110, 27);
            CustomButtonUnsetAllDNSs.TabIndex = 4;
            CustomButtonUnsetAllDNSs.Text = "Unset All DNSs";
            CustomButtonUnsetAllDNSs.UseVisualStyleBackColor = true;
            CustomButtonUnsetAllDNSs.Click += CustomButtonUnsetAllDNSs_Click;
            // 
            // CustomButtonSetDNS
            // 
            CustomButtonSetDNS.BorderColor = Color.Blue;
            CustomButtonSetDNS.FlatStyle = FlatStyle.Flat;
            CustomButtonSetDNS.Location = new Point(3, 3);
            CustomButtonSetDNS.Name = "CustomButtonSetDNS";
            CustomButtonSetDNS.RoundedCorners = 5;
            CustomButtonSetDNS.SelectionColor = Color.LightBlue;
            CustomButtonSetDNS.Size = new Size(75, 27);
            CustomButtonSetDNS.TabIndex = 3;
            CustomButtonSetDNS.Text = "Unset DNS";
            CustomButtonSetDNS.UseVisualStyleBackColor = true;
            CustomButtonSetDNS.Click += CustomButtonSetDNS_Click;
            // 
            // TabPageShare
            // 
            TabPageShare.BackColor = Color.Transparent;
            TabPageShare.Controls.Add(SplitContainerShareMain);
            TabPageShare.Location = new Point(4, 25);
            TabPageShare.Name = "TabPageShare";
            TabPageShare.Padding = new Padding(3);
            TabPageShare.Size = new Size(757, 336);
            TabPageShare.TabIndex = 4;
            TabPageShare.Tag = 3;
            TabPageShare.Text = "4. Share + Bypass DPI";
            TabPageShare.Visible = false;
            // 
            // TabPageGoodbyeDPI
            // 
            TabPageGoodbyeDPI.BackColor = Color.Transparent;
            TabPageGoodbyeDPI.Controls.Add(CustomTabControlDPIBasicAdvanced);
            TabPageGoodbyeDPI.Location = new Point(4, 25);
            TabPageGoodbyeDPI.Name = "TabPageGoodbyeDPI";
            TabPageGoodbyeDPI.Padding = new Padding(3);
            TabPageGoodbyeDPI.Size = new Size(757, 336);
            TabPageGoodbyeDPI.TabIndex = 2;
            TabPageGoodbyeDPI.Tag = 4;
            TabPageGoodbyeDPI.Text = "GoodbyeDPI";
            TabPageGoodbyeDPI.Visible = false;
            // 
            // CustomTabControlDPIBasicAdvanced
            // 
            CustomTabControlDPIBasicAdvanced.BorderColor = Color.Blue;
            CustomTabControlDPIBasicAdvanced.Controls.Add(TabPageDPIBasic);
            CustomTabControlDPIBasicAdvanced.Controls.Add(TabPageDPIAdvanced);
            CustomTabControlDPIBasicAdvanced.Dock = DockStyle.Fill;
            CustomTabControlDPIBasicAdvanced.HideTabHeader = false;
            CustomTabControlDPIBasicAdvanced.ItemSize = new Size(90, 21);
            CustomTabControlDPIBasicAdvanced.Location = new Point(3, 3);
            CustomTabControlDPIBasicAdvanced.Name = "CustomTabControlDPIBasicAdvanced";
            CustomTabControlDPIBasicAdvanced.RoundedCorners = 5;
            CustomTabControlDPIBasicAdvanced.SelectedIndex = 0;
            CustomTabControlDPIBasicAdvanced.Size = new Size(751, 330);
            CustomTabControlDPIBasicAdvanced.SizeMode = TabSizeMode.Fixed;
            CustomTabControlDPIBasicAdvanced.TabIndex = 13;
            CustomTabControlDPIBasicAdvanced.Tag = 1;
            // 
            // TabPageDPIBasic
            // 
            TabPageDPIBasic.BackColor = Color.Transparent;
            TabPageDPIBasic.Controls.Add(SplitContainerGoodbyeDpiBasicMain);
            TabPageDPIBasic.Location = new Point(4, 25);
            TabPageDPIBasic.Name = "TabPageDPIBasic";
            TabPageDPIBasic.Padding = new Padding(3);
            TabPageDPIBasic.Size = new Size(743, 301);
            TabPageDPIBasic.TabIndex = 0;
            TabPageDPIBasic.Tag = 0;
            TabPageDPIBasic.Text = "Basic";
            TabPageDPIBasic.Visible = false;
            // 
            // SplitContainerGoodbyeDpiBasicMain
            // 
            SplitContainerGoodbyeDpiBasicMain.Dock = DockStyle.Fill;
            SplitContainerGoodbyeDpiBasicMain.FixedPanel = FixedPanel.Panel2;
            SplitContainerGoodbyeDpiBasicMain.IsSplitterFixed = true;
            SplitContainerGoodbyeDpiBasicMain.Location = new Point(3, 3);
            SplitContainerGoodbyeDpiBasicMain.Name = "SplitContainerGoodbyeDpiBasicMain";
            SplitContainerGoodbyeDpiBasicMain.Orientation = Orientation.Horizontal;
            // 
            // SplitContainerGoodbyeDpiBasicMain.Panel1
            // 
            SplitContainerGoodbyeDpiBasicMain.Panel1.AutoScroll = true;
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomLabelInfoDPIModes);
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomRadioButtonDPIModeHigh);
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomRadioButtonDPIMode6);
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomRadioButtonDPIModeExtreme);
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomRadioButtonDPIMode5);
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomRadioButtonDPIModeMedium);
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomRadioButtonDPIMode4);
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomRadioButtonDPIModeLight);
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomRadioButtonDPIMode3);
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomLabelSSLFragmentSize);
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomLabelDPIModesGoodbyeDPI);
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomLabelDPIModes);
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomRadioButtonDPIMode2);
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomNumericUpDownSSLFragmentSize);
            SplitContainerGoodbyeDpiBasicMain.Panel1.Controls.Add(CustomRadioButtonDPIMode1);
            // 
            // SplitContainerGoodbyeDpiBasicMain.Panel2
            // 
            SplitContainerGoodbyeDpiBasicMain.Panel2.Controls.Add(CustomButtonDPIBasicActivate);
            SplitContainerGoodbyeDpiBasicMain.Panel2.Controls.Add(CustomButtonDPIBasicDeactivate);
            SplitContainerGoodbyeDpiBasicMain.Size = new Size(737, 295);
            SplitContainerGoodbyeDpiBasicMain.SplitterDistance = 239;
            SplitContainerGoodbyeDpiBasicMain.TabIndex = 21;
            // 
            // CustomLabelInfoDPIModes
            // 
            CustomLabelInfoDPIModes.AutoSize = true;
            CustomLabelInfoDPIModes.BackColor = Color.DimGray;
            CustomLabelInfoDPIModes.Border = false;
            CustomLabelInfoDPIModes.BorderColor = Color.Blue;
            CustomLabelInfoDPIModes.FlatStyle = FlatStyle.Flat;
            CustomLabelInfoDPIModes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CustomLabelInfoDPIModes.ForeColor = Color.White;
            CustomLabelInfoDPIModes.Location = new Point(11, 8);
            CustomLabelInfoDPIModes.Name = "CustomLabelInfoDPIModes";
            CustomLabelInfoDPIModes.RoundedCorners = 0;
            CustomLabelInfoDPIModes.Size = new Size(147, 38);
            CustomLabelInfoDPIModes.TabIndex = 20;
            CustomLabelInfoDPIModes.Text = "Light: MTN-AST-ASK\r\nMedium: MCI-SHT";
            // 
            // CustomRadioButtonDPIMode6
            // 
            CustomRadioButtonDPIMode6.BackColor = Color.DimGray;
            CustomRadioButtonDPIMode6.BorderColor = Color.Blue;
            CustomRadioButtonDPIMode6.CheckColor = Color.Blue;
            CustomRadioButtonDPIMode6.ForeColor = Color.White;
            CustomRadioButtonDPIMode6.Location = new Point(356, 148);
            CustomRadioButtonDPIMode6.Name = "CustomRadioButtonDPIMode6";
            CustomRadioButtonDPIMode6.SelectionColor = Color.LightBlue;
            CustomRadioButtonDPIMode6.Size = new Size(66, 17);
            CustomRadioButtonDPIMode6.TabIndex = 19;
            CustomRadioButtonDPIMode6.Text = "Mode 6";
            CustomRadioButtonDPIMode6.UseVisualStyleBackColor = false;
            // 
            // CustomRadioButtonDPIMode5
            // 
            CustomRadioButtonDPIMode5.BackColor = Color.DimGray;
            CustomRadioButtonDPIMode5.BorderColor = Color.Blue;
            CustomRadioButtonDPIMode5.CheckColor = Color.Blue;
            CustomRadioButtonDPIMode5.ForeColor = Color.White;
            CustomRadioButtonDPIMode5.Location = new Point(287, 148);
            CustomRadioButtonDPIMode5.Name = "CustomRadioButtonDPIMode5";
            CustomRadioButtonDPIMode5.SelectionColor = Color.LightBlue;
            CustomRadioButtonDPIMode5.Size = new Size(66, 17);
            CustomRadioButtonDPIMode5.TabIndex = 18;
            CustomRadioButtonDPIMode5.Text = "Mode 5";
            CustomRadioButtonDPIMode5.UseVisualStyleBackColor = false;
            // 
            // CustomRadioButtonDPIMode4
            // 
            CustomRadioButtonDPIMode4.BackColor = Color.DimGray;
            CustomRadioButtonDPIMode4.BorderColor = Color.Blue;
            CustomRadioButtonDPIMode4.CheckColor = Color.Blue;
            CustomRadioButtonDPIMode4.ForeColor = Color.White;
            CustomRadioButtonDPIMode4.Location = new Point(218, 148);
            CustomRadioButtonDPIMode4.Name = "CustomRadioButtonDPIMode4";
            CustomRadioButtonDPIMode4.SelectionColor = Color.LightBlue;
            CustomRadioButtonDPIMode4.Size = new Size(66, 17);
            CustomRadioButtonDPIMode4.TabIndex = 17;
            CustomRadioButtonDPIMode4.Text = "Mode 4";
            CustomRadioButtonDPIMode4.UseVisualStyleBackColor = false;
            // 
            // CustomRadioButtonDPIMode3
            // 
            CustomRadioButtonDPIMode3.BackColor = Color.DimGray;
            CustomRadioButtonDPIMode3.BorderColor = Color.Blue;
            CustomRadioButtonDPIMode3.CheckColor = Color.Blue;
            CustomRadioButtonDPIMode3.ForeColor = Color.White;
            CustomRadioButtonDPIMode3.Location = new Point(149, 148);
            CustomRadioButtonDPIMode3.Name = "CustomRadioButtonDPIMode3";
            CustomRadioButtonDPIMode3.SelectionColor = Color.LightBlue;
            CustomRadioButtonDPIMode3.Size = new Size(66, 17);
            CustomRadioButtonDPIMode3.TabIndex = 16;
            CustomRadioButtonDPIMode3.Text = "Mode 3";
            CustomRadioButtonDPIMode3.UseVisualStyleBackColor = false;
            // 
            // CustomLabelDPIModesGoodbyeDPI
            // 
            CustomLabelDPIModesGoodbyeDPI.AutoSize = true;
            CustomLabelDPIModesGoodbyeDPI.BackColor = Color.DimGray;
            CustomLabelDPIModesGoodbyeDPI.Border = false;
            CustomLabelDPIModesGoodbyeDPI.BorderColor = Color.Blue;
            CustomLabelDPIModesGoodbyeDPI.FlatStyle = FlatStyle.Flat;
            CustomLabelDPIModesGoodbyeDPI.ForeColor = Color.White;
            CustomLabelDPIModesGoodbyeDPI.Location = new Point(11, 123);
            CustomLabelDPIModesGoodbyeDPI.Name = "CustomLabelDPIModesGoodbyeDPI";
            CustomLabelDPIModesGoodbyeDPI.RoundedCorners = 0;
            CustomLabelDPIModesGoodbyeDPI.Size = new Size(118, 15);
            CustomLabelDPIModesGoodbyeDPI.TabIndex = 15;
            CustomLabelDPIModesGoodbyeDPI.Text = "Goodbye DPI modes:";
            // 
            // CustomRadioButtonDPIMode2
            // 
            CustomRadioButtonDPIMode2.BackColor = Color.DimGray;
            CustomRadioButtonDPIMode2.BorderColor = Color.Blue;
            CustomRadioButtonDPIMode2.CheckColor = Color.Blue;
            CustomRadioButtonDPIMode2.ForeColor = Color.White;
            CustomRadioButtonDPIMode2.Location = new Point(80, 148);
            CustomRadioButtonDPIMode2.Name = "CustomRadioButtonDPIMode2";
            CustomRadioButtonDPIMode2.SelectionColor = Color.LightBlue;
            CustomRadioButtonDPIMode2.Size = new Size(66, 17);
            CustomRadioButtonDPIMode2.TabIndex = 14;
            CustomRadioButtonDPIMode2.Text = "Mode 2";
            CustomRadioButtonDPIMode2.UseVisualStyleBackColor = false;
            // 
            // CustomRadioButtonDPIMode1
            // 
            CustomRadioButtonDPIMode1.BackColor = Color.DimGray;
            CustomRadioButtonDPIMode1.BorderColor = Color.Blue;
            CustomRadioButtonDPIMode1.CheckColor = Color.Blue;
            CustomRadioButtonDPIMode1.ForeColor = Color.White;
            CustomRadioButtonDPIMode1.Location = new Point(11, 148);
            CustomRadioButtonDPIMode1.Name = "CustomRadioButtonDPIMode1";
            CustomRadioButtonDPIMode1.SelectionColor = Color.LightBlue;
            CustomRadioButtonDPIMode1.Size = new Size(66, 17);
            CustomRadioButtonDPIMode1.TabIndex = 13;
            CustomRadioButtonDPIMode1.Text = "Mode 1";
            CustomRadioButtonDPIMode1.UseVisualStyleBackColor = false;
            // 
            // CustomButtonDPIBasicActivate
            // 
            CustomButtonDPIBasicActivate.BorderColor = Color.Blue;
            CustomButtonDPIBasicActivate.FlatStyle = FlatStyle.Flat;
            CustomButtonDPIBasicActivate.Location = new Point(3, 3);
            CustomButtonDPIBasicActivate.Name = "CustomButtonDPIBasicActivate";
            CustomButtonDPIBasicActivate.RoundedCorners = 5;
            CustomButtonDPIBasicActivate.SelectionColor = Color.LightBlue;
            CustomButtonDPIBasicActivate.Size = new Size(73, 27);
            CustomButtonDPIBasicActivate.TabIndex = 11;
            CustomButtonDPIBasicActivate.Text = "Reactivate";
            CustomButtonDPIBasicActivate.UseVisualStyleBackColor = true;
            CustomButtonDPIBasicActivate.Click += CustomButtonDPIBasic_Click;
            // 
            // CustomButtonDPIBasicDeactivate
            // 
            CustomButtonDPIBasicDeactivate.BorderColor = Color.Blue;
            CustomButtonDPIBasicDeactivate.FlatStyle = FlatStyle.Flat;
            CustomButtonDPIBasicDeactivate.Location = new Point(82, 3);
            CustomButtonDPIBasicDeactivate.Name = "CustomButtonDPIBasicDeactivate";
            CustomButtonDPIBasicDeactivate.RoundedCorners = 5;
            CustomButtonDPIBasicDeactivate.SelectionColor = Color.LightBlue;
            CustomButtonDPIBasicDeactivate.Size = new Size(74, 27);
            CustomButtonDPIBasicDeactivate.TabIndex = 12;
            CustomButtonDPIBasicDeactivate.Text = "Deactivate";
            CustomButtonDPIBasicDeactivate.UseVisualStyleBackColor = true;
            CustomButtonDPIBasicDeactivate.Click += CustomButtonDPIBasicDeactivate_Click;
            // 
            // TabPageDPIAdvanced
            // 
            TabPageDPIAdvanced.BackColor = Color.Transparent;
            TabPageDPIAdvanced.Controls.Add(SplitContainerGoodbyeDpiAdvancedMain);
            TabPageDPIAdvanced.Location = new Point(4, 25);
            TabPageDPIAdvanced.Name = "TabPageDPIAdvanced";
            TabPageDPIAdvanced.Padding = new Padding(3);
            TabPageDPIAdvanced.Size = new Size(743, 301);
            TabPageDPIAdvanced.TabIndex = 1;
            TabPageDPIAdvanced.Tag = 1;
            TabPageDPIAdvanced.Text = "Advanced";
            TabPageDPIAdvanced.Visible = false;
            // 
            // SplitContainerGoodbyeDpiAdvancedMain
            // 
            SplitContainerGoodbyeDpiAdvancedMain.Dock = DockStyle.Fill;
            SplitContainerGoodbyeDpiAdvancedMain.FixedPanel = FixedPanel.Panel2;
            SplitContainerGoodbyeDpiAdvancedMain.IsSplitterFixed = true;
            SplitContainerGoodbyeDpiAdvancedMain.Location = new Point(3, 3);
            SplitContainerGoodbyeDpiAdvancedMain.Name = "SplitContainerGoodbyeDpiAdvancedMain";
            SplitContainerGoodbyeDpiAdvancedMain.Orientation = Orientation.Horizontal;
            // 
            // SplitContainerGoodbyeDpiAdvancedMain.Panel1
            // 
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.AutoScroll = true;
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvP);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomTextBoxDPIAdvAutoTTL);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvR);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomNumericUpDownDPIAdvMaxPayload);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvS);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomNumericUpDownDPIAdvMinTTL);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvM);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomNumericUpDownDPIAdvSetTTL);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvF);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomNumericUpDownDPIAdvPort);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomNumericUpDownDPIAdvF);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomButtonDPIAdvBlacklist);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvK);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvBlacklist);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomNumericUpDownDPIAdvK);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvMaxPayload);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvN);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvReverseFrag);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvE);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvNativeFrag);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomNumericUpDownDPIAdvE);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvWrongSeq);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvA);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvWrongChksum);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvW);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvMinTTL);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvPort);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvAutoTTL);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvIpId);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvSetTTL);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomTextBoxDPIAdvIpId);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.Controls.Add(CustomCheckBoxDPIAdvAllowNoSNI);
            // 
            // SplitContainerGoodbyeDpiAdvancedMain.Panel2
            // 
            SplitContainerGoodbyeDpiAdvancedMain.Panel2.Controls.Add(CustomButtonDPIAdvActivate);
            SplitContainerGoodbyeDpiAdvancedMain.Panel2.Controls.Add(CustomButtonDPIAdvDeactivate);
            SplitContainerGoodbyeDpiAdvancedMain.Size = new Size(737, 295);
            SplitContainerGoodbyeDpiAdvancedMain.SplitterDistance = 246;
            SplitContainerGoodbyeDpiAdvancedMain.TabIndex = 38;
            // 
            // CustomCheckBoxDPIAdvP
            // 
            CustomCheckBoxDPIAdvP.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvP.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvP.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvP.Checked = true;
            CustomCheckBoxDPIAdvP.CheckState = CheckState.Checked;
            CustomCheckBoxDPIAdvP.ForeColor = Color.White;
            CustomCheckBoxDPIAdvP.Location = new Point(9, 8);
            CustomCheckBoxDPIAdvP.Name = "CustomCheckBoxDPIAdvP";
            CustomCheckBoxDPIAdvP.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvP.Size = new Size(36, 17);
            CustomCheckBoxDPIAdvP.TabIndex = 0;
            CustomCheckBoxDPIAdvP.Text = "-p";
            CustomCheckBoxDPIAdvP.UseVisualStyleBackColor = false;
            // 
            // CustomTextBoxDPIAdvAutoTTL
            // 
            CustomTextBoxDPIAdvAutoTTL.AcceptsReturn = false;
            CustomTextBoxDPIAdvAutoTTL.AcceptsTab = false;
            CustomTextBoxDPIAdvAutoTTL.BackColor = Color.DimGray;
            CustomTextBoxDPIAdvAutoTTL.Border = true;
            CustomTextBoxDPIAdvAutoTTL.BorderColor = Color.Blue;
            CustomTextBoxDPIAdvAutoTTL.BorderSize = 1;
            CustomTextBoxDPIAdvAutoTTL.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxDPIAdvAutoTTL.Font = new Font("Segoe UI", 9F);
            CustomTextBoxDPIAdvAutoTTL.ForeColor = Color.White;
            CustomTextBoxDPIAdvAutoTTL.HideSelection = true;
            CustomTextBoxDPIAdvAutoTTL.Location = new Point(397, 96);
            CustomTextBoxDPIAdvAutoTTL.MaxLength = 32767;
            CustomTextBoxDPIAdvAutoTTL.Multiline = false;
            CustomTextBoxDPIAdvAutoTTL.Name = "CustomTextBoxDPIAdvAutoTTL";
            CustomTextBoxDPIAdvAutoTTL.ReadOnly = false;
            CustomTextBoxDPIAdvAutoTTL.RoundedCorners = 0;
            CustomTextBoxDPIAdvAutoTTL.ScrollBars = ScrollBars.None;
            CustomTextBoxDPIAdvAutoTTL.ShortcutsEnabled = true;
            CustomTextBoxDPIAdvAutoTTL.Size = new Size(53, 23);
            CustomTextBoxDPIAdvAutoTTL.TabIndex = 0;
            CustomTextBoxDPIAdvAutoTTL.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxDPIAdvAutoTTL.Texts = "1-4-10";
            CustomTextBoxDPIAdvAutoTTL.UnderlinedStyle = true;
            CustomTextBoxDPIAdvAutoTTL.UsePasswordChar = false;
            CustomTextBoxDPIAdvAutoTTL.WordWrap = true;
            // 
            // CustomCheckBoxDPIAdvR
            // 
            CustomCheckBoxDPIAdvR.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvR.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvR.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvR.Checked = true;
            CustomCheckBoxDPIAdvR.CheckState = CheckState.Checked;
            CustomCheckBoxDPIAdvR.ForeColor = Color.White;
            CustomCheckBoxDPIAdvR.Location = new Point(169, 8);
            CustomCheckBoxDPIAdvR.Name = "CustomCheckBoxDPIAdvR";
            CustomCheckBoxDPIAdvR.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvR.Size = new Size(33, 17);
            CustomCheckBoxDPIAdvR.TabIndex = 1;
            CustomCheckBoxDPIAdvR.Text = "-r";
            CustomCheckBoxDPIAdvR.UseVisualStyleBackColor = false;
            // 
            // CustomNumericUpDownDPIAdvMaxPayload
            // 
            CustomNumericUpDownDPIAdvMaxPayload.BackColor = Color.DimGray;
            CustomNumericUpDownDPIAdvMaxPayload.BorderColor = Color.Blue;
            CustomNumericUpDownDPIAdvMaxPayload.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownDPIAdvMaxPayload.Location = new Point(110, 156);
            CustomNumericUpDownDPIAdvMaxPayload.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            CustomNumericUpDownDPIAdvMaxPayload.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownDPIAdvMaxPayload.Name = "CustomNumericUpDownDPIAdvMaxPayload";
            CustomNumericUpDownDPIAdvMaxPayload.RoundedCorners = 5;
            CustomNumericUpDownDPIAdvMaxPayload.Size = new Size(53, 23);
            CustomNumericUpDownDPIAdvMaxPayload.TabIndex = 36;
            CustomNumericUpDownDPIAdvMaxPayload.Value = new decimal(new int[] { 1200, 0, 0, 0 });
            // 
            // CustomCheckBoxDPIAdvS
            // 
            CustomCheckBoxDPIAdvS.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvS.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvS.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvS.Checked = true;
            CustomCheckBoxDPIAdvS.CheckState = CheckState.Checked;
            CustomCheckBoxDPIAdvS.ForeColor = Color.White;
            CustomCheckBoxDPIAdvS.Location = new Point(324, 8);
            CustomCheckBoxDPIAdvS.Name = "CustomCheckBoxDPIAdvS";
            CustomCheckBoxDPIAdvS.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvS.Size = new Size(34, 17);
            CustomCheckBoxDPIAdvS.TabIndex = 2;
            CustomCheckBoxDPIAdvS.Text = "-s";
            CustomCheckBoxDPIAdvS.UseVisualStyleBackColor = false;
            // 
            // CustomNumericUpDownDPIAdvMinTTL
            // 
            CustomNumericUpDownDPIAdvMinTTL.BackColor = Color.DimGray;
            CustomNumericUpDownDPIAdvMinTTL.BorderColor = Color.Blue;
            CustomNumericUpDownDPIAdvMinTTL.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownDPIAdvMinTTL.Location = new Point(543, 96);
            CustomNumericUpDownDPIAdvMinTTL.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            CustomNumericUpDownDPIAdvMinTTL.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownDPIAdvMinTTL.Name = "CustomNumericUpDownDPIAdvMinTTL";
            CustomNumericUpDownDPIAdvMinTTL.RoundedCorners = 5;
            CustomNumericUpDownDPIAdvMinTTL.Size = new Size(53, 23);
            CustomNumericUpDownDPIAdvMinTTL.TabIndex = 35;
            CustomNumericUpDownDPIAdvMinTTL.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // CustomCheckBoxDPIAdvM
            // 
            CustomCheckBoxDPIAdvM.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvM.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvM.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvM.Checked = true;
            CustomCheckBoxDPIAdvM.CheckState = CheckState.Checked;
            CustomCheckBoxDPIAdvM.ForeColor = Color.White;
            CustomCheckBoxDPIAdvM.Location = new Point(474, 8);
            CustomCheckBoxDPIAdvM.Name = "CustomCheckBoxDPIAdvM";
            CustomCheckBoxDPIAdvM.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvM.Size = new Size(40, 17);
            CustomCheckBoxDPIAdvM.TabIndex = 3;
            CustomCheckBoxDPIAdvM.Text = "-m";
            CustomCheckBoxDPIAdvM.UseVisualStyleBackColor = false;
            // 
            // CustomNumericUpDownDPIAdvSetTTL
            // 
            CustomNumericUpDownDPIAdvSetTTL.BackColor = Color.DimGray;
            CustomNumericUpDownDPIAdvSetTTL.BorderColor = Color.Blue;
            CustomNumericUpDownDPIAdvSetTTL.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownDPIAdvSetTTL.Location = new Point(234, 96);
            CustomNumericUpDownDPIAdvSetTTL.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            CustomNumericUpDownDPIAdvSetTTL.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownDPIAdvSetTTL.Name = "CustomNumericUpDownDPIAdvSetTTL";
            CustomNumericUpDownDPIAdvSetTTL.RoundedCorners = 5;
            CustomNumericUpDownDPIAdvSetTTL.Size = new Size(53, 23);
            CustomNumericUpDownDPIAdvSetTTL.TabIndex = 34;
            CustomNumericUpDownDPIAdvSetTTL.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CustomCheckBoxDPIAdvF
            // 
            CustomCheckBoxDPIAdvF.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvF.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvF.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvF.ForeColor = Color.White;
            CustomCheckBoxDPIAdvF.Location = new Point(9, 38);
            CustomCheckBoxDPIAdvF.Name = "CustomCheckBoxDPIAdvF";
            CustomCheckBoxDPIAdvF.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvF.Size = new Size(33, 17);
            CustomCheckBoxDPIAdvF.TabIndex = 4;
            CustomCheckBoxDPIAdvF.Text = "-f";
            CustomCheckBoxDPIAdvF.UseVisualStyleBackColor = false;
            // 
            // CustomNumericUpDownDPIAdvPort
            // 
            CustomNumericUpDownDPIAdvPort.BackColor = Color.DimGray;
            CustomNumericUpDownDPIAdvPort.BorderColor = Color.Blue;
            CustomNumericUpDownDPIAdvPort.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownDPIAdvPort.Location = new Point(380, 66);
            CustomNumericUpDownDPIAdvPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            CustomNumericUpDownDPIAdvPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownDPIAdvPort.Name = "CustomNumericUpDownDPIAdvPort";
            CustomNumericUpDownDPIAdvPort.RoundedCorners = 5;
            CustomNumericUpDownDPIAdvPort.Size = new Size(53, 23);
            CustomNumericUpDownDPIAdvPort.TabIndex = 33;
            CustomNumericUpDownDPIAdvPort.Value = new decimal(new int[] { 80, 0, 0, 0 });
            // 
            // CustomNumericUpDownDPIAdvF
            // 
            CustomNumericUpDownDPIAdvF.BackColor = Color.DimGray;
            CustomNumericUpDownDPIAdvF.BorderColor = Color.Blue;
            CustomNumericUpDownDPIAdvF.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownDPIAdvF.Location = new Point(42, 36);
            CustomNumericUpDownDPIAdvF.Maximum = new decimal(new int[] { 70000, 0, 0, 0 });
            CustomNumericUpDownDPIAdvF.Name = "CustomNumericUpDownDPIAdvF";
            CustomNumericUpDownDPIAdvF.RoundedCorners = 5;
            CustomNumericUpDownDPIAdvF.Size = new Size(53, 23);
            CustomNumericUpDownDPIAdvF.TabIndex = 5;
            CustomNumericUpDownDPIAdvF.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // CustomButtonDPIAdvBlacklist
            // 
            CustomButtonDPIAdvBlacklist.BorderColor = Color.Blue;
            CustomButtonDPIAdvBlacklist.FlatStyle = FlatStyle.Flat;
            CustomButtonDPIAdvBlacklist.Location = new Point(245, 156);
            CustomButtonDPIAdvBlacklist.Name = "CustomButtonDPIAdvBlacklist";
            CustomButtonDPIAdvBlacklist.RoundedCorners = 5;
            CustomButtonDPIAdvBlacklist.SelectionColor = Color.LightBlue;
            CustomButtonDPIAdvBlacklist.Size = new Size(50, 25);
            CustomButtonDPIAdvBlacklist.TabIndex = 30;
            CustomButtonDPIAdvBlacklist.Text = "Edit";
            CustomButtonDPIAdvBlacklist.UseVisualStyleBackColor = true;
            CustomButtonDPIAdvBlacklist.Click += CustomButtonDPIAdvBlacklist_Click;
            // 
            // CustomCheckBoxDPIAdvK
            // 
            CustomCheckBoxDPIAdvK.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvK.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvK.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvK.ForeColor = Color.White;
            CustomCheckBoxDPIAdvK.Location = new Point(169, 38);
            CustomCheckBoxDPIAdvK.Name = "CustomCheckBoxDPIAdvK";
            CustomCheckBoxDPIAdvK.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvK.Size = new Size(35, 17);
            CustomCheckBoxDPIAdvK.TabIndex = 6;
            CustomCheckBoxDPIAdvK.Text = "-k";
            CustomCheckBoxDPIAdvK.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxDPIAdvBlacklist
            // 
            CustomCheckBoxDPIAdvBlacklist.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvBlacklist.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvBlacklist.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvBlacklist.ForeColor = Color.White;
            CustomCheckBoxDPIAdvBlacklist.Location = new Point(169, 158);
            CustomCheckBoxDPIAdvBlacklist.Name = "CustomCheckBoxDPIAdvBlacklist";
            CustomCheckBoxDPIAdvBlacklist.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvBlacklist.Size = new Size(78, 17);
            CustomCheckBoxDPIAdvBlacklist.TabIndex = 29;
            CustomCheckBoxDPIAdvBlacklist.Text = "--blacklist";
            CustomCheckBoxDPIAdvBlacklist.UseVisualStyleBackColor = false;
            // 
            // CustomNumericUpDownDPIAdvK
            // 
            CustomNumericUpDownDPIAdvK.BackColor = Color.DimGray;
            CustomNumericUpDownDPIAdvK.BorderColor = Color.Blue;
            CustomNumericUpDownDPIAdvK.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownDPIAdvK.Location = new Point(205, 36);
            CustomNumericUpDownDPIAdvK.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            CustomNumericUpDownDPIAdvK.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownDPIAdvK.Name = "CustomNumericUpDownDPIAdvK";
            CustomNumericUpDownDPIAdvK.RoundedCorners = 5;
            CustomNumericUpDownDPIAdvK.Size = new Size(53, 23);
            CustomNumericUpDownDPIAdvK.TabIndex = 7;
            CustomNumericUpDownDPIAdvK.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // CustomCheckBoxDPIAdvMaxPayload
            // 
            CustomCheckBoxDPIAdvMaxPayload.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvMaxPayload.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvMaxPayload.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvMaxPayload.Checked = true;
            CustomCheckBoxDPIAdvMaxPayload.CheckState = CheckState.Checked;
            CustomCheckBoxDPIAdvMaxPayload.ForeColor = Color.White;
            CustomCheckBoxDPIAdvMaxPayload.Location = new Point(9, 158);
            CustomCheckBoxDPIAdvMaxPayload.Name = "CustomCheckBoxDPIAdvMaxPayload";
            CustomCheckBoxDPIAdvMaxPayload.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvMaxPayload.Size = new Size(105, 17);
            CustomCheckBoxDPIAdvMaxPayload.TabIndex = 27;
            CustomCheckBoxDPIAdvMaxPayload.Text = "--max-payload";
            CustomCheckBoxDPIAdvMaxPayload.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxDPIAdvN
            // 
            CustomCheckBoxDPIAdvN.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvN.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvN.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvN.ForeColor = Color.White;
            CustomCheckBoxDPIAdvN.Location = new Point(324, 38);
            CustomCheckBoxDPIAdvN.Name = "CustomCheckBoxDPIAdvN";
            CustomCheckBoxDPIAdvN.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvN.Size = new Size(36, 17);
            CustomCheckBoxDPIAdvN.TabIndex = 8;
            CustomCheckBoxDPIAdvN.Text = "-n";
            CustomCheckBoxDPIAdvN.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxDPIAdvReverseFrag
            // 
            CustomCheckBoxDPIAdvReverseFrag.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvReverseFrag.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvReverseFrag.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvReverseFrag.ForeColor = Color.White;
            CustomCheckBoxDPIAdvReverseFrag.Location = new Point(474, 128);
            CustomCheckBoxDPIAdvReverseFrag.Name = "CustomCheckBoxDPIAdvReverseFrag";
            CustomCheckBoxDPIAdvReverseFrag.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvReverseFrag.Size = new Size(100, 17);
            CustomCheckBoxDPIAdvReverseFrag.TabIndex = 26;
            CustomCheckBoxDPIAdvReverseFrag.Text = "--reverse-frag";
            CustomCheckBoxDPIAdvReverseFrag.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxDPIAdvE
            // 
            CustomCheckBoxDPIAdvE.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvE.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvE.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvE.Checked = true;
            CustomCheckBoxDPIAdvE.CheckState = CheckState.Checked;
            CustomCheckBoxDPIAdvE.ForeColor = Color.White;
            CustomCheckBoxDPIAdvE.Location = new Point(474, 38);
            CustomCheckBoxDPIAdvE.Name = "CustomCheckBoxDPIAdvE";
            CustomCheckBoxDPIAdvE.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvE.Size = new Size(35, 17);
            CustomCheckBoxDPIAdvE.TabIndex = 9;
            CustomCheckBoxDPIAdvE.Text = "-e";
            CustomCheckBoxDPIAdvE.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxDPIAdvNativeFrag
            // 
            CustomCheckBoxDPIAdvNativeFrag.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvNativeFrag.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvNativeFrag.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvNativeFrag.Checked = true;
            CustomCheckBoxDPIAdvNativeFrag.CheckState = CheckState.Checked;
            CustomCheckBoxDPIAdvNativeFrag.ForeColor = Color.White;
            CustomCheckBoxDPIAdvNativeFrag.Location = new Point(324, 128);
            CustomCheckBoxDPIAdvNativeFrag.Name = "CustomCheckBoxDPIAdvNativeFrag";
            CustomCheckBoxDPIAdvNativeFrag.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvNativeFrag.Size = new Size(93, 17);
            CustomCheckBoxDPIAdvNativeFrag.TabIndex = 25;
            CustomCheckBoxDPIAdvNativeFrag.Text = "--native-frag";
            CustomCheckBoxDPIAdvNativeFrag.UseVisualStyleBackColor = false;
            // 
            // CustomNumericUpDownDPIAdvE
            // 
            CustomNumericUpDownDPIAdvE.BackColor = Color.DimGray;
            CustomNumericUpDownDPIAdvE.BorderColor = Color.Blue;
            CustomNumericUpDownDPIAdvE.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownDPIAdvE.Location = new Point(510, 36);
            CustomNumericUpDownDPIAdvE.Maximum = new decimal(new int[] { 70000, 0, 0, 0 });
            CustomNumericUpDownDPIAdvE.Name = "CustomNumericUpDownDPIAdvE";
            CustomNumericUpDownDPIAdvE.RoundedCorners = 5;
            CustomNumericUpDownDPIAdvE.Size = new Size(53, 23);
            CustomNumericUpDownDPIAdvE.TabIndex = 10;
            CustomNumericUpDownDPIAdvE.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // CustomCheckBoxDPIAdvWrongSeq
            // 
            CustomCheckBoxDPIAdvWrongSeq.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvWrongSeq.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvWrongSeq.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvWrongSeq.ForeColor = Color.White;
            CustomCheckBoxDPIAdvWrongSeq.Location = new Point(169, 128);
            CustomCheckBoxDPIAdvWrongSeq.Name = "CustomCheckBoxDPIAdvWrongSeq";
            CustomCheckBoxDPIAdvWrongSeq.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvWrongSeq.Size = new Size(93, 17);
            CustomCheckBoxDPIAdvWrongSeq.TabIndex = 24;
            CustomCheckBoxDPIAdvWrongSeq.Text = "--wrong-seq";
            CustomCheckBoxDPIAdvWrongSeq.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxDPIAdvA
            // 
            CustomCheckBoxDPIAdvA.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvA.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvA.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvA.ForeColor = Color.White;
            CustomCheckBoxDPIAdvA.Location = new Point(9, 68);
            CustomCheckBoxDPIAdvA.Name = "CustomCheckBoxDPIAdvA";
            CustomCheckBoxDPIAdvA.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvA.Size = new Size(35, 17);
            CustomCheckBoxDPIAdvA.TabIndex = 11;
            CustomCheckBoxDPIAdvA.Text = "-a";
            CustomCheckBoxDPIAdvA.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxDPIAdvWrongChksum
            // 
            CustomCheckBoxDPIAdvWrongChksum.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvWrongChksum.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvWrongChksum.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvWrongChksum.ForeColor = Color.White;
            CustomCheckBoxDPIAdvWrongChksum.Location = new Point(9, 128);
            CustomCheckBoxDPIAdvWrongChksum.Name = "CustomCheckBoxDPIAdvWrongChksum";
            CustomCheckBoxDPIAdvWrongChksum.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvWrongChksum.Size = new Size(115, 17);
            CustomCheckBoxDPIAdvWrongChksum.TabIndex = 23;
            CustomCheckBoxDPIAdvWrongChksum.Text = "--wrong-chksum";
            CustomCheckBoxDPIAdvWrongChksum.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxDPIAdvW
            // 
            CustomCheckBoxDPIAdvW.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvW.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvW.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvW.Checked = true;
            CustomCheckBoxDPIAdvW.CheckState = CheckState.Checked;
            CustomCheckBoxDPIAdvW.ForeColor = Color.White;
            CustomCheckBoxDPIAdvW.Location = new Point(169, 68);
            CustomCheckBoxDPIAdvW.Name = "CustomCheckBoxDPIAdvW";
            CustomCheckBoxDPIAdvW.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvW.Size = new Size(38, 17);
            CustomCheckBoxDPIAdvW.TabIndex = 12;
            CustomCheckBoxDPIAdvW.Text = "-w";
            CustomCheckBoxDPIAdvW.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxDPIAdvMinTTL
            // 
            CustomCheckBoxDPIAdvMinTTL.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvMinTTL.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvMinTTL.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvMinTTL.ForeColor = Color.White;
            CustomCheckBoxDPIAdvMinTTL.Location = new Point(474, 98);
            CustomCheckBoxDPIAdvMinTTL.Name = "CustomCheckBoxDPIAdvMinTTL";
            CustomCheckBoxDPIAdvMinTTL.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvMinTTL.Size = new Size(71, 17);
            CustomCheckBoxDPIAdvMinTTL.TabIndex = 21;
            CustomCheckBoxDPIAdvMinTTL.Text = "--min-ttl";
            CustomCheckBoxDPIAdvMinTTL.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxDPIAdvPort
            // 
            CustomCheckBoxDPIAdvPort.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvPort.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvPort.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvPort.ForeColor = Color.White;
            CustomCheckBoxDPIAdvPort.Location = new Point(324, 68);
            CustomCheckBoxDPIAdvPort.Name = "CustomCheckBoxDPIAdvPort";
            CustomCheckBoxDPIAdvPort.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvPort.Size = new Size(57, 17);
            CustomCheckBoxDPIAdvPort.TabIndex = 13;
            CustomCheckBoxDPIAdvPort.Text = "--port";
            CustomCheckBoxDPIAdvPort.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxDPIAdvAutoTTL
            // 
            CustomCheckBoxDPIAdvAutoTTL.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvAutoTTL.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvAutoTTL.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvAutoTTL.ForeColor = Color.White;
            CustomCheckBoxDPIAdvAutoTTL.Location = new Point(324, 98);
            CustomCheckBoxDPIAdvAutoTTL.Name = "CustomCheckBoxDPIAdvAutoTTL";
            CustomCheckBoxDPIAdvAutoTTL.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvAutoTTL.Size = new Size(75, 17);
            CustomCheckBoxDPIAdvAutoTTL.TabIndex = 20;
            CustomCheckBoxDPIAdvAutoTTL.Text = "--auto-ttl";
            CustomCheckBoxDPIAdvAutoTTL.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxDPIAdvIpId
            // 
            CustomCheckBoxDPIAdvIpId.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvIpId.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvIpId.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvIpId.ForeColor = Color.White;
            CustomCheckBoxDPIAdvIpId.Location = new Point(474, 68);
            CustomCheckBoxDPIAdvIpId.Name = "CustomCheckBoxDPIAdvIpId";
            CustomCheckBoxDPIAdvIpId.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvIpId.Size = new Size(59, 17);
            CustomCheckBoxDPIAdvIpId.TabIndex = 15;
            CustomCheckBoxDPIAdvIpId.Text = "--ip-id";
            CustomCheckBoxDPIAdvIpId.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxDPIAdvSetTTL
            // 
            CustomCheckBoxDPIAdvSetTTL.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvSetTTL.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvSetTTL.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvSetTTL.ForeColor = Color.White;
            CustomCheckBoxDPIAdvSetTTL.Location = new Point(169, 98);
            CustomCheckBoxDPIAdvSetTTL.Name = "CustomCheckBoxDPIAdvSetTTL";
            CustomCheckBoxDPIAdvSetTTL.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvSetTTL.Size = new Size(66, 17);
            CustomCheckBoxDPIAdvSetTTL.TabIndex = 18;
            CustomCheckBoxDPIAdvSetTTL.Text = "--set-ttl";
            CustomCheckBoxDPIAdvSetTTL.UseVisualStyleBackColor = false;
            // 
            // CustomTextBoxDPIAdvIpId
            // 
            CustomTextBoxDPIAdvIpId.AcceptsReturn = false;
            CustomTextBoxDPIAdvIpId.AcceptsTab = false;
            CustomTextBoxDPIAdvIpId.BackColor = Color.DimGray;
            CustomTextBoxDPIAdvIpId.Border = true;
            CustomTextBoxDPIAdvIpId.BorderColor = Color.Blue;
            CustomTextBoxDPIAdvIpId.BorderSize = 1;
            CustomTextBoxDPIAdvIpId.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxDPIAdvIpId.Font = new Font("Segoe UI", 9F);
            CustomTextBoxDPIAdvIpId.ForeColor = Color.White;
            CustomTextBoxDPIAdvIpId.HideSelection = true;
            CustomTextBoxDPIAdvIpId.Location = new Point(533, 66);
            CustomTextBoxDPIAdvIpId.MaxLength = 32767;
            CustomTextBoxDPIAdvIpId.Multiline = false;
            CustomTextBoxDPIAdvIpId.Name = "CustomTextBoxDPIAdvIpId";
            CustomTextBoxDPIAdvIpId.ReadOnly = false;
            CustomTextBoxDPIAdvIpId.RoundedCorners = 0;
            CustomTextBoxDPIAdvIpId.ScrollBars = ScrollBars.None;
            CustomTextBoxDPIAdvIpId.ShortcutsEnabled = true;
            CustomTextBoxDPIAdvIpId.Size = new Size(70, 23);
            CustomTextBoxDPIAdvIpId.TabIndex = 0;
            CustomTextBoxDPIAdvIpId.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxDPIAdvIpId.Texts = "";
            CustomTextBoxDPIAdvIpId.UnderlinedStyle = true;
            CustomTextBoxDPIAdvIpId.UsePasswordChar = false;
            CustomTextBoxDPIAdvIpId.WordWrap = true;
            // 
            // CustomCheckBoxDPIAdvAllowNoSNI
            // 
            CustomCheckBoxDPIAdvAllowNoSNI.BackColor = Color.DimGray;
            CustomCheckBoxDPIAdvAllowNoSNI.BorderColor = Color.Blue;
            CustomCheckBoxDPIAdvAllowNoSNI.CheckColor = Color.Blue;
            CustomCheckBoxDPIAdvAllowNoSNI.ForeColor = Color.White;
            CustomCheckBoxDPIAdvAllowNoSNI.Location = new Point(9, 98);
            CustomCheckBoxDPIAdvAllowNoSNI.Name = "CustomCheckBoxDPIAdvAllowNoSNI";
            CustomCheckBoxDPIAdvAllowNoSNI.SelectionColor = Color.LightBlue;
            CustomCheckBoxDPIAdvAllowNoSNI.Size = new Size(102, 17);
            CustomCheckBoxDPIAdvAllowNoSNI.TabIndex = 17;
            CustomCheckBoxDPIAdvAllowNoSNI.Text = "--allow-no-sni";
            CustomCheckBoxDPIAdvAllowNoSNI.UseVisualStyleBackColor = false;
            // 
            // CustomButtonDPIAdvActivate
            // 
            CustomButtonDPIAdvActivate.BorderColor = Color.Blue;
            CustomButtonDPIAdvActivate.FlatStyle = FlatStyle.Flat;
            CustomButtonDPIAdvActivate.Location = new Point(3, 3);
            CustomButtonDPIAdvActivate.Name = "CustomButtonDPIAdvActivate";
            CustomButtonDPIAdvActivate.RoundedCorners = 5;
            CustomButtonDPIAdvActivate.SelectionColor = Color.LightBlue;
            CustomButtonDPIAdvActivate.Size = new Size(73, 27);
            CustomButtonDPIAdvActivate.TabIndex = 31;
            CustomButtonDPIAdvActivate.Text = "Reactivate";
            CustomButtonDPIAdvActivate.UseVisualStyleBackColor = true;
            CustomButtonDPIAdvActivate.Click += CustomButtonDPIAdvActivate_Click;
            // 
            // CustomButtonDPIAdvDeactivate
            // 
            CustomButtonDPIAdvDeactivate.BorderColor = Color.Blue;
            CustomButtonDPIAdvDeactivate.FlatStyle = FlatStyle.Flat;
            CustomButtonDPIAdvDeactivate.Location = new Point(82, 3);
            CustomButtonDPIAdvDeactivate.Name = "CustomButtonDPIAdvDeactivate";
            CustomButtonDPIAdvDeactivate.RoundedCorners = 5;
            CustomButtonDPIAdvDeactivate.SelectionColor = Color.LightBlue;
            CustomButtonDPIAdvDeactivate.Size = new Size(74, 27);
            CustomButtonDPIAdvDeactivate.TabIndex = 32;
            CustomButtonDPIAdvDeactivate.Text = "Deactivate";
            CustomButtonDPIAdvDeactivate.UseVisualStyleBackColor = true;
            CustomButtonDPIAdvDeactivate.Click += CustomButtonDPIAdvDeactivate_Click;
            // 
            // TabPageTools
            // 
            TabPageTools.AutoScroll = true;
            TabPageTools.BackColor = Color.Transparent;
            TabPageTools.Controls.Add(CustomButtonBenchmark);
            TabPageTools.Controls.Add(CustomButtonToolsFlushDns);
            TabPageTools.Controls.Add(CustomButtonToolsDnsScanner);
            TabPageTools.Controls.Add(CustomButtonToolsStampGenerator);
            TabPageTools.Controls.Add(CustomButtonToolsStampReader);
            TabPageTools.Controls.Add(CustomButtonToolsDnsLookup);
            TabPageTools.Controls.Add(CustomButtonToolsIpScanner);
            TabPageTools.Location = new Point(4, 25);
            TabPageTools.Name = "TabPageTools";
            TabPageTools.Size = new Size(771, 371);
            TabPageTools.TabIndex = 3;
            TabPageTools.Tag = 1;
            TabPageTools.Text = "Tools";
            TabPageTools.Visible = false;
            // 
            // CustomButtonBenchmark
            // 
            CustomButtonBenchmark.BorderColor = Color.Blue;
            CustomButtonBenchmark.FlatStyle = FlatStyle.Flat;
            CustomButtonBenchmark.Location = new Point(200, 100);
            CustomButtonBenchmark.Name = "CustomButtonBenchmark";
            CustomButtonBenchmark.RoundedCorners = 5;
            CustomButtonBenchmark.SelectionColor = Color.LightBlue;
            CustomButtonBenchmark.Size = new Size(115, 27);
            CustomButtonBenchmark.TabIndex = 21;
            CustomButtonBenchmark.Text = "Benchmark";
            CustomButtonBenchmark.UseVisualStyleBackColor = true;
            CustomButtonBenchmark.Click += CustomButtonBenchmark_Click;
            // 
            // CustomButtonToolsFlushDns
            // 
            CustomButtonToolsFlushDns.BorderColor = Color.Blue;
            CustomButtonToolsFlushDns.FlatStyle = FlatStyle.Flat;
            CustomButtonToolsFlushDns.Location = new Point(200, 50);
            CustomButtonToolsFlushDns.Name = "CustomButtonToolsFlushDns";
            CustomButtonToolsFlushDns.RoundedCorners = 5;
            CustomButtonToolsFlushDns.SelectionColor = Color.LightBlue;
            CustomButtonToolsFlushDns.Size = new Size(115, 27);
            CustomButtonToolsFlushDns.TabIndex = 5;
            CustomButtonToolsFlushDns.Text = "Flush DNS";
            CustomButtonToolsFlushDns.UseVisualStyleBackColor = true;
            CustomButtonToolsFlushDns.Click += CustomButtonToolsFlushDns_Click;
            // 
            // CustomButtonToolsDnsScanner
            // 
            CustomButtonToolsDnsScanner.BorderColor = Color.Blue;
            CustomButtonToolsDnsScanner.FlatStyle = FlatStyle.Flat;
            CustomButtonToolsDnsScanner.Location = new Point(50, 50);
            CustomButtonToolsDnsScanner.Name = "CustomButtonToolsDnsScanner";
            CustomButtonToolsDnsScanner.RoundedCorners = 5;
            CustomButtonToolsDnsScanner.SelectionColor = Color.LightBlue;
            CustomButtonToolsDnsScanner.Size = new Size(115, 27);
            CustomButtonToolsDnsScanner.TabIndex = 4;
            CustomButtonToolsDnsScanner.Text = "DNS Scanner";
            CustomButtonToolsDnsScanner.UseVisualStyleBackColor = true;
            CustomButtonToolsDnsScanner.Click += CustomButtonToolsDnsScanner_Click;
            // 
            // CustomButtonToolsStampGenerator
            // 
            CustomButtonToolsStampGenerator.BorderColor = Color.Blue;
            CustomButtonToolsStampGenerator.FlatStyle = FlatStyle.Flat;
            CustomButtonToolsStampGenerator.Location = new Point(50, 200);
            CustomButtonToolsStampGenerator.Name = "CustomButtonToolsStampGenerator";
            CustomButtonToolsStampGenerator.RoundedCorners = 5;
            CustomButtonToolsStampGenerator.SelectionColor = Color.LightBlue;
            CustomButtonToolsStampGenerator.Size = new Size(115, 27);
            CustomButtonToolsStampGenerator.TabIndex = 3;
            CustomButtonToolsStampGenerator.Text = "Stamp Generator";
            CustomButtonToolsStampGenerator.UseVisualStyleBackColor = true;
            CustomButtonToolsStampGenerator.Click += CustomButtonToolsStampGenerator_Click;
            // 
            // CustomButtonToolsStampReader
            // 
            CustomButtonToolsStampReader.BorderColor = Color.Blue;
            CustomButtonToolsStampReader.FlatStyle = FlatStyle.Flat;
            CustomButtonToolsStampReader.Location = new Point(50, 150);
            CustomButtonToolsStampReader.Name = "CustomButtonToolsStampReader";
            CustomButtonToolsStampReader.RoundedCorners = 5;
            CustomButtonToolsStampReader.SelectionColor = Color.LightBlue;
            CustomButtonToolsStampReader.Size = new Size(115, 27);
            CustomButtonToolsStampReader.TabIndex = 2;
            CustomButtonToolsStampReader.Text = "Stamp Reader";
            CustomButtonToolsStampReader.UseVisualStyleBackColor = true;
            CustomButtonToolsStampReader.Click += CustomButtonToolsStampReader_Click;
            // 
            // CustomButtonToolsDnsLookup
            // 
            CustomButtonToolsDnsLookup.BorderColor = Color.Blue;
            CustomButtonToolsDnsLookup.FlatStyle = FlatStyle.Flat;
            CustomButtonToolsDnsLookup.Location = new Point(50, 100);
            CustomButtonToolsDnsLookup.Name = "CustomButtonToolsDnsLookup";
            CustomButtonToolsDnsLookup.RoundedCorners = 5;
            CustomButtonToolsDnsLookup.SelectionColor = Color.LightBlue;
            CustomButtonToolsDnsLookup.Size = new Size(115, 27);
            CustomButtonToolsDnsLookup.TabIndex = 1;
            CustomButtonToolsDnsLookup.Text = "DNS Lookup";
            CustomButtonToolsDnsLookup.UseVisualStyleBackColor = true;
            CustomButtonToolsDnsLookup.Click += CustomButtonToolsDnsLookup_Click;
            // 
            // CustomButtonToolsIpScanner
            // 
            CustomButtonToolsIpScanner.BorderColor = Color.Blue;
            CustomButtonToolsIpScanner.FlatStyle = FlatStyle.Flat;
            CustomButtonToolsIpScanner.Location = new Point(50, 250);
            CustomButtonToolsIpScanner.Name = "CustomButtonToolsIpScanner";
            CustomButtonToolsIpScanner.RoundedCorners = 5;
            CustomButtonToolsIpScanner.SelectionColor = Color.LightBlue;
            CustomButtonToolsIpScanner.Size = new Size(115, 27);
            CustomButtonToolsIpScanner.TabIndex = 0;
            CustomButtonToolsIpScanner.Text = "Clean IP Scanner";
            CustomButtonToolsIpScanner.UseVisualStyleBackColor = true;
            CustomButtonToolsIpScanner.Click += CustomButtonToolsIpScanner_Click;
            // 
            // TabPageSettings
            // 
            TabPageSettings.BackColor = Color.Transparent;
            TabPageSettings.Controls.Add(SplitContainerSettings);
            TabPageSettings.Location = new Point(4, 25);
            TabPageSettings.Name = "TabPageSettings";
            TabPageSettings.Padding = new Padding(3);
            TabPageSettings.Size = new Size(771, 371);
            TabPageSettings.TabIndex = 1;
            TabPageSettings.Tag = 2;
            TabPageSettings.Text = "Settings";
            TabPageSettings.Visible = false;
            // 
            // SplitContainerSettings
            // 
            SplitContainerSettings.Dock = DockStyle.Fill;
            SplitContainerSettings.Location = new Point(3, 3);
            SplitContainerSettings.Name = "SplitContainerSettings";
            // 
            // SplitContainerSettings.Panel1
            // 
            SplitContainerSettings.Panel1.Controls.Add(CustomListBoxSettingsMenu);
            SplitContainerSettings.Panel1MinSize = 140;
            // 
            // SplitContainerSettings.Panel2
            // 
            SplitContainerSettings.Panel2.Controls.Add(CustomTabControlSettings);
            SplitContainerSettings.Panel2MinSize = 600;
            SplitContainerSettings.Size = new Size(765, 365);
            SplitContainerSettings.SplitterDistance = 140;
            SplitContainerSettings.TabIndex = 11;
            // 
            // CustomListBoxSettingsMenu
            // 
            CustomListBoxSettingsMenu.BackColor = Color.DimGray;
            CustomListBoxSettingsMenu.Border = false;
            CustomListBoxSettingsMenu.BorderColor = Color.Blue;
            CustomListBoxSettingsMenu.Dock = DockStyle.Fill;
            CustomListBoxSettingsMenu.DrawMode = DrawMode.OwnerDrawVariable;
            CustomListBoxSettingsMenu.Font = new Font("Segoe UI", 9F);
            CustomListBoxSettingsMenu.ForeColor = Color.White;
            CustomListBoxSettingsMenu.FormattingEnabled = true;
            CustomListBoxSettingsMenu.IntegralHeight = false;
            CustomListBoxSettingsMenu.ItemBorder = true;
            CustomListBoxSettingsMenu.ItemHeight = 30;
            CustomListBoxSettingsMenu.Items.AddRange(new object[] { "Working Mode", "Check", "Quick Connect", "Connect", "Set/Unset DNS", "Share", "Fake Proxy", "Rules", "Geo Assets", "CPU", "Others" });
            CustomListBoxSettingsMenu.Location = new Point(0, 0);
            CustomListBoxSettingsMenu.Name = "CustomListBoxSettingsMenu";
            CustomListBoxSettingsMenu.RightToLeft = RightToLeft.No;
            CustomListBoxSettingsMenu.RoundedCorners = 5;
            CustomListBoxSettingsMenu.SelectionColor = Color.DimGray;
            CustomListBoxSettingsMenu.Size = new Size(140, 365);
            CustomListBoxSettingsMenu.TabIndex = 10;
            CustomListBoxSettingsMenu.TextAlign = ContentAlignment.MiddleCenter;
            CustomListBoxSettingsMenu.SelectedIndexChanged += CustomListBoxSettingsMenu_SelectedIndexChanged;
            // 
            // CustomTabControlSettings
            // 
            CustomTabControlSettings.Alignment = TabAlignment.Left;
            CustomTabControlSettings.BorderColor = Color.Blue;
            CustomTabControlSettings.Controls.Add(TabPageSettingsWorkingMode);
            CustomTabControlSettings.Controls.Add(TabPageSettingsCheck);
            CustomTabControlSettings.Controls.Add(TabPageSettingsQuickConnect);
            CustomTabControlSettings.Controls.Add(TabPageSettingsConnect);
            CustomTabControlSettings.Controls.Add(TabPageSettingsSetUnsetDNS);
            CustomTabControlSettings.Controls.Add(TabPageSettingsShare);
            CustomTabControlSettings.Controls.Add(TabPageSettingsFakeProxy);
            CustomTabControlSettings.Controls.Add(TabPageSettingsRules);
            CustomTabControlSettings.Controls.Add(TabPageSettingsGeoAssets);
            CustomTabControlSettings.Controls.Add(TabPageSettingsCPU);
            CustomTabControlSettings.Controls.Add(TabPageSettingsOthers);
            CustomTabControlSettings.Dock = DockStyle.Fill;
            CustomTabControlSettings.HideTabHeader = false;
            CustomTabControlSettings.ItemSize = new Size(30, 95);
            CustomTabControlSettings.Location = new Point(0, 0);
            CustomTabControlSettings.Margin = new Padding(0);
            CustomTabControlSettings.Multiline = true;
            CustomTabControlSettings.Name = "CustomTabControlSettings";
            CustomTabControlSettings.RoundedCorners = 5;
            CustomTabControlSettings.SelectedIndex = 0;
            CustomTabControlSettings.Size = new Size(621, 365);
            CustomTabControlSettings.SizeMode = TabSizeMode.Fixed;
            CustomTabControlSettings.TabIndex = 10;
            CustomTabControlSettings.Tag = 0;
            CustomTabControlSettings.SelectedIndexChanged += CustomTabControlSettings_SelectedIndexChanged;
            // 
            // TabPageSettingsWorkingMode
            // 
            TabPageSettingsWorkingMode.AutoScroll = true;
            TabPageSettingsWorkingMode.BackColor = Color.Transparent;
            TabPageSettingsWorkingMode.Controls.Add(CustomNumericUpDownSettingWorkingModeSetDohPort);
            TabPageSettingsWorkingMode.Controls.Add(CustomLabelSettingWorkingModeSetDohPort);
            TabPageSettingsWorkingMode.Controls.Add(CustomButtonSettingUninstallCertificate);
            TabPageSettingsWorkingMode.Controls.Add(CustomRadioButtonSettingWorkingModeDNSandDoH);
            TabPageSettingsWorkingMode.Controls.Add(CustomRadioButtonSettingWorkingModeDNS);
            TabPageSettingsWorkingMode.Controls.Add(CustomLabelSettingInfoWorkingMode1);
            TabPageSettingsWorkingMode.Location = new Point(99, 4);
            TabPageSettingsWorkingMode.Name = "TabPageSettingsWorkingMode";
            TabPageSettingsWorkingMode.Padding = new Padding(3);
            TabPageSettingsWorkingMode.Size = new Size(518, 357);
            TabPageSettingsWorkingMode.TabIndex = 0;
            TabPageSettingsWorkingMode.Tag = 0;
            TabPageSettingsWorkingMode.Text = "Working mode";
            TabPageSettingsWorkingMode.Visible = false;
            // 
            // CustomNumericUpDownSettingWorkingModeSetDohPort
            // 
            CustomNumericUpDownSettingWorkingModeSetDohPort.BackColor = Color.DimGray;
            CustomNumericUpDownSettingWorkingModeSetDohPort.BorderColor = Color.Blue;
            CustomNumericUpDownSettingWorkingModeSetDohPort.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownSettingWorkingModeSetDohPort.Location = new Point(179, 178);
            CustomNumericUpDownSettingWorkingModeSetDohPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            CustomNumericUpDownSettingWorkingModeSetDohPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownSettingWorkingModeSetDohPort.Name = "CustomNumericUpDownSettingWorkingModeSetDohPort";
            CustomNumericUpDownSettingWorkingModeSetDohPort.RoundedCorners = 5;
            CustomNumericUpDownSettingWorkingModeSetDohPort.Size = new Size(53, 23);
            CustomNumericUpDownSettingWorkingModeSetDohPort.TabIndex = 6;
            CustomNumericUpDownSettingWorkingModeSetDohPort.Value = new decimal(new int[] { 443, 0, 0, 0 });
            // 
            // CustomLabelSettingWorkingModeSetDohPort
            // 
            CustomLabelSettingWorkingModeSetDohPort.AutoSize = true;
            CustomLabelSettingWorkingModeSetDohPort.BackColor = Color.DimGray;
            CustomLabelSettingWorkingModeSetDohPort.Border = false;
            CustomLabelSettingWorkingModeSetDohPort.BorderColor = Color.Blue;
            CustomLabelSettingWorkingModeSetDohPort.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingWorkingModeSetDohPort.ForeColor = Color.White;
            CustomLabelSettingWorkingModeSetDohPort.Location = new Point(65, 180);
            CustomLabelSettingWorkingModeSetDohPort.Name = "CustomLabelSettingWorkingModeSetDohPort";
            CustomLabelSettingWorkingModeSetDohPort.RoundedCorners = 0;
            CustomLabelSettingWorkingModeSetDohPort.Size = new Size(108, 17);
            CustomLabelSettingWorkingModeSetDohPort.TabIndex = 5;
            CustomLabelSettingWorkingModeSetDohPort.Text = "Set local DoH port:";
            // 
            // CustomButtonSettingUninstallCertificate
            // 
            CustomButtonSettingUninstallCertificate.BorderColor = Color.Blue;
            CustomButtonSettingUninstallCertificate.FlatStyle = FlatStyle.Flat;
            CustomButtonSettingUninstallCertificate.Location = new Point(50, 220);
            CustomButtonSettingUninstallCertificate.Name = "CustomButtonSettingUninstallCertificate";
            CustomButtonSettingUninstallCertificate.RoundedCorners = 5;
            CustomButtonSettingUninstallCertificate.SelectionColor = Color.LightBlue;
            CustomButtonSettingUninstallCertificate.Size = new Size(120, 27);
            CustomButtonSettingUninstallCertificate.TabIndex = 4;
            CustomButtonSettingUninstallCertificate.Text = "Uninstall certificate";
            CustomButtonSettingUninstallCertificate.UseVisualStyleBackColor = true;
            CustomButtonSettingUninstallCertificate.Click += CustomButtonSettingUninstallCertificate_Click;
            // 
            // CustomRadioButtonSettingWorkingModeDNSandDoH
            // 
            CustomRadioButtonSettingWorkingModeDNSandDoH.BackColor = Color.DimGray;
            CustomRadioButtonSettingWorkingModeDNSandDoH.BorderColor = Color.Blue;
            CustomRadioButtonSettingWorkingModeDNSandDoH.CheckColor = Color.Blue;
            CustomRadioButtonSettingWorkingModeDNSandDoH.ForeColor = Color.White;
            CustomRadioButtonSettingWorkingModeDNSandDoH.Location = new Point(50, 145);
            CustomRadioButtonSettingWorkingModeDNSandDoH.Name = "CustomRadioButtonSettingWorkingModeDNSandDoH";
            CustomRadioButtonSettingWorkingModeDNSandDoH.SelectionColor = Color.LightBlue;
            CustomRadioButtonSettingWorkingModeDNSandDoH.Size = new Size(238, 17);
            CustomRadioButtonSettingWorkingModeDNSandDoH.TabIndex = 2;
            CustomRadioButtonSettingWorkingModeDNSandDoH.Text = "Legacy DNS + DNS-Over-HTTPS Server";
            CustomRadioButtonSettingWorkingModeDNSandDoH.UseVisualStyleBackColor = false;
            // 
            // CustomRadioButtonSettingWorkingModeDNS
            // 
            CustomRadioButtonSettingWorkingModeDNS.BackColor = Color.DimGray;
            CustomRadioButtonSettingWorkingModeDNS.BorderColor = Color.Blue;
            CustomRadioButtonSettingWorkingModeDNS.CheckColor = Color.Blue;
            CustomRadioButtonSettingWorkingModeDNS.Checked = true;
            CustomRadioButtonSettingWorkingModeDNS.ForeColor = Color.White;
            CustomRadioButtonSettingWorkingModeDNS.Location = new Point(50, 100);
            CustomRadioButtonSettingWorkingModeDNS.Name = "CustomRadioButtonSettingWorkingModeDNS";
            CustomRadioButtonSettingWorkingModeDNS.SelectionColor = Color.LightBlue;
            CustomRadioButtonSettingWorkingModeDNS.Size = new Size(127, 17);
            CustomRadioButtonSettingWorkingModeDNS.TabIndex = 1;
            CustomRadioButtonSettingWorkingModeDNS.TabStop = true;
            CustomRadioButtonSettingWorkingModeDNS.Text = "Legacy DNS Server";
            CustomRadioButtonSettingWorkingModeDNS.UseVisualStyleBackColor = false;
            CustomRadioButtonSettingWorkingModeDNS.CheckedChanged += SecureDNSClient_CheckedChanged;
            // 
            // CustomLabelSettingInfoWorkingMode1
            // 
            CustomLabelSettingInfoWorkingMode1.AutoSize = true;
            CustomLabelSettingInfoWorkingMode1.BackColor = Color.DimGray;
            CustomLabelSettingInfoWorkingMode1.Border = false;
            CustomLabelSettingInfoWorkingMode1.BorderColor = Color.Blue;
            CustomLabelSettingInfoWorkingMode1.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingInfoWorkingMode1.ForeColor = Color.White;
            CustomLabelSettingInfoWorkingMode1.Location = new Point(50, 35);
            CustomLabelSettingInfoWorkingMode1.Name = "CustomLabelSettingInfoWorkingMode1";
            CustomLabelSettingInfoWorkingMode1.RoundedCorners = 0;
            CustomLabelSettingInfoWorkingMode1.Size = new Size(398, 32);
            CustomLabelSettingInfoWorkingMode1.TabIndex = 0;
            CustomLabelSettingInfoWorkingMode1.Text = "Legacy DNS Server: You can set and unset DNS easily.\r\nDNS Over HTTPS Server: You need to install certificate and set it manually.";
            // 
            // TabPageSettingsCheck
            // 
            TabPageSettingsCheck.AutoScroll = true;
            TabPageSettingsCheck.BackColor = Color.Transparent;
            TabPageSettingsCheck.Controls.Add(CustomCheckBoxSettingCheckClearWorkingServers);
            TabPageSettingsCheck.Controls.Add(CustomGroupBoxSettingCheckDnsProtocol);
            TabPageSettingsCheck.Controls.Add(CustomGroupBoxSettingCheckSDNS);
            TabPageSettingsCheck.Controls.Add(CustomTextBoxSettingCheckDPIHost);
            TabPageSettingsCheck.Controls.Add(CustomLabelSettingCheckDPIInfo);
            TabPageSettingsCheck.Controls.Add(CustomLabelSettingCheckTimeout);
            TabPageSettingsCheck.Controls.Add(CustomNumericUpDownSettingCheckTimeout);
            TabPageSettingsCheck.Location = new Point(99, 4);
            TabPageSettingsCheck.Name = "TabPageSettingsCheck";
            TabPageSettingsCheck.Padding = new Padding(3);
            TabPageSettingsCheck.Size = new Size(518, 357);
            TabPageSettingsCheck.TabIndex = 3;
            TabPageSettingsCheck.Tag = 1;
            TabPageSettingsCheck.Text = "Check";
            TabPageSettingsCheck.Visible = false;
            // 
            // CustomCheckBoxSettingCheckClearWorkingServers
            // 
            CustomCheckBoxSettingCheckClearWorkingServers.AutoSize = true;
            CustomCheckBoxSettingCheckClearWorkingServers.BackColor = Color.DimGray;
            CustomCheckBoxSettingCheckClearWorkingServers.BorderColor = Color.Blue;
            CustomCheckBoxSettingCheckClearWorkingServers.CheckColor = Color.Blue;
            CustomCheckBoxSettingCheckClearWorkingServers.Checked = true;
            CustomCheckBoxSettingCheckClearWorkingServers.CheckState = CheckState.Checked;
            CustomCheckBoxSettingCheckClearWorkingServers.ForeColor = Color.White;
            CustomCheckBoxSettingCheckClearWorkingServers.Location = new Point(19, 62);
            CustomCheckBoxSettingCheckClearWorkingServers.Name = "CustomCheckBoxSettingCheckClearWorkingServers";
            CustomCheckBoxSettingCheckClearWorkingServers.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingCheckClearWorkingServers.Size = new Size(345, 19);
            CustomCheckBoxSettingCheckClearWorkingServers.TabIndex = 15;
            CustomCheckBoxSettingCheckClearWorkingServers.Text = "Clear Working Servers on new check (Except Quick Connect)";
            CustomCheckBoxSettingCheckClearWorkingServers.UseVisualStyleBackColor = false;
            // 
            // CustomGroupBoxSettingCheckDnsProtocol
            // 
            CustomGroupBoxSettingCheckDnsProtocol.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomGroupBoxSettingCheckDnsProtocol.BorderColor = Color.Blue;
            CustomGroupBoxSettingCheckDnsProtocol.Controls.Add(CustomCheckBoxSettingProtocolPlainDNS);
            CustomGroupBoxSettingCheckDnsProtocol.Controls.Add(CustomCheckBoxSettingProtocolDoQ);
            CustomGroupBoxSettingCheckDnsProtocol.Controls.Add(CustomCheckBoxSettingProtocolAnonymizedDNSCrypt);
            CustomGroupBoxSettingCheckDnsProtocol.Controls.Add(CustomCheckBoxSettingProtocolDNSCrypt);
            CustomGroupBoxSettingCheckDnsProtocol.Controls.Add(CustomCheckBoxSettingProtocolTLS);
            CustomGroupBoxSettingCheckDnsProtocol.Controls.Add(CustomCheckBoxSettingProtocolDoH);
            CustomGroupBoxSettingCheckDnsProtocol.Location = new Point(4, 139);
            CustomGroupBoxSettingCheckDnsProtocol.Name = "CustomGroupBoxSettingCheckDnsProtocol";
            CustomGroupBoxSettingCheckDnsProtocol.RoundedCorners = 5;
            CustomGroupBoxSettingCheckDnsProtocol.Size = new Size(510, 87);
            CustomGroupBoxSettingCheckDnsProtocol.TabIndex = 13;
            CustomGroupBoxSettingCheckDnsProtocol.TabStop = false;
            CustomGroupBoxSettingCheckDnsProtocol.Text = "Select protocol";
            // 
            // CustomCheckBoxSettingProtocolPlainDNS
            // 
            CustomCheckBoxSettingProtocolPlainDNS.BackColor = Color.DimGray;
            CustomCheckBoxSettingProtocolPlainDNS.BorderColor = Color.Blue;
            CustomCheckBoxSettingProtocolPlainDNS.CheckColor = Color.Blue;
            CustomCheckBoxSettingProtocolPlainDNS.ForeColor = Color.White;
            CustomCheckBoxSettingProtocolPlainDNS.Location = new Point(420, 55);
            CustomCheckBoxSettingProtocolPlainDNS.Name = "CustomCheckBoxSettingProtocolPlainDNS";
            CustomCheckBoxSettingProtocolPlainDNS.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingProtocolPlainDNS.Size = new Size(73, 17);
            CustomCheckBoxSettingProtocolPlainDNS.TabIndex = 5;
            CustomCheckBoxSettingProtocolPlainDNS.Text = "Plain DNS";
            CustomCheckBoxSettingProtocolPlainDNS.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxSettingProtocolDoQ
            // 
            CustomCheckBoxSettingProtocolDoQ.BackColor = Color.DimGray;
            CustomCheckBoxSettingProtocolDoQ.BorderColor = Color.Blue;
            CustomCheckBoxSettingProtocolDoQ.CheckColor = Color.Blue;
            CustomCheckBoxSettingProtocolDoQ.Checked = true;
            CustomCheckBoxSettingProtocolDoQ.CheckState = CheckState.Checked;
            CustomCheckBoxSettingProtocolDoQ.ForeColor = Color.White;
            CustomCheckBoxSettingProtocolDoQ.Location = new Point(230, 55);
            CustomCheckBoxSettingProtocolDoQ.Name = "CustomCheckBoxSettingProtocolDoQ";
            CustomCheckBoxSettingProtocolDoQ.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingProtocolDoQ.Size = new Size(104, 17);
            CustomCheckBoxSettingProtocolDoQ.TabIndex = 4;
            CustomCheckBoxSettingProtocolDoQ.Text = "DNS-Over-Quic";
            CustomCheckBoxSettingProtocolDoQ.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxSettingProtocolAnonymizedDNSCrypt
            // 
            CustomCheckBoxSettingProtocolAnonymizedDNSCrypt.BackColor = Color.DimGray;
            CustomCheckBoxSettingProtocolAnonymizedDNSCrypt.BorderColor = Color.Blue;
            CustomCheckBoxSettingProtocolAnonymizedDNSCrypt.CheckColor = Color.Blue;
            CustomCheckBoxSettingProtocolAnonymizedDNSCrypt.Checked = true;
            CustomCheckBoxSettingProtocolAnonymizedDNSCrypt.CheckState = CheckState.Checked;
            CustomCheckBoxSettingProtocolAnonymizedDNSCrypt.ForeColor = Color.White;
            CustomCheckBoxSettingProtocolAnonymizedDNSCrypt.Location = new Point(15, 55);
            CustomCheckBoxSettingProtocolAnonymizedDNSCrypt.Name = "CustomCheckBoxSettingProtocolAnonymizedDNSCrypt";
            CustomCheckBoxSettingProtocolAnonymizedDNSCrypt.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingProtocolAnonymizedDNSCrypt.Size = new Size(147, 17);
            CustomCheckBoxSettingProtocolAnonymizedDNSCrypt.TabIndex = 3;
            CustomCheckBoxSettingProtocolAnonymizedDNSCrypt.Text = "Anonymized DNSCrypt";
            CustomCheckBoxSettingProtocolAnonymizedDNSCrypt.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxSettingProtocolDNSCrypt
            // 
            CustomCheckBoxSettingProtocolDNSCrypt.BackColor = Color.DimGray;
            CustomCheckBoxSettingProtocolDNSCrypt.BorderColor = Color.Blue;
            CustomCheckBoxSettingProtocolDNSCrypt.CheckColor = Color.Blue;
            CustomCheckBoxSettingProtocolDNSCrypt.Checked = true;
            CustomCheckBoxSettingProtocolDNSCrypt.CheckState = CheckState.Checked;
            CustomCheckBoxSettingProtocolDNSCrypt.ForeColor = Color.White;
            CustomCheckBoxSettingProtocolDNSCrypt.Location = new Point(420, 25);
            CustomCheckBoxSettingProtocolDNSCrypt.Name = "CustomCheckBoxSettingProtocolDNSCrypt";
            CustomCheckBoxSettingProtocolDNSCrypt.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingProtocolDNSCrypt.Size = new Size(73, 17);
            CustomCheckBoxSettingProtocolDNSCrypt.TabIndex = 2;
            CustomCheckBoxSettingProtocolDNSCrypt.Text = "DNSCrypt";
            CustomCheckBoxSettingProtocolDNSCrypt.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxSettingProtocolTLS
            // 
            CustomCheckBoxSettingProtocolTLS.BackColor = Color.DimGray;
            CustomCheckBoxSettingProtocolTLS.BorderColor = Color.Blue;
            CustomCheckBoxSettingProtocolTLS.CheckColor = Color.Blue;
            CustomCheckBoxSettingProtocolTLS.Checked = true;
            CustomCheckBoxSettingProtocolTLS.CheckState = CheckState.Checked;
            CustomCheckBoxSettingProtocolTLS.ForeColor = Color.White;
            CustomCheckBoxSettingProtocolTLS.Location = new Point(230, 25);
            CustomCheckBoxSettingProtocolTLS.Name = "CustomCheckBoxSettingProtocolTLS";
            CustomCheckBoxSettingProtocolTLS.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingProtocolTLS.Size = new Size(98, 17);
            CustomCheckBoxSettingProtocolTLS.TabIndex = 1;
            CustomCheckBoxSettingProtocolTLS.Text = "DNS-Over-TLS";
            CustomCheckBoxSettingProtocolTLS.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxSettingProtocolDoH
            // 
            CustomCheckBoxSettingProtocolDoH.BackColor = Color.DimGray;
            CustomCheckBoxSettingProtocolDoH.BorderColor = Color.Blue;
            CustomCheckBoxSettingProtocolDoH.CheckColor = Color.Blue;
            CustomCheckBoxSettingProtocolDoH.Checked = true;
            CustomCheckBoxSettingProtocolDoH.CheckState = CheckState.Checked;
            CustomCheckBoxSettingProtocolDoH.ForeColor = Color.White;
            CustomCheckBoxSettingProtocolDoH.Location = new Point(15, 25);
            CustomCheckBoxSettingProtocolDoH.Name = "CustomCheckBoxSettingProtocolDoH";
            CustomCheckBoxSettingProtocolDoH.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingProtocolDoH.Size = new Size(115, 17);
            CustomCheckBoxSettingProtocolDoH.TabIndex = 0;
            CustomCheckBoxSettingProtocolDoH.Text = "DNS-Over-HTTPS";
            CustomCheckBoxSettingProtocolDoH.UseVisualStyleBackColor = false;
            // 
            // CustomGroupBoxSettingCheckSDNS
            // 
            CustomGroupBoxSettingCheckSDNS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomGroupBoxSettingCheckSDNS.BorderColor = Color.Blue;
            CustomGroupBoxSettingCheckSDNS.Controls.Add(CustomCheckBoxSettingSdnsNoFilter);
            CustomGroupBoxSettingCheckSDNS.Controls.Add(CustomCheckBoxSettingSdnsNoLog);
            CustomGroupBoxSettingCheckSDNS.Controls.Add(CustomCheckBoxSettingSdnsDNSSec);
            CustomGroupBoxSettingCheckSDNS.Location = new Point(4, 230);
            CustomGroupBoxSettingCheckSDNS.Margin = new Padding(1);
            CustomGroupBoxSettingCheckSDNS.Name = "CustomGroupBoxSettingCheckSDNS";
            CustomGroupBoxSettingCheckSDNS.RoundedCorners = 5;
            CustomGroupBoxSettingCheckSDNS.Size = new Size(510, 65);
            CustomGroupBoxSettingCheckSDNS.TabIndex = 11;
            CustomGroupBoxSettingCheckSDNS.TabStop = false;
            CustomGroupBoxSettingCheckSDNS.Text = "sdns:// servers must have";
            // 
            // CustomCheckBoxSettingSdnsNoFilter
            // 
            CustomCheckBoxSettingSdnsNoFilter.BackColor = Color.DimGray;
            CustomCheckBoxSettingSdnsNoFilter.BorderColor = Color.Blue;
            CustomCheckBoxSettingSdnsNoFilter.CheckColor = Color.Blue;
            CustomCheckBoxSettingSdnsNoFilter.ForeColor = Color.White;
            CustomCheckBoxSettingSdnsNoFilter.Location = new Point(420, 28);
            CustomCheckBoxSettingSdnsNoFilter.Name = "CustomCheckBoxSettingSdnsNoFilter";
            CustomCheckBoxSettingSdnsNoFilter.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingSdnsNoFilter.Size = new Size(66, 17);
            CustomCheckBoxSettingSdnsNoFilter.TabIndex = 2;
            CustomCheckBoxSettingSdnsNoFilter.Text = "No Filter";
            CustomCheckBoxSettingSdnsNoFilter.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxSettingSdnsNoLog
            // 
            CustomCheckBoxSettingSdnsNoLog.BackColor = Color.DimGray;
            CustomCheckBoxSettingSdnsNoLog.BorderColor = Color.Blue;
            CustomCheckBoxSettingSdnsNoLog.CheckColor = Color.Blue;
            CustomCheckBoxSettingSdnsNoLog.ForeColor = Color.White;
            CustomCheckBoxSettingSdnsNoLog.Location = new Point(230, 28);
            CustomCheckBoxSettingSdnsNoLog.Name = "CustomCheckBoxSettingSdnsNoLog";
            CustomCheckBoxSettingSdnsNoLog.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingSdnsNoLog.Size = new Size(59, 17);
            CustomCheckBoxSettingSdnsNoLog.TabIndex = 1;
            CustomCheckBoxSettingSdnsNoLog.Text = "No Log";
            CustomCheckBoxSettingSdnsNoLog.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxSettingSdnsDNSSec
            // 
            CustomCheckBoxSettingSdnsDNSSec.BackColor = Color.DimGray;
            CustomCheckBoxSettingSdnsDNSSec.BorderColor = Color.Blue;
            CustomCheckBoxSettingSdnsDNSSec.CheckColor = Color.Blue;
            CustomCheckBoxSettingSdnsDNSSec.ForeColor = Color.White;
            CustomCheckBoxSettingSdnsDNSSec.Location = new Point(15, 28);
            CustomCheckBoxSettingSdnsDNSSec.Name = "CustomCheckBoxSettingSdnsDNSSec";
            CustomCheckBoxSettingSdnsDNSSec.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingSdnsDNSSec.Size = new Size(109, 17);
            CustomCheckBoxSettingSdnsDNSSec.TabIndex = 0;
            CustomCheckBoxSettingSdnsDNSSec.Text = "DNSSec Enabled";
            CustomCheckBoxSettingSdnsDNSSec.UseVisualStyleBackColor = false;
            // 
            // CustomTextBoxSettingCheckDPIHost
            // 
            CustomTextBoxSettingCheckDPIHost.AcceptsReturn = false;
            CustomTextBoxSettingCheckDPIHost.AcceptsTab = false;
            CustomTextBoxSettingCheckDPIHost.BackColor = Color.DimGray;
            CustomTextBoxSettingCheckDPIHost.Border = true;
            CustomTextBoxSettingCheckDPIHost.BorderColor = Color.Blue;
            CustomTextBoxSettingCheckDPIHost.BorderSize = 1;
            CustomTextBoxSettingCheckDPIHost.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxSettingCheckDPIHost.Font = new Font("Segoe UI", 9F);
            CustomTextBoxSettingCheckDPIHost.ForeColor = Color.White;
            CustomTextBoxSettingCheckDPIHost.HideSelection = true;
            CustomTextBoxSettingCheckDPIHost.Location = new Point(274, 97);
            CustomTextBoxSettingCheckDPIHost.MaxLength = 32767;
            CustomTextBoxSettingCheckDPIHost.Multiline = false;
            CustomTextBoxSettingCheckDPIHost.Name = "CustomTextBoxSettingCheckDPIHost";
            CustomTextBoxSettingCheckDPIHost.ReadOnly = false;
            CustomTextBoxSettingCheckDPIHost.RoundedCorners = 0;
            CustomTextBoxSettingCheckDPIHost.ScrollBars = ScrollBars.None;
            CustomTextBoxSettingCheckDPIHost.ShortcutsEnabled = true;
            CustomTextBoxSettingCheckDPIHost.Size = new Size(143, 23);
            CustomTextBoxSettingCheckDPIHost.TabIndex = 0;
            CustomTextBoxSettingCheckDPIHost.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxSettingCheckDPIHost.Texts = "www.youtube.com";
            CustomTextBoxSettingCheckDPIHost.UnderlinedStyle = true;
            CustomTextBoxSettingCheckDPIHost.UsePasswordChar = false;
            CustomTextBoxSettingCheckDPIHost.WordWrap = true;
            CustomTextBoxSettingCheckDPIHost.Leave += CustomTextBoxSettingCheckDPIHost_Leave;
            // 
            // CustomLabelSettingCheckDPIInfo
            // 
            CustomLabelSettingCheckDPIInfo.AutoSize = true;
            CustomLabelSettingCheckDPIInfo.BackColor = Color.DimGray;
            CustomLabelSettingCheckDPIInfo.Border = false;
            CustomLabelSettingCheckDPIInfo.BorderColor = Color.Blue;
            CustomLabelSettingCheckDPIInfo.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingCheckDPIInfo.ForeColor = Color.White;
            CustomLabelSettingCheckDPIInfo.Location = new Point(15, 99);
            CustomLabelSettingCheckDPIInfo.Name = "CustomLabelSettingCheckDPIInfo";
            CustomLabelSettingCheckDPIInfo.RoundedCorners = 0;
            CustomLabelSettingCheckDPIInfo.Size = new Size(259, 17);
            CustomLabelSettingCheckDPIInfo.TabIndex = 10;
            CustomLabelSettingCheckDPIInfo.Text = "A DNS based blocked website to check. https://";
            // 
            // CustomLabelSettingCheckTimeout
            // 
            CustomLabelSettingCheckTimeout.AutoSize = true;
            CustomLabelSettingCheckTimeout.BackColor = Color.DimGray;
            CustomLabelSettingCheckTimeout.Border = false;
            CustomLabelSettingCheckTimeout.BorderColor = Color.Blue;
            CustomLabelSettingCheckTimeout.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingCheckTimeout.ForeColor = Color.White;
            CustomLabelSettingCheckTimeout.Location = new Point(15, 25);
            CustomLabelSettingCheckTimeout.Name = "CustomLabelSettingCheckTimeout";
            CustomLabelSettingCheckTimeout.RoundedCorners = 0;
            CustomLabelSettingCheckTimeout.Size = new Size(144, 17);
            CustomLabelSettingCheckTimeout.TabIndex = 2;
            CustomLabelSettingCheckTimeout.Text = "Check timeout (seconds):";
            // 
            // CustomNumericUpDownSettingCheckTimeout
            // 
            CustomNumericUpDownSettingCheckTimeout.BackColor = Color.DimGray;
            CustomNumericUpDownSettingCheckTimeout.BorderColor = Color.Blue;
            CustomNumericUpDownSettingCheckTimeout.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownSettingCheckTimeout.DecimalPlaces = 1;
            CustomNumericUpDownSettingCheckTimeout.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            CustomNumericUpDownSettingCheckTimeout.Location = new Point(160, 23);
            CustomNumericUpDownSettingCheckTimeout.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            CustomNumericUpDownSettingCheckTimeout.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            CustomNumericUpDownSettingCheckTimeout.Name = "CustomNumericUpDownSettingCheckTimeout";
            CustomNumericUpDownSettingCheckTimeout.RoundedCorners = 5;
            CustomNumericUpDownSettingCheckTimeout.Size = new Size(45, 23);
            CustomNumericUpDownSettingCheckTimeout.TabIndex = 3;
            CustomNumericUpDownSettingCheckTimeout.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // TabPageSettingsQuickConnect
            // 
            TabPageSettingsQuickConnect.BackColor = Color.Transparent;
            TabPageSettingsQuickConnect.Controls.Add(SplitContainerSettingQcMain);
            TabPageSettingsQuickConnect.Location = new Point(99, 4);
            TabPageSettingsQuickConnect.Name = "TabPageSettingsQuickConnect";
            TabPageSettingsQuickConnect.Padding = new Padding(3);
            TabPageSettingsQuickConnect.Size = new Size(518, 357);
            TabPageSettingsQuickConnect.TabIndex = 8;
            TabPageSettingsQuickConnect.Tag = 2;
            TabPageSettingsQuickConnect.Text = "Quick Connect";
            TabPageSettingsQuickConnect.Visible = false;
            // 
            // SplitContainerSettingQcMain
            // 
            SplitContainerSettingQcMain.Dock = DockStyle.Fill;
            SplitContainerSettingQcMain.FixedPanel = FixedPanel.Panel2;
            SplitContainerSettingQcMain.IsSplitterFixed = true;
            SplitContainerSettingQcMain.Location = new Point(3, 3);
            SplitContainerSettingQcMain.Name = "SplitContainerSettingQcMain";
            SplitContainerSettingQcMain.Orientation = Orientation.Horizontal;
            // 
            // SplitContainerSettingQcMain.Panel1
            // 
            SplitContainerSettingQcMain.Panel1.AutoScroll = true;
            SplitContainerSettingQcMain.Panel1.Controls.Add(CustomLabelSettingQcInfo);
            SplitContainerSettingQcMain.Panel1.Controls.Add(CustomLabelSettingQcConnectMode);
            SplitContainerSettingQcMain.Panel1.Controls.Add(CustomComboBoxSettingQcConnectMode);
            SplitContainerSettingQcMain.Panel1.Controls.Add(CustomCheckBoxSettingQcUseSavedServers);
            SplitContainerSettingQcMain.Panel1.Controls.Add(CustomCheckBoxSettingQcCheckAllServers);
            SplitContainerSettingQcMain.Panel1.Controls.Add(CustomCheckBoxSettingQcSetDnsTo);
            SplitContainerSettingQcMain.Panel1.Controls.Add(CustomComboBoxSettingQcNics);
            SplitContainerSettingQcMain.Panel1.Controls.Add(CustomComboBoxSettingQcGdBasic);
            SplitContainerSettingQcMain.Panel1.Controls.Add(CustomButtonSettingQcUpdateNics);
            SplitContainerSettingQcMain.Panel1.Controls.Add(CustomRadioButtonSettingQcGdAdvanced);
            SplitContainerSettingQcMain.Panel1.Controls.Add(CustomCheckBoxSettingQcStartProxyServer);
            SplitContainerSettingQcMain.Panel1.Controls.Add(CustomRadioButtonSettingQcGdBasic);
            SplitContainerSettingQcMain.Panel1.Controls.Add(CustomCheckBoxSettingQcSetProxy);
            SplitContainerSettingQcMain.Panel1.Controls.Add(CustomCheckBoxSettingQcStartGoodbyeDpi);
            // 
            // SplitContainerSettingQcMain.Panel2
            // 
            SplitContainerSettingQcMain.Panel2.Controls.Add(CustomCheckBoxSettingQcOnStartup);
            SplitContainerSettingQcMain.Panel2.Controls.Add(CustomButtonSettingQcStartup);
            SplitContainerSettingQcMain.Size = new Size(512, 351);
            SplitContainerSettingQcMain.SplitterDistance = 301;
            SplitContainerSettingQcMain.TabIndex = 19;
            // 
            // CustomLabelSettingQcInfo
            // 
            CustomLabelSettingQcInfo.AutoSize = true;
            CustomLabelSettingQcInfo.BackColor = Color.DimGray;
            CustomLabelSettingQcInfo.Border = false;
            CustomLabelSettingQcInfo.BorderColor = Color.Blue;
            CustomLabelSettingQcInfo.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingQcInfo.ForeColor = Color.White;
            CustomLabelSettingQcInfo.Location = new Point(12, 10);
            CustomLabelSettingQcInfo.Name = "CustomLabelSettingQcInfo";
            CustomLabelSettingQcInfo.RoundedCorners = 0;
            CustomLabelSettingQcInfo.Size = new Size(172, 17);
            CustomLabelSettingQcInfo.TabIndex = 0;
            CustomLabelSettingQcInfo.Text = "Choose Quick Connect actions";
            // 
            // CustomLabelSettingQcConnectMode
            // 
            CustomLabelSettingQcConnectMode.AutoSize = true;
            CustomLabelSettingQcConnectMode.BackColor = Color.DimGray;
            CustomLabelSettingQcConnectMode.Border = false;
            CustomLabelSettingQcConnectMode.BorderColor = Color.Blue;
            CustomLabelSettingQcConnectMode.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingQcConnectMode.ForeColor = Color.White;
            CustomLabelSettingQcConnectMode.Location = new Point(12, 53);
            CustomLabelSettingQcConnectMode.Name = "CustomLabelSettingQcConnectMode";
            CustomLabelSettingQcConnectMode.RoundedCorners = 0;
            CustomLabelSettingQcConnectMode.Size = new Size(71, 17);
            CustomLabelSettingQcConnectMode.TabIndex = 17;
            CustomLabelSettingQcConnectMode.Text = "Connect to:";
            // 
            // CustomComboBoxSettingQcConnectMode
            // 
            CustomComboBoxSettingQcConnectMode.BackColor = Color.DimGray;
            CustomComboBoxSettingQcConnectMode.BorderColor = Color.Blue;
            CustomComboBoxSettingQcConnectMode.DrawMode = DrawMode.OwnerDrawVariable;
            CustomComboBoxSettingQcConnectMode.Font = new Font("Segoe UI", 9F);
            CustomComboBoxSettingQcConnectMode.ForeColor = Color.White;
            CustomComboBoxSettingQcConnectMode.FormattingEnabled = true;
            CustomComboBoxSettingQcConnectMode.ItemHeight = 17;
            CustomComboBoxSettingQcConnectMode.Location = new Point(109, 51);
            CustomComboBoxSettingQcConnectMode.Name = "CustomComboBoxSettingQcConnectMode";
            CustomComboBoxSettingQcConnectMode.RoundedCorners = 5;
            CustomComboBoxSettingQcConnectMode.SelectionColor = Color.DodgerBlue;
            CustomComboBoxSettingQcConnectMode.Size = new Size(250, 23);
            CustomComboBoxSettingQcConnectMode.TabIndex = 2;
            CustomComboBoxSettingQcConnectMode.Text = "Select a Connect Mode";
            CustomComboBoxSettingQcConnectMode.SelectedIndexChanged += CustomComboBoxSettingQcConnectMode_SelectedIndexChanged;
            // 
            // CustomCheckBoxSettingQcUseSavedServers
            // 
            CustomCheckBoxSettingQcUseSavedServers.BackColor = Color.DimGray;
            CustomCheckBoxSettingQcUseSavedServers.BorderColor = Color.Blue;
            CustomCheckBoxSettingQcUseSavedServers.CheckColor = Color.Blue;
            CustomCheckBoxSettingQcUseSavedServers.Checked = true;
            CustomCheckBoxSettingQcUseSavedServers.CheckState = CheckState.Checked;
            CustomCheckBoxSettingQcUseSavedServers.ForeColor = Color.White;
            CustomCheckBoxSettingQcUseSavedServers.Location = new Point(109, 89);
            CustomCheckBoxSettingQcUseSavedServers.Name = "CustomCheckBoxSettingQcUseSavedServers";
            CustomCheckBoxSettingQcUseSavedServers.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingQcUseSavedServers.Size = new Size(184, 17);
            CustomCheckBoxSettingQcUseSavedServers.TabIndex = 15;
            CustomCheckBoxSettingQcUseSavedServers.Text = "Use Saved Servers if available";
            CustomCheckBoxSettingQcUseSavedServers.UseVisualStyleBackColor = false;
            CustomCheckBoxSettingQcUseSavedServers.CheckedChanged += CustomCheckBoxSettingQcUseSavedServers_CheckedChanged;
            // 
            // CustomCheckBoxSettingQcCheckAllServers
            // 
            CustomCheckBoxSettingQcCheckAllServers.BackColor = Color.DimGray;
            CustomCheckBoxSettingQcCheckAllServers.BorderColor = Color.Blue;
            CustomCheckBoxSettingQcCheckAllServers.CheckColor = Color.Blue;
            CustomCheckBoxSettingQcCheckAllServers.ForeColor = Color.White;
            CustomCheckBoxSettingQcCheckAllServers.Location = new Point(293, 89);
            CustomCheckBoxSettingQcCheckAllServers.Name = "CustomCheckBoxSettingQcCheckAllServers";
            CustomCheckBoxSettingQcCheckAllServers.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingQcCheckAllServers.Size = new Size(114, 17);
            CustomCheckBoxSettingQcCheckAllServers.TabIndex = 3;
            CustomCheckBoxSettingQcCheckAllServers.Text = "Check all servers";
            CustomCheckBoxSettingQcCheckAllServers.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxSettingQcSetDnsTo
            // 
            CustomCheckBoxSettingQcSetDnsTo.BackColor = Color.DimGray;
            CustomCheckBoxSettingQcSetDnsTo.BorderColor = Color.Blue;
            CustomCheckBoxSettingQcSetDnsTo.CheckColor = Color.Blue;
            CustomCheckBoxSettingQcSetDnsTo.Checked = true;
            CustomCheckBoxSettingQcSetDnsTo.CheckState = CheckState.Checked;
            CustomCheckBoxSettingQcSetDnsTo.ForeColor = Color.White;
            CustomCheckBoxSettingQcSetDnsTo.Location = new Point(12, 128);
            CustomCheckBoxSettingQcSetDnsTo.Name = "CustomCheckBoxSettingQcSetDnsTo";
            CustomCheckBoxSettingQcSetDnsTo.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingQcSetDnsTo.Size = new Size(80, 17);
            CustomCheckBoxSettingQcSetDnsTo.TabIndex = 13;
            CustomCheckBoxSettingQcSetDnsTo.Text = "Set Dns to";
            CustomCheckBoxSettingQcSetDnsTo.UseVisualStyleBackColor = false;
            // 
            // CustomComboBoxSettingQcNics
            // 
            CustomComboBoxSettingQcNics.BackColor = Color.DimGray;
            CustomComboBoxSettingQcNics.BorderColor = Color.Blue;
            CustomComboBoxSettingQcNics.DrawMode = DrawMode.OwnerDrawVariable;
            CustomComboBoxSettingQcNics.ForeColor = Color.White;
            CustomComboBoxSettingQcNics.FormattingEnabled = true;
            CustomComboBoxSettingQcNics.ItemHeight = 17;
            CustomComboBoxSettingQcNics.Location = new Point(109, 126);
            CustomComboBoxSettingQcNics.Name = "CustomComboBoxSettingQcNics";
            CustomComboBoxSettingQcNics.RoundedCorners = 5;
            CustomComboBoxSettingQcNics.SelectionColor = Color.DodgerBlue;
            CustomComboBoxSettingQcNics.Size = new Size(200, 23);
            CustomComboBoxSettingQcNics.TabIndex = 5;
            CustomComboBoxSettingQcNics.Text = "Select a Network Adapter";
            // 
            // CustomComboBoxSettingQcGdBasic
            // 
            CustomComboBoxSettingQcGdBasic.BackColor = Color.DimGray;
            CustomComboBoxSettingQcGdBasic.BorderColor = Color.Blue;
            CustomComboBoxSettingQcGdBasic.DrawMode = DrawMode.OwnerDrawVariable;
            CustomComboBoxSettingQcGdBasic.ForeColor = Color.White;
            CustomComboBoxSettingQcGdBasic.FormattingEnabled = true;
            CustomComboBoxSettingQcGdBasic.ItemHeight = 17;
            CustomComboBoxSettingQcGdBasic.Location = new Point(109, 253);
            CustomComboBoxSettingQcGdBasic.Name = "CustomComboBoxSettingQcGdBasic";
            CustomComboBoxSettingQcGdBasic.RoundedCorners = 5;
            CustomComboBoxSettingQcGdBasic.SelectionColor = Color.DodgerBlue;
            CustomComboBoxSettingQcGdBasic.Size = new Size(121, 23);
            CustomComboBoxSettingQcGdBasic.TabIndex = 12;
            CustomComboBoxSettingQcGdBasic.Text = "Select a Mode";
            // 
            // CustomButtonSettingQcUpdateNics
            // 
            CustomButtonSettingQcUpdateNics.BorderColor = Color.Blue;
            CustomButtonSettingQcUpdateNics.FlatStyle = FlatStyle.Flat;
            CustomButtonSettingQcUpdateNics.Location = new Point(332, 124);
            CustomButtonSettingQcUpdateNics.Name = "CustomButtonSettingQcUpdateNics";
            CustomButtonSettingQcUpdateNics.RoundedCorners = 5;
            CustomButtonSettingQcUpdateNics.SelectionColor = Color.LightBlue;
            CustomButtonSettingQcUpdateNics.Size = new Size(75, 27);
            CustomButtonSettingQcUpdateNics.TabIndex = 6;
            CustomButtonSettingQcUpdateNics.Text = "Update";
            CustomButtonSettingQcUpdateNics.UseVisualStyleBackColor = true;
            CustomButtonSettingQcUpdateNics.Click += CustomButtonSettingQcUpdateNics_Click;
            // 
            // CustomRadioButtonSettingQcGdAdvanced
            // 
            CustomRadioButtonSettingQcGdAdvanced.BackColor = Color.DimGray;
            CustomRadioButtonSettingQcGdAdvanced.BorderColor = Color.Blue;
            CustomRadioButtonSettingQcGdAdvanced.CheckColor = Color.Blue;
            CustomRadioButtonSettingQcGdAdvanced.ForeColor = Color.White;
            CustomRadioButtonSettingQcGdAdvanced.Location = new Point(281, 255);
            CustomRadioButtonSettingQcGdAdvanced.Name = "CustomRadioButtonSettingQcGdAdvanced";
            CustomRadioButtonSettingQcGdAdvanced.SelectionColor = Color.LightBlue;
            CustomRadioButtonSettingQcGdAdvanced.Size = new Size(78, 17);
            CustomRadioButtonSettingQcGdAdvanced.TabIndex = 11;
            CustomRadioButtonSettingQcGdAdvanced.Text = "Advanced";
            CustomRadioButtonSettingQcGdAdvanced.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxSettingQcStartProxyServer
            // 
            CustomCheckBoxSettingQcStartProxyServer.BackColor = Color.DimGray;
            CustomCheckBoxSettingQcStartProxyServer.BorderColor = Color.Blue;
            CustomCheckBoxSettingQcStartProxyServer.CheckColor = Color.Blue;
            CustomCheckBoxSettingQcStartProxyServer.Checked = true;
            CustomCheckBoxSettingQcStartProxyServer.CheckState = CheckState.Checked;
            CustomCheckBoxSettingQcStartProxyServer.ForeColor = Color.White;
            CustomCheckBoxSettingQcStartProxyServer.Location = new Point(12, 179);
            CustomCheckBoxSettingQcStartProxyServer.Name = "CustomCheckBoxSettingQcStartProxyServer";
            CustomCheckBoxSettingQcStartProxyServer.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingQcStartProxyServer.Size = new Size(120, 17);
            CustomCheckBoxSettingQcStartProxyServer.TabIndex = 7;
            CustomCheckBoxSettingQcStartProxyServer.Text = "Start Proxy Server";
            CustomCheckBoxSettingQcStartProxyServer.UseVisualStyleBackColor = false;
            CustomCheckBoxSettingQcStartProxyServer.CheckedChanged += CustomCheckBoxSettingQcStartProxyServer_CheckedChanged;
            // 
            // CustomRadioButtonSettingQcGdBasic
            // 
            CustomRadioButtonSettingQcGdBasic.BackColor = Color.DimGray;
            CustomRadioButtonSettingQcGdBasic.BorderColor = Color.Blue;
            CustomRadioButtonSettingQcGdBasic.CheckColor = Color.Blue;
            CustomRadioButtonSettingQcGdBasic.Checked = true;
            CustomRadioButtonSettingQcGdBasic.ForeColor = Color.White;
            CustomRadioButtonSettingQcGdBasic.Location = new Point(27, 255);
            CustomRadioButtonSettingQcGdBasic.Name = "CustomRadioButtonSettingQcGdBasic";
            CustomRadioButtonSettingQcGdBasic.SelectionColor = Color.LightBlue;
            CustomRadioButtonSettingQcGdBasic.Size = new Size(51, 17);
            CustomRadioButtonSettingQcGdBasic.TabIndex = 10;
            CustomRadioButtonSettingQcGdBasic.TabStop = true;
            CustomRadioButtonSettingQcGdBasic.Text = "Basic";
            CustomRadioButtonSettingQcGdBasic.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxSettingQcSetProxy
            // 
            CustomCheckBoxSettingQcSetProxy.BackColor = Color.DimGray;
            CustomCheckBoxSettingQcSetProxy.BorderColor = Color.Blue;
            CustomCheckBoxSettingQcSetProxy.CheckColor = Color.Blue;
            CustomCheckBoxSettingQcSetProxy.Checked = true;
            CustomCheckBoxSettingQcSetProxy.CheckState = CheckState.Checked;
            CustomCheckBoxSettingQcSetProxy.ForeColor = Color.White;
            CustomCheckBoxSettingQcSetProxy.Location = new Point(148, 179);
            CustomCheckBoxSettingQcSetProxy.Name = "CustomCheckBoxSettingQcSetProxy";
            CustomCheckBoxSettingQcSetProxy.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingQcSetProxy.Size = new Size(132, 17);
            CustomCheckBoxSettingQcSetProxy.TabIndex = 8;
            CustomCheckBoxSettingQcSetProxy.Text = "Set Proxy to System";
            CustomCheckBoxSettingQcSetProxy.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxSettingQcStartGoodbyeDpi
            // 
            CustomCheckBoxSettingQcStartGoodbyeDpi.BackColor = Color.DimGray;
            CustomCheckBoxSettingQcStartGoodbyeDpi.BorderColor = Color.Blue;
            CustomCheckBoxSettingQcStartGoodbyeDpi.CheckColor = Color.Blue;
            CustomCheckBoxSettingQcStartGoodbyeDpi.ForeColor = Color.White;
            CustomCheckBoxSettingQcStartGoodbyeDpi.Location = new Point(12, 228);
            CustomCheckBoxSettingQcStartGoodbyeDpi.Name = "CustomCheckBoxSettingQcStartGoodbyeDpi";
            CustomCheckBoxSettingQcStartGoodbyeDpi.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingQcStartGoodbyeDpi.Size = new Size(125, 17);
            CustomCheckBoxSettingQcStartGoodbyeDpi.TabIndex = 9;
            CustomCheckBoxSettingQcStartGoodbyeDpi.Text = "Start Goodbye DPI";
            CustomCheckBoxSettingQcStartGoodbyeDpi.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxSettingQcOnStartup
            // 
            CustomCheckBoxSettingQcOnStartup.BackColor = Color.DimGray;
            CustomCheckBoxSettingQcOnStartup.BorderColor = Color.Blue;
            CustomCheckBoxSettingQcOnStartup.CheckColor = Color.Blue;
            CustomCheckBoxSettingQcOnStartup.Checked = true;
            CustomCheckBoxSettingQcOnStartup.CheckState = CheckState.Checked;
            CustomCheckBoxSettingQcOnStartup.ForeColor = Color.White;
            CustomCheckBoxSettingQcOnStartup.Location = new Point(195, 9);
            CustomCheckBoxSettingQcOnStartup.Name = "CustomCheckBoxSettingQcOnStartup";
            CustomCheckBoxSettingQcOnStartup.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingQcOnStartup.Size = new Size(212, 17);
            CustomCheckBoxSettingQcOnStartup.TabIndex = 18;
            CustomCheckBoxSettingQcOnStartup.Text = "Execute Quick Connect On Startup";
            CustomCheckBoxSettingQcOnStartup.UseVisualStyleBackColor = false;
            // 
            // CustomButtonSettingQcStartup
            // 
            CustomButtonSettingQcStartup.BorderColor = Color.Blue;
            CustomButtonSettingQcStartup.FlatStyle = FlatStyle.Flat;
            CustomButtonSettingQcStartup.Location = new Point(12, 3);
            CustomButtonSettingQcStartup.Name = "CustomButtonSettingQcStartup";
            CustomButtonSettingQcStartup.RoundedCorners = 5;
            CustomButtonSettingQcStartup.SelectionColor = Color.LightBlue;
            CustomButtonSettingQcStartup.Size = new Size(155, 27);
            CustomButtonSettingQcStartup.TabIndex = 14;
            CustomButtonSettingQcStartup.Text = "Apply to Windows Startup";
            CustomButtonSettingQcStartup.UseVisualStyleBackColor = true;
            CustomButtonSettingQcStartup.Click += CustomButtonSettingQcStartup_Click;
            // 
            // TabPageSettingsConnect
            // 
            TabPageSettingsConnect.AutoScroll = true;
            TabPageSettingsConnect.BackColor = Color.Transparent;
            TabPageSettingsConnect.Controls.Add(CustomButtonSettingMalicious);
            TabPageSettingsConnect.Controls.Add(CustomLabelSettingMalicious);
            TabPageSettingsConnect.Controls.Add(CustomCheckBoxSettingConnectRetry);
            TabPageSettingsConnect.Controls.Add(CustomCheckBoxDnsEventShowRequest);
            TabPageSettingsConnect.Controls.Add(CustomNumericUpDownSettingMaxServers);
            TabPageSettingsConnect.Controls.Add(CustomLabelSettingMaxServers);
            TabPageSettingsConnect.Location = new Point(99, 4);
            TabPageSettingsConnect.Name = "TabPageSettingsConnect";
            TabPageSettingsConnect.Padding = new Padding(3);
            TabPageSettingsConnect.Size = new Size(518, 357);
            TabPageSettingsConnect.TabIndex = 4;
            TabPageSettingsConnect.Tag = 3;
            TabPageSettingsConnect.Text = "Connect";
            TabPageSettingsConnect.Visible = false;
            // 
            // CustomButtonSettingMalicious
            // 
            CustomButtonSettingMalicious.BorderColor = Color.Blue;
            CustomButtonSettingMalicious.FlatStyle = FlatStyle.Flat;
            CustomButtonSettingMalicious.Location = new Point(23, 237);
            CustomButtonSettingMalicious.Name = "CustomButtonSettingMalicious";
            CustomButtonSettingMalicious.RoundedCorners = 5;
            CustomButtonSettingMalicious.SelectionColor = Color.LightBlue;
            CustomButtonSettingMalicious.Size = new Size(146, 27);
            CustomButtonSettingMalicious.TabIndex = 137;
            CustomButtonSettingMalicious.Text = "Edit Malicious Domains";
            CustomButtonSettingMalicious.UseVisualStyleBackColor = true;
            CustomButtonSettingMalicious.Click += CustomButtonSettingMalicious_Click;
            // 
            // CustomLabelSettingMalicious
            // 
            CustomLabelSettingMalicious.AutoSize = true;
            CustomLabelSettingMalicious.BackColor = Color.DimGray;
            CustomLabelSettingMalicious.Border = false;
            CustomLabelSettingMalicious.BorderColor = Color.Blue;
            CustomLabelSettingMalicious.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingMalicious.ForeColor = Color.White;
            CustomLabelSettingMalicious.Location = new Point(23, 173);
            CustomLabelSettingMalicious.Name = "CustomLabelSettingMalicious";
            CustomLabelSettingMalicious.RoundedCorners = 0;
            CustomLabelSettingMalicious.Size = new Size(455, 47);
            CustomLabelSettingMalicious.TabIndex = 136;
            CustomLabelSettingMalicious.Text = "Enter Malicious Domain Or IP Addresses.\r\nThe App Will Ignore Servers That Contains Bellow Adresses When Built-In Is Selected.\r\nEach Line One Address.";
            // 
            // CustomCheckBoxSettingConnectRetry
            // 
            CustomCheckBoxSettingConnectRetry.BackColor = Color.DimGray;
            CustomCheckBoxSettingConnectRetry.BorderColor = Color.Blue;
            CustomCheckBoxSettingConnectRetry.CheckColor = Color.Blue;
            CustomCheckBoxSettingConnectRetry.ForeColor = Color.White;
            CustomCheckBoxSettingConnectRetry.Location = new Point(23, 66);
            CustomCheckBoxSettingConnectRetry.Name = "CustomCheckBoxSettingConnectRetry";
            CustomCheckBoxSettingConnectRetry.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingConnectRetry.Size = new Size(132, 17);
            CustomCheckBoxSettingConnectRetry.TabIndex = 135;
            CustomCheckBoxSettingConnectRetry.Text = "Enable one time retry";
            CustomCheckBoxSettingConnectRetry.UseVisualStyleBackColor = false;
            // 
            // CustomCheckBoxDnsEventShowRequest
            // 
            CustomCheckBoxDnsEventShowRequest.BackColor = Color.DimGray;
            CustomCheckBoxDnsEventShowRequest.BorderColor = Color.Blue;
            CustomCheckBoxDnsEventShowRequest.CheckColor = Color.Blue;
            CustomCheckBoxDnsEventShowRequest.Checked = true;
            CustomCheckBoxDnsEventShowRequest.CheckState = CheckState.Checked;
            CustomCheckBoxDnsEventShowRequest.ForeColor = Color.White;
            CustomCheckBoxDnsEventShowRequest.Location = new Point(23, 109);
            CustomCheckBoxDnsEventShowRequest.Name = "CustomCheckBoxDnsEventShowRequest";
            CustomCheckBoxDnsEventShowRequest.SelectionColor = Color.LightBlue;
            CustomCheckBoxDnsEventShowRequest.Size = new Size(158, 17);
            CustomCheckBoxDnsEventShowRequest.TabIndex = 134;
            CustomCheckBoxDnsEventShowRequest.Text = "Write DNS requests to log";
            CustomCheckBoxDnsEventShowRequest.UseVisualStyleBackColor = false;
            // 
            // CustomNumericUpDownSettingMaxServers
            // 
            CustomNumericUpDownSettingMaxServers.BackColor = Color.DimGray;
            CustomNumericUpDownSettingMaxServers.BorderColor = Color.Blue;
            CustomNumericUpDownSettingMaxServers.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownSettingMaxServers.Location = new Point(248, 30);
            CustomNumericUpDownSettingMaxServers.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            CustomNumericUpDownSettingMaxServers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownSettingMaxServers.Name = "CustomNumericUpDownSettingMaxServers";
            CustomNumericUpDownSettingMaxServers.RoundedCorners = 5;
            CustomNumericUpDownSettingMaxServers.Size = new Size(45, 23);
            CustomNumericUpDownSettingMaxServers.TabIndex = 7;
            CustomNumericUpDownSettingMaxServers.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // CustomLabelSettingMaxServers
            // 
            CustomLabelSettingMaxServers.AutoSize = true;
            CustomLabelSettingMaxServers.BackColor = Color.DimGray;
            CustomLabelSettingMaxServers.Border = false;
            CustomLabelSettingMaxServers.BorderColor = Color.Blue;
            CustomLabelSettingMaxServers.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingMaxServers.ForeColor = Color.White;
            CustomLabelSettingMaxServers.Location = new Point(23, 32);
            CustomLabelSettingMaxServers.Name = "CustomLabelSettingMaxServers";
            CustomLabelSettingMaxServers.RoundedCorners = 0;
            CustomLabelSettingMaxServers.Size = new Size(224, 17);
            CustomLabelSettingMaxServers.TabIndex = 6;
            CustomLabelSettingMaxServers.Text = "Maximum number of servers to connect:";
            // 
            // TabPageSettingsSetUnsetDNS
            // 
            TabPageSettingsSetUnsetDNS.AutoScroll = true;
            TabPageSettingsSetUnsetDNS.BackColor = Color.Transparent;
            TabPageSettingsSetUnsetDNS.Controls.Add(CustomTextBoxSettingUnsetDnsIPv6_2);
            TabPageSettingsSetUnsetDNS.Controls.Add(CustomTextBoxSettingUnsetDnsIPv6_1);
            TabPageSettingsSetUnsetDNS.Controls.Add(CustomLabelSettingUnsetDnsIPv6_2);
            TabPageSettingsSetUnsetDNS.Controls.Add(CustomLabelSettingUnsetDnsIPv6_1);
            TabPageSettingsSetUnsetDNS.Controls.Add(CustomTextBoxSettingUnsetDns2);
            TabPageSettingsSetUnsetDNS.Controls.Add(CustomTextBoxSettingUnsetDns1);
            TabPageSettingsSetUnsetDNS.Controls.Add(CustomLabelSettingUnsetDns2);
            TabPageSettingsSetUnsetDNS.Controls.Add(CustomLabelSettingUnsetDns1);
            TabPageSettingsSetUnsetDNS.Controls.Add(CustomRadioButtonSettingUnsetDnsToStatic);
            TabPageSettingsSetUnsetDNS.Controls.Add(CustomRadioButtonSettingUnsetDnsToDhcp);
            TabPageSettingsSetUnsetDNS.Location = new Point(99, 4);
            TabPageSettingsSetUnsetDNS.Name = "TabPageSettingsSetUnsetDNS";
            TabPageSettingsSetUnsetDNS.Padding = new Padding(3);
            TabPageSettingsSetUnsetDNS.Size = new Size(518, 357);
            TabPageSettingsSetUnsetDNS.TabIndex = 5;
            TabPageSettingsSetUnsetDNS.Tag = 4;
            TabPageSettingsSetUnsetDNS.Text = "Set/Unset DNS";
            TabPageSettingsSetUnsetDNS.Visible = false;
            // 
            // CustomTextBoxSettingUnsetDnsIPv6_2
            // 
            CustomTextBoxSettingUnsetDnsIPv6_2.AcceptsReturn = false;
            CustomTextBoxSettingUnsetDnsIPv6_2.AcceptsTab = false;
            CustomTextBoxSettingUnsetDnsIPv6_2.BackColor = Color.DimGray;
            CustomTextBoxSettingUnsetDnsIPv6_2.Border = true;
            CustomTextBoxSettingUnsetDnsIPv6_2.BorderColor = Color.Blue;
            CustomTextBoxSettingUnsetDnsIPv6_2.BorderSize = 1;
            CustomTextBoxSettingUnsetDnsIPv6_2.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxSettingUnsetDnsIPv6_2.Font = new Font("Segoe UI", 9F);
            CustomTextBoxSettingUnsetDnsIPv6_2.ForeColor = Color.White;
            CustomTextBoxSettingUnsetDnsIPv6_2.HideSelection = true;
            CustomTextBoxSettingUnsetDnsIPv6_2.Location = new Point(220, 223);
            CustomTextBoxSettingUnsetDnsIPv6_2.MaxLength = 32767;
            CustomTextBoxSettingUnsetDnsIPv6_2.Multiline = false;
            CustomTextBoxSettingUnsetDnsIPv6_2.Name = "CustomTextBoxSettingUnsetDnsIPv6_2";
            CustomTextBoxSettingUnsetDnsIPv6_2.ReadOnly = false;
            CustomTextBoxSettingUnsetDnsIPv6_2.RoundedCorners = 0;
            CustomTextBoxSettingUnsetDnsIPv6_2.ScrollBars = ScrollBars.None;
            CustomTextBoxSettingUnsetDnsIPv6_2.ShortcutsEnabled = true;
            CustomTextBoxSettingUnsetDnsIPv6_2.Size = new Size(143, 23);
            CustomTextBoxSettingUnsetDnsIPv6_2.TabIndex = 0;
            CustomTextBoxSettingUnsetDnsIPv6_2.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxSettingUnsetDnsIPv6_2.Texts = "";
            CustomTextBoxSettingUnsetDnsIPv6_2.UnderlinedStyle = true;
            CustomTextBoxSettingUnsetDnsIPv6_2.UsePasswordChar = false;
            CustomTextBoxSettingUnsetDnsIPv6_2.WordWrap = true;
            // 
            // CustomTextBoxSettingUnsetDnsIPv6_1
            // 
            CustomTextBoxSettingUnsetDnsIPv6_1.AcceptsReturn = false;
            CustomTextBoxSettingUnsetDnsIPv6_1.AcceptsTab = false;
            CustomTextBoxSettingUnsetDnsIPv6_1.BackColor = Color.DimGray;
            CustomTextBoxSettingUnsetDnsIPv6_1.Border = true;
            CustomTextBoxSettingUnsetDnsIPv6_1.BorderColor = Color.Blue;
            CustomTextBoxSettingUnsetDnsIPv6_1.BorderSize = 1;
            CustomTextBoxSettingUnsetDnsIPv6_1.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxSettingUnsetDnsIPv6_1.Font = new Font("Segoe UI", 9F);
            CustomTextBoxSettingUnsetDnsIPv6_1.ForeColor = Color.White;
            CustomTextBoxSettingUnsetDnsIPv6_1.HideSelection = true;
            CustomTextBoxSettingUnsetDnsIPv6_1.Location = new Point(220, 181);
            CustomTextBoxSettingUnsetDnsIPv6_1.MaxLength = 32767;
            CustomTextBoxSettingUnsetDnsIPv6_1.Multiline = false;
            CustomTextBoxSettingUnsetDnsIPv6_1.Name = "CustomTextBoxSettingUnsetDnsIPv6_1";
            CustomTextBoxSettingUnsetDnsIPv6_1.ReadOnly = false;
            CustomTextBoxSettingUnsetDnsIPv6_1.RoundedCorners = 0;
            CustomTextBoxSettingUnsetDnsIPv6_1.ScrollBars = ScrollBars.None;
            CustomTextBoxSettingUnsetDnsIPv6_1.ShortcutsEnabled = true;
            CustomTextBoxSettingUnsetDnsIPv6_1.Size = new Size(143, 23);
            CustomTextBoxSettingUnsetDnsIPv6_1.TabIndex = 0;
            CustomTextBoxSettingUnsetDnsIPv6_1.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxSettingUnsetDnsIPv6_1.Texts = "";
            CustomTextBoxSettingUnsetDnsIPv6_1.UnderlinedStyle = true;
            CustomTextBoxSettingUnsetDnsIPv6_1.UsePasswordChar = false;
            CustomTextBoxSettingUnsetDnsIPv6_1.WordWrap = true;
            // 
            // CustomLabelSettingUnsetDnsIPv6_2
            // 
            CustomLabelSettingUnsetDnsIPv6_2.AutoSize = true;
            CustomLabelSettingUnsetDnsIPv6_2.BackColor = Color.DimGray;
            CustomLabelSettingUnsetDnsIPv6_2.Border = false;
            CustomLabelSettingUnsetDnsIPv6_2.BorderColor = Color.Blue;
            CustomLabelSettingUnsetDnsIPv6_2.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingUnsetDnsIPv6_2.ForeColor = Color.White;
            CustomLabelSettingUnsetDnsIPv6_2.Location = new Point(110, 223);
            CustomLabelSettingUnsetDnsIPv6_2.Name = "CustomLabelSettingUnsetDnsIPv6_2";
            CustomLabelSettingUnsetDnsIPv6_2.RoundedCorners = 0;
            CustomLabelSettingUnsetDnsIPv6_2.Size = new Size(92, 17);
            CustomLabelSettingUnsetDnsIPv6_2.TabIndex = 5;
            CustomLabelSettingUnsetDnsIPv6_2.Text = "Secondary IPv6:";
            // 
            // CustomLabelSettingUnsetDnsIPv6_1
            // 
            CustomLabelSettingUnsetDnsIPv6_1.AutoSize = true;
            CustomLabelSettingUnsetDnsIPv6_1.BackColor = Color.DimGray;
            CustomLabelSettingUnsetDnsIPv6_1.Border = false;
            CustomLabelSettingUnsetDnsIPv6_1.BorderColor = Color.Blue;
            CustomLabelSettingUnsetDnsIPv6_1.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingUnsetDnsIPv6_1.ForeColor = Color.White;
            CustomLabelSettingUnsetDnsIPv6_1.Location = new Point(110, 181);
            CustomLabelSettingUnsetDnsIPv6_1.Name = "CustomLabelSettingUnsetDnsIPv6_1";
            CustomLabelSettingUnsetDnsIPv6_1.RoundedCorners = 0;
            CustomLabelSettingUnsetDnsIPv6_1.Size = new Size(78, 17);
            CustomLabelSettingUnsetDnsIPv6_1.TabIndex = 4;
            CustomLabelSettingUnsetDnsIPv6_1.Text = "Primary IPv6:";
            // 
            // CustomTextBoxSettingUnsetDns2
            // 
            CustomTextBoxSettingUnsetDns2.AcceptsReturn = false;
            CustomTextBoxSettingUnsetDns2.AcceptsTab = false;
            CustomTextBoxSettingUnsetDns2.BackColor = Color.DimGray;
            CustomTextBoxSettingUnsetDns2.Border = true;
            CustomTextBoxSettingUnsetDns2.BorderColor = Color.Blue;
            CustomTextBoxSettingUnsetDns2.BorderSize = 1;
            CustomTextBoxSettingUnsetDns2.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxSettingUnsetDns2.Font = new Font("Segoe UI", 9F);
            CustomTextBoxSettingUnsetDns2.ForeColor = Color.White;
            CustomTextBoxSettingUnsetDns2.HideSelection = true;
            CustomTextBoxSettingUnsetDns2.Location = new Point(220, 138);
            CustomTextBoxSettingUnsetDns2.MaxLength = 32767;
            CustomTextBoxSettingUnsetDns2.Multiline = false;
            CustomTextBoxSettingUnsetDns2.Name = "CustomTextBoxSettingUnsetDns2";
            CustomTextBoxSettingUnsetDns2.ReadOnly = false;
            CustomTextBoxSettingUnsetDns2.RoundedCorners = 0;
            CustomTextBoxSettingUnsetDns2.ScrollBars = ScrollBars.None;
            CustomTextBoxSettingUnsetDns2.ShortcutsEnabled = true;
            CustomTextBoxSettingUnsetDns2.Size = new Size(143, 23);
            CustomTextBoxSettingUnsetDns2.TabIndex = 0;
            CustomTextBoxSettingUnsetDns2.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxSettingUnsetDns2.Texts = "8.8.4.4";
            CustomTextBoxSettingUnsetDns2.UnderlinedStyle = true;
            CustomTextBoxSettingUnsetDns2.UsePasswordChar = false;
            CustomTextBoxSettingUnsetDns2.WordWrap = true;
            // 
            // CustomTextBoxSettingUnsetDns1
            // 
            CustomTextBoxSettingUnsetDns1.AcceptsReturn = false;
            CustomTextBoxSettingUnsetDns1.AcceptsTab = false;
            CustomTextBoxSettingUnsetDns1.BackColor = Color.DimGray;
            CustomTextBoxSettingUnsetDns1.Border = true;
            CustomTextBoxSettingUnsetDns1.BorderColor = Color.Blue;
            CustomTextBoxSettingUnsetDns1.BorderSize = 1;
            CustomTextBoxSettingUnsetDns1.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxSettingUnsetDns1.Font = new Font("Segoe UI", 9F);
            CustomTextBoxSettingUnsetDns1.ForeColor = Color.White;
            CustomTextBoxSettingUnsetDns1.HideSelection = true;
            CustomTextBoxSettingUnsetDns1.Location = new Point(220, 103);
            CustomTextBoxSettingUnsetDns1.MaxLength = 32767;
            CustomTextBoxSettingUnsetDns1.Multiline = false;
            CustomTextBoxSettingUnsetDns1.Name = "CustomTextBoxSettingUnsetDns1";
            CustomTextBoxSettingUnsetDns1.ReadOnly = false;
            CustomTextBoxSettingUnsetDns1.RoundedCorners = 0;
            CustomTextBoxSettingUnsetDns1.ScrollBars = ScrollBars.None;
            CustomTextBoxSettingUnsetDns1.ShortcutsEnabled = true;
            CustomTextBoxSettingUnsetDns1.Size = new Size(143, 23);
            CustomTextBoxSettingUnsetDns1.TabIndex = 0;
            CustomTextBoxSettingUnsetDns1.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxSettingUnsetDns1.Texts = "8.8.8.8";
            CustomTextBoxSettingUnsetDns1.UnderlinedStyle = true;
            CustomTextBoxSettingUnsetDns1.UsePasswordChar = false;
            CustomTextBoxSettingUnsetDns1.WordWrap = true;
            // 
            // CustomLabelSettingUnsetDns2
            // 
            CustomLabelSettingUnsetDns2.AutoSize = true;
            CustomLabelSettingUnsetDns2.BackColor = Color.DimGray;
            CustomLabelSettingUnsetDns2.Border = false;
            CustomLabelSettingUnsetDns2.BorderColor = Color.Blue;
            CustomLabelSettingUnsetDns2.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingUnsetDns2.ForeColor = Color.White;
            CustomLabelSettingUnsetDns2.Location = new Point(110, 140);
            CustomLabelSettingUnsetDns2.Name = "CustomLabelSettingUnsetDns2";
            CustomLabelSettingUnsetDns2.RoundedCorners = 0;
            CustomLabelSettingUnsetDns2.Size = new Size(92, 17);
            CustomLabelSettingUnsetDns2.TabIndex = 3;
            CustomLabelSettingUnsetDns2.Text = "Secondary IPv4:";
            // 
            // CustomLabelSettingUnsetDns1
            // 
            CustomLabelSettingUnsetDns1.AutoSize = true;
            CustomLabelSettingUnsetDns1.BackColor = Color.DimGray;
            CustomLabelSettingUnsetDns1.Border = false;
            CustomLabelSettingUnsetDns1.BorderColor = Color.Blue;
            CustomLabelSettingUnsetDns1.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingUnsetDns1.ForeColor = Color.White;
            CustomLabelSettingUnsetDns1.Location = new Point(110, 105);
            CustomLabelSettingUnsetDns1.Name = "CustomLabelSettingUnsetDns1";
            CustomLabelSettingUnsetDns1.RoundedCorners = 0;
            CustomLabelSettingUnsetDns1.Size = new Size(78, 17);
            CustomLabelSettingUnsetDns1.TabIndex = 2;
            CustomLabelSettingUnsetDns1.Text = "Primary IPv4:";
            // 
            // CustomRadioButtonSettingUnsetDnsToStatic
            // 
            CustomRadioButtonSettingUnsetDnsToStatic.BackColor = Color.DimGray;
            CustomRadioButtonSettingUnsetDnsToStatic.BorderColor = Color.Blue;
            CustomRadioButtonSettingUnsetDnsToStatic.CheckColor = Color.Blue;
            CustomRadioButtonSettingUnsetDnsToStatic.Checked = true;
            CustomRadioButtonSettingUnsetDnsToStatic.ForeColor = Color.White;
            CustomRadioButtonSettingUnsetDnsToStatic.Location = new Point(50, 70);
            CustomRadioButtonSettingUnsetDnsToStatic.Name = "CustomRadioButtonSettingUnsetDnsToStatic";
            CustomRadioButtonSettingUnsetDnsToStatic.SelectionColor = Color.LightBlue;
            CustomRadioButtonSettingUnsetDnsToStatic.Size = new Size(131, 17);
            CustomRadioButtonSettingUnsetDnsToStatic.TabIndex = 1;
            CustomRadioButtonSettingUnsetDnsToStatic.TabStop = true;
            CustomRadioButtonSettingUnsetDnsToStatic.Text = "Unset DNS to Static";
            CustomRadioButtonSettingUnsetDnsToStatic.UseVisualStyleBackColor = false;
            // 
            // CustomRadioButtonSettingUnsetDnsToDhcp
            // 
            CustomRadioButtonSettingUnsetDnsToDhcp.BackColor = Color.DimGray;
            CustomRadioButtonSettingUnsetDnsToDhcp.BorderColor = Color.Blue;
            CustomRadioButtonSettingUnsetDnsToDhcp.CheckColor = Color.Blue;
            CustomRadioButtonSettingUnsetDnsToDhcp.ForeColor = Color.White;
            CustomRadioButtonSettingUnsetDnsToDhcp.Location = new Point(50, 35);
            CustomRadioButtonSettingUnsetDnsToDhcp.Name = "CustomRadioButtonSettingUnsetDnsToDhcp";
            CustomRadioButtonSettingUnsetDnsToDhcp.SelectionColor = Color.LightBlue;
            CustomRadioButtonSettingUnsetDnsToDhcp.Size = new Size(133, 17);
            CustomRadioButtonSettingUnsetDnsToDhcp.TabIndex = 0;
            CustomRadioButtonSettingUnsetDnsToDhcp.Text = "Unset DNS to DHCP";
            CustomRadioButtonSettingUnsetDnsToDhcp.UseVisualStyleBackColor = false;
            // 
            // TabPageSettingsShare
            // 
            TabPageSettingsShare.BackColor = Color.Transparent;
            TabPageSettingsShare.Controls.Add(CustomTabControlSettingProxy);
            TabPageSettingsShare.Location = new Point(99, 4);
            TabPageSettingsShare.Name = "TabPageSettingsShare";
            TabPageSettingsShare.Padding = new Padding(3);
            TabPageSettingsShare.Size = new Size(518, 357);
            TabPageSettingsShare.TabIndex = 6;
            TabPageSettingsShare.Tag = 5;
            TabPageSettingsShare.Text = "Share";
            TabPageSettingsShare.Visible = false;
            // 
            // CustomTabControlSettingProxy
            // 
            CustomTabControlSettingProxy.BorderColor = Color.Blue;
            CustomTabControlSettingProxy.Controls.Add(TabPageSettingProxyBasic);
            CustomTabControlSettingProxy.Dock = DockStyle.Fill;
            CustomTabControlSettingProxy.HideTabHeader = false;
            CustomTabControlSettingProxy.Location = new Point(3, 3);
            CustomTabControlSettingProxy.Name = "CustomTabControlSettingProxy";
            CustomTabControlSettingProxy.RoundedCorners = 5;
            CustomTabControlSettingProxy.SelectedIndex = 0;
            CustomTabControlSettingProxy.Size = new Size(512, 351);
            CustomTabControlSettingProxy.SizeMode = TabSizeMode.Fixed;
            CustomTabControlSettingProxy.TabIndex = 49;
            CustomTabControlSettingProxy.Tag = 0;
            // 
            // TabPageSettingProxyBasic
            // 
            TabPageSettingProxyBasic.AutoScroll = true;
            TabPageSettingProxyBasic.BackColor = Color.Transparent;
            TabPageSettingProxyBasic.Controls.Add(CustomNumericUpDownSettingProxyKillRequestTimeout);
            TabPageSettingProxyBasic.Controls.Add(CustomLabelSettingProxyKillRequestTimeout);
            TabPageSettingProxyBasic.Controls.Add(CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs);
            TabPageSettingProxyBasic.Controls.Add(CustomNumericUpDownSettingProxyUpstreamPort);
            TabPageSettingProxyBasic.Controls.Add(CustomTextBoxSettingProxyUpstreamHost);
            TabPageSettingProxyBasic.Controls.Add(CustomLabelSettingProxyUpstreamPort);
            TabPageSettingProxyBasic.Controls.Add(CustomLabelSettingProxyUpstreamHost);
            TabPageSettingProxyBasic.Controls.Add(CustomComboBoxSettingProxyUpstreamMode);
            TabPageSettingProxyBasic.Controls.Add(CustomCheckBoxSettingProxyUpstream);
            TabPageSettingProxyBasic.Controls.Add(CustomLabelSettingProxyPort);
            TabPageSettingProxyBasic.Controls.Add(CustomCheckBoxSettingProxyBlockPort80);
            TabPageSettingProxyBasic.Controls.Add(CustomLabelSettingProxyHandleRequests);
            TabPageSettingProxyBasic.Controls.Add(CustomNumericUpDownSettingProxyPort);
            TabPageSettingProxyBasic.Controls.Add(CustomNumericUpDownSettingProxyHandleRequests);
            TabPageSettingProxyBasic.Location = new Point(4, 25);
            TabPageSettingProxyBasic.Name = "TabPageSettingProxyBasic";
            TabPageSettingProxyBasic.Padding = new Padding(3);
            TabPageSettingProxyBasic.Size = new Size(504, 322);
            TabPageSettingProxyBasic.TabIndex = 0;
            TabPageSettingProxyBasic.Tag = 0;
            TabPageSettingProxyBasic.Text = "Basic";
            TabPageSettingProxyBasic.Visible = false;
            // 
            // CustomNumericUpDownSettingProxyKillRequestTimeout
            // 
            CustomNumericUpDownSettingProxyKillRequestTimeout.BackColor = Color.DimGray;
            CustomNumericUpDownSettingProxyKillRequestTimeout.BorderColor = Color.Blue;
            CustomNumericUpDownSettingProxyKillRequestTimeout.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownSettingProxyKillRequestTimeout.Location = new Point(172, 63);
            CustomNumericUpDownSettingProxyKillRequestTimeout.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            CustomNumericUpDownSettingProxyKillRequestTimeout.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            CustomNumericUpDownSettingProxyKillRequestTimeout.Name = "CustomNumericUpDownSettingProxyKillRequestTimeout";
            CustomNumericUpDownSettingProxyKillRequestTimeout.RoundedCorners = 5;
            CustomNumericUpDownSettingProxyKillRequestTimeout.Size = new Size(55, 23);
            CustomNumericUpDownSettingProxyKillRequestTimeout.TabIndex = 56;
            CustomNumericUpDownSettingProxyKillRequestTimeout.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // CustomLabelSettingProxyKillRequestTimeout
            // 
            CustomLabelSettingProxyKillRequestTimeout.AutoSize = true;
            CustomLabelSettingProxyKillRequestTimeout.BackColor = Color.DimGray;
            CustomLabelSettingProxyKillRequestTimeout.Border = false;
            CustomLabelSettingProxyKillRequestTimeout.BorderColor = Color.Blue;
            CustomLabelSettingProxyKillRequestTimeout.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingProxyKillRequestTimeout.ForeColor = Color.White;
            CustomLabelSettingProxyKillRequestTimeout.Location = new Point(6, 65);
            CustomLabelSettingProxyKillRequestTimeout.Name = "CustomLabelSettingProxyKillRequestTimeout";
            CustomLabelSettingProxyKillRequestTimeout.RoundedCorners = 0;
            CustomLabelSettingProxyKillRequestTimeout.Size = new Size(160, 17);
            CustomLabelSettingProxyKillRequestTimeout.TabIndex = 55;
            CustomLabelSettingProxyKillRequestTimeout.Text = "Kill request on timeout (sec):";
            // 
            // CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs
            // 
            CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs.BackColor = Color.DimGray;
            CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs.BorderColor = Color.Blue;
            CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs.CheckColor = Color.Blue;
            CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs.Checked = true;
            CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs.CheckState = CheckState.Checked;
            CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs.ForeColor = Color.White;
            CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs.Location = new Point(25, 135);
            CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs.Name = "CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs";
            CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs.Size = new Size(162, 17);
            CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs.TabIndex = 53;
            CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs.Text = "Apply only to blocked IPs";
            CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs.UseVisualStyleBackColor = false;
            // 
            // CustomNumericUpDownSettingProxyUpstreamPort
            // 
            CustomNumericUpDownSettingProxyUpstreamPort.BackColor = Color.DimGray;
            CustomNumericUpDownSettingProxyUpstreamPort.BorderColor = Color.Blue;
            CustomNumericUpDownSettingProxyUpstreamPort.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownSettingProxyUpstreamPort.Location = new Point(370, 165);
            CustomNumericUpDownSettingProxyUpstreamPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            CustomNumericUpDownSettingProxyUpstreamPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownSettingProxyUpstreamPort.Name = "CustomNumericUpDownSettingProxyUpstreamPort";
            CustomNumericUpDownSettingProxyUpstreamPort.RoundedCorners = 5;
            CustomNumericUpDownSettingProxyUpstreamPort.Size = new Size(55, 23);
            CustomNumericUpDownSettingProxyUpstreamPort.TabIndex = 51;
            CustomNumericUpDownSettingProxyUpstreamPort.Value = new decimal(new int[] { 1090, 0, 0, 0 });
            // 
            // CustomTextBoxSettingProxyUpstreamHost
            // 
            CustomTextBoxSettingProxyUpstreamHost.AcceptsReturn = false;
            CustomTextBoxSettingProxyUpstreamHost.AcceptsTab = false;
            CustomTextBoxSettingProxyUpstreamHost.BackColor = Color.DimGray;
            CustomTextBoxSettingProxyUpstreamHost.Border = true;
            CustomTextBoxSettingProxyUpstreamHost.BorderColor = Color.Blue;
            CustomTextBoxSettingProxyUpstreamHost.BorderSize = 1;
            CustomTextBoxSettingProxyUpstreamHost.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxSettingProxyUpstreamHost.Font = new Font("Segoe UI", 9F);
            CustomTextBoxSettingProxyUpstreamHost.ForeColor = Color.White;
            CustomTextBoxSettingProxyUpstreamHost.HideSelection = true;
            CustomTextBoxSettingProxyUpstreamHost.Location = new Point(156, 165);
            CustomTextBoxSettingProxyUpstreamHost.MaxLength = 32767;
            CustomTextBoxSettingProxyUpstreamHost.Multiline = false;
            CustomTextBoxSettingProxyUpstreamHost.Name = "CustomTextBoxSettingProxyUpstreamHost";
            CustomTextBoxSettingProxyUpstreamHost.ReadOnly = false;
            CustomTextBoxSettingProxyUpstreamHost.RoundedCorners = 0;
            CustomTextBoxSettingProxyUpstreamHost.ScrollBars = ScrollBars.None;
            CustomTextBoxSettingProxyUpstreamHost.ShortcutsEnabled = true;
            CustomTextBoxSettingProxyUpstreamHost.Size = new Size(150, 23);
            CustomTextBoxSettingProxyUpstreamHost.TabIndex = 0;
            CustomTextBoxSettingProxyUpstreamHost.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxSettingProxyUpstreamHost.Texts = "127.0.0.1";
            CustomTextBoxSettingProxyUpstreamHost.UnderlinedStyle = true;
            CustomTextBoxSettingProxyUpstreamHost.UsePasswordChar = false;
            CustomTextBoxSettingProxyUpstreamHost.WordWrap = true;
            // 
            // CustomLabelSettingProxyUpstreamPort
            // 
            CustomLabelSettingProxyUpstreamPort.AutoSize = true;
            CustomLabelSettingProxyUpstreamPort.BackColor = Color.DimGray;
            CustomLabelSettingProxyUpstreamPort.Border = false;
            CustomLabelSettingProxyUpstreamPort.BorderColor = Color.Blue;
            CustomLabelSettingProxyUpstreamPort.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingProxyUpstreamPort.ForeColor = Color.White;
            CustomLabelSettingProxyUpstreamPort.Location = new Point(330, 168);
            CustomLabelSettingProxyUpstreamPort.Name = "CustomLabelSettingProxyUpstreamPort";
            CustomLabelSettingProxyUpstreamPort.RoundedCorners = 0;
            CustomLabelSettingProxyUpstreamPort.Size = new Size(34, 17);
            CustomLabelSettingProxyUpstreamPort.TabIndex = 49;
            CustomLabelSettingProxyUpstreamPort.Text = "Port:";
            // 
            // CustomLabelSettingProxyUpstreamHost
            // 
            CustomLabelSettingProxyUpstreamHost.AutoSize = true;
            CustomLabelSettingProxyUpstreamHost.BackColor = Color.DimGray;
            CustomLabelSettingProxyUpstreamHost.Border = false;
            CustomLabelSettingProxyUpstreamHost.BorderColor = Color.Blue;
            CustomLabelSettingProxyUpstreamHost.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingProxyUpstreamHost.ForeColor = Color.White;
            CustomLabelSettingProxyUpstreamHost.Location = new Point(113, 168);
            CustomLabelSettingProxyUpstreamHost.Name = "CustomLabelSettingProxyUpstreamHost";
            CustomLabelSettingProxyUpstreamHost.RoundedCorners = 0;
            CustomLabelSettingProxyUpstreamHost.Size = new Size(37, 17);
            CustomLabelSettingProxyUpstreamHost.TabIndex = 48;
            CustomLabelSettingProxyUpstreamHost.Text = "Host:";
            // 
            // CustomComboBoxSettingProxyUpstreamMode
            // 
            CustomComboBoxSettingProxyUpstreamMode.BackColor = Color.DimGray;
            CustomComboBoxSettingProxyUpstreamMode.BorderColor = Color.Blue;
            CustomComboBoxSettingProxyUpstreamMode.DrawMode = DrawMode.OwnerDrawVariable;
            CustomComboBoxSettingProxyUpstreamMode.ForeColor = Color.White;
            CustomComboBoxSettingProxyUpstreamMode.FormattingEnabled = true;
            CustomComboBoxSettingProxyUpstreamMode.ItemHeight = 17;
            CustomComboBoxSettingProxyUpstreamMode.Items.AddRange(new object[] { "HTTP", "SOCKS5" });
            CustomComboBoxSettingProxyUpstreamMode.Location = new Point(25, 165);
            CustomComboBoxSettingProxyUpstreamMode.Name = "CustomComboBoxSettingProxyUpstreamMode";
            CustomComboBoxSettingProxyUpstreamMode.RoundedCorners = 5;
            CustomComboBoxSettingProxyUpstreamMode.SelectionColor = Color.DodgerBlue;
            CustomComboBoxSettingProxyUpstreamMode.Size = new Size(70, 23);
            CustomComboBoxSettingProxyUpstreamMode.TabIndex = 47;
            // 
            // CustomCheckBoxSettingProxyUpstream
            // 
            CustomCheckBoxSettingProxyUpstream.BackColor = Color.DimGray;
            CustomCheckBoxSettingProxyUpstream.BorderColor = Color.Blue;
            CustomCheckBoxSettingProxyUpstream.CheckColor = Color.Blue;
            CustomCheckBoxSettingProxyUpstream.ForeColor = Color.White;
            CustomCheckBoxSettingProxyUpstream.Location = new Point(6, 105);
            CustomCheckBoxSettingProxyUpstream.Name = "CustomCheckBoxSettingProxyUpstream";
            CustomCheckBoxSettingProxyUpstream.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingProxyUpstream.Size = new Size(133, 17);
            CustomCheckBoxSettingProxyUpstream.TabIndex = 46;
            CustomCheckBoxSettingProxyUpstream.Text = "Use upstream proxy";
            CustomCheckBoxSettingProxyUpstream.UseVisualStyleBackColor = false;
            // 
            // CustomLabelSettingProxyPort
            // 
            CustomLabelSettingProxyPort.AutoSize = true;
            CustomLabelSettingProxyPort.BackColor = Color.DimGray;
            CustomLabelSettingProxyPort.Border = false;
            CustomLabelSettingProxyPort.BorderColor = Color.Blue;
            CustomLabelSettingProxyPort.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingProxyPort.ForeColor = Color.White;
            CustomLabelSettingProxyPort.Location = new Point(6, 25);
            CustomLabelSettingProxyPort.Name = "CustomLabelSettingProxyPort";
            CustomLabelSettingProxyPort.RoundedCorners = 0;
            CustomLabelSettingProxyPort.Size = new Size(69, 17);
            CustomLabelSettingProxyPort.TabIndex = 42;
            CustomLabelSettingProxyPort.Text = "Proxy. Port:";
            // 
            // CustomCheckBoxSettingProxyBlockPort80
            // 
            CustomCheckBoxSettingProxyBlockPort80.BackColor = Color.DimGray;
            CustomCheckBoxSettingProxyBlockPort80.BorderColor = Color.Blue;
            CustomCheckBoxSettingProxyBlockPort80.CheckColor = Color.Blue;
            CustomCheckBoxSettingProxyBlockPort80.ForeColor = Color.White;
            CustomCheckBoxSettingProxyBlockPort80.Location = new Point(403, 25);
            CustomCheckBoxSettingProxyBlockPort80.Name = "CustomCheckBoxSettingProxyBlockPort80";
            CustomCheckBoxSettingProxyBlockPort80.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingProxyBlockPort80.Size = new Size(96, 17);
            CustomCheckBoxSettingProxyBlockPort80.TabIndex = 45;
            CustomCheckBoxSettingProxyBlockPort80.Text = "Block port 80";
            CustomCheckBoxSettingProxyBlockPort80.UseVisualStyleBackColor = false;
            // 
            // CustomLabelSettingProxyHandleRequests
            // 
            CustomLabelSettingProxyHandleRequests.AutoSize = true;
            CustomLabelSettingProxyHandleRequests.BackColor = Color.DimGray;
            CustomLabelSettingProxyHandleRequests.Border = false;
            CustomLabelSettingProxyHandleRequests.BorderColor = Color.Blue;
            CustomLabelSettingProxyHandleRequests.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingProxyHandleRequests.ForeColor = Color.White;
            CustomLabelSettingProxyHandleRequests.Location = new Point(161, 25);
            CustomLabelSettingProxyHandleRequests.Name = "CustomLabelSettingProxyHandleRequests";
            CustomLabelSettingProxyHandleRequests.RoundedCorners = 0;
            CustomLabelSettingProxyHandleRequests.Size = new Size(137, 17);
            CustomLabelSettingProxyHandleRequests.TabIndex = 43;
            CustomLabelSettingProxyHandleRequests.Text = "Handle requests per sec:";
            // 
            // CustomNumericUpDownSettingProxyPort
            // 
            CustomNumericUpDownSettingProxyPort.BackColor = Color.DimGray;
            CustomNumericUpDownSettingProxyPort.BorderColor = Color.Blue;
            CustomNumericUpDownSettingProxyPort.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownSettingProxyPort.Location = new Point(84, 23);
            CustomNumericUpDownSettingProxyPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            CustomNumericUpDownSettingProxyPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownSettingProxyPort.Name = "CustomNumericUpDownSettingProxyPort";
            CustomNumericUpDownSettingProxyPort.RoundedCorners = 5;
            CustomNumericUpDownSettingProxyPort.Size = new Size(55, 23);
            CustomNumericUpDownSettingProxyPort.TabIndex = 41;
            CustomNumericUpDownSettingProxyPort.Value = new decimal(new int[] { 8080, 0, 0, 0 });
            // 
            // CustomNumericUpDownSettingProxyHandleRequests
            // 
            CustomNumericUpDownSettingProxyHandleRequests.BackColor = Color.DimGray;
            CustomNumericUpDownSettingProxyHandleRequests.BorderColor = Color.Blue;
            CustomNumericUpDownSettingProxyHandleRequests.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownSettingProxyHandleRequests.Location = new Point(310, 23);
            CustomNumericUpDownSettingProxyHandleRequests.Maximum = new decimal(new int[] { 90000, 0, 0, 0 });
            CustomNumericUpDownSettingProxyHandleRequests.Minimum = new decimal(new int[] { 5000, 0, 0, 0 });
            CustomNumericUpDownSettingProxyHandleRequests.Name = "CustomNumericUpDownSettingProxyHandleRequests";
            CustomNumericUpDownSettingProxyHandleRequests.RoundedCorners = 5;
            CustomNumericUpDownSettingProxyHandleRequests.Size = new Size(55, 23);
            CustomNumericUpDownSettingProxyHandleRequests.TabIndex = 44;
            CustomNumericUpDownSettingProxyHandleRequests.Value = new decimal(new int[] { 9000, 0, 0, 0 });
            // 
            // TabPageSettingsFakeProxy
            // 
            TabPageSettingsFakeProxy.AutoScroll = true;
            TabPageSettingsFakeProxy.BackColor = Color.Transparent;
            TabPageSettingsFakeProxy.Controls.Add(CustomTextBoxSettingFakeProxyDohCleanIP);
            TabPageSettingsFakeProxy.Controls.Add(CustomTextBoxSettingFakeProxyDohAddress);
            TabPageSettingsFakeProxy.Controls.Add(CustomLabelSettingFakeProxyDohCleanIP);
            TabPageSettingsFakeProxy.Controls.Add(CustomLabelSettingFakeProxyDohAddress);
            TabPageSettingsFakeProxy.Controls.Add(CustomLabelSettingFakeProxyInfo);
            TabPageSettingsFakeProxy.Location = new Point(99, 4);
            TabPageSettingsFakeProxy.Name = "TabPageSettingsFakeProxy";
            TabPageSettingsFakeProxy.Padding = new Padding(3);
            TabPageSettingsFakeProxy.Size = new Size(518, 357);
            TabPageSettingsFakeProxy.TabIndex = 7;
            TabPageSettingsFakeProxy.Tag = 6;
            TabPageSettingsFakeProxy.Text = "Fake Proxy";
            TabPageSettingsFakeProxy.Visible = false;
            // 
            // CustomTextBoxSettingFakeProxyDohCleanIP
            // 
            CustomTextBoxSettingFakeProxyDohCleanIP.AcceptsReturn = false;
            CustomTextBoxSettingFakeProxyDohCleanIP.AcceptsTab = false;
            CustomTextBoxSettingFakeProxyDohCleanIP.BackColor = Color.DimGray;
            CustomTextBoxSettingFakeProxyDohCleanIP.Border = true;
            CustomTextBoxSettingFakeProxyDohCleanIP.BorderColor = Color.Blue;
            CustomTextBoxSettingFakeProxyDohCleanIP.BorderSize = 1;
            CustomTextBoxSettingFakeProxyDohCleanIP.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxSettingFakeProxyDohCleanIP.Font = new Font("Segoe UI", 9F);
            CustomTextBoxSettingFakeProxyDohCleanIP.ForeColor = Color.White;
            CustomTextBoxSettingFakeProxyDohCleanIP.HideSelection = true;
            CustomTextBoxSettingFakeProxyDohCleanIP.Location = new Point(128, 148);
            CustomTextBoxSettingFakeProxyDohCleanIP.MaxLength = 32767;
            CustomTextBoxSettingFakeProxyDohCleanIP.Multiline = false;
            CustomTextBoxSettingFakeProxyDohCleanIP.Name = "CustomTextBoxSettingFakeProxyDohCleanIP";
            CustomTextBoxSettingFakeProxyDohCleanIP.ReadOnly = false;
            CustomTextBoxSettingFakeProxyDohCleanIP.RoundedCorners = 0;
            CustomTextBoxSettingFakeProxyDohCleanIP.ScrollBars = ScrollBars.None;
            CustomTextBoxSettingFakeProxyDohCleanIP.ShortcutsEnabled = true;
            CustomTextBoxSettingFakeProxyDohCleanIP.Size = new Size(162, 23);
            CustomTextBoxSettingFakeProxyDohCleanIP.TabIndex = 0;
            CustomTextBoxSettingFakeProxyDohCleanIP.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxSettingFakeProxyDohCleanIP.Texts = "104.16.132.229";
            CustomTextBoxSettingFakeProxyDohCleanIP.UnderlinedStyle = true;
            CustomTextBoxSettingFakeProxyDohCleanIP.UsePasswordChar = false;
            CustomTextBoxSettingFakeProxyDohCleanIP.WordWrap = true;
            // 
            // CustomTextBoxSettingFakeProxyDohAddress
            // 
            CustomTextBoxSettingFakeProxyDohAddress.AcceptsReturn = false;
            CustomTextBoxSettingFakeProxyDohAddress.AcceptsTab = false;
            CustomTextBoxSettingFakeProxyDohAddress.BackColor = Color.DimGray;
            CustomTextBoxSettingFakeProxyDohAddress.Border = true;
            CustomTextBoxSettingFakeProxyDohAddress.BorderColor = Color.Blue;
            CustomTextBoxSettingFakeProxyDohAddress.BorderSize = 1;
            CustomTextBoxSettingFakeProxyDohAddress.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxSettingFakeProxyDohAddress.Font = new Font("Segoe UI", 9F);
            CustomTextBoxSettingFakeProxyDohAddress.ForeColor = Color.White;
            CustomTextBoxSettingFakeProxyDohAddress.HideSelection = true;
            CustomTextBoxSettingFakeProxyDohAddress.Location = new Point(128, 98);
            CustomTextBoxSettingFakeProxyDohAddress.MaxLength = 32767;
            CustomTextBoxSettingFakeProxyDohAddress.Multiline = false;
            CustomTextBoxSettingFakeProxyDohAddress.Name = "CustomTextBoxSettingFakeProxyDohAddress";
            CustomTextBoxSettingFakeProxyDohAddress.ReadOnly = false;
            CustomTextBoxSettingFakeProxyDohAddress.RoundedCorners = 0;
            CustomTextBoxSettingFakeProxyDohAddress.ScrollBars = ScrollBars.None;
            CustomTextBoxSettingFakeProxyDohAddress.ShortcutsEnabled = true;
            CustomTextBoxSettingFakeProxyDohAddress.Size = new Size(250, 23);
            CustomTextBoxSettingFakeProxyDohAddress.TabIndex = 0;
            CustomTextBoxSettingFakeProxyDohAddress.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxSettingFakeProxyDohAddress.Texts = "https://dns.cloudflare.com/dns-query";
            CustomTextBoxSettingFakeProxyDohAddress.UnderlinedStyle = true;
            CustomTextBoxSettingFakeProxyDohAddress.UsePasswordChar = false;
            CustomTextBoxSettingFakeProxyDohAddress.WordWrap = true;
            // 
            // CustomLabelSettingFakeProxyDohCleanIP
            // 
            CustomLabelSettingFakeProxyDohCleanIP.AutoSize = true;
            CustomLabelSettingFakeProxyDohCleanIP.BackColor = Color.DimGray;
            CustomLabelSettingFakeProxyDohCleanIP.Border = false;
            CustomLabelSettingFakeProxyDohCleanIP.BorderColor = Color.Blue;
            CustomLabelSettingFakeProxyDohCleanIP.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingFakeProxyDohCleanIP.ForeColor = Color.White;
            CustomLabelSettingFakeProxyDohCleanIP.Location = new Point(20, 150);
            CustomLabelSettingFakeProxyDohCleanIP.Name = "CustomLabelSettingFakeProxyDohCleanIP";
            CustomLabelSettingFakeProxyDohCleanIP.RoundedCorners = 0;
            CustomLabelSettingFakeProxyDohCleanIP.Size = new Size(101, 15);
            CustomLabelSettingFakeProxyDohCleanIP.TabIndex = 50;
            CustomLabelSettingFakeProxyDohCleanIP.Text = "The DoH clean IP:";
            // 
            // CustomLabelSettingFakeProxyDohAddress
            // 
            CustomLabelSettingFakeProxyDohAddress.AutoSize = true;
            CustomLabelSettingFakeProxyDohAddress.BackColor = Color.DimGray;
            CustomLabelSettingFakeProxyDohAddress.Border = false;
            CustomLabelSettingFakeProxyDohAddress.BorderColor = Color.Blue;
            CustomLabelSettingFakeProxyDohAddress.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingFakeProxyDohAddress.ForeColor = Color.White;
            CustomLabelSettingFakeProxyDohAddress.Location = new Point(20, 100);
            CustomLabelSettingFakeProxyDohAddress.Name = "CustomLabelSettingFakeProxyDohAddress";
            CustomLabelSettingFakeProxyDohAddress.RoundedCorners = 0;
            CustomLabelSettingFakeProxyDohAddress.Size = new Size(88, 15);
            CustomLabelSettingFakeProxyDohAddress.TabIndex = 49;
            CustomLabelSettingFakeProxyDohAddress.Text = "A DoH address:";
            // 
            // CustomLabelSettingFakeProxyInfo
            // 
            CustomLabelSettingFakeProxyInfo.AutoSize = true;
            CustomLabelSettingFakeProxyInfo.BackColor = Color.DimGray;
            CustomLabelSettingFakeProxyInfo.Border = false;
            CustomLabelSettingFakeProxyInfo.BorderColor = Color.Blue;
            CustomLabelSettingFakeProxyInfo.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingFakeProxyInfo.Font = new Font("Segoe UI", 12F);
            CustomLabelSettingFakeProxyInfo.ForeColor = Color.White;
            CustomLabelSettingFakeProxyInfo.Location = new Point(20, 10);
            CustomLabelSettingFakeProxyInfo.Name = "CustomLabelSettingFakeProxyInfo";
            CustomLabelSettingFakeProxyInfo.RoundedCorners = 0;
            CustomLabelSettingFakeProxyInfo.Size = new Size(247, 21);
            CustomLabelSettingFakeProxyInfo.TabIndex = 48;
            CustomLabelSettingFakeProxyInfo.Text = "Fake Proxy is use to bypass a DoH.";
            // 
            // TabPageSettingsRules
            // 
            TabPageSettingsRules.Controls.Add(FlowLayoutPanelRules);
            TabPageSettingsRules.Location = new Point(99, 4);
            TabPageSettingsRules.Name = "TabPageSettingsRules";
            TabPageSettingsRules.Padding = new Padding(3);
            TabPageSettingsRules.Size = new Size(518, 357);
            TabPageSettingsRules.TabIndex = 10;
            TabPageSettingsRules.Tag = 7;
            TabPageSettingsRules.Text = "Rules";
            TabPageSettingsRules.UseVisualStyleBackColor = true;
            // 
            // FlowLayoutPanelRules
            // 
            FlowLayoutPanelRules.AutoScroll = true;
            FlowLayoutPanelRules.AutoSize = true;
            FlowLayoutPanelRules.Controls.Add(FlowLayoutPanelRules2);
            FlowLayoutPanelRules.Controls.Add(FlowLayoutPanelRules3);
            FlowLayoutPanelRules.Dock = DockStyle.Fill;
            FlowLayoutPanelRules.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanelRules.Location = new Point(3, 3);
            FlowLayoutPanelRules.Name = "FlowLayoutPanelRules";
            FlowLayoutPanelRules.Padding = new Padding(5);
            FlowLayoutPanelRules.Size = new Size(512, 351);
            FlowLayoutPanelRules.TabIndex = 0;
            FlowLayoutPanelRules.WrapContents = false;
            // 
            // FlowLayoutPanelRules2
            // 
            FlowLayoutPanelRules2.AutoSize = true;
            FlowLayoutPanelRules2.Controls.Add(CustomCheckBoxSettingProxyCfCleanIP);
            FlowLayoutPanelRules2.Controls.Add(CustomTextBoxSettingProxyCfCleanIP);
            FlowLayoutPanelRules2.Location = new Point(8, 8);
            FlowLayoutPanelRules2.Name = "FlowLayoutPanelRules2";
            FlowLayoutPanelRules2.Padding = new Padding(10);
            FlowLayoutPanelRules2.Size = new Size(445, 49);
            FlowLayoutPanelRules2.TabIndex = 0;
            FlowLayoutPanelRules2.WrapContents = false;
            // 
            // CustomCheckBoxSettingProxyCfCleanIP
            // 
            CustomCheckBoxSettingProxyCfCleanIP.BackColor = Color.DimGray;
            CustomCheckBoxSettingProxyCfCleanIP.BorderColor = Color.Blue;
            CustomCheckBoxSettingProxyCfCleanIP.CheckColor = Color.Blue;
            CustomCheckBoxSettingProxyCfCleanIP.ForeColor = Color.White;
            CustomCheckBoxSettingProxyCfCleanIP.Location = new Point(15, 15);
            CustomCheckBoxSettingProxyCfCleanIP.Margin = new Padding(5);
            CustomCheckBoxSettingProxyCfCleanIP.Name = "CustomCheckBoxSettingProxyCfCleanIP";
            CustomCheckBoxSettingProxyCfCleanIP.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingProxyCfCleanIP.Size = new Size(226, 17);
            CustomCheckBoxSettingProxyCfCleanIP.TabIndex = 3;
            CustomCheckBoxSettingProxyCfCleanIP.Text = "Redirect all Cloudflare IPs to a clean IP:";
            CustomCheckBoxSettingProxyCfCleanIP.UseVisualStyleBackColor = false;
            // 
            // CustomTextBoxSettingProxyCfCleanIP
            // 
            CustomTextBoxSettingProxyCfCleanIP.AcceptsReturn = false;
            CustomTextBoxSettingProxyCfCleanIP.AcceptsTab = false;
            CustomTextBoxSettingProxyCfCleanIP.BackColor = Color.DimGray;
            CustomTextBoxSettingProxyCfCleanIP.Border = true;
            CustomTextBoxSettingProxyCfCleanIP.BorderColor = Color.Blue;
            CustomTextBoxSettingProxyCfCleanIP.BorderSize = 1;
            CustomTextBoxSettingProxyCfCleanIP.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxSettingProxyCfCleanIP.Font = new Font("Segoe UI", 9F);
            CustomTextBoxSettingProxyCfCleanIP.ForeColor = Color.White;
            CustomTextBoxSettingProxyCfCleanIP.HideSelection = true;
            CustomTextBoxSettingProxyCfCleanIP.Location = new Point(249, 13);
            CustomTextBoxSettingProxyCfCleanIP.MaxLength = 32767;
            CustomTextBoxSettingProxyCfCleanIP.Multiline = false;
            CustomTextBoxSettingProxyCfCleanIP.Name = "CustomTextBoxSettingProxyCfCleanIP";
            CustomTextBoxSettingProxyCfCleanIP.ReadOnly = false;
            CustomTextBoxSettingProxyCfCleanIP.RoundedCorners = 0;
            CustomTextBoxSettingProxyCfCleanIP.ScrollBars = ScrollBars.None;
            CustomTextBoxSettingProxyCfCleanIP.ShortcutsEnabled = true;
            CustomTextBoxSettingProxyCfCleanIP.Size = new Size(183, 23);
            CustomTextBoxSettingProxyCfCleanIP.TabIndex = 0;
            CustomTextBoxSettingProxyCfCleanIP.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxSettingProxyCfCleanIP.Texts = "104.18.145.170";
            CustomTextBoxSettingProxyCfCleanIP.UnderlinedStyle = true;
            CustomTextBoxSettingProxyCfCleanIP.UsePasswordChar = false;
            CustomTextBoxSettingProxyCfCleanIP.WordWrap = true;
            // 
            // FlowLayoutPanelRules3
            // 
            FlowLayoutPanelRules3.AutoSize = true;
            FlowLayoutPanelRules3.Controls.Add(CustomCheckBoxSettingEnableRules);
            FlowLayoutPanelRules3.Controls.Add(CustomButtonSettingRules);
            FlowLayoutPanelRules3.Controls.Add(LinkLabelSettingRulesHelp);
            FlowLayoutPanelRules3.Location = new Point(8, 63);
            FlowLayoutPanelRules3.Name = "FlowLayoutPanelRules3";
            FlowLayoutPanelRules3.Padding = new Padding(10);
            FlowLayoutPanelRules3.Size = new Size(287, 53);
            FlowLayoutPanelRules3.TabIndex = 1;
            FlowLayoutPanelRules3.WrapContents = false;
            // 
            // CustomCheckBoxSettingEnableRules
            // 
            CustomCheckBoxSettingEnableRules.BackColor = Color.DimGray;
            CustomCheckBoxSettingEnableRules.BorderColor = Color.Blue;
            CustomCheckBoxSettingEnableRules.CheckColor = Color.Blue;
            CustomCheckBoxSettingEnableRules.ForeColor = Color.White;
            CustomCheckBoxSettingEnableRules.Location = new Point(15, 15);
            CustomCheckBoxSettingEnableRules.Margin = new Padding(5);
            CustomCheckBoxSettingEnableRules.Name = "CustomCheckBoxSettingEnableRules";
            CustomCheckBoxSettingEnableRules.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingEnableRules.Size = new Size(94, 17);
            CustomCheckBoxSettingEnableRules.TabIndex = 9;
            CustomCheckBoxSettingEnableRules.Text = "Enable Rules";
            CustomCheckBoxSettingEnableRules.UseVisualStyleBackColor = false;
            // 
            // CustomButtonSettingRules
            // 
            CustomButtonSettingRules.BorderColor = Color.Blue;
            CustomButtonSettingRules.FlatStyle = FlatStyle.Flat;
            CustomButtonSettingRules.Location = new Point(117, 13);
            CustomButtonSettingRules.Name = "CustomButtonSettingRules";
            CustomButtonSettingRules.RoundedCorners = 5;
            CustomButtonSettingRules.SelectionColor = Color.LightBlue;
            CustomButtonSettingRules.Size = new Size(103, 27);
            CustomButtonSettingRules.TabIndex = 10;
            CustomButtonSettingRules.Text = "Edit Rules";
            CustomButtonSettingRules.UseVisualStyleBackColor = true;
            CustomButtonSettingRules.Click += CustomButtonSettingRules_Click;
            // 
            // LinkLabelSettingRulesHelp
            // 
            LinkLabelSettingRulesHelp.AutoSize = true;
            LinkLabelSettingRulesHelp.LinkBehavior = LinkBehavior.NeverUnderline;
            LinkLabelSettingRulesHelp.Location = new Point(226, 10);
            LinkLabelSettingRulesHelp.Name = "LinkLabelSettingRulesHelp";
            LinkLabelSettingRulesHelp.Padding = new Padding(8);
            LinkLabelSettingRulesHelp.Size = new Size(48, 31);
            LinkLabelSettingRulesHelp.TabIndex = 14;
            LinkLabelSettingRulesHelp.TabStop = true;
            LinkLabelSettingRulesHelp.Text = "Help";
            LinkLabelSettingRulesHelp.LinkClicked += LinkLabelSettingRulesHelp_LinkClicked;
            // 
            // TabPageSettingsGeoAssets
            // 
            TabPageSettingsGeoAssets.Controls.Add(FlowLayoutPanelGeoAssets);
            TabPageSettingsGeoAssets.Location = new Point(99, 4);
            TabPageSettingsGeoAssets.Name = "TabPageSettingsGeoAssets";
            TabPageSettingsGeoAssets.Padding = new Padding(3);
            TabPageSettingsGeoAssets.Size = new Size(518, 357);
            TabPageSettingsGeoAssets.TabIndex = 9;
            TabPageSettingsGeoAssets.Tag = 8;
            TabPageSettingsGeoAssets.Text = "Geo Assets";
            TabPageSettingsGeoAssets.UseVisualStyleBackColor = true;
            // 
            // FlowLayoutPanelGeoAssets
            // 
            FlowLayoutPanelGeoAssets.Controls.Add(CustomLabelGeoAssetsSpacer1);
            FlowLayoutPanelGeoAssets.Controls.Add(CustomCheckBoxGeoAsset_IR_Domains);
            FlowLayoutPanelGeoAssets.Controls.Add(CustomCheckBoxGeoAsset_IR_CIDRs);
            FlowLayoutPanelGeoAssets.Controls.Add(CustomCheckBoxGeoAsset_IR_ADS);
            FlowLayoutPanelGeoAssets.Controls.Add(CustomLabelGeoAssetsSpacer2);
            FlowLayoutPanelGeoAssets.Controls.Add(FlowLayoutPanelGeoAssets2);
            FlowLayoutPanelGeoAssets.Controls.Add(CustomLabelGeoAssetsSpacer3);
            FlowLayoutPanelGeoAssets.Dock = DockStyle.Fill;
            FlowLayoutPanelGeoAssets.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanelGeoAssets.Location = new Point(3, 3);
            FlowLayoutPanelGeoAssets.Name = "FlowLayoutPanelGeoAssets";
            FlowLayoutPanelGeoAssets.Padding = new Padding(5);
            FlowLayoutPanelGeoAssets.Size = new Size(512, 351);
            FlowLayoutPanelGeoAssets.TabIndex = 0;
            FlowLayoutPanelGeoAssets.WrapContents = false;
            // 
            // CustomLabelGeoAssetsSpacer1
            // 
            CustomLabelGeoAssetsSpacer1.BackColor = Color.DimGray;
            CustomLabelGeoAssetsSpacer1.Border = false;
            CustomLabelGeoAssetsSpacer1.BorderColor = Color.Blue;
            CustomLabelGeoAssetsSpacer1.FlatStyle = FlatStyle.Flat;
            CustomLabelGeoAssetsSpacer1.ForeColor = Color.White;
            CustomLabelGeoAssetsSpacer1.Location = new Point(8, 8);
            CustomLabelGeoAssetsSpacer1.Margin = new Padding(3);
            CustomLabelGeoAssetsSpacer1.Name = "CustomLabelGeoAssetsSpacer1";
            CustomLabelGeoAssetsSpacer1.RoundedCorners = 0;
            CustomLabelGeoAssetsSpacer1.Size = new Size(103, 20);
            CustomLabelGeoAssetsSpacer1.TabIndex = 10;
            CustomLabelGeoAssetsSpacer1.Text = "                    ";
            // 
            // CustomCheckBoxGeoAsset_IR_Domains
            // 
            CustomCheckBoxGeoAsset_IR_Domains.BackColor = Color.DimGray;
            CustomCheckBoxGeoAsset_IR_Domains.BorderColor = Color.Blue;
            CustomCheckBoxGeoAsset_IR_Domains.CheckColor = Color.Blue;
            CustomCheckBoxGeoAsset_IR_Domains.Checked = true;
            CustomCheckBoxGeoAsset_IR_Domains.CheckState = CheckState.Checked;
            CustomCheckBoxGeoAsset_IR_Domains.ForeColor = Color.White;
            CustomCheckBoxGeoAsset_IR_Domains.Location = new Point(8, 34);
            CustomCheckBoxGeoAsset_IR_Domains.Name = "CustomCheckBoxGeoAsset_IR_Domains";
            CustomCheckBoxGeoAsset_IR_Domains.SelectionColor = Color.LightBlue;
            CustomCheckBoxGeoAsset_IR_Domains.Size = new Size(118, 19);
            CustomCheckBoxGeoAsset_IR_Domains.TabIndex = 11;
            CustomCheckBoxGeoAsset_IR_Domains.Text = "IR Domains: Direct";
            CustomCheckBoxGeoAsset_IR_Domains.UseVisualStyleBackColor = false;
            CustomCheckBoxGeoAsset_IR_Domains.CheckedChanged += CustomCheckBoxGeoAsset_GeoAssets_CheckedChanged;
            // 
            // CustomCheckBoxGeoAsset_IR_CIDRs
            // 
            CustomCheckBoxGeoAsset_IR_CIDRs.BackColor = Color.DimGray;
            CustomCheckBoxGeoAsset_IR_CIDRs.BorderColor = Color.Blue;
            CustomCheckBoxGeoAsset_IR_CIDRs.CheckColor = Color.Blue;
            CustomCheckBoxGeoAsset_IR_CIDRs.Checked = true;
            CustomCheckBoxGeoAsset_IR_CIDRs.CheckState = CheckState.Checked;
            CustomCheckBoxGeoAsset_IR_CIDRs.ForeColor = Color.White;
            CustomCheckBoxGeoAsset_IR_CIDRs.Location = new Point(8, 59);
            CustomCheckBoxGeoAsset_IR_CIDRs.Name = "CustomCheckBoxGeoAsset_IR_CIDRs";
            CustomCheckBoxGeoAsset_IR_CIDRs.SelectionColor = Color.LightBlue;
            CustomCheckBoxGeoAsset_IR_CIDRs.Size = new Size(85, 19);
            CustomCheckBoxGeoAsset_IR_CIDRs.TabIndex = 12;
            CustomCheckBoxGeoAsset_IR_CIDRs.Text = "IR IPs: Direct";
            CustomCheckBoxGeoAsset_IR_CIDRs.UseVisualStyleBackColor = false;
            CustomCheckBoxGeoAsset_IR_CIDRs.CheckedChanged += CustomCheckBoxGeoAsset_GeoAssets_CheckedChanged;
            // 
            // CustomCheckBoxGeoAsset_IR_ADS
            // 
            CustomCheckBoxGeoAsset_IR_ADS.BackColor = Color.DimGray;
            CustomCheckBoxGeoAsset_IR_ADS.BorderColor = Color.Blue;
            CustomCheckBoxGeoAsset_IR_ADS.CheckColor = Color.Blue;
            CustomCheckBoxGeoAsset_IR_ADS.ForeColor = Color.White;
            CustomCheckBoxGeoAsset_IR_ADS.Location = new Point(8, 84);
            CustomCheckBoxGeoAsset_IR_ADS.Name = "CustomCheckBoxGeoAsset_IR_ADS";
            CustomCheckBoxGeoAsset_IR_ADS.SelectionColor = Color.LightBlue;
            CustomCheckBoxGeoAsset_IR_ADS.Size = new Size(145, 19);
            CustomCheckBoxGeoAsset_IR_ADS.TabIndex = 13;
            CustomCheckBoxGeoAsset_IR_ADS.Text = "IR Advertisement: Block";
            CustomCheckBoxGeoAsset_IR_ADS.UseVisualStyleBackColor = false;
            CustomCheckBoxGeoAsset_IR_ADS.CheckedChanged += CustomCheckBoxGeoAsset_GeoAssets_CheckedChanged;
            // 
            // CustomLabelGeoAssetsSpacer2
            // 
            CustomLabelGeoAssetsSpacer2.BackColor = Color.DimGray;
            CustomLabelGeoAssetsSpacer2.Border = false;
            CustomLabelGeoAssetsSpacer2.BorderColor = Color.Blue;
            CustomLabelGeoAssetsSpacer2.FlatStyle = FlatStyle.Flat;
            CustomLabelGeoAssetsSpacer2.ForeColor = Color.White;
            CustomLabelGeoAssetsSpacer2.Location = new Point(8, 109);
            CustomLabelGeoAssetsSpacer2.Margin = new Padding(3);
            CustomLabelGeoAssetsSpacer2.Name = "CustomLabelGeoAssetsSpacer2";
            CustomLabelGeoAssetsSpacer2.RoundedCorners = 0;
            CustomLabelGeoAssetsSpacer2.Size = new Size(103, 20);
            CustomLabelGeoAssetsSpacer2.TabIndex = 14;
            CustomLabelGeoAssetsSpacer2.Text = "                    ";
            // 
            // FlowLayoutPanelGeoAssets2
            // 
            FlowLayoutPanelGeoAssets2.AutoSize = true;
            FlowLayoutPanelGeoAssets2.Controls.Add(CustomCheckBoxGeoAssetUpdate);
            FlowLayoutPanelGeoAssets2.Controls.Add(CustomNumericUpDownGeoAssetsUpdate);
            FlowLayoutPanelGeoAssets2.Location = new Point(8, 135);
            FlowLayoutPanelGeoAssets2.Name = "FlowLayoutPanelGeoAssets2";
            FlowLayoutPanelGeoAssets2.Padding = new Padding(10);
            FlowLayoutPanelGeoAssets2.Size = new Size(225, 49);
            FlowLayoutPanelGeoAssets2.TabIndex = 26;
            FlowLayoutPanelGeoAssets2.WrapContents = false;
            // 
            // CustomCheckBoxGeoAssetUpdate
            // 
            CustomCheckBoxGeoAssetUpdate.BackColor = Color.DimGray;
            CustomCheckBoxGeoAssetUpdate.BorderColor = Color.Blue;
            CustomCheckBoxGeoAssetUpdate.CheckColor = Color.Blue;
            CustomCheckBoxGeoAssetUpdate.Checked = true;
            CustomCheckBoxGeoAssetUpdate.CheckState = CheckState.Checked;
            CustomCheckBoxGeoAssetUpdate.ForeColor = Color.White;
            CustomCheckBoxGeoAssetUpdate.Location = new Point(13, 13);
            CustomCheckBoxGeoAssetUpdate.Name = "CustomCheckBoxGeoAssetUpdate";
            CustomCheckBoxGeoAssetUpdate.SelectionColor = Color.LightBlue;
            CustomCheckBoxGeoAssetUpdate.Size = new Size(133, 19);
            CustomCheckBoxGeoAssetUpdate.TabIndex = 27;
            CustomCheckBoxGeoAssetUpdate.Text = "Auto Update (Hours):";
            CustomCheckBoxGeoAssetUpdate.UseVisualStyleBackColor = false;
            // 
            // CustomNumericUpDownGeoAssetsUpdate
            // 
            CustomNumericUpDownGeoAssetsUpdate.BackColor = Color.DimGray;
            CustomNumericUpDownGeoAssetsUpdate.BorderColor = Color.Blue;
            CustomNumericUpDownGeoAssetsUpdate.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownGeoAssetsUpdate.Location = new Point(152, 13);
            CustomNumericUpDownGeoAssetsUpdate.Maximum = new decimal(new int[] { 168, 0, 0, 0 });
            CustomNumericUpDownGeoAssetsUpdate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownGeoAssetsUpdate.Name = "CustomNumericUpDownGeoAssetsUpdate";
            CustomNumericUpDownGeoAssetsUpdate.RoundedCorners = 5;
            CustomNumericUpDownGeoAssetsUpdate.Size = new Size(60, 23);
            CustomNumericUpDownGeoAssetsUpdate.TabIndex = 23;
            CustomNumericUpDownGeoAssetsUpdate.Value = new decimal(new int[] { 24, 0, 0, 0 });
            // 
            // CustomLabelGeoAssetsSpacer3
            // 
            CustomLabelGeoAssetsSpacer3.BackColor = Color.DimGray;
            CustomLabelGeoAssetsSpacer3.Border = false;
            CustomLabelGeoAssetsSpacer3.BorderColor = Color.Blue;
            CustomLabelGeoAssetsSpacer3.FlatStyle = FlatStyle.Flat;
            CustomLabelGeoAssetsSpacer3.ForeColor = Color.White;
            CustomLabelGeoAssetsSpacer3.Location = new Point(8, 190);
            CustomLabelGeoAssetsSpacer3.Margin = new Padding(3);
            CustomLabelGeoAssetsSpacer3.Name = "CustomLabelGeoAssetsSpacer3";
            CustomLabelGeoAssetsSpacer3.RoundedCorners = 0;
            CustomLabelGeoAssetsSpacer3.Size = new Size(103, 20);
            CustomLabelGeoAssetsSpacer3.TabIndex = 25;
            CustomLabelGeoAssetsSpacer3.Text = "                    ";
            // 
            // TabPageSettingsCPU
            // 
            TabPageSettingsCPU.AutoScroll = true;
            TabPageSettingsCPU.BackColor = Color.Transparent;
            TabPageSettingsCPU.Controls.Add(CustomNumericUpDownUpdateAutoDelayMS);
            TabPageSettingsCPU.Controls.Add(CustomLabelUpdateAutoDelayMS);
            TabPageSettingsCPU.Controls.Add(CustomNumericUpDownSettingCpuKillProxyRequests);
            TabPageSettingsCPU.Controls.Add(CustomLabelSettingCpuKillProxyRequests);
            TabPageSettingsCPU.Controls.Add(CustomRadioButtonSettingCPULow);
            TabPageSettingsCPU.Controls.Add(CustomRadioButtonSettingCPUBelowNormal);
            TabPageSettingsCPU.Controls.Add(CustomRadioButtonSettingCPUNormal);
            TabPageSettingsCPU.Controls.Add(CustomRadioButtonSettingCPUAboveNormal);
            TabPageSettingsCPU.Controls.Add(CustomRadioButtonSettingCPUHigh);
            TabPageSettingsCPU.Controls.Add(CustomLabelSettingInfoCPU);
            TabPageSettingsCPU.Location = new Point(99, 4);
            TabPageSettingsCPU.Name = "TabPageSettingsCPU";
            TabPageSettingsCPU.Padding = new Padding(3);
            TabPageSettingsCPU.Size = new Size(518, 357);
            TabPageSettingsCPU.TabIndex = 1;
            TabPageSettingsCPU.Tag = 9;
            TabPageSettingsCPU.Text = "CPU";
            TabPageSettingsCPU.Visible = false;
            // 
            // CustomNumericUpDownUpdateAutoDelayMS
            // 
            CustomNumericUpDownUpdateAutoDelayMS.BackColor = Color.DimGray;
            CustomNumericUpDownUpdateAutoDelayMS.BorderColor = Color.Blue;
            CustomNumericUpDownUpdateAutoDelayMS.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownUpdateAutoDelayMS.Location = new Point(212, 218);
            CustomNumericUpDownUpdateAutoDelayMS.Maximum = new decimal(new int[] { 2200, 0, 0, 0 });
            CustomNumericUpDownUpdateAutoDelayMS.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            CustomNumericUpDownUpdateAutoDelayMS.Name = "CustomNumericUpDownUpdateAutoDelayMS";
            CustomNumericUpDownUpdateAutoDelayMS.RoundedCorners = 5;
            CustomNumericUpDownUpdateAutoDelayMS.Size = new Size(60, 23);
            CustomNumericUpDownUpdateAutoDelayMS.TabIndex = 9;
            CustomNumericUpDownUpdateAutoDelayMS.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            CustomNumericUpDownUpdateAutoDelayMS.ValueChanged += CustomNumericUpDownUpdateAutoDelayMS_ValueChanged;
            // 
            // CustomLabelUpdateAutoDelayMS
            // 
            CustomLabelUpdateAutoDelayMS.AutoSize = true;
            CustomLabelUpdateAutoDelayMS.BackColor = Color.DimGray;
            CustomLabelUpdateAutoDelayMS.Border = false;
            CustomLabelUpdateAutoDelayMS.BorderColor = Color.Blue;
            CustomLabelUpdateAutoDelayMS.FlatStyle = FlatStyle.Flat;
            CustomLabelUpdateAutoDelayMS.ForeColor = Color.White;
            CustomLabelUpdateAutoDelayMS.Location = new Point(50, 220);
            CustomLabelUpdateAutoDelayMS.Name = "CustomLabelUpdateAutoDelayMS";
            CustomLabelUpdateAutoDelayMS.RoundedCorners = 0;
            CustomLabelUpdateAutoDelayMS.Size = new Size(154, 15);
            CustomLabelUpdateAutoDelayMS.TabIndex = 8;
            CustomLabelUpdateAutoDelayMS.Text = "Variables update delay (ms):";
            // 
            // CustomNumericUpDownSettingCpuKillProxyRequests
            // 
            CustomNumericUpDownSettingCpuKillProxyRequests.BackColor = Color.DimGray;
            CustomNumericUpDownSettingCpuKillProxyRequests.BorderColor = Color.Blue;
            CustomNumericUpDownSettingCpuKillProxyRequests.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownSettingCpuKillProxyRequests.Location = new Point(289, 258);
            CustomNumericUpDownSettingCpuKillProxyRequests.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            CustomNumericUpDownSettingCpuKillProxyRequests.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            CustomNumericUpDownSettingCpuKillProxyRequests.Name = "CustomNumericUpDownSettingCpuKillProxyRequests";
            CustomNumericUpDownSettingCpuKillProxyRequests.RoundedCorners = 5;
            CustomNumericUpDownSettingCpuKillProxyRequests.Size = new Size(45, 23);
            CustomNumericUpDownSettingCpuKillProxyRequests.TabIndex = 7;
            CustomNumericUpDownSettingCpuKillProxyRequests.Value = new decimal(new int[] { 40, 0, 0, 0 });
            // 
            // CustomLabelSettingCpuKillProxyRequests
            // 
            CustomLabelSettingCpuKillProxyRequests.AutoSize = true;
            CustomLabelSettingCpuKillProxyRequests.BackColor = Color.DimGray;
            CustomLabelSettingCpuKillProxyRequests.Border = false;
            CustomLabelSettingCpuKillProxyRequests.BorderColor = Color.Blue;
            CustomLabelSettingCpuKillProxyRequests.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingCpuKillProxyRequests.ForeColor = Color.White;
            CustomLabelSettingCpuKillProxyRequests.Location = new Point(50, 260);
            CustomLabelSettingCpuKillProxyRequests.Name = "CustomLabelSettingCpuKillProxyRequests";
            CustomLabelSettingCpuKillProxyRequests.RoundedCorners = 0;
            CustomLabelSettingCpuKillProxyRequests.Size = new Size(230, 15);
            CustomLabelSettingCpuKillProxyRequests.TabIndex = 6;
            CustomLabelSettingCpuKillProxyRequests.Text = "Kill Proxy requests when CPU is above (%):";
            // 
            // CustomRadioButtonSettingCPULow
            // 
            CustomRadioButtonSettingCPULow.BackColor = Color.DimGray;
            CustomRadioButtonSettingCPULow.BorderColor = Color.Blue;
            CustomRadioButtonSettingCPULow.CheckColor = Color.Blue;
            CustomRadioButtonSettingCPULow.ForeColor = Color.White;
            CustomRadioButtonSettingCPULow.Location = new Point(50, 180);
            CustomRadioButtonSettingCPULow.Name = "CustomRadioButtonSettingCPULow";
            CustomRadioButtonSettingCPULow.SelectionColor = Color.LightBlue;
            CustomRadioButtonSettingCPULow.Size = new Size(46, 17);
            CustomRadioButtonSettingCPULow.TabIndex = 5;
            CustomRadioButtonSettingCPULow.Text = "Low";
            CustomRadioButtonSettingCPULow.UseVisualStyleBackColor = false;
            // 
            // CustomRadioButtonSettingCPUBelowNormal
            // 
            CustomRadioButtonSettingCPUBelowNormal.BackColor = Color.DimGray;
            CustomRadioButtonSettingCPUBelowNormal.BorderColor = Color.Blue;
            CustomRadioButtonSettingCPUBelowNormal.CheckColor = Color.Blue;
            CustomRadioButtonSettingCPUBelowNormal.ForeColor = Color.White;
            CustomRadioButtonSettingCPUBelowNormal.Location = new Point(50, 155);
            CustomRadioButtonSettingCPUBelowNormal.Name = "CustomRadioButtonSettingCPUBelowNormal";
            CustomRadioButtonSettingCPUBelowNormal.SelectionColor = Color.LightBlue;
            CustomRadioButtonSettingCPUBelowNormal.Size = new Size(99, 17);
            CustomRadioButtonSettingCPUBelowNormal.TabIndex = 4;
            CustomRadioButtonSettingCPUBelowNormal.Text = "Below normal";
            CustomRadioButtonSettingCPUBelowNormal.UseVisualStyleBackColor = false;
            // 
            // CustomRadioButtonSettingCPUNormal
            // 
            CustomRadioButtonSettingCPUNormal.BackColor = Color.DimGray;
            CustomRadioButtonSettingCPUNormal.BorderColor = Color.Blue;
            CustomRadioButtonSettingCPUNormal.CheckColor = Color.Blue;
            CustomRadioButtonSettingCPUNormal.Checked = true;
            CustomRadioButtonSettingCPUNormal.ForeColor = Color.White;
            CustomRadioButtonSettingCPUNormal.Location = new Point(50, 130);
            CustomRadioButtonSettingCPUNormal.Name = "CustomRadioButtonSettingCPUNormal";
            CustomRadioButtonSettingCPUNormal.SelectionColor = Color.LightBlue;
            CustomRadioButtonSettingCPUNormal.Size = new Size(65, 17);
            CustomRadioButtonSettingCPUNormal.TabIndex = 3;
            CustomRadioButtonSettingCPUNormal.TabStop = true;
            CustomRadioButtonSettingCPUNormal.Text = "Normal";
            CustomRadioButtonSettingCPUNormal.UseVisualStyleBackColor = false;
            // 
            // CustomRadioButtonSettingCPUAboveNormal
            // 
            CustomRadioButtonSettingCPUAboveNormal.BackColor = Color.DimGray;
            CustomRadioButtonSettingCPUAboveNormal.BorderColor = Color.Blue;
            CustomRadioButtonSettingCPUAboveNormal.CheckColor = Color.Blue;
            CustomRadioButtonSettingCPUAboveNormal.ForeColor = Color.White;
            CustomRadioButtonSettingCPUAboveNormal.Location = new Point(50, 105);
            CustomRadioButtonSettingCPUAboveNormal.Name = "CustomRadioButtonSettingCPUAboveNormal";
            CustomRadioButtonSettingCPUAboveNormal.SelectionColor = Color.LightBlue;
            CustomRadioButtonSettingCPUAboveNormal.Size = new Size(101, 17);
            CustomRadioButtonSettingCPUAboveNormal.TabIndex = 2;
            CustomRadioButtonSettingCPUAboveNormal.Text = "Above normal";
            CustomRadioButtonSettingCPUAboveNormal.UseVisualStyleBackColor = false;
            // 
            // CustomRadioButtonSettingCPUHigh
            // 
            CustomRadioButtonSettingCPUHigh.BackColor = Color.DimGray;
            CustomRadioButtonSettingCPUHigh.BorderColor = Color.Blue;
            CustomRadioButtonSettingCPUHigh.CheckColor = Color.Blue;
            CustomRadioButtonSettingCPUHigh.ForeColor = Color.White;
            CustomRadioButtonSettingCPUHigh.Location = new Point(50, 80);
            CustomRadioButtonSettingCPUHigh.Name = "CustomRadioButtonSettingCPUHigh";
            CustomRadioButtonSettingCPUHigh.SelectionColor = Color.LightBlue;
            CustomRadioButtonSettingCPUHigh.Size = new Size(50, 17);
            CustomRadioButtonSettingCPUHigh.TabIndex = 1;
            CustomRadioButtonSettingCPUHigh.Text = "High";
            CustomRadioButtonSettingCPUHigh.UseVisualStyleBackColor = false;
            // 
            // CustomLabelSettingInfoCPU
            // 
            CustomLabelSettingInfoCPU.AutoSize = true;
            CustomLabelSettingInfoCPU.BackColor = Color.DimGray;
            CustomLabelSettingInfoCPU.Border = false;
            CustomLabelSettingInfoCPU.BorderColor = Color.Blue;
            CustomLabelSettingInfoCPU.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingInfoCPU.ForeColor = Color.White;
            CustomLabelSettingInfoCPU.Location = new Point(50, 35);
            CustomLabelSettingInfoCPU.Name = "CustomLabelSettingInfoCPU";
            CustomLabelSettingInfoCPU.RoundedCorners = 0;
            CustomLabelSettingInfoCPU.Size = new Size(132, 15);
            CustomLabelSettingInfoCPU.TabIndex = 0;
            CustomLabelSettingInfoCPU.Text = "Set processing priorities";
            // 
            // TabPageSettingsOthers
            // 
            TabPageSettingsOthers.BackColor = Color.Transparent;
            TabPageSettingsOthers.Controls.Add(SplitContainerSettingOthersMain);
            TabPageSettingsOthers.Location = new Point(99, 4);
            TabPageSettingsOthers.Name = "TabPageSettingsOthers";
            TabPageSettingsOthers.Padding = new Padding(3);
            TabPageSettingsOthers.Size = new Size(518, 357);
            TabPageSettingsOthers.TabIndex = 2;
            TabPageSettingsOthers.Tag = 10;
            TabPageSettingsOthers.Text = "Others";
            TabPageSettingsOthers.Visible = false;
            // 
            // SplitContainerSettingOthersMain
            // 
            SplitContainerSettingOthersMain.Dock = DockStyle.Fill;
            SplitContainerSettingOthersMain.FixedPanel = FixedPanel.Panel2;
            SplitContainerSettingOthersMain.IsSplitterFixed = true;
            SplitContainerSettingOthersMain.Location = new Point(3, 3);
            SplitContainerSettingOthersMain.Name = "SplitContainerSettingOthersMain";
            SplitContainerSettingOthersMain.Orientation = Orientation.Horizontal;
            // 
            // SplitContainerSettingOthersMain.Panel1
            // 
            SplitContainerSettingOthersMain.Panel1.AutoScroll = true;
            SplitContainerSettingOthersMain.Panel1.Controls.Add(CustomCheckBoxSettingAlertDisplayChanges);
            SplitContainerSettingOthersMain.Panel1.Controls.Add(CustomLabelSettingBootstrapDnsIP);
            SplitContainerSettingOthersMain.Panel1.Controls.Add(CustomCheckBoxSettingWriteLogWindowToFile);
            SplitContainerSettingOthersMain.Panel1.Controls.Add(CustomTextBoxSettingBootstrapDnsIP);
            SplitContainerSettingOthersMain.Panel1.Controls.Add(CustomNumericUpDownSettingFallbackDnsPort);
            SplitContainerSettingOthersMain.Panel1.Controls.Add(CustomLabelSettingFallbackDnsPort);
            SplitContainerSettingOthersMain.Panel1.Controls.Add(CustomCheckBoxSettingDisableAudioAlert);
            SplitContainerSettingOthersMain.Panel1.Controls.Add(CustomTextBoxSettingFallbackDnsIP);
            SplitContainerSettingOthersMain.Panel1.Controls.Add(CustomLabelSettingBootstrapDnsPort);
            SplitContainerSettingOthersMain.Panel1.Controls.Add(CustomLabelSettingFallbackDnsIP);
            SplitContainerSettingOthersMain.Panel1.Controls.Add(CustomNumericUpDownSettingBootstrapDnsPort);
            // 
            // SplitContainerSettingOthersMain.Panel2
            // 
            SplitContainerSettingOthersMain.Panel2.Controls.Add(CustomButtonSettingRestoreDefault);
            SplitContainerSettingOthersMain.Panel2.Controls.Add(CustomButtonImportUserData);
            SplitContainerSettingOthersMain.Panel2.Controls.Add(CustomButtonExportUserData);
            SplitContainerSettingOthersMain.Size = new Size(512, 351);
            SplitContainerSettingOthersMain.SplitterDistance = 304;
            SplitContainerSettingOthersMain.TabIndex = 23;
            // 
            // CustomCheckBoxSettingAlertDisplayChanges
            // 
            CustomCheckBoxSettingAlertDisplayChanges.BackColor = Color.DimGray;
            CustomCheckBoxSettingAlertDisplayChanges.BorderColor = Color.Blue;
            CustomCheckBoxSettingAlertDisplayChanges.CheckColor = Color.Blue;
            CustomCheckBoxSettingAlertDisplayChanges.ForeColor = Color.White;
            CustomCheckBoxSettingAlertDisplayChanges.Location = new Point(12, 163);
            CustomCheckBoxSettingAlertDisplayChanges.Name = "CustomCheckBoxSettingAlertDisplayChanges";
            CustomCheckBoxSettingAlertDisplayChanges.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingAlertDisplayChanges.Size = new Size(216, 17);
            CustomCheckBoxSettingAlertDisplayChanges.TabIndex = 19;
            CustomCheckBoxSettingAlertDisplayChanges.Text = "Alert display settings have changed.";
            CustomCheckBoxSettingAlertDisplayChanges.UseVisualStyleBackColor = false;
            // 
            // CustomLabelSettingBootstrapDnsIP
            // 
            CustomLabelSettingBootstrapDnsIP.AutoSize = true;
            CustomLabelSettingBootstrapDnsIP.BackColor = Color.DimGray;
            CustomLabelSettingBootstrapDnsIP.Border = false;
            CustomLabelSettingBootstrapDnsIP.BorderColor = Color.Blue;
            CustomLabelSettingBootstrapDnsIP.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingBootstrapDnsIP.ForeColor = Color.White;
            CustomLabelSettingBootstrapDnsIP.Location = new Point(12, 10);
            CustomLabelSettingBootstrapDnsIP.Name = "CustomLabelSettingBootstrapDnsIP";
            CustomLabelSettingBootstrapDnsIP.RoundedCorners = 0;
            CustomLabelSettingBootstrapDnsIP.Size = new Size(100, 15);
            CustomLabelSettingBootstrapDnsIP.TabIndex = 3;
            CustomLabelSettingBootstrapDnsIP.Text = "Bootstrap DNS IP:";
            // 
            // CustomCheckBoxSettingWriteLogWindowToFile
            // 
            CustomCheckBoxSettingWriteLogWindowToFile.BackColor = Color.DimGray;
            CustomCheckBoxSettingWriteLogWindowToFile.BorderColor = Color.Blue;
            CustomCheckBoxSettingWriteLogWindowToFile.CheckColor = Color.Blue;
            CustomCheckBoxSettingWriteLogWindowToFile.ForeColor = Color.White;
            CustomCheckBoxSettingWriteLogWindowToFile.Location = new Point(12, 134);
            CustomCheckBoxSettingWriteLogWindowToFile.Name = "CustomCheckBoxSettingWriteLogWindowToFile";
            CustomCheckBoxSettingWriteLogWindowToFile.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingWriteLogWindowToFile.Size = new Size(152, 17);
            CustomCheckBoxSettingWriteLogWindowToFile.TabIndex = 16;
            CustomCheckBoxSettingWriteLogWindowToFile.Text = "Write log window to file.";
            CustomCheckBoxSettingWriteLogWindowToFile.UseVisualStyleBackColor = false;
            // 
            // CustomTextBoxSettingBootstrapDnsIP
            // 
            CustomTextBoxSettingBootstrapDnsIP.AcceptsReturn = false;
            CustomTextBoxSettingBootstrapDnsIP.AcceptsTab = false;
            CustomTextBoxSettingBootstrapDnsIP.BackColor = Color.DimGray;
            CustomTextBoxSettingBootstrapDnsIP.Border = true;
            CustomTextBoxSettingBootstrapDnsIP.BorderColor = Color.Blue;
            CustomTextBoxSettingBootstrapDnsIP.BorderSize = 1;
            CustomTextBoxSettingBootstrapDnsIP.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxSettingBootstrapDnsIP.Font = new Font("Segoe UI", 9F);
            CustomTextBoxSettingBootstrapDnsIP.ForeColor = Color.White;
            CustomTextBoxSettingBootstrapDnsIP.HideSelection = true;
            CustomTextBoxSettingBootstrapDnsIP.Location = new Point(117, 8);
            CustomTextBoxSettingBootstrapDnsIP.MaxLength = 32767;
            CustomTextBoxSettingBootstrapDnsIP.Multiline = false;
            CustomTextBoxSettingBootstrapDnsIP.Name = "CustomTextBoxSettingBootstrapDnsIP";
            CustomTextBoxSettingBootstrapDnsIP.ReadOnly = false;
            CustomTextBoxSettingBootstrapDnsIP.RoundedCorners = 0;
            CustomTextBoxSettingBootstrapDnsIP.ScrollBars = ScrollBars.None;
            CustomTextBoxSettingBootstrapDnsIP.ShortcutsEnabled = true;
            CustomTextBoxSettingBootstrapDnsIP.Size = new Size(118, 23);
            CustomTextBoxSettingBootstrapDnsIP.TabIndex = 0;
            CustomTextBoxSettingBootstrapDnsIP.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxSettingBootstrapDnsIP.Texts = "8.8.8.8";
            CustomTextBoxSettingBootstrapDnsIP.UnderlinedStyle = true;
            CustomTextBoxSettingBootstrapDnsIP.UsePasswordChar = false;
            CustomTextBoxSettingBootstrapDnsIP.WordWrap = true;
            CustomTextBoxSettingBootstrapDnsIP.Leave += CustomTextBoxSettingBootstrapDnsIP_Leave;
            // 
            // CustomNumericUpDownSettingFallbackDnsPort
            // 
            CustomNumericUpDownSettingFallbackDnsPort.BackColor = Color.DimGray;
            CustomNumericUpDownSettingFallbackDnsPort.BorderColor = Color.Blue;
            CustomNumericUpDownSettingFallbackDnsPort.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownSettingFallbackDnsPort.Enabled = false;
            CustomNumericUpDownSettingFallbackDnsPort.Location = new Point(392, 58);
            CustomNumericUpDownSettingFallbackDnsPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            CustomNumericUpDownSettingFallbackDnsPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownSettingFallbackDnsPort.Name = "CustomNumericUpDownSettingFallbackDnsPort";
            CustomNumericUpDownSettingFallbackDnsPort.RoundedCorners = 5;
            CustomNumericUpDownSettingFallbackDnsPort.Size = new Size(53, 23);
            CustomNumericUpDownSettingFallbackDnsPort.TabIndex = 13;
            CustomNumericUpDownSettingFallbackDnsPort.Value = new decimal(new int[] { 53, 0, 0, 0 });
            // 
            // CustomLabelSettingFallbackDnsPort
            // 
            CustomLabelSettingFallbackDnsPort.AutoSize = true;
            CustomLabelSettingFallbackDnsPort.BackColor = Color.DimGray;
            CustomLabelSettingFallbackDnsPort.Border = false;
            CustomLabelSettingFallbackDnsPort.BorderColor = Color.Blue;
            CustomLabelSettingFallbackDnsPort.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingFallbackDnsPort.ForeColor = Color.White;
            CustomLabelSettingFallbackDnsPort.Location = new Point(272, 60);
            CustomLabelSettingFallbackDnsPort.Name = "CustomLabelSettingFallbackDnsPort";
            CustomLabelSettingFallbackDnsPort.RoundedCorners = 0;
            CustomLabelSettingFallbackDnsPort.Size = new Size(104, 15);
            CustomLabelSettingFallbackDnsPort.TabIndex = 12;
            CustomLabelSettingFallbackDnsPort.Text = "Fallback DNS Port:";
            // 
            // CustomCheckBoxSettingDisableAudioAlert
            // 
            CustomCheckBoxSettingDisableAudioAlert.BackColor = Color.DimGray;
            CustomCheckBoxSettingDisableAudioAlert.BorderColor = Color.Blue;
            CustomCheckBoxSettingDisableAudioAlert.CheckColor = Color.Blue;
            CustomCheckBoxSettingDisableAudioAlert.ForeColor = Color.White;
            CustomCheckBoxSettingDisableAudioAlert.Location = new Point(12, 104);
            CustomCheckBoxSettingDisableAudioAlert.Name = "CustomCheckBoxSettingDisableAudioAlert";
            CustomCheckBoxSettingDisableAudioAlert.SelectionColor = Color.LightBlue;
            CustomCheckBoxSettingDisableAudioAlert.Size = new Size(123, 17);
            CustomCheckBoxSettingDisableAudioAlert.TabIndex = 6;
            CustomCheckBoxSettingDisableAudioAlert.Text = "Disable audio alert.";
            CustomCheckBoxSettingDisableAudioAlert.UseVisualStyleBackColor = false;
            // 
            // CustomTextBoxSettingFallbackDnsIP
            // 
            CustomTextBoxSettingFallbackDnsIP.AcceptsReturn = false;
            CustomTextBoxSettingFallbackDnsIP.AcceptsTab = false;
            CustomTextBoxSettingFallbackDnsIP.BackColor = Color.DimGray;
            CustomTextBoxSettingFallbackDnsIP.Border = true;
            CustomTextBoxSettingFallbackDnsIP.BorderColor = Color.Blue;
            CustomTextBoxSettingFallbackDnsIP.BorderSize = 1;
            CustomTextBoxSettingFallbackDnsIP.CharacterCasing = CharacterCasing.Normal;
            CustomTextBoxSettingFallbackDnsIP.Enabled = false;
            CustomTextBoxSettingFallbackDnsIP.Font = new Font("Segoe UI", 9F);
            CustomTextBoxSettingFallbackDnsIP.ForeColor = Color.White;
            CustomTextBoxSettingFallbackDnsIP.HideSelection = true;
            CustomTextBoxSettingFallbackDnsIP.Location = new Point(117, 58);
            CustomTextBoxSettingFallbackDnsIP.MaxLength = 32767;
            CustomTextBoxSettingFallbackDnsIP.Multiline = false;
            CustomTextBoxSettingFallbackDnsIP.Name = "CustomTextBoxSettingFallbackDnsIP";
            CustomTextBoxSettingFallbackDnsIP.ReadOnly = false;
            CustomTextBoxSettingFallbackDnsIP.RoundedCorners = 0;
            CustomTextBoxSettingFallbackDnsIP.ScrollBars = ScrollBars.None;
            CustomTextBoxSettingFallbackDnsIP.ShortcutsEnabled = true;
            CustomTextBoxSettingFallbackDnsIP.Size = new Size(118, 23);
            CustomTextBoxSettingFallbackDnsIP.TabIndex = 0;
            CustomTextBoxSettingFallbackDnsIP.TextAlign = HorizontalAlignment.Left;
            CustomTextBoxSettingFallbackDnsIP.Texts = "8.8.8.8";
            CustomTextBoxSettingFallbackDnsIP.UnderlinedStyle = true;
            CustomTextBoxSettingFallbackDnsIP.UsePasswordChar = false;
            CustomTextBoxSettingFallbackDnsIP.WordWrap = true;
            // 
            // CustomLabelSettingBootstrapDnsPort
            // 
            CustomLabelSettingBootstrapDnsPort.AutoSize = true;
            CustomLabelSettingBootstrapDnsPort.BackColor = Color.DimGray;
            CustomLabelSettingBootstrapDnsPort.Border = false;
            CustomLabelSettingBootstrapDnsPort.BorderColor = Color.Blue;
            CustomLabelSettingBootstrapDnsPort.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingBootstrapDnsPort.ForeColor = Color.White;
            CustomLabelSettingBootstrapDnsPort.Location = new Point(272, 10);
            CustomLabelSettingBootstrapDnsPort.Name = "CustomLabelSettingBootstrapDnsPort";
            CustomLabelSettingBootstrapDnsPort.RoundedCorners = 0;
            CustomLabelSettingBootstrapDnsPort.Size = new Size(112, 15);
            CustomLabelSettingBootstrapDnsPort.TabIndex = 8;
            CustomLabelSettingBootstrapDnsPort.Text = "Bootstrap DNS Port:";
            // 
            // CustomLabelSettingFallbackDnsIP
            // 
            CustomLabelSettingFallbackDnsIP.AutoSize = true;
            CustomLabelSettingFallbackDnsIP.BackColor = Color.DimGray;
            CustomLabelSettingFallbackDnsIP.Border = false;
            CustomLabelSettingFallbackDnsIP.BorderColor = Color.Blue;
            CustomLabelSettingFallbackDnsIP.FlatStyle = FlatStyle.Flat;
            CustomLabelSettingFallbackDnsIP.ForeColor = Color.White;
            CustomLabelSettingFallbackDnsIP.Location = new Point(12, 60);
            CustomLabelSettingFallbackDnsIP.Name = "CustomLabelSettingFallbackDnsIP";
            CustomLabelSettingFallbackDnsIP.RoundedCorners = 0;
            CustomLabelSettingFallbackDnsIP.Size = new Size(92, 15);
            CustomLabelSettingFallbackDnsIP.TabIndex = 10;
            CustomLabelSettingFallbackDnsIP.Text = "Fallback DNS IP:";
            // 
            // CustomNumericUpDownSettingBootstrapDnsPort
            // 
            CustomNumericUpDownSettingBootstrapDnsPort.BackColor = Color.DimGray;
            CustomNumericUpDownSettingBootstrapDnsPort.BorderColor = Color.Blue;
            CustomNumericUpDownSettingBootstrapDnsPort.BorderStyle = BorderStyle.FixedSingle;
            CustomNumericUpDownSettingBootstrapDnsPort.Location = new Point(392, 8);
            CustomNumericUpDownSettingBootstrapDnsPort.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            CustomNumericUpDownSettingBootstrapDnsPort.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            CustomNumericUpDownSettingBootstrapDnsPort.Name = "CustomNumericUpDownSettingBootstrapDnsPort";
            CustomNumericUpDownSettingBootstrapDnsPort.RoundedCorners = 5;
            CustomNumericUpDownSettingBootstrapDnsPort.Size = new Size(53, 23);
            CustomNumericUpDownSettingBootstrapDnsPort.TabIndex = 9;
            CustomNumericUpDownSettingBootstrapDnsPort.Value = new decimal(new int[] { 53, 0, 0, 0 });
            // 
            // CustomButtonSettingRestoreDefault
            // 
            CustomButtonSettingRestoreDefault.BorderColor = Color.Blue;
            CustomButtonSettingRestoreDefault.FlatStyle = FlatStyle.Flat;
            CustomButtonSettingRestoreDefault.Location = new Point(3, 3);
            CustomButtonSettingRestoreDefault.Name = "CustomButtonSettingRestoreDefault";
            CustomButtonSettingRestoreDefault.RoundedCorners = 5;
            CustomButtonSettingRestoreDefault.SelectionColor = Color.LightBlue;
            CustomButtonSettingRestoreDefault.Size = new Size(171, 27);
            CustomButtonSettingRestoreDefault.TabIndex = 2;
            CustomButtonSettingRestoreDefault.Text = "Restore all settings to default";
            CustomButtonSettingRestoreDefault.UseVisualStyleBackColor = true;
            CustomButtonSettingRestoreDefault.Click += CustomButtonSettingRestoreDefault_Click;
            // 
            // CustomButtonImportUserData
            // 
            CustomButtonImportUserData.BorderColor = Color.Blue;
            CustomButtonImportUserData.FlatStyle = FlatStyle.Flat;
            CustomButtonImportUserData.Location = new Point(324, 3);
            CustomButtonImportUserData.Name = "CustomButtonImportUserData";
            CustomButtonImportUserData.RoundedCorners = 5;
            CustomButtonImportUserData.SelectionColor = Color.LightBlue;
            CustomButtonImportUserData.Size = new Size(106, 27);
            CustomButtonImportUserData.TabIndex = 20;
            CustomButtonImportUserData.Text = "Import user data";
            CustomButtonImportUserData.UseVisualStyleBackColor = true;
            CustomButtonImportUserData.Click += CustomButtonImportUserData_Click;
            // 
            // CustomButtonExportUserData
            // 
            CustomButtonExportUserData.BorderColor = Color.Blue;
            CustomButtonExportUserData.FlatStyle = FlatStyle.Flat;
            CustomButtonExportUserData.Location = new Point(214, 3);
            CustomButtonExportUserData.Name = "CustomButtonExportUserData";
            CustomButtonExportUserData.RoundedCorners = 5;
            CustomButtonExportUserData.SelectionColor = Color.LightBlue;
            CustomButtonExportUserData.Size = new Size(104, 27);
            CustomButtonExportUserData.TabIndex = 19;
            CustomButtonExportUserData.Text = "Export user data";
            CustomButtonExportUserData.UseVisualStyleBackColor = true;
            CustomButtonExportUserData.Click += CustomButtonExportUserData_Click;
            // 
            // TabPageAbout
            // 
            TabPageAbout.BackColor = Color.Transparent;
            TabPageAbout.BackgroundImageLayout = ImageLayout.Stretch;
            TabPageAbout.Controls.Add(LinkLabelStNonbarbari);
            TabPageAbout.Controls.Add(LinkLabelStWolfkingal2000);
            TabPageAbout.Controls.Add(CustomLabelAboutVersion);
            TabPageAbout.Controls.Add(PictureBoxFarvahar);
            TabPageAbout.Controls.Add(CustomLabelAboutCopyright);
            TabPageAbout.Controls.Add(LinkLabelStAlidxdydz);
            TabPageAbout.Controls.Add(CustomLabelAboutSpecialThanks);
            TabPageAbout.Controls.Add(LinkLabelGoodbyeDPI);
            TabPageAbout.Controls.Add(LinkLabelDNSLookup);
            TabPageAbout.Controls.Add(CustomLabelAboutUsing);
            TabPageAbout.Controls.Add(CustomLabelAboutThis2);
            TabPageAbout.Controls.Add(CustomLabelAboutThis);
            TabPageAbout.Controls.Add(PictureBoxAbout);
            TabPageAbout.Location = new Point(4, 25);
            TabPageAbout.Name = "TabPageAbout";
            TabPageAbout.Padding = new Padding(3);
            TabPageAbout.Size = new Size(771, 371);
            TabPageAbout.TabIndex = 2;
            TabPageAbout.Tag = 3;
            TabPageAbout.Text = "About";
            TabPageAbout.Visible = false;
            // 
            // LinkLabelStNonbarbari
            // 
            LinkLabelStNonbarbari.AutoSize = true;
            LinkLabelStNonbarbari.LinkBehavior = LinkBehavior.NeverUnderline;
            LinkLabelStNonbarbari.Location = new Point(461, 214);
            LinkLabelStNonbarbari.Name = "LinkLabelStNonbarbari";
            LinkLabelStNonbarbari.Size = new Size(67, 15);
            LinkLabelStNonbarbari.TabIndex = 14;
            LinkLabelStNonbarbari.TabStop = true;
            LinkLabelStNonbarbari.Text = "Nonbarbari";
            LinkLabelStNonbarbari.LinkClicked += LinkLabelStNonbarbari_LinkClicked;
            // 
            // LinkLabelStWolfkingal2000
            // 
            LinkLabelStWolfkingal2000.AutoSize = true;
            LinkLabelStWolfkingal2000.LinkBehavior = LinkBehavior.NeverUnderline;
            LinkLabelStWolfkingal2000.Location = new Point(461, 193);
            LinkLabelStWolfkingal2000.Name = "LinkLabelStWolfkingal2000";
            LinkLabelStWolfkingal2000.Size = new Size(88, 15);
            LinkLabelStWolfkingal2000.TabIndex = 13;
            LinkLabelStWolfkingal2000.TabStop = true;
            LinkLabelStWolfkingal2000.Text = "Wolfkingal2000";
            LinkLabelStWolfkingal2000.LinkClicked += LinkLabelStWolfkingal2000_LinkClicked;
            // 
            // CustomLabelAboutVersion
            // 
            CustomLabelAboutVersion.AutoSize = true;
            CustomLabelAboutVersion.BackColor = Color.DimGray;
            CustomLabelAboutVersion.Border = false;
            CustomLabelAboutVersion.BorderColor = Color.Blue;
            CustomLabelAboutVersion.FlatStyle = FlatStyle.Flat;
            CustomLabelAboutVersion.ForeColor = Color.White;
            CustomLabelAboutVersion.Location = new Point(600, 51);
            CustomLabelAboutVersion.Name = "CustomLabelAboutVersion";
            CustomLabelAboutVersion.RoundedCorners = 0;
            CustomLabelAboutVersion.Size = new Size(45, 15);
            CustomLabelAboutVersion.TabIndex = 7;
            CustomLabelAboutVersion.Text = "Version";
            // 
            // PictureBoxFarvahar
            // 
            PictureBoxFarvahar.Image = Properties.Resources.FarvaharBlueRed;
            PictureBoxFarvahar.Location = new Point(55, 230);
            PictureBoxFarvahar.Name = "PictureBoxFarvahar";
            PictureBoxFarvahar.Size = new Size(128, 60);
            PictureBoxFarvahar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxFarvahar.TabIndex = 12;
            PictureBoxFarvahar.TabStop = false;
            // 
            // CustomLabelAboutCopyright
            // 
            CustomLabelAboutCopyright.AutoSize = true;
            CustomLabelAboutCopyright.BackColor = Color.DimGray;
            CustomLabelAboutCopyright.Border = false;
            CustomLabelAboutCopyright.BorderColor = Color.Blue;
            CustomLabelAboutCopyright.FlatStyle = FlatStyle.Flat;
            CustomLabelAboutCopyright.ForeColor = Color.White;
            CustomLabelAboutCopyright.Location = new Point(55, 185);
            CustomLabelAboutCopyright.Name = "CustomLabelAboutCopyright";
            CustomLabelAboutCopyright.RoundedCorners = 0;
            CustomLabelAboutCopyright.Size = new Size(144, 30);
            CustomLabelAboutCopyright.TabIndex = 11;
            CustomLabelAboutCopyright.Text = "© 2023 - 2025 MSasanMH\r\nLicense: GPLv3";
            // 
            // LinkLabelStAlidxdydz
            // 
            LinkLabelStAlidxdydz.AutoSize = true;
            LinkLabelStAlidxdydz.LinkBehavior = LinkBehavior.NeverUnderline;
            LinkLabelStAlidxdydz.Location = new Point(461, 172);
            LinkLabelStAlidxdydz.Name = "LinkLabelStAlidxdydz";
            LinkLabelStAlidxdydz.Size = new Size(58, 15);
            LinkLabelStAlidxdydz.TabIndex = 10;
            LinkLabelStAlidxdydz.TabStop = true;
            LinkLabelStAlidxdydz.Text = "Alidxdydz";
            LinkLabelStAlidxdydz.LinkClicked += LinkLabelStAlidxdydz_LinkClicked;
            // 
            // CustomLabelAboutSpecialThanks
            // 
            CustomLabelAboutSpecialThanks.AutoSize = true;
            CustomLabelAboutSpecialThanks.BackColor = Color.DimGray;
            CustomLabelAboutSpecialThanks.Border = false;
            CustomLabelAboutSpecialThanks.BorderColor = Color.Blue;
            CustomLabelAboutSpecialThanks.FlatStyle = FlatStyle.Flat;
            CustomLabelAboutSpecialThanks.ForeColor = Color.White;
            CustomLabelAboutSpecialThanks.Location = new Point(446, 135);
            CustomLabelAboutSpecialThanks.Name = "CustomLabelAboutSpecialThanks";
            CustomLabelAboutSpecialThanks.RoundedCorners = 0;
            CustomLabelAboutSpecialThanks.Size = new Size(81, 120);
            CustomLabelAboutSpecialThanks.TabIndex = 9;
            CustomLabelAboutSpecialThanks.Text = "special thanks\r\n{\r\n\r\n\r\n\r\n\r\n\r\n}";
            // 
            // LinkLabelGoodbyeDPI
            // 
            LinkLabelGoodbyeDPI.AutoSize = true;
            LinkLabelGoodbyeDPI.LinkBehavior = LinkBehavior.NeverUnderline;
            LinkLabelGoodbyeDPI.Location = new Point(285, 193);
            LinkLabelGoodbyeDPI.Name = "LinkLabelGoodbyeDPI";
            LinkLabelGoodbyeDPI.Size = new Size(76, 15);
            LinkLabelGoodbyeDPI.TabIndex = 6;
            LinkLabelGoodbyeDPI.TabStop = true;
            LinkLabelGoodbyeDPI.Text = "GoodbyeDPI;";
            LinkLabelGoodbyeDPI.LinkClicked += LinkLabelGoodbyeDPI_LinkClicked;
            // 
            // LinkLabelDNSLookup
            // 
            LinkLabelDNSLookup.AutoSize = true;
            LinkLabelDNSLookup.LinkBehavior = LinkBehavior.NeverUnderline;
            LinkLabelDNSLookup.Location = new Point(285, 172);
            LinkLabelDNSLookup.Name = "LinkLabelDNSLookup";
            LinkLabelDNSLookup.Size = new Size(73, 15);
            LinkLabelDNSLookup.TabIndex = 3;
            LinkLabelDNSLookup.TabStop = true;
            LinkLabelDNSLookup.Text = "DNSLookup;";
            LinkLabelDNSLookup.LinkClicked += LinkLabelDNSLookup_LinkClicked;
            // 
            // CustomLabelAboutUsing
            // 
            CustomLabelAboutUsing.AutoSize = true;
            CustomLabelAboutUsing.BackColor = Color.DimGray;
            CustomLabelAboutUsing.Border = false;
            CustomLabelAboutUsing.BorderColor = Color.Blue;
            CustomLabelAboutUsing.FlatStyle = FlatStyle.Flat;
            CustomLabelAboutUsing.ForeColor = Color.White;
            CustomLabelAboutUsing.Location = new Point(270, 135);
            CustomLabelAboutUsing.Name = "CustomLabelAboutUsing";
            CustomLabelAboutUsing.RoundedCorners = 0;
            CustomLabelAboutUsing.Size = new Size(36, 90);
            CustomLabelAboutUsing.TabIndex = 8;
            CustomLabelAboutUsing.Text = "using\r\n{\r\n\r\n\r\n\r\n}";
            // 
            // CustomLabelAboutThis2
            // 
            CustomLabelAboutThis2.AutoSize = true;
            CustomLabelAboutThis2.BackColor = Color.Transparent;
            CustomLabelAboutThis2.Border = false;
            CustomLabelAboutThis2.BorderColor = Color.Blue;
            CustomLabelAboutThis2.FlatStyle = FlatStyle.Flat;
            CustomLabelAboutThis2.ForeColor = Color.IndianRed;
            CustomLabelAboutThis2.Location = new Point(235, 75);
            CustomLabelAboutThis2.Name = "CustomLabelAboutThis2";
            CustomLabelAboutThis2.RoundedCorners = 0;
            CustomLabelAboutThis2.Size = new Size(460, 15);
            CustomLabelAboutThis2.TabIndex = 2;
            CustomLabelAboutThis2.Text = "A DNS Client, Supporting Anonymized DNSCrypt, DNSCrypt, DoH, DoT, UDP and TCP.";
            // 
            // CustomLabelAboutThis
            // 
            CustomLabelAboutThis.AutoSize = true;
            CustomLabelAboutThis.BackColor = Color.Transparent;
            CustomLabelAboutThis.Border = false;
            CustomLabelAboutThis.BorderColor = Color.Blue;
            CustomLabelAboutThis.Cursor = Cursors.Hand;
            CustomLabelAboutThis.FlatStyle = FlatStyle.Flat;
            CustomLabelAboutThis.Font = new Font("Verdana", 19F, FontStyle.Bold);
            CustomLabelAboutThis.ForeColor = Color.DodgerBlue;
            CustomLabelAboutThis.Location = new Point(235, 33);
            CustomLabelAboutThis.Name = "CustomLabelAboutThis";
            CustomLabelAboutThis.RoundedCorners = 0;
            CustomLabelAboutThis.Size = new Size(367, 32);
            CustomLabelAboutThis.TabIndex = 1;
            CustomLabelAboutThis.Text = "SDC - Secure DNS Client";
            CustomLabelAboutThis.Click += CustomLabelAboutThis_Click;
            // 
            // PictureBoxAbout
            // 
            PictureBoxAbout.Image = Properties.Resources.SecureDNSClient_PNG;
            PictureBoxAbout.Location = new Point(55, 35);
            PictureBoxAbout.Name = "PictureBoxAbout";
            PictureBoxAbout.Size = new Size(128, 128);
            PictureBoxAbout.TabIndex = 0;
            PictureBoxAbout.TabStop = false;
            // 
            // CustomDataGridViewStatus
            // 
            CustomDataGridViewStatus.AllowUserToAddRows = false;
            CustomDataGridViewStatus.AllowUserToDeleteRows = false;
            CustomDataGridViewStatus.AllowUserToResizeColumns = false;
            CustomDataGridViewStatus.AllowUserToResizeRows = false;
            CustomDataGridViewStatus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CustomDataGridViewStatus.BorderColor = Color.Blue;
            CustomDataGridViewStatus.CheckColor = Color.Blue;
            CustomDataGridViewStatus.ColumnHeadersBorder = true;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(73, 73, 73);
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = Color.White;
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(73, 73, 73);
            dataGridViewCellStyle19.SelectionForeColor = Color.White;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            CustomDataGridViewStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            CustomDataGridViewStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomDataGridViewStatus.ColumnHeadersVisible = false;
            CustomDataGridViewStatus.Columns.AddRange(new DataGridViewColumn[] { ColumnStatusName, ColumnStatusText });
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = Color.DimGray;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = Color.White;
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(97, 177, 255);
            dataGridViewCellStyle20.SelectionForeColor = Color.White;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            CustomDataGridViewStatus.DefaultCellStyle = dataGridViewCellStyle20;
            CustomDataGridViewStatus.Dock = DockStyle.Fill;
            CustomDataGridViewStatus.GridColor = Color.LightBlue;
            CustomDataGridViewStatus.Location = new Point(0, 0);
            CustomDataGridViewStatus.MultiSelect = false;
            CustomDataGridViewStatus.Name = "CustomDataGridViewStatus";
            CustomDataGridViewStatus.ReadOnly = true;
            CustomDataGridViewStatus.RowHeadersVisible = false;
            CustomDataGridViewStatus.RowTemplate.Height = 25;
            CustomDataGridViewStatus.ScrollBars = ScrollBars.Vertical;
            CustomDataGridViewStatus.SelectionColor = Color.DodgerBlue;
            CustomDataGridViewStatus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomDataGridViewStatus.SelectionModeFocus = false;
            CustomDataGridViewStatus.ShowCellErrors = false;
            CustomDataGridViewStatus.ShowCellToolTips = false;
            CustomDataGridViewStatus.ShowEditingIcon = false;
            CustomDataGridViewStatus.ShowRowErrors = false;
            CustomDataGridViewStatus.Size = new Size(195, 329);
            CustomDataGridViewStatus.TabIndex = 18;
            // 
            // ColumnStatusName
            // 
            ColumnStatusName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnStatusName.HeaderText = "Status Name";
            ColumnStatusName.Name = "ColumnStatusName";
            ColumnStatusName.ReadOnly = true;
            ColumnStatusName.Resizable = DataGridViewTriState.False;
            ColumnStatusName.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnStatusName.Width = 5;
            // 
            // ColumnStatusText
            // 
            ColumnStatusText.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ColumnStatusText.HeaderText = "Status Text";
            ColumnStatusText.Name = "ColumnStatusText";
            ColumnStatusText.ReadOnly = true;
            ColumnStatusText.Resizable = DataGridViewTriState.False;
            ColumnStatusText.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnStatusText.Width = 5;
            // 
            // NotifyIconMain
            // 
            NotifyIconMain.ContextMenuStrip = CustomContextMenuStripIcon;
            NotifyIconMain.Icon = (Icon)resources.GetObject("NotifyIconMain.Icon");
            NotifyIconMain.Visible = true;
            NotifyIconMain.MouseClick += NotifyIconMain_MouseClick;
            // 
            // CustomContextMenuStripIcon
            // 
            CustomContextMenuStripIcon.BackColor = Color.DimGray;
            CustomContextMenuStripIcon.BorderColor = Color.Blue;
            CustomContextMenuStripIcon.ForeColor = Color.White;
            CustomContextMenuStripIcon.ImageScalingSize = new Size(20, 20);
            CustomContextMenuStripIcon.Name = "CustomContextMenuStripIcon";
            CustomContextMenuStripIcon.RoundedCorners = 5;
            CustomContextMenuStripIcon.SameColorForSubItems = true;
            CustomContextMenuStripIcon.SelectionColor = Color.LightBlue;
            CustomContextMenuStripIcon.Size = new Size(61, 4);
            // 
            // CustomGroupBoxStatus
            // 
            CustomGroupBoxStatus.BorderColor = Color.Blue;
            CustomGroupBoxStatus.Controls.Add(SplitContainerStatusMain);
            CustomGroupBoxStatus.Dock = DockStyle.Fill;
            CustomGroupBoxStatus.Location = new Point(0, 0);
            CustomGroupBoxStatus.Margin = new Padding(1);
            CustomGroupBoxStatus.Name = "CustomGroupBoxStatus";
            CustomGroupBoxStatus.RoundedCorners = 5;
            CustomGroupBoxStatus.Size = new Size(201, 400);
            CustomGroupBoxStatus.TabIndex = 8;
            CustomGroupBoxStatus.TabStop = false;
            CustomGroupBoxStatus.Text = "Status";
            // 
            // SplitContainerStatusMain
            // 
            SplitContainerStatusMain.Dock = DockStyle.Fill;
            SplitContainerStatusMain.FixedPanel = FixedPanel.Panel2;
            SplitContainerStatusMain.IsSplitterFixed = true;
            SplitContainerStatusMain.Location = new Point(3, 19);
            SplitContainerStatusMain.Name = "SplitContainerStatusMain";
            SplitContainerStatusMain.Orientation = Orientation.Horizontal;
            // 
            // SplitContainerStatusMain.Panel1
            // 
            SplitContainerStatusMain.Panel1.Controls.Add(CustomDataGridViewStatus);
            // 
            // SplitContainerStatusMain.Panel2
            // 
            SplitContainerStatusMain.Panel2.Controls.Add(CustomButtonExit);
            SplitContainerStatusMain.Panel2.Controls.Add(CustomButtonProcessMonitor);
            SplitContainerStatusMain.Size = new Size(195, 378);
            SplitContainerStatusMain.SplitterDistance = 329;
            SplitContainerStatusMain.TabIndex = 0;
            // 
            // CustomButtonExit
            // 
            CustomButtonExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CustomButtonExit.BorderColor = Color.Blue;
            CustomButtonExit.FlatStyle = FlatStyle.Flat;
            CustomButtonExit.Location = new Point(147, 2);
            CustomButtonExit.Name = "CustomButtonExit";
            CustomButtonExit.RoundedCorners = 5;
            CustomButtonExit.SelectionColor = Color.LightBlue;
            CustomButtonExit.Size = new Size(45, 27);
            CustomButtonExit.TabIndex = 22;
            CustomButtonExit.Text = "Exit";
            CustomButtonExit.UseVisualStyleBackColor = true;
            CustomButtonExit.Click += CustomButtonExit_Click;
            // 
            // CustomButtonProcessMonitor
            // 
            CustomButtonProcessMonitor.BorderColor = Color.Blue;
            CustomButtonProcessMonitor.FlatStyle = FlatStyle.Flat;
            CustomButtonProcessMonitor.Location = new Point(3, 3);
            CustomButtonProcessMonitor.Name = "CustomButtonProcessMonitor";
            CustomButtonProcessMonitor.RoundedCorners = 5;
            CustomButtonProcessMonitor.SelectionColor = Color.LightBlue;
            CustomButtonProcessMonitor.Size = new Size(62, 27);
            CustomButtonProcessMonitor.TabIndex = 20;
            CustomButtonProcessMonitor.Text = "Net Info";
            CustomButtonProcessMonitor.UseVisualStyleBackColor = true;
            CustomButtonProcessMonitor.Click += CustomButtonProcessMonitor_Click;
            // 
            // SplitContainerMain
            // 
            SplitContainerMain.BackColor = Color.IndianRed;
            SplitContainerMain.Dock = DockStyle.Fill;
            SplitContainerMain.Location = new Point(0, 0);
            SplitContainerMain.Name = "SplitContainerMain";
            SplitContainerMain.Orientation = Orientation.Horizontal;
            // 
            // SplitContainerMain.Panel1
            // 
            SplitContainerMain.Panel1.Controls.Add(SplitContainerTop);
            SplitContainerMain.Panel1MinSize = 400;
            // 
            // SplitContainerMain.Panel2
            // 
            SplitContainerMain.Panel2.Controls.Add(CustomGroupBoxLog);
            SplitContainerMain.Panel2MinSize = 100;
            SplitContainerMain.Size = new Size(984, 581);
            SplitContainerMain.SplitterDistance = 400;
            SplitContainerMain.TabIndex = 9;
            // 
            // SplitContainerTop
            // 
            SplitContainerTop.BackColor = Color.DimGray;
            SplitContainerTop.Dock = DockStyle.Fill;
            SplitContainerTop.FixedPanel = FixedPanel.Panel2;
            SplitContainerTop.IsSplitterFixed = true;
            SplitContainerTop.Location = new Point(0, 0);
            SplitContainerTop.Name = "SplitContainerTop";
            // 
            // SplitContainerTop.Panel1
            // 
            SplitContainerTop.Panel1.Controls.Add(CustomTabControlMain);
            SplitContainerTop.Panel1MinSize = 678;
            // 
            // SplitContainerTop.Panel2
            // 
            SplitContainerTop.Panel2.Controls.Add(CustomGroupBoxStatus);
            SplitContainerTop.Panel2MinSize = 150;
            SplitContainerTop.Size = new Size(984, 400);
            SplitContainerTop.SplitterDistance = 779;
            SplitContainerTop.TabIndex = 0;
            // 
            // FormMain
            // 
            AcceptButton = CustomButtonQuickConnect;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.DimGray;
            ClientSize = new Size(984, 581);
            Controls.Add(SplitContainerMain);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 620);
            Name = "FormMain";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "SecureDNSClient";
            FormClosing += FormMain_FormClosing;
            SplitContainerShareMain.Panel1.ResumeLayout(false);
            SplitContainerShareMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerShareMain).EndInit();
            SplitContainerShareMain.ResumeLayout(false);
            SplitContainerShareTop.Panel1.ResumeLayout(false);
            SplitContainerShareTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerShareTop).EndInit();
            SplitContainerShareTop.ResumeLayout(false);
            SplitContainerShareContent.Panel1.ResumeLayout(false);
            SplitContainerShareContent.Panel1.PerformLayout();
            SplitContainerShareContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerShareContent).EndInit();
            SplitContainerShareContent.ResumeLayout(false);
            CustomTabControlShareDpiBypassOptions.ResumeLayout(false);
            TabPageShareFragment.ResumeLayout(false);
            TabPageShareFragment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownPDpiFragDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownPDpiAntiPatternOffset).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownPDpiSniChunks).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownPDpiBeforeSniChunks).EndInit();
            TabPageShareSslDecryption.ResumeLayout(false);
            TabPageShareSslDecryption.PerformLayout();
            CustomGroupBoxShareRulesStatus.ResumeLayout(false);
            SplitContainerShareRulesStatus1.Panel1.ResumeLayout(false);
            SplitContainerShareRulesStatus1.Panel1.PerformLayout();
            SplitContainerShareRulesStatus1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerShareRulesStatus1).EndInit();
            SplitContainerShareRulesStatus1.ResumeLayout(false);
            SplitContainerShareRulesStatus2.Panel1.ResumeLayout(false);
            SplitContainerShareRulesStatus2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerShareRulesStatus2).EndInit();
            SplitContainerShareRulesStatus2.ResumeLayout(false);
            CustomGroupBoxLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSSLFragmentSize).EndInit();
            CustomTabControlMain.ResumeLayout(false);
            TabPageSecureDNS.ResumeLayout(false);
            CustomTabControlSecureDNS.ResumeLayout(false);
            TabPageCheck.ResumeLayout(false);
            SplitContainerCheckMain.Panel1.ResumeLayout(false);
            SplitContainerCheckMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerCheckMain).EndInit();
            SplitContainerCheckMain.ResumeLayout(false);
            SplitContainerCheckTop.Panel1.ResumeLayout(false);
            SplitContainerCheckTop.Panel1.PerformLayout();
            SplitContainerCheckTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerCheckTop).EndInit();
            SplitContainerCheckTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownCheckInParallel).EndInit();
            CustomGroupBoxCheckStatus.ResumeLayout(false);
            TabPageConnect.ResumeLayout(false);
            SplitContainerConnectMain.Panel1.ResumeLayout(false);
            SplitContainerConnectMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerConnectMain).EndInit();
            SplitContainerConnectMain.ResumeLayout(false);
            SplitContainerConnectTop.Panel1.ResumeLayout(false);
            SplitContainerConnectTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerConnectTop).EndInit();
            SplitContainerConnectTop.ResumeLayout(false);
            CustomGroupBoxConnectStatus.ResumeLayout(false);
            TabPageSetDNS.ResumeLayout(false);
            SplitContainerSetDnsMain.Panel1.ResumeLayout(false);
            SplitContainerSetDnsMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerSetDnsMain).EndInit();
            SplitContainerSetDnsMain.ResumeLayout(false);
            SplitContainerSetDnsTop.Panel1.ResumeLayout(false);
            SplitContainerSetDnsTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerSetDnsTop).EndInit();
            SplitContainerSetDnsTop.ResumeLayout(false);
            FlowLayoutPanelSetDns.ResumeLayout(false);
            FlowLayoutPanelSetDns.PerformLayout();
            CustomGroupBoxNicStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomDataGridViewNicStatus).EndInit();
            TabPageShare.ResumeLayout(false);
            TabPageGoodbyeDPI.ResumeLayout(false);
            CustomTabControlDPIBasicAdvanced.ResumeLayout(false);
            TabPageDPIBasic.ResumeLayout(false);
            SplitContainerGoodbyeDpiBasicMain.Panel1.ResumeLayout(false);
            SplitContainerGoodbyeDpiBasicMain.Panel1.PerformLayout();
            SplitContainerGoodbyeDpiBasicMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerGoodbyeDpiBasicMain).EndInit();
            SplitContainerGoodbyeDpiBasicMain.ResumeLayout(false);
            TabPageDPIAdvanced.ResumeLayout(false);
            SplitContainerGoodbyeDpiAdvancedMain.Panel1.ResumeLayout(false);
            SplitContainerGoodbyeDpiAdvancedMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerGoodbyeDpiAdvancedMain).EndInit();
            SplitContainerGoodbyeDpiAdvancedMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownDPIAdvMaxPayload).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownDPIAdvMinTTL).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownDPIAdvSetTTL).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownDPIAdvPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownDPIAdvF).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownDPIAdvK).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownDPIAdvE).EndInit();
            TabPageTools.ResumeLayout(false);
            TabPageSettings.ResumeLayout(false);
            SplitContainerSettings.Panel1.ResumeLayout(false);
            SplitContainerSettings.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerSettings).EndInit();
            SplitContainerSettings.ResumeLayout(false);
            CustomTabControlSettings.ResumeLayout(false);
            TabPageSettingsWorkingMode.ResumeLayout(false);
            TabPageSettingsWorkingMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingWorkingModeSetDohPort).EndInit();
            TabPageSettingsCheck.ResumeLayout(false);
            TabPageSettingsCheck.PerformLayout();
            CustomGroupBoxSettingCheckDnsProtocol.ResumeLayout(false);
            CustomGroupBoxSettingCheckSDNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingCheckTimeout).EndInit();
            TabPageSettingsQuickConnect.ResumeLayout(false);
            SplitContainerSettingQcMain.Panel1.ResumeLayout(false);
            SplitContainerSettingQcMain.Panel1.PerformLayout();
            SplitContainerSettingQcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerSettingQcMain).EndInit();
            SplitContainerSettingQcMain.ResumeLayout(false);
            TabPageSettingsConnect.ResumeLayout(false);
            TabPageSettingsConnect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingMaxServers).EndInit();
            TabPageSettingsSetUnsetDNS.ResumeLayout(false);
            TabPageSettingsSetUnsetDNS.PerformLayout();
            TabPageSettingsShare.ResumeLayout(false);
            CustomTabControlSettingProxy.ResumeLayout(false);
            TabPageSettingProxyBasic.ResumeLayout(false);
            TabPageSettingProxyBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingProxyKillRequestTimeout).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingProxyUpstreamPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingProxyPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingProxyHandleRequests).EndInit();
            TabPageSettingsFakeProxy.ResumeLayout(false);
            TabPageSettingsFakeProxy.PerformLayout();
            TabPageSettingsRules.ResumeLayout(false);
            TabPageSettingsRules.PerformLayout();
            FlowLayoutPanelRules.ResumeLayout(false);
            FlowLayoutPanelRules.PerformLayout();
            FlowLayoutPanelRules2.ResumeLayout(false);
            FlowLayoutPanelRules3.ResumeLayout(false);
            FlowLayoutPanelRules3.PerformLayout();
            TabPageSettingsGeoAssets.ResumeLayout(false);
            FlowLayoutPanelGeoAssets.ResumeLayout(false);
            FlowLayoutPanelGeoAssets.PerformLayout();
            FlowLayoutPanelGeoAssets2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownGeoAssetsUpdate).EndInit();
            TabPageSettingsCPU.ResumeLayout(false);
            TabPageSettingsCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownUpdateAutoDelayMS).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingCpuKillProxyRequests).EndInit();
            TabPageSettingsOthers.ResumeLayout(false);
            SplitContainerSettingOthersMain.Panel1.ResumeLayout(false);
            SplitContainerSettingOthersMain.Panel1.PerformLayout();
            SplitContainerSettingOthersMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerSettingOthersMain).EndInit();
            SplitContainerSettingOthersMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingFallbackDnsPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomNumericUpDownSettingBootstrapDnsPort).EndInit();
            TabPageAbout.ResumeLayout(false);
            TabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxFarvahar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAbout).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomDataGridViewStatus).EndInit();
            CustomGroupBoxStatus.ResumeLayout(false);
            SplitContainerStatusMain.Panel1.ResumeLayout(false);
            SplitContainerStatusMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerStatusMain).EndInit();
            SplitContainerStatusMain.ResumeLayout(false);
            SplitContainerMain.Panel1.ResumeLayout(false);
            SplitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerMain).EndInit();
            SplitContainerMain.ResumeLayout(false);
            SplitContainerTop.Panel1.ResumeLayout(false);
            SplitContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplitContainerTop).EndInit();
            SplitContainerTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CustomControls.CustomRichTextBox CustomRichTextBoxLog;
        private CustomControls.CustomButton CustomButtonCheck;
        private CustomControls.CustomGroupBox CustomGroupBoxLog;
        private CustomControls.CustomRadioButton CustomRadioButtonBuiltIn;
        private CustomControls.CustomRadioButton CustomRadioButtonCustom;
        private CustomControls.CustomButton CustomButtonEditCustomServers;
        private CustomControls.CustomLabel CustomLabelCustomServersInfo;
        private CustomControls.CustomButton CustomButtonConnect;
        private CustomControls.CustomTabControl CustomTabControlMain;
        private TabPage TabPageSecureDNS;
        private TabPage TabPageSettings;
        private CustomControls.CustomLabel CustomLabelDPIModes;
        private CustomControls.CustomRadioButton CustomRadioButtonDPIModeLight;
        private CustomControls.CustomRadioButton CustomRadioButtonDPIModeMedium;
        private CustomControls.CustomRadioButton CustomRadioButtonDPIModeHigh;
        private CustomControls.CustomRadioButton CustomRadioButtonDPIModeExtreme;
        private CustomControls.CustomLabel CustomLabelSelectNIC;
        private CustomControls.CustomComboBox CustomComboBoxNICs;
        private CustomControls.CustomButton CustomButtonSetDNS;
        private CustomControls.CustomCheckBox CustomCheckBoxInsecure;
        private CustomControls.CustomTextBox CustomTextBoxHTTPProxy;
        private CustomControls.CustomLabel CustomLabelSSLFragmentSize;
        private TabPage TabPageAbout;
        private CustomControls.CustomButton CustomButtonSettingRestoreDefault;
        private CustomControls.CustomTabControl CustomTabControlSecureDNS;
        private TabPage TabPageCheck;
        private TabPage TabPageConnect;
        private TabPage TabPageGoodbyeDPI;
        private TabPage TabPageSetDNS;
        private CustomControls.CustomTabControl CustomTabControlDPIBasicAdvanced;
        private TabPage TabPageDPIBasic;
        private TabPage TabPageDPIAdvanced;
        private CustomControls.CustomButton CustomButtonDPIBasicActivate;
        private CustomControls.CustomButton CustomButtonDPIBasicDeactivate;
        private CustomControls.CustomRadioButton CustomRadioButtonDPIMode2;
        private CustomControls.CustomRadioButton CustomRadioButtonDPIMode1;
        private CustomControls.CustomLabel CustomLabelDPIModesGoodbyeDPI;
        private CustomControls.CustomRadioButton CustomRadioButtonDPIMode3;
        private CustomControls.CustomRadioButton CustomRadioButtonDPIMode6;
        private CustomControls.CustomRadioButton CustomRadioButtonDPIMode5;
        private CustomControls.CustomRadioButton CustomRadioButtonDPIMode4;
        private CustomControls.CustomButton CustomButtonDPIAdvDeactivate;
        private CustomControls.CustomButton CustomButtonDPIAdvActivate;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownSSLFragmentSize;
        private CustomControls.CustomTextBox CustomTextBoxDPIAdvAutoTTL;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvR;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvP;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvS;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvM;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownDPIAdvK;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvK;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownDPIAdvF;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvF;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvN;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvE;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownDPIAdvE;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvA;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvW;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvPort;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvIpId;
        private CustomControls.CustomTextBox CustomTextBoxDPIAdvIpId;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvAllowNoSNI;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvSetTTL;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvAutoTTL;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvMinTTL;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvWrongChksum;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvWrongSeq;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvNativeFrag;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvReverseFrag;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvMaxPayload;
        private CustomControls.CustomCheckBox CustomCheckBoxDPIAdvBlacklist;
        private CustomControls.CustomButton CustomButtonDPIAdvBlacklist;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownDPIAdvPort;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownDPIAdvSetTTL;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownDPIAdvMinTTL;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownDPIAdvMaxPayload;
        private CustomControls.CustomLabel CustomLabelSettingBootstrapDnsIP;
        private CustomControls.CustomTextBox CustomTextBoxSettingBootstrapDnsIP;
        private NotifyIcon NotifyIconMain;
        private CustomControls.CustomContextMenuStrip CustomContextMenuStripIcon;
        private CustomControls.CustomLabel CustomLabelAboutUsing;
        private CustomControls.CustomLabel CustomLabelAboutVersion;
        private LinkLabel LinkLabelGoodbyeDPI;
        private LinkLabel LinkLabelDNSLookup;
        private CustomControls.CustomLabel CustomLabelAboutThis2;
        private CustomControls.CustomLabel CustomLabelAboutThis;
        private PictureBox PictureBoxAbout;
        private CustomControls.CustomGroupBox CustomGroupBoxStatus;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingDisableAudioAlert;
        private CustomControls.CustomTabControl CustomTabControlSettings;
        private TabPage TabPageSettingsWorkingMode;
        private TabPage TabPageSettingsCPU;
        private TabPage TabPageSettingsOthers;
        private CustomControls.CustomLabel CustomLabelSettingInfoWorkingMode1;
        private CustomControls.CustomRadioButton CustomRadioButtonSettingWorkingModeDNSandDoH;
        private CustomControls.CustomRadioButton CustomRadioButtonSettingWorkingModeDNS;
        private CustomControls.CustomRadioButton CustomRadioButtonSettingCPUAboveNormal;
        private CustomControls.CustomRadioButton CustomRadioButtonSettingCPUHigh;
        private CustomControls.CustomLabel CustomLabelSettingInfoCPU;
        private CustomControls.CustomRadioButton CustomRadioButtonSettingCPULow;
        private CustomControls.CustomRadioButton CustomRadioButtonSettingCPUBelowNormal;
        private CustomControls.CustomRadioButton CustomRadioButtonSettingCPUNormal;
        private TabPage TabPageSettingsCheck;
        private CustomControls.CustomLabel CustomLabelSettingCheckTimeout;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownSettingCheckTimeout;
        private CustomControls.CustomTextBox CustomTextBoxSettingCheckDPIHost;
        private CustomControls.CustomLabel CustomLabelSettingCheckDPIInfo;
        private CustomControls.CustomGroupBox CustomGroupBoxSettingCheckSDNS;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingSdnsNoFilter;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingSdnsNoLog;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingSdnsDNSSec;
        private CustomControls.CustomRadioButton CustomRadioButtonConnectDNSCrypt;
        private CustomControls.CustomRadioButton CustomRadioButtonConnectCheckedServers;
        private CustomControls.CustomRadioButton CustomRadioButtonConnectFakeProxyDohViaGoodbyeDPI;
        private TabPage TabPageSettingsConnect;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownSettingMaxServers;
        private CustomControls.CustomLabel CustomLabelSettingMaxServers;
        private TabPage TabPageShare;
        private CustomControls.CustomLabel CustomLabelSettingBootstrapDnsPort;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownSettingBootstrapDnsPort;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownSettingFallbackDnsPort;
        private CustomControls.CustomLabel CustomLabelSettingFallbackDnsPort;
        private CustomControls.CustomTextBox CustomTextBoxSettingFallbackDnsIP;
        private CustomControls.CustomLabel CustomLabelSettingFallbackDnsIP;
        private CustomControls.CustomLabel CustomLabelInfoDPIModes;
        private LinkLabel LinkLabelStAlidxdydz;
        private CustomControls.CustomLabel CustomLabelAboutSpecialThanks;
        private TabPage TabPageSettingsSetUnsetDNS;
        private CustomControls.CustomRadioButton CustomRadioButtonSettingUnsetDnsToDhcp;
        private CustomControls.CustomRadioButton CustomRadioButtonSettingUnsetDnsToStatic;
        private CustomControls.CustomLabel CustomLabelSettingUnsetDns2;
        private CustomControls.CustomLabel CustomLabelSettingUnsetDns1;
        private CustomControls.CustomTextBox CustomTextBoxSettingUnsetDns2;
        private CustomControls.CustomTextBox CustomTextBoxSettingUnsetDns1;
        private SplitContainer SplitContainerMain;
        private SplitContainer SplitContainerTop;
        private CustomControls.CustomGroupBox CustomGroupBoxSettingCheckDnsProtocol;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingProtocolDNSCrypt;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingProtocolTLS;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingProtocolDoH;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingProtocolAnonymizedDNSCrypt;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingProtocolDoQ;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingProtocolPlainDNS;
        private TabPage TabPageSettingsShare;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownSettingProxyHandleRequests;
        private CustomControls.CustomLabel CustomLabelSettingProxyHandleRequests;
        private CustomControls.CustomLabel CustomLabelSettingProxyPort;
        public CustomControls.CustomNumericUpDown CustomNumericUpDownSettingProxyPort;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingProxyBlockPort80;
        private CustomControls.CustomButton CustomButtonSettingUninstallCertificate;
        private CustomControls.CustomLabel CustomLabelAboutCopyright;
        private CustomControls.CustomRadioButton CustomRadioButtonConnectFakeProxyDohViaProxyDPI;
        private TabPage TabPageSettingsFakeProxy;
        private CustomControls.CustomLabel CustomLabelSettingFakeProxyInfo;
        private CustomControls.CustomLabel CustomLabelSettingFakeProxyDohCleanIP;
        private CustomControls.CustomLabel CustomLabelSettingFakeProxyDohAddress;
        private CustomControls.CustomTextBox CustomTextBoxSettingFakeProxyDohAddress;
        private CustomControls.CustomTextBox CustomTextBoxSettingFakeProxyDohCleanIP;
        private TabPage TabPageTools;
        private CustomControls.CustomButton CustomButtonToolsIpScanner;
        private CustomControls.CustomButton CustomButtonWriteSavedServersDelay;
        private CustomControls.CustomTabControl CustomTabControlSettingProxy;
        private TabPage TabPageSettingProxyBasic;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingProxyUpstream;
        private CustomControls.CustomComboBox CustomComboBoxSettingProxyUpstreamMode;
        private CustomControls.CustomLabel CustomLabelSettingProxyUpstreamPort;
        private CustomControls.CustomLabel CustomLabelSettingProxyUpstreamHost;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownSettingProxyUpstreamPort;
        private CustomControls.CustomTextBox CustomTextBoxSettingProxyUpstreamHost;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingProxyUpstreamOnlyBlockedIPs;
        private CustomControls.CustomLabel CustomLabelSettingCpuKillProxyRequests;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownSettingCpuKillProxyRequests;
        private CustomControls.CustomLabel CustomLabelSettingWorkingModeSetDohPort;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownSettingWorkingModeSetDohPort;
        private CustomControls.CustomButton CustomButtonToolsDnsLookup;
        private CustomControls.CustomButton CustomButtonToolsStampReader;
        private CustomControls.CustomButton CustomButtonToolsStampGenerator;
        private CustomControls.CustomButton CustomButtonCheckUpdate;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownSettingProxyKillRequestTimeout;
        private CustomControls.CustomLabel CustomLabelSettingProxyKillRequestTimeout;
        private CustomControls.CustomProgressBar CustomProgressBarCheck;
        private PictureBox PictureBoxFarvahar;
        private CustomControls.CustomButton CustomButtonQuickConnect;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingWriteLogWindowToFile;
        private CustomControls.CustomButton CustomButtonImportUserData;
        private CustomControls.CustomButton CustomButtonExportUserData;
        private CustomControls.CustomButton CustomButtonProcessMonitor;
        private CustomControls.CustomButton CustomButtonToolsDnsScanner;
        private TabPage TabPageSettingsQuickConnect;
        private CustomControls.CustomLabel CustomLabelSettingQcInfo;
        private CustomControls.CustomComboBox CustomComboBoxSettingQcConnectMode;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingQcCheckAllServers;
        private CustomControls.CustomButton CustomButtonSettingQcUpdateNics;
        private CustomControls.CustomComboBox CustomComboBoxSettingQcNics;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingQcSetProxy;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingQcStartProxyServer;
        private CustomControls.CustomComboBox CustomComboBoxSettingQcGdBasic;
        private CustomControls.CustomRadioButton CustomRadioButtonSettingQcGdAdvanced;
        private CustomControls.CustomRadioButton CustomRadioButtonSettingQcGdBasic;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingQcStartGoodbyeDpi;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingQcSetDnsTo;
        private CustomControls.CustomButton CustomButtonToolsFlushDns;
        private CustomControls.CustomDataGridView CustomDataGridViewStatus;
        private CustomControls.CustomButton CustomButtonSettingQcStartup;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingQcUseSavedServers;
        private CustomControls.CustomGroupBox CustomGroupBoxNicStatus;
        private CustomControls.CustomDataGridView CustomDataGridViewNicStatus;
        private DataGridViewTextBoxColumn ColumnNicStatusName;
        private DataGridViewTextBoxColumn ColumnNicStatusText;
        private CustomControls.CustomButton CustomButtonEnableDisableNic;
        private CustomControls.CustomButton CustomButtonDisconnectAll;
        private CustomControls.CustomLabel CustomLabelSettingQcConnectMode;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingQcOnStartup;
        private CustomControls.CustomLabel CustomLabelCheckInParallel;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownCheckInParallel;
        private CustomControls.CustomLabel CustomLabelUpdateAutoDelayMS;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownUpdateAutoDelayMS;
        private CustomControls.CustomButton CustomButtonBenchmark;
        private LinkLabel LinkLabelStWolfkingal2000;
        public SplitContainer SplitContainerShareMain;
        private CustomControls.CustomButton CustomButtonPDpiCheck;
        private CustomControls.CustomButton CustomButtonPDpiApplyChanges;
        private CustomControls.CustomButton CustomButtonSetProxy;
        private CustomControls.CustomButton CustomButtonShare;
        private SplitContainer SplitContainerShareTop;
        private CustomControls.CustomCheckBox CustomCheckBoxProxyEventShowChunkDetails;
        private SplitContainer SplitContainerShareContent;
        private CustomControls.CustomLabel CustomLabelShareInfo;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownPDpiFragDelay;
        private CustomControls.CustomLabel CustomLabelPDpiFragDelay;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownPDpiSniChunks;
        private CustomControls.CustomButton CustomButtonPDpiPresetDefault;
        private CustomControls.CustomComboBox CustomComboBoxPDpiSniChunkMode;
        private CustomControls.CustomLabel CustomLabelPDpiPresets;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownPDpiAntiPatternOffset;
        private CustomControls.CustomLabel CustomLabelPDpiAntiPatternOffset;
        private CustomControls.CustomLabel CustomLabelProxySSLInfo;
        private CustomControls.CustomLabel CustomLabelPDpiSniChunks;
        private CustomControls.CustomCheckBox CustomCheckBoxProxyEnableSSL;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownPDpiBeforeSniChunks;
        private CustomControls.CustomCheckBox CustomCheckBoxProxySSLChangeSni;
        private CustomControls.CustomLabel CustomLabelPDpiSniChunkMode;
        private CustomControls.CustomLabel CustomLabelProxySSLChangeSniInfo;
        private CustomControls.CustomLabel CustomLabelProxySSLDefaultSni;
        private CustomControls.CustomCheckBox CustomCheckBoxPDpiEnableFragment;
        private CustomControls.CustomTextBox CustomTextBoxProxySSLDefaultSni;
        private CustomControls.CustomCheckBox CustomCheckBoxProxyEventShowRequest;
        private CustomControls.CustomLabel CustomLabelPDpiBeforeSniChunks;
        private CustomControls.CustomTabControl CustomTabControlShareDpiBypassOptions;
        private TabPage TabPageShareFragment;
        private TabPage TabPageShareSslDecryption;
        private CustomControls.CustomGroupBox CustomGroupBoxShareRulesStatus;
        private SplitContainer SplitContainerShareRulesStatus1;
        private CustomControls.CustomLabel CustomLabelShareRulesStatus;
        private CustomControls.CustomTextBox CustomTextBoxShareRulesStatusDomain;
        private SplitContainer SplitContainerShareRulesStatus2;
        private CustomControls.CustomButton CustomButtonShareRulesStatusRead;
        private CustomControls.CustomRichTextBox CustomRichTextBoxShareRulesStatusResult;
        private SplitContainer SplitContainerSetDnsMain;
        private SplitContainer SplitContainerSetDnsTop;
        private SplitContainer SplitContainerConnectMain;
        private SplitContainer SplitContainerConnectTop;
        private CustomControls.CustomGroupBox CustomGroupBoxConnectStatus;
        private SplitContainer SplitContainerCheckMain;
        private SplitContainer SplitContainerCheckTop;
        private SplitContainer SplitContainerStatusMain;
        private DataGridViewTextBoxColumn ColumnStatusName;
        private DataGridViewTextBoxColumn ColumnStatusText;
        private SplitContainer SplitContainerGoodbyeDpiBasicMain;
        private SplitContainer SplitContainerGoodbyeDpiAdvancedMain;
        private SplitContainer SplitContainerSettingQcMain;
        private SplitContainer SplitContainerSettingOthersMain;
        private CustomControls.CustomListBox CustomListBoxSettingsMenu;
        private SplitContainer SplitContainerSettings;
        private CustomControls.CustomRichTextBox CustomRichTextBoxConnectStatus;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingCheckClearWorkingServers;
        private CustomControls.CustomButton CustomButtonExit;
        private CustomControls.CustomButton CustomButtonReconnect;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingAlertDisplayChanges;
        private CustomControls.CustomRichTextBox CustomRichTextBoxCheckStatus;
        private CustomControls.CustomGroupBox CustomGroupBoxCheckStatus;
        private CustomControls.CustomButton CustomButtonFindActiveNic;
        private CustomControls.CustomButton CustomButtonUpdateNICs;
        private FlowLayoutPanel FlowLayoutPanelSetDns;
        private CustomControls.CustomButton CustomButtonUnsetAllDNSs;
        private CustomControls.CustomLabel CustomLabelSetDnsSpacer1;
        private CustomControls.CustomLabel CustomLabelSetDnsSpacer2;
        private CustomControls.CustomButton CustomButtonEnableDisableNicIPv6;
        private CustomControls.CustomCheckBox CustomCheckBoxDnsEventShowRequest;
        private LinkLabel LinkLabelStNonbarbari;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingConnectRetry;
        private TabPage TabPageSettingsGeoAssets;
        private FlowLayoutPanel FlowLayoutPanelGeoAssets;
        private CustomControls.CustomLabel CustomLabelGeoAssetsSpacer1;
        private CustomControls.CustomCheckBox CustomCheckBoxGeoAsset_IR_Domains;
        private CustomControls.CustomCheckBox CustomCheckBoxGeoAsset_IR_CIDRs;
        private CustomControls.CustomCheckBox CustomCheckBoxGeoAsset_IR_ADS;
        private CustomControls.CustomLabel CustomLabelGeoAssetsSpacer2;
        private CustomControls.CustomNumericUpDown CustomNumericUpDownGeoAssetsUpdate;
        private TableLayoutPanel TableLayoutPanelGeoAssets;
        private CustomControls.CustomLabel CustomLabelGeoAssetsSpacer3;
        private FlowLayoutPanel FlowLayoutPanelGeoAssets2;
        private CustomControls.CustomCheckBox CustomCheckBoxGeoAssetUpdate;
        private TabPage TabPageSettingsRules;
        private FlowLayoutPanel FlowLayoutPanelRules;
        private FlowLayoutPanel FlowLayoutPanelRules2;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingProxyCfCleanIP;
        private CustomControls.CustomTextBox CustomTextBoxSettingProxyCfCleanIP;
        private FlowLayoutPanel FlowLayoutPanelRules3;
        private CustomControls.CustomCheckBox CustomCheckBoxSettingEnableRules;
        private CustomControls.CustomButton CustomButtonSettingRules;
        private CustomControls.CustomTextBox CustomTextBoxSettingUnsetDnsIPv6_1;
        private CustomControls.CustomLabel CustomLabelSettingUnsetDnsIPv6_2;
        private CustomControls.CustomLabel CustomLabelSettingUnsetDnsIPv6_1;
        private CustomControls.CustomTextBox CustomTextBoxSettingUnsetDnsIPv6_2;
        private LinkLabel LinkLabelSettingRulesHelp;
        private CustomControls.CustomLabel CustomLabelSettingMalicious;
        private CustomControls.CustomButton CustomButtonSettingMalicious;
    }
}