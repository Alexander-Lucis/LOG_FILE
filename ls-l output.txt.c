//Q1.Write a C program to implement the following unix/linux command i.ls-l> output.txt.
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/wait.h>
#include <fcntl.h>
int main()
{
    pid_t pid;
    int fd;

    pid = fork();

    if (pid < 0)
    {
        perror("Fork failed");
        exit(1);
    }
    else if (pid == 0)
    {
        fd = open("output.txt", O_WRONLY | O_CREAT | O_TRUNC, 0644);
        if (fd < 0)
        {
            perror("File open failed");
            exit(1);
        }
        dup2(fd, STDOUT_FILENO);
        close(fd);
        execlp("ls", "ls", "-l", NULL);
        perror("Exec failed");
        exit(1);
    }
    else
    {
        wait(NULL);
        printf("Command executed successfully. Output stored in output.txt\n");
    }

    return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment 1aos]$ gcc Q6.c
// [mcs10@cs13 Assignment 1aos]$ ./a.out
// total 160
// -rw-r--r--. 1 mcs10 users 1145 Jan 20 14:28 Q7.c~
// -rw-r--r--. 1 mcs10 users 1600 Jan 20 15:33 Q8.c
// -rw-r--r--. 1 mcs10 users 1600 Jan 20 15:31 Q8.c~
// -rw-r--r--. 1 mcs10 users 1646 Jan 20 15:58 Q9.c
// -rw-r--r--. 1 mcs10 users 1106 Jan 20 15:41 Q9.c~
// child complete