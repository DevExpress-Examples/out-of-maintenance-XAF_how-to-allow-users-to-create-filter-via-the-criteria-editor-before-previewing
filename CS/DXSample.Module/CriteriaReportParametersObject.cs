using System;
using System.ComponentModel;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Reports;
using DevExpress.ExpressApp.Editors;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.Xpo;

namespace DXSample.Module {
    [NonPersistent]
    public class CriteriaReportParametersObject : ReportParametersObjectBase {
        public CriteriaReportParametersObject(IObjectSpace objectSpace, Type reportDataType) : base(objectSpace, reportDataType) { }

        public override DevExpress.Data.Filtering.CriteriaOperator GetCriteria() {
            return CriteriaEditorHelper.GetCriteriaOperator(Criteria, ReportDataType, ObjectSpace);
        }

        public override SortProperty[] GetSorting() {
            return new SortProperty[0];
        }

        private string _Criteria;
        [CriteriaOptions("ReportDataType"), Size(SizeAttribute.Unlimited)]
        public string Criteria {
            get { return _Criteria; }
            set { _Criteria = value; }
        }
    }
}
