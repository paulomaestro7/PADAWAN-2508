using System.Collections.Generic;

namespace Padawan_2708_TiposGenericos.Util
{
    public class TipoGenrico<T>
    {
        private readonly List<T> list;

        public TipoGenrico()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public List<T> Result()
        {
            return list;
        }
    }
}
