// using System;
// using NUnit.Framework;
// using queue;

// namespace tests
// {
//     [TestFixture]
//     public class QueueTests
//     {
//         [Test]
//         public void Capacity_EnqueueManyItems_DoubleCapacity()
//         {
//             var queue = new ArrayQueue<int>();
//             queue.Enqueue(1);
//             queue.Enqueue(2);
//             queue.Enqueue(3);
//             queue.Enqueue(4);
//             queue.Enqueue(5);

//             Assert.AreEqual(8, queue.Capacity);

//         }

//         [Test]
//         public void IsEmpty_EmptyQueue_ReturnsTrue()
//         {
//             var queue = new ArrayQueue<int>();
//             Assert.IsTrue(queue.IsEmpty);
//         }

//         [Test]
//         public void Count_EnqueueOneItem_ReturnsOne()
//         {
//             var queue = new ArrayQueue<int>();
//             queue.Enqueue(1);

//             Assert.AreEqual(1, queue.Count);
//             Assert.IsFalse(queue.IsEmpty);
//         }

//         [Test]
//         public void Dequeue_EmptyQueue_ThrowsException()
//         {
//             var queue = new ArrayQueue<int>();

//             Assert.Throws<InvalidOperationException>(() => { queue.Dequeue(); });
//         }

//         [Test]
//         public void Peek_EnqueueTwoItemsAndDequeue_ReturnsHeadElement()
//         {
//             var queue = new ArrayQueue<int>();
//             queue.Enqueue(1);
//             queue.Enqueue(2);

//             queue.Dequeue();

//             Assert.AreEqual(2, queue.Peek());
//         }
//     }
// }