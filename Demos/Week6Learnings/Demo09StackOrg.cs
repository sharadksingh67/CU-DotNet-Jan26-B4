//namespace Week6Learnings
//{
//    // The individual data node
//    class EmployeeNode
//    {
//        public string Name { get; set; }
//        public string Position { get; set; }
//        public List<EmployeeNode> Reports { get; set; } = new List<EmployeeNode>();

//        public EmployeeNode(string name, string position)
//        {
//            Name = name;
//            Position = position;
//        }

//        public void AddReport(EmployeeNode employee) => Reports.Add(employee);
//    }

//    // The Tree Wrapper
//    class OrganizationTree
//    {
//        public EmployeeNode Root { get; set; }

//        public OrganizationTree(EmployeeNode root) => Root = root;

//        // METHOD 1: The Stack Logic (The "Discovery" Phase)
//        // This method only cares about the order of visits.
//        public List<(EmployeeNode Node, int Level)> GetNodesViaStack()
//        {
//            var visitedNodes = new List<(EmployeeNode, int)>();
//            if (Root == null) return visitedNodes;

//            Stack<(EmployeeNode Node, int Level)> stack = new Stack<(EmployeeNode, int)>();
//            stack.Push((Root, 0));

//            while (stack.Count > 0)
//            {
//                var current = stack.Pop();
//                visitedNodes.Add(current); // Store the node and its level

//                // Add children to the stack to be processed next
//                for (int i = current.Node.Reports.Count - 1; i >= 0; i--)
//                {
//                    stack.Push((current.Node.Reports[i], current.Level + 1));
//                }
//            }
//            return visitedNodes;
//        }

//        // METHOD 2: The FlatList Logic (The "Presentation" Phase)
//        // This method takes the raw stack data and makes it readable.
//        public List<string> FormatAsFlatList(List<(EmployeeNode Node, int Level)> rawNodes)
//        {
//            List<string> displayList = new List<string>();

//            foreach (var item in rawNodes)
//            {
//                string indent = new string(' ', item.Level * 4);
//                string line = $"{indent}└── {item.Node.Name} [{item.Node.Position}]";
//                displayList.Add(line);
//            }

//            return displayList;
//        }

//        //public List<string> ConvertTreeToFlattenedList()
//        //{
//        //    // This is our final linear result
//        //    List<string> linearList = new List<string>();

//        //    if (Root == null) return linearList;

//        //    // Our "To-Do" Stack
//        //    Stack<(EmployeeNode Node, int Level)> stack = new Stack<(EmployeeNode, int)>();
//        //    stack.Push((Root, 0));

//        //    while (stack.Count > 0)
//        //    {
//        //        var (current, level) = stack.Pop();

//        //        // Correlation: Each 'Level' becomes 4 spaces in our string list
//        //        string indentation = new string(' ', level * 4);
//        //        linearList.Add($"{indentation}{current.Name} ({current.Position})");

//        //        // Push children in reverse to keep the "Top-to-Bottom" visual order
//        //        for (int i = current.Reports.Count - 1; i >= 0; i--)
//        //        {
//        //            stack.Push((current.Reports[i], level + 1));
//        //        }
//        //    }

//        //    return linearList;
//        //}

//        public void Display()
//        {
//            if (Root == null) return;

//            // Stack stores the node and its depth (indentation level)
//            Stack<(EmployeeNode Node, int Level)> stack = new Stack<(EmployeeNode, int)>();

//            // Push the root to start
//            stack.Push((Root, 0));

//            Console.WriteLine("ITERATIVE ORGANIZATION CHART");
//            Console.WriteLine("============================");

//            while (stack.Count > 0)
//            {
//                // Pop the current item
//                var (current, level) = stack.Pop();

//                // Format and print
//                string indent = new string(' ', level * 4);
//                string connector = level == 0 ? "* " : "└── ";
//                Console.WriteLine($"{indent}{connector}{current.Name} [{current.Position}]");

//                // Push children in REVERSE order. 
//                // Why? Because it's a Stack (LIFO). Pushing the last child first 
//                // ensures the first child is the one popped next.
//                for (int i = current.Reports.Count - 1; i >= 0; i--)
//                {
//                    stack.Push((current.Reports[i], level + 1));
//                }
//            }
//        }
//    }

//    internal class Demo09StackOrg
//    {
//        static void Main(string[] args)
//        {
//            // 1. Create the nodes
//            var ceo = new EmployeeNode("Jordan Smith", "CEO");
//            var cto = new EmployeeNode("Alex Chen", "CTO");
//            var cfo = new EmployeeNode("Maria Garcia", "CFO");
//            var devLead = new EmployeeNode("Sam Rivera", "Engineering Lead");
//            var dev1 = new EmployeeNode("Casey L.", "Software Engineer");
//            var dev2 = new EmployeeNode("Robin P.", "Software Engineer");
//            var accountant = new EmployeeNode("Terry W.", "Senior Accountant");

//            // 2. Link them (Building the Tree)
//            ceo.AddReport(cto);
//            ceo.AddReport(cfo);

//            cto.AddReport(devLead);
//            devLead.AddReport(dev1);
//            devLead.AddReport(dev2);

//            cfo.AddReport(accountant);

//            // 3. Initialize the Tree and Display
//            var company = new OrganizationTree(ceo);

//            company.Display();

//            //// Step 1: Use the Stack to get the chronological order
//            //var rawData = company.GetNodesViaStack();

//            //foreach (var data in rawData)
//            //{
//            //    Console.WriteLine($"{data.Node.Position,30} {data.Level,10}");
//            //}

//            //// Step 2: Convert that raw data into a list of formatted strings
//            //List<string> printableList = company.FormatAsFlatList(rawData);

//            //Console.WriteLine("-------------------------------");

//            //// Step 3: Simply print the list
//            //foreach (var line in printableList)
//            //{
//            //    Console.WriteLine(line);
//            //}

//            ////// Convert the complex tree into a simple list
//            ////List<string> flatList = company.ConvertTreeToFlattenedList();

//            ////// Now we can treat it like any normal list!
//            ////foreach (string line in flatList)
//            ////{
//            ////    Console.WriteLine(line);
//            ////}



//        }
//    }
//}