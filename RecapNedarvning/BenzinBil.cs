using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapNedarvning
{
    public class BenzinBil : Bil
    {

        /// <summary>
        /// angiver tanken i liter
        /// </summary>
        public int Tank { get; set; }
        public int KmPrLiter { get; set; }


        /// <summary>
        /// konstruktor for Benzinbil
        /// </summary>
        /// <param name="pris"></param>
        /// <param name="købsår"></param>
        /// <param name="kmPrL"></param>
        public BenzinBil(int pris, int købsår, string mærke, string regnr, int kmLiter, int tank)
            :base(pris, købsår, mærke, regnr)
        {
            this.KmPrLiter = kmLiter;
            this.Tank = tank;
        }


        public override int RækkeVidde()
        {
            return Tank*KmPrLiter;
        }

        public override int GrønAfgift()
        {
            return base.GrønAfgift()-500;
        }
    }
}
