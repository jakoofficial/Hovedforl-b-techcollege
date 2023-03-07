/* Quick Sorting | H1 - Grundlæggende Programming
 * Jacob Ø. Andersen */

int[] arr = {1, 10, 3, 9, 4, 7}; //Original Array for sorting
int[] oriArr = new int[arr.Length]; //Copy of original Array for print
arr.CopyTo(oriArr, 0);

int n = arr.Length;

QuickSort(arr, 0, n-1); //Sorts array

PrintArr(n, oriArr, arr); //Prints array

/* Prints the different array values including their location in the array.
 * Values:
 * n = int value | Array length
 * oriArr = int array | Copy of array
 * a = int array | Array to sort */
static void PrintArr(int n, int[] oriArr, int[] a)
{
    for (int i = 0; i < n; i++)
        Console.WriteLine("Arr space: {0} | Ori: {1} | New: {2} ", i, oriArr[i], a[i]);
}

/* Sorts the array by checking the low index against the high index from a start position.
 * Values: 
 * a = int array | The array to sort 
 * low = int value | Lowest position for partition
 * high = int value | Highest position for partition */
static void QuickSort(int[] a, int low, int high)
{
    if (low < high)
    {
        int par = Partition(a, low, high); //Finds the partition index
        /*Sorts seperately first from the higest value in the array (high = par-1)
         *Then sorts from where sorting is correct (low = par+1)*/
        QuickSort(a, low, par-1);
        QuickSort(a, par+1, high);
    }
}

/* Sorts the array using high as pivot
 * Checks if pivot is higher than index on array
 * If true: +1 to smallest element position (k) -
 * Swap array pos k with array pos i (a[k] -> a[i])
 * -------
 * After the loop swap array pos k+1 with highest pos in array (a[k+1] -> a[high]) -
 * This is to arrange the pivots position currectly.
 * -------
 * Return the partition index (k + 1) 
 * -------
 * Values:
 * a = int array | The array to sort 
 * low = int value | Lowest position for partition
 * high = int value | Highest position for partition */
static int Partition(int[] a, int low, int high)
{
    var pivot = a[high];
    int k = (low - 1);

    for (int i = low; i <= high; i++)
    {
        if (a[i] < pivot)
        {
            k++;
            Swap(a, k, i);
        }
    }
    Swap(a, k + 1, high);
    return k + 1;
}

/* Swaps array value k and array value i.
 * Values:
 * a = int Array | Array for swapping
 * k = int value | Array pos of value to move
 * i = int value | Array pos of value to move */
static void Swap(int[] a, int k, int i)
{
    int temp = a[k];
    a[k] = a[i];
    a[i] = temp;
}