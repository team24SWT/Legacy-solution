using ECS.Legacy;
using NUnit.Framework;
using NSubstitute;

namespace ECS.Tests.Subs
{
    [TestFixture]
    public class Tests
    {
        private Legacy.ECS ecs_;
        private IHeater heater_;
        private ITempSensor tempSensor_;

        

        [SetUp]
        public void Setup()
        {
            heater_ = Substitute.For<IHeater>();
            tempSensor_ = Substitute.For<ITempSensor>();

            ecs_ = new Legacy.ECS(25, tempSensor_, heater_);
        }


        [Test]
        public void tempSensorFailedTest()
        {
            tempSensor_.RunSelfTest().Returns(false);
            heater_.RunSelfTest().Returns(true);
            Assert.IsFalse(ecs_.RunSelfTest());
        }

        [Test]
        public void heaterFailedTest()
        {
            tempSensor_.RunSelfTest().Returns(true);
            heater_.RunSelfTest().Returns(false);
            Assert.IsFalse(ecs_.RunSelfTest());
        }

        [Test]
        public void allFailedTest()
        {
            tempSensor_.RunSelfTest().Returns(false);
            heater_.RunSelfTest().Returns(false);
            Assert.IsFalse(ecs_.RunSelfTest());
        }


        [Test]
        public void allSuccessTest()
        {
            tempSensor_.RunSelfTest().Returns(true);
            heater_.RunSelfTest().Returns(true);
            Assert.IsTrue(ecs_.RunSelfTest());
        }
        

        [Test]
        public void heaterOnWhenTempBelowThreshold()
        {
            tempSensor_.GetTemp().Returns(15);
            ecs_.Regulate();
            heater_.Received(1).TurnOn();
        }

        [Test]
        public void heaterOffWhenTempAboveThreshold()
        {
            tempSensor_.GetTemp().Returns(27);
            ecs_.Regulate();
            heater_.Received(1).TurnOff();
        }
    }
}