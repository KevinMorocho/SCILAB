dig2=input("Ingrese numero a sumar: ");
res=0;
base=0;
limite=0;
while(dig2>0)
    base= (modulo(dig2,10));
    res=res+(base);
    dig2=int(dig2/10);
end
disp("Resultado:");
disp(res);



