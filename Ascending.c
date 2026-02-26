//Q6.Write a C program which receives file names as command line arguments and display those file-names in ascending order according to their sizes.
#include<stdio.h>
#include<dirent.h>
#include<string.h>
#include<sys/stat.h>
#include<time.h>
#include<stdlib.h>
struct filelist
{
char fname[100];
int fsize;
};
int main(int argc,char *argv[])
{
DIR *dp;
int i,j,k;
struct dirent *ep;
struct stat sb;
char mon[100];struct filelist f1[100],temp;
j=0;
for(i=1;i<argc;i++)
{
dp=opendir("./");
if (dp!=NULL)
{
while(ep=readdir(dp))
{
if((strcmp(ep->d_name,argv[i]))==0)
{
stat(ep->d_name,&sb);
strcpy(f1[j].fname,ep->d_name);
f1[j].fsize=sb.st_size;
j++;
break;
}
}
}
(void)closedir(dp);
}
for(i=0;i<j;i++)
{
for(k=0;k<=j;k++)
{
if(f1[i].fsize < f1[k].fsize)
{
temp=f1[k];
f1[k]=f1[i];f1[i]=temp;
}
}
}
for(i=0;i<j;i++)
{
printf("%s\t%d\n",f1[i].fname,f1[i].fsize);
}return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment 1 aos]$ gcc Q12.c
// [mcs10@cs13 Assignment 1 aos]$ ./a.out Q10.c Q5.c Q7.c file1.txt
// file1.txt 58
// Q7.c 1145
// Q5.c 1208
// Q10.c 1692