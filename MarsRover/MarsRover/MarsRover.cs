using System.Security.Cryptography.X509Certificates;

namespace MarsRover;

public class MarsRover
{
    public int[,] Grid { get; }
    public Direction Direction { get; private set; }
    public int[,] Location { get; private set; }
    
    public MarsRover(int[,] location, Direction direction, int[,] grid)
    {
        Location = location;
        Direction = direction;
        Grid = grid;
    }
}

public enum Direction
{
    North,
    South,
    East,
    West,
}

