#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct record
{
	int acc;
	char fio[32];
	float sum;
	int prc;

	float res;
};

#define rows 3
struct record tab[rows];

int main()
{
char tmp[32];
for(int i = 0; i < rows; i++)
{
	printf("[record %d]\n", i);

	printf("acc: ");
	gets(tmp);
	tab[i].acc = atoi(tmp);

	printf("fio: ");
	gets(tab[i].fio);

	printf("sum: ");
	gets(tmp);
	tab[i].sum = atof(tmp);

	printf("%%: ");
	gets(tmp);
	tab[i].prc = atoi(tmp);

	printf("\n");
}
for(int i = 0; i < rows; i++)
{
    tab[i].res = tab[i].sum + (tab[i].sum * tab[i].prc / 100.0f) / 12.0f;
}
	for(int i = 0; i < rows; i++)
	{
		printf("%d\t%s\t%.2f\t%d\t%.2f\n", tab[i].acc, tab[i].fio, tab[i].sum, tab[i].prc, tab[i].res);
	}
int menu = 0;
printf("1.Поиск по номеру счёта\n 2.Поиск по ФИО \n" );
scanf("%d",&menu );
gets (tmp); 
if (menu == 1)
{int search = atoi(tmp);
  int signal = 0;
  for(int q = 0; q < rows;q++)
  {
    if(tab[q].acc == search)
    {
      signal++;
      printf("%d\t%s\t%.2f\t%d\t%.2f\n", tab[q].acc, tab[q].fio, tab[q].sum, tab[q].prc, tab[q].res );
    }
  }
  if(signal == 0)
  {
    printf("not found\n");
  }
}
if (menu == 2)
{
  char search[32] ;
  for(int w = 0; w < 32; w++)
  {
    search[w]=tmp[w];
  }
    int signal = 0;
    for(int q = 0; q < rows;q++)
    {
      if(tab[q].fio == search)//ПАЛИ СЮДА
      {
        signal++;
        printf("%d\t%s\t%.2f\t%d\t%.2f\n", tab[q].acc, tab[q].fio, tab[q].sum, tab[q].prc, tab[q].res );
      }
    }
    if(signal == 0)
    {
      printf("not found\n");
    }
}
return 0;
}