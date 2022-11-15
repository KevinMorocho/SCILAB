n=input("Cantidad de elementos a generar: ");

//Llenar un vector
function
for i = 1:n
    valor=input("ingrese elemento: ");
    vec(i)=valor;
end

aux=0;
valor_mayor=0;
valor_menor=1000;

// Mayor y menor en un vector
for i = 1:n
    if (vec(i)>valor_mayor) then
        valor_mayor=vec(i);
    end
    if (vec(i)<valor_menor) then
        valor_menor=vec(i);
    end
        vec2(i)=vec(i)+5;
end

// 
disp("El valor mayor es: ");
disp(valor_mayor);
disp("El valor menor es: ");
disp(valor_menor);
disp("El nuevo vector es: ");
disp(vec2);
//printf("Elemento(s) sin cambiar: ");
//disp(aux)



