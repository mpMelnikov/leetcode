public static class ArrayHelper
{
    public static T[][] ToJagged<T>(this T[,] array)
    {
        // Get the dimensions of the array
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        // Create a jagged array with the same number of rows
        T[][] jagged = new T[rows][];

        // Loop through the rows
        for (int i = 0; i < rows; i++)
        {
            // Create a new array for each row with the same number of columns
            jagged[i] = new T[cols];

            // Loop through the columns
            for (int j = 0; j < cols; j++)
            {
                // Copy the element from the original array to the jagged array
                jagged[i][j] = array[i, j];
            }
        }

        // Return the jagged array
        return jagged;
    }
}
