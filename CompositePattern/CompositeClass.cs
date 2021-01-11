using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class CompositeClass<T> where T:ICompositeObject
    {
        private List<CompositeClass<T>> _compositeClasses = new List<CompositeClass<T>>();
        public T Node { get;}

        public CompositeClass(T node)
        {
            Node = node;
        }

        public CompositeClass<T> AddCompositeClass(T compositeObject)
        {
            CompositeClass<T> newComposite = new CompositeClass<T>(compositeObject);
            _compositeClasses.Add(newComposite);
            return newComposite;
        }

        public void ToList(int hyphenSize)
        {
            string hyphen = new string('-',hyphenSize++);
            Console.WriteLine(hyphen + Node.ToString());
            foreach (var compositeClass in _compositeClasses)
            {
                compositeClass.ToList(hyphenSize);
            }
        }
    }
}