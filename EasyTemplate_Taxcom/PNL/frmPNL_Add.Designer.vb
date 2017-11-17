<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPNL_Add
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPNL_Add))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim PushTransition1 As DevExpress.Utils.Animation.PushTransition = New DevExpress.Utils.Animation.PushTransition()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.pnlDocImport = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.UcPNL_Import1 = New EasyTemplate_Taxcom.ucPNL_Import()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.pnlProgress = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemProgressBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.txtPCName = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.pnlDocInformation = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.dgvExport = New DevExpress.XtraGrid.GridControl()
        Me.ExportPNLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL2 = New EasyTemplate_Taxcom.dsPNL2()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNo2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLeftAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRightAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lbl_p1NonAllowableExpenses = New DevExpress.XtraEditors.LabelControl()
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.txt_p1GrossProfitLoss = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p1COS = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p1CloseStock = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p1PCP = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p1COP = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p1NonAllowableExpenses = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p1AllowanceExpenses = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p1Depreciation = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p1Purchase = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p1OpenStock = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p1Sales = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p1CloseStock = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p1AllowanceExpenses = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p1Depreciation = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p1Purchase = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p1OpenStock = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p1Sales = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.lbl_p2UnreaGainForeExNon = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p2Other = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2NonTaxProfit = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2UnreaGainForeExNon = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2UnreaGainForeEx = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2ReaForeExGainNonTrade = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2ForeIncomeRemmit = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2ExemptDividend = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2ProDisInvestment = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2ProDispPlantEq = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2NonBizIncome = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2OtherIncome = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2RoyaltyIncome = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2RentalIncome = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2InterestIncome = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2DivIncome = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2ForeignCurrExGain = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2OtherBizIncome = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p2Other = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p2UnreaGainForeEx = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p2ReaForeExGainNonTrade = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p2ForeIncomeRemmit = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p2ExemptDividend = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p2ProDisInvestment = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p2ProDispPlantEq = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p2OtherIncome = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p2RoyaltyIncome = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p2RentalIncome = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p2InterestIncome = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p2DivIncome = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p2ForeignCurrExGain = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p2OtherBizIncome = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.txt_p3ForeignCurrExLoss = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3ForeignCurrExLoss = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3Zakat = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3Zakat = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3DonationNonApp = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3DonationNonApp = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3DonationApp = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3DonationApp = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3Depreciation = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3Depreciation = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3JKDM = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3JKDM = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3Travelling = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3Travelling = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3PromotionAds = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3PromotionAds = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3ResearchDev = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3ResearchDev = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3RepairMain = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3RepairMain = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3Rental = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3Rental = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3Royalty = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3Royalty = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3COEStock = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3COEStock = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3Salary = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3Salary = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3DirectorFee = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3DirectorFee = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3ContractPay = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3ContractPay = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3TechPayNonResis = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3TechPayNonResis = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3ProTechManLeganFees = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3ProTechManLeganFees = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3OtherInterestExHirePur = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3OtherInterestExHirePur = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p3InterestResPurS33 = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p3InterestResPurS33 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.txt_p4ExpectedExpenses = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4NonAllowableExpenses = New DevExpress.XtraEditors.TextEdit()
        Me.lblP4NonAllowableExpenses = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4NetProfitLoss = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl63 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4TotalExpenses = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4TotalOtherExpenses = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4OtherBalacingFigure = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4Other = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p4Other = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4CAExpenditure = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p4CAExpenditure = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4InitSub = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p4InitSub = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4ReaLossForeExNonTrade = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p4ReaLossForeExNonTrade = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4ReaLossForeExTrade = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p4ReaLossForeExTrade = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4UnreaLossForeEx = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p4UnreaLossForeEx = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4FAWrittenOff = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p4FAWrittenOff = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4LeavePass = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p4LeavePass = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4ProvisionAcc = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p4ProvisionAcc = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4Compound = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p4Compound = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4EntStaff = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p4EntStaff = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4EntNonStaff = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p4EntNonStaff = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p4LossDispFA = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_p4LossDispFA = New DevExpress.XtraEditors.LabelControl()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnImport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExport = New DevExpress.XtraBars.BarButtonItem()
        Me.cboPNLStatus = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.txtLastModified = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cboRefNo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.cboYA = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.txtRefNo = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtNetProfit2 = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtNonAllowableExpense = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cboMainSource = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BUSINESSSOURCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPNL = New EasyTemplate_Taxcom.dsPNL()
        Me.cboS60F = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cboS60FA = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox4 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.txtBalacingFigure = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btnRefresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.WorkspaceManager1 = New DevExpress.Utils.WorkspaceManager()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pnlDocExport = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer1 = New DevExpress.XtraBars.Docking.ControlContainer()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerRight.SuspendLayout()
        Me.pnlDocImport.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDocInformation.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.dgvExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportPNLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p1GrossProfitLoss.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p1COS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p1CloseStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p1PCP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p1COP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p1NonAllowableExpenses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p1AllowanceExpenses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p1Depreciation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p1Purchase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p1OpenStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p1Sales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.txt_p2Other.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2NonTaxProfit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2UnreaGainForeExNon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2UnreaGainForeEx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2ReaForeExGainNonTrade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2ForeIncomeRemmit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2ExemptDividend.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2ProDisInvestment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2ProDispPlantEq.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2NonBizIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2OtherIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2RoyaltyIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2RentalIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2InterestIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2DivIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2ForeignCurrExGain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2OtherBizIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.txt_p3ForeignCurrExLoss.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3Zakat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3DonationNonApp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3DonationApp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3Depreciation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3JKDM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3Travelling.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3PromotionAds.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3ResearchDev.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3RepairMain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3Rental.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3Royalty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3COEStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3Salary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3DirectorFee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3ContractPay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3TechPayNonResis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3ProTechManLeganFees.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3OtherInterestExHirePur.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p3InterestResPurS33.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.txt_p4ExpectedExpenses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4NonAllowableExpenses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4NetProfitLoss.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4TotalExpenses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4TotalOtherExpenses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4OtherBalacingFigure.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4Other.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4CAExpenditure.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4InitSub.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4ReaLossForeExNonTrade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4ReaLossForeExTrade.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4UnreaLossForeEx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4FAWrittenOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4LeavePass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4ProvisionAcc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4Compound.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4EntStaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4EntNonStaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4LossDispFA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDocExport.SuspendLayout()
        Me.ControlContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DockManager1
        '
        Me.DockManager1.AutoHideContainers.AddRange(New DevExpress.XtraBars.Docking.AutoHideContainer() {Me.hideContainerRight})
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.pnlDocInformation})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
        '
        'hideContainerRight
        '
        Me.hideContainerRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.hideContainerRight.Controls.Add(Me.pnlDocImport)
        Me.hideContainerRight.Controls.Add(Me.pnlDocExport)
        Me.hideContainerRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.hideContainerRight.Location = New System.Drawing.Point(1296, 141)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(19, 583)
        '
        'pnlDocImport
        '
        Me.pnlDocImport.Controls.Add(Me.DockPanel2_Container)
        Me.pnlDocImport.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.pnlDocImport.ID = New System.Guid("be65f503-51a1-4e68-b6dd-9904920f171e")
        Me.pnlDocImport.Location = New System.Drawing.Point(0, 0)
        Me.pnlDocImport.Name = "pnlDocImport"
        Me.pnlDocImport.OriginalSize = New System.Drawing.Size(584, 198)
        Me.pnlDocImport.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.pnlDocImport.SavedIndex = 0
        Me.pnlDocImport.Size = New System.Drawing.Size(584, 583)
        Me.pnlDocImport.Text = "Import Data List"
        Me.pnlDocImport.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.UcPNL_Import1)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(576, 556)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'UcPNL_Import1
        '
        Me.UcPNL_Import1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcPNL_Import1.Location = New System.Drawing.Point(0, 0)
        Me.UcPNL_Import1.MainData = Nothing
        Me.UcPNL_Import1.MainData2 = Nothing
        Me.UcPNL_Import1.Name = "UcPNL_Import1"
        Me.UcPNL_Import1.Size = New System.Drawing.Size(576, 556)
        Me.UcPNL_Import1.TabIndex = 0
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.pnlProgress, Me.txtPCName})
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemProgressBar2, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6})
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.pnlProgress), New DevExpress.XtraBars.LinkPersistInfo(Me.txtPCName)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'pnlProgress
        '
        Me.pnlProgress.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.pnlProgress.Caption = "Please wait"
        Me.pnlProgress.CaptionAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.pnlProgress.Edit = Me.RepositoryItemProgressBar2
        Me.pnlProgress.Id = 0
        Me.pnlProgress.Name = "pnlProgress"
        Me.pnlProgress.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.pnlProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        Me.pnlProgress.Width = 100
        '
        'RepositoryItemProgressBar2
        '
        Me.RepositoryItemProgressBar2.Name = "RepositoryItemProgressBar2"
        '
        'txtPCName
        '
        Me.txtPCName.Caption = "BarStaticItem1"
        Me.txtPCName.Id = 3
        Me.txtPCName.Name = "txtPCName"
        Me.txtPCName.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1315, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 724)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1315, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 724)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1315, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 724)
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        Me.RepositoryItemTextEdit6.ReadOnly = True
        '
        'pnlDocInformation
        '
        Me.pnlDocInformation.Controls.Add(Me.DockPanel1_Container)
        Me.pnlDocInformation.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.pnlDocInformation.ID = New System.Guid("e6a7b213-c5f9-4782-b8c1-9aacd9e4ed1b")
        Me.pnlDocInformation.Location = New System.Drawing.Point(0, 141)
        Me.pnlDocInformation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlDocInformation.Name = "pnlDocInformation"
        Me.pnlDocInformation.Options.ShowCloseButton = False
        Me.pnlDocInformation.OriginalSize = New System.Drawing.Size(620, 200)
        Me.pnlDocInformation.Size = New System.Drawing.Size(620, 583)
        Me.pnlDocInformation.Text = "Information"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.XtraScrollableControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 23)
        Me.DockPanel1_Container.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(612, 556)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraScrollableControl1.Controls.Add(Me.XtraTabControl1)
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraScrollableControl1.MinimumSize = New System.Drawing.Size(612, 556)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(612, 556)
        Me.XtraScrollableControl1.TabIndex = 1
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabControl1.MinimumSize = New System.Drawing.Size(612, 556)
        Me.XtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Size = New System.Drawing.Size(612, 556)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.lbl_p1NonAllowableExpenses)
        Me.XtraTabPage1.Controls.Add(Me.ProgressPanel1)
        Me.XtraTabPage1.Controls.Add(Me.txt_p1GrossProfitLoss)
        Me.XtraTabPage1.Controls.Add(Me.txt_p1COS)
        Me.XtraTabPage1.Controls.Add(Me.txt_p1CloseStock)
        Me.XtraTabPage1.Controls.Add(Me.txt_p1PCP)
        Me.XtraTabPage1.Controls.Add(Me.txt_p1COP)
        Me.XtraTabPage1.Controls.Add(Me.txt_p1NonAllowableExpenses)
        Me.XtraTabPage1.Controls.Add(Me.txt_p1AllowanceExpenses)
        Me.XtraTabPage1.Controls.Add(Me.txt_p1Depreciation)
        Me.XtraTabPage1.Controls.Add(Me.txt_p1Purchase)
        Me.XtraTabPage1.Controls.Add(Me.txt_p1OpenStock)
        Me.XtraTabPage1.Controls.Add(Me.txt_p1Sales)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl11)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl10)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage1.Controls.Add(Me.lbl_p1CloseStock)
        Me.XtraTabPage1.Controls.Add(Me.lbl_p1AllowanceExpenses)
        Me.XtraTabPage1.Controls.Add(Me.lbl_p1Depreciation)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage1.Controls.Add(Me.lbl_p1Purchase)
        Me.XtraTabPage1.Controls.Add(Me.lbl_p1OpenStock)
        Me.XtraTabPage1.Controls.Add(Me.lbl_p1Sales)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabPage1.Size = New System.Drawing.Size(606, 528)
        Me.XtraTabPage1.Text = "Page 1"
        '
        'dgvExport
        '
        Me.dgvExport.DataSource = Me.ExportPNLBindingSource
        Me.dgvExport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvExport.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvExport.Location = New System.Drawing.Point(0, 0)
        Me.dgvExport.MainView = Me.GridView1
        Me.dgvExport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvExport.MenuManager = Me.BarManager1
        Me.dgvExport.Name = "dgvExport"
        Me.dgvExport.Size = New System.Drawing.Size(344, 556)
        Me.dgvExport.TabIndex = 61
        Me.dgvExport.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ExportPNLBindingSource
        '
        Me.ExportPNLBindingSource.DataMember = "ExportPNL"
        Me.ExportPNLBindingSource.DataSource = Me.DsPNL2
        '
        'DsPNL2
        '
        Me.DsPNL2.DataSetName = "dsPNL2"
        Me.DsPNL2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNo, Me.colNo2, Me.colType, Me.colDescription, Me.colLeftAmount, Me.colRightAmount})
        Me.GridView1.GridControl = Me.dgvExport
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'colNo
        '
        Me.colNo.Caption = "No"
        Me.colNo.FieldName = "No"
        Me.colNo.Name = "colNo"
        Me.colNo.Visible = True
        Me.colNo.VisibleIndex = 0
        '
        'colNo2
        '
        Me.colNo2.Caption = "Parent No"
        Me.colNo2.FieldName = "No2"
        Me.colNo2.Name = "colNo2"
        Me.colNo2.Visible = True
        Me.colNo2.VisibleIndex = 1
        '
        'colType
        '
        Me.colType.Caption = "Type"
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 2
        Me.colType.Width = 150
        '
        'colDescription
        '
        Me.colDescription.Caption = "Description"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 3
        Me.colDescription.Width = 500
        '
        'colLeftAmount
        '
        Me.colLeftAmount.Caption = "Debit Amount"
        Me.colLeftAmount.FieldName = "LeftAmount"
        Me.colLeftAmount.Name = "colLeftAmount"
        Me.colLeftAmount.Visible = True
        Me.colLeftAmount.VisibleIndex = 4
        Me.colLeftAmount.Width = 150
        '
        'colRightAmount
        '
        Me.colRightAmount.Caption = "Credit Amount"
        Me.colRightAmount.FieldName = "RightAmount"
        Me.colRightAmount.Name = "colRightAmount"
        Me.colRightAmount.Visible = True
        Me.colRightAmount.VisibleIndex = 5
        Me.colRightAmount.Width = 150
        '
        'lbl_p1NonAllowableExpenses
        '
        Me.lbl_p1NonAllowableExpenses.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p1NonAllowableExpenses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p1NonAllowableExpenses.Location = New System.Drawing.Point(5, 190)
        Me.lbl_p1NonAllowableExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p1NonAllowableExpenses.Name = "lbl_p1NonAllowableExpenses"
        Me.lbl_p1NonAllowableExpenses.Size = New System.Drawing.Size(106, 12)
        Me.lbl_p1NonAllowableExpenses.TabIndex = 22
        Me.lbl_p1NonAllowableExpenses.Tag = "OTHERNONALLOWEXP"
        Me.lbl_p1NonAllowableExpenses.Text = "Non allowable expenses"
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.AppearanceCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ProgressPanel1.AppearanceCaption.Options.UseFont = True
        Me.ProgressPanel1.AppearanceDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ProgressPanel1.AppearanceDescription.Options.UseFont = True
        Me.ProgressPanel1.Location = New System.Drawing.Point(256, 122)
        Me.ProgressPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.Size = New System.Drawing.Size(218, 62)
        Me.ProgressPanel1.TabIndex = 7
        Me.ProgressPanel1.Text = "ProgressPanel1"
        '
        'txt_p1GrossProfitLoss
        '
        Me.txt_p1GrossProfitLoss.Location = New System.Drawing.Point(474, 344)
        Me.txt_p1GrossProfitLoss.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p1GrossProfitLoss.Name = "txt_p1GrossProfitLoss"
        Me.txt_p1GrossProfitLoss.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p1GrossProfitLoss.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p1GrossProfitLoss.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p1GrossProfitLoss.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p1GrossProfitLoss.Properties.NullText = "0"
        Me.txt_p1GrossProfitLoss.Properties.NullValuePrompt = "0"
        Me.txt_p1GrossProfitLoss.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p1GrossProfitLoss.Properties.ReadOnly = True
        Me.txt_p1GrossProfitLoss.Size = New System.Drawing.Size(86, 20)
        Me.txt_p1GrossProfitLoss.TabIndex = 21
        '
        'txt_p1COS
        '
        Me.txt_p1COS.Location = New System.Drawing.Point(474, 307)
        Me.txt_p1COS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p1COS.Name = "txt_p1COS"
        Me.txt_p1COS.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p1COS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p1COS.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p1COS.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p1COS.Properties.NullText = "0"
        Me.txt_p1COS.Properties.NullValuePrompt = "0"
        Me.txt_p1COS.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p1COS.Properties.ReadOnly = True
        Me.txt_p1COS.Size = New System.Drawing.Size(86, 20)
        Me.txt_p1COS.TabIndex = 20
        '
        'txt_p1CloseStock
        '
        Me.txt_p1CloseStock.Location = New System.Drawing.Point(386, 284)
        Me.txt_p1CloseStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p1CloseStock.Name = "txt_p1CloseStock"
        Me.txt_p1CloseStock.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p1CloseStock.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p1CloseStock.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p1CloseStock.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p1CloseStock.Properties.NullText = "0"
        Me.txt_p1CloseStock.Properties.NullValuePrompt = "0"
        Me.txt_p1CloseStock.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p1CloseStock.Properties.ReadOnly = True
        Me.txt_p1CloseStock.Size = New System.Drawing.Size(86, 20)
        Me.txt_p1CloseStock.TabIndex = 19
        '
        'txt_p1PCP
        '
        Me.txt_p1PCP.Location = New System.Drawing.Point(386, 248)
        Me.txt_p1PCP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p1PCP.Name = "txt_p1PCP"
        Me.txt_p1PCP.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p1PCP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p1PCP.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p1PCP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p1PCP.Properties.NullText = "0"
        Me.txt_p1PCP.Properties.NullValuePrompt = "0"
        Me.txt_p1PCP.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p1PCP.Properties.ReadOnly = True
        Me.txt_p1PCP.Size = New System.Drawing.Size(86, 20)
        Me.txt_p1PCP.TabIndex = 18
        '
        'txt_p1COP
        '
        Me.txt_p1COP.Location = New System.Drawing.Point(295, 209)
        Me.txt_p1COP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p1COP.Name = "txt_p1COP"
        Me.txt_p1COP.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p1COP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p1COP.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p1COP.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p1COP.Properties.NullText = "0"
        Me.txt_p1COP.Properties.NullValuePrompt = "0"
        Me.txt_p1COP.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p1COP.Properties.ReadOnly = True
        Me.txt_p1COP.Size = New System.Drawing.Size(86, 20)
        Me.txt_p1COP.TabIndex = 17
        '
        'txt_p1NonAllowableExpenses
        '
        Me.txt_p1NonAllowableExpenses.Location = New System.Drawing.Point(204, 187)
        Me.txt_p1NonAllowableExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p1NonAllowableExpenses.Name = "txt_p1NonAllowableExpenses"
        Me.txt_p1NonAllowableExpenses.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p1NonAllowableExpenses.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p1NonAllowableExpenses.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p1NonAllowableExpenses.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p1NonAllowableExpenses.Properties.NullText = "0"
        Me.txt_p1NonAllowableExpenses.Properties.NullValuePrompt = "0"
        Me.txt_p1NonAllowableExpenses.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p1NonAllowableExpenses.Properties.ReadOnly = True
        Me.txt_p1NonAllowableExpenses.Size = New System.Drawing.Size(86, 20)
        Me.txt_p1NonAllowableExpenses.TabIndex = 16
        '
        'txt_p1AllowanceExpenses
        '
        Me.txt_p1AllowanceExpenses.Location = New System.Drawing.Point(204, 164)
        Me.txt_p1AllowanceExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p1AllowanceExpenses.Name = "txt_p1AllowanceExpenses"
        Me.txt_p1AllowanceExpenses.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p1AllowanceExpenses.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p1AllowanceExpenses.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p1AllowanceExpenses.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p1AllowanceExpenses.Properties.NullText = "0"
        Me.txt_p1AllowanceExpenses.Properties.NullValuePrompt = "0"
        Me.txt_p1AllowanceExpenses.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p1AllowanceExpenses.Properties.ReadOnly = True
        Me.txt_p1AllowanceExpenses.Size = New System.Drawing.Size(86, 20)
        Me.txt_p1AllowanceExpenses.TabIndex = 15
        '
        'txt_p1Depreciation
        '
        Me.txt_p1Depreciation.Location = New System.Drawing.Point(204, 141)
        Me.txt_p1Depreciation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p1Depreciation.Name = "txt_p1Depreciation"
        Me.txt_p1Depreciation.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p1Depreciation.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p1Depreciation.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p1Depreciation.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p1Depreciation.Properties.NullText = "0"
        Me.txt_p1Depreciation.Properties.NullValuePrompt = "0"
        Me.txt_p1Depreciation.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p1Depreciation.Properties.ReadOnly = True
        Me.txt_p1Depreciation.Size = New System.Drawing.Size(86, 20)
        Me.txt_p1Depreciation.TabIndex = 14
        '
        'txt_p1Purchase
        '
        Me.txt_p1Purchase.Location = New System.Drawing.Point(295, 88)
        Me.txt_p1Purchase.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p1Purchase.Name = "txt_p1Purchase"
        Me.txt_p1Purchase.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p1Purchase.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p1Purchase.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p1Purchase.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p1Purchase.Properties.NullText = "0"
        Me.txt_p1Purchase.Properties.NullValuePrompt = "0"
        Me.txt_p1Purchase.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p1Purchase.Properties.ReadOnly = True
        Me.txt_p1Purchase.Size = New System.Drawing.Size(86, 20)
        Me.txt_p1Purchase.TabIndex = 13
        '
        'txt_p1OpenStock
        '
        Me.txt_p1OpenStock.Location = New System.Drawing.Point(386, 70)
        Me.txt_p1OpenStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p1OpenStock.Name = "txt_p1OpenStock"
        Me.txt_p1OpenStock.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p1OpenStock.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p1OpenStock.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p1OpenStock.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p1OpenStock.Properties.NullText = "0"
        Me.txt_p1OpenStock.Properties.NullValuePrompt = "0"
        Me.txt_p1OpenStock.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p1OpenStock.Properties.ReadOnly = True
        Me.txt_p1OpenStock.Size = New System.Drawing.Size(86, 20)
        Me.txt_p1OpenStock.TabIndex = 12
        '
        'txt_p1Sales
        '
        Me.txt_p1Sales.Location = New System.Drawing.Point(474, 14)
        Me.txt_p1Sales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p1Sales.Name = "txt_p1Sales"
        Me.txt_p1Sales.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p1Sales.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p1Sales.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p1Sales.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p1Sales.Properties.Mask.EditMask = "n"
        Me.txt_p1Sales.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_p1Sales.Properties.NullText = "0"
        Me.txt_p1Sales.Properties.NullValuePrompt = "0"
        Me.txt_p1Sales.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p1Sales.Properties.ReadOnly = True
        Me.txt_p1Sales.Size = New System.Drawing.Size(86, 20)
        Me.txt_p1Sales.TabIndex = 11
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(5, 344)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(128, 17)
        Me.LabelControl11.TabIndex = 10
        Me.LabelControl11.Text = "Gross Profit / Loss"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(5, 307)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(87, 17)
        Me.LabelControl10.TabIndex = 9
        Me.LabelControl10.Text = "Cost of sales"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(5, 248)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(231, 17)
        Me.LabelControl9.TabIndex = 8
        Me.LabelControl9.Text = "Purchases and cost of production"
        '
        'lbl_p1CloseStock
        '
        Me.lbl_p1CloseStock.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p1CloseStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p1CloseStock.Location = New System.Drawing.Point(5, 288)
        Me.lbl_p1CloseStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p1CloseStock.Name = "lbl_p1CloseStock"
        Me.lbl_p1CloseStock.Size = New System.Drawing.Size(60, 12)
        Me.lbl_p1CloseStock.TabIndex = 7
        Me.lbl_p1CloseStock.Tag = "CLOSESTOCK"
        Me.lbl_p1CloseStock.Text = "Closing stock"
        '
        'lbl_p1AllowanceExpenses
        '
        Me.lbl_p1AllowanceExpenses.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p1AllowanceExpenses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p1AllowanceExpenses.Location = New System.Drawing.Point(5, 167)
        Me.lbl_p1AllowanceExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p1AllowanceExpenses.Name = "lbl_p1AllowanceExpenses"
        Me.lbl_p1AllowanceExpenses.Size = New System.Drawing.Size(86, 12)
        Me.lbl_p1AllowanceExpenses.TabIndex = 6
        Me.lbl_p1AllowanceExpenses.Tag = "OTHERALLOWEXP"
        Me.lbl_p1AllowanceExpenses.Text = "Allowable expenses"
        '
        'lbl_p1Depreciation
        '
        Me.lbl_p1Depreciation.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p1Depreciation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p1Depreciation.Location = New System.Drawing.Point(5, 145)
        Me.lbl_p1Depreciation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p1Depreciation.Name = "lbl_p1Depreciation"
        Me.lbl_p1Depreciation.Size = New System.Drawing.Size(56, 12)
        Me.lbl_p1Depreciation.TabIndex = 5
        Me.lbl_p1Depreciation.Tag = "DEPRECIATION"
        Me.lbl_p1Depreciation.Text = "Depreciation"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(5, 123)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(130, 17)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Cost of production"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(5, 42)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(30, 17)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Less"
        '
        'lbl_p1Purchase
        '
        Me.lbl_p1Purchase.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p1Purchase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p1Purchase.Location = New System.Drawing.Point(5, 91)
        Me.lbl_p1Purchase.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p1Purchase.Name = "lbl_p1Purchase"
        Me.lbl_p1Purchase.Size = New System.Drawing.Size(45, 12)
        Me.lbl_p1Purchase.TabIndex = 2
        Me.lbl_p1Purchase.Tag = "PURCHASE"
        Me.lbl_p1Purchase.Text = "Purchases"
        '
        'lbl_p1OpenStock
        '
        Me.lbl_p1OpenStock.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p1OpenStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p1OpenStock.Location = New System.Drawing.Point(5, 73)
        Me.lbl_p1OpenStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p1OpenStock.Name = "lbl_p1OpenStock"
        Me.lbl_p1OpenStock.Size = New System.Drawing.Size(66, 12)
        Me.lbl_p1OpenStock.TabIndex = 1
        Me.lbl_p1OpenStock.Tag = "OPENSTOCK"
        Me.lbl_p1OpenStock.Text = "Opening stock"
        '
        'lbl_p1Sales
        '
        Me.lbl_p1Sales.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline)
        Me.lbl_p1Sales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p1Sales.Location = New System.Drawing.Point(5, 17)
        Me.lbl_p1Sales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p1Sales.Name = "lbl_p1Sales"
        Me.lbl_p1Sales.Size = New System.Drawing.Size(68, 12)
        Me.lbl_p1Sales.TabIndex = 0
        Me.lbl_p1Sales.Tag = "SALES"
        Me.lbl_p1Sales.Text = "Sale / turnover"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2UnreaGainForeExNon)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2Other)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2NonTaxProfit)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2UnreaGainForeExNon)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2UnreaGainForeEx)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2ReaForeExGainNonTrade)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2ForeIncomeRemmit)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2ExemptDividend)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2ProDisInvestment)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2ProDispPlantEq)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2NonBizIncome)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2OtherIncome)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2RoyaltyIncome)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2RentalIncome)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2InterestIncome)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2DivIncome)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2ForeignCurrExGain)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2OtherBizIncome)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2Other)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2UnreaGainForeEx)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2ReaForeExGainNonTrade)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2ForeIncomeRemmit)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2ExemptDividend)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2ProDisInvestment)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2ProDispPlantEq)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl21)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2OtherIncome)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2RoyaltyIncome)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2RentalIncome)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2InterestIncome)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2DivIncome)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl15)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2ForeignCurrExGain)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2OtherBizIncome)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabPage2.Size = New System.Drawing.Size(606, 528)
        Me.XtraTabPage2.Text = "Page 2"
        '
        'lbl_p2UnreaGainForeExNon
        '
        Me.lbl_p2UnreaGainForeExNon.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2UnreaGainForeExNon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2UnreaGainForeExNon.Location = New System.Drawing.Point(5, 401)
        Me.lbl_p2UnreaGainForeExNon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2UnreaGainForeExNon.Name = "lbl_p2UnreaGainForeExNon"
        Me.lbl_p2UnreaGainForeExNon.Size = New System.Drawing.Size(230, 13)
        Me.lbl_p2UnreaGainForeExNon.TabIndex = 36
        Me.lbl_p2UnreaGainForeExNon.Tag = "UNREALFENONTRADE"
        Me.lbl_p2UnreaGainForeExNon.Text = "Unrealised gain on foreign exhange - Non Trade"
        '
        'txt_p2Other
        '
        Me.txt_p2Other.Location = New System.Drawing.Point(309, 422)
        Me.txt_p2Other.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2Other.Name = "txt_p2Other"
        Me.txt_p2Other.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2Other.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2Other.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2Other.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2Other.Properties.NullText = "0"
        Me.txt_p2Other.Properties.NullValuePrompt = "0"
        Me.txt_p2Other.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2Other.Properties.ReadOnly = True
        Me.txt_p2Other.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2Other.TabIndex = 35
        '
        'txt_p2NonTaxProfit
        '
        Me.txt_p2NonTaxProfit.Location = New System.Drawing.Point(406, 450)
        Me.txt_p2NonTaxProfit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2NonTaxProfit.Name = "txt_p2NonTaxProfit"
        Me.txt_p2NonTaxProfit.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2NonTaxProfit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2NonTaxProfit.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2NonTaxProfit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2NonTaxProfit.Properties.NullText = "0"
        Me.txt_p2NonTaxProfit.Properties.NullValuePrompt = "0"
        Me.txt_p2NonTaxProfit.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2NonTaxProfit.Properties.ReadOnly = True
        Me.txt_p2NonTaxProfit.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2NonTaxProfit.TabIndex = 34
        '
        'txt_p2UnreaGainForeExNon
        '
        Me.txt_p2UnreaGainForeExNon.Location = New System.Drawing.Point(309, 398)
        Me.txt_p2UnreaGainForeExNon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2UnreaGainForeExNon.Name = "txt_p2UnreaGainForeExNon"
        Me.txt_p2UnreaGainForeExNon.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2UnreaGainForeExNon.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2UnreaGainForeExNon.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2UnreaGainForeExNon.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2UnreaGainForeExNon.Properties.NullText = "0"
        Me.txt_p2UnreaGainForeExNon.Properties.NullValuePrompt = "0"
        Me.txt_p2UnreaGainForeExNon.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2UnreaGainForeExNon.Properties.ReadOnly = True
        Me.txt_p2UnreaGainForeExNon.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2UnreaGainForeExNon.TabIndex = 33
        '
        'txt_p2UnreaGainForeEx
        '
        Me.txt_p2UnreaGainForeEx.Location = New System.Drawing.Point(309, 375)
        Me.txt_p2UnreaGainForeEx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2UnreaGainForeEx.Name = "txt_p2UnreaGainForeEx"
        Me.txt_p2UnreaGainForeEx.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2UnreaGainForeEx.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2UnreaGainForeEx.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2UnreaGainForeEx.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2UnreaGainForeEx.Properties.NullText = "0"
        Me.txt_p2UnreaGainForeEx.Properties.NullValuePrompt = "0"
        Me.txt_p2UnreaGainForeEx.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2UnreaGainForeEx.Properties.ReadOnly = True
        Me.txt_p2UnreaGainForeEx.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2UnreaGainForeEx.TabIndex = 32
        '
        'txt_p2ReaForeExGainNonTrade
        '
        Me.txt_p2ReaForeExGainNonTrade.Location = New System.Drawing.Point(309, 353)
        Me.txt_p2ReaForeExGainNonTrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2ReaForeExGainNonTrade.Name = "txt_p2ReaForeExGainNonTrade"
        Me.txt_p2ReaForeExGainNonTrade.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2ReaForeExGainNonTrade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2ReaForeExGainNonTrade.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2ReaForeExGainNonTrade.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2ReaForeExGainNonTrade.Properties.NullText = "0"
        Me.txt_p2ReaForeExGainNonTrade.Properties.NullValuePrompt = "0"
        Me.txt_p2ReaForeExGainNonTrade.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2ReaForeExGainNonTrade.Properties.ReadOnly = True
        Me.txt_p2ReaForeExGainNonTrade.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2ReaForeExGainNonTrade.TabIndex = 31
        '
        'txt_p2ForeIncomeRemmit
        '
        Me.txt_p2ForeIncomeRemmit.Location = New System.Drawing.Point(309, 330)
        Me.txt_p2ForeIncomeRemmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2ForeIncomeRemmit.Name = "txt_p2ForeIncomeRemmit"
        Me.txt_p2ForeIncomeRemmit.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2ForeIncomeRemmit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2ForeIncomeRemmit.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2ForeIncomeRemmit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2ForeIncomeRemmit.Properties.NullText = "0"
        Me.txt_p2ForeIncomeRemmit.Properties.NullValuePrompt = "0"
        Me.txt_p2ForeIncomeRemmit.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2ForeIncomeRemmit.Properties.ReadOnly = True
        Me.txt_p2ForeIncomeRemmit.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2ForeIncomeRemmit.TabIndex = 30
        '
        'txt_p2ExemptDividend
        '
        Me.txt_p2ExemptDividend.Location = New System.Drawing.Point(309, 307)
        Me.txt_p2ExemptDividend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2ExemptDividend.Name = "txt_p2ExemptDividend"
        Me.txt_p2ExemptDividend.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2ExemptDividend.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2ExemptDividend.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2ExemptDividend.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2ExemptDividend.Properties.NullText = "0"
        Me.txt_p2ExemptDividend.Properties.NullValuePrompt = "0"
        Me.txt_p2ExemptDividend.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2ExemptDividend.Properties.ReadOnly = True
        Me.txt_p2ExemptDividend.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2ExemptDividend.TabIndex = 29
        '
        'txt_p2ProDisInvestment
        '
        Me.txt_p2ProDisInvestment.Location = New System.Drawing.Point(309, 284)
        Me.txt_p2ProDisInvestment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2ProDisInvestment.Name = "txt_p2ProDisInvestment"
        Me.txt_p2ProDisInvestment.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2ProDisInvestment.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2ProDisInvestment.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2ProDisInvestment.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2ProDisInvestment.Properties.NullText = "0"
        Me.txt_p2ProDisInvestment.Properties.NullValuePrompt = "0"
        Me.txt_p2ProDisInvestment.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2ProDisInvestment.Properties.ReadOnly = True
        Me.txt_p2ProDisInvestment.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2ProDisInvestment.TabIndex = 28
        '
        'txt_p2ProDispPlantEq
        '
        Me.txt_p2ProDispPlantEq.Location = New System.Drawing.Point(309, 262)
        Me.txt_p2ProDispPlantEq.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2ProDispPlantEq.Name = "txt_p2ProDispPlantEq"
        Me.txt_p2ProDispPlantEq.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2ProDispPlantEq.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2ProDispPlantEq.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2ProDispPlantEq.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2ProDispPlantEq.Properties.NullText = "0"
        Me.txt_p2ProDispPlantEq.Properties.NullValuePrompt = "0"
        Me.txt_p2ProDispPlantEq.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2ProDispPlantEq.Properties.ReadOnly = True
        Me.txt_p2ProDispPlantEq.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2ProDispPlantEq.TabIndex = 27
        '
        'txt_p2NonBizIncome
        '
        Me.txt_p2NonBizIncome.Location = New System.Drawing.Point(406, 207)
        Me.txt_p2NonBizIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2NonBizIncome.Name = "txt_p2NonBizIncome"
        Me.txt_p2NonBizIncome.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2NonBizIncome.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2NonBizIncome.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2NonBizIncome.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2NonBizIncome.Properties.NullText = "0"
        Me.txt_p2NonBizIncome.Properties.NullValuePrompt = "0"
        Me.txt_p2NonBizIncome.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2NonBizIncome.Properties.ReadOnly = True
        Me.txt_p2NonBizIncome.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2NonBizIncome.TabIndex = 26
        '
        'txt_p2OtherIncome
        '
        Me.txt_p2OtherIncome.Location = New System.Drawing.Point(309, 187)
        Me.txt_p2OtherIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2OtherIncome.Name = "txt_p2OtherIncome"
        Me.txt_p2OtherIncome.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2OtherIncome.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2OtherIncome.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2OtherIncome.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2OtherIncome.Properties.NullText = "0"
        Me.txt_p2OtherIncome.Properties.NullValuePrompt = "0"
        Me.txt_p2OtherIncome.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2OtherIncome.Properties.ReadOnly = True
        Me.txt_p2OtherIncome.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2OtherIncome.TabIndex = 25
        Me.txt_p2OtherIncome.Tag = "OTHERINC"
        '
        'txt_p2RoyaltyIncome
        '
        Me.txt_p2RoyaltyIncome.Location = New System.Drawing.Point(309, 164)
        Me.txt_p2RoyaltyIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2RoyaltyIncome.Name = "txt_p2RoyaltyIncome"
        Me.txt_p2RoyaltyIncome.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2RoyaltyIncome.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2RoyaltyIncome.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2RoyaltyIncome.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2RoyaltyIncome.Properties.NullText = "0"
        Me.txt_p2RoyaltyIncome.Properties.NullValuePrompt = "0"
        Me.txt_p2RoyaltyIncome.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2RoyaltyIncome.Properties.ReadOnly = True
        Me.txt_p2RoyaltyIncome.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2RoyaltyIncome.TabIndex = 24
        Me.txt_p2RoyaltyIncome.Tag = "ROYALTYINC"
        '
        'txt_p2RentalIncome
        '
        Me.txt_p2RentalIncome.Location = New System.Drawing.Point(309, 141)
        Me.txt_p2RentalIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2RentalIncome.Name = "txt_p2RentalIncome"
        Me.txt_p2RentalIncome.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2RentalIncome.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2RentalIncome.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2RentalIncome.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2RentalIncome.Properties.NullText = "0"
        Me.txt_p2RentalIncome.Properties.NullValuePrompt = "0"
        Me.txt_p2RentalIncome.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2RentalIncome.Properties.ReadOnly = True
        Me.txt_p2RentalIncome.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2RentalIncome.TabIndex = 23
        '
        'txt_p2InterestIncome
        '
        Me.txt_p2InterestIncome.Location = New System.Drawing.Point(309, 119)
        Me.txt_p2InterestIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2InterestIncome.Name = "txt_p2InterestIncome"
        Me.txt_p2InterestIncome.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2InterestIncome.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2InterestIncome.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2InterestIncome.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2InterestIncome.Properties.NullText = "0"
        Me.txt_p2InterestIncome.Properties.NullValuePrompt = "0"
        Me.txt_p2InterestIncome.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2InterestIncome.Properties.ReadOnly = True
        Me.txt_p2InterestIncome.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2InterestIncome.TabIndex = 22
        '
        'txt_p2DivIncome
        '
        Me.txt_p2DivIncome.Location = New System.Drawing.Point(309, 96)
        Me.txt_p2DivIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2DivIncome.Name = "txt_p2DivIncome"
        Me.txt_p2DivIncome.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2DivIncome.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2DivIncome.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2DivIncome.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2DivIncome.Properties.NullText = "0"
        Me.txt_p2DivIncome.Properties.NullValuePrompt = "0"
        Me.txt_p2DivIncome.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2DivIncome.Properties.ReadOnly = True
        Me.txt_p2DivIncome.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2DivIncome.TabIndex = 21
        '
        'txt_p2ForeignCurrExGain
        '
        Me.txt_p2ForeignCurrExGain.Location = New System.Drawing.Point(406, 45)
        Me.txt_p2ForeignCurrExGain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2ForeignCurrExGain.Name = "txt_p2ForeignCurrExGain"
        Me.txt_p2ForeignCurrExGain.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2ForeignCurrExGain.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2ForeignCurrExGain.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2ForeignCurrExGain.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2ForeignCurrExGain.Properties.NullText = "0"
        Me.txt_p2ForeignCurrExGain.Properties.NullValuePrompt = "0"
        Me.txt_p2ForeignCurrExGain.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2ForeignCurrExGain.Properties.ReadOnly = True
        Me.txt_p2ForeignCurrExGain.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2ForeignCurrExGain.TabIndex = 20
        '
        'txt_p2OtherBizIncome
        '
        Me.txt_p2OtherBizIncome.Location = New System.Drawing.Point(406, 22)
        Me.txt_p2OtherBizIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p2OtherBizIncome.Name = "txt_p2OtherBizIncome"
        Me.txt_p2OtherBizIncome.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p2OtherBizIncome.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p2OtherBizIncome.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p2OtherBizIncome.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p2OtherBizIncome.Properties.NullText = "0"
        Me.txt_p2OtherBizIncome.Properties.NullValuePrompt = "0"
        Me.txt_p2OtherBizIncome.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p2OtherBizIncome.Properties.ReadOnly = True
        Me.txt_p2OtherBizIncome.Size = New System.Drawing.Size(86, 20)
        Me.txt_p2OtherBizIncome.TabIndex = 19
        '
        'lbl_p2Other
        '
        Me.lbl_p2Other.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2Other.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2Other.Location = New System.Drawing.Point(5, 425)
        Me.lbl_p2Other.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2Other.Name = "lbl_p2Other"
        Me.lbl_p2Other.Size = New System.Drawing.Size(28, 13)
        Me.lbl_p2Other.TabIndex = 18
        Me.lbl_p2Other.Tag = "OTHERINC"
        Me.lbl_p2Other.Text = "Other"
        '
        'lbl_p2UnreaGainForeEx
        '
        Me.lbl_p2UnreaGainForeEx.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2UnreaGainForeEx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2UnreaGainForeEx.Location = New System.Drawing.Point(5, 378)
        Me.lbl_p2UnreaGainForeEx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2UnreaGainForeEx.Name = "lbl_p2UnreaGainForeEx"
        Me.lbl_p2UnreaGainForeEx.Size = New System.Drawing.Size(170, 13)
        Me.lbl_p2UnreaGainForeEx.TabIndex = 17
        Me.lbl_p2UnreaGainForeEx.Tag = "UNREALFETRADE"
        Me.lbl_p2UnreaGainForeEx.Text = "Unrealised gain on foreign exhange"
        '
        'lbl_p2ReaForeExGainNonTrade
        '
        Me.lbl_p2ReaForeExGainNonTrade.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2ReaForeExGainNonTrade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2ReaForeExGainNonTrade.Location = New System.Drawing.Point(5, 355)
        Me.lbl_p2ReaForeExGainNonTrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2ReaForeExGainNonTrade.Name = "lbl_p2ReaForeExGainNonTrade"
        Me.lbl_p2ReaForeExGainNonTrade.Size = New System.Drawing.Size(207, 13)
        Me.lbl_p2ReaForeExGainNonTrade.TabIndex = 16
        Me.lbl_p2ReaForeExGainNonTrade.Text = "Realised foreign exchange gain - non trade"
        '
        'lbl_p2ForeIncomeRemmit
        '
        Me.lbl_p2ForeIncomeRemmit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2ForeIncomeRemmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2ForeIncomeRemmit.Location = New System.Drawing.Point(5, 332)
        Me.lbl_p2ForeIncomeRemmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2ForeIncomeRemmit.Name = "lbl_p2ForeIncomeRemmit"
        Me.lbl_p2ForeIncomeRemmit.Size = New System.Drawing.Size(126, 13)
        Me.lbl_p2ForeIncomeRemmit.TabIndex = 15
        Me.lbl_p2ForeIncomeRemmit.Tag = "FORINCREMIT"
        Me.lbl_p2ForeIncomeRemmit.Text = "Foreign income remittance"
        '
        'lbl_p2ExemptDividend
        '
        Me.lbl_p2ExemptDividend.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2ExemptDividend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2ExemptDividend.Location = New System.Drawing.Point(5, 310)
        Me.lbl_p2ExemptDividend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2ExemptDividend.Name = "lbl_p2ExemptDividend"
        Me.lbl_p2ExemptDividend.Size = New System.Drawing.Size(79, 13)
        Me.lbl_p2ExemptDividend.TabIndex = 14
        Me.lbl_p2ExemptDividend.Tag = "EXEMDIV"
        Me.lbl_p2ExemptDividend.Text = "Exempt dividend"
        '
        'lbl_p2ProDisInvestment
        '
        Me.lbl_p2ProDisInvestment.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2ProDisInvestment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2ProDisInvestment.Location = New System.Drawing.Point(5, 287)
        Me.lbl_p2ProDisInvestment.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2ProDisInvestment.Name = "lbl_p2ProDisInvestment"
        Me.lbl_p2ProDisInvestment.Size = New System.Drawing.Size(151, 13)
        Me.lbl_p2ProDisInvestment.TabIndex = 13
        Me.lbl_p2ProDisInvestment.Tag = "PDINVEST"
        Me.lbl_p2ProDisInvestment.Text = "Profit on disposal of investment"
        '
        'lbl_p2ProDispPlantEq
        '
        Me.lbl_p2ProDispPlantEq.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2ProDispPlantEq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2ProDispPlantEq.Location = New System.Drawing.Point(5, 264)
        Me.lbl_p2ProDispPlantEq.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2ProDispPlantEq.Name = "lbl_p2ProDispPlantEq"
        Me.lbl_p2ProDispPlantEq.Size = New System.Drawing.Size(241, 13)
        Me.lbl_p2ProDispPlantEq.TabIndex = 12
        Me.lbl_p2ProDispPlantEq.Tag = "PDFIXASSET"
        Me.lbl_p2ProDispPlantEq.Text = "Profit on disposal of propety, plant and equipment"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Location = New System.Drawing.Point(5, 233)
        Me.LabelControl21.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(145, 17)
        Me.LabelControl21.TabIndex = 11
        Me.LabelControl21.Text = "Non - Taxable profits"
        '
        'lbl_p2OtherIncome
        '
        Me.lbl_p2OtherIncome.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2OtherIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2OtherIncome.Location = New System.Drawing.Point(5, 189)
        Me.lbl_p2OtherIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2OtherIncome.Name = "lbl_p2OtherIncome"
        Me.lbl_p2OtherIncome.Size = New System.Drawing.Size(64, 13)
        Me.lbl_p2OtherIncome.TabIndex = 10
        Me.lbl_p2OtherIncome.Tag = "OTHERINC"
        Me.lbl_p2OtherIncome.Text = "Other income"
        '
        'lbl_p2RoyaltyIncome
        '
        Me.lbl_p2RoyaltyIncome.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2RoyaltyIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2RoyaltyIncome.Location = New System.Drawing.Point(5, 167)
        Me.lbl_p2RoyaltyIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2RoyaltyIncome.Name = "lbl_p2RoyaltyIncome"
        Me.lbl_p2RoyaltyIncome.Size = New System.Drawing.Size(73, 13)
        Me.lbl_p2RoyaltyIncome.TabIndex = 9
        Me.lbl_p2RoyaltyIncome.Tag = "ROYALTYINC"
        Me.lbl_p2RoyaltyIncome.Text = "Royalty income"
        '
        'lbl_p2RentalIncome
        '
        Me.lbl_p2RentalIncome.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2RentalIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2RentalIncome.Location = New System.Drawing.Point(5, 144)
        Me.lbl_p2RentalIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2RentalIncome.Name = "lbl_p2RentalIncome"
        Me.lbl_p2RentalIncome.Size = New System.Drawing.Size(67, 13)
        Me.lbl_p2RentalIncome.TabIndex = 8
        Me.lbl_p2RentalIncome.Tag = "RENTALINC"
        Me.lbl_p2RentalIncome.Text = "Rental income"
        '
        'lbl_p2InterestIncome
        '
        Me.lbl_p2InterestIncome.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2InterestIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2InterestIncome.Location = New System.Drawing.Point(5, 121)
        Me.lbl_p2InterestIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2InterestIncome.Name = "lbl_p2InterestIncome"
        Me.lbl_p2InterestIncome.Size = New System.Drawing.Size(75, 13)
        Me.lbl_p2InterestIncome.TabIndex = 7
        Me.lbl_p2InterestIncome.Tag = "INTERESTINC"
        Me.lbl_p2InterestIncome.Text = "Interest income"
        '
        'lbl_p2DivIncome
        '
        Me.lbl_p2DivIncome.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2DivIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2DivIncome.Location = New System.Drawing.Point(5, 98)
        Me.lbl_p2DivIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2DivIncome.Name = "lbl_p2DivIncome"
        Me.lbl_p2DivIncome.Size = New System.Drawing.Size(77, 13)
        Me.lbl_p2DivIncome.TabIndex = 6
        Me.lbl_p2DivIncome.Tag = "DIVIDENDINC"
        Me.lbl_p2DivIncome.Text = "Dividend income"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Location = New System.Drawing.Point(5, 71)
        Me.LabelControl15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(147, 17)
        Me.LabelControl15.TabIndex = 5
        Me.LabelControl15.Text = "Non-business income"
        '
        'lbl_p2ForeignCurrExGain
        '
        Me.lbl_p2ForeignCurrExGain.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2ForeignCurrExGain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2ForeignCurrExGain.Location = New System.Drawing.Point(5, 47)
        Me.lbl_p2ForeignCurrExGain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2ForeignCurrExGain.Name = "lbl_p2ForeignCurrExGain"
        Me.lbl_p2ForeignCurrExGain.Size = New System.Drawing.Size(154, 13)
        Me.lbl_p2ForeignCurrExGain.TabIndex = 2
        Me.lbl_p2ForeignCurrExGain.Text = "Foreign currency exchange gain"
        '
        'lbl_p2OtherBizIncome
        '
        Me.lbl_p2OtherBizIncome.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2OtherBizIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2OtherBizIncome.Location = New System.Drawing.Point(5, 24)
        Me.lbl_p2OtherBizIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2OtherBizIncome.Name = "lbl_p2OtherBizIncome"
        Me.lbl_p2OtherBizIncome.Size = New System.Drawing.Size(108, 13)
        Me.lbl_p2OtherBizIncome.TabIndex = 1
        Me.lbl_p2OtherBizIncome.Tag = "OTHERBUSINC"
        Me.lbl_p2OtherBizIncome.Text = "Other business income"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.txt_p3ForeignCurrExLoss)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3ForeignCurrExLoss)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl46)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3Zakat)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3Zakat)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3DonationNonApp)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3DonationNonApp)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3DonationApp)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3DonationApp)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3Depreciation)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3Depreciation)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3JKDM)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3JKDM)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3Travelling)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3Travelling)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3PromotionAds)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3PromotionAds)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3ResearchDev)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3ResearchDev)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3RepairMain)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3RepairMain)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3Rental)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3Rental)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3Royalty)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3Royalty)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3COEStock)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3COEStock)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3Salary)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3Salary)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3DirectorFee)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3DirectorFee)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3ContractPay)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3ContractPay)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3TechPayNonResis)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3TechPayNonResis)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3ProTechManLeganFees)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3ProTechManLeganFees)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3OtherInterestExHirePur)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3OtherInterestExHirePur)
        Me.XtraTabPage3.Controls.Add(Me.txt_p3InterestResPurS33)
        Me.XtraTabPage3.Controls.Add(Me.lbl_p3InterestResPurS33)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabPage3.Size = New System.Drawing.Size(606, 528)
        Me.XtraTabPage3.Tag = ""
        Me.XtraTabPage3.Text = "Page 3"
        '
        'txt_p3ForeignCurrExLoss
        '
        Me.txt_p3ForeignCurrExLoss.Location = New System.Drawing.Point(407, 359)
        Me.txt_p3ForeignCurrExLoss.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3ForeignCurrExLoss.Name = "txt_p3ForeignCurrExLoss"
        Me.txt_p3ForeignCurrExLoss.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3ForeignCurrExLoss.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3ForeignCurrExLoss.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3ForeignCurrExLoss.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3ForeignCurrExLoss.Properties.NullText = "0"
        Me.txt_p3ForeignCurrExLoss.Properties.NullValuePrompt = "0"
        Me.txt_p3ForeignCurrExLoss.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3ForeignCurrExLoss.Properties.ReadOnly = True
        Me.txt_p3ForeignCurrExLoss.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3ForeignCurrExLoss.TabIndex = 60
        '
        'lbl_p3ForeignCurrExLoss
        '
        Me.lbl_p3ForeignCurrExLoss.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3ForeignCurrExLoss.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3ForeignCurrExLoss.Location = New System.Drawing.Point(18, 362)
        Me.lbl_p3ForeignCurrExLoss.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3ForeignCurrExLoss.Name = "lbl_p3ForeignCurrExLoss"
        Me.lbl_p3ForeignCurrExLoss.Size = New System.Drawing.Size(152, 13)
        Me.lbl_p3ForeignCurrExLoss.TabIndex = 59
        Me.lbl_p3ForeignCurrExLoss.Tag = "EXPJKDM"
        Me.lbl_p3ForeignCurrExLoss.Text = "Foreign currency exchange loss"
        '
        'LabelControl46
        '
        Me.LabelControl46.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl46.Location = New System.Drawing.Point(18, 423)
        Me.LabelControl46.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(128, 17)
        Me.LabelControl46.TabIndex = 58
        Me.LabelControl46.Text = "Other Expenditure"
        '
        'txt_p3Zakat
        '
        Me.txt_p3Zakat.Location = New System.Drawing.Point(500, 513)
        Me.txt_p3Zakat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3Zakat.Name = "txt_p3Zakat"
        Me.txt_p3Zakat.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3Zakat.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3Zakat.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3Zakat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3Zakat.Properties.NullText = "0"
        Me.txt_p3Zakat.Properties.NullValuePrompt = "0"
        Me.txt_p3Zakat.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3Zakat.Properties.ReadOnly = True
        Me.txt_p3Zakat.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3Zakat.TabIndex = 57
        '
        'lbl_p3Zakat
        '
        Me.lbl_p3Zakat.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3Zakat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3Zakat.Location = New System.Drawing.Point(18, 516)
        Me.lbl_p3Zakat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3Zakat.Name = "lbl_p3Zakat"
        Me.lbl_p3Zakat.Size = New System.Drawing.Size(27, 13)
        Me.lbl_p3Zakat.TabIndex = 56
        Me.lbl_p3Zakat.Tag = "EXPZAKAT"
        Me.lbl_p3Zakat.Text = "Zakat"
        '
        'txt_p3DonationNonApp
        '
        Me.txt_p3DonationNonApp.Location = New System.Drawing.Point(500, 489)
        Me.txt_p3DonationNonApp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3DonationNonApp.Name = "txt_p3DonationNonApp"
        Me.txt_p3DonationNonApp.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3DonationNonApp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3DonationNonApp.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3DonationNonApp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3DonationNonApp.Properties.NullText = "0"
        Me.txt_p3DonationNonApp.Properties.NullValuePrompt = "0"
        Me.txt_p3DonationNonApp.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3DonationNonApp.Properties.ReadOnly = True
        Me.txt_p3DonationNonApp.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3DonationNonApp.TabIndex = 55
        '
        'lbl_p3DonationNonApp
        '
        Me.lbl_p3DonationNonApp.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3DonationNonApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3DonationNonApp.Location = New System.Drawing.Point(18, 492)
        Me.lbl_p3DonationNonApp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3DonationNonApp.Name = "lbl_p3DonationNonApp"
        Me.lbl_p3DonationNonApp.Size = New System.Drawing.Size(115, 13)
        Me.lbl_p3DonationNonApp.TabIndex = 54
        Me.lbl_p3DonationNonApp.Tag = "EXPDONATIONNONAPPR"
        Me.lbl_p3DonationNonApp.Text = "Donation Non Approved"
        '
        'txt_p3DonationApp
        '
        Me.txt_p3DonationApp.Location = New System.Drawing.Point(500, 465)
        Me.txt_p3DonationApp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3DonationApp.Name = "txt_p3DonationApp"
        Me.txt_p3DonationApp.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3DonationApp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3DonationApp.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3DonationApp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3DonationApp.Properties.NullText = "0"
        Me.txt_p3DonationApp.Properties.NullValuePrompt = "0"
        Me.txt_p3DonationApp.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3DonationApp.Properties.ReadOnly = True
        Me.txt_p3DonationApp.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3DonationApp.TabIndex = 53
        '
        'lbl_p3DonationApp
        '
        Me.lbl_p3DonationApp.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3DonationApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3DonationApp.Location = New System.Drawing.Point(18, 468)
        Me.lbl_p3DonationApp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3DonationApp.Name = "lbl_p3DonationApp"
        Me.lbl_p3DonationApp.Size = New System.Drawing.Size(93, 13)
        Me.lbl_p3DonationApp.TabIndex = 52
        Me.lbl_p3DonationApp.Tag = "EXPDONATIONAPPR"
        Me.lbl_p3DonationApp.Text = "Donation Approved"
        '
        'txt_p3Depreciation
        '
        Me.txt_p3Depreciation.Location = New System.Drawing.Point(500, 441)
        Me.txt_p3Depreciation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3Depreciation.Name = "txt_p3Depreciation"
        Me.txt_p3Depreciation.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3Depreciation.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3Depreciation.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3Depreciation.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3Depreciation.Properties.NullText = "0"
        Me.txt_p3Depreciation.Properties.NullValuePrompt = "0"
        Me.txt_p3Depreciation.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3Depreciation.Properties.ReadOnly = True
        Me.txt_p3Depreciation.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3Depreciation.TabIndex = 51
        '
        'lbl_p3Depreciation
        '
        Me.lbl_p3Depreciation.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3Depreciation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3Depreciation.Location = New System.Drawing.Point(18, 444)
        Me.lbl_p3Depreciation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3Depreciation.Name = "lbl_p3Depreciation"
        Me.lbl_p3Depreciation.Size = New System.Drawing.Size(60, 13)
        Me.lbl_p3Depreciation.TabIndex = 50
        Me.lbl_p3Depreciation.Tag = "EXPDEPRECIATION"
        Me.lbl_p3Depreciation.Text = "Depreciation"
        '
        'txt_p3JKDM
        '
        Me.txt_p3JKDM.Location = New System.Drawing.Point(407, 383)
        Me.txt_p3JKDM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3JKDM.Name = "txt_p3JKDM"
        Me.txt_p3JKDM.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3JKDM.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3JKDM.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3JKDM.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3JKDM.Properties.NullText = "0"
        Me.txt_p3JKDM.Properties.NullValuePrompt = "0"
        Me.txt_p3JKDM.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3JKDM.Properties.ReadOnly = True
        Me.txt_p3JKDM.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3JKDM.TabIndex = 49
        '
        'lbl_p3JKDM
        '
        Me.lbl_p3JKDM.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3JKDM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3JKDM.Location = New System.Drawing.Point(18, 386)
        Me.lbl_p3JKDM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3JKDM.Name = "lbl_p3JKDM"
        Me.lbl_p3JKDM.Size = New System.Drawing.Size(169, 13)
        Me.lbl_p3JKDM.TabIndex = 48
        Me.lbl_p3JKDM.Tag = "EXPJKDM"
        Me.lbl_p3JKDM.Text = "Input Tax Not Claimable from JKDM"
        '
        'txt_p3Travelling
        '
        Me.txt_p3Travelling.Location = New System.Drawing.Point(407, 335)
        Me.txt_p3Travelling.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3Travelling.Name = "txt_p3Travelling"
        Me.txt_p3Travelling.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3Travelling.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3Travelling.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3Travelling.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3Travelling.Properties.NullText = "0"
        Me.txt_p3Travelling.Properties.NullValuePrompt = "0"
        Me.txt_p3Travelling.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3Travelling.Properties.ReadOnly = True
        Me.txt_p3Travelling.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3Travelling.TabIndex = 47
        '
        'lbl_p3Travelling
        '
        Me.lbl_p3Travelling.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3Travelling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3Travelling.Location = New System.Drawing.Point(18, 338)
        Me.lbl_p3Travelling.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3Travelling.Name = "lbl_p3Travelling"
        Me.lbl_p3Travelling.Size = New System.Drawing.Size(134, 13)
        Me.lbl_p3Travelling.TabIndex = 46
        Me.lbl_p3Travelling.Tag = "EXPTRAVEL"
        Me.lbl_p3Travelling.Text = "Travelling && Accommodation"
        '
        'txt_p3PromotionAds
        '
        Me.txt_p3PromotionAds.Location = New System.Drawing.Point(407, 311)
        Me.txt_p3PromotionAds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3PromotionAds.Name = "txt_p3PromotionAds"
        Me.txt_p3PromotionAds.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3PromotionAds.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3PromotionAds.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3PromotionAds.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3PromotionAds.Properties.NullText = "0"
        Me.txt_p3PromotionAds.Properties.NullValuePrompt = "0"
        Me.txt_p3PromotionAds.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3PromotionAds.Properties.ReadOnly = True
        Me.txt_p3PromotionAds.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3PromotionAds.TabIndex = 45
        '
        'lbl_p3PromotionAds
        '
        Me.lbl_p3PromotionAds.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3PromotionAds.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3PromotionAds.Location = New System.Drawing.Point(18, 314)
        Me.lbl_p3PromotionAds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3PromotionAds.Name = "lbl_p3PromotionAds"
        Me.lbl_p3PromotionAds.Size = New System.Drawing.Size(131, 13)
        Me.lbl_p3PromotionAds.TabIndex = 44
        Me.lbl_p3PromotionAds.Tag = "EXPADVERTISEMENT"
        Me.lbl_p3PromotionAds.Text = "Promotion && Advertisement"
        '
        'txt_p3ResearchDev
        '
        Me.txt_p3ResearchDev.Location = New System.Drawing.Point(407, 287)
        Me.txt_p3ResearchDev.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3ResearchDev.Name = "txt_p3ResearchDev"
        Me.txt_p3ResearchDev.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3ResearchDev.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3ResearchDev.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3ResearchDev.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3ResearchDev.Properties.NullText = "0"
        Me.txt_p3ResearchDev.Properties.NullValuePrompt = "0"
        Me.txt_p3ResearchDev.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3ResearchDev.Properties.ReadOnly = True
        Me.txt_p3ResearchDev.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3ResearchDev.TabIndex = 43
        '
        'lbl_p3ResearchDev
        '
        Me.lbl_p3ResearchDev.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3ResearchDev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3ResearchDev.Location = New System.Drawing.Point(18, 290)
        Me.lbl_p3ResearchDev.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3ResearchDev.Name = "lbl_p3ResearchDev"
        Me.lbl_p3ResearchDev.Size = New System.Drawing.Size(121, 13)
        Me.lbl_p3ResearchDev.TabIndex = 42
        Me.lbl_p3ResearchDev.Tag = "EXPRND"
        Me.lbl_p3ResearchDev.Text = "Research && Development"
        '
        'txt_p3RepairMain
        '
        Me.txt_p3RepairMain.Location = New System.Drawing.Point(407, 263)
        Me.txt_p3RepairMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3RepairMain.Name = "txt_p3RepairMain"
        Me.txt_p3RepairMain.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3RepairMain.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3RepairMain.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3RepairMain.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3RepairMain.Properties.NullText = "0"
        Me.txt_p3RepairMain.Properties.NullValuePrompt = "0"
        Me.txt_p3RepairMain.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3RepairMain.Properties.ReadOnly = True
        Me.txt_p3RepairMain.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3RepairMain.TabIndex = 41
        '
        'lbl_p3RepairMain
        '
        Me.lbl_p3RepairMain.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3RepairMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3RepairMain.Location = New System.Drawing.Point(18, 266)
        Me.lbl_p3RepairMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3RepairMain.Name = "lbl_p3RepairMain"
        Me.lbl_p3RepairMain.Size = New System.Drawing.Size(98, 13)
        Me.lbl_p3RepairMain.TabIndex = 40
        Me.lbl_p3RepairMain.Tag = "EXPREPAIRMAINTENANCE"
        Me.lbl_p3RepairMain.Text = "Repair & Maintenance"
        '
        'txt_p3Rental
        '
        Me.txt_p3Rental.Location = New System.Drawing.Point(407, 239)
        Me.txt_p3Rental.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3Rental.Name = "txt_p3Rental"
        Me.txt_p3Rental.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3Rental.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3Rental.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3Rental.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3Rental.Properties.NullText = "0"
        Me.txt_p3Rental.Properties.NullValuePrompt = "0"
        Me.txt_p3Rental.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3Rental.Properties.ReadOnly = True
        Me.txt_p3Rental.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3Rental.TabIndex = 39
        '
        'lbl_p3Rental
        '
        Me.lbl_p3Rental.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3Rental.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3Rental.Location = New System.Drawing.Point(18, 242)
        Me.lbl_p3Rental.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3Rental.Name = "lbl_p3Rental"
        Me.lbl_p3Rental.Size = New System.Drawing.Size(31, 13)
        Me.lbl_p3Rental.TabIndex = 38
        Me.lbl_p3Rental.Tag = "EXPRENTAL"
        Me.lbl_p3Rental.Text = "Rental"
        '
        'txt_p3Royalty
        '
        Me.txt_p3Royalty.Location = New System.Drawing.Point(407, 215)
        Me.txt_p3Royalty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3Royalty.Name = "txt_p3Royalty"
        Me.txt_p3Royalty.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3Royalty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3Royalty.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3Royalty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3Royalty.Properties.NullText = "0"
        Me.txt_p3Royalty.Properties.NullValuePrompt = "0"
        Me.txt_p3Royalty.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3Royalty.Properties.ReadOnly = True
        Me.txt_p3Royalty.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3Royalty.TabIndex = 37
        '
        'lbl_p3Royalty
        '
        Me.lbl_p3Royalty.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3Royalty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3Royalty.Location = New System.Drawing.Point(18, 218)
        Me.lbl_p3Royalty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3Royalty.Name = "lbl_p3Royalty"
        Me.lbl_p3Royalty.Size = New System.Drawing.Size(37, 13)
        Me.lbl_p3Royalty.TabIndex = 36
        Me.lbl_p3Royalty.Tag = "EXPROYALTY"
        Me.lbl_p3Royalty.Text = "Royalty"
        '
        'txt_p3COEStock
        '
        Me.txt_p3COEStock.Location = New System.Drawing.Point(407, 191)
        Me.txt_p3COEStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3COEStock.Name = "txt_p3COEStock"
        Me.txt_p3COEStock.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3COEStock.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3COEStock.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3COEStock.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3COEStock.Properties.NullText = "0"
        Me.txt_p3COEStock.Properties.NullValuePrompt = "0"
        Me.txt_p3COEStock.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3COEStock.Properties.ReadOnly = True
        Me.txt_p3COEStock.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3COEStock.TabIndex = 35
        '
        'lbl_p3COEStock
        '
        Me.lbl_p3COEStock.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3COEStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3COEStock.Location = New System.Drawing.Point(18, 194)
        Me.lbl_p3COEStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3COEStock.Name = "lbl_p3COEStock"
        Me.lbl_p3COEStock.Size = New System.Drawing.Size(153, 13)
        Me.lbl_p3COEStock.TabIndex = 34
        Me.lbl_p3COEStock.Tag = "EXPEMPLOYEESTOCK"
        Me.lbl_p3COEStock.Text = "Cost of Employee Stock Options"
        '
        'txt_p3Salary
        '
        Me.txt_p3Salary.Location = New System.Drawing.Point(407, 167)
        Me.txt_p3Salary.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3Salary.Name = "txt_p3Salary"
        Me.txt_p3Salary.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3Salary.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3Salary.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3Salary.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3Salary.Properties.NullText = "0"
        Me.txt_p3Salary.Properties.NullValuePrompt = "0"
        Me.txt_p3Salary.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3Salary.Properties.ReadOnly = True
        Me.txt_p3Salary.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3Salary.TabIndex = 33
        '
        'lbl_p3Salary
        '
        Me.lbl_p3Salary.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3Salary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3Salary.Location = New System.Drawing.Point(18, 170)
        Me.lbl_p3Salary.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3Salary.Name = "lbl_p3Salary"
        Me.lbl_p3Salary.Size = New System.Drawing.Size(30, 13)
        Me.lbl_p3Salary.TabIndex = 32
        Me.lbl_p3Salary.Tag = "EXPSALARY"
        Me.lbl_p3Salary.Text = "Salary"
        '
        'txt_p3DirectorFee
        '
        Me.txt_p3DirectorFee.Location = New System.Drawing.Point(407, 143)
        Me.txt_p3DirectorFee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3DirectorFee.Name = "txt_p3DirectorFee"
        Me.txt_p3DirectorFee.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3DirectorFee.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3DirectorFee.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3DirectorFee.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3DirectorFee.Properties.NullText = "0"
        Me.txt_p3DirectorFee.Properties.NullValuePrompt = "0"
        Me.txt_p3DirectorFee.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3DirectorFee.Properties.ReadOnly = True
        Me.txt_p3DirectorFee.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3DirectorFee.TabIndex = 31
        '
        'lbl_p3DirectorFee
        '
        Me.lbl_p3DirectorFee.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3DirectorFee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3DirectorFee.Location = New System.Drawing.Point(18, 146)
        Me.lbl_p3DirectorFee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3DirectorFee.Name = "lbl_p3DirectorFee"
        Me.lbl_p3DirectorFee.Size = New System.Drawing.Size(66, 13)
        Me.lbl_p3DirectorFee.TabIndex = 30
        Me.lbl_p3DirectorFee.Tag = "EXPDIRECTORFEE"
        Me.lbl_p3DirectorFee.Text = "Directors' Fee"
        '
        'txt_p3ContractPay
        '
        Me.txt_p3ContractPay.Location = New System.Drawing.Point(407, 119)
        Me.txt_p3ContractPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3ContractPay.Name = "txt_p3ContractPay"
        Me.txt_p3ContractPay.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3ContractPay.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3ContractPay.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3ContractPay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3ContractPay.Properties.NullText = "0"
        Me.txt_p3ContractPay.Properties.NullValuePrompt = "0"
        Me.txt_p3ContractPay.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3ContractPay.Properties.ReadOnly = True
        Me.txt_p3ContractPay.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3ContractPay.TabIndex = 29
        '
        'lbl_p3ContractPay
        '
        Me.lbl_p3ContractPay.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3ContractPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3ContractPay.Location = New System.Drawing.Point(18, 122)
        Me.lbl_p3ContractPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3ContractPay.Name = "lbl_p3ContractPay"
        Me.lbl_p3ContractPay.Size = New System.Drawing.Size(92, 13)
        Me.lbl_p3ContractPay.TabIndex = 28
        Me.lbl_p3ContractPay.Tag = "EXPCONTRACTPAY"
        Me.lbl_p3ContractPay.Text = "Contract Payments"
        '
        'txt_p3TechPayNonResis
        '
        Me.txt_p3TechPayNonResis.Location = New System.Drawing.Point(407, 95)
        Me.txt_p3TechPayNonResis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3TechPayNonResis.Name = "txt_p3TechPayNonResis"
        Me.txt_p3TechPayNonResis.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3TechPayNonResis.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3TechPayNonResis.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3TechPayNonResis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3TechPayNonResis.Properties.NullText = "0"
        Me.txt_p3TechPayNonResis.Properties.NullValuePrompt = "0"
        Me.txt_p3TechPayNonResis.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3TechPayNonResis.Properties.ReadOnly = True
        Me.txt_p3TechPayNonResis.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3TechPayNonResis.TabIndex = 27
        '
        'lbl_p3TechPayNonResis
        '
        Me.lbl_p3TechPayNonResis.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3TechPayNonResis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3TechPayNonResis.Location = New System.Drawing.Point(18, 98)
        Me.lbl_p3TechPayNonResis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3TechPayNonResis.Name = "lbl_p3TechPayNonResis"
        Me.lbl_p3TechPayNonResis.Size = New System.Drawing.Size(239, 13)
        Me.lbl_p3TechPayNonResis.TabIndex = 26
        Me.lbl_p3TechPayNonResis.Text = "Technical fee payments to non-resident recipients"
        '
        'txt_p3ProTechManLeganFees
        '
        Me.txt_p3ProTechManLeganFees.Location = New System.Drawing.Point(407, 71)
        Me.txt_p3ProTechManLeganFees.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3ProTechManLeganFees.Name = "txt_p3ProTechManLeganFees"
        Me.txt_p3ProTechManLeganFees.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3ProTechManLeganFees.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3ProTechManLeganFees.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3ProTechManLeganFees.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3ProTechManLeganFees.Properties.NullText = "0"
        Me.txt_p3ProTechManLeganFees.Properties.NullValuePrompt = "0"
        Me.txt_p3ProTechManLeganFees.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3ProTechManLeganFees.Properties.ReadOnly = True
        Me.txt_p3ProTechManLeganFees.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3ProTechManLeganFees.TabIndex = 25
        '
        'lbl_p3ProTechManLeganFees
        '
        Me.lbl_p3ProTechManLeganFees.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3ProTechManLeganFees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3ProTechManLeganFees.Location = New System.Drawing.Point(18, 74)
        Me.lbl_p3ProTechManLeganFees.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3ProTechManLeganFees.Name = "lbl_p3ProTechManLeganFees"
        Me.lbl_p3ProTechManLeganFees.Size = New System.Drawing.Size(235, 13)
        Me.lbl_p3ProTechManLeganFees.TabIndex = 24
        Me.lbl_p3ProTechManLeganFees.Tag = "EXPLEGAL"
        Me.lbl_p3ProTechManLeganFees.Text = "Professional, Technical, Management & Legal Fees"
        '
        'txt_p3OtherInterestExHirePur
        '
        Me.txt_p3OtherInterestExHirePur.Location = New System.Drawing.Point(407, 47)
        Me.txt_p3OtherInterestExHirePur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3OtherInterestExHirePur.Name = "txt_p3OtherInterestExHirePur"
        Me.txt_p3OtherInterestExHirePur.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3OtherInterestExHirePur.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3OtherInterestExHirePur.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3OtherInterestExHirePur.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3OtherInterestExHirePur.Properties.NullText = "0"
        Me.txt_p3OtherInterestExHirePur.Properties.NullValuePrompt = "0"
        Me.txt_p3OtherInterestExHirePur.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3OtherInterestExHirePur.Properties.ReadOnly = True
        Me.txt_p3OtherInterestExHirePur.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3OtherInterestExHirePur.TabIndex = 23
        '
        'lbl_p3OtherInterestExHirePur
        '
        Me.lbl_p3OtherInterestExHirePur.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3OtherInterestExHirePur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3OtherInterestExHirePur.Location = New System.Drawing.Point(18, 50)
        Me.lbl_p3OtherInterestExHirePur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3OtherInterestExHirePur.Name = "lbl_p3OtherInterestExHirePur"
        Me.lbl_p3OtherInterestExHirePur.Size = New System.Drawing.Size(234, 13)
        Me.lbl_p3OtherInterestExHirePur.TabIndex = 22
        Me.lbl_p3OtherInterestExHirePur.Tag = "EXPOTHERINTEREST"
        Me.lbl_p3OtherInterestExHirePur.Text = "Other Interest (excluding hire purchase interest)"
        '
        'txt_p3InterestResPurS33
        '
        Me.txt_p3InterestResPurS33.Location = New System.Drawing.Point(407, 23)
        Me.txt_p3InterestResPurS33.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p3InterestResPurS33.Name = "txt_p3InterestResPurS33"
        Me.txt_p3InterestResPurS33.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p3InterestResPurS33.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p3InterestResPurS33.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p3InterestResPurS33.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p3InterestResPurS33.Properties.NullText = "0"
        Me.txt_p3InterestResPurS33.Properties.NullValuePrompt = "0"
        Me.txt_p3InterestResPurS33.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p3InterestResPurS33.Properties.ReadOnly = True
        Me.txt_p3InterestResPurS33.Size = New System.Drawing.Size(86, 20)
        Me.txt_p3InterestResPurS33.TabIndex = 21
        '
        'lbl_p3InterestResPurS33
        '
        Me.lbl_p3InterestResPurS33.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3InterestResPurS33.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3InterestResPurS33.Location = New System.Drawing.Point(18, 26)
        Me.lbl_p3InterestResPurS33.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3InterestResPurS33.Name = "lbl_p3InterestResPurS33"
        Me.lbl_p3InterestResPurS33.Size = New System.Drawing.Size(185, 13)
        Me.lbl_p3InterestResPurS33.TabIndex = 20
        Me.lbl_p3InterestResPurS33.Tag = "INTERESTRESTRICT"
        Me.lbl_p3InterestResPurS33.Text = "Interest restricted pursuant to S33 (2)"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(18, 2)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(30, 17)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Less"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Controls.Add(Me.txt_p4ExpectedExpenses)
        Me.XtraTabPage4.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4NonAllowableExpenses)
        Me.XtraTabPage4.Controls.Add(Me.lblP4NonAllowableExpenses)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4NetProfitLoss)
        Me.XtraTabPage4.Controls.Add(Me.LabelControl63)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4TotalExpenses)
        Me.XtraTabPage4.Controls.Add(Me.LabelControl62)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4TotalOtherExpenses)
        Me.XtraTabPage4.Controls.Add(Me.LabelControl61)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4OtherBalacingFigure)
        Me.XtraTabPage4.Controls.Add(Me.LabelControl60)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4Other)
        Me.XtraTabPage4.Controls.Add(Me.lbl_p4Other)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4CAExpenditure)
        Me.XtraTabPage4.Controls.Add(Me.lbl_p4CAExpenditure)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4InitSub)
        Me.XtraTabPage4.Controls.Add(Me.lbl_p4InitSub)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4ReaLossForeExNonTrade)
        Me.XtraTabPage4.Controls.Add(Me.lbl_p4ReaLossForeExNonTrade)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4ReaLossForeExTrade)
        Me.XtraTabPage4.Controls.Add(Me.lbl_p4ReaLossForeExTrade)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4UnreaLossForeEx)
        Me.XtraTabPage4.Controls.Add(Me.lbl_p4UnreaLossForeEx)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4FAWrittenOff)
        Me.XtraTabPage4.Controls.Add(Me.lbl_p4FAWrittenOff)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4LeavePass)
        Me.XtraTabPage4.Controls.Add(Me.lbl_p4LeavePass)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4ProvisionAcc)
        Me.XtraTabPage4.Controls.Add(Me.lbl_p4ProvisionAcc)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4Compound)
        Me.XtraTabPage4.Controls.Add(Me.lbl_p4Compound)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4EntStaff)
        Me.XtraTabPage4.Controls.Add(Me.lbl_p4EntStaff)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4EntNonStaff)
        Me.XtraTabPage4.Controls.Add(Me.lbl_p4EntNonStaff)
        Me.XtraTabPage4.Controls.Add(Me.txt_p4LossDispFA)
        Me.XtraTabPage4.Controls.Add(Me.lbl_p4LossDispFA)
        Me.XtraTabPage4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabPage4.Size = New System.Drawing.Size(606, 528)
        Me.XtraTabPage4.Text = "Page 4"
        '
        'txt_p4ExpectedExpenses
        '
        Me.txt_p4ExpectedExpenses.Location = New System.Drawing.Point(407, 332)
        Me.txt_p4ExpectedExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4ExpectedExpenses.Name = "txt_p4ExpectedExpenses"
        Me.txt_p4ExpectedExpenses.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4ExpectedExpenses.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4ExpectedExpenses.Properties.DisplayFormat.FormatString = "n0"
        Me.txt_p4ExpectedExpenses.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4ExpectedExpenses.Properties.Mask.EditMask = "n0"
        Me.txt_p4ExpectedExpenses.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_p4ExpectedExpenses.Properties.NullText = "0"
        Me.txt_p4ExpectedExpenses.Properties.NullValuePrompt = "0"
        Me.txt_p4ExpectedExpenses.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4ExpectedExpenses.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4ExpectedExpenses.TabIndex = 59
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(7, 336)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl1.TabIndex = 58
        Me.LabelControl1.Text = "Other (Expected Expenses)"
        '
        'txt_p4NonAllowableExpenses
        '
        Me.txt_p4NonAllowableExpenses.Location = New System.Drawing.Point(481, 468)
        Me.txt_p4NonAllowableExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4NonAllowableExpenses.Name = "txt_p4NonAllowableExpenses"
        Me.txt_p4NonAllowableExpenses.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4NonAllowableExpenses.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4NonAllowableExpenses.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4NonAllowableExpenses.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4NonAllowableExpenses.Properties.NullText = "0"
        Me.txt_p4NonAllowableExpenses.Properties.NullValuePrompt = "0"
        Me.txt_p4NonAllowableExpenses.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4NonAllowableExpenses.Properties.ReadOnly = True
        Me.txt_p4NonAllowableExpenses.Size = New System.Drawing.Size(105, 20)
        Me.txt_p4NonAllowableExpenses.TabIndex = 57
        '
        'lblP4NonAllowableExpenses
        '
        Me.lblP4NonAllowableExpenses.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4NonAllowableExpenses.Location = New System.Drawing.Point(7, 471)
        Me.lblP4NonAllowableExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblP4NonAllowableExpenses.Name = "lblP4NonAllowableExpenses"
        Me.lblP4NonAllowableExpenses.Size = New System.Drawing.Size(112, 12)
        Me.lblP4NonAllowableExpenses.TabIndex = 56
        Me.lblP4NonAllowableExpenses.Tag = "NONALLOWABLEEXPENSES"
        Me.lblP4NonAllowableExpenses.Text = "Non-Allowable Expenses"
        '
        'txt_p4NetProfitLoss
        '
        Me.txt_p4NetProfitLoss.Location = New System.Drawing.Point(481, 444)
        Me.txt_p4NetProfitLoss.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4NetProfitLoss.Name = "txt_p4NetProfitLoss"
        Me.txt_p4NetProfitLoss.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_p4NetProfitLoss.Properties.Appearance.Options.UseFont = True
        Me.txt_p4NetProfitLoss.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4NetProfitLoss.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4NetProfitLoss.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4NetProfitLoss.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4NetProfitLoss.Properties.NullText = "0"
        Me.txt_p4NetProfitLoss.Properties.NullValuePrompt = "0"
        Me.txt_p4NetProfitLoss.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4NetProfitLoss.Properties.ReadOnly = True
        Me.txt_p4NetProfitLoss.Size = New System.Drawing.Size(105, 20)
        Me.txt_p4NetProfitLoss.TabIndex = 55
        '
        'LabelControl63
        '
        Me.LabelControl63.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl63.Location = New System.Drawing.Point(7, 447)
        Me.LabelControl63.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl63.Name = "LabelControl63"
        Me.LabelControl63.Size = New System.Drawing.Size(108, 14)
        Me.LabelControl63.TabIndex = 54
        Me.LabelControl63.Text = "Net Profit or Loss"
        '
        'txt_p4TotalExpenses
        '
        Me.txt_p4TotalExpenses.Location = New System.Drawing.Point(481, 420)
        Me.txt_p4TotalExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4TotalExpenses.Name = "txt_p4TotalExpenses"
        Me.txt_p4TotalExpenses.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4TotalExpenses.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4TotalExpenses.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4TotalExpenses.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4TotalExpenses.Properties.EditFormat.FormatString = "n"
        Me.txt_p4TotalExpenses.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4TotalExpenses.Properties.Mask.EditMask = "d"
        Me.txt_p4TotalExpenses.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_p4TotalExpenses.Properties.NullText = "0"
        Me.txt_p4TotalExpenses.Properties.NullValuePrompt = "0"
        Me.txt_p4TotalExpenses.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4TotalExpenses.Properties.ReadOnly = True
        Me.txt_p4TotalExpenses.Size = New System.Drawing.Size(105, 20)
        Me.txt_p4TotalExpenses.TabIndex = 53
        '
        'LabelControl62
        '
        Me.LabelControl62.Location = New System.Drawing.Point(7, 423)
        Me.LabelControl62.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl62.Name = "LabelControl62"
        Me.LabelControl62.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl62.TabIndex = 52
        Me.LabelControl62.Text = "Total Expenses"
        '
        'txt_p4TotalOtherExpenses
        '
        Me.txt_p4TotalOtherExpenses.Location = New System.Drawing.Point(481, 396)
        Me.txt_p4TotalOtherExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4TotalOtherExpenses.Name = "txt_p4TotalOtherExpenses"
        Me.txt_p4TotalOtherExpenses.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4TotalOtherExpenses.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4TotalOtherExpenses.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4TotalOtherExpenses.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4TotalOtherExpenses.Properties.NullText = "0"
        Me.txt_p4TotalOtherExpenses.Properties.NullValuePrompt = "0"
        Me.txt_p4TotalOtherExpenses.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4TotalOtherExpenses.Properties.ReadOnly = True
        Me.txt_p4TotalOtherExpenses.Size = New System.Drawing.Size(105, 20)
        Me.txt_p4TotalOtherExpenses.TabIndex = 51
        '
        'LabelControl61
        '
        Me.LabelControl61.Location = New System.Drawing.Point(7, 399)
        Me.LabelControl61.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl61.TabIndex = 50
        Me.LabelControl61.Text = "Total Other Expenses"
        '
        'txt_p4OtherBalacingFigure
        '
        Me.txt_p4OtherBalacingFigure.Location = New System.Drawing.Point(407, 353)
        Me.txt_p4OtherBalacingFigure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4OtherBalacingFigure.Name = "txt_p4OtherBalacingFigure"
        Me.txt_p4OtherBalacingFigure.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4OtherBalacingFigure.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4OtherBalacingFigure.Properties.DisplayFormat.FormatString = "n0"
        Me.txt_p4OtherBalacingFigure.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4OtherBalacingFigure.Properties.NullText = "0"
        Me.txt_p4OtherBalacingFigure.Properties.NullValuePrompt = "0"
        Me.txt_p4OtherBalacingFigure.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4OtherBalacingFigure.Properties.ReadOnly = True
        Me.txt_p4OtherBalacingFigure.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4OtherBalacingFigure.TabIndex = 49
        '
        'LabelControl60
        '
        Me.LabelControl60.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl60.Location = New System.Drawing.Point(7, 357)
        Me.LabelControl60.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl60.TabIndex = 48
        Me.LabelControl60.Text = "Other (Balacing Figure)"
        '
        'txt_p4Other
        '
        Me.txt_p4Other.Location = New System.Drawing.Point(407, 311)
        Me.txt_p4Other.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4Other.Name = "txt_p4Other"
        Me.txt_p4Other.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4Other.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4Other.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4Other.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4Other.Properties.NullText = "0"
        Me.txt_p4Other.Properties.NullValuePrompt = "0"
        Me.txt_p4Other.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4Other.Properties.ReadOnly = True
        Me.txt_p4Other.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4Other.TabIndex = 47
        '
        'lbl_p4Other
        '
        Me.lbl_p4Other.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4Other.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4Other.Location = New System.Drawing.Point(7, 314)
        Me.lbl_p4Other.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4Other.Name = "lbl_p4Other"
        Me.lbl_p4Other.Size = New System.Drawing.Size(33, 13)
        Me.lbl_p4Other.TabIndex = 46
        Me.lbl_p4Other.Tag = "EXPOTHERSEXPENSES"
        Me.lbl_p4Other.Text = "Others"
        '
        'txt_p4CAExpenditure
        '
        Me.txt_p4CAExpenditure.Location = New System.Drawing.Point(407, 287)
        Me.txt_p4CAExpenditure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4CAExpenditure.Name = "txt_p4CAExpenditure"
        Me.txt_p4CAExpenditure.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4CAExpenditure.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4CAExpenditure.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4CAExpenditure.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4CAExpenditure.Properties.NullText = "0"
        Me.txt_p4CAExpenditure.Properties.NullValuePrompt = "0"
        Me.txt_p4CAExpenditure.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4CAExpenditure.Properties.ReadOnly = True
        Me.txt_p4CAExpenditure.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4CAExpenditure.TabIndex = 45
        '
        'lbl_p4CAExpenditure
        '
        Me.lbl_p4CAExpenditure.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4CAExpenditure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4CAExpenditure.Location = New System.Drawing.Point(7, 290)
        Me.lbl_p4CAExpenditure.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4CAExpenditure.Name = "lbl_p4CAExpenditure"
        Me.lbl_p4CAExpenditure.Size = New System.Drawing.Size(94, 13)
        Me.lbl_p4CAExpenditure.TabIndex = 44
        Me.lbl_p4CAExpenditure.Tag = "EXPCAPITALEXPENDITURE"
        Me.lbl_p4CAExpenditure.Text = "Capital Expenditure"
        '
        'txt_p4InitSub
        '
        Me.txt_p4InitSub.Location = New System.Drawing.Point(407, 263)
        Me.txt_p4InitSub.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4InitSub.Name = "txt_p4InitSub"
        Me.txt_p4InitSub.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4InitSub.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4InitSub.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4InitSub.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4InitSub.Properties.NullText = "0"
        Me.txt_p4InitSub.Properties.NullValuePrompt = "0"
        Me.txt_p4InitSub.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4InitSub.Properties.ReadOnly = True
        Me.txt_p4InitSub.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4InitSub.TabIndex = 43
        '
        'lbl_p4InitSub
        '
        Me.lbl_p4InitSub.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4InitSub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4InitSub.Location = New System.Drawing.Point(7, 266)
        Me.lbl_p4InitSub.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4InitSub.Name = "lbl_p4InitSub"
        Me.lbl_p4InitSub.Size = New System.Drawing.Size(87, 13)
        Me.lbl_p4InitSub.TabIndex = 42
        Me.lbl_p4InitSub.Tag = "EXPINITIALSUBSCRIPT"
        Me.lbl_p4InitSub.Text = "Initial Subscription"
        '
        'txt_p4ReaLossForeExNonTrade
        '
        Me.txt_p4ReaLossForeExNonTrade.Location = New System.Drawing.Point(407, 239)
        Me.txt_p4ReaLossForeExNonTrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4ReaLossForeExNonTrade.Name = "txt_p4ReaLossForeExNonTrade"
        Me.txt_p4ReaLossForeExNonTrade.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4ReaLossForeExNonTrade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4ReaLossForeExNonTrade.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4ReaLossForeExNonTrade.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4ReaLossForeExNonTrade.Properties.NullText = "0"
        Me.txt_p4ReaLossForeExNonTrade.Properties.NullValuePrompt = "0"
        Me.txt_p4ReaLossForeExNonTrade.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4ReaLossForeExNonTrade.Properties.ReadOnly = True
        Me.txt_p4ReaLossForeExNonTrade.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4ReaLossForeExNonTrade.TabIndex = 41
        '
        'lbl_p4ReaLossForeExNonTrade
        '
        Me.lbl_p4ReaLossForeExNonTrade.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4ReaLossForeExNonTrade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4ReaLossForeExNonTrade.Location = New System.Drawing.Point(7, 242)
        Me.lbl_p4ReaLossForeExNonTrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4ReaLossForeExNonTrade.Name = "lbl_p4ReaLossForeExNonTrade"
        Me.lbl_p4ReaLossForeExNonTrade.Size = New System.Drawing.Size(229, 13)
        Me.lbl_p4ReaLossForeExNonTrade.TabIndex = 40
        Me.lbl_p4ReaLossForeExNonTrade.Tag = "EXPREALLOSSFENONTRADE"
        Me.lbl_p4ReaLossForeExNonTrade.Text = "Realised Loss on Foreign Exchange - Non-Trade"
        '
        'txt_p4ReaLossForeExTrade
        '
        Me.txt_p4ReaLossForeExTrade.Location = New System.Drawing.Point(407, 215)
        Me.txt_p4ReaLossForeExTrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4ReaLossForeExTrade.Name = "txt_p4ReaLossForeExTrade"
        Me.txt_p4ReaLossForeExTrade.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4ReaLossForeExTrade.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4ReaLossForeExTrade.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4ReaLossForeExTrade.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4ReaLossForeExTrade.Properties.NullText = "0"
        Me.txt_p4ReaLossForeExTrade.Properties.NullValuePrompt = "0"
        Me.txt_p4ReaLossForeExTrade.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4ReaLossForeExTrade.Properties.ReadOnly = True
        Me.txt_p4ReaLossForeExTrade.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4ReaLossForeExTrade.TabIndex = 39
        '
        'lbl_p4ReaLossForeExTrade
        '
        Me.lbl_p4ReaLossForeExTrade.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4ReaLossForeExTrade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4ReaLossForeExTrade.Location = New System.Drawing.Point(7, 218)
        Me.lbl_p4ReaLossForeExTrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4ReaLossForeExTrade.Name = "lbl_p4ReaLossForeExTrade"
        Me.lbl_p4ReaLossForeExTrade.Size = New System.Drawing.Size(206, 13)
        Me.lbl_p4ReaLossForeExTrade.TabIndex = 38
        Me.lbl_p4ReaLossForeExTrade.Tag = "EXPREALLOSSFETRADE"
        Me.lbl_p4ReaLossForeExTrade.Text = "Realised Loss on Foreign Exchange - Trade"
        '
        'txt_p4UnreaLossForeEx
        '
        Me.txt_p4UnreaLossForeEx.Location = New System.Drawing.Point(407, 191)
        Me.txt_p4UnreaLossForeEx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4UnreaLossForeEx.Name = "txt_p4UnreaLossForeEx"
        Me.txt_p4UnreaLossForeEx.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4UnreaLossForeEx.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4UnreaLossForeEx.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4UnreaLossForeEx.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4UnreaLossForeEx.Properties.NullText = "0"
        Me.txt_p4UnreaLossForeEx.Properties.NullValuePrompt = "0"
        Me.txt_p4UnreaLossForeEx.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4UnreaLossForeEx.Properties.ReadOnly = True
        Me.txt_p4UnreaLossForeEx.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4UnreaLossForeEx.TabIndex = 37
        '
        'lbl_p4UnreaLossForeEx
        '
        Me.lbl_p4UnreaLossForeEx.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4UnreaLossForeEx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4UnreaLossForeEx.Location = New System.Drawing.Point(7, 194)
        Me.lbl_p4UnreaLossForeEx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4UnreaLossForeEx.Name = "lbl_p4UnreaLossForeEx"
        Me.lbl_p4UnreaLossForeEx.Size = New System.Drawing.Size(178, 13)
        Me.lbl_p4UnreaLossForeEx.TabIndex = 36
        Me.lbl_p4UnreaLossForeEx.Tag = "EXPUNREALLOSSFE"
        Me.lbl_p4UnreaLossForeEx.Text = "Unrealised Loss on Foreign Exchange"
        '
        'txt_p4FAWrittenOff
        '
        Me.txt_p4FAWrittenOff.Location = New System.Drawing.Point(407, 167)
        Me.txt_p4FAWrittenOff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4FAWrittenOff.Name = "txt_p4FAWrittenOff"
        Me.txt_p4FAWrittenOff.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4FAWrittenOff.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4FAWrittenOff.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4FAWrittenOff.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4FAWrittenOff.Properties.NullText = "0"
        Me.txt_p4FAWrittenOff.Properties.NullValuePrompt = "0"
        Me.txt_p4FAWrittenOff.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4FAWrittenOff.Properties.ReadOnly = True
        Me.txt_p4FAWrittenOff.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4FAWrittenOff.TabIndex = 35
        '
        'lbl_p4FAWrittenOff
        '
        Me.lbl_p4FAWrittenOff.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4FAWrittenOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4FAWrittenOff.Location = New System.Drawing.Point(7, 170)
        Me.lbl_p4FAWrittenOff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4FAWrittenOff.Name = "lbl_p4FAWrittenOff"
        Me.lbl_p4FAWrittenOff.Size = New System.Drawing.Size(115, 13)
        Me.lbl_p4FAWrittenOff.TabIndex = 34
        Me.lbl_p4FAWrittenOff.Tag = "EXPFAWRITTENOFF"
        Me.lbl_p4FAWrittenOff.Text = "Fixed Asset Written Off"
        '
        'txt_p4LeavePass
        '
        Me.txt_p4LeavePass.Location = New System.Drawing.Point(407, 143)
        Me.txt_p4LeavePass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4LeavePass.Name = "txt_p4LeavePass"
        Me.txt_p4LeavePass.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4LeavePass.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4LeavePass.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4LeavePass.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4LeavePass.Properties.NullText = "0"
        Me.txt_p4LeavePass.Properties.NullValuePrompt = "0"
        Me.txt_p4LeavePass.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4LeavePass.Properties.ReadOnly = True
        Me.txt_p4LeavePass.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4LeavePass.TabIndex = 33
        '
        'lbl_p4LeavePass
        '
        Me.lbl_p4LeavePass.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4LeavePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4LeavePass.Location = New System.Drawing.Point(7, 146)
        Me.lbl_p4LeavePass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4LeavePass.Name = "lbl_p4LeavePass"
        Me.lbl_p4LeavePass.Size = New System.Drawing.Size(72, 13)
        Me.lbl_p4LeavePass.TabIndex = 32
        Me.lbl_p4LeavePass.Tag = "EXPLEAVEPASSAGE"
        Me.lbl_p4LeavePass.Text = "Leave Passage"
        '
        'txt_p4ProvisionAcc
        '
        Me.txt_p4ProvisionAcc.Location = New System.Drawing.Point(407, 119)
        Me.txt_p4ProvisionAcc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4ProvisionAcc.Name = "txt_p4ProvisionAcc"
        Me.txt_p4ProvisionAcc.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4ProvisionAcc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4ProvisionAcc.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4ProvisionAcc.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4ProvisionAcc.Properties.NullText = "0"
        Me.txt_p4ProvisionAcc.Properties.NullValuePrompt = "0"
        Me.txt_p4ProvisionAcc.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4ProvisionAcc.Properties.ReadOnly = True
        Me.txt_p4ProvisionAcc.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4ProvisionAcc.TabIndex = 31
        '
        'lbl_p4ProvisionAcc
        '
        Me.lbl_p4ProvisionAcc.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4ProvisionAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4ProvisionAcc.Location = New System.Drawing.Point(7, 122)
        Me.lbl_p4ProvisionAcc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4ProvisionAcc.Name = "lbl_p4ProvisionAcc"
        Me.lbl_p4ProvisionAcc.Size = New System.Drawing.Size(85, 13)
        Me.lbl_p4ProvisionAcc.TabIndex = 30
        Me.lbl_p4ProvisionAcc.Tag = "EXPPROVISION"
        Me.lbl_p4ProvisionAcc.Text = "Provision Account"
        '
        'txt_p4Compound
        '
        Me.txt_p4Compound.Location = New System.Drawing.Point(407, 95)
        Me.txt_p4Compound.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4Compound.Name = "txt_p4Compound"
        Me.txt_p4Compound.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4Compound.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4Compound.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4Compound.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4Compound.Properties.NullText = "0"
        Me.txt_p4Compound.Properties.NullValuePrompt = "0"
        Me.txt_p4Compound.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4Compound.Properties.ReadOnly = True
        Me.txt_p4Compound.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4Compound.TabIndex = 29
        '
        'lbl_p4Compound
        '
        Me.lbl_p4Compound.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4Compound.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4Compound.Location = New System.Drawing.Point(7, 98)
        Me.lbl_p4Compound.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4Compound.Name = "lbl_p4Compound"
        Me.lbl_p4Compound.Size = New System.Drawing.Size(97, 13)
        Me.lbl_p4Compound.TabIndex = 28
        Me.lbl_p4Compound.Tag = "EXPCOMPAUNDPENALTY"
        Me.lbl_p4Compound.Text = "Compound / Penalty"
        '
        'txt_p4EntStaff
        '
        Me.txt_p4EntStaff.Location = New System.Drawing.Point(407, 71)
        Me.txt_p4EntStaff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4EntStaff.Name = "txt_p4EntStaff"
        Me.txt_p4EntStaff.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4EntStaff.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4EntStaff.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4EntStaff.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4EntStaff.Properties.NullText = "0"
        Me.txt_p4EntStaff.Properties.NullValuePrompt = "0"
        Me.txt_p4EntStaff.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4EntStaff.Properties.ReadOnly = True
        Me.txt_p4EntStaff.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4EntStaff.TabIndex = 27
        '
        'lbl_p4EntStaff
        '
        Me.lbl_p4EntStaff.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4EntStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4EntStaff.Location = New System.Drawing.Point(7, 74)
        Me.lbl_p4EntStaff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4EntStaff.Name = "lbl_p4EntStaff"
        Me.lbl_p4EntStaff.Size = New System.Drawing.Size(99, 13)
        Me.lbl_p4EntStaff.TabIndex = 26
        Me.lbl_p4EntStaff.Tag = "EXPENTERTAINSTAFF"
        Me.lbl_p4EntStaff.Text = "Entertainment  Staff"
        '
        'txt_p4EntNonStaff
        '
        Me.txt_p4EntNonStaff.Location = New System.Drawing.Point(407, 47)
        Me.txt_p4EntNonStaff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4EntNonStaff.Name = "txt_p4EntNonStaff"
        Me.txt_p4EntNonStaff.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4EntNonStaff.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4EntNonStaff.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4EntNonStaff.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4EntNonStaff.Properties.NullText = "0"
        Me.txt_p4EntNonStaff.Properties.NullValuePrompt = "0"
        Me.txt_p4EntNonStaff.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4EntNonStaff.Properties.ReadOnly = True
        Me.txt_p4EntNonStaff.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4EntNonStaff.TabIndex = 25
        '
        'lbl_p4EntNonStaff
        '
        Me.lbl_p4EntNonStaff.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4EntNonStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4EntNonStaff.Location = New System.Drawing.Point(7, 50)
        Me.lbl_p4EntNonStaff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4EntNonStaff.Name = "lbl_p4EntNonStaff"
        Me.lbl_p4EntNonStaff.Size = New System.Drawing.Size(118, 13)
        Me.lbl_p4EntNonStaff.TabIndex = 24
        Me.lbl_p4EntNonStaff.Tag = "EXPENTERTAINNONSTAFF"
        Me.lbl_p4EntNonStaff.Text = "Entertainment Non Staff"
        '
        'txt_p4LossDispFA
        '
        Me.txt_p4LossDispFA.Location = New System.Drawing.Point(407, 23)
        Me.txt_p4LossDispFA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4LossDispFA.Name = "txt_p4LossDispFA"
        Me.txt_p4LossDispFA.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4LossDispFA.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4LossDispFA.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4LossDispFA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4LossDispFA.Properties.NullText = "0"
        Me.txt_p4LossDispFA.Properties.NullValuePrompt = "0"
        Me.txt_p4LossDispFA.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4LossDispFA.Properties.ReadOnly = True
        Me.txt_p4LossDispFA.Size = New System.Drawing.Size(86, 20)
        Me.txt_p4LossDispFA.TabIndex = 23
        '
        'lbl_p4LossDispFA
        '
        Me.lbl_p4LossDispFA.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4LossDispFA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4LossDispFA.Location = New System.Drawing.Point(7, 26)
        Me.lbl_p4LossDispFA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4LossDispFA.Name = "lbl_p4LossDispFA"
        Me.lbl_p4LossDispFA.Size = New System.Drawing.Size(155, 13)
        Me.lbl_p4LossDispFA.TabIndex = 22
        Me.lbl_p4LossDispFA.Tag = "EXPLOSSDISPFA"
        Me.lbl_p4LossDispFA.Text = "Loss on Disposal of Fixed Assets"
        '
        'DocumentManager1
        '
        Me.DocumentManager1.ContainerControl = Me
        Me.DocumentManager1.MenuManager = Me.BarManager1
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1})
        '
        'TabbedView1
        '
        Me.TabbedView1.DocumentProperties.AllowPin = True
        Me.TabbedView1.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost
        Me.TabbedView1.OptionsLayout.PropertiesRestoreMode = DevExpress.XtraBars.Docking2010.Views.PropertiesRestoreMode.All
        '
        'RibbonControl1
        '
        Me.RibbonControl1.AllowMinimizeRibbon = False
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.BarButtonItem2, Me.BarButtonItem3, Me.btnImport, Me.btnExport, Me.cboPNLStatus, Me.txtLastModified, Me.cboRefNo, Me.cboYA, Me.txtRefNo, Me.txtNetProfit2, Me.txtNonAllowableExpense, Me.cboMainSource, Me.cboS60F, Me.cboS60FA, Me.SkinRibbonGalleryBarItem1, Me.txtBalacingFigure, Me.btnRefresh, Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarButtonItem1, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 16
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemRadioGroup1, Me.RepositoryItemComboBox1, Me.RepositoryItemTextEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemComboBox2, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemComboBox3, Me.RepositoryItemComboBox4, Me.RepositoryItemProgressBar1, Me.RepositoryItemTextEdit7})
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1315, 141)
        Me.RibbonControl1.Toolbar.ItemLinks.Add(Me.BarSubItem1)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Glyph = CType(resources.GetObject("btnSave.Glyph"), System.Drawing.Image)
        Me.btnSave.Id = 1
        Me.btnSave.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.btnSave.LargeGlyph = CType(resources.GetObject("btnSave.LargeGlyph"), System.Drawing.Image)
        Me.btnSave.Name = "btnSave"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print"
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Close"
        Me.BarButtonItem3.Glyph = CType(resources.GetObject("BarButtonItem3.Glyph"), System.Drawing.Image)
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
        Me.BarButtonItem3.LargeGlyph = CType(resources.GetObject("BarButtonItem3.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'btnImport
        '
        Me.btnImport.Caption = "Import"
        Me.btnImport.Glyph = CType(resources.GetObject("btnImport.Glyph"), System.Drawing.Image)
        Me.btnImport.Id = 4
        Me.btnImport.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9)
        Me.btnImport.LargeGlyph = CType(resources.GetObject("btnImport.LargeGlyph"), System.Drawing.Image)
        Me.btnImport.Name = "btnImport"
        '
        'btnExport
        '
        Me.btnExport.Caption = "Export"
        Me.btnExport.Glyph = CType(resources.GetObject("btnExport.Glyph"), System.Drawing.Image)
        Me.btnExport.Id = 5
        Me.btnExport.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F10)
        Me.btnExport.LargeGlyph = CType(resources.GetObject("btnExport.LargeGlyph"), System.Drawing.Image)
        Me.btnExport.Name = "btnExport"
        '
        'cboPNLStatus
        '
        Me.cboPNLStatus.Caption = "Status P&&L :"
        Me.cboPNLStatus.Edit = Me.RepositoryItemComboBox1
        Me.cboPNLStatus.Id = 10
        Me.cboPNLStatus.Name = "cboPNLStatus"
        Me.cboPNLStatus.Width = 160
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"New", "Finished", "Ammen Require", "Bookmarks", "Unfinished"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'txtLastModified
        '
        Me.txtLastModified.Caption = "Last Modified :"
        Me.txtLastModified.Edit = Me.RepositoryItemTextEdit1
        Me.txtLastModified.Id = 11
        Me.txtLastModified.Name = "txtLastModified"
        Me.txtLastModified.Width = 350
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.ReadOnly = True
        '
        'cboRefNo
        '
        Me.cboRefNo.Caption = "Tax Payer :"
        Me.cboRefNo.Edit = Me.RepositoryItemLookUpEdit1
        Me.cboRefNo.Glyph = CType(resources.GetObject("cboRefNo.Glyph"), System.Drawing.Image)
        Me.cboRefNo.Id = 15
        Me.cboRefNo.Name = "cboRefNo"
        Me.cboRefNo.Width = 150
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("RefNo", "Ref No", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "Company Name", 250, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyNo", "Company No", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployerNo", "Employer No", 70, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FileNo", "File No", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyCode", "Company Code", 83, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.TaxPayerFindBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "CompanyName"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = "Please select"
        Me.RepositoryItemLookUpEdit1.PopupFormMinSize = New System.Drawing.Size(450, 0)
        Me.RepositoryItemLookUpEdit1.ValueMember = "RefNo"
        '
        'TaxPayerFindBindingSource
        '
        Me.TaxPayerFindBindingSource.DataMember = "TaxPayerFind"
        Me.TaxPayerFindBindingSource.DataSource = Me.DsCA
        '
        'DsCA
        '
        Me.DsCA.DataSetName = "dsCA"
        Me.DsCA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboYA
        '
        Me.cboYA.Caption = "YA : "
        Me.cboYA.Edit = Me.RepositoryItemComboBox2
        Me.cboYA.Glyph = CType(resources.GetObject("cboYA.Glyph"), System.Drawing.Image)
        Me.cboYA.Id = 16
        Me.cboYA.LargeGlyph = CType(resources.GetObject("cboYA.LargeGlyph"), System.Drawing.Image)
        Me.cboYA.Name = "cboYA"
        Me.cboYA.Width = 150
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'txtRefNo
        '
        Me.txtRefNo.Caption = "Tax Payer :"
        Me.txtRefNo.Edit = Me.RepositoryItemTextEdit2
        Me.txtRefNo.Glyph = CType(resources.GetObject("txtRefNo.Glyph"), System.Drawing.Image)
        Me.txtRefNo.Id = 17
        Me.txtRefNo.LargeGlyph = CType(resources.GetObject("txtRefNo.LargeGlyph"), System.Drawing.Image)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Width = 150
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        Me.RepositoryItemTextEdit2.ReadOnly = True
        '
        'txtNetProfit2
        '
        Me.txtNetProfit2.Caption = "Net Profit :"
        Me.txtNetProfit2.Edit = Me.RepositoryItemTextEdit3
        Me.txtNetProfit2.Id = 18
        Me.txtNetProfit2.Name = "txtNetProfit2"
        Me.txtNetProfit2.Width = 175
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatString = "n"
        Me.RepositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit3.Mask.EditMask = "c"
        Me.RepositoryItemTextEdit3.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        Me.RepositoryItemTextEdit3.NullText = "0"
        Me.RepositoryItemTextEdit3.NullValuePrompt = "0"
        Me.RepositoryItemTextEdit3.NullValuePromptShowForEmptyValue = True
        Me.RepositoryItemTextEdit3.ReadOnly = True
        '
        'txtNonAllowableExpense
        '
        Me.txtNonAllowableExpense.Caption = "Non Allowable Expenses : "
        Me.txtNonAllowableExpense.Edit = Me.RepositoryItemTextEdit4
        Me.txtNonAllowableExpense.Id = 19
        Me.txtNonAllowableExpense.Name = "txtNonAllowableExpense"
        Me.txtNonAllowableExpense.Width = 100
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatString = "n0"
        Me.RepositoryItemTextEdit4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        Me.RepositoryItemTextEdit4.NullText = "0"
        Me.RepositoryItemTextEdit4.ReadOnly = True
        '
        'cboMainSource
        '
        Me.cboMainSource.Caption = "Source No :"
        Me.cboMainSource.Edit = Me.RepositoryItemLookUpEdit2
        Me.cboMainSource.Id = 20
        Me.cboMainSource.Name = "cboMainSource"
        Me.cboMainSource.Width = 130
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_SOURCEKEY", "BC_SOURCEKEY", 101, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_SOURCENO", "Source No", 100, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_CODE", "Code", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BC_TYPE", "Type", 250, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.BUSINESSSOURCEBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "BC_SOURCENO"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = "Please select"
        Me.RepositoryItemLookUpEdit2.PopupFormMinSize = New System.Drawing.Size(300, 120)
        Me.RepositoryItemLookUpEdit2.ValueMember = "BC_SOURCENO"
        '
        'BUSINESSSOURCEBindingSource
        '
        Me.BUSINESSSOURCEBindingSource.DataMember = "BUSINESS_SOURCE"
        Me.BUSINESSSOURCEBindingSource.DataSource = Me.DsPNL
        '
        'DsPNL
        '
        Me.DsPNL.DataSetName = "dsPNL"
        Me.DsPNL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboS60F
        '
        Me.cboS60F.Caption = "S60F Applicable :   "
        Me.cboS60F.Edit = Me.RepositoryItemComboBox3
        Me.cboS60F.Id = 21
        Me.cboS60F.Name = "cboS60F"
        Me.cboS60F.Width = 100
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Items.AddRange(New Object() {"Yes", "No"})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        Me.RepositoryItemComboBox3.NullText = "Yes"
        Me.RepositoryItemComboBox3.NullValuePrompt = "Yes"
        Me.RepositoryItemComboBox3.NullValuePromptShowForEmptyValue = True
        Me.RepositoryItemComboBox3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'cboS60FA
        '
        Me.cboS60FA.Caption = "S60FA Applicable : "
        Me.cboS60FA.Edit = Me.RepositoryItemComboBox4
        Me.cboS60FA.Id = 23
        Me.cboS60FA.Name = "cboS60FA"
        Me.cboS60FA.Width = 100
        '
        'RepositoryItemComboBox4
        '
        Me.RepositoryItemComboBox4.AutoHeight = False
        Me.RepositoryItemComboBox4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox4.Items.AddRange(New Object() {"Yes", "No"})
        Me.RepositoryItemComboBox4.Name = "RepositoryItemComboBox4"
        Me.RepositoryItemComboBox4.NullText = "No"
        Me.RepositoryItemComboBox4.NullValuePrompt = "No"
        Me.RepositoryItemComboBox4.NullValuePromptShowForEmptyValue = True
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinRibbonGalleryBarItem1.Id = 2
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'txtBalacingFigure
        '
        Me.txtBalacingFigure.Caption = "Balacing Figure : "
        Me.txtBalacingFigure.Edit = Me.RepositoryItemTextEdit7
        Me.txtBalacingFigure.Id = 3
        Me.txtBalacingFigure.Name = "txtBalacingFigure"
        Me.txtBalacingFigure.Width = 145
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        Me.RepositoryItemTextEdit7.ReadOnly = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Caption = "Refresh"
        Me.btnRefresh.Glyph = CType(resources.GetObject("btnRefresh.Glyph"), System.Drawing.Image)
        Me.btnRefresh.Id = 4
        Me.btnRefresh.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
        Me.btnRefresh.LargeGlyph = CType(resources.GetObject("btnRefresh.LargeGlyph"), System.Drawing.Image)
        Me.btnRefresh.Name = "btnRefresh"
        ToolTipTitleItem1.Text = "Refresh Data"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Refresh Profit and Loss Data"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnRefresh.SuperTip = SuperToolTip1
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "View"
        Me.BarSubItem1.Description = "View"
        Me.BarSubItem1.Glyph = CType(resources.GetObject("BarSubItem1.Glyph"), System.Drawing.Image)
        Me.BarSubItem1.Id = 9
        Me.BarSubItem1.LargeGlyph = CType(resources.GetObject("BarSubItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5)})
        Me.BarSubItem1.Name = "BarSubItem1"
        Me.BarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.BarSubItem1.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Information"
        Me.BarButtonItem1.Id = 12
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Import Data List"
        Me.BarButtonItem4.Id = 13
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Refresh"
        Me.BarButtonItem5.Id = 14
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Information"
        Me.BarSubItem2.Id = 10
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Import List"
        Me.BarSubItem3.Id = 11
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Home"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRefresh)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Action"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.cboRefNo)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.txtRefNo)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.cboYA, True)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.cboMainSource)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.cboS60F, True)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.cboS60FA)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "General Information"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.txtNetProfit2)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.txtBalacingFigure)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.txtNonAllowableExpense)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Advance Information"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup5})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Advance"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnImport)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnExport)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.txtLastModified, True)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.cboPNLStatus)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Advance"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Theme"
        '
        'RepositoryItemRadioGroup1
        '
        Me.RepositoryItemRadioGroup1.Name = "RepositoryItemRadioGroup1"
        '
        'RepositoryItemProgressBar1
        '
        Me.RepositoryItemProgressBar1.Name = "RepositoryItemProgressBar1"
        '
        'WorkspaceManager1
        '
        Me.WorkspaceManager1.TargetControl = Me.RibbonControl1
        Me.WorkspaceManager1.TransitionType = PushTransition1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pnlDocExport
        '
        Me.pnlDocExport.Controls.Add(Me.ControlContainer1)
        Me.pnlDocExport.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.pnlDocExport.ID = New System.Guid("745323fa-419a-4730-bb91-2039d9d9de58")
        Me.pnlDocExport.Location = New System.Drawing.Point(0, 0)
        Me.pnlDocExport.Name = "pnlDocExport"
        Me.pnlDocExport.OriginalSize = New System.Drawing.Size(352, 200)
        Me.pnlDocExport.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.pnlDocExport.SavedIndex = 1
        Me.pnlDocExport.Size = New System.Drawing.Size(352, 583)
        Me.pnlDocExport.Tag = "Export Data List"
        Me.pnlDocExport.Text = "Export Data List"
        Me.pnlDocExport.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'ControlContainer1
        '
        Me.ControlContainer1.Controls.Add(Me.dgvExport)
        Me.ControlContainer1.Location = New System.Drawing.Point(4, 23)
        Me.ControlContainer1.Name = "ControlContainer1"
        Me.ControlContainer1.Size = New System.Drawing.Size(344, 556)
        Me.ControlContainer1.TabIndex = 0
        '
        'frmPNL_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 749)
        Me.Controls.Add(Me.pnlDocInformation)
        Me.Controls.Add(Me.hideContainerRight)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPNL_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profit And Loss"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerRight.ResumeLayout(False)
        Me.pnlDocImport.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDocInformation.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.XtraScrollableControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.dgvExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportPNLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p1GrossProfitLoss.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p1COS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p1CloseStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p1PCP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p1COP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p1NonAllowableExpenses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p1AllowanceExpenses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p1Depreciation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p1Purchase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p1OpenStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p1Sales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        CType(Me.txt_p2Other.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2NonTaxProfit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2UnreaGainForeExNon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2UnreaGainForeEx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2ReaForeExGainNonTrade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2ForeIncomeRemmit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2ExemptDividend.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2ProDisInvestment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2ProDispPlantEq.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2NonBizIncome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2OtherIncome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2RoyaltyIncome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2RentalIncome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2InterestIncome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2DivIncome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2ForeignCurrExGain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p2OtherBizIncome.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.txt_p3ForeignCurrExLoss.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3Zakat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3DonationNonApp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3DonationApp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3Depreciation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3JKDM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3Travelling.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3PromotionAds.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3ResearchDev.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3RepairMain.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3Rental.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3Royalty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3COEStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3Salary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3DirectorFee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3ContractPay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3TechPayNonResis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3ProTechManLeganFees.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3OtherInterestExHirePur.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p3InterestResPurS33.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.txt_p4ExpectedExpenses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4NonAllowableExpenses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4NetProfitLoss.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4TotalExpenses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4TotalOtherExpenses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4OtherBalacingFigure.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4Other.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4CAExpenditure.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4InitSub.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4ReaLossForeExNonTrade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4ReaLossForeExTrade.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4UnreaLossForeEx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4FAWrittenOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4LeavePass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4ProvisionAcc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4Compound.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4EntStaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4EntNonStaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4LossDispFA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BUSINESSSOURCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDocExport.ResumeLayout(False)
        Me.ControlContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents pnlDocInformation As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txt_p1GrossProfitLoss As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p1COS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p1CloseStock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p1PCP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p1COP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p1NonAllowableExpenses As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p1AllowanceExpenses As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p1Depreciation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p1Purchase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p1OpenStock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p1Sales As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p1CloseStock As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p1AllowanceExpenses As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p1Depreciation As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p1Purchase As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p1OpenStock As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p1Sales As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Friend WithEvents lbl_p1NonAllowableExpenses As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p2NonTaxProfit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2UnreaGainForeExNon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2UnreaGainForeEx As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2ReaForeExGainNonTrade As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2ForeIncomeRemmit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2ExemptDividend As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2ProDisInvestment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2ProDispPlantEq As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2NonBizIncome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2OtherIncome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2RoyaltyIncome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2RentalIncome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2InterestIncome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2DivIncome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2ForeignCurrExGain As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_p2OtherBizIncome As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p2Other As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p2UnreaGainForeEx As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p2ReaForeExGainNonTrade As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p2ForeIncomeRemmit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p2ExemptDividend As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p2ProDisInvestment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p2ProDispPlantEq As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p2OtherIncome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p2RoyaltyIncome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p2RentalIncome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p2InterestIncome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p2DivIncome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p2ForeignCurrExGain As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_p2OtherBizIncome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cboPNLStatus As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents txtLastModified As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents cboRefNo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboYA As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents lbl_p2UnreaGainForeExNon As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p2Other As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3Zakat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3Zakat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3DonationNonApp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3DonationNonApp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3DonationApp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3DonationApp As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3Depreciation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3Depreciation As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3JKDM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3JKDM As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3Travelling As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3Travelling As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3PromotionAds As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3PromotionAds As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3ResearchDev As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3ResearchDev As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3RepairMain As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3RepairMain As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3Rental As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3Rental As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3Royalty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3Royalty As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3COEStock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3COEStock As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3Salary As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3Salary As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3DirectorFee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3DirectorFee As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3ContractPay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3ContractPay As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3TechPayNonResis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3TechPayNonResis As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3ProTechManLeganFees As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3ProTechManLeganFees As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3OtherInterestExHirePur As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3OtherInterestExHirePur As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3InterestResPurS33 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3InterestResPurS33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4NonAllowableExpenses As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblP4NonAllowableExpenses As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4NetProfitLoss As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl63 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4TotalExpenses As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4TotalOtherExpenses As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4OtherBalacingFigure As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4Other As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p4Other As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4CAExpenditure As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p4CAExpenditure As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4InitSub As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p4InitSub As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4ReaLossForeExNonTrade As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p4ReaLossForeExNonTrade As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4ReaLossForeExTrade As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p4ReaLossForeExTrade As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4UnreaLossForeEx As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p4UnreaLossForeEx As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4FAWrittenOff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p4FAWrittenOff As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4LeavePass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p4LeavePass As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4ProvisionAcc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p4ProvisionAcc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4Compound As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p4Compound As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4EntStaff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p4EntStaff As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4EntNonStaff As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p4EntNonStaff As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p4LossDispFA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p4LossDispFA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p3ForeignCurrExLoss As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_p3ForeignCurrExLoss As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRefNo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtNetProfit2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txt_p4ExpectedExpenses As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNonAllowableExpense As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cboMainSource As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BUSINESSSOURCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPNL As EasyTemplate_Taxcom.dsPNL
    Friend WithEvents cboS60F As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cboS60FA As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox4 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents WorkspaceManager1 As DevExpress.Utils.WorkspaceManager
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents pnlProgress As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemProgressBar2 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtPCName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents txtBalacingFigure As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btnRefresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents ExportPNLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPNL2 As EasyTemplate_Taxcom.dsPNL2
    Friend WithEvents dgvExport As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNo2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLeftAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRightAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pnlDocImport As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents UcPNL_Import1 As EasyTemplate_Taxcom.ucPNL_Import
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents hideContainerRight As DevExpress.XtraBars.Docking.AutoHideContainer
    Friend WithEvents pnlDocExport As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents ControlContainer1 As DevExpress.XtraBars.Docking.ControlContainer
End Class
