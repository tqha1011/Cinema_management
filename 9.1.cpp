#include <iostream>
using namespace std;
int main(){
	int n;
	cin>>n;
	float a[100];
	for(int i=0;i<n;i++){
		cin>>a[i];
	}
	for(int i=0;i<n;i++){
		if(i%2!=0){
			cout<<a[i]<<" ";
		}
	}
	return 0;
}
