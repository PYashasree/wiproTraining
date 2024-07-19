#!/bin/bash

dir_count=0
file_count=0

folder="/home/rps/programs"

for item in "$folder"/*; do
    if [ -d "$item" ]; then
        dir_count=$((dir_count + 1))
    elif [ -f "$item" ]; then
        file_count=$((file_count + 1))
    fi
done

echo "Total number of directories: $dir_count"
echo "Total number of files: $file_count"
