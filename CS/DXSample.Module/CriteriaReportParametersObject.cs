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

namespace DXSample.Module {
    [NonPersistent]
    public class CriteriaReportParametersObject : ReportParametersObjectBase {
        public CriteriaReportParametersObject(Session session) : base(session) { }

        public override DevExpress.Data.Filtering.CriteriaOperator GetCriteria() {
            UnitOfWork uow = Session as UnitOfWork;
            if (uow == null) {
                uow = new UnitOfWork(Session.DataLayer);
            }
            return CriteriaEditorHelper.GetCriteriaOperator(Criteria, ReportDataType, new ObjectSpace(uow, XafTypesInfo.Instance));
        }

        public override SortingCollection GetSorting() {
            return new SortingCollection();
        }

        private string _Criteria;
        [CriteriaObjectTypeMember("ReportDataType")]
        public string Criteria {
            get { return _Criteria; }
            set { SetPropertyValue("Criteria", ref _Criteria, value); }
        }
    }

}
