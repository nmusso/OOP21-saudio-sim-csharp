namespace OOP_presepi_csharp
{
    public interface IListenerFactory
    {
        Listener CreateListener(Context context);
        
        Listener CreateListenerWithPos(Context context, Vec3f position);
        
        Listener CreateListenerOriented(Context context, Vec3f position, Vec3f up, Vec3f at);
    }
}