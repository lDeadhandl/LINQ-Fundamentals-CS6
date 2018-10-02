//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LinqSamples
//{
//    //when making an extension method must use public static 
//    public static class MyLinq
//    {
//        // by adding this to the parameter we no have created an
//        // extension method to all IEnumerables that do not have
//        // to be called by an instance
//        public static int Count<T>(this IEnumerable<T> sequence)
//        {
//            int count = 0;
//            foreach(var item in sequence)
//            {
//                count += 1;
//            }
//            return count;
//        }
//    }
//}
