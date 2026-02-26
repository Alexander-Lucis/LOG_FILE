//Q2.Write a C program to print the exit status of a terminated child process.
#include <stdio.h>
#include <stdlib.h>
#include <sys/wait.h>
#include <unistd.h>
int main() {
pid_t pid;
int status;
pid = fork();
if (pid < 0) {
perror("Fork failed");
return 1;
}
if (pid == 0) {
printf("Child process (PID: %d) is terminating...\n", getpid());
exit(42);} else {
wait(&status);
if (WIFEXITED(status)) {
printf("Child process exited with status: %d\n", WEXITSTATUS(status));
} else {
printf("Child process did not terminate normally.\n");
}
}
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment1 aos]$ gcc Q16.c
// [mcs10@cs13 Assignment1 aos]$ ./a.out
// Child process (PID: 8385) is terminating...
// Child process exited with status: 42