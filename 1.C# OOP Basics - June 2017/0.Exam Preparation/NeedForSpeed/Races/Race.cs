using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;
    private List<Car> participants;

    public Race(int length, string route, int prizePool)
    {
        this.length = length;
        this.route = route;
        this.prizePool = prizePool;
        this.participants = new List<Car>();
    }

    public List<Car> Participants
    {
        get { return this.participants; }
        set { this.participants = value; }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.route} - {this.length}");
        this.GetPerformancePints(this.Participants);
        var place = 1;
        foreach (var participant in this.Participants.OrderByDescending(x => x.PerformancePoints).Take(3))
        {
            sb.AppendLine($"{place}. {participant.Brand} {participant.Model} {participant.PerformancePoints}PP - ${this.GetPrize(place)}");
            place++;
        }

        return sb.ToString();
    }

    public abstract void GetPerformancePints(IEnumerable<Car> carsCollection);

    public virtual int GetPrize(int place)
    {
        switch (place)
        {
            case 1:
                return this.prizePool * 50 / 100;
            case 2:
                return this.prizePool * 30 / 100;
            case 3:
                return this.prizePool * 20 / 100;
            default:
                return 0;
        }
    }
}