int A = 10;
for(int i = 1; i<= A; i++)
{
    if(i % 2 == 0)
   Console.WriteLine(i);
}

int B = 3;
if(B % 2 ==0 )
Console.WriteLine("ДА");
else 
{
    Console.WriteLine("Нет");
}


int a5 = 5;
int a2 = 2;
int a9 = 9; 
int b7 = 7;
int b10 = 10;
int b3 = 3;

int max = a5;
if(a2> max ) max = a2;
if(a9 > max ) max = a9;
if(b7 > max ) max = b7;
if(b10 > max)  max = b10;
if(b3 > max ) max = b3;

Console.WriteLine(max);