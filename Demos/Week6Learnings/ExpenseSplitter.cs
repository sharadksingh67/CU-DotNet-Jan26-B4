namespace Week6Learnings
{
    internal class ExpenseSplitter
    {
        static List<string> SettleExpenseShare(
            Dictionary<string, double> expenses)
        {
            List<string> settlement = new List<string>();   // csv string

            // Creditors or Debitors - 
            Queue<KeyValuePair<string, double>> receivers =
                        new Queue<KeyValuePair<string, double>>();

            Queue<KeyValuePair<string, double>> payers =
                        new Queue<KeyValuePair<string, double>>();

            var totalExpense = expenses.Values.Sum();
            var persons = expenses.Count;

            var share = totalExpense / persons;

            // populate payers and receivers queues
            foreach (var person in expenses)
            {
                if (person.Value > share)
                {
                    receivers.Enqueue(
                        new KeyValuePair<string, double>(person.Key,
                        (person.Value - share))
                        );
                }
                else if (person.Value < share)
                {
                    payers.Enqueue(
                        new KeyValuePair<string, double>(person.Key,
                        Math.Abs(person.Value - share))
                        );
                }
            }
            // settlement 
            while (payers.Count > 0 && receivers.Count > 0)
            {
                var payer = payers.Dequeue();
                var receiver = receivers.Dequeue();

                var amount = Math.Min(payer.Value, receiver.Value);

                settlement.Add($"{payer.Key},{receiver.Key},{amount}");

                if (payer.Value > amount)
                    payers.Enqueue(
                            new KeyValuePair<string, double>(payer.Key,
                            Math.Abs(amount - payer.Value))
                            );

                if (receiver.Value > amount)
                    receivers.Enqueue(
                            new KeyValuePair<string, double>(receiver.Key,
                            Math.Abs(amount - receiver.Value))
                            );

            }
            return settlement;
        }
        static void Main(string[] args)
        {

            Dictionary<string, double> expenses =
                new Dictionary<string, double>()
                    {
                        {"Amit", 4000},
                        {"Neha", 3000},
                        {"Rahul", 1500},
                        {"Pooja", 2500}
                    };

            List<string> settlement = SettleExpenseShare(expenses);

            foreach (var payment in settlement)
            {
                Console.WriteLine(payment);
            }


            // settlement item - from, to, amount
        }
    }
}
