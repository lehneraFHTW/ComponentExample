using System;

namespace ComponentTwo
{
    public class ComponentTwoManager : IComponentTwoManager
    {
        private string _nextString;

        public ComponentTwoManager()
        {
            _nextString = "ComponentTwo was created!";
        }

        public string GetComponentTwoInitialString()
        {
            return _nextString;
        }
    }
}
