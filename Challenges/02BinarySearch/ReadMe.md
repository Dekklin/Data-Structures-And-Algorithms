## Challenge

Write a function that runs a binary search on an Int Array, returning the index of the found search key. If the search key was not found, return -1

Everytime we find the mid point, because the array is in numerical order, we can shorten our search by adjusting the min and max, dependant on what the mid point is, and where the search key is relative to the mid point. On a large array full of hundreds of numbers, this is very efficient.

- ![Challenge 02 : Binary Search](../../assets/BinarySearch.jpg)

