using System;
using NUnit.Framework;
using stacks;

namespace tests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            var stack = new ArrayStack<int>();
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void Count_PushOneItem_ReturnsOne()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);

            Assert.AreEqual(1, stack.Count);
            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void Peek_PushTwoItems_ReturnsHeadItem()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);
            stack.Push(2);

            Assert.AreEqual(2, stack.Peek());
        }

        [Test]
        public void Peek_PushTwoItemsAndPop_ReturnsHeadElement()
        {
            var stack = new ArrayStack<int>();
            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            Assert.AreEqual(1, stack.Peek());
        }

        [Test]
        public void Peek_ThrowsException_IfEmpty()
        {
            
        }
    }

    [TestFixture]
    public class LinkedStackTest
    {
        [Test]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            var stack = new LinkedArrayStack<int>();
            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void Count_PushOneItem_ReturnsOne()
        {
            var stack = new LinkedArrayStack<int>();
            stack.Push(1);

            Assert.AreEqual(1, stack.Count);
            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void Peek_PushTwoItems_ReturnsHeadItem()
        {
            var stack = new LinkedArrayStack<int>();
            stack.Push(1);
            stack.Push(2);

            Assert.AreEqual(2, stack.Peek());
        }

        [Test]
        public void Peek_PushTwoItemsAndPop_ReturnsHeadElement()
        {
            var stack = new LinkedArrayStack<int>();
            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            Assert.AreEqual(1, stack.Peek());
        }
    }
}
    