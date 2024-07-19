#!/bin/blash

name=("yashu" "sree" "yashasree")
echo "first element is" ${names[0]}
echo "second element is" ${names[1]}
echo "third element is" ${names[2]}
for name in ${names[@]}
do  
echo $name
done
