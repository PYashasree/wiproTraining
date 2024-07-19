#!/bin/bash

array=(5 7 9 3 6)
sum=0

for num in "${array[@]}"
do
    sum=$((sum + num))
done

echo "The sum of the array is: $sum"
