//Q4.Write a C program to read the current directory and display the name of the files, no of files in current directory.
#include <stdio.h>
#include <stdlib.h>
#include <dirent.h>
#include <string.h>

void list_files_in_directory(const char *dir_name)
{
    DIR *dir = opendir(dir_name);

    if (dir == NULL)
    {
        perror("opendir");
        return;
    }

    struct dirent *entry;
    int file_count = 0;

    while ((entry = readdir(dir)) != NULL)
    {
        if (strcmp(entry->d_name, ".") != 0 &&
            strcmp(entry->d_name, "..") != 0)
        {
            printf("%s\n", entry->d_name);
            file_count++;
        }
    }

    printf("\nTotal number of files: %d\n", file_count);
    closedir(dir);
}

int main()
{
    const char *dir_name = ".";
    list_files_in_directory(dir_name);
    return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment 1 aos]$ gcc Q4.c
// [mcs10@cs13 Assignment 1 aos]$ ./a.out Q4
// ass 1 aos.odt
// file1.txt
// Q1.c
// Q3.c
// Q2.c
// Q3.c~
// Q2.c~
// .~lock.ass 1 aos.odt#
// Q4.c
// Q4.c~
// a.out
// Total number of files: 11