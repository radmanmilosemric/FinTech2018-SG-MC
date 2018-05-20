using System;
using System.Collections.Generic;

namespace CardReaderTest
{
    public class Data
    {
        public string Uid;
        public string CardNumber;
        public string CardHolder;
        public int ExpMonth;
        public int ExpYear;
        public string Cvc;

        public static List<Data> GetData()
        {
            return new List<Data>
            {
                new Data{ Uid = "", CardHolder = "", CardNumber ="", ExpMonth=1, ExpYear=1, Cvc=""},
                new Data{ Uid = "", CardHolder = "", CardNumber ="", ExpMonth=1, ExpYear=1, Cvc=""},
                new Data{ Uid = "", CardHolder = "", CardNumber ="", ExpMonth=1, ExpYear=1, Cvc=""},
                new Data{ Uid = "", CardHolder = "", CardNumber ="", ExpMonth=1, ExpYear=1, Cvc=""},
            };
        }
    }
}
