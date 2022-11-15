// Llenar una matriz

fila=input("Numero de filas: ");
columna=input("Numero de columnas: ");

for i = 1:fila
    for j=1:columna 
         printf("Ingrese valor columna,%d, fila %d \n",i,j);
         valor_leido=input("Ingrese valor");
         matriz(i,j)=valor_leido;
    end
end


disp(matriz);
