using ClosedXML.Excel;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

List<Employee> employees = new List<Employee>
{
    new Employee() { EmpID = 1, EmpName = "Test1", MobileNo = 1122334455 },
    new Employee() { EmpID = 2, EmpName = "Test2", MobileNo = 1188776655 }
};

ClosedXMLExport closedXMLExport = new ClosedXMLExport();

bool result = closedXMLExport.Export<Employee>(employees, @"C:\React_Projects\Employees.xlsx", "Employee List");

if (result)
{
    Console.WriteLine("Successfully created XLS Output file");
}

Console.ReadLine();

public class ClosedXMLExport
{
    public bool Export<T>(List<T> list, string FileName, string SheetName) 
    {
        bool exported = false;

        using(IXLWorkbook workbook = new XLWorkbook())
        {
            workbook.AddWorksheet(SheetName).FirstCell().InsertTable<T>(list, true);

            workbook.SaveAs(FileName);

            exported = true;
        }

        return exported;
    }
}

public class Employee
{ 
    public int EmpID { get; set; }

    public string? EmpName { get; set; }

    public int MobileNo { get; set; }
}