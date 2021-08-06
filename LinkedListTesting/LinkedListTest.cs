using LinkedList;
using NUnit.Framework;

namespace LinkedListTesting
{
    public class Tests
    {
     
        [Test]
        public void Test1()
        {
            LinkedLists list = new LinkedLists();
            list.Add(56);
            list.Add(30);
            list.Add(56);
            list.Search(30);
            int check = list.Search(30);
            Assert.AreEqual(1, check);

        }
    }
}