cifra2=input("Ingrese desde teclado el valor: ");
y=0;
aa=0;
o=0;
while(cifra2>0)
    aa= int(modulo(cifra2,10));
    y=y+int(aa);
    o=o+1;
    cifra2=int(cifra2/10);
end
p=y/o;
printf("Promedio resultante:");
disp(p);

