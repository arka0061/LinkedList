using LinkedList;
using NUnit.Framework;

namespace LinkedListTesting
{
    public class Tests
    {
     
        [Test]
        public void TestIfElement_IsPresent_OrNot()
        {
            LinkedLists list = new LinkedLists();
            list.Add(56);
            list.Add(30);
            list.Add(56);
            list.Search(30);
            int check = list.Search(30);
            Assert.AreEqual(1, check);

        }
        [Test]
        public void TestIfElement_IsInserted_OrNot()
        {
            LinkedLists list = new LinkedLists();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            int check = list.Search(30);
            if (check == 1)
            list.insertAtMid(40);
            int checkAgain = list.Search(40);
            Assert.AreEqual(1, checkAgain);
                
         }
    } 
}
