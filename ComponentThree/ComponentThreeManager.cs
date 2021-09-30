using System;

namespace ComponentThree
{
    public class ComponentThreeManager : IComponentThreeManager
    {
        private string _exampleString;

        public ComponentThreeManager(string exampleString)
        {
            _exampleString = exampleString;
        }

        public string GetExampleString()
        {
            return _exampleString;
        }
    }
}
