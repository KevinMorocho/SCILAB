//ejercicio 2
clc;
clear;
X = [-9:0.2:5];
A1 = 2;
A2 = 2;
A0=3;
Y = A1*X^2+A1*X+A1;
subplot(211),plot(X,Y,'*'), title('Y=2*X+3',"fontsize",4);
ylabel("Y","fontsize",4);
xlabel("X","fontsize",4);
xgrid();
printf('\nf(x)=sqrt(2*X+4)\n');
printf('\nValores generados\n');
for dominio=-21:18;
    Graf =  2*dominio+3;
    printf('%i     %f\n',dominio,Graf);
end


Y = (X)^(1/3);
subplot(212), plot(X,Y,'*'), title("Y = (X)^(1/3))","fontsize",4);
ylabel("Y","fontsize",4);
xlabel("X","fontsize",4);
xgrid();
printf('\nf(x)=(X)^(1/3)\n');
printf('\nValores generados\n');
for dominio=-21:18;
    Graf = sqrt(dominio^2-2*dominio);
    printf('%i  |   %f\n',dominio,Graf);
end


