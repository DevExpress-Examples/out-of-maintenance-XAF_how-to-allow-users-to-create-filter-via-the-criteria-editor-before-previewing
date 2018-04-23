using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Reports;
using DevExpress.ExpressApp;

namespace DXSample.Module {
    public class Updater : ModuleUpdater {
        public Updater(ObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            CreateReport("MasterReport");
            CreateReport("DetailReport");
        }
        private void CreateReport(string reportName) {
            ReportData reportdata = ObjectSpace.FindObject<ReportData>(new BinaryOperator("Name", reportName));
            if (reportdata == null) {
                reportdata = ObjectSpace.CreateObject<ReportData>();
                XafReport rep = new XafReport();
                rep.ReportName = reportName;
                rep.ObjectSpace = ObjectSpace;
                rep.LoadLayout(GetType().Assembly.GetManifestResourceStream(
                   "DXSample.Module.EmbeddedReports." + reportName + ".repx"));
                reportdata.SaveXtraReport(rep);
                reportdata.Save();
            }
        }
    }
}
