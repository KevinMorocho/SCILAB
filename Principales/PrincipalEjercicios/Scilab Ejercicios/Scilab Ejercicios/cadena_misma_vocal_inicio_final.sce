clc
disp('Ingrese el texto');
cadena=input(' ','string');
n=length(cadena)
for j=1:length(cadena)
    arrayf(j)=part(cadena,j);
end
arrayf(n+1)=' ';
cont=0;
pos=0;
conti=1;
contf=0;
for j=1:n+1 
    if(arrayf(j)<>' ')then
        cont=cont+1;        
    end
    if(arrayf(j)==' ')then
        pos=j-cont;
        contf=j-1;
        similar=0;
        for x=pos:j-1
            if (arrayf(x)) == (arrayf(x+1))
                similar = similar+1;
            end
        end   
        if similar==1 then
            for x=pos:j-1
               printf("%s",arrayf(x));                
            end          
            printf("\n");
        end          
        similar=0;
        cont=0;
    end
end

