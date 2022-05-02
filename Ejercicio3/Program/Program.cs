using System.Timers;
using System.Threading.Tasks;

System.Timers.Timer timer = new System.Timers.Timer(1000);
timer.Elapsed += TimerHandler;
timer.Enabled = true;
Console.ReadKey();

static void TimerHandler(object sender, System.Timers.ElapsedEventArgs e)
{
    Console.WriteLine(e.SignalTime);
}
