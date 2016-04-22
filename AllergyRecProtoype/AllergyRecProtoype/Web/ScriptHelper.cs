using System.Runtime.InteropServices;
using System.Security.Permissions;
using AllergyRecProtoype;
using System;
using System.Collections.Generic;

namespace AllergyrecPrototype
{
    /// <summary>
    /// Helper for client side scripting
    /// Javascript will call functions in this class
    /// </summary>
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisible(true)]
    public class ScriptHelper
    {
        MainWindow mExternalWPF;
        public ScriptHelper(MainWindow w)
        {
            mExternalWPF = w;
        }

        public void ToDoSomething(int x, int y, int z)
        {
            Console.WriteLine("{0} {1} {2}", x, y, z);
        }
    }

    public class AllergyVM
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
