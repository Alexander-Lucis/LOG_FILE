//Q3.Write a C program to generate parent process to write unnamed pipe and will read from it.
#include <stdio.h>
#include <unistd.h>
#include <string.h>
int main() {
int pipefd[2];
pid_t pid;
char write_msg[] = "Hello from EXCALIBUR!";
char read_msg[100];
if (pipe(pipefd) == -1) {
perror("Pipe failed");
return 1;
}
pid = fork();
if (pid < 0) {
perror("Fork failed");
return 1;}
if (pid > 0) {
close(pipefd[0]);
write(pipefd[1], write_msg, strlen(write_msg) + 1);
close(pipefd[1]);
printf("Parent: Message sent to pipe\n");
}
else {
close(pipefd[1]);
read(pipefd[0], read_msg, sizeof(read_msg));
close(pipefd[0]);
printf("Child: Received message: %s\n", read_msg);
}
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment1 aos]$ gcc Q18.c
// [mcs10@cs13 Assignment1 aos]$ ./a.out Q18.c
// Parent: Message sent to pipe
// Child: Received message: Hello from TANJILA!