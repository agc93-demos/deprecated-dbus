using System;
using System.Threading.Tasks;
using Tmds.DBus;
using UPower.DBus;

namespace dbus
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting D-Bus service");
            var system = Connection.System;
            var upower = system.CreateProxy<IUPower>("org.freedesktop.UPower", "/org/freedesktop/UPower");
            var props = await upower.GetAllAsync();
            Console.WriteLine($"You are on {(props.OnBattery ? "battery" : "AC power")}");
        }
    }
}
