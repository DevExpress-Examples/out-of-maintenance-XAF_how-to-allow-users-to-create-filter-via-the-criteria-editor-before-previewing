<!-- default file list -->
*Files to look at*:

* **[CriteriaReportParametersObject.cs](./CS/DXSample.Module/CriteriaReportParametersObject.cs) (VB: [CriteriaReportParametersObject.vb](./VB/DXSample.Module/CriteriaReportParametersObject.vb))**
<!-- default file list end -->
# How to allow users to create filter via the criteria editor before previewing a report


<p>This example demonstrates how to display a popup window with the filter editor before showing report preview, and filtering the report using the filter specified in this window. For this purpose, a custom report parameters class - CriteriaReportParametersObject - is created. This class has the Criteria property decorated with the CriteriaOptionsAttribute. XAF automatically uses CriteriaPropertyEditor for properties decorated with this attribute. So, the CriteriaPropertyEditor will be displayed in the CriteriaReportParametersObject DetailView. To convert the string created by this editor to the CriteriaOperator appropriate for the report, use the CriteriaEditorHelper.GetCriteriaOperator method in the CriteriaReportParametersObject.GetCriteria. The following topics contain more information about these techniques:</p><p><a href="http://documentation.devexpress.com/#Xaf/CustomDocument3014"><u>How to: Use Criteria Property Editors</u></a> <br />
<a href="http://documentation.devexpress.com/#Xaf/CustomDocument2778"><u>Filter Report Data Source via the ParametersObjectType Property</u></a></p>

<br/>


