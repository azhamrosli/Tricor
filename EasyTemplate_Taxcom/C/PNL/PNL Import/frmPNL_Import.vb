Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmPNL_Import
    Public FileURL As String = Nothing
    Dim ErrorLog As ClsError = Nothing
    Dim dtTableSheet As DataTable = Nothing
    Public Property DataView_TableSheet() As DataTable
        Get
            Return dtTableSheet
        End Get
        Set(ByVal value As DataTable)
            dtTableSheet = value
        End Set
    End Property
    Sub New()

        InitializeComponent()

    End Sub

    Private Sub frmPNL_Import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtFileURL2.EditValue = FileURL

            LoadData()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub LoadData()
        Try
            If CreateLookUpTaxPayer(DsDefault, ErrorLog) = False Then
                MsgBox("Unable to retrive tax payer.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If CreateLookUpYA(cboYA, ErrorLog, True) = False Then
                MsgBox("Unable to retrive YA.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If mdlProcess.ArgParam2 <> "" Then
                cboRefNo.EditValue = mdlProcess.ArgParam2
            End If

            If mdlProcess.ArgParam3 <> "" Then
                cboYA.EditValue = mdlProcess.ArgParam3
            End If

            '  Dim listofclsPNLLabel As List(Of clsPNL_LabelName) = GetPNLLabelName()

            'If listofclsPNLLabel IsNot Nothing Then
            '    For Each tmp As clsPNL_LabelName In listofclsPNLLabel
            '        'If mdlProcess.isVersionLicenseType = VersionLicenseType.Tricor Then
            '        '    Progress(CurrentProgress, "Getting " & tmp.LabelTricor & " data...")
            '        'Else
            '        '    Progress(CurrentProgress, "Getting " & tmp.LabelText & " data...")
            '        'End If
            '        ''CurrentProgress += 1
            '        mdlPNL2.PNL_GetData(ID, tmp.Type, txtRefNo.EditValue, cboYA.EditValue, dsDataSet, dsDataSet2, ErrorLog)
            '        '  Progress(CurrentProgress, "Loading " & tmp.LabelTricor & " data...")
            '        Application.DoEvents()

            '    Next
            'End If

            Import_Data()
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub

    Private Sub Import_Data()
        Try

            Dim tableName As String = "Sheet"
            Dim adapter As OleDbDataAdapter
            Dim strSQL As String = Nothing
            Dim dtRow As DataRow = Nothing
            Dim connectionString As String = ""

            If FileURL.EndsWith(".xlsx") Then            '2007 Format            
                connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=No'", FileURL)
            Else            '2003 Format            
                connectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=No'", FileURL)
            End If

            For i As Integer = 0 To dtTableSheet.Rows.Count - 1
                Dim ds = New DataSet()
                strSQL = "select * from [" & dtTableSheet.Rows(i)("SheetName").ToString & "]"
                adapter = New OleDbDataAdapter(strSQL, connectionString)
                adapter.Fill(ds, dtTableSheet.Rows(i)("SheetName").ToString)

                If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                    For Each rowx As DataRow In ds.Tables(0).Rows

                        dtRow = DsPNL2.Tables("ExportPNL").NewRow
                        dtRow("No") = rowx(0)
                        dtRow("No2") = rowx(1)
                        dtRow("Type") = rowx(2)
                        dtRow("Description") = rowx(3)
                        dtRow("LeftAmount") = rowx(4)
                        dtRow("RightAmount") = rowx(5)
                        DsPNL2.Tables("ExportPNL").Rows.Add(dtRow)
                    Next
                End If
                ds = Nothing
            Next
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub TransferData()
        Try
            Dim PnlType As mdlEnum.TaxComPNLEnuItem = TaxComPNLEnuItem.CLOSESTOCK
            Dim dtRow As DataRow = Nothing
            For i As Integer = 0 To DsPNL2.Tables("ExportPNL").Rows.Count - 1
                PnlType = DirectCast([Enum].Parse(GetType(mdlEnum.TaxComPNLEnuItem), DsPNL2.Tables(0).Rows(i)("Type")), mdlEnum.TaxComPNLEnuItem)

                Select Case PnlType
                    Case TaxComPNLEnuItem.EXPOTHERSEXPENSES

                        dtRow("EXO_KEY") = 0
                        dtRow("EXO_EXOKEY") = DsPNL2.Tables(0).Rows.Count + 1
                        dtRow("EXO_DESC") = DsPNL2.Tables("ExportPNL").Rows(i)("Description")
                        If IsNumeric(DsPNL2.Tables("ExportPNL").Rows(i)("Description")) = True AndAlso CDec(DsPNL2.Tables("ExportPNL").Rows(i)("Description")) > 0 Then
                            dtRow("EXO_AMOUNT") = DsPNL2.Tables(0).Rows(i)("Debit Amount")
                        Else
                            dtRow("EXO_AMOUNT") = DsPNL2.Tables(0).Rows(i)("Credit Amount")
                        End If
                        dtRow("EXO_DEDUCTIBLE") = False
                        dtRow("EXO_NOTE") = ""
                        dtRow("EXO_SOURCENO") = cboMainSource.EditValue
                        dtRow("EXO_DETAIL") = "No"
                        dtRow("EXO_DEDUCTIBLE_ADD") = False
                        dtRow("RowIndex") = 0
                        dtRow("Pecentage") = 0
                End Select
            Next
        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub cboRefNo_EditValueChanged(sender As Object, e As EventArgs) Handles cboRefNo.EditValueChanged

        Try
            If cboRefNo IsNot Nothing AndAlso cboRefNo.EditValue.ToString <> "" AndAlso cboYA IsNot Nothing AndAlso cboYA.EditValue.ToString <> "" Then
                txtRefNo.EditValue = cboRefNo.EditValue
                mdlProcess.CreateLookUpSourceNO(dsDataSet, cboRefNo.EditValue, cboYA.EditValue, "BUSINESS_SOURCE", ErrorLog)

                BUSINESSSOURCEBindingSource.DataSource = dsDataSet.Tables("BUSINESS_SOURCE")

                For i As Integer = 0 To dsDataSet.Tables("BUSINESS_SOURCE").Rows.Count - 1
                    If i = 0 Then
                        cboMainSource.EditValue = dsDataSet.Tables("BUSINESS_SOURCE").Rows(i)("BC_SOURCENO")
                    End If
                Next
            End If

        Catch ex As Exception
            Dim st As New StackTrace(True)
             st = New StackTrace(ex, True)

        End Try
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Import_Data()
    End Sub

End Class