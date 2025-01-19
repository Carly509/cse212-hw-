public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

    // Step 1: Initialize an array of doubles with the specified length.
    double[] multiples = new double[length];

    // Step 2: Loop through each index from 0 to length - 1.
    for (int i = 0; i < length; i++)
    {
        // Step 3: Calculate the multiple and store it in the array.
        multiples[i] = number * (i + 1);
    }

    // Step 4: Return the populated array of multiples.
    return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Step 1: Calculate the effective rotation amount using modulo.
    int count = data.Count;
    amount = amount % count; // Handle cases where amount > count

    // Step 2: If amount is 0, no rotation is needed.
    if (amount == 0) return;

    // Step 3: Get the last 'amount' elements and the rest of the list.
    List<int> lastElements = data.GetRange(count - amount, amount);
    List<int> remainingElements = data.GetRange(0, count - amount);

    // Step 4: Clear the original list and add the elements back in the correct order.
    data.Clear();
    data.AddRange(lastElements);
    data.AddRange(remainingElements);
    }
}
