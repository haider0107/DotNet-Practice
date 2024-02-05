namespace BLL
{
    public class Employee
    {
        public int Id { get; set; }
        public String? Name { get; set; }

        public double SalPerDay { get; set; }

        public static double HRA { get; set; } = 12.5;

        public double CalculateSalary(int NoOfWorkingDays)
        {
            var totalSalary = (SalPerDay * NoOfWorkingDays) + (SalPerDay * NoOfWorkingDays) * HRA/100;
            return totalSalary;
        }
    }
}
