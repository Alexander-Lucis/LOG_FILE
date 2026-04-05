//Q10.Write a C program to find file properties such as inode number,number of hard links,file permissions,file size,file access and modification time and so on of a given file using stat() system call.
#include<stdio.h>
#include<sys/stat.h>
#include<time.h>
int main(){
struct stat fileStat;
char fileName[]="yourfile.txt";
if(stat(fileName,&fileStat)== -1){
perror("stat");
return 1;
}printf("File:%S\n",fileName);
printf("Inode number:%ld\n",fileStat.st_ino);
printf("Number of Hard Links:%ld\n",fileStat.st_nlink);
printf("File Permissions:");
printf((S_ISDIR(fileStat.st_mode)) ? "d" :"-");
printf((fileStat.st_mode & S_IRUSR) ? "r" : "-");
printf((fileStat.st_mode & S_IWUSR) ? "w" : "-");
printf((fileStat.st_mode & S_IXUSR) ? "x" : "-");
printf((fileStat.st_mode & S_IRGRP) ? "r" : "-");
printf((fileStat.st_mode & S_IWUSR) ? "w" : "-");
printf((fileStat.st_mode & S_IXGRP) ? "x" : "-");
printf((fileStat.st_mode & S_IROTH) ? "r" : "-");
printf((fileStat.st_mode & S_IWOTH) ? "w" : "-");
printf((fileStat.st_mode & S_IXOTH) ? "x" : "-");
printf("\n");
printf("File size:%ld bytes\n",fileStat.st_size);
printf("Last Access Time:%s", ctime(&fileStat.st_atime));
printf("Last Modification Time:%s", ctime(&fileStat.st_mtime));
printf("Last Status Change Time:%s", ctime(&fileStat.st_ctime));
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment 1 aos]$ gcc Q26.c
// [mcs10@cs13 Assignment 1 aos]$ ./a.out yourfile.txt
// File:Inode number:210205331
// Number of Hard Links:1
// File Permissions:-rw-rw-r--
// File size:0 bytes
// Last Access Time:Mon Feb 17 14:50:21 2025
// Last Modification Time:Mon Feb 17 14:50:21 2025
// Last Status Change Time:Mon Feb 17 14:50:21 2025