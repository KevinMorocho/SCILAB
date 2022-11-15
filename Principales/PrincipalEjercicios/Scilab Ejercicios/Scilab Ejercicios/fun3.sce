
//literal _2
clc;
clear;
Xi=input("Valor inicial de X: ");
Xf=input("Valor final de X: ");
a0=input("Valor final de a0: ");
a1=input("Valor final de a1: ");
a2=input("Valor final de a2: ");
a3=input("Valor final de a3: ");

X = [Xi:0.5:Xf];

Y = a3*X^3 + a2*X^2 + a1*X + a0;
subplot(111);
plot(X,Y,'r');
title('a3*X^3 + a2*X^2 + a1*X + a0');
ylabel("Y");
xlabel("X");
xgrid(3);
printf('\nfuncion a generar es f(x)=a3*X^3 + a2*X^2 + a1*X + a0');
printf('\nTabla de valores\n');
for j=Xi:Xf;    
    fcn1 =  a3*j^3 + a2*j^2 + a1*j + a0;
    printf('%i     %f\n',j,fcn1);
end


//subplot(233), plot(y,y',"-"), title("plot(4,t'')", "fontsize",3)
