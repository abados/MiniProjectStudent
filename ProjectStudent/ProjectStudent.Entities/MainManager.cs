using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStudent.Entities
{
    public class MainManager
    {

        private MainManager() { }

        private static readonly MainManager _Instance = new MainManager();
        public static MainManager Instance { get { return _Instance; } }


        public Hashtable hashStudent = new Hashtable();


    }
}
