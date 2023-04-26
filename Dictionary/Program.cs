namespace Dictionary
{
    internal class Program
    {
        void Dictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            // 키와 데이터를 해싱함                                               //
                                                                                  //
            dictionary.Add("txt", "텍스트 파일");                                 // 
            // "txt" : key, "텍스트 파일" : 데이터                                //
            dictionary.Add("bmp", "이미지 파일");                                 //
            dictionary.Add("mp3", "오디오 파일");                                 //
                                                                                  //
            Console.WriteLine(dictionary["txt"]);                                 //
            // 인덱서를 통해 키값에 접근                                          //
            if (dictionary.ContainsKey("mp3"))                                    //
                Console.WriteLine("mp3 키 값의 데이터가 있음");                   //
            // mp3 키 값이 있을 때                                                //
            else                                                                  //
                Console.WriteLine("mp3 키 값의 데이터가 없음");                   //
            // mp3 키 값이 없을 때                                                //
                                                                                  //
            if (dictionary.Remove("mp3"))                                         //
                Console.WriteLine("mp3 키 값에 해당하는 데이터를 지움");          //
            // mp3 키 값이 있을 때 삭제함                                         //
            else                                                                  //
                Console.WriteLine("mp3 키 값에 해당하는 데이터를 못지움");        //
            // mp3 키 값이 없어서 데이터를 삭제하지 못함                          //
                                                                                  //
            if (dictionary.ContainsKey("mp3"))                                    //
                Console.WriteLine("mp3 키 값의 데이터가 있음");                   //
            else                                                                  //
                Console.WriteLine("mp3 키 값의 데이터가 없음");                   //
                                                                                  //
            string output;                                                        //
            if (dictionary.TryGetValue("bmp", out output))                        //
                Console.WriteLine(output);                                        //
            // bmp 키 값이 있을 때 bmp 키 값의 데이터를 출력함                    //
            else                                                                  //
                Console.WriteLine("bmp 키 값의 데이터가 없음");                   //
            // bmp 키 값이 없어서 찾지를 못함
        }

        static void Main(string[] args)
        {
            DataStructure.HashTable<string, string> hashTable = new DataStructure.HashTable<string, string>();

            hashTable.Add("txt", "텍스트 파일");
            hashTable.Add("bmp", "이미지 파일");
            hashTable.Add("mp3", "오디오 파일");

            Console.WriteLine(hashTable["txt"]);       // 키값은 인덱서를 통해 접근

            if (hashTable.ContainsKey("mp3"))
                Console.WriteLine("mp3 키 값의 데이터가 있음");
            else
                Console.WriteLine("mp3 키 값의 데이터가 없음");

            if (hashTable.Remove("mp3"))
                Console.WriteLine("mp3 키 값에 해당하는 데이터를 지움");
            else
                Console.WriteLine("mp3 키 값에 해당하는 데이터를 못지움");

            if (hashTable.ContainsKey("mp3"))
                Console.WriteLine("mp3 키 값의 데이터가 있음");
            else
                Console.WriteLine("mp3 키 값의 데이터가 없음");

            string output;
            if (hashTable.TryGetValue("bmp", out output))
                Console.WriteLine(output);
            else
                Console.WriteLine("bmp 키 값의 데이터가 없음");
        }
    }
}