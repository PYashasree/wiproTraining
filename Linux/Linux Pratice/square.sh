#!/bin/sh

square()
{

num=$1
square=$((num*num))

return  $square

}
square 2
result=$?
echo "square is a $result"
