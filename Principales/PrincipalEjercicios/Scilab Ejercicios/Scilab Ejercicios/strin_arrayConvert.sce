disp('Ingrese el texto');
cadena=input(' ','string');
n=length(cadena)
for j=1:length(cadena)
    arrayf(j)=part(cadena,j);
end
ulti=0;
ac=0;
gene=0;
ap=0;
j=1;
for j=1:n 
    if(arrayf(j)<>' ')then
        ulti=ulti+1; 
        vv=ascii(arrayf(j));
        if(vv>=65 & vv<=90)then
            gene=gene+1;
        end
    end
    if(arrayf(j)==' ')then
        if(gene>=1)then
            l=j-ulti;    
            ap=ap+1;        
        end
        gene=0;
        ulti=0;
    end
//    j=j+1;
end
disp("Resultado");
printf("\nHay %d palabras con letras mayusculas: ",ap);
ulti=0;
ac=0;
gene=0;
for j=1:n 
    if(arrayf(j)<>' ')then
        ulti=ulti+1; 
        vv=ascii(arrayf(j));
        if (vv<=90 & vv>=65) then
            gene=gene+1;
        end
    end
    if(arrayf(j)==' ')then
        if(gene>=1)then
            l=j-ulti;            
            if(j==n) then
                printf("y ");    
            end                    
            for(i=l:j-1)
                printf("%c",arrayf(i));
            end         
            if(j<>n) then
                printf(", ");    
            else 
                 printf("y "); 
            end                    
        end
        gene=0;
        ulti=0;
    end
end

ulti=0;
ac=0;
for j=1:n
    if(arrayf(j)<>' ')then
        ulti=ulti+1; 
    end
    if(arrayf(j)==' ')then
        if(modulo(ulti,3)==0)            
            ac=ac+1;
            l=j-ulti;            
            
        end
        ulti=0;
    end    
end 
printf("\nHay %d palabras que su longitud es multiplo de 3: ",ac);
for j=1:n
    if(arrayf(j)<>' ')then
        ulti=ulti+1; 
    end
    if(arrayf(j)==' ')then
        if(modulo(ulti,3)==0)            
            ac=ac+1;
            l=j-ulti;            
            for(i=l:j-1)
                printf("%c",arrayf(i));
            end
            if(j<>n) then
                printf(", ");    
            end             
        end
        ulti=0;
    end    
end 



