using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hairdresserShop
{
   public class Children : Client
    {
        private bool sensitiveTrimmers;
        private bool adjustableSeats;

        public bool SensitiveTrimmers { get => sensitiveTrimmers; set => sensitiveTrimmers = value; }
        public bool AdjustableSeats { get => adjustableSeats; set => adjustableSeats = value; }
        public override void OtherService()

        {
            string sensitiveTrimmer = string.Empty;
            string seatAdjustable = string.Empty;

            if (sensitiveTrimmers)
            {
                sensitiveTrimmer= "yes";
            }
            else
            {
                sensitiveTrimmer = "no";
            }
            if (adjustableSeats)
            {
                seatAdjustable = "yes";
            }
            else
            {
                seatAdjustable = "no";
            }
            Console.WriteLine("Sensitive Trimming : {0}, Adjustable Seating : {1}", sensitiveTrimmer, seatAdjustable);
        }

        public override string ToString()
        {
            string sensitiveTrimmer = string.Empty;
            string seatAdjustable = string.Empty;

            if (sensitiveTrimmers)
            {
                sensitiveTrimmer = "yes";
            }
            else
            {
                sensitiveTrimmer = "no";
            }
            if (adjustableSeats)
            {
                seatAdjustable = "yes";
            }
            else
            {
                seatAdjustable = "no";
            }
            return string.Format("Children need  sensitive trimmers : {0}, and also require adjustable seat : {1} , {2}", sensitiveTrimmer, seatAdjustable, base.ToString());
        }

    }
}
