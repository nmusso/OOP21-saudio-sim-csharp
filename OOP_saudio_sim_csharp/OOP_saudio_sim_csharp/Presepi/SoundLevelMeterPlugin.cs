using System;
using System.Linq;
using OOP_saudio_sim_csharp.Sciarrillo;
using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Presepi
{
    public class SoundLevelMeterPlugin : AbstractPlugin
    {
        private static readonly float SAFETY_DISTANCE = 3;
        private static readonly int MAX_VALUE_COLOR = 255;
        private readonly Listener _listener;
        private ISourcesHub? Sources { get; set; }

        public SoundLevelMeterPlugin(Listener listener)
        {
            _listener = listener;
            Sources = null;
            Enable();
        }

        public bool SourceHubPresent() => Sources == null;

        private double SourceDistanceMin()
        {
            double? minDistance = null;
            try
            {
                minDistance = Sources?.GetAll().Where(s => s.IsPlaying)
                    .Select(p => Math.Sqrt(Math.Pow(p.Position.X - _listener.Position.X, 2)
                                           + Math.Pow(p.Position.Y - _listener.Position.Y, 2)))
                    .Min();
            }
            catch(Exception e)
            {
                return -1;
            }

            return minDistance ?? -1;
        }
        
        private int GetMappedColor(double distance) {
            if (distance >= SAFETY_DISTANCE) {
                return MAX_VALUE_COLOR * 2;
            }
            if (distance <= 0.0f) {
                return 0;
            }
            float intervals = (MAX_VALUE_COLOR * 2) / (SAFETY_DISTANCE * 10);
            return (int) (Math.Round(distance * 10) * intervals);
        }
        
        public Vec3F GetRgbColor() {
            var distanceMin = SourceDistanceMin();
            if (IsEnabled || !SourceHubPresent() || distanceMin.CompareTo(-1d) == 0) {
                return new Vec3F(MAX_VALUE_COLOR, MAX_VALUE_COLOR, MAX_VALUE_COLOR);
            }

            var mappedColor = GetMappedColor(distanceMin);
            return mappedColor <= MAX_VALUE_COLOR ? new Vec3F(MAX_VALUE_COLOR, mappedColor, 0.0f)
                                                  : new Vec3F(MAX_VALUE_COLOR - (mappedColor - MAX_VALUE_COLOR), MAX_VALUE_COLOR, 0.0f);

        }
        

        protected override void SaveSettings()
        {
        }

        protected override void RestoreSettings()
        {
        }
    }
}