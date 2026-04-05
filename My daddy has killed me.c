// Q1-Write a C program which creates a child process which catch a signal sighup,sigint and sigquit. The parent process sends a sighup or sigint after 3 seconds,at the end of 30 second parent send sigquit signal to child and child terminates by displaying message “My daddy has killed me!”
#include<stdio.h>
#include<signal.h>
#include<stdlib.h>
#include<unistd.h>
void sighup();
void sigint();
void sigquit();
int main()
{
int pid,i,j;
if((pid=fork())<0)
{
perror("fork");
exit(1);
}
if(pid==0)
{
signal(SIGHUP,sighup);
signal(SIGINT,sigint);
signal(SIGQUIT,sigquit);
for(;;);
}
else
{
j=0;
for(i=1;i<=5;i++)
{
j++;printf("parent:sending SIGHUP signal:%d\n",j);
kill(pid,SIGHUP);
sleep(3);
printf("parent:sending SIGHUP signal:%d\n",j);
kill(pid,SIGHUP);
sleep(3);
printf("parent:sending SIGINT signal:%d\n",j);
kill(pid,SIGINT);
sleep(3);
}
sleep(3);
printf("parent sending SIGQUIT\n");
kill(pid,SIGQUIT);
}
return 0;
}
void sighup()
{
printf("child:I have received SIGHUP\n");
}
void sigint()
{
printf("child:I have received SIGINT\n");
}
void sigquit()
{
printf("MY DADDY HAS KILLED ME");
exit(0);
}

// OUTPUT-
// [mcs10@cs13 Assignment1 aos]$ gcc Q13.c
// [mcs10@cs13 Assignment1 aos]$ ./a.out
// parent:sending SIGHUP signal:1
// parent:sending SIGHUP signal:1
// parent:sending SIGINT signal:1
// parent:sending SIGHUP signal:2
// parent:sending SIGHUP signal:2
// parent:sending SIGINT signal:2
// parent:sending SIGHUP signal:3
// parent:sending SIGHUP signal:3
// parent:sending SIGINT signal:3
// parent:sending SIGHUP signal:4
// parent:sending SIGHUP signal:4
// parent:sending SIGINT signal:4
// parent:sending SIGHUP signal:5
// parent:sending SIGHUP signal:5
// parent:sending SIGINT signal:5
// parent sending SIGQUIT
// [mcs10@cs13 Assignment1 aos]$ ./a.out
// parent:sending SIGHUP signal:1
// child:I have received SIGHUP
// parent:sending SIGHUP signal:1
// child:I have received SIGHUP
// parent:sending SIGINT signal:1
// child:I have received SIGINT
// parent:sending SIGHUP signal:2
// child:I have received SIGHUP
// parent:sending SIGHUP signal:2
// child:I have received SIGHUP
// parent:sending SIGINT signal:2
// child:I have received SIGINT
// parent:sending SIGHUP signal:3
// child:I have received SIGHUP
// parent:sending SIGHUP signal:3
// child:I have received SIGHUP
// parent:sending SIGINT signal:3
// child:I have received SIGINT
// parent:sending SIGHUP signal:4
// child:I have received SIGHUP
// parent:sending SIGHUP signal:4
// child:I have received SIGHUP
// parent:sending SIGINT signal:4
// child:I have received SIGINT
// parent:sending SIGHUP signal:5
// child:I have received SIGHUP
// parent:sending SIGHUP signal:5
// child:I have received SIGHUP
// parent:sending SIGINT signal:5
// child:I have received SIGINT
// parent sending SIGQUIT
// MY DADDY HAS KILLED ME