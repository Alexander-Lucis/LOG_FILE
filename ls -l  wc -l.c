// Q7.Write a C program to implement the following unix/linux command (use fork, pipe and exec system call) ls -l | wc -l
#include<stdio.h>
#include <unistd.h>
#include <sys/types.h>
#include <stdlib.h>
int main()
{
int pfds[2];
char buf[80];
if(pipe(pfds)==-1)
{
perror("pipe failed");
exit(1);
}
if(!fork())
{
close(1);
dup(pfds[1]);
system("ls -l");
}
else
{
printf("parent reading from pipe \n");
while(read(pfds[0],buf,80))
printf("%s \n" ,buf);
}
}

// OUTPUT-
// [mcs10@cs13 Assignment 1aos]$ gcc Q15.c
// [mcs10@cs13 Assignment 1aos]$ ls -l
// total 160
// -rw-r--r--. 1 mcs10 users 0 Jan 20 15:10 Tanjila.txt
// -rwxr-xr-x. 1 mcs10 users 9005 Jan 27 2025 a.out
// drwxr-xr-x. 2 mcs10 users 23 Jan 20 15:45 ass1
// -rw-r--r--. 1 mcs10 users 31792 Jan 27 2025 ass 1 aos.odt
// -rw-r--r--. 1 mcs10 users 58 Jan 27 2025 file1.txt
// -rw-r--r--. 1 mcs10 users 56 Jan 27 2025 file1.txt~
// -rw-r--r--. 1 mcs10 users 781 Jan 11 15:39 output.txt
// -rw-r--r--. 1 mcs10 users 1692 Jan 27 2025 Q10.c
// -rw-r--r--. 1 mcs10 users 1691 Jan 27 2025 Q10.c~
// -rw-r--r--. 1 mcs10 users 1720 Jan 27 2025 Q11.c
// -rw-r--r--. 1 mcs10 users 1721 Jan 27 2025 Q11.c~
// -rw-r--r--. 1 mcs10 users 878 Jan 27 2025 Q12.c