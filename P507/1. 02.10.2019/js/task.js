
// ededin tek bolenlerini chixarmaq

var n = 18;

if(n<= 0){
    console.log("musbet eded daxil ediniz");
}

for (var i = 1 ; i<=n ; i++){
    if(n%i == 0){
        if(i%2 != 0)
            console.log(i);
    }
}



// ededin ikinci reqemini yazdirmaq

var n  = 154652 ;
    if(n<0){
        n = -n;
    }
while(n>99){
    n = n/10;
}
    k = n % 10;
    console.log(k);




// # beraber bolenler

var n = 30, m;
var count = 0;

if (n > m)
{
    for (m = 1; m < n; m++)
    {
        if (n % m == n / m)
            count++;
    }
    console.log(count);
}
else
{
    console.log("n m'den kichik ola bilmez");
}

