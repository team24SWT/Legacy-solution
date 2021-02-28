using NUnit.Framework;

namespace NUnitTestECSLegacy
{
    public class Tests
    {
        private ECS ecs_;
        [SetUp]
        public void Setup()
        {
            _heater = 
        }

        [Test]
        public void TestECSThreshold()
        {
            var ecs = new ECS.Legacy.ECS(30, new FakeTempSensor(10), new FakeHeater());
            Assert.That(ecs.GetThreshold(), Is.EqualTo(30));
        }

        [Test]
        public void TestECSCurrentTemp()
        {
            var ecs = new ECS.Legacy.ECS(30, new FakeTempSensor(10), new FakeHeater());
            Assert.That(ecs.GetCurTemp(), Is.EqualTo(10));
        }

        //Fejl skal fixes
        //[Test]
        //public void TestECSHeaterOn()
        //{
        //    var ecs = new ECS.Legacy.ECS(20, new FakeTempSensor(10), new FakeHeater());
        //    Assert.That(ecs.GetIsHeaterOn, Is.EqualTo(true));
        //}

        //[Test]
        //public void TestECSHeaterOff()
        //{
        //    var ecs = new ECS.Legacy.ECS(7, new FakeTempSensor(10), new FakeHeater());
            
        //    Assert.That(ecs.GetIsHeaterOff, Is.EqualTo(true));
        //}
    }
}