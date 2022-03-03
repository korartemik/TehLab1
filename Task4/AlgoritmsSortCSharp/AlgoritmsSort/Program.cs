internal class Program
{
    private static void Quick_Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                Quick_Sort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                Quick_Sort(arr, pivot + 1, right);
            }
        }

    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {

            while (arr[left] < pivot)
            {
                left++;
            }

            while (arr[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                if (arr[left] == arr[right]) return right;

                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;


            }
            else
            {
                return right;
            }
        }
    }
    public static int[] mergeSort(int[] array)
    {
        int[] left;
        int[] right;
        int[] result = new int[array.Length];
        if (array.Length <= 1)
            return array;
        int midPoint = array.Length / 2;
        left = new int[midPoint];

        if (array.Length % 2 == 0)
            right = new int[midPoint];
        else
            right = new int[midPoint + 1];
        for (int i = 0; i < midPoint; i++)
            left[i] = array[i];
        int x = 0;
            for (int i = midPoint; i < array.Length; i++)
        {
            right[x] = array[i];
            x++;
        }
        left = mergeSort(left);
        right = mergeSort(right);
        result = merge(left, right);
        return result;
    }

    public static int[] merge(int[] left, int[] right)
    {
        int resultLength = right.Length + left.Length;
        int[] result = new int[resultLength];
        int indexLeft = 0, indexRight = 0, indexResult = 0;
        while (indexLeft < left.Length || indexRight < right.Length)
        {
            if (indexLeft < left.Length && indexRight < right.Length)
            {
                if (left[indexLeft] <= right[indexRight])
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            else if (indexLeft < left.Length)
            {
                result[indexResult] = left[indexLeft];
                indexLeft++;
                indexResult++;
            }
            else if (indexRight < right.Length)
            {
                result[indexResult] = right[indexRight];
                indexRight++;
                indexResult++;
            }
        }
        return result;
    }
    private static void Main()
    {
        int n = 5000000;
        int[] mas1 = new int[n];
        int[] mas2 = new int[n];
        List<int> list = new List<int>();
        Random rand = new Random(); 
        for(int i =0; i<n; i++)
        {
            int x = rand.Next();
            mas1[i] = x;
            mas2[i] = x;
            list.Add(x);
        }
        mas2 = mergeSort(mas2);
        Quick_Sort(mas1, 0, n-1);
        list.Sort();
        
    }
}