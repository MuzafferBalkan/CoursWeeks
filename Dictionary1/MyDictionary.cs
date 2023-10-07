using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary1
{
    class MyDictionary<I, S>
    {
        I[] keys;
        S[] values;
        I[] tempArrayKey;
        S[] tempArrayValue;
        public MyDictionary()
        {
            keys = new I[0];
            values = new S[0];
        }
        public void Add(I key, S value)
        {
            tempArrayKey = keys;
            tempArrayValue = values;

            keys = new I[keys.Length + 1];
            values = new S[values.Length + 1];

            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                keys[i] = tempArrayKey[i];
                values[i] = tempArrayValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

            Console.WriteLine("Kayıt Başarılı.");
        }
        public void Listele()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Öğrenci No : "+keys[i]);
                Console.WriteLine("Öğrenci Adı : "+values[i]);
            }
        }
    }
}
