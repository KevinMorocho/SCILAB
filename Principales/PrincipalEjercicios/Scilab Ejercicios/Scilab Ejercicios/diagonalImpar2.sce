printf("ingrese el numero de filas: ");
f=input('.');
c=f;

//for i=1:f
//   for j=1:c
//        disp('ingrese el valor '),disp(i),disp(j);
//       matriz(i,j)=input('.');
//   end
//end

matriz=[1,3,7,1,5;1,7,6,8,2;7,13,9,6,15;5,4,10,11,6;7,3,1,2,5];

b=%T;
i=1;
while (i<=c) & (b)
        b=(modulo(matriz(1,i),2)==1)&(modulo(matriz(i,1),2)==1)&(modulo(matriz(i,i),2)==1) ;
        i=i+1;
end;
if(b)
 printf("correcto");
 printf("Fila 1: ");
 disp(matriz(1,:));
 printf("columna 1: ");
 disp(matriz(:,1));
 printf("Diagonal principal: ");
 disp(diag(matriz)); 
else
  printf("Incorrecto")  
end
