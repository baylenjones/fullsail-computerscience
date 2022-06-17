using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7A
{
    public class textCodec
    {
        sbyte mOffset;
        public textCodec(sbyte offset)
        {
            mOffset = offset;
        }

        public string Encode(string message)
        {
            StringBuilder sb = new StringBuilder(message);
            for (int i = 0; i < message.Length; i++)
            {
                sb[i] = (char)(sb[i] + mOffset);
            }
            return sb.ToString();
        }

        public string Decode(string message)
        {
            StringBuilder sb = new StringBuilder(message);
            for (int i = 0; i < message.Length; i++)
            {
                sb[i] = (char)(sb[i] - mOffset);
            }
            return sb.ToString();
        }

    }
}
