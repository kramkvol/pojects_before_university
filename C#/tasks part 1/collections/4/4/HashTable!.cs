using System;
using System.Collections.Generic;
using System.Collections;
namespace _4
{
    class HashTable_
    {
        public string disk;
        public List<string> music;
        public Hashtable ht = new Hashtable();
        public HashTable_(string disk_, List<string> music_)
        {
            ht.Add(disk_, music_);
             //   disk = disk_;
            music = music_;
        }
        public HashTable_(string disk_, string  music_)
        {
            ht.Add(disk_, music_);
            //   disk = disk_;
           // music = music_;
        }
        string O()
        {
            string s = "";
            foreach (var i in ht.Values)
                s += i.ToString() + Environment.NewLine;
            return s;
        }
        public void AddMusic(string namedisk,params string[] a)
        {
           if(ht.ContainsKey(namedisk))
                foreach (string  x in a)
                ht.Add( namedisk,x);

        }
        public void PlayList()
        {
            Console.WriteLine(O());
           // Hashtable ht = new Hashtable();
          //  ICollection keys = ht.Keys;
            foreach (var s in ht.Keys)
            {
                Console.WriteLine(s.ToString());
             //   foreach (string i in ht.Values)
                {
                    Console.WriteLine(ht[s].ToString());// + ht[music]);
                }
            }
        }
    }
}
