﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSReview
{
    public class Turn
    {
        public int Player1 { get; set; }
        public int Player2 { get; set; }
        //optionally, for practice only add constructors 

        public Turn() //Default Constructor 
        {
            
        }

        public Turn(int player1, int player2) //Greedy Constructor 
        {
            Player1 = player1;
            Player2 = player2;
        }
    }
}
