using System;
using System.Collections.Generic;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("ggg", "ggggg gggggggg", 550);

            Type mytype = typeof(Library);

            PropertyInfo[] properties = mytype.GetProperties();

            for (int i = 0; i < properties.Length; i++)
            {
                Console.WriteLine(properties[i].GetValue(library));
                Console.WriteLine(properties[i].Name);
            }

            MethodInfo[] methods = mytype.GetMethods();

            for (int i = 0; i < methods.Length; i++)
            {
                Console.WriteLine(methods[i].Name);
            }
            var res9 = methods[4].GetParameters();
            bool res7 = methods[5].IsAbstract;
            bool res8 = methods[4].IsStatic;

            MemberInfo[] members = mytype.GetMembers();

            for (int i = 0; i < members.Length; i++)
            {
                Console.WriteLine(members[i].Name);
            }

            ConstructorInfo[] constructors = mytype.GetConstructors();

            for (int i = 0; i < constructors.Length; i++)
            {
                Console.WriteLine(constructors[i].Name);
            }

            var res = mytype.GetConstructors()[1].GetParameters()[1].Name;
            Console.WriteLine(res);
            object res1 = mytype.GetConstructors()[1].Invoke(new object[] { "lllll", "lll llllll", 87 });
            mytype.GetConstructors()[1].Invoke(library, new object[] { "lllll", "lll llllll", 87 });
            var res4 = mytype.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            var res5 = mytype.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            var res6 = mytype.GetMethods()[0].Invoke(library, null);


        }
    }
   

}
