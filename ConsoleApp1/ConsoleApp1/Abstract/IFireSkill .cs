﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Abstract
{
    public interface IFireSkill : ISkill
    {
        int BurningTime { get; }
    }
}
