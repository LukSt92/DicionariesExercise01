﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicionariesExercise01
{
    class RetiredPlayer
    {
        public RetiredPlayer(string player, int yearRetired)
        {
            Name = player;
            YearRetired = yearRetired;
        }
        public string Name { get; private set; }
        public int YearRetired { get; private set; }

    }
}