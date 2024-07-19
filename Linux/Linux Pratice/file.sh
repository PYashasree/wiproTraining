#!/bin/sh
 read -p "enter the filename :" filename

if [ -f $filname ]
then
echo "file is found"
else
echo "file is not fount"
fi
