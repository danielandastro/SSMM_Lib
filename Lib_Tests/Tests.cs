using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void End()
        {
            var test = SSM_Lib.Manipulate.Trim.End(1, "test");
            if(test.Equals("tes")) Assert.Pass();
        }
        [Test]
        public void Start()
        {
            var test = SSM_Lib.Manipulate.Trim.Start(1, "test");
            if (test.Equals("est")) Assert.Pass();
        }
        [Test]
        public void Remove()
        {
            var test = SSM_Lib.Manipulate.RemoveString("test", "st");
            if (test.Equals("te")) Assert.Pass();
        }
    }
}