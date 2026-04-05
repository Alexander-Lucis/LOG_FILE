// Q2.Write a C program that illustrates suspending and resuming processes using signals.
#include <stdio.h>
#include <unistd.h>
#include <signal.h>
#include <stdlib.h>
int main() {
pid_t pid;
pid = fork();
if (pid < 0) {
perror("Fork failed");
return 1;
}
if (pid == 0) {
printf("Child process running. PID: %d\n", getpid());
while (1) {
printf("Child process is working...\n");
sleep(2);
}
} else {
printf("Parent process. Child PID: %d\n", pid);sleep(5);
printf("Parent suspending the child process...\n");
kill(pid, SIGSTOP);
sleep(5);
printf("Parent resuming the child process...\n");
kill(pid, SIGCONT);
sleep(10);
kill(pid, SIGKILL);
}
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment1 aos]$ gcc Q22.c
// [mcs10@cs13 Assignment1 aos]$ ./a.out
// Parent process. Child PID: 12231
// Child process running. PID: 12231
// Child process is working...
// Child process is working...
// Child process is working...
// Parent suspending the child process...
// Parent resuming the child process...
// Child process is working...
// Child process is working...
// Child process is working...
// Child process is working...
// Child process is working...