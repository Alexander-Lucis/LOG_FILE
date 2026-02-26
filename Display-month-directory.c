//Q5.Write a C program to display all the files from current directory which are created in particular month.
#include <stdio.h>
#include <stdlib.h>
#include <dirent.h>
#include <sys/stat.h>
#include <time.h>
#include <string.h>

void list_files_by_month(const char *dir_name, int target_month)
{
    DIR *dir = opendir(dir_name);
    if (dir == NULL)
    {
        perror("opendir");
        return;
    }

    struct dirent *entry;
    struct stat file_stat;
    struct tm *time_info;
    int file_count = 0;

    while ((entry = readdir(dir)) != NULL)
    {
        if (strcmp(entry->d_name, ".") != 0 &&
            strcmp(entry->d_name, "..") != 0)
        {
            if (stat(entry->d_name, &file_stat) == -1)
            {
                perror("stat");
                continue;
            }

            time_info = localtime(&file_stat.st_mtime);
            int file_month = time_info->tm_mon + 1;

            if (file_month == target_month)
            {
                printf("%s\n", entry->d_name);
                file_count++;
            }
        }
    }

    if (file_count == 0)
    {
        printf("No files found in month %d.\n", target_month);
    }

    closedir(dir);
}

int main()
{
    int month;

    printf("Enter the month number (1-12): ");
    scanf("%d", &month);

    if (month < 1 || month > 12)
    {
        printf("Invalid month. Please enter a number between 1 and 12.\n");
        return 1;
    }

    list_files_by_month(".", month);

    return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment 1 aos]$ gcc Q5.c
// [mcs10@cs13 Assignment 1 aos]$ ./a.out Q5
// Enter the month number (1-12): 1
// ass 1 aos.odt
// file1.txt
// Q1.c
// Q3.c
// Q2.c
// Q3.c~
// Q2.c~
// Q4.c
// .~lock.ass 1 aos.odt#
// Q5.c
// Q4.c~
// Q5.c~
// a.out