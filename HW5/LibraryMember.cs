public class LibraryMember
{
    // Public fields
    public string MemberName;
    public int OverdueDays;

    // Private fields
    private double totalFine;
    private static int memberCount = 0;

    // Constructor
    public LibraryMember(string memberName, int overdueDays)
    {
        MemberName = memberName;
        OverdueDays = overdueDays;
        memberCount++;
    }

    // Calculate the total overdue fine
    public void CalcTotalFine()
    {
        totalFine = OverdueDays * 5;

        if (OverdueDays > 7)
        {
            totalFine += 10;
        }

        if (totalFine < 0)
        {
            totalFine = 0;
        }
    }

    // Display member information
    public void PrintInfo()
    {
        Console.WriteLine($"{MemberName} owes ${totalFine} in fines.");
    }

    // Return the total number of members
    public static int GetMemberCount()
    {
        return memberCount;
    }
}