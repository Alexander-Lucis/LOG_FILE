// Q4.Write a program that behaves like shell (Command Interpreter). It should display the command prompt as “MyShell$”. Any shell command shall be executed from your shell by starting child process to execute the program corresponding to the given command. Additionally it should interpret the following commands
// typeline +n filename:- To print first n lines in the file.
// typeline -n filename:- To print last n lines in the file.
// typeline a filename :- To print all line in the file.
#include<stdio.h>
#include<stdlib.h>
#include<unistd.h>
#include<string.h>
char *buff,*t1,*t2,*t3,ch;
FILE *fp;
int pid;
void typeline(char *t2,char *t3)
{
int i,n,count=0,num;
if((fp=fopen(t3,"r"))==NULL)
printf("File not found\n");
if(strcmp(t2,"a")==0)
{
while((ch=fgetc(fp))!=EOF)
printf("%c",ch);
fclose(fp);
return;
}
n=atoi(t2);
if(n>0)
{
i=0;
while((ch=fgetc(fp))!=EOF)
{
if(ch=='\n')
i++;
if(i==n)
break;
printf("%c",ch);
}
printf("\n");
}
else
{
count=0;
while((ch=fgetc(fp))!=EOF)
if(ch=='\n')
count++;
fseek(fp,0,SEEK_SET);
i=0;
while((ch=fgetc(fp))!=EOF)
{
if(ch=='\n')
i++;
if(i==count+n-1)
break;
}
while((ch=fgetc(fp))!=EOF)
printf("%c",ch);
}
fclose(fp);
}
main()
{
while(1)
{
printf("myshell$");
fflush(stdin);
t1=(char *)malloc(80);
t2=(char *)malloc(80);
t3=(char *)malloc(80);
buff=(char *)malloc(80);
fgets(buff,80,stdin);
sscanf(buff,"%s %s %s",t1,t2,t3);
if(strcmp(t1,"pause")==0)
exit(0);
else if(strcmp(t1,"typeline")==0)
typeline(t2,t3);
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
// [mcs10@cs13 Assignment 1aos]$ gcc Q10.c
// [mcs10@cs13 Assignment 1aos]$ ./a.out
// myshell$typeline +3 file1.txt
// hello
// Tanjila
// Namira
// myshell$typeline -2 file1.txt
// Tanjila
// Namira
// Onkar
// myshell$typeline a file1.txt
// hello
// Tanjila
// Namira
// Onkar