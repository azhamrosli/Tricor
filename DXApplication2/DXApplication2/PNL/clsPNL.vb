Imports System.Data.SqlClient
Imports DevExpress.XtraBars.Docking
Imports System.Reflection
Public Class clsPNL
    Inherits clsIODatabase

    Public txtNetProfit As DevExpress.XtraBars.BarEditItem

    Public dsDataset As dsPNL

    Public doc_p1Sales As DockPanel = Nothing
    Public doc_p1OpenStock As DockPanel = Nothing
    Public doc_p1Purchase As DockPanel = Nothing
    Public doc_p1Depreciation As DockPanel = Nothing
    Public doc_p1NonAllowableExpenses As DockPanel = Nothing
    Public doc_p1OtherAllowableExpenses As DockPanel = Nothing
    Public doc_p1CloseStock As DockPanel = Nothing
    Public doc_p2OtherBizIncome As DockPanel = Nothing
    Public doc_p2DivIncome As DockPanel = Nothing
    Public doc_p2InterestIncome As DockPanel = Nothing
    Public doc_p2RentalIncome As DockPanel = Nothing
    Public doc_p2RoyaltyIncome As DockPanel = Nothing
    Public doc_p2OtherIncome As DockPanel = Nothing
    Public doc_p2GainDispFixAss As DockPanel = Nothing
    Public doc_p2GainForeEx As DockPanel = Nothing
    Public doc_p2GainInv As DockPanel = Nothing
    Public doc_p2Other As DockPanel = Nothing
    Public doc_p3LoanInterest As DockPanel = Nothing
    Public doc_p3SalAllowBon As DockPanel = Nothing
    Public doc_p3RentMort As DockPanel = Nothing
    Public doc_p3ContSubCont As DockPanel = Nothing
    Public doc_p3Commission As DockPanel = Nothing
    Public doc_p3BadDebts As DockPanel = Nothing
    Public doc_p3TravTransAccom As DockPanel = Nothing
    Public doc_p3RepairMaint As DockPanel = Nothing
    Public doc_p3PromAdv As DockPanel = Nothing
    Public doc_p3InpTaxNotClaimJKDM As DockPanel = Nothing
    Public doc_p3EPFPersonal As DockPanel = Nothing
    Public doc_p3EPFStaff As DockPanel = Nothing
    Public doc_p3LegalFee As DockPanel = Nothing
    Public doc_p3OthExpenses As DockPanel = Nothing
    Public doc_p4LossDispFixAss As DockPanel = Nothing
    Public doc_p4LossForeExch As DockPanel = Nothing
    Public doc_p4LossInv As DockPanel = Nothing
    Public doc_p4Others As DockPanel = Nothing
    Public doc_p4Depreciation As DockPanel = Nothing
    Public doc_p4Entertainment As DockPanel = Nothing
    Public doc_p4Gift As DockPanel = Nothing
    Public doc_p4Donation As DockPanel = Nothing
    Public doc_p4PenFineComp As DockPanel = Nothing
    Public doc_p4DrawingPLStock As DockPanel = Nothing
    Public doc_p4DrawingPLCash As DockPanel = Nothing
    Public doc_p4ProvDoubDebt As DockPanel = Nothing
    Public doc_p4PreCessExp As DockPanel = Nothing
    Public doc_p4CapExp As DockPanel = Nothing
    Public doc_p4AssWritOff As DockPanel = Nothing
    Public doc_p5MotVehUsage As DockPanel = Nothing
    Public doc_p5ResBen As DockPanel = Nothing
    Public doc_p5Telephone As DockPanel = Nothing
    Public doc_p5SubsNotRelBusi As DockPanel = Nothing
    Public doc_p5Seminar As DockPanel = Nothing
    Public doc_p5MedExp As DockPanel = Nothing
    Public doc_p5OthNonAllowExpCha As DockPanel = Nothing


    Public ds_p1Sales As New dsPNL
    Public ds_p1OpenStock As New dsPNL
    Public ds_p1Purchase As New dsPNL
    Public ds_p1Depreciation As New dsPNL
    Public ds_p1OtherAllowableExpenses As New dsPNL
    Public ds_p1NonAllowableExpenses As New dsPNL
    Public ds_p1CloseStock As New dsPNL
    Public ds_p2OtherBizIncome As New dsPNL
    Public ds_p2DivIncome As New dsPNL
    Public ds_p2InterestIncome As New dsPNL
    Public ds_p2RentalIncome As New dsPNL
    Public ds_p2RoyaltyIncome As New dsPNL
    Public ds_p2OtherIncome As New dsPNL
    Public ds_p2GainDispFixAss As New dsPNL
    Public ds_p2GainForeEx As New dsPNL
    Public ds_p2GainInv As New dsPNL
    Public ds_p2Other As New dsPNL
    Public ds_p3LoanInterest As New dsPNL
    Public ds_p3SalAllowBon As New dsPNL
    Public ds_p3RentMort As New dsPNL
    Public ds_p3ContSubCont As New dsPNL
    Public ds_p3Commission As New dsPNL
    Public ds_p3BadDebts As New dsPNL
    Public ds_p3TravTransAccom As New dsPNL
    Public ds_p3RepairMaint As New dsPNL
    Public ds_p3PromAdv As New dsPNL
    Public ds_p3InpTaxNotClaimJKDM As New dsPNL
    Public ds_p3EPFPersonal As New dsPNL
    Public ds_p3EPFStaff As New dsPNL
    Public ds_p3LegalFee As New dsPNL
    Public ds_p3OthExpenses As New dsPNL
    Public ds_p4LossDispFixAss As New dsPNL
    Public ds_p4LossForeExch As New dsPNL
    Public ds_p4LossInv As New dsPNL
    Public ds_p4Others As New dsPNL
    Public ds_p4Depreciation As New dsPNL
    Public ds_p4Entertainment As New dsPNL
    Public ds_p4Gift As New dsPNL
    Public ds_p4Donation As New dsPNL
    Public ds_p4PenFineComp As New dsPNL
    Public ds_p4DrawingPLStock As New dsPNL
    Public ds_p4DrawingPLCash As New dsPNL
    Public ds_p4ProvDoubDebt As New dsPNL
    Public ds_p4PreCessExp As New dsPNL
    Public ds_p4CapExp As New dsPNL
    Public ds_p4AssWritOff As New dsPNL
    Public ds_p5MotVehUsage As New dsPNL
    Public ds_p5ResBen As New dsPNL
    Public ds_p5Telephone As New dsPNL
    Public ds_p5SubsNotRelBusi As New dsPNL
    Public ds_p5Seminar As New dsPNL
    Public ds_p5MedExp As New dsPNL
    Public ds_p5OthNonAllowExpCha As New dsPNL
    Sub New()
        If dsDataset Is Nothing Then
            dsDataset = New dsPNL
        End If
    End Sub

    Public Function ViewPNL(ByVal dtRow As DataRow, ByVal dsDefault As dsDefault, _
                            ByVal RefNo As DevExpress.XtraBars.BarEditItem, ByVal YA As DevExpress.XtraBars.BarEditItem, _
                            ByVal SourceNo As DevExpress.XtraBars.BarEditItem, ByRef DockingManager As DockManager, _
                            ByRef DockDocument As DevExpress.XtraBars.Docking2010.DocumentManager, _
                            Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            DockDocument.BeginUpdate()
            Dim doc As DevExpress.XtraBars.Docking2010.Views.BaseDocument

            Select Case CInt(IIf(IsDBNull(dtRow("OldKey")), 0, dtRow("OldKey")))
                Case 1
                    If doc_p1Sales Is Nothing OrElse doc_p1Sales.IsDisposed Then
                        doc_p1Sales = New DockPanel
                        Dim uc As New ucPNL_p1Sales

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p1Sales
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p1Sales.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p1Sales.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p1Sales.Controls.Add(uc)
                        doc_p1Sales.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p1Sales)
                    Else
                        doc_p1Sales.Visibility = DockVisibility.Visible
                        If doc_p1Sales.Controls.Count > 0 AndAlso TypeOf doc_p1Sales.Controls(0) Is ucPNL_p1Sales Then
                            Dim uc As ucPNL_p1Sales = CType(doc_p1Sales.Controls(0), ucPNL_p1Sales)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p1Sales
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p1Sales)
                    End If
                    DockDocument.View.ActivateDocument(doc_p1Sales)
                Case 2
                    If doc_p1OpenStock Is Nothing OrElse doc_p1OpenStock.IsDisposed Then
                        doc_p1OpenStock = New DockPanel
                        Dim uc As New ucPNL_p1OpenStock

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p1OpenStock
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p1OpenStock.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p1OpenStock.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p1OpenStock.Controls.Add(uc)
                        doc_p1OpenStock.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p1OpenStock)
                    Else
                        doc_p1OpenStock.Visibility = DockVisibility.Visible
                        If doc_p1OpenStock.Controls.Count > 0 AndAlso TypeOf doc_p1OpenStock.Controls(0) Is ucPNL_p1OpenStock Then
                            Dim uc As ucPNL_p1OpenStock = CType(doc_p1OpenStock.Controls(0), ucPNL_p1OpenStock)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p1OpenStock
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p1OpenStock)
                    End If
                    DockDocument.View.ActivateDocument(doc_p1OpenStock)
                Case 3
                    If doc_p1Purchase Is Nothing OrElse doc_p1Purchase.IsDisposed Then
                        doc_p1Purchase = New DockPanel
                        Dim uc As New ucPNL_p1Purchase

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p1Purchase
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p1Purchase.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p1Purchase.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p1Purchase.Controls.Add(uc)
                        doc_p1Purchase.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p1Purchase)
                    Else
                        doc_p1Purchase.Visibility = DockVisibility.Visible
                        If doc_p1Purchase.Controls.Count > 0 AndAlso TypeOf doc_p1Purchase.Controls(0) Is ucPNL_p1Purchase Then
                            Dim uc As ucPNL_p1Purchase = CType(doc_p1Purchase.Controls(0), ucPNL_p1Purchase)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p1Purchase
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p1Purchase)
                    End If
                    DockDocument.View.ActivateDocument(doc_p1Purchase)
                Case 43
                    If doc_p1Depreciation Is Nothing OrElse doc_p1Depreciation.IsDisposed Then
                        doc_p1Depreciation = New DockPanel
                        Dim uc As New ucPNL_p1Depreciation

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p1Depreciation
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p1Depreciation.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p1Depreciation.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p1Depreciation.Controls.Add(uc)
                        doc_p1Depreciation.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p1Depreciation)
                    Else
                        doc_p1Depreciation.Visibility = DockVisibility.Visible
                        If doc_p1Depreciation.Controls.Count > 0 AndAlso TypeOf doc_p1Depreciation.Controls(0) Is ucPNL_p1Depreciation Then
                            Dim uc As ucPNL_p1Depreciation = CType(doc_p1Depreciation.Controls(0), ucPNL_p1Depreciation)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p1Depreciation
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p1Depreciation)
                    End If
                    DockDocument.View.ActivateDocument(doc_p1Depreciation)
                Case 44
                    If doc_p1OtherAllowableExpenses Is Nothing OrElse doc_p1OtherAllowableExpenses.IsDisposed Then
                        doc_p1OtherAllowableExpenses = New DockPanel
                        Dim uc As New ucPNL_p1OtherAllowableExpenses

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p1OtherAllowableExpenses
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p1OtherAllowableExpenses.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p1OtherAllowableExpenses.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p1OtherAllowableExpenses.Controls.Add(uc)
                        doc_p1OtherAllowableExpenses.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p1OtherAllowableExpenses)
                    Else
                        doc_p1OtherAllowableExpenses.Visibility = DockVisibility.Visible
                        If doc_p1OtherAllowableExpenses.Controls.Count > 0 AndAlso TypeOf doc_p1OtherAllowableExpenses.Controls(0) Is ucPNL_p1OtherAllowableExpenses Then
                            Dim uc As ucPNL_p1OtherAllowableExpenses = CType(doc_p1OtherAllowableExpenses.Controls(0), ucPNL_p1OtherAllowableExpenses)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p1OtherAllowableExpenses
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p1OtherAllowableExpenses)
                    End If
                    DockDocument.View.ActivateDocument(doc_p1OtherAllowableExpenses)
                Case 45
                    If doc_p1NonAllowableExpenses Is Nothing OrElse doc_p1NonAllowableExpenses.IsDisposed Then
                        doc_p1NonAllowableExpenses = New DockPanel
                        Dim uc As New ucPNL_p1NonAllowableExpenses

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p1NonAllowableExpenses
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p1NonAllowableExpenses.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p1NonAllowableExpenses.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p1NonAllowableExpenses.Controls.Add(uc)
                        doc_p1NonAllowableExpenses.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p1NonAllowableExpenses)
                    Else
                        doc_p1NonAllowableExpenses.Visibility = DockVisibility.Visible
                        If doc_p1NonAllowableExpenses.Controls.Count > 0 AndAlso TypeOf doc_p1NonAllowableExpenses.Controls(0) Is ucPNL_p1NonAllowableExpenses Then
                            Dim uc As ucPNL_p1NonAllowableExpenses = CType(doc_p1NonAllowableExpenses.Controls(0), ucPNL_p1NonAllowableExpenses)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p1NonAllowableExpenses
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p1NonAllowableExpenses)
                    End If
                    DockDocument.View.ActivateDocument(doc_p1NonAllowableExpenses)
                Case 5
                    If doc_p1CloseStock Is Nothing OrElse doc_p1CloseStock.IsDisposed Then
                        doc_p1CloseStock = New DockPanel
                        Dim uc As New ucPNL_p1CloseStock

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p1CloseStock
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p1CloseStock.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p1CloseStock.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p1CloseStock.Controls.Add(uc)
                        doc_p1CloseStock.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p1CloseStock)
                    Else
                        doc_p1CloseStock.Visibility = DockVisibility.Visible
                        If doc_p1CloseStock.Controls.Count > 0 AndAlso TypeOf doc_p1CloseStock.Controls(0) Is ucPNL_p1CloseStock Then
                            Dim uc As ucPNL_p1CloseStock = CType(doc_p1CloseStock.Controls(0), ucPNL_p1CloseStock)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p1CloseStock
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p1CloseStock)
                    End If
                    DockDocument.View.ActivateDocument(doc_p1CloseStock)
                Case 6
                    If doc_p2OtherBizIncome Is Nothing OrElse doc_p2OtherBizIncome.IsDisposed Then
                        doc_p2OtherBizIncome = New DockPanel
                        Dim uc As New ucPNL_p2OtherBizIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p2OtherBizIncome
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p2OtherBizIncome.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p2OtherBizIncome.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p2OtherBizIncome.Controls.Add(uc)
                        doc_p2OtherBizIncome.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p2OtherBizIncome)
                    Else
                        doc_p2OtherBizIncome.Visibility = DockVisibility.Visible
                        If doc_p2OtherBizIncome.Controls.Count > 0 AndAlso TypeOf doc_p2OtherBizIncome.Controls(0) Is ucPNL_p2OtherBizIncome Then
                            Dim uc As ucPNL_p2OtherBizIncome = CType(doc_p2OtherBizIncome.Controls(0), ucPNL_p2OtherBizIncome)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p2OtherBizIncome
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2OtherBizIncome)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2OtherBizIncome)
                Case 47
                    If doc_p2DivIncome Is Nothing OrElse doc_p2DivIncome.IsDisposed Then
                        doc_p2DivIncome = New DockPanel
                        Dim uc As New ucPNL_p2DivIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p2DivIncome
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p2DivIncome.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p2DivIncome.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p2DivIncome.Controls.Add(uc)
                        doc_p2DivIncome.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p2DivIncome)
                    Else
                        doc_p2DivIncome.Visibility = DockVisibility.Visible
                        If doc_p2DivIncome.Controls.Count > 0 AndAlso TypeOf doc_p2DivIncome.Controls(0) Is ucPNL_p2DivIncome Then
                            Dim uc As ucPNL_p2DivIncome = CType(doc_p2DivIncome.Controls(0), ucPNL_p2DivIncome)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p2DivIncome
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2DivIncome)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2DivIncome)
                Case 50
                    If doc_p2InterestIncome Is Nothing OrElse doc_p2InterestIncome.IsDisposed Then
                        doc_p2InterestIncome = New DockPanel
                        Dim uc As New ucPNL_p2InterestIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p2InterestIncome
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p2InterestIncome.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p2InterestIncome.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p2InterestIncome.Controls.Add(uc)
                        doc_p2InterestIncome.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p2InterestIncome)
                    Else
                        doc_p2InterestIncome.Visibility = DockVisibility.Visible
                        If doc_p2InterestIncome.Controls.Count > 0 AndAlso TypeOf doc_p2InterestIncome.Controls(0) Is ucPNL_p2InterestIncome Then
                            Dim uc As ucPNL_p2InterestIncome = CType(doc_p2InterestIncome.Controls(0), ucPNL_p2InterestIncome)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p2InterestIncome
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2InterestIncome)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2InterestIncome)
                Case 48
                    If doc_p2RentalIncome Is Nothing OrElse doc_p2RentalIncome.IsDisposed Then
                        doc_p2RentalIncome = New DockPanel
                        Dim uc As New ucPNL_p2RentalIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p2RentalIncome
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p2RentalIncome.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p2RentalIncome.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p2RentalIncome.Controls.Add(uc)
                        doc_p2RentalIncome.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p2RentalIncome)
                    Else
                        doc_p2RentalIncome.Visibility = DockVisibility.Visible
                        If doc_p2RentalIncome.Controls.Count > 0 AndAlso TypeOf doc_p2RentalIncome.Controls(0) Is ucPNL_p2RentalIncome Then
                            Dim uc As ucPNL_p2RentalIncome = CType(doc_p2RentalIncome.Controls(0), ucPNL_p2RentalIncome)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p2RentalIncome
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2RentalIncome)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2RentalIncome)
                Case 49
                    If doc_p2RoyaltyIncome Is Nothing OrElse doc_p2RoyaltyIncome.IsDisposed Then
                        doc_p2RoyaltyIncome = New DockPanel
                        Dim uc As New ucPNL_p2RoyaltyIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p2RoyaltyIncome
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p2RoyaltyIncome.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p2RoyaltyIncome.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p2RoyaltyIncome.Controls.Add(uc)
                        doc_p2RoyaltyIncome.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p2RoyaltyIncome)
                    Else
                        doc_p2RoyaltyIncome.Visibility = DockVisibility.Visible
                        If doc_p2RoyaltyIncome.Controls.Count > 0 AndAlso TypeOf doc_p2RoyaltyIncome.Controls(0) Is ucPNL_p2RoyaltyIncome Then
                            Dim uc As ucPNL_p2RoyaltyIncome = CType(doc_p2RoyaltyIncome.Controls(0), ucPNL_p2RoyaltyIncome)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p2RoyaltyIncome
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2RoyaltyIncome)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2RoyaltyIncome)
                Case 51
                    If doc_p2OtherIncome Is Nothing OrElse doc_p2OtherIncome.IsDisposed Then
                        doc_p2OtherIncome = New DockPanel
                        Dim uc As New ucPNL_p2OtherIncome

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p2OtherIncome
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p2OtherIncome.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p2OtherIncome.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p2OtherIncome.Controls.Add(uc)
                        doc_p2OtherIncome.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p2OtherIncome)
                    Else
                        doc_p2OtherIncome.Visibility = DockVisibility.Visible
                        If doc_p2OtherIncome.Controls.Count > 0 AndAlso TypeOf doc_p2OtherIncome.Controls(0) Is ucPNL_p2OtherIncome Then
                            Dim uc As ucPNL_p2OtherIncome = CType(doc_p2OtherIncome.Controls(0), ucPNL_p2OtherIncome)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p2OtherIncome
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2OtherIncome)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2OtherIncome)
                Case 7
                    If doc_p2GainDispFixAss Is Nothing OrElse doc_p2GainDispFixAss.IsDisposed Then
                        doc_p2GainDispFixAss = New DockPanel
                        Dim uc As New ucPNL_p2GainDispFixAss

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p2GainDispFixAss
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p2GainDispFixAss.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p2GainDispFixAss.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p2GainDispFixAss.Controls.Add(uc)
                        doc_p2GainDispFixAss.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p2GainDispFixAss)
                    Else
                        doc_p2GainDispFixAss.Visibility = DockVisibility.Visible
                        If doc_p2GainDispFixAss.Controls.Count > 0 AndAlso TypeOf doc_p2GainDispFixAss.Controls(0) Is ucPNL_p2GainDispFixAss Then
                            Dim uc As ucPNL_p2GainDispFixAss = CType(doc_p2GainDispFixAss.Controls(0), ucPNL_p2GainDispFixAss)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p2GainDispFixAss
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2GainDispFixAss)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2GainDispFixAss)
                Case 8
                    If doc_p2GainForeEx Is Nothing OrElse doc_p2GainForeEx.IsDisposed Then
                        doc_p2GainForeEx = New DockPanel
                        Dim uc As New ucPNL_p2GainForeEx

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p2GainForeEx
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p2GainForeEx.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p2GainForeEx.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p2GainForeEx.Controls.Add(uc)
                        doc_p2GainForeEx.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p2GainForeEx)
                    Else
                        doc_p2GainForeEx.Visibility = DockVisibility.Visible
                        If doc_p2GainForeEx.Controls.Count > 0 AndAlso TypeOf doc_p2GainForeEx.Controls(0) Is ucPNL_p2GainForeEx Then
                            Dim uc As ucPNL_p2GainForeEx = CType(doc_p2GainForeEx.Controls(0), ucPNL_p2GainForeEx)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p2GainForeEx
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2GainForeEx)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2GainForeEx)
                Case 9
                    If doc_p2GainInv Is Nothing OrElse doc_p2GainInv.IsDisposed Then
                        doc_p2GainInv = New DockPanel
                        Dim uc As New ucPNL_p2GainInv

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p2GainInv
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p2GainInv.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p2GainInv.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p2GainInv.Controls.Add(uc)
                        doc_p2GainInv.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p2GainInv)
                    Else
                        doc_p2GainInv.Visibility = DockVisibility.Visible
                        If doc_p2GainInv.Controls.Count > 0 AndAlso TypeOf doc_p2GainInv.Controls(0) Is ucPNL_p2GainInv Then
                            Dim uc As ucPNL_p2GainInv = CType(doc_p2GainInv.Controls(0), ucPNL_p2GainInv)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p2GainInv
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2GainInv)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2GainInv)
                Case 10
                    If doc_p2Other Is Nothing OrElse doc_p2Other.IsDisposed Then
                        doc_p2Other = New DockPanel
                        Dim uc As New ucPNL_p2Other

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p2Other
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p2Other.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p2Other.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p2Other.Controls.Add(uc)
                        doc_p2Other.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p2Other)
                    Else
                        doc_p2Other.Visibility = DockVisibility.Visible
                        If doc_p2Other.Controls.Count > 0 AndAlso TypeOf doc_p2Other.Controls(0) Is ucPNL_p2Other Then
                            Dim uc As ucPNL_p2Other = CType(doc_p2Other.Controls(0), ucPNL_p2Other)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p2Other
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p2Other)
                    End If
                    DockDocument.View.ActivateDocument(doc_p2Other)
                Case 11
                    If doc_p3LoanInterest Is Nothing OrElse doc_p3LoanInterest.IsDisposed Then
                        doc_p3LoanInterest = New DockPanel
                        Dim uc As New ucPNL_p3LoanInterest

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p3LoanInterest
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p3LoanInterest.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p3LoanInterest.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p3LoanInterest.Controls.Add(uc)
                        doc_p3LoanInterest.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p3LoanInterest)
                    Else
                        doc_p3LoanInterest.Visibility = DockVisibility.Visible
                        If doc_p3LoanInterest.Controls.Count > 0 AndAlso TypeOf doc_p3LoanInterest.Controls(0) Is ucPNL_p3LoanInterest Then
                            Dim uc As ucPNL_p3LoanInterest = CType(doc_p3LoanInterest.Controls(0), ucPNL_p3LoanInterest)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p3LoanInterest
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3LoanInterest)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3LoanInterest)
                Case 12
                    If doc_p3LoanInterest Is Nothing OrElse doc_p3LoanInterest.IsDisposed Then
                        doc_p3LoanInterest = New DockPanel
                        Dim uc As New ucPNL_p3SalAllowBon

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p3SalAllowBon
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p3LoanInterest.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p3LoanInterest.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p3LoanInterest.Controls.Add(uc)
                        doc_p3LoanInterest.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p3LoanInterest)
                    Else
                        doc_p3LoanInterest.Visibility = DockVisibility.Visible
                        If doc_p3LoanInterest.Controls.Count > 0 AndAlso TypeOf doc_p3LoanInterest.Controls(0) Is ucPNL_p3SalAllowBon Then
                            Dim uc As ucPNL_p3SalAllowBon = CType(doc_p3LoanInterest.Controls(0), ucPNL_p3SalAllowBon)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p3SalAllowBon
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3LoanInterest)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3LoanInterest)
                Case 13
                    If doc_p3RentMort Is Nothing OrElse doc_p3RentMort.IsDisposed Then
                        doc_p3RentMort = New DockPanel
                        Dim uc As New ucPNL_p3RentMort

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p3RentMort
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p3RentMort.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p3RentMort.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p3RentMort.Controls.Add(uc)
                        doc_p3RentMort.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p3RentMort)
                    Else
                        doc_p3RentMort.Visibility = DockVisibility.Visible
                        If doc_p3RentMort.Controls.Count > 0 AndAlso TypeOf doc_p3RentMort.Controls(0) Is ucPNL_p3RentMort Then
                            Dim uc As ucPNL_p3RentMort = CType(doc_p3RentMort.Controls(0), ucPNL_p3RentMort)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p3RentMort
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3RentMort)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3RentMort)
                Case 14
                    If doc_p3ContSubCont Is Nothing OrElse doc_p3ContSubCont.IsDisposed Then
                        doc_p3ContSubCont = New DockPanel
                        Dim uc As New ucPNL_p3ContSubCont

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p3ContSubCont
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p3ContSubCont.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p3ContSubCont.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p3ContSubCont.Controls.Add(uc)
                        doc_p3ContSubCont.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p3ContSubCont)
                    Else
                        doc_p3ContSubCont.Visibility = DockVisibility.Visible
                        If doc_p3ContSubCont.Controls.Count > 0 AndAlso TypeOf doc_p3ContSubCont.Controls(0) Is ucPNL_p3ContSubCont Then
                            Dim uc As ucPNL_p3ContSubCont = CType(doc_p3ContSubCont.Controls(0), ucPNL_p3ContSubCont)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p3ContSubCont
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3ContSubCont)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3ContSubCont)
                Case 15
                    If doc_p3Commission Is Nothing OrElse doc_p3Commission.IsDisposed Then
                        doc_p3Commission = New DockPanel
                        Dim uc As New ucPNL_p3Commission

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p3Commission
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p3Commission.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p3Commission.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p3Commission.Controls.Add(uc)
                        doc_p3Commission.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p3Commission)
                    Else
                        doc_p3Commission.Visibility = DockVisibility.Visible
                        If doc_p3Commission.Controls.Count > 0 AndAlso TypeOf doc_p3Commission.Controls(0) Is ucPNL_p3Commission Then
                            Dim uc As ucPNL_p3Commission = CType(doc_p3Commission.Controls(0), ucPNL_p3Commission)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p3Commission
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3Commission)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3Commission)
                Case 16
                    If doc_p3BadDebts Is Nothing OrElse doc_p3BadDebts.IsDisposed Then
                        doc_p3BadDebts = New DockPanel
                        Dim uc As New ucPNL_p3BadDebts

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p3BadDebts
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p3BadDebts.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p3BadDebts.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p3BadDebts.Controls.Add(uc)
                        doc_p3BadDebts.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p3BadDebts)
                    Else
                        doc_p3BadDebts.Visibility = DockVisibility.Visible
                        If doc_p3BadDebts.Controls.Count > 0 AndAlso TypeOf doc_p3BadDebts.Controls(0) Is ucPNL_p3BadDebts Then
                            Dim uc As ucPNL_p3BadDebts = CType(doc_p3BadDebts.Controls(0), ucPNL_p3BadDebts)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p3BadDebts
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3BadDebts)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3BadDebts)
                Case 17
                    If doc_p3TravTransAccom Is Nothing OrElse doc_p3TravTransAccom.IsDisposed Then
                        doc_p3TravTransAccom = New DockPanel
                        Dim uc As New ucPNL_p3TravTransAccom

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p3TravTransAccom
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p3TravTransAccom.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p3TravTransAccom.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p3TravTransAccom.Controls.Add(uc)
                        doc_p3TravTransAccom.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p3TravTransAccom)
                    Else
                        doc_p3TravTransAccom.Visibility = DockVisibility.Visible
                        If doc_p3TravTransAccom.Controls.Count > 0 AndAlso TypeOf doc_p3TravTransAccom.Controls(0) Is ucPNL_p3TravTransAccom Then
                            Dim uc As ucPNL_p3TravTransAccom = CType(doc_p3TravTransAccom.Controls(0), ucPNL_p3TravTransAccom)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p3TravTransAccom
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3TravTransAccom)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3TravTransAccom)
                Case 52
                    If doc_p3RepairMaint Is Nothing OrElse doc_p3RepairMaint.IsDisposed Then
                        doc_p3RepairMaint = New DockPanel
                        Dim uc As New ucPNL_p3RepairMaint

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p3RepairMaint
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p3RepairMaint.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p3RepairMaint.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p3RepairMaint.Controls.Add(uc)
                        doc_p3RepairMaint.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p3RepairMaint)
                    Else
                        doc_p3RepairMaint.Visibility = DockVisibility.Visible
                        If doc_p3RepairMaint.Controls.Count > 0 AndAlso TypeOf doc_p3RepairMaint.Controls(0) Is ucPNL_p3RepairMaint Then
                            Dim uc As ucPNL_p3RepairMaint = CType(doc_p3RepairMaint.Controls(0), ucPNL_p3RepairMaint)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p3RepairMaint
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3RepairMaint)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3RepairMaint)
                Case 53
                    If doc_p3PromAdv Is Nothing OrElse doc_p3PromAdv.IsDisposed Then
                        doc_p3PromAdv = New DockPanel
                        Dim uc As New ucPNL_p3PromAdv

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p3PromAdv
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p3PromAdv.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p3PromAdv.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p3PromAdv.Controls.Add(uc)
                        doc_p3PromAdv.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p3PromAdv)
                    Else
                        doc_p3PromAdv.Visibility = DockVisibility.Visible
                        If doc_p3PromAdv.Controls.Count > 0 AndAlso TypeOf doc_p3PromAdv.Controls(0) Is ucPNL_p3PromAdv Then
                            Dim uc As ucPNL_p3PromAdv = CType(doc_p3PromAdv.Controls(0), ucPNL_p3PromAdv)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p3PromAdv
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3PromAdv)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3PromAdv)
                Case 54
                    If doc_p3InpTaxNotClaimJKDM Is Nothing OrElse doc_p3InpTaxNotClaimJKDM.IsDisposed Then
                        doc_p3InpTaxNotClaimJKDM = New DockPanel
                        Dim uc As New ucPNL_p3InpTaxNotClaimJKDM

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p3InpTaxNotClaimJKDM
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p3InpTaxNotClaimJKDM.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p3InpTaxNotClaimJKDM.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p3InpTaxNotClaimJKDM.Controls.Add(uc)
                        doc_p3InpTaxNotClaimJKDM.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p3InpTaxNotClaimJKDM)
                    Else
                        doc_p3InpTaxNotClaimJKDM.Visibility = DockVisibility.Visible
                        If doc_p3InpTaxNotClaimJKDM.Controls.Count > 0 AndAlso TypeOf doc_p3InpTaxNotClaimJKDM.Controls(0) Is ucPNL_p3InpTaxNotClaimJKDM Then
                            Dim uc As ucPNL_p3InpTaxNotClaimJKDM = CType(doc_p3InpTaxNotClaimJKDM.Controls(0), ucPNL_p3InpTaxNotClaimJKDM)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p3InpTaxNotClaimJKDM
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3InpTaxNotClaimJKDM)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3InpTaxNotClaimJKDM)
                Case 18
                    If doc_p3EPFPersonal Is Nothing OrElse doc_p3EPFPersonal.IsDisposed Then
                        doc_p3EPFPersonal = New DockPanel
                        Dim uc As New ucPNL_p3EPFPersonal

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p3EPFPersonal
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p3EPFPersonal.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p3EPFPersonal.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p3EPFPersonal.Controls.Add(uc)
                        doc_p3EPFPersonal.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p3EPFPersonal)
                    Else
                        doc_p3EPFPersonal.Visibility = DockVisibility.Visible
                        If doc_p3EPFPersonal.Controls.Count > 0 AndAlso TypeOf doc_p3EPFPersonal.Controls(0) Is ucPNL_p3EPFPersonal Then
                            Dim uc As ucPNL_p3EPFPersonal = CType(doc_p3EPFPersonal.Controls(0), ucPNL_p3EPFPersonal)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p3EPFPersonal
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3EPFPersonal)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3EPFPersonal)
                Case 19
                    If doc_p3EPFStaff Is Nothing OrElse doc_p3EPFStaff.IsDisposed Then
                        doc_p3EPFStaff = New DockPanel
                        Dim uc As New ucPNL_p3EPFStaff

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p3EPFStaff
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p3EPFStaff.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p3EPFStaff.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p3EPFStaff.Controls.Add(uc)
                        doc_p3EPFStaff.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p3EPFStaff)
                    Else
                        doc_p3EPFStaff.Visibility = DockVisibility.Visible
                        If doc_p3EPFStaff.Controls.Count > 0 AndAlso TypeOf doc_p3EPFStaff.Controls(0) Is ucPNL_p3EPFStaff Then
                            Dim uc As ucPNL_p3EPFStaff = CType(doc_p3EPFStaff.Controls(0), ucPNL_p3EPFStaff)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p3EPFStaff
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3EPFStaff)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3EPFStaff)
                Case 20
                    If doc_p3LegalFee Is Nothing OrElse doc_p3LegalFee.IsDisposed Then
                        doc_p3LegalFee = New DockPanel
                        Dim uc As New ucPNL_p3LegalFee

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p3LegalFee
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p3LegalFee.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p3LegalFee.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p3LegalFee.Controls.Add(uc)
                        doc_p3LegalFee.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p3LegalFee)
                    Else
                        doc_p3LegalFee.Visibility = DockVisibility.Visible
                        If doc_p3LegalFee.Controls.Count > 0 AndAlso TypeOf doc_p3LegalFee.Controls(0) Is ucPNL_p3LegalFee Then
                            Dim uc As ucPNL_p3LegalFee = CType(doc_p3LegalFee.Controls(0), ucPNL_p3LegalFee)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p3LegalFee
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3LegalFee)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3LegalFee)
                Case 46
                    If doc_p3OthExpenses Is Nothing OrElse doc_p3OthExpenses.IsDisposed Then
                        doc_p3OthExpenses = New DockPanel
                        Dim uc As New ucPNL_p3OthExpenses

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p3LegalFee
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p3OthExpenses.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p3OthExpenses.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p3OthExpenses.Controls.Add(uc)
                        doc_p3OthExpenses.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p3OthExpenses)
                    Else
                        doc_p3OthExpenses.Visibility = DockVisibility.Visible
                        If doc_p3OthExpenses.Controls.Count > 0 AndAlso TypeOf doc_p3OthExpenses.Controls(0) Is ucPNL_p3OthExpenses Then
                            Dim uc As ucPNL_p3OthExpenses = CType(doc_p3OthExpenses.Controls(0), ucPNL_p3OthExpenses)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p3LegalFee
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p3OthExpenses)
                    End If
                    DockDocument.View.ActivateDocument(doc_p3OthExpenses)
                Case 21
                    If doc_p4LossDispFixAss Is Nothing OrElse doc_p4LossDispFixAss.IsDisposed Then
                        doc_p4LossDispFixAss = New DockPanel
                        Dim uc As New ucPNL_p4LossDispFixAss

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4LossDispFixAss
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4LossDispFixAss.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4LossDispFixAss.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4LossDispFixAss.Controls.Add(uc)
                        doc_p4LossDispFixAss.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4LossDispFixAss)
                    Else
                        doc_p4LossDispFixAss.Visibility = DockVisibility.Visible
                        If doc_p4LossDispFixAss.Controls.Count > 0 AndAlso TypeOf doc_p4LossDispFixAss.Controls(0) Is ucPNL_p4LossDispFixAss Then
                            Dim uc As ucPNL_p4LossDispFixAss = CType(doc_p4LossDispFixAss.Controls(0), ucPNL_p4LossDispFixAss)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4LossDispFixAss
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4LossDispFixAss)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4LossDispFixAss)
                Case 22
                    If doc_p4LossForeExch Is Nothing OrElse doc_p4LossForeExch.IsDisposed Then
                        doc_p4LossForeExch = New DockPanel
                        Dim uc As New ucPNL_p4LossForeExch

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4LossForeExch
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4LossForeExch.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4LossForeExch.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4LossForeExch.Controls.Add(uc)
                        doc_p4LossForeExch.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4LossForeExch)
                    Else
                        doc_p4LossForeExch.Visibility = DockVisibility.Visible
                        If doc_p4LossForeExch.Controls.Count > 0 AndAlso TypeOf doc_p4LossForeExch.Controls(0) Is ucPNL_p4LossForeExch Then
                            Dim uc As ucPNL_p4LossForeExch = CType(doc_p4LossForeExch.Controls(0), ucPNL_p4LossForeExch)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4LossForeExch
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4LossForeExch)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4LossForeExch)
                Case 23
                    If doc_p4LossInv Is Nothing OrElse doc_p4LossInv.IsDisposed Then
                        doc_p4LossInv = New DockPanel
                        Dim uc As New ucPNL_p4LossInv

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4LossInv
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4LossInv.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4LossInv.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4LossInv.Controls.Add(uc)
                        doc_p4LossInv.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4LossInv)
                    Else
                        doc_p4LossInv.Visibility = DockVisibility.Visible
                        If doc_p4LossInv.Controls.Count > 0 AndAlso TypeOf doc_p4LossInv.Controls(0) Is ucPNL_p4LossInv Then
                            Dim uc As ucPNL_p4LossInv = CType(doc_p4LossInv.Controls(0), ucPNL_p4LossInv)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4LossInv
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4LossInv)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4LossInv)
                Case 24
                    If doc_p4Others Is Nothing OrElse doc_p4Others.IsDisposed Then
                        doc_p4Others = New DockPanel
                        Dim uc As New ucPNL_p4Others

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4Others
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4Others.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4Others.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4Others.Controls.Add(uc)
                        doc_p4Others.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4Others)
                    Else
                        doc_p4Others.Visibility = DockVisibility.Visible
                        If doc_p4Others.Controls.Count > 0 AndAlso TypeOf doc_p4Others.Controls(0) Is ucPNL_p4Others Then
                            Dim uc As ucPNL_p4Others = CType(doc_p4Others.Controls(0), ucPNL_p4Others)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4Others
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4Others)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4Others)
                Case 25
                    If doc_p4Depreciation Is Nothing OrElse doc_p4Depreciation.IsDisposed Then
                        doc_p4Depreciation = New DockPanel
                        Dim uc As New ucPNL_p4Depreciation

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4Depreciation
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4Depreciation.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4Depreciation.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4Depreciation.Controls.Add(uc)
                        doc_p4Depreciation.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4Depreciation)
                    Else
                        doc_p4Depreciation.Visibility = DockVisibility.Visible
                        If doc_p4Depreciation.Controls.Count > 0 AndAlso TypeOf doc_p4Depreciation.Controls(0) Is ucPNL_p4Depreciation Then
                            Dim uc As ucPNL_p4Depreciation = CType(doc_p4Depreciation.Controls(0), ucPNL_p4Depreciation)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4Depreciation
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4Depreciation)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4Depreciation)
                Case 26
                    If doc_p4Entertainment Is Nothing OrElse doc_p4Entertainment.IsDisposed Then
                        doc_p4Entertainment = New DockPanel
                        Dim uc As New ucPNL_p4Entertainment

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4Entertainment
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4Entertainment.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4Entertainment.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4Entertainment.Controls.Add(uc)
                        doc_p4Entertainment.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4Entertainment)
                    Else
                        doc_p4Entertainment.Visibility = DockVisibility.Visible
                        If doc_p4Entertainment.Controls.Count > 0 AndAlso TypeOf doc_p4Entertainment.Controls(0) Is ucPNL_p4Entertainment Then
                            Dim uc As ucPNL_p4Entertainment = CType(doc_p4Entertainment.Controls(0), ucPNL_p4Entertainment)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4Entertainment
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4Entertainment)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4Entertainment)
                Case 27
                    If doc_p4Gift Is Nothing OrElse doc_p4Gift.IsDisposed Then
                        doc_p4Gift = New DockPanel
                        Dim uc As New ucPNL_p4Gift

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4Gift
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4Gift.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4Gift.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4Gift.Controls.Add(uc)
                        doc_p4Gift.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4Gift)
                    Else
                        doc_p4Gift.Visibility = DockVisibility.Visible
                        If doc_p4Gift.Controls.Count > 0 AndAlso TypeOf doc_p4Gift.Controls(0) Is ucPNL_p4Gift Then
                            Dim uc As ucPNL_p4Gift = CType(doc_p4Gift.Controls(0), ucPNL_p4Gift)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4Gift
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4Gift)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4Gift)
                Case 28
                    If doc_p4Donation Is Nothing OrElse doc_p4Donation.IsDisposed Then
                        doc_p4Donation = New DockPanel
                        Dim uc As New ucPNL_p4Donation

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4Donation
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4Donation.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4Donation.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4Donation.Controls.Add(uc)
                        doc_p4Donation.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4Donation)
                    Else
                        doc_p4Donation.Visibility = DockVisibility.Visible
                        If doc_p4Donation.Controls.Count > 0 AndAlso TypeOf doc_p4Donation.Controls(0) Is ucPNL_p4Donation Then
                            Dim uc As ucPNL_p4Donation = CType(doc_p4Donation.Controls(0), ucPNL_p4Donation)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4Donation
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4Donation)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4Donation)
                Case 29
                    If doc_p4PenFineComp Is Nothing OrElse doc_p4PenFineComp.IsDisposed Then
                        doc_p4PenFineComp = New DockPanel
                        Dim uc As New ucPNL_p4PenFineComp

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4PenFineComp
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4PenFineComp.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4PenFineComp.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4PenFineComp.Controls.Add(uc)
                        doc_p4PenFineComp.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4PenFineComp)
                    Else
                        doc_p4PenFineComp.Visibility = DockVisibility.Visible
                        If doc_p4PenFineComp.Controls.Count > 0 AndAlso TypeOf doc_p4PenFineComp.Controls(0) Is ucPNL_p4PenFineComp Then
                            Dim uc As ucPNL_p4PenFineComp = CType(doc_p4PenFineComp.Controls(0), ucPNL_p4PenFineComp)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4PenFineComp
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4PenFineComp)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4PenFineComp)
                Case 30
                    If doc_p4DrawingPLStock Is Nothing OrElse doc_p4DrawingPLStock.IsDisposed Then
                        doc_p4DrawingPLStock = New DockPanel
                        Dim uc As New ucPNL_p4DrawingPLStock

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4DrawingPLStock
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4DrawingPLStock.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4DrawingPLStock.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4DrawingPLStock.Controls.Add(uc)
                        doc_p4DrawingPLStock.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4DrawingPLStock)
                    Else
                        doc_p4DrawingPLStock.Visibility = DockVisibility.Visible
                        If doc_p4DrawingPLStock.Controls.Count > 0 AndAlso TypeOf doc_p4DrawingPLStock.Controls(0) Is ucPNL_p4DrawingPLStock Then
                            Dim uc As ucPNL_p4DrawingPLStock = CType(doc_p4DrawingPLStock.Controls(0), ucPNL_p4DrawingPLStock)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4DrawingPLStock
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4DrawingPLStock)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4DrawingPLStock)
                Case 31
                    If doc_p4DrawingPLCash Is Nothing OrElse doc_p4DrawingPLCash.IsDisposed Then
                        doc_p4DrawingPLCash = New DockPanel
                        Dim uc As New ucPNL_p4DrawingPLCash

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4DrawingPLCash
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4DrawingPLCash.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4DrawingPLCash.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4DrawingPLCash.Controls.Add(uc)
                        doc_p4DrawingPLCash.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4DrawingPLCash)
                    Else
                        doc_p4DrawingPLCash.Visibility = DockVisibility.Visible
                        If doc_p4DrawingPLCash.Controls.Count > 0 AndAlso TypeOf doc_p4DrawingPLCash.Controls(0) Is ucPNL_p4DrawingPLCash Then
                            Dim uc As ucPNL_p4DrawingPLCash = CType(doc_p4DrawingPLCash.Controls(0), ucPNL_p4DrawingPLCash)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4DrawingPLCash
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4DrawingPLCash)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4DrawingPLCash)
                Case 32
                    If doc_p4ProvDoubDebt Is Nothing OrElse doc_p4ProvDoubDebt.IsDisposed Then
                        doc_p4ProvDoubDebt = New DockPanel
                        Dim uc As New ucPNL_p4ProvDoubDebt

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4ProvDoubDebt
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4ProvDoubDebt.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4ProvDoubDebt.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4ProvDoubDebt.Controls.Add(uc)
                        doc_p4ProvDoubDebt.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4ProvDoubDebt)
                    Else
                        doc_p4ProvDoubDebt.Visibility = DockVisibility.Visible
                        If doc_p4ProvDoubDebt.Controls.Count > 0 AndAlso TypeOf doc_p4ProvDoubDebt.Controls(0) Is ucPNL_p4ProvDoubDebt Then
                            Dim uc As ucPNL_p4ProvDoubDebt = CType(doc_p4ProvDoubDebt.Controls(0), ucPNL_p4ProvDoubDebt)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4ProvDoubDebt
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4ProvDoubDebt)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4ProvDoubDebt)
                Case 33
                    If doc_p4PreCessExp Is Nothing OrElse doc_p4PreCessExp.IsDisposed Then
                        doc_p4PreCessExp = New DockPanel
                        Dim uc As New ucPNL_p4PreCessExp

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4PreCessExp
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4PreCessExp.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4PreCessExp.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4PreCessExp.Controls.Add(uc)
                        doc_p4PreCessExp.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4PreCessExp)
                    Else
                        doc_p4PreCessExp.Visibility = DockVisibility.Visible
                        If doc_p4PreCessExp.Controls.Count > 0 AndAlso TypeOf doc_p4PreCessExp.Controls(0) Is ucPNL_p4PreCessExp Then
                            Dim uc As ucPNL_p4PreCessExp = CType(doc_p4PreCessExp.Controls(0), ucPNL_p4PreCessExp)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4PreCessExp
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4PreCessExp)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4PreCessExp)
                Case 34
                    If doc_p4CapExp Is Nothing OrElse doc_p4CapExp.IsDisposed Then
                        doc_p4CapExp = New DockPanel
                        Dim uc As New ucPNL_p4CapExp

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4CapExp
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4CapExp.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4CapExp.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4CapExp.Controls.Add(uc)
                        doc_p4CapExp.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4CapExp)
                    Else
                        doc_p4CapExp.Visibility = DockVisibility.Visible
                        If doc_p4CapExp.Controls.Count > 0 AndAlso TypeOf doc_p4CapExp.Controls(0) Is ucPNL_p4CapExp Then
                            Dim uc As ucPNL_p4CapExp = CType(doc_p4CapExp.Controls(0), ucPNL_p4CapExp)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4CapExp
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4CapExp)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4CapExp)
                Case 35
                    If doc_p4AssWritOff Is Nothing OrElse doc_p4AssWritOff.IsDisposed Then
                        doc_p4AssWritOff = New DockPanel
                        Dim uc As New ucPNL_p4AssWritOff

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p4AssWritOff
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p4AssWritOff.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p4AssWritOff.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p4AssWritOff.Controls.Add(uc)
                        doc_p4AssWritOff.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p4AssWritOff)
                    Else
                        doc_p4AssWritOff.Visibility = DockVisibility.Visible
                        If doc_p4AssWritOff.Controls.Count > 0 AndAlso TypeOf doc_p4AssWritOff.Controls(0) Is ucPNL_p4AssWritOff Then
                            Dim uc As ucPNL_p4AssWritOff = CType(doc_p4AssWritOff.Controls(0), ucPNL_p4AssWritOff)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p4AssWritOff
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p4AssWritOff)
                    End If
                    DockDocument.View.ActivateDocument(doc_p4AssWritOff)
                Case 36
                    If doc_p5MotVehUsage Is Nothing OrElse doc_p5MotVehUsage.IsDisposed Then
                        doc_p5MotVehUsage = New DockPanel
                        Dim uc As New ucPNL_p5MotVehUsage

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p5MotVehUsage
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p5MotVehUsage.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p5MotVehUsage.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p5MotVehUsage.Controls.Add(uc)
                        doc_p5MotVehUsage.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p5MotVehUsage)
                    Else
                        doc_p5MotVehUsage.Visibility = DockVisibility.Visible
                        If doc_p5MotVehUsage.Controls.Count > 0 AndAlso TypeOf doc_p5MotVehUsage.Controls(0) Is ucPNL_p5MotVehUsage Then
                            Dim uc As ucPNL_p5MotVehUsage = CType(doc_p5MotVehUsage.Controls(0), ucPNL_p5MotVehUsage)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p5MotVehUsage
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p5MotVehUsage)
                    End If
                    DockDocument.View.ActivateDocument(doc_p5MotVehUsage)
                Case 37
                    If doc_p5ResBen Is Nothing OrElse doc_p5ResBen.IsDisposed Then
                        doc_p5ResBen = New DockPanel
                        Dim uc As New ucPNL_p5ResBen

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p5ResBen
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p5ResBen.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p5ResBen.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p5ResBen.Controls.Add(uc)
                        doc_p5ResBen.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p5ResBen)
                    Else
                        doc_p5ResBen.Visibility = DockVisibility.Visible
                        If doc_p5ResBen.Controls.Count > 0 AndAlso TypeOf doc_p5ResBen.Controls(0) Is ucPNL_p5ResBen Then
                            Dim uc As ucPNL_p5ResBen = CType(doc_p5ResBen.Controls(0), ucPNL_p5ResBen)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p5ResBen
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p5ResBen)
                    End If
                    DockDocument.View.ActivateDocument(doc_p5ResBen)
                Case 38
                    If doc_p5Telephone Is Nothing OrElse doc_p5Telephone.IsDisposed Then
                        doc_p5Telephone = New DockPanel
                        Dim uc As New ucPNL_p5Telephone

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p5Telephone
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p5Telephone.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p5Telephone.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p5Telephone.Controls.Add(uc)
                        doc_p5Telephone.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p5Telephone)
                    Else
                        doc_p5Telephone.Visibility = DockVisibility.Visible
                        If doc_p5Telephone.Controls.Count > 0 AndAlso TypeOf doc_p5Telephone.Controls(0) Is ucPNL_p5Telephone Then
                            Dim uc As ucPNL_p5Telephone = CType(doc_p5Telephone.Controls(0), ucPNL_p5Telephone)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p5Telephone
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p5Telephone)
                    End If
                    DockDocument.View.ActivateDocument(doc_p5Telephone)
                Case 39
                    If doc_p5SubsNotRelBusi Is Nothing OrElse doc_p5SubsNotRelBusi.IsDisposed Then
                        doc_p5SubsNotRelBusi = New DockPanel
                        Dim uc As New ucPNL_p5SubsNotRelBusi

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p5SubsNotRelBusi
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p5SubsNotRelBusi.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p5SubsNotRelBusi.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p5SubsNotRelBusi.Controls.Add(uc)
                        doc_p5SubsNotRelBusi.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p5SubsNotRelBusi)
                    Else
                        doc_p5SubsNotRelBusi.Visibility = DockVisibility.Visible
                        If doc_p5SubsNotRelBusi.Controls.Count > 0 AndAlso TypeOf doc_p5SubsNotRelBusi.Controls(0) Is ucPNL_p5SubsNotRelBusi Then
                            Dim uc As ucPNL_p5SubsNotRelBusi = CType(doc_p5SubsNotRelBusi.Controls(0), ucPNL_p5SubsNotRelBusi)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p5SubsNotRelBusi
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p5SubsNotRelBusi)
                    End If
                    DockDocument.View.ActivateDocument(doc_p5SubsNotRelBusi)
                Case 40
                    If doc_p5Seminar Is Nothing OrElse doc_p5Seminar.IsDisposed Then
                        doc_p5Seminar = New DockPanel
                        Dim uc As New ucPNL_p5Seminar

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p5Seminar
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p5Seminar.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p5Seminar.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p5Seminar.Controls.Add(uc)
                        doc_p5Seminar.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p5Seminar)
                    Else
                        doc_p5Seminar.Visibility = DockVisibility.Visible
                        If doc_p5Seminar.Controls.Count > 0 AndAlso TypeOf doc_p5Seminar.Controls(0) Is ucPNL_p5Seminar Then
                            Dim uc As ucPNL_p5Seminar = CType(doc_p5Seminar.Controls(0), ucPNL_p5Seminar)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p5Seminar
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p5Seminar)
                    End If
                    DockDocument.View.ActivateDocument(doc_p5Seminar)
                Case 41
                    If doc_p5MedExp Is Nothing OrElse doc_p5MedExp.IsDisposed Then
                        doc_p5MedExp = New DockPanel
                        Dim uc As New ucPNL_p5MedExp

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p5MedExp
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p5MedExp.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p5MedExp.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p5MedExp.Controls.Add(uc)
                        doc_p5MedExp.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p5MedExp)
                    Else
                        doc_p5MedExp.Visibility = DockVisibility.Visible
                        If doc_p5MedExp.Controls.Count > 0 AndAlso TypeOf doc_p5MedExp.Controls(0) Is ucPNL_p5MedExp Then
                            Dim uc As ucPNL_p5MedExp = CType(doc_p5MedExp.Controls(0), ucPNL_p5MedExp)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p5MedExp
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p5MedExp)
                    End If
                    DockDocument.View.ActivateDocument(doc_p5MedExp)
                Case 42
                    If doc_p5OthNonAllowExpCha Is Nothing OrElse doc_p5OthNonAllowExpCha.IsDisposed Then
                        doc_p5OthNonAllowExpCha = New DockPanel
                        Dim uc As New ucPNL_p5OthNonAllowExpCha

                        uc.RefNo = RefNo
                        uc.YA = YA
                        uc.SourceNo = SourceNo
                        uc.DataView_Main = ds_p5OthNonAllowExpCha
                        uc.DataView_Default = dsDefault
                        uc.Dock = DockStyle.Fill
                        uc.dtParent = dtRow
                        uc.LoadData()
                        doc_p5OthNonAllowExpCha.Text = CStr(IIf(IsDBNull(dtRow("Description")), "", dtRow("Description")))
                        doc_p5OthNonAllowExpCha.Name = CStr(IIf(IsDBNull(dtRow("LabelID")), "", dtRow("LabelID")))
                        doc_p5OthNonAllowExpCha.Controls.Add(uc)
                        doc_p5OthNonAllowExpCha.Register(DockingManager)
                        doc = DockDocument.View.AddDocument(doc_p5OthNonAllowExpCha)
                    Else
                        doc_p5OthNonAllowExpCha.Visibility = DockVisibility.Visible
                        If doc_p5OthNonAllowExpCha.Controls.Count > 0 AndAlso TypeOf doc_p5OthNonAllowExpCha.Controls(0) Is ucPNL_p5OthNonAllowExpCha Then
                            Dim uc As ucPNL_p5OthNonAllowExpCha = CType(doc_p5OthNonAllowExpCha.Controls(0), ucPNL_p5OthNonAllowExpCha)
                            uc.RefNo = RefNo
                            uc.dtParent = dtRow
                            uc.YA = YA
                            uc.DataView_Main = ds_p5OthNonAllowExpCha
                            uc.DataView_Default = dsDefault
                            uc.SourceNo = SourceNo
                            uc.LoadData()
                        End If
                        doc = DockDocument.View.AddDocument(doc_p5OthNonAllowExpCha)
                    End If
                    DockDocument.View.ActivateDocument(doc_p5OthNonAllowExpCha)
            End Select
            DockDocument.EndUpdate()
            Return True
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            AddListOfError(Errorlog)
            Return True
        End Try
    End Function
    Public Function CreatePNLINFO(Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim dt As DataTable = Me.Load_PNL_INFO(Errorlog)

            dsDataset.Tables("PNL_INFO").Rows.Clear()
            If dt IsNot Nothing Then
                Dim dtRow As DataRow = Nothing
                For Each row As DataRow In dt.Rows
                    dsDataset.Tables("PNL_INFO").ImportRow(row)
                Next
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            AddListOfError(Errorlog)
            Return False
        End Try
    End Function
    Public Function PNL_SearchItem(ByVal SearchVal As String) As Boolean
        Try

            Dim OldKey As Integer = 0
            Dim tmpds As dsPNL = Nothing
            Dim dtRow As DataRow = Nothing
            Dim RowData As DataRow = Nothing
            Dim RowDataChild As DataRow = Nothing
            Dim isParent As Boolean = False
            Me.dsDataset.Tables("PNL_SEARCH").Rows.Clear()

            For Each rowInfo As DataRow In Me.dsDataset.Tables("PNL_INFO").Rows

                If IsDBNull(rowInfo("OldKey")) = False AndAlso IsNumeric(rowInfo("OldKey")) AndAlso rowInfo("OldKey") <> 0 Then

                    Select Case CInt(rowInfo("OldKey"))
                        Case 1
                            If doc_p1Sales IsNot Nothing AndAlso doc_p1Sales.Controls.Count > 0 AndAlso TypeOf doc_p1Sales.Controls(0) Is ucPNL_p1Sales Then
                                Dim uc As ucPNL_p1Sales = CType(doc_p1Sales.Controls(0), ucPNL_p1Sales)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows

                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 2
                            If doc_p1OpenStock IsNot Nothing AndAlso doc_p1OpenStock.Controls.Count > 0 AndAlso TypeOf doc_p1OpenStock.Controls(0) Is ucPNL_p1OpenStock Then
                                Dim uc As ucPNL_p1OpenStock = CType(doc_p1OpenStock.Controls(0), ucPNL_p1OpenStock)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows

                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 2
                            If doc_p1Purchase IsNot Nothing AndAlso doc_p1Purchase.Controls.Count > 0 AndAlso TypeOf doc_p1Purchase.Controls(0) Is ucPNL_p1Purchase Then
                                Dim uc As ucPNL_p1Purchase = CType(doc_p1Purchase.Controls(0), ucPNL_p1Purchase)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows

                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 43
                            If doc_p1Depreciation IsNot Nothing AndAlso doc_p1Depreciation.Controls.Count > 0 AndAlso TypeOf doc_p1Depreciation.Controls(0) Is ucPNL_p1Depreciation Then
                                Dim uc As ucPNL_p1Depreciation = CType(doc_p1Depreciation.Controls(0), ucPNL_p1Depreciation)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows

                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 44
                            If doc_p1OtherAllowableExpenses IsNot Nothing AndAlso doc_p1OtherAllowableExpenses.Controls.Count > 0 AndAlso TypeOf doc_p1OtherAllowableExpenses.Controls(0) Is ucPNL_p1OtherAllowableExpenses Then
                                Dim uc As ucPNL_p1OtherAllowableExpenses = CType(doc_p1OtherAllowableExpenses.Controls(0), ucPNL_p1OtherAllowableExpenses)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows

                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 45
                            If doc_p1NonAllowableExpenses IsNot Nothing AndAlso doc_p1NonAllowableExpenses.Controls.Count > 0 AndAlso TypeOf doc_p1NonAllowableExpenses.Controls(0) Is ucPNL_p1NonAllowableExpenses Then
                                Dim uc As ucPNL_p1NonAllowableExpenses = CType(doc_p1NonAllowableExpenses.Controls(0), ucPNL_p1NonAllowableExpenses)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows

                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 5
                            If doc_p1CloseStock IsNot Nothing AndAlso doc_p1CloseStock.Controls.Count > 0 AndAlso TypeOf doc_p1CloseStock.Controls(0) Is ucPNL_p1CloseStock Then
                                Dim uc As ucPNL_p1CloseStock = CType(doc_p1CloseStock.Controls(0), ucPNL_p1CloseStock)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 6
                            If doc_p2OtherBizIncome IsNot Nothing AndAlso doc_p2OtherBizIncome.Controls.Count > 0 AndAlso TypeOf doc_p2OtherBizIncome.Controls(0) Is ucPNL_p2OtherBizIncome Then
                                Dim uc As ucPNL_p2OtherBizIncome = CType(doc_p2OtherBizIncome.Controls(0), ucPNL_p2OtherBizIncome)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 47
                            If doc_p2DivIncome IsNot Nothing AndAlso doc_p2DivIncome.Controls.Count > 0 AndAlso TypeOf doc_p2DivIncome.Controls(0) Is ucPNL_p2DivIncome Then
                                Dim uc As ucPNL_p2DivIncome = CType(doc_p2DivIncome.Controls(0), ucPNL_p2DivIncome)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 50
                            If doc_p2InterestIncome IsNot Nothing AndAlso doc_p2InterestIncome.Controls.Count > 0 AndAlso TypeOf doc_p2InterestIncome.Controls(0) Is ucPNL_p2InterestIncome Then
                                Dim uc As ucPNL_p2InterestIncome = CType(doc_p2InterestIncome.Controls(0), ucPNL_p2InterestIncome)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 48
                            If doc_p2RentalIncome IsNot Nothing AndAlso doc_p2RentalIncome.Controls.Count > 0 AndAlso TypeOf doc_p2RentalIncome.Controls(0) Is ucPNL_p2RentalIncome Then
                                Dim uc As ucPNL_p2RentalIncome = CType(doc_p2RentalIncome.Controls(0), ucPNL_p2RentalIncome)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 49
                            If doc_p2RoyaltyIncome IsNot Nothing AndAlso doc_p2RoyaltyIncome.Controls.Count > 0 AndAlso TypeOf doc_p2RoyaltyIncome.Controls(0) Is ucPNL_p2RoyaltyIncome Then
                                Dim uc As ucPNL_p2RoyaltyIncome = CType(doc_p2RoyaltyIncome.Controls(0), ucPNL_p2RoyaltyIncome)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 51
                            If doc_p2OtherIncome IsNot Nothing AndAlso doc_p2OtherIncome.Controls.Count > 0 AndAlso TypeOf doc_p2OtherIncome.Controls(0) Is ucPNL_p2OtherIncome Then
                                Dim uc As ucPNL_p2OtherIncome = CType(doc_p2OtherIncome.Controls(0), ucPNL_p2OtherIncome)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 7
                            If doc_p2GainDispFixAss IsNot Nothing AndAlso doc_p2GainDispFixAss.Controls.Count > 0 AndAlso TypeOf doc_p2GainDispFixAss.Controls(0) Is ucPNL_p2GainDispFixAss Then
                                Dim uc As ucPNL_p2GainDispFixAss = CType(doc_p2GainDispFixAss.Controls(0), ucPNL_p2GainDispFixAss)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 8
                            If doc_p2GainForeEx IsNot Nothing AndAlso doc_p2GainForeEx.Controls.Count > 0 AndAlso TypeOf doc_p2GainForeEx.Controls(0) Is ucPNL_p2GainForeEx Then
                                Dim uc As ucPNL_p2GainForeEx = CType(doc_p2GainForeEx.Controls(0), ucPNL_p2GainForeEx)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 9
                            If doc_p2GainInv IsNot Nothing AndAlso doc_p2GainInv.Controls.Count > 0 AndAlso TypeOf doc_p2GainInv.Controls(0) Is ucPNL_p2GainInv Then
                                Dim uc As ucPNL_p2GainInv = CType(doc_p2GainInv.Controls(0), ucPNL_p2GainInv)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 10
                            If doc_p2Other IsNot Nothing AndAlso doc_p2Other.Controls.Count > 0 AndAlso TypeOf doc_p2Other.Controls(0) Is ucPNL_p2Other Then
                                Dim uc As ucPNL_p2Other = CType(doc_p2Other.Controls(0), ucPNL_p2Other)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 11
                            If doc_p3LoanInterest IsNot Nothing AndAlso doc_p3LoanInterest.Controls.Count > 0 AndAlso TypeOf doc_p3LoanInterest.Controls(0) Is ucPNL_p3LoanInterest Then
                                Dim uc As ucPNL_p3LoanInterest = CType(doc_p3LoanInterest.Controls(0), ucPNL_p3LoanInterest)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 12
                            If doc_p3SalAllowBon IsNot Nothing AndAlso doc_p3SalAllowBon.Controls.Count > 0 AndAlso TypeOf doc_p3SalAllowBon.Controls(0) Is ucPNL_p3SalAllowBon Then
                                Dim uc As ucPNL_p3SalAllowBon = CType(doc_p3SalAllowBon.Controls(0), ucPNL_p3SalAllowBon)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 13
                            If doc_p3RentMort IsNot Nothing AndAlso doc_p3RentMort.Controls.Count > 0 AndAlso TypeOf doc_p3RentMort.Controls(0) Is ucPNL_p3RentMort Then
                                Dim uc As ucPNL_p3RentMort = CType(doc_p3RentMort.Controls(0), ucPNL_p3RentMort)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 14
                            If doc_p3ContSubCont IsNot Nothing AndAlso doc_p3ContSubCont.Controls.Count > 0 AndAlso TypeOf doc_p3ContSubCont.Controls(0) Is ucPNL_p3ContSubCont Then
                                Dim uc As ucPNL_p3ContSubCont = CType(doc_p3ContSubCont.Controls(0), ucPNL_p3ContSubCont)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 15
                            If doc_p3Commission IsNot Nothing AndAlso doc_p3Commission.Controls.Count > 0 AndAlso TypeOf doc_p3Commission.Controls(0) Is ucPNL_p3Commission Then
                                Dim uc As ucPNL_p3Commission = CType(doc_p3Commission.Controls(0), ucPNL_p3Commission)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 16
                            If doc_p3BadDebts IsNot Nothing AndAlso doc_p3BadDebts.Controls.Count > 0 AndAlso TypeOf doc_p3BadDebts.Controls(0) Is ucPNL_p3BadDebts Then
                                Dim uc As ucPNL_p3BadDebts = CType(doc_p3BadDebts.Controls(0), ucPNL_p3BadDebts)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 17
                            If doc_p3TravTransAccom IsNot Nothing AndAlso doc_p3TravTransAccom.Controls.Count > 0 AndAlso TypeOf doc_p3TravTransAccom.Controls(0) Is ucPNL_p3TravTransAccom Then
                                Dim uc As ucPNL_p3TravTransAccom = CType(doc_p3TravTransAccom.Controls(0), ucPNL_p3TravTransAccom)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 52
                            If doc_p3RepairMaint IsNot Nothing AndAlso doc_p3RepairMaint.Controls.Count > 0 AndAlso TypeOf doc_p3RepairMaint.Controls(0) Is ucPNL_p3RepairMaint Then
                                Dim uc As ucPNL_p3RepairMaint = CType(doc_p3RepairMaint.Controls(0), ucPNL_p3RepairMaint)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 53
                            If doc_p3PromAdv IsNot Nothing AndAlso doc_p3PromAdv.Controls.Count > 0 AndAlso TypeOf doc_p3PromAdv.Controls(0) Is ucPNL_p3PromAdv Then
                                Dim uc As ucPNL_p3PromAdv = CType(doc_p3PromAdv.Controls(0), ucPNL_p3PromAdv)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 54
                            If doc_p3InpTaxNotClaimJKDM IsNot Nothing AndAlso doc_p3InpTaxNotClaimJKDM.Controls.Count > 0 AndAlso TypeOf doc_p3InpTaxNotClaimJKDM.Controls(0) Is ucPNL_p3InpTaxNotClaimJKDM Then
                                Dim uc As ucPNL_p3InpTaxNotClaimJKDM = CType(doc_p3InpTaxNotClaimJKDM.Controls(0), ucPNL_p3InpTaxNotClaimJKDM)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 18
                            If doc_p3EPFPersonal IsNot Nothing AndAlso doc_p3EPFPersonal.Controls.Count > 0 AndAlso TypeOf doc_p3EPFPersonal.Controls(0) Is ucPNL_p3EPFPersonal Then
                                Dim uc As ucPNL_p3EPFPersonal = CType(doc_p3EPFPersonal.Controls(0), ucPNL_p3EPFPersonal)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 19
                            If doc_p3EPFStaff IsNot Nothing AndAlso doc_p3EPFStaff.Controls.Count > 0 AndAlso TypeOf doc_p3EPFStaff.Controls(0) Is ucPNL_p3EPFStaff Then
                                Dim uc As ucPNL_p3EPFStaff = CType(doc_p3EPFStaff.Controls(0), ucPNL_p3EPFStaff)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 20
                            If doc_p3LegalFee IsNot Nothing AndAlso doc_p3LegalFee.Controls.Count > 0 AndAlso TypeOf doc_p3LegalFee.Controls(0) Is ucPNL_p3LegalFee Then
                                Dim uc As ucPNL_p3LegalFee = CType(doc_p3LegalFee.Controls(0), ucPNL_p3LegalFee)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 46
                            If doc_p3OthExpenses IsNot Nothing AndAlso doc_p3OthExpenses.Controls.Count > 0 AndAlso TypeOf doc_p3OthExpenses.Controls(0) Is ucPNL_p3OthExpenses Then
                                Dim uc As ucPNL_p3OthExpenses = CType(doc_p3OthExpenses.Controls(0), ucPNL_p3OthExpenses)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 21
                            If doc_p4LossDispFixAss IsNot Nothing AndAlso doc_p4LossDispFixAss.Controls.Count > 0 AndAlso TypeOf doc_p4LossDispFixAss.Controls(0) Is ucPNL_p4LossDispFixAss Then
                                Dim uc As ucPNL_p4LossDispFixAss = CType(doc_p4LossDispFixAss.Controls(0), ucPNL_p4LossDispFixAss)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 22
                            If doc_p4LossForeExch IsNot Nothing AndAlso doc_p4LossForeExch.Controls.Count > 0 AndAlso TypeOf doc_p4LossForeExch.Controls(0) Is ucPNL_p4LossForeExch Then
                                Dim uc As ucPNL_p4LossForeExch = CType(doc_p4LossForeExch.Controls(0), ucPNL_p4LossForeExch)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 23
                            If doc_p4LossInv IsNot Nothing AndAlso doc_p4LossInv.Controls.Count > 0 AndAlso TypeOf doc_p4LossInv.Controls(0) Is ucPNL_p4LossInv Then
                                Dim uc As ucPNL_p4LossInv = CType(doc_p4LossInv.Controls(0), ucPNL_p4LossInv)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 24
                            If doc_p4Others IsNot Nothing AndAlso doc_p4Others.Controls.Count > 0 AndAlso TypeOf doc_p4Others.Controls(0) Is ucPNL_p4Others Then
                                Dim uc As ucPNL_p4Others = CType(doc_p4Others.Controls(0), ucPNL_p4Others)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 25
                            If doc_p4Depreciation IsNot Nothing AndAlso doc_p4Depreciation.Controls.Count > 0 AndAlso TypeOf doc_p4Depreciation.Controls(0) Is ucPNL_p4Depreciation Then
                                Dim uc As ucPNL_p4Depreciation = CType(doc_p4Depreciation.Controls(0), ucPNL_p4Depreciation)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 26
                            If doc_p4Entertainment IsNot Nothing AndAlso doc_p4Entertainment.Controls.Count > 0 AndAlso TypeOf doc_p4Entertainment.Controls(0) Is ucPNL_p4Entertainment Then
                                Dim uc As ucPNL_p4Entertainment = CType(doc_p4Entertainment.Controls(0), ucPNL_p4Entertainment)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 27
                            If doc_p4Gift IsNot Nothing AndAlso doc_p4Gift.Controls.Count > 0 AndAlso TypeOf doc_p4Gift.Controls(0) Is ucPNL_p4Gift Then
                                Dim uc As ucPNL_p4Gift = CType(doc_p4Gift.Controls(0), ucPNL_p4Gift)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 28
                            If doc_p4Donation IsNot Nothing AndAlso doc_p4Donation.Controls.Count > 0 AndAlso TypeOf doc_p4Donation.Controls(0) Is ucPNL_p4Donation Then
                                Dim uc As ucPNL_p4Donation = CType(doc_p4Donation.Controls(0), ucPNL_p4Donation)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 29
                            If doc_p4PenFineComp IsNot Nothing AndAlso doc_p4PenFineComp.Controls.Count > 0 AndAlso TypeOf doc_p4PenFineComp.Controls(0) Is ucPNL_p4PenFineComp Then
                                Dim uc As ucPNL_p4PenFineComp = CType(doc_p4PenFineComp.Controls(0), ucPNL_p4PenFineComp)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 30
                            If doc_p4DrawingPLStock IsNot Nothing AndAlso doc_p4DrawingPLStock.Controls.Count > 0 AndAlso TypeOf doc_p4DrawingPLStock.Controls(0) Is ucPNL_p4DrawingPLStock Then
                                Dim uc As ucPNL_p4DrawingPLStock = CType(doc_p4DrawingPLStock.Controls(0), ucPNL_p4DrawingPLStock)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 31
                            If doc_p4DrawingPLCash IsNot Nothing AndAlso doc_p4DrawingPLCash.Controls.Count > 0 AndAlso TypeOf doc_p4DrawingPLCash.Controls(0) Is ucPNL_p4DrawingPLCash Then
                                Dim uc As ucPNL_p4DrawingPLCash = CType(doc_p4DrawingPLCash.Controls(0), ucPNL_p4DrawingPLCash)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 32
                            If doc_p4ProvDoubDebt IsNot Nothing AndAlso doc_p4ProvDoubDebt.Controls.Count > 0 AndAlso TypeOf doc_p4ProvDoubDebt.Controls(0) Is ucPNL_p4ProvDoubDebt Then
                                Dim uc As ucPNL_p4ProvDoubDebt = CType(doc_p4ProvDoubDebt.Controls(0), ucPNL_p4ProvDoubDebt)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 33
                            If doc_p4PreCessExp IsNot Nothing AndAlso doc_p4PreCessExp.Controls.Count > 0 AndAlso TypeOf doc_p4PreCessExp.Controls(0) Is ucPNL_p4PreCessExp Then
                                Dim uc As ucPNL_p4PreCessExp = CType(doc_p4PreCessExp.Controls(0), ucPNL_p4PreCessExp)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 34
                            If doc_p4CapExp IsNot Nothing AndAlso doc_p4CapExp.Controls.Count > 0 AndAlso TypeOf doc_p4CapExp.Controls(0) Is ucPNL_p4CapExp Then
                                Dim uc As ucPNL_p4CapExp = CType(doc_p4CapExp.Controls(0), ucPNL_p4CapExp)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 35
                            If doc_p4AssWritOff IsNot Nothing AndAlso doc_p4AssWritOff.Controls.Count > 0 AndAlso TypeOf doc_p4AssWritOff.Controls(0) Is ucPNL_p4AssWritOff Then
                                Dim uc As ucPNL_p4AssWritOff = CType(doc_p4AssWritOff.Controls(0), ucPNL_p4AssWritOff)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 36
                            If doc_p5MotVehUsage IsNot Nothing AndAlso doc_p5MotVehUsage.Controls.Count > 0 AndAlso TypeOf doc_p5MotVehUsage.Controls(0) Is ucPNL_p5MotVehUsage Then
                                Dim uc As ucPNL_p5MotVehUsage = CType(doc_p5MotVehUsage.Controls(0), ucPNL_p5MotVehUsage)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 37
                            If doc_p5ResBen IsNot Nothing AndAlso doc_p5ResBen.Controls.Count > 0 AndAlso TypeOf doc_p5ResBen.Controls(0) Is ucPNL_p5ResBen Then
                                Dim uc As ucPNL_p5ResBen = CType(doc_p5ResBen.Controls(0), ucPNL_p5ResBen)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 38
                            If doc_p5Telephone IsNot Nothing AndAlso doc_p5Telephone.Controls.Count > 0 AndAlso TypeOf doc_p5Telephone.Controls(0) Is ucPNL_p5Telephone Then
                                Dim uc As ucPNL_p5Telephone = CType(doc_p5Telephone.Controls(0), ucPNL_p5Telephone)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 39
                            If doc_p5SubsNotRelBusi IsNot Nothing AndAlso doc_p5SubsNotRelBusi.Controls.Count > 0 AndAlso TypeOf doc_p5SubsNotRelBusi.Controls(0) Is ucPNL_p5SubsNotRelBusi Then
                                Dim uc As ucPNL_p5SubsNotRelBusi = CType(doc_p5SubsNotRelBusi.Controls(0), ucPNL_p5SubsNotRelBusi)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 40
                            If doc_p5Seminar IsNot Nothing AndAlso doc_p5Seminar.Controls.Count > 0 AndAlso TypeOf doc_p5Seminar.Controls(0) Is ucPNL_p5Seminar Then
                                Dim uc As ucPNL_p5Seminar = CType(doc_p5Seminar.Controls(0), ucPNL_p5Seminar)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 41
                            If doc_p5MedExp IsNot Nothing AndAlso doc_p5MedExp.Controls.Count > 0 AndAlso TypeOf doc_p5MedExp.Controls(0) Is ucPNL_p5MedExp Then
                                Dim uc As ucPNL_p5MedExp = CType(doc_p5MedExp.Controls(0), ucPNL_p5MedExp)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                        Case 42
                            If doc_p5OthNonAllowExpCha IsNot Nothing AndAlso doc_p5OthNonAllowExpCha.Controls.Count > 0 AndAlso TypeOf doc_p5OthNonAllowExpCha.Controls(0) Is ucPNL_p5OthNonAllowExpCha Then
                                Dim uc As ucPNL_p5OthNonAllowExpCha = CType(doc_p5OthNonAllowExpCha.Controls(0), ucPNL_p5OthNonAllowExpCha)
                                tmpds = uc.DataView_Main

                                If tmpds IsNot Nothing AndAlso tmpds.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    For Each rowMain As DataRow In tmpds.Tables(rowInfo("TableName")).Rows

                                        If rowMain(rowInfo("PrefixName") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = True
                                            RowData = rowMain
                                        End If

                                    Next

                                    For Each rowChild As DataRow In tmpds.Tables(rowInfo("TableName_Details")).Rows
                                        If rowChild(rowInfo("PrefixName_Details") & "_DESC").ToString.ToUpper.Contains(SearchVal.ToUpper) Then
                                            isParent = False
                                            RowDataChild = rowChild
                                        End If
                                    Next
                                End If

                            End If
                    End Select

                    If RowData IsNot Nothing OrElse RowDataChild IsNot Nothing Then
                        If isParent Then
                            dtRow = Nothing
                            dtRow = Me.dsDataset.Tables("PNL_SEARCH").NewRow
                            dtRow("Description") = RowData(rowInfo("PrefixName") & "_DESC")
                            dtRow("Amount") = RowData(rowInfo("ColumnAmount"))
                            dtRow("OldKey") = CInt(rowInfo("OldKey"))
                            dtRow("Title") = rowInfo("Description")
                            Me.dsDataset.Tables("PNL_SEARCH").Rows.Add(dtRow)
                        Else
                            dtRow = Nothing
                            dtRow = Me.dsDataset.Tables("PNL_SEARCH").NewRow
                            dtRow("Description") = RowDataChild(rowInfo("PrefixName_Details") & "_DESC")
                            dtRow("Amount") = RowDataChild(rowInfo("ColumnAmount_Details"))
                            dtRow("OldKey") = CInt(rowInfo("OldKey"))
                            dtRow("Title") = rowInfo("Description")
                            Me.dsDataset.Tables("PNL_SEARCH").Rows.Add(dtRow)
                        End If
                    End If
                    RowData = Nothing
                    RowDataChild = Nothing
                End If

            Next
            Return True
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            Return False
        End Try
    End Function
    Public Function GetPNLData_FromItem(ByVal tmpID As Integer, ByRef ProgressBar As DevExpress.XtraBars.BarEditItem, _
                                        ByRef txtProgress As DevExpress.XtraBars.BarStaticItem, ByVal RefNO As String, ByVal YA As String, _
                                        ByVal TaxPayerInfo As DataRow, ByVal SourceInfo As DataRow, ByRef ListofSQLCmd As List(Of SqlCommand)) As Boolean
        Try
            If ListofSQLCmd Is Nothing Then
                ListofSQLCmd = New List(Of SqlCommand)
            End If
            Dim tmpDataset As dsPNL = Nothing
            Dim CurrCount As Integer = 0
            Dim dtRow As DataRow = Nothing
            For Each rowInfo As DataRow In Me.dsDataset.Tables("PNL_INFO").Rows
                If IsDBNull(rowInfo("OldKey")) = False AndAlso IsNumeric(rowInfo("OldKey")) AndAlso rowInfo("OldKey") <> 0 Then
                    CurrCount += 1
                    Select Case CInt(rowInfo("OldKey"))
                        Case 1
                            If doc_p1Sales IsNot Nothing AndAlso doc_p1Sales.Controls.Count > 0 AndAlso TypeOf doc_p1Sales.Controls(0) Is ucPNL_p1Sales Then
                                Dim uc As ucPNL_p1Sales = CType(doc_p1Sales.Controls(0), ucPNL_p1Sales)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 2
                            If doc_p1OpenStock IsNot Nothing AndAlso doc_p1OpenStock.Controls.Count > 0 AndAlso TypeOf doc_p1OpenStock.Controls(0) Is ucPNL_p1OpenStock Then
                                Dim uc As ucPNL_p1OpenStock = CType(doc_p1OpenStock.Controls(0), ucPNL_p1OpenStock)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 3
                            If doc_p1Purchase IsNot Nothing AndAlso doc_p1Purchase.Controls.Count > 0 AndAlso TypeOf doc_p1Purchase.Controls(0) Is ucPNL_p1Purchase Then
                                Dim uc As ucPNL_p1Purchase = CType(doc_p1Purchase.Controls(0), ucPNL_p1Purchase)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 43
                            If doc_p1Depreciation IsNot Nothing AndAlso doc_p1Depreciation.Controls.Count > 0 AndAlso TypeOf doc_p1Depreciation.Controls(0) Is ucPNL_p1Depreciation Then
                                Dim uc As ucPNL_p1Depreciation = CType(doc_p1Depreciation.Controls(0), ucPNL_p1Depreciation)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 44
                            If doc_p1OtherAllowableExpenses IsNot Nothing AndAlso doc_p1OtherAllowableExpenses.Controls.Count > 0 AndAlso TypeOf doc_p1OtherAllowableExpenses.Controls(0) Is ucPNL_p1OtherAllowableExpenses Then
                                Dim uc As ucPNL_p1OtherAllowableExpenses = CType(doc_p1OtherAllowableExpenses.Controls(0), ucPNL_p1OtherAllowableExpenses)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 45
                            If doc_p1NonAllowableExpenses IsNot Nothing AndAlso doc_p1NonAllowableExpenses.Controls.Count > 0 AndAlso TypeOf doc_p1NonAllowableExpenses.Controls(0) Is ucPNL_p1NonAllowableExpenses Then
                                Dim uc As ucPNL_p1NonAllowableExpenses = CType(doc_p1NonAllowableExpenses.Controls(0), ucPNL_p1NonAllowableExpenses)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 5
                            If doc_p1CloseStock IsNot Nothing AndAlso doc_p1CloseStock.Controls.Count > 0 AndAlso TypeOf doc_p1CloseStock.Controls(0) Is ucPNL_p1CloseStock Then
                                Dim uc As ucPNL_p1CloseStock = CType(doc_p1CloseStock.Controls(0), ucPNL_p1CloseStock)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 6
                            If doc_p2OtherBizIncome IsNot Nothing AndAlso doc_p2OtherBizIncome.Controls.Count > 0 AndAlso TypeOf doc_p2OtherBizIncome.Controls(0) Is ucPNL_p2OtherBizIncome Then
                                Dim uc As ucPNL_p2OtherBizIncome = CType(doc_p2OtherBizIncome.Controls(0), ucPNL_p2OtherBizIncome)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 47
                            If doc_p2DivIncome IsNot Nothing AndAlso doc_p2DivIncome.Controls.Count > 0 AndAlso TypeOf doc_p2DivIncome.Controls(0) Is ucPNL_p2DivIncome Then
                                Dim uc As ucPNL_p2DivIncome = CType(doc_p2DivIncome.Controls(0), ucPNL_p2DivIncome)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 48
                            If doc_p2RentalIncome IsNot Nothing AndAlso doc_p2RentalIncome.Controls.Count > 0 AndAlso TypeOf doc_p2RentalIncome.Controls(0) Is ucPNL_p2RentalIncome Then
                                Dim uc As ucPNL_p2RentalIncome = CType(doc_p2RentalIncome.Controls(0), ucPNL_p2RentalIncome)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 49
                            If doc_p2RoyaltyIncome IsNot Nothing AndAlso doc_p2RoyaltyIncome.Controls.Count > 0 AndAlso TypeOf doc_p2RoyaltyIncome.Controls(0) Is ucPNL_p2RoyaltyIncome Then
                                Dim uc As ucPNL_p2RoyaltyIncome = CType(doc_p2RoyaltyIncome.Controls(0), ucPNL_p2RoyaltyIncome)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '=======================================================================================================
                        Case 50
                            If doc_p2InterestIncome IsNot Nothing AndAlso doc_p2InterestIncome.Controls.Count > 0 AndAlso TypeOf doc_p2InterestIncome.Controls(0) Is ucPNL_p2InterestIncome Then
                                Dim uc As ucPNL_p2InterestIncome = CType(doc_p2InterestIncome.Controls(0), ucPNL_p2InterestIncome)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 51
                            If doc_p2OtherIncome IsNot Nothing AndAlso doc_p2OtherIncome.Controls.Count > 0 AndAlso TypeOf doc_p2OtherIncome.Controls(0) Is ucPNL_p2OtherIncome Then
                                Dim uc As ucPNL_p2OtherIncome = CType(doc_p2OtherIncome.Controls(0), ucPNL_p2OtherIncome)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 7
                            If doc_p2GainDispFixAss IsNot Nothing AndAlso doc_p2GainDispFixAss.Controls.Count > 0 AndAlso TypeOf doc_p2GainDispFixAss.Controls(0) Is ucPNL_p2GainDispFixAss Then
                                Dim uc As ucPNL_p2GainDispFixAss = CType(doc_p2GainDispFixAss.Controls(0), ucPNL_p2GainDispFixAss)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)

                                    If IsDBNull(rowInfo("Amount")) = False AndAlso IsNumeric(rowInfo("Amount")) AndAlso rowInfo("Amount") > 0 AndAlso
                                        TaxPayerInfo IsNot Nothing AndAlso SourceInfo IsNot Nothing Then
                                        clsPNL_.Delete_NonTaxableIncome(IIf(IsDBNull(TaxPayerInfo("TP_REF_NO_PREFIX")), "", TaxPayerInfo("TP_REF_NO_PREFIX")), RefNO, YA, _
                                                                        IIf(IsDBNull(TaxPayerInfo("BC_BUSINESSSOURCE")), "", TaxPayerInfo("BC_BUSINESSSOURCE")), rowInfo("OldKey"), ListofSQLCmd)

                                        tmpDataset.Tables("INCOME_ADJ_NON_TAXABLE_INCOME").Rows.Clear()

                                        dtRow = Nothing
                                        dtRow = tmpDataset.Tables("INCOME_ADJ_NON_TAXABLE_INCOME").NewRow
                                        dtRow("NT_KEY") = Me.GETNONTAXABLEKEY() + 1
                                        dtRow("NT_PREFIT") = IIf(IsDBNull(TaxPayerInfo("TP_REF_NO_PREFIX")), "", TaxPayerInfo("TP_REF_NO_PREFIX"))
                                        dtRow("NT_REF_NO") = RefNO
                                        dtRow("NT_YA") = YA
                                        dtRow("NT_DESC") = rowInfo("Description")
                                        dtRow("NT_AMOUNT") = rowInfo("Amount")
                                        dtRow("NT_CATEGORIZED") = "PNL"
                                        dtRow("NT_SOURCE") = IIf(IsDBNull(TaxPayerInfo("BC_BUSINESSSOURCE")), "", TaxPayerInfo("BC_BUSINESSSOURCE"))
                                        dtRow("NT_1") = IIf(IsDBNull(TaxPayerInfo("BC_COMPANY")), "", TaxPayerInfo("BC_COMPANY"))
                                        dtRow("NT_2") = rowInfo("OldKey")
                                        dtRow("NT_3") = rowInfo("Description")
                                        tmpDataset.Tables("INCOME_ADJ_NON_TAXABLE_INCOME").Rows.Add(dtRow)

                                        Me.InsertSQLScriptPNL(tmpDataset.Tables("INCOME_ADJ_NON_TAXABLE_INCOME"), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)
                                    End If

                                End If
                            End If
                            '========================================================================================================
                        Case 8
                            If doc_p2GainForeEx IsNot Nothing AndAlso doc_p2GainForeEx.Controls.Count > 0 AndAlso TypeOf doc_p2GainForeEx.Controls(0) Is ucPNL_p2GainForeEx Then
                                Dim uc As ucPNL_p2GainForeEx = CType(doc_p2GainForeEx.Controls(0), ucPNL_p2GainForeEx)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)

                                   
                                End If
                            End If
                            '========================================================================================================
                        Case 9
                            If doc_p2GainInv IsNot Nothing AndAlso doc_p2GainInv.Controls.Count > 0 AndAlso TypeOf doc_p2GainInv.Controls(0) Is ucPNL_p2GainInv Then
                                Dim uc As ucPNL_p2GainInv = CType(doc_p2GainInv.Controls(0), ucPNL_p2GainInv)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 10
                            If doc_p2Other IsNot Nothing AndAlso doc_p2Other.Controls.Count > 0 AndAlso TypeOf doc_p2Other.Controls(0) Is ucPNL_p2Other Then
                                Dim uc As ucPNL_p2Other = CType(doc_p2Other.Controls(0), ucPNL_p2Other)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 11
                            If doc_p3LoanInterest IsNot Nothing AndAlso doc_p3LoanInterest.Controls.Count > 0 AndAlso TypeOf doc_p3LoanInterest.Controls(0) Is ucPNL_p3LoanInterest Then
                                Dim uc As ucPNL_p3LoanInterest = CType(doc_p3LoanInterest.Controls(0), ucPNL_p3LoanInterest)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 12
                            If doc_p3SalAllowBon IsNot Nothing AndAlso doc_p3SalAllowBon.Controls.Count > 0 AndAlso TypeOf doc_p3SalAllowBon.Controls(0) Is ucPNL_p3SalAllowBon Then
                                Dim uc As ucPNL_p3SalAllowBon = CType(doc_p3SalAllowBon.Controls(0), ucPNL_p3SalAllowBon)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 13
                            If doc_p3RentMort IsNot Nothing AndAlso doc_p3RentMort.Controls.Count > 0 AndAlso TypeOf doc_p3RentMort.Controls(0) Is ucPNL_p3RentMort Then
                                Dim uc As ucPNL_p3RentMort = CType(doc_p3RentMort.Controls(0), ucPNL_p3RentMort)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 14
                            If doc_p3ContSubCont IsNot Nothing AndAlso doc_p3ContSubCont.Controls.Count > 0 AndAlso TypeOf doc_p3ContSubCont.Controls(0) Is ucPNL_p3ContSubCont Then
                                Dim uc As ucPNL_p3ContSubCont = CType(doc_p3ContSubCont.Controls(0), ucPNL_p3ContSubCont)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 15
                            If doc_p3Commission IsNot Nothing AndAlso doc_p3Commission.Controls.Count > 0 AndAlso TypeOf doc_p3Commission.Controls(0) Is ucPNL_p3Commission Then
                                Dim uc As ucPNL_p3Commission = CType(doc_p3Commission.Controls(0), ucPNL_p3Commission)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 16
                            If doc_p3BadDebts IsNot Nothing AndAlso doc_p3BadDebts.Controls.Count > 0 AndAlso TypeOf doc_p3BadDebts.Controls(0) Is ucPNL_p3BadDebts Then
                                Dim uc As ucPNL_p3BadDebts = CType(doc_p3BadDebts.Controls(0), ucPNL_p3BadDebts)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 17
                            If doc_p3TravTransAccom IsNot Nothing AndAlso doc_p3TravTransAccom.Controls.Count > 0 AndAlso TypeOf doc_p3TravTransAccom.Controls(0) Is ucPNL_p3TravTransAccom Then
                                Dim uc As ucPNL_p3TravTransAccom = CType(doc_p3TravTransAccom.Controls(0), ucPNL_p3TravTransAccom)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 52
                            If doc_p3RepairMaint IsNot Nothing AndAlso doc_p3RepairMaint.Controls.Count > 0 AndAlso TypeOf doc_p3RepairMaint.Controls(0) Is ucPNL_p3RepairMaint Then
                                Dim uc As ucPNL_p3RepairMaint = CType(doc_p3RepairMaint.Controls(0), ucPNL_p3RepairMaint)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 53
                            If doc_p3PromAdv IsNot Nothing AndAlso doc_p3PromAdv.Controls.Count > 0 AndAlso TypeOf doc_p3PromAdv.Controls(0) Is ucPNL_p3PromAdv Then
                                Dim uc As ucPNL_p3PromAdv = CType(doc_p3PromAdv.Controls(0), ucPNL_p3PromAdv)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 54
                            If doc_p3InpTaxNotClaimJKDM IsNot Nothing AndAlso doc_p3InpTaxNotClaimJKDM.Controls.Count > 0 AndAlso TypeOf doc_p3InpTaxNotClaimJKDM.Controls(0) Is ucPNL_p3InpTaxNotClaimJKDM Then
                                Dim uc As ucPNL_p3InpTaxNotClaimJKDM = CType(doc_p3InpTaxNotClaimJKDM.Controls(0), ucPNL_p3InpTaxNotClaimJKDM)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 18
                            If doc_p3EPFPersonal IsNot Nothing AndAlso doc_p3EPFPersonal.Controls.Count > 0 AndAlso TypeOf doc_p3EPFPersonal.Controls(0) Is ucPNL_p3EPFPersonal Then
                                Dim uc As ucPNL_p3EPFPersonal = CType(doc_p3EPFPersonal.Controls(0), ucPNL_p3EPFPersonal)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 19
                            If doc_p3EPFStaff IsNot Nothing AndAlso doc_p3EPFStaff.Controls.Count > 0 AndAlso TypeOf doc_p3EPFStaff.Controls(0) Is ucPNL_p3EPFStaff Then
                                Dim uc As ucPNL_p3EPFStaff = CType(doc_p3EPFStaff.Controls(0), ucPNL_p3EPFStaff)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 20
                            If doc_p3LegalFee IsNot Nothing AndAlso doc_p3LegalFee.Controls.Count > 0 AndAlso TypeOf doc_p3LegalFee.Controls(0) Is ucPNL_p3LegalFee Then
                                Dim uc As ucPNL_p3LegalFee = CType(doc_p3LegalFee.Controls(0), ucPNL_p3LegalFee)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 46
                            If doc_p3OthExpenses IsNot Nothing AndAlso doc_p3OthExpenses.Controls.Count > 0 AndAlso TypeOf doc_p3OthExpenses.Controls(0) Is ucPNL_p3OthExpenses Then
                                Dim uc As ucPNL_p3OthExpenses = CType(doc_p3OthExpenses.Controls(0), ucPNL_p3OthExpenses)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 21
                            If doc_p4LossDispFixAss IsNot Nothing AndAlso doc_p4LossDispFixAss.Controls.Count > 0 AndAlso TypeOf doc_p4LossDispFixAss.Controls(0) Is ucPNL_p4LossDispFixAss Then
                                Dim uc As ucPNL_p4LossDispFixAss = CType(doc_p4LossDispFixAss.Controls(0), ucPNL_p4LossDispFixAss)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 22
                            If doc_p4LossForeExch IsNot Nothing AndAlso doc_p4LossForeExch.Controls.Count > 0 AndAlso TypeOf doc_p4LossForeExch.Controls(0) Is ucPNL_p4LossForeExch Then
                                Dim uc As ucPNL_p4LossForeExch = CType(doc_p4LossForeExch.Controls(0), ucPNL_p4LossForeExch)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 23
                            If doc_p4LossInv IsNot Nothing AndAlso doc_p4LossInv.Controls.Count > 0 AndAlso TypeOf doc_p4LossInv.Controls(0) Is ucPNL_p4LossInv Then
                                Dim uc As ucPNL_p4LossInv = CType(doc_p4LossInv.Controls(0), ucPNL_p4LossInv)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 24
                            If doc_p4Others IsNot Nothing AndAlso doc_p4Others.Controls.Count > 0 AndAlso TypeOf doc_p4Others.Controls(0) Is ucPNL_p4Others Then
                                Dim uc As ucPNL_p4Others = CType(doc_p4Others.Controls(0), ucPNL_p4Others)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 25
                            If doc_p4Depreciation IsNot Nothing AndAlso doc_p4Depreciation.Controls.Count > 0 AndAlso TypeOf doc_p4Depreciation.Controls(0) Is ucPNL_p4Depreciation Then
                                Dim uc As ucPNL_p4Depreciation = CType(doc_p4Depreciation.Controls(0), ucPNL_p4Depreciation)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 26
                            If doc_p4Entertainment IsNot Nothing AndAlso doc_p4Entertainment.Controls.Count > 0 AndAlso TypeOf doc_p4Entertainment.Controls(0) Is ucPNL_p4Entertainment Then
                                Dim uc As ucPNL_p4Entertainment = CType(doc_p4Entertainment.Controls(0), ucPNL_p4Entertainment)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 27
                            If doc_p4Gift IsNot Nothing AndAlso doc_p4Gift.Controls.Count > 0 AndAlso TypeOf doc_p4Gift.Controls(0) Is ucPNL_p4Gift Then
                                Dim uc As ucPNL_p4Gift = CType(doc_p4Gift.Controls(0), ucPNL_p4Gift)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 28
                            If doc_p4Donation IsNot Nothing AndAlso doc_p4Donation.Controls.Count > 0 AndAlso TypeOf doc_p4Donation.Controls(0) Is ucPNL_p4Donation Then
                                Dim uc As ucPNL_p4Donation = CType(doc_p4Donation.Controls(0), ucPNL_p4Donation)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 29
                            If doc_p4PenFineComp IsNot Nothing AndAlso doc_p4PenFineComp.Controls.Count > 0 AndAlso TypeOf doc_p4PenFineComp.Controls(0) Is ucPNL_p4PenFineComp Then
                                Dim uc As ucPNL_p4PenFineComp = CType(doc_p4PenFineComp.Controls(0), ucPNL_p4PenFineComp)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 30
                            If doc_p4DrawingPLStock IsNot Nothing AndAlso doc_p4DrawingPLStock.Controls.Count > 0 AndAlso TypeOf doc_p4DrawingPLStock.Controls(0) Is ucPNL_p4DrawingPLStock Then
                                Dim uc As ucPNL_p4DrawingPLStock = CType(doc_p4DrawingPLStock.Controls(0), ucPNL_p4DrawingPLStock)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 31
                            If doc_p4DrawingPLCash IsNot Nothing AndAlso doc_p4DrawingPLCash.Controls.Count > 0 AndAlso TypeOf doc_p4DrawingPLCash.Controls(0) Is ucPNL_p4DrawingPLCash Then
                                Dim uc As ucPNL_p4DrawingPLCash = CType(doc_p4DrawingPLCash.Controls(0), ucPNL_p4DrawingPLCash)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 32
                            If doc_p4ProvDoubDebt IsNot Nothing AndAlso doc_p4ProvDoubDebt.Controls.Count > 0 AndAlso TypeOf doc_p4ProvDoubDebt.Controls(0) Is ucPNL_p4ProvDoubDebt Then
                                Dim uc As ucPNL_p4ProvDoubDebt = CType(doc_p4ProvDoubDebt.Controls(0), ucPNL_p4ProvDoubDebt)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 33
                            If doc_p4PreCessExp IsNot Nothing AndAlso doc_p4PreCessExp.Controls.Count > 0 AndAlso TypeOf doc_p4PreCessExp.Controls(0) Is ucPNL_p4PreCessExp Then
                                Dim uc As ucPNL_p4PreCessExp = CType(doc_p4PreCessExp.Controls(0), ucPNL_p4PreCessExp)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 34
                            If doc_p4CapExp IsNot Nothing AndAlso doc_p4CapExp.Controls.Count > 0 AndAlso TypeOf doc_p4CapExp.Controls(0) Is ucPNL_p4CapExp Then
                                Dim uc As ucPNL_p4CapExp = CType(doc_p4CapExp.Controls(0), ucPNL_p4CapExp)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 35
                            If doc_p4AssWritOff IsNot Nothing AndAlso doc_p4AssWritOff.Controls.Count > 0 AndAlso TypeOf doc_p4AssWritOff.Controls(0) Is ucPNL_p4AssWritOff Then
                                Dim uc As ucPNL_p4AssWritOff = CType(doc_p4AssWritOff.Controls(0), ucPNL_p4AssWritOff)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 36
                            If doc_p5MotVehUsage IsNot Nothing AndAlso doc_p5MotVehUsage.Controls.Count > 0 AndAlso TypeOf doc_p5MotVehUsage.Controls(0) Is ucPNL_p5MotVehUsage Then
                                Dim uc As ucPNL_p5MotVehUsage = CType(doc_p5MotVehUsage.Controls(0), ucPNL_p5MotVehUsage)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 37
                            If doc_p5ResBen IsNot Nothing AndAlso doc_p5ResBen.Controls.Count > 0 AndAlso TypeOf doc_p5ResBen.Controls(0) Is ucPNL_p5ResBen Then
                                Dim uc As ucPNL_p5ResBen = CType(doc_p5ResBen.Controls(0), ucPNL_p5ResBen)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 38
                            If doc_p5Telephone IsNot Nothing AndAlso doc_p5Telephone.Controls.Count > 0 AndAlso TypeOf doc_p5Telephone.Controls(0) Is ucPNL_p5Telephone Then
                                Dim uc As ucPNL_p5Telephone = CType(doc_p5Telephone.Controls(0), ucPNL_p5Telephone)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 39
                            If doc_p5SubsNotRelBusi IsNot Nothing AndAlso doc_p5SubsNotRelBusi.Controls.Count > 0 AndAlso TypeOf doc_p5SubsNotRelBusi.Controls(0) Is ucPNL_p5SubsNotRelBusi Then
                                Dim uc As ucPNL_p5SubsNotRelBusi = CType(doc_p5SubsNotRelBusi.Controls(0), ucPNL_p5SubsNotRelBusi)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 40
                            If doc_p5Seminar IsNot Nothing AndAlso doc_p5Seminar.Controls.Count > 0 AndAlso TypeOf doc_p5Seminar.Controls(0) Is ucPNL_p5Seminar Then
                                Dim uc As ucPNL_p5Seminar = CType(doc_p5Seminar.Controls(0), ucPNL_p5Seminar)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 41
                            If doc_p5MedExp IsNot Nothing AndAlso doc_p5MedExp.Controls.Count > 0 AndAlso TypeOf doc_p5MedExp.Controls(0) Is ucPNL_p5MedExp Then
                                Dim uc As ucPNL_p5MedExp = CType(doc_p5MedExp.Controls(0), ucPNL_p5MedExp)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================
                        Case 42
                            If doc_p5OthNonAllowExpCha IsNot Nothing AndAlso doc_p5OthNonAllowExpCha.Controls.Count > 0 AndAlso TypeOf doc_p5OthNonAllowExpCha.Controls(0) Is ucPNL_p5OthNonAllowExpCha Then
                                Dim uc As ucPNL_p5OthNonAllowExpCha = CType(doc_p5OthNonAllowExpCha.Controls(0), ucPNL_p5OthNonAllowExpCha)
                                tmpDataset = uc.DataView_Main

                                If tmpDataset IsNot Nothing AndAlso tmpDataset.Tables(rowInfo("TableName")).Rows.Count > 0 Then

                                    Me.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName")), rowInfo("PrefixName") & "_PLTYPE", rowInfo("OldKey"), _
                                                    rowInfo("PrefixName") & "_KEY", tmpID, ListofSQLCmd)


                                    clsPNL_.InsertSQLScriptPNL(tmpDataset.Tables(rowInfo("TableName_Details")), rowInfo("PrefixName_Details") & "_PLTYPE", rowInfo("OldKey"), _
                                                              rowInfo("PrefixName_Details") & "_KEY", tmpID, ListofSQLCmd)
                                End If
                            End If
                            '========================================================================================================

                    End Select

                    ProgressBar.EditValue = (CurrCount / (Me.dsDataset.Tables("PNL_INFO").Rows.Count - 15)) * 100
                    txtProgress.Caption = rowInfo("Description")
                    Application.DoEvents()

                End If
            Next

            Return True
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            Return False
        End Try
    End Function
    Public Function GetDatasetPNL(ByVal Name As String) As dsPNL
        Try
            Select Case Name
                Case "ds_p1Sales"
                    Return ds_p1Sales
                Case "ds_p1OpenStock"
                    Return ds_p1OpenStock
                Case "ds_p1Purchase"
                    Return ds_p1Purchase
                Case "ds_p1Depreciation"
                    Return ds_p1Depreciation
                Case "ds_p1OtherAllowableExpenses"
                    Return ds_p1OtherAllowableExpenses
                Case "ds_p1NonAllowableExpenses"
                    Return ds_p1NonAllowableExpenses
                Case "ds_p1CloseStock"
                    Return ds_p1CloseStock
                Case "ds_p2OtherBizIncome"
                    Return ds_p2OtherBizIncome
                Case "ds_p2DivIncome"
                    Return ds_p2DivIncome
                Case "ds_p2InterestIncome"
                    Return ds_p2InterestIncome
                Case "ds_p2RentalIncome"
                    Return ds_p2RentalIncome
                Case "ds_p2RoyaltyIncome"
                    Return ds_p2RoyaltyIncome
                Case "ds_p2OtherIncome"
                    Return ds_p2OtherIncome
                Case "ds_p2GainDispFixAss"
                    Return ds_p2GainDispFixAss
                Case "ds_p2GainForeEx"
                    Return ds_p2GainForeEx
                Case "ds_p2GainInv"
                    Return ds_p2GainInv
                Case "ds_p2Other"
                    Return ds_p2Other
                Case "ds_p3LoanInterest"
                    Return ds_p3LoanInterest
                Case "ds_p3SalAllowBon"
                    Return ds_p3SalAllowBon
                Case "ds_p3RentMort"
                    Return ds_p3RentMort
                Case "ds_p3ContSubCont"
                    Return ds_p3ContSubCont
                Case "ds_p3Commission"
                    Return ds_p3Commission
                Case "ds_p3BadDebts"
                    Return ds_p3BadDebts
                Case "ds_p3TravTransAccom"
                    Return ds_p3TravTransAccom
                Case "ds_p3RepairMaint"
                    Return ds_p3RepairMaint
                Case "ds_p3PromAdv"
                    Return ds_p3PromAdv
                Case "ds_p3InpTaxNotClaimJKDM"
                    Return ds_p3InpTaxNotClaimJKDM
                Case "ds_p3EPFPersonal"
                    Return ds_p3EPFPersonal
                Case "ds_p3EPFStaff"
                    Return ds_p3EPFStaff
                Case "ds_p3LegalFee"
                    Return ds_p3LegalFee
                Case "ds_p3OthExpenses"
                    Return ds_p3OthExpenses
                Case "ds_p4LossDispFixAss"
                    Return ds_p4LossDispFixAss
                Case "ds_p4LossForeExch"
                    Return ds_p4LossForeExch
                Case "ds_p4LossInv"
                    Return ds_p4LossInv
                Case "ds_p4Others"
                    Return ds_p4Others
                Case "ds_p4Depreciation"
                    Return ds_p4Depreciation
                Case "ds_p4Entertainment"
                    Return ds_p4Entertainment
                Case "ds_p4Gift"
                    Return ds_p4Gift
                Case "ds_p4Donation"
                    Return ds_p4Donation
                Case "ds_p4PenFineComp"
                    Return ds_p4PenFineComp
                Case "ds_p4DrawingPLStock"
                    Return ds_p4DrawingPLStock
                Case "ds_p4DrawingPLCash"
                    Return ds_p4DrawingPLCash
                Case "ds_p4ProvDoubDebt"
                    Return ds_p4ProvDoubDebt
                Case "ds_p4PreCessExp"
                    Return ds_p4PreCessExp
                Case "ds_p4CapExp"
                    Return ds_p4CapExp
                Case "ds_p4AssWritOff"
                    Return ds_p4AssWritOff
                Case "ds_p5MotVehUsage"
                    Return ds_p5MotVehUsage
                Case "ds_p5ResBen"
                    Return ds_p5ResBen
                Case "ds_p5Telephone"
                    Return ds_p5Telephone
                Case "ds_p5SubsNotRelBusi"
                    Return ds_p5SubsNotRelBusi
                Case "ds_p5Seminar"
                    Return ds_p5Seminar
                Case "ds_p5MedExp"
                    Return ds_p5MedExp
                Case "ds_p5OthNonAllowExpCha"
                    Return ds_p5OthNonAllowExpCha
            End Select
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            Return ds_p1Sales
        End Try
    End Function
    Public Function ClearDatabaseMemory(Optional isClear_PNLInfo As Boolean = False, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try

            If ds_p1Sales IsNot Nothing Then
                For Each tbl As DataTable In ds_p1Sales.Tables
                    tbl.Rows.Clear()
                Next
            End If

            If ds_p1OpenStock IsNot Nothing Then
                For Each tbl As DataTable In ds_p1OpenStock.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p1Purchase IsNot Nothing Then
                For Each tbl As DataTable In ds_p1Purchase.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p1Depreciation IsNot Nothing Then
                For Each tbl As DataTable In ds_p1Depreciation.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p1OtherAllowableExpenses IsNot Nothing Then
                For Each tbl As DataTable In ds_p1OtherAllowableExpenses.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p1NonAllowableExpenses IsNot Nothing Then
                For Each tbl As DataTable In ds_p1NonAllowableExpenses.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p1CloseStock IsNot Nothing Then
                For Each tbl As DataTable In ds_p1CloseStock.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p2OtherBizIncome IsNot Nothing Then
                For Each tbl As DataTable In ds_p2OtherBizIncome.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p2DivIncome IsNot Nothing Then
                For Each tbl As DataTable In ds_p2DivIncome.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p2InterestIncome IsNot Nothing Then
                For Each tbl As DataTable In ds_p2InterestIncome.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p2RentalIncome IsNot Nothing Then
                For Each tbl As DataTable In ds_p2InterestIncome.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p2RoyaltyIncome IsNot Nothing Then
                For Each tbl As DataTable In ds_p2RoyaltyIncome.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p2OtherIncome IsNot Nothing Then
                For Each tbl As DataTable In ds_p2OtherIncome.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p2GainDispFixAss IsNot Nothing Then
                For Each tbl As DataTable In ds_p2GainDispFixAss.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p2GainForeEx IsNot Nothing Then
                For Each tbl As DataTable In ds_p2GainForeEx.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p2GainInv IsNot Nothing Then
                For Each tbl As DataTable In ds_p2GainInv.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p2Other IsNot Nothing Then
                For Each tbl As DataTable In ds_p2Other.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p3LoanInterest IsNot Nothing Then
                For Each tbl As DataTable In ds_p3LoanInterest.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p3SalAllowBon IsNot Nothing Then
                For Each tbl As DataTable In ds_p3SalAllowBon.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p3RentMort IsNot Nothing Then
                For Each tbl As DataTable In ds_p3RentMort.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p3ContSubCont IsNot Nothing Then
                For Each tbl As DataTable In ds_p3ContSubCont.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p3Commission IsNot Nothing Then
                For Each tbl As DataTable In ds_p3Commission.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p3BadDebts IsNot Nothing Then
                For Each tbl As DataTable In ds_p3BadDebts.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p3TravTransAccom IsNot Nothing Then
                For Each tbl As DataTable In ds_p3TravTransAccom.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p3RepairMaint IsNot Nothing Then
                For Each tbl As DataTable In ds_p3RepairMaint.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p3PromAdv IsNot Nothing Then
                For Each tbl As DataTable In ds_p3PromAdv.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p3InpTaxNotClaimJKDM IsNot Nothing Then
                For Each tbl As DataTable In ds_p3InpTaxNotClaimJKDM.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p3EPFPersonal IsNot Nothing Then
                For Each tbl As DataTable In ds_p3EPFPersonal.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p3EPFStaff IsNot Nothing Then
                For Each tbl As DataTable In ds_p3EPFStaff.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p3LegalFee IsNot Nothing Then
                For Each tbl As DataTable In ds_p3LegalFee.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p3OthExpenses IsNot Nothing Then
                For Each tbl As DataTable In ds_p3OthExpenses.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4LossDispFixAss IsNot Nothing Then
                For Each tbl As DataTable In ds_p4LossDispFixAss.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4LossForeExch IsNot Nothing Then
                For Each tbl As DataTable In ds_p4LossForeExch.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4LossInv IsNot Nothing Then
                For Each tbl As DataTable In ds_p4LossInv.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4Others IsNot Nothing Then
                For Each tbl As DataTable In ds_p4Others.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4Depreciation IsNot Nothing Then
                For Each tbl As DataTable In ds_p4Depreciation.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4Entertainment IsNot Nothing Then
                For Each tbl As DataTable In ds_p4Entertainment.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4Gift IsNot Nothing Then
                For Each tbl As DataTable In ds_p4Gift.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4Donation IsNot Nothing Then
                For Each tbl As DataTable In ds_p4Donation.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4PenFineComp IsNot Nothing Then
                For Each tbl As DataTable In ds_p4PenFineComp.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4DrawingPLStock IsNot Nothing Then
                For Each tbl As DataTable In ds_p4DrawingPLStock.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4DrawingPLCash IsNot Nothing Then
                For Each tbl As DataTable In ds_p4DrawingPLCash.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4ProvDoubDebt IsNot Nothing Then
                For Each tbl As DataTable In ds_p4ProvDoubDebt.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4PreCessExp IsNot Nothing Then
                For Each tbl As DataTable In ds_p4PreCessExp.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4CapExp IsNot Nothing Then
                For Each tbl As DataTable In ds_p4CapExp.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p4AssWritOff IsNot Nothing Then
                For Each tbl As DataTable In ds_p4AssWritOff.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p5MotVehUsage IsNot Nothing Then
                For Each tbl As DataTable In ds_p5MotVehUsage.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p5ResBen IsNot Nothing Then
                For Each tbl As DataTable In ds_p5ResBen.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p5Telephone IsNot Nothing Then
                For Each tbl As DataTable In ds_p5Telephone.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p5SubsNotRelBusi IsNot Nothing Then
                For Each tbl As DataTable In ds_p5SubsNotRelBusi.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p5Seminar IsNot Nothing Then
                For Each tbl As DataTable In ds_p5Seminar.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p5MedExp IsNot Nothing Then
                For Each tbl As DataTable In ds_p5MedExp.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If ds_p5OthNonAllowExpCha IsNot Nothing Then
                For Each tbl As DataTable In ds_p5OthNonAllowExpCha.Tables
                    tbl.Rows.Clear()
                Next
            End If
            If isClear_PNLInfo Then
                For Each tbl As DataTable In dsDataset.Tables
                    tbl.Rows.Clear()
                Next
            End If

            Return True
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            AddListOfError(Errorlog)
            Return True
        End Try
    End Function
#Region "IO DB"
#Region "LOAD"
    Public Function Load_PNL_INFO(Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PNL_INFO ORDER BY Sequence"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL

            Return Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Check_PNL_Exist(ByVal RefNo As String, ByVal YA As String, Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT COUNT(*) AS COUNTX FROM PROFIT_LOSS_ACCOUNT WHERE PL_REF_NO=@PL_REF_NO AND PL_YA=@PL_YA"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
            SQLcmd.Parameters.Add("@PL_YA", SqlDbType.NVarChar, 20).Value = YA

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("COUNTX")) = False AndAlso dt.Rows(0)("COUNTX") > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            AddListOfError(ErrorLog)
            Return False
        End Try
    End Function
    Public Function GETPNLKEY(Optional ByRef ErrorLog As clsError = Nothing) As Integer
        Try
            Dim SqlCon As SqlConnection
            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select top 1 PL_KEY from profit_loss_account order by pl_key desc"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("pl_key")) = False Then
                Return CInt(dt.Rows(0)("pl_key"))
            Else
                Return -1
            End If
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(ErrorLog)
            Return -1
        End Try
    End Function
    Public Function GETNONTAXABLEKEY(Optional ByRef ErrorLog As clsError = Nothing) As Integer
        Try
            Dim SqlCon As SqlConnection
            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return False
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "select top 1 NT_KEY from INCOME_ADJ_NON_TAXABLE_INCOME order by NT_KEY desc"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL

            Dim dt As DataTable = Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 AndAlso IsDBNull(dt.Rows(0)("NT_KEY")) = False Then
                Return CInt(dt.Rows(0)("NT_KEY"))
            Else
                Return -1
            End If
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = "C1001"
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With

            AddListOfError(ErrorLog)
            Return -1
        End Try
    End Function
    Public Function Load_PNL(ByVal PL_KEY As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PROFIT_LOSS_ACCOUNT WHERE PL_KEY=@PL_KEY"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PL_KEY

            Return Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL(ByVal RefNo As String, ByVal YA As String, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM PROFIT_LOSS_ACCOUNT"
            SQLcmd = New SqlCommand


            Dim isWhere As Boolean = False
            If RefNo <> "" Then
                If isWhere Then
                    StrSQL += " AND PL_REF_NO=@PL_REF_NO"
                    SQLcmd.Parameters.Add("@PL_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
                Else
                    isWhere = True
                    StrSQL += " WHERE PL_REF_NO=@PL_REF_NO"
                    SQLcmd.Parameters.Add("@PL_REF_NO", SqlDbType.NVarChar, 20).Value = RefNo
                End If
            End If
            If YA <> "" Then
                If isWhere Then
                    StrSQL += " AND PL_YA=@PL_YA"
                    SQLcmd.Parameters.Add("@PL_YA", SqlDbType.NVarChar, 5).Value = YA
                Else
                    isWhere = True
                    StrSQL += " WHERE PL_YA=@PL_YA"
                    SQLcmd.Parameters.Add("@PL_YA", SqlDbType.NVarChar, 5).Value = YA
                End If
            End If

            StrSQL += " ORDER BY PL_YA"
            SQLcmd.CommandText = StrSQL

            Return Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
    Public Function Load_PNL_ITEM(ByVal TableName As String, ByVal ColumnMain As String, ByVal PL_KEY As Integer, _
                                  ByVal ColumnPLTYPE As String, ByVal PLTYPE As Integer, Optional ByRef ErrorLog As clsError = Nothing) As DataTable
        Try
            Dim SqlCon As SqlConnection

            If DBConnection(SqlCon, ErrorLog) = False OrElse SqlCon Is Nothing Then
                Return Nothing
            End If

            Dim SQLcmd As SqlCommand
            Dim StrSQL As String = "SELECT * FROM " & TableName & " WHERE " & ColumnMain & " = @PL_KEY AND " & ColumnPLTYPE & " = @PLTYPE"

            SQLcmd = New SqlCommand
            SQLcmd.CommandText = StrSQL
            SQLcmd.Parameters.Add("@PL_KEY", SqlDbType.Int).Value = PL_KEY
            SQLcmd.Parameters.Add("@PLTYPE", SqlDbType.Int).Value = PLTYPE

            Return Me.GetSQLDataTable(SQLcmd, SqlCon, System.Reflection.MethodBase.GetCurrentMethod().Name, ErrorLog)
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If ErrorLog Is Nothing Then
                ErrorLog = New clsError
            End If
            With ErrorLog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            AddListOfError(ErrorLog)
            Return Nothing
        End Try
    End Function
#End Region
    Public Function InsertSQLScriptPNL(ByVal dt As DataTable, ByVal Column_PLTYPE As String, ByVal PL_TYPE As Integer, _
                                       ByVal Column_PL_KEY As String, ByVal PL_KEY As Integer, ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                Return True
            End If

            Dim strSQL As String = Nothing
            Dim SQLcmd As SqlCommand = Nothing
            Dim isLast As Integer = 0
            For Each row As DataRow In dt.Rows
                strSQL = Nothing
                SQLcmd = Nothing
                isLast = 0

                strSQL += "INSERT INTO " & dt.TableName & "("

                SQLcmd = New SqlCommand

                For Each col As DataColumn In dt.Columns
                    isLast += 1
                    If isLast = dt.Columns.Count Then
                        strSQL += col.ColumnName
                    Else
                        strSQL += col.ColumnName & ","
                    End If
                Next
                strSQL += ") VALUES ("
                isLast = 0
                For Each col As DataColumn In dt.Columns
                    isLast += 1
                    If isLast = dt.Columns.Count Then
                        strSQL += "@" & col.ColumnName
                    Else
                        strSQL += "@" & col.ColumnName & ","
                    End If
                Next

                strSQL += ")"
                SQLcmd.CommandText = strSQL

                For Each col As DataColumn In dt.Columns

                    If col.ColumnName = Column_PLTYPE Then
                        SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.Int).Value = PL_TYPE
                    ElseIf col.ColumnName = Column_PL_KEY Then
                        SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.Int).Value = PL_KEY
                    Else
                        Select Case col.DataType
                            Case Type.GetType("System.String")
                                SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.NVarChar, col.MaxLength).Value = row(col.ColumnName)
                            Case Type.GetType("System.Decimal")
                                SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.Decimal).Value = row(col.ColumnName)
                            Case Type.GetType("System.Int16"), Type.GetType("System.Int32"), Type.GetType("System.Int64")
                                SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.Int).Value = row(col.ColumnName)
                            Case Type.GetType("System.Double"), Type.GetType("System.Float")
                                SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.Float).Value = row(col.ColumnName)
                            Case Type.GetType("System.Decimal")
                                SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.Decimal).Value = row(col.ColumnName)
                            Case Type.GetType("System.DateTime")
                                SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.DateTime).Value = row(col.ColumnName)
                            Case Type.GetType("System.Byte()")
                                SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.Image).Value = row(col.ColumnName)
                            Case Type.GetType("System.Boolean")
                                'SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.Bit).Value = row(col.ColumnName)
                                If IsDBNull(row(col.ColumnName)) = False AndAlso CBool(row(col.ColumnName)) = True Then
                                    SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.NVarChar).Value = "Yes"
                                Else
                                    SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.NVarChar).Value = "No"
                                End If

                        End Select
                    End If

                Next

                ListofCmd.Add(SQLcmd)
            Next

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Function
    Public Function UpdateSQLScriptPNL(ByVal dt As DataTable, ByVal ColumnMainKey As String, ByVal ID As Integer, ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try

            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                Return True
            End If

            Dim strSQL As String = Nothing
            Dim SQLcmd As SqlCommand = Nothing
            Dim isLast As Integer = 0
            For Each row As DataRow In dt.Rows
                strSQL = Nothing
                SQLcmd = Nothing
                isLast = 0

                strSQL += "UPDATE " & dt.TableName & " SET "

                SQLcmd = New SqlCommand

                For Each col As DataColumn In dt.Columns
                    isLast += 1
                    If col.ColumnName <> ColumnMainKey Then
                        If isLast = dt.Columns.Count Then
                            strSQL += col.ColumnName & "=@" & col.ColumnName
                        Else
                            strSQL += col.ColumnName & "=@" & col.ColumnName & ","
                        End If
                    End If
                Next
                strSQL += " WHERE " & ColumnMainKey & "=@" & ColumnMainKey


                SQLcmd.CommandText = strSQL

                SQLcmd.Parameters.Add("@" & ColumnMainKey, SqlDbType.Int).Value = ID

                For Each col As DataColumn In dt.Columns
                    If col.ColumnName <> ColumnMainKey Then
                        Select Case col.DataType
                            Case Type.GetType("System.String")
                                SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.NVarChar, col.MaxLength).Value = row(col.ColumnName)
                            Case Type.GetType("System.Decimal")
                                SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.Decimal).Value = row(col.ColumnName)
                            Case Type.GetType("System.Int16"), Type.GetType("System.Int32"), Type.GetType("System.Int64")
                                SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.Int).Value = row(col.ColumnName)
                            Case Type.GetType("System.Double"), Type.GetType("System.Float")
                                SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.Float).Value = row(col.ColumnName)
                            Case Type.GetType("System.Decimal")
                                SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.Decimal).Value = row(col.ColumnName)
                            Case Type.GetType("System.DateTime")
                                SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.DateTime).Value = row(col.ColumnName)
                            Case Type.GetType("System.Byte()")
                                SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.Image).Value = row(col.ColumnName)
                            Case Type.GetType("System.Boolean")
                                'SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.Bit).Value = row(col.ColumnName)
                                If CBool(row(col.ColumnName)) = True Then
                                    SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.NVarChar).Value = "Yes"
                                Else
                                    SQLcmd.Parameters.Add("@" & col.ToString, SqlDbType.NVarChar).Value = "No"
                                End If

                        End Select

                    End If

                Next


                ListofCmd.Add(SQLcmd)
            Next

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Function
    Public Function DeleteSQLScriptPNL(ByVal rowInfo As DataRow, ByVal PL_KEY As Integer, ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try

            Dim strSQL As String = Nothing
            Dim SQLcmd As SqlCommand = Nothing

            If IsDBNull(rowInfo("TableName")) = False AndAlso rowInfo("TableName") <> "" AndAlso IsDBNull(rowInfo("PrefixName")) = False AndAlso rowInfo("PrefixName") <> "" Then
                strSQL = "DELETE " & rowInfo("TableName") & " WHERE " & rowInfo("PrefixName") & "_KEY =@" & rowInfo("PrefixName") & "_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = strSQL
                SQLcmd.Parameters.Add("@" & rowInfo("PrefixName") & "_KEY", SqlDbType.Int).value = PL_KEY
                ListofCmd.Add(SQLcmd)
            End If

            If IsDBNull(rowInfo("TableName_Details")) = False AndAlso rowInfo("TableName_Details") <> "" AndAlso IsDBNull(rowInfo("PrefixName_Details")) = False AndAlso rowInfo("PrefixName_Details") <> "" Then
                strSQL = "DELETE " & rowInfo("TableName_Details") & " WHERE " & rowInfo("PrefixName_Details") & "_KEY =@" & rowInfo("PrefixName_Details") & "_KEY"
                SQLcmd = New SqlCommand
                SQLcmd.CommandText = strSQL
                SQLcmd.Parameters.Add("@" & rowInfo("PrefixName_Details") & "_KEY", SqlDbType.Int).value = PL_KEY
                ListofCmd.Add(SQLcmd)
            End If

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Function
    Public Function DeleteSQLScriptPNL(ByVal TableName As String, ByVal ColumnMain As String, ByVal PL_KEY As Integer, ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try

            Dim strSQL As String = Nothing
            Dim SQLcmd As SqlCommand = Nothing

            strSQL = "DELETE " & TableName & " WHERE " & ColumnMain & " =@" & ColumnMain
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = strSQL
            SQLcmd.Parameters.Add("@" & ColumnMain, SqlDbType.Int).Value = PL_KEY
            ListofCmd.Add(SQLcmd)

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Function
    Public Function Delete_NonTaxableIncome(ByVal NT_PREFIT As String, ByVal NT_REF_NO As String, ByVal NT_YA As Integer,
                                            ByVal NT_SOURCE As String, ByVal NT_2 As String, ByRef ListofCmd As List(Of SqlCommand), Optional ByRef ErrorLog As clsError = Nothing) As Boolean
        Try

            Dim strSQL As String = Nothing
            Dim SQLcmd As SqlCommand = Nothing

            strSQL = "DELETE INCOME_ADJ_NON_TAXABLE_INCOME WHERE NT_PREFIT=@NT_PREFIT AND NT_REF_NO=@NT_REF_NO AND NT_YA=@NT_YA AND NT_SOURCE=@NT_SOURCE AND NT_2=@NT_2"
            SQLcmd = New SqlCommand
            SQLcmd.CommandText = strSQL
            SQLcmd.Parameters.Add("@NT_PREFIT", SqlDbType.NVarChar, 3).Value = NT_PREFIT
            SQLcmd.Parameters.Add("@NT_REF_NO", SqlDbType.NVarChar, 20).Value = NT_REF_NO
            SQLcmd.Parameters.Add("@NT_YA", SqlDbType.NVarChar, 5).Value = NT_YA
            SQLcmd.Parameters.Add("@NT_SOURCE", SqlDbType.NVarChar, 5).Value = NT_SOURCE
            SQLcmd.Parameters.Add("@NT_2", SqlDbType.NVarChar, 5).Value = NT_2
            ListofCmd.Add(SQLcmd)

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)

        End Try
    End Function
#End Region
#Region "FUNCTION"
    Public Function CalcPNL() As Boolean
        Try
            If Me.dsDataset.Tables("PNL_INFO").Rows.Count > 0 Then

                Dim p1Sales As Decimal = 0
                Dim p1OpenStock As Decimal = 0
                Dim p1Purchase As Decimal = 0
                Dim p1COP As Decimal = 0
                Dim p1PurProCost As Decimal = 0
                Dim p1CloseStock As Decimal = 0
                Dim p1COGS As Decimal = 0
                Dim p1GrosCOGS As Decimal = 0
                Dim p2OtherBizIncome As Decimal = 0
                Dim p2NonBizInc As Decimal = 0
                Dim p2NonTaxInc As Decimal = 0
                Dim p3LessExp As Decimal = 0
                Dim p4NonAllowLoss As Decimal = 0
                Dim p4NonAllowExpChar As Decimal = 0
                Dim p5PersonalExp As Decimal = 0
                Dim p5OthNonAllowExpCha As Decimal = 0
                Dim p5TotNonAllowExpChar As Decimal = 0
                Dim p5TotExp As Decimal = 0
                Dim p5NetProfLoss As Decimal = 0
                For Each row As DataRow In Me.dsDataset.Tables("PNL_INFO").Rows

                    Select Case IIf(IsDBNull(row("KeyName")), "", row("KeyName"))
                        Case "p1Sales"
                            p1Sales += IIf(IsDBNull(row("Amount")), 0, row("Amount"))
                        Case "p1OpenStock"
                            p1OpenStock += IIf(IsDBNull(row("Amount")), 0, row("Amount"))

                        Case "p1Depreciation", "p1OtherAllowableExpenses", "p1NonAllowableExpenses"
                            p1COP += IIf(IsDBNull(row("Amount")), 0, row("Amount"))
                        Case "p1Purchase"
                            p1Purchase += IIf(IsDBNull(row("Amount")), 0, row("Amount"))
                        Case "p1CloseStock"
                            p1CloseStock += IIf(IsDBNull(row("Amount")), 0, row("Amount"))
                        Case "p2OtherBizIncome"
                            p2OtherBizIncome += IIf(IsDBNull(row("Amount")), 0, row("Amount"))
                        Case "p2DivIncome", "p2RentalIncome", "p2RoyaltyIncome", "p2InterestIncome", "p2OtherIncome"
                            p2NonBizInc += IIf(IsDBNull(row("Amount")), 0, row("Amount"))
                        Case "p2GainDispFixAss", "p2GainForeEx", "p2GainInv", "p2Other"
                            p2NonTaxInc += IIf(IsDBNull(row("Amount")), 0, row("Amount"))
                        Case "p3LoanInterest", "p3SalAllowBon", "p3RentMort", "p3ContSubCont", "p3Commission", "p3BadDebts", "p3TravTransAccom", "p3RepairMaint", "p3PromAdv", "p3InpTaxNotClaimJKDM", "p3EPFPersonal", "p3EPFStaff", "p3LegalFee", "p3OthExpenses"
                            p3LessExp += IIf(IsDBNull(row("Amount")), 0, row("Amount"))
                        Case "p4LossDispFixAss", "p4LossForeExch", "p4LossInv", "p4Others"
                            p4NonAllowLoss += IIf(IsDBNull(row("Amount")), 0, row("Amount"))
                        Case "p4Depreciation", "p4Entertainment", "p4Gift", "p4Donation", "p4PenFineComp", "p4DrawingPLStock", "p4DrawingPLCash", "p4ProvDoubDebt", "p4PreCessExp", "p4CapExp", "p4AssWritOff"
                            p4NonAllowExpChar += IIf(IsDBNull(row("Amount")), 0, row("Amount"))
                        Case "p5MotVehUsage", "p5ResBen", "p5Telephone", "p5SubsNotRelBusi", "p5Seminar", "p5MedExp"
                            p5PersonalExp += IIf(IsDBNull(row("Amount")), 0, row("Amount"))
                        Case "p5OthNonAllowExpCha"
                            p5OthNonAllowExpCha += IIf(IsDBNull(row("Amount")), 0, row("Amount"))
                    End Select

                Next
                p1PurProCost = p1COP + p1Purchase
                p1COGS = p1OpenStock + p1Purchase + p1COP - p1CloseStock
                p1GrosCOGS = p1Sales - p1COGS
                p5TotNonAllowExpChar = p4NonAllowExpChar + p5PersonalExp + p5OthNonAllowExpCha
                p5TotExp = p3LessExp + p4NonAllowLoss + p5TotNonAllowExpChar
                p5NetProfLoss = p1GrosCOGS + p2OtherBizIncome + p2NonBizInc + p2NonTaxInc - p5TotExp

                Application.DoEvents()

                For Each row As DataRow In Me.dsDataset.Tables("PNL_INFO").Rows
                    Select Case row("KeyName")
                        Case "p1COPTotal"
                            row("Amount") = p1COP
                        Case "p1PurProCost"
                            row("Amount") = p1PurProCost
                        Case "p1COGS"
                            row("Amount") = p1COGS
                        Case "p1GrosCOGS"
                            row("Amount") = p1GrosCOGS
                        Case "p5TotNonAllowExpChar"
                            row("Amount") = p5TotNonAllowExpChar
                        Case "p5TotExp"
                            row("Amount") = p5TotExp
                        Case "p5NetProfLoss"
                            row("Amount") = p5NetProfLoss
                            If txtNetProfit IsNot Nothing Then
                                txtNetProfit.EditValue = p5NetProfLoss
                            End If
                        Case Else
                            If row("Oldkey") <> 0 Then
                                If IsDBNull(row("Amount")) = True OrElse row("Amount") = 0 Then
                                    row("Amount") = 0
                                End If
                            End If
                    End Select
                Next
            End If
            Return True
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            Return False
        End Try
    End Function
    Public Function reCalc_SubTotalView(ByVal dtParent As DataRow, _
                                       ByRef ds As DataSet, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            If ds IsNot Nothing Then
                Dim obj As Object = Nothing

                Dim TableName As String = CStr(dtParent("TableName"))
                Dim TableName_Details As String = CStr(dtParent("TableName_Details"))
                Dim Column_Total As String = CStr(dtParent("ColumnAmount"))
                Dim ColumnDetails_Total As String = CStr(dtParent("ColumnAmount_Details"))
                Dim ColumnName_Key As String = CStr(dtParent("ColumnKey"))
                Dim ColumnNameDetails_Key As String = CStr(dtParent("ColumnKey_Details"))
                Dim Column_OldKey As String = CStr(dtParent("ColumnOldKey"))
                Dim ColumnDetails_OldKey As String = CStr(dtParent("ColumnOldKey_Details"))
                Dim OldKey As Integer = CStr(dtParent("OldKey"))

                For i As Integer = 0 To ds.Tables(TableName).Rows.Count - 1
                    obj = ds.Tables(TableName_Details).Compute("Sum(" & ColumnDetails_Total & ")", ColumnNameDetails_Key & " =" & ds.Tables(TableName).Rows(i)(ColumnName_Key) & " AND " & ColumnDetails_OldKey & " =" & OldKey)

                    If obj IsNot Nothing AndAlso IsNumeric(obj) Then
                        ds.Tables(TableName).Rows(i)(Column_Total) = CDec(obj)
                    End If

                Next

            End If


            Return True
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return True
        End Try
    End Function
    Public Function CalcTotalofView(ByVal dtParent As DataRow, ByRef ds As DataSet, _
                                    ByVal CurrentAmount As Decimal, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            Dim TableName As String = CStr(dtParent("TableName"))
            Dim Column_Total As String = CStr(dtParent("ColumnAmount"))
            Dim Column_OldKey As String = CStr(dtParent("ColumnOldKey"))
            Dim ColumnDetails_OldKey As String = CStr(dtParent("ColumnOldKey_Details"))
            Dim OldKey As Integer = CStr(dtParent("OldKey"))

            Dim obj As Object = ds.Tables(TableName).Compute("sum(" & Column_Total & ")", Column_OldKey & " =" & OldKey)

            For Each rowinfo As DataRow In Me.dsDataset.Tables("PNL_INFO").Rows
                If rowinfo IsNot Nothing AndAlso IsDBNull(rowinfo("OldKey")) = False AndAlso dtParent("OldKey") = rowinfo("OldKey") Then
                    If obj IsNot Nothing AndAlso IsNumeric(obj) Then
                        rowinfo("Amount") = CDec(CDec(obj) + CurrentAmount).ToString(GetDecimalPlace(Setting_DecimalPlace_PNL))
                    Else
                        rowinfo("Amount") = CDec(CurrentAmount).ToString(GetDecimalPlace(Setting_DecimalPlace_PNL))
                    End If
                    Exit For
                End If
            Next

            CalcPNL()
            Return True
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return True
        End Try
    End Function
    Public Function MappingSourceNo(ByVal dtParent As DataRow, _
                                        ByRef ds As DataSet, Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try
            If ds IsNot Nothing Then
                Dim obj As Object = Nothing
                Dim dtRow As DataRow = Nothing


                Dim TableName As String = CStr(dtParent("TableName"))
                Dim TableName_Details As String = CStr(dtParent("TableName_Details"))
                Dim Column_SourceNo As String = CStr(dtParent("ColumnSource"))
                Dim ColumnDetails_SourceNo As String = CStr(dtParent("ColumnSource_Details"))
                Dim ColumnName_Key As String = CStr(dtParent("ColumnKey"))
                Dim ColumnNameDetails_Key As String = CStr(dtParent("ColumnKey_Details"))


                For i As Integer = 0 To ds.Tables(TableName).Rows.Count - 1
                    obj = ds.Tables(TableName_Details).Select(ColumnNameDetails_Key & "=" & ds.Tables(TableName).Rows(i)(ColumnName_Key))

                    If obj IsNot Nothing Then
                        Dim ListofRow() As DataRow = obj
                        For x As Integer = 0 To ListofRow.Count - 1
                            dtRow = ListofRow(x)
                            dtRow(ColumnDetails_SourceNo) = ds.Tables(TableName).Rows(i)(Column_SourceNo)
                        Next

                    End If
                Next

            End If
            Return True
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
    Public Function DisableAmountIfGotChild(ByVal dtParent As DataRow, _
                                             ByRef view1 As DevExpress.XtraGrid.Views.Grid.GridView, ByRef ds As DataSet, _
                                            Optional ByRef Errorlog As clsError = Nothing) As Boolean
        Try

            Dim TableName As String = CStr(dtParent("TableName"))
            Dim TableName_Details As String = CStr(dtParent("TableName_Details"))
            Dim DetailsColumnName As String = CStr(dtParent("PrefixName") & "_DETAIL")
            Dim ColumnName_Key As String = CStr(dtParent("ColumnKey"))
            Dim ColumnNameDetails_Key As String = CStr(dtParent("ColumnKey_Details"))


            Dim parentkey As Integer = 0
            Dim obj As Object = Nothing
            For i As Integer = 0 To view1.RowCount - 1

                If i = view1.FocusedRowHandle Then
                    parentkey = view1.GetDataRow(i)(ColumnName_Key)

                    obj = ds.Tables(TableName_Details).Compute("count(" & ColumnNameDetails_Key & ")", ColumnNameDetails_Key & " =" & parentkey)

                    If obj IsNot Nothing AndAlso IsNumeric(obj) AndAlso CInt(obj) > 0 Then
                        view1.GetDataRow(i)(DetailsColumnName) = "Yes"
                        Return True
                    Else
                        view1.GetDataRow(i)(DetailsColumnName) = "No"
                        Return False
                    End If

                End If

            Next
            Return False
        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            If Errorlog Is Nothing Then
                Errorlog = New clsError
            End If
            With Errorlog
                .ErrorName = System.Reflection.MethodBase.GetCurrentMethod().Name
                .ErrorCode = ex.GetHashCode.ToString
                .ErrorDateTime = Now
                .ErrorMessage = ex.Message
            End With
            Return False
        End Try
    End Function
    Public Sub MoveItemsInListView(ByVal blnMoveUp As Boolean, ByVal dtParent As DataRow, _
                                   ByVal RefNo As String, _
                                    ByRef gridview As DevExpress.XtraGrid.Views.Grid.GridView, _
                                    ByRef ds As DataSet, Optional ByRef ErrorLog As clsError = Nothing)
        Try
            Dim MainTable As String = CStr(dtParent("TableName"))
            Dim MainTable_Details As String = CStr(dtParent("TableName_Details"))
            Dim MainKey As String = CStr(dtParent("ColumnKey"))
            Dim MainKey_Details As String = CStr(dtParent("ColumnKey_Details"))


            'Set the listview index to limit to depending on whether we are moving things up or down in the list
            Dim intLimittedIndex As Integer = (ds.Tables(MainTable).Rows.Count - 1)
            If blnMoveUp Then intLimittedIndex = 0

            'Define a new collection of the listview indexes to move
            Dim colIndexesToMove As New List(Of Integer)()

            For i As Integer = 0 To ds.Tables(MainTable).Rows.Count - 1
                If gridview.FocusedRowHandle = i Then
                    colIndexesToMove.Add(i)
                    If gridview.FocusedRowHandle = intLimittedIndex Then
                        'Do not attempt to move item(s) as we are at the top or bottom of the list
                        Exit Try
                    End If
                    If blnMoveUp = False AndAlso i = ds.Tables(MainTable).Rows.Count - 1 Then
                        Exit Sub
                    End If
                End If
            Next


            'If we are moving items down
            If Not blnMoveUp Then
                'Reverse the index list so that we move items from the bottom of the selection first
                colIndexesToMove.Reverse()
            End If
            Dim ltmpdtRow As New DataTable("TMP")
            Dim tmpcol As System.Data.DataColumn
            For Each col As System.Data.DataColumn In ds.Tables(MainTable_Details).Columns
                tmpcol = Nothing
                tmpcol = New DataColumn
                tmpcol.ColumnName = col.ColumnName
                tmpcol.DataType = col.DataType
                tmpcol.DefaultValue = col.DefaultValue
                tmpcol.AutoIncrement = col.AutoIncrement
                tmpcol.AutoIncrementSeed = col.AutoIncrementSeed
                tmpcol.AutoIncrementStep = col.AutoIncrementStep

                ltmpdtRow.Columns.Add(tmpcol)
            Next
            Application.DoEvents()
            Dim dtXrow As DataRow = Nothing
            Dim row As DataRow
            'Loop through each index we want to move
            For Each intIndex As Integer In colIndexesToMove

                If RefNo IsNot Nothing AndAlso RefNo <> "" Then
                    ltmpdtRow.Rows.Clear()
                    dtXrow = Nothing
                    dtXrow = ds.Tables(MainTable).Rows(intIndex)
                    Dim indx As Integer = 0

                    If blnMoveUp Then
                        indx = intIndex - 1
                    Else
                        indx = intIndex + 1
                    End If

                    Dim KeyNo As Integer = 0
                    row = Nothing
                    row = ds.Tables(MainTable).NewRow
                    For Each col As DataColumn In ds.Tables(MainTable).Columns
                        If col.ColumnName = MainKey Then
                            KeyNo = dtXrow(col)
                        End If
                        row(col) = dtXrow(col)
                    Next
                    'if got child
                    For i As Integer = 0 To ds.Tables(MainTable_Details).Rows.Count - 1
                        If IsDBNull(ds.Tables(MainTable_Details).Rows(i)(MainKey_Details)) = False AndAlso ds.Tables(MainTable_Details).Rows(i)(MainKey_Details) = KeyNo Then
                            ltmpdtRow.ImportRow(ds.Tables(MainTable_Details).Rows(i))
                        End If
                    Next

                    ds.Tables(MainTable).Rows(intIndex).Delete()

                    ds.Tables(MainTable).Rows.InsertAt(row, indx)
                    Application.DoEvents()

                    If ltmpdtRow.Rows.Count > 0 Then
                        For i As Integer = 0 To ltmpdtRow.Rows.Count - 1
                            ltmpdtRow.Rows(i)(MainKey_Details) = ds.Tables(MainTable).Rows(indx)(MainKey)
                            ds.Tables(MainTable_Details).ImportRow(ltmpdtRow.Rows(i))
                        Next
                    End If
                    gridview.FocusedRowHandle = indx
                    gridview.SelectRow(indx)
                Else
                    dtXrow = Nothing
                    dtXrow = gridview.GetDataRow(intIndex)
                    ds.Tables(MainTable).Rows.RemoveAt(intIndex)

                    If blnMoveUp Then

                        ds.Tables(MainTable).Rows.InsertAt(dtXrow, intIndex - 1)
                        gridview.FocusedRowHandle = intIndex - 1
                        gridview.SelectRow(intIndex - 1)
                    Else
                        ds.Tables(MainTable).Rows.InsertAt(dtXrow, intIndex + 1)
                        gridview.FocusedRowHandle = intIndex + 1
                        gridview.SelectRow(intIndex + 1)
                    End If

                End If

            Next

        Catch ex As Exception
Dim st As New StackTrace(True)
 st = New StackTrace(ex, True)
            ' Trace.WriteLine("MoveItemsInListView() has thrown an exception: " & ex.Message)
        Finally
            'Set the focus on the listview
            gridview.Focus()
        End Try
    End Sub
#End Region

End Class
