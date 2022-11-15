// Llenar una matriz

disp("Numero de filas: ");
fila=input("");
disp("Numero de columnas: ");
columna=input("");
valor_mayor=0;
valor_menor=1000;
for i = 1:fila
    for j=1:columna
         printf("Ingrese valor fila,%d, columna %d \n",i,j);
         valor_leido=input(":");
         matriz(i,j)=valor_leido;
    end
end

//Imprrmir matriz
disp(matriz);

valor_mayor=0;
valor_menor=1000;
for i = 1:fila
    for j=1:columna
         if matriz(i,j)>valor_mayor then
             valor_mayor=matriz(i,j);
             pos_fila=i;
             pos_colum=j;
         end
         
         if matriz(i,j)<valor_menor then
             valor_menor=matriz(i,j);
              pos_fila1=i;
             pos_colum1=j;
         end
    end
end
disp("El mayor valor de la matriz es : ");
disp(valor_mayor);
printf("Esta en la posicion fila,%d, columna %d \n",pos_fila,pos_colum);
disp("El menor valor de la matriz es : ");
disp(valor_menor);
printf("Esta en la posicion fila,%d, columna %d \n",pos_fila1,pos_colum1);










