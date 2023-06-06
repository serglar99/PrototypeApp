using PdfSharp.Pdf;
using PrototypeApp.Model;
using System;
using System.IO;

namespace PrototypeApp.Services
{
    public static class PdfService
    {
        public static string EditHtmlTemplate(Report report)
        {
            DrillingMachine drillingMachine = DbService.GetDrillingMachineById(report.DrillingMachineId);
            CuttingMachine cuttingMachine = DbService.GetCuttingMachineById(report.CuttingMachineId);
            WeldingMachine weldingMachine = DbService.GetWeldingMachineById(report.WeldingMachineId);
            BendingMachine bendingMachine = DbService.GetBendingMachineById(report.BendingMachineId);
            Company company = DbService.GetCompanyById(report.SelectedCompany);
            string PdfTemplate = File.ReadAllText("PdfTemplate.html");
            string addData = String.Format(PdfTemplate, report.Name, report.Id, 
                report.BendingMachinesAmount, 
                report.DrillingMachinesAmount, report.CuttingMachinesAmount, report.WeldingMachinesAmount, drillingMachine.D_Name, drillingMachine.Cost, drillingMachine.CostM,
                cuttingMachine.C_Name, cuttingMachine.Cost, cuttingMachine.CostM,
                weldingMachine.V_Name, weldingMachine.Cost, weldingMachine.CostM,
                bendingMachine.G_Name, bendingMachine.Cost, bendingMachine.CostM);
            
            PdfExport(addData, report.Name);

            string strResponse = String.Format("расчет {0} экспортирован", report.Name);
            return strResponse;
        }

        public static void PdfExport(string html, string name)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            PdfPage page = new PdfPage();

            PdfDocument exportDocument = TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerator.GeneratePdf(html, PdfSharp.PageSize.A4);

            exportDocument.AddPage(page);

            exportDocument.Save(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{name}.pdf"));
            
        }
    }
}
