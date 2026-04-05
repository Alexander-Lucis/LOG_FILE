// Q3.Write a C program which creates a child process to run linux/ unix command or any user defined program. The parent process set the signal handler for death of child signal and Alarm signal. If a child process does not complete its execution in 5 second then parent process kills child process.
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <signal.h>
#include <sys/types.h>
#include <sys/wait.h>
pid_t child_pid = -1;
void handle_alarm(int sig) {
printf("Alarm signal received. Killing the child process...\n");
if (child_pid != -1) {
kill(child_pid, SIGKILL);
}
}
void handle_child_death(int sig) {
int status;
waitpid(child_pid, &status, 0);
printf("Child process terminated.\n");
}
int main() {
struct sigaction sa_alarm, sa_child;
sa_alarm.sa_handler = handle_alarm;
sigemptyset(&sa_alarm.sa_mask);
sa_alarm.sa_flags = 0;
sigaction(SIGALRM, &sa_alarm, NULL);
sa_child.sa_handler = handle_child_death;
sigemptyset(&sa_child.sa_mask);
sa_child.sa_flags = 0;sigaction(SIGCHLD, &sa_child, NULL);
child_pid = fork();
if (child_pid == 0) {
printf("Child process running...\n");
execlp("sleep", "sleep", "10", NULL);
perror("execlp failed");
exit(1);
} else if (child_pid > 0) {
printf("Parent process waiting for child...\n");
alarm(5);
pause();
} else {
perror("fork failed");
exit(1);
}
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment1 aos]$ gcc Q24.c
// [mcs10@cs13 Assignment1 aos]$ ./a.out
// Parent process waiting for child...
// Child process running...
// Alarm signal received. Killing the child process...
// [mcs10@cs13 Assignment1 aos]$