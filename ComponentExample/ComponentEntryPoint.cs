using System;
using ComponentOne;
using ComponentTwo;
using Microsoft.VisualBasic;

namespace ComponentExample
{
    class ComponentEntryPoint
    {
        static void Main(string[] args)
        {
            IComponentTwoManager componentTwoManager = new ComponentTwoManager();
            IComponentOneManager componentOneManager = new ComponentOneManager($"Component One called Component Three, but before that \n " +
                                                                               $"{componentTwoManager.GetComponentTwoInitialString()}");

            var textFromComponentTwo = componentTwoManager.GetComponentTwoInitialString();
            var textFromComponentOneAndThree = componentOneManager.GetExampleString();

            Console.WriteLine(textFromComponentTwo);
            Console.WriteLine(textFromComponentOneAndThree);


        }
    }
}
