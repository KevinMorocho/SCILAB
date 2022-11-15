clc
printf('Texto a validar\n');
frase=input(' ','string');
n=length(frase)
for i=1:length(frase)
    cad(i)=part(frase,i);
end
cad(n+1)=' ';
cont=0;
printf('\nNueva Frase: \n');
contp=0;
conti=0;
for i=1:n+1
    if(cad(i)<>' ')then
        cont=cont+1;   
    end
    if(cad(i)==' ')then
        if (modulo(cont,2)==0)     
            contp=contp+1;
        end
        if (modulo(cont,2)==1)     
            conti=conti+1;
        end

        inicio=i-cont;
        fin=i-1;
        aux=0;
        printf(" ");
        for x=inicio:fin
            if ((cad(x)=="a" || cad(x)=="e" || cad(x)=="i" || cad(x)=="o" || (cad(x)=="u"))) then
                cad(x)='*';
            end
            printf("%s",cad(x)," ");
        end
        cont=0;
    end
end
printf("\n pares %i",contp);
printf("\n impares %i",conti);

//la amistad hace iguales a los amigos
