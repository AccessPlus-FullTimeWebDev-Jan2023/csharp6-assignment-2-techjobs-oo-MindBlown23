
using System.Security.Cryptography.X509Certificates;

namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10);
        }

        Job job1;
        Job job2;
        Job job3;
        Job job4;

        [TestInitialize]
        public void CreateJobObject()
        {
            job1 = new Job();
            job2 = new Job();
            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new("Quality control"), new CoreCompetency("Persistence"));
        }

        ////Testing Objects
        ////initalize your testing objects here
        //}
        [TestMethod]
        public void TestSettingJobId()
        {
            int Id1 = job2.Id - job1.Id;
            Assert.AreEqual(Id1, 1);

        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(job3.Name, "Product tester", "Testing Job Name");
            Assert.AreEqual(job3.EmployerName.ToString(), "ACME", "Testing EmployerName Value");
            Assert.AreEqual(job3.EmployerLocation.ToString(), "Desert", "Testing EmployerLocation Value");
            Assert.AreEqual(job3.JobType.ToString(), "Quality control", "Testing JobType Value");
            Assert.AreEqual(job3.JobCoreCompetency.ToString(), "Persistence", "Testing JobCoreCompetency Value");
            Assert.AreNotEqual(job3.Id, job2.Id, "Job objects should have unique ids");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job4.Equals(job3));
        }
        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
            Assert.IsTrue(job3.ToString().EndsWith(Environment.NewLine));
        }
        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            Assert.IsTrue(job3.ToString().Contains($"ID: {job3.Id}"));
            Assert.IsTrue(job3.ToString().Contains($"Name: {job3.Name}"));
            Assert.IsTrue(job3.ToString().Contains($"Employer: {job3.EmployerName}"));
            Assert.IsTrue(job3.ToString().Contains($"Location: {job3.EmployerLocation}"));
            Assert.IsTrue(job3.ToString().Contains($"Position Type: {job3.JobType}"));
            Assert.IsTrue(job3.ToString().Contains($"Core Competency: {job3.JobCoreCompetency}"));
        }
        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            Assert.IsTrue(job3.ToString().StartsWith(""));
        }
        
    }
    
}

