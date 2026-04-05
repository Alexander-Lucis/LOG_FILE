// Q2.Write a C program to create n child processes. When all n child processes terminates, Display total cumulative time children spent in user and kernel mode.
#include <stdio.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/wait.h>
#include <sys/resource.h>
#include <unistd.h>
int main() {
int n,i,j;
printf("Enter the number of child processes: ");
scanf("%d", &n);
pid_t pid;
struct rusage usage;
struct rusage total_usage = {0};
for (i = 0; i < n; i++) {
pid = fork();
if (pid == 0) {
printf("Child process %d started.\n", i + 1);
for (j = 0; j < 10000000; j++);
printf("Child process %d finished.\n", i + 1);
exit(0);
}
else if (pid < 0) {
perror("Fork failed");
return 1;
}
}
for (i = 0; i < n; i++) {
wait(NULL);
if (getrusage(RUSAGE_CHILDREN, &usage) == 0) {
total_usage.ru_utime.tv_sec += usage.ru_utime.tv_sec;
total_usage.ru_utime.tv_usec += usage.ru_utime.tv_usec;
total_usage.ru_stime.tv_sec += usage.ru_stime.tv_sec;
total_usage.ru_stime.tv_usec += usage.ru_stime.tv_usec;
}
}
printf("\nTotal cumulative time spent by children processes:\n");
printf("User time: %ld.%06ld seconds\n", total_usage.ru_utime.tv_sec,
total_usage.ru_utime.tv_usec);
printf("Kernel time: %ld.%06ld seconds\n", total_usage.ru_stime.tv_sec,
total_usage.ru_stime.tv_usec);
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment1 aos]$ gcc Q28.c
// [mcs10@cs13 Assignment1 aos]$ ./a.out
// Enter the number of child processes: 3
// Child process 1 started.
// Child process 2 started.
// Child process 3 started.
// Child process 2 finished.
// Child process 1 finished.
// Child process 3 finished.
// Total cumulative time spent by children processes:
// User time: 0.361189 seconds
// Kernel time: 0.000000 seconds