﻿int a = 1;
int b = 2;
int c = 33;
int d = 4;
int e = 5;

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine($"max={max}");