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
        printf("\nincio %s",cad(inicio));
        printf("\nfinal %s\n",cad(fin));
        aux=0;
        //        for x=inicio:fin
//       // printf("%s",cad(x)," ");
        //in=ascii(cad(x));
        //fi=ascii(cad(x));
        if( (cad(inicio)~="a"&&cad(inicio)~="e"&&cad(inicio)~="i"&&cad(inicio)~="u"&&cad(inicio)~="o"&& cad(inicio)~="A"&&cad(inicio)~="E"&&cad(inicio)~="I"&&cad(inicio)~="U"&&cad(inicio)~="O")
                aux=aux+1;

        end
        //      end
        printf(" %i .\n",aux);        
        aux=0;
        cont=0;
    end

end
//esTuDio EngRanDece al Hombre En su VOLUNTAD  
