using System;
using System.Text.Json;
using System.Collections.Generic;

namespace PipingControlSystem
{
    public class TelemetryData
    {
        public double InletPressurePSI { get; set; }
        public double OutletPressurePSI { get; set; }
    }

    public class Valve
    {
        public string ValveID { get; set; }
        public double PipeDiameterInches { get; set; }
        public bool IsOpen { get; set; }
        public List<string> AllowedFluids { get; set; }
        public double FlowCoefficientCv { get; set; }
        public TelemetryData Telemetry { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // 1. Constructing our Valve object in the C# "Reactor" memory
            Valve controlValve = new Valve
            {
                ValveID = "FCV-101",
                PipeDiameterInches = 6.0,
                IsOpen = true,
                AllowedFluids = new List<string> { "Water", "Glycol", "Steam" },
                FlowCoefficientCv = 120.5,
                Telemetry = new TelemetryData
                {
                    InletPressurePSI = 45.2,
                    OutletPressurePSI = 41.8
                }
            };

            // 2. SERIALIZATION: Converting the object into a JSON string
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonStream = JsonSerializer.Serialize(controlValve, options);
            
            Console.WriteLine("=== Fluidized JSON Stream entering the Pipeline ===");
            Console.WriteLine(jsonStream);

            // 3. DESERIALIZATION: Receiving the JSON string and rebuilding the C# object
            Valve receivedValve = JsonSerializer.Deserialize<Valve>(jsonStream);
            
            Console.WriteLine("\n=== Decanted Object at the Destination Storage Tank ===");
            Console.WriteLine($"Successfully read data for valve: {receivedValve.ValveID}");
            Console.WriteLine($"Pressure Drop (dP): {receivedValve.Telemetry.InletPressurePSI - receivedValve.Telemetry.OutletPressurePSI} PSI");
        }
    }
}
