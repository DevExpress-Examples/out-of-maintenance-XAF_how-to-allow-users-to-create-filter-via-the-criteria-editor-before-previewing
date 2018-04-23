Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web

Namespace DXSample.Web
	Partial Public Class DXSampleAspNetApplication
		Inherits WebApplication
		Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
		Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
		Private module3 As DXSample.Module.DXSampleModule
		Private module4 As DXSample.Module.Web.DXSampleAspNetModule
		Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
		Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
		Private reportsAspNetModule1 As DevExpress.ExpressApp.Reports.Web.ReportsAspNetModule
		Private module5 As DevExpress.ExpressApp.Validation.ValidationModule

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub DXSampleAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
			If System.Diagnostics.Debugger.IsAttached Then
				e.Updater.Update()
				e.Handled = True
			Else
				Throw New InvalidOperationException("The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & Constants.vbCrLf & "The automatic update is disabled, because the application was started without debugging." & Constants.vbCrLf & "You should start the application under Visual Studio, or modify the " & "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " & "or manually create a database using the 'DBUpdater' tool.")
			End If
		End Sub

		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DXSampleAspNetApplication))
			Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
			Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
			Me.module3 = New DXSample.Module.DXSampleModule()
			Me.module4 = New DXSample.Module.Web.DXSampleAspNetModule()
			Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
			Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
			Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
			Me.reportsAspNetModule1 = New DevExpress.ExpressApp.Reports.Web.ReportsAspNetModule()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' module5
			' 
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResult))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResultItem))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RulePropertyValueProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleRequiredFieldProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleRangeProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleValueComparisonProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleStringComparisonProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleRegularExpressionProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleCriteriaProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleSearchObjectProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleObjectExistsProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleUniqueValueProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleIsReferencedProperties))
			' 
			' reportsAspNetModule1
			' 
			Me.reportsAspNetModule1.Description = resources.GetString("reportsAspNetModule1.Description")
			Me.reportsAspNetModule1.EnableInplaceReports = True
			Me.reportsAspNetModule1.ReportDataType = GetType(DevExpress.ExpressApp.Reports.ReportData)
			Me.reportsAspNetModule1.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.SystemModule.SystemModule))
			' 
			' DXSampleAspNetApplication
			' 
			Me.ApplicationName = "DXSample"
			Me.Modules.Add(Me.module1)
			Me.Modules.Add(Me.module2)
			Me.Modules.Add(Me.module6)
			Me.Modules.Add(Me.module3)
			Me.Modules.Add(Me.module4)
			Me.Modules.Add(Me.module5)
			Me.Modules.Add(Me.securityModule1)
			Me.Modules.Add(Me.reportsAspNetModule1)
'			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.DXSampleAspNetApplication_DatabaseVersionMismatch);
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
	End Class
End Namespace
