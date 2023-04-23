using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Routine;

public class Routine : IEntity
{
    public Routine(string name, List<Workout> workouts, string dayOfWeek)
    {
        Name = name;
        Workouts = workouts;
        DayOfWeek = dayOfWeek;
    }

    public string Name { get; private set; }
    public List<Workout> Workouts { get; private set; }
    public string DayOfWeek { get; private set; }
}
