clc
printf('Escriba numero a convertir\n');
frase=input(' ','string');
n=length(frase)
for i=1:length(frase)
    cad(i)=part(frase,i);
end
cont=n;
ndecimal=0;
for i=1:n
    //printf("\n %s",cad(i));
    cont=cont-1;  
    digito = cad(i);
    select digito
    case 'A'
        numerador=10;
    case 'B'
        numerador=11;
    case 'C'
        numerador=12;
    case 'D'
        numerador=13;
    case 'E'
        numerador=14;
    case 'F'
        numerador=15;
    else
        numerador=isnum(cad(i));
    end        
    digitobase=numerador*16^(n-i);
    ndecimal=ndecimal+digitobase;
    printf("\ndigito %s * 16 ^%i =%i",cad(i),cont,digitobase);              
end
printf("\nNuevo numero es: %i",ndecimal);
//FF16
