# include <iostream>
using namespace std;
int main ()
{
	int matriz[2][4],i=0,j=0;

	cout <<"INTRODUCIR VALORES EN MATRIZ: " <<endl;

	for (i=0; i<2; i++)
	{
		for(j=0;j<4;j++)
		{
			cin>>matriz[i][j] ;
			cout<<endl;
		}
	}
	
	for (i=0; i<2; i++)
	{
		for(j=0;j<4;j++)
		{
			cout << matriz[i][j] << ", ";			
		}
		cout <<endl;
	}
}
