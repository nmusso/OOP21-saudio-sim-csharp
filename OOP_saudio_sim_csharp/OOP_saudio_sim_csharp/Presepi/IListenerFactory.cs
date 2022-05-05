namespace OOP_saudio_sim_csharp.Presepi
{
    public interface IListenerFactory
    {
        Listener CreateListener(Context context);
        
        Listener CreateListenerWithPos(Context context, Vec3F position);
        
        Listener CreateListenerOriented(Context context, Vec3F position, Vec3F up, Vec3F at);
    }
}