﻿int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a1 = 10;
int b1 = 14;
int c1 = 17;
int a2 = 44;
int b2 = 32;
int c2 = 2233;
int a3 = 12345;
int b3 = 18;
int c3 = 303;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3) );

Console.WriteLine(max);