using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REdit_prototype
{
    [Serializable]
    public class WordObject
    {
        //autoimplemented properties..consider adding logic, but users won't access
        public string word { get; set; }
        public int count { get; set; }
        public DateTime dateLastUsed { get; set; }
        public string grammarType { get; set; }
        
    }
}