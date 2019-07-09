namespace practice_problems.Strings
{
    public static class Beginner

    {
        //reverse a string
        public static string Reverse(this string input){
            string result = "";
            if(!string.IsNullOrEmpty(input)){
                for (int i = input.Length -1; i >= 0; i--){
                    result += input.ToCharArray()[i];
                }
                return result;
            }else{
                return input;
            }
        }

        //reverse a string in place (without allocating an extra array)
        public static string ReverseInPlace(this string input){
            if(!string.IsNullOrEmpty(input)){
                char[] characters = input.ToCharArray();
                int i = 0;
                int j = characters.Length - 1;
                while (i < j){
                    //swap characters
                    char temp = characters[i];
                    characters[i] = input[j];
                    characters[j] = temp;
                    i++;
                    j--;
                }
                return characters.ToString();
            }else{
                return input;
            }
           

        }
    }
}