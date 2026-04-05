// Q4.Write C program that catches ctrl-c signal (SIGINT) for the first time and display appropriate message and exits on pressing ctrl-c again.
#include <stdio.h>
#include <stdlib.h>
#include <signal.h>
#include <unistd.h>
int sigint_count=0;
void sigint_handler(intsig) {
  sigint_count++;
if(sigint_count == 1) {
printf("SIGINT caught! Press Ctrl+C again to exit.\n");
} else {
printf("Exiting program on second Ctrl+C press.\n");
exit(0);
}
}
int main() {
signal(SIGINT,sigint_handler);
while(1) {
sleep(1);
}
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment1 aos]$ gcc Q25.c
// [mcs10@cs13 Assignment1 aos]$ ./a.out
// ^CSIGINT caught! Press Ctrl+C again to exit.