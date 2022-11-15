clc
printf('Escriba la frase a consultar\n');
frase=input(' ','string');
n=length(frase)
for i=1:length(frase)
    cad(i)=part(frase,i);
end
cad(n+1)=' ';
cont=0;
for i=1:n+1
    if(cad(i)<>' ')then
        cont=cont+1;        
    end
    if(cad(i)==' ')then
        in=i-cont;
        fi=i-1;
        aux=0;
        if ((cad(in)~="a" || cad(in)~="e" || cad(in)~="i" || cad(in)~="o" || (cad(in)~="u")) && (cad(fi)~="a" || cad(fi)~="e" || cad(fi)~="i" || cad(fi)~="o" || (cad(fi)~="u")) ) then
            aux=aux+1;
        end
        //printf(" %i \n",aux);
        printf("\n");
        if(aux>=1)
            for x=in:fi
                printf("%s",cad(x)," ");                    
            end
        end
        aux=0;
    end
end
//esTuDio EngRanDece al Hombre En su VOLUNTAD  
