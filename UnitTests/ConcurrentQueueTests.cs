using System.Collections.Generic;
using System.Threading.Tasks;
using LeetCodeProjects.Contributions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ConcurrentQueueTests
    {
        private ConcurrentQueue _queue;
        private List<int> _output;
        private void EnqueueSequence()
        {
            _queue.Enqueue(1);
            _queue.Enqueue(2);
            _queue.Enqueue(3);
            _queue.Enqueue(4);
            _queue.Enqueue(5);
            _queue.Enqueue(6);
            _queue.Enqueue(7);
            _queue.Enqueue(8);
            _queue.Enqueue(9);
            _queue.Enqueue(10);
        }

        private void DequeueSequence()
        {
            _output = new List<int>
            {
                _queue.Dequeue(),
                _queue.Dequeue(),
                _queue.Dequeue(),
                _queue.Dequeue(),
                _queue.Dequeue(),
                _queue.Dequeue(),
                _queue.Dequeue(),
                _queue.Dequeue(),
                _queue.Dequeue(),
                _queue.Dequeue()
            };
        }
        
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var size = 5;
            _queue = new ConcurrentQueue(size);
            var t1 = new Task(EnqueueSequence);
            var t2 = new Task(DequeueSequence);

            //Act
            t1.Start();
            t2.Start();
            Task.WaitAll(t1, t2);

            //Assert
            for (var i = 0; i < 10; i++)
            {
                Assert.AreEqual(i + 1, _output[i]);
            }
        }
    }
}
