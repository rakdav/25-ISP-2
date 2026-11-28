namespace OurLibrary
{
    public class OurClassLibrary
    {
        public static int MultiMatrix(int[] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.Length; i++) sum += matrix[i];
            return sum;
        }
    }
}
