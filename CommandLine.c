//Q2.Write a C program to print the type of file where file name is accepted through command line.
#include <stdio.h>
#include <stdlib.h>
#include <sys/stat.h>
#include <unistd.h>

void print_file_type(char *filename) {
    struct stat file_stat;

    if (stat(filename, &file_stat) == -1) {
        perror("stat");
        return;
    }

    if (S_ISREG(file_stat.st_mode)) {
        printf("File: %s is a Regular File.\n", filename);
    }
    else if (S_ISDIR(file_stat.st_mode)) {
        printf("File: %s is a Directory.\n", filename);
    }
    else if (S_ISLNK(file_stat.st_mode)) {
        printf("File: %s is a Symbolic Link.\n", filename);
    }
    else if (S_ISCHR(file_stat.st_mode)) {
        printf("File: %s is a Character Device.\n", filename);
    }
    else if (S_ISBLK(file_stat.st_mode)) {
        printf("File: %s is a Block Device.\n", filename);
    }
    else if (S_ISFIFO(file_stat.st_mode)) {
        printf("File: %s is a FIFO (Named Pipe).\n", filename);
    }
    else if (S_ISSOCK(file_stat.st_mode)) {
        printf("File: %s is a Socket.\n", filename);
    }
    else {
        printf("File: %s has an unknown type.\n", filename);
    }
}

int main(int argc, char *argv[]) {
    int i;

    if (argc < 2) {
        printf("Please provide a file as an argument.\n");
        return 1;
    }

    for (i = 1; i < argc; i++) {
        print_file_type(argv[i]);
    }

    return 0;
}

// OUTPUT-
// gcc Q2.c
// ./a.out file1.txt
// File: file1.txt is a Regular File.
