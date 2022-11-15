t=input("Limite de números?: ");
acumulador=0;
for i=1:t
    k=input("Ingrese nuevo valor: ");    
    acumulador=acumulador+k;
end
pro=acumulador/t;
printf("Promedio es");
disp(acumulador/t);
