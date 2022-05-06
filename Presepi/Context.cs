using OOP_saudio_sim_csharp.Utility;

namespace OOP_saudio_sim_csharp.Presepi
{
    public class Context
    {
        public override bool Equals(object obj)
        {
            Context c = (Context)obj;
            return c.GetID().Equals(this.GetID()); 
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int GetID() => OpenAl.GetContextID();


    }
}