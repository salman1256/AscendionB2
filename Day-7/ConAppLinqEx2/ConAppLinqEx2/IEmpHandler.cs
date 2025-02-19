using System.Collections.Generic;
namespace ConAppLinqEx2
{
    public  interface IEmpHandler
    {
        IEnumerable<Emp> GetAllEmps();
        Emp GetEmpById(int id);
        Emp GetEmpByName(string name);
        void UpdateEmp(Emp emp);
        void DeleteEmp(int id);
        void CreateEmp(Emp emp);
    }
}
