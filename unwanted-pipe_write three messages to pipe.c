// Q1-Write a C program to create an unwanted pipe.The child process will write the following three messages to pipe and the parent process will display it.
// Messages1="Hello Mcs"
// Message2="How ae you all"
// Message3="Hope you all are fine” .
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <string.h>
#include <sys/types.h>
int main() {
int pipefd[2];
pid_t pid;
char buffer[100];
if (pipe(pipefd) == -1) {
perror("Pipe failed");
return 1;
}
pid = fork();
if (pid < 0) {
perror("Fork failed");
return 1;
}
if (pid == 0) {
close(pipefd[0]);
write(pipefd[1], "Hello MCS\n", strlen("Hello MCS") + 1);
write(pipefd[1], "How are you all\n", strlen("How are you all") + 1);
write(pipefd[1], "Hope you all are Fine\n", strlen("Hope you all are Fine") + 1);
close(pipefd[1]);
exit(EXIT_SUCCESS);
}
else {
close(pipefd[1]);
while (read(pipefd[0], buffer, sizeof(buffer)) > 0) {
printf("Parent received: %s\n", buffer);
}
close(pipefd[0]);
}
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment1 aos]$ gcc Q27.c
// [mcs10@cs13 Assignment1 aos]$ ./a.out
// Hello MCS
// How are you all
// Hope you all are Fine