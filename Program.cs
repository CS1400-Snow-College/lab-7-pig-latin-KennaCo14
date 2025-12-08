// See https://aka.ms/new-console-template for more information

//Mykenna
// 12/8/25
//Lab 7

Console.WriteLine("Lets make a phrase into pig latin and encrypt it!");
Console.WriteLine("Give me a phrase to turn into pig latin:");
Console.Write("Phrase: ");
string[] input = Console.ReadLine().ToLower().Split(" ");

char[] vowels = {'a', 'e', 'i', 'o', 'u'};

string pigTranslate = "";
//PigLatining
for (int i = 0; i < input.Length; i++)
{
    //Starting Vowel
    bool startVowel = false;
    foreach (char letter in vowels)
    {
        if(input[i].StartsWith(letter))
        {
            startVowel = true;
            break;
        }
    }
    if (startVowel)
        input[i] += "way";

    else
    {
        //closest vowel
        int nextVowel = input[i].Length;
        foreach(char letter in vowels)
        {
            int index = input[i].IndexOf(letter);
            if(index != -1)
            {
                if (index < nextVowel)
                    nextVowel = index;
            }
        }
        string start = input[i].Substring(0, nextVowel);

        input[i] = input[i].Remove(0, nextVowel);
        input[i] = start + "ay";

    }
}
foreach(string word in input)
    pigTranslate += word + " ";

Console.WriteLine($"In pig latin: {pigTranslate}.");