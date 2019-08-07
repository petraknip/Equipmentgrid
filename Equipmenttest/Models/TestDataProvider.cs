using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Equipmenttest.Models
{
    public class TestDataProvider
    {
        public Random rng = new Random(34982174);

        public Dictionary<string, Dictionary<string, Dictionary<int, string>>> CreateRooms(int count)
        {
            var result = new Dictionary<string, Dictionary<string, Dictionary<int, string>>>();
            for (var i = 0; i < count; i++)
            {
                result[$"Room {i}"] = CreateDeviceTypes(rng.Next(1, 10));
            }
            return result;
        }

        public Dictionary<string, Dictionary<int, string>> CreateDeviceTypes(int count)
        {
            var result = new Dictionary<string, Dictionary<int, string>>();
            for (var i = 0; i < count; i++)
            {
                result[$"DeviceType {i}"] = CreateDevices(rng.Next(3, 100));
            }
            return result;
        }

        public Dictionary<int, string> CreateDevices(int count)
        {
            var result = new Dictionary<int, string>();
            for (var i = 0; i < count; i++)
            {
                result[i] = $"Device-{i}";
            }
            return result;
        }
    }
}
