using OOP_saudio_sim_csharp.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_saudio_sim_csharp.Lugaresi
{
    public class Space : ISpace
    {
        public float YMax { get; set; }

        public float XMax { get; set; }

        public Space(float x, float y )
        {
            this.XMax = x;
            this.YMax = y;
        }

        public bool IsAvailable(Vec3F pos, List<Vec3F> position) => CheckBorder(pos) && CheckBusyPos(pos, position);

        private bool CheckBorder(Vec3F pos) => pos.X <= this.XMax && pos.X >= 0f && pos.Y >= 0f && pos.Y <= this.YMax;

        private bool CheckBusyPos(Vec3F pos, List<Vec3F> position) => !position.Contains(pos);
    }     
}