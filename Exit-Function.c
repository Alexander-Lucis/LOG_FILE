// Q6.Write a C program to demonstrate the use of at exit() function.
#include <stdio.h>
#include <stdlib.h>
void Testfunction1()
{
printf("This is Testfunction1\n");
}void Testfunction2()
{
printf("This is Testfunction2\n");
}
void Testfunction3()
{
printf("This is Testfunction3\n");
}
int main ()
{
int status;
status = atexit(Testfunction1);
status = (status == 0)? atexit(Testfunction2):1;
status = (status == 0)? atexit(Testfunction3):1;
if (status != 0)
{
printf("Registration Failed\n");
exit(1);}
printf("Registration successful\n\n");
return 0;
}

// OUTPUT-
// [mcs10@cs13 Assignment 1aos]$ gcc Q14.c
// [mcs10@cs13 Assignment 1aos]$ ./a.out
// Registration successful
// This is Testfunction3
// This is Testfunction2
// This is Testfunction1