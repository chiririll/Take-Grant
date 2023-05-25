using System.Text;

namespace TakeGrant.Model
{
    public static class Rights
    {
        public static Type FromString(string str)
        {
            var rights = Type.None;
            foreach (var c in str)
            {
                switch (c)
                {
                    case 'r':
                    case 'R':
                        rights |= Type.Read;
                        break;
                    case 'w':
                    case 'W':
                        rights |= Type.Write;
                        break;
                    case 't':
                    case 'T':
                        rights |= Type.Take;
                        break;
                    case 'g':
                    case 'G':
                        rights |= Type.Grant;
                        break;
                }
            }
            return rights;
        }

        public static string ToString(Type rights)
        {
            var str = new StringBuilder(4);
            
            if ((rights & Type.Read) != 0) str.Append('r');
            if ((rights & Type.Write) != 0) str.Append('w');
            if ((rights & Type.Take) != 0) str.Append('t');
            if ((rights & Type.Grant) != 0) str.Append('g');
            
            return str.ToString();
        }

        public static Type Randomize(System.Random rand) => rand.Next(2) == 1 ? (Type)rand.Next((int)Type.Grant + 1) : Type.None;

        public enum Type : byte
        {
            None = 0,
            Read = 1,
            Write = Read << 1,
            Take = Write << 1,
            Grant = Take << 1,
        }
    }
}
