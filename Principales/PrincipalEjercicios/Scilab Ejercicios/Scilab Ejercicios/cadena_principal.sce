clc
printf('Escriba la frase a consultar\n');
frase=input(' ','string');
n=length(frase)
band=0;
conti=1;

for i=1:length(frase)
    cad(i)=part(frase,i);
end
cad(n+1)=' ';
cont=0;
contf=0;
for i=1:n+1
    if(cad(i)<>' ')then
        cont=cont+1;        
    end
    if(cad(i)==' ')then
        inicio=i-cont;
        fin=i-1;
        //printf("\nincio %s",cad(inicio));
        //printf("\nfinal %s\n",cad(fin));
        cont=0;
        for x=inicio:fin
            printf("%s",cad(x)," ");
            in=ascii(cad(x));
            fi=ascii(cad(x));
            if (in>=65 && fi<=89) then
                cont=cont+1;
            end
        end
        printf(" %i \n",cont);        
        cont=0;
    end

end
//esTuDio EngRanDece al Hombre En su VOLUNTAD  
