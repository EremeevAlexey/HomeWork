using System;

namespace ClassLibrary
{
    public class ArrayWorker
    {
        
        public int[] sourse;
        public int index;
        public int newValue;

        //конвертация строкового массива в целочисленный.
        public int[] ArrayInput(string [] inpArray)
        {
            int[] inpArrayInsert = new int[inpArray.Length];
            for (int i = 0; i < inpArrayInsert.Length; i++) inpArrayInsert[i] = Int32.Parse(inpArray[i]);
            return inpArrayInsert;
        }
        
        //инвертация массива.
        public int[] ArrayRebild()
        {
            Array.Reverse(sourse);
            return sourse;  
        }
        //вставка нового элемента в массив.
        public int[] ArrayInsert(int index, int newValue)
        {
            //создаем новый временный массив.
            int[] sourse1 = new int[sourse.Length + 1];

            //циклом вставляем старые значения до нового.
            for (int i = 0; i < index; i++)
            {
                sourse1[i] = sourse[i];
            }

            //вставляем новое значение.
            sourse1[index] = newValue;

            //циклом втавляем значение после нового значения.
            for (int t = index + 1; t < sourse1.Length; t++)
            {
                sourse1[t] = sourse[t - 1];
            }

            //присваеваем значения старому массиву из нового.
            sourse = sourse1;
            return sourse;
        }
    }
}
