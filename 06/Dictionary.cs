﻿using System;

namespace Indexers
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] valueRus = new string[5];


        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book"; valueRus[0] = "книга";
            key[1] = "ручка"; value[1] = "pen"; valueRus[1] = "ручка";
            key[2] = "сонце"; value[2] = "sun"; valueRus[2] = "солнце";
            key[3] = "яблуко"; value[3] = "apple"; valueRus[3] = "яблоко";
            key[4] = "стіл"; value[4] = "table"; valueRus[4] = "стол";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index || value[i] == index || valueRus[i] == index)
                        return key[i] + " - " + value[i] + " - " + valueRus[i];

                return string.Format("{0} - немає перекладу для цього слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index] + " - " + valueRus[index];
                else
                    return "Спроба звернення за межі масиву.";
            }
        }      
    }
}
