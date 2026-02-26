//Q8.Write a C program to create a file with hole in it.
#include<stdio.h>
#include<stdlib.h>
#include<unistd.h>
#include<fcntl.h>
int main() {
int fd;
off_t offset;
fd=open("file_with_hole.txt",O_WRONLY|O_CREAT,0644);
if(fd==-1) {
perror("Error opening file");
exit(1);
}
write(fd,"Hello",5);
offset=lseek(fd,100,SEEK_SET);
if(offset==-1) {
perror("Error setting file offset");
exit(1);
}
write(fd,"World",5);
close(fd);
printf("file with hole created successfully.\n");
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment 1 aos]$ gcc Q19.c
// [mcs10@cs13 Assignment 1 aos]$ ./a.out
// file with hole created successfully.
// [mcs10@cs13 Assignment 1 aos]$ hexdump -c file_with_hole.txt
// 0000000 H e l l o \0 \0 \0 \0 \0 \0 \0 \0 \0 \0 \0
// 0000010 \0 \0 \0 \0 \0 \0 \0 \0 \0 \0 \0 \0 \0 \0 \0 \0