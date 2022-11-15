//ejercicio 3
clc;
clear;
aux3=input('Ingrese frase a verificar: ','string');
largo=length(aux3);
w=1;
while w<=length(aux3);
    cadena(w)=part(aux3,w);
    w=w+1;
end
maximo=0;
minimo=10;
aux2=0;
aux=0;
cadena(largo+1)=' ';
for w=1:largo+1
    if(cadena(w)<>' ')then         
        if (cadena(w)=='@')|(cadena(w)=='/')|(cadena(w)=='*')        
            aux=aux+1;
        end
        if (cadena(w)=='a')|(cadena(w)=='e') 
            aux2=aux2+1;
        end
         if (cadena(w)=='i')|(cadena(w)=='o')|(cadena(w)=='u')   
            aux2=aux2+1;
        end
    end
    if(cadena(w)==' ')then
        if aux2<minimo 
            minimo=aux2;    
        end
        if  aux>aux2 
            maximo=aux;    
        end        
        aux=0;
        aux2=0;
    end
end
printf("\n-La palabra con mas caracteres especiales es la que tiene : %i, caracteres especiales ",maximo);
printf("\n-La palabra con menos vocales es la que tiene %i vocal ",minimo);
