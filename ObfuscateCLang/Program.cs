using System;
using System.Collections.Generic;
using System.IO;

namespace ObfuscateCLang
{
    class Program
    {
        static List<string> noun = new List<string>() {"TIME", "NEXT_STAGE", "SAX", "BOMB", "POPING", "ONIKU", "COURT", "CHICKEN", "ABEL", "VICE", "VIRTUE", "HOUSE", "KUWAZAWA", "ROOK",
            "ENDO", "TAKANEZAWA", "ODANOBUNAGA"};
        static List<string> preposition = new List<string>() { "TO", "OF", "IN", "FROM", "NEXT_TO", "ON", "INTO", "AROUND", "AMONG" };
        static List<string> characters = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        static List<string> types = new List<string>() { "int", "int[]", "int*", "char", "char[]", "long", "float", "float[]", "float*" , "double", "double[]", "double*"};
        static string InputSourceFilePath()
        {
            Console.WriteLine("難読化対象のファイルのパスを入力してください（相対パス）");
            string filePath = Console.ReadLine();
            return filePath;
        }
        static string InputWriteFileName()
        {
            Console.WriteLine("書き出すファイル名を指定してください(.cを含めないでください)");
            string filename = Console.ReadLine();
            return filename;
        }
        static Dictionary<string, string> AnalyzeSourceFile(string path)
        {
            var dict = new Dictionary<string, string>();
            int numberOfNoun = noun.Count;
            int numberOfPreposition = preposition.Count;
            int numberOfCharacter = characters.Count;
            //#が出てくる場所を検索する
            int sharpIndex;
            try
            {
                using (var reader = new StreamReader(path))
                {
                    while(!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] token = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach(string t in token)
                        {
                            sharpIndex = t.IndexOf("#");
                            //プリプロセッサ命令がある列は暗号化を行わない
                            if(sharpIndex != -1)
                            {
                                break;
                            }
                            //トークンの重複は許容しない
                            if(!dict.ContainsKey(t))
                            {
                                Random r = new Random();
                                //ダミー文字をランダムに生成する
                                string value = noun[r.Next(0, numberOfNoun)] + preposition[r.Next(0, numberOfPreposition)] + noun[r.Next(0, numberOfNoun)] + characters[r.Next(0, numberOfCharacter)] + noun[r.Next(0, r.Next(0, numberOfNoun))];
                                //値が重複していれば再抽選を行う
                                while(dict.ContainsValue(value))
                                {
                                   value = noun[r.Next(0, numberOfNoun)] + preposition[r.Next(0, numberOfPreposition)] + noun[r.Next(0, numberOfNoun)] + characters[r.Next(0, numberOfCharacter)] + noun[r.Next(0, r.Next(0, numberOfNoun))];
                                }
                                dict.Add(t, value);
                            }
                        }
                    }
                    return dict;
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("File Reading Error");
                Console.WriteLine(e.Message);
                return dict;
            }
        }
        static void Obfusecate(Dictionary<string, string> dict, string filename, string filepath)
        {
            //プリプロセッサ命令が読み終わったか
            bool isNotInitial = false;
            try
            {
                using (var reader = new StreamReader(filepath))
                {
                    using (var writer = new StreamWriter(filename + ".c", false))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            //プリプロセッサ命令はすべてそのまま出力する
                            while(line.IndexOf("#") != -1 || line == "")
                            {
                                string[] token = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (string t in token)
                                {
                                    //プリプロセッサ命令はそのまま記述する
                                    writer.Write(t + " ");
                                }
                                writer.Write("\r\n");
                                line = reader.ReadLine();
                            }
                            if(!isNotInitial && line != "")
                            {
                                foreach(var d in dict)
                                {
                                    writer.Write("#define " + d.Value + " " + d.Key + "\r\n");
                                }
                                isNotInitial = true;
                            }
                            if(isNotInitial)
                            {
                                string[] token = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                                foreach (string t in token)
                                {
                                    writer.Write(dict[t] + " ");
                                }
                            }
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("File Reading Error");
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            var filePath = InputSourceFilePath();
            dict = AnalyzeSourceFile(filePath);
            var fileName = InputWriteFileName();
            Obfusecate(dict, fileName, filePath);
            Console.WriteLine("EnterKey押すと終了します");
            //EnterKeyを押すまで待機
            while(Console.ReadKey().Key != ConsoleKey.Enter){}
        }
    }
}
