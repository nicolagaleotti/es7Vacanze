using System;
using System.Collections.Generic;

namespace StatisticaLibrary
{
    public class Statistica
    {
        public static bool IsPositivo(int n)
        {
            bool resp = false;
            if (n > 0)
                resp = true;
            return resp;
        }
        
        public static int ContaPositivi(int[] num)
        {
            int c = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 0)
                    c++;
            }
            return c;
        }

        public static int[] Positivi(int[] num)
        {
            List<int> positivi = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 0)
                    positivi.Add(num[i]);
            }
            int[] resp = new int[positivi.Count];
            for (int i = 0; i < resp.Length; i++)
            {
                resp[i] = positivi[i];
            }
            return resp;
        }
    }
}
