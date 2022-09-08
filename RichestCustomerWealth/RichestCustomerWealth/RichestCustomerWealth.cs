namespace RichestCustomerWealth;

public class RichestCustomer
{
    public int MaximumWealth(int[][] accounts)
    {
        int maxWealth = 0;
        for (var m = 0; m < accounts.GetLength(0); m++)
        {
            var wealth = accounts[m].Sum();

            if (wealth <= maxWealth)
                continue;

            maxWealth = wealth;
        }

        return maxWealth;
    }

    public int MaximumWealthLinq(int[][] accounts)
    {
        return accounts.Select(r => r.Sum()).Max();
    }
}