//Q4.Write a C program to open a file goes to sleep for 15 seconds before terminating.
#include <stdio.h>
#include <unistd.h>
#include <fcntl.h>
int main() {
int fd;
const char *filename = "example_file.txt";
fd = open(filename, O_RDWR | O_CREAT, 0644);
if (fd == -1) {
perror("Failed to open file");
return 1;
}printf("File opened successfully. Sleeping for 15 seconds...\n");
sleep(15);
close(fd);
printf("Slept for 15 seconds and file closed. Exiting program.\n");
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment1 aos]$ gcc Q20.c
// [mcs10@cs13 Assignment1 aos]$ ./a.out Q20.c
// File opened successfully. Sleeping for 15 seconds...
// Slept for 15 seconds and file closed. Exiting program.