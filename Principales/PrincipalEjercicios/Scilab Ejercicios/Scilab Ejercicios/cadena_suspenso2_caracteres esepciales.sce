asdfsadclc
printf('Escriba la frase a consultar\n');
frase=input(' ','string');
n=length(frase)
band=0;
conti=1;
for i=1:n
    cad(i)=part(frase,i);
end
cad(n+1)=' ';
cont=0;
lonV=0;
cont_may=0;
cont_men=0;
for i=1:n+1
    if(cad(i)<>' ')then
        cont=cont+1;        
    end
    if(cad(i)==' ')then
        inicio=i-cont;
        fin=i-1;
        lon=0;
        for x=inicio:fin            
            if(cad(x)=='@' || cad(x)=='/' || cad(x)=='*' )
                lon=lon+1;
            end                        
        end
        if(lon>cont_may)
            cont_may=lon;
        end
        
        for x=inicio:fin            
            if(cad(x)=='a' || cad(x)=='e' || cad(x)=='i' || cad(x)=='o' || cad(x)=='u' )
                lonV=lonV+1;
            end                        
        end        
        if(lonV>=1 && lonV<cont_men)
            cont_men=lonV;
        end
        lon=0;
        lonV=0;
        cont=0;
    end
end
printf("\nLa palabra con mas caracteres especiales es la que tiene : %i, caracter(res) especiales: ",cont_may);
printf("\nLa palabra con menos vocales es la que tiene %i vocal(as): ",cont_men);
//La @mist@d ha/Ce iguales a los amigos
