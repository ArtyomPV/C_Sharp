﻿int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}

int a1 = 1;
int b1 = 12;
int c1 = 3;
int a2 = 24;
int b2 = 95;
int c2 = 36;
int a3 = 57;
int b3 = 88;
int c3 = 49;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1),
              Max(a2, b2, c2),
              Max(a3, b3, c3) );
// int max = a1;

// if(b1>max) max = b1;
// if(c1>max) max = c1;

// if(a2>max) max = a2;
// if(b2>max) max = b2;
// if(c2>max) max = c2;

// if(a3>max) max = a3;
// if(b3>max) max = b3;
// if(c3>max) max = c3;

Console.WriteLine(max);