using System.Collections.Generic;
using System.Linq;

namespace AdapterPattern
{
    public class EmployeeAdapter:ITarget
    {
        private HRSystem _hrSystem;

        public EmployeeAdapter(HRSystem hrSystem)
        {
            _hrSystem = hrSystem;
        }

        public List<string> GetEmployeeList()
        {
            List<string> employeesList = new List<string>();
            foreach (var employee in _hrSystem.GetEmployees())
            {
                employeesList.AddRange(employee);
                employeesList.Add("\n");
            }
            return employeesList;
        }
    }
}