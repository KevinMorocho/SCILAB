n=input("Cantidad de elementos a generar: ");

for i = 1:n
    valor=input("ingrese elemento: ");
    vec(i)=valor;
end

cont=0;
for i = 1:n
    if(modulo(vec(i),3)==0) then     
        cont=cont+1;
    end
end

disp("Multiplos de 3 que contiene el vector es: ");
disp(cont);



