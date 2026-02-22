//namespace Week6Learnings
//{
//    class Friend
//    {
//        public string Name { get; set; }
//        public List<Friend> Friends { get; set; } = new List<Friend>();

//        public Friend(string name)
//        {
//            Name = name;
//        }

//        public void AddFriend(Friend friend)
//        {
//            if (!Friends.Contains(friend))
//            {
//                Friends.Add(friend);
//                friend.Friends.Add(this);
//            }
//        }
//    }

//    class SocialNetwork
//    {
//        List<Friend> network = new List<Friend>();

//        public void AddMember(Friend friend)
//        {
//            network.Add(friend);
//        }

//        public void ShowNetwork()
//        {
//            foreach (Friend friend in network)
//            {
//                List<string> friendNames = new List<string>();
//                foreach (var person in friend.Friends)
//                {
//                    friendNames.Add(person.Name);
//                }
//                Console.WriteLine($"{friend.Name} has friendship with {string.Join(", ",friendNames)}");
//            }            
//        }
//    }

//    internal class Demo07FriendsNetwork
//    {
//        static void Main(string[] args)
//        {
//            var network = new SocialNetwork();

//            var Aman = new Friend("Aman");
//            var Bhaskar = new Friend("Bhaskar");
//            var Chetan = new Friend("Chetan");
//            var Dinkar = new Friend("Dinkar");

//            network.AddMember(Aman);
//            network.AddMember(Bhaskar);
//            network.AddMember(Chetan);
//            network.AddMember(Dinkar);

//            Aman.AddFriend(Bhaskar);
//            Bhaskar.AddFriend(Chetan);
//            Chetan.AddFriend(Aman);
//            Chetan.AddFriend(Dinkar);

//            network.ShowNetwork();

//        }
//    }
//}
