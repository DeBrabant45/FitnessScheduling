using Domain.Common;

namespace Domain.Routine;

public class Workout : IEntity
{
    public Workout(string name, int reps, int sets, decimal weight)
    {
        Name = name;
        Reps = reps;
        Sets = sets;
        Weight = weight;
    }

    public string Name { get; private set; }
    public int Reps { get; private set; }
    public int Sets { get; private set; }
    public decimal Weight { get; private set; }
}