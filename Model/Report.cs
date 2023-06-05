using System;
using System.ComponentModel.DataAnnotations;

namespace PrototypeApp.Model
{
    public class Report
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(256)]
        public string Name { get; set; }

        public int BendingMachinesAmount { get; set; }

        public int DrillingMachinesAmount { get; set; }

        public int CuttingMachinesAmount { get; set; }

        public int WeldingMachinesAmount { get; set; }

        public DateTime CreatedAt { get; set; }

        public Guid DrillingMachineId { get; set; }
        public Guid CuttingMachineId { get; set; }
        public Guid WeldingMachineId { get; set; }
        public Guid BendingMachineId { get; set; }
        public Guid CompanyId { get; set; }
        public Guid SelectedCompany { get; set; }
    }
}
