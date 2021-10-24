#include <stdio.h>
#include <stdlib.h>
#include <malloc.h>

int main()
{
int n, a;
int sum=0;
int *m;
float avg;
printf("Введите кол-во оценок: ");
scanf("%d", &n);

m = (int*) malloc(n*sizeof(int));
printf("Если вы хотите ввести оценки самостоятельно напишите  1,если нет напишите любой другой символ\n");
scanf("%d",&a);
if(a==1)
{
for (int j=0;j<n;j++)
{
printf("m[%d] = ",j);
scanf("%d",&m[j]);
sum += m[j];
}
avg = (float)sum / (float)n;
printf("avg = %.2f \n", avg);
if (avg < 4.6)
printf("Среднего бала недостаточно для зачисления \n");
else
printf("Среднего бала достаточно для зачисления \n");

free (m);
return 0;
}
else
{
 for (int j=0;j<n;j++)
{
m[j]=rand()%5+2;
printf("m[%d] = ",j);
printf("%d\n",m[j]);
sum += m[j];
}
avg = (float)sum / (float)n;
printf("avg = %.2f \n", avg);
if (avg < 4.6)
printf("Среднего бала недостаточно для зачисления \n");
else
printf("Среднего бала достаточно для зачисления \n");

free (m);
return 0;  
}
}