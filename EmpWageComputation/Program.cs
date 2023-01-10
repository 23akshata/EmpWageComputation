// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Employee Wage");

internal class UC4_EmpWageUsingSwitch
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int EMP_RATE_PER_HOUR = 20;
    public static void EmpWageUsingSwitch()
    {
        //Variables
        int empHrs = 0;
        int empWage = 0;
        Random random = new Random();
        //Computation
        int empCheck = random.Next(0, 3);
        switch (empCheck)
        {
            case IS_PART_TIME:
                empHrs = 4;
                break;
            case IS_FULL_TIME:
                empHrs = 8;
                break;
            default:
                empHrs = 0;
                break;

        }
        empWage = empHrs * EMP_RATE_PER_HOUR;
        Console.WriteLine("Emp Wage : " + empWage);
    }
}

