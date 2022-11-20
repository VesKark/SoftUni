internal class Program
{
    private static void Main(string[] args)
    {
        SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();
        string input = string.Empty;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] inputData = input.Split(" -> ");
            string companyName = inputData[0];
            string employeeID = inputData[1];

            if (!companies.ContainsKey(companyName))
            { 
                companies.Add(companyName, new List<string> { employeeID });
            }
            else if (!companies[companyName].Contains(employeeID))
            {
                companies[companyName].Add(employeeID);
            }
        }

        foreach (var company in companies)
        {
            Console.WriteLine(company.Key);

            foreach (string employeeID in company.Value)
            {
                Console.WriteLine($"-- {employeeID}");
            }
        }
    }
}