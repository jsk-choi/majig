﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using majig.db;

namespace majig.scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new db.ef.MajigContext())
            {
                var jjj = db.vCategory.ToList();

                foreach (var item in jjj)
                {
                    Console.WriteLine($"{item.Id} - {item.Category1} - {item.Crumb}");
                }
            }
        }
    }
}
