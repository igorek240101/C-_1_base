using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System;

namespace Test
{
    [TestClass]
    public class Tests2
    {
        static Assembly assembly;

        static Type[] type;

        static Type parrent;

        static Tests2()
        {
            assembly = Assembly.LoadFrom("C_2_base.dll");
        }

        [TestMethod]
        public void TypesCountTest()
        {
            Type[] types = assembly.GetTypes();
            switch (types.Length)
            {
                case 0:
                    {
                        throw new Exception("Эмм... Похоже у вас в коде нет типов! Это странно...");;
                    }
                case 1:
                    {
                        throw new Exception("Есть подозрения, что вы все запихнули в один тип, а так ООП не делается");
                    }
                case 2:
                    {
                        throw new Exception("Хмм... 2 Типа интересно и странно, покажите мне ваш код, подалуйста");
                    }
                case 3:
                    {
                        throw new Exception("Есть опсения, что ваши классы имеют не совсем правильное общее имя");
                    }
                case 4:
                    {
                        type = types;
                        break;
                    }
                default:
                    {
                        throw new Exception("Что многовато у вас типов получилось, покажите мне ваш код, пожалуйста");
                    }
            }
        }

        [TestMethod]
        public void ValueTypesTest()
        {
            if(type != null)
            {
                foreach(var element in type)
                {
                    if (element.GetTypeInfo().IsValueType) throw new Exception();
                }
                return;
            }
            throw new Exception();
        }

        [TestMethod]
        public void InterfaceOrAbstractTypesTest()
        {
            if (type != null)
            {
                int count = 0;
                foreach (var element in type)
                {
                    if (element.GetTypeInfo().IsInterface || element.GetTypeInfo().IsAbstract) count++;
                }
                if (count > 1) throw new Exception();
                return;
            }
            throw new Exception();
        }

        [TestMethod]
        public void BabyTest()
        {
            if (type != null)
            {
                foreach (var parrent in type)
                {
                    int count = 0;
                    foreach (var element in type)
                        if (element.GetTypeInfo().IsSubclassOf(parrent)) count++;
                    if (count >= 3) { Tests2.parrent = parrent; return; }
                }
                throw new Exception();
            }
            throw new Exception();
        }
    }
}
