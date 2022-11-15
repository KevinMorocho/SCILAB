//adrian
clc
printf('Escriba la frase a consultar\n');
frase=input(' ','string');
n=length(frase)
band=0;
conti=1;
for i=1:length(frase)
    cad(i)=part(frase,i);
end
cont=0;
contf=0;
for i=1:n+1
    if(cad(i)<>' ')then
        cont=cont+1;        
    end
    if(cad(i)==' ')then
        //printf(" %i",cont);
        if(modulo(cont,3)==0)
            vocal=0;
            for x=i-cont:i
                //printf("%s",cad(x));  
                if cad(x)=='a' || cad(x)=='e' || cad(x)=='i' || cad(x)=='o' || cad(x)=='u'  
                    vocal=vocal+1;
                end              
            end
            if (vocal<3)
                for x=i-cont:i-1
                    //printf("%s",cad(x));                  
                    cad(x)='*';
                end 
            end
            vocal=0;
        end
        cont=0;
    end
end
for i=1:n
    printf("%s",cad(i));                  
end
//Ser diferente no esta mal lo malo es no cambiar 






