#!/bin/sh

read -p "Enter the folder path: " folder
if [ -d "$folder" ]; then
    echo "Directories in $folder:"
    find "$folder" -type d
else
    echo "Folder not found"
fi
