digito=input("Digite valor:");
numeroebuscar=input("Digite valor a encontrar: ");
acumulador=0;
bandera=0;
bnde=0;
p=[];
while(digito>0)
    x= int(modulo(digito,10));
    acumulador=acumulador+1;
    p(acumulador)=x;
    digito=int(digito/10);
    if(x==numeroebuscar)then
        bnde=bnde+1;
    end   
end

if(bnde<=0) then
    disp("No pertenece ");
end

if(bnde>=1) then
    disp("Si pertenece")
end



