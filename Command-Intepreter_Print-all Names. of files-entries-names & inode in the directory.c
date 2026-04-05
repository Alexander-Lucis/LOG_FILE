// Q3.Write a program that behaves like shell (Command Interpreter). Itshould display the command prompt as . Any shell command shall be executed from your shell by starting child process to execute the program corresponding to the given command. Additionally it should interpret the following commands-
// list f dirname:- To print names of all the files in current directory.
// list n dirname:- To print the number of all entries in the current directory.
// list i dirname :- To print names and inodes of the files in the current directory.
#include<stdio.h>
#include<stdlib.h>
#include<unistd.h>
#include<dirent.h>
char *buff,*t1,*t2,*t3,ch;int pid;
void list(char t2,char *t3)
{
DIR *dir;
struct dirent *entry;
int cnt=0;
dir=opendir(t3);
if (dir==NULL)
{
printf("Directory %s not found",t3);
return;
}
switch(t2)
{
case 'f' : while((entry=readdir(dir))!=NULL)
{
printf("%s\n",entry->d_name);
}
break;
case 'n' : while((entry=readdir(dir))!=NULL)
cnt++;
printf("Total No of Entries: %d\n",cnt);
break;
case 'i' : while((entry=readdir(dir))!=NULL)
{
printf("\n%s\t %d",entry->d_name,entry->d_ino);
}
break;
default : printf("Invalid argument");}
closedir(dir);
}
main()
{
while(1)
{
printf("myshell$");fflush(stdin);
t1=(char *)malloc(80);
t2=(char *)malloc(80);
t3=(char *)malloc(80);
buff=(char *)malloc(80);
fgets(buff,80,stdin);
sscanf(buff,"%s %s %s",t1,t2,t3);
if(strcmp(t1,"pause")==0)
exit(0);
else if(strcmp(t1,"list")==0)
list(t2[0],t3);
else
{
pid=fork();
if(pid<0)
printf("Child process is not created\n");
else if(pid==0)
{
execlp("/bin",NULL);
if(strcmp(t1,"exit")==0)
exit(0);
system(buff);
}
else
{
wait(NULL);
exit(0);
}
}
}
}

// OUTPUT-
// [mcs10@cs13 Assignment 1aos]$ gcc Q9.c
// [mcs10@cs13 Assignment 1aos]$ ./a.out
// myshell$list f ass1
// .
// ..
// file3.txt
// myshell$list n ass1
// Total No of Entries: 3
// myshell$list i ass1
// . 71544634
// .. 204393657
// file3.txt 71544631myshell$