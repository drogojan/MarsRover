using NUnit.Framework;

namespace Tests
{
    public class MarsRoverShould
    {
        [TestCase("R", "0:0:E")]
        [TestCase("RR", "0:0:S")]
        [TestCase("RRR", "0:0:W")]
        [TestCase("RRRR", "0:0:N")]
        public void Rotate_Right(string commands, string expectedOutput)
        {
            var marsRover = new MarsRover();

            var output = marsRover.Execute(commands);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestCase("L", "0:0:W")]
        [TestCase("LL", "0:0:S")]
        [TestCase("LLL", "0:0:E")]
        [TestCase("LLLL", "0:0:N")]
        public void Rotate_Left(string commands, string expectedOutput)
        {
            var marsRover = new MarsRover();

            var output = marsRover.Execute(commands);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestCase("M", "0:1:N")]
        [TestCase("MMM", "0:3:N")]
        public void Move_Up(string commands, string expectedOutput)
        {
            var marsRover = new MarsRover();

            var output = marsRover.Execute(commands);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestCase("MMMMMMMMMM", "0:0:N")]
        [TestCase("MMMMMMMMMMMM", "0:2:N")]
        public void Wrap_From_Top_To_Bottom_When_Moving_North(string commands, string expectedOutput)
        {
            var marsRover = new MarsRover();

            var output = marsRover.Execute(commands);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestCase("RM", "1:0:E")]
        [TestCase("RMMMMM", "5:0:E")]
        public void Move_Right(string commands, string expectedOutput)
        {
            var marsRover = new MarsRover();

            var output = marsRover.Execute(commands);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestCase("RMMMMMMMMMM", "0:0:E")]
        [TestCase("RMMMMMMMMMMMMM", "3:0:E")]
        public void Wrap_From_Right_To_Left_When_Moving_East(string commands, string expectedOutput)
        {
            var marsRover = new MarsRover();

            var output = marsRover.Execute(commands);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestCase("MRRM", "0:0:S")]
        [TestCase("MMRRM", "0:1:S")]
        public void Move_Down(string commands, string expectedOutput)
        {
            var marsRover = new MarsRover();

            var output = marsRover.Execute(commands);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestCase("RRM", "0:9:S")]
        [TestCase("RRMMM", "0:7:S")]
        public void Wrap_From_Bottom_To_Up_When_Moving_South(string commands, string expectedOutput)
        {
            var marsRover = new MarsRover();

            var output = marsRover.Execute(commands);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestCase("RMLLM", "0:0:W")]
        [TestCase("RMMMLLMM", "1:0:W")]
        public void Move_Left(string commands, string expectedOutput)
        {
            var marsRover = new MarsRover();

            var output = marsRover.Execute(commands);

            Assert.AreEqual(expectedOutput, output);
        }

        [TestCase("LM", "9:0:W")]
        public void Wrap_From_Left_To_Right_When_Moving_South(string commands, string expectedOutput)
        {
            var marsRover = new MarsRover();

            var output = marsRover.Execute(commands);

            Assert.AreEqual(expectedOutput, output);
        }
    }
}