using System.Collections.Generic;

namespace Tests
{
    public class MarsRover
    {
        private int x = 0;
        private int y = 0;
        private string direction = "N";

        private readonly Dictionary<string, string> directionsAfterRightTurn
            = new Dictionary<string, string> {{"N", "E"}, {"E", "S"}, {"S", "W"}, {"W", "N"}};

        private readonly Dictionary<string, string> directionsAfterLeftTurn
            = new Dictionary<string, string> { { "N", "W" }, { "W", "S" }, { "S", "E" }, { "E", "N" } };

        public MarsRover()
        {
        }

        public string Execute(string commands)
        {
            foreach (var individualCommand in commands)
            {
                if (individualCommand == 'R')
                {
                    direction = RotateRight();
                }

                if (individualCommand == 'L')
                {
                    direction = RotateLeft();
                }

                if (individualCommand == 'M')
                {
                    if (direction == "N")
                    {
                        y += 1;

                        if (y == 10)
                        {
                            y = 0;
                        }
                    }

                    if (direction == "E")
                    {
                        x += 1;

                        if (x == 10)
                        {
                            x = 0;
                        }
                    }

                    if (direction == "S")
                    {
                        y -= 1;

                        if (y < 0)
                        {
                            y = 9;
                        }
                    }

                    if (direction == "W")
                    {
                        x -= 1;

                        if (x < 0)
                        {
                            x = 9;
                        }
                    }
                }
            }

            return FormatPosition();
        }

        private string RotateLeft()
        {
            return directionsAfterLeftTurn[direction];
        }

        private string RotateRight()
        {
            return directionsAfterRightTurn[direction];
        }

        private string FormatPosition()
        {
            return $"{x}:{y}:{direction}";
        }
    }
}