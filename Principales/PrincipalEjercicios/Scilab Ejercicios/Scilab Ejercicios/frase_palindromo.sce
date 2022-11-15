printf("Ingrese una cadena: "),
cadena=input('.',"string");
n=length(cadena);
disp(n);
disp(cadena);
for x=1:n 
    vector(x)=part(cadena,x);
end

posi=n;
cont=0;
for x=1:n        
    if (vector(x)==vector(posi))
            cont=cont+1;
    end    
 end

if(cont==n)
    disp("")
end
