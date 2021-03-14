using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hairdresserShop
{

    public class Gentlemen : Client

    {
        private bool isTrimmingNeeded;
        private bool moustaches;

        public bool IsTrimmingNeeded { get => isTrimmingNeeded; set => isTrimmingNeeded = value; }

        public bool Moustaches { get => moustaches; set => moustaches = value; }

        public override void OtherService()

        {
            string trim = string.Empty;
            string moustache = string.Empty;

            if (isTrimmingNeeded)
            {
                trim = "yes";
            }
            else
            {
                trim = "no";
            }
            if (moustaches)
            {
                moustache = "yes";
            }
            else
            {
                moustache = "no";
            }
            Console.WriteLine("Trimming : {0}, Moustaches : {1}", trim, moustache);
        }

        public override string ToString()
        {
            string trim = string.Empty;
            string moustache = string.Empty;

            if (isTrimmingNeeded)
            {
                trim = "yes";
            }
            else
            {
                trim = "no";
            }
            if (moustaches)
            {
                moustache = "yes";
            }
            else
            {
                moustache = "no";
            }
            return string.Format("Gentleman wants to do Trmming : {0}, and Moustaches : {1}, {2}", trim, moustache, base.ToString());

        }

    }
}
