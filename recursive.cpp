#include <iostream>
#include <vector>
#include <Stack>

using namespace std;

int n; 
int counter = 0;
vector<int> conf;
vector<int> rows;
vector<int> diag1;
vector<int> diag2;


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

struct Pair
{
	int row;
	int col;
	Pair(int aRow, int aCol)
	: row(aRow), col(aCol)
	{
	}
};

int main()
{
	cin >> n;
	
	conf.resize(n);
	rows.resize(n, false);
	diag1.resize(2 * n - 1, false);
	diag2.resize(2 * n - 1, false);
	
	stack<Pair> stk;
	
	stk.push(Pair(-1, 0));
	for(;;)
	{
		++stk.top().row;
		int row = stk.top().row;
		int col = stk.top().col;
		
		if(col == 0 and row == n)
		{
			break;
		}
		
		if(col == n)
		{
			printCurrentConf();
			++counter;
			stk.pop();
			takeQueen(stk.top().row, stk.top().col);
		}
		else if(row == n)
		{
			stk.pop();
			takeQueen(stk.top().row, stk.top().col);
		}
		else
		{
			if(checkQueen(row, col))
			{
				putQueen(row, col);
				stk.push(Pair(-1, col + 1));
			}
		}
	}
	
	cout << counter << endl;
	
	return 0;
}