#include <iostream>
#include <vector>

using namespace std;

int n; 
int counter = 0;
vector<int> conf;
vector<bool> rows;
vector<bool> diag1;
vector<bool> diag2;


void printCurrentConf()
{
	for(auto elem: conf)
	{
		cout << elem << ' ';
	}
	cout << endl;
}
void putQueen(int row, int col)
{
	rows[row] = true;
	diag1[row - col + n - 1] = true;
	diag2[row + col] = true;
	conf[col] = row;
}
void takeQueen(int row, int col)
{
	rows[row] = false;
	diag1[row - col + n - 1] = false;
	diag2[row + col] = false;
}
bool checkQueen(int row, int col)
{
	return not rows[row] and 
	       not diag1[row - col + n - 1] and 
		   not diag2[row + col];
}
void solve(int col)
{
	if(col == n)
	{
		printCurrentConf();
		++counter;
	}
	else
	{
		for(int row = 0; row != n; ++row)
		{
			if(checkQueen(row, col))
			{
				putQueen(row, col);
				solve(col + 1);
				takeQueen(row, col);
			}
		}
	}
	
}


int main()
{
	cin >> n;
	conf.resize(n);
	rows.resize(n, false);
	diag1.resize(2 * n - 1, false);
	diag2.resize(2 * n - 1, false);
	solve(0);
	
	cout << counter << endl;
	
	return 0;
}