#!/bin/sh
display()
{
echo "dispaly is a function"
}

#function call
display


#function with return value


sum()
{ 

return 10;
 
}
sum
result=$?
echo "$result"


#function with argument
sub()
{
 num1=$1 
 num2=$2
sub=$(($num1-$num2))
echo "substract $sub"
}

sub 10 5











