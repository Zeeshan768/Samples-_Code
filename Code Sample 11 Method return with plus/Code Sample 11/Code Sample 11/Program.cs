using System;


namespace Code_Sample_11
    {
    class Program
        {
        static int sillyReturnPlus(int i)
            {
            i = i + 1;
            Console. WriteLine ( "i is : " + i );
            return i;
            }
     public static void Main ( string [ ] args )
            {
            int res;
            res = sillyReturnPlus ( 5 );
            Console. WriteLine ( "res is : " + res );
            Console. ReadKey ( );  
            }
        }
    }
