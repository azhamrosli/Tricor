<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPNL_B_Add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPNL_B_Add))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim PushTransition1 As DevExpress.Utils.Animation.PushTransition = New DevExpress.Utils.Animation.PushTransition()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.hideContainerRight = New DevExpress.XtraBars.Docking.AutoHideContainer()
        Me.pnlDocImport = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.UcPNL_Import1 = New EasyTemplate_Taxcom.ucPNL_Import()
        Me.pnlDocExport = New DevExpress.XtraBars.Docking.DockPanel()
        Me.ControlContainer1 = New DevExpress.XtraBars.Docking.ControlContainer()
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
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_p2UnreaGainForeExNon = New DevExpress.XtraEditors.LabelControl()
        Me.txt_p2Other = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2NonTaxProfit = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2UnreaGainForeExNon = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2UnreaGainForeEx = New DevExpress.XtraEditors.TextEdit()
        Me.txt_p2ReaForeExGainNonTrade = New DevExpress.XtraEditors.TextEdit()
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
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.TextEdit16 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit12 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit13 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit14 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit15 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
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
        Me.btnErrorLog = New DevExpress.XtraBars.BarButtonItem()
        Me.cboRefNo = New DevExpress.XtraBars.BarEditItem()
        Me.TaxPayerFindBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCA = New EasyTemplate_Taxcom.dsCA()
        Me.RepositoryItemSearchLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
        Me.RepositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHandleBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmployerNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompanyCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
        Me.WorkspaceManager1 = New DevExpress.Utils.WorkspaceManager()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hideContainerRight.SuspendLayout()
        Me.pnlDocImport.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        Me.pnlDocExport.SuspendLayout()
        Me.ControlContainer1.SuspendLayout()
        CType(Me.dgvExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExportPNLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPNL2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.txt_p2NonBizIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2OtherIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2RoyaltyIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2RentalIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2InterestIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2DivIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2ForeignCurrExGain.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p2OtherBizIncome.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
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
        Me.XtraTabPage5.SuspendLayout()
        CType(Me.TextEdit16.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit15.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage4.SuspendLayout()
        CType(Me.txt_p4ExpectedExpenses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4NonAllowableExpenses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4NetProfitLoss.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4TotalExpenses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4TotalOtherExpenses.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4OtherBalacingFigure.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4UnreaLossForeEx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4FAWrittenOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4LeavePass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4ProvisionAcc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4Compound.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4EntStaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_p4EntNonStaff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.hideContainerRight.Location = New System.Drawing.Point(1510, 177)
        Me.hideContainerRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.hideContainerRight.Name = "hideContainerRight"
        Me.hideContainerRight.Size = New System.Drawing.Size(24, 711)
        '
        'pnlDocImport
        '
        Me.pnlDocImport.Controls.Add(Me.DockPanel2_Container)
        Me.pnlDocImport.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.pnlDocImport.ID = New System.Guid("be65f503-51a1-4e68-b6dd-9904920f171e")
        Me.pnlDocImport.Location = New System.Drawing.Point(0, 0)
        Me.pnlDocImport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlDocImport.Name = "pnlDocImport"
        Me.pnlDocImport.OriginalSize = New System.Drawing.Size(584, 198)
        Me.pnlDocImport.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.pnlDocImport.SavedIndex = 0
        Me.pnlDocImport.Size = New System.Drawing.Size(681, 718)
        Me.pnlDocImport.Text = "Import Data List"
        Me.pnlDocImport.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.UcPNL_Import1)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(5, 28)
        Me.DockPanel2_Container.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(672, 684)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'UcPNL_Import1
        '
        Me.UcPNL_Import1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcPNL_Import1.Location = New System.Drawing.Point(0, 0)
        Me.UcPNL_Import1.MainData = Nothing
        Me.UcPNL_Import1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.UcPNL_Import1.Name = "UcPNL_Import1"
        Me.UcPNL_Import1.Size = New System.Drawing.Size(672, 684)
        Me.UcPNL_Import1.TabIndex = 0
        '
        'pnlDocExport
        '
        Me.pnlDocExport.Controls.Add(Me.ControlContainer1)
        Me.pnlDocExport.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.pnlDocExport.ID = New System.Guid("745323fa-419a-4730-bb91-2039d9d9de58")
        Me.pnlDocExport.Location = New System.Drawing.Point(0, 0)
        Me.pnlDocExport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlDocExport.Name = "pnlDocExport"
        Me.pnlDocExport.OriginalSize = New System.Drawing.Size(352, 200)
        Me.pnlDocExport.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.pnlDocExport.SavedIndex = 1
        Me.pnlDocExport.Size = New System.Drawing.Size(411, 718)
        Me.pnlDocExport.Tag = "Export Data List"
        Me.pnlDocExport.Text = "Export Data List"
        Me.pnlDocExport.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
        '
        'ControlContainer1
        '
        Me.ControlContainer1.Controls.Add(Me.dgvExport)
        Me.ControlContainer1.Location = New System.Drawing.Point(5, 28)
        Me.ControlContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ControlContainer1.Name = "ControlContainer1"
        Me.ControlContainer1.Size = New System.Drawing.Size(401, 684)
        Me.ControlContainer1.TabIndex = 0
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
        Me.dgvExport.Size = New System.Drawing.Size(401, 684)
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
        Me.pnlProgress.EditWidth = 100
        Me.pnlProgress.Id = 0
        Me.pnlProgress.Name = "pnlProgress"
        Me.pnlProgress.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.pnlProgress.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1534, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 888)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1534, 34)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 888)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1534, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 888)
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
        Me.pnlDocInformation.Location = New System.Drawing.Point(0, 177)
        Me.pnlDocInformation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlDocInformation.Name = "pnlDocInformation"
        Me.pnlDocInformation.Options.ShowCloseButton = False
        Me.pnlDocInformation.OriginalSize = New System.Drawing.Size(730, 200)
        Me.pnlDocInformation.Size = New System.Drawing.Size(730, 711)
        Me.pnlDocInformation.Text = "Information"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.XtraScrollableControl1)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(5, 27)
        Me.DockPanel1_Container.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(718, 679)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraScrollableControl1.Controls.Add(Me.XtraTabControl1)
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraScrollableControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.XtraScrollableControl1.MinimumSize = New System.Drawing.Size(714, 684)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(824, 807)
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
        Me.XtraTabControl1.MinimumSize = New System.Drawing.Size(714, 684)
        Me.XtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Size = New System.Drawing.Size(718, 807)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage5, Me.XtraTabPage4})
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
        Me.XtraTabPage1.Size = New System.Drawing.Size(711, 773)
        Me.XtraTabPage1.Text = " Page 1"
        '
        'lbl_p1NonAllowableExpenses
        '
        Me.lbl_p1NonAllowableExpenses.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p1NonAllowableExpenses.Appearance.Options.UseFont = True
        Me.lbl_p1NonAllowableExpenses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p1NonAllowableExpenses.Location = New System.Drawing.Point(6, 234)
        Me.lbl_p1NonAllowableExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p1NonAllowableExpenses.Name = "lbl_p1NonAllowableExpenses"
        Me.lbl_p1NonAllowableExpenses.Size = New System.Drawing.Size(137, 16)
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
        Me.ProgressPanel1.BarAnimationElementThickness = 2
        Me.ProgressPanel1.Location = New System.Drawing.Point(301, 211)
        Me.ProgressPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.Size = New System.Drawing.Size(254, 76)
        Me.ProgressPanel1.TabIndex = 7
        Me.ProgressPanel1.Text = "ProgressPanel1"
        '
        'txt_p1GrossProfitLoss
        '
        Me.txt_p1GrossProfitLoss.Location = New System.Drawing.Point(553, 423)
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
        Me.txt_p1GrossProfitLoss.Size = New System.Drawing.Size(100, 22)
        Me.txt_p1GrossProfitLoss.TabIndex = 21
        '
        'txt_p1COS
        '
        Me.txt_p1COS.Location = New System.Drawing.Point(553, 378)
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
        Me.txt_p1COS.Size = New System.Drawing.Size(100, 22)
        Me.txt_p1COS.TabIndex = 20
        '
        'txt_p1CloseStock
        '
        Me.txt_p1CloseStock.Location = New System.Drawing.Point(450, 350)
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
        Me.txt_p1CloseStock.Size = New System.Drawing.Size(100, 22)
        Me.txt_p1CloseStock.TabIndex = 19
        '
        'txt_p1PCP
        '
        Me.txt_p1PCP.Location = New System.Drawing.Point(450, 305)
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
        Me.txt_p1PCP.Size = New System.Drawing.Size(100, 22)
        Me.txt_p1PCP.TabIndex = 18
        '
        'txt_p1COP
        '
        Me.txt_p1COP.Location = New System.Drawing.Point(344, 257)
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
        Me.txt_p1COP.Size = New System.Drawing.Size(100, 22)
        Me.txt_p1COP.TabIndex = 17
        '
        'txt_p1NonAllowableExpenses
        '
        Me.txt_p1NonAllowableExpenses.Location = New System.Drawing.Point(238, 230)
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
        Me.txt_p1NonAllowableExpenses.Size = New System.Drawing.Size(100, 22)
        Me.txt_p1NonAllowableExpenses.TabIndex = 16
        '
        'txt_p1AllowanceExpenses
        '
        Me.txt_p1AllowanceExpenses.Location = New System.Drawing.Point(238, 202)
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
        Me.txt_p1AllowanceExpenses.Size = New System.Drawing.Size(100, 22)
        Me.txt_p1AllowanceExpenses.TabIndex = 15
        '
        'txt_p1Depreciation
        '
        Me.txt_p1Depreciation.Location = New System.Drawing.Point(238, 174)
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
        Me.txt_p1Depreciation.Size = New System.Drawing.Size(100, 22)
        Me.txt_p1Depreciation.TabIndex = 14
        '
        'txt_p1Purchase
        '
        Me.txt_p1Purchase.Location = New System.Drawing.Point(344, 108)
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
        Me.txt_p1Purchase.Size = New System.Drawing.Size(100, 22)
        Me.txt_p1Purchase.TabIndex = 13
        '
        'txt_p1OpenStock
        '
        Me.txt_p1OpenStock.Location = New System.Drawing.Point(450, 86)
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
        Me.txt_p1OpenStock.Size = New System.Drawing.Size(100, 22)
        Me.txt_p1OpenStock.TabIndex = 12
        '
        'txt_p1Sales
        '
        Me.txt_p1Sales.Location = New System.Drawing.Point(553, 17)
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
        Me.txt_p1Sales.Size = New System.Drawing.Size(100, 22)
        Me.txt_p1Sales.TabIndex = 11
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(6, 423)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(161, 21)
        Me.LabelControl11.TabIndex = 10
        Me.LabelControl11.Text = "Gross Profit / Loss"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(6, 378)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(109, 21)
        Me.LabelControl10.TabIndex = 9
        Me.LabelControl10.Text = "Cost of sales"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(6, 305)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(287, 21)
        Me.LabelControl9.TabIndex = 8
        Me.LabelControl9.Text = "Purchases and cost of production"
        '
        'lbl_p1CloseStock
        '
        Me.lbl_p1CloseStock.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p1CloseStock.Appearance.Options.UseFont = True
        Me.lbl_p1CloseStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p1CloseStock.Location = New System.Drawing.Point(6, 354)
        Me.lbl_p1CloseStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p1CloseStock.Name = "lbl_p1CloseStock"
        Me.lbl_p1CloseStock.Size = New System.Drawing.Size(75, 16)
        Me.lbl_p1CloseStock.TabIndex = 7
        Me.lbl_p1CloseStock.Tag = "CLOSESTOCK"
        Me.lbl_p1CloseStock.Text = "Closing stock"
        '
        'lbl_p1AllowanceExpenses
        '
        Me.lbl_p1AllowanceExpenses.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p1AllowanceExpenses.Appearance.Options.UseFont = True
        Me.lbl_p1AllowanceExpenses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p1AllowanceExpenses.Location = New System.Drawing.Point(6, 206)
        Me.lbl_p1AllowanceExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p1AllowanceExpenses.Name = "lbl_p1AllowanceExpenses"
        Me.lbl_p1AllowanceExpenses.Size = New System.Drawing.Size(112, 16)
        Me.lbl_p1AllowanceExpenses.TabIndex = 6
        Me.lbl_p1AllowanceExpenses.Tag = "OTHERALLOWEXP"
        Me.lbl_p1AllowanceExpenses.Text = "Allowable expenses"
        '
        'lbl_p1Depreciation
        '
        Me.lbl_p1Depreciation.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p1Depreciation.Appearance.Options.UseFont = True
        Me.lbl_p1Depreciation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p1Depreciation.Location = New System.Drawing.Point(6, 178)
        Me.lbl_p1Depreciation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p1Depreciation.Name = "lbl_p1Depreciation"
        Me.lbl_p1Depreciation.Size = New System.Drawing.Size(71, 16)
        Me.lbl_p1Depreciation.TabIndex = 5
        Me.lbl_p1Depreciation.Tag = "DEPRECIATION"
        Me.lbl_p1Depreciation.Text = "Depreciation"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(6, 151)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(160, 21)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Cost of production"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(6, 52)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 21)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Less"
        '
        'lbl_p1Purchase
        '
        Me.lbl_p1Purchase.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p1Purchase.Appearance.Options.UseFont = True
        Me.lbl_p1Purchase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p1Purchase.Location = New System.Drawing.Point(6, 112)
        Me.lbl_p1Purchase.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p1Purchase.Name = "lbl_p1Purchase"
        Me.lbl_p1Purchase.Size = New System.Drawing.Size(58, 16)
        Me.lbl_p1Purchase.TabIndex = 2
        Me.lbl_p1Purchase.Tag = "PURCHASE"
        Me.lbl_p1Purchase.Text = "Purchases"
        '
        'lbl_p1OpenStock
        '
        Me.lbl_p1OpenStock.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p1OpenStock.Appearance.Options.UseFont = True
        Me.lbl_p1OpenStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p1OpenStock.Location = New System.Drawing.Point(6, 90)
        Me.lbl_p1OpenStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p1OpenStock.Name = "lbl_p1OpenStock"
        Me.lbl_p1OpenStock.Size = New System.Drawing.Size(81, 16)
        Me.lbl_p1OpenStock.TabIndex = 1
        Me.lbl_p1OpenStock.Tag = "OPENSTOCK"
        Me.lbl_p1OpenStock.Text = "Opening stock"
        '
        'lbl_p1Sales
        '
        Me.lbl_p1Sales.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Underline)
        Me.lbl_p1Sales.Appearance.Options.UseFont = True
        Me.lbl_p1Sales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p1Sales.Location = New System.Drawing.Point(6, 21)
        Me.lbl_p1Sales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p1Sales.Name = "lbl_p1Sales"
        Me.lbl_p1Sales.Size = New System.Drawing.Size(86, 16)
        Me.lbl_p1Sales.TabIndex = 0
        Me.lbl_p1Sales.Tag = "SALES"
        Me.lbl_p1Sales.Text = "Sale / turnover"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.lbl_p2UnreaGainForeExNon)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2Other)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2NonTaxProfit)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2UnreaGainForeExNon)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2UnreaGainForeEx)
        Me.XtraTabPage2.Controls.Add(Me.txt_p2ReaForeExGainNonTrade)
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
        Me.XtraTabPage2.Size = New System.Drawing.Size(711, 773)
        Me.XtraTabPage2.Text = "Page 2"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(6, 24)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(146, 21)
        Me.LabelControl3.TabIndex = 37
        Me.LabelControl3.Text = "Business Income"
        '
        'lbl_p2UnreaGainForeExNon
        '
        Me.lbl_p2UnreaGainForeExNon.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2UnreaGainForeExNon.Appearance.Options.UseFont = True
        Me.lbl_p2UnreaGainForeExNon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2UnreaGainForeExNon.Location = New System.Drawing.Point(6, 415)
        Me.lbl_p2UnreaGainForeExNon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2UnreaGainForeExNon.Name = "lbl_p2UnreaGainForeExNon"
        Me.lbl_p2UnreaGainForeExNon.Size = New System.Drawing.Size(120, 17)
        Me.lbl_p2UnreaGainForeExNon.TabIndex = 36
        Me.lbl_p2UnreaGainForeExNon.Tag = "UNREALFENONTRADE"
        Me.lbl_p2UnreaGainForeExNon.Text = "Gain on Investment"
        '
        'txt_p2Other
        '
        Me.txt_p2Other.Location = New System.Drawing.Point(360, 440)
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
        Me.txt_p2Other.Size = New System.Drawing.Size(100, 22)
        Me.txt_p2Other.TabIndex = 35
        '
        'txt_p2NonTaxProfit
        '
        Me.txt_p2NonTaxProfit.Location = New System.Drawing.Point(474, 475)
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
        Me.txt_p2NonTaxProfit.Size = New System.Drawing.Size(100, 22)
        Me.txt_p2NonTaxProfit.TabIndex = 34
        '
        'txt_p2UnreaGainForeExNon
        '
        Me.txt_p2UnreaGainForeExNon.Location = New System.Drawing.Point(360, 411)
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
        Me.txt_p2UnreaGainForeExNon.Size = New System.Drawing.Size(100, 22)
        Me.txt_p2UnreaGainForeExNon.TabIndex = 33
        '
        'txt_p2UnreaGainForeEx
        '
        Me.txt_p2UnreaGainForeEx.Location = New System.Drawing.Point(360, 383)
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
        Me.txt_p2UnreaGainForeEx.Size = New System.Drawing.Size(100, 22)
        Me.txt_p2UnreaGainForeEx.TabIndex = 32
        '
        'txt_p2ReaForeExGainNonTrade
        '
        Me.txt_p2ReaForeExGainNonTrade.Location = New System.Drawing.Point(360, 355)
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
        Me.txt_p2ReaForeExGainNonTrade.Size = New System.Drawing.Size(100, 22)
        Me.txt_p2ReaForeExGainNonTrade.TabIndex = 31
        '
        'txt_p2NonBizIncome
        '
        Me.txt_p2NonBizIncome.Location = New System.Drawing.Point(474, 282)
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
        Me.txt_p2NonBizIncome.Size = New System.Drawing.Size(100, 22)
        Me.txt_p2NonBizIncome.TabIndex = 26
        '
        'txt_p2OtherIncome
        '
        Me.txt_p2OtherIncome.Location = New System.Drawing.Point(360, 257)
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
        Me.txt_p2OtherIncome.Size = New System.Drawing.Size(100, 22)
        Me.txt_p2OtherIncome.TabIndex = 25
        Me.txt_p2OtherIncome.Tag = "OTHERINC"
        '
        'txt_p2RoyaltyIncome
        '
        Me.txt_p2RoyaltyIncome.Location = New System.Drawing.Point(360, 229)
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
        Me.txt_p2RoyaltyIncome.Size = New System.Drawing.Size(100, 22)
        Me.txt_p2RoyaltyIncome.TabIndex = 24
        Me.txt_p2RoyaltyIncome.Tag = "ROYALTYINC"
        '
        'txt_p2RentalIncome
        '
        Me.txt_p2RentalIncome.Location = New System.Drawing.Point(360, 201)
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
        Me.txt_p2RentalIncome.Size = New System.Drawing.Size(100, 22)
        Me.txt_p2RentalIncome.TabIndex = 23
        '
        'txt_p2InterestIncome
        '
        Me.txt_p2InterestIncome.Location = New System.Drawing.Point(360, 173)
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
        Me.txt_p2InterestIncome.Size = New System.Drawing.Size(100, 22)
        Me.txt_p2InterestIncome.TabIndex = 22
        '
        'txt_p2DivIncome
        '
        Me.txt_p2DivIncome.Location = New System.Drawing.Point(360, 145)
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
        Me.txt_p2DivIncome.Size = New System.Drawing.Size(100, 22)
        Me.txt_p2DivIncome.TabIndex = 21
        '
        'txt_p2ForeignCurrExGain
        '
        Me.txt_p2ForeignCurrExGain.Location = New System.Drawing.Point(474, 74)
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
        Me.txt_p2ForeignCurrExGain.Size = New System.Drawing.Size(100, 22)
        Me.txt_p2ForeignCurrExGain.TabIndex = 20
        '
        'txt_p2OtherBizIncome
        '
        Me.txt_p2OtherBizIncome.Location = New System.Drawing.Point(474, 46)
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
        Me.txt_p2OtherBizIncome.Size = New System.Drawing.Size(100, 22)
        Me.txt_p2OtherBizIncome.TabIndex = 19
        '
        'lbl_p2Other
        '
        Me.lbl_p2Other.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2Other.Appearance.Options.UseFont = True
        Me.lbl_p2Other.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2Other.Location = New System.Drawing.Point(6, 444)
        Me.lbl_p2Other.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2Other.Name = "lbl_p2Other"
        Me.lbl_p2Other.Size = New System.Drawing.Size(35, 17)
        Me.lbl_p2Other.TabIndex = 18
        Me.lbl_p2Other.Tag = "OTHERINC"
        Me.lbl_p2Other.Text = "Other"
        '
        'lbl_p2UnreaGainForeEx
        '
        Me.lbl_p2UnreaGainForeEx.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2UnreaGainForeEx.Appearance.Options.UseFont = True
        Me.lbl_p2UnreaGainForeEx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2UnreaGainForeEx.Location = New System.Drawing.Point(6, 386)
        Me.lbl_p2UnreaGainForeEx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2UnreaGainForeEx.Name = "lbl_p2UnreaGainForeEx"
        Me.lbl_p2UnreaGainForeEx.Size = New System.Drawing.Size(160, 17)
        Me.lbl_p2UnreaGainForeEx.TabIndex = 17
        Me.lbl_p2UnreaGainForeEx.Tag = "UNREALFETRADE"
        Me.lbl_p2UnreaGainForeEx.Text = "Gain on Foreign Exchange"
        '
        'lbl_p2ReaForeExGainNonTrade
        '
        Me.lbl_p2ReaForeExGainNonTrade.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2ReaForeExGainNonTrade.Appearance.Options.UseFont = True
        Me.lbl_p2ReaForeExGainNonTrade.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2ReaForeExGainNonTrade.Location = New System.Drawing.Point(6, 358)
        Me.lbl_p2ReaForeExGainNonTrade.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2ReaForeExGainNonTrade.Name = "lbl_p2ReaForeExGainNonTrade"
        Me.lbl_p2ReaForeExGainNonTrade.Size = New System.Drawing.Size(193, 17)
        Me.lbl_p2ReaForeExGainNonTrade.TabIndex = 16
        Me.lbl_p2ReaForeExGainNonTrade.Text = "Gain on Disposal of Fixed Assets"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Location = New System.Drawing.Point(6, 314)
        Me.LabelControl21.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(188, 21)
        Me.LabelControl21.TabIndex = 11
        Me.LabelControl21.Text = "Non - Taxable Income"
        '
        'lbl_p2OtherIncome
        '
        Me.lbl_p2OtherIncome.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2OtherIncome.Appearance.Options.UseFont = True
        Me.lbl_p2OtherIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2OtherIncome.Location = New System.Drawing.Point(6, 260)
        Me.lbl_p2OtherIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2OtherIncome.Name = "lbl_p2OtherIncome"
        Me.lbl_p2OtherIncome.Size = New System.Drawing.Size(83, 17)
        Me.lbl_p2OtherIncome.TabIndex = 10
        Me.lbl_p2OtherIncome.Tag = "OTHERINC"
        Me.lbl_p2OtherIncome.Text = "Other income"
        '
        'lbl_p2RoyaltyIncome
        '
        Me.lbl_p2RoyaltyIncome.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2RoyaltyIncome.Appearance.Options.UseFont = True
        Me.lbl_p2RoyaltyIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2RoyaltyIncome.Location = New System.Drawing.Point(6, 233)
        Me.lbl_p2RoyaltyIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2RoyaltyIncome.Name = "lbl_p2RoyaltyIncome"
        Me.lbl_p2RoyaltyIncome.Size = New System.Drawing.Size(95, 17)
        Me.lbl_p2RoyaltyIncome.TabIndex = 9
        Me.lbl_p2RoyaltyIncome.Tag = "ROYALTYINC"
        Me.lbl_p2RoyaltyIncome.Text = "Royalty income"
        '
        'lbl_p2RentalIncome
        '
        Me.lbl_p2RentalIncome.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2RentalIncome.Appearance.Options.UseFont = True
        Me.lbl_p2RentalIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2RentalIncome.Location = New System.Drawing.Point(6, 204)
        Me.lbl_p2RentalIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2RentalIncome.Name = "lbl_p2RentalIncome"
        Me.lbl_p2RentalIncome.Size = New System.Drawing.Size(86, 17)
        Me.lbl_p2RentalIncome.TabIndex = 8
        Me.lbl_p2RentalIncome.Tag = "RENTALINC"
        Me.lbl_p2RentalIncome.Text = "Rental income"
        '
        'lbl_p2InterestIncome
        '
        Me.lbl_p2InterestIncome.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2InterestIncome.Appearance.Options.UseFont = True
        Me.lbl_p2InterestIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2InterestIncome.Location = New System.Drawing.Point(6, 176)
        Me.lbl_p2InterestIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2InterestIncome.Name = "lbl_p2InterestIncome"
        Me.lbl_p2InterestIncome.Size = New System.Drawing.Size(95, 17)
        Me.lbl_p2InterestIncome.TabIndex = 7
        Me.lbl_p2InterestIncome.Tag = "INTERESTINC"
        Me.lbl_p2InterestIncome.Text = "Interest income"
        '
        'lbl_p2DivIncome
        '
        Me.lbl_p2DivIncome.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2DivIncome.Appearance.Options.UseFont = True
        Me.lbl_p2DivIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2DivIncome.Location = New System.Drawing.Point(6, 148)
        Me.lbl_p2DivIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2DivIncome.Name = "lbl_p2DivIncome"
        Me.lbl_p2DivIncome.Size = New System.Drawing.Size(101, 17)
        Me.lbl_p2DivIncome.TabIndex = 6
        Me.lbl_p2DivIncome.Tag = "DIVIDENDINC"
        Me.lbl_p2DivIncome.Text = "Dividend income"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(6, 114)
        Me.LabelControl15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(184, 21)
        Me.LabelControl15.TabIndex = 5
        Me.LabelControl15.Text = "Non-business income"
        '
        'lbl_p2ForeignCurrExGain
        '
        Me.lbl_p2ForeignCurrExGain.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2ForeignCurrExGain.Appearance.Options.UseFont = True
        Me.lbl_p2ForeignCurrExGain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2ForeignCurrExGain.Location = New System.Drawing.Point(6, 77)
        Me.lbl_p2ForeignCurrExGain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2ForeignCurrExGain.Name = "lbl_p2ForeignCurrExGain"
        Me.lbl_p2ForeignCurrExGain.Size = New System.Drawing.Size(197, 17)
        Me.lbl_p2ForeignCurrExGain.TabIndex = 2
        Me.lbl_p2ForeignCurrExGain.Text = "Foreign currency exchange gain"
        '
        'lbl_p2OtherBizIncome
        '
        Me.lbl_p2OtherBizIncome.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p2OtherBizIncome.Appearance.Options.UseFont = True
        Me.lbl_p2OtherBizIncome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p2OtherBizIncome.Location = New System.Drawing.Point(6, 49)
        Me.lbl_p2OtherBizIncome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p2OtherBizIncome.Name = "lbl_p2OtherBizIncome"
        Me.lbl_p2OtherBizIncome.Size = New System.Drawing.Size(138, 17)
        Me.lbl_p2OtherBizIncome.TabIndex = 1
        Me.lbl_p2OtherBizIncome.Tag = "OTHERBUSINC"
        Me.lbl_p2OtherBizIncome.Text = "Other business income"
        '
        'XtraTabPage3
        '
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
        Me.XtraTabPage3.Size = New System.Drawing.Size(711, 773)
        Me.XtraTabPage3.Tag = ""
        Me.XtraTabPage3.Text = "Page 3"
        '
        'txt_p3Travelling
        '
        Me.txt_p3Travelling.Location = New System.Drawing.Point(475, 412)
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
        Me.txt_p3Travelling.Size = New System.Drawing.Size(100, 22)
        Me.txt_p3Travelling.TabIndex = 47
        '
        'lbl_p3Travelling
        '
        Me.lbl_p3Travelling.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3Travelling.Appearance.Options.UseFont = True
        Me.lbl_p3Travelling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3Travelling.Location = New System.Drawing.Point(21, 416)
        Me.lbl_p3Travelling.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3Travelling.Name = "lbl_p3Travelling"
        Me.lbl_p3Travelling.Size = New System.Drawing.Size(97, 17)
        Me.lbl_p3Travelling.TabIndex = 46
        Me.lbl_p3Travelling.Tag = "EXPTRAVEL"
        Me.lbl_p3Travelling.Text = "Other Expenses"
        '
        'txt_p3PromotionAds
        '
        Me.txt_p3PromotionAds.Location = New System.Drawing.Point(475, 383)
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
        Me.txt_p3PromotionAds.Size = New System.Drawing.Size(100, 22)
        Me.txt_p3PromotionAds.TabIndex = 45
        '
        'lbl_p3PromotionAds
        '
        Me.lbl_p3PromotionAds.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3PromotionAds.Appearance.Options.UseFont = True
        Me.lbl_p3PromotionAds.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3PromotionAds.Location = New System.Drawing.Point(21, 386)
        Me.lbl_p3PromotionAds.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3PromotionAds.Name = "lbl_p3PromotionAds"
        Me.lbl_p3PromotionAds.Size = New System.Drawing.Size(56, 17)
        Me.lbl_p3PromotionAds.TabIndex = 44
        Me.lbl_p3PromotionAds.Tag = "EXPADVERTISEMENT"
        Me.lbl_p3PromotionAds.Text = "Legal Fee"
        '
        'txt_p3ResearchDev
        '
        Me.txt_p3ResearchDev.Location = New System.Drawing.Point(475, 353)
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
        Me.txt_p3ResearchDev.Size = New System.Drawing.Size(100, 22)
        Me.txt_p3ResearchDev.TabIndex = 43
        '
        'lbl_p3ResearchDev
        '
        Me.lbl_p3ResearchDev.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3ResearchDev.Appearance.Options.UseFont = True
        Me.lbl_p3ResearchDev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3ResearchDev.Location = New System.Drawing.Point(21, 357)
        Me.lbl_p3ResearchDev.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3ResearchDev.Name = "lbl_p3ResearchDev"
        Me.lbl_p3ResearchDev.Size = New System.Drawing.Size(65, 17)
        Me.lbl_p3ResearchDev.TabIndex = 42
        Me.lbl_p3ResearchDev.Tag = "EXPRND"
        Me.lbl_p3ResearchDev.Text = "EPF (Staff)"
        '
        'txt_p3RepairMain
        '
        Me.txt_p3RepairMain.Location = New System.Drawing.Point(475, 324)
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
        Me.txt_p3RepairMain.Size = New System.Drawing.Size(100, 22)
        Me.txt_p3RepairMain.TabIndex = 41
        '
        'lbl_p3RepairMain
        '
        Me.lbl_p3RepairMain.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3RepairMain.Appearance.Options.UseFont = True
        Me.lbl_p3RepairMain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3RepairMain.Location = New System.Drawing.Point(21, 327)
        Me.lbl_p3RepairMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3RepairMain.Name = "lbl_p3RepairMain"
        Me.lbl_p3RepairMain.Size = New System.Drawing.Size(88, 17)
        Me.lbl_p3RepairMain.TabIndex = 40
        Me.lbl_p3RepairMain.Tag = "EXPREPAIRMAINTENANCE"
        Me.lbl_p3RepairMain.Text = "EPF (Personal)"
        '
        'txt_p3Rental
        '
        Me.txt_p3Rental.Location = New System.Drawing.Point(475, 294)
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
        Me.txt_p3Rental.Size = New System.Drawing.Size(100, 22)
        Me.txt_p3Rental.TabIndex = 39
        '
        'lbl_p3Rental
        '
        Me.lbl_p3Rental.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3Rental.Appearance.Options.UseFont = True
        Me.lbl_p3Rental.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3Rental.Location = New System.Drawing.Point(21, 298)
        Me.lbl_p3Rental.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3Rental.Name = "lbl_p3Rental"
        Me.lbl_p3Rental.Size = New System.Drawing.Size(211, 17)
        Me.lbl_p3Rental.TabIndex = 38
        Me.lbl_p3Rental.Tag = "EXPRENTAL"
        Me.lbl_p3Rental.Text = "Input tax not claimable from JKDM"
        '
        'txt_p3Royalty
        '
        Me.txt_p3Royalty.Location = New System.Drawing.Point(475, 265)
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
        Me.txt_p3Royalty.Size = New System.Drawing.Size(100, 22)
        Me.txt_p3Royalty.TabIndex = 37
        '
        'lbl_p3Royalty
        '
        Me.lbl_p3Royalty.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3Royalty.Appearance.Options.UseFont = True
        Me.lbl_p3Royalty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3Royalty.Location = New System.Drawing.Point(21, 268)
        Me.lbl_p3Royalty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3Royalty.Name = "lbl_p3Royalty"
        Me.lbl_p3Royalty.Size = New System.Drawing.Size(183, 17)
        Me.lbl_p3Royalty.TabIndex = 36
        Me.lbl_p3Royalty.Tag = "EXPROYALTY"
        Me.lbl_p3Royalty.Text = "Promotion and Advertisement"
        '
        'txt_p3COEStock
        '
        Me.txt_p3COEStock.Location = New System.Drawing.Point(475, 235)
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
        Me.txt_p3COEStock.Size = New System.Drawing.Size(100, 22)
        Me.txt_p3COEStock.TabIndex = 35
        '
        'lbl_p3COEStock
        '
        Me.lbl_p3COEStock.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3COEStock.Appearance.Options.UseFont = True
        Me.lbl_p3COEStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3COEStock.Location = New System.Drawing.Point(21, 239)
        Me.lbl_p3COEStock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3COEStock.Name = "lbl_p3COEStock"
        Me.lbl_p3COEStock.Size = New System.Drawing.Size(145, 17)
        Me.lbl_p3COEStock.TabIndex = 34
        Me.lbl_p3COEStock.Tag = "EXPEMPLOYEESTOCK"
        Me.lbl_p3COEStock.Text = "Repair and Maintenance"
        '
        'txt_p3Salary
        '
        Me.txt_p3Salary.Location = New System.Drawing.Point(475, 206)
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
        Me.txt_p3Salary.Size = New System.Drawing.Size(100, 22)
        Me.txt_p3Salary.TabIndex = 33
        '
        'lbl_p3Salary
        '
        Me.lbl_p3Salary.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3Salary.Appearance.Options.UseFont = True
        Me.lbl_p3Salary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3Salary.Location = New System.Drawing.Point(21, 209)
        Me.lbl_p3Salary.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3Salary.Name = "lbl_p3Salary"
        Me.lbl_p3Salary.Size = New System.Drawing.Size(272, 17)
        Me.lbl_p3Salary.TabIndex = 32
        Me.lbl_p3Salary.Tag = "EXPSALARY"
        Me.lbl_p3Salary.Text = "Travelling, Transportation && Accommodation"
        '
        'txt_p3DirectorFee
        '
        Me.txt_p3DirectorFee.Location = New System.Drawing.Point(475, 176)
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
        Me.txt_p3DirectorFee.Size = New System.Drawing.Size(100, 22)
        Me.txt_p3DirectorFee.TabIndex = 31
        '
        'lbl_p3DirectorFee
        '
        Me.lbl_p3DirectorFee.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3DirectorFee.Appearance.Options.UseFont = True
        Me.lbl_p3DirectorFee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3DirectorFee.Location = New System.Drawing.Point(21, 180)
        Me.lbl_p3DirectorFee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3DirectorFee.Name = "lbl_p3DirectorFee"
        Me.lbl_p3DirectorFee.Size = New System.Drawing.Size(63, 17)
        Me.lbl_p3DirectorFee.TabIndex = 30
        Me.lbl_p3DirectorFee.Tag = "EXPDIRECTORFEE"
        Me.lbl_p3DirectorFee.Text = "Bad Debts"
        '
        'txt_p3ContractPay
        '
        Me.txt_p3ContractPay.Location = New System.Drawing.Point(475, 146)
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
        Me.txt_p3ContractPay.Size = New System.Drawing.Size(100, 22)
        Me.txt_p3ContractPay.TabIndex = 29
        '
        'lbl_p3ContractPay
        '
        Me.lbl_p3ContractPay.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3ContractPay.Appearance.Options.UseFont = True
        Me.lbl_p3ContractPay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3ContractPay.Location = New System.Drawing.Point(21, 150)
        Me.lbl_p3ContractPay.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3ContractPay.Name = "lbl_p3ContractPay"
        Me.lbl_p3ContractPay.Size = New System.Drawing.Size(73, 17)
        Me.lbl_p3ContractPay.TabIndex = 28
        Me.lbl_p3ContractPay.Tag = "EXPCONTRACTPAY"
        Me.lbl_p3ContractPay.Text = "Commission"
        '
        'txt_p3TechPayNonResis
        '
        Me.txt_p3TechPayNonResis.Location = New System.Drawing.Point(475, 117)
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
        Me.txt_p3TechPayNonResis.Size = New System.Drawing.Size(100, 22)
        Me.txt_p3TechPayNonResis.TabIndex = 27
        '
        'lbl_p3TechPayNonResis
        '
        Me.lbl_p3TechPayNonResis.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3TechPayNonResis.Appearance.Options.UseFont = True
        Me.lbl_p3TechPayNonResis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3TechPayNonResis.Location = New System.Drawing.Point(21, 121)
        Me.lbl_p3TechPayNonResis.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3TechPayNonResis.Name = "lbl_p3TechPayNonResis"
        Me.lbl_p3TechPayNonResis.Size = New System.Drawing.Size(167, 17)
        Me.lbl_p3TechPayNonResis.TabIndex = 26
        Me.lbl_p3TechPayNonResis.Text = "Contract and Sub Contract"
        '
        'txt_p3ProTechManLeganFees
        '
        Me.txt_p3ProTechManLeganFees.Location = New System.Drawing.Point(475, 87)
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
        Me.txt_p3ProTechManLeganFees.Size = New System.Drawing.Size(100, 22)
        Me.txt_p3ProTechManLeganFees.TabIndex = 25
        '
        'lbl_p3ProTechManLeganFees
        '
        Me.lbl_p3ProTechManLeganFees.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3ProTechManLeganFees.Appearance.Options.UseFont = True
        Me.lbl_p3ProTechManLeganFees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3ProTechManLeganFees.Location = New System.Drawing.Point(21, 91)
        Me.lbl_p3ProTechManLeganFees.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3ProTechManLeganFees.Name = "lbl_p3ProTechManLeganFees"
        Me.lbl_p3ProTechManLeganFees.Size = New System.Drawing.Size(127, 17)
        Me.lbl_p3ProTechManLeganFees.TabIndex = 24
        Me.lbl_p3ProTechManLeganFees.Tag = "EXPLEGAL"
        Me.lbl_p3ProTechManLeganFees.Text = "Rental and Mortgage"
        '
        'txt_p3OtherInterestExHirePur
        '
        Me.txt_p3OtherInterestExHirePur.Location = New System.Drawing.Point(475, 58)
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
        Me.txt_p3OtherInterestExHirePur.Size = New System.Drawing.Size(100, 22)
        Me.txt_p3OtherInterestExHirePur.TabIndex = 23
        '
        'lbl_p3OtherInterestExHirePur
        '
        Me.lbl_p3OtherInterestExHirePur.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3OtherInterestExHirePur.Appearance.Options.UseFont = True
        Me.lbl_p3OtherInterestExHirePur.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3OtherInterestExHirePur.Location = New System.Drawing.Point(21, 62)
        Me.lbl_p3OtherInterestExHirePur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3OtherInterestExHirePur.Name = "lbl_p3OtherInterestExHirePur"
        Me.lbl_p3OtherInterestExHirePur.Size = New System.Drawing.Size(150, 17)
        Me.lbl_p3OtherInterestExHirePur.TabIndex = 22
        Me.lbl_p3OtherInterestExHirePur.Tag = "EXPOTHERINTEREST"
        Me.lbl_p3OtherInterestExHirePur.Text = "Salary, Allowance, Bonus"
        '
        'txt_p3InterestResPurS33
        '
        Me.txt_p3InterestResPurS33.Location = New System.Drawing.Point(475, 28)
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
        Me.txt_p3InterestResPurS33.Size = New System.Drawing.Size(100, 22)
        Me.txt_p3InterestResPurS33.TabIndex = 21
        '
        'lbl_p3InterestResPurS33
        '
        Me.lbl_p3InterestResPurS33.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p3InterestResPurS33.Appearance.Options.UseFont = True
        Me.lbl_p3InterestResPurS33.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p3InterestResPurS33.Location = New System.Drawing.Point(21, 32)
        Me.lbl_p3InterestResPurS33.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p3InterestResPurS33.Name = "lbl_p3InterestResPurS33"
        Me.lbl_p3InterestResPurS33.Size = New System.Drawing.Size(81, 17)
        Me.lbl_p3InterestResPurS33.TabIndex = 20
        Me.lbl_p3InterestResPurS33.Tag = "INTERESTRESTRICT"
        Me.lbl_p3InterestResPurS33.Text = "Loan Interest"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(21, 2)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(123, 21)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Less Expenses"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Controls.Add(Me.TextEdit16)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl27)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl26)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit11)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl22)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit12)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl23)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit13)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit14)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl24)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit15)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl25)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit6)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl20)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit7)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl14)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit8)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl16)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit9)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl17)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit10)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl18)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl19)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit5)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit4)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl13)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit3)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl12)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit2)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage5.Controls.Add(Me.TextEdit1)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage5.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(711, 773)
        Me.XtraTabPage5.Text = "Page 4"
        '
        'TextEdit16
        '
        Me.TextEdit16.Location = New System.Drawing.Point(475, 470)
        Me.TextEdit16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit16.Name = "TextEdit16"
        Me.TextEdit16.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit16.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit16.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit16.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit16.Properties.NullText = "0"
        Me.TextEdit16.Properties.NullValuePrompt = "0"
        Me.TextEdit16.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit16.Properties.ReadOnly = True
        Me.TextEdit16.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit16.TabIndex = 52
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl27.Appearance.Options.UseFont = True
        Me.LabelControl27.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl27.Location = New System.Drawing.Point(21, 474)
        Me.LabelControl27.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(111, 17)
        Me.LabelControl27.TabIndex = 51
        Me.LabelControl27.Tag = "INTERESTRESTRICT"
        Me.LabelControl27.Text = "Assets Written Off"
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl26.Appearance.Options.UseFont = True
        Me.LabelControl26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl26.Location = New System.Drawing.Point(21, 397)
        Me.LabelControl26.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(167, 17)
        Me.LabelControl26.TabIndex = 50
        Me.LabelControl26.Tag = "INTERESTRESTRICT"
        Me.LabelControl26.Text = "Provision for Doubtful Debt"
        '
        'TextEdit11
        '
        Me.TextEdit11.Location = New System.Drawing.Point(475, 444)
        Me.TextEdit11.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit11.Name = "TextEdit11"
        Me.TextEdit11.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit11.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit11.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit11.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit11.Properties.NullText = "0"
        Me.TextEdit11.Properties.NullValuePrompt = "0"
        Me.TextEdit11.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit11.Properties.ReadOnly = True
        Me.TextEdit11.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit11.TabIndex = 49
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl22.Location = New System.Drawing.Point(21, 448)
        Me.LabelControl22.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(118, 17)
        Me.LabelControl22.TabIndex = 48
        Me.LabelControl22.Tag = "INTERESTRESTRICT"
        Me.LabelControl22.Text = "Capital Expenditure"
        '
        'TextEdit12
        '
        Me.TextEdit12.Location = New System.Drawing.Point(475, 418)
        Me.TextEdit12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit12.Name = "TextEdit12"
        Me.TextEdit12.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit12.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit12.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit12.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit12.Properties.NullText = "0"
        Me.TextEdit12.Properties.NullValuePrompt = "0"
        Me.TextEdit12.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit12.Properties.ReadOnly = True
        Me.TextEdit12.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit12.TabIndex = 47
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl23.Location = New System.Drawing.Point(21, 422)
        Me.LabelControl23.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(199, 17)
        Me.LabelControl23.TabIndex = 46
        Me.LabelControl23.Tag = "INTERESTRESTRICT"
        Me.LabelControl23.Text = "Preliminary / Cessation Expenses"
        '
        'TextEdit13
        '
        Me.TextEdit13.Location = New System.Drawing.Point(475, 392)
        Me.TextEdit13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit13.Name = "TextEdit13"
        Me.TextEdit13.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit13.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit13.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit13.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit13.Properties.NullText = "0"
        Me.TextEdit13.Properties.NullValuePrompt = "0"
        Me.TextEdit13.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit13.Properties.ReadOnly = True
        Me.TextEdit13.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit13.TabIndex = 45
        '
        'TextEdit14
        '
        Me.TextEdit14.Location = New System.Drawing.Point(475, 366)
        Me.TextEdit14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit14.Name = "TextEdit14"
        Me.TextEdit14.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit14.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit14.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit14.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit14.Properties.NullText = "0"
        Me.TextEdit14.Properties.NullValuePrompt = "0"
        Me.TextEdit14.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit14.Properties.ReadOnly = True
        Me.TextEdit14.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit14.TabIndex = 44
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl24.Appearance.Options.UseFont = True
        Me.LabelControl24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl24.Location = New System.Drawing.Point(21, 370)
        Me.LabelControl24.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(131, 17)
        Me.LabelControl24.TabIndex = 43
        Me.LabelControl24.Tag = "INTERESTRESTRICT"
        Me.LabelControl24.Text = "Drawing in P/L - Cash"
        '
        'TextEdit15
        '
        Me.TextEdit15.Location = New System.Drawing.Point(475, 340)
        Me.TextEdit15.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit15.Name = "TextEdit15"
        Me.TextEdit15.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit15.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit15.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit15.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit15.Properties.NullText = "0"
        Me.TextEdit15.Properties.NullValuePrompt = "0"
        Me.TextEdit15.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit15.Properties.ReadOnly = True
        Me.TextEdit15.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit15.TabIndex = 42
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl25.Appearance.Options.UseFont = True
        Me.LabelControl25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl25.Location = New System.Drawing.Point(21, 344)
        Me.LabelControl25.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(137, 17)
        Me.LabelControl25.TabIndex = 41
        Me.LabelControl25.Tag = "INTERESTRESTRICT"
        Me.LabelControl25.Text = "Drawing in P/L - Stock"
        '
        'TextEdit6
        '
        Me.TextEdit6.Location = New System.Drawing.Point(475, 314)
        Me.TextEdit6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit6.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit6.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit6.Properties.NullText = "0"
        Me.TextEdit6.Properties.NullValuePrompt = "0"
        Me.TextEdit6.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit6.Properties.ReadOnly = True
        Me.TextEdit6.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit6.TabIndex = 40
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl20.Location = New System.Drawing.Point(21, 318)
        Me.LabelControl20.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(170, 17)
        Me.LabelControl20.TabIndex = 39
        Me.LabelControl20.Tag = "INTERESTRESTRICT"
        Me.LabelControl20.Text = "Penalty / Fines / Compound"
        '
        'TextEdit7
        '
        Me.TextEdit7.Location = New System.Drawing.Point(475, 288)
        Me.TextEdit7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit7.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit7.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit7.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit7.Properties.NullText = "0"
        Me.TextEdit7.Properties.NullValuePrompt = "0"
        Me.TextEdit7.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit7.Properties.ReadOnly = True
        Me.TextEdit7.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit7.TabIndex = 38
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl14.Location = New System.Drawing.Point(21, 292)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(56, 17)
        Me.LabelControl14.TabIndex = 37
        Me.LabelControl14.Tag = "INTERESTRESTRICT"
        Me.LabelControl14.Text = "Donation"
        '
        'TextEdit8
        '
        Me.TextEdit8.Location = New System.Drawing.Point(475, 262)
        Me.TextEdit8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit8.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit8.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit8.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit8.Properties.NullText = "0"
        Me.TextEdit8.Properties.NullValuePrompt = "0"
        Me.TextEdit8.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit8.Properties.ReadOnly = True
        Me.TextEdit8.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit8.TabIndex = 36
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl16.Location = New System.Drawing.Point(21, 266)
        Me.LabelControl16.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(20, 17)
        Me.LabelControl16.TabIndex = 35
        Me.LabelControl16.Tag = "INTERESTRESTRICT"
        Me.LabelControl16.Text = "Gift"
        '
        'TextEdit9
        '
        Me.TextEdit9.Location = New System.Drawing.Point(475, 236)
        Me.TextEdit9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit9.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit9.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit9.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit9.Properties.NullText = "0"
        Me.TextEdit9.Properties.NullValuePrompt = "0"
        Me.TextEdit9.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit9.Properties.ReadOnly = True
        Me.TextEdit9.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit9.TabIndex = 34
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl17.Location = New System.Drawing.Point(21, 240)
        Me.LabelControl17.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(87, 17)
        Me.LabelControl17.TabIndex = 33
        Me.LabelControl17.Tag = "INTERESTRESTRICT"
        Me.LabelControl17.Text = "Entertainment"
        '
        'TextEdit10
        '
        Me.TextEdit10.Location = New System.Drawing.Point(475, 210)
        Me.TextEdit10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit10.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit10.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit10.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit10.Properties.NullText = "0"
        Me.TextEdit10.Properties.NullValuePrompt = "0"
        Me.TextEdit10.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit10.Properties.ReadOnly = True
        Me.TextEdit10.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit10.TabIndex = 32
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl18.Location = New System.Drawing.Point(21, 214)
        Me.LabelControl18.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(76, 17)
        Me.LabelControl18.TabIndex = 31
        Me.LabelControl18.Tag = "INTERESTRESTRICT"
        Me.LabelControl18.Text = "Depreciation"
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Location = New System.Drawing.Point(21, 184)
        Me.LabelControl19.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(343, 21)
        Me.LabelControl19.TabIndex = 30
        Me.LabelControl19.Text = "Non-allowable Expenditure and Charges"
        '
        'TextEdit5
        '
        Me.TextEdit5.Location = New System.Drawing.Point(584, 134)
        Me.TextEdit5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit5.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit5.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit5.Properties.NullText = "0"
        Me.TextEdit5.Properties.NullValuePrompt = "0"
        Me.TextEdit5.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit5.TabIndex = 29
        '
        'TextEdit4
        '
        Me.TextEdit4.Location = New System.Drawing.Point(475, 106)
        Me.TextEdit4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit4.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit4.Properties.NullText = "0"
        Me.TextEdit4.Properties.NullValuePrompt = "0"
        Me.TextEdit4.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit4.TabIndex = 28
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl13.Location = New System.Drawing.Point(21, 110)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(41, 17)
        Me.LabelControl13.TabIndex = 27
        Me.LabelControl13.Tag = "INTERESTRESTRICT"
        Me.LabelControl13.Text = "Others"
        '
        'TextEdit3
        '
        Me.TextEdit3.Location = New System.Drawing.Point(475, 80)
        Me.TextEdit3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit3.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit3.Properties.NullText = "0"
        Me.TextEdit3.Properties.NullValuePrompt = "0"
        Me.TextEdit3.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit3.TabIndex = 26
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl12.Location = New System.Drawing.Point(21, 84)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(121, 17)
        Me.LabelControl12.TabIndex = 25
        Me.LabelControl12.Tag = "INTERESTRESTRICT"
        Me.LabelControl12.Text = "Loss on Investment"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(475, 54)
        Me.TextEdit2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit2.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.NullText = "0"
        Me.TextEdit2.Properties.NullValuePrompt = "0"
        Me.TextEdit2.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit2.TabIndex = 24
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl8.Location = New System.Drawing.Point(21, 58)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(161, 17)
        Me.LabelControl8.TabIndex = 23
        Me.LabelControl8.Tag = "INTERESTRESTRICT"
        Me.LabelControl8.Text = "Loss on Foreign Exchange"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(475, 28)
        Me.TextEdit1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "n"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.NullText = "0"
        Me.TextEdit1.Properties.NullValuePrompt = "0"
        Me.TextEdit1.Properties.NullValuePromptShowForEmptyValue = True
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(100, 22)
        Me.TextEdit1.TabIndex = 22
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelControl7.Location = New System.Drawing.Point(21, 32)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(194, 17)
        Me.LabelControl7.TabIndex = 21
        Me.LabelControl7.Tag = "INTERESTRESTRICT"
        Me.LabelControl7.Text = "Loss on Disposal of Fixed Assets"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(21, 2)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(168, 21)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Non Allowable Loss"
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
        Me.XtraTabPage4.Controls.Add(Me.lbl_p4LossDispFA)
        Me.XtraTabPage4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabPage4.Size = New System.Drawing.Size(711, 773)
        Me.XtraTabPage4.Text = "Page 5"
        '
        'txt_p4ExpectedExpenses
        '
        Me.txt_p4ExpectedExpenses.Location = New System.Drawing.Point(475, 286)
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
        Me.txt_p4ExpectedExpenses.Size = New System.Drawing.Size(100, 22)
        Me.txt_p4ExpectedExpenses.TabIndex = 59
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(8, 291)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(171, 17)
        Me.LabelControl1.TabIndex = 58
        Me.LabelControl1.Text = "Other (Expected Expenses)"
        '
        'txt_p4NonAllowableExpenses
        '
        Me.txt_p4NonAllowableExpenses.Location = New System.Drawing.Point(561, 441)
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
        Me.txt_p4NonAllowableExpenses.Size = New System.Drawing.Size(122, 22)
        Me.txt_p4NonAllowableExpenses.TabIndex = 57
        '
        'lblP4NonAllowableExpenses
        '
        Me.lblP4NonAllowableExpenses.Appearance.Font = New System.Drawing.Font("Tahoma", 7.8!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4NonAllowableExpenses.Appearance.Options.UseFont = True
        Me.lblP4NonAllowableExpenses.Location = New System.Drawing.Point(8, 445)
        Me.lblP4NonAllowableExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblP4NonAllowableExpenses.Name = "lblP4NonAllowableExpenses"
        Me.lblP4NonAllowableExpenses.Size = New System.Drawing.Size(141, 16)
        Me.lblP4NonAllowableExpenses.TabIndex = 56
        Me.lblP4NonAllowableExpenses.Tag = "NONALLOWABLEEXPENSES"
        Me.lblP4NonAllowableExpenses.Text = "Non-Allowable Expenses"
        '
        'txt_p4NetProfitLoss
        '
        Me.txt_p4NetProfitLoss.Location = New System.Drawing.Point(561, 411)
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
        Me.txt_p4NetProfitLoss.Size = New System.Drawing.Size(122, 24)
        Me.txt_p4NetProfitLoss.TabIndex = 55
        '
        'LabelControl63
        '
        Me.LabelControl63.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl63.Appearance.Options.UseFont = True
        Me.LabelControl63.Location = New System.Drawing.Point(8, 415)
        Me.LabelControl63.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl63.Name = "LabelControl63"
        Me.LabelControl63.Size = New System.Drawing.Size(132, 18)
        Me.LabelControl63.TabIndex = 54
        Me.LabelControl63.Text = "Net Profit or Loss"
        '
        'txt_p4TotalExpenses
        '
        Me.txt_p4TotalExpenses.Location = New System.Drawing.Point(561, 382)
        Me.txt_p4TotalExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4TotalExpenses.Name = "txt_p4TotalExpenses"
        Me.txt_p4TotalExpenses.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_p4TotalExpenses.Properties.Appearance.Options.UseFont = True
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
        Me.txt_p4TotalExpenses.Size = New System.Drawing.Size(122, 24)
        Me.txt_p4TotalExpenses.TabIndex = 53
        '
        'LabelControl62
        '
        Me.LabelControl62.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl62.Appearance.Options.UseFont = True
        Me.LabelControl62.Location = New System.Drawing.Point(8, 386)
        Me.LabelControl62.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl62.Name = "LabelControl62"
        Me.LabelControl62.Size = New System.Drawing.Size(112, 18)
        Me.LabelControl62.TabIndex = 52
        Me.LabelControl62.Text = "Total Expenses"
        '
        'txt_p4TotalOtherExpenses
        '
        Me.txt_p4TotalOtherExpenses.Location = New System.Drawing.Point(561, 352)
        Me.txt_p4TotalOtherExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_p4TotalOtherExpenses.Name = "txt_p4TotalOtherExpenses"
        Me.txt_p4TotalOtherExpenses.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_p4TotalOtherExpenses.Properties.Appearance.Options.UseFont = True
        Me.txt_p4TotalOtherExpenses.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_p4TotalOtherExpenses.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_p4TotalOtherExpenses.Properties.DisplayFormat.FormatString = "n"
        Me.txt_p4TotalOtherExpenses.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_p4TotalOtherExpenses.Properties.NullText = "0"
        Me.txt_p4TotalOtherExpenses.Properties.NullValuePrompt = "0"
        Me.txt_p4TotalOtherExpenses.Properties.NullValuePromptShowForEmptyValue = True
        Me.txt_p4TotalOtherExpenses.Properties.ReadOnly = True
        Me.txt_p4TotalOtherExpenses.Size = New System.Drawing.Size(122, 24)
        Me.txt_p4TotalOtherExpenses.TabIndex = 51
        '
        'LabelControl61
        '
        Me.LabelControl61.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl61.Appearance.Options.UseFont = True
        Me.LabelControl61.Location = New System.Drawing.Point(8, 356)
        Me.LabelControl61.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(341, 18)
        Me.LabelControl61.TabIndex = 50
        Me.LabelControl61.Text = "Total Non-allowable Expenditure and Charges"
        '
        'txt_p4OtherBalacingFigure
        '
        Me.txt_p4OtherBalacingFigure.Location = New System.Drawing.Point(475, 311)
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
        Me.txt_p4OtherBalacingFigure.Size = New System.Drawing.Size(100, 22)
        Me.txt_p4OtherBalacingFigure.TabIndex = 49
        '
        'LabelControl60
        '
        Me.LabelControl60.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl60.Appearance.Options.UseFont = True
        Me.LabelControl60.Location = New System.Drawing.Point(8, 316)
        Me.LabelControl60.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(149, 17)
        Me.LabelControl60.TabIndex = 48
        Me.LabelControl60.Text = "Other (Balancing Figure)"
        '
        'txt_p4UnreaLossForeEx
        '
        Me.txt_p4UnreaLossForeEx.Location = New System.Drawing.Point(475, 235)
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
        Me.txt_p4UnreaLossForeEx.Size = New System.Drawing.Size(100, 22)
        Me.txt_p4UnreaLossForeEx.TabIndex = 37
        '
        'lbl_p4UnreaLossForeEx
        '
        Me.lbl_p4UnreaLossForeEx.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4UnreaLossForeEx.Appearance.Options.UseFont = True
        Me.lbl_p4UnreaLossForeEx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4UnreaLossForeEx.Location = New System.Drawing.Point(8, 239)
        Me.lbl_p4UnreaLossForeEx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4UnreaLossForeEx.Name = "lbl_p4UnreaLossForeEx"
        Me.lbl_p4UnreaLossForeEx.Size = New System.Drawing.Size(281, 17)
        Me.lbl_p4UnreaLossForeEx.TabIndex = 36
        Me.lbl_p4UnreaLossForeEx.Tag = "EXPUNREALLOSSFE"
        Me.lbl_p4UnreaLossForeEx.Text = "Other Non-allowable Expenditure and Charges"
        '
        'txt_p4FAWrittenOff
        '
        Me.txt_p4FAWrittenOff.Location = New System.Drawing.Point(475, 206)
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
        Me.txt_p4FAWrittenOff.Size = New System.Drawing.Size(100, 22)
        Me.txt_p4FAWrittenOff.TabIndex = 35
        '
        'lbl_p4FAWrittenOff
        '
        Me.lbl_p4FAWrittenOff.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4FAWrittenOff.Appearance.Options.UseFont = True
        Me.lbl_p4FAWrittenOff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4FAWrittenOff.Location = New System.Drawing.Point(19, 208)
        Me.lbl_p4FAWrittenOff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4FAWrittenOff.Name = "lbl_p4FAWrittenOff"
        Me.lbl_p4FAWrittenOff.Size = New System.Drawing.Size(110, 17)
        Me.lbl_p4FAWrittenOff.TabIndex = 34
        Me.lbl_p4FAWrittenOff.Tag = "EXPFAWRITTENOFF"
        Me.lbl_p4FAWrittenOff.Text = "-Medical Expenses"
        '
        'txt_p4LeavePass
        '
        Me.txt_p4LeavePass.Location = New System.Drawing.Point(475, 176)
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
        Me.txt_p4LeavePass.Size = New System.Drawing.Size(100, 22)
        Me.txt_p4LeavePass.TabIndex = 33
        '
        'lbl_p4LeavePass
        '
        Me.lbl_p4LeavePass.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4LeavePass.Appearance.Options.UseFont = True
        Me.lbl_p4LeavePass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4LeavePass.Location = New System.Drawing.Point(19, 179)
        Me.lbl_p4LeavePass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4LeavePass.Name = "lbl_p4LeavePass"
        Me.lbl_p4LeavePass.Size = New System.Drawing.Size(58, 17)
        Me.lbl_p4LeavePass.TabIndex = 32
        Me.lbl_p4LeavePass.Tag = "EXPLEAVEPASSAGE"
        Me.lbl_p4LeavePass.Text = "- Seminar"
        '
        'txt_p4ProvisionAcc
        '
        Me.txt_p4ProvisionAcc.Location = New System.Drawing.Point(475, 146)
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
        Me.txt_p4ProvisionAcc.Size = New System.Drawing.Size(100, 22)
        Me.txt_p4ProvisionAcc.TabIndex = 31
        '
        'lbl_p4ProvisionAcc
        '
        Me.lbl_p4ProvisionAcc.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4ProvisionAcc.Appearance.Options.UseFont = True
        Me.lbl_p4ProvisionAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4ProvisionAcc.Location = New System.Drawing.Point(19, 149)
        Me.lbl_p4ProvisionAcc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4ProvisionAcc.Name = "lbl_p4ProvisionAcc"
        Me.lbl_p4ProvisionAcc.Size = New System.Drawing.Size(236, 17)
        Me.lbl_p4ProvisionAcc.TabIndex = 30
        Me.lbl_p4ProvisionAcc.Tag = "EXPPROVISION"
        Me.lbl_p4ProvisionAcc.Text = "- Subscription (not related to business)"
        '
        'txt_p4Compound
        '
        Me.txt_p4Compound.Location = New System.Drawing.Point(475, 117)
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
        Me.txt_p4Compound.Size = New System.Drawing.Size(100, 22)
        Me.txt_p4Compound.TabIndex = 29
        '
        'lbl_p4Compound
        '
        Me.lbl_p4Compound.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4Compound.Appearance.Options.UseFont = True
        Me.lbl_p4Compound.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4Compound.Location = New System.Drawing.Point(19, 120)
        Me.lbl_p4Compound.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4Compound.Name = "lbl_p4Compound"
        Me.lbl_p4Compound.Size = New System.Drawing.Size(72, 17)
        Me.lbl_p4Compound.TabIndex = 28
        Me.lbl_p4Compound.Tag = "EXPCOMPAUNDPENALTY"
        Me.lbl_p4Compound.Text = "- Telephone"
        '
        'txt_p4EntStaff
        '
        Me.txt_p4EntStaff.Location = New System.Drawing.Point(475, 87)
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
        Me.txt_p4EntStaff.Size = New System.Drawing.Size(100, 22)
        Me.txt_p4EntStaff.TabIndex = 27
        '
        'lbl_p4EntStaff
        '
        Me.lbl_p4EntStaff.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4EntStaff.Appearance.Options.UseFont = True
        Me.lbl_p4EntStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4EntStaff.Location = New System.Drawing.Point(19, 90)
        Me.lbl_p4EntStaff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4EntStaff.Name = "lbl_p4EntStaff"
        Me.lbl_p4EntStaff.Size = New System.Drawing.Size(117, 17)
        Me.lbl_p4EntStaff.TabIndex = 26
        Me.lbl_p4EntStaff.Tag = "EXPENTERTAINSTAFF"
        Me.lbl_p4EntStaff.Text = "- Residential Benefit"
        '
        'txt_p4EntNonStaff
        '
        Me.txt_p4EntNonStaff.Location = New System.Drawing.Point(475, 58)
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
        Me.txt_p4EntNonStaff.Size = New System.Drawing.Size(100, 22)
        Me.txt_p4EntNonStaff.TabIndex = 25
        '
        'lbl_p4EntNonStaff
        '
        Me.lbl_p4EntNonStaff.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4EntNonStaff.Appearance.Options.UseFont = True
        Me.lbl_p4EntNonStaff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4EntNonStaff.Location = New System.Drawing.Point(19, 61)
        Me.lbl_p4EntNonStaff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4EntNonStaff.Name = "lbl_p4EntNonStaff"
        Me.lbl_p4EntNonStaff.Size = New System.Drawing.Size(138, 17)
        Me.lbl_p4EntNonStaff.TabIndex = 24
        Me.lbl_p4EntNonStaff.Tag = "EXPENTERTAINNONSTAFF"
        Me.lbl_p4EntNonStaff.Text = "- Motor Vechicle Usage"
        '
        'lbl_p4LossDispFA
        '
        Me.lbl_p4LossDispFA.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_p4LossDispFA.Appearance.Options.UseFont = True
        Me.lbl_p4LossDispFA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_p4LossDispFA.Location = New System.Drawing.Point(8, 32)
        Me.lbl_p4LossDispFA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbl_p4LossDispFA.Name = "lbl_p4LossDispFA"
        Me.lbl_p4LossDispFA.Size = New System.Drawing.Size(113, 17)
        Me.lbl_p4LossDispFA.TabIndex = 22
        Me.lbl_p4LossDispFA.Tag = "EXPLOSSDISPFA"
        Me.lbl_p4LossDispFA.Text = "Personal Expenses"
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
        Me.TabbedView1.RootContainer.Element = Nothing
        '
        'RibbonControl1
        '
        Me.RibbonControl1.AllowMinimizeRibbon = False
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.BarButtonItem2, Me.BarButtonItem3, Me.btnImport, Me.btnExport, Me.cboPNLStatus, Me.txtLastModified, Me.cboYA, Me.txtRefNo, Me.txtNetProfit2, Me.txtNonAllowableExpense, Me.cboMainSource, Me.cboS60F, Me.cboS60FA, Me.SkinRibbonGalleryBarItem1, Me.txtBalacingFigure, Me.btnRefresh, Me.BarSubItem1, Me.BarSubItem2, Me.BarSubItem3, Me.BarButtonItem1, Me.BarButtonItem4, Me.BarButtonItem5, Me.btnErrorLog, Me.cboRefNo})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl1.QuickToolbarItemLinks.Add(Me.BarSubItem1)
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemRadioGroup1, Me.RepositoryItemComboBox1, Me.RepositoryItemTextEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemComboBox2, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemComboBox3, Me.RepositoryItemComboBox4, Me.RepositoryItemProgressBar1, Me.RepositoryItemTextEdit7, Me.RepositoryItemSearchLookUpEdit1})
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1534, 177)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 1
        Me.btnSave.ImageOptions.Image = CType(resources.GetObject("btnSave.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSave.ImageOptions.LargeImage = CType(resources.GetObject("btnSave.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSave.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S))
        Me.btnSave.Name = "btnSave"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Print"
        Me.BarButtonItem2.Id = 2
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Close"
        Me.BarButtonItem3.Id = 3
        Me.BarButtonItem3.ImageOptions.Image = CType(resources.GetObject("BarButtonItem3.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem3.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem3.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem3.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F12)
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'btnImport
        '
        Me.btnImport.Caption = "Import"
        Me.btnImport.Id = 4
        Me.btnImport.ImageOptions.Image = CType(resources.GetObject("btnImport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnImport.ImageOptions.LargeImage = CType(resources.GetObject("btnImport.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnImport.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F9)
        Me.btnImport.Name = "btnImport"
        '
        'btnExport
        '
        Me.btnExport.Caption = "Export"
        Me.btnExport.Id = 5
        Me.btnExport.ImageOptions.Image = CType(resources.GetObject("btnExport.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExport.ImageOptions.LargeImage = CType(resources.GetObject("btnExport.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnExport.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F10)
        Me.btnExport.Name = "btnExport"
        '
        'cboPNLStatus
        '
        Me.cboPNLStatus.Caption = "Status P&&L :"
        Me.cboPNLStatus.Edit = Me.RepositoryItemComboBox1
        Me.cboPNLStatus.EditWidth = 160
        Me.cboPNLStatus.Id = 10
        Me.cboPNLStatus.Name = "cboPNLStatus"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"New", "Finished", "Amended Require", "Bookmarks", "Unfinished"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'txtLastModified
        '
        Me.txtLastModified.Caption = "Last Modified :"
        Me.txtLastModified.Edit = Me.RepositoryItemTextEdit1
        Me.txtLastModified.EditWidth = 350
        Me.txtLastModified.Id = 11
        Me.txtLastModified.Name = "txtLastModified"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.ReadOnly = True
        '
        'cboYA
        '
        Me.cboYA.Caption = "YA : "
        Me.cboYA.Edit = Me.RepositoryItemComboBox2
        Me.cboYA.EditWidth = 150
        Me.cboYA.Id = 16
        Me.cboYA.ImageOptions.Image = CType(resources.GetObject("cboYA.ImageOptions.Image"), System.Drawing.Image)
        Me.cboYA.ImageOptions.LargeImage = CType(resources.GetObject("cboYA.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cboYA.Name = "cboYA"
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
        Me.txtRefNo.EditWidth = 150
        Me.txtRefNo.Id = 17
        Me.txtRefNo.ImageOptions.Image = CType(resources.GetObject("txtRefNo.ImageOptions.Image"), System.Drawing.Image)
        Me.txtRefNo.ImageOptions.LargeImage = CType(resources.GetObject("txtRefNo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.txtRefNo.Name = "txtRefNo"
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
        Me.txtNetProfit2.EditWidth = 175
        Me.txtNetProfit2.Id = 18
        Me.txtNetProfit2.Name = "txtNetProfit2"
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
        Me.txtNonAllowableExpense.EditWidth = 100
        Me.txtNonAllowableExpense.Id = 19
        Me.txtNonAllowableExpense.Name = "txtNonAllowableExpense"
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
        Me.cboMainSource.EditWidth = 130
        Me.cboMainSource.Id = 20
        Me.cboMainSource.Name = "cboMainSource"
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
        Me.cboS60F.EditWidth = 100
        Me.cboS60F.Id = 21
        Me.cboS60F.Name = "cboS60F"
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
        Me.cboS60FA.EditWidth = 100
        Me.cboS60FA.Id = 23
        Me.cboS60FA.Name = "cboS60FA"
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
        Me.txtBalacingFigure.Caption = "Balancing Figure : "
        Me.txtBalacingFigure.Edit = Me.RepositoryItemTextEdit7
        Me.txtBalacingFigure.EditWidth = 145
        Me.txtBalacingFigure.Id = 3
        Me.txtBalacingFigure.Name = "txtBalacingFigure"
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
        Me.btnRefresh.Id = 4
        Me.btnRefresh.ImageOptions.Image = CType(resources.GetObject("btnRefresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageOptions.LargeImage = CType(resources.GetObject("btnRefresh.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRefresh.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5)
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
        Me.BarSubItem1.Id = 9
        Me.BarSubItem1.ImageOptions.Image = CType(resources.GetObject("BarSubItem1.ImageOptions.Image"), System.Drawing.Image)
        Me.BarSubItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarSubItem1.ImageOptions.LargeImage"), System.Drawing.Image)
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
        'btnErrorLog
        '
        Me.btnErrorLog.Caption = "Error Log"
        Me.btnErrorLog.Id = 16
        Me.btnErrorLog.ImageOptions.Image = CType(resources.GetObject("btnErrorLog.ImageOptions.Image"), System.Drawing.Image)
        Me.btnErrorLog.ImageOptions.LargeImage = CType(resources.GetObject("btnErrorLog.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnErrorLog.Name = "btnErrorLog"
        '
        'cboRefNo
        '
        Me.cboRefNo.Caption = "Tax Payer"
        Me.cboRefNo.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.cboRefNo.DataBindings.Add(New System.Windows.Forms.Binding("AccessibleDescription", Me.TaxPayerFindBindingSource, "RefNo", True))
        Me.cboRefNo.Edit = Me.RepositoryItemSearchLookUpEdit1
        Me.cboRefNo.EditWidth = 150
        Me.cboRefNo.Id = 17
        Me.cboRefNo.ImageOptions.Image = CType(resources.GetObject("cboRefNo.ImageOptions.Image"), System.Drawing.Image)
        Me.cboRefNo.ImageOptions.LargeImage = CType(resources.GetObject("cboRefNo.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.cboRefNo.Name = "cboRefNo"
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
        'RepositoryItemSearchLookUpEdit1
        '
        Me.RepositoryItemSearchLookUpEdit1.AutoHeight = False
        Me.RepositoryItemSearchLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSearchLookUpEdit1.DataSource = Me.TaxPayerFindBindingSource
        Me.RepositoryItemSearchLookUpEdit1.DisplayMember = "CompanyName"
        Me.RepositoryItemSearchLookUpEdit1.Name = "RepositoryItemSearchLookUpEdit1"
        Me.RepositoryItemSearchLookUpEdit1.NullText = "Select"
        Me.RepositoryItemSearchLookUpEdit1.PopupFormMinSize = New System.Drawing.Size(450, 0)
        Me.RepositoryItemSearchLookUpEdit1.ValueMember = "RefNo"
        Me.RepositoryItemSearchLookUpEdit1.View = Me.RepositoryItemSearchLookUpEdit1View
        '
        'RepositoryItemSearchLookUpEdit1View
        '
        Me.RepositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRefNo, Me.colCompanyName, Me.colHandleBy, Me.colCompanyNo, Me.colEmployerNo, Me.colFileNo, Me.colCountry, Me.colCompanyCode})
        Me.RepositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemSearchLookUpEdit1View.Name = "RepositoryItemSearchLookUpEdit1View"
        Me.RepositoryItemSearchLookUpEdit1View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemSearchLookUpEdit1View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemSearchLookUpEdit1View.OptionsBehavior.Editable = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ColumnAutoWidth = False
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.RowAutoHeight = True
        Me.RepositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colRefNo
        '
        Me.colRefNo.FieldName = "RefNo"
        Me.colRefNo.Name = "colRefNo"
        Me.colRefNo.Visible = True
        Me.colRefNo.VisibleIndex = 0
        Me.colRefNo.Width = 100
        '
        'colCompanyName
        '
        Me.colCompanyName.FieldName = "CompanyName"
        Me.colCompanyName.Name = "colCompanyName"
        Me.colCompanyName.Visible = True
        Me.colCompanyName.VisibleIndex = 1
        Me.colCompanyName.Width = 250
        '
        'colHandleBy
        '
        Me.colHandleBy.FieldName = "HandleBy"
        Me.colHandleBy.Name = "colHandleBy"
        Me.colHandleBy.Visible = True
        Me.colHandleBy.VisibleIndex = 2
        Me.colHandleBy.Width = 150
        '
        'colCompanyNo
        '
        Me.colCompanyNo.FieldName = "CompanyNo"
        Me.colCompanyNo.Name = "colCompanyNo"
        Me.colCompanyNo.Visible = True
        Me.colCompanyNo.VisibleIndex = 3
        Me.colCompanyNo.Width = 100
        '
        'colEmployerNo
        '
        Me.colEmployerNo.FieldName = "EmployerNo"
        Me.colEmployerNo.Name = "colEmployerNo"
        Me.colEmployerNo.Visible = True
        Me.colEmployerNo.VisibleIndex = 4
        Me.colEmployerNo.Width = 100
        '
        'colFileNo
        '
        Me.colFileNo.FieldName = "FileNo"
        Me.colFileNo.Name = "colFileNo"
        Me.colFileNo.Visible = True
        Me.colFileNo.VisibleIndex = 5
        Me.colFileNo.Width = 100
        '
        'colCountry
        '
        Me.colCountry.FieldName = "Country"
        Me.colCountry.Name = "colCountry"
        Me.colCountry.Visible = True
        Me.colCountry.VisibleIndex = 6
        Me.colCountry.Width = 100
        '
        'colCompanyCode
        '
        Me.colCompanyCode.FieldName = "CompanyCode"
        Me.colCompanyCode.Name = "colCompanyCode"
        Me.colCompanyCode.Visible = True
        Me.colCompanyCode.VisibleIndex = 7
        Me.colCompanyCode.Width = 100
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
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup6, Me.RibbonPageGroup5})
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
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnErrorLog)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "Other"
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
        'PopupMenu1
        '
        Me.PopupMenu1.Name = "PopupMenu1"
        Me.PopupMenu1.Ribbon = Me.RibbonControl1
        '
        'frmPNL_B_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1534, 922)
        Me.Controls.Add(Me.pnlDocInformation)
        Me.Controls.Add(Me.hideContainerRight)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPNL_B_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profit And Loss"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hideContainerRight.ResumeLayout(False)
        Me.pnlDocImport.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        Me.pnlDocExport.ResumeLayout(False)
        Me.ControlContainer1.ResumeLayout(False)
        CType(Me.dgvExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExportPNLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPNL2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.XtraTabPage5.ResumeLayout(False)
        Me.XtraTabPage5.PerformLayout()
        CType(Me.TextEdit16.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit13.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit14.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit15.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage4.ResumeLayout(False)
        Me.XtraTabPage4.PerformLayout()
        CType(Me.txt_p4ExpectedExpenses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4NonAllowableExpenses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4NetProfitLoss.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4TotalExpenses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4TotalOtherExpenses.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4OtherBalacingFigure.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4UnreaLossForeEx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4FAWrittenOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4LeavePass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4ProvisionAcc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4Compound.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4EntStaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_p4EntNonStaff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.TaxPayerFindBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cboYA As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents TaxPayerFindBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsCA As EasyTemplate_Taxcom.dsCA
    Friend WithEvents lbl_p2UnreaGainForeExNon As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_p2Other As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents lbl_p4LossDispFA As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents btnErrorLog As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents cboRefNo As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit
    Friend WithEvents RepositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents colRefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHandleBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmployerNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompanyCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TextEdit16 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit15 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class
