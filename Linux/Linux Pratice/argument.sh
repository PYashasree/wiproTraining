#!/bin/sh


display()
{

arg1=$1
arg2=$2
arg3=$@


echo "result of arg1:$arg1"
echo "result of arg2:$arg2"
echo "result of arg3:$arg3"
}

display  1 2 3 4

