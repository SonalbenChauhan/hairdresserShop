using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hairdresserShop
{
    public class Ladies : Client
    {
        private bool hairStyle;


        public bool HairStyle { get => hairStyle; set => hairStyle = value; }


        public override void OtherService()

        {
            string style = string.Empty;


            if (hairStyle)
            {
                style = "yes";
            }
            else
            {
                style = "no";
            }

            // Console.WriteLine("Need hairstyle : {0}", style);
        }

        public override string ToString()
        {
            string style = string.Empty;


            if (hairStyle)
            {
                style = "yes";
            }
            else
            {
                style = "no";
            }
            return string.Format("Ladies need hairstyle : {0}, {1}", style, base.ToString());
        }
    }
}
