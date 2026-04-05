//Q3. Write C program to print the size of the file.
#include <stdio.h>
#include <stdlib.h>
#include <sys/stat.h>
#include <unistd.h>

void print_file_size(char *filename) {
    struct stat file_stat;

    if (stat(filename, &file_stat) == -1) {
        perror("stat");
        return;
    }

    printf("File: %s -> Size: %ld bytes\n", filename, (long)file_stat.st_size);
}

int main(int argc, char *argv[]) {
    int i;

    if (argc < 2) {
        printf("Please provide a file as an argument.\n");
        return 1;
    }

    for (int i = 1; i < argc; i++) {
        print_file_size(argv[i]);
    }

    return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment 1 aos]$ gcc Q3.c
// [mcs10@cs13 Assignment 1 aos]$ ./a.out
// Please provide a file as an argument.
// [mcs10@cs13 Assignment 1 aos]$ ./a.out file1.txt
// File: file1.txt -> Size: 0 bytes