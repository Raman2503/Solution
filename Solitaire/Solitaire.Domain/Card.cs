using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire.Domain
{
    public class Card
    {
        public Rank Rank { get; set; }
        public Suite Suite { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}",Rank,Suite);
        }
    }
}
