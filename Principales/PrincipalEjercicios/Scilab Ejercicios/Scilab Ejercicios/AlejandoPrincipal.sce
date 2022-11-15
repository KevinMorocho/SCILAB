limite=input("Cantidad de elemento vector : ");

for k = 1:limite
    numero=input("ingrese elemento: ");
    v1(k)=numero;
end

independiente=0;
for k = 1:limite
    numero=v1(k);
    interno=0;
while(numero<>0)
    interno=interno+1;
    independiente= int(modulo(numero,10));
    v2(interno)=independiente;
    numero=int(numero/10);
end
may=v2(1);
for t = 1:interno
    if(v2(t)>may)then
        may=v2(t);
    end
end
v1(k)=may;
interno=0;
end
disp("Resultado Vector");
disp(v1)
