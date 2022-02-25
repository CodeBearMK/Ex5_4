namespace Ex5_4
{

    class DataSort<T>
    {
        private T[] ary = new T[6];
        private T[] ary2 = new T[5];
        private int index;

        public void SaveToAry(T tData)
        {
            if (index < ary.Length)
            {
                ary[index] = tData;
                index++;
            }
        }

        public void ShowBeforeSortInt()
        {
            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write("{0}\t", ary[i]);
            }
        }

        public void ShowAfterSortInt()
        {
            Array.Sort(ary);
            for (int i = 0; i < ary.Length; i++)
            {
                Console.Write("{0}\t", ary[i]);
            }
        }

        public void SaveToAry2(T tData)
        {
            if (index < ary2.Length)
            {
                ary2[index] = tData;
                index++;
            }
        }

        public void ShowBeforeSortStr()
        {
            for (int i = 0; i < ary2.Length; i++)
            {
                Console.Write("{0}\t", ary2[i]);
            }
        }

        public void ShowAfterSortStr()
        {
            Array.Sort(ary2);
            for (int i = 0; i < ary2.Length; i++)
            {
                Console.Write("{0}\t", ary2[i]);
            }
        }

    }

    class Program
    { 
        static void Main(string[] args)
        {
            DataSort<int> aryInt = new DataSort<int>();
            aryInt.SaveToAry(12);
            aryInt.SaveToAry(67);
            aryInt.SaveToAry(-8);
            aryInt.SaveToAry(120);
            aryInt.SaveToAry(45);
            aryInt.SaveToAry(-23);

            //排序前
            Console.WriteLine("排序前的資料........");
            aryInt.ShowBeforeSortInt();

            Console.WriteLine("\n");

            //排序後
            Console.WriteLine("排序後的資料........");
            aryInt.ShowAfterSortInt();

            DataSort<string> aryStr = new DataSort<string>();
            aryStr.SaveToAry2("tiger");
            aryStr.SaveToAry2("apple");
            aryStr.SaveToAry2("cat");
            aryStr.SaveToAry2("dog");
            aryStr.SaveToAry2("phone");

            Console.WriteLine("\n");

            //排序前
            Console.WriteLine("排序前的資料........");
            aryStr.ShowBeforeSortStr();

            Console.WriteLine("\n");

            //排序後
            Console.WriteLine("排序後的資料........");
            aryStr.ShowAfterSortStr();
            Console.Read();
        }
    }
}