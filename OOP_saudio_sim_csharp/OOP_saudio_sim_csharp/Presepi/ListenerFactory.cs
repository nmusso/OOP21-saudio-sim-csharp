using System.Collections.Generic;

namespace OOP_saudio_sim_csharp.Presepi
{
    public class ListenerFactory: IListenerFactory
    {
        private readonly IDictionary<Context, Listener> _listeners = new Dictionary<Context, Listener>();

        public Listener CreateListener(Context context)
        {
            _listeners.TryAdd(context, new Listener(context));
            return _listeners[context];
        }

        public Listener CreateListenerWithPos(Context context, Vec3F position)
        {
            if (_listeners.ContainsKey(context))
            {
                _listeners[context].Position = position;
            }

            _listeners.TryAdd(context, new Listener(context, position));
            return _listeners[context];
        }

        public Listener CreateListenerOriented(Context context, Vec3F position, Vec3F up, Vec3F at)
        {
            if (_listeners.ContainsKey(context))
            {
                var listener = _listeners[context];
                listener.Position = position;
                listener.SetOrientation(up, at);
            }

            _listeners.TryAdd(context, new Listener(context, position, up, at));
            return _listeners[context];
        }
    }
}