namespace Solution;

public class DuplicateRemover 
{
    private const int MaxDuplicatesPerElement = 1;
        
    public int RemoveDuplicates(int[] numbers)
    {
        int currentUniqueIndex = 1;
        int currentCount = 0;
            
        for (int i = 1; i < numbers.Length; i++) 
        {
            if (numbers[i] != numbers[i - 1]) 
            {
                currentCount = 0;
                numbers[currentUniqueIndex++] = numbers[i];
            } 
            else 
            {
                currentCount++;
                    
                if (currentCount <= MaxDuplicatesPerElement) 
                    numbers[currentUniqueIndex++] = numbers[i];
            }
        }
            
        return currentUniqueIndex;
    }
}