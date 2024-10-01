﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AliacSearchAlgo;

namespace AISearchSample
{
    class BFS_Fringe:Fringes
    {
       
        Queue<Node> s;
        public BFS_Fringe() 
        {
           
            s = new Queue<Node>();
        }
        
        public void add(Node n,Node origin)
        {
            n.Origin = origin;
            s.Enqueue(n);
        }

        public Node remove()
        {
            if (s.Count != 0)
                return s.Dequeue();
            return null;
        }
    }
}
