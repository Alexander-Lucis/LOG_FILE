//Q1.Write a C program to handle 2 way communication between parent and child using pipe.
#include<stdio.h>
#include<unistd.h>
int main(){
int pipefds1[2],pipefds2[2];
int returnstatus1,returnstatus2;
int pid;
char pipe1writemessage[20]="WELCOME";
char pipe2writemessage[20]="EXCALIBUR";
char readmessage[20];
returnstatus1=pipe(pipefds1);
if(returnstatus1 == -1){
printf("unable to create pipe1\n");
return 1;
}
returnstatus2=pipe(pipefds2);
if(returnstatus2 == -1){
printf("unable to create pipe2\n");
return 1;
}
pid=fork();
if(pid !=0)
{
close(pipefds1[0]);
close(pipefds2[1]);
printf("in Parent:Writing to pipe 1 - Message is %s\n",pipe1writemessage);
write(pipefds1[1],pipe1writemessage,sizeof (pipe1writemessage));
read(pipefds2[0],readmessage,sizeof (readmessage));
printf("in Parent:Reading from pipe2- Message is %s\n",readmessage);
}
else
{close(pipefds1[1]);
close(pipefds2[0]);
read(pipefds1[0], readmessage,sizeof (readmessage));
printf("in Child:Reading from pipe2- Message is %s\n",pipe2writemessage);
printf("in Child:Reading from pipe1- Message is %s\n",readmessage);
write(pipefds2[1],pipe2writemessage,sizeof(pipe2writemessage));
}
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment1 aos]$ ./a.out
// in Parent:Writing to pipe 1 - Message is Hi
// in Child:Reading from pipe1- Message is Hi
// in Child:Reading from pipe2- Message is Tanjila
// in Parent:Reading from pipe2- Message is Tanjila