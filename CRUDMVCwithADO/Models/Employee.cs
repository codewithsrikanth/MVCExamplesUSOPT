namespace CRUDMVCwithADO.Models
{
    //DB table => Contract/POCO/Model
    public class Employee
    {
        public int Eno { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public string Dname { get; set; }
    }
}