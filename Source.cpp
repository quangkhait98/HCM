#include<iostream>
#include <fstream>

using namespace std;
struct Car
{
	char name[100];
	char color[100];
	float speed;
};


#define ElementType Car
//Kiểu số nguyên
int Compare(int a, int b)
{
	if (a < b)
		return 1;
	return 0;
}
int Compare(Car a, Car b)
{
	if (a.speed < b.speed)
		return 1;
	return 0;
}


void SelectionSort(ElementType A[], int n)
{
	int minPos;
	for (int i = 0; i < n - 1; i++)
	{
		minPos = i;
		for (int j = i + 1; j < n; j++)
		{
			if (Compare(A[j], A[minPos]))
			{
				minPos = j;
			}
		}
		if (minPos != i)
		{
			ElementType temp = A[i];
			A[i] = A[minPos];
			A[minPos] = temp;
		}
	}
}

void InsertionSort1(ElementType A[], int n)
{
	for (int i = 1; i < n; i++)
	{
		ElementType x = A[i];
		int j = i - 1;
		while (j >= 0 && Compare(x, A[j]))
		{
			A[j + 1] = A[j];
			j--;
		}
		A[j + 1] = x;
	}
}

int BinarySearch(ElementType A[], ElementType x, int left, int right)
{
	if (left >= right)
		if (Compare(A[left], x)) return left + 1;
		else return left;

		int mid = (left + right) / 2;

		if (!Compare(x, A[mid]) && !Compare(A[mid], x))
			return mid + 1;

		if (Compare(A[mid], x))
			return BinarySearch(A, x, mid + 1, right);
		return BinarySearch(A, x, left, mid - 1);
}

void InsertionSort2(ElementType A[], int n)
{
	for (int i = 1; i < n; i++)
	{
		ElementType x = A[i];
		int j = i - 1;
		int Pos = BinarySearch(A, x, 0, j);
		while (j >= Pos)
		{
			A[j + 1] = A[j];
			j--;
		}
		A[j + 1] = x;
	}
}

void BubbleSort(ElementType A[], int n)
{
	for (int i = 0; i < n - 1; i++)
		for (int j = n - 1; j > i; j--)
			if (Compare(A[j], A[j - 1]))
			{
				ElementType temp = A[j];
				A[j] = A[j - 1];
				A[j - 1] = temp;
			}
}

void ShakerSort(ElementType A[], int n)
{
	int Left = 0;
	int Right = n - 1;
	int k = 0;
	while (Left < Right)
	{
		for (int i = Left; i < Right; i++)
		{
			if (Compare(A[i + 1], A[i]))
			{
				ElementType temp = A[i];
				A[i] = A[i + 1];
				A[i + 1] = temp;
				k = i;
			}
		}
		Right = k;
		for (int i = Right; i > Left; i--)
		{
			if (Compare(A[i], A[i - 1]))
			{
				ElementType temp = A[i];
				A[i] = A[i - 1];
				A[i - 1] = temp;
				k = i;
			}
		}
		Left = k;
	}
}

void QuickSort1(ElementType A[], int left, int right)
{
	int i = left, j = right;
	ElementType pivot = A[(left + right) / 2];
	while (i <= j)
	{
		while (Compare(A[i], pivot)) i++;
		while (Compare(pivot, A[j])) j--;
		if (i <= j)
		{
			ElementType temp = A[i];
			A[i] = A[j];
			A[j] = temp;
			i++;
			j--;
		}
	};
	if (left < j) QuickSort1(A, left, j);
	if (i < right) QuickSort1(A, i, right);
}

void QuickSort2(ElementType A[], int left, int right)
{
	int i = left, j = right;
	ElementType pivot = A[left];
	while (i <= j)
	{
		while (Compare(A[i], pivot)) i++;
		while (Compare(pivot, A[j])) j--;
		if (i <= j)
		{
			ElementType temp = A[i];
			A[i] = A[j];
			A[j] = temp;
			i++;
			j--;
		}
	};
	if (left < j) QuickSort1(A, left, j);
	if (i < right) QuickSort1(A, i, right);
}

void ShowCar(Car a)
{
	cout << "Name:" << a.name << ", " << "Color:" << a.color << ",  " << "Speed:" << a.speed << "km/h";
}

void ShowCarList(Car carList[], int n)
{
	for (int i = 0; i < n; i++)
	{
		cout << "Car number " << i+1 << ": ";
		ShowCar(carList[i]);
		cout << endl;
	}
}

void main()
{
	/*int A[100], n;
	fstream f;
	f.open("Input1.txt", ios::in);
	f >> n;
	for (int i = 0; i < n; i++)
		f >> A[i];
	f.close();
	InsertionSort2(A, n);
	for (int i = 0; i < n; i++)
		cout << A[i] << ", ";
*/
	Car car[100];
	int n;
	fstream f;
	f.open("Input2.txt", ios::in);
	f >> n;
	for (int i = 0; i < n; i++)
	{
		f >> car[i].name;
		f >> car[i].color;
		f >> car[i].speed;
	}
	f.close();
	InsertionSort2(car, n);
	ShowCarList(car, n);
	system("pause");
}


