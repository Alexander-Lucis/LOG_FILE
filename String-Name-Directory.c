//Q9.Write a C program to accept string as an argument and return all the files that begins with that name in the current directory. For Example if the file name start with foo so it will return all the file that starts with foo.
#include<stdio.h>
#include <stdlib.h>
#include <dirent.h>
#include <string.h>
int main(int argc, char *argv[]) {
if (argc != 2) {
printf("Usage: %s <string>\n", argv[0]);
return 1;
}
const char *prefix = argv[1];
DIR *dir;
struct dirent *entry;
dir = opendir(".");
if (dir == NULL) {
perror("Unable to open directory");
return 1;
}
printf("Files starting with '%s' in the current directory:\n", prefix);
while ((entry = readdir(dir)) != NULL) {
if (strncmp(entry->d_name, prefix, strlen(prefix)) == 0) {
printf("%s\n", entry->d_name);
}
}
closedir(dir);
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment 1 aos]$ gcc Q23.c
// [mcs10@cs13 Assignment 1 aos]$ ./a.out Q
// Files starting with 'Q' in the current directory:
// Q1.c
// Q8.c~
// Q10.c