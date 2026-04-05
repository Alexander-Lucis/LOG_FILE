// Q2.Write a program that behaves like shell (Command Interpreter).It should display the command prompt as .Any shell command shall beexecuted from your shell by starting child process to execute theprogram corresponding to the given command. Additionally it shouldinterpret the following commands
// count -c filename:- To print number of characters in the file.
// count -w filename:- To print the number of words in file.
// count -l filename :- To print number of lines in file.
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/wait.h>

void count(char *option, char *filename)
{
    FILE *fp;
    char ch;
    int charcount = 0, wordcount = 0, linecount = 0;
    int inword = 0;

    fp = fopen(filename, "r");
    if (fp == NULL)
    {
        printf("File not found\n");
        return;
    }

    while ((ch = fgetc(fp)) != EOF)
    {
        charcount++;

        if (ch == '\n')
            linecount++;

        if (ch == ' ' || ch == '\n' || ch == '\t')
        {
            inword = 0;
        }
        else if (inword == 0)
        {
            inword = 1;
            wordcount++;
        }
    }

    fclose(fp);

    if (strcmp(option, "-c") == 0)
        printf("Total number of characters: %d\n", charcount);
    else if (strcmp(option, "-w") == 0)
        printf("Total number of words: %d\n", wordcount);
    else if (strcmp(option, "-l") == 0)
        printf("Total number of lines: %d\n", linecount);
    else
        printf("Invalid count option\n");
}

int main()
{
    char command[100];
    char cmd[20], opt[20], arg[50];
    pid_t pid;

    while (1)
    {
        printf("myshell$ ");
        fflush(stdout);

        if (fgets(command, sizeof(command), stdin) == NULL)
            break;

        command[strcspn(command, "\n")] = '\0';

        if (strlen(command) == 0)
            continue;

        sscanf(command, "%s %s %s", cmd, opt, arg);

        if (strcmp(cmd, "exit") == 0)
        {
            printf("Exiting myshell...\n");
            break;
        }
        else if (strcmp(cmd, "count") == 0)
        {
            count(opt, arg);
        }
        else
        {
            pid = fork();

            if (pid < 0)
            {
                printf("Child process not created\n");
            }
            else if (pid == 0)
            {
                execlp("/bin/sh", "sh", "-c", command, NULL);
                perror("Execution failed");
                exit(1);
            }
            else
            {
                wait(NULL);
            }
        }
    }
    return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment 1 aos]$ gcc Q8.c
// [mcs10@cs13 Assignment 1 aos]$ ./a.out
// myshell$count c file1.txt
// the total no. of characters:7
// myshell$count w file1.txt
// the total no. of words:1
// myshell$count l file1.txt
// the total no. of lines:1