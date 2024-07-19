#!/bin/sh
read -p "enter a value" a
read -p "enter a value" b
read -p "enter a value" c

echo "values are &a &b &c"

if [ $a -gt $b ] && [ $a -gt $b ]; then
echo "a is greater"
elif [ $b -gt $a ] && [ $b -gt $c ]; then
echo "b is greater"
else " c is greater"
fi


