fila=input("limite filas: ");
columna=input("limite columnas: ");
sumafila=0;  
numero=0;
sumacolumna=0; 
acumulador=0; 
sc=0;  
for k = 1:fila
    for t = 1:columna
        numero=input("elemeto: ");
        mat(k,t)=numero;
    end    
end

numero=0;
for k = 1:fila
    for t = 1:columna
        sumafila=sumafila+mat(k,t);
    end    
    numero=numero+sumafila;    
    printf('suma de la fila %d es s=%d\n',k,numero);
    sumafila=0;    
    numero=0;
end

s=0;
for k = 1:fila
    for t = 1:columna
        sumacolumna=sumacolumna+mat(t,k);
    end    
    numero=numero+sumacolumna;    
    printf(' es la suma de la columna %d es s=%d\n',k,numero);
    sumacolumna=0;    
    numero=0;
end
