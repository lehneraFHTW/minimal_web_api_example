namespace minimal_api_new
{
    public class Employees
    {


        private List<string> _employees;


        public Employees()
        {
            _employees = new List<string>();
            
        }

        public void AddEmployee(string newEmployeeName)
        {   
            
            if (!_employees.Contains(newEmployeeName))
            {
                _employees.Add(newEmployeeName);
                return;
            }
            throw new Exception($"{newEmployeeName} is already an employee");
            

        }

        public List<string> GetAllEmplyees()
        {
            return _employees;
        }

        
    }
}
