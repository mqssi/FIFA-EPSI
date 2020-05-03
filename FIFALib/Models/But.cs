using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFALib.Models
{

    /// <summary>
    /// Représente un But dans un match
    /// </summary>
    public class But
    {
        public int Id { get; set; }


        /// <summary>
        /// Représente la minute du but dans un match
        /// </summary>
        public double MinBut { get; set; }
        //string.Format("{0}:{1}", Math.Floor(ts.TotalMinutes), ts.ToString("ss\\.ff"))

        /// <summary>
        /// Indique si le but et contre son camp
        /// </summary>
        public bool CscBut { get; set; }
        
        /// <summary>
        /// Représente le nom du buteur virtuel
        /// </summary>
        public string ButeurBut { get; set; }

    }
}
