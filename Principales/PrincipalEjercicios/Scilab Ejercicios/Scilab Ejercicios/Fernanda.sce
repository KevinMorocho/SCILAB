fila=input("limite filas: ");
columna=input("limite columnas: ");

numero=0;

for k = 1:fila
    printf('Fila %d\n',k);
    for t = 1:columna
        printf('Fila %d\n',t);
        numero=input("elemento: ");
        mat(k,t)=numero;
    end    
end

sumaColumna=0;
for k = 1:fila
    for t = 1:columna
        if(modulo(mat(k,t),2)==0) then
            sumaColumna=sumaColumna+1;
        end
    end    
    if(columna==sumaColumna)then
        disp("Columnas: #");
        disp(k)
    end 
end

sumaFila=0;
for k = 1:fila
    for t = 1:columna
        if(modulo(mat(t,k),2)==0) then
            sumaFila=sumaFila+1;
        end
    end    
    if(fila==sumaFila)then
        disp("Filas: #");
        disp(t)
    end 
end

