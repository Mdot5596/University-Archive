/*
------------------DR VASILIOS KELEFOURAS-----------------------------------------------------
------------------COMP1001 ------------------------------------------------------------------
------------------COMPUTER SYSTEMS MODULE-------------------------------------------------
------------------UNIVERSITY OF PLYMOUTH, SCHOOL OF ENGINEERING, COMPUTING AND MATHEMATICS---
*/

/*
if you are running this on Visual Studio, no action is needed.
if you are running this on Linux, comment lines #15 and #48
*/

#include <stdio.h> //this library is needed for printf function
#include <stdlib.h> //this library is needed for rand() function
#include <time.h> //this library is needed for clock() function
#include <math.h> //this library is needed for abs()


void init();
void q1();
void memoryalloc();

#define N 1200 //input size
float *Y, *X, *A, *test;

#define TIMES_TO_RUN 27 //how many times the function will run. If the ex.time you get is lower than 2 seconds, then increase this value accordingly


int main() {

	memoryalloc(); 

	//define the timers measuring execution time
	clock_t start_1, end_1; //ignore this for  now

	init();//initialize the arrays

	start_1 = clock(); //start the timer 

	for (int i = 0; i < TIMES_TO_RUN; i++)//this loop is needed to get an accurate ex.time value
		q1();


	end_1 = clock(); //end the timer 

	printf(" clock() method: %ldms\n", (end_1 - start_1) / (CLOCKS_PER_SEC / 1000));//print the ex.time

	printf("\n The value of the 5th element is %f \n", Y[4]);

	float time = (end_1 - start_1) / (float) CLOCKS_PER_SEC;
	time = time / TIMES_TO_RUN;
	float Flops = (2 * (N * N)) / (time);
	printf(" flops, %f\n", Flops);
	printf("extime, %fms\n", time*1000);


	return 0; //normally, by returning zero, we mean that the program ended successfully. 
}

void memoryalloc()
{
	Y = (float*)malloc(sizeof(float) * N);
	X = (float*)malloc(sizeof(float) * N);
	A = (float*)malloc(sizeof(float) * N*N);
	test = (float*)malloc(sizeof(float) * N);

}


void init() {

	float e = 0.1234f, p = 0.7264f, r = 0.11f;//if you do not specify the 'f' after 0.0, then double precision data type is assumed (not float which single precision). 

	//MVM
	for (unsigned int i = 0; i < N; i++)
		for (unsigned int j = 0; j < N; j++)
			A[N * i + j] = ((i - j) % 9) + p;

	for (unsigned int j = 0; j < N; j++) {
		Y[j] = 0.0f;
		test[j] = 0.0f;
		X[j] = (j % 7) + r;
	}
}



void q1() {

	for (int i = 0; i < N; i++) {
		for (int j = 0; j < N; j++) {
			Y[i] += A[N * i + j] * X[j];
		}
	}


}