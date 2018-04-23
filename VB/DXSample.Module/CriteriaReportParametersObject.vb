Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports DevExpress.Xpo

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation
Imports DevExpress.ExpressApp.Reports
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.Data.Filtering

Namespace DXSample.Module
	<NonPersistent> _
	Public Class CriteriaReportParametersObject
		Inherits ReportParametersObjectBase
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Public Overrides Function GetCriteria() As DevExpress.Data.Filtering.CriteriaOperator
			Dim uow As UnitOfWork = TryCast(Session, UnitOfWork)
			If uow Is Nothing Then
				uow = New UnitOfWork(Session.DataLayer)
			End If
			Return CriteriaEditorHelper.GetCriteriaOperator(Criteria, ReportDataType, New ObjectSpace(uow, XafTypesInfo.Instance))
		End Function

		Public Overrides Function GetSorting() As SortingCollection
			Return New SortingCollection()
		End Function

		Private _Criteria As String
		<CriteriaObjectTypeMember("ReportDataType")> _
		Public Property Criteria() As String
			Get
				Return _Criteria
			End Get
			Set(ByVal value As String)
				SetPropertyValue("Criteria", _Criteria, value)
			End Set
		End Property
	End Class

End Namespace
