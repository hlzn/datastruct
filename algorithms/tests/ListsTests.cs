// using System;
// using lists;
// using NUnit.Framework;

// namespace tests
// {
//     [TestFixture]
//     public class ListsTests
//     {
//         private SinglyLinkedList<int> _singleList;
//         private DoublyLinkedList<int> _doublyList;

//         [SetUp]
//         public void Init()
//         {
//             _singleList = new SinglyLinkedList<int>();
//             _doublyList = new DoublyLinkedList<int>();
//         }

//         [Test]
//         public void CreateEmptyList_CorrectState()
//         {
//             Assert.IsTrue(_singleList.IsEmpty);
//             Assert.IsNull(_singleList.Tail);
//             Assert.IsNull(_singleList.Head);

//         }

//         [Test]
//         public void AddFirst_AddLast_CorrectState()
//         {
//             _singleList.AddFirst(1);
//             ChecksStateWithSingleNode(_singleList);
//             _singleList.RemoveFirst();
//             _singleList.AddLast(1);
//             ChecksStateWithSingleNode(_singleList);
//         }

//         [Test]
//         public void AddRemoveToGetToStateWithSingleNode_CorrectState()
//         {
//             _singleList.AddFirst(1);
//             _singleList.AddFirst(2);
//             _singleList.RemoveFirst();
//             ChecksStateWithSingleNode(_singleList);

//             _singleList.AddFirst(2);
//             _singleList.RemoveLast();
//             ChecksStateWithSingleNode(_singleList);
//         }

//         [Test]
//         public void AddFirst_AddLast_AddItemsInCorrectOrder()
//         {
//             _singleList.AddFirst(1);
//             _singleList.AddFirst(2);

//             Assert.AreEqual(2, _singleList.Head.Value);
//             Assert.AreEqual(1, _singleList.Tail.Value);

//             _singleList.AddLast(3);
//             Assert.AreEqual(3, _singleList.Tail.Value);
//         }

//         [Test]
//         public void RemoveFirst_EmptyList_Throws()
//         {
//             Assert.Throws<InvalidOperationException>(() => _singleList.RemoveFirst());
//         }

//         [Test]
//         public void RemoveFirst_RemoveLast_CorrentState()
//         {
//             _singleList.AddFirst(1);
//             _singleList.AddFirst(2);
//             _singleList.AddFirst(3);
//             _singleList.AddFirst(4);

//             _singleList.RemoveFirst();
//             _singleList.RemoveLast();

//             Assert.AreEqual(3, _singleList.Head.Value);
//             Assert.AreEqual(2, _singleList.Tail.Value);
//         }

//         private void ChecksStateWithSingleNode(SinglyLinkedList<int> list)
//         {
//             Assert.AreEqual(1, list.Count);
//             Assert.IsFalse(list.IsEmpty);
//             Assert.AreSame(list.Head, list.Tail);
//         }
//     }
// }