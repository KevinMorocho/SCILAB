clc;
clear; 
c=7
f=6
mat=int(rand(f,c)*20);
disp(mat);

suma=0;
may=0;
posmay=0;
for k=1:f
    for j=1:c
        suma=suma+mat(k,j);
    end
    if suma>may
        may=suma;
        posmay=k;
    end    
    suma=0;
end
printf("\nMayor dia de clientes es el dia: %i",posmay);


suma=0;
men=99;
posmen=1;
for k=1:f
    for j=1:c
        suma=suma+mat(k,j);
    end
    if suma<men
        men=suma;
        posmen=k;
    end 
    suma=0;   
end
printf("\nMenor dia de clientes es el dia: %i",posmen); 

sumaT=0;
for k=1:f
    for j=1:c
        sumaT=sumaT+mat(k,j);
    end
end
suma=0;
for k=1:c
    for j=1:f
        suma=suma+mat(j,k);
    end
    pro=(suma/sumaT)*100;
    printf("\n Horario %i promedio es %f",k,pro);
    x1(k)=pro;
    suma=0;
end

y1=1:1:c;
subplot(221);
plot2d(y1,x1,2);
//xgrid(2);





