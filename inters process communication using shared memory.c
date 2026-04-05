// Q3.Write a C program to generate parent process to write unnamed pipe and will write into it. Also generate child process which will read from pipe.
#include <stdio.h>
#include <unistd.h>
#include <string.h>
#include <sys/types.h>
#include <sys/wait.h>
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
if (pid > 0) {
close(pipefd[0]);
const char *message = "Hello from Parent!";
write(pipefd[1], message, strlen(message) + 1);
close(pipefd[1]);
wait(NULL);
}
else {
close(pipefd[1]);read(pipefd[0], buffer, sizeof(buffer));
printf("Child received: %s\n", buffer);
close(pipefd[0]);
}
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment1 aos]$ gcc Q30.c
// [mcs10@cs13 Assignment1 aos]$ ./a.out
// Child writing to shared memory...
// Child wrote: Hello from child process!
// Parent reading from shared memory...
// Parent read: Hello from child process!