using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hairdresserShop
{
    public class AppointmentList : IEnumerable<IClient>
    {
        public List<IClient> appList = null;
        public AppointmentList()

        {
            appList = new List<IClient>();

        }
        public void Add(Client a)
        {
            appList.Add(a);
        }

        public IEnumerator<IClient> GetEnumerator()
        {
            return ((IEnumerable<IClient>)appList).GetEnumerator();

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<IClient>)appList).GetEnumerator();

        }

        public int Count
        {
            get
            {
                return appList.Count;
            }
        
           
        }

        public IClient this[int i]
        {
            get { return appList[i]; }
            set { appList[i] = value;  }
        }

        public void Sort()
        {
            appList.Sort();
        }
    }
}




