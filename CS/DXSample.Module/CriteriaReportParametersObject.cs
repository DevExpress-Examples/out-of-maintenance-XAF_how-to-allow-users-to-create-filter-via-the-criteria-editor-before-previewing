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
        public CriteriaReportParametersObject(Session session) : base(session) { }

        public override DevExpress.Data.Filtering.CriteriaOperator GetCriteria() {
            return CriteriaEditorHelper.GetCriteriaOperator(Criteria, ReportDataType, XPObjectSpace.FindObjectSpaceByObject(this));
        }

        public override SortingCollection GetSorting() {
            return new SortingCollection();
        }

        private string _Criteria;
        [CriteriaOptions("ReportDataType"), Size(SizeAttribute.Unlimited)]
        public string Criteria {
            get { return _Criteria; }
            set { SetPropertyValue("Criteria", ref _Criteria, value); }
        }
    }

}
