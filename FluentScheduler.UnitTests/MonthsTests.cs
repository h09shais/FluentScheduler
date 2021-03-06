namespace FluentScheduler.UnitTests
{
    using System;
    using Xunit;
    using static Xunit.Assert;

    public class MonthsTests
    {
        [Fact]
        public void Should_Add_Specified_Months_To_Next_Run_Date()
        {
            // Arrange
            var input = new DateTime(2000, 1, 1);
            var expected = new DateTime(2000, 3, 1);

            // Act
            var schedule = new Schedule(() => { });
            schedule.ToRunEvery(2).Months();
            var actual = schedule.CalculateNextRun(input);

            // Assert
            Equal(expected, actual);
        }

        [Fact]
        public void Should_Default_To_00_00_If_At_Is_Not_Defined()
        {
            // Arrange
            var input = new DateTime(2000, 1, 1, 1, 23, 25);
            var expected = new DateTime(2000, 3, 1);

            // Act
            var schedule = new Schedule(() => { });
            schedule.ToRunEvery(2).Months();
            var actual = schedule.CalculateNextRun(input);

            // Assert
            Equal(expected, actual);
        }
    }
}
