#!/bin/sh

read -p "enter the filename :" filename

if [ -f $filename ]
then
echo "first is found"
else
echo "file is not found"
fi
