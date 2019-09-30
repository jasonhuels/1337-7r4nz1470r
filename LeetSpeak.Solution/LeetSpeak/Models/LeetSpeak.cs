namespace LeetSpeak
{
    public class Translator
    {
        public string EnglishToLeet(string inputString)
        {
            string OutputString = "";
            for(int i=0; i<inputString.Length; i++)
            {
                if(char.ToLower(inputString[i]) =='e')
                {
                    OutputString += "3";
                } 
                else if(char.ToLower(inputString[i]) =='a')
                {
                    OutputString += "4";
                } 
                else if(char.ToLower(inputString[i]) =='o')
                {
                    OutputString += "0";
                } 
                else if(char.ToLower(inputString[i]) =='t')
                {
                    OutputString += "7";
                } 
                else if(char.ToLower(inputString[i]) =='c' && i<inputString.Length-3)
                {
                    if(char.ToLower(inputString[i+1]) == 'k' && char.ToLower(inputString[i+2]) == 'e' && char.ToLower(inputString[i+3]) == 'r')
                    {
                        OutputString += "x0r";
                        i += 3;
                    }
                    
                } 
                else if(i > 0 && char.ToLower(inputString[i]) =='s')
                {
                    OutputString += "z";
                } 
                else if(inputString[i] == 'L')
                {
                    OutputString += "1";
                } 
                else 
                {
                    OutputString += inputString[i];
                }
            }

            return OutputString;
        }
    }
}