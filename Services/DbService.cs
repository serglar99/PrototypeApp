using Microsoft.EntityFrameworkCore.Query;
using PrototypeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;

namespace PrototypeApp.Services
{
    public static class DbService
    {

        public static List<Report> GetAllReports()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Reports.ToList();
                return result;
            }
        }

        public static List<BendingMachine> GetAllBendingMachines()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.BendingMachines.ToList();
                return result;
            }
        }

        public static List<DrillingMachine> GetAllDrillingMachines()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.DrillingMachines.ToList();
                return result;
            }
        }

        public static List<CuttingMachine> GetAllCuttingMachines()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.CuttingMachines.ToList();
                return result;
            }
        }

        public static List<WeldingMachine> GetAllWeldingMachines()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.WeldingMachines.ToList();
                return result;
            }
        }

        public static List<Company> GetAllCompanies()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Companies.ToList();
                return result;
            }
        }


        public static string CreateReport(Guid company)
        {
            Settings data = GetSettings();

            Company data_com = GetCompanyById(company);

            if (data == null)
            {
                data = new Settings();

            }

            int cuttingMachinesAmount = (int)Math.Ceiling((data_com.CountM/ (250 * 1.2 * data.Ks * data.Kzc)) * data.Kcpod);

            int bendingListAmount = ((100 * data.G * data_com.Vprog) / (data.Mb));

            int bendingMachinesAmount = (int)Math.Ceiling(((bendingListAmount) / (data.F * data.Pb * data.Ks * data.Kzb)) * data.Kbpod);

            int drillingListAmount = ((100 * 40 * data_com.Vprog) / (data.Mb));

            int drillingMachinesAmount = (int)Math.Ceiling(((drillingListAmount) / (data.F * data.Pd * data.Ks * data.Kzd)) * data.Kdpod);

            int weldingMachinesAmount = (int)Math.Ceiling(data_com.Vprog/((data.Isv * data.An * data.Kzw) / 1000)/data.Kn);

            var drillingMachines = GetAllDrillingMachines();

            var bendingMachines = GetAllBendingMachines();

            var cuttingMachines = GetAllCuttingMachines();

            var weldingMachines = GetAllWeldingMachines();

            DrillingMachine minDrillingMachine = drillingMachines.Where((x) => x.Cost == drillingMachines.Min(y => y.Cost)).FirstOrDefault();

            CuttingMachine minCuttingMachine = cuttingMachines.Where((x) => x.Cost == cuttingMachines.Min(y => y.Cost)).FirstOrDefault();

            BendingMachine minBendingMachine = bendingMachines.Where((x) => x.Cost == bendingMachines.Min(y => y.Cost)).FirstOrDefault();

            WeldingMachine minWeldingMachine = weldingMachines.Where((x) => x.Cost == weldingMachines.Min(y => y.Cost)).FirstOrDefault();



            using (ApplicationContext db = new ApplicationContext())
            {

                Report newReport = new Report()
                {
                    Name = data_com.Com_Name,
                    BendingMachinesAmount = bendingMachinesAmount,
                    CuttingMachinesAmount = cuttingMachinesAmount,
                    DrillingMachinesAmount =  drillingMachinesAmount,
                    WeldingMachinesAmount = weldingMachinesAmount,
                    DrillingMachineId = minDrillingMachine.Id,
                    CuttingMachineId = minCuttingMachine.Id,
                    WeldingMachineId = minWeldingMachine.Id,
                    BendingMachineId = minBendingMachine.Id,
                    CreatedAt = DateTime.Now,
                    
                };

                db.Reports.Add(newReport);
                db.SaveChanges();
            }
            return "Расчет создан";
        }

        public static string SaveBendingMachine(Guid id, string name, string country, string company,  string town, int cost, int costM, string date, int time, int pkh, int ptc, int bmax, int lmax,
            int sod, int sdv, int massa, int lbh, int energ, int nun, int ngn, string vi )
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                string strResponse = "";
                bool isExist = db.BendingMachines.Any(el => el.Id == id);
    
                if (!isExist)
                {
                    BendingMachine newMachine = new BendingMachine
                    {
                        G_Name = name,
                        Country = country,
                        Company= company,
                        Town = town,
                        Cost = cost,
                        CostM = costM,
                        Date = date,
                        Time = time,
                        Pkh = pkh,
                        Ptc = ptc,
                        Bmax = bmax,
                        Lmax = lmax,
                        Sod = sod,
                        Sdv = sdv,
                        Massa = massa,
                        LBH = lbh,
                        Energ = energ,
                        NUN = nun,
                        NGN = ngn,
                        VI = vi
                        
                    };
                    db.BendingMachines.Add(newMachine);
                    db.SaveChanges();
                    strResponse = "Cтанок " + newMachine.G_Name + " добавлен";
                }
                else
                {
                    BendingMachine bendingMachine = db.BendingMachines.FirstOrDefault(p => p.Id == id);
                    {
                        bendingMachine.G_Name = name;
                        bendingMachine.Country = country;
                        bendingMachine.Company = company;
                        bendingMachine.Town = town;
                        bendingMachine.Cost = cost;
                        bendingMachine.CostM = costM;
                        bendingMachine.Date = date;
                        bendingMachine.Time = time;
                        bendingMachine.Pkh = pkh;
                        bendingMachine.Ptc = ptc;
                        bendingMachine.Bmax = bmax;
                        bendingMachine.Lmax = lmax;
                        bendingMachine.Sod = sod;
                        bendingMachine.Sdv = sdv;
                        bendingMachine.Massa = massa;
                        bendingMachine.LBH = lbh;
                        bendingMachine.Energ = energ;
                        bendingMachine.NUN = nun;
                        bendingMachine.NGN = ngn;
                        bendingMachine.VI = vi;
                        db.SaveChanges();
                        strResponse = "Cтанок " + bendingMachine.G_Name + " изменен";
                    }
                }
                return strResponse;
            }
        }

        public static string SaveCuttingMachine(Guid id, string name, string country, string company, string town, int cost, int costM, string date, int time, int l, int b, int vmax, int vtra,
          int abr, int vs, int massa, int energ, int nun, int ngn, string vi, string abrm, int ppump, int pnom)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                string strResponse = "";
                bool isExist = db.CuttingMachines.Any(el => el.Id == id);

                if (!isExist)
                {
                    CuttingMachine newMachine = new CuttingMachine
                    {
                        C_Name = name,
                        Country = country,
                        Company = company,
                        Town = town,
                        Cost = cost,
                        CostM = costM,
                        Date = date,
                        Time = time,
                        L = l,
                        B = b,
                        Vmax = vmax,
                        Vtra = vtra,
                        Abr = abr,
                        Vs = vs,
                        Massa = massa,
                        Energ = energ,
                        NUN = nun,
                        NGN = ngn,
                        VI = vi,
                        AbrM = abrm,
                        Ppump = ppump,
                        Pnom = pnom,

                    };
                    db.CuttingMachines.Add(newMachine);
                    db.SaveChanges();
                    strResponse = "Cтанок " + newMachine.C_Name + " добавлен";
                }
                else
                {
                    CuttingMachine cuttingMachine = db.CuttingMachines.FirstOrDefault(p => p.Id == id);
                    {
                        cuttingMachine.C_Name = name;
                        cuttingMachine.Country = country;
                        cuttingMachine.Company = company;
                        cuttingMachine.Town = town;
                        cuttingMachine.Cost = cost;
                        cuttingMachine.CostM = costM;
                        cuttingMachine.Date = date;
                        cuttingMachine.Time = time;
                        cuttingMachine.L = l;
                        cuttingMachine.B = b;
                        cuttingMachine.Vmax = vmax;
                        cuttingMachine.Vtra = vtra;
                        cuttingMachine.Abr = abr;
                        cuttingMachine.Vs = vs;
                        cuttingMachine.Massa = massa;
                        cuttingMachine.Energ = energ;
                        cuttingMachine.NUN = nun;
                        cuttingMachine.NGN = ngn;
                        cuttingMachine.VI = vi;
                        cuttingMachine.AbrM = abrm;
                        cuttingMachine.Ppump = ppump;
                        cuttingMachine.Pnom = pnom;
                        db.SaveChanges();
                        strResponse = "Cтанок " + cuttingMachine.C_Name + " изменен";
                    }
                }
                return strResponse;
            }
        }

        public static string SaveDrillingMachine(Guid id, string name, string country, string town, string company, int cost, int costM, string date, int time, double massa,
            string lbh, int energ,int sumn, int nun, int ngn, string vi, int dmax, int e1, int e2, int emax)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                string strResponse = "";
                bool isExist = db.DrillingMachines.Any(el => el.Id == id);

                if (!isExist)
                {
                    DrillingMachine newMachine = new DrillingMachine
                    {
                        D_Name = name,
                        Country = country,
                        Company = company,
                        Town = town,
                        Cost = cost,
                        CostM = costM,
                        Date = date,
                        Time = time,
                        Massa = massa,
                        LBH = lbh,
                        Energ = energ,
                        SumN = sumn,
                        NUN = nun,
                        NGN = ngn,
                        VI = vi,
                        Dmax = dmax,
                        E1 = e1,
                        E2 = e2,
                        Emax = emax
                    };
                    db.DrillingMachines.Add(newMachine);
                    db.SaveChanges();
                    strResponse = "Cтанок " + newMachine.D_Name + " добавлен";
                }
                else
                {
                    DrillingMachine drillingMachine = db.DrillingMachines.FirstOrDefault(p => p.Id == id);
                    {
                        drillingMachine.D_Name = name;
                        drillingMachine.Country = country;
                        drillingMachine.Company = company;
                        drillingMachine.Town = town;
                        drillingMachine.Cost = cost;
                        drillingMachine.CostM = costM;
                        drillingMachine.Date = date;
                        drillingMachine.Time = time;                        
                        drillingMachine.Massa = massa;
                        drillingMachine.LBH = lbh;
                        drillingMachine.Energ = energ;
                        drillingMachine.SumN= sumn;
                        drillingMachine.NUN = nun;
                        drillingMachine.NGN = ngn;
                        drillingMachine.VI = vi;
                        drillingMachine.Dmax = dmax;
                        drillingMachine.E1 = e1;
                        drillingMachine.E2 = e2;
                        drillingMachine.Emax = emax;
                        db.SaveChanges();
                        strResponse = "Cтанок " + drillingMachine.D_Name + " изменен";
                    }
                }
                return strResponse;
            }
        }

        public static string SaveWeldingMachine(Guid id, string name, string country, string company, string town, int cost, int costM, string date, int time, int massa, int lbh, int pmax,
            int nun, int ngn, string vi, int arg, int parg, string specifacation)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                string strResponse = "";
                bool isExist = db.WeldingMachines.Any(el => el.Id == id);

                if (!isExist)
                {
                    WeldingMachine newMachine = new WeldingMachine
                    {
                        V_Name = name,
                        Country = country,
                        Company = company,
                        Town = town,
                        Cost = cost,
                        CostM = costM,
                        Date = date,
                        Time = time,
                        Massa = massa,
                        LBH = lbh,
                        Pmax = pmax,
                        NUN = nun,
                        NGN = ngn,
                        VI = vi,
                        Arg = arg,
                        Parg = parg,
                        Specification = specifacation

                    };
                    db.WeldingMachines.Add(newMachine);
                    db.SaveChanges();
                    strResponse = "Cтанок " + newMachine.V_Name + " добавлен";
                }
                else
                {
                    WeldingMachine weldingMachine = db.WeldingMachines.FirstOrDefault(p => p.Id == id);
                    {
                        weldingMachine.V_Name = name;
                        weldingMachine.Country = country;
                        weldingMachine.Company = company;
                        weldingMachine.Town = town;
                        weldingMachine.Cost = cost;
                        weldingMachine.CostM = costM;
                        weldingMachine.Date = date;
                        weldingMachine.Time = time;
                        weldingMachine.Massa = massa;
                        weldingMachine.LBH = lbh;
                        weldingMachine.Pmax = pmax;
                        weldingMachine.NUN = nun;
                        weldingMachine.NGN = ngn;
                        weldingMachine.VI = vi;
                        weldingMachine.Arg = arg;
                        weldingMachine.Parg = parg;
                        weldingMachine.Specification = specifacation;
                        db.SaveChanges();
                        strResponse = "Cтанок " + weldingMachine.V_Name + " изменен";
                    }
                }
                return strResponse;
            }
        }

        public static string SaveCompany(Guid id, string name, int region, int shift, int week, int vprog, string program, string appProgram, int rm, int countm)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                string strResponse = "";
                bool isExist = db.Companies.Any(el => el.Id == id);

                if (!isExist)
                {
                    Company newCompany = new Company
                    {
                        Com_Name = name,
                        Region = region,
                        Shift = shift,
                        Week = week,
                        Vprog = vprog,
                        Program = program,
                        AppProgram = appProgram,
                        Rm = rm,
                        CountM= countm

                    };
                    db.Companies.Add(newCompany);
                    db.SaveChanges();
                    strResponse = "Предприятие " + newCompany.Com_Name + " добавлено";
                }
                else
                {
                    Company company = db.Companies.FirstOrDefault(p => p.Id == id);
                    {
                        company.Com_Name = name;
                        company.Region = region;
                        company.Shift = shift;
                        company.Week = week;
                        company.Vprog = vprog;
                        company.Program = program;
                        company.AppProgram = appProgram;
                        company.Rm = rm;
                        company.CountM = countm;
                        db.SaveChanges();
                        strResponse = "Предприятие " + company.Com_Name + " изменено";
                    }
                }
                return strResponse;
            }
        }

            public static string DeleteBendingMachine(BendingMachine bendingMachine)
        {
            string result = "Станок не найден";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.BendingMachines.Remove(bendingMachine);
                db.SaveChanges();
                result = "Cтанок " + bendingMachine.G_Name + " удален";
            }
            return result;
        }

        public static string DeleteDrillingMachine(DrillingMachine drillingMachine)
        {
            string result = "Станок не найден";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.DrillingMachines.Remove(drillingMachine);
                db.SaveChanges();
                result = "Cтанок " + drillingMachine.D_Name + " удален";
            }
            return result;
        }

        public static string DeleteCuttingMachine(CuttingMachine cuttingMachine)
        {
            string result = "Станок не найден";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.CuttingMachines.Remove(cuttingMachine);
                db.SaveChanges();
                result = "Cтанок " + cuttingMachine.C_Name + " удален";
            }
            return result;
        }

        public static string DeleteWeldingMachine(WeldingMachine weldingMachine)
        {
            string result = "Станок не найден";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.WeldingMachines.Remove(weldingMachine);
                db.SaveChanges();
                result = "Cтанок " + weldingMachine.V_Name + " удален";
            }
            return result;
        }

        public static string DeleteCompany(Company Company)
        {
            string result = "Предприятие не найдено";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Companies.Remove(Company);
                db.SaveChanges();
                result = "Предприятие " + Company.Com_Name + " удалено";
            }
            return result;
        }
        public static Report GetReportById(Guid id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Report pos = db.Reports.FirstOrDefault(p => p.Id == id);
                return pos;
            }
        }

        public static DrillingMachine GetDrillingMachineById(Guid id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                DrillingMachine pos = db.DrillingMachines.FirstOrDefault(p => p.Id == id);
                return pos;
            }
        }

        public static CuttingMachine GetCuttingMachineById(Guid id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                CuttingMachine pos = db.CuttingMachines.FirstOrDefault(p => p.Id == id);
                return pos;
            }
        }
        public static WeldingMachine GetWeldingMachineById(Guid id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                WeldingMachine pos = db.WeldingMachines.FirstOrDefault(p => p.Id == id);
                return pos;
            }
        }
        public static BendingMachine GetBendingMachineById(Guid id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                BendingMachine pos = db.BendingMachines.FirstOrDefault(p => p.Id == id);
                return pos;
            }
        }
        public static Company GetCompanyById(Guid id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Company pos = db.Companies.FirstOrDefault(p => p.Id == id);
                return pos;
            }
        }
        public static Settings GetSettings()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                {
                    Settings result = db.Settings.FirstOrDefault();
                    return result;
                }
            }

        }

        public static int CreateReportMathHelper(int amount)
        {
            CalculationData data = new CalculationData();

            int formResult = (int)Math.Ceiling((amount /
            (data.workingDaysInYear * data.CuttListAmount *
            data.changeRatio * data.CuttMachineLoadRatio)) * data.maintenanceRatio);

            return formResult;
        }
    }
}
