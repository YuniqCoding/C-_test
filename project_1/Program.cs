﻿using System;

namespace test
{
    class CStudent
    class Program
    {
        static void Main(string[] args)
        {
            List<CStudent> listData = new List<CStudent>();
            bool IsLoop = true;

            InitData(listData);

            PrintList(listData);

            do
            {
                Console.WriteLine("메뉴를 골라주세요.");
                Console.Write("(1)id 정렬 (2)성적순 정렬 (3)국어점수 정렬 (4)특정점수 이상 (5)특정점수 이하 (0)나가기");

                string inputNum = Console.ReadLine();
                switch (inputNum) 

            } while (IsLoop);
        }
        /// <summary>
        /// 학생 데이터를 생성
        /// 0 0 0 0
        /// 1, ?, ?, ?
        /// </summary>
        /// <param name="_listData"></param>
        static void InitData(List<CStudent> _listData)
        {
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
        }

        static void PrintList(List<CStudent> _listData)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", "ID", "KOR", "MATH", "ENG", "TOTAL");
            Console.WriteLine("======================================================================");

            foreach (var student in _listData)
            {
            }
        }

        static void SortID(List<CStudent> _listData)
        {
            _listData.Sort(delegate(CStudent a, CStudent b)
            {
                if (a.ID > b.ID)
                    return 1;
                else if (a.ID < b.ID)
                    return -1;
                else
                    return 0;
	        });

            Console.WriteLine("아이디 정렬");
            PrintList(_listData);
        }

        static void SortTotal(List<CStudent> _listData)
        {
            var items = from item in _listData
                        orderby item.TOTAL descending
                        select item;

            List<CStudent> sortData = items.ToList<CStudent>();

            Console.WriteLine("총점 정렬");
            PrintList(sortData);
        }

        static void SortKor(List<CStudent> _listData)
        {
            _listData.Sort((CStudent a, CStudent b) => { return b.KOR - a.KOR; });

            Console.WriteLine("국어 점수 정렬");
            PrintList(_listData);
        }

        static void FindDataUp(List<CStudent> _listData, bool isUp)
        {
            Console.WriteLine("기준 점수를 입력하세요");
            string inputData = Console.ReadLine();
            int num = 0;
            try
            if (0 <= num && num <= 300)
        }
    }
    
}