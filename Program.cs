using System;

// A way to write code that represents some thing; object.
// An animal for example

namespace dotnet_hello_world
{
    class Program
    { // below is a method called 'Main'
        static void Main(string[] args)
        { // Lines in these {} will run at start of program

            Console.WriteLine("Hello World!");
            CeaserCipher ceaser = new CeaserCipher("Hello Proth");
            Console.WriteLine(ceaser.word);
            ceaser.Encrypt();
            Console.WriteLine(ceaser.word);
            // ceaser.Word = "Not encrypted";

        }
    }

    public bool guess(ICipher cipher, string guess)
    {
        return cipher.Decrypt() == guess;
    }


    interface ICipher 
    {
        public string Word {get; set;}
        void Encrypt();
        void Decrypt();
    }

    class EnigmaCipher: ICipher 
    {

    }

    class CeaserCipher: ICipher {
        private string Word {get; set;}
        // Constructor, needs to be the same name as class
        public CeaserCipher(string word) {
            Word = word;
        }

        public void Encrypt()
        {
            Word = "SDFLKSLDKFJLSDKJF";
        }
        
        public void Decrypt()
        {
            Word = "Hello Proth";
        }
    }
}






// Console.WriteLine("This is the first line.");
// Console.Write("");
// Console.Write("This is the second line.");
// Console.WriteLine("");
// Console.Write("This is the third line.");
// Console.WriteLine("The current time is " + DateTime.Now);