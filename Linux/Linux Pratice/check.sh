#!/bin/sh

read -p "enter the file name": filename
if [ -w $filename ]
then
echo "the file writeable"
else
echo"file is not writable"
fi   
