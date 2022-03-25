using System;
using System.Collections.Generic;

namespace Assignment_2
{
    // Food wrt calories as key,value pair
    public class FoodCalorie
    {
        public static IDictionary<int, int> burgers = new Dictionary<int, int>() {
            { 1 , 461 },
            { 2 , 431 },
            { 3 , 420 },
            { 4 , 0 },
        };


        public static IDictionary<int, int> drinks = new Dictionary<int, int>() {
            { 1 , 130 },
            { 2 , 160 },
            { 3 , 118 },
            { 4 , 0 },
        };



        public static IDictionary<int, int> sides = new Dictionary<int, int>() {
            { 1 , 100 },
            { 2 , 57 },
            { 3 , 70 },
            { 4 , 0 },
        };



        public static IDictionary<int, int> desserts = new Dictionary<int, int>() {
            { 1 , 166 },
            { 2 , 266 },
            { 3 , 75 },
            { 4 , 0 },
        };


    }

}
