namespace minimal_api_new
{
    public class DataManager
    {
        private Employees _employees;
        public DataManager()
        {
            _employees = new Employees();
            AddSampleData();
        }

        private void AddSampleData()
        {
            _employees.AddEmployee("Jeff Bezos");
            _employees.AddEmployee("Mark Zuckerberg");
            _employees.AddEmployee("Satya Nadella");
        }

        public List<string> GetEmployees()
        {
            return _employees.GetAllEmplyees();
        }


        public void AddEmployess(string newEmployeeName)
        {
            try
            {
                _employees.AddEmployee(newEmployeeName);
            }
                catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
