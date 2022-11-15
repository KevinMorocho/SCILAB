clc
disp("Total de sucursales???");
sucur=input("");
for i = 1:12
    printf('MES %d',i);
    for j = 1:sucur
        printf('\nSucursal %d ',j);
        valor= input(":");
        mat(i,j)=valor;
    end    
end
disp(mat);
acum=0;
for i = 1:12
    for j = 1:sucur
        acum=acum+mat(i,j);
    end    
end
disp('A)Total, ventas de la compania: ');
printf(' %d ',acum);

printf('\nB)Total, ventas por cada  sucursal de la compania: ');
acum=0;
for j = 1:sucur
    for i = 1:12
        acum=acum+mat(i,j);
    end 
    v(j)=acum;
    printf('\nSucursal %d ',j);
    printf('Suma es %d ',acum);
    acum=0;
end
printf('\nC)Sucursal que mas vendio durante el año compania: ');
x=v(1);
for i = 1:sucur
   if(v(i)>x)then
       x=v(i);     
    end
end
printf(' %d ', x);

acum=0;
for i = 1:12
    for j = 1:sucur
        acum=acum+mat(i,j);
    end  
    v2(i)=acum;
    acum=0;
end
sumames=v2(1);
pos=0;
for i = 1:12
   if(v2(i)>sumames)then
       sumames=v2(i);
       pos=i;
    end
end
printf('\nD) Mes que mas vendió la compania : ');
printf(' %d ', pos);

