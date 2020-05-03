﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFALib.Models
{
    public class MatchEntry
    {
        public int Id { get; set; }
        public Equipe EquipeJouant { get; set; }

        public double Score { get; set; }

        public Match MatchParent { get; set; }

    }
}
