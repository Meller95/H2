using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class ThreadpoolParallelMergeSort
    {
        private const int Threshold = 1000000; 

        public static void Sort(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException(nameof(arr));

            Sort(arr, 0, arr.Length - 1);
        }

        private static void Sort(int[] arr, int left, int right)
        {
            if (right - left < Threshold)
            {
                // Use sequential sort for small array segments
                SequentialMergeSort(arr, left, right);
            }
            else
            {
                if (left < right)
                {
                    int mid = (left + right) / 2;
                    CountdownEvent countdown = new CountdownEvent(2); // Synchronization mechanism

                    ThreadPool.QueueUserWorkItem(_ => {
                        Sort(arr, left, mid);
                        countdown.Signal();
                    });
                    ThreadPool.QueueUserWorkItem(_ => {
                        Sort(arr, mid + 1, right);
                        countdown.Signal();
                    });

                    countdown.Wait(); // Wait for both halves to be sorted
                    Merge(arr, left, mid, right);
                }
            }
        }


        private static void SequentialMergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                SequentialMergeSort(arr, left, mid);
                SequentialMergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArr[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                rightArr[j] = arr[mid + 1 + j];

            int iLeft = 0, iRight = 0, k = left;
            while (iLeft < n1 && iRight < n2)
            {
                if (leftArr[iLeft] <= rightArr[iRight])
                {
                    arr[k] = leftArr[iLeft++];
                }
                else
                {
                    arr[k] = rightArr[iRight++];
                }
                k++;
            }

            while (iLeft < n1)
                arr[k++] = leftArr[iLeft++];
            while (iRight < n2)
                arr[k++] = rightArr[iRight++];
        }
    }
}
