using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace REdit_prototype

{
    class Serializer
    {
        //attributes
        private List<WordObject> wordList = new List<WordObject>();
        private string filePath;

        //ctor.. this simple one is adequate for object construction
        public Serializer()
        {

        }
        //pass the parameters to the instantiated object
        public Serializer(List<WordObject> wordList, string filePath)
        {
            this.wordList = wordList;
            this.filePath = filePath;
        }

        //methods

        //serialize a List of WordObjects to File
        public void Serialize(List<WordObject> wordList, string filePath)
        {

            using (Stream fileStream = File.Open(filePath, FileMode.Create))
            {
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(fileStream, wordList);
            }

        }

        //deserialize a File to a List which is passed back to the method call
        public List<WordObject> Deserialize(string filePath)
        {
            List<WordObject> wordList;
            using (Stream fileStream = File.OpenRead(filePath))
            {
                BinaryFormatter deserializer = new BinaryFormatter();
                wordList = (List<WordObject>)deserializer.Deserialize(fileStream);
            }
            return wordList;

        }




    }
}
