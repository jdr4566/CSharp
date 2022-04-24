/*  Programmer : John-David Rodriguez
    Course: ITSE-1430
    Date: 4/24/2022
    IDE: Microsoft Visual Studio
    Description:   11.3 (Composition vs. Inheritance) Many apps written with inheritance could be written with composition instead, and vice versa.
                   Rewrite class BasePlusCommissionEmployee (Fig. 11.11) of the CommissionEmployee–BasePlusCommissionEmployee hierarchy 
                   to use composition rather than inheritance.
*/

using System;

namespace Module_11_Assignment { 
public class CommissionEmployee
{
    private string firstName;
    private string lastName;
    private string socialSecurityNumber;
    private decimal grossSales; // gross weekly sales
    private decimal commissionRate; // commission percentage

    // five-parameter constructor
    public CommissionEmployee(string first, string last, string ssn,
    decimal sales, decimal rate)
    {
        // implicit call to object constructor occurs here
        firstName = first;
        lastName = last;
        socialSecurityNumber = ssn;
        GrossSales = sales; // validate gross sales via property
        CommissionRate = rate; // validate commission rate via property
    } // end five-parameter CommissionEmployee constructor   

    // read-only property that gets commission employee's first name
    public string FirstName
    {
        get
        {
            return firstName;
        } // end get
    } // end property FirstName

    // read-only property that gets commission employee's last name
    public string LastName
    {
        get
        {
            return lastName;
        } // end get
    } // end property LastName

    // read-only property that gets
    // commission employee's social security number
    public string SocialSecurityNumber
    {
        get
        {
            return socialSecurityNumber;
        } // end get
    } // end property SocialSecurityNumber

    // property that gets and sets commission employee's gross sales
    public decimal GrossSales
    {
        get
        {
            return grossSales;
        } // end get
        set
        {
            if (value >= 0)
                grossSales = value;
            else
                throw new ArgumentOutOfRangeException(
                "GrossSales", value, "GrossSales must be >= 0");
        } // end set
    } // end property GrossSales

    // property that gets and sets commission employee's commission rate
    public decimal CommissionRate
    {
        get
        {
            return commissionRate;
        } // end get
        set
        {
            if (value > 0 && value < 10)
                commissionRate = value;
            else
                throw new ArgumentOutOfRangeException("CommissionRate",
                value, "CommissionRate must be > 0 and < 1");
        } // end set
    } // end property CommissionRate

    // calculate commission employee's pay
    public decimal Earnings()
    {
        return commissionRate * grossSales;
    } // end method Earnings   

    // return string representation of CommissionEmployee object
    public override string ToString()
    {
        return string.Format(
        "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
        "commission employee", FirstName, LastName,
        "social security number", SocialSecurityNumber,
        "gross sales", GrossSales, "commission rate", CommissionRate);
    } // end method ToString
} // end class CommissionEmployee

public class BasePlusCommissionEmployee
{
    private decimal baseSalary; // base salary per week
    private CommissionEmployee commissionEmployee;
    // six-parameter constructor
    public BasePlusCommissionEmployee(string first, string last,
    string ssn, decimal sales, decimal rate, decimal salary)

    {
        commissionEmployee = new CommissionEmployee(first, last, ssn, sales, rate);
        BaseSalary = salary; // validate base salary via property
    } // end six-parameter BasePlusCommissionEmployee constructor

    // property that gets and sets
    // base-salaried commission employee's base salary
    public decimal BaseSalary
    {
        get
        {
            return baseSalary;
        } // end get
        set
        {
            if (value >= 0)
                baseSalary = value;
            else
                throw new ArgumentOutOfRangeException("BaseSalary",
                value, "BaseSalary must be >= 0");
        } // end set
    } // end property BaseSalary

    // calculate earnings; override method Earnings in CommissionEmployee
    public decimal Earnings()
    {
        return BaseSalary + commissionEmployee.Earnings();
    } // end method Earnings

    // return string representation of BasePlusCommissionEmployee object
    public override string ToString()
    {
        return string.Format("base-salaried {0}; base salary: {1:C}",
        commissionEmployee.ToString(), BaseSalary);
    } // end method ToString   
} // end class BasePlusCommissionEmployee

class Program
{
    static void Main(string[] args)
    {
        BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("John", "Mike", "110-2202", 50, 0.34m, 3000);
        Console.WriteLine(basePlusCommissionEmployee);
        Console.WriteLine("Total Earnings: {0}", basePlusCommissionEmployee.Earnings());
    }
}
}
