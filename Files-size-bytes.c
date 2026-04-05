//Q7.Write a C program to display all the files from current directory whose size is greater that n Bytes where n is accept from user.
#include <stdio.h>
#include <stdlib.h>
#include <dirent.h>
#include <sys/stat.h>
#include <string.h>
int main() {
DIR *dir;
struct dirent *entry;
struct stat file_stat;
char *dir_name = ".";
long n;
printf("Enter the size limit in bytes: ");
scanf("%ld", &n);
dir = opendir(dir_name);
if (dir == NULL) {
perror("Unable to open directory");
return 1;
}
printf("Files greater than %ld bytes in the current directory:\n", n);
while ((entry = readdir(dir)) != NULL) {
if (entry->d_type == DT_REG) {
if (stat(entry->d_name, &file_stat) == 0) {if (file_stat.st_size > n) {
printf("%s (Size: %ld bytes)\n", entry->d_name, file_stat.st_size);
}
}
}
}
closedir(dir);
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment 1 aos]$ gcc Q17.c
// [mcs10@cs13 Assignment 1 aos]$ ./a.out Q17.c
// Enter the size limit in bytes: 600
// Files greater than 600 bytes in the current directory:
// ass 1 aos.odt (Size: 30887 bytes)
// Q8.c~ (Size: 1600 bytes)
// Q10.c (Size: 1692 bytes)