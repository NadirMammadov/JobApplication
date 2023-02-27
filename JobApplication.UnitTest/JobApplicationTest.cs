

using JobApplicationLibrary;

namespace JobApplication.UnitTest
{
    public class JobApplicationTest
    {
        [Test]
        public void ApplicationEvalutor_WithUnderAge_UnderCondition()
        {
            // Arrange
            ApplicationEvaluator evaluator = new ApplicationEvaluator();
            JobApplicationLibrary.Models.JobApplication form = new()
            {
                Applicant = new()
                {
                    Age = 18
                }
            };


            // Act
            var result = evaluator.Evalute(form);

            // Assert
            Assert.AreEqual(ApplicationResult.AutoRejected, result);
        }
    }
}
