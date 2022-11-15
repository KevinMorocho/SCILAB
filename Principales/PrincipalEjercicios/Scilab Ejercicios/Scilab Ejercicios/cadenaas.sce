printf("Ingrese una cadena: "),
cadena=input('.',"string");
n=length(cadena);
disp(n);
disp(cadena);
for j=1:n 
    vector(j)=part(cadena,j);
end
posi=1;
for j=1:n
        if vector(j)==' ' then
           posf=j-1;
           for i=posi:posf
            printf(vector(i));
            end
        printf("\n");
        posi=i+1;
    end
    
 end
 
printf("Escribir cada palabra formada en una línea nueva, pero alternando las letras mayúsculas y minúsculas") 
printf("\n");
 posi1=1;
 for j=1:n   
    if vector(j)==' ' then
           posf=j-1;
           for i=posi1:posf   
            if(modulo(i,2)==0) then
             printf(convstr(vector(i),'l'));  
        else 
            printf(convstr(vector(i),'u'));
            end
        posi1=i+1;
    end
    printf("\n");
end
end

 conta=1;
 conte=1;
 conti=1;
 conto=1;
 contu=1;
 posi2=1;
 for j=1:n   
    if vector(j)==' ' then
           posf=j-1;
           //Evaluacion para letra A
           for i=posi2:posf   
            if(vector(i)=='A'| vector(i)=='a' & conta ==1) then
             printf(vector(i));
             conta=conta+1;      
            end     
    end
    conta=1;   
 //Evaluacion para letra E
  for i=posi2:posf   
            if(vector(i)=='E'| vector(i)=='e' & conte ==1) then
             printf(vector(i));
             conte=conte+1;      
            end     
    end
    conte=1;
    //Evaluacion para letra I
    for i=posi2:posf   
            if(vector(i)=='I'| vector(i)=='i' & conti ==1) then
             printf(vector(i));
             conti=conti+1;      
            end     
    end
    conti=1;
    
     //Evaluacion para letra O
    for i=posi2:posf   
            if(vector(i)=='O'| vector(i)=='o' & conto ==1) then
             printf(vector(i));
             conto=conto+1;      
            end     
    end
    conto=1;
    
     //Evaluacion para letra U
    for i=posi2:posf   
            if(vector(i)=='U'| vector(i)=='u' & contu ==1) then
             printf(vector(i));
             contu=contu+1;      
            end     
    end
    contu=1;
    
    posi2=i+1; 
    printf("\n");         
end 

end

disp("Devolver una cadena formada por las iniciales de la frase en letras mayúsculas:");
printf("\n");
posi3=1;
for j=1:n
        if vector(j)==' ' then
           posf=j-1;
           for i=posi3:posi3
           printf(convstr(vector(i),'u'));
        end
        posi3=j+1;      
    end
 end


//B=["hola mundo']'
//disp(B);
//disp(part("How to use ""part"" ?",1:11))
 //printf('Result is:\nalpha=%f",0.535)
// disp(vector(j));
//printf('Hola como estas\n mi\n nombres es JOSE JEREMÍAS CABALLERO\n')
