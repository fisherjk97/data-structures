namespace practice_problems.Strings
{
    public static class Beginner

    {
        //reverse a string
        public static string Reverse(this string input){
            string result = "";
            for (int i = input.Length -1; i >= 0; i--){
                result += input.ToCharArray()[i];
            }
            return result;

        }
    }
}