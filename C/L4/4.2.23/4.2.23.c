#include<conio.h>
#include<malloc.h>
#include<windows.h>
#include<stdio.h>
#define n 160
int nestrlen(char *text)
{
	int i;
	for(i=0;;i++)
	{
		if(text[i]=='\0') return i;
	}
}
int num(char *str,int i)
{
	int j;
	char numbers[11]="0123456789";
	for(j=0;j<10;j++)
	{
		if(str[i]==numbers[j])return 1;
	}
	return 0;
}
void task(char *str,int *sum,int *wordcount)
{
	int len,i,j;

	for(i=0,len=nestrlen(str);i<len;i++)
	{
		if(num(str,i)==1)*sum+=str[i]-'0';
		if(num(str,i)==0 && str[i]!=' ')
		{
		   *wordcount=*wordcount+1;
		   for(;i<len;i++)
		   {
			   if(str[i]==' ')break;
           }
		}
	}
}
int main(void)
{
	char str[n];
	int sum=0,wordcount=0;
	FILE *fp;
	fp=fopen("text.txt","r");
	if(!fp)exit(1);
	fgets(str,n,fp);
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	task(str,&sum,&wordcount);
	printf("%s\n",str);
	printf("sum=%d\t",sum);
	printf("wordcount=%d\n",wordcount);
	if(sum==wordcount)printf("Верно");
	else printf("Неверно");
	getch();
	fclose(fp);
	return 0;
}
//---------------------------------------------------------------------------
