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
        [Test]
        public void TestIfSize_Is_3()
        {
            LinkedLists list = new LinkedLists();
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);         
            list.DeleteNodeAtParticularPosition(2);
            int check = list.Size();
            Assert.AreEqual(3,check);
        }
    } 
}
