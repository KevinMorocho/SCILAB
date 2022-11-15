f=input("Ingrese número de filas: ");
c=input("Ingrese número de columnas: ");
for i = 1:f
    for j = 1:c
        valor=input("ingrese elemento: ");
        mat(i,j)=valor;
    end    
end2

disp("Diagonal 1");
for i = 1:f
    printf(mat(i,1));
end

disp("Diagonal 2");


disp("Diagonal 3");
