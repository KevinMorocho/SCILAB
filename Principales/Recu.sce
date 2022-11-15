clc
clear
n=input('Limites de la sumatoria  ');
aux=0;
suma=0;
serie=0;
for x=1:6
    a0=0;
    a2=2;
    a6=6;
    su1=0;
    printf('\nX= %i',x);
    for i=1:n
        if(modulo(i,1)==0)then
            printf("\n+( %i/sqrt(%i+ %i )^%i",a6,x,n,a0,a2,a2);
            nume=sqrt(a6*(x-(n-a0)))
            deno=factorial(a2);
            serie=(nume/deno)^a2;
            suma=suma+serie;
        end
        if(modulo(i,1)<>0)then
            printf("\n+( %i/sqrt(%i+ %i )^%i",a6,x,n,a0,a2,a2);
            nume=sqrt(aux6*(x-(n-aux0)) )
            deno=factorial(a2);
            serie=(nume/deno)^a2;
            suma=suma+serie;
        end
        a0=a0+1;
        a2=a2+2;
        a6=a6+6;
    end    
    printf('\nSuma de x %i es = %f ',x,suma);
    x1(x)=suma;
end
printf('\nSuma total es: %f\n\n',suma);

y1=1:1:6
subplot(222);
plot2d(y1,x1,2);
xgrid(2);
