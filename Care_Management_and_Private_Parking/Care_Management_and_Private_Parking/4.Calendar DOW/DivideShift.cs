using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care_Management_and_Private_Parking
{
    class DivideShift
    {
        #region Properties
        private List<List<int>> Arr;
        public List<List<int>> Array
        {
            get { return Arr; }
            set { Arr = value; }
        }
        #endregion

        public static void Swap(ref List<List<int>> Array, int oi, int oj, int ni, int nj)
        {
            int r = Array[oi][oj];
            Array[oi][oj] = Array[ni][nj];
            Array[ni][nj] = r;
        }

        public List<List<int>> SetTheBaseDOW(int C, int R, int DayOfRotation)
        {
            Array = new List<List<int>>();
            //Khởi tạo mảng 0
            for(int i = 0; i < R; ++i)
            {
                Array.Add(new List<int>());
                for(int j = 0; j < C; ++j)
                {
                    Array[i].Add(C);
                    Array[i][j] = 0;
                }
            }
            //Thêm ca làm cố định
            int count = 0, k = 0;
            /*
            for (int i = 0; i <= R; ++i)
            {
                if (count < C && i >= R)
                    i = 0;
                else if (count >= C)
                    break;
                Array[i][k] = 1;
                k++;
                count++;
            }
            */
            for (int i = 0; i <= R; ++i)
            {
                if (count < C && i > R)
                    i = 0;
                else if (count >= C || k >= C)
                    break;
                Array[i][k] = 1;
                k += 2;
                count++;
            }
            //Xoay ca
            for (int RT = 1; RT <= DayOfRotation; ++RT)
            {
                for(int i = 0; i < R; ++i)
                {
                    for(int j = 0; j < C; ++j)
                    {
                        if (Arr[i][j] == 1 && j < C - 1)                        //Nếu tại ô đó = 1
                        {
                            Swap(ref Arr, i, j, i, j+1);
                            j++;
                        }
                        else if (Arr[i][j] == 1 && j == C - 1)
                        {
                            Swap(ref Arr, i, j, i, 0);
                        }
                    }
                }
            }
            return Array;
        }
    }
}
