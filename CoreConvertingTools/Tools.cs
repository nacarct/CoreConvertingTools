using System;

namespace CoreConvertingTools
{
    public static class Tools
    {
        public static int ToInt(this object value)
        {
            int vl;

            try
            {
                vl = Convert.ToInt32(value);
            }
            catch (Exception)
            {
                vl = 0;
            }

            return vl;
        }

        public static short ToShort(this object value)
        {
            short vl;

            try
            {
                vl = Convert.ToInt16(value);
            }
            catch (Exception)
            {
                vl = 0;
            }

            return vl;
        }

        public static long ToLong(this object value)
        {
            long vl;

            try
            {
                vl = Convert.ToInt64(value);
            }
            catch (Exception)
            {
                vl = 0;
            }

            return vl;
        }

        public static double ToDouble(this object value)
        {
            double vl;

            try
            {
                vl = Convert.ToDouble(value);
            }
            catch (Exception)
            {
                vl = 0;
            }

            return vl;
        }

        public static DateTime ToDateTime(this object value)
        {
            DateTime vl;

            try
            {
                vl = Convert.ToDateTime(value);
            }
            catch (Exception)
            {
                vl = DateTime.Now;
            }

            return vl;
        }
    }
}
