using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program

{
	public static void Main(string[] args)
	{
        User user1 = new User("msm");

        user1.app.countTotalIncome(10000);
        user1.app.countTotalOutcome(10);
        user1.app.countTotalOutcome(250);

        user1.app.getBalance();
        user1.app.getAnalysys();

	}
}