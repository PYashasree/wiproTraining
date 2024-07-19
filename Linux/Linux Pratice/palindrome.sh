#!/bin/sh



# Check whether the number is palindrome or not
read -p "Enter a number: " number
reverse=$(echo "$number" | rev)
if [ "$number" -eq "$reverse" ]; then
    echo "$number is a palindrome"
else
    echo "$number is not a palindrome"
fi
