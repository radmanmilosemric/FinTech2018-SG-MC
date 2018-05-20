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
                new Data{ Uid = "05-8D-0A-7E-DD-10-00", CardHolder = "MILOS RADMAN", CardNumber ="111111111111", ExpMonth=1, ExpYear=2022, Cvc="123"},
                new Data{ Uid = "05-80-A5-8E-CA-30-00", CardHolder = "MILAN DAMNJANOVIC", CardNumber ="222222222222", ExpMonth=2, ExpYear=2019, Cvc="456"},
                new Data{ Uid = "5F-93-FF-CC", CardHolder = "JANKO DJUKIC", CardNumber ="333333333333", ExpMonth=7, ExpYear=2021, Cvc="789"},
                new Data{ Uid = "DF-C7-C7-A1", CardHolder = "OGNJEN RADOVIC", CardNumber ="444444444444", ExpMonth=6, ExpYear=2024, Cvc="159"},
            };
        }
    }
}
