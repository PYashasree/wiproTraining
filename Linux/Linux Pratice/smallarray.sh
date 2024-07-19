#!/bin/bash

numbers=(23 9 4 15 6 32)

smallest=${numbers[0]}

for num in "${numbers[@]}"; do
    if (( num < smallest )); then
        smallest=$num
    fi
done

echo "The smallest number is: $smallest"
