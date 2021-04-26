﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care_Management_and_Private_Parking
{
    class DivideShift
    {
        #region
        private List<List<int>> Arr;
        public List<List<int>> Array
        {
            get { return Arr; }
            set { Arr = value; }
        }
        #endregion

        void Swap(int a, int b)
        {
            int r = a;
            a = b;
            b = r;
        }
        public List<List<int>> SetTheBaseDOW(ref int C, ref int R, ref int DayOfRotation)
        {
            Array.Add(new List<int>());
            //Khởi tạo mảng 0
            for(int i = 0; i < R; ++i)
            {
                Array[i].Add(C);
                for(int j = 0; j < C; ++j)
                {
                    Array[i][j] = 0;
                }
            }
            //Thêm ca làm cố định
            int count = 0, k = 0;
            for(int i = 0; i <= R; ++i)
            {
                if (count < C && i >= R)
                    i = 0;
                else if (count >= C)
                    break;
                Array[i][k] = 1;
                k++;
                count++;
            }
            
            for(int RT = 1; RT <= DayOfRotation; ++RT)
            {
                for(int i = 0; i < R; ++i)
                {
                    for(int j = 0; j < C; ++j)
                    {
                        if (Arr[i][j] == 1 && j < C - 1)                        //Nếu tại ô đó = 1
                        {
                            Swap(Arr[i][j], Arr[i][j + 1]);
                            j++;
                        }
                        else if (Arr[i][j] == 1 && j == C - 1)
                        {
                            Swap(Arr[i][j], Arr[i][0]);
                        }
                    }
                }
            }
            return Array;
        }
    }
}
