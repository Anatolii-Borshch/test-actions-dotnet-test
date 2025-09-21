namespace TestBack.Console.Services
{
    public class CalculateService
    {
        public int Factorial(int n)
        {
            if (n <= 0)
                throw new ArgumentException("n must be greater than 1");

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        public int ArraySum(int[] array)
        {
            if(array == null || array.Length == 0)
                throw new ArgumentException("array must not be empty");
            
            int sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            
            return sum;
        }

        public bool IsPatronimic(string str)
        {
            if(string.IsNullOrWhiteSpace(str))
                throw new ArgumentException("str must not be empty");
            
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                    return false;
                
                left++;
                right--;
            }
            
            return true;
        }
    }
}