Imports System
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Reports
Imports DevExpress.ExpressApp

Namespace DXSample.Module

    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub

        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            CreateReport("MasterReport")
            CreateReport("DetailReport")
        End Sub

        Private Sub CreateReport(ByVal reportName As String)
            Dim reportdata As ReportData = ObjectSpace.FindObject(Of ReportData)(New BinaryOperator("Name", reportName))
            If reportdata Is Nothing Then
                reportdata = ObjectSpace.CreateObject(Of ReportData)()
                Dim rep As XafReport = New XafReport()
                rep.ReportName = reportName
                rep.ObjectSpace = ObjectSpace
                rep.LoadLayout([GetType]().Assembly.GetManifestResourceStream("DXSample.Module.EmbeddedReports." & reportName & ".repx"))
                reportdata.SaveReport(rep)
                reportdata.Save()
            End If
        End Sub
    End Class
End Namespace
