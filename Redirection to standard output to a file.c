// Q8.Write a C program that demonstrates redirection of standard output to a file.
#include<stdio.h>
int main(){FILE *file=freopen("output.txt","w",stdout);
if(file == NULL){
perror("error opening a file ");
return 1;
}
printf("This is a test message that will be written to the file.\n");
printf("The standard output has been redirected to 'output.txt'.\n");
fclose(file);
return 0;
}

// OUTPUT-
// This is a test message that will be written to the file.
// The standard output has been redirected to 'output.txt'.