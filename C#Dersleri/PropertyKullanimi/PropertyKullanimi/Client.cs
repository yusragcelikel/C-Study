using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKullanimi
{
    public class Client
    {
        private int weight; // field/değişken

        public int prpWeight // property
        {
            get 
            {
                return weight;
            }
            set 
            { 
                weight = value; 
            } 
        }
    }
}
