using System;
using ComponentThree;

namespace ComponentOne
{
    public class ComponentOneManager : IComponentOneManager
    {
        private IComponentThreeManager _componentThreeManager;

        public ComponentOneManager(string exampleString)
        {
            _componentThreeManager = new ComponentThreeManager(exampleString);
        }

        public string GetExampleString()
        {
            return _componentThreeManager.GetExampleString();
        }
    }
}

